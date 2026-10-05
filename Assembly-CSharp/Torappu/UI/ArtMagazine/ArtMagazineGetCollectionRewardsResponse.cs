using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006517 RID: 25879
	[Token(Token = "0x2006517")]
	public class ArtMagazineGetCollectionRewardsResponse : PlayerDeltaResponse
	{
		// Token: 0x060252F7 RID: 152311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252F7")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ArtMagazineGetCollectionRewardsResponse()
		{
		}

		// Token: 0x0403427C RID: 213628
		[Token(Token = "0x403427C")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> rewards;
	}
}
