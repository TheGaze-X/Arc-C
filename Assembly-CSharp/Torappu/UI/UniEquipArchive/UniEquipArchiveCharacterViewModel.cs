using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BFE RID: 15358
	[Token(Token = "0x2003BFE")]
	public class UniEquipArchiveCharacterViewModel : IHotfixable
	{
		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0601803F RID: 98367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003944")]
		public List<UniEquipArchiveCharacterItemViewModel> charCards
		{
			[Token(Token = "0x601803F")]
			[Address(RVA = "0x10791A0", Offset = "0x1077DA0", VA = "0x1810791A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x06018040 RID: 98368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003945")]
		public UniEquipArchiveCharacterSortViewModel sortModel
		{
			[Token(Token = "0x6018040")]
			[Address(RVA = "0x1079200", Offset = "0x1077E00", VA = "0x181079200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018041 RID: 98369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018041")]
		[Address(RVA = "0x10786E0", Offset = "0x10772E0", VA = "0x1810786E0")]
		public void LoadData(ref HashSet<string> validSubProfIds, out int trackNum)
		{
		}

		// Token: 0x06018042 RID: 98370 RVA: 0x00098F10 File Offset: 0x00097110
		[Token(Token = "0x6018042")]
		[Address(RVA = "0x1078E60", Offset = "0x1077A60", VA = "0x181078E60")]
		private int _SortViewModel(UniEquipArchiveCharacterItemViewModel lhs, UniEquipArchiveCharacterItemViewModel rhs)
		{
			return 0;
		}

		// Token: 0x06018043 RID: 98371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018043")]
		[Address(RVA = "0x1078660", Offset = "0x1077260", VA = "0x181078660")]
		public void ApplySortType(CharacterSortType sortType)
		{
		}

		// Token: 0x06018044 RID: 98372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018044")]
		[Address(RVA = "0x10785D0", Offset = "0x10771D0", VA = "0x1810785D0")]
		public void ApplySortStarMark(bool hasStarMark)
		{
		}

		// Token: 0x06018045 RID: 98373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018045")]
		[Address(RVA = "0x10782B0", Offset = "0x1076EB0", VA = "0x1810782B0")]
		public void ApplyProfFilterParam(UICharacterProfessionFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x06018046 RID: 98374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018046")]
		[Address(RVA = "0x1078230", Offset = "0x1076E30", VA = "0x181078230")]
		public void ApplyEquipFilterParam(UniEquipArchiveFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x06018047 RID: 98375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018047")]
		[Address(RVA = "0x1078330", Offset = "0x1076F30", VA = "0x181078330")]
		public void ApplySortFilter()
		{
		}

		// Token: 0x06018048 RID: 98376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018048")]
		[Address(RVA = "0x1079030", Offset = "0x1077C30", VA = "0x181079030")]
		public UniEquipArchiveCharacterViewModel()
		{
		}

		// Token: 0x0401D1CF RID: 119247
		[Token(Token = "0x401D1CF")]
		[FieldOffset(Offset = "0x10")]
		private List<UniEquipArchiveCharacterItemViewModel> m_charCards;

		// Token: 0x0401D1D0 RID: 119248
		[Token(Token = "0x401D1D0")]
		[FieldOffset(Offset = "0x18")]
		private List<UniEquipArchiveCharacterItemViewModel> m_sortFilteredCharCards;

		// Token: 0x0401D1D1 RID: 119249
		[Token(Token = "0x401D1D1")]
		[FieldOffset(Offset = "0x20")]
		private UniEquipArchiveCharacterSortViewModel m_sortModel;

		// Token: 0x0401D1D2 RID: 119250
		[Token(Token = "0x401D1D2")]
		[FieldOffset(Offset = "0x28")]
		private UICharacterProfessionFilterHolder.FilterParam m_profFilterParam;

		// Token: 0x0401D1D3 RID: 119251
		[Token(Token = "0x401D1D3")]
		[FieldOffset(Offset = "0x30")]
		private UniEquipArchiveFilterHolder.FilterParam m_equipFilterParam;

		// Token: 0x0401D1D4 RID: 119252
		[Token(Token = "0x401D1D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charCards;

		// Token: 0x0401D1D5 RID: 119253
		[Token(Token = "0x401D1D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sortModel;

		// Token: 0x0401D1D6 RID: 119254
		[Token(Token = "0x401D1D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D1D7 RID: 119255
		[Token(Token = "0x401D1D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SortViewModel;

		// Token: 0x0401D1D8 RID: 119256
		[Token(Token = "0x401D1D8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplySortType;

		// Token: 0x0401D1D9 RID: 119257
		[Token(Token = "0x401D1D9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplySortStarMark;

		// Token: 0x0401D1DA RID: 119258
		[Token(Token = "0x401D1DA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyProfFilterParam;

		// Token: 0x0401D1DB RID: 119259
		[Token(Token = "0x401D1DB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ApplyEquipFilterParam;

		// Token: 0x0401D1DC RID: 119260
		[Token(Token = "0x401D1DC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplySortFilter;

		// Token: 0x0401D1DD RID: 119261
		[Token(Token = "0x401D1DD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
