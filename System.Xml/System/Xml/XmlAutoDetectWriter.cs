using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	internal class XmlAutoDetectWriter : XmlRawWriter
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4F7C260", Offset = "0x4F7AE60", VA = "0x184F7C260")]
		private XmlAutoDetectWriter(XmlWriterSettings writerSettings)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4F7C220", Offset = "0x4F7AE20", VA = "0x184F7C220")]
		public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4F7C1E0", Offset = "0x4F7ADE0", VA = "0x184F7C1E0")]
		public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4F7B8A0", Offset = "0x4F7A4A0", VA = "0x184F7B8A0", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4F7BD50", Offset = "0x4F7A950", VA = "0x184F7BD50", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x4F7BCC0", Offset = "0x4F7A8C0", VA = "0x184F7BCC0", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x4F7B930", Offset = "0x4F7A530", VA = "0x184F7B930", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4F7B6E0", Offset = "0x4F7A2E0", VA = "0x184F7B6E0", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4F7B840", Offset = "0x4F7A440", VA = "0x184F7B840", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4F7BB60", Offset = "0x4F7A760", VA = "0x184F7BB60", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4F7C0B0", Offset = "0x4F7ACB0", VA = "0x184F7C0B0", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4F7BF30", Offset = "0x4F7AB30", VA = "0x184F7BF30", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4F7B7E0", Offset = "0x4F7A3E0", VA = "0x184F7B7E0", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x4F7BBD0", Offset = "0x4F7A7D0", VA = "0x184F7BBD0", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4F7BC30", Offset = "0x4F7A830", VA = "0x184F7BC30", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4F7B9F0", Offset = "0x4F7A5F0", VA = "0x184F7B9F0", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4F7B770", Offset = "0x4F7A370", VA = "0x184F7B770", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4F7BFC0", Offset = "0x4F7ABC0", VA = "0x184F7BFC0", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4F7B5C0", Offset = "0x4F7A1C0", VA = "0x184F7B5C0", Slot = "25")]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4F7B650", Offset = "0x4F7A250", VA = "0x184F7B650", Slot = "26")]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x4F7B0B0", Offset = "0x4F79CB0", VA = "0x184F7B0B0", Slot = "28")]
		public override void Close()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4F7B420", Offset = "0x4F7A020", VA = "0x184F7B420", Slot = "29")]
		public override void Flush()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4F7C040", Offset = "0x4F7AC40", VA = "0x184F7C040", Slot = "31")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x17000038 RID: 56
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000038")]
		internal override IXmlNamespaceResolver NamespaceResolver
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x4F7C340", Offset = "0x4F7AF40", VA = "0x184F7C340", Slot = "33")]
			set
			{
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4F7C110", Offset = "0x4F7AD10", VA = "0x184F7C110", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4F7C170", Offset = "0x4F7AD70", VA = "0x184F7C170", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4F78CC0", Offset = "0x4F778C0", VA = "0x184F78CC0", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x4F7B970", Offset = "0x4F7A570", VA = "0x184F7B970", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x4F7BA60", Offset = "0x4F7A660", VA = "0x184F7BA60", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4F7BAE0", Offset = "0x4F7A6E0", VA = "0x184F7BAE0", Slot = "40")]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x17000039")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x4F79CD0", Offset = "0x4F788D0", VA = "0x184F79CD0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x4F7BEC0", Offset = "0x4F7AAC0", VA = "0x184F7BEC0", Slot = "42")]
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x4F79080", Offset = "0x4F77C80", VA = "0x184F79080", Slot = "43")]
		internal override void WriteEndNamespaceDeclaration()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4F7B480", Offset = "0x4F7A080", VA = "0x184F7B480")]
		private static bool IsHtmlTag(string tagName)
		{
			return default(bool);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4F7B410", Offset = "0x4F7A010", VA = "0x184F7B410")]
		private void EnsureWrappedWriter(XmlOutputMethod outMethod)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x4F7B560", Offset = "0x4F7A160", VA = "0x184F7B560")]
		private bool TextBlockCreatesWriter(string textBlock)
		{
			return default(bool);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4F7B110", Offset = "0x4F79D10", VA = "0x184F7B110")]
		private void CreateWrappedWriter(XmlOutputMethod outMethod)
		{
		}

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x20")]
		private XmlRawWriter wrapped;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x28")]
		private OnRemoveWriter onRemove;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x30")]
		private XmlWriterSettings writerSettings;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x38")]
		private XmlEventCache eventCache;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x40")]
		private TextWriter textWriter;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x48")]
		private Stream strm;
	}
}
