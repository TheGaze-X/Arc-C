using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020034FE RID: 13566
	[Token(Token = "0x20034FE")]
	public class CharacterCardGroupViewModel
	{
		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x06015A1F RID: 88607 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015A20 RID: 88608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003342")]
		public Action<List<CharacterCardViewModel>, CharacterSortType, Action<List<CharacterCardViewModel>, CharacterSortType>> overrideCharListSort
		{
			[Token(Token = "0x6015A1F")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6015A20")]
			[Address(RVA = "0xE31CC0", Offset = "0xE308C0", VA = "0x180E31CC0")]
			set
			{
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x06015A21 RID: 88609 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015A22 RID: 88610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003343")]
		public List<CharacterCardViewModel> dataSource
		{
			[Token(Token = "0x6015A21")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6015A22")]
			[Address(RVA = "0xE31C00", Offset = "0xE30800", VA = "0x180E31C00")]
			set
			{
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x06015A23 RID: 88611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003344")]
		public Dictionary<string, CharacterTrackPointData> charId2TrackPointDataMap
		{
			[Token(Token = "0x6015A23")]
			[Address(RVA = "0xE31B70", Offset = "0xE30770", VA = "0x180E31B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x06015A24 RID: 88612 RVA: 0x0008D120 File Offset: 0x0008B320
		// (set) Token: 0x06015A25 RID: 88613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003345")]
		public CharacterSortType sortType
		{
			[Token(Token = "0x6015A24")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			get
			{
				return CharacterSortType.BY_LEVEL_UP;
			}
			[Token(Token = "0x6015A25")]
			[Address(RVA = "0xE31CF0", Offset = "0xE308F0", VA = "0x180E31CF0")]
			set
			{
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x06015A26 RID: 88614 RVA: 0x0008D138 File Offset: 0x0008B338
		// (set) Token: 0x06015A27 RID: 88615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003346")]
		public bool isStarMarkTopSelected
		{
			[Token(Token = "0x6015A26")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015A27")]
			[Address(RVA = "0xE31C80", Offset = "0xE30880", VA = "0x180E31C80")]
			set
			{
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x06015A28 RID: 88616 RVA: 0x0008D150 File Offset: 0x0008B350
		// (set) Token: 0x06015A29 RID: 88617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003347")]
		public bool isEnableStarMarkEdit
		{
			[Token(Token = "0x6015A28")]
			[Address(RVA = "0xE31BA0", Offset = "0xE307A0", VA = "0x180E31BA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015A29")]
			[Address(RVA = "0xE31C40", Offset = "0xE30840", VA = "0x180E31C40")]
			set
			{
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x06015A2A RID: 88618 RVA: 0x0008D168 File Offset: 0x0008B368
		// (set) Token: 0x06015A2B RID: 88619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003348")]
		public bool isTrackPointFilterSelected
		{
			[Token(Token = "0x6015A2A")]
			[Address(RVA = "0xE31BC0", Offset = "0xE307C0", VA = "0x180E31BC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015A2B")]
			[Address(RVA = "0xE31CA0", Offset = "0xE308A0", VA = "0x180E31CA0")]
			set
			{
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x06015A2C RID: 88620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003349")]
		public HashSet<string> validSubProfIds
		{
			[Token(Token = "0x6015A2C")]
			[Address(RVA = "0xE31BE0", Offset = "0xE307E0", VA = "0x180E31BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015A2D RID: 88621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A2D")]
		[Address(RVA = "0xE30720", Offset = "0xE2F320", VA = "0x180E30720")]
		public void NotifyFilterChanged(CharacterProfessionFilterParam filterParam)
		{
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x06015A2E RID: 88622 RVA: 0x0008D180 File Offset: 0x0008B380
		[Token(Token = "0x1700334A")]
		public int enterSeq
		{
			[Token(Token = "0x6015A2E")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06015A2F RID: 88623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A2F")]
		[Address(RVA = "0xE30710", Offset = "0xE2F310", VA = "0x180E30710")]
		public void NotifyEnter()
		{
		}

		// Token: 0x06015A30 RID: 88624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A30")]
		[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
		public void ResetEnterSeq(int seq)
		{
		}

		// Token: 0x06015A31 RID: 88625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A31")]
		[Address(RVA = "0xE30AE0", Offset = "0xE2F6E0", VA = "0x180E30AE0")]
		private List<CharacterCardViewModel> _AchieveSortedAndFilteredCharacters(Func<CharacterCardViewModel, bool> filterWhiteList)
		{
			return null;
		}

		// Token: 0x06015A32 RID: 88626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A32")]
		[Address(RVA = "0xE308A0", Offset = "0xE2F4A0", VA = "0x180E308A0")]
		private Dictionary<string, CharacterTrackPointData> _AchieveCharTrackPointMap()
		{
			return null;
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x06015A33 RID: 88627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700334B")]
		public List<CharacterCardViewModel> cardList
		{
			[Token(Token = "0x6015A33")]
			[Address(RVA = "0xE31B30", Offset = "0xE30730", VA = "0x180E31B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015A34 RID: 88628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A34")]
		[Address(RVA = "0xE31160", Offset = "0xE2FD60", VA = "0x180E31160")]
		private List<CharacterCardViewModel> _ProcessSelectedCharTopMode(bool isStarTopMode = false)
		{
			return null;
		}

		// Token: 0x06015A35 RID: 88629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A35")]
		[Address(RVA = "0xE313D0", Offset = "0xE2FFD0", VA = "0x180E313D0")]
		private List<CharacterCardViewModel> _ProcessStarMarkCharTopMode(List<CharacterCardViewModel> cardList)
		{
			return null;
		}

		// Token: 0x06015A36 RID: 88630 RVA: 0x0008D198 File Offset: 0x0008B398
		[Token(Token = "0x6015A36")]
		[Address(RVA = "0xE310D0", Offset = "0xE2FCD0", VA = "0x180E310D0")]
		private bool _IsCardSelectedOrStarMarked(CharacterCardViewModel cardModel)
		{
			return default(bool);
		}

		// Token: 0x06015A37 RID: 88631 RVA: 0x0008D1B0 File Offset: 0x0008B3B0
		[Token(Token = "0x6015A37")]
		[Address(RVA = "0xE30F30", Offset = "0xE2FB30", VA = "0x180E30F30")]
		private int _FindCardSelectIndex(CharacterCardViewModel cardModel)
		{
			return 0;
		}

		// Token: 0x06015A38 RID: 88632 RVA: 0x0008D1C8 File Offset: 0x0008B3C8
		[Token(Token = "0x6015A38")]
		[Address(RVA = "0xE31050", Offset = "0xE2FC50", VA = "0x180E31050")]
		private bool _GetCardStarMarkSelected(CharacterCardViewModel cardModel)
		{
			return default(bool);
		}

		// Token: 0x06015A39 RID: 88633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A39")]
		[Address(RVA = "0xE316C0", Offset = "0xE302C0", VA = "0x180E316C0")]
		private void _TryUpdateValidSubProfs()
		{
		}

		// Token: 0x06015A3A RID: 88634 RVA: 0x0008D1E0 File Offset: 0x0008B3E0
		[Token(Token = "0x6015A3A")]
		[Address(RVA = "0xE30790", Offset = "0xE2F390", VA = "0x180E30790")]
		public bool StarMarkEditModeAddChar(int chrInstId)
		{
			return default(bool);
		}

		// Token: 0x06015A3B RID: 88635 RVA: 0x0008D1F8 File Offset: 0x0008B3F8
		[Token(Token = "0x6015A3B")]
		[Address(RVA = "0xE30840", Offset = "0xE2F440", VA = "0x180E30840")]
		public bool StarMarkEditModeRemoveChar(int chrInstId)
		{
			return default(bool);
		}

		// Token: 0x06015A3C RID: 88636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A3C")]
		[Address(RVA = "0xE307F0", Offset = "0xE2F3F0", VA = "0x180E307F0")]
		public void StarMarkEditModeClearChar()
		{
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x06015A3D RID: 88637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015A3E RID: 88638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700334C")]
		public HashSet<int> starMarkedSelectedChrInsts
		{
			[Token(Token = "0x6015A3D")]
			[Address(RVA = "0xE31BD0", Offset = "0xE307D0", VA = "0x180E31BD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6015A3E")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06015A3F RID: 88639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A3F")]
		[Address(RVA = "0xE30DB0", Offset = "0xE2F9B0", VA = "0x180E30DB0")]
		private void _EnsureStarMarkEditList()
		{
		}

		// Token: 0x06015A40 RID: 88640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A40")]
		[Address(RVA = "0xE318F0", Offset = "0xE304F0", VA = "0x180E318F0")]
		public CharacterCardGroupViewModel()
		{
		}

		// Token: 0x04019F1B RID: 106267
		[Token(Token = "0x4019F1B")]
		[FieldOffset(Offset = "0x10")]
		public CharacterProfessionFilterViewModel filter;

		// Token: 0x04019F1C RID: 106268
		[Token(Token = "0x4019F1C")]
		[FieldOffset(Offset = "0x18")]
		public List<int> selectedChrInstIds;

		// Token: 0x04019F1D RID: 106269
		[Token(Token = "0x4019F1D")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<int> m_starMarkSelectedChrInstIds;

		// Token: 0x04019F1E RID: 106270
		[Token(Token = "0x4019F1E")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<int> m_starMarkEditModeChrInstIds;

		// Token: 0x04019F1F RID: 106271
		[Token(Token = "0x4019F1F")]
		[FieldOffset(Offset = "0x30")]
		private List<CharacterCardViewModel> m_characterViewModels;

		// Token: 0x04019F20 RID: 106272
		[Token(Token = "0x4019F20")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<string> m_validSubProfIds;

		// Token: 0x04019F21 RID: 106273
		[Token(Token = "0x4019F21")]
		[FieldOffset(Offset = "0x40")]
		private int m_enterSeq;

		// Token: 0x04019F22 RID: 106274
		[Token(Token = "0x4019F22")]
		[FieldOffset(Offset = "0x48")]
		private List<CharacterCardViewModel> m_cardListCache;

		// Token: 0x04019F23 RID: 106275
		[Token(Token = "0x4019F23")]
		[FieldOffset(Offset = "0x50")]
		private CharacterSortType m_sortTypeCache;

		// Token: 0x04019F24 RID: 106276
		[Token(Token = "0x4019F24")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, CharacterTrackPointData> m_charId2TrackPointDataMapCache;

		// Token: 0x04019F25 RID: 106277
		[Token(Token = "0x4019F25")]
		[FieldOffset(Offset = "0x60")]
		private Action<List<CharacterCardViewModel>, CharacterSortType, Action<List<CharacterCardViewModel>, CharacterSortType>> m_overrideCharListSort;

		// Token: 0x04019F26 RID: 106278
		[Token(Token = "0x4019F26")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isStarMarkTopSelected;

		// Token: 0x04019F27 RID: 106279
		[Token(Token = "0x4019F27")]
		[FieldOffset(Offset = "0x69")]
		private bool m_isEnableStarMarkEdit;

		// Token: 0x04019F28 RID: 106280
		[Token(Token = "0x4019F28")]
		[FieldOffset(Offset = "0x6A")]
		private bool m_isTrackPointFilterSelected;
	}
}
