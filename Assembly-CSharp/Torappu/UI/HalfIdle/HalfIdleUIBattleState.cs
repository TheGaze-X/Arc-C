using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006755 RID: 26453
	[Token(Token = "0x2006755")]
	public class HalfIdleUIBattleState : State, ICompDialogCallBack
	{
		// Token: 0x06025F61 RID: 155489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025F61")]
		[Address(RVA = "0x20F7330", Offset = "0x20F5F30", VA = "0x1820F7330", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025F62 RID: 155490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F62")]
		[Address(RVA = "0x20F7530", Offset = "0x20F6130", VA = "0x1820F7530", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025F63 RID: 155491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F63")]
		[Address(RVA = "0x20F7390", Offset = "0x20F5F90", VA = "0x1820F7390", Slot = "23")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06025F64 RID: 155492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F64")]
		[Address(RVA = "0x20F79D0", Offset = "0x20F65D0", VA = "0x1820F79D0")]
		private void _HandleGiveUpDialogCallBack(ValueBundle output)
		{
		}

		// Token: 0x06025F65 RID: 155493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F65")]
		[Address(RVA = "0x20F7BC0", Offset = "0x20F67C0", VA = "0x1820F7BC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025F66 RID: 155494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F66")]
		[Address(RVA = "0x20F7710", Offset = "0x20F6310", VA = "0x1820F7710")]
		private void _BindBattleEvents()
		{
		}

		// Token: 0x06025F67 RID: 155495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F67")]
		[Address(RVA = "0x20F7D60", Offset = "0x20F6960", VA = "0x1820F7D60")]
		private void _InitializeViews()
		{
		}

		// Token: 0x06025F68 RID: 155496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F68")]
		[Address(RVA = "0x20F8210", Offset = "0x20F6E10", VA = "0x1820F8210")]
		private void _OnEquipPanelItemChanged(object arg)
		{
		}

		// Token: 0x06025F69 RID: 155497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F69")]
		[Address(RVA = "0x20F8070", Offset = "0x20F6C70", VA = "0x1820F8070")]
		private void _OnBattleItemChanged(object arg)
		{
		}

		// Token: 0x06025F6A RID: 155498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F6A")]
		[Address(RVA = "0x20F8360", Offset = "0x20F6F60", VA = "0x1820F8360")]
		private void _OnHudPanelVisibleChanged(object arg)
		{
		}

		// Token: 0x06025F6B RID: 155499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F6B")]
		[Address(RVA = "0x20F8140", Offset = "0x20F6D40", VA = "0x1820F8140")]
		private void _OnBattleStatusChanged(object arg)
		{
		}

		// Token: 0x06025F6C RID: 155500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F6C")]
		[Address(RVA = "0x20F8570", Offset = "0x20F7170", VA = "0x1820F8570")]
		private void _OnSystemMenuClicked(object arg)
		{
		}

		// Token: 0x06025F6D RID: 155501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F6D")]
		[Address(RVA = "0x20F7AE0", Offset = "0x20F66E0", VA = "0x1820F7AE0")]
		private void _HideDialogsImmediately(object arg)
		{
		}

		// Token: 0x06025F6E RID: 155502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F6E")]
		[Address(RVA = "0x20F8710", Offset = "0x20F7310", VA = "0x1820F8710")]
		private void _OnTipChanged(object arg)
		{
		}

		// Token: 0x06025F6F RID: 155503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F6F")]
		[Address(RVA = "0x20F84B0", Offset = "0x20F70B0", VA = "0x1820F84B0")]
		private void _OnNormalTipShow(object arg)
		{
		}

		// Token: 0x06025F70 RID: 155504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F70")]
		[Address(RVA = "0x20F87E0", Offset = "0x20F73E0", VA = "0x1820F87E0")]
		public HalfIdleUIBattleState()
		{
		}

		// Token: 0x06025F71 RID: 155505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F71")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04035658 RID: 218712
		[Token(Token = "0x4035658")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HalfIdleUITopStatusView _topStatusView;

		// Token: 0x04035659 RID: 218713
		[Token(Token = "0x4035659")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private HalfIdleUIImportantTipView _importantTipView;

		// Token: 0x0403565A RID: 218714
		[Token(Token = "0x403565A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private HalfIdleUINormalTipView _normalTipView;

		// Token: 0x0403565B RID: 218715
		[Token(Token = "0x403565B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private HalfIdleUIBattleItemListView _battleItemListView;

		// Token: 0x0403565C RID: 218716
		[Token(Token = "0x403565C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HalfIdleUIBattleEquipPanelView _equipPanelView;

		// Token: 0x0403565D RID: 218717
		[Token(Token = "0x403565D")]
		[FieldOffset(Offset = "0x78")]
		private HalfIdleUIBattlePage m_page;

		// Token: 0x0403565E RID: 218718
		[Token(Token = "0x403565E")]
		[FieldOffset(Offset = "0x80")]
		private HalfIdleBattleTipListProperty m_importantTipProperty;

		// Token: 0x0403565F RID: 218719
		[Token(Token = "0x403565F")]
		[FieldOffset(Offset = "0x88")]
		private HalfIdleUITopStatusProperty m_topStatusProperty;

		// Token: 0x04035660 RID: 218720
		[Token(Token = "0x4035660")]
		[FieldOffset(Offset = "0x90")]
		private HalfIdleUIBattleItemListProperty m_battleItemProperty;

		// Token: 0x04035661 RID: 218721
		[Token(Token = "0x4035661")]
		[FieldOffset(Offset = "0x98")]
		private HalfIdleUIBattleEquipPanelProperty m_equipPanelProperty;

		// Token: 0x04035662 RID: 218722
		[Token(Token = "0x4035662")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04035663 RID: 218723
		[Token(Token = "0x4035663")]
		[FieldOffset(Offset = "0xA4")]
		private int m_giveUpInst;

		// Token: 0x04035664 RID: 218724
		[Token(Token = "0x4035664")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035665 RID: 218725
		[Token(Token = "0x4035665")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035666 RID: 218726
		[Token(Token = "0x4035666")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04035667 RID: 218727
		[Token(Token = "0x4035667")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleGiveUpDialogCallBack;

		// Token: 0x04035668 RID: 218728
		[Token(Token = "0x4035668")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035669 RID: 218729
		[Token(Token = "0x4035669")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__BindBattleEvents;

		// Token: 0x0403566A RID: 218730
		[Token(Token = "0x403566A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitializeViews;

		// Token: 0x0403566B RID: 218731
		[Token(Token = "0x403566B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnEquipPanelItemChanged;

		// Token: 0x0403566C RID: 218732
		[Token(Token = "0x403566C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBattleItemChanged;

		// Token: 0x0403566D RID: 218733
		[Token(Token = "0x403566D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnHudPanelVisibleChanged;

		// Token: 0x0403566E RID: 218734
		[Token(Token = "0x403566E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBattleStatusChanged;

		// Token: 0x0403566F RID: 218735
		[Token(Token = "0x403566F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSystemMenuClicked;

		// Token: 0x04035670 RID: 218736
		[Token(Token = "0x4035670")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HideDialogsImmediately;

		// Token: 0x04035671 RID: 218737
		[Token(Token = "0x4035671")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnTipChanged;

		// Token: 0x04035672 RID: 218738
		[Token(Token = "0x4035672")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnNormalTipShow;

		// Token: 0x04035673 RID: 218739
		[Token(Token = "0x4035673")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
