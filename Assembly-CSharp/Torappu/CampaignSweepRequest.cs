using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006B6 RID: 1718
	[Token(Token = "0x20006B6")]
	public class CampaignSweepRequest
	{
		// Token: 0x060062FF RID: 25343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignSweepRequest()
		{
		}

		// Token: 0x04002EA1 RID: 11937
		[Token(Token = "0x4002EA1")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04002EA2 RID: 11938
		[Token(Token = "0x4002EA2")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x20")]
		public int instId;
	}
}
