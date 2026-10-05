using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003542 RID: 13634
	[Token(Token = "0x2003542")]
	public class UICharacterSortFilterPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015BB6 RID: 89014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BB6")]
		[Address(RVA = "0xE52020", Offset = "0xE50C20", VA = "0x180E52020")]
		public void Render(CharacterSortType sortType, [Optional] UICharacterSortFilterPanel.ProfessionFilterOptions filterOptions)
		{
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x06015BB7 RID: 89015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033A0")]
		public UICharacterHandbookStageCountItem stageCountItem
		{
			[Token(Token = "0x6015BB7")]
			[Address(RVA = "0xE52AB0", Offset = "0xE516B0", VA = "0x180E52AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015BB8 RID: 89016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BB8")]
		[Address(RVA = "0xE52740", Offset = "0xE51340", VA = "0x180E52740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015BB9 RID: 89017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BB9")]
		[Address(RVA = "0xE523F0", Offset = "0xE50FF0", VA = "0x180E523F0")]
		private void _InitFilterState()
		{
		}

		// Token: 0x06015BBA RID: 89018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BBA")]
		[Address(RVA = "0xE52520", Offset = "0xE51120", VA = "0x180E52520")]
		private void _InitFilter()
		{
		}

		// Token: 0x06015BBB RID: 89019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BBB")]
		[Address(RVA = "0xE51E20", Offset = "0xE50A20", VA = "0x180E51E20")]
		public void EventOnDissmissSort()
		{
		}

		// Token: 0x06015BBC RID: 89020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BBC")]
		[Address(RVA = "0xE51F20", Offset = "0xE50B20", VA = "0x180E51F20")]
		public void EventOnShowSortPanel()
		{
		}

		// Token: 0x06015BBD RID: 89021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BBD")]
		[Address(RVA = "0xE529D0", Offset = "0xE515D0", VA = "0x180E529D0")]
		public UICharacterSortFilterPanel()
		{
		}

		// Token: 0x0401A1C7 RID: 106951
		[Token(Token = "0x401A1C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("the sort panel")]
		private UICharacterSortGroupOnFloat _sortGroup;

		// Token: 0x0401A1C8 RID: 106952
		[Token(Token = "0x401A1C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _sortPanel;

		// Token: 0x0401A1C9 RID: 106953
		[Token(Token = "0x401A1C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _backBkg;

		// Token: 0x0401A1CA RID: 106954
		[Token(Token = "0x401A1CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _filterContainer;

		// Token: 0x0401A1CB RID: 106955
		[Token(Token = "0x401A1CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<UICharacterProfessionFilterHolder.FilterParam> eventOnFilterClick;

		// Token: 0x0401A1CC RID: 106956
		[Token(Token = "0x401A1CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<bool> eventOnFilterShow;

		// Token: 0x0401A1CD RID: 106957
		[Token(Token = "0x401A1CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<CharacterSortType> eventOnSortClick;

		// Token: 0x0401A1CE RID: 106958
		[Token(Token = "0x401A1CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0401A1CF RID: 106959
		[Token(Token = "0x401A1CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public bool enableValidSubProfs;

		// Token: 0x0401A1D0 RID: 106960
		[Token(Token = "0x401A1D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public List<CharacterSortTypePair> customSortTypes;

		// Token: 0x0401A1D1 RID: 106961
		[Token(Token = "0x401A1D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0401A1D2 RID: 106962
		[Token(Token = "0x401A1D2")]
		private const float PANEL_ANIMATION_DURATION = 0.15f;

		// Token: 0x0401A1D3 RID: 106963
		[Token(Token = "0x401A1D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401A1D4 RID: 106964
		[Token(Token = "0x401A1D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UICharacterSortFilterPanel.ProfessionFilterHandler m_profFilterHandler;

		// Token: 0x0401A1D5 RID: 106965
		[Token(Token = "0x401A1D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UICharacterProfessionFilterHolder m_profFilterHolder;

		// Token: 0x0401A1D6 RID: 106966
		[Token(Token = "0x401A1D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 m_originSortPanelPos;

		// Token: 0x0401A1D7 RID: 106967
		[Token(Token = "0x401A1D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 m_targetSortPanelPos;

		// Token: 0x0401A1D8 RID: 106968
		[Token(Token = "0x401A1D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A1D9 RID: 106969
		[Token(Token = "0x401A1D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stageCountItem;

		// Token: 0x0401A1DA RID: 106970
		[Token(Token = "0x401A1DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A1DB RID: 106971
		[Token(Token = "0x401A1DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitFilterState;

		// Token: 0x0401A1DC RID: 106972
		[Token(Token = "0x401A1DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitFilter;

		// Token: 0x0401A1DD RID: 106973
		[Token(Token = "0x401A1DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnDissmissSort;

		// Token: 0x0401A1DE RID: 106974
		[Token(Token = "0x401A1DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnShowSortPanel;

		// Token: 0x0401A1DF RID: 106975
		[Token(Token = "0x401A1DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003543 RID: 13635
		[Token(Token = "0x2003543")]
		[Serializable]
		public class CharacterSortTypeMessage : UnityEvent<CharacterSortType>
		{
			// Token: 0x06015BBE RID: 89022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015BBE")]
			[Address(RVA = "0xE43960", Offset = "0xE42560", VA = "0x180E43960")]
			public CharacterSortTypeMessage()
			{
			}
		}

		// Token: 0x02003544 RID: 13636
		[Token(Token = "0x2003544")]
		[Serializable]
		public class CharacterFilterMessage : UnityEvent<UICharacterProfessionFilterHolder.FilterParam>
		{
			// Token: 0x06015BBF RID: 89023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015BBF")]
			[Address(RVA = "0xE43860", Offset = "0xE42460", VA = "0x180E43860")]
			public CharacterFilterMessage()
			{
			}
		}

		// Token: 0x02003545 RID: 13637
		[Token(Token = "0x2003545")]
		[Serializable]
		public class CharacterFilterShowMessage : UnityEvent<bool>
		{
			// Token: 0x06015BC0 RID: 89024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015BC0")]
			[Address(RVA = "0xE438E0", Offset = "0xE424E0", VA = "0x180E438E0")]
			public CharacterFilterShowMessage()
			{
			}
		}

		// Token: 0x02003546 RID: 13638
		[Token(Token = "0x2003546")]
		public struct ProfessionFilterOptions
		{
			// Token: 0x0401A1E0 RID: 106976
			[Token(Token = "0x401A1E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HashSet<string> validSubProfs;

			// Token: 0x0401A1E1 RID: 106977
			[Token(Token = "0x401A1E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool needReset;

			// Token: 0x0401A1E2 RID: 106978
			[Token(Token = "0x401A1E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool resetShow;

			// Token: 0x0401A1E3 RID: 106979
			[Token(Token = "0x401A1E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UICharacterProfessionFilterHolder.FilterParam filterResetParam;
		}

		// Token: 0x02003547 RID: 13639
		[Token(Token = "0x2003547")]
		private class ProfessionFilterHandler : UICharacterProfessionFilterHolder.IProfFilterHandler, UICharacterFilterHolder.IFilterHandler, IHotfixable
		{
			// Token: 0x06015BC1 RID: 89025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015BC1")]
			[Address(RVA = "0xE475B0", Offset = "0xE461B0", VA = "0x180E475B0")]
			public ProfessionFilterHandler(UICharacterSortFilterPanel closure)
			{
			}

			// Token: 0x06015BC2 RID: 89026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015BC2")]
			[Address(RVA = "0xE473F0", Offset = "0xE45FF0", VA = "0x180E473F0", Slot = "5")]
			public void OnApplyFilter(ValueBundle val)
			{
			}

			// Token: 0x06015BC3 RID: 89027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015BC3")]
			[Address(RVA = "0xE47520", Offset = "0xE46120", VA = "0x180E47520", Slot = "4")]
			public void OnProfPanelChanged(bool isShow)
			{
			}

			// Token: 0x0401A1E4 RID: 106980
			[Token(Token = "0x401A1E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UICharacterSortFilterPanel m_closure;

			// Token: 0x0401A1E5 RID: 106981
			[Token(Token = "0x401A1E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401A1E6 RID: 106982
			[Token(Token = "0x401A1E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnApplyFilter;

			// Token: 0x0401A1E7 RID: 106983
			[Token(Token = "0x401A1E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnProfPanelChanged;
		}
	}
}
