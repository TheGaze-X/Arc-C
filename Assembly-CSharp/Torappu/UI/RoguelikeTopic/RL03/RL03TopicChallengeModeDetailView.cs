using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045A6 RID: 17830
	[Token(Token = "0x20045A6")]
	public class RL03TopicChallengeModeDetailView : RoguelikeTopicChallengeModeDetailViewBase
	{
		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x0601B231 RID: 111153 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B232 RID: 111154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040AA")]
		private RoguelikeTopicChallengeModeDetailState bindState
		{
			[Token(Token = "0x601B231")]
			[Address(RVA = "0x144CB10", Offset = "0x144B710", VA = "0x18144CB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B232")]
			[Address(RVA = "0x144CB70", Offset = "0x144B770", VA = "0x18144CB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B233 RID: 111155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B233")]
		[Address(RVA = "0x144C5A0", Offset = "0x144B1A0", VA = "0x18144C5A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B234 RID: 111156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B234")]
		[Address(RVA = "0x144C450", Offset = "0x144B050", VA = "0x18144C450", Slot = "8")]
		public override void Init(RoguelikeTopicChallengeModeDetailState state)
		{
		}

		// Token: 0x0601B235 RID: 111157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B235")]
		[Address(RVA = "0x144C500", Offset = "0x144B100", VA = "0x18144C500", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B236 RID: 111158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B236")]
		[Address(RVA = "0x144C780", Offset = "0x144B380", VA = "0x18144C780")]
		private void _Render(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B237 RID: 111159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B237")]
		[Address(RVA = "0x144CAB0", Offset = "0x144B6B0", VA = "0x18144CAB0")]
		public RL03TopicChallengeModeDetailView()
		{
		}

		// Token: 0x04022ED9 RID: 143065
		[Token(Token = "0x4022ED9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _challengeModeTitleText;

		// Token: 0x04022EDA RID: 143066
		[Token(Token = "0x4022EDA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _challengeModeDesc;

		// Token: 0x04022EDB RID: 143067
		[Token(Token = "0x4022EDB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _challengeModeSubDesc;

		// Token: 0x04022EDC RID: 143068
		[Token(Token = "0x4022EDC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _challengeTargetTitleName;

		// Token: 0x04022EDD RID: 143069
		[Token(Token = "0x4022EDD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _challengeTargetPrefixText;

		// Token: 0x04022EDE RID: 143070
		[Token(Token = "0x4022EDE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _taskList;

		// Token: 0x04022EDF RID: 143071
		[Token(Token = "0x4022EDF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x04022EE0 RID: 143072
		[Token(Token = "0x4022EE0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelRewardNotReceived;

		// Token: 0x04022EE1 RID: 143073
		[Token(Token = "0x4022EE1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelRewardReceived;

		// Token: 0x04022EE2 RID: 143074
		[Token(Token = "0x4022EE2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasItems;

		// Token: 0x04022EE4 RID: 143076
		[Token(Token = "0x4022EE4")]
		[FieldOffset(Offset = "0x78")]
		private RL03TopicChallengeModeDetailView.TaskAdapter m_taskListAdapter;

		// Token: 0x04022EE5 RID: 143077
		[Token(Token = "0x4022EE5")]
		[FieldOffset(Offset = "0x80")]
		private RL03TopicChallengeModeDetailView.RewardAdapter m_rewardListAdapter;

		// Token: 0x04022EE6 RID: 143078
		[Token(Token = "0x4022EE6")]
		[FieldOffset(Offset = "0x88")]
		private List<RoguelikeTopicTaskInfo> m_cachedTaskList;

		// Token: 0x04022EE7 RID: 143079
		[Token(Token = "0x4022EE7")]
		[FieldOffset(Offset = "0x90")]
		private List<ItemBundle> m_cachedRewardList;

		// Token: 0x04022EE8 RID: 143080
		[Token(Token = "0x4022EE8")]
		[FieldOffset(Offset = "0x98")]
		private bool m_cachedRewardReceived;

		// Token: 0x04022EE9 RID: 143081
		[Token(Token = "0x4022EE9")]
		[FieldOffset(Offset = "0x99")]
		private bool m_hasInited;

		// Token: 0x04022EEA RID: 143082
		[Token(Token = "0x4022EEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindState;

		// Token: 0x04022EEB RID: 143083
		[Token(Token = "0x4022EEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x04022EEC RID: 143084
		[Token(Token = "0x4022EEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022EED RID: 143085
		[Token(Token = "0x4022EED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022EEE RID: 143086
		[Token(Token = "0x4022EEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022EEF RID: 143087
		[Token(Token = "0x4022EEF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04022EF0 RID: 143088
		[Token(Token = "0x4022EF0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045A7 RID: 17831
		[Token(Token = "0x20045A7")]
		private class TaskAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B238 RID: 111160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B238")]
			[Address(RVA = "0x14594A0", Offset = "0x14580A0", VA = "0x1814594A0")]
			public TaskAdapter(RL03TopicChallengeModeDetailView closure)
			{
			}

			// Token: 0x170040AB RID: 16555
			// (get) Token: 0x0601B239 RID: 111161 RVA: 0x000A4778 File Offset: 0x000A2978
			[Token(Token = "0x170040AB")]
			public override int count
			{
				[Token(Token = "0x601B239")]
				[Address(RVA = "0x1459520", Offset = "0x1458120", VA = "0x181459520", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B23A RID: 111162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B23A")]
			[Address(RVA = "0x14592F0", Offset = "0x1457EF0", VA = "0x1814592F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04022EF1 RID: 143089
			[Token(Token = "0x4022EF1")]
			[FieldOffset(Offset = "0x20")]
			private RL03TopicChallengeModeDetailView m_closure;

			// Token: 0x04022EF2 RID: 143090
			[Token(Token = "0x4022EF2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022EF3 RID: 143091
			[Token(Token = "0x4022EF3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022EF4 RID: 143092
			[Token(Token = "0x4022EF4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020045A8 RID: 17832
		[Token(Token = "0x20045A8")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B23B RID: 111163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B23B")]
			[Address(RVA = "0x14544B0", Offset = "0x14530B0", VA = "0x1814544B0")]
			public RewardAdapter(RL03TopicChallengeModeDetailView closure)
			{
			}

			// Token: 0x170040AC RID: 16556
			// (get) Token: 0x0601B23C RID: 111164 RVA: 0x000A4790 File Offset: 0x000A2990
			[Token(Token = "0x170040AC")]
			public override int count
			{
				[Token(Token = "0x601B23C")]
				[Address(RVA = "0x1454530", Offset = "0x1453130", VA = "0x181454530", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B23D RID: 111165 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B23D")]
			[Address(RVA = "0x14542E0", Offset = "0x1452EE0", VA = "0x1814542E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04022EF5 RID: 143093
			[Token(Token = "0x4022EF5")]
			[FieldOffset(Offset = "0x20")]
			private RL03TopicChallengeModeDetailView m_closure;

			// Token: 0x04022EF6 RID: 143094
			[Token(Token = "0x4022EF6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022EF7 RID: 143095
			[Token(Token = "0x4022EF7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022EF8 RID: 143096
			[Token(Token = "0x4022EF8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
