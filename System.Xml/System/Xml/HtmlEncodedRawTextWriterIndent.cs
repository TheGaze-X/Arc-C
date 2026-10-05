using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4F751C0", Offset = "0x4F73DC0", VA = "0x184F751C0")]
		public HtmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4F75150", Offset = "0x4F73D50", VA = "0x184F75150")]
		public HtmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4F74D10", Offset = "0x4F73910", VA = "0x184F74D10", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4F74F50", Offset = "0x4F73B50", VA = "0x184F74F50", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4F74C90", Offset = "0x4F73890", VA = "0x184F74C90", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4F74D40", Offset = "0x4F73940", VA = "0x184F74D40", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4F74EA0", Offset = "0x4F73AA0", VA = "0x184F74EA0", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4F74C20", Offset = "0x4F73820", VA = "0x184F74C20", Slot = "46")]
		protected override void FlushBuffer()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4F74C40", Offset = "0x4F73840", VA = "0x184F74C40")]
		private void Init(XmlWriterSettings settings)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4F74E00", Offset = "0x4F73A00", VA = "0x184F74E00")]
		private void WriteIndent()
		{
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xE8")]
		private int indentLevel;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0xEC")]
		private int endBlockPos;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xF0")]
		private string indentChars;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xF8")]
		private bool newLineOnAttributes;
	}
}
