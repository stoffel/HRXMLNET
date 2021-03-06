// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.0.0.19662
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace HRXML.Net
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("DunsNumber", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DunsNumberDataType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class DunsNumberDataType : EntityBase<DunsNumberDataType>
    {

        private DunsNumberDataTypeDunsNumberType dunsNumberTypeField;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DunsNumberDataTypeDunsNumberType dunsNumberType
        {
            get
            {
                return this.dunsNumberTypeField;
            }
            set
            {
                if ((dunsNumberTypeField.Equals(value) != true))
                {
                    this.dunsNumberTypeField = value;
                    this.OnPropertyChanged("dunsNumberType");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public enum DunsNumberDataTypeDunsNumberType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("standard Duns")]
        standardDuns,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("global ultimate")]
        globalultimate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("domestic ultimate")]
        domesticultimate,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("InternetDomainName", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "InternetDomainNameType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class InternetDomainNameType : EntityBase<InternetDomainNameType>
    {

        private bool primaryIndicatorField;

        private bool primaryIndicatorFieldSpecified;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool primaryIndicator
        {
            get
            {
                return this.primaryIndicatorField;
            }
            set
            {
                if ((primaryIndicatorField.Equals(value) != true))
                {
                    this.primaryIndicatorField = value;
                    this.OnPropertyChanged("primaryIndicator");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool primaryIndicatorSpecified
        {
            get
            {
                return this.primaryIndicatorFieldSpecified;
            }
            set
            {
                if ((primaryIndicatorFieldSpecified.Equals(value) != true))
                {
                    this.primaryIndicatorFieldSpecified = value;
                    this.OnPropertyChanged("primaryIndicatorSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }

}
