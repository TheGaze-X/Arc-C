using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	internal class DtdParser : IDtdParser
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x4FC8C60", Offset = "0x4FC7860", VA = "0x184FC8C60")]
		private DtdParser()
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x4FBCF50", Offset = "0x4FBBB50", VA = "0x184FBCF50")]
		internal static IDtdParser Create()
		{
			return null;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x4FBEFB0", Offset = "0x4FBDBB0", VA = "0x184FBEFB0")]
		private void Initialize(IDtdParserAdapter readerAdapter)
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x4FBEBB0", Offset = "0x4FBD7B0", VA = "0x184FBEBB0")]
		private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x4FC80D0", Offset = "0x4FC6CD0", VA = "0x184FC80D0", Slot = "4")]
		private IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
		{
			return null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x4FC8080", Offset = "0x4FC6C80", VA = "0x184FC8080", Slot = "5")]
		private IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			return null;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x170001AE")]
		private bool ParsingInternalSubset
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x4FC8EF0", Offset = "0x4FC7AF0", VA = "0x184FC8EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x170001AF")]
		private bool IgnoreEntityReferences
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x4FC8E30", Offset = "0x4FC7A30", VA = "0x184FC8E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x170001B0")]
		private bool SaveInternalSubsetValue
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x4FC8F20", Offset = "0x4FC7B20", VA = "0x184FC8F20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x170001B1")]
		private bool ParsingTopLevelMarkup
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x4FC8F00", Offset = "0x4FC7B00", VA = "0x184FC8F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x170001B2")]
		private bool SupportNamespaces
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x4FC8F80", Offset = "0x4FC7B80", VA = "0x184FC8F80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x170001B3")]
		private bool Normalize
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x4FC2970", Offset = "0x4FC1570", VA = "0x184FC2970")]
		private void Parse(bool saveInternalSubset)
		{
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x4FC1EB0", Offset = "0x4FC0AB0", VA = "0x184FC1EB0")]
		private void ParseInDocumentDtd(bool saveInternalSubset)
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x4FC1DE0", Offset = "0x4FC09E0", VA = "0x184FC1DE0")]
		private void ParseFreeFloatingDtd()
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x4FC2030", Offset = "0x4FC0C30", VA = "0x184FC2030")]
		private void ParseInternalSubset()
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x4FC1C20", Offset = "0x4FC0820", VA = "0x184FC1C20")]
		private void ParseExternalSubset()
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x4FC2370", Offset = "0x4FC0F70", VA = "0x184FC2370")]
		private void ParseSubset()
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x4FBF470", Offset = "0x4FBE070", VA = "0x184FBF470")]
		private void ParseAttlistDecl()
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x4FBFCB0", Offset = "0x4FBE8B0", VA = "0x184FBFCB0")]
		private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x4FBFA60", Offset = "0x4FBE660", VA = "0x184FBFA60")]
		private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x4FC07B0", Offset = "0x4FBF3B0", VA = "0x184FC07B0")]
		private void ParseElementDecl()
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x4FC0EF0", Offset = "0x4FBFAF0", VA = "0x184FC0EF0")]
		private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x4FC1E40", Offset = "0x4FC0A40", VA = "0x184FC1E40")]
		private void ParseHowMany(ParticleContentValidator pcv)
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x4FC0BD0", Offset = "0x4FBF7D0", VA = "0x184FC0BD0")]
		private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId)
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x4FC1370", Offset = "0x4FBFF70", VA = "0x184FC1370")]
		private void ParseEntityDecl()
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x4FC2040", Offset = "0x4FC0C40", VA = "0x184FC2040")]
		private void ParseNotationDecl()
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x4FBCD40", Offset = "0x4FBB940", VA = "0x184FBCD40")]
		private void AddUndeclaredNotation(string notationName)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x4FC03A0", Offset = "0x4FBEFA0", VA = "0x184FC03A0")]
		private void ParseComment()
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x4FC2270", Offset = "0x4FC0E70", VA = "0x184FC2270")]
		private void ParsePI()
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x4FC0540", Offset = "0x4FBF140", VA = "0x184FC0540")]
		private void ParseCondSection()
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x4FC1720", Offset = "0x4FC0320", VA = "0x184FC1720")]
		private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x4FBD3D0", Offset = "0x4FBBFD0", VA = "0x184FBD3D0")]
		private DtdParser.Token GetToken(bool needWhiteSpace)
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x4FC7220", Offset = "0x4FC5E20", VA = "0x184FC7220")]
		private DtdParser.Token ScanSubsetContent()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x4FC6A60", Offset = "0x4FC5660", VA = "0x184FC6A60")]
		private DtdParser.Token ScanNameExpected()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x4FC6EB0", Offset = "0x4FC5AB0", VA = "0x184FC6EB0")]
		private DtdParser.Token ScanQNameExpected()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x4FC6AA0", Offset = "0x4FC56A0", VA = "0x184FC6AA0")]
		private DtdParser.Token ScanNmtokenExpected()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x4FC47E0", Offset = "0x4FC33E0", VA = "0x184FC47E0")]
		private DtdParser.Token ScanDoctype1()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x4FC4920", Offset = "0x4FC3520", VA = "0x184FC4920")]
		private DtdParser.Token ScanDoctype2()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x4FC3CC0", Offset = "0x4FC28C0", VA = "0x184FC3CC0")]
		private DtdParser.Token ScanClosingTag()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x4FC49D0", Offset = "0x4FC35D0", VA = "0x184FC49D0")]
		private DtdParser.Token ScanElement1()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x4FC4C70", Offset = "0x4FC3870", VA = "0x184FC4C70")]
		private DtdParser.Token ScanElement2()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x4FC4E90", Offset = "0x4FC3A90", VA = "0x184FC4E90")]
		private DtdParser.Token ScanElement3()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x4FC4F20", Offset = "0x4FC3B20", VA = "0x184FC4F20")]
		private DtdParser.Token ScanElement4()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x4FC5030", Offset = "0x4FC3C30", VA = "0x184FC5030")]
		private DtdParser.Token ScanElement5()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x4FC5120", Offset = "0x4FC3D20", VA = "0x184FC5120")]
		private DtdParser.Token ScanElement6()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x4FC51F0", Offset = "0x4FC3DF0", VA = "0x184FC51F0")]
		private DtdParser.Token ScanElement7()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x4FC2DC0", Offset = "0x4FC19C0", VA = "0x184FC2DC0")]
		private DtdParser.Token ScanAttlist1()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x4FC2E90", Offset = "0x4FC1A90", VA = "0x184FC2E90")]
		private DtdParser.Token ScanAttlist2()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x4FC35A0", Offset = "0x4FC21A0", VA = "0x184FC35A0")]
		private DtdParser.Token ScanAttlist3()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x4FC3630", Offset = "0x4FC2230", VA = "0x184FC3630")]
		private DtdParser.Token ScanAttlist4()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x4FC3700", Offset = "0x4FC2300", VA = "0x184FC3700")]
		private DtdParser.Token ScanAttlist5()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x4FC37D0", Offset = "0x4FC23D0", VA = "0x184FC37D0")]
		private DtdParser.Token ScanAttlist6()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x4FC3C10", Offset = "0x4FC2810", VA = "0x184FC3C10")]
		private DtdParser.Token ScanAttlist7()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x4FC5600", Offset = "0x4FC4200", VA = "0x184FC5600")]
		private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType)
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x4FC54F0", Offset = "0x4FC40F0", VA = "0x184FC54F0")]
		private XmlQualifiedName ScanEntityName()
		{
			return null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x4FC6CA0", Offset = "0x4FC58A0", VA = "0x184FC6CA0")]
		private DtdParser.Token ScanNotation1()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x4FC7A10", Offset = "0x4FC6610", VA = "0x184FC7A10")]
		private DtdParser.Token ScanSystemId()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x4FC5250", Offset = "0x4FC3E50", VA = "0x184FC5250")]
		private DtdParser.Token ScanEntity1()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x4FC52C0", Offset = "0x4FC3EC0", VA = "0x184FC52C0")]
		private DtdParser.Token ScanEntity2()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x4FC5400", Offset = "0x4FC4000", VA = "0x184FC5400")]
		private DtdParser.Token ScanEntity3()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x4FC6DA0", Offset = "0x4FC59A0", VA = "0x184FC6DA0")]
		private DtdParser.Token ScanPublicId1()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x4FC6E40", Offset = "0x4FC5A40", VA = "0x184FC6E40")]
		private DtdParser.Token ScanPublicId2()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x4FC3D40", Offset = "0x4FC2940", VA = "0x184FC3D40")]
		private DtdParser.Token ScanCondSection1()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x4FC40C0", Offset = "0x4FC2CC0", VA = "0x184FC40C0")]
		private DtdParser.Token ScanCondSection2()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x4FC4140", Offset = "0x4FC2D40", VA = "0x184FC4140")]
		private DtdParser.Token ScanCondSection3()
		{
			return DtdParser.Token.CDATA;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x4FC6A90", Offset = "0x4FC5690", VA = "0x184FC6A90")]
		private void ScanName()
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x4FC7210", Offset = "0x4FC5E10", VA = "0x184FC7210")]
		private void ScanQName()
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x4FC6EE0", Offset = "0x4FC5AE0", VA = "0x184FC6EE0")]
		private void ScanQName(bool isQName)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x4FC2C00", Offset = "0x4FC1800", VA = "0x184FC2C00")]
		private bool ReadDataInName()
		{
			return default(bool);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x4FC6AD0", Offset = "0x4FC56D0", VA = "0x184FC6AD0")]
		private void ScanNmtoken()
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x4FBD080", Offset = "0x4FBBC80", VA = "0x184FBD080")]
		private bool EatPublicKeyword()
		{
			return default(bool);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x4FBD140", Offset = "0x4FBBD40", VA = "0x184FBD140")]
		private bool EatSystemKeyword()
		{
			return default(bool);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x4FBD200", Offset = "0x4FBBE00", VA = "0x184FBD200")]
		private XmlQualifiedName GetNameQualified(bool canHavePrefix)
		{
			return null;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x4FBD3A0", Offset = "0x4FBBFA0", VA = "0x184FBD3A0")]
		private string GetNameString()
		{
			return null;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x4FBD3A0", Offset = "0x4FBBFA0", VA = "0x184FBD3A0")]
		private string GetNmtokenString()
		{
			return null;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x4FBE710", Offset = "0x4FBD310", VA = "0x184FBE710")]
		private string GetValue()
		{
			return null;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x4FBE670", Offset = "0x4FBD270", VA = "0x184FBE670")]
		private string GetValueWithStrippedSpaces()
		{
			return null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x4FC2C50", Offset = "0x4FC1850", VA = "0x184FC2C50")]
		private int ReadData()
		{
			return 0;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x4FBF2B0", Offset = "0x4FBDEB0", VA = "0x184FBF2B0")]
		private void LoadParsingBuffer()
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x4FC2DB0", Offset = "0x4FC19B0", VA = "0x184FC2DB0")]
		private void SaveParsingBuffer()
		{
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x4FC2CD0", Offset = "0x4FC18D0", VA = "0x184FC2CD0")]
		private void SaveParsingBuffer(int internalSubsetValueEndPos)
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x4FBEB40", Offset = "0x4FBD740", VA = "0x184FBEB40")]
		private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute)
		{
			return default(bool);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x4FBE930", Offset = "0x4FBD530", VA = "0x184FBE930")]
		private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute)
		{
			return default(bool);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x4FBE7A0", Offset = "0x4FBD3A0", VA = "0x184FBE7A0")]
		private bool HandleEntityEnd(bool inLiteral)
		{
			return default(bool);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x4FC8A20", Offset = "0x4FC7620", VA = "0x184FC8A20")]
		private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute)
		{
			return null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x4FC7AB0", Offset = "0x4FC66B0", VA = "0x184FC7AB0")]
		private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x4FC7C20", Offset = "0x4FC6820", VA = "0x184FC7C20")]
		private void SendValidationEvent(XmlSeverityType severity, string code, string arg)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x4FC7D70", Offset = "0x4FC6970", VA = "0x184FC7D70")]
		private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e)
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x4FBF2A0", Offset = "0x4FBDEA0", VA = "0x184FBF2A0")]
		private bool IsAttributeValueType(DtdParser.Token token)
		{
			return default(bool);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x170001B4")]
		private int LineNo
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x4FC8E40", Offset = "0x4FC7A40", VA = "0x184FC8E40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x170001B5")]
		private int LinePos
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x4FC8E90", Offset = "0x4FC7A90", VA = "0x184FC8E90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B6")]
		private string BaseUriStr
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x4FC8D50", Offset = "0x4FC7950", VA = "0x184FC8D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x4FBF3E0", Offset = "0x4FBDFE0", VA = "0x184FBF3E0")]
		private void OnUnexpectedError()
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x4FC8490", Offset = "0x4FC7090", VA = "0x184FC8490")]
		private void Throw(int curPos, string res)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x4FC8500", Offset = "0x4FC7100", VA = "0x184FC8500")]
		private void Throw(int curPos, string res, string arg)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x4FC8840", Offset = "0x4FC7440", VA = "0x184FC8840")]
		private void Throw(int curPos, string res, string[] args)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x4FC86E0", Offset = "0x4FC72E0", VA = "0x184FC86E0")]
		private void Throw(string res, string arg, int lineNo, int linePos)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x4FC8190", Offset = "0x4FC6D90", VA = "0x184FC8190")]
		private void ThrowInvalidChar(int pos, string data, int invCharPos)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x4FC8110", Offset = "0x4FC6D10", VA = "0x184FC8110")]
		private void ThrowInvalidChar(char[] data, int length, int invCharPos)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x4FC8210", Offset = "0x4FC6E10", VA = "0x184FC8210")]
		private void ThrowUnexpectedToken(int pos, string expectedToken)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x4FC8230", Offset = "0x4FC6E30", VA = "0x184FC8230")]
		private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x4FC28A0", Offset = "0x4FC14A0", VA = "0x184FC28A0")]
		private string ParseUnexpectedToken(int startPos)
		{
			return null;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x4FC7E90", Offset = "0x4FC6A90", VA = "0x184FC7E90")]
		internal static string StripSpaces(string value)
		{
			return null;
		}

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x10")]
		private IDtdParserAdapter readerAdapter;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x18")]
		private IDtdParserAdapterWithValidation readerAdapterWithValidation;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x20")]
		private XmlNameTable nameTable;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x28")]
		private SchemaInfo schemaInfo;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x30")]
		private XmlCharType xmlCharType;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x38")]
		private string systemId;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x40")]
		private string publicId;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x48")]
		private bool normalize;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x49")]
		private bool validate;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x4A")]
		private bool supportNamespaces;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x4B")]
		private bool v1Compat;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x50")]
		private char[] chars;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x58")]
		private int charsUsed;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x5C")]
		private int curPos;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x60")]
		private DtdParser.ScanningFunction scanningFunction;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x64")]
		private DtdParser.ScanningFunction nextScaningFunction;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x68")]
		private DtdParser.ScanningFunction savedScanningFunction;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x6C")]
		private bool whitespaceSeen;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x70")]
		private int tokenStartPos;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x74")]
		private int colonPos;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x78")]
		private StringBuilder internalSubsetValueSb;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x80")]
		private int externalEntitiesDepth;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x84")]
		private int currentEntityId;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x88")]
		private bool freeFloatingDtd;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x89")]
		private bool hasFreeFloatingInternalSubset;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x90")]
		private StringBuilder stringBuilder;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x98")]
		private int condSectionDepth;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x9C")]
		private LineInfo literalLineInfo;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0xA4")]
		private char literalQuoteChar;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0xA8")]
		private string documentBaseUri;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0xB0")]
		private string externalDtdBaseUri;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0xC0")]
		private int[] condSectionEntityIds;

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		private enum Token
		{
			// Token: 0x0400032A RID: 810
			[Token(Token = "0x400032A")]
			CDATA,
			// Token: 0x0400032B RID: 811
			[Token(Token = "0x400032B")]
			ID,
			// Token: 0x0400032C RID: 812
			[Token(Token = "0x400032C")]
			IDREF,
			// Token: 0x0400032D RID: 813
			[Token(Token = "0x400032D")]
			IDREFS,
			// Token: 0x0400032E RID: 814
			[Token(Token = "0x400032E")]
			ENTITY,
			// Token: 0x0400032F RID: 815
			[Token(Token = "0x400032F")]
			ENTITIES,
			// Token: 0x04000330 RID: 816
			[Token(Token = "0x4000330")]
			NMTOKEN,
			// Token: 0x04000331 RID: 817
			[Token(Token = "0x4000331")]
			NMTOKENS,
			// Token: 0x04000332 RID: 818
			[Token(Token = "0x4000332")]
			NOTATION,
			// Token: 0x04000333 RID: 819
			[Token(Token = "0x4000333")]
			None,
			// Token: 0x04000334 RID: 820
			[Token(Token = "0x4000334")]
			PERef,
			// Token: 0x04000335 RID: 821
			[Token(Token = "0x4000335")]
			AttlistDecl,
			// Token: 0x04000336 RID: 822
			[Token(Token = "0x4000336")]
			ElementDecl,
			// Token: 0x04000337 RID: 823
			[Token(Token = "0x4000337")]
			EntityDecl,
			// Token: 0x04000338 RID: 824
			[Token(Token = "0x4000338")]
			NotationDecl,
			// Token: 0x04000339 RID: 825
			[Token(Token = "0x4000339")]
			Comment,
			// Token: 0x0400033A RID: 826
			[Token(Token = "0x400033A")]
			PI,
			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400033B")]
			CondSectionStart,
			// Token: 0x0400033C RID: 828
			[Token(Token = "0x400033C")]
			CondSectionEnd,
			// Token: 0x0400033D RID: 829
			[Token(Token = "0x400033D")]
			Eof,
			// Token: 0x0400033E RID: 830
			[Token(Token = "0x400033E")]
			REQUIRED,
			// Token: 0x0400033F RID: 831
			[Token(Token = "0x400033F")]
			IMPLIED,
			// Token: 0x04000340 RID: 832
			[Token(Token = "0x4000340")]
			FIXED,
			// Token: 0x04000341 RID: 833
			[Token(Token = "0x4000341")]
			QName,
			// Token: 0x04000342 RID: 834
			[Token(Token = "0x4000342")]
			Name,
			// Token: 0x04000343 RID: 835
			[Token(Token = "0x4000343")]
			Nmtoken,
			// Token: 0x04000344 RID: 836
			[Token(Token = "0x4000344")]
			Quote,
			// Token: 0x04000345 RID: 837
			[Token(Token = "0x4000345")]
			LeftParen,
			// Token: 0x04000346 RID: 838
			[Token(Token = "0x4000346")]
			RightParen,
			// Token: 0x04000347 RID: 839
			[Token(Token = "0x4000347")]
			GreaterThan,
			// Token: 0x04000348 RID: 840
			[Token(Token = "0x4000348")]
			Or,
			// Token: 0x04000349 RID: 841
			[Token(Token = "0x4000349")]
			LeftBracket,
			// Token: 0x0400034A RID: 842
			[Token(Token = "0x400034A")]
			RightBracket,
			// Token: 0x0400034B RID: 843
			[Token(Token = "0x400034B")]
			PUBLIC,
			// Token: 0x0400034C RID: 844
			[Token(Token = "0x400034C")]
			SYSTEM,
			// Token: 0x0400034D RID: 845
			[Token(Token = "0x400034D")]
			Literal,
			// Token: 0x0400034E RID: 846
			[Token(Token = "0x400034E")]
			DOCTYPE,
			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			NData,
			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			Percent,
			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			Star,
			// Token: 0x04000352 RID: 850
			[Token(Token = "0x4000352")]
			QMark,
			// Token: 0x04000353 RID: 851
			[Token(Token = "0x4000353")]
			Plus,
			// Token: 0x04000354 RID: 852
			[Token(Token = "0x4000354")]
			PCDATA,
			// Token: 0x04000355 RID: 853
			[Token(Token = "0x4000355")]
			Comma,
			// Token: 0x04000356 RID: 854
			[Token(Token = "0x4000356")]
			ANY,
			// Token: 0x04000357 RID: 855
			[Token(Token = "0x4000357")]
			EMPTY,
			// Token: 0x04000358 RID: 856
			[Token(Token = "0x4000358")]
			IGNORE,
			// Token: 0x04000359 RID: 857
			[Token(Token = "0x4000359")]
			INCLUDE
		}

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200008B")]
		private enum ScanningFunction
		{
			// Token: 0x0400035B RID: 859
			[Token(Token = "0x400035B")]
			SubsetContent,
			// Token: 0x0400035C RID: 860
			[Token(Token = "0x400035C")]
			Name,
			// Token: 0x0400035D RID: 861
			[Token(Token = "0x400035D")]
			QName,
			// Token: 0x0400035E RID: 862
			[Token(Token = "0x400035E")]
			Nmtoken,
			// Token: 0x0400035F RID: 863
			[Token(Token = "0x400035F")]
			Doctype1,
			// Token: 0x04000360 RID: 864
			[Token(Token = "0x4000360")]
			Doctype2,
			// Token: 0x04000361 RID: 865
			[Token(Token = "0x4000361")]
			Element1,
			// Token: 0x04000362 RID: 866
			[Token(Token = "0x4000362")]
			Element2,
			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			Element3,
			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			Element4,
			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			Element5,
			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			Element6,
			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			Element7,
			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			Attlist1,
			// Token: 0x04000369 RID: 873
			[Token(Token = "0x4000369")]
			Attlist2,
			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			Attlist3,
			// Token: 0x0400036B RID: 875
			[Token(Token = "0x400036B")]
			Attlist4,
			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			Attlist5,
			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			Attlist6,
			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			Attlist7,
			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			Entity1,
			// Token: 0x04000370 RID: 880
			[Token(Token = "0x4000370")]
			Entity2,
			// Token: 0x04000371 RID: 881
			[Token(Token = "0x4000371")]
			Entity3,
			// Token: 0x04000372 RID: 882
			[Token(Token = "0x4000372")]
			Notation1,
			// Token: 0x04000373 RID: 883
			[Token(Token = "0x4000373")]
			CondSection1,
			// Token: 0x04000374 RID: 884
			[Token(Token = "0x4000374")]
			CondSection2,
			// Token: 0x04000375 RID: 885
			[Token(Token = "0x4000375")]
			CondSection3,
			// Token: 0x04000376 RID: 886
			[Token(Token = "0x4000376")]
			Literal,
			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			SystemId,
			// Token: 0x04000378 RID: 888
			[Token(Token = "0x4000378")]
			PublicId1,
			// Token: 0x04000379 RID: 889
			[Token(Token = "0x4000379")]
			PublicId2,
			// Token: 0x0400037A RID: 890
			[Token(Token = "0x400037A")]
			ClosingTag,
			// Token: 0x0400037B RID: 891
			[Token(Token = "0x400037B")]
			ParamEntitySpace,
			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			None
		}

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x200008C")]
		private enum LiteralType
		{
			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			AttributeValue,
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			EntityReplText,
			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			SystemOrPublicID
		}

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		private class UndeclaredNotation
		{
			// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x4FEABC0", Offset = "0x4FE97C0", VA = "0x184FEABC0")]
			internal UndeclaredNotation(string name, int lineNo, int linePos)
			{
			}

			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			[FieldOffset(Offset = "0x10")]
			internal string name;

			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000382")]
			[FieldOffset(Offset = "0x18")]
			internal int lineNo;

			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			[FieldOffset(Offset = "0x1C")]
			internal int linePos;

			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x20")]
			internal DtdParser.UndeclaredNotation next;
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		private class ParseElementOnlyContent_LocalFrame
		{
			// Token: 0x060006AD RID: 1709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x4FE1F30", Offset = "0x4FE0B30", VA = "0x184FE1F30")]
			public ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam)
			{
			}

			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x10")]
			public int startParenEntityId;

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x14")]
			public DtdParser.Token parsingSchema;
		}
	}
}
