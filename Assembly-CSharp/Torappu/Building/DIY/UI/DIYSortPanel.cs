using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001959 RID: 6489
	[Token(Token = "0x2001959")]
	public class DIYSortPanel : MonoBehaviour
	{
		// Token: 0x0600A321 RID: 41761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A321")]
		[Address(RVA = "0x31E31B0", Offset = "0x31E1DB0", VA = "0x1831E31B0")]
		public void Setup()
		{
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A322")]
		[Address(RVA = "0x31E3680", Offset = "0x31E2280", VA = "0x1831E3680")]
		public void ShowPanel(Action<DIYSortPanel.ISortAndFilterState> resultHandler)
		{
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A323")]
		[Address(RVA = "0x31E3860", Offset = "0x31E2460", VA = "0x1831E3860")]
		private void _Hide()
		{
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A324")]
		[Address(RVA = "0x31E2FC0", Offset = "0x31E1BC0", VA = "0x1831E2FC0")]
		public void OnCancelButtonPressed()
		{
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A325")]
		[Address(RVA = "0x31E3170", Offset = "0x31E1D70", VA = "0x1831E3170")]
		public void OnOkButtonPressed()
		{
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A326")]
		[Address(RVA = "0x31E3BE0", Offset = "0x31E27E0", VA = "0x1831E3BE0")]
		private void _SetupSortIndex(int index, FurnitureSorter.SortingMethod method)
		{
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A327")]
		[Address(RVA = "0x31E3B10", Offset = "0x31E2710", VA = "0x1831E3B10")]
		private void _RemoveAllFilter()
		{
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A328")]
		[Address(RVA = "0x31E3D40", Offset = "0x31E2940", VA = "0x1831E3D40")]
		private void _ToggleFilter(int index)
		{
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A329")]
		[Address(RVA = "0x31E3A20", Offset = "0x31E2620", VA = "0x1831E3A20")]
		private void _OnSortButton(DIYSortButton button)
		{
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A32A")]
		[Address(RVA = "0x31E3940", Offset = "0x31E2540", VA = "0x1831E3940")]
		private void _OnFilterButton(DIYFilterButton button)
		{
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A32B")]
		[Address(RVA = "0x31E2FD0", Offset = "0x31E1BD0", VA = "0x1831E2FD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A32C")]
		[Address(RVA = "0x31E40B0", Offset = "0x31E2CB0", VA = "0x1831E40B0")]
		public DIYSortPanel()
		{
		}

		// Token: 0x0400999E RID: 39326
		[Token(Token = "0x400999E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYSortPanel.SortButtonItem[] _sortButtons;

		// Token: 0x0400999F RID: 39327
		[Token(Token = "0x400999F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DIYSortPanel.FilterButtonItem[] _filterButtons;

		// Token: 0x040099A0 RID: 39328
		[Token(Token = "0x40099A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040099A1 RID: 39329
		[Token(Token = "0x40099A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _background;

		// Token: 0x040099A2 RID: 39330
		[Token(Token = "0x40099A2")]
		[FieldOffset(Offset = "0x38")]
		private DIYSortPanel.SortAndFilterState m_currentState;

		// Token: 0x040099A3 RID: 39331
		[Token(Token = "0x40099A3")]
		[FieldOffset(Offset = "0x40")]
		private Action<DIYSortPanel.ISortAndFilterState> onOkButtonPressed;

		// Token: 0x0200195A RID: 6490
		[Token(Token = "0x200195A")]
		public enum FilterType
		{
			// Token: 0x040099A5 RID: 39333
			[Token(Token = "0x40099A5")]
			RARITY,
			// Token: 0x040099A6 RID: 39334
			[Token(Token = "0x40099A6")]
			HAS_FURNITURE,
			// Token: 0x040099A7 RID: 39335
			[Token(Token = "0x40099A7")]
			DISCOUNT
		}

		// Token: 0x0200195B RID: 6491
		[Token(Token = "0x200195B")]
		public class FilterSetting
		{
			// Token: 0x0600A32E RID: 41774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A32E")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public FilterSetting(DIYSortPanel.FilterButtonItem item)
			{
			}

			// Token: 0x170012E6 RID: 4838
			// (get) Token: 0x0600A32F RID: 41775 RVA: 0x0003F6D8 File Offset: 0x0003D8D8
			[Token(Token = "0x170012E6")]
			public DIYSortPanel.FilterType filterType
			{
				[Token(Token = "0x600A32F")]
				[Address(RVA = "0x5BA1B0", Offset = "0x5B8DB0", VA = "0x1805BA1B0")]
				get
				{
					return DIYSortPanel.FilterType.RARITY;
				}
			}

			// Token: 0x170012E7 RID: 4839
			// (get) Token: 0x0600A330 RID: 41776 RVA: 0x0003F6F0 File Offset: 0x0003D8F0
			[Token(Token = "0x170012E7")]
			public int param
			{
				[Token(Token = "0x600A330")]
				[Address(RVA = "0x1437670", Offset = "0x1436270", VA = "0x181437670")]
				get
				{
					return 0;
				}
			}

			// Token: 0x040099A8 RID: 39336
			[Token(Token = "0x40099A8")]
			[FieldOffset(Offset = "0x10")]
			private DIYSortPanel.FilterButtonItem m_item;
		}

		// Token: 0x0200195C RID: 6492
		[Token(Token = "0x200195C")]
		public interface ISortAndFilterState
		{
			// Token: 0x170012E8 RID: 4840
			// (get) Token: 0x0600A331 RID: 41777
			[Token(Token = "0x170012E8")]
			FurnitureSorter.FurnitureSortingOption sortingOption { [Token(Token = "0x600A331")] get; }

			// Token: 0x170012E9 RID: 4841
			// (get) Token: 0x0600A332 RID: 41778
			[Token(Token = "0x170012E9")]
			FurnitureSorter.SortingMethod sortingMethod { [Token(Token = "0x600A332")] get; }

			// Token: 0x0600A333 RID: 41779
			[Token(Token = "0x600A333")]
			IEnumerable<DIYSortPanel.FilterSetting> EnumSortingSetting();
		}

		// Token: 0x0200195D RID: 6493
		[Token(Token = "0x200195D")]
		private class SortAndFilterState : DIYSortPanel.ISortAndFilterState
		{
			// Token: 0x170012EA RID: 4842
			// (get) Token: 0x0600A334 RID: 41780 RVA: 0x0003F708 File Offset: 0x0003D908
			// (set) Token: 0x0600A335 RID: 41781 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170012EA")]
			public FurnitureSorter.FurnitureSortingOption sortingOption
			{
				[Token(Token = "0x600A334")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return FurnitureSorter.FurnitureSortingOption.COMFORT;
				}
				[Token(Token = "0x600A335")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170012EB RID: 4843
			// (get) Token: 0x0600A336 RID: 41782 RVA: 0x0003F720 File Offset: 0x0003D920
			// (set) Token: 0x0600A337 RID: 41783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170012EB")]
			public FurnitureSorter.SortingMethod sortingMethod
			{
				[Token(Token = "0x600A336")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return FurnitureSorter.SortingMethod.ASCENT;
				}
				[Token(Token = "0x600A337")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600A338 RID: 41784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A338")]
			[Address(RVA = "0x31EA4F0", Offset = "0x31E90F0", VA = "0x1831EA4F0", Slot = "6")]
			public IEnumerable<DIYSortPanel.FilterSetting> EnumSortingSetting()
			{
				return null;
			}

			// Token: 0x0600A339 RID: 41785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A339")]
			[Address(RVA = "0x31EA570", Offset = "0x31E9170", VA = "0x1831EA570")]
			public SortAndFilterState()
			{
			}

			// Token: 0x040099AB RID: 39339
			[Token(Token = "0x40099AB")]
			[FieldOffset(Offset = "0x18")]
			public List<DIYSortPanel.FilterButtonItem> filters;
		}

		// Token: 0x0200195F RID: 6495
		[Token(Token = "0x200195F")]
		[Serializable]
		public class SortButtonItem
		{
			// Token: 0x0600A342 RID: 41794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A342")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SortButtonItem()
			{
			}

			// Token: 0x040099B2 RID: 39346
			[Token(Token = "0x40099B2")]
			[FieldOffset(Offset = "0x10")]
			public FurnitureSorter.FurnitureSortingOption option;

			// Token: 0x040099B3 RID: 39347
			[Token(Token = "0x40099B3")]
			[FieldOffset(Offset = "0x18")]
			public DIYSortButton button;
		}

		// Token: 0x02001960 RID: 6496
		[Token(Token = "0x2001960")]
		[Serializable]
		public class FilterButtonItem
		{
			// Token: 0x0600A343 RID: 41795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A343")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FilterButtonItem()
			{
			}

			// Token: 0x040099B4 RID: 39348
			[Token(Token = "0x40099B4")]
			[FieldOffset(Offset = "0x10")]
			public DIYSortPanel.FilterType filterType;

			// Token: 0x040099B5 RID: 39349
			[Token(Token = "0x40099B5")]
			[FieldOffset(Offset = "0x14")]
			public int param;

			// Token: 0x040099B6 RID: 39350
			[Token(Token = "0x40099B6")]
			[FieldOffset(Offset = "0x18")]
			public DIYFilterButton button;
		}
	}
}
