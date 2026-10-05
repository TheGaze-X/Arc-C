using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C73 RID: 7283
	[Token(Token = "0x2001C73")]
	public class StationCharGroupViewModel
	{
		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x0600B4E8 RID: 46312 RVA: 0x00044B20 File Offset: 0x00042D20
		[Token(Token = "0x170015BE")]
		public BuildingData.RoomType roomType
		{
			[Token(Token = "0x600B4E8")]
			[Address(RVA = "0x32FB7F0", Offset = "0x32FA3F0", VA = "0x1832FB7F0")]
			get
			{
				return BuildingData.RoomType.NONE;
			}
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4E9")]
		[Address(RVA = "0x32FAA70", Offset = "0x32F9670", VA = "0x1832FAA70")]
		public void LoadData(Dictionary<int, StationCharViewModel> rawChars, RoomSlotModel selectedRoom, List<int> selectedInsts, int maxSelectCount)
		{
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x0600B4EA RID: 46314 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B4EB RID: 46315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015BF")]
		public StationCharViewModel focusedChar
		{
			[Token(Token = "0x600B4EA")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600B4EB")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x00044B38 File Offset: 0x00042D38
		[Token(Token = "0x600B4EC")]
		[Address(RVA = "0x32FA940", Offset = "0x32F9540", VA = "0x1832FA940")]
		public bool AddSelectedChar(int instId)
		{
			return default(bool);
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x00044B50 File Offset: 0x00042D50
		[Token(Token = "0x600B4ED")]
		[Address(RVA = "0x32FAD10", Offset = "0x32F9910", VA = "0x1832FAD10")]
		public bool RemoveSelectedChar(int instId)
		{
			return default(bool);
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x0600B4EE RID: 46318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015C0")]
		public ListDict<int, StationCharViewModel> selectedChars
		{
			[Token(Token = "0x600B4EE")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x0600B4EF RID: 46319 RVA: 0x00044B68 File Offset: 0x00042D68
		[Token(Token = "0x170015C1")]
		public int maxSelectCount
		{
			[Token(Token = "0x600B4EF")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x0600B4F0 RID: 46320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015C2")]
		public Dictionary<int, StationCharViewModel> rawChars
		{
			[Token(Token = "0x600B4F0")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x0600B4F1 RID: 46321 RVA: 0x00044B80 File Offset: 0x00042D80
		// (set) Token: 0x0600B4F2 RID: 46322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170015C3")]
		public StationOrderStruct orderStruct
		{
			[Token(Token = "0x600B4F1")]
			[Address(RVA = "0x32FB1B0", Offset = "0x32F9DB0", VA = "0x1832FB1B0")]
			get
			{
				return default(StationOrderStruct);
			}
			[Token(Token = "0x600B4F2")]
			[Address(RVA = "0x32FB810", Offset = "0x32FA410", VA = "0x1832FB810")]
			set
			{
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x0600B4F3 RID: 46323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015C4")]
		public List<StationCharViewModel> restrictedList
		{
			[Token(Token = "0x600B4F3")]
			[Address(RVA = "0x32FB1D0", Offset = "0x32F9DD0", VA = "0x1832FB1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x0600B4F4 RID: 46324 RVA: 0x00044B98 File Offset: 0x00042D98
		[Token(Token = "0x170015C5")]
		public int initSeq
		{
			[Token(Token = "0x600B4F4")]
			[Address(RVA = "0x32FB190", Offset = "0x32F9D90", VA = "0x1832FB190")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F5")]
		[Address(RVA = "0x32FAD00", Offset = "0x32F9900", VA = "0x1832FAD00")]
		public void NotifyInit()
		{
		}

		// Token: 0x0600B4F6 RID: 46326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F6")]
		[Address(RVA = "0x32FACA0", Offset = "0x32F98A0", VA = "0x1832FACA0")]
		public void NotifyFilterChanged(CharacterProfessionFilterParam param)
		{
		}

		// Token: 0x0600B4F7 RID: 46327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F7")]
		[Address(RVA = "0x32FAD70", Offset = "0x32F9970", VA = "0x1832FAD70")]
		private void _LoadSortTypeByRoomType()
		{
		}

		// Token: 0x0600B4F8 RID: 46328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F8")]
		[Address(RVA = "0x32FAFF0", Offset = "0x32F9BF0", VA = "0x1832FAFF0")]
		public StationCharGroupViewModel()
		{
		}

		// Token: 0x0400B0EA RID: 45290
		[Token(Token = "0x400B0EA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StationOrderStruct SORT_WORK_DECREASE_ORDER;

		// Token: 0x0400B0EB RID: 45291
		[Token(Token = "0x400B0EB")]
		[FieldOffset(Offset = "0xC")]
		public static readonly StationOrderStruct SORT_AP_INCREASE_ORDER;

		// Token: 0x0400B0EC RID: 45292
		[Token(Token = "0x400B0EC")]
		[FieldOffset(Offset = "0x10")]
		public bool isProfessionFilterPanelShow;

		// Token: 0x0400B0ED RID: 45293
		[Token(Token = "0x400B0ED")]
		[FieldOffset(Offset = "0x11")]
		public bool isStationFilterPanelShow;

		// Token: 0x0400B0EE RID: 45294
		[Token(Token = "0x400B0EE")]
		[FieldOffset(Offset = "0x14")]
		public CharacterSortType sortType;

		// Token: 0x0400B0EF RID: 45295
		[Token(Token = "0x400B0EF")]
		[FieldOffset(Offset = "0x18")]
		public StationSelectStateBean.StationSelectStateBeanInputType selectType;

		// Token: 0x0400B0F0 RID: 45296
		[Token(Token = "0x400B0F0")]
		[FieldOffset(Offset = "0x20")]
		public UICharacterProfessionFilterHolder.FilterParam professionFilterViewModel;

		// Token: 0x0400B0F1 RID: 45297
		[Token(Token = "0x400B0F1")]
		[FieldOffset(Offset = "0x28")]
		public HashSet<string> sortTypeNeedShow;

		// Token: 0x0400B0F2 RID: 45298
		[Token(Token = "0x400B0F2")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<int, StationCharViewModel> m_selectedChars;

		// Token: 0x0400B0F3 RID: 45299
		[Token(Token = "0x400B0F3")]
		[FieldOffset(Offset = "0x38")]
		private StationOrderStruct m_orderStruct;

		// Token: 0x0400B0F4 RID: 45300
		[Token(Token = "0x400B0F4")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, StationCharViewModel> m_rawChars;

		// Token: 0x0400B0F5 RID: 45301
		[Token(Token = "0x400B0F5")]
		[FieldOffset(Offset = "0x50")]
		private RoomSlotModel m_selectedRoom;

		// Token: 0x0400B0F6 RID: 45302
		[Token(Token = "0x400B0F6")]
		[FieldOffset(Offset = "0x58")]
		private int m_maxSelectCount;

		// Token: 0x0400B0F7 RID: 45303
		[Token(Token = "0x400B0F7")]
		[FieldOffset(Offset = "0x5C")]
		private int m_initSeq;

		// Token: 0x0400B0F9 RID: 45305
		[Token(Token = "0x400B0F9")]
		[FieldOffset(Offset = "0x68")]
		private List<StationCharViewModel> m_cachedList;
	}
}
