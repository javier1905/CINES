amespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapBucketType">
    <xsd:choice maxOccurs="unbounded">
      <xsd:element name="StartValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="EndValue" type="xsd:string" minOccurs="0"/>
      <xsd:any namespace="##other" processContents="lax"/>
    </xsd:choice>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapColorRangeRuleType">
    <xsd:choice maxOccurs="unbounded">
    <!--MapAppearanceRule Start-->
    <xsd:element name="DataValue" type="xsd:string" minOccurs="0"/>
    <xsd:element name="DistributionType" type="xsd:string" minOccurs="0"/>
    <xsd:element name="BucketCount" type="xsd:string" minOccurs="0"/>
    <xsd:element name="StartValue" type="xsd:string" minOccurs="0"/>
    <xsd:element name="EndValue" type="xsd:string" minOccurs="0"/>
    <xsd:element name="MapBuckets" type="MapBucketsType" minOccurs="0"/>
    <xsd:element name="LegendName" type="xsd:string" minOccurs="0"/>
    <xsd:element name="LegendText" type="xsd:string" minOccurs="0"/>
    <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementOutput" minOccurs="0">
        <xsd:simpleType>
          <xsd:restriction base="xsd:string">
            <xsd:enumeration value="Output"/>
            <xsd:enumeration value="NoOutput"/>
          </xsd:restriction>
        </xsd:simpleType>
      </xsd:element>
    <!--MapAppearanceRule End-->
    <!--MapColorRule Start-->
    <xsd:element name="ShowInColorScale" type="xsd:string" minOccurs="0"/>
    <!--MapColorRule End-->
    <xsd:element name="StartColor" type="xsd:string" minOccurs="0"/>
    <xsd:element name="MiddleColor" type="xsd:string" minOccurs="0"/>
    <xsd:element name="EndColor" type="xsd:string" minOccurs="0"/>
    <xsd:any namespace="##other" processContents="lax"/>
    </xsd:choice>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapColorPaletteRuleType">
    <xsd:choice maxOccurs="unbounded">
      <!--MapAppearanceRule Start-->
      <xsd:element name="DataValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DistributionType" type="xsd:string" minOccurs="0"/>
      <xsd:element name="BucketCount" type="xsd:string" minOccurs="0"/>
      <xsd:element name="StartValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="EndValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="MapBuckets" type="MapBucketsType" minOccurs="0"/>
      <xsd:element name="LegendName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="LegendText" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementOutput" minOccurs="0">
        <xsd:simpleType>
          <xsd:restriction base="xsd:string">
            <xsd:enumeration value="Output"/>
            <xsd:enumeration value="NoOutput"/>
          </xsd:restriction>
        </xsd:simpleType>
      </xsd:element>
      <!--MapAppearanceRule End-->
      <!--MapColorRule Start-->
      <xsd:element name="ShowInColorScale" type="xsd:string" minOccurs="0"/>
      <!--MapColorRule End-->
      <xsd:element name="Palette" type="xsd:string" minOccurs="0"/>
       <xsd:any namespace="##other" processContents="lax"/>
    </xsd:choice>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapCustomColorRuleType">
    <xsd:choice maxOccurs="unbounded">
      <!--MapAppearanceRule Start-->
      <xsd:element name="DataValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DistributionType" type="xsd:string" minOccurs="0"/>
      <xsd:element name="BucketCount" type="xsd:string" minOccurs="0"/>
      <xsd:element name="StartValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="EndValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="MapBuckets" type="MapBucketsType" minOccurs="0"/>
      <xsd:element name="LegendName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="LegendText" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementOutput" minOccurs="0">
        <xsd:simpleType>
          <xsd:restriction base="xsd:string">
            <xsd:enumeration value="Output"/>
            <xsd:enumeration value="NoOutput"/>
          </xsd:restriction>
        </xsd:simpleType>
      </xsd:element>
      <!--MapAppearanceRule End-->
      <!--MapColorRule Start-->
      <xsd:element name="ShowInColorScale" type="xsd:string" minOccurs="0"/>
      <!--MapColorRule End-->
      <xsd:element name="MapCustomColors" type="MapCustomColorsType" minOccurs="1"/>
      <xsd:any namespace="##other" processContents="lax"/>
    </xsd:choice>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapCustomColorsType">
    <xsd:sequence>
      <xsd:element name="MapCustomColor" type="xsd:string" minOccurs="1" maxOccurs="unbounded"/>
    </xsd:sequence>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>


  <xsd:complexType name="MapSizeRuleType">
    <xsd:choice maxOccurs="unbounded">
      <!--MapAppearanceRule Start-->
      <xsd:element name="DataValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DistributionType" type="xsd:string" minOccurs="0"/>
      <xsd:element name="BucketCount" type="xsd:string" minOccurs="0"/>
      <xsd:element name="StartValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="EndValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="MapBuckets" type="MapBucketsType" minOccurs="0"/>
      <xsd:element name="LegendName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="LegendText" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementOutput" minOccurs="0">
        <xsd:simpleType>
          <xsd:restriction base="xsd:string">
            <xsd:enumeration value="Output"/>
            <xsd:enumeration value="NoOutput"/>
          </xsd:restriction>
        </xsd:simpleType>
      </xsd:element>
      <!--MapAppearanceRule End-->
      <xsd:element name="StartSize" type="xsd:string" minOccurs="1"/>
      <xsd:element name="EndSize" type="xsd:string" minOccurs="1"/>
      <xsd:any namespace="##other" processContents="lax"/>
    </xsd:choice>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapMarkerRuleType">
    <xsd:choice maxOccurs="unbounded">
      <!--MapAppearanceRule Start-->
      <xsd:element name="DataValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DistributionType" type="xsd:string" minOccurs="0"/>
      <xsd:element name="BucketCount" type="xsd:string" minOccurs="0"/>
      <xsd:element name="StartValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="EndValue" type="xsd:string" minOccurs="0"/>
      <xsd:element name="MapBuckets" type="MapBucketsType" minOccurs="0"/>
      <xsd:element name="LegendName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="LegendText" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementName" type="xsd:string" minOccurs="0"/>
      <xsd:element name="DataElementOutput" minOccurs="0">
        <xsd:simpleType>
          <xsd:restriction base="xsd:string">
            <xsd:enumeration value="Output"/>
            <xsd:enumeration value="NoOutput"/>
          </xsd:restriction>
        </xsd:simpleType>
      </xsd:element>
      <!--MapAppearanceRule End-->
      <xsd:element name="MapMarkers" type="MapMarkersType" minOccurs="1"/>
      <xsd:any namespace="##other" processContents="lax"/>
    </xsd:choice>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapMarkersType">
    <xsd:sequence>
      <xsd:element name="MapMarker" type="MapMarkerType" minOccurs="1" maxOccurs="unbounded"/>
    </xsd:sequence>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapMarkerType">
    <xsd:choice maxOccurs="unbounded">
      <xsd:element name="MapMarkerStyle" type="xsd:string" minOccurs="0"/>
      <xsd:element name="MapMarkerImage" type="MapMarkerImageType" minOccurs="0"/>
      <xsd:any namespace="##other" processContents="lax"/>
    </xsd:choice>
    <xsd:anyAttribute namespace="##other" processContents="lax"/>
  </xsd:complexType>

  <xsd:complexType name="MapMa