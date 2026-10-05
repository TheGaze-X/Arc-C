using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007682 RID: 30338
	[Token(Token = "0x2007682")]
	public class Act20sideCollectionView : DataBinder<Act20sideCollectionProperty>, IHotfixable
	{
		// Token: 0x0602AABF RID: 174783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AABF")]
		[Address(RVA = "0x2671E80", Offset = "0x2670A80", VA = "0x182671E80")]
		private UIAtlasObject _EnsureAtlasObject()
		{
			return null;
		}

		// Token: 0x0602AAC0 RID: 174784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAC0")]
		[Address(RVA = "0x2671910", Offset = "0x2670510", VA = "0x182671910")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602AAC1 RID: 174785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAC1")]
		[Address(RVA = "0x2672A70", Offset = "0x2671670", VA = "0x182672A70")]
		private void _UnloadCart()
		{
		}

		// Token: 0x0602AAC2 RID: 174786 RVA: 0x000D95D8 File Offset: 0x000D77D8
		[Token(Token = "0x602AAC2")]
		[Address(RVA = "0x2671FC0", Offset = "0x2670BC0", VA = "0x182671FC0")]
		private SpriteRenderData _GetSpriteCart(string compId, CartComponents.CartAccessoryPos pos)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x17006442 RID: 25666
		// (get) Token: 0x0602AAC3 RID: 174787 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AAC4 RID: 174788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006442")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x602AAC3")]
			[Address(RVA = "0x2672CD0", Offset = "0x26718D0", VA = "0x182672CD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AAC4")]
			[Address(RVA = "0x2672D50", Offset = "0x2671950", VA = "0x182672D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AAC5 RID: 174789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAC5")]
		[Address(RVA = "0x2671AD0", Offset = "0x26706D0", VA = "0x182671AD0", Slot = "7")]
		public override void OnValueChanged(Act20sideCollectionProperty property)
		{
		}

		// Token: 0x0602AAC6 RID: 174790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAC6")]
		[Address(RVA = "0x26723D0", Offset = "0x2670FD0", VA = "0x1826723D0")]
		private void _RenderSelectItem()
		{
		}

		// Token: 0x0602AAC7 RID: 174791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAC7")]
		[Address(RVA = "0x2672890", Offset = "0x2671490", VA = "0x182672890")]
		private void _SetItemImg(SpriteRenderData spriteData, CartComponents.CartAccessoryType type)
		{
		}

		// Token: 0x0602AAC8 RID: 174792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAC8")]
		[Address(RVA = "0x2672270", Offset = "0x2670E70", VA = "0x182672270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AAC9 RID: 174793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAC9")]
		[Address(RVA = "0x2672C40", Offset = "0x2671840", VA = "0x182672C40")]
		public Act20sideCollectionView()
		{
		}

		// Token: 0x0403D773 RID: 251763
		[Token(Token = "0x403D773")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string COLLECT_PROGRESS_FORMAT;

		// Token: 0x0403D774 RID: 251764
		[Token(Token = "0x403D774")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _partNameText;

		// Token: 0x0403D775 RID: 251765
		[Token(Token = "0x403D775")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descriptionText;

		// Token: 0x0403D776 RID: 251766
		[Token(Token = "0x403D776")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _recommendText;

		// Token: 0x0403D777 RID: 251767
		[Token(Token = "0x403D777")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _obtainMethodText;

		// Token: 0x0403D778 RID: 251768
		[Token(Token = "0x403D778")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _collectionProgressText;

		// Token: 0x0403D779 RID: 251769
		[Token(Token = "0x403D779")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _totalCollectCount;

		// Token: 0x0403D77A RID: 251770
		[Token(Token = "0x403D77A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _selectItemBg;

		// Token: 0x0403D77B RID: 251771
		[Token(Token = "0x403D77B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _itemBgAtlas;

		// Token: 0x0403D77C RID: 251772
		[Token(Token = "0x403D77C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act20sideCollectionItemAdapter _adapter;

		// Token: 0x0403D77D RID: 251773
		[Token(Token = "0x403D77D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _unobtainedMask;

		// Token: 0x0403D77E RID: 251774
		[Token(Token = "0x403D77E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("item img")]
		private UIAtlasImage _itemImgHeadstock;

		// Token: 0x0403D77F RID: 251775
		[Token(Token = "0x403D77F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("item img")]
		private UIAtlasImage _itemImgRoof;

		// Token: 0x0403D780 RID: 251776
		[Token(Token = "0x403D780")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("item img")]
		private UIAtlasImage _itemImgTrunk;

		// Token: 0x0403D781 RID: 251777
		[Token(Token = "0x403D781")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("item img")]
		private Image _itemIconImg;

		// Token: 0x0403D782 RID: 251778
		[Token(Token = "0x403D782")]
		[FieldOffset(Offset = "0x90")]
		private List<Act20sideCollectionItemViewModel> m_cachedItemModelList;

		// Token: 0x0403D783 RID: 251779
		[Token(Token = "0x403D783")]
		[FieldOffset(Offset = "0x98")]
		private string m_selectedItemId;

		// Token: 0x0403D784 RID: 251780
		[Token(Token = "0x403D784")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0403D785 RID: 251781
		[Token(Token = "0x403D785")]
		[FieldOffset(Offset = "0xA8")]
		private SpriteRenderData _selectRenderData;

		// Token: 0x0403D786 RID: 251782
		[Token(Token = "0x403D786")]
		[FieldOffset(Offset = "0xE8")]
		private UIAtlasObject m_atlasObject;

		// Token: 0x0403D788 RID: 251784
		[Token(Token = "0x403D788")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureAtlasObject;

		// Token: 0x0403D789 RID: 251785
		[Token(Token = "0x403D789")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403D78A RID: 251786
		[Token(Token = "0x403D78A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UnloadCart;

		// Token: 0x0403D78B RID: 251787
		[Token(Token = "0x403D78B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetSpriteCart;

		// Token: 0x0403D78C RID: 251788
		[Token(Token = "0x403D78C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0403D78D RID: 251789
		[Token(Token = "0x403D78D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0403D78E RID: 251790
		[Token(Token = "0x403D78E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403D78F RID: 251791
		[Token(Token = "0x403D78F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderSelectItem;

		// Token: 0x0403D790 RID: 251792
		[Token(Token = "0x403D790")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetItemImg;

		// Token: 0x0403D791 RID: 251793
		[Token(Token = "0x403D791")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D792 RID: 251794
		[Token(Token = "0x403D792")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
