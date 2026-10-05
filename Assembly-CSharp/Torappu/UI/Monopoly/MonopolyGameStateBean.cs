using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004819 RID: 18457
	[Token(Token = "0x2004819")]
	public class MonopolyGameStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601BE87 RID: 114311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE87")]
		[Address(RVA = "0x153B1E0", Offset = "0x1539DE0", VA = "0x18153B1E0")]
		public MonopolyGameStateBean()
		{
		}

		// Token: 0x04024616 RID: 149014
		[Token(Token = "0x4024616")]
		[FieldOffset(Offset = "0x10")]
		public MonopolyGameProperty property;

		// Token: 0x04024617 RID: 149015
		[Token(Token = "0x4024617")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
