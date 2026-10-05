using System;
using Il2CppDummyDll;

namespace System.Net.Cache
{
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	internal class RequestCacheBinding
	{
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000577")]
		internal RequestCache Cache
		{
			[Token(Token = "0x60018BF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000578")]
		internal RequestCacheValidator Validator
		{
			[Token(Token = "0x60018C0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F51 RID: 3921
		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x10")]
		private RequestCache m_RequestCache;

		// Token: 0x04000F52 RID: 3922
		[Token(Token = "0x4000F52")]
		[FieldOffset(Offset = "0x18")]
		private RequestCacheValidator m_CacheValidator;
	}
}
