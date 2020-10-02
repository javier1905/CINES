pe="StringLocIDType" minOccurs="0"/>
         <xsd:element name="LinkToChild" type="xsd:string" minOccurs="0"/>
         <xsd:element name="Bookmark" type="xsd:string" minOccurs="0"/>
         <xsd:element name="RepeatWith" type="xsd:string" minOccurs="0"/>
         <xsd:element name="CustomProperties" type="CustomPropertiesType" minOccurs="0"/>
         <xsd:element name="ReportItems" type="ReportItemsType" minOccurs="0"/>
         <xsd:element name="PageBreak" type="PageBreakType" minOccurs="0"/>
         <xsd:element name="PageName" type="xsd:string" minOccurs="0"/>
         <xsd:element name="KeepTogether" type="xsd:boolean" minOccurs="0"/>
         <xsd:element name="OmitBorderOnPageBreak" type="xsd:boolean" minOccurs="0"/>
         <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
         <xsd:element name="DataElementOutput" minOccurs="0">
            <xsd:simpleType>
               <xsd:restriction base="xsd:string">
                  <xsd:enumeration value="Output"/>
                  <xsd:enumeration value="NoOutput"/>
                  <xsd:enumeration value="ContentsOnly"/>
                  <xsd:enumeration value="Auto"/>
               </xsd:restriction>
            </xsd:simpleType>
         </xsd:element>
         <xsd:any namespace="##other" processContents="lax"/>
      </xsd:choice>
      <xsd:attribute name="Name" type="xsd:normalizedString" use="required"/>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="TextboxType">
      <xsd:choice minOccurs="1" maxOccurs="unbounded">
         <xsd:element name="Style" type="StyleType" minOccurs="0"/>
         <xsd:element name="ActionInfo" type="ActionInfoType" minOccurs="0"/>
         <xsd:element name="Top" type="SizeType" minOccurs="0"/>
         <xsd:element name="Left" type="SizeType" minOccurs="0"/>
         <xsd:element name="Height" type="SizeType" minOccurs="0"/>
         <xsd:element name="Width" type="SizeType" minOccurs="0"/>
         <xsd:element name="ZIndex" type="xsd:unsignedInt" minOccurs="0"/>
         <xsd:element name="Visibility" type="VisibilityType" minOccurs="0"/>
         <xsd:element name="ToolTip" type="StringLocIDType" minOccurs="0"/>
         <xsd:element name="DocumentMapLabel" type="StringLocIDType" minOccurs="0"/>
         <xsd:element name="Bookmark" type="xsd:string" minOccurs="0"/>
         <xsd:element name="RepeatWith" type="xsd:string" minOccurs="0"/>
         <xsd:element name="CustomProperties" type="CustomPropertiesType" minOccurs="0"/>
         <xsd:element name="Paragraphs" type="ParagraphsType" minOccurs="1"/>
         <xsd:element name="CanGrow" type="xsd:boolean" minOccurs="0"/>
         <xsd:element name="CanShrink" type="xsd:boolean" minOccurs="0"/>
         <xsd:element name="HideDuplicates" type="xsd:string" minOccurs="0"/>
         <xsd:element name="ToggleImage" type="ToggleImageType" minOccurs="0"/>
         <xsd:element name="UserSort" type="UserSortType" minOccurs="0"/>
         <xsd:element name="KeepTogether" type="xsd:boolean" minOccurs="0"/>
         <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
         <xsd:element name="DataElementOutput" minOccurs="0">
            <xsd:simpleType>
               <xsd:restriction base="xsd:string">
                  <xsd:enumeration value="Output"/>
                  <xsd:enumeration value="NoOutput"/>
                  <xsd:enumeration value="ContentsOnly"/>
                  <xsd:enumeration value="Auto"/>
               </xsd:restriction>
            </xsd:simpleType>
         </xsd:element>
         <xsd:element name="DataElementStyle" minOccurs="0">
            <xsd:simpleType>
               <xsd:restriction base="xsd:string">
                  <xsd:enumeration value="Auto"/>
                  <xsd:enumeration value="Attribute"/>
                  <xsd:enumeration value="Element"/>
               </xsd:restriction>
            </xsd:simpleType>
         </xsd:element>
         <xsd:any namespace="##other" processContents="lax"/>
      </xsd:choice>
      <xsd:attribute name="Name" type="xsd:normalizedString" use="required"/>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="ParagraphsType">
      <xsd:sequence>
         <xsd:element name="Paragraph" type="ParagraphType" minOccurs="1" maxOccurs="unbounded"/>
      </xsd:sequence>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="ParagraphType">
      <xsd:choice minOccurs="0" maxOccurs="unbounded">
         <xsd:element name="Style" type="StyleType" minOccurs="0"/>
         <xsd:element name="TextRuns" type="TextRunsType" minOccurs="1"/>
         <xsd:element name="LeftIndent" type="xsd:string" minOccurs="0"/>
         <xsd:element name="RightIndent" type="xsd:string" minOccurs="0"/>
         <xsd:element name="HangingIndent" type="xsd:string" minOccurs="0"/>
         <xsd:element name="ListStyle" minOccurs="0">
				    <xsd:simpleType>
					    <xsd:restriction base="xsd:string">
						     <xsd:enumeration value="None"/>
						     <xsd:enumeration value="Bulleted"/>
						     <xsd:enumeration value="Numbered"/>
					     </xsd:restriction>
				    </xsd:simpleType>
				 </xsd:element>
         <xsd:element name="ListLevel" type="xsd:unsignedInt" minOccurs="0"/>
         <xsd:element name="SpaceBefore" type="xsd:string" minOccurs="0"/>
         <xsd:element name="SpaceAfter" type="xsd:string" minOccurs="0"/>
         <xsd:any namespace="##other" processContents="lax"/>
      </xsd:choice>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="TextRunsType">
      <xsd:sequence>
         <xsd:element name="TextRun" type="TextRunType" minOccurs="1" maxOccurs="unbounded"/>
      </xsd:sequence>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="TextRunType">
      <xsd:choice minOccurs="0" maxOccurs="unbounded">
         <xsd:element name="Style" type="StyleType" minOccurs="0"/>
         <xsd:element name="Value" type="LocIDStringWithDataTypeAttribute" minOccurs="1"/>
         <xsd:element name="Label" type="xsd:string" minOccurs="0"/>
         <xsd:element name="ActionInfo" type="ActionInfoType" minOccurs="0"/>
         <xsd:element name="ToolTip" type="xsd:string" minOccurs="0"/>
         <xsd:element name="MarkupType" type="xsd:string" minOccurs="0"/>
         <xsd:any namespace="##other" processContents="lax"/>
      </xsd:choice>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="ToggleImageType">
      <xsd:choice minOccurs="1" maxOccurs="unbounded">
         <xsd:element name="InitialState" type="xsd:string"/>
         <xsd:any namespace="##other" processContents="lax"/>
      </xsd:choice>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="ImageType">
      <xsd:choice minOccurs="1" maxOccurs="unbounded">
         <xsd:element name="Style" type="StyleType" minOccurs="0"/>
         <xsd:element name="ActionInfo" type="ActionInfoType" minOccurs="0"/>
         <xsd:element name="Top" type="SizeType" minOccurs="0"/>
         <xsd:element name="Left" type="SizeType" minOccurs="0"/>
         <xsd:element name="Height" type="SizeType" minOccurs="0"/>
         <xsd:element name="Width" type="SizeType" minOccurs="0"/>
         <xsd:element name="ZIndex" type="xsd:unsignedInt" minOccurs="0"/>
         <xsd:element name="Visibility" type="VisibilityType" minOccurs="0"/>
         <xsd:element name="ToolTip" type="StringLocIDType" minOccurs="0"/>
         <xsd:element name="DocumentMapLabel" type="StringLocIDType" minOccurs="0"/>
         <xsd:element name="Bookmark" type="xsd:string" minOccurs="0"/>
         <xsd:element name="RepeatWith" type="xsd:string" minOccurs="0"/>
         <xsd:element name="CustomProperties" type="CustomPropertiesType" minOccurs="0"/>
         <xsd:element name="Source">
            <xsd:simpleType>
               <xsd:restriction base="xsd:string">
                  <xsd:enumeration value="External"/>
                  <xsd:enumeration value="Embedded"/>
                  <xsd:enumeration value="Database"/>
               </xsd:restriction>
            </xsd:simpleType>
         </xsd:element>
         <xsd:element name="Value" type="xsd:string"/>
         <xsd:element name="MIMEType" type="xsd:string" minOccurs="0"/>
         <xsd:element name="Sizing" minOccurs="0">
            <xsd:simpleType>
               <xsd:restriction base="xsd:string">
                  <xsd:enumeration value="AutoSize"/>
                  <xsd:enumeration value="Fit"/>
                  <xsd:enumeration value="FitProportional"/>
                  <xsd:enumeration value="Clip"/>
               </xsd:restriction>
            </xsd:simpleType>
         </xsd:element>
         <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
         <xsd:element name="DataElementOutput" minOccurs="0">
            <xsd:simpleType>
               <xsd:restriction base="xsd:string">
                  <xsd:enumeration value="Output"/>
                  <xsd:enumeration value="NoOutput"/>
                  <xsd:enumeration value="ContentsOnly"/>
                  <xsd:enumeration value="Auto"/>
               </xsd:restriction>
            </xsd:simpleType>
         </xsd:element>
         <xsd:any namespace="##other" processContents="lax"/>
      </xsd:choice>
      <xsd:attribute name="Name" type="xsd:normalizedString" use="required"/>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="SubreportType">
      <xsd:choice minOccurs="1" maxOccurs="unbounded">
         <xsd:element name="Style" type="StyleType" minOccurs="0"/>
         <xsd:element name="ActionInfo" type="ActionInfoType" minOccurs="0"/>
         <xsd:element name="Top" type="SizeType" minOccurs="0"/>
         <xsd:element name="Left" type="SizeType" minOccurs="0"/>
         <xsd:element name="Height" type="SizeType" minOccurs="0"/>
         <xsd:element name="Width" type="SizeType" minOccurs="0"/>
         <xsd:element name="ZIndex" type="xsd:unsignedInt" minOccurs="0"/>
         <xsd:element name="Visibility" type="VisibilityType" minOccurs="0"/>
         <xsd:element name="ToolTip" type="StringLocIDType" minOccurs="0"/>
         <xsd:element name="DocumentMapLabel" type="StringLocIDType" minOccurs="0"/>
         <xsd:element name="Bookmark" type="xsd:string" minOccurs="0"/>
         <xsd:element name="RepeatWith" type="xsd:string" minOccurs="0"/>
         <xsd:element name="CustomProperties" type="CustomPropertiesType" minOccurs="0"/>
         <xsd:element name="ReportName" type="xsd:string"/>
         <xsd:element name="Parameters" type="ParametersType" minOccurs="0"/>
         <xsd:element name="NoRowsMessage" type="xsd:string" minOccurs="0"/>
         <xsd:element name="MergeTransactions" type="xsd:boolean" minOccurs="0"/>
         <xsd:element name="KeepTogether" type="xsd:boolean" minOccurs="0"/>
         <xsd:element name="OmitBorderOnPageBreak" type="xsd:boolean" minOccurs="0"/>
         <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
         <xsd:element name="DataElementOutput" minOccurs="0">
            <xsd:simpleType>
               <xsd:restriction base="xsd:string">
                  <xsd:enumeration value="Output"/>
                  <xsd:enumeration value="NoOutput"/>
                  <xsd:enumeration value="ContentsOnly"/>
                  <xsd:enumeration value="Auto"/>
               </xsd:restriction>
            </xsd:simpleType>
         </xsd:element>
         <xsd:any namespace="##other" processContents="lax"/>
      </xsd:choice>
  