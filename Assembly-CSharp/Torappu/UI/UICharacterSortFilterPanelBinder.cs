using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003548 RID: 13640
	[Token(Token = "0x2003548")]
	public class UICharacterSortFilterPanelBinder : DataBinder<CardGroupViewProperty>, IHotfixable
	{
		// Token: 0x06015BC4 RID: 89028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BC4")]
		[Address(RVA = "0xE51880", Offset = "0xE50480", VA = "0x180E51880", Slot = "7")]
		public override void OnValueChanged(CardGroupViewProperty property)
		{
		}

		// Token: 0x06015BC5 RID: 89029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BC5")]
		[Address(RVA = "0xE51AE0", Offset = "0xE506E0", VA = "0x180E51AE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015BC6 RID: 89030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BC6")]
		[Address(RVA = "0xE51D70", Offset = "0xE50970", VA = "0x180E51D70")]
		public void onSortPanelShow()
		{
		}

		// Token: 0x06015BC7 RID: 89031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BC7")]
		[Address(RVA = "0xE51D00", Offset = "0xE50900", VA = "0x180E51D00")]
		public UICharacterSortFilterPanelBinder()
		{
		}

		// Token: 0x0401A1E8 RID: 106984
		[Token(Token = "0x401A1E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelHolder;

		// Token: 0x0401A1E9 RID: 106985
		[Token(Token = "0x401A1E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterSortFilterPanel _panelPrefab;

		// Token: 0x0401A1EA RID: 106986
		[Token(Token = "0x401A1EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICharacterSortFilterPanel.CharacterFilterMessage _onFilterEvent;

		// Token: 0x0401A1EB RID: 106987
		[Token(Token = "0x401A1EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICharacterSortFilterPanel.CharacterFilterShowMessage _onFilterShowEvent;

		// Token: 0x0401A1EC RID: 106988
		[Token(Token = "0x401A1EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICharacterSortFilterPanel.CharacterSortTypeMessage _onSortEvent;

		// Token: 0x0401A1ED RID: 106989
		[Token(Token = "0x401A1ED")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0401A1EE RID: 106990
		[Token(Token = "0x401A1EE")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401A1EF RID: 106991
		[Token(Token = "0x401A1EF")]
		[FieldOffset(Offset = "0x54")]
		private int m_cachedEnterSeq;

		// Token: 0x0401A1F0 RID: 106992
		[Token(Token = "0x401A1F0")]
		[FieldOffset(Offset = "0x58")]
		private UICharacterSortFilterPanel m_sortFilterPanel;

		// Token: 0x0401A1F1 RID: 106993
		[Token(Token = "0x401A1F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A1F2 RID: 106994
		[Token(Token = "0x401A1F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A1F3 RID: 106995
		[Token(Token = "0x401A1F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_onSortPanelShow;

		// Token: 0x0401A1F4 RID: 106996
		[Token(Token = "0x401A1F4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
