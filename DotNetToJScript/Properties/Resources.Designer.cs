﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetToJScript.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetToJScript.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var shell = new ActiveXObject(&apos;WScript.Shell&apos;);
        ///ver = &apos;v4.0.30319&apos;;
        ///try {
        ///shell.RegRead(&apos;HKLM\\SOFTWARE\\Microsoft\\.NETFramework\\v4.0.30319\\&apos;);
        ///} catch(e) { 
        ///ver = &apos;v2.0.50727&apos;;
        ///}
        ///shell.Environment(&apos;Process&apos;)(&apos;COMPLUS_Version&apos;) = ver;
        ///.
        /// </summary>
        internal static string jscript_auto_version_script {
            get {
                return ResourceManager.GetString("jscript_auto_version_script", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function base64ToStream(b) {
        ///	var enc = new ActiveXObject(&quot;System.Text.ASCIIEncoding&quot;);
        ///	var length = enc.GetByteCount_2(b);
        ///	var ba = enc.GetBytes_4(b);
        ///	var transform = new ActiveXObject(&quot;System.Security.Cryptography.FromBase64Transform&quot;);
        ///	ba = transform.TransformFinalBlock(ba, 0, length);
        ///	var ms = new ActiveXObject(&quot;System.IO.MemoryStream&quot;);
        ///	ms.Write(ba, 0, (length / 4) * 3);
        ///	ms.Position = 0;
        ///	return ms;
        ///}
        ///
        ///var serialized_obj = %SERIALIZED%;
        ///var entry_class = &apos;%CLASS%&apos;;
        ///
        ///try {
        ///	setver [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string jscript_template {
            get {
                return ResourceManager.GetString("jscript_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&apos;1.0&apos;?&gt;
        ///&lt;package&gt;
        ///&lt;component id=&apos;dummy&apos;&gt;
        ///&lt;registration
        ///  description=&apos;dummy&apos;
        ///  progid=&apos;dummy&apos;
        ///  version=&apos;1.00&apos;
        ///  remotable=&apos;True&apos;&gt;
        ///&lt;/registration&gt;
        ///&lt;/component&gt;
        ///&lt;/package&gt;.
        /// </summary>
        internal static string scriptlet_template {
            get {
                return ResourceManager.GetString("scriptlet_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dim ver
        ///ver = &quot;v4.0.30319&quot;
        ///On Error Resume Next
        ///shell.RegRead &quot;HKLM\SOFTWARE\\Microsoft\.NETFramework\v4.0.30319\&quot;
        ///If Err.Number &lt;&gt; 0 Then
        ///  ver = &quot;v2.0.50727&quot;
        ///  Err.Clear
        ///End If
        ///shell.Environment(&quot;Process&quot;).Item(&quot;COMPLUS_Version&quot;) = ver
        ///.
        /// </summary>
        internal static string vb_multi_auto_version_script {
            get {
                return ResourceManager.GetString("vb_multi_auto_version_script", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Private Function decodeHex(hex)
        ///    On Error Resume Next
        ///    Dim DM, EL
        ///    Set DM = CreateObject(&quot;Microsoft.XMLDOM&quot;)
        ///    Set EL = DM.createElement(&quot;tmp&quot;)
        ///    EL.DataType = &quot;bin.hex&quot;
        ///    EL.Text = hex
        ///    decodeHex = EL.NodeTypedValue
        ///End Function
        ///
        ///Function Run()
        ///    Dim serialized_obj
        ///    %SERIALIZED%
        ///
        ///    entry_class = &quot;%CLASS%&quot;
        ///
        ///    Dim stm As Object, fmt As Object, al As Object
        ///    Set stm = CreateObject(&quot;System.IO.MemoryStream&quot;)
        ///    Set fmt = CreateObject(&quot;System.Runtime.Serialization [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string vba_template {
            get {
                return ResourceManager.GetString("vba_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function Base64ToStream(b)
        ///  Dim enc, length, ba, transform, ms
        ///  Set enc = CreateObject(&quot;System.Text.ASCIIEncoding&quot;)
        ///  length = enc.GetByteCount_2(b)
        ///  Set transform = CreateObject(&quot;System.Security.Cryptography.FromBase64Transform&quot;)
        ///  Set ms = CreateObject(&quot;System.IO.MemoryStream&quot;)
        ///  ms.Write transform.TransformFinalBlock(enc.GetBytes_4(b), 0, length), 0, ((length / 4) * 3)
        ///  ms.Position = 0
        ///  Set Base64ToStream = ms
        ///End Function
        ///
        ///Sub Run
        ///Dim s, entry_class
        ///s = %SERIALIZED%
        ///entry_class = &quot;%CL [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string vbs_template {
            get {
                return ResourceManager.GetString("vbs_template", resourceCulture);
            }
        }
    }
}
