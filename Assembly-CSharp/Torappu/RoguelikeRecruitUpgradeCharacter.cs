using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200115A RID: 4442
	[Token(Token = "0x200115A")]
	public class RoguelikeRecruitUpgradeCharacter : PlayerCharacter
	{
		// Token: 0x06006F35 RID: 28469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F35")]
		[Address(RVA = "0x2112390", Offset = "0x2110F90", VA = "0x182112390")]
		public RoguelikeRecruitUpgradeCharacter()
		{
		}

		// Token: 0x04005F29 RID: 24361
		[Token(Token = "0x4005F29")]
		[FieldOffset(Offset = "0x90")]
		public int population;

		// Token: 0x04005F2A RID: 24362
		[Token(Token = "0x4005F2A")]
		[FieldOffset(Offset = "0x94")]
		public int isAddition;

		// Token: 0x04005F2B RID: 24363
		[Token(Token = "0x4005F2B")]
		[FieldOffset(Offset = "0x98")]
		public int isElite;

		// Token: 0x04005F2C RID: 24364
		[Token(Token = "0x4005F2C")]
		[FieldOffset(Offset = "0x9C")]
		public int isFree;

		// Token: 0x04005F2D RID: 24365
		[Token(Token = "0x4005F2D")]
		[FieldOffset(Offset = "0xA0")]
		public int upgradePhase;

		// Token: 0x04005F2E RID: 24366
		[Token(Token = "0x4005F2E")]
		[FieldOffset(Offset = "0xA4")]
		public bool upgradeLimited;

		// Token: 0x04005F2F RID: 24367
		[Token(Token = "0x4005F2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
