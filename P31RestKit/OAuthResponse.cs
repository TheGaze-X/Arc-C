using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class OAuthResponse
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public string responseText
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		[Token(Token = "0x17000008")]
		public string this[string ix]
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x4E0D5A0", Offset = "0x4E0C1A0", VA = "0x184E0D5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4E0D3F0", Offset = "0x4E0BFF0", VA = "0x184E0D3F0")]
		public OAuthResponse(string alltext)
		{
		}

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, string> _params;
	}
}
