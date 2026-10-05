using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001175 RID: 4469
	[Token(Token = "0x2001175")]
	public class RelicStableUnlockParam
	{
		// Token: 0x06006F63 RID: 28515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F63")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RelicStableUnlockParam()
		{
		}

		// Token: 0x04005FCC RID: 24524
		[Token(Token = "0x4005FCC")]
		[FieldOffset(Offset = "0x10")]
		public string unlockCondDetail;

		// Token: 0x04005FCD RID: 24525
		[Token(Token = "0x4005FCD")]
		[FieldOffset(Offset = "0x18")]
		public int unlockCnt;
	}
}
