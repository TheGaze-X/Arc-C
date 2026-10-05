using System;
using System.Collections;
using System.Security;
using Il2CppDummyDll;

namespace Mono.Xml
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4AB20E0", Offset = "0x4AB0CE0", VA = "0x184AB20E0")]
		public SecurityParser()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4AB1B20", Offset = "0x4AB0720", VA = "0x184AB1B20")]
		public void LoadXml(string xml)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
		public System.Security.SecurityElement ToXml()
		{
			return null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnStartParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public void OnProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		public void OnIgnorableWhitespace(string s)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4AB1D40", Offset = "0x4AB0940", VA = "0x184AB1D40", Slot = "6")]
		public void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x4AB1C60", Offset = "0x4AB0860", VA = "0x184AB1C60", Slot = "7")]
		public void OnEndElement(string name)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4AB1BE0", Offset = "0x4AB07E0", VA = "0x184AB1BE0", Slot = "9")]
		public void OnChars(string ch)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void OnEndParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x68")]
		private System.Security.SecurityElement root;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x70")]
		private System.Security.SecurityElement current;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x78")]
		private System.Collections.Stack stack;
	}
}
