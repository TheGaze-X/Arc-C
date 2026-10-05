using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056B7 RID: 22199
	[Token(Token = "0x20056B7")]
	public class RL04FragmentDetailCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x060208F5 RID: 133365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060208F6 RID: 133366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C4A")]
		public ILoadAsset loader
		{
			[Token(Token = "0x60208F5")]
			[Address(RVA = "0x1AAB9E0", Offset = "0x1AAA5E0", VA = "0x181AAB9E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60208F6")]
			[Address(RVA = "0x1AABA40", Offset = "0x1AAA640", VA = "0x181AABA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060208F7 RID: 133367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208F7")]
		[Address(RVA = "0x1AAB680", Offset = "0x1AAA280", VA = "0x181AAB680")]
		public void Render(IRoguelikeFragmentItemModel viewModel)
		{
		}

		// Token: 0x060208F8 RID: 133368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208F8")]
		[Address(RVA = "0x1AAB8A0", Offset = "0x1AAA4A0", VA = "0x181AAB8A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060208F9 RID: 133369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208F9")]
		[Address(RVA = "0x1AAB980", Offset = "0x1AAA580", VA = "0x181AAB980")]
		public RL04FragmentDetailCard()
		{
		}

		// Token: 0x0402C1CC RID: 180684
		[Token(Token = "0x402C1CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL04FragmentItemCard _itemCard;

		// Token: 0x0402C1CD RID: 180685
		[Token(Token = "0x402C1CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x0402C1CE RID: 180686
		[Token(Token = "0x402C1CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL04FragmentDetailCard.TitleConfig[] _titleConfigList;

		// Token: 0x0402C1D0 RID: 180688
		[Token(Token = "0x402C1D0")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402C1D1 RID: 180689
		[Token(Token = "0x402C1D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402C1D2 RID: 180690
		[Token(Token = "0x402C1D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402C1D3 RID: 180691
		[Token(Token = "0x402C1D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C1D4 RID: 180692
		[Token(Token = "0x402C1D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C1D5 RID: 180693
		[Token(Token = "0x402C1D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056B8 RID: 22200
		[Token(Token = "0x20056B8")]
		[Serializable]
		private struct TitleConfig
		{
			// Token: 0x0402C1D6 RID: 180694
			[Token(Token = "0x402C1D6")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeFragmentType type;

			// Token: 0x0402C1D7 RID: 180695
			[Token(Token = "0x402C1D7")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelTitle;
		}
	}
}
