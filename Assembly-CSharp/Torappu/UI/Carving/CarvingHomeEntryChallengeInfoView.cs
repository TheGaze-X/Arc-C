using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200601F RID: 24607
	[Token(Token = "0x200601F")]
	public class CarvingHomeEntryChallengeInfoView : DataBinder<CarvingHomeEntryProperty>, IHotfixable
	{
		// Token: 0x0602396E RID: 145774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602396E")]
		[Address(RVA = "0x1E3A110", Offset = "0x1E38D10", VA = "0x181E3A110")]
		public void OnExit()
		{
		}

		// Token: 0x0602396F RID: 145775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602396F")]
		[Address(RVA = "0x1E3A200", Offset = "0x1E38E00", VA = "0x181E3A200", Slot = "7")]
		public override void OnValueChanged(CarvingHomeEntryProperty property)
		{
		}

		// Token: 0x06023970 RID: 145776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023970")]
		[Address(RVA = "0x1E39ED0", Offset = "0x1E38AD0", VA = "0x181E39ED0")]
		public void EventOnNextBtnClicked()
		{
		}

		// Token: 0x06023971 RID: 145777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023971")]
		[Address(RVA = "0x1E39F60", Offset = "0x1E38B60", VA = "0x181E39F60")]
		public void EventOnPrevBtnClicked()
		{
		}

		// Token: 0x06023972 RID: 145778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023972")]
		[Address(RVA = "0x1E3A080", Offset = "0x1E38C80", VA = "0x181E3A080")]
		public void EventOnStartChallengeBtnClicked()
		{
		}

		// Token: 0x06023973 RID: 145779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023973")]
		[Address(RVA = "0x1E39FF0", Offset = "0x1E38BF0", VA = "0x181E39FF0")]
		public void EventOnSettleChallengeBtnClicked()
		{
		}

		// Token: 0x06023974 RID: 145780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023974")]
		[Address(RVA = "0x1E39E40", Offset = "0x1E38A40", VA = "0x181E39E40")]
		public void EventOnHandbookBtnClicked()
		{
		}

		// Token: 0x06023975 RID: 145781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023975")]
		[Address(RVA = "0x1E3A8B0", Offset = "0x1E394B0", VA = "0x181E3A8B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023976 RID: 145782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023976")]
		[Address(RVA = "0x1E3A940", Offset = "0x1E39540", VA = "0x181E3A940")]
		public CarvingHomeEntryChallengeInfoView()
		{
		}

		// Token: 0x04031425 RID: 201765
		[Token(Token = "0x4031425")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x04031426 RID: 201766
		[Token(Token = "0x4031426")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _lockedAnim;

		// Token: 0x04031427 RID: 201767
		[Token(Token = "0x4031427")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UISpineLocation _handbookSpine;

		// Token: 0x04031428 RID: 201768
		[Token(Token = "0x4031428")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelBestRecord;

		// Token: 0x04031429 RID: 201769
		[Token(Token = "0x4031429")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textBestRecord;

		// Token: 0x0403142A RID: 201770
		[Token(Token = "0x403142A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelInfo;

		// Token: 0x0403142B RID: 201771
		[Token(Token = "0x403142B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403142C RID: 201772
		[Token(Token = "0x403142C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403142D RID: 201773
		[Token(Token = "0x403142D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0403142E RID: 201774
		[Token(Token = "0x403142E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403142F RID: 201775
		[Token(Token = "0x403142F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelStageLockedTips;

		// Token: 0x04031430 RID: 201776
		[Token(Token = "0x4031430")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelTimeLockedTips;

		// Token: 0x04031431 RID: 201777
		[Token(Token = "0x4031431")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textUnlockTime;

		// Token: 0x04031432 RID: 201778
		[Token(Token = "0x4031432")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelIsPlaying;

		// Token: 0x04031433 RID: 201779
		[Token(Token = "0x4031433")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelPrevBtn;

		// Token: 0x04031434 RID: 201780
		[Token(Token = "0x4031434")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelPrevNew;

		// Token: 0x04031435 RID: 201781
		[Token(Token = "0x4031435")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelNextBtn;

		// Token: 0x04031436 RID: 201782
		[Token(Token = "0x4031436")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _panelNextNew;

		// Token: 0x04031437 RID: 201783
		[Token(Token = "0x4031437")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _panelContinueChallenge;

		// Token: 0x04031438 RID: 201784
		[Token(Token = "0x4031438")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _panelPlayingTip;

		// Token: 0x04031439 RID: 201785
		[Token(Token = "0x4031439")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _panelStartChallengeEnable;

		// Token: 0x0403143A RID: 201786
		[Token(Token = "0x403143A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _panelStartChallengeDisable;

		// Token: 0x0403143B RID: 201787
		[Token(Token = "0x403143B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _panelStopChallenge;

		// Token: 0x0403143C RID: 201788
		[Token(Token = "0x403143C")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_loopAnim;

		// Token: 0x0403143D RID: 201789
		[Token(Token = "0x403143D")]
		[FieldOffset(Offset = "0xF8")]
		private Tween m_lockedAnim;

		// Token: 0x0403143E RID: 201790
		[Token(Token = "0x403143E")]
		[FieldOffset(Offset = "0x100")]
		private int m_cachedIndex;

		// Token: 0x0403143F RID: 201791
		[Token(Token = "0x403143F")]
		[FieldOffset(Offset = "0x108")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031440 RID: 201792
		[Token(Token = "0x4031440")]
		[FieldOffset(Offset = "0x118")]
		private bool m_hasInited;

		// Token: 0x04031441 RID: 201793
		[Token(Token = "0x4031441")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04031442 RID: 201794
		[Token(Token = "0x4031442")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031443 RID: 201795
		[Token(Token = "0x4031443")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClicked;

		// Token: 0x04031444 RID: 201796
		[Token(Token = "0x4031444")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnPrevBtnClicked;

		// Token: 0x04031445 RID: 201797
		[Token(Token = "0x4031445")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnStartChallengeBtnClicked;

		// Token: 0x04031446 RID: 201798
		[Token(Token = "0x4031446")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnSettleChallengeBtnClicked;

		// Token: 0x04031447 RID: 201799
		[Token(Token = "0x4031447")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnHandbookBtnClicked;

		// Token: 0x04031448 RID: 201800
		[Token(Token = "0x4031448")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031449 RID: 201801
		[Token(Token = "0x4031449")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
