﻿//
// MimeTypes.cs
//
// Author: Kees van Spelde <sicos2002@hotmail.com>
//
// Copyright (c) 2021-2023 Kees van Spelde.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Collections.Generic;

// ReSharper disable StringLiteralTypo

namespace QPdfNet.Helpers;

/// <summary>
///     A mapping of file name extensions to the corresponding MIME-type.
/// </summary>
internal static class MimeTypes
{
    #region Fields
    /// <summary>
    /// A dictionary of mimetypes
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static readonly Dictionary<string, string> mimeTypes;
    #endregion

    #region Constructor
    static MimeTypes()
    {
        mimeTypes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        mimeTypes.Add("323", "text/h323");
        mimeTypes.Add("3dmf", "x-world/x-3dmf");
        mimeTypes.Add("3dm", "x-world/x-3dmf");
        mimeTypes.Add("3g2", "video/3gpp2");
        mimeTypes.Add("3gp", "video/3gpp");
        mimeTypes.Add("7z", "application/x-7z-compressed");
        mimeTypes.Add("aab", "application/x-authorware-bin");
        mimeTypes.Add("aac", "audio/aac");
        mimeTypes.Add("aam", "application/x-authorware-map");
        mimeTypes.Add("aas", "application/x-authorware-seg");
        mimeTypes.Add("abc", "text/vnd.abc");
        mimeTypes.Add("acgi", "text/html");
        mimeTypes.Add("acx", "application/internet-property-stream");
        mimeTypes.Add("afl", "video/animaflex");
        mimeTypes.Add("ai", "application/postscript");
        mimeTypes.Add("aif", "audio/aiff");
        mimeTypes.Add("aifc", "audio/aiff");
        mimeTypes.Add("aiff", "audio/aiff");
        mimeTypes.Add("aim", "application/x-aim");
        mimeTypes.Add("aip", "text/x-audiosoft-intra");
        mimeTypes.Add("ani", "application/x-navi-animation");
        mimeTypes.Add("aos", "application/x-nokia-9000-communicator-add-on-software");
        mimeTypes.Add("appcache", "text/cache-manifest");
        mimeTypes.Add("application", "application/x-ms-application");
        mimeTypes.Add("aps", "application/mime");
        mimeTypes.Add("art", "image/x-jg");
        mimeTypes.Add("asf", "video/x-ms-asf");
        mimeTypes.Add("asm", "text/x-asm");
        mimeTypes.Add("asp", "text/asp");
        mimeTypes.Add("asr", "video/x-ms-asf");
        mimeTypes.Add("asx", "application/x-mplayer2");
        mimeTypes.Add("atom", "application/atom+xml");
        mimeTypes.Add("au", "audio/x-au");
        mimeTypes.Add("avi", "video/avi");
        mimeTypes.Add("avs", "video/avs-video");
        mimeTypes.Add("axs", "application/olescript");
        mimeTypes.Add("bas", "text/plain");
        mimeTypes.Add("bcpio", "application/x-bcpio");
        mimeTypes.Add("bin", "application/octet-stream");
        mimeTypes.Add("bm", "image/bmp");
        mimeTypes.Add("bmp", "image/bmp");
        mimeTypes.Add("boo", "application/book");
        mimeTypes.Add("book", "application/book");
        mimeTypes.Add("boz", "application/x-bzip2");
        mimeTypes.Add("bsh", "application/x-bsh");
        mimeTypes.Add("bz2", "application/x-bzip2");
        mimeTypes.Add("bz", "application/x-bzip");
        mimeTypes.Add("cat", "application/vnd.ms-pki.seccat");
        mimeTypes.Add("ccad", "application/clariscad");
        mimeTypes.Add("cco", "application/x-cocoa");
        mimeTypes.Add("cc", "text/plain");
        mimeTypes.Add("cdf", "application/cdf");
        mimeTypes.Add("cer", "application/pkix-cert");
        mimeTypes.Add("cha", "application/x-chat");
        mimeTypes.Add("chat", "application/x-chat");
        mimeTypes.Add("class", "application/x-java-applet");
        mimeTypes.Add("clp", "application/x-msclip");
        mimeTypes.Add("cmx", "image/x-cmx");
        mimeTypes.Add("cod", "image/cis-cod");
        mimeTypes.Add("coffee", "text/x-coffeescript");
        mimeTypes.Add("conf", "text/plain");
        mimeTypes.Add("cpio", "application/x-cpio");
        mimeTypes.Add("cpp", "text/plain");
        mimeTypes.Add("cpt", "application/x-cpt");
        mimeTypes.Add("crd", "application/x-mscardfile");
        mimeTypes.Add("crl", "application/pkix-crl");
        mimeTypes.Add("crt", "application/pkix-cert");
        mimeTypes.Add("csh", "application/x-csh");
        mimeTypes.Add("css", "text/css");
        mimeTypes.Add("c", "text/plain");
        mimeTypes.Add("c++", "text/plain");
        mimeTypes.Add("cxx", "text/plain");
        mimeTypes.Add("dart", "application/dart");
        mimeTypes.Add("dcr", "application/x-director");
        mimeTypes.Add("deb", "application/x-deb");
        mimeTypes.Add("deepv", "application/x-deepv");
        mimeTypes.Add("def", "text/plain");
        mimeTypes.Add("deploy", "application/octet-stream");
        mimeTypes.Add("der", "application/x-x509-ca-cert");
        mimeTypes.Add("dib", "image/bmp");
        mimeTypes.Add("dif", "video/x-dv");
        mimeTypes.Add("dir", "application/x-director");
        mimeTypes.Add("disco", "text/xml");
        mimeTypes.Add("dll", "application/x-msdownload");
        mimeTypes.Add("dl", "video/dl");
        mimeTypes.Add("doc", "application/msword");
        mimeTypes.Add("docm", "application/vnd.ms-word.document.macroEnabled.12");
        mimeTypes.Add("docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        mimeTypes.Add("dot", "application/msword");
        mimeTypes.Add("dotm", "application/vnd.ms-word.template.macroEnabled.12");
        mimeTypes.Add("dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template");
        mimeTypes.Add("dp", "application/commonground");
        mimeTypes.Add("drw", "application/drafting");
        mimeTypes.Add("dtd", "application/xml-dtd");
        mimeTypes.Add("dvi", "application/x-dvi");
        mimeTypes.Add("dv", "video/x-dv");
        mimeTypes.Add("dwf", "drawing/x-dwf (old)");
        mimeTypes.Add("dwg", "application/acad");
        mimeTypes.Add("dxf", "application/dxf");
        mimeTypes.Add("dxr", "application/x-director");
        mimeTypes.Add("elc", "application/x-elc");
        mimeTypes.Add("el", "text/x-script.elisp");
        mimeTypes.Add("eml", "message/rfc822");
        mimeTypes.Add("eot", "application/vnd.bw-fontobject");
        mimeTypes.Add("eps", "application/postscript");
        mimeTypes.Add("es", "application/x-esrehber");
        mimeTypes.Add("etx", "text/x-setext");
        mimeTypes.Add("evy", "application/envoy");
        mimeTypes.Add("exe", "application/octet-stream");
        mimeTypes.Add("f77", "text/plain");
        mimeTypes.Add("f90", "text/plain");
        mimeTypes.Add("fdf", "application/vnd.fdf");
        mimeTypes.Add("fif", "image/fif");
        mimeTypes.Add("flac", "audio/x-flac");
        mimeTypes.Add("fli", "video/fli");
        mimeTypes.Add("flo", "image/florian");
        mimeTypes.Add("flr", "x-world/x-vrml");
        mimeTypes.Add("flx", "text/vnd.fmi.flexstor");
        mimeTypes.Add("fmf", "video/x-atomic3d-feature");
        mimeTypes.Add("for", "text/plain");
        mimeTypes.Add("fpx", "image/vnd.fpx");
        mimeTypes.Add("frl", "application/freeloader");
        mimeTypes.Add("f", "text/plain");
        mimeTypes.Add("funk", "audio/make");
        mimeTypes.Add("g3", "image/g3fax");
        mimeTypes.Add("gif", "image/gif");
        mimeTypes.Add("gl", "video/gl");
        mimeTypes.Add("gsd", "audio/x-gsm");
        mimeTypes.Add("gsm", "audio/x-gsm");
        mimeTypes.Add("gsp", "application/x-gsp");
        mimeTypes.Add("gss", "application/x-gss");
        mimeTypes.Add("gtar", "application/x-gtar");
        mimeTypes.Add("g", "text/plain");
        mimeTypes.Add("gz", "application/x-gzip");
        mimeTypes.Add("gzip", "application/x-gzip");
        mimeTypes.Add("hdf", "application/x-hdf");
        mimeTypes.Add("help", "application/x-helpfile");
        mimeTypes.Add("hgl", "application/vnd.hp-HPGL");
        mimeTypes.Add("hh", "text/plain");
        mimeTypes.Add("hlb", "text/x-script");
        mimeTypes.Add("hlp", "application/x-helpfile");
        mimeTypes.Add("hpg", "application/vnd.hp-HPGL");
        mimeTypes.Add("hpgl", "application/vnd.hp-HPGL");
        mimeTypes.Add("hqx", "application/binhex");
        mimeTypes.Add("hta", "application/hta");
        mimeTypes.Add("htc", "text/x-component");
        mimeTypes.Add("h", "text/plain");
        mimeTypes.Add("htmls", "text/html");
        mimeTypes.Add("html", "text/html");
        mimeTypes.Add("htm", "text/html");
        mimeTypes.Add("htt", "text/webviewhtml");
        mimeTypes.Add("htx", "text/html");
        mimeTypes.Add("ice", "x-conference/x-cooltalk");
        mimeTypes.Add("ico", "image/x-icon");
        mimeTypes.Add("ics", "text/calendar");
        mimeTypes.Add("idc", "text/plain");
        mimeTypes.Add("ief", "image/ief");
        mimeTypes.Add("iefs", "image/ief");
        mimeTypes.Add("iges", "application/iges");
        mimeTypes.Add("igs", "application/iges");
        mimeTypes.Add("iii", "application/x-iphone");
        mimeTypes.Add("ima", "application/x-ima");
        mimeTypes.Add("imap", "application/x-httpd-imap");
        mimeTypes.Add("inf", "application/inf");
        mimeTypes.Add("ins", "application/x-internett-signup");
        mimeTypes.Add("ip", "application/x-ip2");
        mimeTypes.Add("isp", "application/x-internet-signup");
        mimeTypes.Add("isu", "video/x-isvideo");
        mimeTypes.Add("it", "audio/it");
        mimeTypes.Add("iv", "application/x-inventor");
        mimeTypes.Add("ivf", "video/x-ivf");
        mimeTypes.Add("ivr", "i-world/i-vrml");
        mimeTypes.Add("ivy", "application/x-livescreen");
        mimeTypes.Add("jam", "audio/x-jam");
        mimeTypes.Add("jar", "application/java-archive");
        mimeTypes.Add("java", "text/plain");
        mimeTypes.Add("jav", "text/plain");
        mimeTypes.Add("jcm", "application/x-java-commerce");
        mimeTypes.Add("jfif", "image/jpeg");
        mimeTypes.Add("jfif-tbnl", "image/jpeg");
        mimeTypes.Add("jpeg", "image/jpeg");
        mimeTypes.Add("jpe", "image/jpeg");
        mimeTypes.Add("jpg", "image/jpeg");
        mimeTypes.Add("jps", "image/x-jps");
        mimeTypes.Add("js", "application/javascript");
        mimeTypes.Add("json", "application/json");
        mimeTypes.Add("jut", "image/jutvision");
        mimeTypes.Add("kar", "audio/midi");
        mimeTypes.Add("ksh", "text/x-script.ksh");
        mimeTypes.Add("la", "audio/nspaudio");
        mimeTypes.Add("lam", "audio/x-liveaudio");
        mimeTypes.Add("latex", "application/x-latex");
        mimeTypes.Add("list", "text/plain");
        mimeTypes.Add("lma", "audio/nspaudio");
        mimeTypes.Add("log", "text/plain");
        mimeTypes.Add("lsp", "application/x-lisp");
        mimeTypes.Add("lst", "text/plain");
        mimeTypes.Add("lsx", "text/x-la-asf");
        mimeTypes.Add("ltx", "application/x-latex");
        mimeTypes.Add("m13", "application/x-msmediaview");
        mimeTypes.Add("m14", "application/x-msmediaview");
        mimeTypes.Add("m1v", "video/mpeg");
        mimeTypes.Add("m2a", "audio/mpeg");
        mimeTypes.Add("m2v", "video/mpeg");
        mimeTypes.Add("m3u", "audio/x-mpequrl");
        mimeTypes.Add("m4a", "audio/mp4");
        mimeTypes.Add("m4v", "video/mp4");
        mimeTypes.Add("man", "application/x-troff-man");
        mimeTypes.Add("manifest", "application/x-ms-manifest");
        mimeTypes.Add("map", "application/x-navimap");
        mimeTypes.Add("mar", "text/plain");
        mimeTypes.Add("mbd", "application/mbedlet");
        mimeTypes.Add("mc$", "application/x-magic-cap-package-1.0");
        mimeTypes.Add("mcd", "application/mcad");
        mimeTypes.Add("mcf", "image/vasa");
        mimeTypes.Add("mcp", "application/netmc");
        mimeTypes.Add("mdb", "application/x-msaccess");
        mimeTypes.Add("mesh", "model/mesh");
        mimeTypes.Add("me", "application/x-troff-me");
        mimeTypes.Add("mid", "audio/midi");
        mimeTypes.Add("midi", "audio/midi");
        mimeTypes.Add("mif", "application/x-mif");
        mimeTypes.Add("mjf", "audio/x-vnd.AudioExplosion.MjuiceMediaFile");
        mimeTypes.Add("mjpg", "video/x-motion-jpeg");
        mimeTypes.Add("mm", "application/base64");
        mimeTypes.Add("mme", "application/base64");
        mimeTypes.Add("mny", "application/x-msmoney");
        mimeTypes.Add("mod", "audio/mod");
        mimeTypes.Add("mov", "video/quicktime");
        mimeTypes.Add("movie", "video/x-sgi-movie");
        mimeTypes.Add("mp2", "video/mpeg");
        mimeTypes.Add("mp3", "audio/mpeg");
        mimeTypes.Add("mp4", "video/mp4");
        mimeTypes.Add("mp4a", "audio/mp4");
        mimeTypes.Add("mp4v", "video/mp4");
        mimeTypes.Add("mpa", "audio/mpeg");
        mimeTypes.Add("mpc", "application/x-project");
        mimeTypes.Add("mpeg", "video/mpeg");
        mimeTypes.Add("mpe", "video/mpeg");
        mimeTypes.Add("mpga", "audio/mpeg");
        mimeTypes.Add("mpg", "video/mpeg");
        mimeTypes.Add("mpp", "application/vnd.ms-project");
        mimeTypes.Add("mpt", "application/x-project");
        mimeTypes.Add("mpv2", "video/mpeg");
        mimeTypes.Add("mpv", "application/x-project");
        mimeTypes.Add("mpx", "application/x-project");
        mimeTypes.Add("mrc", "application/marc");
        mimeTypes.Add("ms", "application/x-troff-ms");
        mimeTypes.Add("msh", "model/mesh");
        mimeTypes.Add("m", "text/plain");
        mimeTypes.Add("mvb", "application/x-msmediaview");
        mimeTypes.Add("mv", "video/x-sgi-movie");
        mimeTypes.Add("my", "audio/make");
        mimeTypes.Add("mzz", "application/x-vnd.AudioExplosion.mzz");
        mimeTypes.Add("nap", "image/naplps");
        mimeTypes.Add("naplps", "image/naplps");
        mimeTypes.Add("nc", "application/x-netcdf");
        mimeTypes.Add("ncm", "application/vnd.nokia.configuration-message");
        mimeTypes.Add("niff", "image/x-niff");
        mimeTypes.Add("nif", "image/x-niff");
        mimeTypes.Add("nix", "application/x-mix-transfer");
        mimeTypes.Add("nsc", "application/x-conference");
        mimeTypes.Add("nvd", "application/x-navidoc");
        mimeTypes.Add("nws", "message/rfc822");
        mimeTypes.Add("oda", "application/oda");
        mimeTypes.Add("ods", "application/oleobject");
        mimeTypes.Add("oga", "audio/ogg");
        mimeTypes.Add("ogg", "audio/ogg");
        mimeTypes.Add("ogv", "video/ogg");
        mimeTypes.Add("ogx", "application/ogg");
        mimeTypes.Add("omc", "application/x-omc");
        mimeTypes.Add("omcd", "application/x-omcdatamaker");
        mimeTypes.Add("omcr", "application/x-omcregerator");
        mimeTypes.Add("opus", "audio/ogg");
        mimeTypes.Add("oxps", "application/oxps");
        mimeTypes.Add("p10", "application/pkcs10");
        mimeTypes.Add("p12", "application/pkcs-12");
        mimeTypes.Add("p7a", "application/x-pkcs7-signature");
        mimeTypes.Add("p7b", "application/x-pkcs7-certificates");
        mimeTypes.Add("p7c", "application/pkcs7-mime");
        mimeTypes.Add("p7m", "application/pkcs7-mime");
        mimeTypes.Add("p7r", "application/x-pkcs7-certreqresp");
        mimeTypes.Add("p7s", "application/pkcs7-signature");
        mimeTypes.Add("part", "application/pro_eng");
        mimeTypes.Add("pas", "text/pascal");
        mimeTypes.Add("pbm", "image/x-portable-bitmap");
        mimeTypes.Add("pcl", "application/x-pcl");
        mimeTypes.Add("pct", "image/x-pict");
        mimeTypes.Add("pcx", "image/x-pcx");
        mimeTypes.Add("pdb", "chemical/x-pdb");
        mimeTypes.Add("pdf", "application/pdf");
        mimeTypes.Add("pfunk", "audio/make");
        mimeTypes.Add("pfx", "application/x-pkcs12");
        mimeTypes.Add("pgm", "image/x-portable-graymap");
        mimeTypes.Add("pic", "image/pict");
        mimeTypes.Add("pict", "image/pict");
        mimeTypes.Add("pkg", "application/x-newton-compatible-pkg");
        mimeTypes.Add("pko", "application/vnd.ms-pki.pko");
        mimeTypes.Add("pl", "text/plain");
        mimeTypes.Add("plx", "application/x-PiXCLscript");
        mimeTypes.Add("pm4", "application/x-pagemaker");
        mimeTypes.Add("pm5", "application/x-pagemaker");
        mimeTypes.Add("pma", "application/x-perfmon");
        mimeTypes.Add("pmc", "application/x-perfmon");
        mimeTypes.Add("pm", "image/x-xpixmap");
        mimeTypes.Add("pml", "application/x-perfmon");
        mimeTypes.Add("pmr", "application/x-perfmon");
        mimeTypes.Add("pmw", "application/x-perfmon");
        mimeTypes.Add("png", "image/png");
        mimeTypes.Add("pnm", "application/x-portable-anymap");
        mimeTypes.Add("pot", "application/vnd.ms-powerpoint");
        mimeTypes.Add("potm", "application/vnd.ms-powerpoint.template.macroEnabled.12");
        mimeTypes.Add("potx", "application/vnd.openxmlformats-officedocument.presentationml.template");
        mimeTypes.Add("pov", "model/x-pov");
        mimeTypes.Add("ppa", "application/vnd.ms-powerpoint");
        mimeTypes.Add("ppam", "application/vnd.ms-powerpoint.addin.macroEnabled.12");
        mimeTypes.Add("ppm", "image/x-portable-pixmap");
        mimeTypes.Add("pps", "application/vnd.ms-powerpoint");
        mimeTypes.Add("ppsm", "application/vnd.ms-powerpoint.slideshow.macroEnabled.12");
        mimeTypes.Add("ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow");
        mimeTypes.Add("ppt", "application/vnd.ms-powerpoint");
        mimeTypes.Add("pptm", "application/vnd.ms-powerpoint.presentation.macroEnabled.12");
        mimeTypes.Add("pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation");
        mimeTypes.Add("ppz", "application/mspowerpoint");
        mimeTypes.Add("pre", "application/x-freelance");
        mimeTypes.Add("prf", "application/pics-rules");
        mimeTypes.Add("prt", "application/pro_eng");
        mimeTypes.Add("ps", "application/postscript");
        mimeTypes.Add("p", "text/x-pascal");
        mimeTypes.Add("pub", "application/x-mspublisher");
        mimeTypes.Add("pvu", "paleovu/x-pv");
        mimeTypes.Add("pwz", "application/vnd.ms-powerpoint");
        mimeTypes.Add("pyc", "applicaiton/x-bytecode.python");
        mimeTypes.Add("py", "text/x-script.phyton");
        mimeTypes.Add("qcp", "audio/vnd.qcelp");
        mimeTypes.Add("qd3d", "x-world/x-3dmf");
        mimeTypes.Add("qd3", "x-world/x-3dmf");
        mimeTypes.Add("qif", "image/x-quicktime");
        mimeTypes.Add("qtc", "video/x-qtc");
        mimeTypes.Add("qtif", "image/x-quicktime");
        mimeTypes.Add("qti", "image/x-quicktime");
        mimeTypes.Add("qt", "video/quicktime");
        mimeTypes.Add("ra", "audio/x-pn-realaudio");
        mimeTypes.Add("ram", "audio/x-pn-realaudio");
        mimeTypes.Add("ras", "application/x-cmu-raster");
        mimeTypes.Add("rast", "image/cmu-raster");
        mimeTypes.Add("rexx", "text/x-script.rexx");
        mimeTypes.Add("rf", "image/vnd.rn-realflash");
        mimeTypes.Add("rgb", "image/x-rgb");
        mimeTypes.Add("rm", "application/vnd.rn-realmedia");
        mimeTypes.Add("rmi", "audio/mid");
        mimeTypes.Add("rmm", "audio/x-pn-realaudio");
        mimeTypes.Add("rmp", "audio/x-pn-realaudio");
        mimeTypes.Add("rng", "application/ringing-tones");
        mimeTypes.Add("rnx", "application/vnd.rn-realplayer");
        mimeTypes.Add("roff", "application/x-troff");
        mimeTypes.Add("rp", "image/vnd.rn-realpix");
        mimeTypes.Add("rpm", "audio/x-pn-realaudio-plugin");
        mimeTypes.Add("rss", "application/rss+xml");
        mimeTypes.Add("rtf", "text/richtext");
        mimeTypes.Add("rt", "text/richtext");
        mimeTypes.Add("rtx", "text/richtext");
        mimeTypes.Add("rv", "video/vnd.rn-realvideo");
        mimeTypes.Add("s3m", "audio/s3m");
        mimeTypes.Add("sbk", "application/x-tbook");
        mimeTypes.Add("scd", "application/x-msschedule");
        mimeTypes.Add("scm", "application/x-lotusscreencam");
        mimeTypes.Add("sct", "text/scriptlet");
        mimeTypes.Add("sdml", "text/plain");
        mimeTypes.Add("sdp", "application/sdp");
        mimeTypes.Add("sdr", "application/sounder");
        mimeTypes.Add("sea", "application/sea");
        mimeTypes.Add("set", "application/set");
        mimeTypes.Add("setpay", "application/set-payment-initiation");
        mimeTypes.Add("setreg", "application/set-registration-initiation");
        mimeTypes.Add("sgml", "text/sgml");
        mimeTypes.Add("sgm", "text/sgml");
        mimeTypes.Add("shar", "application/x-bsh");
        mimeTypes.Add("sh", "text/x-script.sh");
        mimeTypes.Add("shtml", "text/html");
        mimeTypes.Add("sid", "audio/x-psid");
        mimeTypes.Add("silo", "model/mesh");
        mimeTypes.Add("sit", "application/x-sit");
        mimeTypes.Add("skd", "application/x-koan");
        mimeTypes.Add("skm", "application/x-koan");
        mimeTypes.Add("skp", "application/x-koan");
        mimeTypes.Add("skt", "application/x-koan");
        mimeTypes.Add("sl", "application/x-seelogo");
        mimeTypes.Add("smi", "application/smil");
        mimeTypes.Add("smil", "application/smil");
        mimeTypes.Add("snd", "audio/basic");
        mimeTypes.Add("sol", "application/solids");
        mimeTypes.Add("spc", "application/x-pkcs7-certificates");
        mimeTypes.Add("spl", "application/futuresplash");
        mimeTypes.Add("spr", "application/x-sprite");
        mimeTypes.Add("sprite", "application/x-sprite");
        mimeTypes.Add("spx", "audio/ogg");
        mimeTypes.Add("src", "application/x-wais-source");
        mimeTypes.Add("ssi", "text/x-server-parsed-html");
        mimeTypes.Add("ssm", "application/streamingmedia");
        mimeTypes.Add("sst", "application/vnd.ms-pki.certstore");
        mimeTypes.Add("step", "application/step");
        mimeTypes.Add("s", "text/x-asm");
        mimeTypes.Add("stl", "application/sla");
        mimeTypes.Add("stm", "text/html");
        mimeTypes.Add("stp", "application/step");
        mimeTypes.Add("sv4cpio", "application/x-sv4cpio");
        mimeTypes.Add("sv4crc", "application/x-sv4crc");
        mimeTypes.Add("svf", "image/x-dwg");
        mimeTypes.Add("svg", "image/svg+xml");
        mimeTypes.Add("svr", "application/x-world");
        mimeTypes.Add("swf", "application/x-shockwave-flash");
        mimeTypes.Add("talk", "text/x-speech");
        mimeTypes.Add("t", "application/x-troff");
        mimeTypes.Add("tar", "application/x-tar");
        mimeTypes.Add("tbk", "application/toolbook");
        mimeTypes.Add("tcl", "text/x-script.tcl");
        mimeTypes.Add("tcsh", "text/x-script.tcsh");
        mimeTypes.Add("tex", "application/x-tex");
        mimeTypes.Add("texi", "application/x-texinfo");
        mimeTypes.Add("texinfo", "application/x-texinfo");
        mimeTypes.Add("text", "text/plain");
        mimeTypes.Add("tgz", "application/x-compressed");
        mimeTypes.Add("tiff", "image/tiff");
        mimeTypes.Add("tif", "image/tiff");
        mimeTypes.Add("tr", "application/x-troff");
        mimeTypes.Add("trm", "application/x-msterminal");
        mimeTypes.Add("ts", "text/x-typescript");
        mimeTypes.Add("tsi", "audio/tsp-audio");
        mimeTypes.Add("tsp", "audio/tsplayer");
        mimeTypes.Add("tsv", "text/tab-separated-values");
        mimeTypes.Add("ttf", "application/x-font-ttf");
        mimeTypes.Add("turbot", "image/florian");
        mimeTypes.Add("txt", "text/plain");
        mimeTypes.Add("uil", "text/x-uil");
        mimeTypes.Add("uls", "text/iuls");
        mimeTypes.Add("unis", "text/uri-list");
        mimeTypes.Add("uni", "text/uri-list");
        mimeTypes.Add("unv", "application/i-deas");
        mimeTypes.Add("uris", "text/uri-list");
        mimeTypes.Add("uri", "text/uri-list");
        mimeTypes.Add("ustar", "multipart/x-ustar");
        mimeTypes.Add("uue", "text/x-uuencode");
        mimeTypes.Add("uu", "text/x-uuencode");
        mimeTypes.Add("vcd", "application/x-cdlink");
        mimeTypes.Add("vcf", "text/vcard");
        mimeTypes.Add("vcard", "text/vcard");
        mimeTypes.Add("vcs", "text/x-vCalendar");
        mimeTypes.Add("vda", "application/vda");
        mimeTypes.Add("vdo", "video/vdo");
        mimeTypes.Add("vew", "application/groupwise");
        mimeTypes.Add("vivo", "video/vivo");
        mimeTypes.Add("viv", "video/vivo");
        mimeTypes.Add("vmd", "application/vocaltec-media-desc");
        mimeTypes.Add("vmf", "application/vocaltec-media-file");
        mimeTypes.Add("voc", "audio/voc");
        mimeTypes.Add("vos", "video/vosaic");
        mimeTypes.Add("vox", "audio/voxware");
        mimeTypes.Add("vqe", "audio/x-twinvq-plugin");
        mimeTypes.Add("vqf", "audio/x-twinvq");
        mimeTypes.Add("vql", "audio/x-twinvq-plugin");
        mimeTypes.Add("vrml", "application/x-vrml");
        mimeTypes.Add("vrt", "x-world/x-vrt");
        mimeTypes.Add("vsd", "application/x-visio");
        mimeTypes.Add("vst", "application/x-visio");
        mimeTypes.Add("vsw", "application/x-visio");
        mimeTypes.Add("w60", "application/wordperfect6.0");
        mimeTypes.Add("w61", "application/wordperfect6.1");
        mimeTypes.Add("w6w", "application/msword");
        mimeTypes.Add("wav", "audio/wav");
        mimeTypes.Add("wb1", "application/x-qpro");
        mimeTypes.Add("wbmp", "image/vnd.wap.wbmp");
        mimeTypes.Add("wcm", "application/vnd.ms-works");
        mimeTypes.Add("wdb", "application/vnd.ms-works");
        mimeTypes.Add("web", "application/vnd.xara");
        mimeTypes.Add("webm", "video/webm");
        mimeTypes.Add("wiz", "application/msword");
        mimeTypes.Add("wk1", "application/x-123");
        mimeTypes.Add("wks", "application/vnd.ms-works");
        mimeTypes.Add("wmf", "windows/metafile");
        mimeTypes.Add("wmlc", "application/vnd.wap.wmlc");
        mimeTypes.Add("wmlsc", "application/vnd.wap.wmlscriptc");
        mimeTypes.Add("wmls", "text/vnd.wap.wmlscript");
        mimeTypes.Add("wml", "text/vnd.wap.wml");
        mimeTypes.Add("wmp", "video/x-ms-wmp");
        mimeTypes.Add("wmv", "video/x-ms-wmv");
        mimeTypes.Add("wmx", "video/x-ms-wmx");
        mimeTypes.Add("woff", "application/x-woff");
        mimeTypes.Add("word", "application/msword");
        mimeTypes.Add("wp5", "application/wordperfect");
        mimeTypes.Add("wp6", "application/wordperfect");
        mimeTypes.Add("wp", "application/wordperfect");
        mimeTypes.Add("wpd", "application/wordperfect");
        mimeTypes.Add("wps", "application/vnd.ms-works");
        mimeTypes.Add("wq1", "application/x-lotus");
        mimeTypes.Add("wri", "application/mswrite");
        mimeTypes.Add("wrl", "application/x-world");
        mimeTypes.Add("wrz", "model/vrml");
        mimeTypes.Add("wsc", "text/scriplet");
        mimeTypes.Add("wsdl", "text/xml");
        mimeTypes.Add("wsrc", "application/x-wais-source");
        mimeTypes.Add("wtk", "application/x-wintalk");
        mimeTypes.Add("wvx", "video/x-ms-wvx");
        mimeTypes.Add("x3d", "model/x3d+xml");
        mimeTypes.Add("x3db", "model/x3d+fastinfoset");
        mimeTypes.Add("x3dv", "model/x3d-vrml");
        mimeTypes.Add("xaf", "x-world/x-vrml");
        mimeTypes.Add("xaml", "application/xaml+xml");
        mimeTypes.Add("xap", "application/x-silverlight-app");
        mimeTypes.Add("xbap", "application/x-ms-xbap");
        mimeTypes.Add("xbm", "image/x-xbitmap");
        mimeTypes.Add("xdr", "video/x-amt-demorun");
        mimeTypes.Add("xgz", "xgl/drawing");
        mimeTypes.Add("xht", "application/xhtml+xml");
        mimeTypes.Add("xhtml", "application/xhtml+xml");
        mimeTypes.Add("xif", "image/vnd.xiff");
        mimeTypes.Add("xla", "application/vnd.ms-excel");
        mimeTypes.Add("xlam", "application/vnd.ms-excel.addin.macroEnabled.12");
        mimeTypes.Add("xl", "application/excel");
        mimeTypes.Add("xlb", "application/excel");
        mimeTypes.Add("xlc", "application/excel");
        mimeTypes.Add("xld", "application/excel");
        mimeTypes.Add("xlk", "application/excel");
        mimeTypes.Add("xll", "application/excel");
        mimeTypes.Add("xlm", "application/excel");
        mimeTypes.Add("xls", "application/vnd.ms-excel");
        mimeTypes.Add("xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12");
        mimeTypes.Add("xlsm", "application/vnd.ms-excel.sheet.macroEnabled.12");
        mimeTypes.Add("xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        mimeTypes.Add("xlt", "application/vnd.ms-excel");
        mimeTypes.Add("xltm", "application/vnd.ms-excel.template.macroEnabled.12");
        mimeTypes.Add("xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template");
        mimeTypes.Add("xlv", "application/excel");
        mimeTypes.Add("xlw", "application/excel");
        mimeTypes.Add("xm", "audio/xm");
        mimeTypes.Add("xml", "text/xml");
        mimeTypes.Add("xmz", "xgl/movie");
        mimeTypes.Add("xof", "x-world/x-vrml");
        mimeTypes.Add("xpi", "application/x-xpinstall");
        mimeTypes.Add("xpix", "application/x-vnd.ls-xpix");
        mimeTypes.Add("xpm", "image/xpm");
        mimeTypes.Add("xps", "application/vnd.ms-xpsdocument");
        mimeTypes.Add("x-png", "image/png");
        mimeTypes.Add("xsd", "text/xml");
        mimeTypes.Add("xsl", "text/xml");
        mimeTypes.Add("xslt", "text/xml");
        mimeTypes.Add("xsr", "video/x-amt-showrun");
        mimeTypes.Add("xwd", "image/x-xwd");
        mimeTypes.Add("xyz", "chemical/x-pdb");
        mimeTypes.Add("z", "application/x-compressed");
        mimeTypes.Add("zip", "application/zip");
        mimeTypes.Add("zsh", "text/x-script.zsh");
    }
    #endregion

    #region GetMimeType
    /// <summary>
    /// Gets the MIME-type of the file.
    /// </summary>
    /// <remarks>
    /// Gets the MIME-type of the file based on the file extension.
    /// </remarks>
    /// <returns>The MIME-type.</returns>
    /// <param name="fileName">The file name.</param>
    /// <exception>
    ///     <cref>System.ArgumentNullException</cref>
    ///     <paramref name="fileName"/> is <c>null</c>.
    /// </exception>
    public static string GetMimeType(string fileName)
    {
        if (fileName == null)
            throw new ArgumentNullException(nameof(fileName));

        var dot = fileName.LastIndexOf('.');
        string mimeType = null;

        if (dot != -1 && fileName.Length > dot + 1)
            mimeTypes.TryGetValue(fileName.Substring(dot + 1), out mimeType);

        return mimeType ?? ("application/octet-stream");
    }
    #endregion
}