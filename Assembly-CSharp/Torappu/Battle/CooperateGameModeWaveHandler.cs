using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200243C RID: 9276
	[Token(Token = "0x200243C")]
	public class CooperateGameModeWaveHandler : Scheduler.DefaultWaveHandler
	{
		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x0600ED26 RID: 60710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001E7A")]
		protected GameModeFactory.CooperateGameMode gameMode
		{
			[Token(Token = "0x600ED26")]
			[Address(RVA = "0x6477F0", Offset = "0x6463F0", VA = "0x1806477F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x0600ED27 RID: 60711 RVA: 0x00056A60 File Offset: 0x00054C60
		[Token(Token = "0x17001E7B")]
		public override bool skipCurWave
		{
			[Token(Token = "0x600ED27")]
			[Address(RVA = "0x647910", Offset = "0x646510", VA = "0x180647910", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ED28 RID: 60712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED28")]
		[Address(RVA = "0x6476C0", Offset = "0x6462C0", VA = "0x1806476C0", Slot = "5")]
		public override IEnumerator WaitForPredelay(LevelData.WaveData wave)
		{
			return null;
		}

		// Token: 0x0600ED29 RID: 60713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED29")]
		[Address(RVA = "0x6475F0", Offset = "0x6461F0", VA = "0x1806475F0", Slot = "6")]
		public override IEnumerator WaitForPostDelay(LevelData.WaveData wave)
		{
			return null;
		}

		// Token: 0x0600ED2A RID: 60714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED2A")]
		[Address(RVA = "0x647330", Offset = "0x645F30", VA = "0x180647330", Slot = "7")]
		public override IEnumerator ExecuteActionQueue()
		{
			return null;
		}

		// Token: 0x0600ED2B RID: 60715 RVA: 0x00056A78 File Offset: 0x00054C78
		[Token(Token = "0x600ED2B")]
		[Address(RVA = "0x6473E0", Offset = "0x645FE0", VA = "0x1806473E0")]
		public bool ReplaceAllActionKeyForLastWave(string key)
		{
			return default(bool);
		}

		// Token: 0x0600ED2C RID: 60716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED2C")]
		[Address(RVA = "0x647790", Offset = "0x646390", VA = "0x180647790")]
		public CooperateGameModeWaveHandler()
		{
		}

		// Token: 0x0600ED2D RID: 60717 RVA: 0x00056A90 File Offset: 0x00054C90
		[Token(Token = "0x600ED2D")]
		[Address(RVA = "0x6475E0", Offset = "0x6461E0", VA = "0x1806475E0")]
		private bool <>xLuaBaseProxy_get_skipCurWave()
		{
			return default(bool);
		}

		// Token: 0x0600ED2E RID: 60718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED2E")]
		[Address(RVA = "0x6475D0", Offset = "0x6461D0", VA = "0x1806475D0")]
		private IEnumerator <>xLuaBaseProxy_WaitForPredelay(LevelData.WaveData P0)
		{
			return null;
		}

		// Token: 0x0600ED2F RID: 60719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED2F")]
		[Address(RVA = "0x6475C0", Offset = "0x6461C0", VA = "0x1806475C0")]
		private IEnumerator <>xLuaBaseProxy_WaitForPostDelay(LevelData.WaveData P0)
		{
			return null;
		}

		// Token: 0x0600ED30 RID: 60720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED30")]
		[Address(RVA = "0x6475B0", Offset = "0x6461B0", VA = "0x1806475B0")]
		private IEnumerator <>xLuaBaseProxy_ExecuteActionQueue()
		{
			return null;
		}

		// Token: 0x0401064E RID: 67150
		[Token(Token = "0x401064E")]
		private const string STAGE_JUDGE_TRAP = "trap_179_muctrl";

		// Token: 0x0401064F RID: 67151
		[Token(Token = "0x401064F")]
		private const string LAST_WAVE_KEY = "boss_wave";

		// Token: 0x04010650 RID: 67152
		[Token(Token = "0x4010650")]
		[FieldOffset(Offset = "0x18")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x04010651 RID: 67153
		[Token(Token = "0x4010651")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x04010652 RID: 67154
		[Token(Token = "0x4010652")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_skipCurWave;

		// Token: 0x04010653 RID: 67155
		[Token(Token = "0x4010653")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_WaitForPredelay;

		// Token: 0x04010654 RID: 67156
		[Token(Token = "0x4010654")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_WaitForPostDelay;

		// Token: 0x04010655 RID: 67157
		[Token(Token = "0x4010655")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ExecuteActionQueue;

		// Token: 0x04010656 RID: 67158
		[Token(Token = "0x4010656")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReplaceAllActionKeyForLastWave;

		// Token: 0x04010657 RID: 67159
		[Token(Token = "0x4010657")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
