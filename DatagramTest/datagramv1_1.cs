﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0", IsNullable=false)]
public partial class Datagram {
    
    private DatagramTransaction transactionField;
    
    private string idField;
    
    private System.DateTime timestampField;
    
    /// <remarks/>
    public DatagramTransaction Transaction {
        get {
            return this.transactionField;
        }
        set {
            this.transactionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime Timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransaction {
    
    private DatagramTransactionCustomer customerField;
    
    private DatagramTransactionOrder orderField;
    
    private DatagramTransactionPayment paymentField;
    
    private string idField;
    
    private System.DateTime timestampField;
    
    /// <remarks/>
    public DatagramTransactionCustomer Customer {
        get {
            return this.customerField;
        }
        set {
            this.customerField = value;
        }
    }
    
    /// <remarks/>
    public DatagramTransactionOrder Order {
        get {
            return this.orderField;
        }
        set {
            this.orderField = value;
        }
    }
    
    /// <remarks/>
    public DatagramTransactionPayment Payment {
        get {
            return this.paymentField;
        }
        set {
            this.paymentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime Timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionCustomer {
    
    private string nameField;
    
    private DatagramTransactionCustomerAddress[] addressField;
    
    private string notesField;
    
    private string idField;
    
    private string languageField;
    
    /// <remarks/>
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Address")]
    public DatagramTransactionCustomerAddress[] Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string Notes {
        get {
            return this.notesField;
        }
        set {
            this.notesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
    public string Language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionCustomerAddress {
    
    private string addressLine1Field;
    
    private string addressLine2Field;
    
    private string cityField;
    
    private string stateProvinceField;
    
    private string postalCodeField;
    
    private string mobileTelephoneField;
    
    private string alternateTelephoneField;
    
    private string notesField;
    
    private string idField;
    
    private DatagramTransactionCustomerAddressType typeField;
    
    /// <remarks/>
    public string AddressLine1 {
        get {
            return this.addressLine1Field;
        }
        set {
            this.addressLine1Field = value;
        }
    }
    
    /// <remarks/>
    public string AddressLine2 {
        get {
            return this.addressLine2Field;
        }
        set {
            this.addressLine2Field = value;
        }
    }
    
    /// <remarks/>
    public string City {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public string StateProvince {
        get {
            return this.stateProvinceField;
        }
        set {
            this.stateProvinceField = value;
        }
    }
    
    /// <remarks/>
    public string PostalCode {
        get {
            return this.postalCodeField;
        }
        set {
            this.postalCodeField = value;
        }
    }
    
    /// <remarks/>
    public string MobileTelephone {
        get {
            return this.mobileTelephoneField;
        }
        set {
            this.mobileTelephoneField = value;
        }
    }
    
    /// <remarks/>
    public string AlternateTelephone {
        get {
            return this.alternateTelephoneField;
        }
        set {
            this.alternateTelephoneField = value;
        }
    }
    
    /// <remarks/>
    public string Notes {
        get {
            return this.notesField;
        }
        set {
            this.notesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DatagramTransactionCustomerAddressType Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public enum DatagramTransactionCustomerAddressType {
    
    /// <remarks/>
    Contact,
    
    /// <remarks/>
    Delivery,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionOrder {
    
    private DatagramTransactionOrderAssembly[] assemblyField;
    
    private string notesField;
    
    private string orderingStoreField;
    
    private string producingStoreField;
    
    private System.DateTime readyTimeField;
    
    private bool readyTimeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Assembly")]
    public DatagramTransactionOrderAssembly[] Assembly {
        get {
            return this.assemblyField;
        }
        set {
            this.assemblyField = value;
        }
    }
    
    /// <remarks/>
    public string Notes {
        get {
            return this.notesField;
        }
        set {
            this.notesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string OrderingStore {
        get {
            return this.orderingStoreField;
        }
        set {
            this.orderingStoreField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string ProducingStore {
        get {
            return this.producingStoreField;
        }
        set {
            this.producingStoreField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime ReadyTime {
        get {
            return this.readyTimeField;
        }
        set {
            this.readyTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ReadyTimeSpecified {
        get {
            return this.readyTimeFieldSpecified;
        }
        set {
            this.readyTimeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionOrderAssembly {
    
    private DatagramTransactionOrderAssemblyItem[] itemField;
    
    private string sKUField;
    
    private string descriptionField;
    
    private string quantityField;
    
    private decimal unitPriceField;
    
    private bool taxableField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Item")]
    public DatagramTransactionOrderAssemblyItem[] Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SKU {
        get {
            return this.sKUField;
        }
        set {
            this.sKUField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal UnitPrice {
        get {
            return this.unitPriceField;
        }
        set {
            this.unitPriceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Taxable {
        get {
            return this.taxableField;
        }
        set {
            this.taxableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionOrderAssemblyItem {
    
    private DatagramTransactionOrderAssemblyItemComponent[] componentField;
    
    private string notesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Component")]
    public DatagramTransactionOrderAssemblyItemComponent[] Component {
        get {
            return this.componentField;
        }
        set {
            this.componentField = value;
        }
    }
    
    /// <remarks/>
    public string Notes {
        get {
            return this.notesField;
        }
        set {
            this.notesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionOrderAssemblyItemComponent {
    
    private string sKUField;
    
    private string descriptionField;
    
    private decimal quantityField;
    
    private decimal unitPriceField;
    
    private bool taxableField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SKU {
        get {
            return this.sKUField;
        }
        set {
            this.sKUField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal UnitPrice {
        get {
            return this.unitPriceField;
        }
        set {
            this.unitPriceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Taxable {
        get {
            return this.taxableField;
        }
        set {
            this.taxableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionPayment {
    
    private DatagramTransactionPaymentPurchaseTotal purchaseTotalField;
    
    private DatagramTransactionPaymentSalesTax[] salesTaxField;
    
    private DatagramTransactionPaymentVAT[] vATField;
    
    private DatagramTransactionPaymentPrepayment[] prepaymentField;
    
    private DatagramTransactionPaymentPaymentDue paymentDueField;
    
    private string notesField;
    
    /// <remarks/>
    public DatagramTransactionPaymentPurchaseTotal PurchaseTotal {
        get {
            return this.purchaseTotalField;
        }
        set {
            this.purchaseTotalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SalesTax")]
    public DatagramTransactionPaymentSalesTax[] SalesTax {
        get {
            return this.salesTaxField;
        }
        set {
            this.salesTaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("VAT")]
    public DatagramTransactionPaymentVAT[] VAT {
        get {
            return this.vATField;
        }
        set {
            this.vATField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Prepayment")]
    public DatagramTransactionPaymentPrepayment[] Prepayment {
        get {
            return this.prepaymentField;
        }
        set {
            this.prepaymentField = value;
        }
    }
    
    /// <remarks/>
    public DatagramTransactionPaymentPaymentDue PaymentDue {
        get {
            return this.paymentDueField;
        }
        set {
            this.paymentDueField = value;
        }
    }
    
    /// <remarks/>
    public string Notes {
        get {
            return this.notesField;
        }
        set {
            this.notesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionPaymentPurchaseTotal {
    
    private decimal amountField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionPaymentSalesTax {
    
    private decimal amountField;
    
    private decimal rateField;
    
    private string jurisdictionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Rate {
        get {
            return this.rateField;
        }
        set {
            this.rateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Jurisdiction {
        get {
            return this.jurisdictionField;
        }
        set {
            this.jurisdictionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionPaymentVAT {
    
    private decimal amountField;
    
    private decimal rateField;
    
    private string jurisdictionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Rate {
        get {
            return this.rateField;
        }
        set {
            this.rateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Jurisdiction {
        get {
            return this.jurisdictionField;
        }
        set {
            this.jurisdictionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionPaymentPrepayment {
    
    private decimal amountField;
    
    private System.DateTime datePaidField;
    
    private string transactionIdField;
    
    private string authorizationCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
    public System.DateTime DatePaid {
        get {
            return this.datePaidField;
        }
        set {
            this.datePaidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TransactionId {
        get {
            return this.transactionIdField;
        }
        set {
            this.transactionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AuthorizationCode {
        get {
            return this.authorizationCodeField;
        }
        set {
            this.authorizationCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://Namespaces.TLGPizza.com/Datagram-v1.0")]
public partial class DatagramTransactionPaymentPaymentDue {
    
    private decimal amountField;
    
    private System.DateTime dueDateField;
    
    private bool dueDateFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
    public System.DateTime DueDate {
        get {
            return this.dueDateField;
        }
        set {
            this.dueDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DueDateSpecified {
        get {
            return this.dueDateFieldSpecified;
        }
        set {
            this.dueDateFieldSpecified = value;
        }
    }
}
