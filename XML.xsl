<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/Books">
    <BookList>
      <xsl:apply-templates select="Book"/>
    </BookList>
  </xsl:template>

  <xsl:template match="Book">
    <Default>
      <Author>
        <xsl:value-of select="Author" />
      </Author>
      <Name>
        <xsl:value-of select="Name" />
      </Name>
      <PublishingOffice>
        <xsl:value-of select="PublishingOffice" />
      </PublishingOffice>
    </Default>
    <Genre>
      <xsl:value-of select="Genre" />
    </Genre>
    <Period>
      <xsl:value-of select="Period" />
    </Period>
    <Person>
      <xsl:value-of select="Person" />
    </Person>
    <Years>
      <xsl:value-of select="Years" />
    </Years>
    <Type>
      <xsl:value-of select="Type" />
    </Type>
    <Age>
      <xsl:value-of select="Age" />
    </Age>
    <CoAuthors>
      <xsl:value-of select="CoAuthors" />
    </CoAuthors>
    <IsIllustrated>
      <xsl:value-of select="IsIllustrated" />
    </IsIllustrated>
  </xsl:template>

</xsl:stylesheet>