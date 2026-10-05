using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039B8 RID: 14776
	[Token(Token = "0x20039B8")]
	public class SetDateViewModel : IHotfixable
	{
		// Token: 0x06017592 RID: 95634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017592")]
		[Address(RVA = "0xFB7040", Offset = "0xFB5C40", VA = "0x180FB7040")]
		public void InitData(int initMonth, int initDay)
		{
		}

		// Token: 0x06017593 RID: 95635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017593")]
		[Address(RVA = "0xFB7210", Offset = "0xFB5E10", VA = "0x180FB7210")]
		public void LoadData()
		{
		}

		// Token: 0x06017594 RID: 95636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017594")]
		[Address(RVA = "0xFB7440", Offset = "0xFB6040", VA = "0x180FB7440")]
		private void _LoadDays(int curMonth)
		{
		}

		// Token: 0x06017595 RID: 95637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017595")]
		[Address(RVA = "0xFB75B0", Offset = "0xFB61B0", VA = "0x180FB75B0")]
		public SetDateViewModel()
		{
		}

		// Token: 0x0401C31A RID: 115482
		[Token(Token = "0x401C31A")]
		private const int MONTH_IN_YEAR = 12;

		// Token: 0x0401C31B RID: 115483
		[Token(Token = "0x401C31B")]
		private const int SAMPLE_LEAP_YEAR = 2024;

		// Token: 0x0401C31C RID: 115484
		[Token(Token = "0x401C31C")]
		[FieldOffset(Offset = "0x10")]
		public SetDateListViewModel monthModel;

		// Token: 0x0401C31D RID: 115485
		[Token(Token = "0x401C31D")]
		[FieldOffset(Offset = "0x18")]
		public SetDateListViewModel dayModel;

		// Token: 0x0401C31E RID: 115486
		[Token(Token = "0x401C31E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401C31F RID: 115487
		[Token(Token = "0x401C31F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401C320 RID: 115488
		[Token(Token = "0x401C320")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadDays;

		// Token: 0x0401C321 RID: 115489
		[Token(Token = "0x401C321")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
