using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200650E RID: 25870
	[Token(Token = "0x200650E")]
	public class ArtMagazineGetFirstRewardsResponse : PlayerDeltaResponse
	{
		// Token: 0x060252EE RID: 152302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252EE")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ArtMagazineGetFirstRewardsResponse()
		{
		}

		// Token: 0x04034271 RID: 213617
		[Token(Token = "0x4034271")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> rewards;
	}
}
