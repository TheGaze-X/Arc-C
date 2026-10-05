using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Home;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003541 RID: 13633
	[Token(Token = "0x2003541")]
	public class UICharacterSecretarySortFilterPanelBinder : DataBinder<HomeSecretaryChangeCardGroupViewProperty>
	{
		// Token: 0x06015BAF RID: 89007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BAF")]
		[Address(RVA = "0xE50A10", Offset = "0xE4F610", VA = "0x180E50A10", Slot = "7")]
		public override void OnValueChanged(HomeSecretaryChangeCardGroupViewProperty property)
		{
		}

		// Token: 0x06015BB0 RID: 89008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BB0")]
		[Address(RVA = "0xE50B70", Offset = "0xE4F770", VA = "0x180E50B70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015BB1 RID: 89009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BB1")]
		[Address(RVA = "0xE50950", Offset = "0xE4F550", VA = "0x180E50950")]
		public void OnFilterBlockClick()
		{
		}

		// Token: 0x06015BB2 RID: 89010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BB2")]
		[Address(RVA = "0xE50E20", Offset = "0xE4FA20", VA = "0x180E50E20")]
		public UICharacterSecretarySortFilterPanelBinder()
		{
		}

		// Token: 0x0401A1BD RID: 106941
		[Token(Token = "0x401A1BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelHolder;

		// Token: 0x0401A1BE RID: 106942
		[Token(Token = "0x401A1BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterSecretarySortFilterPanel _panelPrefab;

		// Token: 0x0401A1BF RID: 106943
		[Token(Token = "0x401A1BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _transSortFilterBlocker;

		// Token: 0x0401A1C0 RID: 106944
		[Token(Token = "0x401A1C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICharacterSecretarySortFilterPanel.CharacterFilterMessage _onFilterEvent;

		// Token: 0x0401A1C1 RID: 106945
		[Token(Token = "0x401A1C1")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401A1C2 RID: 106946
		[Token(Token = "0x401A1C2")]
		[FieldOffset(Offset = "0x48")]
		private UICharacterSecretarySortFilterPanel m_sortFilterPanel;

		// Token: 0x0401A1C3 RID: 106947
		[Token(Token = "0x401A1C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A1C4 RID: 106948
		[Token(Token = "0x401A1C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A1C5 RID: 106949
		[Token(Token = "0x401A1C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFilterBlockClick;

		// Token: 0x0401A1C6 RID: 106950
		[Token(Token = "0x401A1C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
