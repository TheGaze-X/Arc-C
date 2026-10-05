using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.Extensions
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	public sealed class HeaderValue
	{
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600293E RID: 10558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EF")]
		public string Key
		{
			[Token(Token = "0x600293D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600293E")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F0")]
		public string Value
		{
			[Token(Token = "0x600293F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002940")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F1")]
		public List<HeaderValue> Options
		{
			[Token(Token = "0x6002941")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002942")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x00011700 File Offset: 0x0000F900
		[Token(Token = "0x170005F2")]
		public bool HasValue
		{
			[Token(Token = "0x6002943")]
			[Address(RVA = "0x20086A0", Offset = "0x20072A0", VA = "0x1820086A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002944")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HeaderValue()
		{
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002945")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public HeaderValue(string key)
		{
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002946")]
		[Address(RVA = "0x53AAF60", Offset = "0x53A9B60", VA = "0x1853AAF60")]
		public void Parse(string headerStr, ref int pos)
		{
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x53AB010", Offset = "0x53A9C10", VA = "0x1853AB010")]
		public bool TryGetOption(string key, out HeaderValue option)
		{
			return default(bool);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x53AAA80", Offset = "0x53A9680", VA = "0x1853AAA80")]
		private void ParseImplementation(string headerStr, ref int pos, bool isOptionIsAnOption)
		{
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x53AAF80", Offset = "0x53A9B80", VA = "0x1853AAF80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
