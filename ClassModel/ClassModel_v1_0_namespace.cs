//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace ClassModel_v1_0 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/XMLSchema1.xsd")]
    [System.Xml.Serialization.XmlRootAttribute("ClassModelAbstraction", Namespace="http://tempuri.org/XMLSchema1.xsd", IsNullable=false)]
    public partial class ClassModelAbstractionType {
        
        private ClassesType[] classesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Classes")]
        public ClassesType[] Classes {
            get {
                return this.classesField;
            }
            set {
                this.classesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/XMLSchema1.xsd")]
    public partial class ClassesType {
        
        private ClassType[] classField;
        
        private string namespaceNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Class")]
        public ClassType[] Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string namespaceName {
            get {
                return this.namespaceNameField;
            }
            set {
                this.namespaceNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/XMLSchema1.xsd")]
    public partial class ClassType {
        
        private PropertyType[] propertiesField;
        
        private string nameField;
        
        private bool sankoDemoLuokkaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Property", IsNullable=false)]
        public PropertyType[] Properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool sankoDemoLuokka {
            get {
                return this.sankoDemoLuokkaField;
            }
            set {
                this.sankoDemoLuokkaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/XMLSchema1.xsd")]
    public partial class PropertyType {
        
        private string nameField;
        
        private string dataTypeField;
        
        private bool isAutoPropertyField;
        
        public PropertyType() {
            this.isAutoPropertyField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool isAutoProperty {
            get {
                return this.isAutoPropertyField;
            }
            set {
                this.isAutoPropertyField = value;
            }
        }
    }
}
