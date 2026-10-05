using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200564F RID: 22095
	[Token(Token = "0x200564F")]
	public class RL04AlchemyController : AbstractRoguelikeAlchemyController
	{
		// Token: 0x06020692 RID: 132754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020692")]
		[Address(RVA = "0x1A8C5D0", Offset = "0x1A8B1D0", VA = "0x181A8C5D0", Slot = "4")]
		public override void OnInit()
		{
		}

		// Token: 0x06020693 RID: 132755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020693")]
		[Address(RVA = "0x1A8C390", Offset = "0x1A8AF90", VA = "0x181A8C390", Slot = "5")]
		public override void BindState(State state)
		{
		}

		// Token: 0x06020694 RID: 132756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020694")]
		[Address(RVA = "0x1A8CD70", Offset = "0x1A8B970", VA = "0x181A8CD70", Slot = "6")]
		public override void OnStateResume()
		{
		}

		// Token: 0x06020695 RID: 132757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020695")]
		[Address(RVA = "0x1A8C540", Offset = "0x1A8B140", VA = "0x181A8C540", Slot = "7")]
		public override IRoguelikeAlchemyViewModel GeneViewData(string topicId)
		{
			return null;
		}

		// Token: 0x06020696 RID: 132758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020696")]
		[Address(RVA = "0x1A8C8B0", Offset = "0x1A8B4B0", VA = "0x181A8C8B0", Slot = "8")]
		public override void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06020697 RID: 132759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020697")]
		[Address(RVA = "0x1A8CDD0", Offset = "0x1A8B9D0", VA = "0x181A8CDD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020698 RID: 132760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020698")]
		[Address(RVA = "0x1A8DC40", Offset = "0x1A8C840", VA = "0x181A8DC40")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x06020699 RID: 132761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020699")]
		[Address(RVA = "0x1A8E3C0", Offset = "0x1A8CFC0", VA = "0x181A8E3C0")]
		private void _SendStartAlchemyRequest(Action requestCallback)
		{
		}

		// Token: 0x0602069A RID: 132762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602069A")]
		[Address(RVA = "0x1A8DB80", Offset = "0x1A8C780", VA = "0x181A8DB80")]
		private void _OnStartAlchemyFailed()
		{
		}

		// Token: 0x0602069B RID: 132763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602069B")]
		[Address(RVA = "0x1A8D980", Offset = "0x1A8C580", VA = "0x181A8D980")]
		private void _OnStartAlchemyCompleted()
		{
		}

		// Token: 0x0602069C RID: 132764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602069C")]
		[Address(RVA = "0x1A8E060", Offset = "0x1A8CC60", VA = "0x181A8E060")]
		private void _SendLeaveAlchemyRequest(Action requestCallback)
		{
		}

		// Token: 0x0602069D RID: 132765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602069D")]
		[Address(RVA = "0x1A8D370", Offset = "0x1A8BF70", VA = "0x181A8D370")]
		private void _OnLeaveAlchemyCompleted()
		{
		}

		// Token: 0x0602069E RID: 132766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602069E")]
		[Address(RVA = "0x1A8D600", Offset = "0x1A8C200", VA = "0x181A8D600")]
		private void _OnLeaveAlchemyResponseFinish()
		{
		}

		// Token: 0x0602069F RID: 132767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602069F")]
		[Address(RVA = "0x1A8DDA0", Offset = "0x1A8C9A0", VA = "0x181A8DDA0")]
		private void _SendClaimAlchemyRewardRequest(int rewardIndex, Action requestCallback)
		{
		}

		// Token: 0x060206A0 RID: 132768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206A0")]
		[Address(RVA = "0x1A8D030", Offset = "0x1A8BC30", VA = "0x181A8D030")]
		private void _OnClaimAlchemyRewardCompleted()
		{
		}

		// Token: 0x060206A1 RID: 132769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206A1")]
		[Address(RVA = "0x1A8D8D0", Offset = "0x1A8C4D0", VA = "0x181A8D8D0")]
		private void _OnStartAlchemyBtnClick()
		{
		}

		// Token: 0x060206A2 RID: 132770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206A2")]
		[Address(RVA = "0x1A8D6C0", Offset = "0x1A8C2C0", VA = "0x181A8D6C0")]
		private void _OnLeaveBtnClick()
		{
		}

		// Token: 0x060206A3 RID: 132771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206A3")]
		[Address(RVA = "0x1A8CE80", Offset = "0x1A8BA80", VA = "0x181A8CE80")]
		private void _OnCancelLeaveClick()
		{
		}

		// Token: 0x060206A4 RID: 132772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206A4")]
		[Address(RVA = "0x1A8D1C0", Offset = "0x1A8BDC0", VA = "0x181A8D1C0")]
		private void _OnFragmentItemClick(string fragmentInstId)
		{
		}

		// Token: 0x060206A5 RID: 132773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206A5")]
		[Address(RVA = "0x1A8D800", Offset = "0x1A8C400", VA = "0x181A8D800")]
		private void _OnSlotItemClick(int slotIndex)
		{
		}

		// Token: 0x060206A6 RID: 132774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206A6")]
		[Address(RVA = "0x1A8CF60", Offset = "0x1A8BB60", VA = "0x181A8CF60")]
		private void _OnClaimAlchemyRewardClick(int rewardIndex)
		{
		}

		// Token: 0x060206A7 RID: 132775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206A7")]
		[Address(RVA = "0x1A8E9A0", Offset = "0x1A8D5A0", VA = "0x181A8E9A0")]
		public RL04AlchemyController()
		{
		}

		// Token: 0x0402BE26 RID: 179750
		[Token(Token = "0x402BE26")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL04AlchemyImplView _implView;

		// Token: 0x0402BE27 RID: 179751
		[Token(Token = "0x402BE27")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x0402BE28 RID: 179752
		[Token(Token = "0x402BE28")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _entryAnimLocation;

		// Token: 0x0402BE29 RID: 179753
		[Token(Token = "0x402BE29")]
		[NonSerialized]
		public const int MSG_SLOT_ITEM_CLICK = 1;

		// Token: 0x0402BE2A RID: 179754
		[Token(Token = "0x402BE2A")]
		[NonSerialized]
		public const int MSG_FRAGMENT_ITEM_CLICK = 2;

		// Token: 0x0402BE2B RID: 179755
		[Token(Token = "0x402BE2B")]
		[NonSerialized]
		public const int MSG_LEAVE_BTN_CLICK = 3;

		// Token: 0x0402BE2C RID: 179756
		[Token(Token = "0x402BE2C")]
		[NonSerialized]
		public const int MSG_START_ALCHEMY_BTN_CLICK = 4;

		// Token: 0x0402BE2D RID: 179757
		[Token(Token = "0x402BE2D")]
		[NonSerialized]
		public const int MSG_RESULT_VIEW_CLAIM_REWARD_CLICK = 5;

		// Token: 0x0402BE2E RID: 179758
		[Token(Token = "0x402BE2E")]
		[NonSerialized]
		public const int MSG_CANCEL_LEAVE_CLICK = 6;

		// Token: 0x0402BE2F RID: 179759
		[Token(Token = "0x402BE2F")]
		[FieldOffset(Offset = "0x38")]
		private RL04AlchemyViewModel m_viewModel;

		// Token: 0x0402BE30 RID: 179760
		[Token(Token = "0x402BE30")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_entryTween;

		// Token: 0x0402BE31 RID: 179761
		[Token(Token = "0x402BE31")]
		[FieldOffset(Offset = "0x48")]
		private State m_bindState;

		// Token: 0x0402BE32 RID: 179762
		[Token(Token = "0x402BE32")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402BE33 RID: 179763
		[Token(Token = "0x402BE33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402BE34 RID: 179764
		[Token(Token = "0x402BE34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindState;

		// Token: 0x0402BE35 RID: 179765
		[Token(Token = "0x402BE35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateResume;

		// Token: 0x0402BE36 RID: 179766
		[Token(Token = "0x402BE36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GeneViewData;

		// Token: 0x0402BE37 RID: 179767
		[Token(Token = "0x402BE37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402BE38 RID: 179768
		[Token(Token = "0x402BE38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BE39 RID: 179769
		[Token(Token = "0x402BE39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0402BE3A RID: 179770
		[Token(Token = "0x402BE3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendStartAlchemyRequest;

		// Token: 0x0402BE3B RID: 179771
		[Token(Token = "0x402BE3B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnStartAlchemyFailed;

		// Token: 0x0402BE3C RID: 179772
		[Token(Token = "0x402BE3C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnStartAlchemyCompleted;

		// Token: 0x0402BE3D RID: 179773
		[Token(Token = "0x402BE3D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SendLeaveAlchemyRequest;

		// Token: 0x0402BE3E RID: 179774
		[Token(Token = "0x402BE3E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnLeaveAlchemyCompleted;

		// Token: 0x0402BE3F RID: 179775
		[Token(Token = "0x402BE3F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnLeaveAlchemyResponseFinish;

		// Token: 0x0402BE40 RID: 179776
		[Token(Token = "0x402BE40")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SendClaimAlchemyRewardRequest;

		// Token: 0x0402BE41 RID: 179777
		[Token(Token = "0x402BE41")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnClaimAlchemyRewardCompleted;

		// Token: 0x0402BE42 RID: 179778
		[Token(Token = "0x402BE42")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnStartAlchemyBtnClick;

		// Token: 0x0402BE43 RID: 179779
		[Token(Token = "0x402BE43")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnLeaveBtnClick;

		// Token: 0x0402BE44 RID: 179780
		[Token(Token = "0x402BE44")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnCancelLeaveClick;

		// Token: 0x0402BE45 RID: 179781
		[Token(Token = "0x402BE45")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnFragmentItemClick;

		// Token: 0x0402BE46 RID: 179782
		[Token(Token = "0x402BE46")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnSlotItemClick;

		// Token: 0x0402BE47 RID: 179783
		[Token(Token = "0x402BE47")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnClaimAlchemyRewardClick;

		// Token: 0x0402BE48 RID: 179784
		[Token(Token = "0x402BE48")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
