using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005593 RID: 21907
	[Token(Token = "0x2005593")]
	public class RL05RedrawCopperResultView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B7B RID: 19323
		// (get) Token: 0x060202D1 RID: 131793 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060202D2 RID: 131794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B7B")]
		public Action onExchangeDetailClicked
		{
			[Token(Token = "0x60202D1")]
			[Address(RVA = "0x1A57F40", Offset = "0x1A56B40", VA = "0x181A57F40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60202D2")]
			[Address(RVA = "0x1A57FA0", Offset = "0x1A56BA0", VA = "0x181A57FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060202D3 RID: 131795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202D3")]
		[Address(RVA = "0x1A57620", Offset = "0x1A56220", VA = "0x181A57620")]
		public void Render(RoguelikeDrawCopperViewModel model, ILoadAsset assetLoader, bool isFastMode)
		{
		}

		// Token: 0x060202D4 RID: 131796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202D4")]
		[Address(RVA = "0x1A57990", Offset = "0x1A56590", VA = "0x181A57990")]
		public void ResetShow(bool isShow, bool isFastMode)
		{
		}

		// Token: 0x060202D5 RID: 131797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202D5")]
		[Address(RVA = "0x1A57B60", Offset = "0x1A56760", VA = "0x181A57B60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060202D6 RID: 131798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202D6")]
		[Address(RVA = "0x1A57D10", Offset = "0x1A56910", VA = "0x181A57D10")]
		private void _PlayShowAnim(UIAnimationLocation location, bool isFastMode)
		{
		}

		// Token: 0x060202D7 RID: 131799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202D7")]
		[Address(RVA = "0x1A57E70", Offset = "0x1A56A70", VA = "0x181A57E70")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x060202D8 RID: 131800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202D8")]
		[Address(RVA = "0x1A57A60", Offset = "0x1A56660", VA = "0x181A57A60")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x060202D9 RID: 131801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202D9")]
		[Address(RVA = "0x1A575C0", Offset = "0x1A561C0", VA = "0x181A575C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060202DA RID: 131802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202DA")]
		[Address(RVA = "0x1A57540", Offset = "0x1A56140", VA = "0x181A57540")]
		public void OnClickConfirmRedraw()
		{
		}

		// Token: 0x060202DB RID: 131803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202DB")]
		[Address(RVA = "0x1A57470", Offset = "0x1A56070", VA = "0x181A57470")]
		public void EventOnExchangeDetailClicked()
		{
		}

		// Token: 0x060202DC RID: 131804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202DC")]
		[Address(RVA = "0x1A57EE0", Offset = "0x1A56AE0", VA = "0x181A57EE0")]
		public RL05RedrawCopperResultView()
		{
		}

		// Token: 0x0402B7BC RID: 178108
		[Token(Token = "0x402B7BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _blur;

		// Token: 0x0402B7BD RID: 178109
		[Token(Token = "0x402B7BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402B7BE RID: 178110
		[Token(Token = "0x402B7BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _resultCopperContent;

		// Token: 0x0402B7BF RID: 178111
		[Token(Token = "0x402B7BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _goodShowAnimLocation;

		// Token: 0x0402B7C0 RID: 178112
		[Token(Token = "0x402B7C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _normShowAnimLocation;

		// Token: 0x0402B7C1 RID: 178113
		[Token(Token = "0x402B7C1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _badShowAnimLocation;

		// Token: 0x0402B7C2 RID: 178114
		[Token(Token = "0x402B7C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<RL05DrawCopperGroupView> _copperGroups;

		// Token: 0x0402B7C3 RID: 178115
		[Token(Token = "0x402B7C3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _resultDesc;

		// Token: 0x0402B7C4 RID: 178116
		[Token(Token = "0x402B7C4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402B7C5 RID: 178117
		[Token(Token = "0x402B7C5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelExchangeDetail;

		// Token: 0x0402B7C6 RID: 178118
		[Token(Token = "0x402B7C6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textExchangeCount;

		// Token: 0x0402B7C7 RID: 178119
		[Token(Token = "0x402B7C7")]
		[FieldOffset(Offset = "0x88")]
		private RL05RedrawCopperResultView.RedrawCopperResultAdapter m_adapter;

		// Token: 0x0402B7C8 RID: 178120
		[Token(Token = "0x402B7C8")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_showTween;

		// Token: 0x0402B7C9 RID: 178121
		[Token(Token = "0x402B7C9")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0402B7CA RID: 178122
		[Token(Token = "0x402B7CA")]
		[FieldOffset(Offset = "0x99")]
		private bool m_isPending;

		// Token: 0x0402B7CB RID: 178123
		[Token(Token = "0x402B7CB")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0402B7CC RID: 178124
		[Token(Token = "0x402B7CC")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Action onConfirmDrawPending;

		// Token: 0x0402B7CE RID: 178126
		[Token(Token = "0x402B7CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onExchangeDetailClicked;

		// Token: 0x0402B7CF RID: 178127
		[Token(Token = "0x402B7CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onExchangeDetailClicked;

		// Token: 0x0402B7D0 RID: 178128
		[Token(Token = "0x402B7D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B7D1 RID: 178129
		[Token(Token = "0x402B7D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetShow;

		// Token: 0x0402B7D2 RID: 178130
		[Token(Token = "0x402B7D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B7D3 RID: 178131
		[Token(Token = "0x402B7D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayShowAnim;

		// Token: 0x0402B7D4 RID: 178132
		[Token(Token = "0x402B7D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x0402B7D5 RID: 178133
		[Token(Token = "0x402B7D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x0402B7D6 RID: 178134
		[Token(Token = "0x402B7D6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402B7D7 RID: 178135
		[Token(Token = "0x402B7D7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClickConfirmRedraw;

		// Token: 0x0402B7D8 RID: 178136
		[Token(Token = "0x402B7D8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnExchangeDetailClicked;

		// Token: 0x0402B7D9 RID: 178137
		[Token(Token = "0x402B7D9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005594 RID: 21908
		[Token(Token = "0x2005594")]
		private class RedrawCopperResultAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004B7C RID: 19324
			// (get) Token: 0x060202DD RID: 131805 RVA: 0x000B4DF8 File Offset: 0x000B2FF8
			[Token(Token = "0x17004B7C")]
			public override int count
			{
				[Token(Token = "0x60202DD")]
				[Address(RVA = "0x1A5D2D0", Offset = "0x1A5BED0", VA = "0x181A5D2D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060202DE RID: 131806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60202DE")]
			[Address(RVA = "0x1A5D0B0", Offset = "0x1A5BCB0", VA = "0x181A5D0B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060202DF RID: 131807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60202DF")]
			[Address(RVA = "0x1A5D270", Offset = "0x1A5BE70", VA = "0x181A5D270")]
			public RedrawCopperResultAdapter()
			{
			}

			// Token: 0x0402B7DA RID: 178138
			[Token(Token = "0x402B7DA")]
			private const float SHOW_DELAY = 0.4f;

			// Token: 0x0402B7DB RID: 178139
			[Token(Token = "0x402B7DB")]
			private const float SHOW_DELAY_BETWEEN = 0.2f;

			// Token: 0x0402B7DC RID: 178140
			[Token(Token = "0x402B7DC")]
			[FieldOffset(Offset = "0x20")]
			public ILoadAsset assetLoader;

			// Token: 0x0402B7DD RID: 178141
			[Token(Token = "0x402B7DD")]
			[FieldOffset(Offset = "0x28")]
			public List<RoguelikePlayerCopperItemViewModel> dataSource;

			// Token: 0x0402B7DE RID: 178142
			[Token(Token = "0x402B7DE")]
			[FieldOffset(Offset = "0x30")]
			public bool isFastMode;

			// Token: 0x0402B7DF RID: 178143
			[Token(Token = "0x402B7DF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402B7E0 RID: 178144
			[Token(Token = "0x402B7E0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402B7E1 RID: 178145
			[Token(Token = "0x402B7E1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
