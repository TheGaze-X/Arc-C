using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DB5 RID: 23989
	[Token(Token = "0x2005DB5")]
	public class ClimbTowerEntryGodCardModel : IHotfixable, IComparable
	{
		// Token: 0x06022C6C RID: 142444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C6C")]
		[Address(RVA = "0x1D52D70", Offset = "0x1D51970", VA = "0x181D52D70")]
		public static ClimbTowerEntryGodCardModel LoadData(string cardId, string seasonId)
		{
			return null;
		}

		// Token: 0x06022C6D RID: 142445 RVA: 0x000BEC50 File Offset: 0x000BCE50
		[Token(Token = "0x6022C6D")]
		[Address(RVA = "0x1D52C10", Offset = "0x1D51810", VA = "0x181D52C10", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06022C6E RID: 142446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C6E")]
		[Address(RVA = "0x1D53620", Offset = "0x1D52220", VA = "0x181D53620")]
		public ClimbTowerEntryGodCardModel()
		{
		}

		// Token: 0x0402FD20 RID: 195872
		[Token(Token = "0x402FD20")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0402FD21 RID: 195873
		[Token(Token = "0x402FD21")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0402FD22 RID: 195874
		[Token(Token = "0x402FD22")]
		[FieldOffset(Offset = "0x20")]
		public ClimbTowerCardType cardType;

		// Token: 0x0402FD23 RID: 195875
		[Token(Token = "0x402FD23")]
		[FieldOffset(Offset = "0x28")]
		public string bindTowerName;

		// Token: 0x0402FD24 RID: 195876
		[Token(Token = "0x402FD24")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x0402FD25 RID: 195877
		[Token(Token = "0x402FD25")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x0402FD26 RID: 195878
		[Token(Token = "0x402FD26")]
		[FieldOffset(Offset = "0x40")]
		public bool isNew;

		// Token: 0x0402FD27 RID: 195879
		[Token(Token = "0x402FD27")]
		[FieldOffset(Offset = "0x41")]
		public bool isComplete;

		// Token: 0x0402FD28 RID: 195880
		[Token(Token = "0x402FD28")]
		[FieldOffset(Offset = "0x48")]
		public List<ClimbTowerEntryGodCardModel.GodCardBindTowerStatus> towerStatus;

		// Token: 0x0402FD29 RID: 195881
		[Token(Token = "0x402FD29")]
		[FieldOffset(Offset = "0x50")]
		public List<ClimbTowerEntrySubCardModel> subCardList;

		// Token: 0x0402FD2A RID: 195882
		[Token(Token = "0x402FD2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD2B RID: 195883
		[Token(Token = "0x402FD2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402FD2C RID: 195884
		[Token(Token = "0x402FD2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DB6 RID: 23990
		[Token(Token = "0x2005DB6")]
		public struct GodCardBindTowerStatus
		{
			// Token: 0x0402FD2D RID: 195885
			[Token(Token = "0x402FD2D")]
			[FieldOffset(Offset = "0x0")]
			public string towerId;

			// Token: 0x0402FD2E RID: 195886
			[Token(Token = "0x402FD2E")]
			[FieldOffset(Offset = "0x8")]
			public int sortId;

			// Token: 0x0402FD2F RID: 195887
			[Token(Token = "0x402FD2F")]
			[FieldOffset(Offset = "0xC")]
			public bool isComplete;
		}
	}
}
