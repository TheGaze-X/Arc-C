using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FD8 RID: 20440
	[Token(Token = "0x2004FD8")]
	public class EnemyDuelStandModeViewModel : IHotfixable
	{
		// Token: 0x0601E597 RID: 124311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E597")]
		[Address(RVA = "0x1820470", Offset = "0x181F070", VA = "0x181820470")]
		public EnemyDuelStandModeViewModel()
		{
		}

		// Token: 0x0402892F RID: 166191
		[Token(Token = "0x402892F")]
		[FieldOffset(Offset = "0x10")]
		public int protectionOffRoundNum;

		// Token: 0x04028930 RID: 166192
		[Token(Token = "0x4028930")]
		[FieldOffset(Offset = "0x14")]
		public bool isSelfProtectionOff;

		// Token: 0x04028931 RID: 166193
		[Token(Token = "0x4028931")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
