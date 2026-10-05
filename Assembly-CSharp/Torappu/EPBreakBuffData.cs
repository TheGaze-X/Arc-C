using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	[Serializable]
	public class EPBreakBuffData
	{
		// Token: 0x06004CEB RID: 19691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EPBreakBuffData()
		{
		}

		// Token: 0x040010EA RID: 4330
		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x10")]
		public float elementBreakDuration;

		// Token: 0x040010EB RID: 4331
		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x14")]
		public float enemyElementBreakDuration;

		// Token: 0x040010EC RID: 4332
		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x18")]
		public List<string> elementBuffs;
	}
}
