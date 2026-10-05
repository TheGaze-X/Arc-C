using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007451 RID: 29777
	[Token(Token = "0x2007451")]
	public class Act36sideFoodHandbookTokenItemModel : IComparable<Act36sideFoodHandbookTokenItemModel>
	{
		// Token: 0x0602A043 RID: 172099 RVA: 0x000D73D0 File Offset: 0x000D55D0
		[Token(Token = "0x602A043")]
		[Address(RVA = "0x259BEB0", Offset = "0x259AAB0", VA = "0x18259BEB0", Slot = "4")]
		public int CompareTo(Act36sideFoodHandbookTokenItemModel other)
		{
			return 0;
		}

		// Token: 0x0602A044 RID: 172100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A044")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act36sideFoodHandbookTokenItemModel()
		{
		}

		// Token: 0x0403C429 RID: 246825
		[Token(Token = "0x403C429")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403C42A RID: 246826
		[Token(Token = "0x403C42A")]
		[FieldOffset(Offset = "0x18")]
		public string spriteId;

		// Token: 0x0403C42B RID: 246827
		[Token(Token = "0x403C42B")]
		[FieldOffset(Offset = "0x20")]
		public string tokenAbility;

		// Token: 0x0403C42C RID: 246828
		[Token(Token = "0x403C42C")]
		[FieldOffset(Offset = "0x28")]
		public string tokenObtain;

		// Token: 0x0403C42D RID: 246829
		[Token(Token = "0x403C42D")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x0403C42E RID: 246830
		[Token(Token = "0x403C42E")]
		[FieldOffset(Offset = "0x34")]
		public bool isNew;

		// Token: 0x0403C42F RID: 246831
		[Token(Token = "0x403C42F")]
		[FieldOffset(Offset = "0x35")]
		public bool isUnlock;
	}
}
