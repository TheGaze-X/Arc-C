using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003549 RID: 13641
	[Token(Token = "0x2003549")]
	public class UICharacterSortGroupOnFloat : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015BCB RID: 89035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BCB")]
		[Address(RVA = "0xE52B50", Offset = "0xE51750", VA = "0x180E52B50")]
		public void RenderSortGroup()
		{
		}

		// Token: 0x06015BCC RID: 89036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BCC")]
		[Address(RVA = "0xE536B0", Offset = "0xE522B0", VA = "0x180E536B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015BCD RID: 89037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015BCD")]
		[Address(RVA = "0xE52D40", Offset = "0xE51940", VA = "0x180E52D40")]
		private UICharacterSortCommonItem _DealWithCustomItem(CharacterSortTypePair sortpair, bool lightColorFlag)
		{
			return null;
		}

		// Token: 0x06015BCE RID: 89038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015BCE")]
		[Address(RVA = "0xE534B0", Offset = "0xE520B0", VA = "0x180E534B0")]
		private UICharacterSortTypeItem _GenNormalSortTypeItem(CharacterSortTypePair sortPair, bool lightColor)
		{
			return null;
		}

		// Token: 0x06015BCF RID: 89039 RVA: 0x0008DA20 File Offset: 0x0008BC20
		[Token(Token = "0x6015BCF")]
		[Address(RVA = "0xE531D0", Offset = "0xE51DD0", VA = "0x180E531D0")]
		private bool _EnsureShowHandBookSort()
		{
			return default(bool);
		}

		// Token: 0x06015BD0 RID: 89040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015BD0")]
		[Address(RVA = "0xE53030", Offset = "0xE51C30", VA = "0x180E53030")]
		private UICharacterSortTypePanelItem _DealWithHandBookSort(CharacterSortTypePair sortPair, bool lightColor)
		{
			return null;
		}

		// Token: 0x06015BD1 RID: 89041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015BD1")]
		[Address(RVA = "0xE53260", Offset = "0xE51E60", VA = "0x180E53260")]
		private UICharacterSortTypePanelItem _GenCustomSortTypeItem(CharacterSortTypePair sortPair, bool lightColor)
		{
			return null;
		}

		// Token: 0x06015BD2 RID: 89042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BD2")]
		[Address(RVA = "0xE52CE0", Offset = "0xE518E0", VA = "0x180E52CE0")]
		private void _ClearSortItems()
		{
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x06015BD3 RID: 89043 RVA: 0x0008DA38 File Offset: 0x0008BC38
		// (set) Token: 0x06015BD4 RID: 89044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033A1")]
		public CharacterSortType sortType
		{
			[Token(Token = "0x6015BD3")]
			[Address(RVA = "0xE539A0", Offset = "0xE525A0", VA = "0x180E539A0")]
			get
			{
				return CharacterSortType.BY_LEVEL_UP;
			}
			[Token(Token = "0x6015BD4")]
			[Address(RVA = "0xE53A60", Offset = "0xE52660", VA = "0x180E53A60")]
			set
			{
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x06015BD5 RID: 89045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033A2")]
		public UICharacterHandbookStageCountItem stageCountItem
		{
			[Token(Token = "0x6015BD5")]
			[Address(RVA = "0xE53A00", Offset = "0xE52600", VA = "0x180E53A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015BD6 RID: 89046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BD6")]
		[Address(RVA = "0xE52BB0", Offset = "0xE517B0", VA = "0x180E52BB0")]
		private void _ChangeSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x06015BD7 RID: 89047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BD7")]
		[Address(RVA = "0xE53940", Offset = "0xE52540", VA = "0x180E53940")]
		public UICharacterSortGroupOnFloat()
		{
		}

		// Token: 0x0401A1F5 RID: 106997
		[Token(Token = "0x401A1F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _sortItemContainer;

		// Token: 0x0401A1F6 RID: 106998
		[Token(Token = "0x401A1F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICharacterSortCommonItem _sortItemPrefab;

		// Token: 0x0401A1F7 RID: 106999
		[Token(Token = "0x401A1F7")]
		[FieldOffset(Offset = "0x28")]
		private CharacterSortType m_sortType;

		// Token: 0x0401A1F8 RID: 107000
		[Token(Token = "0x401A1F8")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<CharacterSortType> onSortCallback;

		// Token: 0x0401A1F9 RID: 107001
		[Token(Token = "0x401A1F9")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0401A1FA RID: 107002
		[Token(Token = "0x401A1FA")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public bool useCustomPrefab;

		// Token: 0x0401A1FB RID: 107003
		[Token(Token = "0x401A1FB")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public List<CharacterSortTypePair> customSortTypes;

		// Token: 0x0401A1FC RID: 107004
		[Token(Token = "0x401A1FC")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401A1FD RID: 107005
		[Token(Token = "0x401A1FD")]
		[FieldOffset(Offset = "0x58")]
		private List<UICharacterSortCommonItem> m_sortItems;

		// Token: 0x0401A1FE RID: 107006
		[Token(Token = "0x401A1FE")]
		[FieldOffset(Offset = "0x60")]
		private UICharacterHandbookStageCountItem m_stageCntItem;

		// Token: 0x0401A1FF RID: 107007
		[Token(Token = "0x401A1FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSortGroup;

		// Token: 0x0401A200 RID: 107008
		[Token(Token = "0x401A200")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A201 RID: 107009
		[Token(Token = "0x401A201")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DealWithCustomItem;

		// Token: 0x0401A202 RID: 107010
		[Token(Token = "0x401A202")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenNormalSortTypeItem;

		// Token: 0x0401A203 RID: 107011
		[Token(Token = "0x401A203")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureShowHandBookSort;

		// Token: 0x0401A204 RID: 107012
		[Token(Token = "0x401A204")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DealWithHandBookSort;

		// Token: 0x0401A205 RID: 107013
		[Token(Token = "0x401A205")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenCustomSortTypeItem;

		// Token: 0x0401A206 RID: 107014
		[Token(Token = "0x401A206")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ClearSortItems;

		// Token: 0x0401A207 RID: 107015
		[Token(Token = "0x401A207")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_sortType;

		// Token: 0x0401A208 RID: 107016
		[Token(Token = "0x401A208")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_sortType;

		// Token: 0x0401A209 RID: 107017
		[Token(Token = "0x401A209")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_stageCountItem;

		// Token: 0x0401A20A RID: 107018
		[Token(Token = "0x401A20A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ChangeSortType;

		// Token: 0x0401A20B RID: 107019
		[Token(Token = "0x401A20B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
