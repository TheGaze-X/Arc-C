using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E30 RID: 24112
	[Token(Token = "0x2005E30")]
	public class CharacterRepoStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06022F0B RID: 143115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F0B")]
		[Address(RVA = "0x1D7D910", Offset = "0x1D7C510", VA = "0x181D7D910")]
		public void LoadData(string pageName)
		{
		}

		// Token: 0x06022F0C RID: 143116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F0C")]
		[Address(RVA = "0x1D7D9F0", Offset = "0x1D7C5F0", VA = "0x181D7D9F0")]
		public void LoadData(CharacterSortType charSortType, bool cachedStarMarkTop, string pageName)
		{
		}

		// Token: 0x06022F0D RID: 143117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F0D")]
		[Address(RVA = "0x1D7DCC0", Offset = "0x1D7C8C0", VA = "0x181D7DCC0")]
		public void ReloadAllCards()
		{
		}

		// Token: 0x170052D0 RID: 21200
		// (get) Token: 0x06022F0E RID: 143118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170052D0")]
		public CharacterProfessionFilterViewModel cardFilter
		{
			[Token(Token = "0x6022F0E")]
			[Address(RVA = "0x1D7E7B0", Offset = "0x1D7D3B0", VA = "0x181D7E7B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022F0F RID: 143119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F0F")]
		[Address(RVA = "0x1D7E010", Offset = "0x1D7CC10", VA = "0x181D7E010")]
		public void SetCardFilter(CharacterProfessionFilterParam filter)
		{
		}

		// Token: 0x170052D1 RID: 21201
		// (get) Token: 0x06022F10 RID: 143120 RVA: 0x000BF8B0 File Offset: 0x000BDAB0
		[Token(Token = "0x170052D1")]
		public CharacterSortType sortType
		{
			[Token(Token = "0x6022F10")]
			[Address(RVA = "0x1D7E840", Offset = "0x1D7D440", VA = "0x181D7E840")]
			get
			{
				return CharacterSortType.BY_LEVEL_UP;
			}
		}

		// Token: 0x06022F11 RID: 143121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F11")]
		[Address(RVA = "0x1D7E0D0", Offset = "0x1D7CCD0", VA = "0x181D7E0D0")]
		public void SetSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x170052D2 RID: 21202
		// (get) Token: 0x06022F12 RID: 143122 RVA: 0x000BF8C8 File Offset: 0x000BDAC8
		// (set) Token: 0x06022F13 RID: 143123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052D2")]
		public bool trackPointFilterState
		{
			[Token(Token = "0x6022F12")]
			[Address(RVA = "0x1D7E950", Offset = "0x1D7D550", VA = "0x181D7E950")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022F13")]
			[Address(RVA = "0x1D7EB20", Offset = "0x1D7D720", VA = "0x181D7EB20")]
			set
			{
			}
		}

		// Token: 0x06022F14 RID: 143124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F14")]
		[Address(RVA = "0x1D7E320", Offset = "0x1D7CF20", VA = "0x181D7E320")]
		public void ToggleTrackPointSelected()
		{
		}

		// Token: 0x170052D3 RID: 21203
		// (get) Token: 0x06022F15 RID: 143125 RVA: 0x000BF8E0 File Offset: 0x000BDAE0
		// (set) Token: 0x06022F16 RID: 143126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052D3")]
		public bool starMarkTopState
		{
			[Token(Token = "0x6022F15")]
			[Address(RVA = "0x1D7E8C0", Offset = "0x1D7D4C0", VA = "0x181D7E8C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022F16")]
			[Address(RVA = "0x1D7E9D0", Offset = "0x1D7D5D0", VA = "0x181D7E9D0")]
			set
			{
			}
		}

		// Token: 0x06022F17 RID: 143127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F17")]
		[Address(RVA = "0x1D7E240", Offset = "0x1D7CE40", VA = "0x181D7E240")]
		public void ToggleStarMarkTopSelected()
		{
		}

		// Token: 0x06022F18 RID: 143128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F18")]
		[Address(RVA = "0x1D7D7B0", Offset = "0x1D7C3B0", VA = "0x181D7D7B0")]
		public void ClearStarMarkEditSelectIds()
		{
		}

		// Token: 0x06022F19 RID: 143129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F19")]
		[Address(RVA = "0x1D7D860", Offset = "0x1D7C460", VA = "0x181D7D860")]
		public void ExitStarMarkEditMode()
		{
		}

		// Token: 0x06022F1A RID: 143130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F1A")]
		[Address(RVA = "0x1D7DC40", Offset = "0x1D7C840", VA = "0x181D7DC40")]
		public void NotifyCardGroupChanged()
		{
		}

		// Token: 0x06022F1B RID: 143131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F1B")]
		[Address(RVA = "0x1D7E3E0", Offset = "0x1D7CFE0", VA = "0x181D7E3E0")]
		private Dictionary<int, CharacterHandbookStageStatus> _GenStageStatusDict(out int unlockedCount)
		{
			return null;
		}

		// Token: 0x06022F1C RID: 143132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F1C")]
		[Address(RVA = "0x1D7E5E0", Offset = "0x1D7D1E0", VA = "0x181D7E5E0")]
		public CharacterRepoStateBean()
		{
		}

		// Token: 0x04030214 RID: 197140
		[Token(Token = "0x4030214")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public CharacterRepoCardGroupViewProperty cardGroupProperty;

		// Token: 0x04030215 RID: 197141
		[Token(Token = "0x4030215")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private IntProperty _trackPointCountProperty;

		// Token: 0x04030216 RID: 197142
		[Token(Token = "0x4030216")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoolProperty _trackPointSelectedProperty;

		// Token: 0x04030217 RID: 197143
		[Token(Token = "0x4030217")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BoolProperty _starMarkSelectedProperty;

		// Token: 0x04030218 RID: 197144
		[Token(Token = "0x4030218")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterCardSortTypeViewProperty _sortTypeProperty;

		// Token: 0x04030219 RID: 197145
		[Token(Token = "0x4030219")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403021A RID: 197146
		[Token(Token = "0x403021A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0403021B RID: 197147
		[Token(Token = "0x403021B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReloadAllCards;

		// Token: 0x0403021C RID: 197148
		[Token(Token = "0x403021C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cardFilter;

		// Token: 0x0403021D RID: 197149
		[Token(Token = "0x403021D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetCardFilter;

		// Token: 0x0403021E RID: 197150
		[Token(Token = "0x403021E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_sortType;

		// Token: 0x0403021F RID: 197151
		[Token(Token = "0x403021F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetSortType;

		// Token: 0x04030220 RID: 197152
		[Token(Token = "0x4030220")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_trackPointFilterState;

		// Token: 0x04030221 RID: 197153
		[Token(Token = "0x4030221")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_trackPointFilterState;

		// Token: 0x04030222 RID: 197154
		[Token(Token = "0x4030222")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ToggleTrackPointSelected;

		// Token: 0x04030223 RID: 197155
		[Token(Token = "0x4030223")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_starMarkTopState;

		// Token: 0x04030224 RID: 197156
		[Token(Token = "0x4030224")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_starMarkTopState;

		// Token: 0x04030225 RID: 197157
		[Token(Token = "0x4030225")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ToggleStarMarkTopSelected;

		// Token: 0x04030226 RID: 197158
		[Token(Token = "0x4030226")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ClearStarMarkEditSelectIds;

		// Token: 0x04030227 RID: 197159
		[Token(Token = "0x4030227")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ExitStarMarkEditMode;

		// Token: 0x04030228 RID: 197160
		[Token(Token = "0x4030228")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_NotifyCardGroupChanged;

		// Token: 0x04030229 RID: 197161
		[Token(Token = "0x4030229")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenStageStatusDict;

		// Token: 0x0403022A RID: 197162
		[Token(Token = "0x403022A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
