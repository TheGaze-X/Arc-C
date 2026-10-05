using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x4FAF720", Offset = "0x4FAE320", VA = "0x184FAF720")]
		public XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x4FAED90", Offset = "0x4FAD990", VA = "0x184FAED90", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x4FAF460", Offset = "0x4FAE060", VA = "0x184FAF460", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x4FAEC50", Offset = "0x4FAD850", VA = "0x184FAEC50", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x4FAEC40", Offset = "0x4FAD840", VA = "0x184FAEC40", Slot = "37")]
		internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x4FAEE00", Offset = "0x4FADA00", VA = "0x184FAEE00", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x4FAEF60", Offset = "0x4FADB60", VA = "0x184FAEF60", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x4FAF340", Offset = "0x4FADF40", VA = "0x184FAF340", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x4FAECE0", Offset = "0x4FAD8E0", VA = "0x184FAECE0", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x4FAED50", Offset = "0x4FAD950", VA = "0x184FAED50", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x4FAF150", Offset = "0x4FADD50", VA = "0x184FAF150", Slot = "16")]
		public override void WriteProcessingInstruction(string target, string text)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x4FAEE90", Offset = "0x4FADA90", VA = "0x184FAEE90", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x4FAECF0", Offset = "0x4FAD8F0", VA = "0x184FAECF0", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x4FAF5E0", Offset = "0x4FAE1E0", VA = "0x184FAF5E0", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x4FAF570", Offset = "0x4FAE170", VA = "0x184FAF570", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4FAF570", Offset = "0x4FAE170", VA = "0x184FAF570", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x4FAED00", Offset = "0x4FAD900", VA = "0x184FAED00", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x4FAF2F0", Offset = "0x4FADEF0", VA = "0x184FAF2F0", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x4FAF290", Offset = "0x4FADE90", VA = "0x184FAF290", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x4FAECC0", Offset = "0x4FAD8C0", VA = "0x184FAECC0", Slot = "25")]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x4FAEB10", Offset = "0x4FAD710", VA = "0x184FAEB10")]
		private void Init(XmlWriterSettings settings)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4FAF0B0", Offset = "0x4FADCB0", VA = "0x184FAF0B0")]
		private void WriteIndent()
		{
		}

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x88")]
		protected int indentLevel;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x8C")]
		protected bool newLineOnAttributes;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x90")]
		protected string indentChars;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x98")]
		protected bool mixedContent;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0xA0")]
		private BitStack mixedContentStack;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0xA8")]
		protected ConformanceLevel conformanceLevel;
	}
}
