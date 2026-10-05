using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterRepo;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200353E RID: 13630
	[Token(Token = "0x200353E")]
	public class UICharacterRepoSortFilterPanelBinder : DataBinder<CharacterRepoCardGroupViewProperty>, IHotfixable
	{
		// Token: 0x06015B9C RID: 88988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B9C")]
		[Address(RVA = "0xE4FC80", Offset = "0xE4E880", VA = "0x180E4FC80", Slot = "7")]
		public override void OnValueChanged(CharacterRepoCardGroupViewProperty property)
		{
		}

		// Token: 0x06015B9D RID: 88989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B9D")]
		[Address(RVA = "0xE50400", Offset = "0xE4F000", VA = "0x180E50400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015B9E RID: 88990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B9E")]
		[Address(RVA = "0xE50250", Offset = "0xE4EE50", VA = "0x180E50250")]
		private void _BindCntItemIfNot()
		{
		}

		// Token: 0x06015B9F RID: 88991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B9F")]
		[Address(RVA = "0xE50620", Offset = "0xE4F220", VA = "0x180E50620")]
		private void _UpdateValidSubProfs(List<CharacterCardViewModel> charCards)
		{
		}

		// Token: 0x06015BA0 RID: 88992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BA0")]
		[Address(RVA = "0xE508A0", Offset = "0xE4F4A0", VA = "0x180E508A0")]
		public void onSortPanelShow()
		{
		}

		// Token: 0x06015BA1 RID: 88993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BA1")]
		[Address(RVA = "0xE50790", Offset = "0xE4F390", VA = "0x180E50790")]
		public UICharacterRepoSortFilterPanelBinder()
		{
		}

		// Token: 0x0401A194 RID: 106900
		[Token(Token = "0x401A194")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelHolder;

		// Token: 0x0401A195 RID: 106901
		[Token(Token = "0x401A195")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterSortFilterPanel _panelPrefab;

		// Token: 0x0401A196 RID: 106902
		[Token(Token = "0x401A196")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICharacterSortFilterPanel.CharacterFilterMessage _onFilterEvent;

		// Token: 0x0401A197 RID: 106903
		[Token(Token = "0x401A197")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICharacterSortFilterPanel.CharacterFilterShowMessage _onFilterShowEvent;

		// Token: 0x0401A198 RID: 106904
		[Token(Token = "0x401A198")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICharacterSortFilterPanel.CharacterSortTypeMessage _onSortEvent;

		// Token: 0x0401A199 RID: 106905
		[Token(Token = "0x401A199")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401A19A RID: 106906
		[Token(Token = "0x401A19A")]
		[FieldOffset(Offset = "0x50")]
		private UICharacterSortFilterPanel m_sortFilterPanel;

		// Token: 0x0401A19B RID: 106907
		[Token(Token = "0x401A19B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_itemBind;

		// Token: 0x0401A19C RID: 106908
		[Token(Token = "0x401A19C")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cachedEnterSeq;

		// Token: 0x0401A19D RID: 106909
		[Token(Token = "0x401A19D")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private IntProperty m_charHandbookStageCntProperty;

		// Token: 0x0401A19E RID: 106910
		[Token(Token = "0x401A19E")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0401A19F RID: 106911
		[Token(Token = "0x401A19F")]
		[FieldOffset(Offset = "0x70")]
		private HashSet<string> m_cachedValidSubProf;

		// Token: 0x0401A1A0 RID: 106912
		[Token(Token = "0x401A1A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A1A1 RID: 106913
		[Token(Token = "0x401A1A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A1A2 RID: 106914
		[Token(Token = "0x401A1A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BindCntItemIfNot;

		// Token: 0x0401A1A3 RID: 106915
		[Token(Token = "0x401A1A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateValidSubProfs;

		// Token: 0x0401A1A4 RID: 106916
		[Token(Token = "0x401A1A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_onSortPanelShow;

		// Token: 0x0401A1A5 RID: 106917
		[Token(Token = "0x401A1A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
