using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4F76CE0", Offset = "0x4F758E0", VA = "0x184F76CE0")]
		public HtmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4F76D10", Offset = "0x4F75910", VA = "0x184F76D10")]
		public HtmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4F756B0", Offset = "0x4F742B0", VA = "0x184F756B0", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4F76640", Offset = "0x4F75240", VA = "0x184F76640", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4F75550", Offset = "0x4F74150", VA = "0x184F75550", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4F75A40", Offset = "0x4F74640", VA = "0x184F75A40", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x4F75C10", Offset = "0x4F74810", VA = "0x184F75C10", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4F76490", Offset = "0x4F75090", VA = "0x184F76490", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4F759B0", Offset = "0x4F745B0", VA = "0x184F759B0", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4F76320", Offset = "0x4F74F20", VA = "0x184F76320", Slot = "16")]
		public override void WriteProcessingInstruction(string target, string text)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4F76790", Offset = "0x4F75390", VA = "0x184F76790", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4F75BA0", Offset = "0x4F747A0", VA = "0x184F75BA0", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x4F755B0", Offset = "0x4F741B0", VA = "0x184F755B0", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4F76880", Offset = "0x4F75480", VA = "0x184F76880", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4F75620", Offset = "0x4F74220", VA = "0x184F75620", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4F75230", Offset = "0x4F73E30", VA = "0x184F75230")]
		private void Init(XmlWriterSettings settings)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4F76130", Offset = "0x4F74D30", VA = "0x184F76130")]
		protected void WriteMetaElement()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x4F76110", Offset = "0x4F74D10", VA = "0x184F76110")]
		protected unsafe void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4F75D70", Offset = "0x4F74970", VA = "0x184F75D70")]
		protected unsafe void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4F75DB0", Offset = "0x4F749B0", VA = "0x184F75DB0")]
		private unsafe void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4F768F0", Offset = "0x4F754F0", VA = "0x184F768F0")]
		private unsafe void WriteUriAttributeText(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4F75490", Offset = "0x4F74090", VA = "0x184F75490")]
		private void OutputRestAmps()
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xB8")]
		protected ByteStack elementScope;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xC0")]
		protected ElementProperties currentElementProperties;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xC4")]
		private AttributeProperties currentAttributeProperties;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xC8")]
		private bool endsWithAmpersand;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xD0")]
		private byte[] uriEscapingBuffer;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xD8")]
		private string mediaType;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xE0")]
		private bool doNotEscapeUriAttributes;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x0")]
		protected static TernaryTreeReadOnly elementPropertySearch;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x8")]
		protected static TernaryTreeReadOnly attributePropertySearch;
	}
}
