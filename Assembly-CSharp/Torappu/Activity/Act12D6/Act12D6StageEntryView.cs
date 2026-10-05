using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AFF RID: 31487
	[Token(Token = "0x2007AFF")]
	public class Act12D6StageEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700674D RID: 26445
		// (get) Token: 0x0602C170 RID: 180592 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C171 RID: 180593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700674D")]
		public string Difficulty
		{
			[Token(Token = "0x602C170")]
			[Address(RVA = "0x27FBA10", Offset = "0x27FA610", VA = "0x1827FBA10")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C171")]
			[Address(RVA = "0x27FBA70", Offset = "0x27FA670", VA = "0x1827FBA70")]
			set
			{
			}
		}

		// Token: 0x0602C172 RID: 180594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C172")]
		[Address(RVA = "0x27FB540", Offset = "0x27FA140", VA = "0x1827FB540")]
		private void _RenderDifficulty()
		{
		}

		// Token: 0x0602C173 RID: 180595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C173")]
		[Address(RVA = "0x27FB310", Offset = "0x27F9F10", VA = "0x1827FB310")]
		private string _FormatRemainTime(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x0602C174 RID: 180596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C174")]
		[Address(RVA = "0x27F9930", Offset = "0x27F8530", VA = "0x1827F9930")]
		public void Render(PlayerRoguelike.CurrentData currentData)
		{
		}

		// Token: 0x0602C175 RID: 180597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C175")]
		[Address(RVA = "0x27FAD30", Offset = "0x27F9930", VA = "0x1827FAD30")]
		private void Update()
		{
		}

		// Token: 0x0602C176 RID: 180598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C176")]
		[Address(RVA = "0x27F98A0", Offset = "0x27F84A0", VA = "0x1827F98A0")]
		public void EventOnNewGameLockClicked()
		{
		}

		// Token: 0x0602C177 RID: 180599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C177")]
		[Address(RVA = "0x27FAEB0", Offset = "0x27F9AB0", VA = "0x1827FAEB0")]
		private void _DealWithNewGameCoolDown()
		{
		}

		// Token: 0x0602C178 RID: 180600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C178")]
		[Address(RVA = "0x27FB800", Offset = "0x27FA400", VA = "0x1827FB800")]
		private void _TickNewGameCoolDownTime(CountDownTask.TickValue tickValue)
		{
		}

		// Token: 0x0602C179 RID: 180601 RVA: 0x000DE0F0 File Offset: 0x000DC2F0
		[Token(Token = "0x602C179")]
		[Address(RVA = "0x27FADA0", Offset = "0x27F99A0", VA = "0x1827FADA0")]
		private long _CheckReOpenRemainSeconds()
		{
			return 0L;
		}

		// Token: 0x0602C17A RID: 180602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C17A")]
		[Address(RVA = "0x27FB950", Offset = "0x27FA550", VA = "0x1827FB950")]
		public Act12D6StageEntryView()
		{
		}

		// Token: 0x0403FE58 RID: 261720
		[Token(Token = "0x403FE58")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelStageEndTime;

		// Token: 0x0403FE59 RID: 261721
		[Token(Token = "0x403FE59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelRewardEndTime;

		// Token: 0x0403FE5A RID: 261722
		[Token(Token = "0x403FE5A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textStageEndTime;

		// Token: 0x0403FE5B RID: 261723
		[Token(Token = "0x403FE5B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRewardEndTime;

		// Token: 0x0403FE5C RID: 261724
		[Token(Token = "0x403FE5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0403FE5D RID: 261725
		[Token(Token = "0x403FE5D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _remainTimeColor;

		// Token: 0x0403FE5E RID: 261726
		[Token(Token = "0x403FE5E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _btnMillstone;

		// Token: 0x0403FE5F RID: 261727
		[Token(Token = "0x403FE5F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("EndGamePanel")]
		private GameObject _lockEntry;

		// Token: 0x0403FE60 RID: 261728
		[Token(Token = "0x403FE60")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("EndGamePanel")]
		private GameObject _endBtn;

		// Token: 0x0403FE61 RID: 261729
		[Token(Token = "0x403FE61")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _btnPlayerBuff;

		// Token: 0x0403FE62 RID: 261730
		[Token(Token = "0x403FE62")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objbuff;

		// Token: 0x0403FE63 RID: 261731
		[Token(Token = "0x403FE63")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("ContinueGamePanel")]
		private GameObject _panelContinue;

		// Token: 0x0403FE64 RID: 261732
		[Token(Token = "0x403FE64")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("ContinueGamePanel")]
		private Text _textCurrentDifficulty;

		// Token: 0x0403FE65 RID: 261733
		[Token(Token = "0x403FE65")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("ContinueGamePanel")]
		private Text _textLastStartTime;

		// Token: 0x0403FE66 RID: 261734
		[Token(Token = "0x403FE66")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("ContinueGamePanel")]
		private Text _textLastNode;

		// Token: 0x0403FE67 RID: 261735
		[Token(Token = "0x403FE67")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("ContinueGamePanel")]
		private GameObject _imageBuffLocked;

		// Token: 0x0403FE68 RID: 261736
		[Token(Token = "0x403FE68")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("ContinueGamePanel")]
		private Image _imageChosenModeBg;

		// Token: 0x0403FE69 RID: 261737
		[Token(Token = "0x403FE69")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("NewGamePanel")]
		private GameObject _panelStartNew;

		// Token: 0x0403FE6A RID: 261738
		[Token(Token = "0x403FE6A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("NewGamePanel")]
		private Text _textDifficultyChosen;

		// Token: 0x0403FE6B RID: 261739
		[Token(Token = "0x403FE6B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("NewGamePanel")]
		private Toggle[] _toggles;

		// Token: 0x0403FE6C RID: 261740
		[Token(Token = "0x403FE6C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("NewGamePanel")]
		private Image _imageDifficultyBg;

		// Token: 0x0403FE6D RID: 261741
		[Token(Token = "0x403FE6D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("NewGamePanel")]
		private Animator _diffDescAnimator;

		// Token: 0x0403FE6E RID: 261742
		[Token(Token = "0x403FE6E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("NewGameLock")]
		private Button _btnNewGame;

		// Token: 0x0403FE6F RID: 261743
		[Token(Token = "0x403FE6F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("NewGameLock")]
		private GameObject _panelNewGameLock;

		// Token: 0x0403FE70 RID: 261744
		[Token(Token = "0x403FE70")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("NewGameLock")]
		private Text _textNewGameLock;

		// Token: 0x0403FE71 RID: 261745
		[Token(Token = "0x403FE71")]
		[FieldOffset(Offset = "0xE8")]
		private string m_difficulty;

		// Token: 0x0403FE72 RID: 261746
		[Token(Token = "0x403FE72")]
		[FieldOffset(Offset = "0xF0")]
		private Act12D6StageEntryView.Status m_status;

		// Token: 0x0403FE73 RID: 261747
		[Token(Token = "0x403FE73")]
		[FieldOffset(Offset = "0x118")]
		private CountDownTask m_reOpenTask;

		// Token: 0x0403FE74 RID: 261748
		[Token(Token = "0x403FE74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_Difficulty;

		// Token: 0x0403FE75 RID: 261749
		[Token(Token = "0x403FE75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_Difficulty;

		// Token: 0x0403FE76 RID: 261750
		[Token(Token = "0x403FE76")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDifficulty;

		// Token: 0x0403FE77 RID: 261751
		[Token(Token = "0x403FE77")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FormatRemainTime;

		// Token: 0x0403FE78 RID: 261752
		[Token(Token = "0x403FE78")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FE79 RID: 261753
		[Token(Token = "0x403FE79")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403FE7A RID: 261754
		[Token(Token = "0x403FE7A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnNewGameLockClicked;

		// Token: 0x0403FE7B RID: 261755
		[Token(Token = "0x403FE7B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DealWithNewGameCoolDown;

		// Token: 0x0403FE7C RID: 261756
		[Token(Token = "0x403FE7C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TickNewGameCoolDownTime;

		// Token: 0x0403FE7D RID: 261757
		[Token(Token = "0x403FE7D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckReOpenRemainSeconds;

		// Token: 0x0403FE7E RID: 261758
		[Token(Token = "0x403FE7E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007B00 RID: 31488
		[Token(Token = "0x2007B00")]
		private struct Status
		{
			// Token: 0x0602C17B RID: 180603 RVA: 0x000DE108 File Offset: 0x000DC308
			[Token(Token = "0x602C17B")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0602C17C RID: 180604 RVA: 0x000DE120 File Offset: 0x000DC320
			[Token(Token = "0x602C17C")]
			[Address(RVA = "0x2801C60", Offset = "0x2800860", VA = "0x182801C60")]
			public static Act12D6StageEntryView.Status Create(string activityId, PlayerRoguelike.CurrentData currentData)
			{
				return default(Act12D6StageEntryView.Status);
			}

			// Token: 0x0403FE7F RID: 261759
			[Token(Token = "0x403FE7F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Act12D6StageEntryView.Status EMPTY;

			// Token: 0x0403FE80 RID: 261760
			[Token(Token = "0x403FE80")]
			[FieldOffset(Offset = "0x0")]
			public string activityId;

			// Token: 0x0403FE81 RID: 261761
			[Token(Token = "0x403FE81")]
			[FieldOffset(Offset = "0x8")]
			public ActivityRoguelikeData data;

			// Token: 0x0403FE82 RID: 261762
			[Token(Token = "0x403FE82")]
			[FieldOffset(Offset = "0x10")]
			public ActivityTable.BasicData basicInfo;

			// Token: 0x0403FE83 RID: 261763
			[Token(Token = "0x403FE83")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerRoguelikeActivity playerData;

			// Token: 0x0403FE84 RID: 261764
			[Token(Token = "0x403FE84")]
			[FieldOffset(Offset = "0x20")]
			public bool isNewFlag;
		}
	}
}
