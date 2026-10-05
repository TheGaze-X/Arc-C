using System;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076B3 RID: 30387
	[Token(Token = "0x20076B3")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act1VHalfIdleBattleStarter
	{
		// Token: 0x0602ABD5 RID: 175061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABD5")]
		[Address(RVA = "0x2682400", Offset = "0x2681000", VA = "0x182682400")]
		public static void Start(BattleStartParam input)
		{
		}

		// Token: 0x0602ABD6 RID: 175062 RVA: 0x000D9BF0 File Offset: 0x000D7DF0
		[Token(Token = "0x602ABD6")]
		[Address(RVA = "0x2682CA0", Offset = "0x26818A0", VA = "0x182682CA0")]
		private static GameModeMeta _GenGameModeMeta(BattleStartParam input)
		{
			return default(GameModeMeta);
		}

		// Token: 0x0403D93E RID: 252222
		[Token(Token = "0x403D93E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403D93F RID: 252223
		[Token(Token = "0x403D93F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenGameModeMeta;
	}
}
