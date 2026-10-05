using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
	{
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000012")]
		public event Action<IEnumerable<object>> onItemsChosen
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x5AACBF0", Offset = "0x5AAB7F0", VA = "0x185AACBF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x5AACF80", Offset = "0x5AABB80", VA = "0x185AACF80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000013")]
		public event Action<IEnumerable<object>> onSelectionChange
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x5AACCA0", Offset = "0x5AAB8A0", VA = "0x185AACCA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x5AAD030", Offset = "0x5AABC30", VA = "0x185AAD030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		internal Func<int, int> getItemId
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x5AACDF0", Offset = "0x5AAB9F0", VA = "0x185AACDF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x5AAD240", Offset = "0x5AABE40", VA = "0x185AAD240")]
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000186")]
		public IList itemsSource
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x5AACE00", Offset = "0x5AABA00", VA = "0x185AACE00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x5AAD2B0", Offset = "0x5AABEB0", VA = "0x185AAD2B0")]
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000187")]
		public Func<VisualElement> makeItem
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x4437740", Offset = "0x4436340", VA = "0x184437740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x5AAD320", Offset = "0x5AABF20", VA = "0x185AAD320")]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000188")]
		public Action<VisualElement, int> bindItem
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x4437730", Offset = "0x4436330", VA = "0x184437730")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x5AAD0E0", Offset = "0x5AABCE0", VA = "0x185AAD0E0")]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		public Action<VisualElement, int> unbindItem
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x5AACF70", Offset = "0x5AABB70", VA = "0x185AACF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x5AAD570", Offset = "0x5AAC170", VA = "0x185AAD570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700018A")]
		public Action<VisualElement> destroyItem
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x45A7900", Offset = "0x45A6500", VA = "0x1845A7900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700018B")]
		public override VisualElement contentContainer
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00004F08 File Offset: 0x00003108
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018C")]
		public SelectionType selectionType
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x5AACF50", Offset = "0x5AABB50", VA = "0x185AACF50")]
			get
			{
				return SelectionType.None;
			}
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x5AAD420", Offset = "0x5AAC020", VA = "0x185AAD420")]
			set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00004F20 File Offset: 0x00003120
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018D")]
		public int selectedIndex
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x5AACED0", Offset = "0x5AABAD0", VA = "0x185AACED0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x5AAADC0", Offset = "0x5AA99C0", VA = "0x185AAADC0")]
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700018E")]
		public IEnumerable<int> selectedIndices
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x5AACF40", Offset = "0x5AABB40", VA = "0x185AACF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700018F")]
		internal List<int> selectedIds
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x5AACEC0", Offset = "0x5AABAC0", VA = "0x185AACEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000190")]
		internal IEnumerable<ReusableCollectionItem> activeItems
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x5AACD50", Offset = "0x5AAB950", VA = "0x185AACD50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000191")]
		internal ScrollView scrollView
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x45A78A0", Offset = "0x45A64A0", VA = "0x1845A78A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000192")]
		internal ListViewDragger dragger
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x5695800", Offset = "0x5694400", VA = "0x185695800")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000193")]
		internal CollectionViewController viewController
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x45A7890", Offset = "0x45A6490", VA = "0x1845A7890")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000194")]
		internal CollectionVirtualizationController virtualizationController
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x5AA9540", Offset = "0x5AA8140", VA = "0x185AA9540")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x5AAB5F0", Offset = "0x5AAA1F0", VA = "0x185AAB5F0")]
		internal float ResolveItemHeight(float height = -1f)
		{
			return 0f;
		}

		// Token: 0x17000195 RID: 405
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000195")]
		public bool showBorder
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x5AAD4E0", Offset = "0x5AAC0E0", VA = "0x185AAD4E0")]
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00004F50 File Offset: 0x00003150
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000196")]
		public bool reorderable
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x5AACE30", Offset = "0x5AABA30", VA = "0x185AACE30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x5AAD380", Offset = "0x5AABF80", VA = "0x185AAD380")]
			set
			{
			}
		}

		// Token: 0x17000197 RID: 407
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000197")]
		public bool horizontalScrollingEnabled
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x5AAD270", Offset = "0x5AABE70", VA = "0x185AAD270")]
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00004F68 File Offset: 0x00003168
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000198")]
		public AlternatingRowBackground showAlternatingRowBackgrounds
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x5AACF60", Offset = "0x5AABB60", VA = "0x185AACF60")]
			get
			{
				return AlternatingRowBackground.None;
			}
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x5AAD4C0", Offset = "0x5AAC0C0", VA = "0x185AAD4C0")]
			set
			{
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00004F80 File Offset: 0x00003180
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000199")]
		public CollectionVirtualizationMethod virtualizationMethod
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x3B3D7A0", Offset = "0x3B3C3A0", VA = "0x183B3D7A0")]
			get
			{
				return CollectionVirtualizationMethod.FixedHeight;
			}
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x5AAD580", Offset = "0x5AAC180", VA = "0x185AAD580")]
			set
			{
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00004F98 File Offset: 0x00003198
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019A")]
		public float fixedItemHeight
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x5AACDE0", Offset = "0x5AAB9E0", VA = "0x185AACDE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x5AAD140", Offset = "0x5AABD40", VA = "0x185AAD140")]
			set
			{
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x1700019B")]
		internal float lastHeight
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x5AACE20", Offset = "0x5AABA20", VA = "0x185AACE20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x5AA8B80", Offset = "0x5AA7780", VA = "0x185AA8B80", Slot = "101")]
		private protected virtual void CreateVirtualizationController()
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x5AA9540", Offset = "0x5AA8140", VA = "0x185AA9540")]
		internal CollectionVirtualizationController GetOrCreateVirtualizationController()
		{
			return null;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000769")]
		internal void CreateVirtualizationController<T>() where T : ReusableCollectionItem, new()
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x5AA94E0", Offset = "0x5AA80E0", VA = "0x185AA94E0")]
		internal CollectionViewController GetOrCreateViewController()
		{
			return null;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x5AA8B10", Offset = "0x5AA7710", VA = "0x185AA8B10", Slot = "102")]
		private protected virtual void CreateViewController()
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x5AABD90", Offset = "0x5AAA990", VA = "0x185AABD90")]
		internal void SetViewController(CollectionViewController controller)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x5AA8AB0", Offset = "0x5AA76B0", VA = "0x185AA8AB0", Slot = "103")]
		internal virtual ListViewDragger CreateDragger()
		{
			return null;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x5AA9700", Offset = "0x5AA8300", VA = "0x185AA9700")]
		internal void InitializeDragAndDropController(bool enableReordering)
		{
		}

		// Token: 0x0600076F RID: 1903
		[Token(Token = "0x600076F")]
		internal abstract ICollectionDragAndDropController CreateDragAndDropController();

		// Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x5AAC470", Offset = "0x5AAB070", VA = "0x185AAC470")]
		public BaseVerticalCollectionView()
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x5AA95A0", Offset = "0x5AA81A0", VA = "0x185AA95A0")]
		public VisualElement GetRootElementForId(int id)
		{
			return null;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x5AA96C0", Offset = "0x5AA82C0", VA = "0x185AA96C0")]
		internal bool HasValidDataAndBindings()
		{
			return default(bool);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x5AAA1B0", Offset = "0x5AA8DB0", VA = "0x185AAA1B0")]
		private void OnItemIndexChanged(int srcIndex, int dstIndex)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x5AAA1E0", Offset = "0x5AA8DE0", VA = "0x185AAA1E0")]
		private void OnItemsSourceChanged()
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x5AAAE90", Offset = "0x5AA9A90", VA = "0x185AAAE90")]
		public void RefreshItems()
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x5AAADD0", Offset = "0x5AA99D0", VA = "0x185AAADD0")]
		public void Rebuild()
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x5AAAF50", Offset = "0x5AA9B50", VA = "0x185AAAF50")]
		private void RefreshSelection()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x5AAA700", Offset = "0x5AA9300", VA = "0x185AAA700", Slot = "105")]
		private protected virtual void PostRefresh()
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x5AAB640", Offset = "0x5AAA240", VA = "0x185AAB640")]
		public void ScrollToItem(int index)
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x5AAA4E0", Offset = "0x5AA90E0", VA = "0x185AAA4E0")]
		private void OnScroll(Vector2 offset)
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x5AAB4E0", Offset = "0x5AAA0E0", VA = "0x185AAB4E0")]
		private void Resize(Vector2 size)
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x5AA98B0", Offset = "0x5AA84B0", VA = "0x185AA98B0")]
		private void OnAttachToPanel(AttachToPanelEvent evt)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x5AA9E60", Offset = "0x5AA8A60", VA = "0x185AA9E60")]
		private void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x5AA83A0", Offset = "0x5AA6FA0", VA = "0x185AA83A0")]
		private bool Apply(KeyboardNavigationOperation op, bool shiftKey)
		{
			return default(bool);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x5AA86C0", Offset = "0x5AA72C0", VA = "0x185AA86C0")]
		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x5AAA370", Offset = "0x5AA8F70", VA = "0x185AAA370")]
		private void OnPointerMove(PointerMoveEvent evt)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x5AAA290", Offset = "0x5AA8E90", VA = "0x185AAA290")]
		private void OnPointerDown(PointerDownEvent evt)
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x5AAA200", Offset = "0x5AA8E00", VA = "0x185AAA200")]
		private void OnPointerCancel(PointerCancelEvent evt)
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x5AAA400", Offset = "0x5AA9000", VA = "0x185AAA400")]
		private void OnPointerUp(PointerUpEvent evt)
		{
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x5AAA850", Offset = "0x5AA9450", VA = "0x185AAA850")]
		private void ProcessPointerDown(IPointerEvent evt)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x5AAAA50", Offset = "0x5AA9650", VA = "0x185AAAA50")]
		private void ProcessPointerUp(IPointerEvent evt)
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x5AA8D50", Offset = "0x5AA7950", VA = "0x185AA8D50")]
		private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey)
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x5AA8BC0", Offset = "0x5AA77C0", VA = "0x185AA8BC0")]
		private void DoRangeSelection(int rangeSelectionFinalIndex)
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x5AAADC0", Offset = "0x5AA99C0", VA = "0x185AAADC0")]
		private void ProcessSingleClick(int clickedIndex)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x5AAB700", Offset = "0x5AAA300", VA = "0x185AAB700")]
		internal void SelectAll()
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x5AA8070", Offset = "0x5AA6C70", VA = "0x185AA8070")]
		public void AddToSelection(int index)
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x5AA80E0", Offset = "0x5AA6CE0", VA = "0x185AA80E0")]
		internal void AddToSelection(IList<int> indexes)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x5AA7CB0", Offset = "0x5AA68B0", VA = "0x185AA7CB0")]
		private void AddToSelectionWithoutValidation(int index)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x5AAB480", Offset = "0x5AAA080", VA = "0x185AAB480")]
		public void RemoveFromSelection(int index)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x5AAB150", Offset = "0x5AA9D50", VA = "0x185AAB150")]
		private void RemoveFromSelectionWithoutValidation(int index)
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x5AABD00", Offset = "0x5AAA900", VA = "0x185AABD00")]
		public void SetSelection(int index)
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x5AABCF0", Offset = "0x5AAA8F0", VA = "0x185AABCF0")]
		public void SetSelection(IEnumerable<int> indices)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x5AABCE0", Offset = "0x5AAA8E0", VA = "0x185AABCE0")]
		public void SetSelectionWithoutNotify(IEnumerable<int> indices)
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x5AABA70", Offset = "0x5AAA670", VA = "0x185AABA70")]
		internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification)
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x5AA9830", Offset = "0x5AA8430", VA = "0x185AA9830")]
		private void NotifyOfSelectionChange()
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x5AA8A20", Offset = "0x5AA7620", VA = "0x185AA8A20")]
		public void ClearSelection()
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x5AA87B0", Offset = "0x5AA73B0", VA = "0x185AA87B0")]
		private void ClearSelectionWithoutValidation()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x5AAA6D0", Offset = "0x5AA92D0", VA = "0x185AAA6D0", Slot = "93")]
		internal override void OnViewDataReady()
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x5AA91B0", Offset = "0x5AA7DB0", VA = "0x185AA91B0", Slot = "12")]
		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x5AAA5A0", Offset = "0x5AA91A0", VA = "0x185AAA5A0")]
		private void OnSizeChanged(GeometryChangedEvent evt)
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x5AA9C90", Offset = "0x5AA8890", VA = "0x185AA9C90")]
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "99")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x5AABFE0", Offset = "0x5AAABE0", VA = "0x185AABFE0", Slot = "100")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x5AABE40", Offset = "0x5AAAA40", VA = "0x185AABE40")]
		[CompilerGenerated]
		private void <Apply>g__HandleSelectionAndScroll|165_0(int index, ref BaseVerticalCollectionView.<>c__DisplayClass165_0 A_2)
		{
		}

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x3D0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> onSelectedIndicesChange;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x3D8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<int, int> itemIndexChanged;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x3E0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action itemsSourceChanged;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x3E8")]
		private Func<int, int> m_GetItemId;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x3F0")]
		private Func<VisualElement> m_MakeItem;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x3F8")]
		private Action<VisualElement, int> m_BindItem;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x410")]
		private SelectionType m_SelectionType;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x418")]
		[SerializeField]
		internal SerializedVirtualizationData serializedVirtualizationData;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ReusableCollectionItem> k_EmptyItems;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x420")]
		private bool m_HorizontalScrollingEnabled;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x424")]
		[SerializeField]
		private AlternatingRowBackground m_ShowAlternatingRowBackgrounds;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int s_DefaultItemHeight;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x428")]
		internal float m_FixedItemHeight;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x42C")]
		internal bool m_ItemHeightIsInline;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x430")]
		private CollectionVirtualizationMethod m_VirtualizationMethod;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x438")]
		private readonly ScrollView m_ScrollView;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x440")]
		private CollectionViewController m_ViewController;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x448")]
		private CollectionVirtualizationController m_VirtualizationController;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x450")]
		private KeyboardNavigationManipulator m_NavigationManipulator;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x458")]
		[SerializeField]
		internal Vector2 m_ScrollOffset;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x460")]
		[SerializeField]
		private readonly List<int> m_SelectedIds;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x468")]
		private readonly List<int> m_SelectedIndices;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x470")]
		private readonly List<object> m_SelectedItems;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x478")]
		private float m_LastHeight;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x47C")]
		private bool m_IsRangeSelectionDirectionUp;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x480")]
		private ListViewDragger m_Dragger;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x10")]
		internal static CustomStyleProperty<int> s_ItemHeightProperty;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x488")]
		private Action<int, int> m_ItemIndexChangedCallback;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x490")]
		private Action m_ItemsSourceChangedCallback;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string ussClassName;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string borderUssClassName;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string itemUssClassName;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string dragHoverBarUssClassName;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string dragHoverMarkerUssClassName;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string itemDragHoverUssClassName;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string itemSelectedVariantUssClassName;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string itemAlternativeBackgroundUssClassName;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string listScrollViewUssClassName;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x60")]
		internal static readonly string backgroundFillUssClassName;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x498")]
		private Vector3 m_TouchDownPosition;
	}
}
