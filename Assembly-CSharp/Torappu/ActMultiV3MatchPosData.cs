using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E44 RID: 3652
	[Token(Token = "0x2000E44")]
	public class ActMultiV3MatchPosData
	{
		// Token: 0x06006B12 RID: 27410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B12")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3MatchPosData()
		{
		}

		// Token: 0x04004C0F RID: 19471
		[Token(Token = "0x4004C0F")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3MatchPosType matchPos;

		// Token: 0x04004C10 RID: 19472
		[Token(Token = "0x4004C10")]
		[FieldOffset(Offset = "0x14")]
		public int sortId;

		// Token: 0x04004C11 RID: 19473
		[Token(Token = "0x4004C11")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04004C12 RID: 19474
		[Token(Token = "0x4004C12")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04004C13 RID: 19475
		[Token(Token = "0x4004C13")]
		[FieldOffset(Offset = "0x28")]
		public string posToast;

		// Token: 0x04004C14 RID: 19476
		[Token(Token = "0x4004C14")]
		[FieldOffset(Offset = "0x30")]
		public string matchDesc;

		// Token: 0x04004C15 RID: 19477
		[Token(Token = "0x4004C15")]
		[FieldOffset(Offset = "0x38")]
		public ActMultiV3MatchPosUnlockCond unlockCond;
	}
}
