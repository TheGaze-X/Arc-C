using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	internal class InternalTreeView : VisualElement
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700022F")]
		public Action<VisualElement, ITreeViewItem> unbindItem
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x5ACFFA0", Offset = "0x5ACEBA0", VA = "0x185ACFFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000230 RID: 560
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000230")]
		public int itemHeight
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x5ACFFB0", Offset = "0x5ACEBB0", VA = "0x185ACFFB0")]
			set
			{
			}
		}

		// Token: 0x17000231 RID: 561
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000231")]
		public bool showBorder
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x5AD0040", Offset = "0x5ACEC40", VA = "0x185AD0040")]
			set
			{
			}
		}

		// Token: 0x17000232 RID: 562
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000232")]
		public SelectionType selectionType
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x5ACFFE0", Offset = "0x5ACEBE0", VA = "0x185ACFFE0")]
			set
			{
			}
		}

		// Token: 0x17000233 RID: 563
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000233")]
		public AlternatingRowBackground showAlternatingRowBackgrounds
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x5AD0010", Offset = "0x5ACEC10", VA = "0x185AD0010")]
			set
			{
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x5AE0F10", Offset = "0x5ADFB10", VA = "0x185AE0F10")]
		public InternalTreeView()
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x5AE0970", Offset = "0x5ADF570", VA = "0x185AE0970")]
		public void RefreshItems()
		{
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x5AE0940", Offset = "0x5ADF540", VA = "0x185AE0940")]
		public void Rebuild()
		{
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x5AE08E0", Offset = "0x5ADF4E0", VA = "0x185AE08E0", Slot = "93")]
		internal override void OnViewDataReady()
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x5ADF3A0", Offset = "0x5ADDFA0", VA = "0x185ADF3A0")]
		public static IEnumerable<ITreeViewItem> GetAllItems(IEnumerable<ITreeViewItem> rootItems)
		{
			return null;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x5AE0510", Offset = "0x5ADF110", VA = "0x185AE0510")]
		public void OnKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x5ACDF10", Offset = "0x5ACCB10", VA = "0x185ACDF10")]
		private void ListViewRefresh()
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x5AE0260", Offset = "0x5ADEE60", VA = "0x185AE0260")]
		private void OnItemsChosen(IEnumerable<object> chosenItems)
		{
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x5AE05D0", Offset = "0x5ADF1D0", VA = "0x185AE05D0")]
		private void OnSelectionChange(IEnumerable<object> selectedListItems)
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x5ACF300", Offset = "0x5ACDF00", VA = "0x185ACF300")]
		private void OnTreeViewMouseUp(MouseUpEvent evt)
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x5ADFC10", Offset = "0x5ADE810", VA = "0x185ADFC10")]
		private void OnItemMouseUp(MouseUpEvent evt)
		{
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x5ADF590", Offset = "0x5ADE190", VA = "0x185ADF590")]
		private VisualElement MakeTreeItem()
		{
			return null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x5AE0C10", Offset = "0x5ADF810", VA = "0x185AE0C10")]
		private void UnbindTreeItem(VisualElement element, int index)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x5ADE7E0", Offset = "0x5ADD3E0", VA = "0x185ADE7E0")]
		private void BindTreeItem(VisualElement element, int index)
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x5ADF430", Offset = "0x5ADE030", VA = "0x185ADF430")]
		internal int GetItemId(int index)
		{
			return 0;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x5ADF4C0", Offset = "0x5ADE0C0", VA = "0x185ADF4C0")]
		private bool IsExpandedByIndex(int index)
		{
			return default(bool);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x5ADEB50", Offset = "0x5ADD750", VA = "0x185ADEB50")]
		private void CollapseItemByIndex(int index)
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x5ADF130", Offset = "0x5ADDD30", VA = "0x185ADF130")]
		private void ExpandItemByIndex(int index)
		{
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x5AE0A30", Offset = "0x5ADF630", VA = "0x185AE0A30")]
		private void ToggleExpandedState(ChangeEvent<bool> evt)
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x5ADED50", Offset = "0x5ADD950", VA = "0x185ADED50")]
		private void CreateWrappers(IEnumerable<ITreeViewItem> treeViewItems, int depth, ref List<InternalTreeView.TreeViewItemWrapper> wrappers)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x5AE09A0", Offset = "0x5ADF5A0", VA = "0x185AE09A0")]
		private void RegenerateWrappers()
		{
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x5ADFA50", Offset = "0x5ADE650", VA = "0x185ADFA50")]
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_ListViewName;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string s_ItemToggleName;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string s_ItemIndentsContainerName;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string s_ItemIndentName;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string s_ItemContentContainerName;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string itemUssClassName;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x3B0")]
		private Func<VisualElement> m_MakeItem;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x3B8")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<ITreeViewItem>> onItemsChosen;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x3C0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<ITreeViewItem>> onSelectionChange;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x3C8")]
		private List<ITreeViewItem> m_SelectedItems;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x3D0")]
		private Action<VisualElement, ITreeViewItem> m_BindItem;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x3E0")]
		private IList<ITreeViewItem> m_RootItems;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x3E8")]
		[SerializeField]
		private List<int> m_ExpandedItemIds;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x3F0")]
		private List<InternalTreeView.TreeViewItemWrapper> m_ItemWrappers;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x3F8")]
		private readonly ListView m_ListView;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x400")]
		internal readonly ScrollView m_ScrollView;

		// Token: 0x02000167 RID: 359
		[Token(Token = "0x2000167")]
		public new class UxmlFactory : UxmlFactory<InternalTreeView, InternalTreeView.UxmlTraits>
		{
			// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x5AECED0", Offset = "0x5AEBAD0", VA = "0x185AECED0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000168 RID: 360
		[Token(Token = "0x2000168")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x5AECF10", Offset = "0x5AEBB10", VA = "0x185AECF10", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x5AED4B0", Offset = "0x5AEC0B0", VA = "0x185AED4B0")]
			public UxmlTraits()
			{
			}

			// Token: 0x040005B4 RID: 1460
			[Token(Token = "0x40005B4")]
			[FieldOffset(Offset = "0x70")]
			private readonly UxmlIntAttributeDescription m_ItemHeight;

			// Token: 0x040005B5 RID: 1461
			[Token(Token = "0x40005B5")]
			[FieldOffset(Offset = "0x78")]
			private readonly UxmlBoolAttributeDescription m_ShowBorder;

			// Token: 0x040005B6 RID: 1462
			[Token(Token = "0x40005B6")]
			[FieldOffset(Offset = "0x80")]
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType;

			// Token: 0x040005B7 RID: 1463
			[Token(Token = "0x40005B7")]
			[FieldOffset(Offset = "0x88")]
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;
		}

		// Token: 0x02000169 RID: 361
		[Token(Token = "0x2000169")]
		private struct TreeViewItemWrapper
		{
			// Token: 0x17000234 RID: 564
			// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00005A48 File Offset: 0x00003C48
			[Token(Token = "0x17000234")]
			public int id
			{
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0x5AEBBF0", Offset = "0x5AEA7F0", VA = "0x185AEBBF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x040005B8 RID: 1464
			[Token(Token = "0x40005B8")]
			[FieldOffset(Offset = "0x0")]
			public int depth;

			// Token: 0x040005B9 RID: 1465
			[Token(Token = "0x40005B9")]
			[FieldOffset(Offset = "0x8")]
			public ITreeViewItem item;
		}
	}
}
