Option Strict Off
Option Explicit On

Imports System.Xml.Serialization

Namespace CTeDML

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte"), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IsNullable:=False)> _
    Partial Public Class cteProc
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cTeField As TCTe

        Private protCTeField As TProtCTe

        Private versaoField As String

        '''<remarks/>
        Public Property CTe() As TCTe
            Get
                Return Me.cTeField
            End Get
            Set(ByVal value As TCTe)
                Me.cTeField = Value
                Me.RaisePropertyChanged("CTe")
            End Set
        End Property

        '''<remarks/>
        Public Property protCTe() As TProtCTe
            Get
                Return Me.protCTeField
            End Get
            Set(ByVal value As TProtCTe)
                Me.protCTeField = Value
                Me.RaisePropertyChanged("protCTe")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property versao() As String
            Get
                Return Me.versaoField
            End Get
            Set(ByVal value As String)
                Me.versaoField = Value
                Me.RaisePropertyChanged("versao")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTe
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private infCteField As TCTeInfCte

        Private signatureField As SignatureType

        '''<remarks/>
        Public Property infCte() As TCTeInfCte
            Get
                Return Me.infCteField
            End Get
            Set(ByVal value As TCTeInfCte)
                Me.infCteField = Value
                Me.RaisePropertyChanged("infCte")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
        Public Property Signature() As SignatureType
            Get
                Return Me.signatureField
            End Get
            Set(ByVal value As SignatureType)
                Me.signatureField = Value
                Me.RaisePropertyChanged("Signature")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCte
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private ideField As TCTeInfCteIde

        Private complField As TCTeInfCteCompl

        Private emitField As TCTeInfCteEmit

        Private remField As TCTeInfCteRem

        Private expedField As TCTeInfCteExped

        Private recebField As TCTeInfCteReceb

        Private destField As TCTeInfCteDest

        Private vPrestField As TCTeInfCteVPrest

        Private impField As TCTeInfCteImp

        Private itemField As Object

        Private autXMLField() As TCTeInfCteAutXML

        Private versaoField As String

        Private idField As String

        '''<remarks/>
        Public Property ide() As TCTeInfCteIde
            Get
                Return Me.ideField
            End Get
            Set(ByVal value As TCTeInfCteIde)
                Me.ideField = Value
                Me.RaisePropertyChanged("ide")
            End Set
        End Property

        '''<remarks/>
        Public Property compl() As TCTeInfCteCompl
            Get
                Return Me.complField
            End Get
            Set(ByVal value As TCTeInfCteCompl)
                Me.complField = Value
                Me.RaisePropertyChanged("compl")
            End Set
        End Property

        '''<remarks/>
        Public Property emit() As TCTeInfCteEmit
            Get
                Return Me.emitField
            End Get
            Set(ByVal value As TCTeInfCteEmit)
                Me.emitField = Value
                Me.RaisePropertyChanged("emit")
            End Set
        End Property

        '''<remarks/>
        Public Property [rem]() As TCTeInfCteRem
            Get
                Return Me.remField
            End Get
            Set(ByVal value As TCTeInfCteRem)
                Me.remField = Value
                Me.RaisePropertyChanged("rem")
            End Set
        End Property

        '''<remarks/>
        Public Property exped() As TCTeInfCteExped
            Get
                Return Me.expedField
            End Get
            Set(ByVal value As TCTeInfCteExped)
                Me.expedField = Value
                Me.RaisePropertyChanged("exped")
            End Set
        End Property

        '''<remarks/>
        Public Property receb() As TCTeInfCteReceb
            Get
                Return Me.recebField
            End Get
            Set(ByVal value As TCTeInfCteReceb)
                Me.recebField = Value
                Me.RaisePropertyChanged("receb")
            End Set
        End Property

        '''<remarks/>
        Public Property dest() As TCTeInfCteDest
            Get
                Return Me.destField
            End Get
            Set(ByVal value As TCTeInfCteDest)
                Me.destField = Value
                Me.RaisePropertyChanged("dest")
            End Set
        End Property

        '''<remarks/>
        Public Property vPrest() As TCTeInfCteVPrest
            Get
                Return Me.vPrestField
            End Get
            Set(ByVal value As TCTeInfCteVPrest)
                Me.vPrestField = Value
                Me.RaisePropertyChanged("vPrest")
            End Set
        End Property

        '''<remarks/>
        Public Property imp() As TCTeInfCteImp
            Get
                Return Me.impField
            End Get
            Set(ByVal value As TCTeInfCteImp)
                Me.impField = Value
                Me.RaisePropertyChanged("imp")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("infCTeNorm", GetType(TCTeInfCteInfCTeNorm)), _
         System.Xml.Serialization.XmlElementAttribute("infCteAnu", GetType(TCTeInfCteInfCteAnu)), _
         System.Xml.Serialization.XmlElementAttribute("infCteComp", GetType(TCTeInfCteInfCteComp))> _
        Public Property Item() As Object
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As Object)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("autXML")> _
        Public Property autXML() As TCTeInfCteAutXML()
            Get
                Return Me.autXMLField
            End Get
            Set(ByVal value As TCTeInfCteAutXML())
                Me.autXMLField = Value
                Me.RaisePropertyChanged("autXML")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property versao() As String
            Get
                Return Me.versaoField
            End Get
            Set(ByVal value As String)
                Me.versaoField = Value
                Me.RaisePropertyChanged("versao")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="ID")> _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
                Me.RaisePropertyChanged("Id")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteIde
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cUFField As TCodUfIBGE

        Private cCTField As String

        Private cFOPField As String

        Private natOpField As String

        Private forPagField As TCTeInfCteIdeForPag

        Private forPagFieldSpecified As Boolean

        Private modField As TModCT

        Private serieField As String

        Private nCTField As String

        Private dhEmiField As String

        Private tpImpField As TCTeInfCteIdeTpImp

        Private tpEmisField As TCTeInfCteIdeTpEmis

        Private cDVField As String

        Private tpAmbField As TAmb

        Private tpCTeField As TFinCTe

        Private procEmiField As TProcEmi

        Private verProcField As String

        Private refCTEField As String

        Private cMunEnvField As String

        Private xMunEnvField As String

        Private uFEnvField As TUf

        Private modalField As TModTransp

        Private tpServField As TCTeInfCteIdeTpServ

        Private cMunIniField As String

        Private xMunIniField As String

        Private uFIniField As TUf

        Private cMunFimField As String

        Private xMunFimField As String

        Private uFFimField As TUf

        Private retiraField As TCTeInfCteIdeRetira

        Private xDetRetiraField As String

        Private itemField As Object

        Private dhContField As String

        Private xJustField As String

        '''<remarks/>
        Public Property cUF() As TCodUfIBGE
            Get
                Return Me.cUFField
            End Get
            Set(ByVal value As TCodUfIBGE)
                Me.cUFField = Value
                Me.RaisePropertyChanged("cUF")
            End Set
        End Property

        '''<remarks/>
        Public Property cCT() As String
            Get
                Return Me.cCTField
            End Get
            Set(ByVal value As String)
                Me.cCTField = Value
                Me.RaisePropertyChanged("cCT")
            End Set
        End Property

        '''<remarks/>
        Public Property CFOP() As String
            Get
                Return Me.cFOPField
            End Get
            Set(ByVal value As String)
                Me.cFOPField = Value
                Me.RaisePropertyChanged("CFOP")
            End Set
        End Property

        '''<remarks/>
        Public Property natOp() As String
            Get
                Return Me.natOpField
            End Get
            Set(ByVal value As String)
                Me.natOpField = Value
                Me.RaisePropertyChanged("natOp")
            End Set
        End Property

        '''<remarks/>
        Public Property forPag() As TCTeInfCteIdeForPag
            Get
                Return Me.forPagField
            End Get
            Set(ByVal value As TCTeInfCteIdeForPag)
                Me.forPagField = Value
                Me.RaisePropertyChanged("forPag")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property forPagSpecified() As Boolean
            Get
                Return Me.forPagFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.forPagFieldSpecified = Value
                Me.RaisePropertyChanged("forPagSpecified")
            End Set
        End Property

        '''<remarks/>
        Public Property [mod]() As TModCT
            Get
                Return Me.modField
            End Get
            Set(ByVal value As TModCT)
                Me.modField = Value
                Me.RaisePropertyChanged("mod")
            End Set
        End Property

        '''<remarks/>
        Public Property serie() As String
            Get
                Return Me.serieField
            End Get
            Set(ByVal value As String)
                Me.serieField = Value
                Me.RaisePropertyChanged("serie")
            End Set
        End Property

        '''<remarks/>
        Public Property nCT() As String
            Get
                Return Me.nCTField
            End Get
            Set(ByVal value As String)
                Me.nCTField = Value
                Me.RaisePropertyChanged("nCT")
            End Set
        End Property

        '''<remarks/>
        Public Property dhEmi() As String
            Get
                Return Me.dhEmiField
            End Get
            Set(ByVal value As String)
                Me.dhEmiField = Value
                Me.RaisePropertyChanged("dhEmi")
            End Set
        End Property

        '''<remarks/>
        Public Property tpImp() As TCTeInfCteIdeTpImp
            Get
                Return Me.tpImpField
            End Get
            Set(ByVal value As TCTeInfCteIdeTpImp)
                Me.tpImpField = Value
                Me.RaisePropertyChanged("tpImp")
            End Set
        End Property

        '''<remarks/>
        Public Property tpEmis() As TCTeInfCteIdeTpEmis
            Get
                Return Me.tpEmisField
            End Get
            Set(ByVal value As TCTeInfCteIdeTpEmis)
                Me.tpEmisField = Value
                Me.RaisePropertyChanged("tpEmis")
            End Set
        End Property

        '''<remarks/>
        Public Property cDV() As String
            Get
                Return Me.cDVField
            End Get
            Set(ByVal value As String)
                Me.cDVField = Value
                Me.RaisePropertyChanged("cDV")
            End Set
        End Property

        '''<remarks/>
        Public Property tpAmb() As TAmb
            Get
                Return Me.tpAmbField
            End Get
            Set(ByVal value As TAmb)
                Me.tpAmbField = Value
                Me.RaisePropertyChanged("tpAmb")
            End Set
        End Property

        '''<remarks/>
        Public Property tpCTe() As TFinCTe
            Get
                Return Me.tpCTeField
            End Get
            Set(ByVal value As TFinCTe)
                Me.tpCTeField = Value
                Me.RaisePropertyChanged("tpCTe")
            End Set
        End Property

        '''<remarks/>
        Public Property procEmi() As TProcEmi
            Get
                Return Me.procEmiField
            End Get
            Set(ByVal value As TProcEmi)
                Me.procEmiField = Value
                Me.RaisePropertyChanged("procEmi")
            End Set
        End Property

        '''<remarks/>
        Public Property verProc() As String
            Get
                Return Me.verProcField
            End Get
            Set(ByVal value As String)
                Me.verProcField = Value
                Me.RaisePropertyChanged("verProc")
            End Set
        End Property

        '''<remarks/>
        Public Property refCTE() As String
            Get
                Return Me.refCTEField
            End Get
            Set(ByVal value As String)
                Me.refCTEField = Value
                Me.RaisePropertyChanged("refCTE")
            End Set
        End Property

        '''<remarks/>
        Public Property cMunEnv() As String
            Get
                Return Me.cMunEnvField
            End Get
            Set(ByVal value As String)
                Me.cMunEnvField = Value
                Me.RaisePropertyChanged("cMunEnv")
            End Set
        End Property

        '''<remarks/>
        Public Property xMunEnv() As String
            Get
                Return Me.xMunEnvField
            End Get
            Set(ByVal value As String)
                Me.xMunEnvField = Value
                Me.RaisePropertyChanged("xMunEnv")
            End Set
        End Property

        '''<remarks/>
        Public Property UFEnv() As TUf
            Get
                Return Me.uFEnvField
            End Get
            Set(ByVal value As TUf)
                Me.uFEnvField = Value
                Me.RaisePropertyChanged("UFEnv")
            End Set
        End Property

        '''<remarks/>
        Public Property modal() As TModTransp
            Get
                Return Me.modalField
            End Get
            Set(ByVal value As TModTransp)
                Me.modalField = Value
                Me.RaisePropertyChanged("modal")
            End Set
        End Property

        '''<remarks/>
        Public Property tpServ() As TCTeInfCteIdeTpServ
            Get
                Return Me.tpServField
            End Get
            Set(ByVal value As TCTeInfCteIdeTpServ)
                Me.tpServField = Value
                Me.RaisePropertyChanged("tpServ")
            End Set
        End Property

        '''<remarks/>
        Public Property cMunIni() As String
            Get
                Return Me.cMunIniField
            End Get
            Set(ByVal value As String)
                Me.cMunIniField = Value
                Me.RaisePropertyChanged("cMunIni")
            End Set
        End Property

        '''<remarks/>
        Public Property xMunIni() As String
            Get
                Return Me.xMunIniField
            End Get
            Set(ByVal value As String)
                Me.xMunIniField = Value
                Me.RaisePropertyChanged("xMunIni")
            End Set
        End Property

        '''<remarks/>
        Public Property UFIni() As TUf
            Get
                Return Me.uFIniField
            End Get
            Set(ByVal value As TUf)
                Me.uFIniField = Value
                Me.RaisePropertyChanged("UFIni")
            End Set
        End Property

        '''<remarks/>
        Public Property cMunFim() As String
            Get
                Return Me.cMunFimField
            End Get
            Set(ByVal value As String)
                Me.cMunFimField = Value
                Me.RaisePropertyChanged("cMunFim")
            End Set
        End Property

        '''<remarks/>
        Public Property xMunFim() As String
            Get
                Return Me.xMunFimField
            End Get
            Set(ByVal value As String)
                Me.xMunFimField = Value
                Me.RaisePropertyChanged("xMunFim")
            End Set
        End Property

        '''<remarks/>
        Public Property UFFim() As TUf
            Get
                Return Me.uFFimField
            End Get
            Set(ByVal value As TUf)
                Me.uFFimField = Value
                Me.RaisePropertyChanged("UFFim")
            End Set
        End Property

        '''<remarks/>
        Public Property retira() As TCTeInfCteIdeRetira
            Get
                Return Me.retiraField
            End Get
            Set(ByVal value As TCTeInfCteIdeRetira)
                Me.retiraField = Value
                Me.RaisePropertyChanged("retira")
            End Set
        End Property

        '''<remarks/>
        Public Property xDetRetira() As String
            Get
                Return Me.xDetRetiraField
            End Get
            Set(ByVal value As String)
                Me.xDetRetiraField = Value
                Me.RaisePropertyChanged("xDetRetira")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("toma03", GetType(TCTeInfCteIdeToma03)), _
         System.Xml.Serialization.XmlElementAttribute("toma4", GetType(TCTeInfCteIdeToma4))> _
        Public Property Item() As Object
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As Object)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        Public Property dhCont() As String
            Get
                Return Me.dhContField
            End Get
            Set(ByVal value As String)
                Me.dhContField = Value
                Me.RaisePropertyChanged("dhCont")
            End Set
        End Property

        '''<remarks/>
        Public Property xJust() As String
            Get
                Return Me.xJustField
            End Get
            Set(ByVal value As String)
                Me.xJustField = Value
                Me.RaisePropertyChanged("xJust")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCodUfIBGE

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("11")> _
        Item11

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("12")> _
        Item12

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("13")> _
        Item13

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("14")> _
        Item14

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("15")> _
        Item15

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("16")> _
        Item16

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("17")> _
        Item17

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("21")> _
        Item21

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("22")> _
        Item22

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("23")> _
        Item23

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("24")> _
        Item24

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("25")> _
        Item25

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("26")> _
        Item26

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("27")> _
        Item27

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("28")> _
        Item28

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("29")> _
        Item29

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("31")> _
        Item31

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("32")> _
        Item32

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("33")> _
        Item33

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("35")> _
        Item35

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("41")> _
        Item41

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("42")> _
        Item42

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("43")> _
        Item43

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("50")> _
        Item50

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("51")> _
        Item51

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("52")> _
        Item52

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("53")> _
        Item53
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteIdeForPag

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TModCT

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("57")> _
        Item57
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteIdeTpImp

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteIdeTpEmis

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")> _
        Item5

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")> _
        Item7

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8")> _
        Item8
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TAmb

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TFinCTe

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TProcEmi

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TUf

        '''<remarks/>
        AC

        '''<remarks/>
        AL

        '''<remarks/>
        AM

        '''<remarks/>
        AP

        '''<remarks/>
        BA

        '''<remarks/>
        CE

        '''<remarks/>
        DF

        '''<remarks/>
        ES

        '''<remarks/>
        GO

        '''<remarks/>
        MA

        '''<remarks/>
        MG

        '''<remarks/>
        MS

        '''<remarks/>
        MT

        '''<remarks/>
        PA

        '''<remarks/>
        PB

        '''<remarks/>
        PE

        '''<remarks/>
        PI

        '''<remarks/>
        PR

        '''<remarks/>
        RJ

        '''<remarks/>
        RN

        '''<remarks/>
        RO

        '''<remarks/>
        RR

        '''<remarks/>
        RS

        '''<remarks/>
        SC

        '''<remarks/>
        SE

        '''<remarks/>
        SP

        '''<remarks/>
        [TO]

        '''<remarks/>
        EX
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TModTransp

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("01")> _
        Item01

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("02")> _
        Item02

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("03")> _
        Item03

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("04")> _
        Item04

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("05")> _
        Item05

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("06")> _
        Item06
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteIdeTpServ

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteIdeRetira

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteIdeToma03
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tomaField As TCTeInfCteIdeToma03Toma

        '''<remarks/>
        Public Property toma() As TCTeInfCteIdeToma03Toma
            Get
                Return Me.tomaField
            End Get
            Set(ByVal value As TCTeInfCteIdeToma03Toma)
                Me.tomaField = Value
                Me.RaisePropertyChanged("toma")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteIdeToma03Toma

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TProtCTe
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private infProtField As TProtCTeInfProt

        Private signatureField As SignatureType

        Private versaoField As String

        '''<remarks/>
        Public Property infProt() As TProtCTeInfProt
            Get
                Return Me.infProtField
            End Get
            Set(ByVal value As TProtCTeInfProt)
                Me.infProtField = Value
                Me.RaisePropertyChanged("infProt")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
        Public Property Signature() As SignatureType
            Get
                Return Me.signatureField
            End Get
            Set(ByVal value As SignatureType)
                Me.signatureField = Value
                Me.RaisePropertyChanged("Signature")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property versao() As String
            Get
                Return Me.versaoField
            End Get
            Set(ByVal value As String)
                Me.versaoField = Value
                Me.RaisePropertyChanged("versao")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TProtCTeInfProt
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpAmbField As TAmb

        Private verAplicField As String

        Private chCTeField As String

        Private dhRecbtoField As Date

        Private nProtField As String

        Private digValField() As Byte

        Private cStatField As String

        Private xMotivoField As String

        Private idField As String

        '''<remarks/>
        Public Property tpAmb() As TAmb
            Get
                Return Me.tpAmbField
            End Get
            Set(ByVal value As TAmb)
                Me.tpAmbField = Value
                Me.RaisePropertyChanged("tpAmb")
            End Set
        End Property

        '''<remarks/>
        Public Property verAplic() As String
            Get
                Return Me.verAplicField
            End Get
            Set(ByVal value As String)
                Me.verAplicField = Value
                Me.RaisePropertyChanged("verAplic")
            End Set
        End Property

        '''<remarks/>
        Public Property chCTe() As String
            Get
                Return Me.chCTeField
            End Get
            Set(ByVal value As String)
                Me.chCTeField = Value
                Me.RaisePropertyChanged("chCTe")
            End Set
        End Property

        '''<remarks/>
        Public Property dhRecbto() As Date
            Get
                Return Me.dhRecbtoField
            End Get
            Set(ByVal value As Date)
                Me.dhRecbtoField = Value
                Me.RaisePropertyChanged("dhRecbto")
            End Set
        End Property

        '''<remarks/>
        Public Property nProt() As String
            Get
                Return Me.nProtField
            End Get
            Set(ByVal value As String)
                Me.nProtField = Value
                Me.RaisePropertyChanged("nProt")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> _
        Public Property digVal() As Byte()
            Get
                Return Me.digValField
            End Get
            Set(ByVal value As Byte())
                Me.digValField = Value
                Me.RaisePropertyChanged("digVal")
            End Set
        End Property

        '''<remarks/>
        Public Property cStat() As String
            Get
                Return Me.cStatField
            End Get
            Set(ByVal value As String)
                Me.cStatField = Value
                Me.RaisePropertyChanged("cStat")
            End Set
        End Property

        '''<remarks/>
        Public Property xMotivo() As String
            Get
                Return Me.xMotivoField
            End Get
            Set(ByVal value As String)
                Me.xMotivoField = Value
                Me.RaisePropertyChanged("xMotivo")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="ID")> _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
                Me.RaisePropertyChanged("Id")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#"), _
     System.Xml.Serialization.XmlRootAttribute("Signature", [Namespace]:="http://www.w3.org/2000/09/xmldsig#", IsNullable:=False)> _
    Partial Public Class SignatureType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private signedInfoField As SignedInfoType

        Private signatureValueField As SignatureValueType

        Private keyInfoField As KeyInfoType

        Private idField As String

        '''<remarks/>
        Public Property SignedInfo() As SignedInfoType
            Get
                Return Me.signedInfoField
            End Get
            Set(ByVal value As SignedInfoType)
                Me.signedInfoField = Value
                Me.RaisePropertyChanged("SignedInfo")
            End Set
        End Property

        '''<remarks/>
        Public Property SignatureValue() As SignatureValueType
            Get
                Return Me.signatureValueField
            End Get
            Set(ByVal value As SignatureValueType)
                Me.signatureValueField = Value
                Me.RaisePropertyChanged("SignatureValue")
            End Set
        End Property

        '''<remarks/>
        Public Property KeyInfo() As KeyInfoType
            Get
                Return Me.keyInfoField
            End Get
            Set(ByVal value As KeyInfoType)
                Me.keyInfoField = Value
                Me.RaisePropertyChanged("KeyInfo")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="ID")> _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
                Me.RaisePropertyChanged("Id")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class SignedInfoType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private canonicalizationMethodField As SignedInfoTypeCanonicalizationMethod

        Private signatureMethodField As SignedInfoTypeSignatureMethod

        Private referenceField As ReferenceType

        Private idField As String

        '''<remarks/>
        Public Property CanonicalizationMethod() As SignedInfoTypeCanonicalizationMethod
            Get
                Return Me.canonicalizationMethodField
            End Get
            Set(ByVal value As SignedInfoTypeCanonicalizationMethod)
                Me.canonicalizationMethodField = Value
                Me.RaisePropertyChanged("CanonicalizationMethod")
            End Set
        End Property

        '''<remarks/>
        Public Property SignatureMethod() As SignedInfoTypeSignatureMethod
            Get
                Return Me.signatureMethodField
            End Get
            Set(ByVal value As SignedInfoTypeSignatureMethod)
                Me.signatureMethodField = Value
                Me.RaisePropertyChanged("SignatureMethod")
            End Set
        End Property

        '''<remarks/>
        Public Property Reference() As ReferenceType
            Get
                Return Me.referenceField
            End Get
            Set(ByVal value As ReferenceType)
                Me.referenceField = Value
                Me.RaisePropertyChanged("Reference")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="ID")> _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
                Me.RaisePropertyChanged("Id")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class SignedInfoTypeCanonicalizationMethod
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private algorithmField As String

        Public Sub New()
            MyBase.New()
            Me.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315"
        End Sub

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="anyURI")> _
        Public Property Algorithm() As String
            Get
                Return Me.algorithmField
            End Get
            Set(ByVal value As String)
                Me.algorithmField = Value
                Me.RaisePropertyChanged("Algorithm")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class SignedInfoTypeSignatureMethod
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private algorithmField As String

        Public Sub New()
            MyBase.New()
            Me.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1"
        End Sub

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="anyURI")> _
        Public Property Algorithm() As String
            Get
                Return Me.algorithmField
            End Get
            Set(ByVal value As String)
                Me.algorithmField = Value
                Me.RaisePropertyChanged("Algorithm")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class ReferenceType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private transformsField() As TransformType

        Private digestMethodField As ReferenceTypeDigestMethod

        Private digestValueField() As Byte

        Private idField As String

        Private uRIField As String

        Private typeField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable:=False)> _
        Public Property Transforms() As TransformType()
            Get
                Return Me.transformsField
            End Get
            Set(ByVal value As TransformType())
                Me.transformsField = Value
                Me.RaisePropertyChanged("Transforms")
            End Set
        End Property

        '''<remarks/>
        Public Property DigestMethod() As ReferenceTypeDigestMethod
            Get
                Return Me.digestMethodField
            End Get
            Set(ByVal value As ReferenceTypeDigestMethod)
                Me.digestMethodField = Value
                Me.RaisePropertyChanged("DigestMethod")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> _
        Public Property DigestValue() As Byte()
            Get
                Return Me.digestValueField
            End Get
            Set(ByVal value As Byte())
                Me.digestValueField = Value
                Me.RaisePropertyChanged("DigestValue")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="ID")> _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
                Me.RaisePropertyChanged("Id")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="anyURI")> _
        Public Property URI() As String
            Get
                Return Me.uRIField
            End Get
            Set(ByVal value As String)
                Me.uRIField = Value
                Me.RaisePropertyChanged("URI")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="anyURI")> _
        Public Property Type() As String
            Get
                Return Me.typeField
            End Get
            Set(ByVal value As String)
                Me.typeField = Value
                Me.RaisePropertyChanged("Type")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class TransformType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xPathField() As String

        Private algorithmField As TTransformURI

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("XPath")> _
        Public Property XPath() As String()
            Get
                Return Me.xPathField
            End Get
            Set(ByVal value As String())
                Me.xPathField = Value
                Me.RaisePropertyChanged("XPath")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property Algorithm() As TTransformURI
            Get
                Return Me.algorithmField
            End Get
            Set(ByVal value As TTransformURI)
                Me.algorithmField = Value
                Me.RaisePropertyChanged("Algorithm")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Public Enum TTransformURI

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")> _
        httpwwww3org200009xmldsigenvelopedsignature

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")> _
        httpwwww3orgTR2001RECxmlc14n20010315
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class ReferenceTypeDigestMethod
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private algorithmField As String

        Public Sub New()
            MyBase.New()
            Me.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1"
        End Sub

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="anyURI")> _
        Public Property Algorithm() As String
            Get
                Return Me.algorithmField
            End Get
            Set(ByVal value As String)
                Me.algorithmField = Value
                Me.RaisePropertyChanged("Algorithm")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class SignatureValueType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private idField As String

        Private valueField() As Byte

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="ID")> _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
                Me.RaisePropertyChanged("Id")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute(DataType:="base64Binary")> _
        Public Property Value() As Byte()
            Get
                Return Me.valueField
            End Get
            Set(ByVal value As Byte())
                Me.valueField = Value
                Me.RaisePropertyChanged("Value")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class KeyInfoType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private x509DataField As X509DataType

        Private idField As String

        '''<remarks/>
        Public Property X509Data() As X509DataType
            Get
                Return Me.x509DataField
            End Get
            Set(ByVal value As X509DataType)
                Me.x509DataField = Value
                Me.RaisePropertyChanged("X509Data")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="ID")> _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set(ByVal value As String)
                Me.idField = Value
                Me.RaisePropertyChanged("Id")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.w3.org/2000/09/xmldsig#")> _
    Partial Public Class X509DataType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private x509CertificateField() As Byte

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> _
        Public Property X509Certificate() As Byte()
            Get
                Return Me.x509CertificateField
            End Get
            Set(ByVal value As Byte())
                Me.x509CertificateField = Value
                Me.RaisePropertyChanged("X509Certificate")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TUnidCarga
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpUnidCargaField As TtipoUnidCarga

        Private idUnidCargaField As String

        Private lacUnidCargaField() As TUnidCargaLacUnidCarga

        Private qtdRatField As String

        '''<remarks/>
        Public Property tpUnidCarga() As TtipoUnidCarga
            Get
                Return Me.tpUnidCargaField
            End Get
            Set(ByVal value As TtipoUnidCarga)
                Me.tpUnidCargaField = Value
                Me.RaisePropertyChanged("tpUnidCarga")
            End Set
        End Property

        '''<remarks/>
        Public Property idUnidCarga() As String
            Get
                Return Me.idUnidCargaField
            End Get
            Set(ByVal value As String)
                Me.idUnidCargaField = Value
                Me.RaisePropertyChanged("idUnidCarga")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("lacUnidCarga")> _
        Public Property lacUnidCarga() As TUnidCargaLacUnidCarga()
            Get
                Return Me.lacUnidCargaField
            End Get
            Set(ByVal value As TUnidCargaLacUnidCarga())
                Me.lacUnidCargaField = Value
                Me.RaisePropertyChanged("lacUnidCarga")
            End Set
        End Property

        '''<remarks/>
        Public Property qtdRat() As String
            Get
                Return Me.qtdRatField
            End Get
            Set(ByVal value As String)
                Me.qtdRatField = Value
                Me.RaisePropertyChanged("qtdRat")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TtipoUnidCarga

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TUnidCargaLacUnidCarga
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private nLacreField As String

        '''<remarks/>
        Public Property nLacre() As String
            Get
                Return Me.nLacreField
            End Get
            Set(ByVal value As String)
                Me.nLacreField = Value
                Me.RaisePropertyChanged("nLacre")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TUnidadeTransp
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpUnidTranspField As TtipoUnidTransp

        Private idUnidTranspField As String

        Private lacUnidTranspField() As TUnidadeTranspLacUnidTransp

        Private infUnidCargaField() As TUnidCarga

        Private qtdRatField As String

        '''<remarks/>
        Public Property tpUnidTransp() As TtipoUnidTransp
            Get
                Return Me.tpUnidTranspField
            End Get
            Set(ByVal value As TtipoUnidTransp)
                Me.tpUnidTranspField = Value
                Me.RaisePropertyChanged("tpUnidTransp")
            End Set
        End Property

        '''<remarks/>
        Public Property idUnidTransp() As String
            Get
                Return Me.idUnidTranspField
            End Get
            Set(ByVal value As String)
                Me.idUnidTranspField = Value
                Me.RaisePropertyChanged("idUnidTransp")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("lacUnidTransp")> _
        Public Property lacUnidTransp() As TUnidadeTranspLacUnidTransp()
            Get
                Return Me.lacUnidTranspField
            End Get
            Set(ByVal value As TUnidadeTranspLacUnidTransp())
                Me.lacUnidTranspField = Value
                Me.RaisePropertyChanged("lacUnidTransp")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("infUnidCarga")> _
        Public Property infUnidCarga() As TUnidCarga()
            Get
                Return Me.infUnidCargaField
            End Get
            Set(ByVal value As TUnidCarga())
                Me.infUnidCargaField = Value
                Me.RaisePropertyChanged("infUnidCarga")
            End Set
        End Property

        '''<remarks/>
        Public Property qtdRat() As String
            Get
                Return Me.qtdRatField
            End Get
            Set(ByVal value As String)
                Me.qtdRatField = Value
                Me.RaisePropertyChanged("qtdRat")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TtipoUnidTransp

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")> _
        Item5

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("6")> _
        Item6

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")> _
        Item7
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TUnidadeTranspLacUnidTransp
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private nLacreField As String

        '''<remarks/>
        Public Property nLacre() As String
            Get
                Return Me.nLacreField
            End Get
            Set(ByVal value As String)
                Me.nLacreField = Value
                Me.RaisePropertyChanged("nLacre")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TImp
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As Object

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("ICMS00", GetType(TImpICMS00)), _
         System.Xml.Serialization.XmlElementAttribute("ICMS20", GetType(TImpICMS20)), _
         System.Xml.Serialization.XmlElementAttribute("ICMS45", GetType(TImpICMS45)), _
         System.Xml.Serialization.XmlElementAttribute("ICMS60", GetType(TImpICMS60)), _
         System.Xml.Serialization.XmlElementAttribute("ICMS90", GetType(TImpICMS90)), _
         System.Xml.Serialization.XmlElementAttribute("ICMSOutraUF", GetType(TImpICMSOutraUF)), _
         System.Xml.Serialization.XmlElementAttribute("ICMSSN", GetType(TImpICMSSN))> _
        Public Property Item() As Object
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As Object)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TImpICMS00
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cSTField As TImpICMS00CST

        Private vBCField As String

        Private pICMSField As String

        Private vICMSField As String

        '''<remarks/>
        Public Property CST() As TImpICMS00CST
            Get
                Return Me.cSTField
            End Get
            Set(ByVal value As TImpICMS00CST)
                Me.cSTField = Value
                Me.RaisePropertyChanged("CST")
            End Set
        End Property

        '''<remarks/>
        Public Property vBC() As String
            Get
                Return Me.vBCField
            End Get
            Set(ByVal value As String)
                Me.vBCField = Value
                Me.RaisePropertyChanged("vBC")
            End Set
        End Property

        '''<remarks/>
        Public Property pICMS() As String
            Get
                Return Me.pICMSField
            End Get
            Set(ByVal value As String)
                Me.pICMSField = Value
                Me.RaisePropertyChanged("pICMS")
            End Set
        End Property

        '''<remarks/>
        Public Property vICMS() As String
            Get
                Return Me.vICMSField
            End Get
            Set(ByVal value As String)
                Me.vICMSField = Value
                Me.RaisePropertyChanged("vICMS")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TImpICMS00CST

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("00")> _
        Item00
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TImpICMS20
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cSTField As TImpICMS20CST

        Private pRedBCField As String

        Private vBCField As String

        Private pICMSField As String

        Private vICMSField As String

        '''<remarks/>
        Public Property CST() As TImpICMS20CST
            Get
                Return Me.cSTField
            End Get
            Set(ByVal value As TImpICMS20CST)
                Me.cSTField = Value
                Me.RaisePropertyChanged("CST")
            End Set
        End Property

        '''<remarks/>
        Public Property pRedBC() As String
            Get
                Return Me.pRedBCField
            End Get
            Set(ByVal value As String)
                Me.pRedBCField = Value
                Me.RaisePropertyChanged("pRedBC")
            End Set
        End Property

        '''<remarks/>
        Public Property vBC() As String
            Get
                Return Me.vBCField
            End Get
            Set(ByVal value As String)
                Me.vBCField = Value
                Me.RaisePropertyChanged("vBC")
            End Set
        End Property

        '''<remarks/>
        Public Property pICMS() As String
            Get
                Return Me.pICMSField
            End Get
            Set(ByVal value As String)
                Me.pICMSField = Value
                Me.RaisePropertyChanged("pICMS")
            End Set
        End Property

        '''<remarks/>
        Public Property vICMS() As String
            Get
                Return Me.vICMSField
            End Get
            Set(ByVal value As String)
                Me.vICMSField = Value
                Me.RaisePropertyChanged("vICMS")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TImpICMS20CST

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("20")> _
        Item20
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TImpICMS45
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cSTField As TImpICMS45CST

        '''<remarks/>
        Public Property CST() As TImpICMS45CST
            Get
                Return Me.cSTField
            End Get
            Set(ByVal value As TImpICMS45CST)
                Me.cSTField = Value
                Me.RaisePropertyChanged("CST")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TImpICMS45CST

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("40")> _
        Item40

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("41")> _
        Item41

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("51")> _
        Item51
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TImpICMS60
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cSTField As TImpICMS60CST

        Private vBCSTRetField As String

        Private vICMSSTRetField As String

        Private pICMSSTRetField As String

        Private vCredField As String

        '''<remarks/>
        Public Property CST() As TImpICMS60CST
            Get
                Return Me.cSTField
            End Get
            Set(ByVal value As TImpICMS60CST)
                Me.cSTField = Value
                Me.RaisePropertyChanged("CST")
            End Set
        End Property

        '''<remarks/>
        Public Property vBCSTRet() As String
            Get
                Return Me.vBCSTRetField
            End Get
            Set(ByVal value As String)
                Me.vBCSTRetField = Value
                Me.RaisePropertyChanged("vBCSTRet")
            End Set
        End Property

        '''<remarks/>
        Public Property vICMSSTRet() As String
            Get
                Return Me.vICMSSTRetField
            End Get
            Set(ByVal value As String)
                Me.vICMSSTRetField = Value
                Me.RaisePropertyChanged("vICMSSTRet")
            End Set
        End Property

        '''<remarks/>
        Public Property pICMSSTRet() As String
            Get
                Return Me.pICMSSTRetField
            End Get
            Set(ByVal value As String)
                Me.pICMSSTRetField = Value
                Me.RaisePropertyChanged("pICMSSTRet")
            End Set
        End Property

        '''<remarks/>
        Public Property vCred() As String
            Get
                Return Me.vCredField
            End Get
            Set(ByVal value As String)
                Me.vCredField = Value
                Me.RaisePropertyChanged("vCred")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TImpICMS60CST

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("60")> _
        Item60
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TImpICMS90
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cSTField As TImpICMS90CST

        Private pRedBCField As String

        Private vBCField As String

        Private pICMSField As String

        Private vICMSField As String

        Private vCredField As String

        '''<remarks/>
        Public Property CST() As TImpICMS90CST
            Get
                Return Me.cSTField
            End Get
            Set(ByVal value As TImpICMS90CST)
                Me.cSTField = Value
                Me.RaisePropertyChanged("CST")
            End Set
        End Property

        '''<remarks/>
        Public Property pRedBC() As String
            Get
                Return Me.pRedBCField
            End Get
            Set(ByVal value As String)
                Me.pRedBCField = Value
                Me.RaisePropertyChanged("pRedBC")
            End Set
        End Property

        '''<remarks/>
        Public Property vBC() As String
            Get
                Return Me.vBCField
            End Get
            Set(ByVal value As String)
                Me.vBCField = Value
                Me.RaisePropertyChanged("vBC")
            End Set
        End Property

        '''<remarks/>
        Public Property pICMS() As String
            Get
                Return Me.pICMSField
            End Get
            Set(ByVal value As String)
                Me.pICMSField = Value
                Me.RaisePropertyChanged("pICMS")
            End Set
        End Property

        '''<remarks/>
        Public Property vICMS() As String
            Get
                Return Me.vICMSField
            End Get
            Set(ByVal value As String)
                Me.vICMSField = Value
                Me.RaisePropertyChanged("vICMS")
            End Set
        End Property

        '''<remarks/>
        Public Property vCred() As String
            Get
                Return Me.vCredField
            End Get
            Set(ByVal value As String)
                Me.vCredField = Value
                Me.RaisePropertyChanged("vCred")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TImpICMS90CST

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("90")> _
        Item90
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TImpICMSOutraUF
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cSTField As TImpICMSOutraUFCST

        Private pRedBCOutraUFField As String

        Private vBCOutraUFField As String

        Private pICMSOutraUFField As String

        Private vICMSOutraUFField As String

        '''<remarks/>
        Public Property CST() As TImpICMSOutraUFCST
            Get
                Return Me.cSTField
            End Get
            Set(ByVal value As TImpICMSOutraUFCST)
                Me.cSTField = Value
                Me.RaisePropertyChanged("CST")
            End Set
        End Property

        '''<remarks/>
        Public Property pRedBCOutraUF() As String
            Get
                Return Me.pRedBCOutraUFField
            End Get
            Set(ByVal value As String)
                Me.pRedBCOutraUFField = Value
                Me.RaisePropertyChanged("pRedBCOutraUF")
            End Set
        End Property

        '''<remarks/>
        Public Property vBCOutraUF() As String
            Get
                Return Me.vBCOutraUFField
            End Get
            Set(ByVal value As String)
                Me.vBCOutraUFField = Value
                Me.RaisePropertyChanged("vBCOutraUF")
            End Set
        End Property

        '''<remarks/>
        Public Property pICMSOutraUF() As String
            Get
                Return Me.pICMSOutraUFField
            End Get
            Set(ByVal value As String)
                Me.pICMSOutraUFField = Value
                Me.RaisePropertyChanged("pICMSOutraUF")
            End Set
        End Property

        '''<remarks/>
        Public Property vICMSOutraUF() As String
            Get
                Return Me.vICMSOutraUFField
            End Get
            Set(ByVal value As String)
                Me.vICMSOutraUFField = Value
                Me.RaisePropertyChanged("vICMSOutraUF")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TImpICMSOutraUFCST

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("90")> _
        Item90
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TImpICMSSN
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private indSNField As TImpICMSSNIndSN

        '''<remarks/>
        Public Property indSN() As TImpICMSSNIndSN
            Get
                Return Me.indSNField
            End Get
            Set(ByVal value As TImpICMSSNIndSN)
                Me.indSNField = Value
                Me.RaisePropertyChanged("indSN")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TImpICMSSNIndSN

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TEndeEmi
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xLgrField As String

        Private nroField As String

        Private xCplField As String

        Private xBairroField As String

        Private cMunField As String

        Private xMunField As String

        Private cEPField As String

        Private ufField As TUF_sem_EX

        Private foneField As String

        '''<remarks/>
        Public Property xLgr() As String
            Get
                Return Me.xLgrField
            End Get
            Set(ByVal value As String)
                Me.xLgrField = Value
                Me.RaisePropertyChanged("xLgr")
            End Set
        End Property

        '''<remarks/>
        Public Property nro() As String
            Get
                Return Me.nroField
            End Get
            Set(ByVal value As String)
                Me.nroField = Value
                Me.RaisePropertyChanged("nro")
            End Set
        End Property

        '''<remarks/>
        Public Property xCpl() As String
            Get
                Return Me.xCplField
            End Get
            Set(ByVal value As String)
                Me.xCplField = Value
                Me.RaisePropertyChanged("xCpl")
            End Set
        End Property

        '''<remarks/>
        Public Property xBairro() As String
            Get
                Return Me.xBairroField
            End Get
            Set(ByVal value As String)
                Me.xBairroField = Value
                Me.RaisePropertyChanged("xBairro")
            End Set
        End Property

        '''<remarks/>
        Public Property cMun() As String
            Get
                Return Me.cMunField
            End Get
            Set(ByVal value As String)
                Me.cMunField = Value
                Me.RaisePropertyChanged("cMun")
            End Set
        End Property

        '''<remarks/>
        Public Property xMun() As String
            Get
                Return Me.xMunField
            End Get
            Set(ByVal value As String)
                Me.xMunField = Value
                Me.RaisePropertyChanged("xMun")
            End Set
        End Property

        '''<remarks/>
        Public Property CEP() As String
            Get
                Return Me.cEPField
            End Get
            Set(ByVal value As String)
                Me.cEPField = Value
                Me.RaisePropertyChanged("CEP")
            End Set
        End Property

        '''<remarks/>
        Public Property UF() As TUF_sem_EX
            Get
                Return Me.ufField
            End Get
            Set(ByVal value As TUF_sem_EX)
                Me.ufField = Value
                Me.RaisePropertyChanged("UF")
            End Set
        End Property

        '''<remarks/>
        Public Property fone() As String
            Get
                Return Me.foneField
            End Get
            Set(ByVal value As String)
                Me.foneField = Value
                Me.RaisePropertyChanged("fone")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TUF_sem_EX

        '''<remarks/>
        AC

        '''<remarks/>
        AL

        '''<remarks/>
        AM

        '''<remarks/>
        AP

        '''<remarks/>
        BA

        '''<remarks/>
        CE

        '''<remarks/>
        DF

        '''<remarks/>
        ES

        '''<remarks/>
        GO

        '''<remarks/>
        MA

        '''<remarks/>
        MG

        '''<remarks/>
        MS

        '''<remarks/>
        MT

        '''<remarks/>
        PA

        '''<remarks/>
        PB

        '''<remarks/>
        PE

        '''<remarks/>
        PI

        '''<remarks/>
        PR

        '''<remarks/>
        RJ

        '''<remarks/>
        RN

        '''<remarks/>
        RO

        '''<remarks/>
        RR

        '''<remarks/>
        RS

        '''<remarks/>
        SC

        '''<remarks/>
        SE

        '''<remarks/>
        SP

        '''<remarks/>
        [TO]
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TEndereco
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xLgrField As String

        Private nroField As String

        Private xCplField As String

        Private xBairroField As String

        Private cMunField As String

        Private xMunField As String

        Private cEPField As String

        Private ufField As TUf

        Private cPaisField As String

        Private xPaisField As String

        '''<remarks/>
        Public Property xLgr() As String
            Get
                Return Me.xLgrField
            End Get
            Set(ByVal value As String)
                Me.xLgrField = Value
                Me.RaisePropertyChanged("xLgr")
            End Set
        End Property

        '''<remarks/>
        Public Property nro() As String
            Get
                Return Me.nroField
            End Get
            Set(ByVal value As String)
                Me.nroField = Value
                Me.RaisePropertyChanged("nro")
            End Set
        End Property

        '''<remarks/>
        Public Property xCpl() As String
            Get
                Return Me.xCplField
            End Get
            Set(ByVal value As String)
                Me.xCplField = Value
                Me.RaisePropertyChanged("xCpl")
            End Set
        End Property

        '''<remarks/>
        Public Property xBairro() As String
            Get
                Return Me.xBairroField
            End Get
            Set(ByVal value As String)
                Me.xBairroField = Value
                Me.RaisePropertyChanged("xBairro")
            End Set
        End Property

        '''<remarks/>
        Public Property cMun() As String
            Get
                Return Me.cMunField
            End Get
            Set(ByVal value As String)
                Me.cMunField = Value
                Me.RaisePropertyChanged("cMun")
            End Set
        End Property

        '''<remarks/>
        Public Property xMun() As String
            Get
                Return Me.xMunField
            End Get
            Set(ByVal value As String)
                Me.xMunField = Value
                Me.RaisePropertyChanged("xMun")
            End Set
        End Property

        '''<remarks/>
        Public Property CEP() As String
            Get
                Return Me.cEPField
            End Get
            Set(ByVal value As String)
                Me.cEPField = Value
                Me.RaisePropertyChanged("CEP")
            End Set
        End Property

        '''<remarks/>
        Public Property UF() As TUf
            Get
                Return Me.ufField
            End Get
            Set(ByVal value As TUf)
                Me.ufField = Value
                Me.RaisePropertyChanged("UF")
            End Set
        End Property

        '''<remarks/>
        Public Property cPais() As String
            Get
                Return Me.cPaisField
            End Get
            Set(ByVal value As String)
                Me.cPaisField = Value
                Me.RaisePropertyChanged("cPais")
            End Set
        End Property

        '''<remarks/>
        Public Property xPais() As String
            Get
                Return Me.xPaisField
            End Get
            Set(ByVal value As String)
                Me.xPaisField = Value
                Me.RaisePropertyChanged("xPais")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteIdeToma4
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tomaField As TCTeInfCteIdeToma4Toma

        Private itemField As String

        Private itemElementNameField As ItemChoiceType

        Private ieField As String

        Private xNomeField As String

        Private xFantField As String

        Private foneField As String

        Private enderTomaField As TEndereco

        Private emailField As String

        '''<remarks/>
        Public Property toma() As TCTeInfCteIdeToma4Toma
            Get
                Return Me.tomaField
            End Get
            Set(ByVal value As TCTeInfCteIdeToma4Toma)
                Me.tomaField = Value
                Me.RaisePropertyChanged("toma")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("CPF", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As String
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As String)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        '''<remarks/>
        Public Property IE() As String
            Get
                Return Me.ieField
            End Get
            Set(ByVal value As String)
                Me.ieField = Value
                Me.RaisePropertyChanged("IE")
            End Set
        End Property

        '''<remarks/>
        Public Property xNome() As String
            Get
                Return Me.xNomeField
            End Get
            Set(ByVal value As String)
                Me.xNomeField = Value
                Me.RaisePropertyChanged("xNome")
            End Set
        End Property

        '''<remarks/>
        Public Property xFant() As String
            Get
                Return Me.xFantField
            End Get
            Set(ByVal value As String)
                Me.xFantField = Value
                Me.RaisePropertyChanged("xFant")
            End Set
        End Property

        '''<remarks/>
        Public Property fone() As String
            Get
                Return Me.foneField
            End Get
            Set(ByVal value As String)
                Me.foneField = Value
                Me.RaisePropertyChanged("fone")
            End Set
        End Property

        '''<remarks/>
        Public Property enderToma() As TEndereco
            Get
                Return Me.enderTomaField
            End Get
            Set(ByVal value As TEndereco)
                Me.enderTomaField = Value
                Me.RaisePropertyChanged("enderToma")
            End Set
        End Property

        '''<remarks/>
        Public Property email() As String
            Get
                Return Me.emailField
            End Get
            Set(ByVal value As String)
                Me.emailField = Value
                Me.RaisePropertyChanged("email")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteIdeToma4Toma

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType

        '''<remarks/>
        CNPJ

        '''<remarks/>
        CPF
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteCompl
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xCaracAdField As String

        Private xCaracSerField As String

        Private xEmiField As String

        Private fluxoField As TCTeInfCteComplFluxo

        Private entregaField As TCTeInfCteComplEntrega

        Private origCalcField As String

        Private destCalcField As String

        Private xObsField As String

        Private obsContField() As TCTeInfCteComplObsCont

        Private obsFiscoField() As TCTeInfCteComplObsFisco

        '''<remarks/>
        Public Property xCaracAd() As String
            Get
                Return Me.xCaracAdField
            End Get
            Set(ByVal value As String)
                Me.xCaracAdField = Value
                Me.RaisePropertyChanged("xCaracAd")
            End Set
        End Property

        '''<remarks/>
        Public Property xCaracSer() As String
            Get
                Return Me.xCaracSerField
            End Get
            Set(ByVal value As String)
                Me.xCaracSerField = Value
                Me.RaisePropertyChanged("xCaracSer")
            End Set
        End Property

        '''<remarks/>
        Public Property xEmi() As String
            Get
                Return Me.xEmiField
            End Get
            Set(ByVal value As String)
                Me.xEmiField = Value
                Me.RaisePropertyChanged("xEmi")
            End Set
        End Property

        '''<remarks/>
        Public Property fluxo() As TCTeInfCteComplFluxo
            Get
                Return Me.fluxoField
            End Get
            Set(ByVal value As TCTeInfCteComplFluxo)
                Me.fluxoField = Value
                Me.RaisePropertyChanged("fluxo")
            End Set
        End Property

        '''<remarks/>
        Public Property Entrega() As TCTeInfCteComplEntrega
            Get
                Return Me.entregaField
            End Get
            Set(ByVal value As TCTeInfCteComplEntrega)
                Me.entregaField = Value
                Me.RaisePropertyChanged("Entrega")
            End Set
        End Property

        '''<remarks/>
        Public Property origCalc() As String
            Get
                Return Me.origCalcField
            End Get
            Set(ByVal value As String)
                Me.origCalcField = Value
                Me.RaisePropertyChanged("origCalc")
            End Set
        End Property

        '''<remarks/>
        Public Property destCalc() As String
            Get
                Return Me.destCalcField
            End Get
            Set(ByVal value As String)
                Me.destCalcField = Value
                Me.RaisePropertyChanged("destCalc")
            End Set
        End Property

        '''<remarks/>
        Public Property xObs() As String
            Get
                Return Me.xObsField
            End Get
            Set(ByVal value As String)
                Me.xObsField = Value
                Me.RaisePropertyChanged("xObs")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("ObsCont")> _
        Public Property ObsCont() As TCTeInfCteComplObsCont()
            Get
                Return Me.obsContField
            End Get
            Set(ByVal value As TCTeInfCteComplObsCont())
                Me.obsContField = Value
                Me.RaisePropertyChanged("ObsCont")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("ObsFisco")> _
        Public Property ObsFisco() As TCTeInfCteComplObsFisco()
            Get
                Return Me.obsFiscoField
            End Get
            Set(ByVal value As TCTeInfCteComplObsFisco())
                Me.obsFiscoField = Value
                Me.RaisePropertyChanged("ObsFisco")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplFluxo
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xOrigField As String

        Private passField() As TCTeInfCteComplFluxoPass

        Private xDestField As String

        Private xRotaField As String

        '''<remarks/>
        Public Property xOrig() As String
            Get
                Return Me.xOrigField
            End Get
            Set(ByVal value As String)
                Me.xOrigField = Value
                Me.RaisePropertyChanged("xOrig")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("pass")> _
        Public Property pass() As TCTeInfCteComplFluxoPass()
            Get
                Return Me.passField
            End Get
            Set(ByVal value As TCTeInfCteComplFluxoPass())
                Me.passField = Value
                Me.RaisePropertyChanged("pass")
            End Set
        End Property

        '''<remarks/>
        Public Property xDest() As String
            Get
                Return Me.xDestField
            End Get
            Set(ByVal value As String)
                Me.xDestField = Value
                Me.RaisePropertyChanged("xDest")
            End Set
        End Property

        '''<remarks/>
        Public Property xRota() As String
            Get
                Return Me.xRotaField
            End Get
            Set(ByVal value As String)
                Me.xRotaField = Value
                Me.RaisePropertyChanged("xRota")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplFluxoPass
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xPassField As String

        '''<remarks/>
        Public Property xPass() As String
            Get
                Return Me.xPassField
            End Get
            Set(ByVal value As String)
                Me.xPassField = Value
                Me.RaisePropertyChanged("xPass")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplEntrega
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As Object

        Private item1Field As Object

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("comData", GetType(TCTeInfCteComplEntregaComData)), _
         System.Xml.Serialization.XmlElementAttribute("noPeriodo", GetType(TCTeInfCteComplEntregaNoPeriodo)), _
         System.Xml.Serialization.XmlElementAttribute("semData", GetType(TCTeInfCteComplEntregaSemData))> _
        Public Property Item() As Object
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As Object)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("comHora", GetType(TCTeInfCteComplEntregaComHora)), _
         System.Xml.Serialization.XmlElementAttribute("noInter", GetType(TCTeInfCteComplEntregaNoInter)), _
         System.Xml.Serialization.XmlElementAttribute("semHora", GetType(TCTeInfCteComplEntregaSemHora))> _
        Public Property Item1() As Object
            Get
                Return Me.item1Field
            End Get
            Set(ByVal value As Object)
                Me.item1Field = Value
                Me.RaisePropertyChanged("Item1")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplEntregaComData
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpPerField As TCTeInfCteComplEntregaComDataTpPer

        Private dProgField As String

        '''<remarks/>
        Public Property tpPer() As TCTeInfCteComplEntregaComDataTpPer
            Get
                Return Me.tpPerField
            End Get
            Set(ByVal value As TCTeInfCteComplEntregaComDataTpPer)
                Me.tpPerField = Value
                Me.RaisePropertyChanged("tpPer")
            End Set
        End Property

        '''<remarks/>
        Public Property dProg() As String
            Get
                Return Me.dProgField
            End Get
            Set(ByVal value As String)
                Me.dProgField = Value
                Me.RaisePropertyChanged("dProg")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteComplEntregaComDataTpPer

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplEntregaNoPeriodo
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpPerField As TCTeInfCteComplEntregaNoPeriodoTpPer

        Private dIniField As String

        Private dFimField As String

        '''<remarks/>
        Public Property tpPer() As TCTeInfCteComplEntregaNoPeriodoTpPer
            Get
                Return Me.tpPerField
            End Get
            Set(ByVal value As TCTeInfCteComplEntregaNoPeriodoTpPer)
                Me.tpPerField = Value
                Me.RaisePropertyChanged("tpPer")
            End Set
        End Property

        '''<remarks/>
        Public Property dIni() As String
            Get
                Return Me.dIniField
            End Get
            Set(ByVal value As String)
                Me.dIniField = Value
                Me.RaisePropertyChanged("dIni")
            End Set
        End Property

        '''<remarks/>
        Public Property dFim() As String
            Get
                Return Me.dFimField
            End Get
            Set(ByVal value As String)
                Me.dFimField = Value
                Me.RaisePropertyChanged("dFim")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteComplEntregaNoPeriodoTpPer

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplEntregaSemData
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpPerField As TCTeInfCteComplEntregaSemDataTpPer

        '''<remarks/>
        Public Property tpPer() As TCTeInfCteComplEntregaSemDataTpPer
            Get
                Return Me.tpPerField
            End Get
            Set(ByVal value As TCTeInfCteComplEntregaSemDataTpPer)
                Me.tpPerField = Value
                Me.RaisePropertyChanged("tpPer")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteComplEntregaSemDataTpPer

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplEntregaComHora
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpHorField As TCTeInfCteComplEntregaComHoraTpHor

        Private hProgField As String

        '''<remarks/>
        Public Property tpHor() As TCTeInfCteComplEntregaComHoraTpHor
            Get
                Return Me.tpHorField
            End Get
            Set(ByVal value As TCTeInfCteComplEntregaComHoraTpHor)
                Me.tpHorField = Value
                Me.RaisePropertyChanged("tpHor")
            End Set
        End Property

        '''<remarks/>
        Public Property hProg() As String
            Get
                Return Me.hProgField
            End Get
            Set(ByVal value As String)
                Me.hProgField = Value
                Me.RaisePropertyChanged("hProg")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteComplEntregaComHoraTpHor

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplEntregaNoInter
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpHorField As TCTeInfCteComplEntregaNoInterTpHor

        Private hIniField As String

        Private hFimField As String

        '''<remarks/>
        Public Property tpHor() As TCTeInfCteComplEntregaNoInterTpHor
            Get
                Return Me.tpHorField
            End Get
            Set(ByVal value As TCTeInfCteComplEntregaNoInterTpHor)
                Me.tpHorField = Value
                Me.RaisePropertyChanged("tpHor")
            End Set
        End Property

        '''<remarks/>
        Public Property hIni() As String
            Get
                Return Me.hIniField
            End Get
            Set(ByVal value As String)
                Me.hIniField = Value
                Me.RaisePropertyChanged("hIni")
            End Set
        End Property

        '''<remarks/>
        Public Property hFim() As String
            Get
                Return Me.hFimField
            End Get
            Set(ByVal value As String)
                Me.hFimField = Value
                Me.RaisePropertyChanged("hFim")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteComplEntregaNoInterTpHor

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplEntregaSemHora
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpHorField As TCTeInfCteComplEntregaSemHoraTpHor

        '''<remarks/>
        Public Property tpHor() As TCTeInfCteComplEntregaSemHoraTpHor
            Get
                Return Me.tpHorField
            End Get
            Set(ByVal value As TCTeInfCteComplEntregaSemHoraTpHor)
                Me.tpHorField = Value
                Me.RaisePropertyChanged("tpHor")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteComplEntregaSemHoraTpHor

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplObsCont
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xTextoField As String

        Private xCampoField As String

        '''<remarks/>
        Public Property xTexto() As String
            Get
                Return Me.xTextoField
            End Get
            Set(ByVal value As String)
                Me.xTextoField = Value
                Me.RaisePropertyChanged("xTexto")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property xCampo() As String
            Get
                Return Me.xCampoField
            End Get
            Set(ByVal value As String)
                Me.xCampoField = Value
                Me.RaisePropertyChanged("xCampo")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteComplObsFisco
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xTextoField As String

        Private xCampoField As String

        '''<remarks/>
        Public Property xTexto() As String
            Get
                Return Me.xTextoField
            End Get
            Set(ByVal value As String)
                Me.xTextoField = Value
                Me.RaisePropertyChanged("xTexto")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property xCampo() As String
            Get
                Return Me.xCampoField
            End Get
            Set(ByVal value As String)
                Me.xCampoField = Value
                Me.RaisePropertyChanged("xCampo")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteEmit
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cNPJField As String

        Private ieField As String

        Private xNomeField As String

        Private xFantField As String

        Private enderEmitField As TEndeEmi

        '''<remarks/>
        Public Property CNPJ() As String
            Get
                Return Me.cNPJField
            End Get
            Set(ByVal value As String)
                Me.cNPJField = Value
                Me.RaisePropertyChanged("CNPJ")
            End Set
        End Property

        '''<remarks/>
        Public Property IE() As String
            Get
                Return Me.ieField
            End Get
            Set(ByVal value As String)
                Me.ieField = Value
                Me.RaisePropertyChanged("IE")
            End Set
        End Property

        '''<remarks/>
        Public Property xNome() As String
            Get
                Return Me.xNomeField
            End Get
            Set(ByVal value As String)
                Me.xNomeField = Value
                Me.RaisePropertyChanged("xNome")
            End Set
        End Property

        '''<remarks/>
        Public Property xFant() As String
            Get
                Return Me.xFantField
            End Get
            Set(ByVal value As String)
                Me.xFantField = Value
                Me.RaisePropertyChanged("xFant")
            End Set
        End Property

        '''<remarks/>
        Public Property enderEmit() As TEndeEmi
            Get
                Return Me.enderEmitField
            End Get
            Set(ByVal value As TEndeEmi)
                Me.enderEmitField = Value
                Me.RaisePropertyChanged("enderEmit")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteRem
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As String

        Private itemElementNameField As ItemChoiceType1

        Private ieField As String

        Private xNomeField As String

        Private xFantField As String

        Private foneField As String

        Private enderRemeField As TEndereco

        Private emailField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("CPF", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As String
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As String)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType1
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType1)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        '''<remarks/>
        Public Property IE() As String
            Get
                Return Me.ieField
            End Get
            Set(ByVal value As String)
                Me.ieField = Value
                Me.RaisePropertyChanged("IE")
            End Set
        End Property

        '''<remarks/>
        Public Property xNome() As String
            Get
                Return Me.xNomeField
            End Get
            Set(ByVal value As String)
                Me.xNomeField = Value
                Me.RaisePropertyChanged("xNome")
            End Set
        End Property

        '''<remarks/>
        Public Property xFant() As String
            Get
                Return Me.xFantField
            End Get
            Set(ByVal value As String)
                Me.xFantField = Value
                Me.RaisePropertyChanged("xFant")
            End Set
        End Property

        '''<remarks/>
        Public Property fone() As String
            Get
                Return Me.foneField
            End Get
            Set(ByVal value As String)
                Me.foneField = Value
                Me.RaisePropertyChanged("fone")
            End Set
        End Property

        '''<remarks/>
        Public Property enderReme() As TEndereco
            Get
                Return Me.enderRemeField
            End Get
            Set(ByVal value As TEndereco)
                Me.enderRemeField = Value
                Me.RaisePropertyChanged("enderReme")
            End Set
        End Property

        '''<remarks/>
        Public Property email() As String
            Get
                Return Me.emailField
            End Get
            Set(ByVal value As String)
                Me.emailField = Value
                Me.RaisePropertyChanged("email")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType1

        '''<remarks/>
        CNPJ

        '''<remarks/>
        CPF
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteExped
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As String

        Private itemElementNameField As ItemChoiceType2

        Private ieField As String

        Private xNomeField As String

        Private foneField As String

        Private enderExpedField As TEndereco

        Private emailField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("CPF", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As String
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As String)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType2
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType2)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        '''<remarks/>
        Public Property IE() As String
            Get
                Return Me.ieField
            End Get
            Set(ByVal value As String)
                Me.ieField = Value
                Me.RaisePropertyChanged("IE")
            End Set
        End Property

        '''<remarks/>
        Public Property xNome() As String
            Get
                Return Me.xNomeField
            End Get
            Set(ByVal value As String)
                Me.xNomeField = Value
                Me.RaisePropertyChanged("xNome")
            End Set
        End Property

        '''<remarks/>
        Public Property fone() As String
            Get
                Return Me.foneField
            End Get
            Set(ByVal value As String)
                Me.foneField = Value
                Me.RaisePropertyChanged("fone")
            End Set
        End Property

        '''<remarks/>
        Public Property enderExped() As TEndereco
            Get
                Return Me.enderExpedField
            End Get
            Set(ByVal value As TEndereco)
                Me.enderExpedField = Value
                Me.RaisePropertyChanged("enderExped")
            End Set
        End Property

        '''<remarks/>
        Public Property email() As String
            Get
                Return Me.emailField
            End Get
            Set(ByVal value As String)
                Me.emailField = Value
                Me.RaisePropertyChanged("email")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType2

        '''<remarks/>
        CNPJ

        '''<remarks/>
        CPF
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteReceb
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As String

        Private itemElementNameField As ItemChoiceType3

        Private ieField As String

        Private xNomeField As String

        Private foneField As String

        Private enderRecebField As TEndereco

        Private emailField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("CPF", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As String
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As String)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType3
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType3)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        '''<remarks/>
        Public Property IE() As String
            Get
                Return Me.ieField
            End Get
            Set(ByVal value As String)
                Me.ieField = Value
                Me.RaisePropertyChanged("IE")
            End Set
        End Property

        '''<remarks/>
        Public Property xNome() As String
            Get
                Return Me.xNomeField
            End Get
            Set(ByVal value As String)
                Me.xNomeField = Value
                Me.RaisePropertyChanged("xNome")
            End Set
        End Property

        '''<remarks/>
        Public Property fone() As String
            Get
                Return Me.foneField
            End Get
            Set(ByVal value As String)
                Me.foneField = Value
                Me.RaisePropertyChanged("fone")
            End Set
        End Property

        '''<remarks/>
        Public Property enderReceb() As TEndereco
            Get
                Return Me.enderRecebField
            End Get
            Set(ByVal value As TEndereco)
                Me.enderRecebField = Value
                Me.RaisePropertyChanged("enderReceb")
            End Set
        End Property

        '''<remarks/>
        Public Property email() As String
            Get
                Return Me.emailField
            End Get
            Set(ByVal value As String)
                Me.emailField = Value
                Me.RaisePropertyChanged("email")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType3

        '''<remarks/>
        CNPJ

        '''<remarks/>
        CPF
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteDest
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As String

        Private itemElementNameField As ItemChoiceType4

        Private ieField As String

        Private xNomeField As String

        Private foneField As String

        Private iSUFField As String

        Private enderDestField As TEndereco

        Private emailField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("CPF", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As String
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As String)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType4
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType4)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        '''<remarks/>
        Public Property IE() As String
            Get
                Return Me.ieField
            End Get
            Set(ByVal value As String)
                Me.ieField = Value
                Me.RaisePropertyChanged("IE")
            End Set
        End Property

        '''<remarks/>
        Public Property xNome() As String
            Get
                Return Me.xNomeField
            End Get
            Set(ByVal value As String)
                Me.xNomeField = Value
                Me.RaisePropertyChanged("xNome")
            End Set
        End Property

        '''<remarks/>
        Public Property fone() As String
            Get
                Return Me.foneField
            End Get
            Set(ByVal value As String)
                Me.foneField = Value
                Me.RaisePropertyChanged("fone")
            End Set
        End Property

        '''<remarks/>
        Public Property ISUF() As String
            Get
                Return Me.iSUFField
            End Get
            Set(ByVal value As String)
                Me.iSUFField = Value
                Me.RaisePropertyChanged("ISUF")
            End Set
        End Property

        '''<remarks/>
        Public Property enderDest() As TEndereco
            Get
                Return Me.enderDestField
            End Get
            Set(ByVal value As TEndereco)
                Me.enderDestField = Value
                Me.RaisePropertyChanged("enderDest")
            End Set
        End Property

        '''<remarks/>
        Public Property email() As String
            Get
                Return Me.emailField
            End Get
            Set(ByVal value As String)
                Me.emailField = Value
                Me.RaisePropertyChanged("email")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType4

        '''<remarks/>
        CNPJ

        '''<remarks/>
        CPF
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteVPrest
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private vTPrestField As String

        Private vRecField As String

        Private compField() As TCTeInfCteVPrestComp

        '''<remarks/>
        Public Property vTPrest() As String
            Get
                Return Me.vTPrestField
            End Get
            Set(ByVal value As String)
                Me.vTPrestField = Value
                Me.RaisePropertyChanged("vTPrest")
            End Set
        End Property

        '''<remarks/>
        Public Property vRec() As String
            Get
                Return Me.vRecField
            End Get
            Set(ByVal value As String)
                Me.vRecField = Value
                Me.RaisePropertyChanged("vRec")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("Comp")> _
        Public Property Comp() As TCTeInfCteVPrestComp()
            Get
                Return Me.compField
            End Get
            Set(ByVal value As TCTeInfCteVPrestComp())
                Me.compField = Value
                Me.RaisePropertyChanged("Comp")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteVPrestComp
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private xNomeField As String

        Private vCompField As String

        '''<remarks/>
        Public Property xNome() As String
            Get
                Return Me.xNomeField
            End Get
            Set(ByVal value As String)
                Me.xNomeField = Value
                Me.RaisePropertyChanged("xNome")
            End Set
        End Property

        '''<remarks/>
        Public Property vComp() As String
            Get
                Return Me.vCompField
            End Get
            Set(ByVal value As String)
                Me.vCompField = Value
                Me.RaisePropertyChanged("vComp")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteImp
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private iCMSField As TImp

        Private vTotTribField As String

        Private infAdFiscoField As String

        Private iCMSUFFimField As TCTeInfCteImpICMSUFFim

        '''<remarks/>
        Public Property ICMS() As TImp
            Get
                Return Me.iCMSField
            End Get
            Set(ByVal value As TImp)
                Me.iCMSField = Value
                Me.RaisePropertyChanged("ICMS")
            End Set
        End Property

        '''<remarks/>
        Public Property vTotTrib() As String
            Get
                Return Me.vTotTribField
            End Get
            Set(ByVal value As String)
                Me.vTotTribField = Value
                Me.RaisePropertyChanged("vTotTrib")
            End Set
        End Property

        '''<remarks/>
        Public Property infAdFisco() As String
            Get
                Return Me.infAdFiscoField
            End Get
            Set(ByVal value As String)
                Me.infAdFiscoField = Value
                Me.RaisePropertyChanged("infAdFisco")
            End Set
        End Property

        '''<remarks/>
        Public Property ICMSUFFim() As TCTeInfCteImpICMSUFFim
            Get
                Return Me.iCMSUFFimField
            End Get
            Set(ByVal value As TCTeInfCteImpICMSUFFim)
                Me.iCMSUFFimField = Value
                Me.RaisePropertyChanged("ICMSUFFim")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteImpICMSUFFim
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private vBCUFFimField As String

        Private pICMSUFFimField As String

        Private pICMSInterField As String

        Private pICMSInterPartField As String

        Private vICMSUFFimField As String

        Private vICMSUFIniField As String

        '''<remarks/>
        Public Property vBCUFFim() As String
            Get
                Return Me.vBCUFFimField
            End Get
            Set(ByVal value As String)
                Me.vBCUFFimField = Value
                Me.RaisePropertyChanged("vBCUFFim")
            End Set
        End Property

        '''<remarks/>
        Public Property pICMSUFFim() As String
            Get
                Return Me.pICMSUFFimField
            End Get
            Set(ByVal value As String)
                Me.pICMSUFFimField = Value
                Me.RaisePropertyChanged("pICMSUFFim")
            End Set
        End Property

        '''<remarks/>
        Public Property pICMSInter() As String
            Get
                Return Me.pICMSInterField
            End Get
            Set(ByVal value As String)
                Me.pICMSInterField = Value
                Me.RaisePropertyChanged("pICMSInter")
            End Set
        End Property

        '''<remarks/>
        Public Property pICMSInterPart() As String
            Get
                Return Me.pICMSInterPartField
            End Get
            Set(ByVal value As String)
                Me.pICMSInterPartField = Value
                Me.RaisePropertyChanged("pICMSInterPart")
            End Set
        End Property

        '''<remarks/>
        Public Property vICMSUFFim() As String
            Get
                Return Me.vICMSUFFimField
            End Get
            Set(ByVal value As String)
                Me.vICMSUFFimField = Value
                Me.RaisePropertyChanged("vICMSUFFim")
            End Set
        End Property

        '''<remarks/>
        Public Property vICMSUFIni() As String
            Get
                Return Me.vICMSUFIniField
            End Get
            Set(ByVal value As String)
                Me.vICMSUFIniField = Value
                Me.RaisePropertyChanged("vICMSUFIni")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNorm
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private infCargaField As TCTeInfCteInfCTeNormInfCarga

        Private infDocField As TCTeInfCteInfCTeNormInfDoc

        Private docAntField() As TCTeInfCteInfCTeNormEmiDocAnt

        Private segField() As TCTeInfCteInfCTeNormSeg

        Private infModalField As TCTeInfCteInfCTeNormInfModal

        Private periField() As TCTeInfCteInfCTeNormPeri

        Private veicNovosField() As TCTeInfCteInfCTeNormVeicNovos

        Private cobrField As TCTeInfCteInfCTeNormCobr

        Private infCteSubField As TCTeInfCteInfCTeNormInfCteSub

        '''<remarks/>
        Public Property infCarga() As TCTeInfCteInfCTeNormInfCarga
            Get
                Return Me.infCargaField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormInfCarga)
                Me.infCargaField = value
                Me.RaisePropertyChanged("infCarga")
            End Set
        End Property

        '''<remarks/>
        Public Property infDoc() As TCTeInfCteInfCTeNormInfDoc
            Get
                Return Me.infDocField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormInfDoc)
                Me.infDocField = value
                Me.RaisePropertyChanged("infDoc")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("emiDocAnt", IsNullable:=False)> _
        Public Property docAnt() As TCTeInfCteInfCTeNormEmiDocAnt()
            Get
                Return Me.docAntField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormEmiDocAnt())
                Me.docAntField = value
                Me.RaisePropertyChanged("docAnt")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("seg")> _
        Public Property seg() As TCTeInfCteInfCTeNormSeg()
            Get
                Return Me.segField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormSeg())
                Me.segField = value
                Me.RaisePropertyChanged("seg")
            End Set
        End Property

        '''<remarks/>
        Public Property infModal() As TCTeInfCteInfCTeNormInfModal
            Get
                Return Me.infModalField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormInfModal)
                Me.infModalField = value
                Me.RaisePropertyChanged("infModal")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("peri")> _
        Public Property peri() As TCTeInfCteInfCTeNormPeri()
            Get
                Return Me.periField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormPeri())
                Me.periField = value
                Me.RaisePropertyChanged("peri")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("veicNovos")> _
        Public Property veicNovos() As TCTeInfCteInfCTeNormVeicNovos()
            Get
                Return Me.veicNovosField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormVeicNovos())
                Me.veicNovosField = value
                Me.RaisePropertyChanged("veicNovos")
            End Set
        End Property

        '''<remarks/>
        Public Property cobr() As TCTeInfCteInfCTeNormCobr
            Get
                Return Me.cobrField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormCobr)
                Me.cobrField = value
                Me.RaisePropertyChanged("cobr")
            End Set
        End Property

        '''<remarks/>
        Public Property infCteSub() As TCTeInfCteInfCTeNormInfCteSub
            Get
                Return Me.infCteSubField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormInfCteSub)
                Me.infCteSubField = value
                Me.RaisePropertyChanged("infCteSub")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfCarga
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private vCargaField As String

        Private proPredField As String

        Private xOutCatField As String

        Private infQField() As TCTeInfCteInfCTeNormInfCargaInfQ

        '''<remarks/>
        Public Property vCarga() As String
            Get
                Return Me.vCargaField
            End Get
            Set(ByVal value As String)
                Me.vCargaField = Value
                Me.RaisePropertyChanged("vCarga")
            End Set
        End Property

        '''<remarks/>
        Public Property proPred() As String
            Get
                Return Me.proPredField
            End Get
            Set(ByVal value As String)
                Me.proPredField = Value
                Me.RaisePropertyChanged("proPred")
            End Set
        End Property

        '''<remarks/>
        Public Property xOutCat() As String
            Get
                Return Me.xOutCatField
            End Get
            Set(ByVal value As String)
                Me.xOutCatField = Value
                Me.RaisePropertyChanged("xOutCat")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("infQ")> _
        Public Property infQ() As TCTeInfCteInfCTeNormInfCargaInfQ()
            Get
                Return Me.infQField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormInfCargaInfQ())
                Me.infQField = Value
                Me.RaisePropertyChanged("infQ")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfCargaInfQ
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cUnidField As TCTeInfCteInfCTeNormInfCargaInfQCUnid

        Private tpMedField As String

        Private qCargaField As String

        '''<remarks/>
        Public Property cUnid() As TCTeInfCteInfCTeNormInfCargaInfQCUnid
            Get
                Return Me.cUnidField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormInfCargaInfQCUnid)
                Me.cUnidField = Value
                Me.RaisePropertyChanged("cUnid")
            End Set
        End Property

        '''<remarks/>
        Public Property tpMed() As String
            Get
                Return Me.tpMedField
            End Get
            Set(ByVal value As String)
                Me.tpMedField = Value
                Me.RaisePropertyChanged("tpMed")
            End Set
        End Property

        '''<remarks/>
        Public Property qCarga() As String
            Get
                Return Me.qCargaField
            End Get
            Set(ByVal value As String)
                Me.qCargaField = Value
                Me.RaisePropertyChanged("qCarga")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteInfCTeNormInfCargaInfQCUnid

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("00")> _
        Item00

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("01")> _
        Item01

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("02")> _
        Item02

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("03")> _
        Item03

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("04")> _
        Item04

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("05")> _
        Item05
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfDoc
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemsField() As Object

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("infNF", GetType(TCTeInfCteInfCTeNormInfDocInfNF)), _
         System.Xml.Serialization.XmlElementAttribute("infNFe", GetType(TCTeInfCteInfCTeNormInfDocInfNFe)), _
         System.Xml.Serialization.XmlElementAttribute("infOutros", GetType(TCTeInfCteInfCTeNormInfDocInfOutros))> _
        Public Property Items() As Object()
            Get
                Return Me.itemsField
            End Get
            Set(ByVal value As Object())
                Me.itemsField = Value
                Me.RaisePropertyChanged("Items")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfDocInfNF
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private nRomaField As String

        Private nPedField As String

        Private modField As TModNF

        Private serieField As String

        Private nDocField As String

        Private dEmiField As String

        Private vBCField As String

        Private vICMSField As String

        Private vBCSTField As String

        Private vSTField As String

        Private vProdField As String

        Private vNFField As String

        Private nCFOPField As String

        Private nPesoField As String

        Private pINField As String

        Private dPrevField As String

        Private itemsField() As Object

        '''<remarks/>
        Public Property nRoma() As String
            Get
                Return Me.nRomaField
            End Get
            Set(ByVal value As String)
                Me.nRomaField = Value
                Me.RaisePropertyChanged("nRoma")
            End Set
        End Property

        '''<remarks/>
        Public Property nPed() As String
            Get
                Return Me.nPedField
            End Get
            Set(ByVal value As String)
                Me.nPedField = Value
                Me.RaisePropertyChanged("nPed")
            End Set
        End Property

        '''<remarks/>
        Public Property [mod]() As TModNF
            Get
                Return Me.modField
            End Get
            Set(ByVal value As TModNF)
                Me.modField = Value
                Me.RaisePropertyChanged("mod")
            End Set
        End Property

        '''<remarks/>
        Public Property serie() As String
            Get
                Return Me.serieField
            End Get
            Set(ByVal value As String)
                Me.serieField = Value
                Me.RaisePropertyChanged("serie")
            End Set
        End Property

        '''<remarks/>
        Public Property nDoc() As String
            Get
                Return Me.nDocField
            End Get
            Set(ByVal value As String)
                Me.nDocField = Value
                Me.RaisePropertyChanged("nDoc")
            End Set
        End Property

        '''<remarks/>
        Public Property dEmi() As String
            Get
                Return Me.dEmiField
            End Get
            Set(ByVal value As String)
                Me.dEmiField = Value
                Me.RaisePropertyChanged("dEmi")
            End Set
        End Property

        '''<remarks/>
        Public Property vBC() As String
            Get
                Return Me.vBCField
            End Get
            Set(ByVal value As String)
                Me.vBCField = Value
                Me.RaisePropertyChanged("vBC")
            End Set
        End Property

        '''<remarks/>
        Public Property vICMS() As String
            Get
                Return Me.vICMSField
            End Get
            Set(ByVal value As String)
                Me.vICMSField = Value
                Me.RaisePropertyChanged("vICMS")
            End Set
        End Property

        '''<remarks/>
        Public Property vBCST() As String
            Get
                Return Me.vBCSTField
            End Get
            Set(ByVal value As String)
                Me.vBCSTField = Value
                Me.RaisePropertyChanged("vBCST")
            End Set
        End Property

        '''<remarks/>
        Public Property vST() As String
            Get
                Return Me.vSTField
            End Get
            Set(ByVal value As String)
                Me.vSTField = Value
                Me.RaisePropertyChanged("vST")
            End Set
        End Property

        '''<remarks/>
        Public Property vProd() As String
            Get
                Return Me.vProdField
            End Get
            Set(ByVal value As String)
                Me.vProdField = Value
                Me.RaisePropertyChanged("vProd")
            End Set
        End Property

        '''<remarks/>
        Public Property vNF() As String
            Get
                Return Me.vNFField
            End Get
            Set(ByVal value As String)
                Me.vNFField = Value
                Me.RaisePropertyChanged("vNF")
            End Set
        End Property

        '''<remarks/>
        Public Property nCFOP() As String
            Get
                Return Me.nCFOPField
            End Get
            Set(ByVal value As String)
                Me.nCFOPField = Value
                Me.RaisePropertyChanged("nCFOP")
            End Set
        End Property

        '''<remarks/>
        Public Property nPeso() As String
            Get
                Return Me.nPesoField
            End Get
            Set(ByVal value As String)
                Me.nPesoField = Value
                Me.RaisePropertyChanged("nPeso")
            End Set
        End Property

        '''<remarks/>
        Public Property PIN() As String
            Get
                Return Me.pINField
            End Get
            Set(ByVal value As String)
                Me.pINField = Value
                Me.RaisePropertyChanged("PIN")
            End Set
        End Property

        '''<remarks/>
        Public Property dPrev() As String
            Get
                Return Me.dPrevField
            End Get
            Set(ByVal value As String)
                Me.dPrevField = Value
                Me.RaisePropertyChanged("dPrev")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("infUnidCarga", GetType(TUnidCarga)), _
         System.Xml.Serialization.XmlElementAttribute("infUnidTransp", GetType(TUnidadeTransp))> _
        Public Property Items() As Object()
            Get
                Return Me.itemsField
            End Get
            Set(ByVal value As Object())
                Me.itemsField = Value
                Me.RaisePropertyChanged("Items")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TModNF

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("01")> _
        Item01

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("04")> _
        Item04
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfDocInfNFe
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private chaveField As String

        Private pINField As String

        Private dPrevField As String

        Private itemsField() As Object

        '''<remarks/>
        Public Property chave() As String
            Get
                Return Me.chaveField
            End Get
            Set(ByVal value As String)
                Me.chaveField = Value
                Me.RaisePropertyChanged("chave")
            End Set
        End Property

        '''<remarks/>
        Public Property PIN() As String
            Get
                Return Me.pINField
            End Get
            Set(ByVal value As String)
                Me.pINField = Value
                Me.RaisePropertyChanged("PIN")
            End Set
        End Property

        '''<remarks/>
        Public Property dPrev() As String
            Get
                Return Me.dPrevField
            End Get
            Set(ByVal value As String)
                Me.dPrevField = Value
                Me.RaisePropertyChanged("dPrev")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("infUnidCarga", GetType(TUnidCarga)), _
         System.Xml.Serialization.XmlElementAttribute("infUnidTransp", GetType(TUnidadeTransp))> _
        Public Property Items() As Object()
            Get
                Return Me.itemsField
            End Get
            Set(ByVal value As Object())
                Me.itemsField = Value
                Me.RaisePropertyChanged("Items")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfDocInfOutros
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpDocField As TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc

        Private descOutrosField As String

        Private nDocField As String

        Private dEmiField As String

        Private vDocFiscField As String

        Private dPrevField As String

        Private itemsField() As Object

        '''<remarks/>
        Public Property tpDoc() As TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc
            Get
                Return Me.tpDocField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc)
                Me.tpDocField = Value
                Me.RaisePropertyChanged("tpDoc")
            End Set
        End Property

        '''<remarks/>
        Public Property descOutros() As String
            Get
                Return Me.descOutrosField
            End Get
            Set(ByVal value As String)
                Me.descOutrosField = Value
                Me.RaisePropertyChanged("descOutros")
            End Set
        End Property

        '''<remarks/>
        Public Property nDoc() As String
            Get
                Return Me.nDocField
            End Get
            Set(ByVal value As String)
                Me.nDocField = Value
                Me.RaisePropertyChanged("nDoc")
            End Set
        End Property

        '''<remarks/>
        Public Property dEmi() As String
            Get
                Return Me.dEmiField
            End Get
            Set(ByVal value As String)
                Me.dEmiField = Value
                Me.RaisePropertyChanged("dEmi")
            End Set
        End Property

        '''<remarks/>
        Public Property vDocFisc() As String
            Get
                Return Me.vDocFiscField
            End Get
            Set(ByVal value As String)
                Me.vDocFiscField = Value
                Me.RaisePropertyChanged("vDocFisc")
            End Set
        End Property

        '''<remarks/>
        Public Property dPrev() As String
            Get
                Return Me.dPrevField
            End Get
            Set(ByVal value As String)
                Me.dPrevField = Value
                Me.RaisePropertyChanged("dPrev")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("infUnidCarga", GetType(TUnidCarga)), _
         System.Xml.Serialization.XmlElementAttribute("infUnidTransp", GetType(TUnidadeTransp))> _
        Public Property Items() As Object()
            Get
                Return Me.itemsField
            End Get
            Set(ByVal value As Object())
                Me.itemsField = Value
                Me.RaisePropertyChanged("Items")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteInfCTeNormInfDocInfOutrosTpDoc

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("00")> _
        Item00

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("10")> _
        Item10

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("99")> _
        Item99
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormEmiDocAnt
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As String

        Private itemElementNameField As ItemChoiceType5

        Private ieField As String

        Private ufField As TUf

        Private xNomeField As String

        Private idDocAntField() As TCTeInfCteInfCTeNormEmiDocAntIdDocAnt

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("CPF", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As String
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As String)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType5
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType5)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        '''<remarks/>
        Public Property IE() As String
            Get
                Return Me.ieField
            End Get
            Set(ByVal value As String)
                Me.ieField = Value
                Me.RaisePropertyChanged("IE")
            End Set
        End Property

        '''<remarks/>
        Public Property UF() As TUf
            Get
                Return Me.ufField
            End Get
            Set(ByVal value As TUf)
                Me.ufField = Value
                Me.RaisePropertyChanged("UF")
            End Set
        End Property

        '''<remarks/>
        Public Property xNome() As String
            Get
                Return Me.xNomeField
            End Get
            Set(ByVal value As String)
                Me.xNomeField = Value
                Me.RaisePropertyChanged("xNome")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("idDocAnt")> _
        Public Property idDocAnt() As TCTeInfCteInfCTeNormEmiDocAntIdDocAnt()
            Get
                Return Me.idDocAntField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormEmiDocAntIdDocAnt())
                Me.idDocAntField = Value
                Me.RaisePropertyChanged("idDocAnt")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType5

        '''<remarks/>
        CNPJ

        '''<remarks/>
        CPF
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormEmiDocAntIdDocAnt
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemsField() As Object

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("idDocAntEle", GetType(TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntEle)), _
         System.Xml.Serialization.XmlElementAttribute("idDocAntPap", GetType(TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPap))> _
        Public Property Items() As Object()
            Get
                Return Me.itemsField
            End Get
            Set(ByVal value As Object())
                Me.itemsField = Value
                Me.RaisePropertyChanged("Items")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntEle
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private chaveField As String

        '''<remarks/>
        Public Property chave() As String
            Get
                Return Me.chaveField
            End Get
            Set(ByVal value As String)
                Me.chaveField = Value
                Me.RaisePropertyChanged("chave")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormEmiDocAntIdDocAntIdDocAntPap
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private tpDocField As TDocAssoc

        Private serieField As String

        Private subserField As String

        Private nDocField As String

        Private dEmiField As String

        '''<remarks/>
        Public Property tpDoc() As TDocAssoc
            Get
                Return Me.tpDocField
            End Get
            Set(ByVal value As TDocAssoc)
                Me.tpDocField = Value
                Me.RaisePropertyChanged("tpDoc")
            End Set
        End Property

        '''<remarks/>
        Public Property serie() As String
            Get
                Return Me.serieField
            End Get
            Set(ByVal value As String)
                Me.serieField = Value
                Me.RaisePropertyChanged("serie")
            End Set
        End Property

        '''<remarks/>
        Public Property subser() As String
            Get
                Return Me.subserField
            End Get
            Set(ByVal value As String)
                Me.subserField = Value
                Me.RaisePropertyChanged("subser")
            End Set
        End Property

        '''<remarks/>
        Public Property nDoc() As String
            Get
                Return Me.nDocField
            End Get
            Set(ByVal value As String)
                Me.nDocField = Value
                Me.RaisePropertyChanged("nDoc")
            End Set
        End Property

        '''<remarks/>
        Public Property dEmi() As String
            Get
                Return Me.dEmiField
            End Get
            Set(ByVal value As String)
                Me.dEmiField = Value
                Me.RaisePropertyChanged("dEmi")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TDocAssoc

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("00")> _
        Item00

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("01")> _
        Item01

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("02")> _
        Item02

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("03")> _
        Item03

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("04")> _
        Item04

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("05")> _
        Item05

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("06")> _
        Item06

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("07")> _
        Item07

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("08")> _
        Item08

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("09")> _
        Item09

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("10")> _
        Item10

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("11")> _
        Item11

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("12")> _
        Item12

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("99")> _
        Item99
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormSeg
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private respSegField As TCTeInfCteInfCTeNormSegRespSeg

        Private xSegField As String

        Private nApolField As String

        Private nAverField As String

        Private vCargaField As String

        '''<remarks/>
        Public Property respSeg() As TCTeInfCteInfCTeNormSegRespSeg
            Get
                Return Me.respSegField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormSegRespSeg)
                Me.respSegField = Value
                Me.RaisePropertyChanged("respSeg")
            End Set
        End Property

        '''<remarks/>
        Public Property xSeg() As String
            Get
                Return Me.xSegField
            End Get
            Set(ByVal value As String)
                Me.xSegField = Value
                Me.RaisePropertyChanged("xSeg")
            End Set
        End Property

        '''<remarks/>
        Public Property nApol() As String
            Get
                Return Me.nApolField
            End Get
            Set(ByVal value As String)
                Me.nApolField = Value
                Me.RaisePropertyChanged("nApol")
            End Set
        End Property

        '''<remarks/>
        Public Property nAver() As String
            Get
                Return Me.nAverField
            End Get
            Set(ByVal value As String)
                Me.nAverField = Value
                Me.RaisePropertyChanged("nAver")
            End Set
        End Property

        '''<remarks/>
        Public Property vCarga() As String
            Get
                Return Me.vCargaField
            End Get
            Set(ByVal value As String)
                Me.vCargaField = Value
                Me.RaisePropertyChanged("vCarga")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TCTeInfCteInfCTeNormSegRespSeg

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")> _
        Item5
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfModal
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private anyField As System.Xml.XmlElement

        Private versaoModalField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAnyElementAttribute()> _
        Public Property Any() As System.Xml.XmlElement
            Get
                Return Me.anyField
            End Get
            Set(ByVal value As System.Xml.XmlElement)
                Me.anyField = Value
                Me.RaisePropertyChanged("Any")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property versaoModal() As String
            Get
                Return Me.versaoModalField
            End Get
            Set(ByVal value As String)
                Me.versaoModalField = Value
                Me.RaisePropertyChanged("versaoModal")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormPeri
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private nONUField As String

        Private xNomeAEField As String

        Private xClaRiscoField As String

        Private grEmbField As String

        Private qTotProdField As String

        Private qVolTipoField As String

        Private pontoFulgorField As String

        '''<remarks/>
        Public Property nONU() As String
            Get
                Return Me.nONUField
            End Get
            Set(ByVal value As String)
                Me.nONUField = Value
                Me.RaisePropertyChanged("nONU")
            End Set
        End Property

        '''<remarks/>
        Public Property xNomeAE() As String
            Get
                Return Me.xNomeAEField
            End Get
            Set(ByVal value As String)
                Me.xNomeAEField = Value
                Me.RaisePropertyChanged("xNomeAE")
            End Set
        End Property

        '''<remarks/>
        Public Property xClaRisco() As String
            Get
                Return Me.xClaRiscoField
            End Get
            Set(ByVal value As String)
                Me.xClaRiscoField = Value
                Me.RaisePropertyChanged("xClaRisco")
            End Set
        End Property

        '''<remarks/>
        Public Property grEmb() As String
            Get
                Return Me.grEmbField
            End Get
            Set(ByVal value As String)
                Me.grEmbField = Value
                Me.RaisePropertyChanged("grEmb")
            End Set
        End Property

        '''<remarks/>
        Public Property qTotProd() As String
            Get
                Return Me.qTotProdField
            End Get
            Set(ByVal value As String)
                Me.qTotProdField = Value
                Me.RaisePropertyChanged("qTotProd")
            End Set
        End Property

        '''<remarks/>
        Public Property qVolTipo() As String
            Get
                Return Me.qVolTipoField
            End Get
            Set(ByVal value As String)
                Me.qVolTipoField = Value
                Me.RaisePropertyChanged("qVolTipo")
            End Set
        End Property

        '''<remarks/>
        Public Property pontoFulgor() As String
            Get
                Return Me.pontoFulgorField
            End Get
            Set(ByVal value As String)
                Me.pontoFulgorField = Value
                Me.RaisePropertyChanged("pontoFulgor")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormVeicNovos
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private chassiField As String

        Private cCorField As String

        Private xCorField As String

        Private cModField As String

        Private vUnitField As String

        Private vFreteField As String

        '''<remarks/>
        Public Property chassi() As String
            Get
                Return Me.chassiField
            End Get
            Set(ByVal value As String)
                Me.chassiField = Value
                Me.RaisePropertyChanged("chassi")
            End Set
        End Property

        '''<remarks/>
        Public Property cCor() As String
            Get
                Return Me.cCorField
            End Get
            Set(ByVal value As String)
                Me.cCorField = Value
                Me.RaisePropertyChanged("cCor")
            End Set
        End Property

        '''<remarks/>
        Public Property xCor() As String
            Get
                Return Me.xCorField
            End Get
            Set(ByVal value As String)
                Me.xCorField = Value
                Me.RaisePropertyChanged("xCor")
            End Set
        End Property

        '''<remarks/>
        Public Property cMod() As String
            Get
                Return Me.cModField
            End Get
            Set(ByVal value As String)
                Me.cModField = Value
                Me.RaisePropertyChanged("cMod")
            End Set
        End Property

        '''<remarks/>
        Public Property vUnit() As String
            Get
                Return Me.vUnitField
            End Get
            Set(ByVal value As String)
                Me.vUnitField = Value
                Me.RaisePropertyChanged("vUnit")
            End Set
        End Property

        '''<remarks/>
        Public Property vFrete() As String
            Get
                Return Me.vFreteField
            End Get
            Set(ByVal value As String)
                Me.vFreteField = Value
                Me.RaisePropertyChanged("vFrete")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormCobr
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private fatField As TCTeInfCteInfCTeNormCobrFat

        Private dupField() As TCTeInfCteInfCTeNormCobrDup

        '''<remarks/>
        Public Property fat() As TCTeInfCteInfCTeNormCobrFat
            Get
                Return Me.fatField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormCobrFat)
                Me.fatField = Value
                Me.RaisePropertyChanged("fat")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("dup")> _
        Public Property dup() As TCTeInfCteInfCTeNormCobrDup()
            Get
                Return Me.dupField
            End Get
            Set(ByVal value As TCTeInfCteInfCTeNormCobrDup())
                Me.dupField = Value
                Me.RaisePropertyChanged("dup")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormCobrFat
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private nFatField As String

        Private vOrigField As String

        Private vDescField As String

        Private vLiqField As String

        '''<remarks/>
        Public Property nFat() As String
            Get
                Return Me.nFatField
            End Get
            Set(ByVal value As String)
                Me.nFatField = Value
                Me.RaisePropertyChanged("nFat")
            End Set
        End Property

        '''<remarks/>
        Public Property vOrig() As String
            Get
                Return Me.vOrigField
            End Get
            Set(ByVal value As String)
                Me.vOrigField = Value
                Me.RaisePropertyChanged("vOrig")
            End Set
        End Property

        '''<remarks/>
        Public Property vDesc() As String
            Get
                Return Me.vDescField
            End Get
            Set(ByVal value As String)
                Me.vDescField = Value
                Me.RaisePropertyChanged("vDesc")
            End Set
        End Property

        '''<remarks/>
        Public Property vLiq() As String
            Get
                Return Me.vLiqField
            End Get
            Set(ByVal value As String)
                Me.vLiqField = Value
                Me.RaisePropertyChanged("vLiq")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormCobrDup
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private nDupField As String

        Private dVencField As String

        Private vDupField As String

        '''<remarks/>
        Public Property nDup() As String
            Get
                Return Me.nDupField
            End Get
            Set(ByVal value As String)
                Me.nDupField = Value
                Me.RaisePropertyChanged("nDup")
            End Set
        End Property

        '''<remarks/>
        Public Property dVenc() As String
            Get
                Return Me.dVencField
            End Get
            Set(ByVal value As String)
                Me.dVencField = Value
                Me.RaisePropertyChanged("dVenc")
            End Set
        End Property

        '''<remarks/>
        Public Property vDup() As String
            Get
                Return Me.vDupField
            End Get
            Set(ByVal value As String)
                Me.vDupField = Value
                Me.RaisePropertyChanged("vDup")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfCteSub
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private chCteField As String

        Private itemField As Object

        '''<remarks/>
        Public Property chCte() As String
            Get
                Return Me.chCteField
            End Get
            Set(ByVal value As String)
                Me.chCteField = Value
                Me.RaisePropertyChanged("chCte")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("tomaICMS", GetType(TCTeInfCteInfCTeNormInfCteSubTomaICMS)), _
         System.Xml.Serialization.XmlElementAttribute("tomaNaoICMS", GetType(TCTeInfCteInfCTeNormInfCteSubTomaNaoICMS))> _
        Public Property Item() As Object
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As Object)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfCteSubTomaICMS
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As Object

        Private itemElementNameField As ItemChoiceType7

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("refCte", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("refNF", GetType(TCTeInfCteInfCTeNormInfCteSubTomaICMSRefNF)), _
         System.Xml.Serialization.XmlElementAttribute("refNFe", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As Object
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As Object)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType7
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType7)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfCteSubTomaICMSRefNF
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As String

        Private itemElementNameField As ItemChoiceType6

        Private modField As TModDoc

        Private serieField As String

        Private subserieField As String

        Private nroField As String

        Private valorField As String

        Private dEmiField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("CPF", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As String
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As String)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType6
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType6)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        '''<remarks/>
        Public Property [mod]() As TModDoc
            Get
                Return Me.modField
            End Get
            Set(ByVal value As TModDoc)
                Me.modField = Value
                Me.RaisePropertyChanged("mod")
            End Set
        End Property

        '''<remarks/>
        Public Property serie() As String
            Get
                Return Me.serieField
            End Get
            Set(ByVal value As String)
                Me.serieField = Value
                Me.RaisePropertyChanged("serie")
            End Set
        End Property

        '''<remarks/>
        Public Property subserie() As String
            Get
                Return Me.subserieField
            End Get
            Set(ByVal value As String)
                Me.subserieField = Value
                Me.RaisePropertyChanged("subserie")
            End Set
        End Property

        '''<remarks/>
        Public Property nro() As String
            Get
                Return Me.nroField
            End Get
            Set(ByVal value As String)
                Me.nroField = Value
                Me.RaisePropertyChanged("nro")
            End Set
        End Property

        '''<remarks/>
        Public Property valor() As String
            Get
                Return Me.valorField
            End Get
            Set(ByVal value As String)
                Me.valorField = Value
                Me.RaisePropertyChanged("valor")
            End Set
        End Property

        '''<remarks/>
        Public Property dEmi() As String
            Get
                Return Me.dEmiField
            End Get
            Set(ByVal value As String)
                Me.dEmiField = Value
                Me.RaisePropertyChanged("dEmi")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType6

        '''<remarks/>
        CNPJ

        '''<remarks/>
        CPF
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Public Enum TModDoc

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("01")> _
        Item01

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1B")> _
        Item1B

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("02")> _
        Item02

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2D")> _
        Item2D

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2E")> _
        Item2E

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("04")> _
        Item04

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("06")> _
        Item06

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("07")> _
        Item07

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("08")> _
        Item08

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8B")> _
        Item8B

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("09")> _
        Item09

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("10")> _
        Item10

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("11")> _
        Item11

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("13")> _
        Item13

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("14")> _
        Item14

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("15")> _
        Item15

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("16")> _
        Item16

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("17")> _
        Item17

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("18")> _
        Item18

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("20")> _
        Item20

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("21")> _
        Item21

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("22")> _
        Item22

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("23")> _
        Item23

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("24")> _
        Item24

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("25")> _
        Item25

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("26")> _
        Item26

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("27")> _
        Item27

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("28")> _
        Item28

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("55")> _
        Item55
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType7

        '''<remarks/>
        refCte

        '''<remarks/>
        refNF

        '''<remarks/>
        refNFe
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCTeNormInfCteSubTomaNaoICMS
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private refCteAnuField As String

        '''<remarks/>
        Public Property refCteAnu() As String
            Get
                Return Me.refCteAnuField
            End Get
            Set(ByVal value As String)
                Me.refCteAnuField = Value
                Me.RaisePropertyChanged("refCteAnu")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCteAnu
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private chCteField As String

        Private dEmiField As String

        '''<remarks/>
        Public Property chCte() As String
            Get
                Return Me.chCteField
            End Get
            Set(ByVal value As String)
                Me.chCteField = Value
                Me.RaisePropertyChanged("chCte")
            End Set
        End Property

        '''<remarks/>
        Public Property dEmi() As String
            Get
                Return Me.dEmiField
            End Get
            Set(ByVal value As String)
                Me.dEmiField = Value
                Me.RaisePropertyChanged("dEmi")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteInfCteComp
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private chaveField As String

        '''<remarks/>
        Public Property chave() As String
            Get
                Return Me.chaveField
            End Get
            Set(ByVal value As String)
                Me.chaveField = Value
                Me.RaisePropertyChanged("chave")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/cte")> _
    Partial Public Class TCTeInfCteAutXML
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private itemField As String

        Private itemElementNameField As ItemChoiceType8

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("CNPJ", GetType(String)), _
         System.Xml.Serialization.XmlElementAttribute("CPF", GetType(String)), _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")> _
        Public Property Item() As String
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As String)
                Me.itemField = Value
                Me.RaisePropertyChanged("Item")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property ItemElementName() As ItemChoiceType8
            Get
                Return Me.itemElementNameField
            End Get
            Set(ByVal value As ItemChoiceType8)
                Me.itemElementNameField = Value
                Me.RaisePropertyChanged("ItemElementName")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/cte", IncludeInSchema:=False)> _
    Public Enum ItemChoiceType8

        '''<remarks/>
        CNPJ

        '''<remarks/>
        CPF
    End Enum
End Namespace
