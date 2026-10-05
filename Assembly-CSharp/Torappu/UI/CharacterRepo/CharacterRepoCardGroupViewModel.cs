using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E2E RID: 24110
	[Token(Token = "0x2005E2E")]
	public class CharacterRepoCardGroupViewModel
	{
		// Token: 0x170052CE RID: 21198
		// (get) Token: 0x06022F02 RID: 143106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170052CE")]
		public CharacterCardGroupViewModel cardGroup
		{
			[Token(Token = "0x6022F02")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170052CF RID: 21199
		// (get) Token: 0x06022F03 RID: 143107 RVA: 0x000BF850 File Offset: 0x000BDA50
		// (set) Token: 0x06022F04 RID: 143108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052CF")]
		public int unfinishedCharStageCnt
		{
			[Token(Token = "0x6022F03")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6022F04")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x06022F05 RID: 143109 RVA: 0x000BF868 File Offset: 0x000BDA68
		[Token(Token = "0x6022F05")]
		[Address(RVA = "0x1D77450", Offset = "0x1D76050", VA = "0x181D77450")]
		public CharacterHandbookStageStatus GetStageStatus(int instId)
		{
			return CharacterHandbookStageStatus.NONE;
		}

		// Token: 0x06022F06 RID: 143110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F06")]
		[Address(RVA = "0x1D774C0", Offset = "0x1D760C0", VA = "0x181D774C0")]
		public void OverrideCharListSort(List<CharacterCardViewModel> charList, CharacterSortType sortType, Action<List<CharacterCardViewModel>, CharacterSortType> selfCharListSort)
		{
		}

		// Token: 0x06022F07 RID: 143111 RVA: 0x000BF880 File Offset: 0x000BDA80
		[Token(Token = "0x6022F07")]
		[Address(RVA = "0x1D77780", Offset = "0x1D76380", VA = "0x181D77780")]
		private int _CompareByHandbookStageUp(CharacterCardViewModel a, CharacterCardViewModel b)
		{
			return 0;
		}

		// Token: 0x06022F08 RID: 143112 RVA: 0x000BF898 File Offset: 0x000BDA98
		[Token(Token = "0x6022F08")]
		[Address(RVA = "0x1D77620", Offset = "0x1D76220", VA = "0x181D77620")]
		private int _CompareByHandbookStageDown(CharacterCardViewModel a, CharacterCardViewModel b)
		{
			return 0;
		}

		// Token: 0x06022F09 RID: 143113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F09")]
		[Address(RVA = "0x1D778E0", Offset = "0x1D764E0", VA = "0x181D778E0")]
		public CharacterRepoCardGroupViewModel()
		{
		}

		// Token: 0x0403020F RID: 197135
		[Token(Token = "0x403020F")]
		[FieldOffset(Offset = "0x10")]
		private CharacterCardGroupViewModel m_cardGroup;

		// Token: 0x04030210 RID: 197136
		[Token(Token = "0x4030210")]
		[FieldOffset(Offset = "0x18")]
		private int m_unfinishedCharStageCount;

		// Token: 0x04030211 RID: 197137
		[Token(Token = "0x4030211")]
		[FieldOffset(Offset = "0x20")]
		private Comparison<BasicCharInfoModel> m_cachedDefaultComparison;

		// Token: 0x04030212 RID: 197138
		[Token(Token = "0x4030212")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<int, CharacterHandbookStageStatus> charStageStatusDict;

		// Token: 0x04030213 RID: 197139
		[Token(Token = "0x4030213")]
		[FieldOffset(Offset = "0x30")]
		public bool disableLockAndInSquad;
	}
}
