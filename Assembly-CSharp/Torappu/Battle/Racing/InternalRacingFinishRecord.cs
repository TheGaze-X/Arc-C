using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Racing
{
	// Token: 0x0200297C RID: 10620
	[Token(Token = "0x200297C")]
	public struct InternalRacingFinishRecord
	{
		// Token: 0x0601190A RID: 71946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601190A")]
		[Address(RVA = "0x955560", Offset = "0x954160", VA = "0x180955560")]
		public InternalRacingFinishRecord(string id, float time)
		{
		}

		// Token: 0x04013A27 RID: 80423
		[Token(Token = "0x4013A27")]
		[FieldOffset(Offset = "0x0")]
		public string instId;

		// Token: 0x04013A28 RID: 80424
		[Token(Token = "0x4013A28")]
		[FieldOffset(Offset = "0x8")]
		public float finishTime;
	}
}
