using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	public static class UINotificationInterface
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x555F590", Offset = "0x555E190", VA = "0x18555F590")]
		public static void Bind(UINotificationInterface.FuncCollection funcs)
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x555F680", Offset = "0x555E280", VA = "0x18555F680")]
		public static void TextToast(string content, float delay = 0f, bool useDeduplicate = true)
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x555F600", Offset = "0x555E200", VA = "0x18555F600")]
		public static void LockToast(string content, float delay = 0f)
		{
		}

		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		[FieldOffset(Offset = "0x0")]
		private static UINotificationInterface.FuncCollection s_funcs;

		// Token: 0x02000184 RID: 388
		[Token(Token = "0x2000184")]
		public struct FuncCollection
		{
			// Token: 0x040008A9 RID: 2217
			[Token(Token = "0x40008A9")]
			[FieldOffset(Offset = "0x0")]
			public Action<string, float, bool> textToast;

			// Token: 0x040008AA RID: 2218
			[Token(Token = "0x40008AA")]
			[FieldOffset(Offset = "0x8")]
			public Action<string, float> lockToast;
		}
	}
}
