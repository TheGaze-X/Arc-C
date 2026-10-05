using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064E4 RID: 25828
	[Token(Token = "0x20064E4")]
	public class AutoChessBannedBondItemModel : IHotfixable, IComparable<AutoChessBannedBondItemModel>
	{
		// Token: 0x060251BA RID: 151994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251BA")]
		[Address(RVA = "0x200EA60", Offset = "0x200D660", VA = "0x18200EA60")]
		public void LoadData(string bondId, ActAutoChessData actData, List<string> bannedChessList)
		{
		}

		// Token: 0x060251BB RID: 151995 RVA: 0x000C6738 File Offset: 0x000C4938
		[Token(Token = "0x60251BB")]
		[Address(RVA = "0x200E9C0", Offset = "0x200D5C0", VA = "0x18200E9C0", Slot = "4")]
		public int CompareTo(AutoChessBannedBondItemModel other)
		{
			return 0;
		}

		// Token: 0x060251BC RID: 151996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251BC")]
		[Address(RVA = "0x200EC10", Offset = "0x200D810", VA = "0x18200EC10")]
		public AutoChessBannedBondItemModel()
		{
		}

		// Token: 0x04034019 RID: 213017
		[Token(Token = "0x4034019")]
		[FieldOffset(Offset = "0x10")]
		public string bondId;

		// Token: 0x0403401A RID: 213018
		[Token(Token = "0x403401A")]
		[FieldOffset(Offset = "0x18")]
		public string bondName;

		// Token: 0x0403401B RID: 213019
		[Token(Token = "0x403401B")]
		[FieldOffset(Offset = "0x20")]
		public string bondIcon;

		// Token: 0x0403401C RID: 213020
		[Token(Token = "0x403401C")]
		[FieldOffset(Offset = "0x28")]
		public int absentCnt;

		// Token: 0x0403401D RID: 213021
		[Token(Token = "0x403401D")]
		[FieldOffset(Offset = "0x2C")]
		private int m_identifier;

		// Token: 0x0403401E RID: 213022
		[Token(Token = "0x403401E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403401F RID: 213023
		[Token(Token = "0x403401F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04034020 RID: 213024
		[Token(Token = "0x4034020")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
