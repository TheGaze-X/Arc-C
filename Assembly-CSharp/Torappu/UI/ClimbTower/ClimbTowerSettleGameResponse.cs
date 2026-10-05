using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C83 RID: 23683
	[Token(Token = "0x2005C83")]
	public class ClimbTowerSettleGameResponse : PlayerDeltaResponse
	{
		// Token: 0x060224FF RID: 140543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224FF")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ClimbTowerSettleGameResponse()
		{
		}

		// Token: 0x0402F1C8 RID: 192968
		[Token(Token = "0x402F1C8")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty(PropertyName = "ts")]
		public long finishTs;
	}
}
