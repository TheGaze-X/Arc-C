using System;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006516 RID: 25878
	[Token(Token = "0x2006516")]
	public class ArtMagazineGetCollectionRewardsRequest
	{
		// Token: 0x060252F6 RID: 152310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineGetCollectionRewardsRequest()
		{
		}

		// Token: 0x0403427A RID: 213626
		[Token(Token = "0x403427A")]
		[FieldOffset(Offset = "0x10")]
		public string setId;

		// Token: 0x0403427B RID: 213627
		[Token(Token = "0x403427B")]
		[FieldOffset(Offset = "0x18")]
		public string missionId;
	}
}
