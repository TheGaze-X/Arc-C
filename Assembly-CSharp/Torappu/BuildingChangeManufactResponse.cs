using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2000641")]
	public class BuildingChangeManufactResponse : PlayerDeltaResponse
	{
		// Token: 0x0600626F RID: 25199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingChangeManufactResponse()
		{
		}

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0x28")]
		public bool change;
	}
}
