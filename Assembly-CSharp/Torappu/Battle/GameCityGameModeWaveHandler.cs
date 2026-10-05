using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002440 RID: 9280
	[Token(Token = "0x2002440")]
	public class GameCityGameModeWaveHandler : Scheduler.DefaultWaveHandler
	{
		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x0600ED43 RID: 60739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001E82")]
		protected GameModeFactory.GameCityGameMode gameMode
		{
			[Token(Token = "0x600ED43")]
			[Address(RVA = "0x64B3F0", Offset = "0x649FF0", VA = "0x18064B3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ED44 RID: 60740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED44")]
		[Address(RVA = "0x64B1D0", Offset = "0x649DD0", VA = "0x18064B1D0", Slot = "6")]
		public override IEnumerator WaitForPostDelay(LevelData.WaveData wave)
		{
			return null;
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600ED45 RID: 60741 RVA: 0x00056AF0 File Offset: 0x00054CF0
		[Token(Token = "0x17001E83")]
		public override bool skipCurWave
		{
			[Token(Token = "0x600ED45")]
			[Address(RVA = "0x64B510", Offset = "0x64A110", VA = "0x18064B510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ED46 RID: 60742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED46")]
		[Address(RVA = "0x64B120", Offset = "0x649D20", VA = "0x18064B120", Slot = "7")]
		public override IEnumerator ExecuteActionQueue()
		{
			return null;
		}

		// Token: 0x0600ED47 RID: 60743 RVA: 0x00056B08 File Offset: 0x00054D08
		[Token(Token = "0x600ED47")]
		[Address(RVA = "0x64B280", Offset = "0x649E80", VA = "0x18064B280")]
		private bool _CheckRestingIsFinish()
		{
			return default(bool);
		}

		// Token: 0x0600ED48 RID: 60744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED48")]
		[Address(RVA = "0x64B390", Offset = "0x649F90", VA = "0x18064B390")]
		public GameCityGameModeWaveHandler()
		{
		}

		// Token: 0x0600ED49 RID: 60745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED49")]
		[Address(RVA = "0x6475C0", Offset = "0x6461C0", VA = "0x1806475C0")]
		private IEnumerator <>xLuaBaseProxy_WaitForPostDelay(LevelData.WaveData P0)
		{
			return null;
		}

		// Token: 0x0600ED4A RID: 60746 RVA: 0x00056B20 File Offset: 0x00054D20
		[Token(Token = "0x600ED4A")]
		[Address(RVA = "0x6475E0", Offset = "0x6461E0", VA = "0x1806475E0")]
		private bool <>xLuaBaseProxy_get_skipCurWave()
		{
			return default(bool);
		}

		// Token: 0x0600ED4B RID: 60747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED4B")]
		[Address(RVA = "0x6475B0", Offset = "0x6461B0", VA = "0x1806475B0")]
		private IEnumerator <>xLuaBaseProxy_ExecuteActionQueue()
		{
			return null;
		}

		// Token: 0x04010667 RID: 67175
		[Token(Token = "0x4010667")]
		[FieldOffset(Offset = "0x18")]
		private GameModeFactory.GameCityGameMode m_gameMode;

		// Token: 0x04010668 RID: 67176
		[Token(Token = "0x4010668")]
		[FieldOffset(Offset = "0x20")]
		private bool isRestTimerSet;

		// Token: 0x04010669 RID: 67177
		[Token(Token = "0x4010669")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x0401066A RID: 67178
		[Token(Token = "0x401066A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_WaitForPostDelay;

		// Token: 0x0401066B RID: 67179
		[Token(Token = "0x401066B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skipCurWave;

		// Token: 0x0401066C RID: 67180
		[Token(Token = "0x401066C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ExecuteActionQueue;

		// Token: 0x0401066D RID: 67181
		[Token(Token = "0x401066D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckRestingIsFinish;

		// Token: 0x0401066E RID: 67182
		[Token(Token = "0x401066E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
