using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	public class GenericDropdownMenu : IGenericMenu
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001A7")]
		public VisualElement contentContainer
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x5AB2EE0", Offset = "0x5AB1AE0", VA = "0x185AB2EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x5AB2B50", Offset = "0x5AB1750", VA = "0x185AB2B50")]
		public GenericDropdownMenu()
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x5AB18B0", Offset = "0x5AB04B0", VA = "0x185AB18B0")]
		private void OnAttachToPanel(AttachToPanelEvent evt)
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x5AB1CC0", Offset = "0x5AB08C0", VA = "0x185AB1CC0")]
		private void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x5AB17B0", Offset = "0x5AB03B0", VA = "0x185AB17B0")]
		private void Hide()
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x5AB09A0", Offset = "0x5AAF5A0", VA = "0x185AB09A0")]
		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x5AB0610", Offset = "0x5AAF210", VA = "0x185AB0610")]
		private bool Apply(KeyboardNavigationOperation op)
		{
			return default(bool);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x5AB21B0", Offset = "0x5AB0DB0", VA = "0x185AB21B0")]
		private void OnPointerDown(PointerDownEvent evt)
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x5AB2330", Offset = "0x5AB0F30", VA = "0x185AB2330")]
		private void OnPointerMove(PointerMoveEvent evt)
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x5AB24B0", Offset = "0x5AB10B0", VA = "0x185AB24B0")]
		private void OnPointerUp(PointerUpEvent evt)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x5AB2030", Offset = "0x5AB0C30", VA = "0x185AB2030")]
		private void OnFocusOut(FocusOutEvent evt)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x5AB21A0", Offset = "0x5AB0DA0", VA = "0x185AB21A0")]
		private void OnParentResized(GeometryChangedEvent evt)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x5AB2750", Offset = "0x5AB1350", VA = "0x185AB2750")]
		private void UpdateSelection(VisualElement target)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x5AB09E0", Offset = "0x5AAF5E0", VA = "0x185AB09E0")]
		private void ChangeSelectedIndex(int newIndex, int previousIndex)
		{
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x5AB1700", Offset = "0x5AB0300", VA = "0x185AB1700")]
		private int GetSelectedIndex()
		{
			return 0;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x5AB0110", Offset = "0x5AAED10", VA = "0x185AB0110", Slot = "4")]
		public void AddItem(string itemName, bool isChecked, Action action)
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x5AB0550", Offset = "0x5AAF150", VA = "0x185AB0550", Slot = "6")]
		public void AddSeparator(string path)
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x5AB0150", Offset = "0x5AAED50", VA = "0x185AB0150")]
		private GenericDropdownMenu.MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, [Optional] object data)
		{
			return null;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x5AB0B10", Offset = "0x5AAF710", VA = "0x185AB0B10", Slot = "5")]
		public void DropDown(Rect position, [Optional] VisualElement targetElement, bool anchored = false)
		{
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x5AB21A0", Offset = "0x5AB0DA0", VA = "0x185AB21A0")]
		private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt)
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x5AB1CB0", Offset = "0x5AB08B0", VA = "0x185AB1CB0")]
		private void OnContainerGeometryChanged(GeometryChangedEvent evt)
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x5AB1160", Offset = "0x5AAFD60", VA = "0x185AB1160")]
		private void EnsureVisibilityInParent()
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x5AB2600", Offset = "0x5AB1200", VA = "0x185AB2600")]
		[CompilerGenerated]
		private void <Apply>g__UpdateSelectionDown|27_0(int newIndex, ref GenericDropdownMenu.<>c__DisplayClass27_0 A_2)
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x5AB26B0", Offset = "0x5AB12B0", VA = "0x185AB26B0")]
		[CompilerGenerated]
		private void <Apply>g__UpdateSelectionUp|27_1(int newIndex, ref GenericDropdownMenu.<>c__DisplayClass27_0 A_2)
		{
		}

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string itemUssClassName;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly string labelUssClassName;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly string containerInnerUssClassName;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly string containerOuterUssClassName;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly string checkmarkUssClassName;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly string separatorUssClassName;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<GenericDropdownMenu.MenuItem> m_Items;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VisualElement m_MenuContainer;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VisualElement m_OuterContainer;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ScrollView m_ScrollView;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VisualElement m_PanelRootVisualContainer;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private VisualElement m_TargetElement;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rect m_DesiredRect;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private KeyboardNavigationManipulator m_NavigationManipulator;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 m_MousePosition;

		// Token: 0x0200010F RID: 271
		[Token(Token = "0x200010F")]
		internal class MenuItem
		{
			// Token: 0x060007F8 RID: 2040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MenuItem()
			{
			}

			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0400040D RID: 1037
			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public VisualElement element;

			// Token: 0x0400040E RID: 1038
			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;

			// Token: 0x0400040F RID: 1039
			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<object> actionUserData;
		}
	}
}
