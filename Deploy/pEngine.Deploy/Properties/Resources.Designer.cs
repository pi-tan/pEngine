﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace pEngine.Properties {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("pEngine.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string FillShaderFrag {
            get {
                return ResourceManager.GetString("FillShaderFrag", resourceCulture);
            }
        }
        
        public static string FillShaderVert {
            get {
                return ResourceManager.GetString("FillShaderVert", resourceCulture);
            }
        }
        
        public static string SpriteShaderFrag {
            get {
                return ResourceManager.GetString("SpriteShaderFrag", resourceCulture);
            }
        }
        
        public static string SpriteShaderVert {
            get {
                return ResourceManager.GetString("SpriteShaderVert", resourceCulture);
            }
        }
        
        public static string TextShaderFrag {
            get {
                return ResourceManager.GetString("TextShaderFrag", resourceCulture);
            }
        }
        
        public static string TextShaderVert {
            get {
                return ResourceManager.GetString("TextShaderVert", resourceCulture);
            }
        }
    }
}