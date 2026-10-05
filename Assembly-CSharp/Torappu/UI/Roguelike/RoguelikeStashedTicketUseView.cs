using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005543 RID: 21827
	[Token(Token = "0x2005543")]
	public class RoguelikeStashedTicketUseView : DataBinder<RoguelikeStashedTicketUseProperty>
	{
		// Token: 0x17004B3D RID: 19261
		// (get) Token: 0x06020182 RID: 131458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B3D")]
		public RoguelikeStashedTicketUsePlugin plugin
		{
			[Token(Token = "0x6020182")]
			[Address(RVA = "0x1A43830", Offset = "0x1A42430", VA = "0x181A43830")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020183 RID: 131459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020183")]
		[Address(RVA = "0x1A431B0", Offset = "0x1A41DB0", VA = "0x181A431B0", Slot = "7")]
		public override void OnValueChanged(RoguelikeStashedTicketUseProperty property)
		{
		}

		// Token: 0x06020184 RID: 131460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020184")]
		[Address(RVA = "0x1A43630", Offset = "0x1A42230", VA = "0x181A43630")]
		public void ResetListToTop()
		{
		}

		// Token: 0x06020185 RID: 131461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020185")]
		[Address(RVA = "0x1A43520", Offset = "0x1A42120", VA = "0x181A43520")]
		public void PlayEnterAnim()
		{
		}

		// Token: 0x06020186 RID: 131462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020186")]
		[Address(RVA = "0x1A436B0", Offset = "0x1A422B0", VA = "0x181A436B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020187 RID: 131463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020187")]
		[Address(RVA = "0x1A43030", Offset = "0x1A41C30", VA = "0x181A43030")]
		public void OnLeaveClick()
		{
		}

		// Token: 0x06020188 RID: 131464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020188")]
		[Address(RVA = "0x1A42FA0", Offset = "0x1A41BA0", VA = "0x181A42FA0")]
		public void OnCancelLeaveClick()
		{
		}

		// Token: 0x06020189 RID: 131465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020189")]
		[Address(RVA = "0x1A437C0", Offset = "0x1A423C0", VA = "0x181A437C0")]
		public RoguelikeStashedTicketUseView()
		{
		}

		// Token: 0x0402B59D RID: 177565
		[Token(Token = "0x402B59D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Plugin")]
		private RoguelikeStashedTicketUsePlugin _plugin;

		// Token: 0x0402B59E RID: 177566
		[Token(Token = "0x402B59E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("List Part")]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x0402B59F RID: 177567
		[Token(Token = "0x402B59F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("List Part")]
		private RoguelikeStashedTicketUseViewScrollAdapter _scrollAdapter;

		// Token: 0x0402B5A0 RID: 177568
		[Token(Token = "0x402B5A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("List Part")]
		private GameObject _objListPart;

		// Token: 0x0402B5A1 RID: 177569
		[Token(Token = "0x402B5A1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("List Part")]
		private GameObject _objEmptyTipsPart;

		// Token: 0x0402B5A2 RID: 177570
		[Token(Token = "0x402B5A2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("List Part")]
		private Text _txtEmptyTips;

		// Token: 0x0402B5A3 RID: 177571
		[Token(Token = "0x402B5A3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Info Part")]
		private RoguelikeStashedTicketUseInfoView _infoView;

		// Token: 0x0402B5A4 RID: 177572
		[Token(Token = "0x402B5A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Confirm Part")]
		private RoguelikeStashedTicketUseConfirmBtnView _btnConfirmView;

		// Token: 0x0402B5A5 RID: 177573
		[Token(Token = "0x402B5A5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("LeaveBtn Part")]
		private GameObject _objLeaveBtnOpeningBlock;

		// Token: 0x0402B5A6 RID: 177574
		[Token(Token = "0x402B5A6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("LeaveBtn Part")]
		private UIAnimationLocation _leaveBtnAnim;

		// Token: 0x0402B5A7 RID: 177575
		[Token(Token = "0x402B5A7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Enter Anim Part")]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0402B5A8 RID: 177576
		[Token(Token = "0x402B5A8")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402B5A9 RID: 177577
		[Token(Token = "0x402B5A9")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B5AA RID: 177578
		[Token(Token = "0x402B5AA")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_leaveBtnAnimTween;

		// Token: 0x0402B5AB RID: 177579
		[Token(Token = "0x402B5AB")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_enterTween;

		// Token: 0x0402B5AC RID: 177580
		[Token(Token = "0x402B5AC")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedLoadDataSeqNum;

		// Token: 0x0402B5AD RID: 177581
		[Token(Token = "0x402B5AD")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_isLeaveBtnOpening;

		// Token: 0x0402B5AE RID: 177582
		[Token(Token = "0x402B5AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0402B5AF RID: 177583
		[Token(Token = "0x402B5AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B5B0 RID: 177584
		[Token(Token = "0x402B5B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetListToTop;

		// Token: 0x0402B5B1 RID: 177585
		[Token(Token = "0x402B5B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x0402B5B2 RID: 177586
		[Token(Token = "0x402B5B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B5B3 RID: 177587
		[Token(Token = "0x402B5B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnLeaveClick;

		// Token: 0x0402B5B4 RID: 177588
		[Token(Token = "0x402B5B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCancelLeaveClick;

		// Token: 0x0402B5B5 RID: 177589
		[Token(Token = "0x402B5B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
