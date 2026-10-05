using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D2A RID: 7466
	[Token(Token = "0x2001D2A")]
	public class BuildingMeetingSession : IMeetingSession, IHotfixable
	{
		// Token: 0x0600B851 RID: 47185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B851")]
		[Address(RVA = "0x335BE00", Offset = "0x335AA00", VA = "0x18335BE00")]
		public BuildingMeetingSession()
		{
		}

		// Token: 0x0600B852 RID: 47186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B852")]
		[Address(RVA = "0x335AE70", Offset = "0x3359A70", VA = "0x18335AE70")]
		private BuildingMeetingSession.Character _FetchCharacter(int index, ref BuildingMeetingSession.Character cache)
		{
			return null;
		}

		// Token: 0x0600B853 RID: 47187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B853")]
		[Address(RVA = "0x335B5D0", Offset = "0x335A1D0", VA = "0x18335B5D0")]
		private IEnumerable<IMeetingClue> _GetClueList(List<PlayerBuildingMeetingClue> clueList, bool external)
		{
			return null;
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x0600B854 RID: 47188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001636")]
		public IEnumerable<IMeetingClue> storedClues
		{
			[Token(Token = "0x600B854")]
			[Address(RVA = "0x335C8A0", Offset = "0x335B4A0", VA = "0x18335C8A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x0600B855 RID: 47189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001637")]
		public IEnumerable<IMeetingClue> waitingClues
		{
			[Token(Token = "0x600B855")]
			[Address(RVA = "0x335CB50", Offset = "0x335B750", VA = "0x18335CB50", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x0600B856 RID: 47190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001638")]
		public IEnumerable<IPeer> peers
		{
			[Token(Token = "0x600B856")]
			[Address(RVA = "0x335C4C0", Offset = "0x335B0C0", VA = "0x18335C4C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B857 RID: 47191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B857")]
		[Address(RVA = "0x335B820", Offset = "0x335A420", VA = "0x18335B820")]
		private void _UpdateCharacterProduct()
		{
		}

		// Token: 0x0600B858 RID: 47192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B858")]
		[Address(RVA = "0x335BA30", Offset = "0x335A630", VA = "0x18335BA30")]
		private void _UpdateSocialReward(Action<List<ItemBundle>> rewardHandler)
		{
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x0600B859 RID: 47193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001639")]
		public ICharacterClueProduct characterMadeClue
		{
			[Token(Token = "0x600B859")]
			[Address(RVA = "0x335BFB0", Offset = "0x335ABB0", VA = "0x18335BFB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x0600B85A RID: 47194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700163A")]
		public IRoomClueProduct roomMadeClue
		{
			[Token(Token = "0x600B85A")]
			[Address(RVA = "0x335C570", Offset = "0x335B170", VA = "0x18335C570", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B85B RID: 47195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B85B")]
		[Address(RVA = "0x335B6D0", Offset = "0x335A2D0", VA = "0x18335B6D0")]
		private MeetingClueData.ClueTypeData _GetTypeFromNumber(int typeNumber)
		{
			return null;
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x0600B85C RID: 47196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700163B")]
		private PlayerBuildingMeeting meetingRoom
		{
			[Token(Token = "0x600B85C")]
			[Address(RVA = "0x335C360", Offset = "0x335AF60", VA = "0x18335C360")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B85D RID: 47197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B85D")]
		[Address(RVA = "0x335B410", Offset = "0x335A010", VA = "0x18335B410")]
		private PlayerBuildingMeetingClue _GetClueFromId(string id, out bool external)
		{
			return null;
		}

		// Token: 0x0600B85E RID: 47198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B85E")]
		[Address(RVA = "0x3358210", Offset = "0x3356E10", VA = "0x183358210", Slot = "9")]
		public IMeetingClue GetSlotClue(int index)
		{
			return null;
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x0600B85F RID: 47199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700163C")]
		public IMeetingStationaryCharacter stationaryCharacter0
		{
			[Token(Token = "0x600B85F")]
			[Address(RVA = "0x335C7C0", Offset = "0x335B3C0", VA = "0x18335C7C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x0600B860 RID: 47200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700163D")]
		public IMeetingStationaryCharacter stationaryCharacter1
		{
			[Token(Token = "0x600B860")]
			[Address(RVA = "0x335C830", Offset = "0x335B430", VA = "0x18335C830", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x0600B861 RID: 47201 RVA: 0x000453F0 File Offset: 0x000435F0
		[Token(Token = "0x1700163E")]
		public bool hasNewProduct
		{
			[Token(Token = "0x600B861")]
			[Address(RVA = "0x335C0B0", Offset = "0x335ACB0", VA = "0x18335C0B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x0600B862 RID: 47202 RVA: 0x00045408 File Offset: 0x00043608
		[Token(Token = "0x1700163F")]
		public bool hasNewRecv
		{
			[Token(Token = "0x600B862")]
			[Address(RVA = "0x335C160", Offset = "0x335AD60", VA = "0x18335C160", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x0600B863 RID: 47203 RVA: 0x00045420 File Offset: 0x00043620
		[Token(Token = "0x17001640")]
		public bool hasNewSend
		{
			[Token(Token = "0x600B863")]
			[Address(RVA = "0x335C220", Offset = "0x335AE20", VA = "0x18335C220", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x0600B864 RID: 47204 RVA: 0x00045438 File Offset: 0x00043638
		[Token(Token = "0x17001641")]
		public int clueCountNeededForUnlockTransfer
		{
			[Token(Token = "0x600B864")]
			[Address(RVA = "0x335C020", Offset = "0x335AC20", VA = "0x18335C020", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x0600B865 RID: 47205 RVA: 0x00045450 File Offset: 0x00043650
		[Token(Token = "0x17001642")]
		public bool transferring
		{
			[Token(Token = "0x600B865")]
			[Address(RVA = "0x335CAE0", Offset = "0x335B6E0", VA = "0x18335CAE0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x0600B866 RID: 47206 RVA: 0x00045468 File Offset: 0x00043668
		// (set) Token: 0x0600B867 RID: 47207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001643")]
		public int transferringVisitNumber
		{
			[Token(Token = "0x600B866")]
			[Address(RVA = "0x335CA80", Offset = "0x335B680", VA = "0x18335CA80", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B867")]
			[Address(RVA = "0x335CC00", Offset = "0x335B800", VA = "0x18335CC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x0600B868 RID: 47208 RVA: 0x00045480 File Offset: 0x00043680
		[Token(Token = "0x17001644")]
		public int transferringSocialPoint
		{
			[Token(Token = "0x600B868")]
			[Address(RVA = "0x335CA00", Offset = "0x335B600", VA = "0x18335CA00", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x0600B869 RID: 47209 RVA: 0x00045498 File Offset: 0x00043698
		[Token(Token = "0x17001645")]
		public int localStorageCapacity
		{
			[Token(Token = "0x600B869")]
			[Address(RVA = "0x335C2E0", Offset = "0x335AEE0", VA = "0x18335C2E0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x0600B86A RID: 47210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001646")]
		public TransferResult lastTransferResult
		{
			[Token(Token = "0x600B86A")]
			[Address(RVA = "0x335C280", Offset = "0x335AE80", VA = "0x18335C280", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x0600B86B RID: 47211 RVA: 0x000454B0 File Offset: 0x000436B0
		[Token(Token = "0x17001647")]
		public DateTime transferExpireTime
		{
			[Token(Token = "0x600B86B")]
			[Address(RVA = "0x335C950", Offset = "0x335B550", VA = "0x18335C950", Slot = "21")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0600B86C RID: 47212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001648")]
		public string slotId
		{
			[Token(Token = "0x600B86C")]
			[Address(RVA = "0x335C740", Offset = "0x335B340", VA = "0x18335C740", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x0600B86D RID: 47213 RVA: 0x000454C8 File Offset: 0x000436C8
		[Token(Token = "0x17001649")]
		public bool needReceiveTransferReward
		{
			[Token(Token = "0x600B86D")]
			[Address(RVA = "0x335C440", Offset = "0x335B040", VA = "0x18335C440", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x000454E0 File Offset: 0x000436E0
		[Token(Token = "0x600B86E")]
		[Address(RVA = "0x3358B80", Offset = "0x3357780", VA = "0x183358B80", Slot = "25")]
		public bool IsPeerStarFriend(string uid)
		{
			return default(bool);
		}

		// Token: 0x0600B86F RID: 47215 RVA: 0x000454F8 File Offset: 0x000436F8
		[Token(Token = "0x600B86F")]
		[Address(RVA = "0x3359100", Offset = "0x3357D00", VA = "0x183359100", Slot = "23")]
		public int ReceiveBonus(int count)
		{
			return 0;
		}

		// Token: 0x0600B870 RID: 47216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B870")]
		[Address(RVA = "0x3357ED0", Offset = "0x3356AD0", VA = "0x183357ED0", Slot = "26")]
		public void EquipClue(IMeetingClue clue, Action<int> resultHandler)
		{
		}

		// Token: 0x0600B871 RID: 47217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B871")]
		[Address(RVA = "0x3357990", Offset = "0x3356590", VA = "0x183357990", Slot = "27")]
		public void AutoEquipClue(Action<int, int> resultHandler)
		{
		}

		// Token: 0x0600B872 RID: 47218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B872")]
		[Address(RVA = "0x335A3A0", Offset = "0x3358FA0", VA = "0x18335A3A0", Slot = "28")]
		public void UnequipClue(IMeetingClue clue, Action<int> resultHandler)
		{
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B873")]
		[Address(RVA = "0x33596D0", Offset = "0x33582D0", VA = "0x1833596D0", Slot = "29")]
		public void RemoveClue(IMeetingClue clue, Action<int> resultHandler)
		{
		}

		// Token: 0x0600B874 RID: 47220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B874")]
		[Address(RVA = "0x335A0F0", Offset = "0x3358CF0", VA = "0x18335A0F0", Slot = "30")]
		public void TryUnlockTransfer(Action<int> resultHandler)
		{
		}

		// Token: 0x0600B875 RID: 47221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B875")]
		[Address(RVA = "0x3359BA0", Offset = "0x33587A0", VA = "0x183359BA0", Slot = "31")]
		public void TryFetchRoomProductClue(Action<int> resultHandler)
		{
		}

		// Token: 0x0600B876 RID: 47222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B876")]
		[Address(RVA = "0x3359E40", Offset = "0x3358A40", VA = "0x183359E40", Slot = "32")]
		public void TryFetchTransferReward(Action<int> resultHandler)
		{
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B877")]
		[Address(RVA = "0x3359250", Offset = "0x3357E50", VA = "0x183359250", Slot = "33")]
		public void ReceiveExternalClue(IMeetingClue clue, Action<int> resultHandler)
		{
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B878")]
		[Address(RVA = "0x3358D20", Offset = "0x3357920", VA = "0x183358D20", Slot = "34")]
		public void ReceiveAllExternalClue(Action<int> resultHandler)
		{
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B879")]
		[Address(RVA = "0x3358700", Offset = "0x3357300", VA = "0x183358700", Slot = "35")]
		public void GiveClue(IMeetingClue clue, IPeer peer, Action<int> resultHandler)
		{
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B87A")]
		[Address(RVA = "0x3357C30", Offset = "0x3356830", VA = "0x183357C30", Slot = "36")]
		public void AutoGiveClue(Action<int, int, int> resultHandler)
		{
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B87B")]
		[Address(RVA = "0x335A740", Offset = "0x3359340", VA = "0x18335A740", Slot = "37")]
		public void UpdatePeers(Action<int> resultHandler)
		{
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B87C")]
		[Address(RVA = "0x335A9D0", Offset = "0x33595D0", VA = "0x18335A9D0", Slot = "38")]
		public void UpdateTransferVisitNum(Action<int> resultHandler)
		{
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B87D")]
		[Address(RVA = "0x335AC20", Offset = "0x3359820", VA = "0x18335AC20", Slot = "39")]
		public void UpdateWaitingClue(Action<int> resultHandler)
		{
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B87E")]
		[Address(RVA = "0x3358C20", Offset = "0x3357820", VA = "0x183358C20")]
		public void OnInit(Action<List<ItemBundle>> rewardHandler)
		{
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B87F")]
		[Address(RVA = "0x3358CA0", Offset = "0x33578A0", VA = "0x183358CA0")]
		public void OnPlayerDataChanged(Action<List<ItemBundle>> rewardHandler)
		{
		}

		// Token: 0x0400B684 RID: 46724
		[Token(Token = "0x400B684")]
		[FieldOffset(Offset = "0x10")]
		private SpriteHub m_clueSpriteHub;

		// Token: 0x0400B685 RID: 46725
		[Token(Token = "0x400B685")]
		[FieldOffset(Offset = "0x18")]
		private BuildingMeetingSession.Character m_cachedCharacter0;

		// Token: 0x0400B686 RID: 46726
		[Token(Token = "0x400B686")]
		[FieldOffset(Offset = "0x20")]
		private BuildingMeetingSession.Character m_cachedCharacter1;

		// Token: 0x0400B687 RID: 46727
		[Token(Token = "0x400B687")]
		[FieldOffset(Offset = "0x28")]
		private List<BuildingMeetingSession.Peer> m_peerList;

		// Token: 0x0400B688 RID: 46728
		[Token(Token = "0x400B688")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_starFriendList;

		// Token: 0x0400B689 RID: 46729
		[Token(Token = "0x400B689")]
		[FieldOffset(Offset = "0x38")]
		private List<BuildingMeetingSession.Clue> m_storedClueCache;

		// Token: 0x0400B68A RID: 46730
		[Token(Token = "0x400B68A")]
		[FieldOffset(Offset = "0x40")]
		private List<BuildingMeetingSession.Clue> m_waitingClue;

		// Token: 0x0400B68B RID: 46731
		[Token(Token = "0x400B68B")]
		[FieldOffset(Offset = "0x48")]
		private BuildingMeetingSession.CharacterProduct m_characterProduct;

		// Token: 0x0400B68C RID: 46732
		[Token(Token = "0x400B68C")]
		[FieldOffset(Offset = "0x50")]
		private TransferResult m_lastTransferResult;

		// Token: 0x0400B68D RID: 46733
		[Token(Token = "0x400B68D")]
		[FieldOffset(Offset = "0x58")]
		private bool m_usePushFlag;

		// Token: 0x0400B68F RID: 46735
		[Token(Token = "0x400B68F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400B690 RID: 46736
		[Token(Token = "0x400B690")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FetchCharacter;

		// Token: 0x0400B691 RID: 46737
		[Token(Token = "0x400B691")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetClueList;

		// Token: 0x0400B692 RID: 46738
		[Token(Token = "0x400B692")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_storedClues;

		// Token: 0x0400B693 RID: 46739
		[Token(Token = "0x400B693")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_waitingClues;

		// Token: 0x0400B694 RID: 46740
		[Token(Token = "0x400B694")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_peers;

		// Token: 0x0400B695 RID: 46741
		[Token(Token = "0x400B695")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateCharacterProduct;

		// Token: 0x0400B696 RID: 46742
		[Token(Token = "0x400B696")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateSocialReward;

		// Token: 0x0400B697 RID: 46743
		[Token(Token = "0x400B697")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_characterMadeClue;

		// Token: 0x0400B698 RID: 46744
		[Token(Token = "0x400B698")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_roomMadeClue;

		// Token: 0x0400B699 RID: 46745
		[Token(Token = "0x400B699")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetTypeFromNumber;

		// Token: 0x0400B69A RID: 46746
		[Token(Token = "0x400B69A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_meetingRoom;

		// Token: 0x0400B69B RID: 46747
		[Token(Token = "0x400B69B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetClueFromId;

		// Token: 0x0400B69C RID: 46748
		[Token(Token = "0x400B69C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetSlotClue;

		// Token: 0x0400B69D RID: 46749
		[Token(Token = "0x400B69D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_stationaryCharacter0;

		// Token: 0x0400B69E RID: 46750
		[Token(Token = "0x400B69E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_stationaryCharacter1;

		// Token: 0x0400B69F RID: 46751
		[Token(Token = "0x400B69F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_hasNewProduct;

		// Token: 0x0400B6A0 RID: 46752
		[Token(Token = "0x400B6A0")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_hasNewRecv;

		// Token: 0x0400B6A1 RID: 46753
		[Token(Token = "0x400B6A1")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_hasNewSend;

		// Token: 0x0400B6A2 RID: 46754
		[Token(Token = "0x400B6A2")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_clueCountNeededForUnlockTransfer;

		// Token: 0x0400B6A3 RID: 46755
		[Token(Token = "0x400B6A3")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_transferring;

		// Token: 0x0400B6A4 RID: 46756
		[Token(Token = "0x400B6A4")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_transferringVisitNumber;

		// Token: 0x0400B6A5 RID: 46757
		[Token(Token = "0x400B6A5")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_transferringVisitNumber;

		// Token: 0x0400B6A6 RID: 46758
		[Token(Token = "0x400B6A6")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_transferringSocialPoint;

		// Token: 0x0400B6A7 RID: 46759
		[Token(Token = "0x400B6A7")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_localStorageCapacity;

		// Token: 0x0400B6A8 RID: 46760
		[Token(Token = "0x400B6A8")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_lastTransferResult;

		// Token: 0x0400B6A9 RID: 46761
		[Token(Token = "0x400B6A9")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_transferExpireTime;

		// Token: 0x0400B6AA RID: 46762
		[Token(Token = "0x400B6AA")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_slotId;

		// Token: 0x0400B6AB RID: 46763
		[Token(Token = "0x400B6AB")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_needReceiveTransferReward;

		// Token: 0x0400B6AC RID: 46764
		[Token(Token = "0x400B6AC")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_IsPeerStarFriend;

		// Token: 0x0400B6AD RID: 46765
		[Token(Token = "0x400B6AD")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_ReceiveBonus;

		// Token: 0x0400B6AE RID: 46766
		[Token(Token = "0x400B6AE")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_EquipClue;

		// Token: 0x0400B6AF RID: 46767
		[Token(Token = "0x400B6AF")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_AutoEquipClue;

		// Token: 0x0400B6B0 RID: 46768
		[Token(Token = "0x400B6B0")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UnequipClue;

		// Token: 0x0400B6B1 RID: 46769
		[Token(Token = "0x400B6B1")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_RemoveClue;

		// Token: 0x0400B6B2 RID: 46770
		[Token(Token = "0x400B6B2")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_TryUnlockTransfer;

		// Token: 0x0400B6B3 RID: 46771
		[Token(Token = "0x400B6B3")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_TryFetchRoomProductClue;

		// Token: 0x0400B6B4 RID: 46772
		[Token(Token = "0x400B6B4")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_TryFetchTransferReward;

		// Token: 0x0400B6B5 RID: 46773
		[Token(Token = "0x400B6B5")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_ReceiveExternalClue;

		// Token: 0x0400B6B6 RID: 46774
		[Token(Token = "0x400B6B6")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_ReceiveAllExternalClue;

		// Token: 0x0400B6B7 RID: 46775
		[Token(Token = "0x400B6B7")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GiveClue;

		// Token: 0x0400B6B8 RID: 46776
		[Token(Token = "0x400B6B8")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_AutoGiveClue;

		// Token: 0x0400B6B9 RID: 46777
		[Token(Token = "0x400B6B9")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_UpdatePeers;

		// Token: 0x0400B6BA RID: 46778
		[Token(Token = "0x400B6BA")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_UpdateTransferVisitNum;

		// Token: 0x0400B6BB RID: 46779
		[Token(Token = "0x400B6BB")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_UpdateWaitingClue;

		// Token: 0x0400B6BC RID: 46780
		[Token(Token = "0x400B6BC")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400B6BD RID: 46781
		[Token(Token = "0x400B6BD")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x02001D2B RID: 7467
		[Token(Token = "0x2001D2B")]
		private class Clue : IMeetingClue, IHotfixable
		{
			// Token: 0x0600B880 RID: 47232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B880")]
			[Address(RVA = "0x33655B0", Offset = "0x33641B0", VA = "0x1833655B0")]
			public Clue(PlayerBuildingMeetingClue clue, MeetingClueData.ClueData clueData, MeetingClueData.ClueTypeData typeData, SpriteHub spriteHub, bool external)
			{
			}

			// Token: 0x0600B881 RID: 47233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B881")]
			[Address(RVA = "0x3365530", Offset = "0x3364130", VA = "0x183365530")]
			public void UpdatePlayerClue(PlayerBuildingMeetingClue clue)
			{
			}

			// Token: 0x1700164A RID: 5706
			// (get) Token: 0x0600B882 RID: 47234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700164A")]
			public string clueId
			{
				[Token(Token = "0x600B882")]
				[Address(RVA = "0x3365710", Offset = "0x3364310", VA = "0x183365710")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700164B RID: 5707
			// (get) Token: 0x0600B883 RID: 47235 RVA: 0x00045510 File Offset: 0x00043710
			[Token(Token = "0x1700164B")]
			public bool isInSlot
			{
				[Token(Token = "0x600B883")]
				[Address(RVA = "0x3365A90", Offset = "0x3364690", VA = "0x183365A90", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700164C RID: 5708
			// (get) Token: 0x0600B884 RID: 47236 RVA: 0x00045528 File Offset: 0x00043728
			[Token(Token = "0x1700164C")]
			public int category
			{
				[Token(Token = "0x600B884")]
				[Address(RVA = "0x33656A0", Offset = "0x33642A0", VA = "0x1833656A0", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700164D RID: 5709
			// (get) Token: 0x0600B885 RID: 47237 RVA: 0x00045540 File Offset: 0x00043740
			[Token(Token = "0x1700164D")]
			public int number
			{
				[Token(Token = "0x600B885")]
				[Address(RVA = "0x3365B90", Offset = "0x3364790", VA = "0x183365B90", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700164E RID: 5710
			// (get) Token: 0x0600B886 RID: 47238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700164E")]
			public string name
			{
				[Token(Token = "0x600B886")]
				[Address(RVA = "0x3365B00", Offset = "0x3364700", VA = "0x183365B00", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700164F RID: 5711
			// (get) Token: 0x0600B887 RID: 47239 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700164F")]
			public string description
			{
				[Token(Token = "0x600B887")]
				[Address(RVA = "0x33657E0", Offset = "0x33643E0", VA = "0x1833657E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001650 RID: 5712
			// (get) Token: 0x0600B888 RID: 47240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001650")]
			public Sprite image
			{
				[Token(Token = "0x600B888")]
				[Address(RVA = "0x33659B0", Offset = "0x33645B0", VA = "0x1833659B0", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001651 RID: 5713
			// (get) Token: 0x0600B889 RID: 47241 RVA: 0x00045558 File Offset: 0x00043758
			[Token(Token = "0x17001651")]
			public bool external
			{
				[Token(Token = "0x600B889")]
				[Address(RVA = "0x33658C0", Offset = "0x33644C0", VA = "0x1833658C0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001652 RID: 5714
			// (get) Token: 0x0600B88A RID: 47242 RVA: 0x00045570 File Offset: 0x00043770
			[Token(Token = "0x17001652")]
			public long expireTime
			{
				[Token(Token = "0x600B88A")]
				[Address(RVA = "0x3365850", Offset = "0x3364450", VA = "0x183365850", Slot = "11")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001653 RID: 5715
			// (get) Token: 0x0600B88B RID: 47243 RVA: 0x00045588 File Offset: 0x00043788
			[Token(Token = "0x17001653")]
			public int collectBonus
			{
				[Token(Token = "0x600B88B")]
				[Address(RVA = "0x3365780", Offset = "0x3364380", VA = "0x183365780", Slot = "12")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001654 RID: 5716
			// (get) Token: 0x0600B88C RID: 47244 RVA: 0x000455A0 File Offset: 0x000437A0
			[Token(Token = "0x17001654")]
			public int removeBonus
			{
				[Token(Token = "0x600B88C")]
				[Address(RVA = "0x3365CB0", Offset = "0x33648B0", VA = "0x183365CB0", Slot = "13")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001655 RID: 5717
			// (get) Token: 0x0600B88D RID: 47245 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001655")]
			public IEnumerable<ClueProducerInfo> producers
			{
				[Token(Token = "0x600B88D")]
				[Address(RVA = "0x3365C00", Offset = "0x3364800", VA = "0x183365C00", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001656 RID: 5718
			// (get) Token: 0x0600B88E RID: 47246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001656")]
			public string fromString
			{
				[Token(Token = "0x600B88E")]
				[Address(RVA = "0x3365920", Offset = "0x3364520", VA = "0x183365920", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001657 RID: 5719
			// (get) Token: 0x0600B88F RID: 47247 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001657")]
			public string typeName
			{
				[Token(Token = "0x600B88F")]
				[Address(RVA = "0x3365D30", Offset = "0x3364930", VA = "0x183365D30")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B6BE RID: 46782
			[Token(Token = "0x400B6BE")]
			[FieldOffset(Offset = "0x10")]
			private PlayerBuildingMeetingClue m_clue;

			// Token: 0x0400B6BF RID: 46783
			[Token(Token = "0x400B6BF")]
			[FieldOffset(Offset = "0x18")]
			private MeetingClueData.ClueData m_clueData;

			// Token: 0x0400B6C0 RID: 46784
			[Token(Token = "0x400B6C0")]
			[FieldOffset(Offset = "0x20")]
			private MeetingClueData.ClueTypeData m_typeData;

			// Token: 0x0400B6C1 RID: 46785
			[Token(Token = "0x400B6C1")]
			[FieldOffset(Offset = "0x28")]
			private SpriteHub m_spriteHub;

			// Token: 0x0400B6C2 RID: 46786
			[Token(Token = "0x400B6C2")]
			[FieldOffset(Offset = "0x30")]
			private bool m_external;

			// Token: 0x0400B6C3 RID: 46787
			[Token(Token = "0x400B6C3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B6C4 RID: 46788
			[Token(Token = "0x400B6C4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdatePlayerClue;

			// Token: 0x0400B6C5 RID: 46789
			[Token(Token = "0x400B6C5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_clueId;

			// Token: 0x0400B6C6 RID: 46790
			[Token(Token = "0x400B6C6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_isInSlot;

			// Token: 0x0400B6C7 RID: 46791
			[Token(Token = "0x400B6C7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_category;

			// Token: 0x0400B6C8 RID: 46792
			[Token(Token = "0x400B6C8")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_number;

			// Token: 0x0400B6C9 RID: 46793
			[Token(Token = "0x400B6C9")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_name;

			// Token: 0x0400B6CA RID: 46794
			[Token(Token = "0x400B6CA")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_description;

			// Token: 0x0400B6CB RID: 46795
			[Token(Token = "0x400B6CB")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_image;

			// Token: 0x0400B6CC RID: 46796
			[Token(Token = "0x400B6CC")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_external;

			// Token: 0x0400B6CD RID: 46797
			[Token(Token = "0x400B6CD")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_expireTime;

			// Token: 0x0400B6CE RID: 46798
			[Token(Token = "0x400B6CE")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_collectBonus;

			// Token: 0x0400B6CF RID: 46799
			[Token(Token = "0x400B6CF")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_removeBonus;

			// Token: 0x0400B6D0 RID: 46800
			[Token(Token = "0x400B6D0")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_producers;

			// Token: 0x0400B6D1 RID: 46801
			[Token(Token = "0x400B6D1")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_fromString;

			// Token: 0x0400B6D2 RID: 46802
			[Token(Token = "0x400B6D2")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_typeName;
		}

		// Token: 0x02001D2D RID: 7469
		[Token(Token = "0x2001D2D")]
		private class Peer : IPeer, IHotfixable
		{
			// Token: 0x0600B898 RID: 47256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B898")]
			[Address(RVA = "0x3367170", Offset = "0x3365D70", VA = "0x183367170")]
			public Peer(FriendDataWithNameCard info, string comment, int sendReward)
			{
			}

			// Token: 0x1700165A RID: 5722
			// (get) Token: 0x0600B899 RID: 47257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700165A")]
			public Sprite icon
			{
				[Token(Token = "0x600B899")]
				[Address(RVA = "0x33674F0", Offset = "0x33660F0", VA = "0x1833674F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700165B RID: 5723
			// (get) Token: 0x0600B89A RID: 47258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700165B")]
			public string userId
			{
				[Token(Token = "0x600B89A")]
				[Address(RVA = "0x33678E0", Offset = "0x33664E0", VA = "0x1833678E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700165C RID: 5724
			// (get) Token: 0x0600B89B RID: 47259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700165C")]
			public string nickName
			{
				[Token(Token = "0x600B89B")]
				[Address(RVA = "0x33676A0", Offset = "0x33662A0", VA = "0x1833676A0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700165D RID: 5725
			// (get) Token: 0x0600B89C RID: 47260 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700165D")]
			public string nickNumber
			{
				[Token(Token = "0x600B89C")]
				[Address(RVA = "0x3367720", Offset = "0x3366320", VA = "0x183367720", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700165E RID: 5726
			// (get) Token: 0x0600B89D RID: 47261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700165E")]
			public string comment
			{
				[Token(Token = "0x600B89D")]
				[Address(RVA = "0x33673D0", Offset = "0x3365FD0", VA = "0x1833673D0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700165F RID: 5727
			// (get) Token: 0x0600B89E RID: 47262 RVA: 0x000455E8 File Offset: 0x000437E8
			[Token(Token = "0x1700165F")]
			public int level
			{
				[Token(Token = "0x600B89E")]
				[Address(RVA = "0x33675C0", Offset = "0x33661C0", VA = "0x1833675C0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001660 RID: 5728
			// (get) Token: 0x0600B89F RID: 47263 RVA: 0x00045600 File Offset: 0x00043800
			[Token(Token = "0x17001660")]
			public bool online
			{
				[Token(Token = "0x600B89F")]
				[Address(RVA = "0x3367830", Offset = "0x3366430", VA = "0x183367830", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001661 RID: 5729
			// (get) Token: 0x0600B8A0 RID: 47264 RVA: 0x00045618 File Offset: 0x00043818
			[Token(Token = "0x17001661")]
			public DateTime lastLoginTime
			{
				[Token(Token = "0x600B8A0")]
				[Address(RVA = "0x3367550", Offset = "0x3366150", VA = "0x183367550", Slot = "11")]
				get
				{
					return default(DateTime);
				}
			}

			// Token: 0x0600B8A1 RID: 47265 RVA: 0x00045630 File Offset: 0x00043830
			[Token(Token = "0x600B8A1")]
			[Address(RVA = "0x3366F70", Offset = "0x3365B70", VA = "0x183366F70", Slot = "12")]
			public bool HasCard(int category)
			{
				return default(bool);
			}

			// Token: 0x0600B8A2 RID: 47266 RVA: 0x00045648 File Offset: 0x00043848
			[Token(Token = "0x600B8A2")]
			[Address(RVA = "0x3366E30", Offset = "0x3365A30", VA = "0x183366E30", Slot = "13")]
			public bool HasAllTypesOfClue()
			{
				return default(bool);
			}

			// Token: 0x17001662 RID: 5730
			// (get) Token: 0x0600B8A3 RID: 47267 RVA: 0x00045660 File Offset: 0x00043860
			[Token(Token = "0x17001662")]
			public int creditReward
			{
				[Token(Token = "0x600B8A3")]
				[Address(RVA = "0x3367430", Offset = "0x3366030", VA = "0x183367430", Slot = "14")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001663 RID: 5731
			// (get) Token: 0x0600B8A4 RID: 47268 RVA: 0x00045678 File Offset: 0x00043878
			[Token(Token = "0x17001663")]
			public PlayerAvatarQuery avatarQuery
			{
				[Token(Token = "0x600B8A4")]
				[Address(RVA = "0x3367320", Offset = "0x3365F20", VA = "0x183367320", Slot = "15")]
				get
				{
					return default(PlayerAvatarQuery);
				}
			}

			// Token: 0x17001664 RID: 5732
			// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001664")]
			public PlayerNameCardSkin nameCardSkin
			{
				[Token(Token = "0x600B8A5")]
				[Address(RVA = "0x3367630", Offset = "0x3366230", VA = "0x183367630", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001665 RID: 5733
			// (get) Token: 0x0600B8A6 RID: 47270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001665")]
			public List<int> hasCluesFromMe
			{
				[Token(Token = "0x600B8A6")]
				[Address(RVA = "0x3367490", Offset = "0x3366090", VA = "0x183367490", Slot = "17")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001666 RID: 5734
			// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x00045690 File Offset: 0x00043890
			[Token(Token = "0x17001666")]
			public int numCluesSentToMe
			{
				[Token(Token = "0x600B8A7")]
				[Address(RVA = "0x33677D0", Offset = "0x33663D0", VA = "0x1833677D0", Slot = "18")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B8A8 RID: 47272 RVA: 0x000456A8 File Offset: 0x000438A8
			[Token(Token = "0x600B8A8")]
			[Address(RVA = "0x3367000", Offset = "0x3365C00", VA = "0x183367000")]
			private int _ConvertClueTypeToNum(string typeName)
			{
				return 0;
			}

			// Token: 0x0400B6D9 RID: 46809
			[Token(Token = "0x400B6D9")]
			[FieldOffset(Offset = "0x10")]
			private FriendDataWithNameCard m_info;

			// Token: 0x0400B6DA RID: 46810
			[Token(Token = "0x400B6DA")]
			[FieldOffset(Offset = "0x18")]
			private int m_sendReward;

			// Token: 0x0400B6DB RID: 46811
			[Token(Token = "0x400B6DB")]
			[FieldOffset(Offset = "0x20")]
			private string m_comment;

			// Token: 0x0400B6DC RID: 46812
			[Token(Token = "0x400B6DC")]
			[FieldOffset(Offset = "0x28")]
			private List<int> m_hasCard;

			// Token: 0x0400B6DD RID: 46813
			[Token(Token = "0x400B6DD")]
			[FieldOffset(Offset = "0x30")]
			private List<int> m_hasClueFromMe;

			// Token: 0x0400B6DE RID: 46814
			[Token(Token = "0x400B6DE")]
			[FieldOffset(Offset = "0x38")]
			private int m_numCluesSentToMe;

			// Token: 0x0400B6DF RID: 46815
			[Token(Token = "0x400B6DF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B6E0 RID: 46816
			[Token(Token = "0x400B6E0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_icon;

			// Token: 0x0400B6E1 RID: 46817
			[Token(Token = "0x400B6E1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_userId;

			// Token: 0x0400B6E2 RID: 46818
			[Token(Token = "0x400B6E2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_nickName;

			// Token: 0x0400B6E3 RID: 46819
			[Token(Token = "0x400B6E3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_nickNumber;

			// Token: 0x0400B6E4 RID: 46820
			[Token(Token = "0x400B6E4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_comment;

			// Token: 0x0400B6E5 RID: 46821
			[Token(Token = "0x400B6E5")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_level;

			// Token: 0x0400B6E6 RID: 46822
			[Token(Token = "0x400B6E6")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_online;

			// Token: 0x0400B6E7 RID: 46823
			[Token(Token = "0x400B6E7")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_lastLoginTime;

			// Token: 0x0400B6E8 RID: 46824
			[Token(Token = "0x400B6E8")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_HasCard;

			// Token: 0x0400B6E9 RID: 46825
			[Token(Token = "0x400B6E9")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_HasAllTypesOfClue;

			// Token: 0x0400B6EA RID: 46826
			[Token(Token = "0x400B6EA")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_creditReward;

			// Token: 0x0400B6EB RID: 46827
			[Token(Token = "0x400B6EB")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_avatarQuery;

			// Token: 0x0400B6EC RID: 46828
			[Token(Token = "0x400B6EC")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_nameCardSkin;

			// Token: 0x0400B6ED RID: 46829
			[Token(Token = "0x400B6ED")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_hasCluesFromMe;

			// Token: 0x0400B6EE RID: 46830
			[Token(Token = "0x400B6EE")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_numCluesSentToMe;

			// Token: 0x0400B6EF RID: 46831
			[Token(Token = "0x400B6EF")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0__ConvertClueTypeToNum;
		}

		// Token: 0x02001D2E RID: 7470
		[Token(Token = "0x2001D2E")]
		private class InfoShareVisitor : IPeer, IHotfixable
		{
			// Token: 0x0600B8A9 RID: 47273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8A9")]
			[Address(RVA = "0x3365E90", Offset = "0x3364A90", VA = "0x183365E90")]
			public InfoShareVisitor(BuildingMeetingClueReceiveInfoShareRewardResponse.VisitorInfo info)
			{
			}

			// Token: 0x17001667 RID: 5735
			// (get) Token: 0x0600B8AA RID: 47274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001667")]
			public Sprite icon
			{
				[Token(Token = "0x600B8AA")]
				[Address(RVA = "0x33660F0", Offset = "0x3364CF0", VA = "0x1833660F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001668 RID: 5736
			// (get) Token: 0x0600B8AB RID: 47275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001668")]
			public string userId
			{
				[Token(Token = "0x600B8AB")]
				[Address(RVA = "0x3366450", Offset = "0x3365050", VA = "0x183366450", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001669 RID: 5737
			// (get) Token: 0x0600B8AC RID: 47276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001669")]
			public string nickName
			{
				[Token(Token = "0x600B8AC")]
				[Address(RVA = "0x33662B0", Offset = "0x3364EB0", VA = "0x1833662B0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700166A RID: 5738
			// (get) Token: 0x0600B8AD RID: 47277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700166A")]
			public string nickNumber
			{
				[Token(Token = "0x600B8AD")]
				[Address(RVA = "0x3366320", Offset = "0x3364F20", VA = "0x183366320", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700166B RID: 5739
			// (get) Token: 0x0600B8AE RID: 47278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700166B")]
			public string comment
			{
				[Token(Token = "0x600B8AE")]
				[Address(RVA = "0x3365FC0", Offset = "0x3364BC0", VA = "0x183365FC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700166C RID: 5740
			// (get) Token: 0x0600B8AF RID: 47279 RVA: 0x000456C0 File Offset: 0x000438C0
			[Token(Token = "0x1700166C")]
			public int level
			{
				[Token(Token = "0x600B8AF")]
				[Address(RVA = "0x33661E0", Offset = "0x3364DE0", VA = "0x1833661E0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700166D RID: 5741
			// (get) Token: 0x0600B8B0 RID: 47280 RVA: 0x000456D8 File Offset: 0x000438D8
			[Token(Token = "0x1700166D")]
			public bool online
			{
				[Token(Token = "0x600B8B0")]
				[Address(RVA = "0x33663F0", Offset = "0x3364FF0", VA = "0x1833663F0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700166E RID: 5742
			// (get) Token: 0x0600B8B1 RID: 47281 RVA: 0x000456F0 File Offset: 0x000438F0
			[Token(Token = "0x1700166E")]
			public DateTime lastLoginTime
			{
				[Token(Token = "0x600B8B1")]
				[Address(RVA = "0x3366150", Offset = "0x3364D50", VA = "0x183366150", Slot = "11")]
				get
				{
					return default(DateTime);
				}
			}

			// Token: 0x0600B8B2 RID: 47282 RVA: 0x00045708 File Offset: 0x00043908
			[Token(Token = "0x600B8B2")]
			[Address(RVA = "0x3365E20", Offset = "0x3364A20", VA = "0x183365E20", Slot = "12")]
			public bool HasCard(int category)
			{
				return default(bool);
			}

			// Token: 0x0600B8B3 RID: 47283 RVA: 0x00045720 File Offset: 0x00043920
			[Token(Token = "0x600B8B3")]
			[Address(RVA = "0x3365DC0", Offset = "0x33649C0", VA = "0x183365DC0", Slot = "13")]
			public bool HasAllTypesOfClue()
			{
				return default(bool);
			}

			// Token: 0x1700166F RID: 5743
			// (get) Token: 0x0600B8B4 RID: 47284 RVA: 0x00045738 File Offset: 0x00043938
			[Token(Token = "0x1700166F")]
			public int creditReward
			{
				[Token(Token = "0x600B8B4")]
				[Address(RVA = "0x3366030", Offset = "0x3364C30", VA = "0x183366030", Slot = "14")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001670 RID: 5744
			// (get) Token: 0x0600B8B5 RID: 47285 RVA: 0x00045750 File Offset: 0x00043950
			[Token(Token = "0x17001670")]
			public PlayerAvatarQuery avatarQuery
			{
				[Token(Token = "0x600B8B5")]
				[Address(RVA = "0x3365F10", Offset = "0x3364B10", VA = "0x183365F10", Slot = "15")]
				get
				{
					return default(PlayerAvatarQuery);
				}
			}

			// Token: 0x17001671 RID: 5745
			// (get) Token: 0x0600B8B6 RID: 47286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001671")]
			public PlayerNameCardSkin nameCardSkin
			{
				[Token(Token = "0x600B8B6")]
				[Address(RVA = "0x3366250", Offset = "0x3364E50", VA = "0x183366250", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001672 RID: 5746
			// (get) Token: 0x0600B8B7 RID: 47287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001672")]
			public List<int> hasCluesFromMe
			{
				[Token(Token = "0x600B8B7")]
				[Address(RVA = "0x3366090", Offset = "0x3364C90", VA = "0x183366090", Slot = "17")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001673 RID: 5747
			// (get) Token: 0x0600B8B8 RID: 47288 RVA: 0x00045768 File Offset: 0x00043968
			[Token(Token = "0x17001673")]
			public int numCluesSentToMe
			{
				[Token(Token = "0x600B8B8")]
				[Address(RVA = "0x3366390", Offset = "0x3364F90", VA = "0x183366390", Slot = "18")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0400B6F0 RID: 46832
			[Token(Token = "0x400B6F0")]
			[FieldOffset(Offset = "0x10")]
			private BuildingMeetingClueReceiveInfoShareRewardResponse.VisitorInfo m_info;

			// Token: 0x0400B6F1 RID: 46833
			[Token(Token = "0x400B6F1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B6F2 RID: 46834
			[Token(Token = "0x400B6F2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_icon;

			// Token: 0x0400B6F3 RID: 46835
			[Token(Token = "0x400B6F3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_userId;

			// Token: 0x0400B6F4 RID: 46836
			[Token(Token = "0x400B6F4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_nickName;

			// Token: 0x0400B6F5 RID: 46837
			[Token(Token = "0x400B6F5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_nickNumber;

			// Token: 0x0400B6F6 RID: 46838
			[Token(Token = "0x400B6F6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_comment;

			// Token: 0x0400B6F7 RID: 46839
			[Token(Token = "0x400B6F7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_level;

			// Token: 0x0400B6F8 RID: 46840
			[Token(Token = "0x400B6F8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_online;

			// Token: 0x0400B6F9 RID: 46841
			[Token(Token = "0x400B6F9")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_lastLoginTime;

			// Token: 0x0400B6FA RID: 46842
			[Token(Token = "0x400B6FA")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_HasCard;

			// Token: 0x0400B6FB RID: 46843
			[Token(Token = "0x400B6FB")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_HasAllTypesOfClue;

			// Token: 0x0400B6FC RID: 46844
			[Token(Token = "0x400B6FC")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_creditReward;

			// Token: 0x0400B6FD RID: 46845
			[Token(Token = "0x400B6FD")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_avatarQuery;

			// Token: 0x0400B6FE RID: 46846
			[Token(Token = "0x400B6FE")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_nameCardSkin;

			// Token: 0x0400B6FF RID: 46847
			[Token(Token = "0x400B6FF")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_hasCluesFromMe;

			// Token: 0x0400B700 RID: 46848
			[Token(Token = "0x400B700")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_numCluesSentToMe;
		}

		// Token: 0x02001D2F RID: 7471
		[Token(Token = "0x2001D2F")]
		private class CharacterProduct : ICharacterClueProduct
		{
			// Token: 0x0600B8B9 RID: 47289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8B9")]
			[Address(RVA = "0x3364A30", Offset = "0x3363630", VA = "0x183364A30")]
			public CharacterProduct(long startTime, long endTime, float basicProgress)
			{
			}

			// Token: 0x17001674 RID: 5748
			// (get) Token: 0x0600B8BA RID: 47290 RVA: 0x00045780 File Offset: 0x00043980
			[Token(Token = "0x17001674")]
			public long startTime
			{
				[Token(Token = "0x600B8BA")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001675 RID: 5749
			// (get) Token: 0x0600B8BB RID: 47291 RVA: 0x00045798 File Offset: 0x00043998
			[Token(Token = "0x17001675")]
			public long endTime
			{
				[Token(Token = "0x600B8BB")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001676 RID: 5750
			// (get) Token: 0x0600B8BC RID: 47292 RVA: 0x000457B0 File Offset: 0x000439B0
			[Token(Token = "0x17001676")]
			public float basicProgress
			{
				[Token(Token = "0x600B8BC")]
				[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40", Slot = "6")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17001677 RID: 5751
			// (get) Token: 0x0600B8BD RID: 47293 RVA: 0x000457C8 File Offset: 0x000439C8
			[Token(Token = "0x17001677")]
			public int creditPerClue
			{
				[Token(Token = "0x600B8BD")]
				[Address(RVA = "0x3364A80", Offset = "0x3363680", VA = "0x183364A80", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001678 RID: 5752
			// (get) Token: 0x0600B8BE RID: 47294 RVA: 0x000457E0 File Offset: 0x000439E0
			// (set) Token: 0x0600B8BF RID: 47295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001678")]
			public bool running
			{
				[Token(Token = "0x600B8BE")]
				[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600B8BF")]
				[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0400B701 RID: 46849
			[Token(Token = "0x400B701")]
			[FieldOffset(Offset = "0x10")]
			private long m_startTime;

			// Token: 0x0400B702 RID: 46850
			[Token(Token = "0x400B702")]
			[FieldOffset(Offset = "0x18")]
			private long m_endTime;

			// Token: 0x0400B703 RID: 46851
			[Token(Token = "0x400B703")]
			[FieldOffset(Offset = "0x20")]
			private float m_basicProgress;
		}

		// Token: 0x02001D30 RID: 7472
		[Token(Token = "0x2001D30")]
		private class RoomProduct : IRoomClueProduct, IHotfixable
		{
			// Token: 0x0600B8C0 RID: 47296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8C0")]
			[Address(RVA = "0x3367990", Offset = "0x3366590", VA = "0x183367990")]
			public RoomProduct(PlayerBuildingMeetingClue clue, SpriteHub clueHub)
			{
			}

			// Token: 0x17001679 RID: 5753
			// (get) Token: 0x0600B8C1 RID: 47297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001679")]
			public IMeetingClue clue
			{
				[Token(Token = "0x600B8C1")]
				[Address(RVA = "0x3367CC0", Offset = "0x33668C0", VA = "0x183367CC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700167A RID: 5754
			// (get) Token: 0x0600B8C2 RID: 47298 RVA: 0x000457F8 File Offset: 0x000439F8
			[Token(Token = "0x1700167A")]
			public int creditPerClue
			{
				[Token(Token = "0x600B8C2")]
				[Address(RVA = "0x3367D20", Offset = "0x3366920", VA = "0x183367D20", Slot = "5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0400B705 RID: 46853
			[Token(Token = "0x400B705")]
			[FieldOffset(Offset = "0x10")]
			private BuildingMeetingSession.Clue m_clue;

			// Token: 0x0400B706 RID: 46854
			[Token(Token = "0x400B706")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B707 RID: 46855
			[Token(Token = "0x400B707")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_clue;

			// Token: 0x0400B708 RID: 46856
			[Token(Token = "0x400B708")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_creditPerClue;
		}

		// Token: 0x02001D31 RID: 7473
		[Token(Token = "0x2001D31")]
		private class Buff : IMeetingBuildingBuff
		{
			// Token: 0x0600B8C3 RID: 47299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8C3")]
			[Address(RVA = "0x3351690", Offset = "0x3350290", VA = "0x183351690")]
			public Buff(BuildingCharModel charModel)
			{
			}

			// Token: 0x1700167B RID: 5755
			// (get) Token: 0x0600B8C4 RID: 47300 RVA: 0x00045810 File Offset: 0x00043A10
			[Token(Token = "0x1700167B")]
			public bool avaiable
			{
				[Token(Token = "0x600B8C4")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700167C RID: 5756
			// (get) Token: 0x0600B8C5 RID: 47301 RVA: 0x00045828 File Offset: 0x00043A28
			[Token(Token = "0x1700167C")]
			public BuildingBuffDescStruct buffDesc
			{
				[Token(Token = "0x600B8C5")]
				[Address(RVA = "0x3351840", Offset = "0x3350440", VA = "0x183351840", Slot = "4")]
				get
				{
					return default(BuildingBuffDescStruct);
				}
			}

			// Token: 0x0400B709 RID: 46857
			[Token(Token = "0x400B709")]
			[FieldOffset(Offset = "0x10")]
			private bool m_available;

			// Token: 0x0400B70A RID: 46858
			[Token(Token = "0x400B70A")]
			[FieldOffset(Offset = "0x18")]
			private BuildingBuffDescStruct m_desc;
		}

		// Token: 0x02001D32 RID: 7474
		[Token(Token = "0x2001D32")]
		private class Character : IMeetingStationaryCharacter, IHotfixable
		{
			// Token: 0x0600B8C6 RID: 47302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8C6")]
			[Address(RVA = "0x3364C60", Offset = "0x3363860", VA = "0x183364C60")]
			private void _Init(BuildingCharModel buildingChar)
			{
			}

			// Token: 0x0600B8C7 RID: 47303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8C7")]
			[Address(RVA = "0x3364AC0", Offset = "0x33636C0", VA = "0x183364AC0")]
			public void Setup(BuildingCharModel buildingChar)
			{
			}

			// Token: 0x1700167D RID: 5757
			// (get) Token: 0x0600B8C8 RID: 47304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700167D")]
			public string name
			{
				[Token(Token = "0x600B8C8")]
				[Address(RVA = "0x33653F0", Offset = "0x3363FF0", VA = "0x1833653F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700167E RID: 5758
			// (get) Token: 0x0600B8C9 RID: 47305 RVA: 0x00045840 File Offset: 0x00043A40
			[Token(Token = "0x1700167E")]
			public int instId
			{
				[Token(Token = "0x600B8C9")]
				[Address(RVA = "0x3365390", Offset = "0x3363F90", VA = "0x183365390")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700167F RID: 5759
			// (get) Token: 0x0600B8CA RID: 47306 RVA: 0x00045858 File Offset: 0x00043A58
			[Token(Token = "0x1700167F")]
			public SpriteRenderData portrait
			{
				[Token(Token = "0x600B8CA")]
				[Address(RVA = "0x3365480", Offset = "0x3364080", VA = "0x183365480", Slot = "5")]
				get
				{
					return default(SpriteRenderData);
				}
			}

			// Token: 0x17001680 RID: 5760
			// (get) Token: 0x0600B8CB RID: 47307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001680")]
			public Sprite face
			{
				[Token(Token = "0x600B8CB")]
				[Address(RVA = "0x3365330", Offset = "0x3363F30", VA = "0x183365330", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001681 RID: 5761
			// (get) Token: 0x0600B8CC RID: 47308 RVA: 0x00045870 File Offset: 0x00043A70
			[Token(Token = "0x17001681")]
			public BuildingCharModel charModel
			{
				[Token(Token = "0x600B8CC")]
				[Address(RVA = "0x3365240", Offset = "0x3363E40", VA = "0x183365240", Slot = "8")]
				get
				{
					return default(BuildingCharModel);
				}
			}

			// Token: 0x17001682 RID: 5762
			// (get) Token: 0x0600B8CD RID: 47309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001682")]
			public IMeetingBuildingBuff buildingBuff
			{
				[Token(Token = "0x600B8CD")]
				[Address(RVA = "0x33651D0", Offset = "0x3363DD0", VA = "0x1833651D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B8CE RID: 47310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8CE")]
			[Address(RVA = "0x3365170", Offset = "0x3363D70", VA = "0x183365170")]
			public Character()
			{
			}

			// Token: 0x0400B70B RID: 46859
			[Token(Token = "0x400B70B")]
			[FieldOffset(Offset = "0x10")]
			private BuildingCharModel m_buildingChar;

			// Token: 0x0400B70C RID: 46860
			[Token(Token = "0x400B70C")]
			[FieldOffset(Offset = "0x88")]
			private CharacterCardViewModel m_cardViewModel;

			// Token: 0x0400B70D RID: 46861
			[Token(Token = "0x400B70D")]
			[FieldOffset(Offset = "0x90")]
			private SpriteRenderData m_portraitSprite;

			// Token: 0x0400B70E RID: 46862
			[Token(Token = "0x400B70E")]
			[FieldOffset(Offset = "0xD0")]
			private Sprite m_faceSprite;

			// Token: 0x0400B70F RID: 46863
			[Token(Token = "0x400B70F")]
			[FieldOffset(Offset = "0xD8")]
			private BuildingMeetingSession.Buff m_buff;

			// Token: 0x0400B710 RID: 46864
			[Token(Token = "0x400B710")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__Init;

			// Token: 0x0400B711 RID: 46865
			[Token(Token = "0x400B711")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Setup;

			// Token: 0x0400B712 RID: 46866
			[Token(Token = "0x400B712")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_name;

			// Token: 0x0400B713 RID: 46867
			[Token(Token = "0x400B713")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_instId;

			// Token: 0x0400B714 RID: 46868
			[Token(Token = "0x400B714")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_portrait;

			// Token: 0x0400B715 RID: 46869
			[Token(Token = "0x400B715")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_face;

			// Token: 0x0400B716 RID: 46870
			[Token(Token = "0x400B716")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_charModel;

			// Token: 0x0400B717 RID: 46871
			[Token(Token = "0x400B717")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_buildingBuff;

			// Token: 0x0400B718 RID: 46872
			[Token(Token = "0x400B718")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
