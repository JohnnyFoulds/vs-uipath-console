//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XamlStaticHelperNamespace {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
    internal class _XamlStaticHelper {
        
        private static System.WeakReference schemaContextField;
        
        private static System.Collections.Generic.IList<System.Reflection.Assembly> assemblyListField;
        
        internal static System.Xaml.XamlSchemaContext SchemaContext {
            get {
                System.Xaml.XamlSchemaContext xsc = null;
                if ((schemaContextField != null)) {
                    xsc = ((System.Xaml.XamlSchemaContext)(schemaContextField.Target));
                    if ((xsc != null)) {
                        return xsc;
                    }
                }
                if ((AssemblyList.Count > 0)) {
                    xsc = new System.Xaml.XamlSchemaContext(AssemblyList);
                }
                else {
                    xsc = new System.Xaml.XamlSchemaContext();
                }
                schemaContextField = new System.WeakReference(xsc);
                return xsc;
            }
        }
        
        internal static System.Collections.Generic.IList<System.Reflection.Assembly> AssemblyList {
            get {
                if ((assemblyListField == null)) {
                    assemblyListField = LoadAssemblies();
                }
                return assemblyListField;
            }
        }
        
        private static System.Collections.Generic.IList<System.Reflection.Assembly> LoadAssemblies() {
            System.Collections.Generic.IList<System.Reflection.Assembly> assemblyList = new System.Collections.Generic.List<System.Reflection.Assembly>();
            assemblyList.Add(Load("Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                        "3a"));
            assemblyList.Add(Load("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856a" +
                        "d364e35"));
            assemblyList.Add(Load("System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364" +
                        "e35"));
            assemblyList.Add(Load("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Net, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.Http, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                        "a"));
            assemblyList.Add(Load("System.Net.Http.WebRequest, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                        ""));
            assemblyList.Add(Load("System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b7" +
                        "7a5c561934e089"));
            assemblyList.Add(Load("System.ServiceModel.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "31bf3856ad364e35"));
            assemblyList.Add(Load("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c56193" +
                        "4e089"));
            assemblyList.Add(Load("System.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08" +
                        "9"));
            assemblyList.Add(Load("ActiproSoftware.DataGrid.Contrib.Wpf, Version=18.1.674.0, Culture=neutral, Public" +
                        "KeyToken=36ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.Docking.Wpf, Version=18.1.674.0, Culture=neutral, PublicKeyToken=" +
                        "36ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.Editors.Wpf, Version=18.1.674.0, Culture=neutral, PublicKeyToken=" +
                        "36ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.Ribbon.Wpf, Version=18.1.674.0, Culture=neutral, PublicKeyToken=3" +
                        "6ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.Shared.Wpf, Version=18.1.674.0, Culture=neutral, PublicKeyToken=3" +
                        "6ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.SyntaxEditor.Addons.DotNet.Wpf, Version=18.1.674.0, Culture=neutr" +
                        "al, PublicKeyToken=36ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.SyntaxEditor.Wpf, Version=18.1.674.0, Culture=neutral, PublicKeyT" +
                        "oken=36ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.Text.Addons.DotNet.Wpf, Version=18.1.674.0, Culture=neutral, Publ" +
                        "icKeyToken=36ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.Text.LLParser.Wpf, Version=18.1.674.0, Culture=neutral, PublicKey" +
                        "Token=36ff2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.Text.Wpf, Version=18.1.674.0, Culture=neutral, PublicKeyToken=36f" +
                        "f2196ab5654b9"));
            assemblyList.Add(Load("ActiproSoftware.Wizard.Wpf, Version=18.1.674.0, Culture=neutral, PublicKeyToken=3" +
                        "6ff2196ab5654b9"));
            assemblyList.Add(Load("CsvHelper, Version=2.0.0.0, Culture=neutral, PublicKeyToken=8c4959082be5c823"));
            assemblyList.Add(Load("CustomInputForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("DocX, Version=1.0.0.18, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("Humanizer, Version=2.4.0.0, Culture=neutral, PublicKeyToken=979442b78dfc278e"));
            assemblyList.Add(Load("ICSharpCode.AvalonEdit, Version=5.0.3.0, Culture=neutral, PublicKeyToken=9cc39be6" +
                        "72370310"));
            assemblyList.Add(Load("Microsoft.AspNet.SignalR.Client, Version=2.4.0.0, Culture=neutral, PublicKeyToken" +
                        "=31bf3856ad364e35"));
            assemblyList.Add(Load("Microsoft.Rest.ClientRuntime, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31" +
                        "bf3856ad364e35"));
            assemblyList.Add(Load("Newtonsoft.Json, Version=11.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6ae" +
                        "ed"));
            assemblyList.Add(Load("UiPath.Activities.Contracts, Version=19.10.3.0, Culture=neutral, PublicKeyToken=n" +
                        "ull"));
            assemblyList.Add(Load("UiPath.CV.Activities.Design, Version=19.11.1.0, Culture=neutral, PublicKeyToken=n" +
                        "ull"));
            assemblyList.Add(Load("UiPath.CV.Activities, Version=19.11.1.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("UiPath.CV, Version=19.11.1.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("UiPath.Interop, Version=0.1.1.0, Culture=neutral, PublicKeyToken=461894da7f0ba157" +
                        ""));
            assemblyList.Add(Load("UiPath.OCR.Contracts, Version=2.2.1.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("UiPath.OrchestratorClient, Version=19.10.1.0, Culture=neutral, PublicKeyToken=nul" +
                        "l"));
            assemblyList.Add(Load("UiPath.System.Activities.Design, Version=19.10.1.0, Culture=neutral, PublicKeyTok" +
                        "en=null"));
            assemblyList.Add(Load("UiPath.System.Activities, Version=19.10.1.0, Culture=neutral, PublicKeyToken=null" +
                        ""));
            assemblyList.Add(Load("UiPath.UIAutomation.Activities.Design, Version=19.11.1.0, Culture=neutral, Public" +
                        "KeyToken=null"));
            assemblyList.Add(Load("UiPath.UiAutomation.Activities, Version=19.11.1.0, Culture=neutral, PublicKeyToke" +
                        "n=null"));
            assemblyList.Add(Load("UiPath.Vision.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("UiPath.Vision, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("UiPath.Wizards, Version=19.11.1.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("Xceed.Wpf.AvalonDock, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f3" +
                        "0244f4"));
            assemblyList.Add(Load("Xceed.Wpf.AvalonDock.Themes.Aero, Version=3.5.0.0, Culture=neutral, PublicKeyToke" +
                        "n=3e4669d2f30244f4"));
            assemblyList.Add(Load("Xceed.Wpf.AvalonDock.Themes.Metro, Version=3.5.0.0, Culture=neutral, PublicKeyTok" +
                        "en=3e4669d2f30244f4"));
            assemblyList.Add(Load("Xceed.Wpf.AvalonDock.Themes.VS2010, Version=3.5.0.0, Culture=neutral, PublicKeyTo" +
                        "ken=3e4669d2f30244f4"));
            assemblyList.Add(Load("Xceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f3024" +
                        "4f4"));
            assemblyList.Add(Load("Microsoft.Win32.Primitives, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("System.AppContext, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50" +
                        "a3a"));
            assemblyList.Add(Load("System.Collections.Concurrent, Version=4.0.11.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Collections, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                        "50a3a"));
            assemblyList.Add(Load("System.Collections.NonGeneric, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Collections.Specialized, Version=4.0.3.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.Annotations, Version=4.0.10.0, Culture=neutral, PublicKeyTo" +
                        "ken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.EventBasedAsync, Version=4.0.11.0, Culture=neutral, PublicK" +
                        "eyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.Primitives, Version=4.1.2.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.TypeConverter, Version=4.1.2.0, Culture=neutral, PublicKeyT" +
                        "oken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Console, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                        ""));
            assemblyList.Add(Load("System.Data.Common, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                        "0a3a"));
            assemblyList.Add(Load("System.Diagnostics.Contracts, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Debug, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.FileVersionInfo, Version=4.0.2.0, Culture=neutral, PublicKeyTo" +
                        "ken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Process, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.StackTrace, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.TextWriterTraceListener, Version=4.0.2.0, Culture=neutral, Pub" +
                        "licKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Tools, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.TraceSource, Version=4.0.2.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Drawing.Primitives, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Dynamic.Runtime, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Globalization.Calendars, Version=4.0.3.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Globalization, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Globalization.Extensions, Version=4.1.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.Compression.ZipFile, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b" +
                        "77a5c561934e089"));
            assemblyList.Add(Load("System.IO, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem.DriveInfo, Version=4.0.2.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem.Primitives, Version=4.0.3.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem.Watcher, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.IsolatedStorage, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.MemoryMappedFiles, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03" +
                        "f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.Pipes, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                        "a"));
            assemblyList.Add(Load("System.IO.UnmanagedMemoryStream, Version=4.0.3.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Linq, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Linq.Expressions, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Linq.Parallel, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Linq.Queryable, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Net.Http.Rtc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                        "50a3a"));
            assemblyList.Add(Load("System.Net.NameResolution, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.NetworkInformation, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.Ping, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                        "a"));
            assemblyList.Add(Load("System.Net.Primitives, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Net.Requests, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Net.Security, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                        "50a3a"));
            assemblyList.Add(Load("System.Net.Sockets, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                        "0a3a"));
            assemblyList.Add(Load("System.Net.WebHeaderCollection, Version=4.0.1.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.WebSockets.Client, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.WebSockets, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.ObjectModel, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                        "50a3a"));
            assemblyList.Add(Load("System.Reflection, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50" +
                        "a3a"));
            assemblyList.Add(Load("System.Reflection.Emit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Emit.ILGeneration, Version=4.0.0.0, Culture=neutral, PublicKeyT" +
                        "oken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Emit.Lightweight, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                        "ken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Extensions, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Primitives, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Resources.Reader, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Resources.ResourceManager, Version=4.0.1.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Resources.Writer, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.CompilerServices.VisualC, Version=4.0.2.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Extensions, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Handles, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Runtime.InteropServices, Version=4.1.2.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.InteropServices.RuntimeInformation, Version=4.0.2.0, Culture=neutr" +
                        "al, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.InteropServices.WindowsRuntime, Version=4.0.0.0, Culture=neutral, " +
                        "PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Numerics, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Formatters, Version=4.0.2.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Json, Version=4.0.1.0, Culture=neutral, PublicKeyTok" +
                        "en=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Primitives, Version=4.2.0.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Xml, Version=4.1.3.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Claims, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Algorithms, Version=4.3.0.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Csp, Version=4.0.2.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Encoding, Version=4.0.2.0, Culture=neutral, PublicKe" +
                        "yToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Primitives, Version=4.0.2.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.X509Certificates, Version=4.1.2.0, Culture=neutral, " +
                        "PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Principal, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.SecureString, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Duplex, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Http, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.NetTcp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Primitives, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Text.Encoding, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Text.Encoding.Extensions, Version=4.0.11.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Text.RegularExpressions, Version=4.1.1.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50" +
                        "a3a"));
            assemblyList.Add(Load("System.Threading.Overlapped, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03" +
                        "f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Tasks, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Tasks.Parallel, Version=4.0.1.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Thread, Version=4.0.2.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Threading.ThreadPool, Version=4.0.12.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Timer, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.ValueTuple, Version=4.0.2.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2dd" +
                        "d51"));
            assemblyList.Add(Load("System.Xml.ReaderWriter, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Xml.XDocument, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Xml.XmlDocument, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Xml.XmlSerializer, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Xml.XPath, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                        "3a"));
            assemblyList.Add(Load("System.Xml.XPath.XDocument, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(System.Reflection.Assembly.GetExecutingAssembly());
            return assemblyList;
        }
        
        private static System.Reflection.Assembly Load(string assemblyNameVal) {
            System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(assemblyNameVal);
            byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
            System.Reflection.Assembly asm = null;
            try {
                asm = System.Reflection.Assembly.Load(assemblyName.FullName);
            }
            catch (System.Exception ) {
                System.Reflection.AssemblyName shortName = new System.Reflection.AssemblyName(assemblyName.Name);
                if ((publicKeyToken != null)) {
                    shortName.SetPublicKeyToken(publicKeyToken);
                }
                asm = System.Reflection.Assembly.Load(shortName);
            }
            return asm;
        }
    }
}
