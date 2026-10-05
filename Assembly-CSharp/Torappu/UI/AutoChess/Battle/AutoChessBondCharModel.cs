using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064D8 RID: 25816
	[Token(Token = "0x20064D8")]
	public class AutoChessBondCharModel : IHotfixable, IComparable<AutoChessBondCharModel>
	{
		// Token: 0x06025184 RID: 151940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025184")]
		[Address(RVA = "0x1FEE440", Offset = "0x1FED040", VA = "0x181FEE440")]
		public void LoadData(string chessId, string bondId, ActAutoChessData actData)
		{
		}

		// Token: 0x06025185 RID: 151941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025185")]
		[Address(RVA = "0x1FEE580", Offset = "0x1FED180", VA = "0x181FEE580")]
		public void UpdateData(int playerIndex)
		{
		}

		// Token: 0x06025186 RID: 151942 RVA: 0x000C66D8 File Offset: 0x000C48D8
		[Token(Token = "0x6025186")]
		[Address(RVA = "0x1FEE3A0", Offset = "0x1FECFA0", VA = "0x181FEE3A0", Slot = "4")]
		public int CompareTo(AutoChessBondCharModel other)
		{
			return 0;
		}

		// Token: 0x06025187 RID: 151943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025187")]
		[Address(RVA = "0x1FEE680", Offset = "0x1FED280", VA = "0x181FEE680")]
		public AutoChessBondCharModel()
		{
		}

		// Token: 0x04033F85 RID: 212869
		[Token(Token = "0x4033F85")]
		[FieldOffset(Offset = "0x10")]
		public string chessId;

		// Token: 0x04033F86 RID: 212870
		[Token(Token = "0x4033F86")]
		[FieldOffset(Offset = "0x18")]
		public string bondId;

		// Token: 0x04033F87 RID: 212871
		[Token(Token = "0x4033F87")]
		[FieldOffset(Offset = "0x20")]
		public int chessLevel;

		// Token: 0x04033F88 RID: 212872
		[Token(Token = "0x4033F88")]
		[FieldOffset(Offset = "0x24")]
		public int identifier;

		// Token: 0x04033F89 RID: 212873
		[Token(Token = "0x4033F89")]
		[FieldOffset(Offset = "0x28")]
		public int playerIdx;

		// Token: 0x04033F8A RID: 212874
		[Token(Token = "0x4033F8A")]
		[FieldOffset(Offset = "0x30")]
		public string charName;

		// Token: 0x04033F8B RID: 212875
		[Token(Token = "0x4033F8B")]
		[FieldOffset(Offset = "0x38")]
		public bool isActive;

		// Token: 0x04033F8C RID: 212876
		[Token(Token = "0x4033F8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033F8D RID: 212877
		[Token(Token = "0x4033F8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033F8E RID: 212878
		[Token(Token = "0x4033F8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04033F8F RID: 212879
		[Token(Token = "0x4033F8F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
