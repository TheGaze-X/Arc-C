using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051A3 RID: 20899
	[Token(Token = "0x20051A3")]
	public class RoguelikeChoiceAnimEffect : RoguelikeChoiceEffectBase, IHotfixable
	{
		// Token: 0x0601EDFA RID: 126458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDFA")]
		[Address(RVA = "0x189FF00", Offset = "0x189EB00", VA = "0x18189FF00", Slot = "4")]
		public override void SetChoiceBgEffectVisible(bool isActive, string assetName)
		{
		}

		// Token: 0x0601EDFB RID: 126459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDFB")]
		[Address(RVA = "0x18A00D0", Offset = "0x189ECD0", VA = "0x1818A00D0")]
		private void _OnLeaveAnimEnd()
		{
		}

		// Token: 0x0601EDFC RID: 126460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDFC")]
		[Address(RVA = "0x18A0130", Offset = "0x189ED30", VA = "0x1818A0130")]
		public RoguelikeChoiceAnimEffect()
		{
		}

		// Token: 0x040296B2 RID: 169650
		[Token(Token = "0x40296B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040296B3 RID: 169651
		[Token(Token = "0x40296B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _leaveAnim;

		// Token: 0x040296B4 RID: 169652
		[Token(Token = "0x40296B4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _effectObject;

		// Token: 0x040296B5 RID: 169653
		[Token(Token = "0x40296B5")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isActive;

		// Token: 0x040296B6 RID: 169654
		[Token(Token = "0x40296B6")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_playingTween;

		// Token: 0x040296B7 RID: 169655
		[Token(Token = "0x40296B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetChoiceBgEffectVisible;

		// Token: 0x040296B8 RID: 169656
		[Token(Token = "0x40296B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnLeaveAnimEnd;

		// Token: 0x040296B9 RID: 169657
		[Token(Token = "0x40296B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
