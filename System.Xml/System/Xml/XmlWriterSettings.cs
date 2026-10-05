using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public sealed class XmlWriterSettings
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x4FBC650", Offset = "0x4FBB250", VA = "0x184FBC650")]
		public XmlWriterSettings()
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x170000C9")]
		public bool Async
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		public Encoding Encoding
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00002F70 File Offset: 0x00001170
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CB")]
		public bool OmitXmlDeclaration
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x4FBCA10", Offset = "0x4FBB610", VA = "0x184FBCA10")]
			set
			{
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x170000CC")]
		public NewLineHandling NewLineHandling
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return NewLineHandling.Replace;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CD")]
		public string NewLineChars
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CE")]
		public bool Indent
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x36B3FB0", Offset = "0x36B2BB0", VA = "0x1836B3FB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x4FBC900", Offset = "0x4FBB500", VA = "0x184FBC900")]
			set
			{
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CF")]
		public string IndentChars
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x170000D0")]
		public bool NewLineOnAttributes
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x170000D1")]
		public bool CloseOutput
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00002FE8 File Offset: 0x000011E8
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D2")]
		public ConformanceLevel ConformanceLevel
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return ConformanceLevel.Auto;
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x4FBC850", Offset = "0x4FBB450", VA = "0x184FBC850")]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x170000D3")]
		public bool CheckCharacters
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x4E4C0F0", Offset = "0x4E4ACF0", VA = "0x184E4C0F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D4")]
		public NamespaceHandling NamespaceHandling
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			get
			{
				return NamespaceHandling.Default;
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x4FBC960", Offset = "0x4FBB560", VA = "0x184FBC960")]
			set
			{
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x170000D5")]
		public bool WriteEndDocumentOnClose
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x4FBC840", Offset = "0x4FBB440", VA = "0x184FBC840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00003048 File Offset: 0x00001248
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D6")]
		public XmlOutputMethod OutputMethod
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			get
			{
				return XmlOutputMethod.Xml;
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x509F70", Offset = "0x508B70", VA = "0x180509F70")]
			internal set
			{
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x4FBBBC0", Offset = "0x4FBA7C0", VA = "0x184FBBBC0")]
		public XmlWriterSettings Clone()
		{
			return null;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D7")]
		internal List<XmlQualifiedName> CDataSectionElements
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x170000D8")]
		public bool DoNotEscapeUriAttributes
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x170000D9")]
		internal bool MergeCDataSections
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x2218060", Offset = "0x2216C60", VA = "0x182218060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DA")]
		internal string MediaType
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DB")]
		internal string DocTypeSystem
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DC")]
		internal string DocTypePublic
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x170000DD")]
		internal XmlStandalone Standalone
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x21E8010", Offset = "0x21E6C10", VA = "0x1821E8010")]
			get
			{
				return XmlStandalone.Omit;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x170000DE")]
		internal bool AutoXmlDeclaration
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x36D4BC0", Offset = "0x36D37C0", VA = "0x1836D4BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x170000DF")]
		internal TriState IndentInternal
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return TriState.False;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x170000E0")]
		internal bool IsQuerySpecific
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x4FBC7E0", Offset = "0x4FBB3E0", VA = "0x184FBC7E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x4FBBC90", Offset = "0x4FBA890", VA = "0x184FBBC90")]
		internal XmlWriter CreateWriter(Stream output)
		{
			return null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x4FBC230", Offset = "0x4FBAE30", VA = "0x184FBC230")]
		internal XmlWriter CreateWriter(TextWriter output)
		{
			return null;
		}

		// Token: 0x170000E1 RID: 225
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E1")]
		internal bool ReadOnly
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x4FBCA60", Offset = "0x4FBB660", VA = "0x184FBCA60")]
			set
			{
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x4FBBB00", Offset = "0x4FBA700", VA = "0x184FBBB00")]
		private void CheckReadOnly(string propertyName)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x4FBC530", Offset = "0x4FBB130", VA = "0x184FBC530")]
		private void Initialize()
		{
		}

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x10")]
		private bool useAsync;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x18")]
		private Encoding encoding;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x20")]
		private bool omitXmlDecl;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x24")]
		private NewLineHandling newLineHandling;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x28")]
		private string newLineChars;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x30")]
		private TriState indent;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x38")]
		private string indentChars;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x40")]
		private bool newLineOnAttributes;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x41")]
		private bool closeOutput;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x44")]
		private NamespaceHandling namespaceHandling;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x48")]
		private ConformanceLevel conformanceLevel;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x4C")]
		private bool checkCharacters;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x4D")]
		private bool writeEndDocumentOnClose;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x50")]
		private XmlOutputMethod outputMethod;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x58")]
		private List<XmlQualifiedName> cdataSections;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x60")]
		private bool doNotEscapeUriAttributes;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x61")]
		private bool mergeCDataSections;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x68")]
		private string mediaType;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x70")]
		private string docTypeSystem;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x78")]
		private string docTypePublic;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x80")]
		private XmlStandalone standalone;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x84")]
		private bool autoXmlDecl;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x85")]
		private bool isReadOnly;
	}
}
