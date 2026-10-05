using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051A4 RID: 20900
	[Token(Token = "0x20051A4")]
	public class RoguelikeChoiceEffect : RoguelikeChoiceEffectBase, IHotfixable
	{
		// Token: 0x0601EDFD RID: 126461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EDFD")]
		[Address(RVA = "0x18A0530", Offset = "0x189F130", VA = "0x1818A0530")]
		private IEnumerator _SceneHideTween()
		{
			return null;
		}

		// Token: 0x0601EDFE RID: 126462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDFE")]
		[Address(RVA = "0x18A0310", Offset = "0x189EF10", VA = "0x1818A0310", Slot = "4")]
		public override void SetChoiceBgEffectVisible(bool isActive, string assetName)
		{
		}

		// Token: 0x0601EDFF RID: 126463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDFF")]
		[Address(RVA = "0x18A05E0", Offset = "0x189F1E0", VA = "0x1818A05E0")]
		public RoguelikeChoiceEffect()
		{
		}

		// Token: 0x040296BA RID: 169658
		[Token(Token = "0x40296BA")]
		private const int FADEIN_FRAME = 20;

		// Token: 0x040296BB RID: 169659
		[Token(Token = "0x40296BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _choiceStaticBg;

		// Token: 0x040296BC RID: 169660
		[Token(Token = "0x40296BC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _choiceBlackBg;

		// Token: 0x040296BD RID: 169661
		[Token(Token = "0x40296BD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _choiceBlackBgAlpha;

		// Token: 0x040296BE RID: 169662
		[Token(Token = "0x40296BE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _choiceParticleGo;

		// Token: 0x040296BF RID: 169663
		[Token(Token = "0x40296BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _choiceEffectGo;

		// Token: 0x040296C0 RID: 169664
		[Token(Token = "0x40296C0")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isActive;

		// Token: 0x040296C1 RID: 169665
		[Token(Token = "0x40296C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SceneHideTween;

		// Token: 0x040296C2 RID: 169666
		[Token(Token = "0x40296C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetChoiceBgEffectVisible;

		// Token: 0x040296C3 RID: 169667
		[Token(Token = "0x40296C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
