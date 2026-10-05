using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005591 RID: 21905
	[Token(Token = "0x2005591")]
	public class RL05RedrawCopperResultItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060202CE RID: 131790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202CE")]
		[Address(RVA = "0x1A56BD0", Offset = "0x1A557D0", VA = "0x181A56BD0")]
		public void Render(RoguelikePlayerCopperItemViewModel itemModel, ILoadAsset assetLoader, float showDelay, bool isFastMode)
		{
		}

		// Token: 0x060202CF RID: 131791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202CF")]
		[Address(RVA = "0x1A57280", Offset = "0x1A55E80", VA = "0x181A57280")]
		private void _PlayShowAnim(float showDelay, bool isFastMode)
		{
		}

		// Token: 0x060202D0 RID: 131792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202D0")]
		[Address(RVA = "0x1A57410", Offset = "0x1A56010", VA = "0x181A57410")]
		public RL05RedrawCopperResultItemView()
		{
		}

		// Token: 0x0402B7AA RID: 178090
		[Token(Token = "0x402B7AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _copperFrameItemHolder;

		// Token: 0x0402B7AB RID: 178091
		[Token(Token = "0x402B7AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _copperLuckyIcon;

		// Token: 0x0402B7AC RID: 178092
		[Token(Token = "0x402B7AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _copperName;

		// Token: 0x0402B7AD RID: 178093
		[Token(Token = "0x402B7AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _isDrawn;

		// Token: 0x0402B7AE RID: 178094
		[Token(Token = "0x402B7AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _countDownObj;

		// Token: 0x0402B7AF RID: 178095
		[Token(Token = "0x402B7AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _countDownText;

		// Token: 0x0402B7B0 RID: 178096
		[Token(Token = "0x402B7B0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _copperLayerDesc;

		// Token: 0x0402B7B1 RID: 178097
		[Token(Token = "0x402B7B1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0402B7B2 RID: 178098
		[Token(Token = "0x402B7B2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<Text> _poemTextList;

		// Token: 0x0402B7B3 RID: 178099
		[Token(Token = "0x402B7B3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RL05RedrawCopperResultItemView.DrawHitReasonTip[] _hitReasonTipList;

		// Token: 0x0402B7B4 RID: 178100
		[Token(Token = "0x402B7B4")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeCopperResHolder m_resHolder;

		// Token: 0x0402B7B5 RID: 178101
		[Token(Token = "0x402B7B5")]
		[FieldOffset(Offset = "0x78")]
		private RL05CommonCopperItemWithFrameView m_copperFrameItemView;

		// Token: 0x0402B7B6 RID: 178102
		[Token(Token = "0x402B7B6")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_showTween;

		// Token: 0x0402B7B7 RID: 178103
		[Token(Token = "0x402B7B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B7B8 RID: 178104
		[Token(Token = "0x402B7B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayShowAnim;

		// Token: 0x0402B7B9 RID: 178105
		[Token(Token = "0x402B7B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005592 RID: 21906
		[Token(Token = "0x2005592")]
		[Serializable]
		private struct DrawHitReasonTip
		{
			// Token: 0x0402B7BA RID: 178106
			[Token(Token = "0x402B7BA")]
			[FieldOffset(Offset = "0x0")]
			public PlayerRoguelikePendingEvent.DrawCopperHitReason hitReason;

			// Token: 0x0402B7BB RID: 178107
			[Token(Token = "0x402B7BB")]
			[FieldOffset(Offset = "0x8")]
			public GameObject[] panelHitReason;
		}
	}
}
