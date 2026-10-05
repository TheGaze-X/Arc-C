using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D5D RID: 15709
	[Token(Token = "0x2003D5D")]
	public class TemplateShopLoopGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018772 RID: 100210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018772")]
		[Address(RVA = "0x10F5E30", Offset = "0x10F4A30", VA = "0x1810F5E30")]
		public void _InitIfNot()
		{
		}

		// Token: 0x06018773 RID: 100211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018773")]
		[Address(RVA = "0x10F5990", Offset = "0x10F4590", VA = "0x1810F5990")]
		public void ApplyCellSizeAndSpacing(Vector2 cellSize, Vector2 spacing)
		{
		}

		// Token: 0x06018774 RID: 100212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018774")]
		[Address(RVA = "0x10F5A50", Offset = "0x10F4650", VA = "0x1810F5A50")]
		public void Render(TemplateShopGroupViewModel groupViewModel, TemplateShopResHolder holder, int constraint, AsyncGameObjectLoader loader)
		{
		}

		// Token: 0x06018775 RID: 100213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018775")]
		[Address(RVA = "0x10F5F60", Offset = "0x10F4B60", VA = "0x1810F5F60")]
		public TemplateShopLoopGroupView()
		{
		}

		// Token: 0x0401DF64 RID: 122724
		[Token(Token = "0x401DF64")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401DF65 RID: 122725
		[Token(Token = "0x401DF65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _slotId;

		// Token: 0x0401DF66 RID: 122726
		[Token(Token = "0x401DF66")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0401DF67 RID: 122727
		[Token(Token = "0x401DF67")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _lockedString;

		// Token: 0x0401DF68 RID: 122728
		[Token(Token = "0x401DF68")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GridLayoutGroup _layOutGroup;

		// Token: 0x0401DF69 RID: 122729
		[Token(Token = "0x401DF69")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ContentSizeFitter _sizeFitter;

		// Token: 0x0401DF6A RID: 122730
		[Token(Token = "0x401DF6A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0401DF6B RID: 122731
		[Token(Token = "0x401DF6B")]
		[FieldOffset(Offset = "0x50")]
		private TemplateShopLoopGroupView.ItemAdapter m_adapter;

		// Token: 0x0401DF6C RID: 122732
		[Token(Token = "0x401DF6C")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0401DF6D RID: 122733
		[Token(Token = "0x401DF6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DF6E RID: 122734
		[Token(Token = "0x401DF6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyCellSizeAndSpacing;

		// Token: 0x0401DF6F RID: 122735
		[Token(Token = "0x401DF6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DF70 RID: 122736
		[Token(Token = "0x401DF70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D5E RID: 15710
		[Token(Token = "0x2003D5E")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<TemplateShopLoopGroupView>
		{
			// Token: 0x06018776 RID: 100214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018776")]
			[Address(RVA = "0x1100B70", Offset = "0x10FF770", VA = "0x181100B70", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06018777 RID: 100215 RVA: 0x0009A770 File Offset: 0x00098970
			[Token(Token = "0x6018777")]
			[Address(RVA = "0x1100BE0", Offset = "0x10FF7E0", VA = "0x181100BE0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06018778 RID: 100216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018778")]
			[Address(RVA = "0x1100E70", Offset = "0x10FFA70", VA = "0x181100E70", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06018779 RID: 100217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018779")]
			[Address(RVA = "0x1100CF0", Offset = "0x10FF8F0", VA = "0x181100CF0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601877A RID: 100218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601877A")]
			[Address(RVA = "0x1100ED0", Offset = "0x10FFAD0", VA = "0x181100ED0")]
			public VirtualView()
			{
			}

			// Token: 0x0401DF71 RID: 122737
			[Token(Token = "0x401DF71")]
			private const float HEAD_WIDTH = 49f;

			// Token: 0x0401DF72 RID: 122738
			[Token(Token = "0x401DF72")]
			[FieldOffset(Offset = "0x20")]
			public TemplateShopGroupViewModel viewModel;

			// Token: 0x0401DF73 RID: 122739
			[Token(Token = "0x401DF73")]
			[FieldOffset(Offset = "0x28")]
			public TemplateShopResHolder prefab;

			// Token: 0x0401DF74 RID: 122740
			[Token(Token = "0x401DF74")]
			[FieldOffset(Offset = "0x30")]
			public TemplateShopLoopGroupView groupView;

			// Token: 0x0401DF75 RID: 122741
			[Token(Token = "0x401DF75")]
			[FieldOffset(Offset = "0x38")]
			public int constraint;

			// Token: 0x0401DF76 RID: 122742
			[Token(Token = "0x401DF76")]
			[FieldOffset(Offset = "0x40")]
			public AsyncGameObjectLoader loader;

			// Token: 0x0401DF77 RID: 122743
			[Token(Token = "0x401DF77")]
			[FieldOffset(Offset = "0x48")]
			public Vector2 cellSize;

			// Token: 0x0401DF78 RID: 122744
			[Token(Token = "0x401DF78")]
			[FieldOffset(Offset = "0x50")]
			public Vector2 spaceing;

			// Token: 0x0401DF79 RID: 122745
			[Token(Token = "0x401DF79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401DF7A RID: 122746
			[Token(Token = "0x401DF7A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401DF7B RID: 122747
			[Token(Token = "0x401DF7B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0401DF7C RID: 122748
			[Token(Token = "0x401DF7C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0401DF7D RID: 122749
			[Token(Token = "0x401DF7D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003D5F RID: 15711
		[Token(Token = "0x2003D5F")]
		public class ItemAdapter : AsyncDataViewListAdapter<TemplateShopCommonItemView, TemplateCommonShopGoodViewModel>
		{
			// Token: 0x0601877B RID: 100219 RVA: 0x0009A788 File Offset: 0x00098988
			[Token(Token = "0x601877B")]
			[Address(RVA = "0x10E94B0", Offset = "0x10E80B0", VA = "0x1810E94B0", Slot = "4")]
			protected override int GetCount()
			{
				return 0;
			}

			// Token: 0x0601877C RID: 100220 RVA: 0x0009A7A0 File Offset: 0x000989A0
			[Token(Token = "0x601877C")]
			[Address(RVA = "0x10E9450", Offset = "0x10E8050", VA = "0x1810E9450", Slot = "8")]
			protected override uint CostPerItem()
			{
				return 0U;
			}

			// Token: 0x0601877D RID: 100221 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601877D")]
			[Address(RVA = "0x10E9620", Offset = "0x10E8220", VA = "0x1810E9620", Slot = "6")]
			protected override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601877E RID: 100222 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601877E")]
			[Address(RVA = "0x10E9520", Offset = "0x10E8120", VA = "0x1810E9520", Slot = "5")]
			protected override TemplateCommonShopGoodViewModel GetData(int index)
			{
				return null;
			}

			// Token: 0x0601877F RID: 100223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601877F")]
			[Address(RVA = "0x10E95B0", Offset = "0x10E81B0", VA = "0x1810E95B0", Slot = "7")]
			protected override Transform GetListContainer()
			{
				return null;
			}

			// Token: 0x06018780 RID: 100224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018780")]
			[Address(RVA = "0x10E9690", Offset = "0x10E8290", VA = "0x1810E9690")]
			public ItemAdapter()
			{
			}

			// Token: 0x0401DF7E RID: 122750
			[Token(Token = "0x401DF7E")]
			[FieldOffset(Offset = "0x18")]
			public List<TemplateCommonShopGoodViewModel> paramList;

			// Token: 0x0401DF7F RID: 122751
			[Token(Token = "0x401DF7F")]
			[FieldOffset(Offset = "0x20")]
			public SimpleLayoutContent content;

			// Token: 0x0401DF80 RID: 122752
			[Token(Token = "0x401DF80")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetCount;

			// Token: 0x0401DF81 RID: 122753
			[Token(Token = "0x401DF81")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CostPerItem;

			// Token: 0x0401DF82 RID: 122754
			[Token(Token = "0x401DF82")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401DF83 RID: 122755
			[Token(Token = "0x401DF83")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x0401DF84 RID: 122756
			[Token(Token = "0x401DF84")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetListContainer;

			// Token: 0x0401DF85 RID: 122757
			[Token(Token = "0x401DF85")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
