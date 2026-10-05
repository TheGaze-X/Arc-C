using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D60 RID: 15712
	[Token(Token = "0x2003D60")]
	public class TemplateShopRarityListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018781 RID: 100225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018781")]
		[Address(RVA = "0x10F78F0", Offset = "0x10F64F0", VA = "0x1810F78F0")]
		public void _InitIfNot()
		{
		}

		// Token: 0x06018782 RID: 100226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018782")]
		[Address(RVA = "0x10F7700", Offset = "0x10F6300", VA = "0x1810F7700")]
		public void Render(List<TemplateShopRarityViewModel> viewModelList, TemplateShopResHolder resHolder)
		{
		}

		// Token: 0x06018783 RID: 100227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018783")]
		[Address(RVA = "0x10F7460", Offset = "0x10F6060", VA = "0x1810F7460")]
		public void FocusOnRarityList(int focusIdx)
		{
		}

		// Token: 0x06018784 RID: 100228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018784")]
		[Address(RVA = "0x10F7A00", Offset = "0x10F6600", VA = "0x1810F7A00")]
		public TemplateShopRarityListView()
		{
		}

		// Token: 0x0401DF86 RID: 122758
		[Token(Token = "0x401DF86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401DF87 RID: 122759
		[Token(Token = "0x401DF87")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401DF88 RID: 122760
		[Token(Token = "0x401DF88")]
		[FieldOffset(Offset = "0x28")]
		private TemplateShopRarityListView.Adapter m_adapter;

		// Token: 0x0401DF89 RID: 122761
		[Token(Token = "0x401DF89")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401DF8A RID: 122762
		[Token(Token = "0x401DF8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DF8B RID: 122763
		[Token(Token = "0x401DF8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DF8C RID: 122764
		[Token(Token = "0x401DF8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FocusOnRarityList;

		// Token: 0x0401DF8D RID: 122765
		[Token(Token = "0x401DF8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D61 RID: 15713
		[Token(Token = "0x2003D61")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003A6D RID: 14957
			// (get) Token: 0x06018785 RID: 100229 RVA: 0x0009A7B8 File Offset: 0x000989B8
			[Token(Token = "0x17003A6D")]
			public override int count
			{
				[Token(Token = "0x6018785")]
				[Address(RVA = "0x10E9370", Offset = "0x10E7F70", VA = "0x1810E9370", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018786 RID: 100230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018786")]
			[Address(RVA = "0x10E9100", Offset = "0x10E7D00", VA = "0x1810E9100", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018787 RID: 100231 RVA: 0x0009A7D0 File Offset: 0x000989D0
			[Token(Token = "0x6018787")]
			[Address(RVA = "0x10E8E30", Offset = "0x10E7A30", VA = "0x1810E8E30")]
			public float GetRarityPos(int index)
			{
				return 0f;
			}

			// Token: 0x06018788 RID: 100232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018788")]
			[Address(RVA = "0x10E92B0", Offset = "0x10E7EB0", VA = "0x1810E92B0")]
			public Adapter()
			{
			}

			// Token: 0x0401DF8E RID: 122766
			[Token(Token = "0x401DF8E")]
			[FieldOffset(Offset = "0x20")]
			public List<TemplateShopRarityViewModel> viewModelList;

			// Token: 0x0401DF8F RID: 122767
			[Token(Token = "0x401DF8F")]
			[FieldOffset(Offset = "0x28")]
			public TemplateShopResHolder resHolder;

			// Token: 0x0401DF90 RID: 122768
			[Token(Token = "0x401DF90")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401DF91 RID: 122769
			[Token(Token = "0x401DF91")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401DF92 RID: 122770
			[Token(Token = "0x401DF92")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetRarityPos;

			// Token: 0x0401DF93 RID: 122771
			[Token(Token = "0x401DF93")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
