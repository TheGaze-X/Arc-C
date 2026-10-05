using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007974 RID: 31092
	[Token(Token = "0x2007974")]
	public class Act1ArcadeSettlementStatusEntryView : Act1ArcadeSettlementStatusBaseView
	{
		// Token: 0x1700663F RID: 26175
		// (get) Token: 0x0602B9CD RID: 178637 RVA: 0x000DC968 File Offset: 0x000DAB68
		[Token(Token = "0x1700663F")]
		public override Act1ArcadeSettlementModel.SettlementViewStatus viewStatus
		{
			[Token(Token = "0x602B9CD")]
			[Address(RVA = "0x2784100", Offset = "0x2782D00", VA = "0x182784100", Slot = "4")]
			get
			{
				return Act1ArcadeSettlementModel.SettlementViewStatus.None;
			}
		}

		// Token: 0x17006640 RID: 26176
		// (get) Token: 0x0602B9CE RID: 178638 RVA: 0x000DC980 File Offset: 0x000DAB80
		[Token(Token = "0x17006640")]
		public override Act1ArcadeSettlementModel.SettlementViewStatus nextViewStatus
		{
			[Token(Token = "0x602B9CE")]
			[Address(RVA = "0x2783FF0", Offset = "0x2782BF0", VA = "0x182783FF0", Slot = "5")]
			get
			{
				return Act1ArcadeSettlementModel.SettlementViewStatus.None;
			}
		}

		// Token: 0x0602B9CF RID: 178639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9CF")]
		[Address(RVA = "0x2783C90", Offset = "0x2782890", VA = "0x182783C90", Slot = "6")]
		public override void SetToDefaultShow()
		{
		}

		// Token: 0x0602B9D0 RID: 178640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9D0")]
		[Address(RVA = "0x27838C0", Offset = "0x27824C0", VA = "0x1827838C0", Slot = "7")]
		public override void ChangeInStatusAndRender(Act1ArcadeSettlementModel model)
		{
		}

		// Token: 0x0602B9D1 RID: 178641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B9D1")]
		[Address(RVA = "0x2783DE0", Offset = "0x27829E0", VA = "0x182783DE0")]
		private IEnumerator _PlayEntryAnim(bool autoClick)
		{
			return null;
		}

		// Token: 0x0602B9D2 RID: 178642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B9D2")]
		[Address(RVA = "0x2783EA0", Offset = "0x2782AA0", VA = "0x182783EA0")]
		private IEnumerator _PlayNewRecordAudio(float delay)
		{
			return null;
		}

		// Token: 0x0602B9D3 RID: 178643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9D3")]
		[Address(RVA = "0x2783D50", Offset = "0x2782950", VA = "0x182783D50")]
		private void _InitAnim()
		{
		}

		// Token: 0x0602B9D4 RID: 178644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9D4")]
		[Address(RVA = "0x2783BF0", Offset = "0x27827F0", VA = "0x182783BF0")]
		public void EventOnClickBg()
		{
		}

		// Token: 0x0602B9D5 RID: 178645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9D5")]
		[Address(RVA = "0x2783F50", Offset = "0x2782B50", VA = "0x182783F50")]
		public Act1ArcadeSettlementStatusEntryView()
		{
		}

		// Token: 0x0602B9D6 RID: 178646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9D6")]
		[Address(RVA = "0x2783440", Offset = "0x2782040", VA = "0x182783440")]
		private void <>xLuaBaseProxy_SetToDefaultShow()
		{
		}

		// Token: 0x0602B9D7 RID: 178647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9D7")]
		[Address(RVA = "0x2783370", Offset = "0x2781F70", VA = "0x182783370")]
		private void <>xLuaBaseProxy_ChangeInStatusAndRender(Act1ArcadeSettlementModel P0)
		{
		}

		// Token: 0x0403F172 RID: 258418
		[Token(Token = "0x403F172")]
		private const float SCORE_TWEEN_DELAY = 0.25f;

		// Token: 0x0403F173 RID: 258419
		[Token(Token = "0x403F173")]
		private const float SCORE_TWEEN_DURATION = 1.5f;

		// Token: 0x0403F174 RID: 258420
		[Token(Token = "0x403F174")]
		private const float NEW_RECORD_AUDIO_DELAY = 1.3f;

		// Token: 0x0403F175 RID: 258421
		[Token(Token = "0x403F175")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403F176 RID: 258422
		[Token(Token = "0x403F176")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNewRecordTip;

		// Token: 0x0403F177 RID: 258423
		[Token(Token = "0x403F177")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelNewRecordBlock;

		// Token: 0x0403F178 RID: 258424
		[Token(Token = "0x403F178")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelCommonBlock;

		// Token: 0x0403F179 RID: 258425
		[Token(Token = "0x403F179")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act1ArcadeSettlementScoreComp _scoreComp;

		// Token: 0x0403F17A RID: 258426
		[Token(Token = "0x403F17A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _rankIcons;

		// Token: 0x0403F17B RID: 258427
		[Token(Token = "0x403F17B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_blockClick;

		// Token: 0x0403F17C RID: 258428
		[Token(Token = "0x403F17C")]
		[FieldOffset(Offset = "0x68")]
		private Act1ArcadeSettlementModel m_model;

		// Token: 0x0403F17D RID: 258429
		[Token(Token = "0x403F17D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewStatus;

		// Token: 0x0403F17E RID: 258430
		[Token(Token = "0x403F17E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nextViewStatus;

		// Token: 0x0403F17F RID: 258431
		[Token(Token = "0x403F17F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetToDefaultShow;

		// Token: 0x0403F180 RID: 258432
		[Token(Token = "0x403F180")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeInStatusAndRender;

		// Token: 0x0403F181 RID: 258433
		[Token(Token = "0x403F181")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0403F182 RID: 258434
		[Token(Token = "0x403F182")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayNewRecordAudio;

		// Token: 0x0403F183 RID: 258435
		[Token(Token = "0x403F183")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitAnim;

		// Token: 0x0403F184 RID: 258436
		[Token(Token = "0x403F184")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClickBg;

		// Token: 0x0403F185 RID: 258437
		[Token(Token = "0x403F185")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
