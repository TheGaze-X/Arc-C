using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x4F7A4A0", Offset = "0x4F790A0", VA = "0x184F7A4A0")]
		public TextUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4F7A430", Offset = "0x4F79030", VA = "0x184F7A430", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4F7A3B0", Offset = "0x4F78FB0", VA = "0x184F7A3B0", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "40")]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x17000036")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4F7A460", Offset = "0x4F79060", VA = "0x184F7A460", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4F7A490", Offset = "0x4F79090", VA = "0x184F7A490", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4F7A490", Offset = "0x4F79090", VA = "0x184F7A490", Slot = "20")]
		public override void WriteString(string textBlock)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4F7A470", Offset = "0x4F79070", VA = "0x184F7A470", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x4F7A470", Offset = "0x4F79070", VA = "0x184F7A470", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x4F7A490", Offset = "0x4F79090", VA = "0x184F7A490", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}
	}
}
