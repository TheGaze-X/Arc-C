using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	public class ListView : BaseVerticalCollectionView
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x000051A8 File Offset: 0x000033A8
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B4")]
		public bool showBoundCollectionSize
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x5AB9290", Offset = "0x5AB7E90", VA = "0x185AB9290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x5AB93E0", Offset = "0x5AB7FE0", VA = "0x185AB93E0")]
			set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x000051C0 File Offset: 0x000033C0
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B5")]
		public bool showFoldoutHeader
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x5AB92A0", Offset = "0x5AB7EA0", VA = "0x185AB92A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x5AB9400", Offset = "0x5AB8000", VA = "0x185AB9400")]
			set
			{
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x5AB8500", Offset = "0x5AB7100", VA = "0x185AB8500")]
		internal void SetupArraySizeField()
		{
		}

		// Token: 0x170001B6 RID: 438
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B6")]
		public string headerTitle
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x5AB92C0", Offset = "0x5AB7EC0", VA = "0x185AB92C0")]
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x000051D8 File Offset: 0x000033D8
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B7")]
		public bool showAddRemoveFooter
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x5AB9280", Offset = "0x5AB7E80", VA = "0x185AB9280")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x5AB93D0", Offset = "0x5AB7FD0", VA = "0x185AB93D0")]
			set
			{
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x5AB77A0", Offset = "0x5AB63A0", VA = "0x185AB77A0")]
		private void EnableFooter(bool enabled)
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x5AB7590", Offset = "0x5AB6190", VA = "0x185AB7590")]
		private void AddItems(int itemCount)
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x5AB7E30", Offset = "0x5AB6A30", VA = "0x185AB7E30")]
		private void OnArraySizeFieldChanged(ChangeEvent<string> evt)
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x5AB88D0", Offset = "0x5AB74D0", VA = "0x185AB88D0")]
		private void UpdateArraySizeField()
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x5AB89B0", Offset = "0x5AB75B0", VA = "0x185AB89B0")]
		private void UpdateEmpty()
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x5AB7C30", Offset = "0x5AB6830", VA = "0x185AB7C30")]
		private void OnAddClicked()
		{
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x5AB7FF0", Offset = "0x5AB6BF0", VA = "0x185AB7FF0")]
		private void OnRemoveClicked()
		{
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001B8")]
		internal new ListViewController viewController
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x5AB92B0", Offset = "0x5AB7EB0", VA = "0x185AB92B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x5AB7760", Offset = "0x5AB6360", VA = "0x185AB7760", Slot = "101")]
		private protected override void CreateVirtualizationController()
		{
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x5AB76F0", Offset = "0x5AB62F0", VA = "0x185AB76F0", Slot = "102")]
		private protected override void CreateViewController()
		{
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x5AB82D0", Offset = "0x5AB6ED0", VA = "0x185AB82D0")]
		internal void SetViewController(ListViewController controller)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x5AB7FB0", Offset = "0x5AB6BB0", VA = "0x185AB7FB0")]
		private void OnItemAdded(IEnumerable<int> indices)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x5AB7FD0", Offset = "0x5AB6BD0", VA = "0x185AB7FD0")]
		private void OnItemsRemoved(IEnumerable<int> indices)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x5AABFE0", Offset = "0x5AAABE0", VA = "0x185AABFE0")]
		private void OnItemsSourceSizeChanged()
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x000051F0 File Offset: 0x000033F0
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B9")]
		public ListViewReorderMode reorderMode
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x5AB9270", Offset = "0x5AB7E70", VA = "0x185AB9270")]
			get
			{
				return ListViewReorderMode.Simple;
			}
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x5AB9310", Offset = "0x5AB7F10", VA = "0x185AB9310")]
			set
			{
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x5AB7640", Offset = "0x5AB6240", VA = "0x185AB7640", Slot = "103")]
		internal override ListViewDragger CreateDragger()
		{
			return null;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x5AB75E0", Offset = "0x5AB61E0", VA = "0x185AB75E0", Slot = "104")]
		internal override ICollectionDragAndDropController CreateDragAndDropController()
		{
			return null;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x5AB91D0", Offset = "0x5AB7DD0", VA = "0x185AB91D0")]
		public ListView()
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x5AB8170", Offset = "0x5AB6D70", VA = "0x185AB8170", Slot = "105")]
		private protected override void PostRefresh()
		{
		}

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string k_SizeFieldLabel;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x4A8")]
		private bool m_ShowBoundCollectionSize;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x4A9")]
		private bool m_ShowFoldoutHeader;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x4B0")]
		private string m_HeaderTitle;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x4B8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IEnumerable<int>> itemsAdded;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x4C0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IEnumerable<int>> itemsRemoved;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x4C8")]
		private Label m_EmptyListLabel;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x4D0")]
		private Foldout m_Foldout;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x4D8")]
		private TextField m_ArraySizeField;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x4E0")]
		private VisualElement m_Footer;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x4E8")]
		private Button m_AddButton;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x4F0")]
		private Button m_RemoveButton;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x4F8")]
		private Action<IEnumerable<int>> m_ItemAddedCallback;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x500")]
		private Action<IEnumerable<int>> m_ItemRemovedCallback;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x508")]
		private Action m_ItemsSourceSizeChangedCallback;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x510")]
		private ListViewController m_ListViewController;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x518")]
		private ListViewReorderMode m_ReorderMode;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly string ussClassName;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x10")]
		public new static readonly string itemUssClassName;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string emptyLabelUssClassName;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string reorderableUssClassName;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string reorderableItemUssClassName;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string reorderableItemContainerUssClassName;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string reorderableItemHandleUssClassName;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string reorderableItemHandleBarUssClassName;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string footerUssClassName;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string foldoutHeaderUssClassName;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string arraySizeFieldUssClassName;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string arraySizeFieldWithHeaderUssClassName;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x68")]
		public static readonly string arraySizeFieldWithFooterUssClassName;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x70")]
		public static readonly string listViewWithHeaderUssClassName;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x78")]
		public static readonly string listViewWithFooterUssClassName;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x80")]
		public static readonly string scrollViewWithFooterUssClassName;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x88")]
		internal static readonly string footerAddButtonName;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x90")]
		internal static readonly string footerRemoveButtonName;

		// Token: 0x02000123 RID: 291
		[Token(Token = "0x2000123")]
		public new class UxmlFactory : UxmlFactory<ListView, ListView.UxmlTraits>
		{
			// Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x5ABD520", Offset = "0x5ABC120", VA = "0x185ABD520")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000124 RID: 292
		[Token(Token = "0x2000124")]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x06000855 RID: 2133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x5ABD560", Offset = "0x5ABC160", VA = "0x185ABD560", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x06000856 RID: 2134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x5ABE560", Offset = "0x5ABD160", VA = "0x185ABE560")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000465 RID: 1125
			[Token(Token = "0x4000465")]
			[FieldOffset(Offset = "0x78")]
			private readonly UxmlIntAttributeDescription m_FixedItemHeight;

			// Token: 0x04000466 RID: 1126
			[Token(Token = "0x4000466")]
			[FieldOffset(Offset = "0x80")]
			private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod;

			// Token: 0x04000467 RID: 1127
			[Token(Token = "0x4000467")]
			[FieldOffset(Offset = "0x88")]
			private readonly UxmlBoolAttributeDescription m_ShowBorder;

			// Token: 0x04000468 RID: 1128
			[Token(Token = "0x4000468")]
			[FieldOffset(Offset = "0x90")]
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType;

			// Token: 0x04000469 RID: 1129
			[Token(Token = "0x4000469")]
			[FieldOffset(Offset = "0x98")]
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			[FieldOffset(Offset = "0xA0")]
			private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader;

			// Token: 0x0400046B RID: 1131
			[Token(Token = "0x400046B")]
			[FieldOffset(Offset = "0xA8")]
			private readonly UxmlStringAttributeDescription m_HeaderTitle;

			// Token: 0x0400046C RID: 1132
			[Token(Token = "0x400046C")]
			[FieldOffset(Offset = "0xB0")]
			private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter;

			// Token: 0x0400046D RID: 1133
			[Token(Token = "0x400046D")]
			[FieldOffset(Offset = "0xB8")]
			private readonly UxmlBoolAttributeDescription m_Reorderable;

			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x400046E")]
			[FieldOffset(Offset = "0xC0")]
			private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode;

			// Token: 0x0400046F RID: 1135
			[Token(Token = "0x400046F")]
			[FieldOffset(Offset = "0xC8")]
			private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize;

			// Token: 0x04000470 RID: 1136
			[Token(Token = "0x4000470")]
			[FieldOffset(Offset = "0xD0")]
			private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled;
		}
	}
}
