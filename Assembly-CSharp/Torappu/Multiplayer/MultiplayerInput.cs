using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Multiplayer
{
	// Token: 0x0200154F RID: 5455
	[Token(Token = "0x200154F")]
	[Serializable]
	public class MultiplayerInput : IHotfixable
	{
		// Token: 0x06007CB1 RID: 31921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB1")]
		[Address(RVA = "0x28447F0", Offset = "0x28433F0", VA = "0x1828447F0")]
		public MultiplayerInput()
		{
		}

		// Token: 0x04007D45 RID: 32069
		[Token(Token = "0x4007D45")]
		[FieldOffset(Offset = "0x10")]
		public int randomSeed;

		// Token: 0x04007D46 RID: 32070
		[Token(Token = "0x4007D46")]
		[FieldOffset(Offset = "0x18")]
		public string levelId;

		// Token: 0x04007D47 RID: 32071
		[Token(Token = "0x4007D47")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerSquadData myPlayerSquadData;

		// Token: 0x04007D48 RID: 32072
		[Token(Token = "0x4007D48")]
		[FieldOffset(Offset = "0x28")]
		public MultiplayerSquadData anotherPlayerSquadData;

		// Token: 0x04007D49 RID: 32073
		[Token(Token = "0x4007D49")]
		[FieldOffset(Offset = "0x30")]
		public BattlePlayerData anotherPlayerData;

		// Token: 0x04007D4A RID: 32074
		[Token(Token = "0x4007D4A")]
		[FieldOffset(Offset = "0x38")]
		public GameModeFactory.CooperateGameMode.SubGameModeType gameModeType;

		// Token: 0x04007D4B RID: 32075
		[Token(Token = "0x4007D4B")]
		[FieldOffset(Offset = "0x40")]
		public List<MultiplayerInputPlayerInfo> playerInfos;

		// Token: 0x04007D4C RID: 32076
		[Token(Token = "0x4007D4C")]
		[FieldOffset(Offset = "0x48")]
		public bool isMatch;

		// Token: 0x04007D4D RID: 32077
		[Token(Token = "0x4007D4D")]
		[FieldOffset(Offset = "0x49")]
		public bool isInversed;

		// Token: 0x04007D4E RID: 32078
		[Token(Token = "0x4007D4E")]
		[FieldOffset(Offset = "0x4C")]
		public ProfessionCategory myBuff;

		// Token: 0x04007D4F RID: 32079
		[Token(Token = "0x4007D4F")]
		[FieldOffset(Offset = "0x50")]
		public ProfessionCategory mateBuff;

		// Token: 0x04007D50 RID: 32080
		[Token(Token = "0x4007D50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
