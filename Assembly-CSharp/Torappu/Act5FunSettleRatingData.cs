using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EBA RID: 3770
	[Token(Token = "0x2000EBA")]
	public class Act5FunSettleRatingData
	{
		// Token: 0x06006B8B RID: 27531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B8B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5FunSettleRatingData()
		{
		}

		// Token: 0x04004FBE RID: 20414
		[Token(Token = "0x4004FBE")]
		[FieldOffset(Offset = "0x10")]
		public int minRating;

		// Token: 0x04004FBF RID: 20415
		[Token(Token = "0x4004FBF")]
		[FieldOffset(Offset = "0x14")]
		public int maxRating;

		// Token: 0x04004FC0 RID: 20416
		[Token(Token = "0x4004FC0")]
		[FieldOffset(Offset = "0x18")]
		public string ratingDesc;
	}
}
