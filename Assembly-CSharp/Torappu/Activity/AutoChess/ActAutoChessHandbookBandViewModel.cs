using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007109 RID: 28937
	[Token(Token = "0x2007109")]
	public class ActAutoChessHandbookBandViewModel : ActAutoChessHandbookItemModelBase, IComparable
	{
		// Token: 0x060291E8 RID: 168424 RVA: 0x000D48B0 File Offset: 0x000D2AB0
		[Token(Token = "0x60291E8")]
		[Address(RVA = "0x2482860", Offset = "0x2481460", VA = "0x182482860", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060291E9 RID: 168425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291E9")]
		[Address(RVA = "0x2482960", Offset = "0x2481560", VA = "0x182482960")]
		public ActAutoChessHandbookBandViewModel()
		{
		}

		// Token: 0x0403AB49 RID: 240457
		[Token(Token = "0x403AB49")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0403AB4A RID: 240458
		[Token(Token = "0x403AB4A")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x0403AB4B RID: 240459
		[Token(Token = "0x403AB4B")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x0403AB4C RID: 240460
		[Token(Token = "0x403AB4C")]
		[FieldOffset(Offset = "0x38")]
		public string totalHp;

		// Token: 0x0403AB4D RID: 240461
		[Token(Token = "0x403AB4D")]
		[FieldOffset(Offset = "0x40")]
		public bool isNew;

		// Token: 0x0403AB4E RID: 240462
		[Token(Token = "0x403AB4E")]
		[FieldOffset(Offset = "0x41")]
		public bool isLocked;

		// Token: 0x0403AB4F RID: 240463
		[Token(Token = "0x403AB4F")]
		[FieldOffset(Offset = "0x42")]
		public bool isBanned;

		// Token: 0x0403AB50 RID: 240464
		[Token(Token = "0x403AB50")]
		[FieldOffset(Offset = "0x48")]
		public TimeSpan timeDelta;

		// Token: 0x0403AB51 RID: 240465
		[Token(Token = "0x403AB51")]
		[FieldOffset(Offset = "0x50")]
		public int completeTimes;

		// Token: 0x0403AB52 RID: 240466
		[Token(Token = "0x403AB52")]
		[FieldOffset(Offset = "0x54")]
		public bool showVictorIcon;

		// Token: 0x0403AB53 RID: 240467
		[Token(Token = "0x403AB53")]
		[FieldOffset(Offset = "0x58")]
		public string completeTimesDesc;

		// Token: 0x0403AB54 RID: 240468
		[Token(Token = "0x403AB54")]
		[FieldOffset(Offset = "0x60")]
		public int sortId;

		// Token: 0x0403AB55 RID: 240469
		[Token(Token = "0x403AB55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403AB56 RID: 240470
		[Token(Token = "0x403AB56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
