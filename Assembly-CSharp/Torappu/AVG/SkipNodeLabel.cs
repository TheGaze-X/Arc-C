using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001EB3 RID: 7859
	[Token(Token = "0x2001EB3")]
	[Serializable]
	public struct SkipNodeLabel
	{
		// Token: 0x0600C299 RID: 49817 RVA: 0x00047640 File Offset: 0x00045840
		[Token(Token = "0x600C299")]
		[Address(RVA = "0x3404EA0", Offset = "0x3403AA0", VA = "0x183404EA0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0400C479 RID: 50297
		[Token(Token = "0x400C479")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SkipNodeLabel EMPTY;

		// Token: 0x0400C47A RID: 50298
		[Token(Token = "0x400C47A")]
		[FieldOffset(Offset = "0x0")]
		public int LineNum;

		// Token: 0x0400C47B RID: 50299
		[Token(Token = "0x400C47B")]
		[FieldOffset(Offset = "0x4")]
		public AVGSkipMode Mode;
	}
}
