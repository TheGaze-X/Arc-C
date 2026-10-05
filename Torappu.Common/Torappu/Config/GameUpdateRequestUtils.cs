using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Config
{
	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	public static class GameUpdateRequestUtils
	{
		// Token: 0x06000D5C RID: 3420 RVA: 0x000087D4 File Offset: 0x000069D4
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x55818C0", Offset = "0x55804C0", VA = "0x1855818C0")]
		public static GetLatestGameRequest CreateGetLatestGameRequest([Optional] string localVersion)
		{
			return default(GetLatestGameRequest);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x55820D0", Offset = "0x5580CD0", VA = "0x1855820D0")]
		private static string _GetVersion()
		{
			return null;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x5581D60", Offset = "0x5580960", VA = "0x185581D60")]
		private static string _GetAppCode()
		{
			return null;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x5581E50", Offset = "0x5580A50", VA = "0x185581E50")]
		private static string _GetRuntimeChannelName()
		{
			return null;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x5581F90", Offset = "0x5580B90", VA = "0x185581F90")]
		private static string _GetRuntimeSubChannelName()
		{
			return null;
		}

		// Token: 0x04000D7D RID: 3453
		[Token(Token = "0x4000D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string DEFAULT_SOURCE;
	}
}
