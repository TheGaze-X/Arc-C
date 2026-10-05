using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007978 RID: 31096
	[Token(Token = "0x2007978")]
	public class Act1ArcadeSettlementStatusResultView : Act1ArcadeSettlementStatusBaseView
	{
		// Token: 0x17006645 RID: 26181
		// (get) Token: 0x0602B9E6 RID: 178662 RVA: 0x000DC9E0 File Offset: 0x000DABE0
		[Token(Token = "0x17006645")]
		public override Act1ArcadeSettlementModel.SettlementViewStatus viewStatus
		{
			[Token(Token = "0x602B9E6")]
			[Address(RVA = "0x2784CF0", Offset = "0x27838F0", VA = "0x182784CF0", Slot = "4")]
			get
			{
				return Act1ArcadeSettlementModel.SettlementViewStatus.None;
			}
		}

		// Token: 0x17006646 RID: 26182
		// (get) Token: 0x0602B9E7 RID: 178663 RVA: 0x000DC9F8 File Offset: 0x000DABF8
		[Token(Token = "0x17006646")]
		public override Act1ArcadeSettlementModel.SettlementViewStatus nextViewStatus
		{
			[Token(Token = "0x602B9E7")]
			[Address(RVA = "0x2784C90", Offset = "0x2783890", VA = "0x182784C90", Slot = "5")]
			get
			{
				return Act1ArcadeSettlementModel.SettlementViewStatus.None;
			}
		}

		// Token: 0x0602B9E8 RID: 178664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9E8")]
		[Address(RVA = "0x2784980", Offset = "0x2783580", VA = "0x182784980", Slot = "6")]
		public override void SetToDefaultShow()
		{
		}

		// Token: 0x0602B9E9 RID: 178665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9E9")]
		[Address(RVA = "0x2784160", Offset = "0x2782D60", VA = "0x182784160", Slot = "7")]
		public override void ChangeInStatusAndRender(Act1ArcadeSettlementModel model)
		{
		}

		// Token: 0x0602B9EA RID: 178666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B9EA")]
		[Address(RVA = "0x2784A70", Offset = "0x2783670", VA = "0x182784A70")]
		private IEnumerator _PlayEntryAnim()
		{
			return null;
		}

		// Token: 0x0602B9EB RID: 178667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B9EB")]
		[Address(RVA = "0x2784B20", Offset = "0x2783720", VA = "0x182784B20")]
		private IEnumerator _ShowToast(Act1ArcadeSettlementModel model)
		{
			return null;
		}

		// Token: 0x0602B9EC RID: 178668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9EC")]
		[Address(RVA = "0x27848E0", Offset = "0x27834E0", VA = "0x1827848E0")]
		public void EventOnClickBg()
		{
		}

		// Token: 0x0602B9ED RID: 178669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9ED")]
		[Address(RVA = "0x2784BF0", Offset = "0x27837F0", VA = "0x182784BF0")]
		public Act1ArcadeSettlementStatusResultView()
		{
		}

		// Token: 0x0602B9EE RID: 178670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9EE")]
		[Address(RVA = "0x2783440", Offset = "0x2782040", VA = "0x182783440")]
		private void <>xLuaBaseProxy_SetToDefaultShow()
		{
		}

		// Token: 0x0602B9EF RID: 178671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9EF")]
		[Address(RVA = "0x2783370", Offset = "0x2781F70", VA = "0x182783370")]
		private void <>xLuaBaseProxy_ChangeInStatusAndRender(Act1ArcadeSettlementModel P0)
		{
		}

		// Token: 0x0403F18E RID: 258446
		[Token(Token = "0x403F18E")]
		private const float TOAST_SHOW_DELAY = 1f;

		// Token: 0x0403F18F RID: 258447
		[Token(Token = "0x403F18F")]
		private const float TOAST_EACH_SHOW_DELAY = 0.5f;

		// Token: 0x0403F190 RID: 258448
		[Token(Token = "0x403F190")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403F191 RID: 258449
		[Token(Token = "0x403F191")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _rankIcons;

		// Token: 0x0403F192 RID: 258450
		[Token(Token = "0x403F192")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x0403F193 RID: 258451
		[Token(Token = "0x403F193")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x0403F194 RID: 258452
		[Token(Token = "0x403F194")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x0403F195 RID: 258453
		[Token(Token = "0x403F195")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textPlayerName;

		// Token: 0x0403F196 RID: 258454
		[Token(Token = "0x403F196")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textFinishTime;

		// Token: 0x0403F197 RID: 258455
		[Token(Token = "0x403F197")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act1ArcadeSettlementCharCardView _charView;

		// Token: 0x0403F198 RID: 258456
		[Token(Token = "0x403F198")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1ArcadeSettlementIllustView _illustView;

		// Token: 0x0403F199 RID: 258457
		[Token(Token = "0x403F199")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1ArcadeSettlementMilestoneView _milestoneView;

		// Token: 0x0403F19A RID: 258458
		[Token(Token = "0x403F19A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act1ArcadeToast _notifyToastPrefab;

		// Token: 0x0403F19B RID: 258459
		[Token(Token = "0x403F19B")]
		[FieldOffset(Offset = "0x88")]
		private bool m_blockClick;

		// Token: 0x0403F19C RID: 258460
		[Token(Token = "0x403F19C")]
		[FieldOffset(Offset = "0x90")]
		private Act1ArcadeSettlementModel m_model;

		// Token: 0x0403F19D RID: 258461
		[Token(Token = "0x403F19D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewStatus;

		// Token: 0x0403F19E RID: 258462
		[Token(Token = "0x403F19E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nextViewStatus;

		// Token: 0x0403F19F RID: 258463
		[Token(Token = "0x403F19F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetToDefaultShow;

		// Token: 0x0403F1A0 RID: 258464
		[Token(Token = "0x403F1A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeInStatusAndRender;

		// Token: 0x0403F1A1 RID: 258465
		[Token(Token = "0x403F1A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0403F1A2 RID: 258466
		[Token(Token = "0x403F1A2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowToast;

		// Token: 0x0403F1A3 RID: 258467
		[Token(Token = "0x403F1A3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClickBg;

		// Token: 0x0403F1A4 RID: 258468
		[Token(Token = "0x403F1A4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
