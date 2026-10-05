using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F12 RID: 24338
	[Token(Token = "0x2005F12")]
	public class CharacterLvlupItemCollectionViewModel : IHotfixable
	{
		// Token: 0x17005361 RID: 21345
		// (get) Token: 0x06023428 RID: 144424 RVA: 0x000C0498 File Offset: 0x000BE698
		[Token(Token = "0x17005361")]
		public int expItemCount
		{
			[Token(Token = "0x6023428")]
			[Address(RVA = "0x1DC78B0", Offset = "0x1DC64B0", VA = "0x181DC78B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005362 RID: 21346
		// (get) Token: 0x06023429 RID: 144425 RVA: 0x000C04B0 File Offset: 0x000BE6B0
		[Token(Token = "0x17005362")]
		public long requireGoldCount
		{
			[Token(Token = "0x6023429")]
			[Address(RVA = "0x1DC7940", Offset = "0x1DC6540", VA = "0x181DC7940")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0602342A RID: 144426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602342A")]
		[Address(RVA = "0x1DC7170", Offset = "0x1DC5D70", VA = "0x181DC7170")]
		public void LoadData()
		{
		}

		// Token: 0x0602342B RID: 144427 RVA: 0x000C04C8 File Offset: 0x000BE6C8
		[Token(Token = "0x602342B")]
		[Address(RVA = "0x1DC6C20", Offset = "0x1DC5820", VA = "0x181DC6C20")]
		public int CalcCurrentAddExp()
		{
			return 0;
		}

		// Token: 0x0602342C RID: 144428 RVA: 0x000C04E0 File Offset: 0x000BE6E0
		[Token(Token = "0x602342C")]
		[Address(RVA = "0x1DC6A60", Offset = "0x1DC5660", VA = "0x181DC6A60")]
		public int CalcAddExpFromCounts(int[] countArray)
		{
			return 0;
		}

		// Token: 0x0602342D RID: 144429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602342D")]
		[Address(RVA = "0x1DC6F70", Offset = "0x1DC5B70", VA = "0x181DC6F70")]
		public void ChangeToSelectableMode()
		{
		}

		// Token: 0x0602342E RID: 144430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602342E")]
		[Address(RVA = "0x1DC6DB0", Offset = "0x1DC59B0", VA = "0x181DC6DB0")]
		public void ChangeToCountingMode()
		{
		}

		// Token: 0x0602342F RID: 144431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602342F")]
		[Address(RVA = "0x1DC6E90", Offset = "0x1DC5A90", VA = "0x181DC6E90")]
		public void ChangeToDisplayMode()
		{
		}

		// Token: 0x06023430 RID: 144432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023430")]
		[Address(RVA = "0x1DC76E0", Offset = "0x1DC62E0", VA = "0x181DC76E0")]
		public void UpdateExpsCountAndGold(int[] countArray, long gold)
		{
		}

		// Token: 0x06023431 RID: 144433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023431")]
		[Address(RVA = "0x1DC7050", Offset = "0x1DC5C50", VA = "0x181DC7050")]
		public int[] GetExpCountArray()
		{
			return null;
		}

		// Token: 0x06023432 RID: 144434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023432")]
		[Address(RVA = "0x1DC7850", Offset = "0x1DC6450", VA = "0x181DC7850")]
		public CharacterLvlupItemCollectionViewModel()
		{
		}

		// Token: 0x04030985 RID: 199045
		[Token(Token = "0x4030985")]
		[FieldOffset(Offset = "0x10")]
		public CharacterLvlupItemCardViewModel[] expItems;

		// Token: 0x04030986 RID: 199046
		[Token(Token = "0x4030986")]
		[FieldOffset(Offset = "0x18")]
		public CharacterLvlupItemCardViewModel goldItem;

		// Token: 0x04030987 RID: 199047
		[Token(Token = "0x4030987")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_expItemCount;

		// Token: 0x04030988 RID: 199048
		[Token(Token = "0x4030988")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_requireGoldCount;

		// Token: 0x04030989 RID: 199049
		[Token(Token = "0x4030989")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403098A RID: 199050
		[Token(Token = "0x403098A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalcCurrentAddExp;

		// Token: 0x0403098B RID: 199051
		[Token(Token = "0x403098B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CalcAddExpFromCounts;

		// Token: 0x0403098C RID: 199052
		[Token(Token = "0x403098C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangeToSelectableMode;

		// Token: 0x0403098D RID: 199053
		[Token(Token = "0x403098D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ChangeToCountingMode;

		// Token: 0x0403098E RID: 199054
		[Token(Token = "0x403098E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ChangeToDisplayMode;

		// Token: 0x0403098F RID: 199055
		[Token(Token = "0x403098F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateExpsCountAndGold;

		// Token: 0x04030990 RID: 199056
		[Token(Token = "0x4030990")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetExpCountArray;

		// Token: 0x04030991 RID: 199057
		[Token(Token = "0x4030991")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
