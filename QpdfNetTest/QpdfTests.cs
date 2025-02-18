using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QPdfNet;
using QPdfNet.Enums;
using QPdfNet.Info;
using QPdfNet.Output;

namespace QpdfNetTest
{
    [TestClass]
    public class QpdfTests
    {
#pragma warning disable CS8618
        private string _testFolder;
#pragma warning restore CS8618

        [TestInitialize]
        public void Initialize()
        {
            var directory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
            directory.Create();
            _testFolder = directory.FullName;
        }

        [TestCleanup]
        public void Cleanup()
        {
            var directory = new DirectoryInfo(_testFolder);
            if (directory.Exists)
                directory.Delete(true);
        }

        [TestMethod]
        public void TestInputOutput()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job
                .InputFile(Path.Combine("TestFiles", "test.pdf"))
                .OutputFile(outputFile)
                .Run(out var output);

            Assert.AreEqual(ExitCode.Success, result);
            Assert.IsTrue(string.IsNullOrEmpty(output));
            Assert.IsTrue(File.Exists(outputFile));
        }

        [TestMethod]
        public void TestEmpty()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.Empty()
                .OutputFile(outputFile)
                .Run(out _);

            Assert.AreEqual(new FileInfo(outputFile).Length, 315);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestInputOutputWithParameters()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job
                .InputFile(Path.Combine("TestFiles", "test.pdf"))
                .OutputFile(outputFile)
                .WarningExit0()
                .Verbose()
                .NoWarn()
                .DeterministicId()
                .AllowWeakCrypto()
                .SuppressRecovery()
                .SuppressPasswordRecovery()
                .IgnoreXrefStreams()
                .Linearize()
                .NoOriginalObjectIds()
                .CompressStreams(true)
                .DecodeLevel()
                .StreamData()
                .RecompressFlate()
                .CompressionLevel(9)
                .NormalizeContent(true)
                .ObjectStreams(ObjectStreams.Generate)
                .PreserveUnreferenced()
                .PreserveUnreferencedResources()
                .NewlineBeforeEndstream()
                .CoalesceContents()
                .ExternalizeInlineImages()
                .IiMinBytes()
                .FlattenRotation()
                .FlattenAnnotations(FlattenAnnotations.All)
                .Rotate(Rotation.Rotate0)
                .GenerateAppearances()
                .OptimizeImages()
                .OiMinWidth()
                .OiMinHeight()
                .OiMinArea()
                .KeepInlineImages()
                .RemovePageLabels()
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
            Assert.IsTrue(File.Exists(outputFile));
        }

        [TestMethod]
        public void TestIsEncrypted()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .IsEncrypted()
                .RunIsEncrypted(out _);

            Assert.AreEqual(ExitCodeIsEncrypted.Encrypted, result);
        }

        [TestMethod]
        public void TestRequiresPassword()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .RequiresPassword()
                .RunRequiresPassword(out _);

            Assert.AreEqual(ExitCodeRequiresPassword.OtherPasswordRequired, result);
        }

        [TestMethod]
        public void TestCheck()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .Check()
                .Run(out var output);

            Assert.AreEqual(output?.Length, 1279);
            Assert.AreEqual(ExitCode.WarningsWereFoundFileProcessed, result);
        }

        [TestMethod]
        public void TestParseCheck()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .Check()
                .Run(out var output);

            var parseCheck = Helper.ParseCheck(output);

            Assert.IsTrue(parseCheck.Warnings?.Count == 12);
            Assert.AreEqual(ExitCode.WarningsWereFoundFileProcessed, result);
        }

        [TestMethod]
        public void TestShowEncryption1()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .ShowEncryption()
                .Run(out var output);

            Assert.AreEqual(output, "File is not encrypted");
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestShowEncryption2()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .Password("owner")
                .ShowEncryption()
                .Run(out var output);

            Assert.IsTrue(output?.Contains("Supplied password is owner password"));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestShowEncryptionKey()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .Password("owner")
                .ShowEncryption()
                .ShowEncryptionKey()
                .Run(out var output);

            Assert.IsTrue(output?.Contains("Encryption key = bc4d3ad2b43dbe372b02a4291cc7ee11413d33e87eb348d3364d5420312f1645"));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestParseShowEncryptionKey()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .Password("owner")
                .ShowEncryption()
                .ShowEncryptionKey()
                .Run(out var output);

            var encryptionInfo = Helper.ParseShowEncryption(output);

            Assert.IsTrue(encryptionInfo.EncryptionKey == "bc4d3ad2b43dbe372b02a4291cc7ee11413d33e87eb348d3364d5420312f1645");
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestCheckLinearization()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .CheckLinearization()
                .Run(out _);

            Assert.AreEqual(ExitCode.WarningsWereFoundFileProcessed, result);
        }

        [TestMethod]
        public void TestShowLinearization()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .ShowLinearization()
                .Run(out var output);

            Assert.IsTrue(output?.Contains("file_size: 180701"));
            Assert.AreEqual(ExitCode.WarningsWereFoundFileProcessed, result);
        }

        [TestMethod]
        public void TestShowXref()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "random.pdf"))
                .ShowXref()
                .Run(out var output);

            Assert.IsTrue(output?.Contains("1/0: uncompressed; offset = 15"));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestParseShowXref()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "random.pdf"))
                .ShowXref()
                .Run(out var output);

            var xRefInfos = Helper.ParseShowXref(output);

            Assert.IsTrue(xRefInfos.Count == 20);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestShowObject()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .ShowObject("trailer")
                .Run(out var output);

            Assert.IsTrue(output?.Contains("<< /ID [ <abfecb2b8e80721668392435f5aa76a6> <abfecb2b8e80721668392435f5aa76a6> ] /Info 3 0 R /Prev 180512 /Root 8 0 R /Size 19 >>"));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestRawStreamData()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withattachment.pdf"))
                .ShowObject("10 0 R")
                .RawStreamData()
                .Run(out _, out var data);

            Assert.IsTrue(data!.Length == 41469);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestFilteredStreamData()
        {
            var outputFile = Path.Combine("TestFiles", "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .OutputFile(outputFile)
                .RawStreamData()
                .Run(out _);

            Assert.IsTrue(File.Exists(outputFile));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestShowNPages()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "20_pages.pdf"))
                .ShowNPages()
                .Run(out var output);

            Assert.AreEqual(ExitCode.Success, result);
            Assert.AreEqual(output, "20");
        }

        [TestMethod]
        public void TestShowPages()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "20_pages.pdf"))
                .ShowPages()
                .Run(out var output);

            Assert.IsTrue(output?.Contains("page 12: 29 0 R"));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestQdf()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "20_pages.pdf"))
                .OutputFile(outputFile)
                .Qdf()
                .Run(out _);

            Assert.AreEqual(new FileInfo(outputFile).Length, 144930);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestPages()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "20_pages.pdf"))
                .OutputFile(outputFile)
                .Pages(".", "1-5,9,15")
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestCollate()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "20_pages.pdf"))
                .OutputFile(outputFile)
                .Pages(".", "1-20")
                .Pages(Path.Combine(Path.Combine("TestFiles", "acrobat_8_help.pdf")), "1-20")
                .Collate(2)
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
            Assert.IsTrue(File.Exists(outputFile));
        }

        [TestMethod]
        public void TestEncryption40Bit()
        {
            var outputFile = Path.Combine(_testFolder, "output_encryption_40_bit.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .OutputFile(outputFile)
                .Encrypt("user", "owner", new Encryption40Bit(false))
                .AllowWeakCrypto()
                .Linearize()
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
            Assert.IsTrue(File.Exists(outputFile));
        }

        [TestMethod]
        public void TestEncryption128Bit()
        {
            var outputFile = Path.Combine(_testFolder, "output_encryption_128_bit.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .OutputFile(outputFile)
                .Encrypt("user", "owner", new Encryption128Bit(false, false))
                .AllowWeakCrypto()
                .Linearize()
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
            Assert.IsTrue(File.Exists(outputFile));
        }

        [TestMethod]
        public void TestEncryption256Bit()
        {
            var outputFile = Path.Combine(_testFolder, "output_encryption_256_bit.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .OutputFile(outputFile)
                .Encrypt("user", "owner", new Encryption256Bit(true, true, true, true, true, true, Modify.None, Print.None))
                .Linearize()
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
            Assert.IsTrue(File.Exists(outputFile));
        }

        [TestMethod]
        public void TestPasswordUser()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .OutputFile(outputFile)
                .Password("user")
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestPasswordOwner()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .OutputFile(outputFile)
                .Password("owner")
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestDecrypt()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .OutputFile(outputFile)
                .Password("owner")
                .Decrypt()
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestRemoveRestrictions()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "encryption_256_bit.pdf"))
                .OutputFile(outputFile)
                .Password("owner")
                .RemoveRestrictions()
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
        }
        
        [TestMethod]
        public void TestSplitPages()
        {
            var outputFile = Path.Combine(_testFolder, "%d.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "acrobat_8_help.pdf"))
                .OutputFile(outputFile)
                .SplitPages(100)
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
            Assert.IsTrue(File.Exists(Path.Combine(_testFolder, "001-100.pdf")));
            Assert.IsTrue(File.Exists(Path.Combine(_testFolder, "101-200.pdf")));
            Assert.IsTrue(File.Exists(Path.Combine(_testFolder, "201-300.pdf")));
            Assert.IsTrue(File.Exists(Path.Combine(_testFolder, "301-400.pdf")));
            Assert.IsTrue(File.Exists(Path.Combine(_testFolder, "401-404.pdf")));
        }

        [TestMethod]
        public void TestOverlay()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "20_pages.pdf"))
                .OutputFile(outputFile)
                .Overlay(Path.Combine("TestFiles", "test.pdf"), "1-20", null, "1")
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestUnderlay()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "20_pages.pdf"))
                .OutputFile(outputFile)
                .Underlay(Path.Combine("TestFiles", "test.pdf"))
                .Run(out _);

            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestAddAttachment()
        {
            var outputFile = Path.Combine(_testFolder, "output.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "test.pdf"))
                .OutputFile(outputFile)
                .AddAttachment(Path.Combine("TestFiles", "20_pages.pdf"))
                .Run(out _);

            Assert.IsTrue(new FileInfo(outputFile).Length == 222133);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestRemoveAttachment()
        {
            var outputFile = Path.Combine(_testFolder, "test.pdf");

            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withattachment.pdf"))
                .OutputFile(outputFile)
                .RemoveAttachment("20_pages.pdf")
                .Verbose()
                .Run(out _);

            Assert.IsTrue(new FileInfo(outputFile).Length == 180240);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestListAttachments()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withattachment.pdf"))
                .ListAttachments()
                .Run(out var output);

            Assert.IsTrue(output?.Contains("20_pages.pdf -> 10,0"));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestParseListAttachments()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withattachment.pdf"))
                .ListAttachments()
                .Run(out var output);

            var attachments = Helper.ParseListAttachments(output);

            Assert.IsTrue(attachments.Count == 1);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestShowAttachments()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withattachment.pdf"))
                .ShowAttachment("20_pages.pdf")
                .Run(out _, out var data);

            Assert.IsTrue(data!.Length == 54695);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestJsonWithAttachment()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withattachment.pdf"))
                .Json()
                .JsonStreamData(JsonStreamData.Inline)
                .Run(out _, out var data);

            var json = Encoding.ASCII.GetString(data!);

            Assert.IsTrue(json.Length == 317908);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestJsonWithImages()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withimages.pdf"))
                .Json()
                .JsonKey("pages")
                .Run(out var output, out var data);

            var json = Encoding.ASCII.GetString(data!);

            Assert.IsTrue(json.Length == 2013);
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestJsonKey()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withattachment.pdf"))
                .Json()
                .JsonKey("attachments")
                .JsonKey("encrypt")
                .Run(out _, out var data);

            var json = Encoding.ASCII.GetString(data!);

            Assert.IsTrue(json.Contains("attachments"));
            Assert.IsTrue(json.Contains("encrypt"));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestObjectKey()
        {
            var job = new Job();
            var result = job.InputFile(Path.Combine("TestFiles", "withattachment.pdf"))
                .Json()
                .JsonObject("1 0 R")
                .JsonObject("11 0 R")
                .Run(out _, out var data);

            var json = Encoding.ASCII.GetString(data!);

            Assert.IsTrue(json.Contains("1 0 R"));
            Assert.IsTrue(json.Contains("11 0 R"));
            Assert.IsTrue(!json.Contains("14 0 R"));
            Assert.AreEqual(ExitCode.Success, result);
        }

        [TestMethod]
        public void TestPdfInfo()
        {
            var pdf = Pdf.FromFile(Path.Combine("TestFiles", "random.pdf"));
            Assert.IsTrue(pdf != null);
        }
    }
}