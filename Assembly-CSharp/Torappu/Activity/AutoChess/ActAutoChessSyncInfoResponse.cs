using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070E5 RID: 28901
	[Token(Token = "0x20070E5")]
	public class ActAutoChessSyncInfoResponse : PlayerDeltaResponse
	{
		// Token: 0x06029167 RID: 168295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029167")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActAutoChessSyncInfoResponse()
		{
		}

		// Token: 0x0403AA2B RID: 240171
		[Token(Token = "0x403AA2B")]
		[FieldOffset(Offset = "0x28")]
		public List<string> changed;

		// Token: 0x0403AA2C RID: 240172
		[Token(Token = "0x403AA2C")]
		[FieldOffset(Offset = "0x30")]
		public ActAutoChessSyncInfoBattleInfo battleInfo;
	}
}
