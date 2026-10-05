using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	internal abstract class XmlRawWriter : XmlWriter
	{
		// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x4F83750", Offset = "0x4F82350", VA = "0x184F83750", Slot = "5")]
		public override void WriteStartDocument()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x4F837C0", Offset = "0x4F823C0", VA = "0x184F837C0", Slot = "6")]
		public override void WriteStartDocument(bool standalone)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x4F83540", Offset = "0x4F82140", VA = "0x184F83540", Slot = "7")]
		public override void WriteEndDocument()
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x4F835B0", Offset = "0x4F821B0", VA = "0x184F835B0", Slot = "10")]
		public override void WriteEndElement()
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x4F83670", Offset = "0x4F82270", VA = "0x184F83670", Slot = "11")]
		public override void WriteFullEndElement()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x4F832A0", Offset = "0x4F81EA0", VA = "0x184F832A0", Slot = "25")]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x4F83230", Offset = "0x4F81E30", VA = "0x184F83230", Slot = "30")]
		public override string LookupPrefix(string ns)
		{
			return null;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x1700004B")]
		public override WriteState WriteState
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x4F83940", Offset = "0x4F82540", VA = "0x184F83940", Slot = "27")]
			get
			{
				return WriteState.Start;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x4F829F0", Offset = "0x4F815F0", VA = "0x184F829F0", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4F833B0", Offset = "0x4F81FB0", VA = "0x184F833B0", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4F83880", Offset = "0x4F82480", VA = "0x184F83880", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4F829F0", Offset = "0x4F815F0", VA = "0x184F829F0", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4F7B7E0", Offset = "0x4F7A3E0", VA = "0x184F7B7E0", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4F7B7E0", Offset = "0x4F7A3E0", VA = "0x184F7B7E0", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4F829F0", Offset = "0x4F815F0", VA = "0x184F829F0", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x4F829F0", Offset = "0x4F815F0", VA = "0x184F829F0", Slot = "31")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x1700004C RID: 76
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004C")]
		internal virtual IXmlNamespaceResolver NamespaceResolver
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "33")]
			set
			{
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		internal virtual void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
		internal virtual void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060001F2 RID: 498
		[Token(Token = "0x60001F2")]
		internal abstract void StartElementContent();

		// Token: 0x060001F3 RID: 499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "37")]
		internal virtual void OnRootElement(ConformanceLevel conformanceLevel)
		{
		}

		// Token: 0x060001F4 RID: 500
		[Token(Token = "0x60001F4")]
		internal abstract void WriteEndElement(string prefix, string localName, string ns);

		// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x4F836E0", Offset = "0x4F822E0", VA = "0x184F836E0", Slot = "39")]
		internal virtual void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060001F6 RID: 502
		[Token(Token = "0x60001F6")]
		internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x1700004D")]
		internal virtual bool SupportsNamespaceDeclarationInChunks
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x4F83830", Offset = "0x4F82430", VA = "0x184F83830", Slot = "42")]
		internal virtual void WriteStartNamespaceDeclaration(string prefix)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4F83620", Offset = "0x4F82220", VA = "0x184F83620", Slot = "43")]
		internal virtual void WriteEndNamespaceDeclaration()
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4F83450", Offset = "0x4F82050", VA = "0x184F83450", Slot = "44")]
		internal virtual void WriteEndBase64()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4F831F0", Offset = "0x4F81DF0", VA = "0x184F831F0", Slot = "45")]
		internal virtual void Close(WriteState currentState)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected XmlRawWriter()
		{
		}

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x10")]
		protected XmlRawWriterBase64Encoder base64Encoder;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x18")]
		protected IXmlNamespaceResolver resolver;
	}
}
