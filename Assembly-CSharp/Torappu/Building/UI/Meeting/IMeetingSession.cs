using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D11 RID: 7441
	[Token(Token = "0x2001D11")]
	public interface IMeetingSession : IHotfixable
	{
		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x0600B7A0 RID: 47008
		[Token(Token = "0x1700161A")]
		IEnumerable<IMeetingClue> storedClues { [Token(Token = "0x600B7A0")] get; }

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x0600B7A1 RID: 47009
		[Token(Token = "0x1700161B")]
		IEnumerable<IMeetingClue> waitingClues { [Token(Token = "0x600B7A1")] get; }

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x0600B7A2 RID: 47010
		[Token(Token = "0x1700161C")]
		IEnumerable<IPeer> peers { [Token(Token = "0x600B7A2")] get; }

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x0600B7A3 RID: 47011
		[Token(Token = "0x1700161D")]
		ICharacterClueProduct characterMadeClue { [Token(Token = "0x600B7A3")] get; }

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x0600B7A4 RID: 47012
		[Token(Token = "0x1700161E")]
		IRoomClueProduct roomMadeClue { [Token(Token = "0x600B7A4")] get; }

		// Token: 0x0600B7A5 RID: 47013
		[Token(Token = "0x600B7A5")]
		IMeetingClue GetSlotClue(int index);

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x0600B7A6 RID: 47014
		[Token(Token = "0x1700161F")]
		IMeetingStationaryCharacter stationaryCharacter0 { [Token(Token = "0x600B7A6")] get; }

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x0600B7A7 RID: 47015
		[Token(Token = "0x17001620")]
		IMeetingStationaryCharacter stationaryCharacter1 { [Token(Token = "0x600B7A7")] get; }

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x0600B7A8 RID: 47016
		[Token(Token = "0x17001621")]
		bool hasNewProduct { [Token(Token = "0x600B7A8")] get; }

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x0600B7A9 RID: 47017
		[Token(Token = "0x17001622")]
		bool hasNewRecv { [Token(Token = "0x600B7A9")] get; }

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x0600B7AA RID: 47018
		[Token(Token = "0x17001623")]
		bool hasNewSend { [Token(Token = "0x600B7AA")] get; }

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x0600B7AB RID: 47019
		[Token(Token = "0x17001624")]
		int clueCountNeededForUnlockTransfer { [Token(Token = "0x600B7AB")] get; }

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x0600B7AC RID: 47020
		[Token(Token = "0x17001625")]
		bool transferring { [Token(Token = "0x600B7AC")] get; }

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x0600B7AD RID: 47021
		[Token(Token = "0x17001626")]
		int transferringVisitNumber { [Token(Token = "0x600B7AD")] get; }

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x0600B7AE RID: 47022
		[Token(Token = "0x17001627")]
		int transferringSocialPoint { [Token(Token = "0x600B7AE")] get; }

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x0600B7AF RID: 47023
		[Token(Token = "0x17001628")]
		int localStorageCapacity { [Token(Token = "0x600B7AF")] get; }

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x0600B7B0 RID: 47024
		[Token(Token = "0x17001629")]
		TransferResult lastTransferResult { [Token(Token = "0x600B7B0")] get; }

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x0600B7B1 RID: 47025
		[Token(Token = "0x1700162A")]
		DateTime transferExpireTime { [Token(Token = "0x600B7B1")] get; }

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x0600B7B2 RID: 47026
		[Token(Token = "0x1700162B")]
		string slotId { [Token(Token = "0x600B7B2")] get; }

		// Token: 0x0600B7B3 RID: 47027
		[Token(Token = "0x600B7B3")]
		int ReceiveBonus(int count);

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x0600B7B4 RID: 47028
		[Token(Token = "0x1700162C")]
		bool needReceiveTransferReward { [Token(Token = "0x600B7B4")] get; }

		// Token: 0x0600B7B5 RID: 47029
		[Token(Token = "0x600B7B5")]
		bool IsPeerStarFriend(string uid);

		// Token: 0x0600B7B6 RID: 47030
		[Token(Token = "0x600B7B6")]
		void EquipClue(IMeetingClue clue, Action<int> resultHandler);

		// Token: 0x0600B7B7 RID: 47031
		[Token(Token = "0x600B7B7")]
		void AutoEquipClue(Action<int, int> resultHandler);

		// Token: 0x0600B7B8 RID: 47032
		[Token(Token = "0x600B7B8")]
		void UnequipClue(IMeetingClue clue, Action<int> resultHandler);

		// Token: 0x0600B7B9 RID: 47033
		[Token(Token = "0x600B7B9")]
		void RemoveClue(IMeetingClue clue, Action<int> resultHandler);

		// Token: 0x0600B7BA RID: 47034
		[Token(Token = "0x600B7BA")]
		void TryUnlockTransfer(Action<int> resultHandler);

		// Token: 0x0600B7BB RID: 47035
		[Token(Token = "0x600B7BB")]
		void TryFetchRoomProductClue(Action<int> resultHandler);

		// Token: 0x0600B7BC RID: 47036
		[Token(Token = "0x600B7BC")]
		void TryFetchTransferReward(Action<int> resultHandler);

		// Token: 0x0600B7BD RID: 47037
		[Token(Token = "0x600B7BD")]
		void ReceiveExternalClue(IMeetingClue clue, Action<int> resultHandler);

		// Token: 0x0600B7BE RID: 47038
		[Token(Token = "0x600B7BE")]
		void ReceiveAllExternalClue(Action<int> resultHandler);

		// Token: 0x0600B7BF RID: 47039
		[Token(Token = "0x600B7BF")]
		void GiveClue(IMeetingClue clue, IPeer peer, Action<int> resultHandler);

		// Token: 0x0600B7C0 RID: 47040
		[Token(Token = "0x600B7C0")]
		void AutoGiveClue(Action<int, int, int> resultHandler);

		// Token: 0x0600B7C1 RID: 47041
		[Token(Token = "0x600B7C1")]
		void UpdatePeers(Action<int> resultHandler);

		// Token: 0x0600B7C2 RID: 47042
		[Token(Token = "0x600B7C2")]
		void UpdateTransferVisitNum(Action<int> resultHandler);

		// Token: 0x0600B7C3 RID: 47043
		[Token(Token = "0x600B7C3")]
		void UpdateWaitingClue(Action<int> resultHandler);
	}
}
