using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045A9 RID: 17833
	[Token(Token = "0x20045A9")]
	public class RL03TopicChallengeModeInfoView : RoguelikeTopicChallengeModeInfoViewBase
	{
		// Token: 0x0601B23E RID: 111166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B23E")]
		[Address(RVA = "0x144CC50", Offset = "0x144B850", VA = "0x18144CC50")]
		public void OnOpenChallengeBookEvent()
		{
		}

		// Token: 0x0601B23F RID: 111167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B23F")]
		[Address(RVA = "0x144CBF0", Offset = "0x144B7F0", VA = "0x18144CBF0", Slot = "4")]
		public override void InitStyle(RoguelikeTopicChallengeModelStyle style)
		{
		}

		// Token: 0x0601B240 RID: 111168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B240")]
		[Address(RVA = "0x144CE70", Offset = "0x144BA70", VA = "0x18144CE70", Slot = "5")]
		public override void Render(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B241 RID: 111169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B241")]
		[Address(RVA = "0x144D490", Offset = "0x144C090", VA = "0x18144D490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B242 RID: 111170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B242")]
		[Address(RVA = "0x144D540", Offset = "0x144C140", VA = "0x18144D540")]
		private void _LoadRewardItemIcon(int index, List<ItemBundle> items)
		{
		}

		// Token: 0x0601B243 RID: 111171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B243")]
		[Address(RVA = "0x144D8A0", Offset = "0x144C4A0", VA = "0x18144D8A0")]
		public RL03TopicChallengeModeInfoView()
		{
		}

		// Token: 0x04022EF9 RID: 143097
		[Token(Token = "0x4022EF9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Tasks")]
		private Text _textTaskTitle;

		// Token: 0x04022EFA RID: 143098
		[Token(Token = "0x4022EFA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Tasks")]
		private RL03TopicChallengeModeInfoView.ChallengeTaskInfoPanel[] _challengeTaskInfos;

		// Token: 0x04022EFB RID: 143099
		[Token(Token = "0x4022EFB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Tasks")]
		private GameObject _taskCompletePanel;

		// Token: 0x04022EFC RID: 143100
		[Token(Token = "0x4022EFC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Tasks")]
		private GameObject _taskIncompletePanel;

		// Token: 0x04022EFD RID: 143101
		[Token(Token = "0x4022EFD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Rewards")]
		private Text _textClaimReward;

		// Token: 0x04022EFE RID: 143102
		[Token(Token = "0x4022EFE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Rewards")]
		private Text _textRewardClaimed;

		// Token: 0x04022EFF RID: 143103
		[Token(Token = "0x4022EFF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Rewards")]
		private GameObject _panelRewardClaimed;

		// Token: 0x04022F00 RID: 143104
		[Token(Token = "0x4022F00")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Rewards")]
		private GameObject _panelRewardUnclaimed;

		// Token: 0x04022F01 RID: 143105
		[Token(Token = "0x4022F01")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Rewards")]
		private RectTransform[] _itemIconHolder;

		// Token: 0x04022F02 RID: 143106
		[Token(Token = "0x4022F02")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Rewards")]
		private float _rewardItemScale;

		// Token: 0x04022F03 RID: 143107
		[Token(Token = "0x4022F03")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Conditions")]
		private Text _textConditionTitle;

		// Token: 0x04022F04 RID: 143108
		[Token(Token = "0x4022F04")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Conditions")]
		private RL03TopicChallengeModeInfoView.ChallengeConditionLine[] _challengeDescLines;

		// Token: 0x04022F05 RID: 143109
		[Token(Token = "0x4022F05")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("ChallengeBook")]
		private GameObject _challengeBookNormalPanel;

		// Token: 0x04022F06 RID: 143110
		[Token(Token = "0x4022F06")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("ChallengeBook")]
		private GameObject _challengeBookLockedPanel;

		// Token: 0x04022F07 RID: 143111
		[Token(Token = "0x4022F07")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("ChallengeBook")]
		private GameObject _challengeBookNewPanel;

		// Token: 0x04022F08 RID: 143112
		[Token(Token = "0x4022F08")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x04022F09 RID: 143113
		[Token(Token = "0x4022F09")]
		[FieldOffset(Offset = "0xA8")]
		private UIItemCard[] m_itemCardList;

		// Token: 0x04022F0A RID: 143114
		[Token(Token = "0x4022F0A")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedChallengeId;

		// Token: 0x04022F0B RID: 143115
		[Token(Token = "0x4022F0B")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_cachedChallengeBookAccessible;

		// Token: 0x04022F0C RID: 143116
		[Token(Token = "0x4022F0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnOpenChallengeBookEvent;

		// Token: 0x04022F0D RID: 143117
		[Token(Token = "0x4022F0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitStyle;

		// Token: 0x04022F0E RID: 143118
		[Token(Token = "0x4022F0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022F0F RID: 143119
		[Token(Token = "0x4022F0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022F10 RID: 143120
		[Token(Token = "0x4022F10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadRewardItemIcon;

		// Token: 0x04022F11 RID: 143121
		[Token(Token = "0x4022F11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045AA RID: 17834
		[Token(Token = "0x20045AA")]
		[Serializable]
		private class ChallengeConditionLine : IHotfixable
		{
			// Token: 0x0601B244 RID: 111172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B244")]
			[Address(RVA = "0x1444000", Offset = "0x1442C00", VA = "0x181444000")]
			public void Render(string desc)
			{
			}

			// Token: 0x0601B245 RID: 111173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B245")]
			[Address(RVA = "0x1444100", Offset = "0x1442D00", VA = "0x181444100")]
			public ChallengeConditionLine()
			{
			}

			// Token: 0x04022F12 RID: 143122
			[Token(Token = "0x4022F12")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _textDesc;

			// Token: 0x04022F13 RID: 143123
			[Token(Token = "0x4022F13")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04022F14 RID: 143124
			[Token(Token = "0x4022F14")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020045AB RID: 17835
		[Token(Token = "0x20045AB")]
		[Serializable]
		private class ChallengeTaskInfoPanel : IHotfixable
		{
			// Token: 0x0601B246 RID: 111174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B246")]
			[Address(RVA = "0x1444160", Offset = "0x1442D60", VA = "0x181444160")]
			public void Render(RoguelikeTopicChallengeModel challengeModel, RoguelikeTopicTaskInfo taskInfo)
			{
			}

			// Token: 0x0601B247 RID: 111175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B247")]
			[Address(RVA = "0x14443A0", Offset = "0x1442FA0", VA = "0x1814443A0")]
			public ChallengeTaskInfoPanel()
			{
			}

			// Token: 0x04022F15 RID: 143125
			[Token(Token = "0x4022F15")]
			private const string TASK_TOTAL_PROGRESS_STYLE = "/{0}";

			// Token: 0x04022F16 RID: 143126
			[Token(Token = "0x4022F16")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _normalPanel;

			// Token: 0x04022F17 RID: 143127
			[Token(Token = "0x4022F17")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _exploringPanel;

			// Token: 0x04022F18 RID: 143128
			[Token(Token = "0x4022F18")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _currProgressText;

			// Token: 0x04022F19 RID: 143129
			[Token(Token = "0x4022F19")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _totalProgressText;

			// Token: 0x04022F1A RID: 143130
			[Token(Token = "0x4022F1A")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text[] _taskTexts;

			// Token: 0x04022F1B RID: 143131
			[Token(Token = "0x4022F1B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04022F1C RID: 143132
			[Token(Token = "0x4022F1C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
