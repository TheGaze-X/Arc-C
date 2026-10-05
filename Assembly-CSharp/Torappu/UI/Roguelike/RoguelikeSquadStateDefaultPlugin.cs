using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005533 RID: 21811
	[Token(Token = "0x2005533")]
	public class RoguelikeSquadStateDefaultPlugin : RoguelikeSquadStatePlugin
	{
		// Token: 0x06020142 RID: 131394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020142")]
		[Address(RVA = "0x1A3CCD0", Offset = "0x1A3B8D0", VA = "0x181A3CCD0", Slot = "5")]
		public override IRoguelikeSquadBattleStartHandler GetCustomSquadStartBattleHandler()
		{
			return null;
		}

		// Token: 0x06020143 RID: 131395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020143")]
		[Address(RVA = "0x1A3CE00", Offset = "0x1A3BA00", VA = "0x181A3CE00")]
		public RoguelikeSquadStateDefaultPlugin()
		{
		}

		// Token: 0x06020144 RID: 131396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020144")]
		[Address(RVA = "0x1A3CDA0", Offset = "0x1A3B9A0", VA = "0x181A3CDA0")]
		private IRoguelikeSquadBattleStartHandler <>xLuaBaseProxy_GetCustomSquadStartBattleHandler()
		{
			return null;
		}

		// Token: 0x0402B523 RID: 177443
		[Token(Token = "0x402B523")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCustomSquadStartBattleHandler;

		// Token: 0x0402B524 RID: 177444
		[Token(Token = "0x402B524")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
