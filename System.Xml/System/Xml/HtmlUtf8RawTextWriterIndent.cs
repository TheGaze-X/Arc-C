using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x4F77540", Offset = "0x4F76140", VA = "0x184F77540")]
		public HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x4F76F60", Offset = "0x4F75B60", VA = "0x184F76F60", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4F77340", Offset = "0x4F75F40", VA = "0x184F77340", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x4F76EA0", Offset = "0x4F75AA0", VA = "0x184F76EA0", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4F76F90", Offset = "0x4F75B90", VA = "0x184F76F90", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4F77180", Offset = "0x4F75D80", VA = "0x184F77180", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x4F76E30", Offset = "0x4F75A30", VA = "0x184F76E30", Slot = "46")]
		protected override void FlushBuffer()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x4F76E50", Offset = "0x4F75A50", VA = "0x184F76E50")]
		private void Init(XmlWriterSettings settings)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4F77130", Offset = "0x4F75D30", VA = "0x184F77130")]
		private void WriteIndent()
		{
		}

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xB8")]
		private int indentLevel;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0xBC")]
		private int endBlockPos;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xC0")]
		private string indentChars;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xC8")]
		private bool newLineOnAttributes;
	}
}
