using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D62 RID: 15714
	[Token(Token = "0x2003D62")]
	public class TemplateShopRarityView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018789 RID: 100233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018789")]
		[Address(RVA = "0x10F9060", Offset = "0x10F7C60", VA = "0x1810F9060")]
		public void _InitIfNot()
		{
		}

		// Token: 0x0601878A RID: 100234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601878A")]
		[Address(RVA = "0x10F88C0", Offset = "0x10F74C0", VA = "0x1810F88C0")]
		public IEnumerator OnRefreshContent()
		{
			return null;
		}

		// Token: 0x0601878B RID: 100235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601878B")]
		[Address(RVA = "0x10F8970", Offset = "0x10F7570", VA = "0x1810F8970")]
		public void Render(TemplateShopRarityViewModel groupViewModel, int index, TemplateShopResHolder resHolder)
		{
		}

		// Token: 0x0601878C RID: 100236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601878C")]
		[Address(RVA = "0x10F9230", Offset = "0x10F7E30", VA = "0x1810F9230")]
		private void _RenderCustomBg(string bkgPath)
		{
		}

		// Token: 0x0601878D RID: 100237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601878D")]
		[Address(RVA = "0x10F9300", Offset = "0x10F7F00", VA = "0x1810F9300")]
		private void _RenderRarityBg(int index, TemplateShopResHolder resHolder)
		{
		}

		// Token: 0x0601878E RID: 100238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601878E")]
		[Address(RVA = "0x10F8E60", Offset = "0x10F7A60", VA = "0x1810F8E60")]
		private Sprite _GetRarityBg(TemplateShopResHolder resHolder, int index)
		{
			return null;
		}

		// Token: 0x0601878F RID: 100239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601878F")]
		[Address(RVA = "0x10F93E0", Offset = "0x10F7FE0", VA = "0x1810F93E0")]
		public TemplateShopRarityView()
		{
		}

		// Token: 0x0401DF94 RID: 122772
		[Token(Token = "0x401DF94")]
		private const int RARITY_LEVELS = 3;

		// Token: 0x0401DF95 RID: 122773
		[Token(Token = "0x401DF95")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401DF96 RID: 122774
		[Token(Token = "0x401DF96")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0401DF97 RID: 122775
		[Token(Token = "0x401DF97")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _lockedString;

		// Token: 0x0401DF98 RID: 122776
		[Token(Token = "0x401DF98")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _layOutGroup;

		// Token: 0x0401DF99 RID: 122777
		[Token(Token = "0x401DF99")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ContentSizeFitter _sizeFitter;

		// Token: 0x0401DF9A RID: 122778
		[Token(Token = "0x401DF9A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _rarityBg;

		// Token: 0x0401DF9B RID: 122779
		[Token(Token = "0x401DF9B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _rarityDotGo;

		// Token: 0x0401DF9C RID: 122780
		[Token(Token = "0x401DF9C")]
		[FieldOffset(Offset = "0x50")]
		private TemplateShopRarityView.Adapter m_adapter;

		// Token: 0x0401DF9D RID: 122781
		[Token(Token = "0x401DF9D")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0401DF9E RID: 122782
		[Token(Token = "0x401DF9E")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401DF9F RID: 122783
		[Token(Token = "0x401DF9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DFA0 RID: 122784
		[Token(Token = "0x401DFA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRefreshContent;

		// Token: 0x0401DFA1 RID: 122785
		[Token(Token = "0x401DFA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DFA2 RID: 122786
		[Token(Token = "0x401DFA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCustomBg;

		// Token: 0x0401DFA3 RID: 122787
		[Token(Token = "0x401DFA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderRarityBg;

		// Token: 0x0401DFA4 RID: 122788
		[Token(Token = "0x401DFA4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetRarityBg;

		// Token: 0x0401DFA5 RID: 122789
		[Token(Token = "0x401DFA5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D63 RID: 15715
		[Token(Token = "0x2003D63")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003A6E RID: 14958
			// (get) Token: 0x06018790 RID: 100240 RVA: 0x0009A7E8 File Offset: 0x000989E8
			[Token(Token = "0x17003A6E")]
			public override int count
			{
				[Token(Token = "0x6018790")]
				[Address(RVA = "0x10E93E0", Offset = "0x10E7FE0", VA = "0x1810E93E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018791 RID: 100241 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018791")]
			[Address(RVA = "0x10E8F60", Offset = "0x10E7B60", VA = "0x1810E8F60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018792 RID: 100242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018792")]
			[Address(RVA = "0x10E9310", Offset = "0x10E7F10", VA = "0x1810E9310")]
			public Adapter()
			{
			}

			// Token: 0x0401DFA6 RID: 122790
			[Token(Token = "0x401DFA6")]
			[FieldOffset(Offset = "0x20")]
			public List<TemplateCommonShopGoodViewModel> viewModelList;

			// Token: 0x0401DFA7 RID: 122791
			[Token(Token = "0x401DFA7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401DFA8 RID: 122792
			[Token(Token = "0x401DFA8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401DFA9 RID: 122793
			[Token(Token = "0x401DFA9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
