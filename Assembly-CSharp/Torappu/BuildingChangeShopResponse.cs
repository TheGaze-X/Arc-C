using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	public class BuildingChangeShopResponse : PlayerDeltaResponse
	{
		// Token: 0x06006271 RID: 25201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006271")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingChangeShopResponse()
		{
		}

		// Token: 0x04002DFB RID: 11771
		[Token(Token = "0x4002DFB")]
		[FieldOffset(Offset = "0x28")]
		public bool change;
	}
}
