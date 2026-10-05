using System;
using System.Collections;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public class XmlDocument : XmlNode
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x4FADA30", Offset = "0x4FAC630", VA = "0x184FADA30")]
		public XmlDocument()
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x4FADAA0", Offset = "0x4FAC6A0", VA = "0x184FADAA0")]
		protected internal XmlDocument(XmlImplementation imp)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700010C")]
		internal SchemaInfo DtdSchemaInfo
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			set
			{
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x4FAA750", Offset = "0x4FA9350", VA = "0x184FAA750")]
		internal static void CheckName(string name)
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x4FAA110", Offset = "0x4FA8D10", VA = "0x184FAA110")]
		internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x4FAC2A0", Offset = "0x4FAAEA0", VA = "0x184FAC2A0")]
		internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x4FA9910", Offset = "0x4FA8510", VA = "0x184FA9910")]
		internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x4FAA010", Offset = "0x4FA8C10", VA = "0x184FAA010")]
		internal bool AddIdInfo(XmlName eleName, XmlName attrName)
		{
			return default(bool);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x4FABDF0", Offset = "0x4FAA9F0", VA = "0x184FABDF0")]
		private XmlName GetIDInfoByElement_(XmlName eleName)
		{
			return null;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x4FAC050", Offset = "0x4FAAC50", VA = "0x184FAC050")]
		internal XmlName GetIDInfoByElement(XmlName eleName)
		{
			return null;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x4FAB650", Offset = "0x4FAA250", VA = "0x184FAB650")]
		private WeakReference GetElement(ArrayList elementList, XmlElement elem)
		{
			return null;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x4FA9D80", Offset = "0x4FA8980", VA = "0x184FA9D80")]
		internal void AddElementWithId(string id, XmlElement elem)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x4FAD5D0", Offset = "0x4FAC1D0", VA = "0x184FAD5D0")]
		internal void RemoveElementWithId(string id, XmlElement elem)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x4FAA820", Offset = "0x4FA9420", VA = "0x184FAA820", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x1700010D")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010E")]
		public override XmlNode ParentNode
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010F")]
		public virtual XmlDocumentType DocumentType
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x4FAE330", Offset = "0x4FACF30", VA = "0x184FAE330", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000110")]
		internal virtual XmlDeclaration Declaration
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x4FAE150", Offset = "0x4FACD50", VA = "0x184FAE150", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000111")]
		public XmlImplementation Implementation
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000112")]
		public override string Name
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000113")]
		public override string LocalName
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000114")]
		public XmlElement DocumentElement
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x4FAE250", Offset = "0x4FACE50", VA = "0x184FAE250")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x17000115")]
		internal override bool IsContainer
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000116")]
		internal override XmlLinkedNode LastNode
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000117")]
		public override XmlDocument OwnerDocument
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000118")]
		public XmlSchemaSet Schemas
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			set
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x17000119")]
		internal bool CanReportValidity
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x1700011A")]
		internal bool HasSetResolver
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x4FA1B50", Offset = "0x4FA0750", VA = "0x184FA1B50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
		internal XmlResolver GetResolver()
		{
			return null;
		}

		// Token: 0x1700011B RID: 283
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011B")]
		public virtual XmlResolver XmlResolver
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x4FAE570", Offset = "0x4FAD170", VA = "0x184FAE570", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x4FACDD0", Offset = "0x4FAB9D0", VA = "0x184FACDD0", Slot = "24")]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return default(bool);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x4FAC470", Offset = "0x4FAB070", VA = "0x184FAC470")]
		private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode)
		{
			return default(bool);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x4FAC400", Offset = "0x4FAB000", VA = "0x184FAC400")]
		private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode)
		{
			return default(bool);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x4FAA4E0", Offset = "0x4FA90E0", VA = "0x184FAA4E0", Slot = "25")]
		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return default(bool);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x4FAAA00", Offset = "0x4FA9600", VA = "0x184FAAA00")]
		public XmlAttribute CreateAttribute(string name)
		{
			return null;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x4FAD770", Offset = "0x4FAC370", VA = "0x184FAD770")]
		internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI)
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x4FAAC10", Offset = "0x4FA9810", VA = "0x184FAAC10", Slot = "49")]
		public virtual XmlCDataSection CreateCDataSection(string data)
		{
			return null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x4FAACA0", Offset = "0x4FA98A0", VA = "0x184FAACA0", Slot = "50")]
		public virtual XmlComment CreateComment(string data)
		{
			return null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x4FAAE20", Offset = "0x4FA9A20", VA = "0x184FAAE20", Slot = "51")]
		public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x4FAADC0", Offset = "0x4FA99C0", VA = "0x184FAADC0", Slot = "52")]
		public virtual XmlDocumentFragment CreateDocumentFragment()
		{
			return null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x4FAAF90", Offset = "0x4FA9B90", VA = "0x184FAAF90")]
		public XmlElement CreateElement(string name)
		{
			return null;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x4FA9A50", Offset = "0x4FA8650", VA = "0x184FA9A50")]
		internal void AddDefaultAttributes(XmlElement elem)
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x4FAC150", Offset = "0x4FAAD50", VA = "0x184FAC150")]
		private SchemaElementDecl GetSchemaElementDecl(XmlElement elem)
		{
			return null;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x4FAD420", Offset = "0x4FAC020", VA = "0x184FAD420")]
		private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			return null;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x4FAB130", Offset = "0x4FA9D30", VA = "0x184FAB130", Slot = "53")]
		public virtual XmlEntityReference CreateEntityReference(string name)
		{
			return null;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x4FAB1A0", Offset = "0x4FA9DA0", VA = "0x184FAB1A0", Slot = "54")]
		public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4FAB380", Offset = "0x4FA9F80", VA = "0x184FAB380", Slot = "55")]
		public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x4FAB2A0", Offset = "0x4FA9EA0", VA = "0x184FAB2A0", Slot = "56")]
		public virtual XmlText CreateTextNode(string text)
		{
			return null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x4FAB230", Offset = "0x4FA9E30", VA = "0x184FAB230", Slot = "57")]
		public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text)
		{
			return null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x4FAB310", Offset = "0x4FA9F10", VA = "0x184FAB310", Slot = "58")]
		public virtual XmlWhitespace CreateWhitespace(string text)
		{
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x4FAAB50", Offset = "0x4FA9750", VA = "0x184FAAB50")]
		public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI)
		{
			return null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x4FAAED0", Offset = "0x4FA9AD0", VA = "0x184FAAED0")]
		public XmlElement CreateElement(string qualifiedName, string namespaceURI)
		{
			return null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x4FAC820", Offset = "0x4FAB420", VA = "0x184FAC820")]
		private XmlNode ImportNodeInternal(XmlNode node, bool deep)
		{
			return null;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x4FAC590", Offset = "0x4FAB190", VA = "0x184FAC590")]
		private void ImportAttributes(XmlNode fromElem, XmlNode toElem)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x4FAC720", Offset = "0x4FAB320", VA = "0x184FAC720")]
		private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011C")]
		public XmlNameTable NameTable
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x4A52E10", Offset = "0x4A51A10", VA = "0x184A52E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x4FAA960", Offset = "0x4FA9560", VA = "0x184FAA960", Slot = "59")]
		public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x4FAAD20", Offset = "0x4FA9920", VA = "0x184FAAD20", Slot = "60")]
		protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x4FAB060", Offset = "0x4FA9C60", VA = "0x184FAB060", Slot = "61")]
		public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI)
		{
			return null;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x1700011D")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011E")]
		internal XmlNamedNodeMap Entities
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x4FAE410", Offset = "0x4FAD010", VA = "0x184FAE410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00003390 File Offset: 0x00001590
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011F")]
		internal bool IsLoading
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x4FAE4A0", Offset = "0x4FAD0A0", VA = "0x184FAE4A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x4FA2980", Offset = "0x4FA1580", VA = "0x184FA2980")]
			set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x17000120")]
		internal bool ActualLoadingStatus
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x4FAD820", Offset = "0x4FAC420", VA = "0x184FAD820")]
		private XmlTextReader SetupReader(XmlTextReader tr)
		{
			return null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4FAD2D0", Offset = "0x4FABED0", VA = "0x184FAD2D0", Slot = "62")]
		public virtual void Load(XmlReader reader)
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x4FAD070", Offset = "0x4FABC70", VA = "0x184FAD070", Slot = "63")]
		public virtual void LoadXml(string xml)
		{
		}

		// Token: 0x17000121 RID: 289
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000121")]
		public override string InnerText
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x4FAE4B0", Offset = "0x4FAD0B0", VA = "0x184FAE4B0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x17000122 RID: 290
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000122")]
		public override string InnerXml
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x4FAE520", Offset = "0x4FAD120", VA = "0x184FAE520", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4FABCF0", Offset = "0x4FAA8F0", VA = "0x184FABCF0", Slot = "42")]
		internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			return null;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x4FAC070", Offset = "0x4FAAC70", VA = "0x184FAC070")]
		internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent)
		{
			return null;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x4FAA490", Offset = "0x4FA9090", VA = "0x184FAA490", Slot = "43")]
		internal override void BeforeEvent(XmlNodeChangedEventArgs args)
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x4FAA140", Offset = "0x4FA8D40", VA = "0x184FAA140", Slot = "44")]
		internal override void AfterEvent(XmlNodeChangedEventArgs args)
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x4FAB420", Offset = "0x4FAA020", VA = "0x184FAB420")]
		internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			return null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x4FABB80", Offset = "0x4FAA780", VA = "0x184FABB80")]
		internal XmlEntity GetEntityNode(string name)
		{
			return null;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000123")]
		public override string BaseURI
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x4FAD760", Offset = "0x4FAC360", VA = "0x184FAD760")]
		internal void SetBaseURI(string inBaseURI)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x4FAA190", Offset = "0x4FA8D90", VA = "0x184FAA190", Slot = "23")]
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			return null;
		}

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x18")]
		private XmlImplementation implementation;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x20")]
		private DomNameTable domNameTable;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x28")]
		private XmlLinkedNode lastChild;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x30")]
		private XmlNamedNodeMap entities;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x38")]
		private Hashtable htElementIdMap;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x40")]
		private Hashtable htElementIDAttrDecl;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x48")]
		private SchemaInfo schemaInfo;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x50")]
		private XmlSchemaSet schemas;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x58")]
		private bool reportValidity;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x59")]
		private bool actualLoadingStatus;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x60")]
		private XmlNodeChangedEventHandler onNodeInsertingDelegate;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x68")]
		private XmlNodeChangedEventHandler onNodeInsertedDelegate;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x70")]
		private XmlNodeChangedEventHandler onNodeRemovingDelegate;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x78")]
		private XmlNodeChangedEventHandler onNodeRemovedDelegate;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x80")]
		private XmlNodeChangedEventHandler onNodeChangingDelegate;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x88")]
		private XmlNodeChangedEventHandler onNodeChangedDelegate;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x90")]
		internal bool fEntRefNodesPresent;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x91")]
		internal bool fCDataNodesPresent;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x92")]
		private bool preserveWhitespace;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x93")]
		private bool isLoading;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x98")]
		internal string strDocumentName;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0xA0")]
		internal string strDocumentFragmentName;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0xA8")]
		internal string strCommentName;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0xB0")]
		internal string strTextName;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0xB8")]
		internal string strCDataSectionName;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0xC0")]
		internal string strEntityName;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0xC8")]
		internal string strID;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0xD0")]
		internal string strXmlns;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0xD8")]
		internal string strXml;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0xE0")]
		internal string strSpace;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0xE8")]
		internal string strLang;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0xF0")]
		internal string strEmpty;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0xF8")]
		internal string strNonSignificantWhitespaceName;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x100")]
		internal string strSignificantWhitespaceName;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x108")]
		internal string strReservedXmlns;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x110")]
		internal string strReservedXml;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x118")]
		internal string baseURI;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x120")]
		private XmlResolver resolver;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x128")]
		internal bool bSetResolver;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x130")]
		internal object objLock;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x0")]
		internal static EmptyEnumerator EmptyEnumerator;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x8")]
		internal static IXmlSchemaInfo NotKnownSchemaInfo;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x10")]
		internal static IXmlSchemaInfo ValidSchemaInfo;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x18")]
		internal static IXmlSchemaInfo InvalidSchemaInfo;
	}
}
