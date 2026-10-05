using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006097 RID: 24727
	[Token(Token = "0x2006097")]
	public class CarvingMainViewModel : IHotfixable
	{
		// Token: 0x17005491 RID: 21649
		// (get) Token: 0x06023C75 RID: 146549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005491")]
		public CarvingMainCardDetailViewModel cardDetailViewModel
		{
			[Token(Token = "0x6023C75")]
			[Address(RVA = "0x1E7AF60", Offset = "0x1E79B60", VA = "0x181E7AF60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023C76 RID: 146550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C76")]
		[Address(RVA = "0x1E7A310", Offset = "0x1E78F10", VA = "0x181E7A310")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06023C77 RID: 146551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C77")]
		[Address(RVA = "0x1E7A880", Offset = "0x1E79480", VA = "0x181E7A880")]
		public void UpdateData(bool noNeedReloadCard = false)
		{
		}

		// Token: 0x06023C78 RID: 146552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C78")]
		[Address(RVA = "0x1E7A700", Offset = "0x1E79300", VA = "0x181E7A700")]
		public void ShopSelectSlot()
		{
		}

		// Token: 0x06023C79 RID: 146553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C79")]
		[Address(RVA = "0x1E7A660", Offset = "0x1E79260", VA = "0x181E7A660")]
		public void ShopSelectCard(int pos)
		{
		}

		// Token: 0x06023C7A RID: 146554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C7A")]
		[Address(RVA = "0x1E7A540", Offset = "0x1E79140", VA = "0x181E7A540")]
		public void SelectHandCard(string cardId)
		{
		}

		// Token: 0x06023C7B RID: 146555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C7B")]
		[Address(RVA = "0x1E7A260", Offset = "0x1E78E60", VA = "0x181E7A260")]
		public void GoProcessing(List<CarvingProcessFrame> frames, int fromScore)
		{
		}

		// Token: 0x06023C7C RID: 146556 RVA: 0x000C2010 File Offset: 0x000C0210
		[Token(Token = "0x6023C7C")]
		[Address(RVA = "0x1E7A790", Offset = "0x1E79390", VA = "0x181E7A790")]
		public bool TryProcessNextFrame()
		{
			return default(bool);
		}

		// Token: 0x06023C7D RID: 146557 RVA: 0x000C2028 File Offset: 0x000C0228
		[Token(Token = "0x6023C7D")]
		[Address(RVA = "0x1E7A0E0", Offset = "0x1E78CE0", VA = "0x181E7A0E0")]
		public bool CheckIsBonusFrame()
		{
			return default(bool);
		}

		// Token: 0x06023C7E RID: 146558 RVA: 0x000C2040 File Offset: 0x000C0240
		[Token(Token = "0x6023C7E")]
		[Address(RVA = "0x1E7A170", Offset = "0x1E78D70", VA = "0x181E7A170")]
		public bool CheckIsTaskFrame()
		{
			return default(bool);
		}

		// Token: 0x06023C7F RID: 146559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C7F")]
		[Address(RVA = "0x1E7A200", Offset = "0x1E78E00", VA = "0x181E7A200")]
		public void EndProcessing()
		{
		}

		// Token: 0x06023C80 RID: 146560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C80")]
		[Address(RVA = "0x1E7A800", Offset = "0x1E79400", VA = "0x181E7A800")]
		public void UnSelectAllCard()
		{
		}

		// Token: 0x06023C81 RID: 146561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C81")]
		[Address(RVA = "0x1E7A5D0", Offset = "0x1E791D0", VA = "0x181E7A5D0")]
		public void SetChallengeTaskFinished(bool isTaskFinished)
		{
		}

		// Token: 0x06023C82 RID: 146562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C82")]
		[Address(RVA = "0x1E7A480", Offset = "0x1E79080", VA = "0x181E7A480")]
		public void NotifyEnterBoard()
		{
		}

		// Token: 0x06023C83 RID: 146563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C83")]
		[Address(RVA = "0x1E7A4E0", Offset = "0x1E790E0", VA = "0x181E7A4E0")]
		public void NotifyFirstLoad()
		{
		}

		// Token: 0x06023C84 RID: 146564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023C84")]
		[Address(RVA = "0x1E7ABD0", Offset = "0x1E797D0", VA = "0x181E7ABD0")]
		private CarvingMainCardViewModel _GetSelectedCardViewModel()
		{
			return null;
		}

		// Token: 0x06023C85 RID: 146565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C85")]
		[Address(RVA = "0x1E7AC60", Offset = "0x1E79860", VA = "0x181E7AC60")]
		private void _UpdateRoundId(PlayerActivity.PlayerAct35SideActivity.PlayerAct35SideCarving playerData)
		{
		}

		// Token: 0x06023C86 RID: 146566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C86")]
		[Address(RVA = "0x1E7AD80", Offset = "0x1E79980", VA = "0x181E7AD80")]
		public CarvingMainViewModel()
		{
		}

		// Token: 0x040319AB RID: 203179
		[Token(Token = "0x40319AB")]
		[FieldOffset(Offset = "0x10")]
		public PlayerActivity.PlayerAct35SideActivity.GameState gameState;

		// Token: 0x040319AC RID: 203180
		[Token(Token = "0x40319AC")]
		[FieldOffset(Offset = "0x18")]
		public CarvingMainShopViewModel shopViewModel;

		// Token: 0x040319AD RID: 203181
		[Token(Token = "0x40319AD")]
		[FieldOffset(Offset = "0x20")]
		public CarvingCardListViewModel cardListViewModel;

		// Token: 0x040319AE RID: 203182
		[Token(Token = "0x40319AE")]
		[FieldOffset(Offset = "0x28")]
		public CarvingMainBoardModel boardViewModel;

		// Token: 0x040319AF RID: 203183
		[Token(Token = "0x40319AF")]
		[FieldOffset(Offset = "0x30")]
		public CarvingMainChallengeTaskViewModel challengeTaskViewModel;

		// Token: 0x040319B0 RID: 203184
		[Token(Token = "0x40319B0")]
		[FieldOffset(Offset = "0x38")]
		public CarvingMainProcessModel processModel;

		// Token: 0x040319B1 RID: 203185
		[Token(Token = "0x40319B1")]
		[FieldOffset(Offset = "0x40")]
		public bool isProcessing;

		// Token: 0x040319B2 RID: 203186
		[Token(Token = "0x40319B2")]
		[FieldOffset(Offset = "0x48")]
		public string currRoundId;

		// Token: 0x040319B3 RID: 203187
		[Token(Token = "0x40319B3")]
		[FieldOffset(Offset = "0x50")]
		public int firstLoadSeqNum;

		// Token: 0x040319B4 RID: 203188
		[Token(Token = "0x40319B4")]
		[FieldOffset(Offset = "0x54")]
		public int enterBoardSeqNum;

		// Token: 0x040319B5 RID: 203189
		[Token(Token = "0x40319B5")]
		[FieldOffset(Offset = "0x58")]
		private string m_actId;

		// Token: 0x040319B6 RID: 203190
		[Token(Token = "0x40319B6")]
		[FieldOffset(Offset = "0x60")]
		private Act35SideData m_actData;

		// Token: 0x040319B7 RID: 203191
		[Token(Token = "0x40319B7")]
		[FieldOffset(Offset = "0x68")]
		private CarvingMainCardDetailViewModel m_cardDetailViewModel;

		// Token: 0x040319B8 RID: 203192
		[Token(Token = "0x40319B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardDetailViewModel;

		// Token: 0x040319B9 RID: 203193
		[Token(Token = "0x40319B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040319BA RID: 203194
		[Token(Token = "0x40319BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040319BB RID: 203195
		[Token(Token = "0x40319BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShopSelectSlot;

		// Token: 0x040319BC RID: 203196
		[Token(Token = "0x40319BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShopSelectCard;

		// Token: 0x040319BD RID: 203197
		[Token(Token = "0x40319BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SelectHandCard;

		// Token: 0x040319BE RID: 203198
		[Token(Token = "0x40319BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GoProcessing;

		// Token: 0x040319BF RID: 203199
		[Token(Token = "0x40319BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryProcessNextFrame;

		// Token: 0x040319C0 RID: 203200
		[Token(Token = "0x40319C0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIsBonusFrame;

		// Token: 0x040319C1 RID: 203201
		[Token(Token = "0x40319C1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIsTaskFrame;

		// Token: 0x040319C2 RID: 203202
		[Token(Token = "0x40319C2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EndProcessing;

		// Token: 0x040319C3 RID: 203203
		[Token(Token = "0x40319C3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UnSelectAllCard;

		// Token: 0x040319C4 RID: 203204
		[Token(Token = "0x40319C4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetChallengeTaskFinished;

		// Token: 0x040319C5 RID: 203205
		[Token(Token = "0x40319C5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_NotifyEnterBoard;

		// Token: 0x040319C6 RID: 203206
		[Token(Token = "0x40319C6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_NotifyFirstLoad;

		// Token: 0x040319C7 RID: 203207
		[Token(Token = "0x40319C7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetSelectedCardViewModel;

		// Token: 0x040319C8 RID: 203208
		[Token(Token = "0x40319C8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateRoundId;

		// Token: 0x040319C9 RID: 203209
		[Token(Token = "0x40319C9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
