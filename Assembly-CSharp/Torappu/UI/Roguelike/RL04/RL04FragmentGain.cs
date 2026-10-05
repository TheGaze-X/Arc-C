using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056AC RID: 22188
	[Token(Token = "0x20056AC")]
	public class RL04FragmentGain : RoguelikeDungeonModule
	{
		// Token: 0x060208A7 RID: 133287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208A7")]
		[Address(RVA = "0x1AB0940", Offset = "0x1AAF540", VA = "0x181AB0940", Slot = "4")]
		protected override void OnCreate()
		{
		}

		// Token: 0x060208A8 RID: 133288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208A8")]
		[Address(RVA = "0x1AB0A80", Offset = "0x1AAF680", VA = "0x181AB0A80")]
		private void _HandleFragmentGainPushMsg(object arg)
		{
		}

		// Token: 0x060208A9 RID: 133289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208A9")]
		[Address(RVA = "0x1AB1040", Offset = "0x1AAFC40", VA = "0x181AB1040")]
		public RL04FragmentGain()
		{
		}

		// Token: 0x060208AA RID: 133290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208AA")]
		[Address(RVA = "0x1A4A420", Offset = "0x1A49020", VA = "0x181A4A420")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0402C171 RID: 180593
		[Token(Token = "0x402C171")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402C172 RID: 180594
		[Token(Token = "0x402C172")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleFragmentGainPushMsg;

		// Token: 0x0402C173 RID: 180595
		[Token(Token = "0x402C173")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
