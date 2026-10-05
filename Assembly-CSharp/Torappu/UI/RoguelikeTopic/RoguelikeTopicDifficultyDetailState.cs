using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044C4 RID: 17604
	[Token(Token = "0x20044C4")]
	public class RoguelikeTopicDifficultyDetailState : PopupFloatState
	{
		// Token: 0x0601AE1F RID: 110111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AE1F")]
		[Address(RVA = "0x14092B0", Offset = "0x1407EB0", VA = "0x1814092B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601AE20 RID: 110112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE20")]
		[Address(RVA = "0x1409820", Offset = "0x1408420", VA = "0x181409820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AE21 RID: 110113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE21")]
		[Address(RVA = "0x1409390", Offset = "0x1407F90", VA = "0x181409390", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601AE22 RID: 110114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE22")]
		[Address(RVA = "0x1409310", Offset = "0x1407F10", VA = "0x181409310")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601AE23 RID: 110115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE23")]
		[Address(RVA = "0x1409940", Offset = "0x1408540", VA = "0x181409940")]
		public RoguelikeTopicDifficultyDetailState()
		{
		}

		// Token: 0x0601AE24 RID: 110116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE24")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402272F RID: 141103
		[Token(Token = "0x402272F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _difficultyList;

		// Token: 0x04022730 RID: 141104
		[Token(Token = "0x4022730")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04022731 RID: 141105
		[Token(Token = "0x4022731")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeTopicDifficultyDetailStateBean m_stateBean;

		// Token: 0x04022732 RID: 141106
		[Token(Token = "0x4022732")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeTopicDifficultyDetailState.Adapter m_adapter;

		// Token: 0x04022733 RID: 141107
		[Token(Token = "0x4022733")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeTopicNormalModelStyle m_normalModeStyle;

		// Token: 0x04022734 RID: 141108
		[Token(Token = "0x4022734")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04022735 RID: 141109
		[Token(Token = "0x4022735")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022736 RID: 141110
		[Token(Token = "0x4022736")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022737 RID: 141111
		[Token(Token = "0x4022737")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022738 RID: 141112
		[Token(Token = "0x4022738")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04022739 RID: 141113
		[Token(Token = "0x4022739")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044C5 RID: 17605
		[Token(Token = "0x20044C5")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AE25 RID: 110117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AE25")]
			[Address(RVA = "0x1401040", Offset = "0x13FFC40", VA = "0x181401040")]
			public void SetData(List<RoguelikeTopicDifficultyItemModel> data)
			{
			}

			// Token: 0x17003FD3 RID: 16339
			// (get) Token: 0x0601AE26 RID: 110118 RVA: 0x000A3920 File Offset: 0x000A1B20
			[Token(Token = "0x17003FD3")]
			public override int count
			{
				[Token(Token = "0x601AE26")]
				[Address(RVA = "0x14011A0", Offset = "0x13FFDA0", VA = "0x1814011A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AE27 RID: 110119 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AE27")]
			[Address(RVA = "0x1400EA0", Offset = "0x13FFAA0", VA = "0x181400EA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AE28 RID: 110120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AE28")]
			[Address(RVA = "0x14010C0", Offset = "0x13FFCC0", VA = "0x1814010C0")]
			public Adapter()
			{
			}

			// Token: 0x0402273A RID: 141114
			[Token(Token = "0x402273A")]
			[FieldOffset(Offset = "0x20")]
			private List<RoguelikeTopicDifficultyItemModel> m_data;

			// Token: 0x0402273B RID: 141115
			[Token(Token = "0x402273B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x0402273C RID: 141116
			[Token(Token = "0x402273C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402273D RID: 141117
			[Token(Token = "0x402273D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402273E RID: 141118
			[Token(Token = "0x402273E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
