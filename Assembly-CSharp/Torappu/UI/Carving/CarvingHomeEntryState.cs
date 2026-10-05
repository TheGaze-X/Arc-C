using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006027 RID: 24615
	[Token(Token = "0x2006027")]
	public class CarvingHomeEntryState : State, IValueMsgReceiver, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x06023984 RID: 145796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023984")]
		[Address(RVA = "0x1E3B3B0", Offset = "0x1E39FB0", VA = "0x181E3B3B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023985 RID: 145797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023985")]
		[Address(RVA = "0x1E3B580", Offset = "0x1E3A180", VA = "0x181E3B580", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023986 RID: 145798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023986")]
		[Address(RVA = "0x1E3BE30", Offset = "0x1E3AA30", VA = "0x181E3BE30", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06023987 RID: 145799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023987")]
		[Address(RVA = "0x1E3B950", Offset = "0x1E3A550", VA = "0x181E3B950", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06023988 RID: 145800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023988")]
		[Address(RVA = "0x1E3BB30", Offset = "0x1E3A730", VA = "0x181E3BB30", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06023989 RID: 145801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023989")]
		[Address(RVA = "0x1E3B410", Offset = "0x1E3A010", VA = "0x181E3B410", Slot = "24")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602398A RID: 145802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602398A")]
		[Address(RVA = "0x1E3D0A0", Offset = "0x1E3BCA0", VA = "0x181E3D0A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602398B RID: 145803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602398B")]
		[Address(RVA = "0x1E3CFC0", Offset = "0x1E3BBC0", VA = "0x181E3CFC0")]
		private string _GetActivityId()
		{
			return null;
		}

		// Token: 0x0602398C RID: 145804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602398C")]
		[Address(RVA = "0x1E3CEB0", Offset = "0x1E3BAB0", VA = "0x181E3CEB0")]
		private void _GenerateEntryAnim()
		{
		}

		// Token: 0x0602398D RID: 145805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602398D")]
		[Address(RVA = "0x1E3BF30", Offset = "0x1E3AB30", VA = "0x181E3BF30")]
		private void _EventOnBackBtnClicked()
		{
		}

		// Token: 0x0602398E RID: 145806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602398E")]
		[Address(RVA = "0x1E3C3A0", Offset = "0x1E3AFA0", VA = "0x181E3C3A0")]
		private void _EventOnOpenIntroDialog()
		{
		}

		// Token: 0x0602398F RID: 145807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602398F")]
		[Address(RVA = "0x1E3C250", Offset = "0x1E3AE50", VA = "0x181E3C250")]
		private void _EventOnNextBtnClicked()
		{
		}

		// Token: 0x06023990 RID: 145808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023990")]
		[Address(RVA = "0x1E3C5F0", Offset = "0x1E3B1F0", VA = "0x181E3C5F0")]
		private void _EventOnPrevBtnClicked()
		{
		}

		// Token: 0x06023991 RID: 145809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023991")]
		[Address(RVA = "0x1E3CA00", Offset = "0x1E3B600", VA = "0x181E3CA00")]
		private void _EventOnStartChallengeBtnClicked()
		{
		}

		// Token: 0x06023992 RID: 145810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023992")]
		[Address(RVA = "0x1E3D6E0", Offset = "0x1E3C2E0", VA = "0x181E3D6E0")]
		private void _OpenCarvingMainPage(CarvingCreateGameResponse response)
		{
		}

		// Token: 0x06023993 RID: 145811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023993")]
		[Address(RVA = "0x1E3C730", Offset = "0x1E3B330", VA = "0x181E3C730")]
		private void _EventOnSettleChallengeBtnClicked()
		{
		}

		// Token: 0x06023994 RID: 145812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023994")]
		[Address(RVA = "0x1E3C030", Offset = "0x1E3AC30", VA = "0x181E3C030")]
		private void _EventOnHandbookBtnClicked()
		{
		}

		// Token: 0x06023995 RID: 145813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023995")]
		[Address(RVA = "0x1E3D220", Offset = "0x1E3BE20", VA = "0x181E3D220")]
		private void _OnSettleChallengeConfirm()
		{
		}

		// Token: 0x06023996 RID: 145814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023996")]
		[Address(RVA = "0x1E3D490", Offset = "0x1E3C090", VA = "0x181E3D490")]
		private void _OnSettleProceed(CarvingSettleResponse response)
		{
		}

		// Token: 0x06023997 RID: 145815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023997")]
		[Address(RVA = "0x1E3D8C0", Offset = "0x1E3C4C0", VA = "0x181E3D8C0")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x06023998 RID: 145816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023998")]
		[Address(RVA = "0x1E3D920", Offset = "0x1E3C520", VA = "0x181E3D920")]
		public CarvingHomeEntryState()
		{
		}

		// Token: 0x06023999 RID: 145817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023999")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602399A RID: 145818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602399A")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0602399B RID: 145819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602399B")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403146F RID: 201839
		[Token(Token = "0x403146F")]
		[NonSerialized]
		public const int ON_NEXT_BTN_CLICKED = 0;

		// Token: 0x04031470 RID: 201840
		[Token(Token = "0x4031470")]
		[NonSerialized]
		public const int ON_PREV_BTN_CLICKED = 1;

		// Token: 0x04031471 RID: 201841
		[Token(Token = "0x4031471")]
		[NonSerialized]
		public const int ON_START_CHALLENGE_BTN_CLICKED = 2;

		// Token: 0x04031472 RID: 201842
		[Token(Token = "0x4031472")]
		[NonSerialized]
		public const int ON_SETTLE_CHALLENGE_BTN_CLICKED = 3;

		// Token: 0x04031473 RID: 201843
		[Token(Token = "0x4031473")]
		[NonSerialized]
		public const int ON_HANDBOOK_BTN_CLICKED = 4;

		// Token: 0x04031474 RID: 201844
		[Token(Token = "0x4031474")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CarvingHomeEntryChallengeInfoView _infoView;

		// Token: 0x04031475 RID: 201845
		[Token(Token = "0x4031475")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CarvingHomeEntryChallengeGroupView _groupView;

		// Token: 0x04031476 RID: 201846
		[Token(Token = "0x4031476")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CarvingHomeEntryPageGroupView _pageGroupView;

		// Token: 0x04031477 RID: 201847
		[Token(Token = "0x4031477")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x04031478 RID: 201848
		[Token(Token = "0x4031478")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04031479 RID: 201849
		[Token(Token = "0x4031479")]
		[FieldOffset(Offset = "0x80")]
		private CarvingHomeEntryStateBean m_stateBean;

		// Token: 0x0403147A RID: 201850
		[Token(Token = "0x403147A")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403147B RID: 201851
		[Token(Token = "0x403147B")]
		[FieldOffset(Offset = "0x8C")]
		private int m_introDialogInstId;

		// Token: 0x0403147C RID: 201852
		[Token(Token = "0x403147C")]
		[FieldOffset(Offset = "0x90")]
		private int m_confirmDialogInstId;

		// Token: 0x0403147D RID: 201853
		[Token(Token = "0x403147D")]
		[FieldOffset(Offset = "0x94")]
		private int m_settleDialogInstId;

		// Token: 0x0403147E RID: 201854
		[Token(Token = "0x403147E")]
		[FieldOffset(Offset = "0x98")]
		private int m_handbookDialogInstId;

		// Token: 0x0403147F RID: 201855
		[Token(Token = "0x403147F")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_entryAnim;

		// Token: 0x04031480 RID: 201856
		[Token(Token = "0x4031480")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031481 RID: 201857
		[Token(Token = "0x4031481")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031482 RID: 201858
		[Token(Token = "0x4031482")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04031483 RID: 201859
		[Token(Token = "0x4031483")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04031484 RID: 201860
		[Token(Token = "0x4031484")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04031485 RID: 201861
		[Token(Token = "0x4031485")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04031486 RID: 201862
		[Token(Token = "0x4031486")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031487 RID: 201863
		[Token(Token = "0x4031487")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetActivityId;

		// Token: 0x04031488 RID: 201864
		[Token(Token = "0x4031488")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateEntryAnim;

		// Token: 0x04031489 RID: 201865
		[Token(Token = "0x4031489")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnBackBtnClicked;

		// Token: 0x0403148A RID: 201866
		[Token(Token = "0x403148A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnOpenIntroDialog;

		// Token: 0x0403148B RID: 201867
		[Token(Token = "0x403148B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnNextBtnClicked;

		// Token: 0x0403148C RID: 201868
		[Token(Token = "0x403148C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnPrevBtnClicked;

		// Token: 0x0403148D RID: 201869
		[Token(Token = "0x403148D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnStartChallengeBtnClicked;

		// Token: 0x0403148E RID: 201870
		[Token(Token = "0x403148E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OpenCarvingMainPage;

		// Token: 0x0403148F RID: 201871
		[Token(Token = "0x403148F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnSettleChallengeBtnClicked;

		// Token: 0x04031490 RID: 201872
		[Token(Token = "0x4031490")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnHandbookBtnClicked;

		// Token: 0x04031491 RID: 201873
		[Token(Token = "0x4031491")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnSettleChallengeConfirm;

		// Token: 0x04031492 RID: 201874
		[Token(Token = "0x4031492")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnSettleProceed;

		// Token: 0x04031493 RID: 201875
		[Token(Token = "0x4031493")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x04031494 RID: 201876
		[Token(Token = "0x4031494")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
