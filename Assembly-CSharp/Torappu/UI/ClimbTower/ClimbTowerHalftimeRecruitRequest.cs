using System;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C88 RID: 23688
	[Token(Token = "0x2005C88")]
	public class ClimbTowerHalftimeRecruitRequest
	{
		// Token: 0x06022504 RID: 140548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022504")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerHalftimeRecruitRequest()
		{
		}

		// Token: 0x0402F1CC RID: 192972
		[Token(Token = "0x402F1CC")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0402F1CD RID: 192973
		[Token(Token = "0x402F1CD")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x0402F1CE RID: 192974
		[Token(Token = "0x402F1CE")]
		[FieldOffset(Offset = "0x20")]
		public bool giveUp;
	}
}
