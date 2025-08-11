using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Internal;

using Ionic.Zip;

using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.IO;
using SharpCompress.Readers;

using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization.EventEmitters;

using ICSharpCode.SharpZipLib.Zip;

using Opc.Ua;
using Opc.Ua.Client;

using log4net;
using log4net.Config;

using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Services.Tokens;
using DotNetNuke.Entities.Users;

using ServiceStack.Formats;

using Microsoft.IdentityModel.Clients.ActiveDirectory;

using Microsoft.AspNetCore.SpaServices.Prerendering;

using CoreFtp;

public class Program
{
    public static int Main()
    {
        Console.WriteLine(".NET App");
        _Run();
        return 0;
    }

    private static void _Run()
    {
        Data d = new();
        d.Initialize();
        Processor p = new();
        p.Process(d);

        Program _ = new();
        _.Use_DotNetZip();
        _.Use_SharpCompress();
        _.Use_YamlDotNet();
        _.Use_SharpZipLib();
        _.Use_OPCFoundation_NetStandard_Opc_Ua();
        _.Use_log4net();
        _.Use_DotNetNuke();
        _.Use_ServiceStack();
        _.Use_Microsoft_IdentityModel_Clients_ActiveDirectory();
        _.Use_CreateGlobalsAssignmentScript();
    }

    private void Use_DotNetZip()
    {
        Ionic.Zip.ZipEntry ze = new();
        ze.Extract();
    }

    private void Use_SharpCompress()
    {
        using (var stream = File.OpenRead(""))
        {
            using var archive = ArchiveFactory.Open(stream);
            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
            {
                entry.WriteToDirectory(
                    "abc",
                    new ExtractionOptions { ExtractFullPath = true, Overwrite = true }
                );
            }
        }
    }

    private void Use_YamlDotNet()
    {
        var person = new Person
        {
            Name = "Abe Lincoln",
        };

        var serializer = new SerializerBuilder()
            .EnsureRoundtrip()
            .WithEventEmitter(eventEmitter =>
                new TypeAssigningEventEmitter(eventEmitter, false))
            .Build();
        var yaml = serializer.Serialize(person);
        System.Console.WriteLine(yaml);

        var deserializer = new DeserializerBuilder()
            .Build();
    }

    private void Use_SharpZipLib()
    {
        var zip = new FastZip();
        zip.ExtractZip("", "", "");
    }

    private void Use_OPCFoundation_NetStandard_Opc_Ua()
    {
        IDecoder idec = new BinaryDecoder(new byte[1], null);
        idec.ReadExtensionObject("interface-typed-indirect");
        BinaryDecoder dec = new(new byte[1], null);
        dec.ReadExtensionObject("concrete-typed-indirect");
        var session = new Session(null, null, null);
        session.UpdateSession(null, null);
    }

    private void Use_log4net()
    {
        XmlConfigurator.Configure(null);
    }

    private void Use_DotNetNuke()
    {
        JavaScript.RequestRegistration("js");
        DotNetNuke.Entities.Users.UserInfo ui = new();
        bool found = false;
        var p = ui.GetProperty("", "", null, ui, Scope.DefaultSettings, ref found);
        UserController.VerifyUser("user");
    }

    private void Use_ServiceStack()
    {
        var htmlFormat = new HtmlFormat();
        htmlFormat.Register(null);
        htmlFormat.SerializeToStreamAsync(null, this, null);
    }

    private void Use_Microsoft_IdentityModel_Clients_ActiveDirectory()
    {
        AuthenticationContext authCtx = new("");
        IClientAssertionCertificate cert = null;
        authCtx.AcquireTokenAsync("", cert, false);
    }

    private void Use_CreateGlobalsAssignmentScript()
    {
        RenderToStringResult rst = new();
        rst.CreateGlobalsAssignmentScript();
    }

    private void Use_()
    {
        FtpClient ftp = new();
        ftp.GetFileSizeAsync("file");
    }
}

public class Person
{
    public string Name { get; set; }
}
