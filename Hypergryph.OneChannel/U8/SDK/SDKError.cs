using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public struct SDKError
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700003C")]
		public string code
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700003D")]
		public string msg
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4A0D4D0", Offset = "0x4A0C0D0", VA = "0x184A0D4D0")]
		public SDKError(string content)
		{
		}

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		public const int NetworkRequestFailed = -1000;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		public const int ConcurrentCall = -1001;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		public const int ErrorNeedExit = -1002;
	}
}
