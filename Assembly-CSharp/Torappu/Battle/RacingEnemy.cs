using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Racing;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023E6 RID: 9190
	[Token(Token = "0x20023E6")]
	public class RacingEnemy : Enemy
	{
		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x0600EA8E RID: 60046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DE2")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy", Priority = -100)]
		public RacingEnemyData racingData
		{
			[Token(Token = "0x600EA8E")]
			[Address(RVA = "0x60BCD0", Offset = "0x60A8D0", VA = "0x18060BCD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x0600EA8F RID: 60047 RVA: 0x00055E30 File Offset: 0x00054030
		[Token(Token = "0x17001DE3")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy")]
		public FP racingMaxMoveSpeed
		{
			[Token(Token = "0x600EA8F")]
			[Address(RVA = "0x60BF60", Offset = "0x60AB60", VA = "0x18060BF60")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x0600EA90 RID: 60048 RVA: 0x00055E48 File Offset: 0x00054048
		[Token(Token = "0x17001DE4")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy")]
		public FP racingAcceleration
		{
			[Token(Token = "0x600EA90")]
			[Address(RVA = "0x60BC00", Offset = "0x60A800", VA = "0x18060BC00")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x0600EA91 RID: 60049 RVA: 0x00055E60 File Offset: 0x00054060
		[Token(Token = "0x17001DE5")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy")]
		public FP racingMaxHp
		{
			[Token(Token = "0x600EA91")]
			[Address(RVA = "0x60BEA0", Offset = "0x60AAA0", VA = "0x18060BEA0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x0600EA92 RID: 60050 RVA: 0x00055E78 File Offset: 0x00054078
		[Token(Token = "0x17001DE6")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy")]
		public FP racingEndurance
		{
			[Token(Token = "0x600EA92")]
			[Address(RVA = "0x60BD30", Offset = "0x60A930", VA = "0x18060BD30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x00055E90 File Offset: 0x00054090
		[Token(Token = "0x17001DE7")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy")]
		public FP racingMassLevel
		{
			[Token(Token = "0x600EA93")]
			[Address(RVA = "0x60BE00", Offset = "0x60AA00", VA = "0x18060BE00")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600EA94 RID: 60052 RVA: 0x00055EA8 File Offset: 0x000540A8
		[Token(Token = "0x17001DE8")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy")]
		public FP racingMoveSpeed
		{
			[Token(Token = "0x600EA94")]
			[Address(RVA = "0x60C030", Offset = "0x60AC30", VA = "0x18060C030")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x00055EC0 File Offset: 0x000540C0
		[Token(Token = "0x17001DE9")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy")]
		public FP moveSpeedAttribute
		{
			[Token(Token = "0x600EA95")]
			[Address(RVA = "0x60BB20", Offset = "0x60A720", VA = "0x18060BB20")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x0600EA96 RID: 60054 RVA: 0x00055ED8 File Offset: 0x000540D8
		[Token(Token = "0x17001DEA")]
		[ReadOnly]
		[Inspect]
		[Group("RacingEnemy")]
		public RacingEnemy.RacingMode racingMode
		{
			[Token(Token = "0x600EA96")]
			[Address(RVA = "0x60BFD0", Offset = "0x60ABD0", VA = "0x18060BFD0")]
			get
			{
				return RacingEnemy.RacingMode.Racing;
			}
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DEB")]
		public RacingAttributesData racingAttributes
		{
			[Token(Token = "0x600EA97")]
			[Address(RVA = "0x60BC70", Offset = "0x60A870", VA = "0x18060BC70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x0600EA98 RID: 60056 RVA: 0x00055EF0 File Offset: 0x000540F0
		// (set) Token: 0x0600EA99 RID: 60057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DEC")]
		public bool ignoreCollisionSpeedLoss
		{
			[Token(Token = "0x600EA98")]
			[Address(RVA = "0x60BAC0", Offset = "0x60A6C0", VA = "0x18060BAC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EA99")]
			[Address(RVA = "0x60C490", Offset = "0x60B090", VA = "0x18060C490")]
			set
			{
			}
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x0600EA9A RID: 60058 RVA: 0x00055F08 File Offset: 0x00054108
		[Token(Token = "0x17001DED")]
		protected override bool onlyCollideWhenUnbalance
		{
			[Token(Token = "0x600EA9A")]
			[Address(RVA = "0x60BBA0", Offset = "0x60A7A0", VA = "0x18060BBA0", Slot = "195")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x0600EA9B RID: 60059 RVA: 0x00055F20 File Offset: 0x00054120
		[Token(Token = "0x17001DEE")]
		public override bool updateHpColor
		{
			[Token(Token = "0x600EA9B")]
			[Address(RVA = "0x60C330", Offset = "0x60AF30", VA = "0x18060C330", Slot = "209")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600EA9C RID: 60060 RVA: 0x00055F38 File Offset: 0x00054138
		[Token(Token = "0x17001DEF")]
		public override Color hpColor
		{
			[Token(Token = "0x600EA9C")]
			[Address(RVA = "0x60B9E0", Offset = "0x60A5E0", VA = "0x18060B9E0", Slot = "210")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x0600EA9D RID: 60061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DF0")]
		public EventPool<RacingEnemy.RacingEvent> racingEvPool
		{
			[Token(Token = "0x600EA9D")]
			[Address(RVA = "0x60BDA0", Offset = "0x60A9A0", VA = "0x18060BDA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x0600EA9E RID: 60062 RVA: 0x00055F50 File Offset: 0x00054150
		[Token(Token = "0x17001DF1")]
		public override Vector2 velocity
		{
			[Token(Token = "0x600EA9E")]
			[Address(RVA = "0x60C390", Offset = "0x60AF90", VA = "0x18060C390", Slot = "202")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x0600EA9F RID: 60063 RVA: 0x00055F68 File Offset: 0x00054168
		[Token(Token = "0x17001DF2")]
		public int finishedRoundCount
		{
			[Token(Token = "0x600EA9F")]
			[Address(RVA = "0x60B980", Offset = "0x60A580", VA = "0x18060B980")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x0600EAA0 RID: 60064 RVA: 0x00055F80 File Offset: 0x00054180
		[Token(Token = "0x17001DF3")]
		public FP racingProgress
		{
			[Token(Token = "0x600EAA0")]
			[Address(RVA = "0x60C120", Offset = "0x60AD20", VA = "0x18060C120")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x00055F98 File Offset: 0x00054198
		// (set) Token: 0x0600EAA2 RID: 60066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DF4")]
		public int ranking
		{
			[Token(Token = "0x600EAA1")]
			[Address(RVA = "0x60C270", Offset = "0x60AE70", VA = "0x18060C270")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600EAA2")]
			[Address(RVA = "0x60C500", Offset = "0x60B100", VA = "0x18060C500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x0600EAA3 RID: 60067 RVA: 0x00055FB0 File Offset: 0x000541B0
		// (set) Token: 0x0600EAA4 RID: 60068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DF5")]
		public int reverseRanking
		{
			[Token(Token = "0x600EAA3")]
			[Address(RVA = "0x60C2D0", Offset = "0x60AED0", VA = "0x18060C2D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600EAA4")]
			[Address(RVA = "0x60C570", Offset = "0x60B170", VA = "0x18060C570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600EAA5 RID: 60069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EAA5")]
		[Address(RVA = "0x608830", Offset = "0x607430", VA = "0x180608830")]
		public SandboxV2RacingItemInfo GetCurrentItem()
		{
			return null;
		}

		// Token: 0x0600EAA6 RID: 60070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAA6")]
		[Address(RVA = "0x609B00", Offset = "0x608700", VA = "0x180609B00")]
		public void UseCurrentItem()
		{
		}

		// Token: 0x0600EAA7 RID: 60071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAA7")]
		[Address(RVA = "0x609590", Offset = "0x608190", VA = "0x180609590")]
		public void SetMagnetTarget(Entity target, FP speed)
		{
		}

		// Token: 0x0600EAA8 RID: 60072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAA8")]
		[Address(RVA = "0x6098C0", Offset = "0x6084C0", VA = "0x1806098C0")]
		public void SwitchRacingMode(RacingEnemy.RacingMode mode)
		{
		}

		// Token: 0x0600EAA9 RID: 60073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAA9")]
		[Address(RVA = "0x609350", Offset = "0x607F50", VA = "0x180609350")]
		public void OnTakeForce(RacingEnemy.RacingCollisionContext context)
		{
		}

		// Token: 0x0600EAAA RID: 60074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAAA")]
		[Address(RVA = "0x6090A0", Offset = "0x607CA0", VA = "0x1806090A0")]
		public void OnOutputForce(RacingEnemy.RacingCollisionContext context)
		{
		}

		// Token: 0x0600EAAB RID: 60075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAAB")]
		[Address(RVA = "0x608CA0", Offset = "0x6078A0", VA = "0x180608CA0")]
		public void OnCollision(RacingEnemy another)
		{
		}

		// Token: 0x0600EAAC RID: 60076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAAC")]
		[Address(RVA = "0x608EA0", Offset = "0x607AA0", VA = "0x180608EA0")]
		public void OnCollision(Tile tile)
		{
		}

		// Token: 0x0600EAAD RID: 60077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAAD")]
		[Address(RVA = "0x608390", Offset = "0x606F90", VA = "0x180608390")]
		public void CheckCheckpoint(int checkpointId)
		{
		}

		// Token: 0x0600EAAE RID: 60078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAAE")]
		[Address(RVA = "0x609660", Offset = "0x608260", VA = "0x180609660", Slot = "211")]
		public override void Spawn(LevelData.EnemyData data, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route, Enemy.Options options)
		{
		}

		// Token: 0x0600EAAF RID: 60079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAAF")]
		[Address(RVA = "0x607ED0", Offset = "0x606AD0", VA = "0x180607ED0", Slot = "179")]
		protected override void AssignDynamicAbility(IList<DynamicAbilityData> dynamicAbilities)
		{
		}

		// Token: 0x0600EAB0 RID: 60080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB0")]
		[Address(RVA = "0x608A40", Offset = "0x607640", VA = "0x180608A40", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600EAB1 RID: 60081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB1")]
		[Address(RVA = "0x6091D0", Offset = "0x607DD0", VA = "0x1806091D0", Slot = "220")]
		protected override void OnRootTileChanged(Tile newTile, Tile oldTile)
		{
		}

		// Token: 0x0600EAB2 RID: 60082 RVA: 0x00055FC8 File Offset: 0x000541C8
		[Token(Token = "0x600EAB2")]
		[Address(RVA = "0x6086E0", Offset = "0x6072E0", VA = "0x1806086E0", Slot = "215")]
		public override bool FallDown(Tile tile, MotionMode mode = MotionMode.WALK)
		{
			return default(bool);
		}

		// Token: 0x0600EAB3 RID: 60083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB3")]
		[Address(RVA = "0x609140", Offset = "0x607D40", VA = "0x180609140", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600EAB4 RID: 60084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB4")]
		[Address(RVA = "0x6093F0", Offset = "0x607FF0", VA = "0x1806093F0", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600EAB5 RID: 60085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB5")]
		[Address(RVA = "0x6094B0", Offset = "0x6080B0", VA = "0x1806094B0", Slot = "170")]
		public override void PreloadSpecialAudioSignals(string unitId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0600EAB6 RID: 60086 RVA: 0x00055FE0 File Offset: 0x000541E0
		[Token(Token = "0x600EAB6")]
		[Address(RVA = "0x609B90", Offset = "0x608790", VA = "0x180609B90")]
		private bool _CheckValidTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600EAB7 RID: 60087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB7")]
		[Address(RVA = "0x60A8C0", Offset = "0x6094C0", VA = "0x18060A8C0")]
		private void _OnRacingEnemyFallDown(MotionMode motionMode)
		{
		}

		// Token: 0x0600EAB8 RID: 60088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB8")]
		[Address(RVA = "0x60A4D0", Offset = "0x6090D0", VA = "0x18060A4D0")]
		private void _DoCollisionWithEnemyInternal(RacingEnemy another)
		{
		}

		// Token: 0x0600EAB9 RID: 60089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB9")]
		[Address(RVA = "0x60A670", Offset = "0x609270", VA = "0x18060A670")]
		private void _DoCollisionWithTileInternal(Tile tile)
		{
		}

		// Token: 0x0600EABA RID: 60090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABA")]
		[Address(RVA = "0x609F10", Offset = "0x608B10", VA = "0x180609F10")]
		private void _DoCollisionInternal(Vector2 kbDir, float force, FP speedLoss, FP hpLoss)
		{
		}

		// Token: 0x0600EABB RID: 60091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABB")]
		[Address(RVA = "0x609DB0", Offset = "0x6089B0", VA = "0x180609DB0")]
		private void _DoCollisionHpLoss(FP hpLoss)
		{
		}

		// Token: 0x0600EABC RID: 60092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABC")]
		[Address(RVA = "0x60A380", Offset = "0x608F80", VA = "0x18060A380")]
		private void _DoCollisionSpeedLoss(FP speedLoss)
		{
		}

		// Token: 0x0600EABD RID: 60093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABD")]
		[Address(RVA = "0x60B5F0", Offset = "0x60A1F0", VA = "0x18060B5F0")]
		private void _UpdateRacingAttributes(bool init = false)
		{
		}

		// Token: 0x0600EABE RID: 60094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABE")]
		[Address(RVA = "0x60ACD0", Offset = "0x6098D0", VA = "0x18060ACD0")]
		private void _TryUpdateAttribute(AttributeType attributeType, FP value)
		{
		}

		// Token: 0x0600EABF RID: 60095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABF")]
		[Address(RVA = "0x609CA0", Offset = "0x6088A0", VA = "0x180609CA0")]
		private void _ClearMoveVelocity()
		{
		}

		// Token: 0x0600EAC0 RID: 60096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC0")]
		[Address(RVA = "0x60B340", Offset = "0x609F40", VA = "0x18060B340")]
		private void _UpdateMoveSpeed(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600EAC1 RID: 60097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC1")]
		[Address(RVA = "0x60A810", Offset = "0x609410", VA = "0x18060A810")]
		private void _DoUpdateMoveSpeed(FP newMoveSpeed)
		{
		}

		// Token: 0x0600EAC2 RID: 60098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC2")]
		[Address(RVA = "0x60B070", Offset = "0x609C70", VA = "0x18060B070")]
		private void _UpdateMagnet()
		{
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC3")]
		[Address(RVA = "0x60ADF0", Offset = "0x6099F0", VA = "0x18060ADF0")]
		private void _UpdateAutoUseItem(FP deltaTime)
		{
		}

		// Token: 0x0600EAC4 RID: 60100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC4")]
		[Address(RVA = "0x60B7D0", Offset = "0x60A3D0", VA = "0x18060B7D0")]
		public RacingEnemy()
		{
		}

		// Token: 0x0600EAC6 RID: 60102 RVA: 0x00055FF8 File Offset: 0x000541F8
		[Token(Token = "0x600EAC6")]
		[Address(RVA = "0x609AA0", Offset = "0x6086A0", VA = "0x180609AA0")]
		private bool <>xLuaBaseProxy_get_onlyCollideWhenUnbalance()
		{
			return default(bool);
		}

		// Token: 0x0600EAC7 RID: 60103 RVA: 0x00056010 File Offset: 0x00054210
		[Token(Token = "0x600EAC7")]
		[Address(RVA = "0x609AB0", Offset = "0x6086B0", VA = "0x180609AB0")]
		private bool <>xLuaBaseProxy_get_updateHpColor()
		{
			return default(bool);
		}

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x00056028 File Offset: 0x00054228
		[Token(Token = "0x600EAC8")]
		[Address(RVA = "0x609A70", Offset = "0x608670", VA = "0x180609A70")]
		private Color <>xLuaBaseProxy_get_hpColor()
		{
			return default(Color);
		}

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x00056040 File Offset: 0x00054240
		[Token(Token = "0x600EAC9")]
		[Address(RVA = "0x609AC0", Offset = "0x6086C0", VA = "0x180609AC0")]
		private Vector2 <>xLuaBaseProxy_get_velocity()
		{
			return default(Vector2);
		}

		// Token: 0x0600EACA RID: 60106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EACA")]
		[Address(RVA = "0x609A00", Offset = "0x608600", VA = "0x180609A00")]
		private void <>xLuaBaseProxy_Spawn(LevelData.EnemyData P0, EnemyHandBookData P1, Scheduler.SchedulerSnapshot P2, Route P3, Enemy.Options P4)
		{
		}

		// Token: 0x0600EACB RID: 60107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EACB")]
		[Address(RVA = "0x609990", Offset = "0x608590", VA = "0x180609990")]
		private void <>xLuaBaseProxy_AssignDynamicAbility(IList<DynamicAbilityData> P0)
		{
		}

		// Token: 0x0600EACC RID: 60108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EACC")]
		[Address(RVA = "0x6099B0", Offset = "0x6085B0", VA = "0x1806099B0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600EACD RID: 60109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EACD")]
		[Address(RVA = "0x6099D0", Offset = "0x6085D0", VA = "0x1806099D0")]
		private void <>xLuaBaseProxy_OnRootTileChanged(Tile P0, Tile P1)
		{
		}

		// Token: 0x0600EACE RID: 60110 RVA: 0x00056058 File Offset: 0x00054258
		[Token(Token = "0x600EACE")]
		[Address(RVA = "0x6099A0", Offset = "0x6085A0", VA = "0x1806099A0")]
		private bool <>xLuaBaseProxy_FallDown(Tile P0, MotionMode P1)
		{
			return default(bool);
		}

		// Token: 0x0600EACF RID: 60111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EACF")]
		[Address(RVA = "0x6099C0", Offset = "0x6085C0", VA = "0x1806099C0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600EAD0 RID: 60112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD0")]
		[Address(RVA = "0x6099E0", Offset = "0x6085E0", VA = "0x1806099E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EAD1 RID: 60113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD1")]
		[Address(RVA = "0x6099F0", Offset = "0x6085F0", VA = "0x1806099F0")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x040102FB RID: 66299
		[Token(Token = "0x40102FB")]
		[FieldOffset(Offset = "0x528")]
		private List<int> m_checkedCheckpoints;

		// Token: 0x040102FC RID: 66300
		[Token(Token = "0x40102FC")]
		[FieldOffset(Offset = "0x530")]
		private int m_finishedRoundCount;

		// Token: 0x040102FD RID: 66301
		[Token(Token = "0x40102FD")]
		[FieldOffset(Offset = "0x538")]
		private ObjectPtr<Entity> m_magnetTarget;

		// Token: 0x040102FE RID: 66302
		[Token(Token = "0x40102FE")]
		[FieldOffset(Offset = "0x548")]
		private FP m_magnetSpeed;

		// Token: 0x040102FF RID: 66303
		[Token(Token = "0x40102FF")]
		[FieldOffset(Offset = "0x550")]
		private RacingMoveController m_racingMoveController;

		// Token: 0x04010300 RID: 66304
		[Token(Token = "0x4010300")]
		[FieldOffset(Offset = "0x558")]
		private Tile m_lastValidTile;

		// Token: 0x04010301 RID: 66305
		[Token(Token = "0x4010301")]
		[FieldOffset(Offset = "0x560")]
		private RacingAttributesData m_attributesData;

		// Token: 0x04010302 RID: 66306
		[Token(Token = "0x4010302")]
		[FieldOffset(Offset = "0x568")]
		private EventPool<RacingEnemy.RacingEvent> m_racingEvPool;

		// Token: 0x04010303 RID: 66307
		[Token(Token = "0x4010303")]
		[FieldOffset(Offset = "0x570")]
		private RacingEnemy.RacingMode m_currentRacingMode;

		// Token: 0x04010304 RID: 66308
		[Token(Token = "0x4010304")]
		[FieldOffset(Offset = "0x574")]
		private bool m_ignoreCollisionSpeedLoss;

		// Token: 0x04010305 RID: 66309
		[Token(Token = "0x4010305")]
		[FieldOffset(Offset = "0x578")]
		private PeriodicTimer m_autoUseItemTimer;

		// Token: 0x04010306 RID: 66310
		[Token(Token = "0x4010306")]
		[FieldOffset(Offset = "0x580")]
		private RacingEnemyData m_racingData;

		// Token: 0x04010307 RID: 66311
		[Token(Token = "0x4010307")]
		[FieldOffset(Offset = "0x588")]
		private BattleTweenMgr.Tween m_falldownTween;

		// Token: 0x0401030A RID: 66314
		[Token(Token = "0x401030A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_racingData;

		// Token: 0x0401030B RID: 66315
		[Token(Token = "0x401030B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_racingMaxMoveSpeed;

		// Token: 0x0401030C RID: 66316
		[Token(Token = "0x401030C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_racingAcceleration;

		// Token: 0x0401030D RID: 66317
		[Token(Token = "0x401030D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_racingMaxHp;

		// Token: 0x0401030E RID: 66318
		[Token(Token = "0x401030E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_racingEndurance;

		// Token: 0x0401030F RID: 66319
		[Token(Token = "0x401030F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_racingMassLevel;

		// Token: 0x04010310 RID: 66320
		[Token(Token = "0x4010310")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_racingMoveSpeed;

		// Token: 0x04010311 RID: 66321
		[Token(Token = "0x4010311")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_moveSpeedAttribute;

		// Token: 0x04010312 RID: 66322
		[Token(Token = "0x4010312")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_racingMode;

		// Token: 0x04010313 RID: 66323
		[Token(Token = "0x4010313")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_racingAttributes;

		// Token: 0x04010314 RID: 66324
		[Token(Token = "0x4010314")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_ignoreCollisionSpeedLoss;

		// Token: 0x04010315 RID: 66325
		[Token(Token = "0x4010315")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_ignoreCollisionSpeedLoss;

		// Token: 0x04010316 RID: 66326
		[Token(Token = "0x4010316")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_onlyCollideWhenUnbalance;

		// Token: 0x04010317 RID: 66327
		[Token(Token = "0x4010317")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_updateHpColor;

		// Token: 0x04010318 RID: 66328
		[Token(Token = "0x4010318")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_hpColor;

		// Token: 0x04010319 RID: 66329
		[Token(Token = "0x4010319")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_racingEvPool;

		// Token: 0x0401031A RID: 66330
		[Token(Token = "0x401031A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_velocity;

		// Token: 0x0401031B RID: 66331
		[Token(Token = "0x401031B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_finishedRoundCount;

		// Token: 0x0401031C RID: 66332
		[Token(Token = "0x401031C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_racingProgress;

		// Token: 0x0401031D RID: 66333
		[Token(Token = "0x401031D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_ranking;

		// Token: 0x0401031E RID: 66334
		[Token(Token = "0x401031E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_ranking;

		// Token: 0x0401031F RID: 66335
		[Token(Token = "0x401031F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_reverseRanking;

		// Token: 0x04010320 RID: 66336
		[Token(Token = "0x4010320")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_reverseRanking;

		// Token: 0x04010321 RID: 66337
		[Token(Token = "0x4010321")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetCurrentItem;

		// Token: 0x04010322 RID: 66338
		[Token(Token = "0x4010322")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_UseCurrentItem;

		// Token: 0x04010323 RID: 66339
		[Token(Token = "0x4010323")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SetMagnetTarget;

		// Token: 0x04010324 RID: 66340
		[Token(Token = "0x4010324")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SwitchRacingMode;

		// Token: 0x04010325 RID: 66341
		[Token(Token = "0x4010325")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnTakeForce;

		// Token: 0x04010326 RID: 66342
		[Token(Token = "0x4010326")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnOutputForce;

		// Token: 0x04010327 RID: 66343
		[Token(Token = "0x4010327")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnCollision;

		// Token: 0x04010328 RID: 66344
		[Token(Token = "0x4010328")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix1_OnCollision;

		// Token: 0x04010329 RID: 66345
		[Token(Token = "0x4010329")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckCheckpoint;

		// Token: 0x0401032A RID: 66346
		[Token(Token = "0x401032A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_Spawn;

		// Token: 0x0401032B RID: 66347
		[Token(Token = "0x401032B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_AssignDynamicAbility;

		// Token: 0x0401032C RID: 66348
		[Token(Token = "0x401032C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x0401032D RID: 66349
		[Token(Token = "0x401032D")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnRootTileChanged;

		// Token: 0x0401032E RID: 66350
		[Token(Token = "0x401032E")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_FallDown;

		// Token: 0x0401032F RID: 66351
		[Token(Token = "0x401032F")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04010330 RID: 66352
		[Token(Token = "0x4010330")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010331 RID: 66353
		[Token(Token = "0x4010331")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04010332 RID: 66354
		[Token(Token = "0x4010332")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CheckValidTile;

		// Token: 0x04010333 RID: 66355
		[Token(Token = "0x4010333")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnRacingEnemyFallDown;

		// Token: 0x04010334 RID: 66356
		[Token(Token = "0x4010334")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__DoCollisionWithEnemyInternal;

		// Token: 0x04010335 RID: 66357
		[Token(Token = "0x4010335")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__DoCollisionWithTileInternal;

		// Token: 0x04010336 RID: 66358
		[Token(Token = "0x4010336")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__DoCollisionInternal;

		// Token: 0x04010337 RID: 66359
		[Token(Token = "0x4010337")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__DoCollisionHpLoss;

		// Token: 0x04010338 RID: 66360
		[Token(Token = "0x4010338")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__DoCollisionSpeedLoss;

		// Token: 0x04010339 RID: 66361
		[Token(Token = "0x4010339")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__UpdateRacingAttributes;

		// Token: 0x0401033A RID: 66362
		[Token(Token = "0x401033A")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__TryUpdateAttribute;

		// Token: 0x0401033B RID: 66363
		[Token(Token = "0x401033B")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__ClearMoveVelocity;

		// Token: 0x0401033C RID: 66364
		[Token(Token = "0x401033C")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__UpdateMoveSpeed;

		// Token: 0x0401033D RID: 66365
		[Token(Token = "0x401033D")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__DoUpdateMoveSpeed;

		// Token: 0x0401033E RID: 66366
		[Token(Token = "0x401033E")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__UpdateMagnet;

		// Token: 0x0401033F RID: 66367
		[Token(Token = "0x401033F")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__UpdateAutoUseItem;

		// Token: 0x04010340 RID: 66368
		[Token(Token = "0x4010340")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020023E7 RID: 9191
		[Token(Token = "0x20023E7")]
		public enum RacingEvent
		{
			// Token: 0x04010342 RID: 66370
			[Token(Token = "0x4010342")]
			ON_SWITCH_RACING_MODE,
			// Token: 0x04010343 RID: 66371
			[Token(Token = "0x4010343")]
			COLLISION_WITH_ENEMY,
			// Token: 0x04010344 RID: 66372
			[Token(Token = "0x4010344")]
			COLLISION_WITH_TILE,
			// Token: 0x04010345 RID: 66373
			[Token(Token = "0x4010345")]
			ON_TAKE_FORCE,
			// Token: 0x04010346 RID: 66374
			[Token(Token = "0x4010346")]
			ON_OUTPUT_FORCE
		}

		// Token: 0x020023E8 RID: 9192
		[Token(Token = "0x20023E8")]
		public class RacingCollisionContext
		{
			// Token: 0x0600EAD2 RID: 60114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EAD2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RacingCollisionContext()
			{
			}

			// Token: 0x04010347 RID: 66375
			[Token(Token = "0x4010347")]
			[FieldOffset(Offset = "0x10")]
			public RacingEnemy target;

			// Token: 0x04010348 RID: 66376
			[Token(Token = "0x4010348")]
			[FieldOffset(Offset = "0x18")]
			public RacingEnemy source;

			// Token: 0x04010349 RID: 66377
			[Token(Token = "0x4010349")]
			[FieldOffset(Offset = "0x20")]
			public Tile tile;

			// Token: 0x0401034A RID: 66378
			[Token(Token = "0x401034A")]
			[FieldOffset(Offset = "0x28")]
			public int forceLevel;

			// Token: 0x0401034B RID: 66379
			[Token(Token = "0x401034B")]
			[FieldOffset(Offset = "0x2C")]
			public float force;

			// Token: 0x0401034C RID: 66380
			[Token(Token = "0x401034C")]
			[FieldOffset(Offset = "0x30")]
			public FP speedLoss;

			// Token: 0x0401034D RID: 66381
			[Token(Token = "0x401034D")]
			[FieldOffset(Offset = "0x38")]
			public FP hpLoss;
		}

		// Token: 0x020023E9 RID: 9193
		[Token(Token = "0x20023E9")]
		public enum RacingMode
		{
			// Token: 0x0401034F RID: 66383
			[Token(Token = "0x401034F")]
			Racing,
			// Token: 0x04010350 RID: 66384
			[Token(Token = "0x4010350")]
			Recover
		}
	}
}
