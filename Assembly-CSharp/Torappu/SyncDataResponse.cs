using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008C7 RID: 2247
	[Token(Token = "0x20008C7")]
	public class SyncDataResponse : PlayerInitResponse
	{
		// Token: 0x0600657A RID: 25978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657A")]
		[Address(RVA = "0x1F02580", Offset = "0x1F01180", VA = "0x181F02580")]
		public SyncDataResponse()
		{
		}

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0x20")]
		public int result;

		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		[FieldOffset(Offset = "0x28")]
		public long ts;
	}
}
