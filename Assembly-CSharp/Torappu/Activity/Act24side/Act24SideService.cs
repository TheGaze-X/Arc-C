using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007547 RID: 30023
	[Token(Token = "0x2007547")]
	public class Act24SideService : IHotfixable
	{
		// Token: 0x0602A4CA RID: 173258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4CA")]
		[Address(RVA = "0x25F31B0", Offset = "0x25F1DB0", VA = "0x1825F31B0")]
		public Act24SideService()
		{
		}

		// Token: 0x0403CD15 RID: 249109
		[Token(Token = "0x403CD15")]
		public const string EAT = "/activity/act24side/eat";

		// Token: 0x0403CD16 RID: 249110
		[Token(Token = "0x403CD16")]
		public const string SET_TOOL = "/activity/act24side/setTool";

		// Token: 0x0403CD17 RID: 249111
		[Token(Token = "0x403CD17")]
		public const string ALCHEMY = "/activity/act24side/alchemy";

		// Token: 0x0403CD18 RID: 249112
		[Token(Token = "0x403CD18")]
		public const string BATTLE_START = "/activity/act24side/battleStart";

		// Token: 0x0403CD19 RID: 249113
		[Token(Token = "0x403CD19")]
		public const string BATTLE_FINISH = "/activity/act24side/battleFinish";

		// Token: 0x0403CD1A RID: 249114
		[Token(Token = "0x403CD1A")]
		public const string GET_HUNT_WIKI_REWARD = "/activity/act24side/getHuntCollectRewards";

		// Token: 0x0403CD1B RID: 249115
		[Token(Token = "0x403CD1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
