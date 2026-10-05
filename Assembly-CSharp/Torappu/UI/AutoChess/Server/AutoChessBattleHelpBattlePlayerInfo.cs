using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006433 RID: 25651
	[Token(Token = "0x2006433")]
	public class AutoChessBattleHelpBattlePlayerInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EC5 RID: 151237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC5")]
		[Address(RVA = "0x1FC5840", Offset = "0x1FC4440", VA = "0x181FC5840", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EC6 RID: 151238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC6")]
		[Address(RVA = "0x1FC5910", Offset = "0x1FC4510", VA = "0x181FC5910")]
		public AutoChessBattleHelpBattlePlayerInfo()
		{
		}

		// Token: 0x04033A51 RID: 211537
		[Token(Token = "0x4033A51")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessBattlePlayerDeploymentInfo deployment;

		// Token: 0x04033A52 RID: 211538
		[Token(Token = "0x4033A52")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessBattleCharBattleStatus> charBattleStatusList;

		// Token: 0x04033A53 RID: 211539
		[Token(Token = "0x4033A53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A54 RID: 211540
		[Token(Token = "0x4033A54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
