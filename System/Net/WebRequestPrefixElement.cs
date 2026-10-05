using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	internal class WebRequestPrefixElement
	{
		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040E")]
		public IWebRequestCreate Creator
		{
			[Token(Token = "0x6001363")]
			[Address(RVA = "0x5065170", Offset = "0x5063D70", VA = "0x185065170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001364")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public WebRequestPrefixElement(string P, IWebRequestCreate C)
		{
		}

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[FieldOffset(Offset = "0x10")]
		public string Prefix;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		[FieldOffset(Offset = "0x18")]
		internal IWebRequestCreate creator;

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[FieldOffset(Offset = "0x20")]
		internal Type creatorType;
	}
}
