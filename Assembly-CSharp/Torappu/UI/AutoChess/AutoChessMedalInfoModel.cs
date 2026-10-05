using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200629C RID: 25244
	[Token(Token = "0x200629C")]
	public class AutoChessMedalInfoModel : IComparable, IHotfixable
	{
		// Token: 0x06024656 RID: 149078 RVA: 0x000C4170 File Offset: 0x000C2370
		[Token(Token = "0x6024656")]
		[Address(RVA = "0x1F2A7F0", Offset = "0x1F293F0", VA = "0x181F2A7F0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06024657 RID: 149079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024657")]
		[Address(RVA = "0x1F2A8F0", Offset = "0x1F294F0", VA = "0x181F2A8F0")]
		public AutoChessMedalInfoModel()
		{
		}

		// Token: 0x04032A41 RID: 207425
		[Token(Token = "0x4032A41")]
		[FieldOffset(Offset = "0x10")]
		public int count;

		// Token: 0x04032A42 RID: 207426
		[Token(Token = "0x4032A42")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x04032A43 RID: 207427
		[Token(Token = "0x4032A43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04032A44 RID: 207428
		[Token(Token = "0x4032A44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
