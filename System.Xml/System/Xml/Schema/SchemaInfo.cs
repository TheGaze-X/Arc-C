using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	internal class SchemaInfo : IDtdInfo
	{
		// Token: 0x06000A85 RID: 2693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x50092D0", Offset = "0x5007ED0", VA = "0x1850092D0")]
		internal SchemaInfo()
		{
		}

		// Token: 0x170002F4 RID: 756
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F4")]
		public XmlQualifiedName DocTypeName
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x170002F5 RID: 757
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F5")]
		internal string InternalDtdSubset
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			set
			{
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F6")]
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F7")]
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F8")]
		internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
		{
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x50094D0", Offset = "0x50080D0", VA = "0x1850094D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F9")]
		internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x50095F0", Offset = "0x50081F0", VA = "0x1850095F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00005868 File Offset: 0x00003A68
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FA")]
		internal SchemaType SchemaType
		{
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return SchemaType.None;
			}
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x4A5BF80", Offset = "0x4A5AB80", VA = "0x184A5BF80")]
			set
			{
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FB")]
		internal Dictionary<string, SchemaNotation> Notations
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x5009560", Offset = "0x5008160", VA = "0x185009560")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x5008F90", Offset = "0x5007B90", VA = "0x185008F90")]
		internal void Finish()
		{
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x170002FC")]
		private bool HasDefaultAttributes
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x170002FD")]
		private bool HasNonCDataAttributes
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x5009120", Offset = "0x5007D20", VA = "0x185009120", Slot = "8")]
		private IDtdAttributeListInfo LookupAttributeList(string prefix, string localName)
		{
			return null;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x5009200", Offset = "0x5007E00", VA = "0x185009200", Slot = "9")]
		private IDtdEntityInfo LookupEntity(string name)
		{
			return null;
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FE")]
		private XmlQualifiedName Name
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		private string InternalDtdSubset
		{
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x30")]
		private XmlQualifiedName docTypeName;

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x38")]
		private string internalDtdSubset;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x40")]
		private bool hasNonCDataAttributes;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x41")]
		private bool hasDefaultAttributes;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, bool> targetNamespaces;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x58")]
		private SchemaType schemaType;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, SchemaNotation> notations;
	}
}
