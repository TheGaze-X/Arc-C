using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4F7A440", Offset = "0x4F79040", VA = "0x184F7A440")]
		public TextEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x4F7A450", Offset = "0x4F79050", VA = "0x184F7A450")]
		public TextEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x4F7A430", Offset = "0x4F79030", VA = "0x184F7A430", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x4F7A3B0", Offset = "0x4F78FB0", VA = "0x184F7A3B0", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "40")]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x17000035")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x4F7A2B0", Offset = "0x4F78EB0", VA = "0x184F7A2B0", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x4F7A3C0", Offset = "0x4F78FC0", VA = "0x184F7A3C0", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x4F7A3C0", Offset = "0x4F78FC0", VA = "0x184F7A3C0", Slot = "20")]
		public override void WriteString(string textBlock)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x4F7A320", Offset = "0x4F78F20", VA = "0x184F7A320", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x4F7A320", Offset = "0x4F78F20", VA = "0x184F7A320", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4F7A3C0", Offset = "0x4F78FC0", VA = "0x184F7A3C0", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}
	}
}
