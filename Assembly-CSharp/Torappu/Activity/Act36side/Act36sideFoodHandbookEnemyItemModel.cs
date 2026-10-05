using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007450 RID: 29776
	[Token(Token = "0x2007450")]
	public class Act36sideFoodHandbookEnemyItemModel : IComparable<Act36sideFoodHandbookEnemyItemModel>
	{
		// Token: 0x0602A041 RID: 172097 RVA: 0x000D73B8 File Offset: 0x000D55B8
		[Token(Token = "0x602A041")]
		[Address(RVA = "0x259BEB0", Offset = "0x259AAB0", VA = "0x18259BEB0", Slot = "4")]
		public int CompareTo(Act36sideFoodHandbookEnemyItemModel other)
		{
			return 0;
		}

		// Token: 0x0602A042 RID: 172098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A042")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act36sideFoodHandbookEnemyItemModel()
		{
		}

		// Token: 0x0403C422 RID: 246818
		[Token(Token = "0x403C422")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403C423 RID: 246819
		[Token(Token = "0x403C423")]
		[FieldOffset(Offset = "0x18")]
		public string spriteId;

		// Token: 0x0403C424 RID: 246820
		[Token(Token = "0x403C424")]
		[FieldOffset(Offset = "0x20")]
		public string foodAmountIconId;

		// Token: 0x0403C425 RID: 246821
		[Token(Token = "0x403C425")]
		[FieldOffset(Offset = "0x28")]
		public string foodTypeIconId;

		// Token: 0x0403C426 RID: 246822
		[Token(Token = "0x403C426")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x0403C427 RID: 246823
		[Token(Token = "0x403C427")]
		[FieldOffset(Offset = "0x34")]
		public bool isNew;

		// Token: 0x0403C428 RID: 246824
		[Token(Token = "0x403C428")]
		[FieldOffset(Offset = "0x35")]
		public bool isUnlock;
	}
}
