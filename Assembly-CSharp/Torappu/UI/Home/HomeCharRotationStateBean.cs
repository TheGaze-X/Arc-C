using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B64 RID: 19300
	[Token(Token = "0x2004B64")]
	public class HomeCharRotationStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D0E1 RID: 119009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0E1")]
		[Address(RVA = "0x169B6B0", Offset = "0x169A2B0", VA = "0x18169B6B0")]
		public HomeCharRotationStateBean()
		{
		}

		// Token: 0x040261CC RID: 156108
		[Token(Token = "0x40261CC")]
		[FieldOffset(Offset = "0x10")]
		public HomeCharRotationProperty property;

		// Token: 0x040261CD RID: 156109
		[Token(Token = "0x40261CD")]
		[FieldOffset(Offset = "0x18")]
		public bool playedDynEntranceOnExit;

		// Token: 0x040261CE RID: 156110
		[Token(Token = "0x40261CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
