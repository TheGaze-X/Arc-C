using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200558E RID: 21902
	[Token(Token = "0x200558E")]
	public class RL05EventDrawCopperView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060202C0 RID: 131776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202C0")]
		[Address(RVA = "0x1A50AF0", Offset = "0x1A4F6F0", VA = "0x181A50AF0")]
		public void Render(RoguelikeDrawCopperViewModel model)
		{
		}

		// Token: 0x060202C1 RID: 131777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60202C1")]
		[Address(RVA = "0x1A50F80", Offset = "0x1A4FB80", VA = "0x181A50F80")]
		private Tween _PlayShowAnimAndAudio(UIAnimationLocation location, string signal)
		{
			return null;
		}

		// Token: 0x060202C2 RID: 131778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202C2")]
		[Address(RVA = "0x1A50940", Offset = "0x1A4F540", VA = "0x181A50940")]
		public void OnClickConfirmDrawPending()
		{
		}

		// Token: 0x060202C3 RID: 131779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202C3")]
		[Address(RVA = "0x1A509E0", Offset = "0x1A4F5E0", VA = "0x181A509E0")]
		public void OnClickSkipBtn()
		{
		}

		// Token: 0x060202C4 RID: 131780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202C4")]
		[Address(RVA = "0x1A510E0", Offset = "0x1A4FCE0", VA = "0x181A510E0")]
		public RL05EventDrawCopperView()
		{
		}

		// Token: 0x0402B78A RID: 178058
		[Token(Token = "0x402B78A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL05DrawCopperReviewView _reviewViewPrefab;

		// Token: 0x0402B78B RID: 178059
		[Token(Token = "0x402B78B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _reviewContent;

		// Token: 0x0402B78C RID: 178060
		[Token(Token = "0x402B78C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RL05DrawCopperGroupView> _copperGroups;

		// Token: 0x0402B78D RID: 178061
		[Token(Token = "0x402B78D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _goodShowAnimLocation;

		// Token: 0x0402B78E RID: 178062
		[Token(Token = "0x402B78E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _normShowAnimLocation;

		// Token: 0x0402B78F RID: 178063
		[Token(Token = "0x402B78F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _badShowAnimLocation;

		// Token: 0x0402B790 RID: 178064
		[Token(Token = "0x402B790")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _copperShowDelay;

		// Token: 0x0402B791 RID: 178065
		[Token(Token = "0x402B791")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _resultDesc;

		// Token: 0x0402B792 RID: 178066
		[Token(Token = "0x402B792")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _skipPanelGo;

		// Token: 0x0402B793 RID: 178067
		[Token(Token = "0x402B793")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _skipHideDelay;

		// Token: 0x0402B794 RID: 178068
		[Token(Token = "0x402B794")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action onConfirmDrawPending;

		// Token: 0x0402B795 RID: 178069
		[Token(Token = "0x402B795")]
		[FieldOffset(Offset = "0x88")]
		private Sequence m_showSequence;

		// Token: 0x0402B796 RID: 178070
		[Token(Token = "0x402B796")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B797 RID: 178071
		[Token(Token = "0x402B797")]
		[FieldOffset(Offset = "0xA0")]
		private RL05DrawCopperReviewView m_reviewView;

		// Token: 0x0402B798 RID: 178072
		[Token(Token = "0x402B798")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeDrawCopperViewModel m_cachedViewModel;

		// Token: 0x0402B799 RID: 178073
		[Token(Token = "0x402B799")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_confirmed;

		// Token: 0x0402B79A RID: 178074
		[Token(Token = "0x402B79A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B79B RID: 178075
		[Token(Token = "0x402B79B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayShowAnimAndAudio;

		// Token: 0x0402B79C RID: 178076
		[Token(Token = "0x402B79C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickConfirmDrawPending;

		// Token: 0x0402B79D RID: 178077
		[Token(Token = "0x402B79D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickSkipBtn;

		// Token: 0x0402B79E RID: 178078
		[Token(Token = "0x402B79E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
