using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A1A RID: 2586
	[Token(Token = "0x2000A1A")]
	public class PlayerTroop
	{
		// Token: 0x060066DA RID: 26330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DA")]
		[Address(RVA = "0x1EFFB90", Offset = "0x1EFE790", VA = "0x181EFFB90")]
		public PlayerTroop()
		{
		}

		// Token: 0x040037AE RID: 14254
		[Token(Token = "0x40037AE")]
		[FieldOffset(Offset = "0x10")]
		public int troopCapacity;

		// Token: 0x040037AF RID: 14255
		[Token(Token = "0x40037AF")]
		[FieldOffset(Offset = "0x14")]
		public int curSquadCount;

		// Token: 0x040037B0 RID: 14256
		[Token(Token = "0x40037B0")]
		[FieldOffset(Offset = "0x18")]
		public int curCharInstCount;

		// Token: 0x040037B1 RID: 14257
		[Token(Token = "0x40037B1")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerSquad> squads;

		// Token: 0x040037B2 RID: 14258
		[Token(Token = "0x40037B2")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, PlayerCharacter> chars;

		// Token: 0x040037B3 RID: 14259
		[Token(Token = "0x40037B3")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, PlayerHandBookAddon> addon;

		// Token: 0x040037B4 RID: 14260
		[Token(Token = "0x40037B4")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Dictionary<string, PlayerTroop.CharMissionState>> charMission;

		// Token: 0x040037B5 RID: 14261
		[Token(Token = "0x40037B5")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Dictionary<string, Dictionary<string, PlayerSpecialOperatorNode>>> spOperator;

		// Token: 0x02000A1B RID: 2587
		[Token(Token = "0x2000A1B")]
		public enum CharMissionState
		{
			// Token: 0x040037B7 RID: 14263
			[Token(Token = "0x40037B7")]
			UNCOMPLETE,
			// Token: 0x040037B8 RID: 14264
			[Token(Token = "0x40037B8")]
			FULLFILLED,
			// Token: 0x040037B9 RID: 14265
			[Token(Token = "0x40037B9")]
			COMPLETE
		}
	}
}
