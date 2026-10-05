using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044AF RID: 17583
	[Token(Token = "0x20044AF")]
	public class RoguelikeTopicChallengeModeDetailView : RoguelikeTopicChallengeModeDetailViewBase
	{
		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x0601ADC1 RID: 110017 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ADC2 RID: 110018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FC0")]
		private RoguelikeTopicChallengeModeDetailState bindState
		{
			[Token(Token = "0x601ADC1")]
			[Address(RVA = "0x1404F30", Offset = "0x1403B30", VA = "0x181404F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601ADC2")]
			[Address(RVA = "0x1404F90", Offset = "0x1403B90", VA = "0x181404F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601ADC3 RID: 110019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADC3")]
		[Address(RVA = "0x1404980", Offset = "0x1403580", VA = "0x181404980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ADC4 RID: 110020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADC4")]
		[Address(RVA = "0x1404830", Offset = "0x1403430", VA = "0x181404830", Slot = "8")]
		public override void Init(RoguelikeTopicChallengeModeDetailState state)
		{
		}

		// Token: 0x0601ADC5 RID: 110021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADC5")]
		[Address(RVA = "0x14048E0", Offset = "0x14034E0", VA = "0x1814048E0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601ADC6 RID: 110022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADC6")]
		[Address(RVA = "0x1404B60", Offset = "0x1403760", VA = "0x181404B60")]
		private void _Render(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601ADC7 RID: 110023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADC7")]
		[Address(RVA = "0x1404E80", Offset = "0x1403A80", VA = "0x181404E80")]
		public RoguelikeTopicChallengeModeDetailView()
		{
		}

		// Token: 0x0402267D RID: 140925
		[Token(Token = "0x402267D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _challengeModeDesc;

		// Token: 0x0402267E RID: 140926
		[Token(Token = "0x402267E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _challengeModeSubDesc;

		// Token: 0x0402267F RID: 140927
		[Token(Token = "0x402267F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _challengeName;

		// Token: 0x04022680 RID: 140928
		[Token(Token = "0x4022680")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _taskList;

		// Token: 0x04022681 RID: 140929
		[Token(Token = "0x4022681")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x04022682 RID: 140930
		[Token(Token = "0x4022682")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlAwardReceived;

		// Token: 0x04022683 RID: 140931
		[Token(Token = "0x4022683")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasItems;

		// Token: 0x04022684 RID: 140932
		[Token(Token = "0x4022684")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _challengeModeTitleName;

		// Token: 0x04022685 RID: 140933
		[Token(Token = "0x4022685")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _challengeTaskTitleName;

		// Token: 0x04022686 RID: 140934
		[Token(Token = "0x4022686")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _challengeTaskTargetTitleName;

		// Token: 0x04022688 RID: 140936
		[Token(Token = "0x4022688")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeTopicChallengeModeDetailView.TaskAdapter m_taskListAdapter;

		// Token: 0x04022689 RID: 140937
		[Token(Token = "0x4022689")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeTopicChallengeModeDetailView.RewardAdapter m_rewardListAdapter;

		// Token: 0x0402268A RID: 140938
		[Token(Token = "0x402268A")]
		[FieldOffset(Offset = "0x88")]
		private List<RoguelikeTopicTaskInfo> m_cachedTaskList;

		// Token: 0x0402268B RID: 140939
		[Token(Token = "0x402268B")]
		[FieldOffset(Offset = "0x90")]
		private List<ItemBundle> m_cachedRewardList;

		// Token: 0x0402268C RID: 140940
		[Token(Token = "0x402268C")]
		[FieldOffset(Offset = "0x98")]
		private bool m_cachedRewardReceived;

		// Token: 0x0402268D RID: 140941
		[Token(Token = "0x402268D")]
		[FieldOffset(Offset = "0x99")]
		private bool m_hasInited;

		// Token: 0x0402268E RID: 140942
		[Token(Token = "0x402268E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindState;

		// Token: 0x0402268F RID: 140943
		[Token(Token = "0x402268F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x04022690 RID: 140944
		[Token(Token = "0x4022690")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022691 RID: 140945
		[Token(Token = "0x4022691")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022692 RID: 140946
		[Token(Token = "0x4022692")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022693 RID: 140947
		[Token(Token = "0x4022693")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04022694 RID: 140948
		[Token(Token = "0x4022694")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044B0 RID: 17584
		[Token(Token = "0x20044B0")]
		private class TaskAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601ADC8 RID: 110024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADC8")]
			[Address(RVA = "0x1415C40", Offset = "0x1414840", VA = "0x181415C40")]
			public TaskAdapter(RoguelikeTopicChallengeModeDetailView closure)
			{
			}

			// Token: 0x17003FC1 RID: 16321
			// (get) Token: 0x0601ADC9 RID: 110025 RVA: 0x000A3800 File Offset: 0x000A1A00
			[Token(Token = "0x17003FC1")]
			public override int count
			{
				[Token(Token = "0x601ADC9")]
				[Address(RVA = "0x1415CC0", Offset = "0x14148C0", VA = "0x181415CC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601ADCA RID: 110026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ADCA")]
			[Address(RVA = "0x1415A90", Offset = "0x1414690", VA = "0x181415A90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04022695 RID: 140949
			[Token(Token = "0x4022695")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicChallengeModeDetailView m_closure;

			// Token: 0x04022696 RID: 140950
			[Token(Token = "0x4022696")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022697 RID: 140951
			[Token(Token = "0x4022697")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022698 RID: 140952
			[Token(Token = "0x4022698")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020044B1 RID: 17585
		[Token(Token = "0x20044B1")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601ADCB RID: 110027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADCB")]
			[Address(RVA = "0x1402130", Offset = "0x1400D30", VA = "0x181402130")]
			public RewardAdapter(RoguelikeTopicChallengeModeDetailView closure)
			{
			}

			// Token: 0x17003FC2 RID: 16322
			// (get) Token: 0x0601ADCC RID: 110028 RVA: 0x000A3818 File Offset: 0x000A1A18
			[Token(Token = "0x17003FC2")]
			public override int count
			{
				[Token(Token = "0x601ADCC")]
				[Address(RVA = "0x14021B0", Offset = "0x1400DB0", VA = "0x1814021B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601ADCD RID: 110029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ADCD")]
			[Address(RVA = "0x1401F60", Offset = "0x1400B60", VA = "0x181401F60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04022699 RID: 140953
			[Token(Token = "0x4022699")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicChallengeModeDetailView m_closure;

			// Token: 0x0402269A RID: 140954
			[Token(Token = "0x402269A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402269B RID: 140955
			[Token(Token = "0x402269B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402269C RID: 140956
			[Token(Token = "0x402269C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
