using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Racing
{
	// Token: 0x0200297B RID: 10619
	[Token(Token = "0x200297B")]
	public struct RacingCollisionResultData
	{
		// Token: 0x04013A23 RID: 80419
		[Token(Token = "0x4013A23")]
		[FieldOffset(Offset = "0x0")]
		public float speedLoss;

		// Token: 0x04013A24 RID: 80420
		[Token(Token = "0x4013A24")]
		[FieldOffset(Offset = "0x4")]
		public float hpLoss;

		// Token: 0x04013A25 RID: 80421
		[Token(Token = "0x4013A25")]
		[FieldOffset(Offset = "0x8")]
		public float tileColissionSpeedLoss;

		// Token: 0x04013A26 RID: 80422
		[Token(Token = "0x4013A26")]
		[FieldOffset(Offset = "0xC")]
		public float tileColissionHpLoss;
	}
}
