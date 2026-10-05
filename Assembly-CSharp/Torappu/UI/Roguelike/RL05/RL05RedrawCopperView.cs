using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005595 RID: 21909
	[Token(Token = "0x2005595")]
	public class RL05RedrawCopperView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B7D RID: 19325
		// (get) Token: 0x060202E0 RID: 131808 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060202E1 RID: 131809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B7D")]
		public Action onExchangeDetailClicked
		{
			[Token(Token = "0x60202E0")]
			[Address(RVA = "0x1A58AE0", Offset = "0x1A576E0", VA = "0x181A58AE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60202E1")]
			[Address(RVA = "0x1A58B40", Offset = "0x1A57740", VA = "0x181A58B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060202E2 RID: 131810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202E2")]
		[Address(RVA = "0x1A58160", Offset = "0x1A56D60", VA = "0x181A58160")]
		public void Render(RoguelikeDrawCopperViewModel model, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060202E3 RID: 131811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202E3")]
		[Address(RVA = "0x1A587B0", Offset = "0x1A573B0", VA = "0x181A587B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060202E4 RID: 131812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60202E4")]
		[Address(RVA = "0x1A58900", Offset = "0x1A57500", VA = "0x181A58900")]
		private Tween _PlayShowAnimAndAudio(UIAnimationLocation location, string signal)
		{
			return null;
		}

		// Token: 0x060202E5 RID: 131813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202E5")]
		[Address(RVA = "0x1A58020", Offset = "0x1A56C20", VA = "0x181A58020")]
		public void OnClickSkipBtn()
		{
		}

		// Token: 0x060202E6 RID: 131814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202E6")]
		[Address(RVA = "0x1A58A60", Offset = "0x1A57660", VA = "0x181A58A60")]
		public RL05RedrawCopperView()
		{
		}

		// Token: 0x0402B7E2 RID: 178146
		[Token(Token = "0x402B7E2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL05DrawCopperReviewView _reviewViewPrefab;

		// Token: 0x0402B7E3 RID: 178147
		[Token(Token = "0x402B7E3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _reviewContent;

		// Token: 0x0402B7E4 RID: 178148
		[Token(Token = "0x402B7E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RL05DrawCopperGroupView> _copperGroups;

		// Token: 0x0402B7E5 RID: 178149
		[Token(Token = "0x402B7E5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _skipPanelGo;

		// Token: 0x0402B7E6 RID: 178150
		[Token(Token = "0x402B7E6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _goodShowAnimLocation;

		// Token: 0x0402B7E7 RID: 178151
		[Token(Token = "0x402B7E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _normShowAnimLocation;

		// Token: 0x0402B7E8 RID: 178152
		[Token(Token = "0x402B7E8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _badShowAnimLocation;

		// Token: 0x0402B7E9 RID: 178153
		[Token(Token = "0x402B7E9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RL05RedrawCopperResultView _resultView;

		// Token: 0x0402B7EA RID: 178154
		[Token(Token = "0x402B7EA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _copperShowDelay;

		// Token: 0x0402B7EB RID: 178155
		[Token(Token = "0x402B7EB")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _resultShowDelay;

		// Token: 0x0402B7EC RID: 178156
		[Token(Token = "0x402B7EC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _skipHideDelay;

		// Token: 0x0402B7ED RID: 178157
		[Token(Token = "0x402B7ED")]
		[FieldOffset(Offset = "0x80")]
		private Sequence m_showSequence;

		// Token: 0x0402B7EE RID: 178158
		[Token(Token = "0x402B7EE")]
		[FieldOffset(Offset = "0x88")]
		private RL05DrawCopperReviewView m_reviewView;

		// Token: 0x0402B7EF RID: 178159
		[Token(Token = "0x402B7EF")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0402B7F0 RID: 178160
		[Token(Token = "0x402B7F0")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeDrawCopperViewModel m_cachedViewModel;

		// Token: 0x0402B7F1 RID: 178161
		[Token(Token = "0x402B7F1")]
		[FieldOffset(Offset = "0xA0")]
		private ILoadAsset m_cachedAssetLoader;

		// Token: 0x0402B7F2 RID: 178162
		[Token(Token = "0x402B7F2")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Action onConfirmDraw;

		// Token: 0x0402B7F4 RID: 178164
		[Token(Token = "0x402B7F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onExchangeDetailClicked;

		// Token: 0x0402B7F5 RID: 178165
		[Token(Token = "0x402B7F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onExchangeDetailClicked;

		// Token: 0x0402B7F6 RID: 178166
		[Token(Token = "0x402B7F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B7F7 RID: 178167
		[Token(Token = "0x402B7F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B7F8 RID: 178168
		[Token(Token = "0x402B7F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayShowAnimAndAudio;

		// Token: 0x0402B7F9 RID: 178169
		[Token(Token = "0x402B7F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickSkipBtn;

		// Token: 0x0402B7FA RID: 178170
		[Token(Token = "0x402B7FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
