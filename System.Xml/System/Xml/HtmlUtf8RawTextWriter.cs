using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4F78B30", Offset = "0x4F77730", VA = "0x184F78B30")]
		public HtmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4F779C0", Offset = "0x4F765C0", VA = "0x184F779C0", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4F78570", Offset = "0x4F77170", VA = "0x184F78570", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4F778B0", Offset = "0x4F764B0", VA = "0x184F778B0", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x4F77C20", Offset = "0x4F76820", VA = "0x184F77C20", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4F77DA0", Offset = "0x4F769A0", VA = "0x184F77DA0", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4F78410", Offset = "0x4F77010", VA = "0x184F78410", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4F77BB0", Offset = "0x4F767B0", VA = "0x184F77BB0", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4F78310", Offset = "0x4F76F10", VA = "0x184F78310", Slot = "16")]
		public override void WriteProcessingInstruction(string target, string text)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x4F78680", Offset = "0x4F77280", VA = "0x184F78680", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x4F77D30", Offset = "0x4F76930", VA = "0x184F77D30", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x4F77900", Offset = "0x4F76500", VA = "0x184F77900", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4F78750", Offset = "0x4F77350", VA = "0x184F78750", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x4F77970", Offset = "0x4F76570", VA = "0x184F77970", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4F775B0", Offset = "0x4F761B0", VA = "0x184F775B0")]
		private void Init(XmlWriterSettings settings)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4F781E0", Offset = "0x4F76DE0", VA = "0x184F781E0")]
		protected void WriteMetaElement()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4F781C0", Offset = "0x4F76DC0", VA = "0x184F781C0")]
		protected unsafe void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4F77EB0", Offset = "0x4F76AB0", VA = "0x184F77EB0")]
		protected unsafe void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4F77EF0", Offset = "0x4F76AF0", VA = "0x184F77EF0")]
		private unsafe void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4F787C0", Offset = "0x4F773C0", VA = "0x184F787C0")]
		private unsafe void WriteUriAttributeText(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4F77810", Offset = "0x4F76410", VA = "0x184F77810")]
		private void OutputRestAmps()
		{
		}

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x88")]
		protected ByteStack elementScope;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x90")]
		protected ElementProperties currentElementProperties;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x94")]
		private AttributeProperties currentAttributeProperties;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x98")]
		private bool endsWithAmpersand;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0xA0")]
		private byte[] uriEscapingBuffer;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0xA8")]
		private string mediaType;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0xB0")]
		private bool doNotEscapeUriAttributes;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		protected static TernaryTreeReadOnly elementPropertySearch;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x8")]
		protected static TernaryTreeReadOnly attributePropertySearch;
	}
}
