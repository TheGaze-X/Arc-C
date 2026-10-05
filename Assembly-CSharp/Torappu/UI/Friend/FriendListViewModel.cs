using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D6F RID: 19823
	[Token(Token = "0x2004D6F")]
	public class FriendListViewModel
	{
		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x0601DAAC RID: 121516 RVA: 0x000AC2D8 File Offset: 0x000AA4D8
		[Token(Token = "0x1700458A")]
		public bool isInStarEditMode
		{
			[Token(Token = "0x601DAAC")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x0601DAAD RID: 121517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700458B")]
		public Dictionary<string, FriendListViewModel.FriendSortInfo> sortInfoDict
		{
			[Token(Token = "0x601DAAD")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x0601DAAE RID: 121518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700458C")]
		public List<string> editStartFriendList
		{
			[Token(Token = "0x601DAAE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x0601DAAF RID: 121519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700458D")]
		public List<string> currStarFriendList
		{
			[Token(Token = "0x601DAAF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x0601DAB0 RID: 121520 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DAB1 RID: 121521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700458E")]
		public List<FriendData> myFriendsList
		{
			[Token(Token = "0x601DAB0")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x601DAB1")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x0601DAB2 RID: 121522 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DAB3 RID: 121523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700458F")]
		public List<FriendData> friendSearchResult
		{
			[Token(Token = "0x601DAB2")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x601DAB3")]
			[Address(RVA = "0x1743370", Offset = "0x1741F70", VA = "0x181743370")]
			set
			{
			}
		}

		// Token: 0x17004590 RID: 17808
		// (get) Token: 0x0601DAB4 RID: 121524 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DAB5 RID: 121525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004590")]
		public List<FriendData> friendRequestList
		{
			[Token(Token = "0x601DAB4")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x601DAB5")]
			[Address(RVA = "0x1743340", Offset = "0x1741F40", VA = "0x181743340")]
			set
			{
			}
		}

		// Token: 0x17004591 RID: 17809
		// (get) Token: 0x0601DAB6 RID: 121526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004591")]
		public List<FriendSortViewModel> myFriendsIdList
		{
			[Token(Token = "0x601DAB6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DAB7 RID: 121527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAB7")]
		[Address(RVA = "0x1741C00", Offset = "0x1740800", VA = "0x181741C00")]
		public void ChangeStarEditMode(bool isInEdit)
		{
		}

		// Token: 0x0601DAB8 RID: 121528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAB8")]
		[Address(RVA = "0x1741D20", Offset = "0x1740920", VA = "0x181741D20")]
		public void ClearEditStarList()
		{
		}

		// Token: 0x0601DAB9 RID: 121529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAB9")]
		[Address(RVA = "0x17423E0", Offset = "0x1740FE0", VA = "0x1817423E0")]
		public void RefreshFriendIdList(List<FriendSortViewModel> originList, List<string> starFriendList)
		{
		}

		// Token: 0x0601DABA RID: 121530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DABA")]
		[Address(RVA = "0x1741D90", Offset = "0x1740990", VA = "0x181741D90")]
		public void DeleteFriend(string uid)
		{
		}

		// Token: 0x0601DABB RID: 121531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DABB")]
		[Address(RVA = "0x1742660", Offset = "0x1741260", VA = "0x181742660")]
		public void RefreshStarFriendList(List<string> starFriendList)
		{
		}

		// Token: 0x0601DABC RID: 121532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DABC")]
		[Address(RVA = "0x1742EE0", Offset = "0x1741AE0", VA = "0x181742EE0")]
		private void _RefreshStarFriendList(List<string> starFriendList)
		{
		}

		// Token: 0x0601DABD RID: 121533 RVA: 0x000AC2F0 File Offset: 0x000AA4F0
		[Token(Token = "0x601DABD")]
		[Address(RVA = "0x1742BF0", Offset = "0x17417F0", VA = "0x181742BF0")]
		public bool TryToggleEditStarStatus(string uid, out string hintToast)
		{
			return default(bool);
		}

		// Token: 0x0601DABE RID: 121534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DABE")]
		[Address(RVA = "0x1742A70", Offset = "0x1741670", VA = "0x181742A70")]
		public FriendSortViewModel SearchSortViewModelByUid(string uid)
		{
			return null;
		}

		// Token: 0x0601DABF RID: 121535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DABF")]
		[Address(RVA = "0x1742920", Offset = "0x1741520", VA = "0x181742920")]
		public FriendSortViewModel SearchSearchSortViewModelByUid(string uid)
		{
			return null;
		}

		// Token: 0x0601DAC0 RID: 121536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DAC0")]
		[Address(RVA = "0x17427D0", Offset = "0x17413D0", VA = "0x1817427D0")]
		public FriendSortViewModel SearchRequestSortViewModelByUid(string uid)
		{
			return null;
		}

		// Token: 0x0601DAC1 RID: 121537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DAC1")]
		[Address(RVA = "0x1742060", Offset = "0x1740C60", VA = "0x181742060")]
		public List<FriendAssistCharData> LoadFriendAssistViewDatas()
		{
			return null;
		}

		// Token: 0x0601DAC2 RID: 121538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DAC2")]
		[Address(RVA = "0x1741FA0", Offset = "0x1740BA0", VA = "0x181741FA0")]
		public UISquadEditCharModel[] GetEditingAssists()
		{
			return null;
		}

		// Token: 0x0601DAC3 RID: 121539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAC3")]
		[Address(RVA = "0x1742BC0", Offset = "0x17417C0", VA = "0x181742BC0")]
		public void SetEditingAssists(UISquadEditCharModel[] setVal)
		{
		}

		// Token: 0x0601DAC4 RID: 121540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAC4")]
		[Address(RVA = "0x1742EA0", Offset = "0x1741AA0", VA = "0x181742EA0")]
		public void UpdateEditingAssists(out bool tmplChange)
		{
		}

		// Token: 0x17004592 RID: 17810
		// (get) Token: 0x0601DAC5 RID: 121541 RVA: 0x000AC308 File Offset: 0x000AA508
		[Token(Token = "0x17004592")]
		public int friendCount
		{
			[Token(Token = "0x601DAC5")]
			[Address(RVA = "0x1743280", Offset = "0x1741E80", VA = "0x181743280")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004593 RID: 17811
		// (get) Token: 0x0601DAC6 RID: 121542 RVA: 0x000AC320 File Offset: 0x000AA520
		[Token(Token = "0x17004593")]
		public int friendSearchCount
		{
			[Token(Token = "0x601DAC6")]
			[Address(RVA = "0x1743300", Offset = "0x1741F00", VA = "0x181743300")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004594 RID: 17812
		// (get) Token: 0x0601DAC7 RID: 121543 RVA: 0x000AC338 File Offset: 0x000AA538
		[Token(Token = "0x17004594")]
		public int friendRequestCount
		{
			[Token(Token = "0x601DAC7")]
			[Address(RVA = "0x17432C0", Offset = "0x1741EC0", VA = "0x1817432C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601DAC8 RID: 121544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAC8")]
		[Address(RVA = "0x17423D0", Offset = "0x1740FD0", VA = "0x1817423D0")]
		public void MarkAssitListDataDirty()
		{
		}

		// Token: 0x0601DAC9 RID: 121545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAC9")]
		[Address(RVA = "0x1741AF0", Offset = "0x17406F0", VA = "0x181741AF0")]
		public void ApplyAssist(int selectedCharacterIndex, int chrInstId, string skillId, string equipId)
		{
		}

		// Token: 0x0601DACA RID: 121546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DACA")]
		[Address(RVA = "0x1741CB0", Offset = "0x17408B0", VA = "0x181741CB0")]
		public void CleanAssist(int selectedIndex)
		{
		}

		// Token: 0x0601DACB RID: 121547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DACB")]
		[Address(RVA = "0x1741A00", Offset = "0x1740600", VA = "0x181741A00")]
		public void ApplyAssistSkill(int selectedIndex, string skillId)
		{
		}

		// Token: 0x0601DACC RID: 121548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DACC")]
		[Address(RVA = "0x1741910", Offset = "0x1740510", VA = "0x181741910")]
		public void ApplyAssistEquip(int selectedIndex, string equipId)
		{
		}

		// Token: 0x0601DACD RID: 121549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DACD")]
		[Address(RVA = "0x1742F70", Offset = "0x1741B70", VA = "0x181742F70")]
		public FriendListViewModel()
		{
		}

		// Token: 0x04027327 RID: 160551
		[Token(Token = "0x4027327")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, FriendListViewModel.FriendSortInfo> m_sortInfoDict;

		// Token: 0x04027328 RID: 160552
		[Token(Token = "0x4027328")]
		[FieldOffset(Offset = "0x18")]
		private List<FriendSortViewModel> m_friendIdList;

		// Token: 0x04027329 RID: 160553
		[Token(Token = "0x4027329")]
		[FieldOffset(Offset = "0x20")]
		private List<string> m_editStarFriendList;

		// Token: 0x0402732A RID: 160554
		[Token(Token = "0x402732A")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_currStarFriendList;

		// Token: 0x0402732B RID: 160555
		[Token(Token = "0x402732B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInStarEditMode;

		// Token: 0x0402732C RID: 160556
		[Token(Token = "0x402732C")]
		[FieldOffset(Offset = "0x38")]
		public List<FriendSortViewModel> friendSearchIdList;

		// Token: 0x0402732D RID: 160557
		[Token(Token = "0x402732D")]
		[FieldOffset(Offset = "0x40")]
		public List<FriendSortViewModel> friendRequestIdList;

		// Token: 0x0402732E RID: 160558
		[Token(Token = "0x402732E")]
		[FieldOffset(Offset = "0x48")]
		public List<FriendStatus> friendSearchState;

		// Token: 0x0402732F RID: 160559
		[Token(Token = "0x402732F")]
		[FieldOffset(Offset = "0x50")]
		public List<string> friendAlias;

		// Token: 0x04027330 RID: 160560
		[Token(Token = "0x4027330")]
		[FieldOffset(Offset = "0x58")]
		private List<FriendData> m_myFriendsList;

		// Token: 0x04027331 RID: 160561
		[Token(Token = "0x4027331")]
		[FieldOffset(Offset = "0x60")]
		private List<FriendData> m_friendRequestList;

		// Token: 0x04027332 RID: 160562
		[Token(Token = "0x4027332")]
		[FieldOffset(Offset = "0x68")]
		private List<FriendData> m_friendSearchResult;

		// Token: 0x04027333 RID: 160563
		[Token(Token = "0x4027333")]
		[FieldOffset(Offset = "0x70")]
		public SharedCharData[] mySharedChar;

		// Token: 0x04027334 RID: 160564
		[Token(Token = "0x4027334")]
		[FieldOffset(Offset = "0x78")]
		private UISquadEditCharModel[] m_editingAssists;

		// Token: 0x04027335 RID: 160565
		[Token(Token = "0x4027335")]
		[FieldOffset(Offset = "0x80")]
		public string friendSearchData;

		// Token: 0x04027336 RID: 160566
		[Token(Token = "0x4027336")]
		[FieldOffset(Offset = "0x88")]
		public bool myFriendsListChangeFlag;

		// Token: 0x04027337 RID: 160567
		[Token(Token = "0x4027337")]
		[FieldOffset(Offset = "0x89")]
		public bool friendRequestListChangeFlag;

		// Token: 0x04027338 RID: 160568
		[Token(Token = "0x4027338")]
		[FieldOffset(Offset = "0x8A")]
		public bool friendSearchResultChangeFlag;

		// Token: 0x04027339 RID: 160569
		[Token(Token = "0x4027339")]
		[FieldOffset(Offset = "0x8B")]
		public bool myFriendsListRefreshFlag;

		// Token: 0x0402733A RID: 160570
		[Token(Token = "0x402733A")]
		[FieldOffset(Offset = "0x8C")]
		public bool friendRequestListRefreshFlag;

		// Token: 0x0402733B RID: 160571
		[Token(Token = "0x402733B")]
		[FieldOffset(Offset = "0x8D")]
		public bool friendSearchResultRefreshFlag;

		// Token: 0x0402733C RID: 160572
		[Token(Token = "0x402733C")]
		[FieldOffset(Offset = "0x8E")]
		public bool friendAssistChangeFlag;

		// Token: 0x0402733D RID: 160573
		[Token(Token = "0x402733D")]
		[FieldOffset(Offset = "0x8F")]
		public bool friendAssistUnSaveFlag;

		// Token: 0x0402733E RID: 160574
		[Token(Token = "0x402733E")]
		[FieldOffset(Offset = "0x90")]
		public bool friendAssistFloatPanelShowFlag;

		// Token: 0x0402733F RID: 160575
		[Token(Token = "0x402733F")]
		[FieldOffset(Offset = "0x94")]
		public int friendAssistFloatPanelFocusedIndex;

		// Token: 0x04027340 RID: 160576
		[Token(Token = "0x4027340")]
		[FieldOffset(Offset = "0x98")]
		public string friendAssistFloatPanelSelectedId;

		// Token: 0x04027341 RID: 160577
		[Token(Token = "0x4027341")]
		[FieldOffset(Offset = "0xA0")]
		public FriendAssistItemFloatPanel.ItemType friendAssistFloatPanelShowType;

		// Token: 0x02004D70 RID: 19824
		[Token(Token = "0x2004D70")]
		public class FriendSortInfo
		{
			// Token: 0x0601DACF RID: 121551 RVA: 0x000AC368 File Offset: 0x000AA568
			[Token(Token = "0x601DACF")]
			[Address(RVA = "0x17433A0", Offset = "0x1741FA0", VA = "0x1817433A0")]
			public int CompareTo(FriendListViewModel.FriendSortInfo sortInfo)
			{
				return 0;
			}

			// Token: 0x0601DAD0 RID: 121552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DAD0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FriendSortInfo()
			{
			}

			// Token: 0x04027342 RID: 160578
			[Token(Token = "0x4027342")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x04027343 RID: 160579
			[Token(Token = "0x4027343")]
			[FieldOffset(Offset = "0x18")]
			public int level;

			// Token: 0x04027344 RID: 160580
			[Token(Token = "0x4027344")]
			[FieldOffset(Offset = "0x1C")]
			public bool isStar;

			// Token: 0x04027345 RID: 160581
			[Token(Token = "0x4027345")]
			[FieldOffset(Offset = "0x20")]
			public int origIndex;
		}
	}
}
