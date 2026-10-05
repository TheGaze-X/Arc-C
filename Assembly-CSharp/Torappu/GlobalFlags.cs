using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	public static class GlobalFlags
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
		[Token(Token = "0x17000239")]
		public static bool PRELOAD_CHARACTER_ILLUSTRATIONS
		{
			[Token(Token = "0x6004EB5")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040012DD RID: 4829
		[Token(Token = "0x40012DD")]
		public const bool ENABLE_PAPER_MARIO = true;

		// Token: 0x040012DE RID: 4830
		[Token(Token = "0x40012DE")]
		public const bool ALLOW_WITHDRAW_GAIN_COST = true;

		// Token: 0x040012DF RID: 4831
		[Token(Token = "0x40012DF")]
		public const bool ENABLE_CHARACTER_LIMIT = true;

		// Token: 0x040012E0 RID: 4832
		[Token(Token = "0x40012E0")]
		public const bool CHECK_INVALID_INPUT_ON_CLIENT = true;

		// Token: 0x040012E1 RID: 4833
		[Token(Token = "0x40012E1")]
		public const bool ENABLE_CAMERA_EFFECT = true;
	}
}
