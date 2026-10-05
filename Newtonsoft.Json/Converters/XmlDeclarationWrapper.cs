using System;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x06000A85 RID: 2693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x4DF4B70", Offset = "0x4DF3770", VA = "0x184DF4B70")]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DC")]
		public string Version
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x4DF4BF0", Offset = "0x4DF37F0", VA = "0x184DF4BF0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001DD")]
		public string Encoding
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x4DF4BB0", Offset = "0x4DF37B0", VA = "0x184DF4BB0", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x4DF4C10", Offset = "0x4DF3810", VA = "0x184DF4C10", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001DE")]
		public string Standalone
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x4DF4BD0", Offset = "0x4DF37D0", VA = "0x184DF4BD0", Slot = "18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x4DF4C30", Offset = "0x4DF3830", VA = "0x184DF4C30", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDeclaration _declaration;
	}
}
