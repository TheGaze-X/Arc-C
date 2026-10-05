using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	internal class XmlWellFormedWriter : XmlWriter
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x4FBB470", Offset = "0x4FBA070", VA = "0x184FBB470")]
		internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings)
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x170000C2")]
		public override WriteState WriteState
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x4FBBA70", Offset = "0x4FBA670", VA = "0x184FBBA70", Slot = "27")]
			get
			{
				return WriteState.Start;
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x4FB9C40", Offset = "0x4FB8840", VA = "0x184FB9C40", Slot = "5")]
		public override void WriteStartDocument()
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x4FB9C10", Offset = "0x4FB8810", VA = "0x184FB9C10", Slot = "6")]
		public override void WriteStartDocument(bool standalone)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x4FB86D0", Offset = "0x4FB72D0", VA = "0x184FB86D0", Slot = "7")]
		public override void WriteEndDocument()
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x4FB61E0", Offset = "0x4FB4DE0", VA = "0x184FB61E0", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x4FB9C50", Offset = "0x4FB8850", VA = "0x184FB9C50", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x4FB8810", Offset = "0x4FB7410", VA = "0x184FB8810", Slot = "10")]
		public override void WriteEndElement()
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x4FB8B30", Offset = "0x4FB7730", VA = "0x184FB8B30", Slot = "11")]
		public override void WriteFullEndElement()
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x4FB93C0", Offset = "0x4FB7FC0", VA = "0x184FB93C0", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string namespaceName)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x4FB66A0", Offset = "0x4FB52A0", VA = "0x184FB66A0", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x4FB5B30", Offset = "0x4FB4730", VA = "0x184FB5B30", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x4FB6110", Offset = "0x4FB4D10", VA = "0x184FB6110", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x4FB8D40", Offset = "0x4FB7940", VA = "0x184FB8D40", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x4FB8A20", Offset = "0x4FB7620", VA = "0x184FB8A20", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x4FB5C00", Offset = "0x4FB4800", VA = "0x184FB5C00", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x4FBA100", Offset = "0x4FB8D00", VA = "0x184FBA100", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x4FBA470", Offset = "0x4FB9070", VA = "0x184FBA470", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x4FB9FB0", Offset = "0x4FB8BB0", VA = "0x184FB9FB0", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x4FB5E10", Offset = "0x4FB4A10", VA = "0x184FB5E10", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x4FB90C0", Offset = "0x4FB7CC0", VA = "0x184FB90C0", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x4FB8F80", Offset = "0x4FB7B80", VA = "0x184FB8F80", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x4FB5830", Offset = "0x4FB4430", VA = "0x184FB5830", Slot = "25")]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x4FB3D80", Offset = "0x4FB2980", VA = "0x184FB3D80", Slot = "28")]
		public override void Close()
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x4FB4030", Offset = "0x4FB2C30", VA = "0x184FB4030", Slot = "29")]
		public override void Flush()
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x4FB4720", Offset = "0x4FB3320", VA = "0x184FB4720", Slot = "30")]
		public override string LookupPrefix(string ns)
		{
			return null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x4FBA330", Offset = "0x4FB8F30", VA = "0x184FBA330", Slot = "31")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x4FB5A30", Offset = "0x4FB4630", VA = "0x184FB5A30", Slot = "26")]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		internal XmlRawWriter RawWriter
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x170000C4")]
		private bool SaveAttrValue
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x4FBBA60", Offset = "0x4FBA660", VA = "0x184FBBA60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x170000C5")]
		private bool InBase64
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x4FBBA30", Offset = "0x4FBA630", VA = "0x184FBBA30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x4FB5420", Offset = "0x4FB4020", VA = "0x184FB5420")]
		private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special)
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x4FB9A80", Offset = "0x4FB8680", VA = "0x184FB9A80")]
		private void WriteStartDocumentImpl(XmlStandalone standalone)
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x4FB55F0", Offset = "0x4FB41F0", VA = "0x184FB55F0")]
		private void StartFragment()
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x4FB4F70", Offset = "0x4FB3B70", VA = "0x184FB4F70")]
		private void PushNamespaceImplicit(string prefix, string ns)
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x4FB49B0", Offset = "0x4FB35B0", VA = "0x184FB49B0")]
		private bool PushNamespaceExplicit(string prefix, string ns)
		{
			return default(bool);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x4FB3460", Offset = "0x4FB2060", VA = "0x184FB3460")]
		private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x4FB3730", Offset = "0x4FB2330", VA = "0x184FB3730")]
		private void AddToNamespaceHashtable(int namespaceIndex)
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x4FB4520", Offset = "0x4FB3120", VA = "0x184FB4520")]
		private int LookupNamespaceIndex(string prefix)
		{
			return 0;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x4FB48E0", Offset = "0x4FB34E0", VA = "0x184FB48E0")]
		private void PopNamespaces(int indexFrom, int indexTo)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x4FB3F10", Offset = "0x4FB2B10", VA = "0x184FB3F10")]
		private static XmlException DupAttrException(string prefix, string localName)
		{
			return null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x4FB3810", Offset = "0x4FB2410", VA = "0x184FB3810")]
		private void AdvanceState(XmlWellFormedWriter.Token token)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x4FB5520", Offset = "0x4FB4120", VA = "0x184FB5520")]
		private void StartElementContent()
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x4FB41F0", Offset = "0x4FB2DF0", VA = "0x184FB41F0")]
		private static string GetStateName(XmlWellFormedWriter.State state)
		{
			return null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x4FB4630", Offset = "0x4FB3230", VA = "0x184FB4630")]
		internal string LookupNamespace(string prefix)
		{
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x4FB4450", Offset = "0x4FB3050", VA = "0x184FB4450")]
		private string LookupLocalNamespace(string prefix)
		{
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x4FB40B0", Offset = "0x4FB2CB0", VA = "0x184FB40B0")]
		private string GeneratePrefix()
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x4FB3C40", Offset = "0x4FB2840", VA = "0x184FB3C40")]
		private void CheckNCName(string ncname)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x4FB4280", Offset = "0x4FB2E80", VA = "0x184FB4280")]
		private static Exception InvalidCharsException(string name, int badCharIndex)
		{
			return null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x4FB5600", Offset = "0x4FB4200", VA = "0x184FB5600")]
		private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x170000C6")]
		private bool IsClosedOrErrorState
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x4FBBA50", Offset = "0x4FBA650", VA = "0x184FBBA50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x4FB3140", Offset = "0x4FB1D40", VA = "0x184FB3140")]
		private void AddAttribute(string prefix, string localName, string namespaceName)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x4FB3600", Offset = "0x4FB2200", VA = "0x184FB3600")]
		private void AddToAttrHashTable(int attributeIndex)
		{
		}

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x10")]
		private XmlWriter writer;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x18")]
		private XmlRawWriter rawWriter;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x20")]
		private IXmlNamespaceResolver predefinedNamespaces;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x28")]
		private XmlWellFormedWriter.Namespace[] nsStack;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x30")]
		private int nsTop;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, int> nsHashtable;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x40")]
		private bool useNsHashtable;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x48")]
		private XmlWellFormedWriter.ElementScope[] elemScopeStack;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x50")]
		private int elemTop;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x58")]
		private XmlWellFormedWriter.AttrName[] attrStack;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x60")]
		private int attrCount;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, int> attrHashTable;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x70")]
		private XmlWellFormedWriter.SpecialAttribute specAttr;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x78")]
		private XmlWellFormedWriter.AttributeValueCache attrValueCache;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x80")]
		private string curDeclPrefix;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x88")]
		private XmlWellFormedWriter.State[] stateTable;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x90")]
		private XmlWellFormedWriter.State currentState;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x94")]
		private bool checkCharacters;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x95")]
		private bool omitDuplNamespaces;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x96")]
		private bool writeEndDocumentOnClose;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x98")]
		private ConformanceLevel conformanceLevel;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x9C")]
		private bool dtdWritten;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x9D")]
		private bool xmlDeclFollows;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0xA0")]
		private XmlCharType xmlCharType;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0xA8")]
		private SecureStringHasher hasher;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly string[] stateName;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly string[] tokenName;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x10")]
		private static WriteState[] state2WriteState;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		private static readonly XmlWellFormedWriter.State[] StateTableDocument;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x20")]
		private static readonly XmlWellFormedWriter.State[] StateTableAuto;

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		private enum State
		{
			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40001FD")]
			Start,
			// Token: 0x040001FE RID: 510
			[Token(Token = "0x40001FE")]
			TopLevel,
			// Token: 0x040001FF RID: 511
			[Token(Token = "0x40001FF")]
			Document,
			// Token: 0x04000200 RID: 512
			[Token(Token = "0x4000200")]
			Element,
			// Token: 0x04000201 RID: 513
			[Token(Token = "0x4000201")]
			Content,
			// Token: 0x04000202 RID: 514
			[Token(Token = "0x4000202")]
			B64Content,
			// Token: 0x04000203 RID: 515
			[Token(Token = "0x4000203")]
			B64Attribute,
			// Token: 0x04000204 RID: 516
			[Token(Token = "0x4000204")]
			AfterRootEle,
			// Token: 0x04000205 RID: 517
			[Token(Token = "0x4000205")]
			Attribute,
			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			SpecialAttr,
			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			EndDocument,
			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			RootLevelAttr,
			// Token: 0x04000209 RID: 521
			[Token(Token = "0x4000209")]
			RootLevelSpecAttr,
			// Token: 0x0400020A RID: 522
			[Token(Token = "0x400020A")]
			RootLevelB64Attr,
			// Token: 0x0400020B RID: 523
			[Token(Token = "0x400020B")]
			AfterRootLevelAttr,
			// Token: 0x0400020C RID: 524
			[Token(Token = "0x400020C")]
			Closed,
			// Token: 0x0400020D RID: 525
			[Token(Token = "0x400020D")]
			Error,
			// Token: 0x0400020E RID: 526
			[Token(Token = "0x400020E")]
			StartContent = 101,
			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			StartContentEle,
			// Token: 0x04000210 RID: 528
			[Token(Token = "0x4000210")]
			StartContentB64,
			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			StartDoc,
			// Token: 0x04000212 RID: 530
			[Token(Token = "0x4000212")]
			StartDocEle = 106,
			// Token: 0x04000213 RID: 531
			[Token(Token = "0x4000213")]
			EndAttrSEle,
			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			EndAttrEEle,
			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			EndAttrSCont,
			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			EndAttrSAttr = 111,
			// Token: 0x04000217 RID: 535
			[Token(Token = "0x4000217")]
			PostB64Cont,
			// Token: 0x04000218 RID: 536
			[Token(Token = "0x4000218")]
			PostB64Attr,
			// Token: 0x04000219 RID: 537
			[Token(Token = "0x4000219")]
			PostB64RootAttr,
			// Token: 0x0400021A RID: 538
			[Token(Token = "0x400021A")]
			StartFragEle,
			// Token: 0x0400021B RID: 539
			[Token(Token = "0x400021B")]
			StartFragCont,
			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			StartFragB64,
			// Token: 0x0400021D RID: 541
			[Token(Token = "0x400021D")]
			StartRootLevelAttr
		}

		// Token: 0x02000050 RID: 80
		[Token(Token = "0x2000050")]
		private enum Token
		{
			// Token: 0x0400021F RID: 543
			[Token(Token = "0x400021F")]
			StartDocument,
			// Token: 0x04000220 RID: 544
			[Token(Token = "0x4000220")]
			EndDocument,
			// Token: 0x04000221 RID: 545
			[Token(Token = "0x4000221")]
			PI,
			// Token: 0x04000222 RID: 546
			[Token(Token = "0x4000222")]
			Comment,
			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000223")]
			Dtd,
			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			StartElement,
			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			EndElement,
			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			StartAttribute,
			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			EndAttribute,
			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			Text,
			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			CData,
			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			AtomicValue,
			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			Base64,
			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			RawData,
			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			Whitespace
		}

		// Token: 0x02000051 RID: 81
		[Token(Token = "0x2000051")]
		private class NamespaceResolverProxy : IXmlNamespaceResolver
		{
			// Token: 0x060003FD RID: 1021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter)
			{
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x4FA4E30", Offset = "0x4FA3A30", VA = "0x184FA4E30", Slot = "4")]
			private string LookupNamespace(string prefix)
			{
				return null;
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x4FA4E50", Offset = "0x4FA3A50", VA = "0x184FA4E50", Slot = "5")]
			private string LookupPrefix(string namespaceName)
			{
				return null;
			}

			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			[FieldOffset(Offset = "0x10")]
			private XmlWellFormedWriter wfWriter;
		}

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x2000052")]
		private struct ElementScope
		{
			// Token: 0x06000400 RID: 1024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x4FA4CC0", Offset = "0x4FA38C0", VA = "0x184FA4CC0")]
			internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop)
			{
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x4FA4D30", Offset = "0x4FA3930", VA = "0x184FA4D30")]
			internal void WriteEndElement(XmlRawWriter rawWriter)
			{
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x4FA4DB0", Offset = "0x4FA39B0", VA = "0x184FA4DB0")]
			internal void WriteFullEndElement(XmlRawWriter rawWriter)
			{
			}

			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			[FieldOffset(Offset = "0x0")]
			internal int prevNSTop;

			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			[FieldOffset(Offset = "0x8")]
			internal string prefix;

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			[FieldOffset(Offset = "0x10")]
			internal string localName;

			// Token: 0x04000232 RID: 562
			[Token(Token = "0x4000232")]
			[FieldOffset(Offset = "0x18")]
			internal string namespaceUri;

			// Token: 0x04000233 RID: 563
			[Token(Token = "0x4000233")]
			[FieldOffset(Offset = "0x20")]
			internal XmlSpace xmlSpace;

			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			[FieldOffset(Offset = "0x28")]
			internal string xmlLang;
		}

		// Token: 0x02000053 RID: 83
		[Token(Token = "0x2000053")]
		private enum NamespaceKind
		{
			// Token: 0x04000236 RID: 566
			[Token(Token = "0x4000236")]
			Written,
			// Token: 0x04000237 RID: 567
			[Token(Token = "0x4000237")]
			NeedToWrite,
			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000238")]
			Implied,
			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			Special
		}

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		private struct Namespace
		{
			// Token: 0x06000403 RID: 1027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x4FA4EB0", Offset = "0x4FA3AB0", VA = "0x184FA4EB0")]
			internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind)
			{
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x4FA4F00", Offset = "0x4FA3B00", VA = "0x184FA4F00")]
			internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter)
			{
			}

			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x0")]
			internal string prefix;

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0x8")]
			internal string namespaceUri;

			// Token: 0x0400023C RID: 572
			[Token(Token = "0x400023C")]
			[FieldOffset(Offset = "0x10")]
			internal XmlWellFormedWriter.NamespaceKind kind;

			// Token: 0x0400023D RID: 573
			[Token(Token = "0x400023D")]
			[FieldOffset(Offset = "0x14")]
			internal int prevNsIndex;
		}

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		private struct AttrName
		{
			// Token: 0x06000405 RID: 1029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x4FA2A10", Offset = "0x4FA1610", VA = "0x184FA2A10")]
			internal void Set(string prefix, string localName, string namespaceUri)
			{
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x00002F40 File Offset: 0x00001140
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x4FA2990", Offset = "0x4FA1590", VA = "0x184FA2990")]
			internal bool IsDuplicate(string prefix, string localName, string namespaceUri)
			{
				return default(bool);
			}

			// Token: 0x0400023E RID: 574
			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x0")]
			internal string prefix;

			// Token: 0x0400023F RID: 575
			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x8")]
			internal string namespaceUri;

			// Token: 0x04000240 RID: 576
			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x10")]
			internal string localName;

			// Token: 0x04000241 RID: 577
			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x18")]
			internal int prev;
		}

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		private enum SpecialAttribute
		{
			// Token: 0x04000243 RID: 579
			[Token(Token = "0x4000243")]
			No,
			// Token: 0x04000244 RID: 580
			[Token(Token = "0x4000244")]
			DefaultXmlns,
			// Token: 0x04000245 RID: 581
			[Token(Token = "0x4000245")]
			PrefixedXmlns,
			// Token: 0x04000246 RID: 582
			[Token(Token = "0x4000246")]
			XmlSpace,
			// Token: 0x04000247 RID: 583
			[Token(Token = "0x4000247")]
			XmlLang
		}

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		private class AttributeValueCache
		{
			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000C7")]
			internal string StringValue
			{
				[Token(Token = "0x6000407")]
				[Address(RVA = "0x4FA3D50", Offset = "0x4FA2950", VA = "0x184FA3D50")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x4FA3660", Offset = "0x4FA2260", VA = "0x184FA3660")]
			internal void WriteEntityRef(string name)
			{
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x4FA3480", Offset = "0x4FA2080", VA = "0x184FA3480")]
			internal void WriteCharEntity(char ch)
			{
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x4FA3AA0", Offset = "0x4FA26A0", VA = "0x184FA3AA0")]
			internal void WriteSurrogateCharEntity(char lowChar, char highChar)
			{
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x4FA3C40", Offset = "0x4FA2840", VA = "0x184FA3C40")]
			internal void WriteWhitespace(string ws)
			{
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x4FA39E0", Offset = "0x4FA25E0", VA = "0x184FA39E0")]
			internal void WriteString(string text)
			{
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x4FA3550", Offset = "0x4FA2150", VA = "0x184FA3550")]
			internal void WriteChars(char[] buffer, int index, int count)
			{
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x4FA38D0", Offset = "0x4FA24D0", VA = "0x184FA38D0")]
			internal void WriteRaw(char[] buffer, int index, int count)
			{
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x4FA3840", Offset = "0x4FA2440", VA = "0x184FA3840")]
			internal void WriteRaw(string data)
			{
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x4FA3BB0", Offset = "0x4FA27B0", VA = "0x184FA3BB0")]
			internal void WriteValue(string value)
			{
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x4FA2C50", Offset = "0x4FA1850", VA = "0x184FA2C50")]
			internal void Replay(XmlWriter writer)
			{
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x4FA3020", Offset = "0x4FA1C20", VA = "0x184FA3020")]
			internal void Trim()
			{
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x4FA2C00", Offset = "0x4FA1800", VA = "0x184FA2C00")]
			internal void Clear()
			{
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x4FA2FC0", Offset = "0x4FA1BC0", VA = "0x184FA2FC0")]
			private void StartComplexValue()
			{
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x4FA2A70", Offset = "0x4FA1670", VA = "0x184FA2A70")]
			private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data)
			{
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x4FA3CD0", Offset = "0x4FA28D0", VA = "0x184FA3CD0")]
			public AttributeValueCache()
			{
			}

			// Token: 0x04000248 RID: 584
			[Token(Token = "0x4000248")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder stringValue;

			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			[FieldOffset(Offset = "0x18")]
			private string singleStringValue;

			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			[FieldOffset(Offset = "0x20")]
			private XmlWellFormedWriter.AttributeValueCache.Item[] items;

			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			[FieldOffset(Offset = "0x28")]
			private int firstItem;

			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			[FieldOffset(Offset = "0x2C")]
			private int lastItem;

			// Token: 0x02000058 RID: 88
			[Token(Token = "0x2000058")]
			private enum ItemType
			{
				// Token: 0x0400024E RID: 590
				[Token(Token = "0x400024E")]
				EntityRef,
				// Token: 0x0400024F RID: 591
				[Token(Token = "0x400024F")]
				CharEntity,
				// Token: 0x04000250 RID: 592
				[Token(Token = "0x4000250")]
				SurrogateCharEntity,
				// Token: 0x04000251 RID: 593
				[Token(Token = "0x4000251")]
				Whitespace,
				// Token: 0x04000252 RID: 594
				[Token(Token = "0x4000252")]
				String,
				// Token: 0x04000253 RID: 595
				[Token(Token = "0x4000253")]
				StringChars,
				// Token: 0x04000254 RID: 596
				[Token(Token = "0x4000254")]
				Raw,
				// Token: 0x04000255 RID: 597
				[Token(Token = "0x4000255")]
				RawChars,
				// Token: 0x04000256 RID: 598
				[Token(Token = "0x4000256")]
				ValueString
			}

			// Token: 0x02000059 RID: 89
			[Token(Token = "0x2000059")]
			private class Item
			{
				// Token: 0x06000417 RID: 1047 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000417")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				internal Item()
				{
				}

				// Token: 0x06000418 RID: 1048 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x4B93D10", Offset = "0x4B92910", VA = "0x184B93D10")]
				internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data)
				{
				}

				// Token: 0x04000257 RID: 599
				[Token(Token = "0x4000257")]
				[FieldOffset(Offset = "0x10")]
				internal XmlWellFormedWriter.AttributeValueCache.ItemType type;

				// Token: 0x04000258 RID: 600
				[Token(Token = "0x4000258")]
				[FieldOffset(Offset = "0x18")]
				internal object data;
			}

			// Token: 0x0200005A RID: 90
			[Token(Token = "0x200005A")]
			private class BufferChunk
			{
				// Token: 0x06000419 RID: 1049 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x16EA240", Offset = "0x16E8E40", VA = "0x1816EA240")]
				internal BufferChunk(char[] buffer, int index, int count)
				{
				}

				// Token: 0x04000259 RID: 601
				[Token(Token = "0x4000259")]
				[FieldOffset(Offset = "0x10")]
				internal char[] buffer;

				// Token: 0x0400025A RID: 602
				[Token(Token = "0x400025A")]
				[FieldOffset(Offset = "0x18")]
				internal int index;

				// Token: 0x0400025B RID: 603
				[Token(Token = "0x400025B")]
				[FieldOffset(Offset = "0x1C")]
				internal int count;
			}
		}
	}
}
