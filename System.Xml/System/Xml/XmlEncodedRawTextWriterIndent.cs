using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4F7CE90", Offset = "0x4F7BA90", VA = "0x184F7CE90")]
		public XmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4F7CEC0", Offset = "0x4F7BAC0", VA = "0x184F7CEC0")]
		public XmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x4F7C790", Offset = "0x4F7B390", VA = "0x184F7C790", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4F7CCF0", Offset = "0x4F7B8F0", VA = "0x184F7CCF0", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4F7C500", Offset = "0x4F7B100", VA = "0x184F7C500", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x371A410", Offset = "0x3719010", VA = "0x18371A410", Slot = "37")]
		internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4F7C800", Offset = "0x4F7B400", VA = "0x184F7C800", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4F7C9D0", Offset = "0x4F7B5D0", VA = "0x184F7C9D0", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4F7CC90", Offset = "0x4F7B890", VA = "0x184F7CC90", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4F7C690", Offset = "0x4F7B290", VA = "0x184F7C690", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4F7C750", Offset = "0x4F7B350", VA = "0x184F7C750", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x4F7CB40", Offset = "0x4F7B740", VA = "0x184F7CB40", Slot = "16")]
		public override void WriteProcessingInstruction(string target, string text)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4F7C8D0", Offset = "0x4F7B4D0", VA = "0x184F7C8D0", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x4F7C6A0", Offset = "0x4F7B2A0", VA = "0x184F7C6A0", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x4F7CE00", Offset = "0x4F7BA00", VA = "0x184F7CE00", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x4F7CE10", Offset = "0x4F7BA10", VA = "0x184F7CE10", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4F7CD80", Offset = "0x4F7B980", VA = "0x184F7CD80", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4F7C6B0", Offset = "0x4F7B2B0", VA = "0x184F7C6B0", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4F7CB90", Offset = "0x4F7B790", VA = "0x184F7CB90", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4F7CC20", Offset = "0x4F7B820", VA = "0x184F7CC20", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x4F7C580", Offset = "0x4F7B180", VA = "0x184F7C580", Slot = "25")]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x4F7C3C0", Offset = "0x4F7AFC0", VA = "0x184F7C3C0")]
		private void Init(XmlWriterSettings settings)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x4F7CAA0", Offset = "0x4F7B6A0", VA = "0x184F7CAA0")]
		private void WriteIndent()
		{
		}

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0xB8")]
		protected int indentLevel;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0xBC")]
		protected bool newLineOnAttributes;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0xC0")]
		protected string indentChars;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0xC8")]
		protected bool mixedContent;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0xD0")]
		private BitStack mixedContentStack;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0xD8")]
		protected ConformanceLevel conformanceLevel;
	}
}
