using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameCity;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200226F RID: 8815
	[Token(Token = "0x200226F")]
	public class GameCityModeGlobalBuff : GlobalBuff
	{
		// Token: 0x0600DDB7 RID: 56759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB7")]
		[Address(RVA = "0x3635A60", Offset = "0x3634660", VA = "0x183635A60", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DDB8 RID: 56760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB8")]
		[Address(RVA = "0x3635DE0", Offset = "0x36349E0", VA = "0x183635DE0")]
		private void _GetArcgachaDataFromBlackboard()
		{
		}

		// Token: 0x0600DDB9 RID: 56761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB9")]
		[Address(RVA = "0x36362E0", Offset = "0x3634EE0", VA = "0x1836362E0")]
		public GameCityModeGlobalBuff()
		{
		}

		// Token: 0x0600DDBA RID: 56762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDBA")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0400F051 RID: 61521
		[Token(Token = "0x400F051")]
		private const string ARCGACHA_OBJECT_PREFIX = "trap_";

		// Token: 0x0400F052 RID: 61522
		[Token(Token = "0x400F052")]
		private const string ARCGACHA_OBJECT_COUNT_KEY = "cnt";

		// Token: 0x0400F053 RID: 61523
		[Token(Token = "0x400F053")]
		private const string ARCGACHA_OBJECT_WEIGHT_KEY = "weight";

		// Token: 0x0400F054 RID: 61524
		[Token(Token = "0x400F054")]
		[FieldOffset(Offset = "0x148")]
		private FP m_waveDuration;

		// Token: 0x0400F055 RID: 61525
		[Token(Token = "0x400F055")]
		[FieldOffset(Offset = "0x150")]
		private FP m_restDuration;

		// Token: 0x0400F056 RID: 61526
		[Token(Token = "0x400F056")]
		[FieldOffset(Offset = "0x158")]
		private string m_startTrapIds;

		// Token: 0x0400F057 RID: 61527
		[Token(Token = "0x400F057")]
		[FieldOffset(Offset = "0x160")]
		private GameModeFactory.GameCityGameMode m_gameMode;

		// Token: 0x0400F058 RID: 61528
		[Token(Token = "0x400F058")]
		[FieldOffset(Offset = "0x168")]
		private Dictionary<string, GameCityModeBattleData.GameCityArcgachaObjectData> m_tempData;

		// Token: 0x0400F059 RID: 61529
		[Token(Token = "0x400F059")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F05A RID: 61530
		[Token(Token = "0x400F05A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetArcgachaDataFromBlackboard;

		// Token: 0x0400F05B RID: 61531
		[Token(Token = "0x400F05B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
