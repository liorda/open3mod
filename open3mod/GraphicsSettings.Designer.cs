﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace open3mod {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class GraphicsSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static GraphicsSettings defaultInstance = ((GraphicsSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new GraphicsSettings())));
        
        public static GraphicsSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int TexQualityBias {
            get {
                return ((int)(this["TexQualityBias"]));
            }
            set {
                this["TexQualityBias"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int TextureFilter {
            get {
                return ((int)(this["TextureFilter"]));
            }
            set {
                this["TextureFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseMips {
            get {
                return ((bool)(this["UseMips"]));
            }
            set {
                this["UseMips"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int MultiSampling {
            get {
                return ((int)(this["MultiSampling"]));
            }
            set {
                this["MultiSampling"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int RenderingBackend {
            get {
                return ((int)(this["RenderingBackend"]));
            }
            set {
                this["RenderingBackend"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int LightingQuality {
            get {
                return ((int)(this["LightingQuality"]));
            }
            set {
                this["LightingQuality"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BackFaceCulling {
            get {
                return ((bool)(this["BackFaceCulling"]));
            }
            set {
                this["BackFaceCulling"] = value;
            }
        }
    }
}
