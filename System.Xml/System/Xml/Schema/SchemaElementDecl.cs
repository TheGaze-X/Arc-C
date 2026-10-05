using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x5008BC0", Offset = "0x50077C0", VA = "0x185008BC0")]
		internal SchemaElementDecl()
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x5008940", Offset = "0x5007540", VA = "0x185008940")]
		internal SchemaElementDecl(XmlSchemaDatatype dtype)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x5008AD0", Offset = "0x50076D0", VA = "0x185008AD0")]
		internal SchemaElementDecl(XmlQualifiedName name, string prefix)
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x50086B0", Offset = "0x50072B0", VA = "0x1850086B0")]
		internal static SchemaElementDecl CreateAnyTypeElementDecl()
		{
			return null;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x170002D4")]
		private bool HasNonCDataAttributes
		{
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x37002A0", Offset = "0x36FEEA0", VA = "0x1837002A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x5008800", Offset = "0x5007400", VA = "0x185008800", Slot = "5")]
		private IDtdAttributeInfo LookupAttribute(string prefix, string localName)
		{
			return null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "6")]
		private IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes()
		{
			return null;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00005718 File Offset: 0x00003918
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D5")]
		internal bool IsIdDeclared
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x2109C30", Offset = "0x2108830", VA = "0x182109C30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x4D6B950", Offset = "0x4D6A550", VA = "0x184D6B950")]
			set
			{
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00005730 File Offset: 0x00003930
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D6")]
		internal bool HasNonCDataAttribute
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x37002A0", Offset = "0x36FEEA0", VA = "0x1837002A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x37002C0", Offset = "0x36FEEC0", VA = "0x1837002C0")]
			set
			{
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00005748 File Offset: 0x00003948
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D7")]
		internal bool IsNotationDeclared
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x5008CF0", Offset = "0x50078F0", VA = "0x185008CF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x5008D00", Offset = "0x5007900", VA = "0x185008D00")]
			set
			{
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D8")]
		internal ContentValidator ContentValidator
		{
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			set
			{
			}
		}

		// Token: 0x170002D9 RID: 729
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D9")]
		internal XmlSchemaAnyAttribute AnyAttribute
		{
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x168B8E0", Offset = "0x168A4E0", VA = "0x18168B8E0")]
			set
			{
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x50085A0", Offset = "0x50071A0", VA = "0x1850085A0")]
		internal void AddAttDef(SchemaAttDef attdef)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x5008780", Offset = "0x5007380", VA = "0x185008780")]
		internal SchemaAttDef GetAttDef(XmlQualifiedName qname)
		{
			return null;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DA")]
		internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DB")]
		internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
		{
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x68")]
		private List<IDtdDefaultAttributeInfo> defaultAttdefs;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x70")]
		private bool isIdDeclared;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x71")]
		private bool hasNonCDataAttribute;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x72")]
		private bool hasRequiredAttribute;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x73")]
		private bool isNotationDeclared;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x80")]
		private ContentValidator contentValidator;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x88")]
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly SchemaElementDecl Empty;
	}
}
