using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B65 RID: 19301
	[Token(Token = "0x2004B65")]
	public class HomeCheckInStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D0E2 RID: 119010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0E2")]
		[Address(RVA = "0x169B800", Offset = "0x169A400", VA = "0x18169B800")]
		public HomeCheckInStateBean()
		{
		}

		// Token: 0x040261CF RID: 156111
		[Token(Token = "0x40261CF")]
		[FieldOffset(Offset = "0x10")]
		public HomeCheckInProperty property;

		// Token: 0x040261D0 RID: 156112
		[Token(Token = "0x40261D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
