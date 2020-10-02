hoice minOccurs="0" maxOccurs="unbounded">
         <xsd:element name="Enabled" type="xsd:string" minOccurs="0"/>
         <xsd:element name="ProjectionMode" type="xsd:string" minOccurs="0"/>
         <xsd:element name="Rotation" type="xsd:string" minOccurs="0"/>
         <xsd:element name="Inclination" type="xsd:string" minOccurs="0"/>
         <xsd:element name="Perspective" type="xsd:string" minOccurs="0"/>
         <xsd:element name="DepthRatio" type="xsd:string" minOccurs="0"/>
         <xsd:element name="Shading" type="xsd:string" minOccurs="0"/>
         <xsd:element name="GapDepth" type="xsd:string" minOccurs="0"/>
         <xsd:element name="WallThickness" type="xsd:string" minOccurs="0"/>
         <xsd:element name="Clustered" type="xsd:string" minOccurs="0"/>
         <xsd:any namespace="##other" processContents="lax"/>
      </xsd:choice>
      <xsd:anyAttribute namespace="##other" processContents="lax"/>
   </xsd:complexType>
   <xsd:complexType name="ChartGridLinesType">
      <xsd:choice minOccurs="0" maxOccurs="unbounded">
         <xsd:element name="Enabled" type="xsd:string" minOccurs="0"/>
         <xsd:element name="Style" type="StyleType" minOccurs="0"/>