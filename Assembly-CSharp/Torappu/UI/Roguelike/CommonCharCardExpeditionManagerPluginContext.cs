using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005467 RID: 21607
	[Token(Token = "0x2005467")]
	public class CommonCharCardExpeditionManagerPluginContext : RoguelikeCharCardExpeditionManagerPluginContextBase
	{
		// Token: 0x0601FCE2 RID: 130274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCE2")]
		[Address(RVA = "0x19E6AC0", Offset = "0x19E56C0", VA = "0x1819E6AC0", Slot = "26")]
		protected override void CustomLoadData()
		{
		}

		// Token: 0x0601FCE3 RID: 130275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FCE3")]
		[Address(RVA = "0x19E6CF0", Offset = "0x19E58F0", VA = "0x1819E6CF0", Slot = "27")]
		protected override string GetExpedConflictToast(PlayerRoguelikeV2.CurrentData.Troop.ExpedType expedType)
		{
			return null;
		}

		// Token: 0x0601FCE4 RID: 130276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCE4")]
		[Address(RVA = "0x19E6E40", Offset = "0x19E5A40", VA = "0x1819E6E40")]
		public CommonCharCardExpeditionManagerPluginContext()
		{
		}

		// Token: 0x0601FCE5 RID: 130277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCE5")]
		[Address(RVA = "0x19E6DE0", Offset = "0x19E59E0", VA = "0x1819E6DE0")]
		private void <>xLuaBaseProxy_CustomLoadData()
		{
		}

		// Token: 0x0402ADB2 RID: 175538
		[Token(Token = "0x402ADB2")]
		[FieldOffset(Offset = "0x30")]
		private string m_expeditionToastStr;

		// Token: 0x0402ADB3 RID: 175539
		[Token(Token = "0x402ADB3")]
		[FieldOffset(Offset = "0x38")]
		private string m_travelToastStr;

		// Token: 0x0402ADB4 RID: 175540
		[Token(Token = "0x402ADB4")]
		[FieldOffset(Offset = "0x40")]
		private string m_candleToastStr;

		// Token: 0x0402ADB5 RID: 175541
		[Token(Token = "0x402ADB5")]
		[FieldOffset(Offset = "0x48")]
		private string m_noUpgradeToastStr;

		// Token: 0x0402ADB6 RID: 175542
		[Token(Token = "0x402ADB6")]
		[FieldOffset(Offset = "0x50")]
		private string m_guidedToastStr;

		// Token: 0x0402ADB7 RID: 175543
		[Token(Token = "0x402ADB7")]
		[FieldOffset(Offset = "0x58")]
		private string m_nonGuidedToastStr;

		// Token: 0x0402ADB8 RID: 175544
		[Token(Token = "0x402ADB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CustomLoadData;

		// Token: 0x0402ADB9 RID: 175545
		[Token(Token = "0x402ADB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExpedConflictToast;

		// Token: 0x0402ADBA RID: 175546
		[Token(Token = "0x402ADBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
