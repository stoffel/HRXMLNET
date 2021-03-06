// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.3.0.36516
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLasyLoading>False</EnableLasyLoading><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IncludeInSchema = false)]
    public enum CertificateChoiceType
    {

        /// <remarks/>
        Duration,

        /// <remarks/>
        EndDateTime,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingAdditionalData", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingAdditionalData : AdditionalDataType
    {

        private List<object> itemsField;

        /// <summary>
        /// StaffingAdditionalData class constructor
        /// </summary>
        public StaffingAdditionalData()
        {
            this.itemsField = new List<object>();
        }

        [System.Xml.Serialization.XmlElementAttribute("StaffingAdditionalData", typeof(StaffingAdditionalData))]
        [System.Xml.Serialization.XmlElementAttribute("CustomerReportingRequirements", typeof(CustomerReportingRequirementsType))]
        [System.Xml.Serialization.XmlElementAttribute("ReferenceInformation", typeof(StaffingAdditionalDataReferenceInformation))]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<object> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                if ((this.itemsField != null))
                {
                    if ((itemsField.Equals(value) != true))
                    {
                        this.itemsField = value;
                        this.OnPropertyChanged("Items");
                    }
                }
                else
                {
                    this.itemsField = value;
                    this.OnPropertyChanged("Items");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingAdditionalDataReferenceInformation", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingAdditionalDataReferenceInformation : EntityBase<StaffingAdditionalDataReferenceInformation>
    {

        private List<EntityIdType> orderIdField;

        private List<EntityIdType> positionIdField;

        private List<EntityIdType> intermediaryIdField;

        private List<EntityIdType> staffingSupplierIdField;

        private List<EntityIdType> staffingCustomerIdField;

        private List<EntityIdType> masterOrderIdField;

        private List<EntityIdType> humanResourceIdField;

        private List<EntityIdType> assignmentIdField;

        private EntityIdType documentIdField;

        private List<EntityIdType> staffingSupplierOrgUnitIdField;

        private List<EntityIdType> staffingCustomerOrgUnitIdField;

        private List<EntityIdType> invoiceIdField;

        private List<EntityIdType> billToEntityIdField;

        private List<EntityIdType> staffingOrganizationIdField;

        private UserAreaType userAreaField;

        /// <summary>
        /// StaffingAdditionalDataReferenceInformation class constructor
        /// </summary>
        public StaffingAdditionalDataReferenceInformation()
        {
            this.staffingOrganizationIdField = new List<EntityIdType>();
            this.billToEntityIdField = new List<EntityIdType>();
            this.invoiceIdField = new List<EntityIdType>();
            this.staffingCustomerOrgUnitIdField = new List<EntityIdType>();
            this.staffingSupplierOrgUnitIdField = new List<EntityIdType>();
            this.assignmentIdField = new List<EntityIdType>();
            this.humanResourceIdField = new List<EntityIdType>();
            this.masterOrderIdField = new List<EntityIdType>();
            this.staffingCustomerIdField = new List<EntityIdType>();
            this.staffingSupplierIdField = new List<EntityIdType>();
            this.intermediaryIdField = new List<EntityIdType>();
            this.positionIdField = new List<EntityIdType>();
            this.orderIdField = new List<EntityIdType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("OrderId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> OrderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                if ((this.orderIdField != null))
                {
                    if ((orderIdField.Equals(value) != true))
                    {
                        this.orderIdField = value;
                        this.OnPropertyChanged("OrderId");
                    }
                }
                else
                {
                    this.orderIdField = value;
                    this.OnPropertyChanged("OrderId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("PositionId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> PositionId
        {
            get
            {
                return this.positionIdField;
            }
            set
            {
                if ((this.positionIdField != null))
                {
                    if ((positionIdField.Equals(value) != true))
                    {
                        this.positionIdField = value;
                        this.OnPropertyChanged("PositionId");
                    }
                }
                else
                {
                    this.positionIdField = value;
                    this.OnPropertyChanged("PositionId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("IntermediaryId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> IntermediaryId
        {
            get
            {
                return this.intermediaryIdField;
            }
            set
            {
                if ((this.intermediaryIdField != null))
                {
                    if ((intermediaryIdField.Equals(value) != true))
                    {
                        this.intermediaryIdField = value;
                        this.OnPropertyChanged("IntermediaryId");
                    }
                }
                else
                {
                    this.intermediaryIdField = value;
                    this.OnPropertyChanged("IntermediaryId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("StaffingSupplierId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> StaffingSupplierId
        {
            get
            {
                return this.staffingSupplierIdField;
            }
            set
            {
                if ((this.staffingSupplierIdField != null))
                {
                    if ((staffingSupplierIdField.Equals(value) != true))
                    {
                        this.staffingSupplierIdField = value;
                        this.OnPropertyChanged("StaffingSupplierId");
                    }
                }
                else
                {
                    this.staffingSupplierIdField = value;
                    this.OnPropertyChanged("StaffingSupplierId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("StaffingCustomerId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> StaffingCustomerId
        {
            get
            {
                return this.staffingCustomerIdField;
            }
            set
            {
                if ((this.staffingCustomerIdField != null))
                {
                    if ((staffingCustomerIdField.Equals(value) != true))
                    {
                        this.staffingCustomerIdField = value;
                        this.OnPropertyChanged("StaffingCustomerId");
                    }
                }
                else
                {
                    this.staffingCustomerIdField = value;
                    this.OnPropertyChanged("StaffingCustomerId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("MasterOrderId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> MasterOrderId
        {
            get
            {
                return this.masterOrderIdField;
            }
            set
            {
                if ((this.masterOrderIdField != null))
                {
                    if ((masterOrderIdField.Equals(value) != true))
                    {
                        this.masterOrderIdField = value;
                        this.OnPropertyChanged("MasterOrderId");
                    }
                }
                else
                {
                    this.masterOrderIdField = value;
                    this.OnPropertyChanged("MasterOrderId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("HumanResourceId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> HumanResourceId
        {
            get
            {
                return this.humanResourceIdField;
            }
            set
            {
                if ((this.humanResourceIdField != null))
                {
                    if ((humanResourceIdField.Equals(value) != true))
                    {
                        this.humanResourceIdField = value;
                        this.OnPropertyChanged("HumanResourceId");
                    }
                }
                else
                {
                    this.humanResourceIdField = value;
                    this.OnPropertyChanged("HumanResourceId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("AssignmentId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> AssignmentId
        {
            get
            {
                return this.assignmentIdField;
            }
            set
            {
                if ((this.assignmentIdField != null))
                {
                    if ((assignmentIdField.Equals(value) != true))
                    {
                        this.assignmentIdField = value;
                        this.OnPropertyChanged("AssignmentId");
                    }
                }
                else
                {
                    this.assignmentIdField = value;
                    this.OnPropertyChanged("AssignmentId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType DocumentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                if ((this.documentIdField != null))
                {
                    if ((documentIdField.Equals(value) != true))
                    {
                        this.documentIdField = value;
                        this.OnPropertyChanged("DocumentId");
                    }
                }
                else
                {
                    this.documentIdField = value;
                    this.OnPropertyChanged("DocumentId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("StaffingSupplierOrgUnitId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> StaffingSupplierOrgUnitId
        {
            get
            {
                return this.staffingSupplierOrgUnitIdField;
            }
            set
            {
                if ((this.staffingSupplierOrgUnitIdField != null))
                {
                    if ((staffingSupplierOrgUnitIdField.Equals(value) != true))
                    {
                        this.staffingSupplierOrgUnitIdField = value;
                        this.OnPropertyChanged("StaffingSupplierOrgUnitId");
                    }
                }
                else
                {
                    this.staffingSupplierOrgUnitIdField = value;
                    this.OnPropertyChanged("StaffingSupplierOrgUnitId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("StaffingCustomerOrgUnitId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> StaffingCustomerOrgUnitId
        {
            get
            {
                return this.staffingCustomerOrgUnitIdField;
            }
            set
            {
                if ((this.staffingCustomerOrgUnitIdField != null))
                {
                    if ((staffingCustomerOrgUnitIdField.Equals(value) != true))
                    {
                        this.staffingCustomerOrgUnitIdField = value;
                        this.OnPropertyChanged("StaffingCustomerOrgUnitId");
                    }
                }
                else
                {
                    this.staffingCustomerOrgUnitIdField = value;
                    this.OnPropertyChanged("StaffingCustomerOrgUnitId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("InvoiceId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> InvoiceId
        {
            get
            {
                return this.invoiceIdField;
            }
            set
            {
                if ((this.invoiceIdField != null))
                {
                    if ((invoiceIdField.Equals(value) != true))
                    {
                        this.invoiceIdField = value;
                        this.OnPropertyChanged("InvoiceId");
                    }
                }
                else
                {
                    this.invoiceIdField = value;
                    this.OnPropertyChanged("InvoiceId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("BillToEntityId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> BillToEntityId
        {
            get
            {
                return this.billToEntityIdField;
            }
            set
            {
                if ((this.billToEntityIdField != null))
                {
                    if ((billToEntityIdField.Equals(value) != true))
                    {
                        this.billToEntityIdField = value;
                        this.OnPropertyChanged("BillToEntityId");
                    }
                }
                else
                {
                    this.billToEntityIdField = value;
                    this.OnPropertyChanged("BillToEntityId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("StaffingOrganizationId")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> StaffingOrganizationId
        {
            get
            {
                return this.staffingOrganizationIdField;
            }
            set
            {
                if ((this.staffingOrganizationIdField != null))
                {
                    if ((staffingOrganizationIdField.Equals(value) != true))
                    {
                        this.staffingOrganizationIdField = value;
                        this.OnPropertyChanged("StaffingOrganizationId");
                    }
                }
                else
                {
                    this.staffingOrganizationIdField = value;
                    this.OnPropertyChanged("StaffingOrganizationId");
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
    }
}
