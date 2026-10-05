using System;
using Il2CppDummyDll;

namespace System.Net.Cache
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	public class RequestCachePolicy
	{
		// Token: 0x060018C1 RID: 6337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x50A41A0", Offset = "0x50A2DA0", VA = "0x1850A41A0")]
		public RequestCachePolicy(RequestCacheLevel level)
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x0000B190 File Offset: 0x00009390
		[Token(Token = "0x17000579")]
		public RequestCacheLevel Level
		{
			[Token(Token = "0x60018C2")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return RequestCacheLevel.Default;
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x50A4120", Offset = "0x50A2D20", VA = "0x1850A4120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x10")]
		private RequestCacheLevel m_Level;
	}
}
