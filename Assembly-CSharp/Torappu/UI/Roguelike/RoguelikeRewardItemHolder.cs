using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053E6 RID: 21478
	[Token(Token = "0x20053E6")]
	public class RoguelikeRewardItemHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x0601F9A4 RID: 129444 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F9A5 RID: 129445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A02")]
		public UIIntEvent onClickEvent
		{
			[Token(Token = "0x601F9A4")]
			[Address(RVA = "0x193E580", Offset = "0x193D180", VA = "0x18193E580")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F9A5")]
			[Address(RVA = "0x193E5E0", Offset = "0x193D1E0", VA = "0x18193E5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x0601F9A6 RID: 129446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A03")]
		public CanvasGroup alphaHandler
		{
			[Token(Token = "0x601F9A6")]
			[Address(RVA = "0x193E520", Offset = "0x193D120", VA = "0x18193E520")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F9A7 RID: 129447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9A7")]
		[Address(RVA = "0x193DF20", Offset = "0x193CB20", VA = "0x18193DF20")]
		public void ApplyAnimation()
		{
		}

		// Token: 0x0601F9A8 RID: 129448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9A8")]
		[Address(RVA = "0x193E3C0", Offset = "0x193CFC0", VA = "0x18193E3C0")]
		public void ToAnimationBegin()
		{
		}

		// Token: 0x0601F9A9 RID: 129449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9A9")]
		[Address(RVA = "0x193E440", Offset = "0x193D040", VA = "0x18193E440")]
		public void ToAnimationEnd()
		{
		}

		// Token: 0x0601F9AA RID: 129450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9AA")]
		[Address(RVA = "0x193DFB0", Offset = "0x193CBB0", VA = "0x18193DFB0")]
		public void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F9AB RID: 129451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9AB")]
		[Address(RVA = "0x193E4C0", Offset = "0x193D0C0", VA = "0x18193E4C0")]
		public RoguelikeRewardItemHolder()
		{
		}

		// Token: 0x0402A907 RID: 174343
		[Token(Token = "0x402A907")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeRewardItem[] _rewardItemList;

		// Token: 0x0402A908 RID: 174344
		[Token(Token = "0x402A908")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402A909 RID: 174345
		[Token(Token = "0x402A909")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0402A90A RID: 174346
		[Token(Token = "0x402A90A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402A90B RID: 174347
		[Token(Token = "0x402A90B")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeRewardItem m_cachedItem;

		// Token: 0x0402A90C RID: 174348
		[Token(Token = "0x402A90C")]
		[FieldOffset(Offset = "0x40")]
		private bool m_entryAnimPlayed;

		// Token: 0x0402A90E RID: 174350
		[Token(Token = "0x402A90E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A90F RID: 174351
		[Token(Token = "0x402A90F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A910 RID: 174352
		[Token(Token = "0x402A910")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x0402A911 RID: 174353
		[Token(Token = "0x402A911")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyAnimation;

		// Token: 0x0402A912 RID: 174354
		[Token(Token = "0x402A912")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ToAnimationBegin;

		// Token: 0x0402A913 RID: 174355
		[Token(Token = "0x402A913")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ToAnimationEnd;

		// Token: 0x0402A914 RID: 174356
		[Token(Token = "0x402A914")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A915 RID: 174357
		[Token(Token = "0x402A915")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
