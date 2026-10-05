using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200642F RID: 25647
	[Token(Token = "0x200642F")]
	public class AutoChessBattleBossBattleGroupInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EBD RID: 151229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EBD")]
		[Address(RVA = "0x1FAF150", Offset = "0x1FADD50", VA = "0x181FAF150", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EBE RID: 151230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EBE")]
		[Address(RVA = "0x1FAF200", Offset = "0x1FADE00", VA = "0x181FAF200")]
		public AutoChessBattleBossBattleGroupInfo()
		{
		}

		// Token: 0x04033A41 RID: 211521
		[Token(Token = "0x4033A41")]
		[FieldOffset(Offset = "0x10")]
		public BossPlayerGroup group;

		// Token: 0x04033A42 RID: 211522
		[Token(Token = "0x4033A42")]
		[FieldOffset(Offset = "0x18")]
		public List<int> players;

		// Token: 0x04033A43 RID: 211523
		[Token(Token = "0x4033A43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A44 RID: 211524
		[Token(Token = "0x4033A44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
