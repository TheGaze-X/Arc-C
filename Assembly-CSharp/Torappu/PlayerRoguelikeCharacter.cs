using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000AAF RID: 2735
	[Token(Token = "0x2000AAF")]
	public class PlayerRoguelikeCharacter : PlayerCharacter
	{
		// Token: 0x0600676D RID: 26477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676D")]
		[Address(RVA = "0x1EFC880", Offset = "0x1EFB480", VA = "0x181EFC880")]
		public PlayerRoguelikeCharacter()
		{
		}

		// Token: 0x040039AA RID: 14762
		[Token(Token = "0x40039AA")]
		[FieldOffset(Offset = "0x90")]
		public int upgradePhase;

		// Token: 0x040039AB RID: 14763
		[Token(Token = "0x40039AB")]
		[FieldOffset(Offset = "0x94")]
		public bool upgradeLimited;

		// Token: 0x040039AC RID: 14764
		[Token(Token = "0x40039AC")]
		[FieldOffset(Offset = "0x98")]
		public int isAddition;

		// Token: 0x040039AD RID: 14765
		[Token(Token = "0x40039AD")]
		[FieldOffset(Offset = "0x9C")]
		public int isElite;

		// Token: 0x040039AE RID: 14766
		[Token(Token = "0x40039AE")]
		[FieldOffset(Offset = "0xA0")]
		public int isFree;

		// Token: 0x040039AF RID: 14767
		[Token(Token = "0x40039AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
