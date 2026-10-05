using System;
using Il2CppDummyDll;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004828 RID: 18472
	[Token(Token = "0x2004828")]
	public class MonopolyService
	{
		// Token: 0x0601BEC3 RID: 114371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEC3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MonopolyService()
		{
		}

		// Token: 0x04024670 RID: 149104
		[Token(Token = "0x4024670")]
		public const string MONOPOLY_START_GAME = "/activity/act46side/startGame";

		// Token: 0x04024671 RID: 149105
		[Token(Token = "0x4024671")]
		public const string MONOPOLY_MOVE = "/activity/act46side/move";

		// Token: 0x04024672 RID: 149106
		[Token(Token = "0x4024672")]
		public const string MONOPOLY_MINING = "/activity/act46side/mining";

		// Token: 0x04024673 RID: 149107
		[Token(Token = "0x4024673")]
		public const string MONOPOLY_END_ROUND = "/activity/act46side/endRound";

		// Token: 0x04024674 RID: 149108
		[Token(Token = "0x4024674")]
		public const string MONOPOLY_SETTLE_GAME = "/activity/act46side/settleGame";
	}
}
