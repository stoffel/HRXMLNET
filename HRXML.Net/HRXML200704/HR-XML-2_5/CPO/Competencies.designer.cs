// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.3.0.36516
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLasyLoading>False</EnableLasyLoading><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("Competency", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CompetencyType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class CompetencyType : EntityBase<CompetencyType>
    {

        private CompetencyTypeCompetencyId competencyIdField;

        private List<CompetencyTypeTaxonomyId> taxonomyIdField;

        private List<CompetencyTypeCompetencyEvidence> competencyEvidenceField;

        private List<CompetencyTypeCompetencyWeight> competencyWeightField;

        private List<CompetencyType> competencyField;

        private UserAreaType userAreaField;

        private string nameField;

        private string descriptionField;

        private bool requiredField;

        private bool requiredFieldSpecified;

        /// <summary>
        /// CompetencyType class constructor
        /// </summary>
        public CompetencyType()
        {
            this.userAreaField = new UserAreaType();
            this.competencyField = new List<CompetencyType>();
            this.competencyWeightField = new List<CompetencyTypeCompetencyWeight>();
            this.competencyEvidenceField = new List<CompetencyTypeCompetencyEvidence>();
            this.taxonomyIdField = new List<CompetencyTypeTaxonomyId>();
            this.competencyIdField = new CompetencyTypeCompetencyId();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompetencyTypeCompetencyId CompetencyId
        {
            get
            {
                return this.competencyIdField;
            }
            set
            {
                if ((this.competencyIdField != null))
                {
                    if ((competencyIdField.Equals(value) != true))
                    {
                        this.competencyIdField = value;
                        this.OnPropertyChanged("CompetencyId");
                    }
                }
                else
                {
                    this.competencyIdField = value;
                    this.OnPropertyChanged("CompetencyId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("TaxonomyId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<CompetencyTypeTaxonomyId> TaxonomyId
        {
            get
            {
                return this.taxonomyIdField;
            }
            set
            {
                if ((this.taxonomyIdField != null))
                {
                    if ((taxonomyIdField.Equals(value) != true))
                    {
                        this.taxonomyIdField = value;
                        this.OnPropertyChanged("TaxonomyId");
                    }
                }
                else
                {
                    this.taxonomyIdField = value;
                    this.OnPropertyChanged("TaxonomyId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CompetencyEvidence")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<CompetencyTypeCompetencyEvidence> CompetencyEvidence
        {
            get
            {
                return this.competencyEvidenceField;
            }
            set
            {
                if ((this.competencyEvidenceField != null))
                {
                    if ((competencyEvidenceField.Equals(value) != true))
                    {
                        this.competencyEvidenceField = value;
                        this.OnPropertyChanged("CompetencyEvidence");
                    }
                }
                else
                {
                    this.competencyEvidenceField = value;
                    this.OnPropertyChanged("CompetencyEvidence");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CompetencyWeight")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<CompetencyTypeCompetencyWeight> CompetencyWeight
        {
            get
            {
                return this.competencyWeightField;
            }
            set
            {
                if ((this.competencyWeightField != null))
                {
                    if ((competencyWeightField.Equals(value) != true))
                    {
                        this.competencyWeightField = value;
                        this.OnPropertyChanged("CompetencyWeight");
                    }
                }
                else
                {
                    this.competencyWeightField = value;
                    this.OnPropertyChanged("CompetencyWeight");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Competency")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<CompetencyType> Competency
        {
            get
            {
                return this.competencyField;
            }
            set
            {
                if ((this.competencyField != null))
                {
                    if ((competencyField.Equals(value) != true))
                    {
                        this.competencyField = value;
                        this.OnPropertyChanged("Competency");
                    }
                }
                else
                {
                    this.competencyField = value;
                    this.OnPropertyChanged("Competency");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserAreaType UserArea
        {
            get
            {
                return this.userAreaField;
            }
            set
            {
                if ((this.userAreaField != null))
                {
                    if ((userAreaField.Equals(value) != true))
                    {
                        this.userAreaField = value;
                        this.OnPropertyChanged("UserArea");
                    }
                }
                else
                {
                    this.userAreaField = value;
                    this.OnPropertyChanged("UserArea");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                if ((this.nameField != null))
                {
                    if ((nameField.Equals(value) != true))
                    {
                        this.nameField = value;
                        this.OnPropertyChanged("name");
                    }
                }
                else
                {
                    this.nameField = value;
                    this.OnPropertyChanged("name");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                if ((this.descriptionField != null))
                {
                    if ((descriptionField.Equals(value) != true))
                    {
                        this.descriptionField = value;
                        this.OnPropertyChanged("description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("description");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                if ((requiredField.Equals(value) != true))
                {
                    this.requiredField = value;
                    this.OnPropertyChanged("required");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool requiredSpecified
        {
            get
            {
                return this.requiredFieldSpecified;
            }
            set
            {
                if ((requiredFieldSpecified.Equals(value) != true))
                {
                    this.requiredFieldSpecified = value;
                    this.OnPropertyChanged("requiredSpecified");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CompetencyTypeCompetencyId", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class CompetencyTypeCompetencyId : EntityBase<CompetencyTypeCompetencyId>
    {

        private string idField;

        private string idOwnerField;

        private string descriptionField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                if ((this.idField != null))
                {
                    if ((idField.Equals(value) != true))
                    {
                        this.idField = value;
                        this.OnPropertyChanged("id");
                    }
                }
                else
                {
                    this.idField = value;
                    this.OnPropertyChanged("id");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idOwner
        {
            get
            {
                return this.idOwnerField;
            }
            set
            {
                if ((this.idOwnerField != null))
                {
                    if ((idOwnerField.Equals(value) != true))
                    {
                        this.idOwnerField = value;
                        this.OnPropertyChanged("idOwner");
                    }
                }
                else
                {
                    this.idOwnerField = value;
                    this.OnPropertyChanged("idOwner");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                if ((this.descriptionField != null))
                {
                    if ((descriptionField.Equals(value) != true))
                    {
                        this.descriptionField = value;
                        this.OnPropertyChanged("description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("description");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CompetencyTypeTaxonomyId", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class CompetencyTypeTaxonomyId : EntityBase<CompetencyTypeTaxonomyId>
    {

        private string idField;

        private string idOwnerField;

        private string descriptionField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                if ((this.idField != null))
                {
                    if ((idField.Equals(value) != true))
                    {
                        this.idField = value;
                        this.OnPropertyChanged("id");
                    }
                }
                else
                {
                    this.idField = value;
                    this.OnPropertyChanged("id");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idOwner
        {
            get
            {
                return this.idOwnerField;
            }
            set
            {
                if ((this.idOwnerField != null))
                {
                    if ((idOwnerField.Equals(value) != true))
                    {
                        this.idOwnerField = value;
                        this.OnPropertyChanged("idOwner");
                    }
                }
                else
                {
                    this.idOwnerField = value;
                    this.OnPropertyChanged("idOwner");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                if ((this.descriptionField != null))
                {
                    if ((descriptionField.Equals(value) != true))
                    {
                        this.descriptionField = value;
                        this.OnPropertyChanged("description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("description");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CompetencyTypeCompetencyEvidence", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class CompetencyTypeCompetencyEvidence : EntityBase<CompetencyTypeCompetencyEvidence>
    {

        private CompetencyTypeCompetencyEvidenceEvidenceId evidenceIdField;

        private object itemField;

        private List<string> supportingInformationField;

        private string dateOfIncidentField;

        private string nameField;

        private string typeDescriptionField;

        private string expirationDateField;

        private string typeIdField;

        private bool requiredField;

        private bool requiredFieldSpecified;

        private string lastUsedField;

        /// <summary>
        /// CompetencyTypeCompetencyEvidence class constructor
        /// </summary>
        public CompetencyTypeCompetencyEvidence()
        {
            this.supportingInformationField = new List<string>();
            this.evidenceIdField = new CompetencyTypeCompetencyEvidenceEvidenceId();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CompetencyTypeCompetencyEvidenceEvidenceId EvidenceId
        {
            get
            {
                return this.evidenceIdField;
            }
            set
            {
                if ((this.evidenceIdField != null))
                {
                    if ((evidenceIdField.Equals(value) != true))
                    {
                        this.evidenceIdField = value;
                        this.OnPropertyChanged("EvidenceId");
                    }
                }
                else
                {
                    this.evidenceIdField = value;
                    this.OnPropertyChanged("EvidenceId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("NumericValue", typeof(NumericValueType))]
        [System.Xml.Serialization.XmlElementAttribute("StringValue", typeof(StringValue))]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                if ((this.itemField != null))
                {
                    if ((itemField.Equals(value) != true))
                    {
                        this.itemField = value;
                        this.OnPropertyChanged("Item");
                    }
                }
                else
                {
                    this.itemField = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("SupportingInformation")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> SupportingInformation
        {
            get
            {
                return this.supportingInformationField;
            }
            set
            {
                if ((this.supportingInformationField != null))
                {
                    if ((supportingInformationField.Equals(value) != true))
                    {
                        this.supportingInformationField = value;
                        this.OnPropertyChanged("SupportingInformation");
                    }
                }
                else
                {
                    this.supportingInformationField = value;
                    this.OnPropertyChanged("SupportingInformation");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dateOfIncident
        {
            get
            {
                return this.dateOfIncidentField;
            }
            set
            {
                if ((this.dateOfIncidentField != null))
                {
                    if ((dateOfIncidentField.Equals(value) != true))
                    {
                        this.dateOfIncidentField = value;
                        this.OnPropertyChanged("dateOfIncident");
                    }
                }
                else
                {
                    this.dateOfIncidentField = value;
                    this.OnPropertyChanged("dateOfIncident");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                if ((this.nameField != null))
                {
                    if ((nameField.Equals(value) != true))
                    {
                        this.nameField = value;
                        this.OnPropertyChanged("name");
                    }
                }
                else
                {
                    this.nameField = value;
                    this.OnPropertyChanged("name");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string typeDescription
        {
            get
            {
                return this.typeDescriptionField;
            }
            set
            {
                if ((this.typeDescriptionField != null))
                {
                    if ((typeDescriptionField.Equals(value) != true))
                    {
                        this.typeDescriptionField = value;
                        this.OnPropertyChanged("typeDescription");
                    }
                }
                else
                {
                    this.typeDescriptionField = value;
                    this.OnPropertyChanged("typeDescription");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                if ((this.expirationDateField != null))
                {
                    if ((expirationDateField.Equals(value) != true))
                    {
                        this.expirationDateField = value;
                        this.OnPropertyChanged("expirationDate");
                    }
                }
                else
                {
                    this.expirationDateField = value;
                    this.OnPropertyChanged("expirationDate");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string typeId
        {
            get
            {
                return this.typeIdField;
            }
            set
            {
                if ((this.typeIdField != null))
                {
                    if ((typeIdField.Equals(value) != true))
                    {
                        this.typeIdField = value;
                        this.OnPropertyChanged("typeId");
                    }
                }
                else
                {
                    this.typeIdField = value;
                    this.OnPropertyChanged("typeId");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                if ((requiredField.Equals(value) != true))
                {
                    this.requiredField = value;
                    this.OnPropertyChanged("required");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool requiredSpecified
        {
            get
            {
                return this.requiredFieldSpecified;
            }
            set
            {
                if ((requiredFieldSpecified.Equals(value) != true))
                {
                    this.requiredFieldSpecified = value;
                    this.OnPropertyChanged("requiredSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastUsed
        {
            get
            {
                return this.lastUsedField;
            }
            set
            {
                if ((this.lastUsedField != null))
                {
                    if ((lastUsedField.Equals(value) != true))
                    {
                        this.lastUsedField = value;
                        this.OnPropertyChanged("lastUsed");
                    }
                }
                else
                {
                    this.lastUsedField = value;
                    this.OnPropertyChanged("lastUsed");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CompetencyTypeCompetencyEvidenceEvidenceId", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class CompetencyTypeCompetencyEvidenceEvidenceId : EntityBase<CompetencyTypeCompetencyEvidenceEvidenceId>
    {

        private string idField;

        private string idOwnerField;

        private string descriptionField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                if ((this.idField != null))
                {
                    if ((idField.Equals(value) != true))
                    {
                        this.idField = value;
                        this.OnPropertyChanged("id");
                    }
                }
                else
                {
                    this.idField = value;
                    this.OnPropertyChanged("id");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idOwner
        {
            get
            {
                return this.idOwnerField;
            }
            set
            {
                if ((this.idOwnerField != null))
                {
                    if ((idOwnerField.Equals(value) != true))
                    {
                        this.idOwnerField = value;
                        this.OnPropertyChanged("idOwner");
                    }
                }
                else
                {
                    this.idOwnerField = value;
                    this.OnPropertyChanged("idOwner");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                if ((this.descriptionField != null))
                {
                    if ((descriptionField.Equals(value) != true))
                    {
                        this.descriptionField = value;
                        this.OnPropertyChanged("description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("description");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CompetencyTypeCompetencyWeight", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class CompetencyTypeCompetencyWeight : EntityBase<CompetencyTypeCompetencyWeight>
    {

        private object itemField;

        private List<string> supportingInformationField;

        private string typeField;

        /// <summary>
        /// CompetencyTypeCompetencyWeight class constructor
        /// </summary>
        public CompetencyTypeCompetencyWeight()
        {
            this.supportingInformationField = new List<string>();
        }

        [System.Xml.Serialization.XmlElementAttribute("NumericValue", typeof(NumericValueType))]
        [System.Xml.Serialization.XmlElementAttribute("StringValue", typeof(StringValue))]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                if ((this.itemField != null))
                {
                    if ((itemField.Equals(value) != true))
                    {
                        this.itemField = value;
                        this.OnPropertyChanged("Item");
                    }
                }
                else
                {
                    this.itemField = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("SupportingInformation")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> SupportingInformation
        {
            get
            {
                return this.supportingInformationField;
            }
            set
            {
                if ((this.supportingInformationField != null))
                {
                    if ((supportingInformationField.Equals(value) != true))
                    {
                        this.supportingInformationField = value;
                        this.OnPropertyChanged("SupportingInformation");
                    }
                }
                else
                {
                    this.supportingInformationField = value;
                    this.OnPropertyChanged("SupportingInformation");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                if ((this.typeField != null))
                {
                    if ((typeField.Equals(value) != true))
                    {
                        this.typeField = value;
                        this.OnPropertyChanged("type");
                    }
                }
                else
                {
                    this.typeField = value;
                    this.OnPropertyChanged("type");
                }
            }
        }
    }
}
