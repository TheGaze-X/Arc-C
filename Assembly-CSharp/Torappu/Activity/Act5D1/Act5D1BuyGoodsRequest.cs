using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200721F RID: 29215
	[Token(Token = "0x200721F")]
	public class Act5D1BuyGoodsRequest
	{
		// Token: 0x0602969A RID: 169626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602969A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5D1BuyGoodsRequest()
		{
		}

		// Token: 0x0403B246 RID: 242246
		[Token(Token = "0x403B246")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403B247 RID: 242247
		[Token(Token = "0x403B247")]
		[FieldOffset(Offset = "0x18")]
		public string goodId;

		// Token: 0x0403B248 RID: 242248
		[Token(Token = "0x403B248")]
		[FieldOffset(Offset = "0x20")]
		public int count;
	}
}
