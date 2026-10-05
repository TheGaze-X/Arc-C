using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI.Cooperate;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200226C RID: 8812
	[Token(Token = "0x200226C")]
	public class CooperateFortressGlobalBuff : GlobalBuff
	{
		// Token: 0x0600DD96 RID: 56726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD96")]
		[Address(RVA = "0x362F120", Offset = "0x362DD20", VA = "0x18362F120", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DD97 RID: 56727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD97")]
		[Address(RVA = "0x362F8D0", Offset = "0x362E4D0", VA = "0x18362F8D0")]
		private void _OnWaveWillStart()
		{
		}

		// Token: 0x0600DD98 RID: 56728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD98")]
		[Address(RVA = "0x362F950", Offset = "0x362E550", VA = "0x18362F950")]
		private void _BeforeResting(object args)
		{
		}

		// Token: 0x0600DD99 RID: 56729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD99")]
		[Address(RVA = "0x362FCF0", Offset = "0x362E8F0", VA = "0x18362FCF0")]
		private void _BeforeWaveFinish(object args)
		{
		}

		// Token: 0x0600DD9A RID: 56730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD9A")]
		[Address(RVA = "0x362F690", Offset = "0x362E290", VA = "0x18362F690", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DD9B RID: 56731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD9B")]
		[Address(RVA = "0x362FE30", Offset = "0x362EA30", VA = "0x18362FE30")]
		private void _FinishCurWaveBecauseTimeUp()
		{
		}

		// Token: 0x0600DD9C RID: 56732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD9C")]
		[Address(RVA = "0x36300E0", Offset = "0x362ECE0", VA = "0x1836300E0")]
		public CooperateFortressGlobalBuff()
		{
		}

		// Token: 0x0600DD9E RID: 56734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD9E")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DD9F RID: 56735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD9F")]
		[Address(RVA = "0x362C380", Offset = "0x362AF80", VA = "0x18362C380")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F015 RID: 61461
		[Token(Token = "0x400F015")]
		private const string REST_TIME = "rest_time";

		// Token: 0x0400F016 RID: 61462
		[Token(Token = "0x400F016")]
		private const string WAVE_TIME = "wave_time";

		// Token: 0x0400F017 RID: 61463
		[Token(Token = "0x400F017")]
		private const string WAVE_TIME_LAST = "wave_time_last";

		// Token: 0x0400F018 RID: 61464
		[Token(Token = "0x400F018")]
		private const string LIFE_POINT = "life_point";

		// Token: 0x0400F019 RID: 61465
		[Token(Token = "0x400F019")]
		private const string REST_TIME_ADD = "rest_add";

		// Token: 0x0400F01A RID: 61466
		[Token(Token = "0x400F01A")]
		[FieldOffset(Offset = "0x148")]
		private FP m_waveTime;

		// Token: 0x0400F01B RID: 61467
		[Token(Token = "0x400F01B")]
		[FieldOffset(Offset = "0x150")]
		private FP m_waveTimeLast;

		// Token: 0x0400F01C RID: 61468
		[Token(Token = "0x400F01C")]
		[FieldOffset(Offset = "0x158")]
		private int m_waveLifePoint;

		// Token: 0x0400F01D RID: 61469
		[Token(Token = "0x400F01D")]
		[FieldOffset(Offset = "0x160")]
		private FP m_waveReadyTime;

		// Token: 0x0400F01E RID: 61470
		[Token(Token = "0x400F01E")]
		[FieldOffset(Offset = "0x168")]
		private int m_reviveLifePoint;

		// Token: 0x0400F01F RID: 61471
		[Token(Token = "0x400F01F")]
		[FieldOffset(Offset = "0x16C")]
		private bool m_inPlayState;

		// Token: 0x0400F020 RID: 61472
		[Token(Token = "0x400F020")]
		[FieldOffset(Offset = "0x170")]
		private int m_waveAddime;

		// Token: 0x0400F021 RID: 61473
		[Token(Token = "0x400F021")]
		[FieldOffset(Offset = "0x178")]
		private FP m_remaningDuration;

		// Token: 0x0400F022 RID: 61474
		[Token(Token = "0x400F022")]
		[FieldOffset(Offset = "0x180")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x0400F023 RID: 61475
		[Token(Token = "0x400F023")]
		[FieldOffset(Offset = "0x188")]
		private CooperateUIPlugin m_cooperatePlugin;

		// Token: 0x0400F024 RID: 61476
		[Token(Token = "0x400F024")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F025 RID: 61477
		[Token(Token = "0x400F025")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnWaveWillStart;

		// Token: 0x0400F026 RID: 61478
		[Token(Token = "0x400F026")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BeforeResting;

		// Token: 0x0400F027 RID: 61479
		[Token(Token = "0x400F027")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__BeforeWaveFinish;

		// Token: 0x0400F028 RID: 61480
		[Token(Token = "0x400F028")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F029 RID: 61481
		[Token(Token = "0x400F029")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FinishCurWaveBecauseTimeUp;

		// Token: 0x0400F02A RID: 61482
		[Token(Token = "0x400F02A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
