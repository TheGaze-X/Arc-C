using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006EC RID: 1772
	[Token(Token = "0x20006EC")]
	public class EvolveCharRequest
	{
		// Token: 0x06006342 RID: 25410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006342")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EvolveCharRequest()
		{
		}

		// Token: 0x04002F0C RID: 12044
		[Token(Token = "0x4002F0C")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04002F0D RID: 12045
		[Token(Token = "0x4002F0D")]
		[FieldOffset(Offset = "0x14")]
		public EvolvePhase destEvolvePhase;
	}
}
