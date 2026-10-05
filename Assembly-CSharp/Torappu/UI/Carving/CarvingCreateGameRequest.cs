using System;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x020060A9 RID: 24745
	[Token(Token = "0x20060A9")]
	public class CarvingCreateGameRequest
	{
		// Token: 0x06023CB9 RID: 146617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CB9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CarvingCreateGameRequest()
		{
		}

		// Token: 0x04031A1D RID: 203293
		[Token(Token = "0x4031A1D")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04031A1E RID: 203294
		[Token(Token = "0x4031A1E")]
		[FieldOffset(Offset = "0x18")]
		public string challengeId;
	}
}
