using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200111B RID: 4379
	[Token(Token = "0x200111B")]
	public class NPCUnlock
	{
		// Token: 0x06006EDA RID: 28378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDA")]
		[Address(RVA = "0x2108590", Offset = "0x2107190", VA = "0x182108590")]
		public NPCUnlock()
		{
		}

		// Token: 0x04005DD6 RID: 24022
		[Token(Token = "0x4005DD6")]
		[FieldOffset(Offset = "0x10")]
		public DataUnlockType unLockType;

		// Token: 0x04005DD7 RID: 24023
		[Token(Token = "0x4005DD7")]
		[FieldOffset(Offset = "0x18")]
		public string unLockParam;

		// Token: 0x04005DD8 RID: 24024
		[Token(Token = "0x4005DD8")]
		[FieldOffset(Offset = "0x20")]
		public string unLockString;
	}
}
