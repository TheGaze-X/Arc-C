using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004148 RID: 16712
	[Token(Token = "0x2004148")]
	public class SandboxV2BasementUpgradeState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06019CFF RID: 105727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CFF")]
		[Address(RVA = "0x12A51B0", Offset = "0x12A3DB0", VA = "0x1812A51B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019D00 RID: 105728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D00")]
		[Address(RVA = "0x12A5760", Offset = "0x12A4360", VA = "0x1812A5760", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06019D01 RID: 105729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019D01")]
		[Address(RVA = "0x12A4F00", Offset = "0x12A3B00", VA = "0x1812A4F00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019D02 RID: 105730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D02")]
		[Address(RVA = "0x12A54E0", Offset = "0x12A40E0", VA = "0x1812A54E0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019D03 RID: 105731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D03")]
		[Address(RVA = "0x12A57C0", Offset = "0x12A43C0", VA = "0x1812A57C0")]
		private void _OnBasementUpgrade()
		{
		}

		// Token: 0x06019D04 RID: 105732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D04")]
		[Address(RVA = "0x12A59E0", Offset = "0x12A45E0", VA = "0x1812A59E0")]
		private void _OnUpgradeResp(SandboxV2BasementUpgradeResponse resp)
		{
		}

		// Token: 0x06019D05 RID: 105733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D05")]
		[Address(RVA = "0x12A5C20", Offset = "0x12A4820", VA = "0x1812A5C20")]
		private void _PlayUpgradeAudio()
		{
		}

		// Token: 0x06019D06 RID: 105734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D06")]
		[Address(RVA = "0x12A5CB0", Offset = "0x12A48B0", VA = "0x1812A5CB0")]
		private void _UpgradeAnimFinish()
		{
		}

		// Token: 0x06019D07 RID: 105735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D07")]
		[Address(RVA = "0x12A4F60", Offset = "0x12A3B60", VA = "0x1812A4F60")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x06019D08 RID: 105736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D08")]
		[Address(RVA = "0x12A5E10", Offset = "0x12A4A10", VA = "0x1812A5E10")]
		public SandboxV2BasementUpgradeState()
		{
		}

		// Token: 0x06019D09 RID: 105737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D09")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019D0A RID: 105738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D0A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04020650 RID: 132688
		[Token(Token = "0x4020650")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2BasementUpgradeView _upgradeView;

		// Token: 0x04020651 RID: 132689
		[Token(Token = "0x4020651")]
		[NonSerialized]
		public const int MSG_SANDBOX_V2_UPGRADE_BASEMENT = 0;

		// Token: 0x04020652 RID: 132690
		[Token(Token = "0x4020652")]
		[NonSerialized]
		public const int MSG_SANDBOX_V2_CLOSE_STATE = 1;

		// Token: 0x04020653 RID: 132691
		[Token(Token = "0x4020653")]
		private const string ANIM_UPGRADE = "sandboxv2_basement_upgrade_completed";

		// Token: 0x04020654 RID: 132692
		[Token(Token = "0x4020654")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2BasementUpgradeStateBean m_cachedBean;

		// Token: 0x04020655 RID: 132693
		[Token(Token = "0x4020655")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedTopicId;

		// Token: 0x04020656 RID: 132694
		[Token(Token = "0x4020656")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020657 RID: 132695
		[Token(Token = "0x4020657")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04020658 RID: 132696
		[Token(Token = "0x4020658")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020659 RID: 132697
		[Token(Token = "0x4020659")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402065A RID: 132698
		[Token(Token = "0x402065A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBasementUpgrade;

		// Token: 0x0402065B RID: 132699
		[Token(Token = "0x402065B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUpgradeResp;

		// Token: 0x0402065C RID: 132700
		[Token(Token = "0x402065C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayUpgradeAudio;

		// Token: 0x0402065D RID: 132701
		[Token(Token = "0x402065D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpgradeAnimFinish;

		// Token: 0x0402065E RID: 132702
		[Token(Token = "0x402065E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x0402065F RID: 132703
		[Token(Token = "0x402065F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
