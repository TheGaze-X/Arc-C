using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle.Racing
{
	// Token: 0x02002980 RID: 10624
	[Token(Token = "0x2002980")]
	public class RacingBattleManager : IHotfixable
	{
		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x06011913 RID: 71955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026C4")]
		public FreeFollowCameraPlugin cameraPlugin
		{
			[Token(Token = "0x6011913")]
			[Address(RVA = "0x95BE80", Offset = "0x95AA80", VA = "0x18095BE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x06011914 RID: 71956 RVA: 0x0006BEE0 File Offset: 0x0006A0E0
		[Token(Token = "0x170026C5")]
		public int ranking
		{
			[Token(Token = "0x6011914")]
			[Address(RVA = "0x95C100", Offset = "0x95AD00", VA = "0x18095C100")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x06011915 RID: 71957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026C6")]
		public RacingEnemy myRacingEnemy
		{
			[Token(Token = "0x6011915")]
			[Address(RVA = "0x95C030", Offset = "0x95AC30", VA = "0x18095C030")]
			get
			{
				return null;
			}
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x06011916 RID: 71958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026C7")]
		public List<ObjectPtr<RacingEnemy>> racingEnemies
		{
			[Token(Token = "0x6011916")]
			[Address(RVA = "0x95C0A0", Offset = "0x95ACA0", VA = "0x18095C0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011917 RID: 71959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011917")]
		[Address(RVA = "0x95B230", Offset = "0x959E30", VA = "0x18095B230")]
		public void Init(GameModeFactory.RacingGameMode gamemode, RacingInput input)
		{
		}

		// Token: 0x06011918 RID: 71960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011918")]
		[Address(RVA = "0x95BA30", Offset = "0x95A630", VA = "0x18095BA30")]
		private void _ParseCameraPlugin(Blackboard blackboard)
		{
		}

		// Token: 0x06011919 RID: 71961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011919")]
		[Address(RVA = "0x95B5E0", Offset = "0x95A1E0", VA = "0x18095B5E0")]
		public void UseCurrentItem()
		{
		}

		// Token: 0x0601191A RID: 71962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601191A")]
		[Address(RVA = "0x95B170", Offset = "0x959D70", VA = "0x18095B170")]
		public SandboxV2RacingItemInfo GetCurrentItemInfo()
		{
			return null;
		}

		// Token: 0x0601191B RID: 71963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601191B")]
		[Address(RVA = "0x95B6E0", Offset = "0x95A2E0", VA = "0x18095B6E0")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0601191C RID: 71964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601191C")]
		[Address(RVA = "0x95B4F0", Offset = "0x95A0F0", VA = "0x18095B4F0")]
		public void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601191D RID: 71965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601191D")]
		[Address(RVA = "0x95BAF0", Offset = "0x95A6F0", VA = "0x18095BAF0")]
		private void _UpdateRanking()
		{
		}

		// Token: 0x0601191E RID: 71966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601191E")]
		[Address(RVA = "0x95BDD0", Offset = "0x95A9D0", VA = "0x18095BDD0")]
		public RacingBattleManager()
		{
		}

		// Token: 0x04013A45 RID: 80453
		[Token(Token = "0x4013A45")]
		[FieldOffset(Offset = "0x10")]
		private GameModeFactory.RacingGameMode m_gameMode;

		// Token: 0x04013A46 RID: 80454
		[Token(Token = "0x4013A46")]
		[FieldOffset(Offset = "0x18")]
		private RacingInput m_racingInput;

		// Token: 0x04013A47 RID: 80455
		[Token(Token = "0x4013A47")]
		[FieldOffset(Offset = "0x20")]
		private List<ObjectPtr<RacingEnemy>> m_rankingList;

		// Token: 0x04013A48 RID: 80456
		[Token(Token = "0x4013A48")]
		[FieldOffset(Offset = "0x28")]
		private PeriodicTimer m_rankingTimer;

		// Token: 0x04013A49 RID: 80457
		[Token(Token = "0x4013A49")]
		[FieldOffset(Offset = "0x30")]
		private FreeFollowCameraPlugin m_cameraPlugin;

		// Token: 0x04013A4A RID: 80458
		[Token(Token = "0x4013A4A")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<RacingEnemy> m_myRacingEnemy;

		// Token: 0x04013A4B RID: 80459
		[Token(Token = "0x4013A4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameraPlugin;

		// Token: 0x04013A4C RID: 80460
		[Token(Token = "0x4013A4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ranking;

		// Token: 0x04013A4D RID: 80461
		[Token(Token = "0x4013A4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_myRacingEnemy;

		// Token: 0x04013A4E RID: 80462
		[Token(Token = "0x4013A4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_racingEnemies;

		// Token: 0x04013A4F RID: 80463
		[Token(Token = "0x4013A4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013A50 RID: 80464
		[Token(Token = "0x4013A50")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ParseCameraPlugin;

		// Token: 0x04013A51 RID: 80465
		[Token(Token = "0x4013A51")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UseCurrentItem;

		// Token: 0x04013A52 RID: 80466
		[Token(Token = "0x4013A52")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCurrentItemInfo;

		// Token: 0x04013A53 RID: 80467
		[Token(Token = "0x4013A53")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x04013A54 RID: 80468
		[Token(Token = "0x4013A54")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013A55 RID: 80469
		[Token(Token = "0x4013A55")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateRanking;

		// Token: 0x04013A56 RID: 80470
		[Token(Token = "0x4013A56")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
