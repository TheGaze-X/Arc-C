using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053D4 RID: 21460
	[Token(Token = "0x20053D4")]
	public class RoguelikeRewardEntryLevelAndExpView : RLRewardEntryLevelPartView
	{
		// Token: 0x0601F952 RID: 129362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F952")]
		[Address(RVA = "0x1939840", Offset = "0x1938440", VA = "0x181939840", Slot = "4")]
		public override void Init(RoguelikeRewardEarnViewModel earnViewModel)
		{
		}

		// Token: 0x0601F953 RID: 129363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F953")]
		[Address(RVA = "0x1939750", Offset = "0x1938350", VA = "0x181939750", Slot = "5")]
		public override IEnumerator DealWithAnimation(RoguelikeRewardEarnViewModel earnViewModel, string stageId, string topicId)
		{
			return null;
		}

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x0601F954 RID: 129364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049F7")]
		public override GameObject stateRelatedEffect
		{
			[Token(Token = "0x601F954")]
			[Address(RVA = "0x1939C50", Offset = "0x1938850", VA = "0x181939C50", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F955 RID: 129365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F955")]
		[Address(RVA = "0x19399F0", Offset = "0x19385F0", VA = "0x1819399F0", Slot = "7")]
		protected virtual void _RenderExp(int maxLevel, int level, int exp, string topicId, RoguelikeRewardEarnViewModel earnViewModel)
		{
		}

		// Token: 0x0601F956 RID: 129366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F956")]
		[Address(RVA = "0x1939BB0", Offset = "0x19387B0", VA = "0x181939BB0")]
		public RoguelikeRewardEntryLevelAndExpView()
		{
		}

		// Token: 0x0402A857 RID: 174167
		[Token(Token = "0x402A857")]
		protected const float CONST_ALPHA = 0.4f;

		// Token: 0x0402A858 RID: 174168
		[Token(Token = "0x402A858")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Text _currentExp;

		// Token: 0x0402A859 RID: 174169
		[Token(Token = "0x402A859")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Text _currentLevel;

		// Token: 0x0402A85A RID: 174170
		[Token(Token = "0x402A85A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected CanvasGroup _addExpPart;

		// Token: 0x0402A85B RID: 174171
		[Token(Token = "0x402A85B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Text _addExp;

		// Token: 0x0402A85C RID: 174172
		[Token(Token = "0x402A85C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected CanvasGroup _levelUpPart;

		// Token: 0x0402A85D RID: 174173
		[Token(Token = "0x402A85D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject _levelUpEffect;

		// Token: 0x0402A85E RID: 174174
		[Token(Token = "0x402A85E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected RoguelikeRewardEntryPopListAdapter _popListAdapter;

		// Token: 0x0402A85F RID: 174175
		[Token(Token = "0x402A85F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected AnimationWrapper _levelUpAnimationWrapper;

		// Token: 0x0402A860 RID: 174176
		[Token(Token = "0x402A860")]
		[FieldOffset(Offset = "0x58")]
		protected Tween m_effectTween;

		// Token: 0x0402A861 RID: 174177
		[Token(Token = "0x402A861")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A862 RID: 174178
		[Token(Token = "0x402A862")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealWithAnimation;

		// Token: 0x0402A863 RID: 174179
		[Token(Token = "0x402A863")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stateRelatedEffect;

		// Token: 0x0402A864 RID: 174180
		[Token(Token = "0x402A864")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderExp;

		// Token: 0x0402A865 RID: 174181
		[Token(Token = "0x402A865")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
