using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074C5 RID: 29893
	[Token(Token = "0x20074C5")]
	public class Act25sideDailyRefreshResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A297 RID: 172695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A297")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act25sideDailyRefreshResponse()
		{
		}

		// Token: 0x0403C907 RID: 248071
		[Token(Token = "0x403C907")]
		[FieldOffset(Offset = "0x28")]
		public int tokenDelta;

		// Token: 0x0403C908 RID: 248072
		[Token(Token = "0x403C908")]
		[FieldOffset(Offset = "0x2C")]
		public bool reachRecvMax;
	}
}
