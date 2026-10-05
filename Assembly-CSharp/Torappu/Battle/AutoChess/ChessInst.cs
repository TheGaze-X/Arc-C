using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002777 RID: 10103
	[Token(Token = "0x2002777")]
	public class ChessInst : IComparable<ChessInst>, IHotfixable
	{
		// Token: 0x060107CD RID: 67533 RVA: 0x000647A0 File Offset: 0x000629A0
		[Token(Token = "0x60107CD")]
		[Address(RVA = "0x850660", Offset = "0x84F260", VA = "0x180850660", Slot = "4")]
		public int CompareTo(ChessInst other)
		{
			return 0;
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x060107CE RID: 67534 RVA: 0x000647B8 File Offset: 0x000629B8
		[Token(Token = "0x170023F5")]
		public bool isInHand
		{
			[Token(Token = "0x60107CE")]
			[Address(RVA = "0x850B90", Offset = "0x84F790", VA = "0x180850B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x060107CF RID: 67535 RVA: 0x000647D0 File Offset: 0x000629D0
		[Token(Token = "0x170023F6")]
		public bool isInBattle
		{
			[Token(Token = "0x60107CF")]
			[Address(RVA = "0x850B30", Offset = "0x84F730", VA = "0x180850B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x060107D0 RID: 67536 RVA: 0x000647E8 File Offset: 0x000629E8
		[Token(Token = "0x170023F7")]
		public bool isCharacter
		{
			[Token(Token = "0x60107D0")]
			[Address(RVA = "0x850A70", Offset = "0x84F670", VA = "0x180850A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x060107D1 RID: 67537 RVA: 0x00064800 File Offset: 0x00062A00
		[Token(Token = "0x170023F8")]
		public bool isToken
		{
			[Token(Token = "0x60107D1")]
			[Address(RVA = "0x850C50", Offset = "0x84F850", VA = "0x180850C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x060107D2 RID: 67538 RVA: 0x00064818 File Offset: 0x00062A18
		[Token(Token = "0x170023F9")]
		public bool isEquip
		{
			[Token(Token = "0x60107D2")]
			[Address(RVA = "0x850AD0", Offset = "0x84F6D0", VA = "0x180850AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x060107D3 RID: 67539 RVA: 0x00064830 File Offset: 0x00062A30
		[Token(Token = "0x170023FA")]
		public bool isMagic
		{
			[Token(Token = "0x60107D3")]
			[Address(RVA = "0x850BF0", Offset = "0x84F7F0", VA = "0x180850BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060107D4 RID: 67540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60107D4")]
		[Address(RVA = "0x8508D0", Offset = "0x84F4D0", VA = "0x1808508D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060107D5 RID: 67541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107D5")]
		[Address(RVA = "0x850A10", Offset = "0x84F610", VA = "0x180850A10")]
		public ChessInst()
		{
		}

		// Token: 0x060107D6 RID: 67542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60107D6")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x040127AA RID: 75690
		[Token(Token = "0x40127AA")]
		private const int TOKEN_COMPARE_OFFSET = 1000;

		// Token: 0x040127AB RID: 75691
		[Token(Token = "0x40127AB")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x040127AC RID: 75692
		[Token(Token = "0x40127AC")]
		[FieldOffset(Offset = "0x18")]
		public string chessId;

		// Token: 0x040127AD RID: 75693
		[Token(Token = "0x40127AD")]
		[FieldOffset(Offset = "0x20")]
		public AdvancedCharacterInst charInst;

		// Token: 0x040127AE RID: 75694
		[Token(Token = "0x40127AE")]
		[FieldOffset(Offset = "0x28")]
		public SharedConsts.Direction dir;

		// Token: 0x040127AF RID: 75695
		[Token(Token = "0x40127AF")]
		[FieldOffset(Offset = "0x2C")]
		public GridPosition pos;

		// Token: 0x040127B0 RID: 75696
		[Token(Token = "0x40127B0")]
		[FieldOffset(Offset = "0x34")]
		public AutoChessItemType chessType;

		// Token: 0x040127B1 RID: 75697
		[Token(Token = "0x40127B1")]
		[FieldOffset(Offset = "0x38")]
		public PlayerSide side;

		// Token: 0x040127B2 RID: 75698
		[Token(Token = "0x40127B2")]
		[FieldOffset(Offset = "0x3C")]
		public int playerIndex;

		// Token: 0x040127B3 RID: 75699
		[Token(Token = "0x40127B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040127B4 RID: 75700
		[Token(Token = "0x40127B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isInHand;

		// Token: 0x040127B5 RID: 75701
		[Token(Token = "0x40127B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isInBattle;

		// Token: 0x040127B6 RID: 75702
		[Token(Token = "0x40127B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isCharacter;

		// Token: 0x040127B7 RID: 75703
		[Token(Token = "0x40127B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isToken;

		// Token: 0x040127B8 RID: 75704
		[Token(Token = "0x40127B8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isEquip;

		// Token: 0x040127B9 RID: 75705
		[Token(Token = "0x40127B9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isMagic;

		// Token: 0x040127BA RID: 75706
		[Token(Token = "0x40127BA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ToString;

		// Token: 0x040127BB RID: 75707
		[Token(Token = "0x40127BB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
