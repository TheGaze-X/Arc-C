using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AsyncLoader
{
	// Token: 0x020016CF RID: 5839
	[Token(Token = "0x20016CF")]
	public struct AsyncOrder : IHotfixable
	{
		// Token: 0x060093EF RID: 37871 RVA: 0x00039BA0 File Offset: 0x00037DA0
		[Token(Token = "0x60093EF")]
		[Address(RVA = "0x2B26BA0", Offset = "0x2B257A0", VA = "0x182B26BA0")]
		public int CompareTo(AsyncOrder other)
		{
			return 0;
		}

		// Token: 0x040089BF RID: 35263
		[Token(Token = "0x40089BF")]
		[FieldOffset(Offset = "0x0")]
		public int group;

		// Token: 0x040089C0 RID: 35264
		[Token(Token = "0x40089C0")]
		[FieldOffset(Offset = "0x4")]
		public int index;

		// Token: 0x040089C1 RID: 35265
		[Token(Token = "0x40089C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
