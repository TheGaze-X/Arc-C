using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EB3 RID: 3763
	[Token(Token = "0x2000EB3")]
	public class Act5FunNpcSelectorData
	{
		// Token: 0x06006B85 RID: 27525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B85")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5FunNpcSelectorData()
		{
		}

		// Token: 0x04004F96 RID: 20374
		[Token(Token = "0x4004F96")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;

		// Token: 0x04004F97 RID: 20375
		[Token(Token = "0x4004F97")]
		[FieldOffset(Offset = "0x18")]
		public string enemyId;

		// Token: 0x04004F98 RID: 20376
		[Token(Token = "0x4004F98")]
		[FieldOffset(Offset = "0x20")]
		public float score;
	}
}
