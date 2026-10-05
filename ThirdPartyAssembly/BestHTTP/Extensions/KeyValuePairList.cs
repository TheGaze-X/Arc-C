using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.Extensions
{
	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	public class KeyValuePairList
	{
		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F3")]
		public List<HeaderValue> Values
		{
			[Token(Token = "0x6002952")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002953")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x53C4FD0", Offset = "0x53C3BD0", VA = "0x1853C4FD0")]
		public bool TryGet(string valueKeyName, out HeaderValue param)
		{
			return default(bool);
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KeyValuePairList()
		{
		}
	}
}
