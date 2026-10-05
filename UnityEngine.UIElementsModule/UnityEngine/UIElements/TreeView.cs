using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	internal class TreeView : VisualElement
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000217")]
		public Action<VisualElement, ITreeViewItem> unbindItem
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x5ACFFA0", Offset = "0x5ACEBA0", VA = "0x185ACFFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000218 RID: 536
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000218")]
		public int itemHeight
		{
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x5ACFFB0", Offset = "0x5ACEBB0", VA = "0x185ACFFB0")]
			set
			{
			}
		}

		// Token: 0x17000219 RID: 537
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000219")]
		public bool showBorder
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x5AD0040", Offset = "0x5ACEC40", VA = "0x185AD0040")]
			set
			{
			}
		}

		// Token: 0x1700021A RID: 538
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021A")]
		public SelectionType selectionType
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x5ACFFE0", Offset = "0x5ACEBE0", VA = "0x185ACFFE0")]
			set
			{
			}
		}

		// Token: 0x1700021B RID: 539
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021B")]
		public AlternatingRowBackground showAlternatingRowBackgrounds
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x5AD0010", Offset = "0x5ACEC10", VA = "0x185AD0010")]
			set
			{
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x5ACF9A0", Offset = "0x5ACE5A0", VA = "0x185ACF9A0")]
		public TreeView()
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x5ACF410", Offset = "0x5ACE010", VA = "0x185ACF410")]
		public void RefreshItems()
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x5ACF3E0", Offset = "0x5ACDFE0", VA = "0x185ACF3E0")]
		public void Rebuild()
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x5ACF380", Offset = "0x5ACDF80", VA = "0x185ACF380", Slot = "93")]
		internal override void OnViewDataReady()
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x5ACDD20", Offset = "0x5ACC920", VA = "0x185ACDD20")]
		public static IEnumerable<ITreeViewItem> GetAllItems(IEnumerable<ITreeViewItem> rootItems)
		{
			return null;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x5ACEF30", Offset = "0x5ACDB30", VA = "0x185ACEF30")]
		public void OnKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x5ACDF10", Offset = "0x5ACCB10", VA = "0x185ACDF10")]
		private void ListViewRefresh()
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x5ACEC80", Offset = "0x5ACD880", VA = "0x185ACEC80")]
		private void OnItemsChosen(IEnumerable<object> chosenItems)
		{
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x5ACEFF0", Offset = "0x5ACDBF0", VA = "0x185ACEFF0")]
		private void OnSelectionChange(IEnumerable<object> selectedListItems)
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x5ACF300", Offset = "0x5ACDF00", VA = "0x185ACF300")]
		private void OnTreeViewMouseUp(MouseUpEvent evt)
		{
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x5ACE620", Offset = "0x5ACD220", VA = "0x185ACE620")]
		private void OnItemMouseUp(MouseUpEvent evt)
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x5ACDF40", Offset = "0x5ACCB40", VA = "0x185ACDF40")]
		private VisualElement MakeTreeItem()
		{
			return null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x5ACF6C0", Offset = "0x5ACE2C0", VA = "0x185ACF6C0")]
		private void UnbindTreeItem(VisualElement element, int index)
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x5ACD160", Offset = "0x5ACBD60", VA = "0x185ACD160")]
		private void BindTreeItem(VisualElement element, int index)
		{
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x5ACDDB0", Offset = "0x5ACC9B0", VA = "0x185ACDDB0")]
		private int GetItemId(int index)
		{
			return 0;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x5ACDE40", Offset = "0x5ACCA40", VA = "0x185ACDE40")]
		private bool IsExpandedByIndex(int index)
		{
			return default(bool);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x5ACD4D0", Offset = "0x5ACC0D0", VA = "0x185ACD4D0")]
		private void CollapseItemByIndex(int index)
		{
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x5ACDAB0", Offset = "0x5ACC6B0", VA = "0x185ACDAB0")]
		private void ExpandItemByIndex(int index)
		{
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x5ACF4D0", Offset = "0x5ACE0D0", VA = "0x185ACF4D0")]
		private void ToggleExpandedState(ChangeEvent<bool> evt)
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x5ACD6D0", Offset = "0x5ACC2D0", VA = "0x185ACD6D0")]
		private void CreateWrappers(IEnumerable<ITreeViewItem> treeViewItems, int depth, ref List<TreeView.TreeViewItemWrapper> wrappers)
		{
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x5ACF440", Offset = "0x5ACE040", VA = "0x185ACF440")]
		private void RegenerateWrappers()
		{
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x5ACE460", Offset = "0x5ACD060", VA = "0x185ACE460")]
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_ListViewName;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string s_ItemName;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string s_ItemToggleName;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string s_ItemIndentsContainerName;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string s_ItemIndentName;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string s_ItemContentContainerName;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x3B0")]
		private Func<VisualElement> m_MakeItem;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x3B8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IEnumerable<ITreeViewItem>> onItemsChosen;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x3C0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<ITreeViewItem>> onSelectionChange;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x3C8")]
		private List<ITreeViewItem> m_SelectedItems;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x3D0")]
		private Action<VisualElement, ITreeViewItem> m_BindItem;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x3E0")]
		private IList<ITreeViewItem> m_RootItems;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x3E8")]
		[SerializeField]
		private List<int> m_ExpandedItemIds;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x3F0")]
		private List<TreeView.TreeViewItemWrapper> m_ItemWrappers;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x3F8")]
		private readonly ListView m_ListView;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x400")]
		private readonly ScrollView m_ScrollView;

		// Token: 0x0200015B RID: 347
		[Token(Token = "0x200015B")]
		public new class UxmlFactory : UxmlFactory<TreeView, TreeView.UxmlTraits>
		{
			// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x5AD2C30", Offset = "0x5AD1830", VA = "0x185AD2C30")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x0200015C RID: 348
		[Token(Token = "0x200015C")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x060009EF RID: 2543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x5AD51E0", Offset = "0x5AD3DE0", VA = "0x185AD51E0", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060009F0 RID: 2544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x5AD6B00", Offset = "0x5AD5700", VA = "0x185AD6B00")]
			public UxmlTraits()
			{
			}

			// Token: 0x0400056D RID: 1389
			[Token(Token = "0x400056D")]
			[FieldOffset(Offset = "0x70")]
			private readonly UxmlIntAttributeDescription m_ItemHeight;

			// Token: 0x0400056E RID: 1390
			[Token(Token = "0x400056E")]
			[FieldOffset(Offset = "0x78")]
			private readonly UxmlBoolAttributeDescription m_ShowBorder;

			// Token: 0x0400056F RID: 1391
			[Token(Token = "0x400056F")]
			[FieldOffset(Offset = "0x80")]
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType;

			// Token: 0x04000570 RID: 1392
			[Token(Token = "0x4000570")]
			[FieldOffset(Offset = "0x88")]
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;
		}

		// Token: 0x0200015D RID: 349
		[Token(Token = "0x200015D")]
		private struct TreeViewItemWrapper
		{
			// Token: 0x1700021C RID: 540
			// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00005910 File Offset: 0x00003B10
			[Token(Token = "0x1700021C")]
			public int id
			{
				[Token(Token = "0x60009F1")]
				[Address(RVA = "0x5ACD110", Offset = "0x5ACBD10", VA = "0x185ACD110")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000571 RID: 1393
			[Token(Token = "0x4000571")]
			[FieldOffset(Offset = "0x0")]
			public int depth;

			// Token: 0x04000572 RID: 1394
			[Token(Token = "0x4000572")]
			[FieldOffset(Offset = "0x8")]
			public ITreeViewItem item;
		}
	}
}
