using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using Torappu.Battle.Effects;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025BF RID: 9663
	[Token(Token = "0x20025BF")]
	[SelectionBase]
	[RequireComponent(typeof(MoveController), typeof(Rigidbody2D))]
	public class Enemy : Unit, IMovable, ILocatable
	{
		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x0600FA29 RID: 64041 RVA: 0x0005E0C8 File Offset: 0x0005C2C8
		[Token(Token = "0x1700211A")]
		public SharedConsts.Direction lastMoveDirection
		{
			[Token(Token = "0x600FA29")]
			[Address(RVA = "0x732680", Offset = "0x731280", VA = "0x180732680")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x0600FA2A RID: 64042 RVA: 0x0005E0E0 File Offset: 0x0005C2E0
		// (set) Token: 0x0600FA2B RID: 64043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700211B")]
		public Vector2 lastMoveDirVec
		{
			[Token(Token = "0x600FA2A")]
			[Address(RVA = "0x7325F0", Offset = "0x7311F0", VA = "0x1807325F0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600FA2B")]
			[Address(RVA = "0x734F60", Offset = "0x733B60", VA = "0x180734F60")]
			set
			{
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x0600FA2C RID: 64044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700211C")]
		public Enemy.SpecialBlockCondition specialBlockCondition
		{
			[Token(Token = "0x600FA2C")]
			[Address(RVA = "0x733C20", Offset = "0x732820", VA = "0x180733C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600FA2D RID: 64045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700211D")]
		private Transform extraSpineControl
		{
			[Token(Token = "0x600FA2D")]
			[Address(RVA = "0x730E30", Offset = "0x72FA30", VA = "0x180730E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600FA2E RID: 64046 RVA: 0x0005E0F8 File Offset: 0x0005C2F8
		// (set) Token: 0x0600FA2F RID: 64047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700211E")]
		public bool disableAppearTweenColor
		{
			[Token(Token = "0x600FA2E")]
			[Address(RVA = "0x730760", Offset = "0x72F360", VA = "0x180730760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600FA2F")]
			[Address(RVA = "0x734C60", Offset = "0x733860", VA = "0x180734C60")]
			set
			{
			}
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x0600FA30 RID: 64048 RVA: 0x0005E110 File Offset: 0x0005C310
		[Token(Token = "0x1700211F")]
		public override SourceApplyWay allApplyWay
		{
			[Token(Token = "0x600FA30")]
			[Address(RVA = "0x72FB20", Offset = "0x72E720", VA = "0x18072FB20", Slot = "49")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x0600FA31 RID: 64049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002120")]
		public Enemy.FearController fearController
		{
			[Token(Token = "0x600FA31")]
			[Address(RVA = "0x731030", Offset = "0x72FC30", VA = "0x180731030")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x0600FA32 RID: 64050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002121")]
		public Enemy.AttractController attractController
		{
			[Token(Token = "0x600FA32")]
			[Address(RVA = "0x72FD30", Offset = "0x72E930", VA = "0x18072FD30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600FA33 RID: 64051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FA33")]
		[Address(RVA = "0x729C00", Offset = "0x728800", VA = "0x180729C00")]
		public void SetSpecialBlockCondition(Enemy.SpecialBlockCondition.Type type, Enemy.SpecialBlockCondition.BuffKeyPair[] buffKeyPairs, string[] filterTags)
		{
		}

		// Token: 0x0600FA34 RID: 64052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FA34")]
		[Address(RVA = "0x729660", Offset = "0x728260", VA = "0x180729660")]
		public void SetEnemyCombatWrapperInterrupted()
		{
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x0600FA35 RID: 64053 RVA: 0x0005E128 File Offset: 0x0005C328
		[Token(Token = "0x17002122")]
		public override FP ColliderRadius
		{
			[Token(Token = "0x600FA35")]
			[Address(RVA = "0x72FAA0", Offset = "0x72E6A0", VA = "0x18072FAA0", Slot = "148")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x0600FA36 RID: 64054 RVA: 0x0005E140 File Offset: 0x0005C340
		[Token(Token = "0x17002123")]
		protected virtual bool onlyCollideWhenUnbalance
		{
			[Token(Token = "0x600FA36")]
			[Address(RVA = "0x7333F0", Offset = "0x731FF0", VA = "0x1807333F0", Slot = "195")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x0600FA37 RID: 64055 RVA: 0x0005E158 File Offset: 0x0005C358
		[Token(Token = "0x17002124")]
		public Enemy.BodyDirectionPolicy bodyDirectionPolicy
		{
			[Token(Token = "0x600FA37")]
			[Address(RVA = "0x72FF70", Offset = "0x72EB70", VA = "0x18072FF70")]
			get
			{
				return Enemy.BodyDirectionPolicy.DEFAULT_FOUR_WAYS;
			}
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x0600FA38 RID: 64056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002125")]
		public Ability attackAbilityCasted
		{
			[Token(Token = "0x600FA38")]
			[Address(RVA = "0x72FC30", Offset = "0x72E830", VA = "0x18072FC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x0600FA39 RID: 64057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA3A RID: 64058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002126")]
		public Ability combatAbilityCasted
		{
			[Token(Token = "0x600FA39")]
			[Address(RVA = "0x72FFE0", Offset = "0x72EBE0", VA = "0x18072FFE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600FA3A")]
			[Address(RVA = "0x7349F0", Offset = "0x7335F0", VA = "0x1807349F0")]
			set
			{
			}
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x0600FA3B RID: 64059 RVA: 0x0005E170 File Offset: 0x0005C370
		// (set) Token: 0x0600FA3C RID: 64060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002127")]
		public uint hostUid
		{
			[Token(Token = "0x600FA3B")]
			[Address(RVA = "0x7315F0", Offset = "0x7301F0", VA = "0x1807315F0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600FA3C")]
			[Address(RVA = "0x734EA0", Offset = "0x733AA0", VA = "0x180734EA0")]
			set
			{
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x0600FA3D RID: 64061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002128")]
		protected Collider2D nonTriggerCollider
		{
			[Token(Token = "0x600FA3D")]
			[Address(RVA = "0x733200", Offset = "0x731E00", VA = "0x180733200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x0600FA3E RID: 64062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002129")]
		protected MoveController moveController
		{
			[Token(Token = "0x600FA3E")]
			[Address(RVA = "0x732D00", Offset = "0x731900", VA = "0x180732D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600FA3F RID: 64063 RVA: 0x0005E188 File Offset: 0x0005C388
		[Token(Token = "0x1700212A")]
		public float distToExit
		{
			[Token(Token = "0x600FA3F")]
			[Address(RVA = "0x730BF0", Offset = "0x72F7F0", VA = "0x180730BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600FA40 RID: 64064 RVA: 0x0005E1A0 File Offset: 0x0005C3A0
		[Token(Token = "0x1700212B")]
		public float distToExitPrecise
		{
			[Token(Token = "0x600FA40")]
			[Address(RVA = "0x730AE0", Offset = "0x72F6E0", VA = "0x180730AE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x0600FA41 RID: 64065 RVA: 0x0005E1B8 File Offset: 0x0005C3B8
		[Token(Token = "0x1700212C")]
		public bool uiHideFlag
		{
			[Token(Token = "0x600FA41")]
			[Address(RVA = "0x734440", Offset = "0x733040", VA = "0x180734440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x0600FA42 RID: 64066 RVA: 0x0005E1D0 File Offset: 0x0005C3D0
		[Token(Token = "0x1700212D")]
		public bool hideHp
		{
			[Token(Token = "0x600FA42")]
			[Address(RVA = "0x731550", Offset = "0x730150", VA = "0x180731550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x0600FA43 RID: 64067 RVA: 0x0005E1E8 File Offset: 0x0005C3E8
		[Token(Token = "0x1700212E")]
		public bool showSpUIFlag
		{
			[Token(Token = "0x600FA43")]
			[Address(RVA = "0x733B20", Offset = "0x732720", VA = "0x180733B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x0600FA44 RID: 64068 RVA: 0x0005E200 File Offset: 0x0005C400
		// (set) Token: 0x0600FA45 RID: 64069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700212F")]
		public bool alwaysShowHpFlag
		{
			[Token(Token = "0x600FA44")]
			[Address(RVA = "0x72FBB0", Offset = "0x72E7B0", VA = "0x18072FBB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600FA45")]
			[Address(RVA = "0x734770", Offset = "0x733370", VA = "0x180734770")]
			set
			{
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x0600FA46 RID: 64070 RVA: 0x0005E218 File Offset: 0x0005C418
		// (set) Token: 0x0600FA47 RID: 64071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002130")]
		public bool fogHideUIFlag
		{
			[Token(Token = "0x600FA46")]
			[Address(RVA = "0x7310B0", Offset = "0x72FCB0", VA = "0x1807310B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600FA47")]
			[Address(RVA = "0x734E10", Offset = "0x733A10", VA = "0x180734E10")]
			set
			{
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x0600FA48 RID: 64072 RVA: 0x0005E230 File Offset: 0x0005C430
		[Token(Token = "0x17002131")]
		public float spineHeight
		{
			[Token(Token = "0x600FA48")]
			[Address(RVA = "0x733CB0", Offset = "0x7328B0", VA = "0x180733CB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x0600FA49 RID: 64073 RVA: 0x0005E248 File Offset: 0x0005C448
		[Token(Token = "0x17002132")]
		public float originHeight
		{
			[Token(Token = "0x600FA49")]
			[Address(RVA = "0x7335F0", Offset = "0x7321F0", VA = "0x1807335F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x0600FA4A RID: 64074 RVA: 0x0005E260 File Offset: 0x0005C460
		// (set) Token: 0x0600FA4B RID: 64075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002133")]
		public bool disableUIHud
		{
			[Token(Token = "0x600FA4A")]
			[Address(RVA = "0x7309A0", Offset = "0x72F5A0", VA = "0x1807309A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600FA4B")]
			[Address(RVA = "0x734D80", Offset = "0x733980", VA = "0x180734D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x0600FA4C RID: 64076 RVA: 0x0005E278 File Offset: 0x0005C478
		[Token(Token = "0x17002134")]
		public virtual bool disableUIUnitHud
		{
			[Token(Token = "0x600FA4C")]
			[Address(RVA = "0x730A20", Offset = "0x72F620", VA = "0x180730A20", Slot = "196")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FA4D RID: 64077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FA4D")]
		[Address(RVA = "0x7234C0", Offset = "0x7220C0", VA = "0x1807234C0", Slot = "167")]
		public override void GatherHudPluginTypes(List<string> pluginNames)
		{
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x0600FA4E RID: 64078 RVA: 0x0005E290 File Offset: 0x0005C490
		[Token(Token = "0x17002135")]
		public override HudPluginMask hudPluginMask
		{
			[Token(Token = "0x600FA4E")]
			[Address(RVA = "0x731740", Offset = "0x730340", VA = "0x180731740", Slot = "166")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x0600FA4F RID: 64079 RVA: 0x0005E2A8 File Offset: 0x0005C4A8
		[Token(Token = "0x17002136")]
		public override FP hatred
		{
			[Token(Token = "0x600FA4F")]
			[Address(RVA = "0x731300", Offset = "0x72FF00", VA = "0x180731300", Slot = "46")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x0600FA50 RID: 64080 RVA: 0x0005E2C0 File Offset: 0x0005C4C0
		[Token(Token = "0x17002137")]
		public float totalMoveDist
		{
			[Token(Token = "0x600FA50")]
			[Address(RVA = "0x734050", Offset = "0x732C50", VA = "0x180734050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x0600FA51 RID: 64081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002138")]
		public Character blocker
		{
			[Token(Token = "0x600FA51")]
			[Address(RVA = "0x72FEB0", Offset = "0x72EAB0", VA = "0x18072FEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x0600FA52 RID: 64082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002139")]
		public override List<ObjectPtr<Projectile>> managedProjectiles
		{
			[Token(Token = "0x600FA52")]
			[Address(RVA = "0x7329A0", Offset = "0x7315A0", VA = "0x1807329A0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x0600FA53 RID: 64083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700213A")]
		public override Tile rootTile
		{
			[Token(Token = "0x600FA53")]
			[Address(RVA = "0x733920", Offset = "0x732520", VA = "0x180733920", Slot = "50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x0600FA54 RID: 64084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700213B")]
		public override Tile oldTile
		{
			[Token(Token = "0x600FA54")]
			[Address(RVA = "0x733370", Offset = "0x731F70", VA = "0x180733370", Slot = "51")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x0600FA55 RID: 64085 RVA: 0x0005E2D8 File Offset: 0x0005C4D8
		[Token(Token = "0x1700213C")]
		public GridPosition routeSpawnPosition
		{
			[Token(Token = "0x600FA55")]
			[Address(RVA = "0x7339A0", Offset = "0x7325A0", VA = "0x1807339A0")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600FA56 RID: 64086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700213D")]
		public List<Tile> rootSubTiles
		{
			[Token(Token = "0x600FA56")]
			[Address(RVA = "0x7338A0", Offset = "0x7324A0", VA = "0x1807338A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x0600FA57 RID: 64087 RVA: 0x0005E2F0 File Offset: 0x0005C4F0
		// (set) Token: 0x0600FA58 RID: 64088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700213E")]
		public int lifePointReduce
		{
			[Token(Token = "0x600FA57")]
			[Address(RVA = "0x732810", Offset = "0x731410", VA = "0x180732810")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600FA58")]
			[Address(RVA = "0x734FF0", Offset = "0x733BF0", VA = "0x180734FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x0600FA59 RID: 64089 RVA: 0x0005E308 File Offset: 0x0005C508
		// (set) Token: 0x0600FA5A RID: 64090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700213F")]
		public float defaultRangeRadius
		{
			[Token(Token = "0x600FA59")]
			[Address(RVA = "0x7304D0", Offset = "0x72F0D0", VA = "0x1807304D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600FA5A")]
			[Address(RVA = "0x734BD0", Offset = "0x7337D0", VA = "0x180734BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x0600FA5B RID: 64091 RVA: 0x0005E320 File Offset: 0x0005C520
		[Token(Token = "0x17002140")]
		public new virtual int massLevel
		{
			[Token(Token = "0x600FA5B")]
			[Address(RVA = "0x732A20", Offset = "0x731620", VA = "0x180732A20", Slot = "197")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x0600FA5C RID: 64092 RVA: 0x0005E338 File Offset: 0x0005C538
		[Token(Token = "0x17002141")]
		public override FP maxEp
		{
			[Token(Token = "0x600FA5C")]
			[Address(RVA = "0x732B40", Offset = "0x731740", VA = "0x180732B40", Slot = "77")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x0600FA5D RID: 64093 RVA: 0x0005E350 File Offset: 0x0005C550
		[Token(Token = "0x17002142")]
		public MotionMode essentialMotionMode
		{
			[Token(Token = "0x600FA5D")]
			[Address(RVA = "0x730D90", Offset = "0x72F990", VA = "0x180730D90")]
			get
			{
				return MotionMode.WALK;
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x0600FA5E RID: 64094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002143")]
		public string[] enemyTags
		{
			[Token(Token = "0x600FA5E")]
			[Address(RVA = "0x730D00", Offset = "0x72F900", VA = "0x180730D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600FA5F RID: 64095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA60 RID: 64096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002144")]
		public LevelData.EnemyData data
		{
			[Token(Token = "0x600FA5F")]
			[Address(RVA = "0x730280", Offset = "0x72EE80", VA = "0x180730280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FA60")]
			[Address(RVA = "0x734B30", Offset = "0x733730", VA = "0x180734B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x0600FA61 RID: 64097 RVA: 0x0005E368 File Offset: 0x0005C568
		[Token(Token = "0x17002145")]
		public virtual bool isUnbalanced
		{
			[Token(Token = "0x600FA61")]
			[Address(RVA = "0x732490", Offset = "0x731090", VA = "0x180732490", Slot = "198")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x0600FA62 RID: 64098 RVA: 0x0005E380 File Offset: 0x0005C580
		[Token(Token = "0x17002146")]
		public override bool isInAttackState
		{
			[Token(Token = "0x600FA62")]
			[Address(RVA = "0x731CE0", Offset = "0x7308E0", VA = "0x180731CE0", Slot = "150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x0600FA63 RID: 64099 RVA: 0x0005E398 File Offset: 0x0005C598
		[Token(Token = "0x17002147")]
		public override bool isInCombatState
		{
			[Token(Token = "0x600FA63")]
			[Address(RVA = "0x731E90", Offset = "0x730A90", VA = "0x180731E90", Slot = "151")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x0600FA64 RID: 64100 RVA: 0x0005E3B0 File Offset: 0x0005C5B0
		[Token(Token = "0x17002148")]
		public override bool isInRebornState
		{
			[Token(Token = "0x600FA64")]
			[Address(RVA = "0x732230", Offset = "0x730E30", VA = "0x180732230", Slot = "153")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x0600FA65 RID: 64101 RVA: 0x0005E3C8 File Offset: 0x0005C5C8
		[Token(Token = "0x17002149")]
		public bool isInMoveState
		{
			[Token(Token = "0x600FA65")]
			[Address(RVA = "0x7321A0", Offset = "0x730DA0", VA = "0x1807321A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x0600FA66 RID: 64102 RVA: 0x0005E3E0 File Offset: 0x0005C5E0
		[Token(Token = "0x1700214A")]
		public bool isInBlinkState
		{
			[Token(Token = "0x600FA66")]
			[Address(RVA = "0x731D70", Offset = "0x730970", VA = "0x180731D70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x0600FA67 RID: 64103 RVA: 0x0005E3F8 File Offset: 0x0005C5F8
		[Token(Token = "0x1700214B")]
		public bool isInBornState
		{
			[Token(Token = "0x600FA67")]
			[Address(RVA = "0x731E00", Offset = "0x730A00", VA = "0x180731E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x0600FA68 RID: 64104 RVA: 0x0005E410 File Offset: 0x0005C610
		[Token(Token = "0x1700214C")]
		public override bool isInDyingState
		{
			[Token(Token = "0x600FA68")]
			[Address(RVA = "0x732070", Offset = "0x730C70", VA = "0x180732070", Slot = "152")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600FA69 RID: 64105 RVA: 0x0005E428 File Offset: 0x0005C628
		[Token(Token = "0x1700214D")]
		public bool isBoss
		{
			[Token(Token = "0x600FA69")]
			[Address(RVA = "0x731AE0", Offset = "0x7306E0", VA = "0x180731AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600FA6A RID: 64106 RVA: 0x0005E440 File Offset: 0x0005C640
		[Token(Token = "0x1700214E")]
		public virtual bool isGiantBoss
		{
			[Token(Token = "0x600FA6A")]
			[Address(RVA = "0x731C70", Offset = "0x730870", VA = "0x180731C70", Slot = "199")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600FA6B RID: 64107 RVA: 0x0005E458 File Offset: 0x0005C658
		[Token(Token = "0x1700214F")]
		public virtual bool isEnemyLikeNeutral
		{
			[Token(Token = "0x600FA6B")]
			[Address(RVA = "0x731B80", Offset = "0x730780", VA = "0x180731B80", Slot = "200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x0600FA6C RID: 64108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002150")]
		public IDrawableRange locateRange
		{
			[Token(Token = "0x600FA6C")]
			[Address(RVA = "0x732890", Offset = "0x731490", VA = "0x180732890")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x0600FA6D RID: 64109 RVA: 0x0005E470 File Offset: 0x0005C670
		[Token(Token = "0x17002151")]
		public bool disableRenderLocateRange
		{
			[Token(Token = "0x600FA6D")]
			[Address(RVA = "0x7308A0", Offset = "0x72F4A0", VA = "0x1807308A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x0600FA6E RID: 64110 RVA: 0x0005E488 File Offset: 0x0005C688
		[Token(Token = "0x17002152")]
		public int blockVolume
		{
			[Token(Token = "0x600FA6E")]
			[Address(RVA = "0x72FE30", Offset = "0x72EA30", VA = "0x18072FE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x0600FA6F RID: 64111 RVA: 0x0005E4A0 File Offset: 0x0005C6A0
		// (set) Token: 0x0600FA70 RID: 64112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002153")]
		public int blockVolumeAddition
		{
			[Token(Token = "0x600FA6F")]
			[Address(RVA = "0x72FDB0", Offset = "0x72E9B0", VA = "0x18072FDB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600FA70")]
			[Address(RVA = "0x7348A0", Offset = "0x7334A0", VA = "0x1807348A0")]
			set
			{
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x0600FA71 RID: 64113 RVA: 0x0005E4B8 File Offset: 0x0005C6B8
		[Token(Token = "0x17002154")]
		public bool showSpAsBulletMode
		{
			[Token(Token = "0x600FA71")]
			[Address(RVA = "0x733AA0", Offset = "0x7326A0", VA = "0x180733AA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x0600FA72 RID: 64114 RVA: 0x0005E4D0 File Offset: 0x0005C6D0
		[Token(Token = "0x17002155")]
		public bool disableBulletSp
		{
			[Token(Token = "0x600FA72")]
			[Address(RVA = "0x7307E0", Offset = "0x72F3E0", VA = "0x1807307E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x0600FA73 RID: 64115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002156")]
		public override UnitMode defaultMode
		{
			[Token(Token = "0x600FA73")]
			[Address(RVA = "0x730430", Offset = "0x72F030", VA = "0x180730430", Slot = "141")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600FA74 RID: 64116 RVA: 0x0005E4E8 File Offset: 0x0005C6E8
		[Token(Token = "0x17002157")]
		public override bool hasCombat
		{
			[Token(Token = "0x600FA74")]
			[Address(RVA = "0x731250", Offset = "0x72FE50", VA = "0x180731250", Slot = "145")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600FA75 RID: 64117 RVA: 0x0005E500 File Offset: 0x0005C700
		[Token(Token = "0x17002158")]
		public bool combatable
		{
			[Token(Token = "0x600FA75")]
			[Address(RVA = "0x7300E0", Offset = "0x72ECE0", VA = "0x1807300E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x0600FA76 RID: 64118 RVA: 0x0005E518 File Offset: 0x0005C718
		[Token(Token = "0x17002159")]
		public override bool isInCombat
		{
			[Token(Token = "0x600FA76")]
			[Address(RVA = "0x731F20", Offset = "0x730B20", VA = "0x180731F20", Slot = "149")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x0600FA77 RID: 64119 RVA: 0x0005E530 File Offset: 0x0005C730
		[Token(Token = "0x1700215A")]
		public override bool isMovingBySelf
		{
			[Token(Token = "0x600FA77")]
			[Address(RVA = "0x732340", Offset = "0x730F40", VA = "0x180732340", Slot = "154")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x0600FA78 RID: 64120 RVA: 0x0005E548 File Offset: 0x0005C748
		[Token(Token = "0x1700215B")]
		protected override bool needUpdateRootHeight
		{
			[Token(Token = "0x600FA78")]
			[Address(RVA = "0x733160", Offset = "0x731D60", VA = "0x180733160", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x0600FA79 RID: 64121 RVA: 0x0005E560 File Offset: 0x0005C760
		[Token(Token = "0x1700215C")]
		public Vector2 footMapPosition
		{
			[Token(Token = "0x600FA79")]
			[Address(RVA = "0x731130", Offset = "0x72FD30", VA = "0x180731130", Slot = "192")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x0600FA7A RID: 64122 RVA: 0x0005E578 File Offset: 0x0005C778
		[Token(Token = "0x1700215D")]
		public Vector2 offsetMapPosition
		{
			[Token(Token = "0x600FA7A")]
			[Address(RVA = "0x733280", Offset = "0x731E80", VA = "0x180733280", Slot = "193")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x0600FA7B RID: 64123 RVA: 0x0005E590 File Offset: 0x0005C790
		[Token(Token = "0x1700215E")]
		public Vector2 stableBlockPosition
		{
			[Token(Token = "0x600FA7B")]
			[Address(RVA = "0x733D40", Offset = "0x732940", VA = "0x180733D40")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x0600FA7C RID: 64124 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
		// (set) Token: 0x0600FA7D RID: 64125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700215F")]
		public Enemy.Options options
		{
			[Token(Token = "0x600FA7C")]
			[Address(RVA = "0x733460", Offset = "0x732060", VA = "0x180733460")]
			[CompilerGenerated]
			get
			{
				return default(Enemy.Options);
			}
			[Token(Token = "0x600FA7D")]
			[Address(RVA = "0x735080", Offset = "0x733C80", VA = "0x180735080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600FA7E RID: 64126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FA7E")]
		[Address(RVA = "0x722060", Offset = "0x720C60", VA = "0x180722060")]
		public void DontCountAsFinished()
		{
		}

		// Token: 0x0600FA7F RID: 64127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FA7F")]
		[Address(RVA = "0x724B80", Offset = "0x723780", VA = "0x180724B80")]
		public void MarkUnharmful()
		{
		}

		// Token: 0x0600FA80 RID: 64128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FA80")]
		[Address(RVA = "0x722120", Offset = "0x720D20", VA = "0x180722120")]
		public void DontLogInEnemyStatsWhenFinished()
		{
		}

		// Token: 0x0600FA81 RID: 64129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FA81")]
		[Address(RVA = "0x729860", Offset = "0x728460", VA = "0x180729860")]
		public void SetExtraMeta(object extraMeta)
		{
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x0600FA82 RID: 64130 RVA: 0x0005E5C0 File Offset: 0x0005C7C0
		[Token(Token = "0x17002160")]
		public bool isInvalidKilled
		{
			[Token(Token = "0x600FA82")]
			[Address(RVA = "0x7322C0", Offset = "0x730EC0", VA = "0x1807322C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x0600FA83 RID: 64131 RVA: 0x0005E5D8 File Offset: 0x0005C7D8
		[Token(Token = "0x17002161")]
		public bool isOverrideKillCnt
		{
			[Token(Token = "0x600FA83")]
			[Address(RVA = "0x732410", Offset = "0x731010", VA = "0x180732410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x0600FA84 RID: 64132 RVA: 0x0005E5F0 File Offset: 0x0005C7F0
		[Token(Token = "0x17002162")]
		public int overrideKillCnt
		{
			[Token(Token = "0x600FA84")]
			[Address(RVA = "0x733730", Offset = "0x732330", VA = "0x180733730")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x0600FA85 RID: 64133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002163")]
		protected HierachyStateMachine<Enemy.States.State, Enemy, Enemy.States.Blackboard> stateMachine
		{
			[Token(Token = "0x600FA85")]
			[Address(RVA = "0x733F50", Offset = "0x732B50", VA = "0x180733F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x0600FA86 RID: 64134 RVA: 0x0005E608 File Offset: 0x0005C808
		[Token(Token = "0x17002164")]
		protected override bool isFixedRotation
		{
			[Token(Token = "0x600FA86")]
			[Address(RVA = "0x731BF0", Offset = "0x7307F0", VA = "0x180731BF0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x0600FA87 RID: 64135 RVA: 0x0005E620 File Offset: 0x0005C820
		[Token(Token = "0x17002165")]
		protected override int initState
		{
			[Token(Token = "0x600FA87")]
			[Address(RVA = "0x731A70", Offset = "0x730670", VA = "0x180731A70", Slot = "68")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x0600FA88 RID: 64136 RVA: 0x0005E638 File Offset: 0x0005C838
		[Token(Token = "0x17002166")]
		protected override float delayToRecycle
		{
			[Token(Token = "0x600FA88")]
			[Address(RVA = "0x7306E0", Offset = "0x72F2E0", VA = "0x1807306E0", Slot = "66")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x0600FA89 RID: 64137 RVA: 0x0005E650 File Offset: 0x0005C850
		[Token(Token = "0x17002167")]
		protected virtual SideTypeIndex sideTypeIndex
		{
			[Token(Token = "0x600FA89")]
			[Address(RVA = "0x733BA0", Offset = "0x7327A0", VA = "0x180733BA0", Slot = "201")]
			get
			{
				return SideTypeIndex.ALLY;
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x0600FA8A RID: 64138 RVA: 0x0005E668 File Offset: 0x0005C868
		[Token(Token = "0x17002168")]
		public float delayToBorn
		{
			[Token(Token = "0x600FA8A")]
			[Address(RVA = "0x730550", Offset = "0x72F150", VA = "0x180730550")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x0600FA8B RID: 64139 RVA: 0x0005E680 File Offset: 0x0005C880
		[Token(Token = "0x17002169")]
		public override FP createdTime
		{
			[Token(Token = "0x600FA8B")]
			[Address(RVA = "0x730180", Offset = "0x72ED80", VA = "0x180730180", Slot = "55")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x0600FA8C RID: 64140 RVA: 0x0005E698 File Offset: 0x0005C898
		[Token(Token = "0x1700216A")]
		public bool isInEnemySide
		{
			[Token(Token = "0x600FA8C")]
			[Address(RVA = "0x7320E0", Offset = "0x730CE0", VA = "0x1807320E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x0600FA8D RID: 64141 RVA: 0x0005E6B0 File Offset: 0x0005C8B0
		[Token(Token = "0x1700216B")]
		public float mass
		{
			[Token(Token = "0x600FA8D")]
			[Address(RVA = "0x732AB0", Offset = "0x7316B0", VA = "0x180732AB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x0600FA8E RID: 64142 RVA: 0x0005E6C8 File Offset: 0x0005C8C8
		// (set) Token: 0x0600FA8F RID: 64143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700216C")]
		public virtual Vector2 velocity
		{
			[Token(Token = "0x600FA8E")]
			[Address(RVA = "0x7346E0", Offset = "0x7332E0", VA = "0x1807346E0", Slot = "202")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600FA8F")]
			[Address(RVA = "0x735290", Offset = "0x733E90", VA = "0x180735290", Slot = "203")]
			set
			{
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x0600FA90 RID: 64144 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA91 RID: 64145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700216D")]
		private protected Rigidbody2D rigidbody2D
		{
			[Token(Token = "0x600FA90")]
			[Address(RVA = "0x733820", Offset = "0x732420", VA = "0x180733820")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600FA91")]
			[Address(RVA = "0x735150", Offset = "0x733D50", VA = "0x180735150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x0600FA92 RID: 64146 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA93 RID: 64147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700216E")]
		private protected Enemy.AttackWrapper attackWrapper
		{
			[Token(Token = "0x600FA92")]
			[Address(RVA = "0x72FCB0", Offset = "0x72E8B0", VA = "0x18072FCB0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600FA93")]
			[Address(RVA = "0x734800", Offset = "0x733400", VA = "0x180734800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x0600FA94 RID: 64148 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA95 RID: 64149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700216F")]
		private protected Enemy.CombatWrapper combatWrapper
		{
			[Token(Token = "0x600FA94")]
			[Address(RVA = "0x730060", Offset = "0x72EC60", VA = "0x180730060")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600FA95")]
			[Address(RVA = "0x734A90", Offset = "0x733690", VA = "0x180734A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x0600FA96 RID: 64150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002170")]
		public Ability lastAttackOrCombatAbility
		{
			[Token(Token = "0x600FA96")]
			[Address(RVA = "0x732520", Offset = "0x731120", VA = "0x180732520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x0600FA97 RID: 64151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002171")]
		public Ability mainCombatAbility
		{
			[Token(Token = "0x600FA97")]
			[Address(RVA = "0x732910", Offset = "0x731510", VA = "0x180732910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x0600FA98 RID: 64152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002172")]
		public EnemySkill lastSkill
		{
			[Token(Token = "0x600FA98")]
			[Address(RVA = "0x732740", Offset = "0x731340", VA = "0x180732740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x0600FA99 RID: 64153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002173")]
		protected string deadEffect
		{
			[Token(Token = "0x600FA99")]
			[Address(RVA = "0x730300", Offset = "0x72EF00", VA = "0x180730300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600FA9A RID: 64154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002174")]
		protected string startEffect
		{
			[Token(Token = "0x600FA9A")]
			[Address(RVA = "0x733ED0", Offset = "0x732AD0", VA = "0x180733ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x0600FA9B RID: 64155 RVA: 0x0005E6E0 File Offset: 0x0005C8E0
		[Token(Token = "0x17002175")]
		protected float moveSpdTotalScale
		{
			[Token(Token = "0x600FA9B")]
			[Address(RVA = "0x733050", Offset = "0x731C50", VA = "0x180733050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x0600FA9C RID: 64156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002176")]
		public TracePositionCursor traceTargetCursor
		{
			[Token(Token = "0x600FA9C")]
			[Address(RVA = "0x734150", Offset = "0x732D50", VA = "0x180734150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x0600FA9D RID: 64157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002177")]
		public virtual DirectionCursor cursor
		{
			[Token(Token = "0x600FA9D")]
			[Address(RVA = "0x730200", Offset = "0x72EE00", VA = "0x180730200", Slot = "204")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x0600FA9E RID: 64158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002178")]
		public virtual DirectionCursor moveCursor
		{
			[Token(Token = "0x600FA9E")]
			[Address(RVA = "0x732D80", Offset = "0x731980", VA = "0x180732D80", Slot = "205")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x0600FA9F RID: 64159 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FAA0 RID: 64160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002179")]
		public BaseTraceTargetAbility traceTargetAbility
		{
			[Token(Token = "0x600FA9F")]
			[Address(RVA = "0x7340D0", Offset = "0x732CD0", VA = "0x1807340D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600FAA0")]
			[Address(RVA = "0x7351F0", Offset = "0x733DF0", VA = "0x1807351F0")]
			set
			{
			}
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x0600FAA1 RID: 64161 RVA: 0x0005E6F8 File Offset: 0x0005C8F8
		[Token(Token = "0x1700217A")]
		public virtual bool usingTraceCursor
		{
			[Token(Token = "0x600FAA1")]
			[Address(RVA = "0x7345C0", Offset = "0x7331C0", VA = "0x1807345C0", Slot = "206")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x0600FAA2 RID: 64162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700217B")]
		public virtual Entity traceTarget
		{
			[Token(Token = "0x600FAA2")]
			[Address(RVA = "0x734330", Offset = "0x732F30", VA = "0x180734330", Slot = "207")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x0600FAA3 RID: 64163 RVA: 0x0005E710 File Offset: 0x0005C910
		[Token(Token = "0x1700217C")]
		public float frictionFactor
		{
			[Token(Token = "0x600FAA3")]
			[Address(RVA = "0x7311C0", Offset = "0x72FDC0", VA = "0x1807311C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x0600FAA4 RID: 64164 RVA: 0x0005E728 File Offset: 0x0005C928
		[Token(Token = "0x1700217D")]
		public virtual int preloadCnt
		{
			[Token(Token = "0x600FAA4")]
			[Address(RVA = "0x7337B0", Offset = "0x7323B0", VA = "0x1807337B0", Slot = "208")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x0600FAA5 RID: 64165 RVA: 0x0005E740 File Offset: 0x0005C940
		// (set) Token: 0x0600FAA6 RID: 64166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700217E")]
		public bool disableSwitchFaceByMove
		{
			[Token(Token = "0x600FAA5")]
			[Address(RVA = "0x730920", Offset = "0x72F520", VA = "0x180730920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600FAA6")]
			[Address(RVA = "0x734CF0", Offset = "0x7338F0", VA = "0x180734CF0")]
			set
			{
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x0600FAA7 RID: 64167 RVA: 0x0005E758 File Offset: 0x0005C958
		[Token(Token = "0x1700217F")]
		private bool scaleMoveBySpeed
		{
			[Token(Token = "0x600FAA7")]
			[Address(RVA = "0x733A20", Offset = "0x732620", VA = "0x180733A20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x0600FAA8 RID: 64168 RVA: 0x0005E770 File Offset: 0x0005C970
		[Token(Token = "0x17002180")]
		public virtual bool updateHpColor
		{
			[Token(Token = "0x600FAA8")]
			[Address(RVA = "0x734550", Offset = "0x733150", VA = "0x180734550", Slot = "209")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x0600FAA9 RID: 64169 RVA: 0x0005E788 File Offset: 0x0005C988
		[Token(Token = "0x17002181")]
		public virtual Color hpColor
		{
			[Token(Token = "0x600FAA9")]
			[Address(RVA = "0x731670", Offset = "0x730270", VA = "0x180731670", Slot = "210")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0600FAAA RID: 64170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAAA")]
		[Address(RVA = "0x72BAA0", Offset = "0x72A6A0", VA = "0x18072BAA0")]
		public void UpdateFrictionFactor(float value)
		{
		}

		// Token: 0x0600FAAB RID: 64171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAAB")]
		[Address(RVA = "0x729220", Offset = "0x727E20", VA = "0x180729220")]
		public void RestoreFrictionFactor()
		{
		}

		// Token: 0x0600FAAC RID: 64172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAAC")]
		[Address(RVA = "0x72F520", Offset = "0x72E120", VA = "0x18072F520")]
		private void _UpdateFrictionFactorAdditional(float value)
		{
		}

		// Token: 0x0600FAAD RID: 64173 RVA: 0x0005E7A0 File Offset: 0x0005C9A0
		[Token(Token = "0x600FAAD")]
		[Address(RVA = "0x729110", Offset = "0x727D10", VA = "0x180729110")]
		public bool RestoreCachedRoute()
		{
			return default(bool);
		}

		// Token: 0x0600FAAE RID: 64174 RVA: 0x0005E7B8 File Offset: 0x0005C9B8
		[Token(Token = "0x600FAAE")]
		[Address(RVA = "0x72B290", Offset = "0x729E90", VA = "0x18072B290")]
		public bool TryReassignRouteAndCacheOrigin(Route route)
		{
			return default(bool);
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x0600FAAF RID: 64175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002182")]
		public Route originRoute
		{
			[Token(Token = "0x600FAAF")]
			[Address(RVA = "0x733670", Offset = "0x732270", VA = "0x180733670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x0600FAB0 RID: 64176 RVA: 0x0005E7D0 File Offset: 0x0005C9D0
		[Token(Token = "0x17002183")]
		public int originCursorIndex
		{
			[Token(Token = "0x600FAB0")]
			[Address(RVA = "0x733510", Offset = "0x732110", VA = "0x180733510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600FAB1 RID: 64177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAB1")]
		[Address(RVA = "0x7240F0", Offset = "0x722CF0", VA = "0x1807240F0")]
		public void InterruptLastAbilityIfNot(bool resetCooldown, [Optional] Ability ability)
		{
		}

		// Token: 0x0600FAB2 RID: 64178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAB2")]
		[Address(RVA = "0x729E10", Offset = "0x728A10", VA = "0x180729E10", Slot = "211")]
		public virtual void Spawn(LevelData.EnemyData data, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route, Enemy.Options options)
		{
		}

		// Token: 0x0600FAB3 RID: 64179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAB3")]
		[Address(RVA = "0x720C40", Offset = "0x71F840", VA = "0x180720C40", Slot = "24")]
		public override void Born()
		{
		}

		// Token: 0x0600FAB4 RID: 64180 RVA: 0x0005E7E8 File Offset: 0x0005C9E8
		[Token(Token = "0x600FAB4")]
		[Address(RVA = "0x7239C0", Offset = "0x7225C0", VA = "0x1807239C0", Slot = "176")]
		public override float GetModeRangeRadius(UnitMode mode)
		{
			return 0f;
		}

		// Token: 0x0600FAB5 RID: 64181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FAB5")]
		[Address(RVA = "0x723780", Offset = "0x722380", VA = "0x180723780", Slot = "178")]
		public override AbstractBasicAttack GetCurrentAttackOrCombatAbility()
		{
			return null;
		}

		// Token: 0x0600FAB6 RID: 64182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAB6")]
		[Address(RVA = "0x727DC0", Offset = "0x7269C0", VA = "0x180727DC0", Slot = "169")]
		public override void PlayAudioSignal(string ev, bool ignorePredefined)
		{
		}

		// Token: 0x0600FAB7 RID: 64183 RVA: 0x0005E800 File Offset: 0x0005CA00
		[Token(Token = "0x600FAB7")]
		[Address(RVA = "0x72AF70", Offset = "0x729B70", VA = "0x18072AF70", Slot = "105")]
		public override bool TryHookAudio(string signal, string subSignal, out string newSignal, out string newSubsignal)
		{
			return default(bool);
		}

		// Token: 0x0600FAB8 RID: 64184 RVA: 0x0005E818 File Offset: 0x0005CA18
		[Token(Token = "0x600FAB8")]
		[Address(RVA = "0x721760", Offset = "0x720360", VA = "0x180721760", Slot = "97")]
		public override bool CheckHasFilterTag(string enemyTag)
		{
			return default(bool);
		}

		// Token: 0x0600FAB9 RID: 64185 RVA: 0x0005E830 File Offset: 0x0005CA30
		[Token(Token = "0x600FAB9")]
		[Address(RVA = "0x72A4B0", Offset = "0x7290B0", VA = "0x18072A4B0")]
		public bool TriggerEnemySkill(Ability ability, Entity target, EnemySkill skill, bool assignCombatAbility = true)
		{
			return default(bool);
		}

		// Token: 0x0600FABA RID: 64186 RVA: 0x0005E848 File Offset: 0x0005CA48
		[Token(Token = "0x600FABA")]
		[Address(RVA = "0x721640", Offset = "0x720240", VA = "0x180721640")]
		public bool CheckEnemySkillAffecting()
		{
			return default(bool);
		}

		// Token: 0x0600FABB RID: 64187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FABB")]
		[Address(RVA = "0x722760", Offset = "0x721360", VA = "0x180722760", Slot = "163")]
		public override Entity FetchHost()
		{
			return null;
		}

		// Token: 0x0600FABC RID: 64188 RVA: 0x0005E860 File Offset: 0x0005CA60
		[Token(Token = "0x600FABC")]
		[Address(RVA = "0x721540", Offset = "0x720140", VA = "0x180721540")]
		public bool CheckBlockable(Character blocker)
		{
			return default(bool);
		}

		// Token: 0x0600FABD RID: 64189 RVA: 0x0005E878 File Offset: 0x0005CA78
		[Token(Token = "0x600FABD")]
		[Address(RVA = "0x721300", Offset = "0x71FF00", VA = "0x180721300")]
		public bool CheckBlockableWithoutCheckRange(Character blocker)
		{
			return default(bool);
		}

		// Token: 0x0600FABE RID: 64190 RVA: 0x0005E890 File Offset: 0x0005CA90
		[Token(Token = "0x600FABE")]
		[Address(RVA = "0x72CB80", Offset = "0x72B780", VA = "0x18072CB80")]
		private bool _CheckMotionModeBlockable(Character blocker)
		{
			return default(bool);
		}

		// Token: 0x0600FABF RID: 64191 RVA: 0x0005E8A8 File Offset: 0x0005CAA8
		[Token(Token = "0x600FABF")]
		[Address(RVA = "0x72CC50", Offset = "0x72B850", VA = "0x18072CC50")]
		private bool _CheckSpecialBlockCondition(Character blocker)
		{
			return default(bool);
		}

		// Token: 0x0600FAC0 RID: 64192 RVA: 0x0005E8C0 File Offset: 0x0005CAC0
		[Token(Token = "0x600FAC0")]
		[Address(RVA = "0x728D60", Offset = "0x727960", VA = "0x180728D60")]
		public bool RegisterBlocker(Character blocker, Vector2 offset)
		{
			return default(bool);
		}

		// Token: 0x0600FAC1 RID: 64193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAC1")]
		[Address(RVA = "0x72B8B0", Offset = "0x72A4B0", VA = "0x18072B8B0")]
		public void UnregisterBlocker(Character blocker)
		{
		}

		// Token: 0x0600FAC2 RID: 64194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAC2")]
		[Address(RVA = "0x725580", Offset = "0x724180", VA = "0x180725580")]
		private void OnBlockVolumeChanged()
		{
		}

		// Token: 0x0600FAC3 RID: 64195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAC3")]
		[Address(RVA = "0x7248B0", Offset = "0x7234B0", VA = "0x1807248B0", Slot = "212")]
		public virtual void KnockBack(Vector2 direction, float force, bool changeFaceByDirection)
		{
		}

		// Token: 0x0600FAC4 RID: 64196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAC4")]
		[Address(RVA = "0x721CE0", Offset = "0x7208E0", VA = "0x180721CE0")]
		public void DisableCurrentStillPull()
		{
		}

		// Token: 0x0600FAC5 RID: 64197 RVA: 0x0005E8D8 File Offset: 0x0005CAD8
		[Token(Token = "0x600FAC5")]
		[Address(RVA = "0x71FE00", Offset = "0x71EA00", VA = "0x18071FE00", Slot = "213")]
		public virtual bool BeginPull(BObject source, Vector2 direction, float force)
		{
			return default(bool);
		}

		// Token: 0x0600FAC6 RID: 64198 RVA: 0x0005E8F0 File Offset: 0x0005CAF0
		[Token(Token = "0x600FAC6")]
		[Address(RVA = "0x72A000", Offset = "0x728C00", VA = "0x18072A000")]
		public bool StillPull(BObject source, Vector2 direction, float force)
		{
			return default(bool);
		}

		// Token: 0x0600FAC7 RID: 64199 RVA: 0x0005E908 File Offset: 0x0005CB08
		[Token(Token = "0x600FAC7")]
		[Address(RVA = "0x72A880", Offset = "0x729480", VA = "0x18072A880")]
		public bool TryEarlyStopPull(BObject source)
		{
			return default(bool);
		}

		// Token: 0x0600FAC8 RID: 64200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAC8")]
		[Address(RVA = "0x7221E0", Offset = "0x720DE0", VA = "0x1807221E0", Slot = "214")]
		public virtual void EndPull(BObject source)
		{
		}

		// Token: 0x0600FAC9 RID: 64201 RVA: 0x0005E920 File Offset: 0x0005CB20
		[Token(Token = "0x600FAC9")]
		[Address(RVA = "0x722590", Offset = "0x721190", VA = "0x180722590", Slot = "215")]
		public virtual bool FallDown(Tile tile, MotionMode mode = MotionMode.WALK)
		{
			return default(bool);
		}

		// Token: 0x0600FACA RID: 64202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FACA")]
		[Address(RVA = "0x726820", Offset = "0x725420", VA = "0x180726820", Slot = "124")]
		protected override void OnMotionModeChanged(MotionMode oldMode, MotionMode newMode)
		{
		}

		// Token: 0x0600FACB RID: 64203 RVA: 0x0005E938 File Offset: 0x0005CB38
		[Token(Token = "0x600FACB")]
		[Address(RVA = "0x721830", Offset = "0x720430", VA = "0x180721830")]
		public bool CheckReadyToFallDown()
		{
			return default(bool);
		}

		// Token: 0x0600FACC RID: 64204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FACC")]
		[Address(RVA = "0x727FE0", Offset = "0x726BE0", VA = "0x180727FE0")]
		public void PlayMoveAnim()
		{
		}

		// Token: 0x0600FACD RID: 64205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FACD")]
		[Address(RVA = "0x72E9C0", Offset = "0x72D5C0", VA = "0x18072E9C0")]
		private void _RemoveInvalidPullSources()
		{
		}

		// Token: 0x0600FACE RID: 64206 RVA: 0x0005E950 File Offset: 0x0005CB50
		[Token(Token = "0x600FACE")]
		[Address(RVA = "0x729D20", Offset = "0x728920", VA = "0x180729D20")]
		public bool SetStruggling(bool struggling)
		{
			return default(bool);
		}

		// Token: 0x0600FACF RID: 64207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FACF")]
		[Address(RVA = "0x7295D0", Offset = "0x7281D0", VA = "0x1807295D0")]
		public void SetCanNotExit(bool canNotExit)
		{
		}

		// Token: 0x0600FAD0 RID: 64208 RVA: 0x0005E968 File Offset: 0x0005CB68
		[Token(Token = "0x600FAD0")]
		[Address(RVA = "0x720710", Offset = "0x71F310", VA = "0x180720710")]
		public bool Blink(float distance, float hideTime, bool blinkUseAnimTime, bool withoutSwitchToBlinkState, bool skipDisappearCheckpoint = false)
		{
			return default(bool);
		}

		// Token: 0x0600FAD1 RID: 64209 RVA: 0x0005E980 File Offset: 0x0005CB80
		[Token(Token = "0x600FAD1")]
		[Address(RVA = "0x720490", Offset = "0x71F090", VA = "0x180720490")]
		public bool Blink(GridPosition grid)
		{
			return default(bool);
		}

		// Token: 0x0600FAD2 RID: 64210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAD2")]
		[Address(RVA = "0x729380", Offset = "0x727F80", VA = "0x180729380")]
		public void SetBodyColor(Color newColor)
		{
		}

		// Token: 0x0600FAD3 RID: 64211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAD3")]
		[Address(RVA = "0x7202E0", Offset = "0x71EEE0", VA = "0x1807202E0")]
		protected void BlinkWithoutSwitchToBlinkState(float distance, bool skipDisappearCheckpoint = false)
		{
		}

		// Token: 0x0600FAD4 RID: 64212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAD4")]
		[Address(RVA = "0x720150", Offset = "0x71ED50", VA = "0x180720150")]
		protected void BlinkToGridPositionWithoutSwitchToBlinkState(GridPosition grid)
		{
		}

		// Token: 0x0600FAD5 RID: 64213 RVA: 0x0005E998 File Offset: 0x0005CB98
		[Token(Token = "0x600FAD5")]
		[Address(RVA = "0x72ACB0", Offset = "0x7298B0", VA = "0x18072ACB0")]
		public bool TryGetDistanceToNextCheckpoint(out float distance)
		{
			return default(bool);
		}

		// Token: 0x0600FAD6 RID: 64214 RVA: 0x0005E9B0 File Offset: 0x0005CBB0
		[Token(Token = "0x600FAD6")]
		[Address(RVA = "0x72ABD0", Offset = "0x7297D0", VA = "0x18072ABD0")]
		public bool TryGetDistanceToMapPosInCheckpointsAhead(GridPosition gridPos, out float distance)
		{
			return default(bool);
		}

		// Token: 0x0600FAD7 RID: 64215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAD7")]
		[Address(RVA = "0x721BD0", Offset = "0x7207D0", VA = "0x180721BD0")]
		public void ClearTraceIfExist()
		{
		}

		// Token: 0x0600FAD8 RID: 64216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAD8")]
		[Address(RVA = "0x728720", Offset = "0x727320", VA = "0x180728720")]
		public void ReassignRoute(Route route, int cursorIndex)
		{
		}

		// Token: 0x0600FAD9 RID: 64217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAD9")]
		[Address(RVA = "0x728C20", Offset = "0x727820", VA = "0x180728C20")]
		public void ReconstructRoute(GridPosition endGridPos, RouteData.CheckpointData[] checkPointDataArray)
		{
		}

		// Token: 0x0600FADA RID: 64218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FADA")]
		[Address(RVA = "0x7287F0", Offset = "0x7273F0", VA = "0x1807287F0")]
		public void ReconstructRouteWithTargetGridMove(GridPosition targetPosition, [Optional] Vector2 offset)
		{
		}

		// Token: 0x0600FADB RID: 64219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FADB")]
		[Address(RVA = "0x72A310", Offset = "0x728F10", VA = "0x18072A310")]
		public void TransportInternal(Vector2 dir, Route route, int cursorIndex, Vector2 targetPos)
		{
		}

		// Token: 0x0600FADC RID: 64220 RVA: 0x0005E9C8 File Offset: 0x0005CBC8
		[Token(Token = "0x600FADC")]
		[Address(RVA = "0x72AE20", Offset = "0x729A20", VA = "0x18072AE20")]
		public bool TryGetNextAppearCheckpoint(out int nextAppearCp, out Vector2 mapPos)
		{
			return default(bool);
		}

		// Token: 0x0600FADD RID: 64221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FADD")]
		[Address(RVA = "0x72A210", Offset = "0x728E10", VA = "0x18072A210")]
		public void SwitchToDeadState()
		{
		}

		// Token: 0x0600FADE RID: 64222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FADE")]
		[Address(RVA = "0x7283F0", Offset = "0x726FF0", VA = "0x1807283F0", Slot = "185")]
		public override void PopulateSnapshotToHashBuilder(HashCodeBuilder builder)
		{
		}

		// Token: 0x0600FADF RID: 64223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FADF")]
		[Address(RVA = "0x7284B0", Offset = "0x7270B0", VA = "0x1807284B0", Slot = "186")]
		public override void PopulateSnapshotToStrBuilder(StringBuilder builder)
		{
		}

		// Token: 0x0600FAE0 RID: 64224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE0")]
		[Address(RVA = "0x723280", Offset = "0x721E80", VA = "0x180723280", Slot = "172")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600FAE1 RID: 64225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE1")]
		[Address(RVA = "0x723BB0", Offset = "0x7227B0", VA = "0x180723BB0", Slot = "216")]
		protected virtual void Init(LevelData.EnemyData data, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route)
		{
		}

		// Token: 0x0600FAE2 RID: 64226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE2")]
		[Address(RVA = "0x720FD0", Offset = "0x71FBD0", VA = "0x180720FD0", Slot = "93")]
		public override void ChangePathMotionMode(MotionMode mode)
		{
		}

		// Token: 0x0600FAE3 RID: 64227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE3")]
		[Address(RVA = "0x726C90", Offset = "0x725890", VA = "0x180726C90", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FAE4 RID: 64228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE4")]
		[Address(RVA = "0x725660", Offset = "0x724260", VA = "0x180725660", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FAE5 RID: 64229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE5")]
		[Address(RVA = "0x723AB0", Offset = "0x7226B0", VA = "0x180723AB0")]
		public void InitFaceTo()
		{
		}

		// Token: 0x0600FAE6 RID: 64230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE6")]
		[Address(RVA = "0x7269A0", Offset = "0x7255A0", VA = "0x1807269A0", Slot = "184")]
		public override void OnReborn(Unit.RebornData data)
		{
		}

		// Token: 0x0600FAE7 RID: 64231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE7")]
		[Address(RVA = "0x7292A0", Offset = "0x727EA0", VA = "0x1807292A0", Slot = "86")]
		public override void SetBodyAndFaceDirection(Vector2 direction, bool force = false)
		{
		}

		// Token: 0x0600FAE8 RID: 64232 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
		[Token(Token = "0x600FAE8")]
		[Address(RVA = "0x72B130", Offset = "0x729D30", VA = "0x18072B130", Slot = "104")]
		public override bool TryIgnoreEffect(string originEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600FAE9 RID: 64233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAE9")]
		[Address(RVA = "0x725D50", Offset = "0x724950", VA = "0x180725D50", Slot = "123")]
		protected override void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle)
		{
		}

		// Token: 0x0600FAEA RID: 64234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAEA")]
		[Address(RVA = "0x729480", Offset = "0x728080", VA = "0x180729480")]
		protected void SetBodyDirectionWithPolicy(Vector2 dir, bool force)
		{
		}

		// Token: 0x0600FAEB RID: 64235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAEB")]
		[Address(RVA = "0x725B90", Offset = "0x724790", VA = "0x180725B90", Slot = "34")]
		protected override void OnDisappearChanged(bool newValue)
		{
		}

		// Token: 0x0600FAEC RID: 64236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAEC")]
		[Address(RVA = "0x727200", Offset = "0x725E00", VA = "0x180727200", Slot = "182")]
		protected override void OnSwitchMode(UnitMode next, UnitMode last, bool restartFSM)
		{
		}

		// Token: 0x0600FAED RID: 64237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAED")]
		[Address(RVA = "0x7263C0", Offset = "0x724FC0", VA = "0x1807263C0", Slot = "117")]
		protected override void OnHpZero(bool noSource, bool skipReborn)
		{
		}

		// Token: 0x0600FAEE RID: 64238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAEE")]
		[Address(RVA = "0x724E90", Offset = "0x723A90", VA = "0x180724E90", Slot = "122")]
		protected override void OnAttributeDirty(AttributeType attributeType, FP oldValue)
		{
		}

		// Token: 0x0600FAEF RID: 64239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FAEF")]
		[Address(RVA = "0x721C60", Offset = "0x720860", VA = "0x180721C60", Slot = "112")]
		protected override StateMachine ConstructStateMachine()
		{
			return null;
		}

		// Token: 0x0600FAF0 RID: 64240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAF0")]
		[Address(RVA = "0x722970", Offset = "0x721570", VA = "0x180722970", Slot = "113")]
		protected override void FinishMe(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600FAF1 RID: 64241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAF1")]
		[Address(RVA = "0x721DC0", Offset = "0x7209C0", VA = "0x180721DC0", Slot = "180")]
		protected override void DoFakeDeath(Unit.RebornData rebornData)
		{
		}

		// Token: 0x0600FAF2 RID: 64242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAF2")]
		[Address(RVA = "0x721EC0", Offset = "0x720AC0", VA = "0x180721EC0", Slot = "181")]
		protected override void DoReborn(Unit.RebornData data)
		{
		}

		// Token: 0x0600FAF3 RID: 64243 RVA: 0x0005E9F8 File Offset: 0x0005CBF8
		[Token(Token = "0x600FAF3")]
		[Address(RVA = "0x72E0A0", Offset = "0x72CCA0", VA = "0x18072E0A0", Slot = "217")]
		protected virtual Vector2 _MoveByRoute(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FAF4 RID: 64244 RVA: 0x0005EA10 File Offset: 0x0005CC10
		[Token(Token = "0x600FAF4")]
		[Address(RVA = "0x72E280", Offset = "0x72CE80", VA = "0x18072E280", Slot = "218")]
		protected virtual Vector2 _MoveInFearArea(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FAF5 RID: 64245 RVA: 0x0005EA28 File Offset: 0x0005CC28
		[Token(Token = "0x600FAF5")]
		[Address(RVA = "0x72E180", Offset = "0x72CD80", VA = "0x18072E180", Slot = "219")]
		protected virtual Vector2 _MoveInAttractArea(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FAF6 RID: 64246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAF6")]
		[Address(RVA = "0x72E710", Offset = "0x72D310", VA = "0x18072E710")]
		private void _MoveToFixedDirection(Vector2 direction, FP deltaTime)
		{
		}

		// Token: 0x0600FAF7 RID: 64247 RVA: 0x0005EA40 File Offset: 0x0005CC40
		[Token(Token = "0x600FAF7")]
		[Address(RVA = "0x72D9B0", Offset = "0x72C5B0", VA = "0x18072D9B0")]
		private Vector2 _MoveByCursor(DirectionCursor cursor, float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FAF8 RID: 64248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAF8")]
		[Address(RVA = "0x728F90", Offset = "0x727B90", VA = "0x180728F90")]
		public void ReleaseFromBlocker()
		{
		}

		// Token: 0x0600FAF9 RID: 64249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAF9")]
		[Address(RVA = "0x72EBA0", Offset = "0x72D7A0", VA = "0x18072EBA0")]
		private void _ResetPhysicsStatus()
		{
		}

		// Token: 0x0600FAFA RID: 64250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAFA")]
		[Address(RVA = "0x72E8C0", Offset = "0x72D4C0", VA = "0x18072E8C0")]
		private void _ReactivateMainTriggerCollider()
		{
		}

		// Token: 0x0600FAFB RID: 64251 RVA: 0x0005EA58 File Offset: 0x0005CC58
		[Token(Token = "0x600FAFB")]
		[Address(RVA = "0x72EE50", Offset = "0x72DA50", VA = "0x18072EE50")]
		private bool _SearchAttackTarget()
		{
			return default(bool);
		}

		// Token: 0x0600FAFC RID: 64252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAFC")]
		[Address(RVA = "0x72D4F0", Offset = "0x72C0F0", VA = "0x18072D4F0")]
		private void _InitCurrentTile()
		{
		}

		// Token: 0x0600FAFD RID: 64253 RVA: 0x0005EA70 File Offset: 0x0005CC70
		[Token(Token = "0x600FAFD")]
		[Address(RVA = "0x72CD20", Offset = "0x72B920", VA = "0x18072CD20")]
		private bool _CheckTileCanExit(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600FAFE RID: 64254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FAFE")]
		[Address(RVA = "0x72BA10", Offset = "0x72A610", VA = "0x18072BA10")]
		public void UpdateCurrentTile(bool force)
		{
		}

		// Token: 0x0600FAFF RID: 64255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FAFF")]
		[Address(RVA = "0x72AD70", Offset = "0x729970", VA = "0x18072AD70")]
		public EnemySkill TryGetFirstAttachedSkill(string skillName)
		{
			return null;
		}

		// Token: 0x0600FB00 RID: 64256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB00")]
		[Address(RVA = "0x72EF00", Offset = "0x72DB00", VA = "0x18072EF00")]
		private void _UpdateCurrentTile(bool force)
		{
		}

		// Token: 0x0600FB01 RID: 64257 RVA: 0x0005EA88 File Offset: 0x0005CC88
		[Token(Token = "0x600FB01")]
		[Address(RVA = "0x72D040", Offset = "0x72BC40", VA = "0x18072D040")]
		private bool _CursorNeedCheckReached(Enemy.CursorType cursor)
		{
			return default(bool);
		}

		// Token: 0x0600FB02 RID: 64258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB02")]
		[Address(RVA = "0x729960", Offset = "0x728560", VA = "0x180729960")]
		public void SetHeightDirectly(float height, bool isDirectly = true)
		{
		}

		// Token: 0x0600FB03 RID: 64259 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
		[Token(Token = "0x600FB03")]
		[Address(RVA = "0x72D3C0", Offset = "0x72BFC0", VA = "0x18072D3C0")]
		private float _GetRootTileDeltaHeight()
		{
			return 0f;
		}

		// Token: 0x0600FB04 RID: 64260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB04")]
		[Address(RVA = "0x729B40", Offset = "0x728740", VA = "0x180729B40", Slot = "12")]
		public override void SetHeight(float height, bool isInit = false)
		{
		}

		// Token: 0x0600FB05 RID: 64261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB05")]
		[Address(RVA = "0x7296F0", Offset = "0x7282F0", VA = "0x1807296F0")]
		public void SetEnemyHeightOffset(float offset, bool instant, bool isSet)
		{
		}

		// Token: 0x0600FB06 RID: 64262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB06")]
		[Address(RVA = "0x71FD40", Offset = "0x71E940", VA = "0x18071FD40")]
		public void AdjustEnemyHeightByInitial(float offset, bool instant)
		{
		}

		// Token: 0x0600FB07 RID: 64263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB07")]
		[Address(RVA = "0x729AB0", Offset = "0x7286B0", VA = "0x180729AB0")]
		public void SetHeightImmediatelyChange()
		{
		}

		// Token: 0x0600FB08 RID: 64264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB08")]
		[Address(RVA = "0x7297C0", Offset = "0x7283C0", VA = "0x1807297C0")]
		protected void SetEnemyLevitateOffset(float offset)
		{
		}

		// Token: 0x0600FB09 RID: 64265 RVA: 0x0005EAB8 File Offset: 0x0005CCB8
		[Token(Token = "0x600FB09")]
		[Address(RVA = "0x724430", Offset = "0x723030", VA = "0x180724430")]
		public bool IsHanging()
		{
			return default(bool);
		}

		// Token: 0x0600FB0A RID: 64266 RVA: 0x0005EAD0 File Offset: 0x0005CCD0
		[Token(Token = "0x600FB0A")]
		[Address(RVA = "0x7245A0", Offset = "0x7231A0", VA = "0x1807245A0", Slot = "92")]
		public override bool IsStayStill()
		{
			return default(bool);
		}

		// Token: 0x0600FB0B RID: 64267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB0B")]
		[Address(RVA = "0x727120", Offset = "0x725D20", VA = "0x180727120", Slot = "220")]
		protected virtual void OnRootTileChanged(Tile newTile, Tile oldTile)
		{
		}

		// Token: 0x0600FB0C RID: 64268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB0C")]
		[Address(RVA = "0x728320", Offset = "0x726F20", VA = "0x180728320", Slot = "221")]
		public virtual void PlayUnbalanceAnimation()
		{
		}

		// Token: 0x0600FB0D RID: 64269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB0D")]
		[Address(RVA = "0x724C40", Offset = "0x723840", VA = "0x180724C40")]
		public void ModifySpUIFlag(bool isShow)
		{
		}

		// Token: 0x0600FB0E RID: 64270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB0E")]
		[Address(RVA = "0x72E380", Offset = "0x72CF80", VA = "0x18072E380")]
		private void _MoveToBlockPosition(Vector2 mapPos)
		{
		}

		// Token: 0x0600FB0F RID: 64271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB0F")]
		[Address(RVA = "0x7224B0", Offset = "0x7210B0", VA = "0x1807224B0")]
		public void FaceToCalculateDirection(Vector2 moveDir)
		{
		}

		// Token: 0x0600FB10 RID: 64272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB10")]
		[Address(RVA = "0x728650", Offset = "0x727250", VA = "0x180728650")]
		public void ReachExit()
		{
		}

		// Token: 0x0600FB11 RID: 64273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB11")]
		[Address(RVA = "0x723190", Offset = "0x721D90", VA = "0x180723190", Slot = "91")]
		public override void FinishWithReachExit(bool switchState = false)
		{
		}

		// Token: 0x0600FB12 RID: 64274 RVA: 0x0005EAE8 File Offset: 0x0005CCE8
		[Token(Token = "0x600FB12")]
		[Address(RVA = "0x72C950", Offset = "0x72B550", VA = "0x18072C950")]
		protected Vector2 _CalculateFaceDirection(Vector2 moveDir)
		{
			return default(Vector2);
		}

		// Token: 0x0600FB13 RID: 64275 RVA: 0x0005EB00 File Offset: 0x0005CD00
		[Token(Token = "0x600FB13")]
		[Address(RVA = "0x72CF30", Offset = "0x72BB30", VA = "0x18072CF30")]
		private bool _CheckUseIdForAudioSignal(string ev)
		{
			return default(bool);
		}

		// Token: 0x0600FB14 RID: 64276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB14")]
		[Address(RVA = "0x72BB30", Offset = "0x72A730", VA = "0x18072BB30")]
		private void _AssignData(LevelData.EnemyData data, EnemyHandBookData handbookData)
		{
		}

		// Token: 0x0600FB15 RID: 64277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB15")]
		[Address(RVA = "0x72C090", Offset = "0x72AC90", VA = "0x18072C090")]
		private void _AssignSkill(IList<LevelData.EnemyData.ESkillData> skillsData)
		{
		}

		// Token: 0x0600FB16 RID: 64278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB16")]
		[Address(RVA = "0x72C610", Offset = "0x72B210", VA = "0x18072C610")]
		private void _AssignTalent(Blackboard talentBlackboard)
		{
		}

		// Token: 0x0600FB17 RID: 64279 RVA: 0x0005EB18 File Offset: 0x0005CD18
		[Token(Token = "0x600FB17")]
		[Address(RVA = "0x72D200", Offset = "0x72BE00", VA = "0x18072D200")]
		private int _GetDefaultModeIndex()
		{
			return 0;
		}

		// Token: 0x0600FB18 RID: 64280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FB18")]
		[Address(RVA = "0x723550", Offset = "0x722150", VA = "0x180723550", Slot = "171")]
		public override Blackboard GetAttackBlackboard(UnitMode mode)
		{
			return null;
		}

		// Token: 0x0600FB19 RID: 64281 RVA: 0x0005EB30 File Offset: 0x0005CD30
		[Token(Token = "0x600FB19")]
		[Address(RVA = "0x72AA10", Offset = "0x729610", VA = "0x18072AA10")]
		public bool TryFindFirstEnabledEnemySkill(string skillKey, out EnemySkill skillFound, bool checkActivate)
		{
			return default(bool);
		}

		// Token: 0x0600FB1A RID: 64282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB1A")]
		[Address(RVA = "0x724FF0", Offset = "0x723BF0", VA = "0x180724FF0", Slot = "183")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600FB1B RID: 64283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB1B")]
		[Address(RVA = "0x726550", Offset = "0x725150", VA = "0x180726550", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600FB1C RID: 64284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB1C")]
		[Address(RVA = "0x725E60", Offset = "0x724A60", VA = "0x180725E60", Slot = "119")]
		protected override void OnFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600FB1D RID: 64285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB1D")]
		[Address(RVA = "0x726B30", Offset = "0x725730", VA = "0x180726B30", Slot = "26")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0600FB1E RID: 64286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB1E")]
		[Address(RVA = "0x727670", Offset = "0x726270", VA = "0x180727670", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FB1F RID: 64287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB1F")]
		[Address(RVA = "0x721B10", Offset = "0x720710", VA = "0x180721B10")]
		public new static void ClearStaticVariables()
		{
		}

		// Token: 0x0600FB20 RID: 64288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB20")]
		[Address(RVA = "0x7273E0", Offset = "0x725FE0", VA = "0x1807273E0")]
		protected void OnTickAfterDead(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FB21 RID: 64289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB21")]
		[Address(RVA = "0x7253D0", Offset = "0x723FD0", VA = "0x1807253D0")]
		protected void OnBeforeAttack(Ability ability, bool isCombat)
		{
		}

		// Token: 0x0600FB22 RID: 64290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB22")]
		[Address(RVA = "0x724CD0", Offset = "0x7238D0", VA = "0x180724CD0")]
		protected void OnAfterAttack(Ability ability, bool isCombat, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600FB23 RID: 64291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB23")]
		[Address(RVA = "0x727C70", Offset = "0x726870", VA = "0x180727C70", Slot = "130")]
		public override void OnTriggerPalsy()
		{
		}

		// Token: 0x0600FB24 RID: 64292 RVA: 0x0005EB48 File Offset: 0x0005CD48
		[Token(Token = "0x600FB24")]
		[Address(RVA = "0x720DD0", Offset = "0x71F9D0", VA = "0x180720DD0", Slot = "132")]
		public override bool CanDoAbilitySpellOn(Ability ability, out Ability.FinishReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600FB25 RID: 64293 RVA: 0x0005EB60 File Offset: 0x0005CD60
		[Token(Token = "0x600FB25")]
		[Address(RVA = "0x7219B0", Offset = "0x7205B0", VA = "0x1807219B0")]
		public bool CheckTargetInAttackRange(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600FB26 RID: 64294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB26")]
		[Address(RVA = "0x72D640", Offset = "0x72C240", VA = "0x18072D640")]
		private void _InitPhysics()
		{
		}

		// Token: 0x0600FB27 RID: 64295 RVA: 0x0005EB78 File Offset: 0x0005CD78
		[Token(Token = "0x600FB27")]
		[Address(RVA = "0x72B570", Offset = "0x72A170", VA = "0x18072B570")]
		public bool TryUpdateEnemySkillSelector(string skillKey, bool checkActivate, string blackboardKey, FP value)
		{
			return default(bool);
		}

		// Token: 0x0600FB28 RID: 64296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FB28")]
		[Address(RVA = "0x72D110", Offset = "0x72BD10", VA = "0x18072D110")]
		protected SpData _GenerateSpData(LevelData.EnemyData data)
		{
			return null;
		}

		// Token: 0x0600FB29 RID: 64297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB29")]
		[Address(RVA = "0x720F30", Offset = "0x71FB30", VA = "0x180720F30", Slot = "94")]
		public override void ChangeMotionMode(MotionMode mode)
		{
		}

		// Token: 0x0600FB2A RID: 64298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB2A")]
		[Address(RVA = "0x729090", Offset = "0x727C90", VA = "0x180729090", Slot = "95")]
		public override void ResetMotionMode()
		{
		}

		// Token: 0x0600FB2B RID: 64299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FB2B")]
		[Address(RVA = "0x7236E0", Offset = "0x7222E0", VA = "0x1807236E0", Slot = "188")]
		public override string GetBakeMuzzleDataPath()
		{
			return null;
		}

		// Token: 0x0600FB2C RID: 64300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB2C")]
		[Address(RVA = "0x72F640", Offset = "0x72E240", VA = "0x18072F640")]
		public Enemy()
		{
		}

		// Token: 0x0600FB33 RID: 64307 RVA: 0x0005EBA8 File Offset: 0x0005CDA8
		[Token(Token = "0x600FB33")]
		[Address(RVA = "0x72B830", Offset = "0x72A430", VA = "0x18072B830")]
		private SourceApplyWay <>xLuaBaseProxy_get_allApplyWay()
		{
			return SourceApplyWay.NONE;
		}

		// Token: 0x0600FB34 RID: 64308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB34")]
		[Address(RVA = "0x6FE970", Offset = "0x6FD570", VA = "0x1806FE970")]
		private void <>xLuaBaseProxy_GatherHudPluginTypes(List<string> P0)
		{
		}

		// Token: 0x0600FB35 RID: 64309 RVA: 0x0005EBC0 File Offset: 0x0005CDC0
		[Token(Token = "0x600FB35")]
		[Address(RVA = "0x6FEC10", Offset = "0x6FD810", VA = "0x1806FEC10")]
		private HudPluginMask <>xLuaBaseProxy_get_hudPluginMask()
		{
			return HudPluginMask.NONE;
		}

		// Token: 0x0600FB36 RID: 64310 RVA: 0x0005EBD8 File Offset: 0x0005CDD8
		[Token(Token = "0x600FB36")]
		[Address(RVA = "0x72B850", Offset = "0x72A450", VA = "0x18072B850")]
		private FP <>xLuaBaseProxy_get_maxEp()
		{
			return default(FP);
		}

		// Token: 0x0600FB37 RID: 64311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FB37")]
		[Address(RVA = "0x6FEBB0", Offset = "0x6FD7B0", VA = "0x1806FEBB0")]
		private UnitMode <>xLuaBaseProxy_get_defaultMode()
		{
			return null;
		}

		// Token: 0x0600FB38 RID: 64312 RVA: 0x0005EBF0 File Offset: 0x0005CDF0
		[Token(Token = "0x600FB38")]
		[Address(RVA = "0x6FEC00", Offset = "0x6FD800", VA = "0x1806FEC00")]
		private bool <>xLuaBaseProxy_get_hasCombat()
		{
			return default(bool);
		}

		// Token: 0x0600FB39 RID: 64313 RVA: 0x0005EC08 File Offset: 0x0005CE08
		[Token(Token = "0x600FB39")]
		[Address(RVA = "0x72B840", Offset = "0x72A440", VA = "0x18072B840")]
		private bool <>xLuaBaseProxy_get_isMovingBySelf()
		{
			return default(bool);
		}

		// Token: 0x0600FB3A RID: 64314 RVA: 0x0005EC20 File Offset: 0x0005CE20
		[Token(Token = "0x600FB3A")]
		[Address(RVA = "0x72B860", Offset = "0x72A460", VA = "0x18072B860")]
		private bool <>xLuaBaseProxy_get_needUpdateRootHeight()
		{
			return default(bool);
		}

		// Token: 0x0600FB3B RID: 64315 RVA: 0x0005EC38 File Offset: 0x0005CE38
		[Token(Token = "0x600FB3B")]
		[Address(RVA = "0x6FEC20", Offset = "0x6FD820", VA = "0x1806FEC20")]
		private int <>xLuaBaseProxy_get_initState()
		{
			return 0;
		}

		// Token: 0x0600FB3C RID: 64316 RVA: 0x0005EC50 File Offset: 0x0005CE50
		[Token(Token = "0x600FB3C")]
		[Address(RVA = "0x6FEBD0", Offset = "0x6FD7D0", VA = "0x1806FEBD0")]
		private float <>xLuaBaseProxy_get_delayToRecycle()
		{
			return 0f;
		}

		// Token: 0x0600FB3D RID: 64317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB3D")]
		[Address(RVA = "0x6FE870", Offset = "0x6FD470", VA = "0x1806FE870")]
		private void <>xLuaBaseProxy_Born()
		{
		}

		// Token: 0x0600FB3E RID: 64318 RVA: 0x0005EC68 File Offset: 0x0005CE68
		[Token(Token = "0x600FB3E")]
		[Address(RVA = "0x72B790", Offset = "0x72A390", VA = "0x18072B790")]
		private float <>xLuaBaseProxy_GetModeRangeRadius(UnitMode P0)
		{
			return 0f;
		}

		// Token: 0x0600FB3F RID: 64319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FB3F")]
		[Address(RVA = "0x6FE990", Offset = "0x6FD590", VA = "0x1806FE990")]
		private AbstractBasicAttack <>xLuaBaseProxy_GetCurrentAttackOrCombatAbility()
		{
			return null;
		}

		// Token: 0x0600FB40 RID: 64320 RVA: 0x0005EC80 File Offset: 0x0005CE80
		[Token(Token = "0x600FB40")]
		[Address(RVA = "0x6FEAF0", Offset = "0x6FD6F0", VA = "0x1806FEAF0")]
		private bool <>xLuaBaseProxy_TryHookAudio(string P0, string P1, out string P2, out string P3)
		{
			return default(bool);
		}

		// Token: 0x0600FB41 RID: 64321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FB41")]
		[Address(RVA = "0x6FE940", Offset = "0x6FD540", VA = "0x1806FE940")]
		private Entity <>xLuaBaseProxy_FetchHost()
		{
			return null;
		}

		// Token: 0x0600FB42 RID: 64322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB42")]
		[Address(RVA = "0x72B7D0", Offset = "0x72A3D0", VA = "0x18072B7D0")]
		private void <>xLuaBaseProxy_OnMotionModeChanged(MotionMode P0, MotionMode P1)
		{
		}

		// Token: 0x0600FB43 RID: 64323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB43")]
		[Address(RVA = "0x6FEAC0", Offset = "0x6FD6C0", VA = "0x1806FEAC0")]
		private void <>xLuaBaseProxy_PopulateSnapshotToHashBuilder(HashCodeBuilder P0)
		{
		}

		// Token: 0x0600FB44 RID: 64324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB44")]
		[Address(RVA = "0x6FEAD0", Offset = "0x6FD6D0", VA = "0x1806FEAD0")]
		private void <>xLuaBaseProxy_PopulateSnapshotToStrBuilder(StringBuilder P0)
		{
		}

		// Token: 0x0600FB45 RID: 64325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB45")]
		[Address(RVA = "0x6FE960", Offset = "0x6FD560", VA = "0x1806FE960")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600FB46 RID: 64326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB46")]
		[Address(RVA = "0x72B770", Offset = "0x72A370", VA = "0x18072B770")]
		private void <>xLuaBaseProxy_ChangePathMotionMode(MotionMode P0)
		{
		}

		// Token: 0x0600FB47 RID: 64327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB47")]
		[Address(RVA = "0x6FEAA0", Offset = "0x6FD6A0", VA = "0x1806FEAA0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600FB48 RID: 64328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB48")]
		[Address(RVA = "0x6FE9E0", Offset = "0x6FD5E0", VA = "0x1806FE9E0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FB49 RID: 64329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB49")]
		[Address(RVA = "0x6FEA40", Offset = "0x6FD640", VA = "0x1806FEA40")]
		private void <>xLuaBaseProxy_OnReborn(Unit.RebornData P0)
		{
		}

		// Token: 0x0600FB4A RID: 64330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB4A")]
		[Address(RVA = "0x72B800", Offset = "0x72A400", VA = "0x18072B800")]
		private void <>xLuaBaseProxy_SetBodyAndFaceDirection(Vector2 P0, bool P1)
		{
		}

		// Token: 0x0600FB4B RID: 64331 RVA: 0x0005EC98 File Offset: 0x0005CE98
		[Token(Token = "0x600FB4B")]
		[Address(RVA = "0x72B820", Offset = "0x72A420", VA = "0x18072B820")]
		private bool <>xLuaBaseProxy_TryIgnoreEffect(string P0)
		{
			return default(bool);
		}

		// Token: 0x0600FB4C RID: 64332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB4C")]
		[Address(RVA = "0x72B7B0", Offset = "0x72A3B0", VA = "0x18072B7B0")]
		private void <>xLuaBaseProxy_OnFaceChanged(Vector2 P0, Vector2 P1, bool P2, bool P3)
		{
		}

		// Token: 0x0600FB4D RID: 64333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB4D")]
		[Address(RVA = "0x6FE9F0", Offset = "0x6FD5F0", VA = "0x1806FE9F0")]
		private void <>xLuaBaseProxy_OnDisappearChanged(bool P0)
		{
		}

		// Token: 0x0600FB4E RID: 64334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB4E")]
		[Address(RVA = "0x72B7E0", Offset = "0x72A3E0", VA = "0x18072B7E0")]
		private void <>xLuaBaseProxy_OnSwitchMode(UnitMode P0, UnitMode P1, bool P2)
		{
		}

		// Token: 0x0600FB4F RID: 64335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB4F")]
		[Address(RVA = "0x6FEA10", Offset = "0x6FD610", VA = "0x1806FEA10")]
		private void <>xLuaBaseProxy_OnHpZero(bool P0, bool P1)
		{
		}

		// Token: 0x0600FB50 RID: 64336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB50")]
		[Address(RVA = "0x6FE9C0", Offset = "0x6FD5C0", VA = "0x1806FE9C0")]
		private void <>xLuaBaseProxy_OnAttributeDirty(AttributeType P0, FP P1)
		{
		}

		// Token: 0x0600FB51 RID: 64337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB51")]
		[Address(RVA = "0x6FE950", Offset = "0x6FD550", VA = "0x1806FE950")]
		private void <>xLuaBaseProxy_FinishMe(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600FB52 RID: 64338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB52")]
		[Address(RVA = "0x6FE8A0", Offset = "0x6FD4A0", VA = "0x1806FE8A0")]
		private void <>xLuaBaseProxy_DoFakeDeath(Unit.RebornData P0)
		{
		}

		// Token: 0x0600FB53 RID: 64339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB53")]
		[Address(RVA = "0x6FE8F0", Offset = "0x6FD4F0", VA = "0x1806FE8F0")]
		private void <>xLuaBaseProxy_DoReborn(Unit.RebornData P0)
		{
		}

		// Token: 0x0600FB54 RID: 64340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB54")]
		[Address(RVA = "0x72B810", Offset = "0x72A410", VA = "0x18072B810")]
		private void <>xLuaBaseProxy_SetHeight(float P0, bool P1)
		{
		}

		// Token: 0x0600FB55 RID: 64341 RVA: 0x0005ECB0 File Offset: 0x0005CEB0
		[Token(Token = "0x600FB55")]
		[Address(RVA = "0x72B7A0", Offset = "0x72A3A0", VA = "0x18072B7A0")]
		private bool <>xLuaBaseProxy_IsStayStill()
		{
			return default(bool);
		}

		// Token: 0x0600FB56 RID: 64342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB56")]
		[Address(RVA = "0x72B780", Offset = "0x72A380", VA = "0x18072B780")]
		private void <>xLuaBaseProxy_FinishWithReachExit(bool P0)
		{
		}

		// Token: 0x0600FB57 RID: 64343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FB57")]
		[Address(RVA = "0x6FE980", Offset = "0x6FD580", VA = "0x1806FE980")]
		private Blackboard <>xLuaBaseProxy_GetAttackBlackboard(UnitMode P0)
		{
			return null;
		}

		// Token: 0x0600FB58 RID: 64344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB58")]
		[Address(RVA = "0x6FE9D0", Offset = "0x6FD5D0", VA = "0x1806FE9D0")]
		private void <>xLuaBaseProxy_OnAwake()
		{
		}

		// Token: 0x0600FB59 RID: 64345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB59")]
		[Address(RVA = "0x6FEA20", Offset = "0x6FD620", VA = "0x1806FEA20")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600FB5A RID: 64346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB5A")]
		[Address(RVA = "0x6FEA00", Offset = "0x6FD600", VA = "0x1806FEA00")]
		private void <>xLuaBaseProxy_OnFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600FB5B RID: 64347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB5B")]
		[Address(RVA = "0x6FEA90", Offset = "0x6FD690", VA = "0x1806FEA90")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0600FB5C RID: 64348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB5C")]
		[Address(RVA = "0x6FEAB0", Offset = "0x6FD6B0", VA = "0x1806FEAB0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600FB5D RID: 64349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB5D")]
		[Address(RVA = "0x72B7F0", Offset = "0x72A3F0", VA = "0x18072B7F0")]
		private void <>xLuaBaseProxy_OnTriggerPalsy()
		{
		}

		// Token: 0x0600FB5E RID: 64350 RVA: 0x0005ECC8 File Offset: 0x0005CEC8
		[Token(Token = "0x600FB5E")]
		[Address(RVA = "0x72B760", Offset = "0x72A360", VA = "0x18072B760")]
		private bool <>xLuaBaseProxy_CanDoAbilitySpellOn(Ability P0, out Ability.FinishReason P1)
		{
			return default(bool);
		}

		// Token: 0x0600FB5F RID: 64351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB5F")]
		[Address(RVA = "0x6FE880", Offset = "0x6FD480", VA = "0x1806FE880")]
		private void <>xLuaBaseProxy_ChangeMotionMode(MotionMode P0)
		{
		}

		// Token: 0x0600FB60 RID: 64352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FB60")]
		[Address(RVA = "0x6FEAE0", Offset = "0x6FD6E0", VA = "0x1806FEAE0")]
		private void <>xLuaBaseProxy_ResetMotionMode()
		{
		}

		// Token: 0x040115FB RID: 71163
		[Token(Token = "0x40115FB")]
		private const int UPDATE_POS_TICK = 5;

		// Token: 0x040115FC RID: 71164
		[Token(Token = "0x40115FC")]
		private const float BLOCKING_TWEEN_DURATION = 0.2f;

		// Token: 0x040115FD RID: 71165
		[Token(Token = "0x40115FD")]
		protected const float HATRED_VALUE_GAP = 1000f;

		// Token: 0x040115FE RID: 71166
		[Token(Token = "0x40115FE")]
		private const float MIN_BLINK_DISTANCE = 0.01f;

		// Token: 0x040115FF RID: 71167
		[Token(Token = "0x40115FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		protected Vector2 m_lastMoveDirVec;

		// Token: 0x04011600 RID: 71168
		[Token(Token = "0x4011600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<EnemySkill> s_sharedList;

		// Token: 0x04011601 RID: 71169
		[Token(Token = "0x4011601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		[SerializeField]
		private SideTypeIndex _sideTypeIndex;

		// Token: 0x04011602 RID: 71170
		[Token(Token = "0x4011602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		protected Range _locateRange;

		// Token: 0x04011603 RID: 71171
		[Token(Token = "0x4011603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		[SerializeField]
		protected bool _disableRenderLocateRange;

		// Token: 0x04011604 RID: 71172
		[Token(Token = "0x4011604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
		[SerializeField]
		private bool _isFixedRotation;

		// Token: 0x04011605 RID: 71173
		[Token(Token = "0x4011605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		[SerializeField]
		private Enemy.BodyDirectionPolicy _bodyDirectionPolicy;

		// Token: 0x04011606 RID: 71174
		[Token(Token = "0x4011606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		[SerializeField]
		private bool _scaleMoveBySpeed;

		// Token: 0x04011607 RID: 71175
		[Token(Token = "0x4011607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		[SerializeField]
		private Vector2 _scaleMoveAnimationRange;

		// Token: 0x04011608 RID: 71176
		[Token(Token = "0x4011608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		[SerializeField]
		private bool _showSpAsBulletMode;

		// Token: 0x04011609 RID: 71177
		[Token(Token = "0x4011609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		private List<int> _hideBulletSpModes;

		// Token: 0x0401160A RID: 71178
		[Token(Token = "0x401160A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		[SerializeField]
		private bool _alwaysShowHp;

		// Token: 0x0401160B RID: 71179
		[Token(Token = "0x401160B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C9")]
		[SerializeField]
		private bool _alwaysHideHp;

		// Token: 0x0401160C RID: 71180
		[Token(Token = "0x401160C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CA")]
		[SerializeField]
		private bool _keepMoveAnimScale;

		// Token: 0x0401160D RID: 71181
		[Token(Token = "0x401160D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CB")]
		[SerializeField]
		private bool _useSpecificDeadAnim;

		// Token: 0x0401160E RID: 71182
		[Token(Token = "0x401160E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		[SerializeField]
		private bool _useSpecificReachExitAnim;

		// Token: 0x0401160F RID: 71183
		[Token(Token = "0x401160F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CD")]
		[SerializeField]
		private bool _disableBornTweenColor;

		// Token: 0x04011610 RID: 71184
		[Token(Token = "0x4011610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		[SerializeField]
		private float _height;

		// Token: 0x04011611 RID: 71185
		[Token(Token = "0x4011611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		[SerializeField]
		private bool _useSpineLikeHeightUpdate;

		// Token: 0x04011612 RID: 71186
		[Token(Token = "0x4011612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		private float _spineLikeHeightUpdateRatio;

		// Token: 0x04011613 RID: 71187
		[Token(Token = "0x4011613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		[SerializeField]
		private float _delayToBorn;

		// Token: 0x04011614 RID: 71188
		[Token(Token = "0x4011614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		[SerializeField]
		private bool _onlyDelayToBornOnTileStart;

		// Token: 0x04011615 RID: 71189
		[Token(Token = "0x4011615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		[SerializeField]
		private string _startEffect;

		// Token: 0x04011616 RID: 71190
		[Token(Token = "0x4011616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		[SerializeField]
		private string _deadEffect;

		// Token: 0x04011617 RID: 71191
		[Token(Token = "0x4011617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		[SerializeField]
		private int _blockVolume;

		// Token: 0x04011618 RID: 71192
		[Token(Token = "0x4011618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		[SerializeField]
		private Enemy.SpecialBlockCondition _specialBlockCondition;

		// Token: 0x04011619 RID: 71193
		[Token(Token = "0x4011619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		[SerializeField]
		private bool _dontSetEnemyFaceByCursorWhenBorn;

		// Token: 0x0401161A RID: 71194
		[Token(Token = "0x401161A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x309")]
		[SerializeField]
		private bool _idleWhenBorn;

		// Token: 0x0401161B RID: 71195
		[Token(Token = "0x401161B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30A")]
		[SerializeField]
		private bool _canNotExit;

		// Token: 0x0401161C RID: 71196
		[Token(Token = "0x401161C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30B")]
		[SerializeField]
		private bool _hideShadowOnReset;

		// Token: 0x0401161D RID: 71197
		[Token(Token = "0x401161D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		[SerializeField]
		private bool _allowFalldownWhenReborn;

		// Token: 0x0401161E RID: 71198
		[Token(Token = "0x401161E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30D")]
		[SerializeField]
		private bool _alwaysCheckCurrentPoint;

		// Token: 0x0401161F RID: 71199
		[Token(Token = "0x401161F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private int m_defaultModeIndex;

		// Token: 0x04011620 RID: 71200
		[Token(Token = "0x4011620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		private float m_totalMoveDist;

		// Token: 0x04011621 RID: 71201
		[Token(Token = "0x4011621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		protected bool m_blinkHideUIFlag;

		// Token: 0x04011622 RID: 71202
		[Token(Token = "0x4011622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x319")]
		protected bool m_fogHideUIFlag;

		// Token: 0x04011623 RID: 71203
		[Token(Token = "0x4011623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31A")]
		protected bool m_showSpUIFlag;

		// Token: 0x04011624 RID: 71204
		[Token(Token = "0x4011624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31B")]
		protected bool m_alwaysShowHpFlag;

		// Token: 0x04011625 RID: 71205
		[Token(Token = "0x4011625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		protected Tile m_currentTile;

		// Token: 0x04011626 RID: 71206
		[Token(Token = "0x4011626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		protected Tile m_oldTile;

		// Token: 0x04011627 RID: 71207
		[Token(Token = "0x4011627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private DirectionCursor m_cursor;

		// Token: 0x04011628 RID: 71208
		[Token(Token = "0x4011628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private Route m_cachedRoute;

		// Token: 0x04011629 RID: 71209
		[Token(Token = "0x4011629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private int m_cachedCursorIndex;

		// Token: 0x0401162A RID: 71210
		[Token(Token = "0x401162A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private BaseTraceTargetAbility m_traceTargetAbility;

		// Token: 0x0401162B RID: 71211
		[Token(Token = "0x401162B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private TracePositionCursor m_traceTargetCursor;

		// Token: 0x0401162C RID: 71212
		[Token(Token = "0x401162C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		protected MoveController m_moveController;

		// Token: 0x0401162D RID: 71213
		[Token(Token = "0x401162D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private ObjectPtr<Character> m_blocker;

		// Token: 0x0401162E RID: 71214
		[Token(Token = "0x401162E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private PeriodicTicker m_updatePosTicker;

		// Token: 0x0401162F RID: 71215
		[Token(Token = "0x401162F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private Enemy.HeightController m_heightCtrl;

		// Token: 0x04011630 RID: 71216
		[Token(Token = "0x4011630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private SpineAnimator m_spineAnimator;

		// Token: 0x04011631 RID: 71217
		[Token(Token = "0x4011631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private Enemy.SpecialBlockCondition m_changealeSpecialBlockCondition;

		// Token: 0x04011632 RID: 71218
		[Token(Token = "0x4011632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private bool m_disableAppearTweenColor;

		// Token: 0x04011633 RID: 71219
		[Token(Token = "0x4011633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private Transform m_heightSpineLikeControlTransform;

		// Token: 0x04011634 RID: 71220
		[Token(Token = "0x4011634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private Enemy.FearController m_fearController;

		// Token: 0x04011635 RID: 71221
		[Token(Token = "0x4011635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private Enemy.AttractController m_attractController;

		// Token: 0x04011636 RID: 71222
		[Token(Token = "0x4011636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private ITweenHandler m_blockTween;

		// Token: 0x04011637 RID: 71223
		[Token(Token = "0x4011637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private Tween m_tweenToRecycle;

		// Token: 0x04011638 RID: 71224
		[Token(Token = "0x4011638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private Vector2 m_blockPosition;

		// Token: 0x04011639 RID: 71225
		[Token(Token = "0x4011639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private Vector2 m_contDirAfterEnd;

		// Token: 0x0401163A RID: 71226
		[Token(Token = "0x401163A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private Vector2 m_posInLastFrame;

		// Token: 0x0401163B RID: 71227
		[Token(Token = "0x401163B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private bool m_canNotExit;

		// Token: 0x0401163C RID: 71228
		[Token(Token = "0x401163C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private Collider2D m_nonTriggerCollider;

		// Token: 0x0401163D RID: 71229
		[Token(Token = "0x401163D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private Collider2D m_mainTriggerCollider;

		// Token: 0x0401163E RID: 71230
		[Token(Token = "0x401163E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private FP m_mainTriggerColliderRadius;

		// Token: 0x0401163F RID: 71231
		[Token(Token = "0x401163F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private ListSet<ObjectPtr<BObject>> m_pullSources;

		// Token: 0x04011640 RID: 71232
		[Token(Token = "0x4011640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private ListSet<ObjectPtr<BObject>> m_disabledPullSources;

		// Token: 0x04011641 RID: 71233
		[Token(Token = "0x4011641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private List<ObjectPtr<Projectile>> m_managedProjectiles;

		// Token: 0x04011642 RID: 71234
		[Token(Token = "0x4011642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private EnemySkill[] m_allSkills;

		// Token: 0x04011643 RID: 71235
		[Token(Token = "0x4011643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private Unit.RebornData m_rebornData;

		// Token: 0x04011644 RID: 71236
		[Token(Token = "0x4011644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private bool m_isInvalidKilled;

		// Token: 0x04011645 RID: 71237
		[Token(Token = "0x4011645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x461")]
		private bool m_isOverrideKillCnt;

		// Token: 0x04011646 RID: 71238
		[Token(Token = "0x4011646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x464")]
		private int m_overrideKillCnt;

		// Token: 0x04011647 RID: 71239
		[Token(Token = "0x4011647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private int m_blockVolumeAddition;

		// Token: 0x04011648 RID: 71240
		[Token(Token = "0x4011648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46C")]
		protected bool m_disableSwitchFaceByMove;

		// Token: 0x04011649 RID: 71241
		[Token(Token = "0x4011649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private FP m_createdTime;

		// Token: 0x0401164A RID: 71242
		[Token(Token = "0x401164A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private GridPosition m_routeSpawnPosition;

		// Token: 0x0401164B RID: 71243
		[Token(Token = "0x401164B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private float m_delayToRecycle;

		// Token: 0x0401164C RID: 71244
		[Token(Token = "0x401164C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		protected List<int> m_ExtraLogIds;

		// Token: 0x0401164D RID: 71245
		[Token(Token = "0x401164D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private uint m_hostUid;

		// Token: 0x0401164E RID: 71246
		[Token(Token = "0x401164E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private List<EnemySkill> m_skills;

		// Token: 0x0401164F RID: 71247
		[Token(Token = "0x401164F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private List<Tile> m_currentSubTiles;

		// Token: 0x04011650 RID: 71248
		[Token(Token = "0x4011650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private Ability m_attackAbilityCasted;

		// Token: 0x04011651 RID: 71249
		[Token(Token = "0x4011651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private Ability m_combatAbilityCasted;

		// Token: 0x04011652 RID: 71250
		[Token(Token = "0x4011652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private FP m_combatNextEscapeTime;

		// Token: 0x0401165B RID: 71259
		[Token(Token = "0x401165B")]
		private const float DEFAULT_FRICTION_FACTOR = 1f;

		// Token: 0x0401165C RID: 71260
		[Token(Token = "0x401165C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private float m_frictionFactor;

		// Token: 0x0401165D RID: 71261
		[Token(Token = "0x401165D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x524")]
		private float m_frictionFactorAdditional;

		// Token: 0x0401165E RID: 71262
		[Token(Token = "0x401165E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lastMoveDirection;

		// Token: 0x0401165F RID: 71263
		[Token(Token = "0x401165F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lastMoveDirVec;

		// Token: 0x04011660 RID: 71264
		[Token(Token = "0x4011660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_lastMoveDirVec;

		// Token: 0x04011661 RID: 71265
		[Token(Token = "0x4011661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_specialBlockCondition;

		// Token: 0x04011662 RID: 71266
		[Token(Token = "0x4011662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_extraSpineControl;

		// Token: 0x04011663 RID: 71267
		[Token(Token = "0x4011663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_disableAppearTweenColor;

		// Token: 0x04011664 RID: 71268
		[Token(Token = "0x4011664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_disableAppearTweenColor;

		// Token: 0x04011665 RID: 71269
		[Token(Token = "0x4011665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_allApplyWay;

		// Token: 0x04011666 RID: 71270
		[Token(Token = "0x4011666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_fearController;

		// Token: 0x04011667 RID: 71271
		[Token(Token = "0x4011667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_attractController;

		// Token: 0x04011668 RID: 71272
		[Token(Token = "0x4011668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetSpecialBlockCondition;

		// Token: 0x04011669 RID: 71273
		[Token(Token = "0x4011669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetEnemyCombatWrapperInterrupted;

		// Token: 0x0401166A RID: 71274
		[Token(Token = "0x401166A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_ColliderRadius;

		// Token: 0x0401166B RID: 71275
		[Token(Token = "0x401166B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_onlyCollideWhenUnbalance;

		// Token: 0x0401166C RID: 71276
		[Token(Token = "0x401166C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_bodyDirectionPolicy;

		// Token: 0x0401166D RID: 71277
		[Token(Token = "0x401166D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_attackAbilityCasted;

		// Token: 0x0401166E RID: 71278
		[Token(Token = "0x401166E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_combatAbilityCasted;

		// Token: 0x0401166F RID: 71279
		[Token(Token = "0x401166F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_combatAbilityCasted;

		// Token: 0x04011670 RID: 71280
		[Token(Token = "0x4011670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_hostUid;

		// Token: 0x04011671 RID: 71281
		[Token(Token = "0x4011671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_hostUid;

		// Token: 0x04011672 RID: 71282
		[Token(Token = "0x4011672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_nonTriggerCollider;

		// Token: 0x04011673 RID: 71283
		[Token(Token = "0x4011673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_moveController;

		// Token: 0x04011674 RID: 71284
		[Token(Token = "0x4011674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_distToExit;

		// Token: 0x04011675 RID: 71285
		[Token(Token = "0x4011675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_distToExitPrecise;

		// Token: 0x04011676 RID: 71286
		[Token(Token = "0x4011676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_uiHideFlag;

		// Token: 0x04011677 RID: 71287
		[Token(Token = "0x4011677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_hideHp;

		// Token: 0x04011678 RID: 71288
		[Token(Token = "0x4011678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_showSpUIFlag;

		// Token: 0x04011679 RID: 71289
		[Token(Token = "0x4011679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_alwaysShowHpFlag;

		// Token: 0x0401167A RID: 71290
		[Token(Token = "0x401167A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_alwaysShowHpFlag;

		// Token: 0x0401167B RID: 71291
		[Token(Token = "0x401167B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_fogHideUIFlag;

		// Token: 0x0401167C RID: 71292
		[Token(Token = "0x401167C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_fogHideUIFlag;

		// Token: 0x0401167D RID: 71293
		[Token(Token = "0x401167D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_spineHeight;

		// Token: 0x0401167E RID: 71294
		[Token(Token = "0x401167E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_originHeight;

		// Token: 0x0401167F RID: 71295
		[Token(Token = "0x401167F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_disableUIHud;

		// Token: 0x04011680 RID: 71296
		[Token(Token = "0x4011680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_disableUIHud;

		// Token: 0x04011681 RID: 71297
		[Token(Token = "0x4011681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_disableUIUnitHud;

		// Token: 0x04011682 RID: 71298
		[Token(Token = "0x4011682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GatherHudPluginTypes;

		// Token: 0x04011683 RID: 71299
		[Token(Token = "0x4011683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_hudPluginMask;

		// Token: 0x04011684 RID: 71300
		[Token(Token = "0x4011684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_hatred;

		// Token: 0x04011685 RID: 71301
		[Token(Token = "0x4011685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_totalMoveDist;

		// Token: 0x04011686 RID: 71302
		[Token(Token = "0x4011686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_blocker;

		// Token: 0x04011687 RID: 71303
		[Token(Token = "0x4011687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_managedProjectiles;

		// Token: 0x04011688 RID: 71304
		[Token(Token = "0x4011688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_rootTile;

		// Token: 0x04011689 RID: 71305
		[Token(Token = "0x4011689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_oldTile;

		// Token: 0x0401168A RID: 71306
		[Token(Token = "0x401168A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_routeSpawnPosition;

		// Token: 0x0401168B RID: 71307
		[Token(Token = "0x401168B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_rootSubTiles;

		// Token: 0x0401168C RID: 71308
		[Token(Token = "0x401168C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_lifePointReduce;

		// Token: 0x0401168D RID: 71309
		[Token(Token = "0x401168D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_set_lifePointReduce;

		// Token: 0x0401168E RID: 71310
		[Token(Token = "0x401168E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_defaultRangeRadius;

		// Token: 0x0401168F RID: 71311
		[Token(Token = "0x401168F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_set_defaultRangeRadius;

		// Token: 0x04011690 RID: 71312
		[Token(Token = "0x4011690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_massLevel;

		// Token: 0x04011691 RID: 71313
		[Token(Token = "0x4011691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_maxEp;

		// Token: 0x04011692 RID: 71314
		[Token(Token = "0x4011692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_essentialMotionMode;

		// Token: 0x04011693 RID: 71315
		[Token(Token = "0x4011693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_enemyTags;

		// Token: 0x04011694 RID: 71316
		[Token(Token = "0x4011694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x04011695 RID: 71317
		[Token(Token = "0x4011695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x04011696 RID: 71318
		[Token(Token = "0x4011696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_get_isUnbalanced;

		// Token: 0x04011697 RID: 71319
		[Token(Token = "0x4011697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_isInAttackState;

		// Token: 0x04011698 RID: 71320
		[Token(Token = "0x4011698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_get_isInCombatState;

		// Token: 0x04011699 RID: 71321
		[Token(Token = "0x4011699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_get_isInRebornState;

		// Token: 0x0401169A RID: 71322
		[Token(Token = "0x401169A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_get_isInMoveState;

		// Token: 0x0401169B RID: 71323
		[Token(Token = "0x401169B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_isInBlinkState;

		// Token: 0x0401169C RID: 71324
		[Token(Token = "0x401169C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_get_isInBornState;

		// Token: 0x0401169D RID: 71325
		[Token(Token = "0x401169D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_get_isInDyingState;

		// Token: 0x0401169E RID: 71326
		[Token(Token = "0x401169E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_get_isBoss;

		// Token: 0x0401169F RID: 71327
		[Token(Token = "0x401169F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_isGiantBoss;

		// Token: 0x040116A0 RID: 71328
		[Token(Token = "0x40116A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_get_isEnemyLikeNeutral;

		// Token: 0x040116A1 RID: 71329
		[Token(Token = "0x40116A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_get_locateRange;

		// Token: 0x040116A2 RID: 71330
		[Token(Token = "0x40116A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_get_disableRenderLocateRange;

		// Token: 0x040116A3 RID: 71331
		[Token(Token = "0x40116A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_get_blockVolume;

		// Token: 0x040116A4 RID: 71332
		[Token(Token = "0x40116A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_get_blockVolumeAddition;

		// Token: 0x040116A5 RID: 71333
		[Token(Token = "0x40116A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_set_blockVolumeAddition;

		// Token: 0x040116A6 RID: 71334
		[Token(Token = "0x40116A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_get_showSpAsBulletMode;

		// Token: 0x040116A7 RID: 71335
		[Token(Token = "0x40116A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_get_disableBulletSp;

		// Token: 0x040116A8 RID: 71336
		[Token(Token = "0x40116A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_get_defaultMode;

		// Token: 0x040116A9 RID: 71337
		[Token(Token = "0x40116A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_get_hasCombat;

		// Token: 0x040116AA RID: 71338
		[Token(Token = "0x40116AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_get_combatable;

		// Token: 0x040116AB RID: 71339
		[Token(Token = "0x40116AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_get_isInCombat;

		// Token: 0x040116AC RID: 71340
		[Token(Token = "0x40116AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_get_isMovingBySelf;

		// Token: 0x040116AD RID: 71341
		[Token(Token = "0x40116AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_get_needUpdateRootHeight;

		// Token: 0x040116AE RID: 71342
		[Token(Token = "0x40116AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_get_footMapPosition;

		// Token: 0x040116AF RID: 71343
		[Token(Token = "0x40116AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_get_offsetMapPosition;

		// Token: 0x040116B0 RID: 71344
		[Token(Token = "0x40116B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_get_stableBlockPosition;

		// Token: 0x040116B1 RID: 71345
		[Token(Token = "0x40116B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x040116B2 RID: 71346
		[Token(Token = "0x40116B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_set_options;

		// Token: 0x040116B3 RID: 71347
		[Token(Token = "0x40116B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_DontCountAsFinished;

		// Token: 0x040116B4 RID: 71348
		[Token(Token = "0x40116B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_MarkUnharmful;

		// Token: 0x040116B5 RID: 71349
		[Token(Token = "0x40116B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_DontLogInEnemyStatsWhenFinished;

		// Token: 0x040116B6 RID: 71350
		[Token(Token = "0x40116B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_SetExtraMeta;

		// Token: 0x040116B7 RID: 71351
		[Token(Token = "0x40116B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_get_isInvalidKilled;

		// Token: 0x040116B8 RID: 71352
		[Token(Token = "0x40116B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_get_isOverrideKillCnt;

		// Token: 0x040116B9 RID: 71353
		[Token(Token = "0x40116B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_get_overrideKillCnt;

		// Token: 0x040116BA RID: 71354
		[Token(Token = "0x40116BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_get_stateMachine;

		// Token: 0x040116BB RID: 71355
		[Token(Token = "0x40116BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_get_isFixedRotation;

		// Token: 0x040116BC RID: 71356
		[Token(Token = "0x40116BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_get_initState;

		// Token: 0x040116BD RID: 71357
		[Token(Token = "0x40116BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x040116BE RID: 71358
		[Token(Token = "0x40116BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_get_sideTypeIndex;

		// Token: 0x040116BF RID: 71359
		[Token(Token = "0x40116BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_get_delayToBorn;

		// Token: 0x040116C0 RID: 71360
		[Token(Token = "0x40116C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_get_createdTime;

		// Token: 0x040116C1 RID: 71361
		[Token(Token = "0x40116C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_get_isInEnemySide;

		// Token: 0x040116C2 RID: 71362
		[Token(Token = "0x40116C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_get_mass;

		// Token: 0x040116C3 RID: 71363
		[Token(Token = "0x40116C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_get_velocity;

		// Token: 0x040116C4 RID: 71364
		[Token(Token = "0x40116C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_set_velocity;

		// Token: 0x040116C5 RID: 71365
		[Token(Token = "0x40116C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_get_rigidbody2D;

		// Token: 0x040116C6 RID: 71366
		[Token(Token = "0x40116C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_set_rigidbody2D;

		// Token: 0x040116C7 RID: 71367
		[Token(Token = "0x40116C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_get_attackWrapper;

		// Token: 0x040116C8 RID: 71368
		[Token(Token = "0x40116C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_set_attackWrapper;

		// Token: 0x040116C9 RID: 71369
		[Token(Token = "0x40116C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_get_combatWrapper;

		// Token: 0x040116CA RID: 71370
		[Token(Token = "0x40116CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_set_combatWrapper;

		// Token: 0x040116CB RID: 71371
		[Token(Token = "0x40116CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_get_lastAttackOrCombatAbility;

		// Token: 0x040116CC RID: 71372
		[Token(Token = "0x40116CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_get_mainCombatAbility;

		// Token: 0x040116CD RID: 71373
		[Token(Token = "0x40116CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_get_lastSkill;

		// Token: 0x040116CE RID: 71374
		[Token(Token = "0x40116CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_get_deadEffect;

		// Token: 0x040116CF RID: 71375
		[Token(Token = "0x40116CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_get_startEffect;

		// Token: 0x040116D0 RID: 71376
		[Token(Token = "0x40116D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_get_moveSpdTotalScale;

		// Token: 0x040116D1 RID: 71377
		[Token(Token = "0x40116D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_get_traceTargetCursor;

		// Token: 0x040116D2 RID: 71378
		[Token(Token = "0x40116D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_get_cursor;

		// Token: 0x040116D3 RID: 71379
		[Token(Token = "0x40116D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_get_moveCursor;

		// Token: 0x040116D4 RID: 71380
		[Token(Token = "0x40116D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_get_traceTargetAbility;

		// Token: 0x040116D5 RID: 71381
		[Token(Token = "0x40116D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_set_traceTargetAbility;

		// Token: 0x040116D6 RID: 71382
		[Token(Token = "0x40116D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_get_usingTraceCursor;

		// Token: 0x040116D7 RID: 71383
		[Token(Token = "0x40116D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_get_traceTarget;

		// Token: 0x040116D8 RID: 71384
		[Token(Token = "0x40116D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_get_frictionFactor;

		// Token: 0x040116D9 RID: 71385
		[Token(Token = "0x40116D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_get_preloadCnt;

		// Token: 0x040116DA RID: 71386
		[Token(Token = "0x40116DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_get_disableSwitchFaceByMove;

		// Token: 0x040116DB RID: 71387
		[Token(Token = "0x40116DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_set_disableSwitchFaceByMove;

		// Token: 0x040116DC RID: 71388
		[Token(Token = "0x40116DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_get_scaleMoveBySpeed;

		// Token: 0x040116DD RID: 71389
		[Token(Token = "0x40116DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_get_updateHpColor;

		// Token: 0x040116DE RID: 71390
		[Token(Token = "0x40116DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_get_hpColor;

		// Token: 0x040116DF RID: 71391
		[Token(Token = "0x40116DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_UpdateFrictionFactor;

		// Token: 0x040116E0 RID: 71392
		[Token(Token = "0x40116E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_RestoreFrictionFactor;

		// Token: 0x040116E1 RID: 71393
		[Token(Token = "0x40116E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0__UpdateFrictionFactorAdditional;

		// Token: 0x040116E2 RID: 71394
		[Token(Token = "0x40116E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_RestoreCachedRoute;

		// Token: 0x040116E3 RID: 71395
		[Token(Token = "0x40116E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_TryReassignRouteAndCacheOrigin;

		// Token: 0x040116E4 RID: 71396
		[Token(Token = "0x40116E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_get_originRoute;

		// Token: 0x040116E5 RID: 71397
		[Token(Token = "0x40116E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_get_originCursorIndex;

		// Token: 0x040116E6 RID: 71398
		[Token(Token = "0x40116E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_InterruptLastAbilityIfNot;

		// Token: 0x040116E7 RID: 71399
		[Token(Token = "0x40116E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_Spawn;

		// Token: 0x040116E8 RID: 71400
		[Token(Token = "0x40116E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_Born;

		// Token: 0x040116E9 RID: 71401
		[Token(Token = "0x40116E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_GetModeRangeRadius;

		// Token: 0x040116EA RID: 71402
		[Token(Token = "0x40116EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_GetCurrentAttackOrCombatAbility;

		// Token: 0x040116EB RID: 71403
		[Token(Token = "0x40116EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_PlayAudioSignal;

		// Token: 0x040116EC RID: 71404
		[Token(Token = "0x40116EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_TryHookAudio;

		// Token: 0x040116ED RID: 71405
		[Token(Token = "0x40116ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_CheckHasFilterTag;

		// Token: 0x040116EE RID: 71406
		[Token(Token = "0x40116EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_TriggerEnemySkill;

		// Token: 0x040116EF RID: 71407
		[Token(Token = "0x40116EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_CheckEnemySkillAffecting;

		// Token: 0x040116F0 RID: 71408
		[Token(Token = "0x40116F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_FetchHost;

		// Token: 0x040116F1 RID: 71409
		[Token(Token = "0x40116F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_CheckBlockable;

		// Token: 0x040116F2 RID: 71410
		[Token(Token = "0x40116F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_CheckBlockableWithoutCheckRange;

		// Token: 0x040116F3 RID: 71411
		[Token(Token = "0x40116F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix0__CheckMotionModeBlockable;

		// Token: 0x040116F4 RID: 71412
		[Token(Token = "0x40116F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0__CheckSpecialBlockCondition;

		// Token: 0x040116F5 RID: 71413
		[Token(Token = "0x40116F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix0_RegisterBlocker;

		// Token: 0x040116F6 RID: 71414
		[Token(Token = "0x40116F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge __Hotfix0_UnregisterBlocker;

		// Token: 0x040116F7 RID: 71415
		[Token(Token = "0x40116F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0_OnBlockVolumeChanged;

		// Token: 0x040116F8 RID: 71416
		[Token(Token = "0x40116F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0_KnockBack;

		// Token: 0x040116F9 RID: 71417
		[Token(Token = "0x40116F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0_DisableCurrentStillPull;

		// Token: 0x040116FA RID: 71418
		[Token(Token = "0x40116FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge __Hotfix0_BeginPull;

		// Token: 0x040116FB RID: 71419
		[Token(Token = "0x40116FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		private static DelegateBridge __Hotfix0_StillPull;

		// Token: 0x040116FC RID: 71420
		[Token(Token = "0x40116FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		private static DelegateBridge __Hotfix0_TryEarlyStopPull;

		// Token: 0x040116FD RID: 71421
		[Token(Token = "0x40116FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private static DelegateBridge __Hotfix0_EndPull;

		// Token: 0x040116FE RID: 71422
		[Token(Token = "0x40116FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		private static DelegateBridge __Hotfix0_FallDown;

		// Token: 0x040116FF RID: 71423
		[Token(Token = "0x40116FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private static DelegateBridge __Hotfix0_OnMotionModeChanged;

		// Token: 0x04011700 RID: 71424
		[Token(Token = "0x4011700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private static DelegateBridge __Hotfix0_CheckReadyToFallDown;

		// Token: 0x04011701 RID: 71425
		[Token(Token = "0x4011701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private static DelegateBridge __Hotfix0_PlayMoveAnim;

		// Token: 0x04011702 RID: 71426
		[Token(Token = "0x4011702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		private static DelegateBridge __Hotfix0__RemoveInvalidPullSources;

		// Token: 0x04011703 RID: 71427
		[Token(Token = "0x4011703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		private static DelegateBridge __Hotfix0_SetStruggling;

		// Token: 0x04011704 RID: 71428
		[Token(Token = "0x4011704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		private static DelegateBridge __Hotfix0_SetCanNotExit;

		// Token: 0x04011705 RID: 71429
		[Token(Token = "0x4011705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		private static DelegateBridge __Hotfix0_Blink;

		// Token: 0x04011706 RID: 71430
		[Token(Token = "0x4011706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		private static DelegateBridge __Hotfix1_Blink;

		// Token: 0x04011707 RID: 71431
		[Token(Token = "0x4011707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		private static DelegateBridge __Hotfix0_SetBodyColor;

		// Token: 0x04011708 RID: 71432
		[Token(Token = "0x4011708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		private static DelegateBridge __Hotfix0_BlinkWithoutSwitchToBlinkState;

		// Token: 0x04011709 RID: 71433
		[Token(Token = "0x4011709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		private static DelegateBridge __Hotfix0_BlinkToGridPositionWithoutSwitchToBlinkState;

		// Token: 0x0401170A RID: 71434
		[Token(Token = "0x401170A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		private static DelegateBridge __Hotfix0_TryGetDistanceToNextCheckpoint;

		// Token: 0x0401170B RID: 71435
		[Token(Token = "0x401170B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private static DelegateBridge __Hotfix0_TryGetDistanceToMapPosInCheckpointsAhead;

		// Token: 0x0401170C RID: 71436
		[Token(Token = "0x401170C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private static DelegateBridge __Hotfix0_ClearTraceIfExist;

		// Token: 0x0401170D RID: 71437
		[Token(Token = "0x401170D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private static DelegateBridge __Hotfix0_ReassignRoute;

		// Token: 0x0401170E RID: 71438
		[Token(Token = "0x401170E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private static DelegateBridge __Hotfix0_ReconstructRoute;

		// Token: 0x0401170F RID: 71439
		[Token(Token = "0x401170F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		private static DelegateBridge __Hotfix0_ReconstructRouteWithTargetGridMove;

		// Token: 0x04011710 RID: 71440
		[Token(Token = "0x4011710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private static DelegateBridge __Hotfix0_TransportInternal;

		// Token: 0x04011711 RID: 71441
		[Token(Token = "0x4011711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private static DelegateBridge __Hotfix0_TryGetNextAppearCheckpoint;

		// Token: 0x04011712 RID: 71442
		[Token(Token = "0x4011712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private static DelegateBridge __Hotfix0_SwitchToDeadState;

		// Token: 0x04011713 RID: 71443
		[Token(Token = "0x4011713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private static DelegateBridge __Hotfix0_PopulateSnapshotToHashBuilder;

		// Token: 0x04011714 RID: 71444
		[Token(Token = "0x4011714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		private static DelegateBridge __Hotfix0_PopulateSnapshotToStrBuilder;

		// Token: 0x04011715 RID: 71445
		[Token(Token = "0x4011715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04011716 RID: 71446
		[Token(Token = "0x4011716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04011717 RID: 71447
		[Token(Token = "0x4011717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		private static DelegateBridge __Hotfix0_ChangePathMotionMode;

		// Token: 0x04011718 RID: 71448
		[Token(Token = "0x4011718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011719 RID: 71449
		[Token(Token = "0x4011719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x0401171A RID: 71450
		[Token(Token = "0x401171A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		private static DelegateBridge __Hotfix0_InitFaceTo;

		// Token: 0x0401171B RID: 71451
		[Token(Token = "0x401171B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		private static DelegateBridge __Hotfix0_OnReborn;

		// Token: 0x0401171C RID: 71452
		[Token(Token = "0x401171C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		private static DelegateBridge __Hotfix0_SetBodyAndFaceDirection;

		// Token: 0x0401171D RID: 71453
		[Token(Token = "0x401171D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		private static DelegateBridge __Hotfix0_TryIgnoreEffect;

		// Token: 0x0401171E RID: 71454
		[Token(Token = "0x401171E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x0401171F RID: 71455
		[Token(Token = "0x401171F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		private static DelegateBridge __Hotfix0_SetBodyDirectionWithPolicy;

		// Token: 0x04011720 RID: 71456
		[Token(Token = "0x4011720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		private static DelegateBridge __Hotfix0_OnDisappearChanged;

		// Token: 0x04011721 RID: 71457
		[Token(Token = "0x4011721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		private static DelegateBridge __Hotfix0_OnSwitchMode;

		// Token: 0x04011722 RID: 71458
		[Token(Token = "0x4011722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		private static DelegateBridge __Hotfix0_OnHpZero;

		// Token: 0x04011723 RID: 71459
		[Token(Token = "0x4011723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		private static DelegateBridge __Hotfix0_OnAttributeDirty;

		// Token: 0x04011724 RID: 71460
		[Token(Token = "0x4011724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		private static DelegateBridge __Hotfix0_ConstructStateMachine;

		// Token: 0x04011725 RID: 71461
		[Token(Token = "0x4011725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		private static DelegateBridge __Hotfix0_FinishMe;

		// Token: 0x04011726 RID: 71462
		[Token(Token = "0x4011726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x648")]
		private static DelegateBridge __Hotfix0_DoFakeDeath;

		// Token: 0x04011727 RID: 71463
		[Token(Token = "0x4011727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x650")]
		private static DelegateBridge __Hotfix0_DoReborn;

		// Token: 0x04011728 RID: 71464
		[Token(Token = "0x4011728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x658")]
		private static DelegateBridge __Hotfix0__MoveByRoute;

		// Token: 0x04011729 RID: 71465
		[Token(Token = "0x4011729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x660")]
		private static DelegateBridge __Hotfix0__MoveInFearArea;

		// Token: 0x0401172A RID: 71466
		[Token(Token = "0x401172A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x668")]
		private static DelegateBridge __Hotfix0__MoveInAttractArea;

		// Token: 0x0401172B RID: 71467
		[Token(Token = "0x401172B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		private static DelegateBridge __Hotfix0__MoveToFixedDirection;

		// Token: 0x0401172C RID: 71468
		[Token(Token = "0x401172C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		private static DelegateBridge __Hotfix0__MoveByCursor;

		// Token: 0x0401172D RID: 71469
		[Token(Token = "0x401172D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		private static DelegateBridge __Hotfix0_ReleaseFromBlocker;

		// Token: 0x0401172E RID: 71470
		[Token(Token = "0x401172E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x688")]
		private static DelegateBridge __Hotfix0__ResetPhysicsStatus;

		// Token: 0x0401172F RID: 71471
		[Token(Token = "0x401172F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		private static DelegateBridge __Hotfix0__ReactivateMainTriggerCollider;

		// Token: 0x04011730 RID: 71472
		[Token(Token = "0x4011730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		private static DelegateBridge __Hotfix0__SearchAttackTarget;

		// Token: 0x04011731 RID: 71473
		[Token(Token = "0x4011731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		private static DelegateBridge __Hotfix0__InitCurrentTile;

		// Token: 0x04011732 RID: 71474
		[Token(Token = "0x4011732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
		private static DelegateBridge __Hotfix0__CheckTileCanExit;

		// Token: 0x04011733 RID: 71475
		[Token(Token = "0x4011733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		private static DelegateBridge __Hotfix0_UpdateCurrentTile;

		// Token: 0x04011734 RID: 71476
		[Token(Token = "0x4011734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		private static DelegateBridge __Hotfix0_TryGetFirstAttachedSkill;

		// Token: 0x04011735 RID: 71477
		[Token(Token = "0x4011735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		private static DelegateBridge __Hotfix0__UpdateCurrentTile;

		// Token: 0x04011736 RID: 71478
		[Token(Token = "0x4011736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
		private static DelegateBridge __Hotfix0__CursorNeedCheckReached;

		// Token: 0x04011737 RID: 71479
		[Token(Token = "0x4011737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
		private static DelegateBridge __Hotfix0_SetHeightDirectly;

		// Token: 0x04011738 RID: 71480
		[Token(Token = "0x4011738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
		private static DelegateBridge __Hotfix0__GetRootTileDeltaHeight;

		// Token: 0x04011739 RID: 71481
		[Token(Token = "0x4011739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
		private static DelegateBridge __Hotfix0_SetHeight;

		// Token: 0x0401173A RID: 71482
		[Token(Token = "0x401173A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
		private static DelegateBridge __Hotfix0_SetEnemyHeightOffset;

		// Token: 0x0401173B RID: 71483
		[Token(Token = "0x401173B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		private static DelegateBridge __Hotfix0_AdjustEnemyHeightByInitial;

		// Token: 0x0401173C RID: 71484
		[Token(Token = "0x401173C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
		private static DelegateBridge __Hotfix0_SetHeightImmediatelyChange;

		// Token: 0x0401173D RID: 71485
		[Token(Token = "0x401173D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
		private static DelegateBridge __Hotfix0_SetEnemyLevitateOffset;

		// Token: 0x0401173E RID: 71486
		[Token(Token = "0x401173E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x708")]
		private static DelegateBridge __Hotfix0_IsHanging;

		// Token: 0x0401173F RID: 71487
		[Token(Token = "0x401173F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x710")]
		private static DelegateBridge __Hotfix0_IsStayStill;

		// Token: 0x04011740 RID: 71488
		[Token(Token = "0x4011740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x718")]
		private static DelegateBridge __Hotfix0_OnRootTileChanged;

		// Token: 0x04011741 RID: 71489
		[Token(Token = "0x4011741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x720")]
		private static DelegateBridge __Hotfix0_PlayUnbalanceAnimation;

		// Token: 0x04011742 RID: 71490
		[Token(Token = "0x4011742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x728")]
		private static DelegateBridge __Hotfix0_ModifySpUIFlag;

		// Token: 0x04011743 RID: 71491
		[Token(Token = "0x4011743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x730")]
		private static DelegateBridge __Hotfix0__MoveToBlockPosition;

		// Token: 0x04011744 RID: 71492
		[Token(Token = "0x4011744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x738")]
		private static DelegateBridge __Hotfix0_FaceToCalculateDirection;

		// Token: 0x04011745 RID: 71493
		[Token(Token = "0x4011745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		private static DelegateBridge __Hotfix0_ReachExit;

		// Token: 0x04011746 RID: 71494
		[Token(Token = "0x4011746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x748")]
		private static DelegateBridge __Hotfix0_FinishWithReachExit;

		// Token: 0x04011747 RID: 71495
		[Token(Token = "0x4011747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		private static DelegateBridge __Hotfix0__CalculateFaceDirection;

		// Token: 0x04011748 RID: 71496
		[Token(Token = "0x4011748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x758")]
		private static DelegateBridge __Hotfix0__CheckUseIdForAudioSignal;

		// Token: 0x04011749 RID: 71497
		[Token(Token = "0x4011749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		private static DelegateBridge __Hotfix0__AssignData;

		// Token: 0x0401174A RID: 71498
		[Token(Token = "0x401174A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x768")]
		private static DelegateBridge __Hotfix0__AssignSkill;

		// Token: 0x0401174B RID: 71499
		[Token(Token = "0x401174B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		private static DelegateBridge __Hotfix0__AssignTalent;

		// Token: 0x0401174C RID: 71500
		[Token(Token = "0x401174C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x778")]
		private static DelegateBridge __Hotfix0__GetDefaultModeIndex;

		// Token: 0x0401174D RID: 71501
		[Token(Token = "0x401174D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		private static DelegateBridge __Hotfix0_GetAttackBlackboard;

		// Token: 0x0401174E RID: 71502
		[Token(Token = "0x401174E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x788")]
		private static DelegateBridge __Hotfix0_TryFindFirstEnabledEnemySkill;

		// Token: 0x0401174F RID: 71503
		[Token(Token = "0x401174F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x04011750 RID: 71504
		[Token(Token = "0x4011750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011751 RID: 71505
		[Token(Token = "0x4011751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04011752 RID: 71506
		[Token(Token = "0x4011752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04011753 RID: 71507
		[Token(Token = "0x4011753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011754 RID: 71508
		[Token(Token = "0x4011754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B8")]
		private static DelegateBridge __Hotfix0_ClearStaticVariables;

		// Token: 0x04011755 RID: 71509
		[Token(Token = "0x4011755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C0")]
		private static DelegateBridge __Hotfix0_OnTickAfterDead;

		// Token: 0x04011756 RID: 71510
		[Token(Token = "0x4011756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C8")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x04011757 RID: 71511
		[Token(Token = "0x4011757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x04011758 RID: 71512
		[Token(Token = "0x4011758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
		private static DelegateBridge __Hotfix0_OnTriggerPalsy;

		// Token: 0x04011759 RID: 71513
		[Token(Token = "0x4011759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
		private static DelegateBridge __Hotfix0_CanDoAbilitySpellOn;

		// Token: 0x0401175A RID: 71514
		[Token(Token = "0x401175A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
		private static DelegateBridge __Hotfix0_CheckTargetInAttackRange;

		// Token: 0x0401175B RID: 71515
		[Token(Token = "0x401175B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		private static DelegateBridge __Hotfix0__InitPhysics;

		// Token: 0x0401175C RID: 71516
		[Token(Token = "0x401175C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
		private static DelegateBridge __Hotfix0_TryUpdateEnemySkillSelector;

		// Token: 0x0401175D RID: 71517
		[Token(Token = "0x401175D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
		private static DelegateBridge __Hotfix0__GenerateSpData;

		// Token: 0x0401175E RID: 71518
		[Token(Token = "0x401175E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x808")]
		private static DelegateBridge __Hotfix0_ChangeMotionMode;

		// Token: 0x0401175F RID: 71519
		[Token(Token = "0x401175F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		private static DelegateBridge __Hotfix0_ResetMotionMode;

		// Token: 0x04011760 RID: 71520
		[Token(Token = "0x4011760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x818")]
		private static DelegateBridge __Hotfix0_GetBakeMuzzleDataPath;

		// Token: 0x04011761 RID: 71521
		[Token(Token = "0x4011761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x820")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020025C0 RID: 9664
		[Token(Token = "0x20025C0")]
		public struct Options
		{
			// Token: 0x04011762 RID: 71522
			[Token(Token = "0x4011762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool unharmful;

			// Token: 0x04011763 RID: 71523
			[Token(Token = "0x4011763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool alwaysCountAsKilled;

			// Token: 0x04011764 RID: 71524
			[Token(Token = "0x4011764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool dontCountAsFinished;

			// Token: 0x04011765 RID: 71525
			[Token(Token = "0x4011765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool disableBornTweenColor;

			// Token: 0x04011766 RID: 71526
			[Token(Token = "0x4011766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint spawnedCnt;

			// Token: 0x04011767 RID: 71527
			[Token(Token = "0x4011767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool isSummon;

			// Token: 0x04011768 RID: 71528
			[Token(Token = "0x4011768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string hiddenGroupKey;

			// Token: 0x04011769 RID: 71529
			[Token(Token = "0x4011769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object actionExtraMeta;

			// Token: 0x0401176A RID: 71530
			[Token(Token = "0x401176A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LevelData.WaveData.FragmentData.ActionData actionData;

			// Token: 0x0401176B RID: 71531
			[Token(Token = "0x401176B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool noLogInEnemyStatsWhenFinished;
		}

		// Token: 0x020025C1 RID: 9665
		[Token(Token = "0x20025C1")]
		public enum BodyDirectionPolicy
		{
			// Token: 0x0401176D RID: 71533
			[Token(Token = "0x401176D")]
			DEFAULT_FOUR_WAYS,
			// Token: 0x0401176E RID: 71534
			[Token(Token = "0x401176E")]
			LEFT_OR_RIGHT
		}

		// Token: 0x020025C2 RID: 9666
		[Token(Token = "0x20025C2")]
		public enum CursorType
		{
			// Token: 0x04011770 RID: 71536
			[Token(Token = "0x4011770")]
			MOVE_CURSOR,
			// Token: 0x04011771 RID: 71537
			[Token(Token = "0x4011771")]
			FEAR_CURSOR,
			// Token: 0x04011772 RID: 71538
			[Token(Token = "0x4011772")]
			ATTRACT_CURSOR
		}

		// Token: 0x020025C3 RID: 9667
		[Token(Token = "0x20025C3")]
		public static class States
		{
			// Token: 0x0600FB61 RID: 64353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600FB61")]
			[Address(RVA = "0x74E9E0", Offset = "0x74D5E0", VA = "0x18074E9E0")]
			public static StateMachine ConstructStateMachine(Enemy owner)
			{
				return null;
			}

			// Token: 0x020025C4 RID: 9668
			[Token(Token = "0x20025C4")]
			public enum State
			{
				// Token: 0x04011774 RID: 71540
				[Token(Token = "0x4011774")]
				DEFAULT,
				// Token: 0x04011775 RID: 71541
				[Token(Token = "0x4011775")]
				MOVE,
				// Token: 0x04011776 RID: 71542
				[Token(Token = "0x4011776")]
				ATTACK,
				// Token: 0x04011777 RID: 71543
				[Token(Token = "0x4011777")]
				COMBAT,
				// Token: 0x04011778 RID: 71544
				[Token(Token = "0x4011778")]
				STUN,
				// Token: 0x04011779 RID: 71545
				[Token(Token = "0x4011779")]
				DEAD,
				// Token: 0x0401177A RID: 71546
				[Token(Token = "0x401177A")]
				BORN,
				// Token: 0x0401177B RID: 71547
				[Token(Token = "0x401177B")]
				REACH_EXIT,
				// Token: 0x0401177C RID: 71548
				[Token(Token = "0x401177C")]
				REBORN,
				// Token: 0x0401177D RID: 71549
				[Token(Token = "0x401177D")]
				UNBALANCE,
				// Token: 0x0401177E RID: 71550
				[Token(Token = "0x401177E")]
				FALLDOWN,
				// Token: 0x0401177F RID: 71551
				[Token(Token = "0x401177F")]
				DISAPPEAR,
				// Token: 0x04011780 RID: 71552
				[Token(Token = "0x4011780")]
				BLINK,
				// Token: 0x04011781 RID: 71553
				[Token(Token = "0x4011781")]
				FROZEN,
				// Token: 0x04011782 RID: 71554
				[Token(Token = "0x4011782")]
				LEVITATE,
				// Token: 0x04011783 RID: 71555
				[Token(Token = "0x4011783")]
				DIALOG,
				// Token: 0x04011784 RID: 71556
				[Token(Token = "0x4011784")]
				PALSY,
				// Token: 0x04011785 RID: 71557
				[Token(Token = "0x4011785")]
				TERMINAL = -1
			}

			// Token: 0x020025C5 RID: 9669
			[Token(Token = "0x20025C5")]
			public class Blackboard : StateMachine.IBlackboard
			{
				// Token: 0x17002184 RID: 8580
				// (get) Token: 0x0600FB62 RID: 64354 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600FB63 RID: 64355 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002184")]
				public Enemy owner
				{
					[Token(Token = "0x600FB62")]
					[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x600FB63")]
					[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x17002185 RID: 8581
				// (get) Token: 0x0600FB64 RID: 64356 RVA: 0x0005ECE0 File Offset: 0x0005CEE0
				[Token(Token = "0x17002185")]
				public FP unbalanceProtectDueTime
				{
					[Token(Token = "0x600FB64")]
					[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x17002186 RID: 8582
				// (get) Token: 0x0600FB65 RID: 64357 RVA: 0x0005ECF8 File Offset: 0x0005CEF8
				// (set) Token: 0x0600FB66 RID: 64358 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002186")]
				public float blinkDistance
				{
					[Token(Token = "0x600FB65")]
					[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
					get
					{
						return 0f;
					}
					[Token(Token = "0x600FB66")]
					[Address(RVA = "0x73B900", Offset = "0x73A500", VA = "0x18073B900")]
					set
					{
					}
				}

				// Token: 0x17002187 RID: 8583
				// (get) Token: 0x0600FB67 RID: 64359 RVA: 0x0005ED10 File Offset: 0x0005CF10
				// (set) Token: 0x0600FB68 RID: 64360 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002187")]
				public float blinkHideTime
				{
					[Token(Token = "0x600FB67")]
					[Address(RVA = "0x73B8E0", Offset = "0x73A4E0", VA = "0x18073B8E0")]
					get
					{
						return 0f;
					}
					[Token(Token = "0x600FB68")]
					[Address(RVA = "0x73B910", Offset = "0x73A510", VA = "0x18073B910")]
					set
					{
					}
				}

				// Token: 0x17002188 RID: 8584
				// (get) Token: 0x0600FB69 RID: 64361 RVA: 0x0005ED28 File Offset: 0x0005CF28
				// (set) Token: 0x0600FB6A RID: 64362 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002188")]
				public bool blinkUseAnimTime
				{
					[Token(Token = "0x600FB69")]
					[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x600FB6A")]
					[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
					set
					{
					}
				}

				// Token: 0x0600FB6B RID: 64363 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB6B")]
				[Address(RVA = "0x73B8B0", Offset = "0x73A4B0", VA = "0x18073B8B0")]
				public Blackboard(Enemy owner)
				{
				}

				// Token: 0x0600FB6C RID: 64364 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB6C")]
				[Address(RVA = "0x73B760", Offset = "0x73A360", VA = "0x18073B760", Slot = "4")]
				public void OnReset()
				{
				}

				// Token: 0x0600FB6D RID: 64365 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB6D")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
				public void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FB6E RID: 64366 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB6E")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
				public void OnStop()
				{
				}

				// Token: 0x0600FB6F RID: 64367 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB6F")]
				[Address(RVA = "0x73B810", Offset = "0x73A410", VA = "0x18073B810")]
				public void UpdateUnbalanceProtectTime()
				{
				}

				// Token: 0x0600FB70 RID: 64368 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB70")]
				[Address(RVA = "0x73B7C0", Offset = "0x73A3C0", VA = "0x18073B7C0")]
				public void ResetUnbalanceProtectTime()
				{
				}

				// Token: 0x04011786 RID: 71558
				[Token(Token = "0x4011786")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool isHanging;

				// Token: 0x04011787 RID: 71559
				[Token(Token = "0x4011787")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
				public bool isStruggling;

				// Token: 0x04011788 RID: 71560
				[Token(Token = "0x4011788")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_unbalanceProtectDueTime;

				// Token: 0x04011789 RID: 71561
				[Token(Token = "0x4011789")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private float m_blinkDistance;

				// Token: 0x0401178A RID: 71562
				[Token(Token = "0x401178A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private float m_blinkHideTime;

				// Token: 0x0401178B RID: 71563
				[Token(Token = "0x401178B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private bool m_blinkUseAnimTime;
			}

			// Token: 0x020025C6 RID: 9670
			[Token(Token = "0x20025C6")]
			private class EnemyStateMachine : HierachyStateMachine<Enemy.States.State, Enemy, Enemy.States.Blackboard>, IHotfixable
			{
				// Token: 0x0600FB71 RID: 64369 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB71")]
				[Address(RVA = "0x7446B0", Offset = "0x7432B0", VA = "0x1807446B0")]
				public EnemyStateMachine(Enemy enemy, Enemy.States.Blackboard blackboard)
				{
				}

				// Token: 0x0600FB72 RID: 64370 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB72")]
				[Address(RVA = "0x7445D0", Offset = "0x7431D0", VA = "0x1807445D0", Slot = "8")]
				protected override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FB73 RID: 64371 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB73")]
				[Address(RVA = "0x7446A0", Offset = "0x7432A0", VA = "0x1807446A0")]
				private void <>xLuaBaseProxy_OnTick(FP P0)
				{
				}

				// Token: 0x0401178D RID: 71565
				[Token(Token = "0x401178D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x0401178E RID: 71566
				[Token(Token = "0x401178E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;
			}

			// Token: 0x020025C7 RID: 9671
			[Token(Token = "0x20025C7")]
			public abstract class BasicState : HierachyStateMachine<Enemy.States.State, Enemy, Enemy.States.Blackboard>.StateNode, IHotfixable
			{
				// Token: 0x0600FB74 RID: 64372 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB74")]
				[Address(RVA = "0x73B6F0", Offset = "0x73A2F0", VA = "0x18073B6F0")]
				protected BasicState()
				{
				}

				// Token: 0x0401178F RID: 71567
				[Token(Token = "0x401178F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025C8 RID: 9672
			[Token(Token = "0x20025C8")]
			private class BornState : Enemy.States.BasicState
			{
				// Token: 0x0600FB75 RID: 64373 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB75")]
				[Address(RVA = "0x73C1B0", Offset = "0x73ADB0", VA = "0x18073C1B0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FB76 RID: 64374 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB76")]
				[Address(RVA = "0x73C310", Offset = "0x73AF10", VA = "0x18073C310", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FB77 RID: 64375 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB77")]
				[Address(RVA = "0x73C490", Offset = "0x73B090", VA = "0x18073C490", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FB78 RID: 64376 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB78")]
				[Address(RVA = "0x73C6F0", Offset = "0x73B2F0", VA = "0x18073C6F0")]
				private void _PlayAnimation()
				{
				}

				// Token: 0x0600FB79 RID: 64377 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB79")]
				[Address(RVA = "0x73CDC0", Offset = "0x73B9C0", VA = "0x18073CDC0")]
				private void _SetBodyColor(Color color)
				{
				}

				// Token: 0x0600FB7A RID: 64378 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB7A")]
				[Address(RVA = "0x73CEF0", Offset = "0x73BAF0", VA = "0x18073CEF0")]
				public BornState()
				{
				}

				// Token: 0x04011790 RID: 71568
				[Token(Token = "0x4011790")]
				private const float BORN_ANIMATION_TIME = 1f;

				// Token: 0x04011791 RID: 71569
				[Token(Token = "0x4011791")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_remainingTime;

				// Token: 0x04011792 RID: 71570
				[Token(Token = "0x4011792")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private ObjectPtr<Effect> m_effect;

				// Token: 0x04011793 RID: 71571
				[Token(Token = "0x4011793")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x04011794 RID: 71572
				[Token(Token = "0x4011794")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x04011795 RID: 71573
				[Token(Token = "0x4011795")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x04011796 RID: 71574
				[Token(Token = "0x4011796")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x04011797 RID: 71575
				[Token(Token = "0x4011797")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0__SetBodyColor;

				// Token: 0x04011798 RID: 71576
				[Token(Token = "0x4011798")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025CA RID: 9674
			[Token(Token = "0x20025CA")]
			public class MoveState : Enemy.States.BasicState
			{
				// Token: 0x17002189 RID: 8585
				// (get) Token: 0x0600FB80 RID: 64384 RVA: 0x0005ED58 File Offset: 0x0005CF58
				// (set) Token: 0x0600FB81 RID: 64385 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17002189")]
				public bool isHanging
				{
					[Token(Token = "0x600FB80")]
					[Address(RVA = "0x74B5E0", Offset = "0x74A1E0", VA = "0x18074B5E0")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x600FB81")]
					[Address(RVA = "0x74B660", Offset = "0x74A260", VA = "0x18074B660")]
					private set
					{
					}
				}

				// Token: 0x0600FB82 RID: 64386 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB82")]
				[Address(RVA = "0x74AD80", Offset = "0x749980", VA = "0x18074AD80", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FB83 RID: 64387 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB83")]
				[Address(RVA = "0x74AED0", Offset = "0x749AD0", VA = "0x18074AED0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FB84 RID: 64388 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB84")]
				[Address(RVA = "0x74AF60", Offset = "0x749B60", VA = "0x18074AF60", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FB85 RID: 64389 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB85")]
				[Address(RVA = "0x74B420", Offset = "0x74A020", VA = "0x18074B420")]
				public void UpdateMoveAnimation()
				{
				}

				// Token: 0x0600FB86 RID: 64390 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB86")]
				[Address(RVA = "0x74B530", Offset = "0x74A130", VA = "0x18074B530")]
				public MoveState()
				{
				}

				// Token: 0x0401179B RID: 71579
				[Token(Token = "0x401179B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_isHanging;

				// Token: 0x0401179C RID: 71580
				[Token(Token = "0x401179C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_set_isHanging;

				// Token: 0x0401179D RID: 71581
				[Token(Token = "0x401179D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x0401179E RID: 71582
				[Token(Token = "0x401179E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x0401179F RID: 71583
				[Token(Token = "0x401179F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040117A0 RID: 71584
				[Token(Token = "0x40117A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_UpdateMoveAnimation;

				// Token: 0x040117A1 RID: 71585
				[Token(Token = "0x40117A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025CB RID: 9675
			[Token(Token = "0x20025CB")]
			private class AttackState : Enemy.States.BasicState
			{
				// Token: 0x0600FB87 RID: 64391 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB87")]
				[Address(RVA = "0x739300", Offset = "0x737F00", VA = "0x180739300", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FB88 RID: 64392 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB88")]
				[Address(RVA = "0x739620", Offset = "0x738220", VA = "0x180739620", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FB89 RID: 64393 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB89")]
				[Address(RVA = "0x7394E0", Offset = "0x7380E0", VA = "0x1807394E0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FB8A RID: 64394 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB8A")]
				[Address(RVA = "0x739810", Offset = "0x738410", VA = "0x180739810")]
				private void _AttackFinishCallback(Ability ability, Ability.FinishReason reason, bool resetCd)
				{
				}

				// Token: 0x0600FB8B RID: 64395 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB8B")]
				[Address(RVA = "0x7398E0", Offset = "0x7384E0", VA = "0x1807398E0")]
				public AttackState()
				{
				}

				// Token: 0x040117A2 RID: 71586
				[Token(Token = "0x40117A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117A3 RID: 71587
				[Token(Token = "0x40117A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040117A4 RID: 71588
				[Token(Token = "0x40117A4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040117A5 RID: 71589
				[Token(Token = "0x40117A5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__AttackFinishCallback;

				// Token: 0x040117A6 RID: 71590
				[Token(Token = "0x40117A6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025CC RID: 9676
			[Token(Token = "0x20025CC")]
			private class DeadState : Enemy.States.BasicState
			{
				// Token: 0x0600FB8C RID: 64396 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB8C")]
				[Address(RVA = "0x73F0F0", Offset = "0x73DCF0", VA = "0x18073F0F0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FB8D RID: 64397 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB8D")]
				[Address(RVA = "0x73F300", Offset = "0x73DF00", VA = "0x18073F300", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FB8E RID: 64398 RVA: 0x0005ED70 File Offset: 0x0005CF70
				[Token(Token = "0x600FB8E")]
				[Address(RVA = "0x73F080", Offset = "0x73DC80", VA = "0x18073F080", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FB8F RID: 64399 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB8F")]
				[Address(RVA = "0x73F3D0", Offset = "0x73DFD0", VA = "0x18073F3D0")]
				private void _PlayAnimation()
				{
				}

				// Token: 0x0600FB90 RID: 64400 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB90")]
				[Address(RVA = "0x73FB00", Offset = "0x73E700", VA = "0x18073FB00")]
				public DeadState()
				{
				}

				// Token: 0x040117A7 RID: 71591
				[Token(Token = "0x40117A7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Tween m_tween;

				// Token: 0x040117A8 RID: 71592
				[Token(Token = "0x40117A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117A9 RID: 71593
				[Token(Token = "0x40117A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040117AA RID: 71594
				[Token(Token = "0x40117AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040117AB RID: 71595
				[Token(Token = "0x40117AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x040117AC RID: 71596
				[Token(Token = "0x40117AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025CF RID: 9679
			[Token(Token = "0x20025CF")]
			private class ReachExitState : Enemy.States.BasicState
			{
				// Token: 0x0600FB9A RID: 64410 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB9A")]
				[Address(RVA = "0x74C120", Offset = "0x74AD20", VA = "0x18074C120", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FB9B RID: 64411 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB9B")]
				[Address(RVA = "0x74C1C0", Offset = "0x74ADC0", VA = "0x18074C1C0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FB9C RID: 64412 RVA: 0x0005EDD0 File Offset: 0x0005CFD0
				[Token(Token = "0x600FB9C")]
				[Address(RVA = "0x74C0B0", Offset = "0x74ACB0", VA = "0x18074C0B0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FB9D RID: 64413 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB9D")]
				[Address(RVA = "0x74C290", Offset = "0x74AE90", VA = "0x18074C290")]
				private void _PlayAnimation()
				{
				}

				// Token: 0x0600FB9E RID: 64414 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FB9E")]
				[Address(RVA = "0x74CE60", Offset = "0x74BA60", VA = "0x18074CE60")]
				public ReachExitState()
				{
				}

				// Token: 0x040117B4 RID: 71604
				[Token(Token = "0x40117B4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Tween m_tween;

				// Token: 0x040117B5 RID: 71605
				[Token(Token = "0x40117B5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117B6 RID: 71606
				[Token(Token = "0x40117B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040117B7 RID: 71607
				[Token(Token = "0x40117B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040117B8 RID: 71608
				[Token(Token = "0x40117B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x040117B9 RID: 71609
				[Token(Token = "0x40117B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025D2 RID: 9682
			[Token(Token = "0x20025D2")]
			private class CombatState : Enemy.States.BasicState
			{
				// Token: 0x0600FBAC RID: 64428 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBAC")]
				[Address(RVA = "0x73CFD0", Offset = "0x73BBD0", VA = "0x18073CFD0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FBAD RID: 64429 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBAD")]
				[Address(RVA = "0x73D350", Offset = "0x73BF50", VA = "0x18073D350", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FBAE RID: 64430 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBAE")]
				[Address(RVA = "0x73D230", Offset = "0x73BE30", VA = "0x18073D230", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FBAF RID: 64431 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBAF")]
				[Address(RVA = "0x73D6E0", Offset = "0x73C2E0", VA = "0x18073D6E0")]
				public CombatState()
				{
				}

				// Token: 0x040117C3 RID: 71619
				[Token(Token = "0x40117C3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117C4 RID: 71620
				[Token(Token = "0x40117C4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040117C5 RID: 71621
				[Token(Token = "0x40117C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040117C6 RID: 71622
				[Token(Token = "0x40117C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025D3 RID: 9683
			[Token(Token = "0x20025D3")]
			private class StunState : Enemy.States.BasicState
			{
				// Token: 0x0600FBB0 RID: 64432 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBB0")]
				[Address(RVA = "0x74F9E0", Offset = "0x74E5E0", VA = "0x18074F9E0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FBB1 RID: 64433 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBB1")]
				[Address(RVA = "0x74FB70", Offset = "0x74E770", VA = "0x18074FB70", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FBB2 RID: 64434 RVA: 0x0005EE60 File Offset: 0x0005D060
				[Token(Token = "0x600FBB2")]
				[Address(RVA = "0x74F920", Offset = "0x74E520", VA = "0x18074F920", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FBB3 RID: 64435 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBB3")]
				[Address(RVA = "0x74FD00", Offset = "0x74E900", VA = "0x18074FD00")]
				public StunState()
				{
				}

				// Token: 0x040117C7 RID: 71623
				[Token(Token = "0x40117C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117C8 RID: 71624
				[Token(Token = "0x40117C8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040117C9 RID: 71625
				[Token(Token = "0x40117C9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040117CA RID: 71626
				[Token(Token = "0x40117CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025D4 RID: 9684
			[Token(Token = "0x20025D4")]
			private class PalsyState : Enemy.States.BasicState
			{
				// Token: 0x0600FBB4 RID: 64436 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBB4")]
				[Address(RVA = "0x74B910", Offset = "0x74A510", VA = "0x18074B910", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FBB5 RID: 64437 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBB5")]
				[Address(RVA = "0x74BAA0", Offset = "0x74A6A0", VA = "0x18074BAA0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FBB6 RID: 64438 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBB6")]
				[Address(RVA = "0x74BBC0", Offset = "0x74A7C0", VA = "0x18074BBC0", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FBB7 RID: 64439 RVA: 0x0005EE78 File Offset: 0x0005D078
				[Token(Token = "0x600FBB7")]
				[Address(RVA = "0x74B830", Offset = "0x74A430", VA = "0x18074B830", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FBB8 RID: 64440 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBB8")]
				[Address(RVA = "0x74BD60", Offset = "0x74A960", VA = "0x18074BD60")]
				private void _PlayShaking()
				{
				}

				// Token: 0x0600FBB9 RID: 64441 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBB9")]
				[Address(RVA = "0x74BFE0", Offset = "0x74ABE0", VA = "0x18074BFE0")]
				public PalsyState()
				{
				}

				// Token: 0x040117CB RID: 71627
				[Token(Token = "0x40117CB")]
				private const float SHAKE_DEFAULT_TIME = 5f;

				// Token: 0x040117CC RID: 71628
				[Token(Token = "0x40117CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static Vector3 SHAKE_STRENGTH;

				// Token: 0x040117CD RID: 71629
				[Token(Token = "0x40117CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 m_beforePos;

				// Token: 0x040117CE RID: 71630
				[Token(Token = "0x40117CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Tween m_tween;

				// Token: 0x040117CF RID: 71631
				[Token(Token = "0x40117CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117D0 RID: 71632
				[Token(Token = "0x40117D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040117D1 RID: 71633
				[Token(Token = "0x40117D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040117D2 RID: 71634
				[Token(Token = "0x40117D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040117D3 RID: 71635
				[Token(Token = "0x40117D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0__PlayShaking;

				// Token: 0x040117D4 RID: 71636
				[Token(Token = "0x40117D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025D5 RID: 9685
			[Token(Token = "0x20025D5")]
			private class FreezeState : Enemy.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x1700218A RID: 8586
				// (get) Token: 0x0600FBBB RID: 64443 RVA: 0x0005EE90 File Offset: 0x0005D090
				[Token(Token = "0x1700218A")]
				public long attributeMask
				{
					[Token(Token = "0x600FBBB")]
					[Address(RVA = "0x749070", Offset = "0x747C70", VA = "0x180749070", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700218B RID: 8587
				// (get) Token: 0x0600FBBC RID: 64444 RVA: 0x0005EEA8 File Offset: 0x0005D0A8
				[Token(Token = "0x1700218B")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600FBBC")]
					[Address(RVA = "0x748FB0", Offset = "0x747BB0", VA = "0x180748FB0", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700218C RID: 8588
				// (get) Token: 0x0600FBBD RID: 64445 RVA: 0x0005EEC0 File Offset: 0x0005D0C0
				[Token(Token = "0x1700218C")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600FBBD")]
					[Address(RVA = "0x749010", Offset = "0x747C10", VA = "0x180749010", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700218D RID: 8589
				// (get) Token: 0x0600FBBE RID: 64446 RVA: 0x0005EED8 File Offset: 0x0005D0D8
				[Token(Token = "0x1700218D")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600FBBE")]
					[Address(RVA = "0x748E90", Offset = "0x747A90", VA = "0x180748E90", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700218E RID: 8590
				// (get) Token: 0x0600FBBF RID: 64447 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
				[Token(Token = "0x1700218E")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600FBBF")]
					[Address(RVA = "0x748F50", Offset = "0x747B50", VA = "0x180748F50", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700218F RID: 8591
				// (get) Token: 0x0600FBC0 RID: 64448 RVA: 0x0005EF08 File Offset: 0x0005D108
				[Token(Token = "0x1700218F")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600FBC0")]
					[Address(RVA = "0x748EF0", Offset = "0x747AF0", VA = "0x180748EF0", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FBC1 RID: 64449 RVA: 0x0005EF20 File Offset: 0x0005D120
				[Token(Token = "0x600FBC1")]
				[Address(RVA = "0x7487B0", Offset = "0x7473B0", VA = "0x1807487B0", Slot = "20")]
				public bool GetValue(AttributeType attributeType, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600FBC2 RID: 64450 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBC2")]
				[Address(RVA = "0x748890", Offset = "0x747490", VA = "0x180748890", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FBC3 RID: 64451 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBC3")]
				[Address(RVA = "0x748C50", Offset = "0x747850", VA = "0x180748C50", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FBC4 RID: 64452 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBC4")]
				[Address(RVA = "0x748AB0", Offset = "0x7476B0", VA = "0x180748AB0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FBC5 RID: 64453 RVA: 0x0005EF38 File Offset: 0x0005D138
				[Token(Token = "0x600FBC5")]
				[Address(RVA = "0x7486F0", Offset = "0x7472F0", VA = "0x1807486F0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FBC6 RID: 64454 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBC6")]
				[Address(RVA = "0x748DE0", Offset = "0x7479E0", VA = "0x180748DE0")]
				public FreezeState()
				{
				}

				// Token: 0x040117D5 RID: 71637
				[Token(Token = "0x40117D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private UnitAnimator.CurrentAniState m_animatorState;

				// Token: 0x040117D6 RID: 71638
				[Token(Token = "0x40117D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x040117D7 RID: 71639
				[Token(Token = "0x40117D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x040117D8 RID: 71640
				[Token(Token = "0x40117D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x040117D9 RID: 71641
				[Token(Token = "0x40117D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x040117DA RID: 71642
				[Token(Token = "0x40117DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x040117DB RID: 71643
				[Token(Token = "0x40117DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x040117DC RID: 71644
				[Token(Token = "0x40117DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x040117DD RID: 71645
				[Token(Token = "0x40117DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117DE RID: 71646
				[Token(Token = "0x40117DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040117DF RID: 71647
				[Token(Token = "0x40117DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040117E0 RID: 71648
				[Token(Token = "0x40117E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040117E1 RID: 71649
				[Token(Token = "0x40117E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025D6 RID: 9686
			[Token(Token = "0x20025D6")]
			private class LevitateState : Enemy.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x17002190 RID: 8592
				// (get) Token: 0x0600FBC7 RID: 64455 RVA: 0x0005EF50 File Offset: 0x0005D150
				[Token(Token = "0x17002190")]
				public long attributeMask
				{
					[Token(Token = "0x600FBC7")]
					[Address(RVA = "0x74AD10", Offset = "0x749910", VA = "0x18074AD10", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002191 RID: 8593
				// (get) Token: 0x0600FBC8 RID: 64456 RVA: 0x0005EF68 File Offset: 0x0005D168
				[Token(Token = "0x17002191")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600FBC8")]
					[Address(RVA = "0x74AC30", Offset = "0x749830", VA = "0x18074AC30", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002192 RID: 8594
				// (get) Token: 0x0600FBC9 RID: 64457 RVA: 0x0005EF80 File Offset: 0x0005D180
				[Token(Token = "0x17002192")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600FBC9")]
					[Address(RVA = "0x74ACA0", Offset = "0x7498A0", VA = "0x18074ACA0", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002193 RID: 8595
				// (get) Token: 0x0600FBCA RID: 64458 RVA: 0x0005EF98 File Offset: 0x0005D198
				[Token(Token = "0x17002193")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600FBCA")]
					[Address(RVA = "0x74AAE0", Offset = "0x7496E0", VA = "0x18074AAE0", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002194 RID: 8596
				// (get) Token: 0x0600FBCB RID: 64459 RVA: 0x0005EFB0 File Offset: 0x0005D1B0
				[Token(Token = "0x17002194")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600FBCB")]
					[Address(RVA = "0x74ABC0", Offset = "0x7497C0", VA = "0x18074ABC0", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002195 RID: 8597
				// (get) Token: 0x0600FBCC RID: 64460 RVA: 0x0005EFC8 File Offset: 0x0005D1C8
				[Token(Token = "0x17002195")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600FBCC")]
					[Address(RVA = "0x74AB50", Offset = "0x749750", VA = "0x18074AB50", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FBCD RID: 64461 RVA: 0x0005EFE0 File Offset: 0x0005D1E0
				[Token(Token = "0x600FBCD")]
				[Address(RVA = "0x74A080", Offset = "0x748C80", VA = "0x18074A080", Slot = "20")]
				public bool GetValue(AttributeType attributeType, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600FBCE RID: 64462 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBCE")]
				[Address(RVA = "0x74A180", Offset = "0x748D80", VA = "0x18074A180", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FBCF RID: 64463 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBCF")]
				[Address(RVA = "0x74A590", Offset = "0x749190", VA = "0x18074A590", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FBD0 RID: 64464 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBD0")]
				[Address(RVA = "0x74A390", Offset = "0x748F90", VA = "0x18074A390", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FBD1 RID: 64465 RVA: 0x0005EFF8 File Offset: 0x0005D1F8
				[Token(Token = "0x600FBD1")]
				[Address(RVA = "0x749FB0", Offset = "0x748BB0", VA = "0x180749FB0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FBD2 RID: 64466 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBD2")]
				[Address(RVA = "0x74A6F0", Offset = "0x7492F0", VA = "0x18074A6F0")]
				private void _PlayAnimation()
				{
				}

				// Token: 0x0600FBD3 RID: 64467 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBD3")]
				[Address(RVA = "0x74AA10", Offset = "0x749610", VA = "0x18074AA10")]
				public LevitateState()
				{
				}

				// Token: 0x040117E2 RID: 71650
				[Token(Token = "0x40117E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static float RAISE_HEIGHT_OFFSET;

				// Token: 0x040117E3 RID: 71651
				[Token(Token = "0x40117E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				private static float RAISE_SHAKE_DEFAULT_TIME;

				// Token: 0x040117E4 RID: 71652
				[Token(Token = "0x40117E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static float SHAKE_DELAY_TIME;

				// Token: 0x040117E5 RID: 71653
				[Token(Token = "0x40117E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				private static Vector3 SHAKE_STRENGTH;

				// Token: 0x040117E6 RID: 71654
				[Token(Token = "0x40117E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Tween m_tween;

				// Token: 0x040117E7 RID: 71655
				[Token(Token = "0x40117E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Vector3 m_beforePos;

				// Token: 0x040117E8 RID: 71656
				[Token(Token = "0x40117E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x040117E9 RID: 71657
				[Token(Token = "0x40117E9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x040117EA RID: 71658
				[Token(Token = "0x40117EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x040117EB RID: 71659
				[Token(Token = "0x40117EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x040117EC RID: 71660
				[Token(Token = "0x40117EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x040117ED RID: 71661
				[Token(Token = "0x40117ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x040117EE RID: 71662
				[Token(Token = "0x40117EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x040117EF RID: 71663
				[Token(Token = "0x40117EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117F0 RID: 71664
				[Token(Token = "0x40117F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x040117F1 RID: 71665
				[Token(Token = "0x40117F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040117F2 RID: 71666
				[Token(Token = "0x40117F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x040117F3 RID: 71667
				[Token(Token = "0x40117F3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x040117F4 RID: 71668
				[Token(Token = "0x40117F4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025D7 RID: 9687
			[Token(Token = "0x20025D7")]
			private class UnbalanceState : Enemy.States.BasicState, Attributes.IAttributesModifier, IPhysicObject
			{
				// Token: 0x17002196 RID: 8598
				// (get) Token: 0x0600FBD5 RID: 64469 RVA: 0x0005F010 File Offset: 0x0005D210
				[Token(Token = "0x17002196")]
				public long attributeMask
				{
					[Token(Token = "0x600FBD5")]
					[Address(RVA = "0x753320", Offset = "0x751F20", VA = "0x180753320", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002197 RID: 8599
				// (get) Token: 0x0600FBD6 RID: 64470 RVA: 0x0005F028 File Offset: 0x0005D228
				[Token(Token = "0x17002197")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600FBD6")]
					[Address(RVA = "0x753260", Offset = "0x751E60", VA = "0x180753260", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002198 RID: 8600
				// (get) Token: 0x0600FBD7 RID: 64471 RVA: 0x0005F040 File Offset: 0x0005D240
				[Token(Token = "0x17002198")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600FBD7")]
					[Address(RVA = "0x7532C0", Offset = "0x751EC0", VA = "0x1807532C0", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17002199 RID: 8601
				// (get) Token: 0x0600FBD8 RID: 64472 RVA: 0x0005F058 File Offset: 0x0005D258
				[Token(Token = "0x17002199")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600FBD8")]
					[Address(RVA = "0x753140", Offset = "0x751D40", VA = "0x180753140", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700219A RID: 8602
				// (get) Token: 0x0600FBD9 RID: 64473 RVA: 0x0005F070 File Offset: 0x0005D270
				[Token(Token = "0x1700219A")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600FBD9")]
					[Address(RVA = "0x753200", Offset = "0x751E00", VA = "0x180753200", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700219B RID: 8603
				// (get) Token: 0x0600FBDA RID: 64474 RVA: 0x0005F088 File Offset: 0x0005D288
				[Token(Token = "0x1700219B")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600FBDA")]
					[Address(RVA = "0x7531A0", Offset = "0x751DA0", VA = "0x1807531A0", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FBDB RID: 64475 RVA: 0x0005F0A0 File Offset: 0x0005D2A0
				[Token(Token = "0x600FBDB")]
				[Address(RVA = "0x751B00", Offset = "0x750700", VA = "0x180751B00", Slot = "20")]
				public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600FBDC RID: 64476 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBDC")]
				[Address(RVA = "0x751CB0", Offset = "0x7508B0", VA = "0x180751CB0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FBDD RID: 64477 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBDD")]
				[Address(RVA = "0x752080", Offset = "0x750C80", VA = "0x180752080", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FBDE RID: 64478 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBDE")]
				[Address(RVA = "0x752380", Offset = "0x750F80", VA = "0x180752380", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FBDF RID: 64479 RVA: 0x0005F0B8 File Offset: 0x0005D2B8
				[Token(Token = "0x600FBDF")]
				[Address(RVA = "0x7527C0", Offset = "0x7513C0", VA = "0x1807527C0")]
				private bool _CheckCollideWithHighLand(Enemy enemy, float scopeOffset)
				{
					return default(bool);
				}

				// Token: 0x0600FBE0 RID: 64480 RVA: 0x0005F0D0 File Offset: 0x0005D2D0
				[Token(Token = "0x600FBE0")]
				[Address(RVA = "0x752C60", Offset = "0x751860", VA = "0x180752C60")]
				private bool _UpdateFriction(float deltaTime)
				{
					return default(bool);
				}

				// Token: 0x0600FBE1 RID: 64481 RVA: 0x0005F0E8 File Offset: 0x0005D2E8
				[Token(Token = "0x600FBE1")]
				[Address(RVA = "0x752FD0", Offset = "0x751BD0", VA = "0x180752FD0")]
				private bool _UpdatePullSources()
				{
					return default(bool);
				}

				// Token: 0x0600FBE2 RID: 64482 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBE2")]
				[Address(RVA = "0x752260", Offset = "0x750E60", VA = "0x180752260", Slot = "21")]
				public void OnPhysicObjectInit()
				{
				}

				// Token: 0x0600FBE3 RID: 64483 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBE3")]
				[Address(RVA = "0x751BE0", Offset = "0x7507E0", VA = "0x180751BE0", Slot = "23")]
				public void OnAfterPhysicSimulate(float deltaTimeAsFloat)
				{
				}

				// Token: 0x0600FBE4 RID: 64484 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBE4")]
				[Address(RVA = "0x7522F0", Offset = "0x750EF0", VA = "0x1807522F0", Slot = "22")]
				public void OnPhysicObjectRecycle()
				{
				}

				// Token: 0x0600FBE5 RID: 64485 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBE5")]
				[Address(RVA = "0x753090", Offset = "0x751C90", VA = "0x180753090")]
				public UnbalanceState()
				{
				}

				// Token: 0x040117F5 RID: 71669
				[Token(Token = "0x40117F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private HashSet<GridPosition> m_mapValidGrids;

				// Token: 0x040117F6 RID: 71670
				[Token(Token = "0x40117F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x040117F7 RID: 71671
				[Token(Token = "0x40117F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x040117F8 RID: 71672
				[Token(Token = "0x40117F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x040117F9 RID: 71673
				[Token(Token = "0x40117F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x040117FA RID: 71674
				[Token(Token = "0x40117FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x040117FB RID: 71675
				[Token(Token = "0x40117FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x040117FC RID: 71676
				[Token(Token = "0x40117FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x040117FD RID: 71677
				[Token(Token = "0x40117FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x040117FE RID: 71678
				[Token(Token = "0x40117FE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x040117FF RID: 71679
				[Token(Token = "0x40117FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x04011800 RID: 71680
				[Token(Token = "0x4011800")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0__CheckCollideWithHighLand;

				// Token: 0x04011801 RID: 71681
				[Token(Token = "0x4011801")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0__UpdateFriction;

				// Token: 0x04011802 RID: 71682
				[Token(Token = "0x4011802")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0__UpdatePullSources;

				// Token: 0x04011803 RID: 71683
				[Token(Token = "0x4011803")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_OnPhysicObjectInit;

				// Token: 0x04011804 RID: 71684
				[Token(Token = "0x4011804")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_OnAfterPhysicSimulate;

				// Token: 0x04011805 RID: 71685
				[Token(Token = "0x4011805")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0_OnPhysicObjectRecycle;

				// Token: 0x04011806 RID: 71686
				[Token(Token = "0x4011806")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025D8 RID: 9688
			[Token(Token = "0x20025D8")]
			private class FallDownState : Enemy.States.BasicState
			{
				// Token: 0x0600FBE6 RID: 64486 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBE6")]
				[Address(RVA = "0x7447C0", Offset = "0x7433C0", VA = "0x1807447C0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FBE7 RID: 64487 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBE7")]
				[Address(RVA = "0x744900", Offset = "0x743500", VA = "0x180744900", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FBE8 RID: 64488 RVA: 0x0005F100 File Offset: 0x0005D300
				[Token(Token = "0x600FBE8")]
				[Address(RVA = "0x744750", Offset = "0x743350", VA = "0x180744750", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FBE9 RID: 64489 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBE9")]
				[Address(RVA = "0x7449D0", Offset = "0x7435D0", VA = "0x1807449D0")]
				private void _PlayAnimation()
				{
				}

				// Token: 0x0600FBEA RID: 64490 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBEA")]
				[Address(RVA = "0x745100", Offset = "0x743D00", VA = "0x180745100")]
				public FallDownState()
				{
				}

				// Token: 0x04011807 RID: 71687
				[Token(Token = "0x4011807")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private float FALLDOWN_TIME;

				// Token: 0x04011808 RID: 71688
				[Token(Token = "0x4011808")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private float FALLDOWN_HEIGHT_OFFSET;

				// Token: 0x04011809 RID: 71689
				[Token(Token = "0x4011809")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private float FALLDOWN_SHRINK_SCALE;

				// Token: 0x0401180A RID: 71690
				[Token(Token = "0x401180A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Tween m_tween;

				// Token: 0x0401180B RID: 71691
				[Token(Token = "0x401180B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x0401180C RID: 71692
				[Token(Token = "0x401180C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x0401180D RID: 71693
				[Token(Token = "0x401180D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x0401180E RID: 71694
				[Token(Token = "0x401180E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x0401180F RID: 71695
				[Token(Token = "0x401180F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025DB RID: 9691
			[Token(Token = "0x20025DB")]
			private class DisappearState : Enemy.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x1700219C RID: 8604
				// (get) Token: 0x0600FBF4 RID: 64500 RVA: 0x0005F160 File Offset: 0x0005D360
				[Token(Token = "0x1700219C")]
				public long attributeMask
				{
					[Token(Token = "0x600FBF4")]
					[Address(RVA = "0x741B90", Offset = "0x740790", VA = "0x180741B90", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700219D RID: 8605
				// (get) Token: 0x0600FBF5 RID: 64501 RVA: 0x0005F178 File Offset: 0x0005D378
				[Token(Token = "0x1700219D")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600FBF5")]
					[Address(RVA = "0x741AD0", Offset = "0x7406D0", VA = "0x180741AD0", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700219E RID: 8606
				// (get) Token: 0x0600FBF6 RID: 64502 RVA: 0x0005F190 File Offset: 0x0005D390
				[Token(Token = "0x1700219E")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600FBF6")]
					[Address(RVA = "0x741B30", Offset = "0x740730", VA = "0x180741B30", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x1700219F RID: 8607
				// (get) Token: 0x0600FBF7 RID: 64503 RVA: 0x0005F1A8 File Offset: 0x0005D3A8
				[Token(Token = "0x1700219F")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600FBF7")]
					[Address(RVA = "0x7419B0", Offset = "0x7405B0", VA = "0x1807419B0", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021A0 RID: 8608
				// (get) Token: 0x0600FBF8 RID: 64504 RVA: 0x0005F1C0 File Offset: 0x0005D3C0
				[Token(Token = "0x170021A0")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600FBF8")]
					[Address(RVA = "0x741A70", Offset = "0x740670", VA = "0x180741A70", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021A1 RID: 8609
				// (get) Token: 0x0600FBF9 RID: 64505 RVA: 0x0005F1D8 File Offset: 0x0005D3D8
				[Token(Token = "0x170021A1")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600FBF9")]
					[Address(RVA = "0x741A10", Offset = "0x740610", VA = "0x180741A10", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FBFA RID: 64506 RVA: 0x0005F1F0 File Offset: 0x0005D3F0
				[Token(Token = "0x600FBFA")]
				[Address(RVA = "0x740C70", Offset = "0x73F870", VA = "0x180740C70", Slot = "20")]
				public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600FBFB RID: 64507 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBFB")]
				[Address(RVA = "0x740D50", Offset = "0x73F950", VA = "0x180740D50", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FBFC RID: 64508 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBFC")]
				[Address(RVA = "0x740F10", Offset = "0x73FB10", VA = "0x180740F10", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FBFD RID: 64509 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBFD")]
				[Address(RVA = "0x7410A0", Offset = "0x73FCA0", VA = "0x1807410A0", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FBFE RID: 64510 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600FBFE")]
				[Address(RVA = "0x741730", Offset = "0x740330", VA = "0x180741730")]
				private IEnumerator _DoDisappear()
				{
					return null;
				}

				// Token: 0x0600FBFF RID: 64511 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FBFF")]
				[Address(RVA = "0x741170", Offset = "0x73FD70", VA = "0x180741170")]
				private void _DoAppear()
				{
				}

				// Token: 0x0600FC00 RID: 64512 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC00")]
				[Address(RVA = "0x7417E0", Offset = "0x7403E0", VA = "0x1807417E0")]
				private void _InterruptDisappearTweenIfNot()
				{
				}

				// Token: 0x0600FC01 RID: 64513 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC01")]
				[Address(RVA = "0x741900", Offset = "0x740500", VA = "0x180741900")]
				public DisappearState()
				{
				}

				// Token: 0x0401181A RID: 71706
				[Token(Token = "0x401181A")]
				private const float DISAPPEAR_TIME = 0.3f;

				// Token: 0x0401181B RID: 71707
				[Token(Token = "0x401181B")]
				private const float APPEAR_TIME = 0.3f;

				// Token: 0x0401181C RID: 71708
				[Token(Token = "0x401181C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private CoroutineId m_coroutine;

				// Token: 0x0401181D RID: 71709
				[Token(Token = "0x401181D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private bool m_originalColliderEnable;

				// Token: 0x0401181E RID: 71710
				[Token(Token = "0x401181E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private Tween m_disappearTween;

				// Token: 0x0401181F RID: 71711
				[Token(Token = "0x401181F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x04011820 RID: 71712
				[Token(Token = "0x4011820")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x04011821 RID: 71713
				[Token(Token = "0x4011821")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x04011822 RID: 71714
				[Token(Token = "0x4011822")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x04011823 RID: 71715
				[Token(Token = "0x4011823")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x04011824 RID: 71716
				[Token(Token = "0x4011824")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x04011825 RID: 71717
				[Token(Token = "0x4011825")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x04011826 RID: 71718
				[Token(Token = "0x4011826")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x04011827 RID: 71719
				[Token(Token = "0x4011827")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x04011828 RID: 71720
				[Token(Token = "0x4011828")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x04011829 RID: 71721
				[Token(Token = "0x4011829")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0__DoDisappear;

				// Token: 0x0401182A RID: 71722
				[Token(Token = "0x401182A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0__DoAppear;

				// Token: 0x0401182B RID: 71723
				[Token(Token = "0x401182B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0__InterruptDisappearTweenIfNot;

				// Token: 0x0401182C RID: 71724
				[Token(Token = "0x401182C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025E0 RID: 9696
			[Token(Token = "0x20025E0")]
			public class BlinkState : Enemy.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x170021A4 RID: 8612
				// (get) Token: 0x0600FC14 RID: 64532 RVA: 0x0005F280 File Offset: 0x0005D480
				[Token(Token = "0x170021A4")]
				public long attributeMask
				{
					[Token(Token = "0x600FC14")]
					[Address(RVA = "0x73C150", Offset = "0x73AD50", VA = "0x18073C150", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021A5 RID: 8613
				// (get) Token: 0x0600FC15 RID: 64533 RVA: 0x0005F298 File Offset: 0x0005D498
				[Token(Token = "0x170021A5")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600FC15")]
					[Address(RVA = "0x73C090", Offset = "0x73AC90", VA = "0x18073C090", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021A6 RID: 8614
				// (get) Token: 0x0600FC16 RID: 64534 RVA: 0x0005F2B0 File Offset: 0x0005D4B0
				[Token(Token = "0x170021A6")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600FC16")]
					[Address(RVA = "0x73C0F0", Offset = "0x73ACF0", VA = "0x18073C0F0", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021A7 RID: 8615
				// (get) Token: 0x0600FC17 RID: 64535 RVA: 0x0005F2C8 File Offset: 0x0005D4C8
				[Token(Token = "0x170021A7")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600FC17")]
					[Address(RVA = "0x73BF70", Offset = "0x73AB70", VA = "0x18073BF70", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021A8 RID: 8616
				// (get) Token: 0x0600FC18 RID: 64536 RVA: 0x0005F2E0 File Offset: 0x0005D4E0
				[Token(Token = "0x170021A8")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600FC18")]
					[Address(RVA = "0x73C030", Offset = "0x73AC30", VA = "0x18073C030", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021A9 RID: 8617
				// (get) Token: 0x0600FC19 RID: 64537 RVA: 0x0005F2F8 File Offset: 0x0005D4F8
				[Token(Token = "0x170021A9")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600FC19")]
					[Address(RVA = "0x73BFD0", Offset = "0x73ABD0", VA = "0x18073BFD0", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FC1A RID: 64538 RVA: 0x0005F310 File Offset: 0x0005D510
				[Token(Token = "0x600FC1A")]
				[Address(RVA = "0x73B9B0", Offset = "0x73A5B0", VA = "0x18073B9B0", Slot = "20")]
				public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600FC1B RID: 64539 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC1B")]
				[Address(RVA = "0x73BA90", Offset = "0x73A690", VA = "0x18073BA90", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FC1C RID: 64540 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC1C")]
				[Address(RVA = "0x73BC50", Offset = "0x73A850", VA = "0x18073BC50", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FC1D RID: 64541 RVA: 0x0005F328 File Offset: 0x0005D528
				[Token(Token = "0x600FC1D")]
				[Address(RVA = "0x73B930", Offset = "0x73A530", VA = "0x18073B930", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FC1E RID: 64542 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600FC1E")]
				[Address(RVA = "0x73BE10", Offset = "0x73AA10", VA = "0x18073BE10")]
				private IEnumerator _PlayAnimation()
				{
					return null;
				}

				// Token: 0x0600FC1F RID: 64543 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC1F")]
				[Address(RVA = "0x73BEC0", Offset = "0x73AAC0", VA = "0x18073BEC0")]
				public BlinkState()
				{
				}

				// Token: 0x04011839 RID: 71737
				[Token(Token = "0x4011839")]
				private const float BLINK_BEGIN_TIME = 0.25f;

				// Token: 0x0401183A RID: 71738
				[Token(Token = "0x401183A")]
				private const float BLINK_END_TIME = 0.25f;

				// Token: 0x0401183B RID: 71739
				[Token(Token = "0x401183B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private CoroutineId m_coroutine;

				// Token: 0x0401183C RID: 71740
				[Token(Token = "0x401183C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x0401183D RID: 71741
				[Token(Token = "0x401183D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x0401183E RID: 71742
				[Token(Token = "0x401183E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x0401183F RID: 71743
				[Token(Token = "0x401183F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x04011840 RID: 71744
				[Token(Token = "0x4011840")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x04011841 RID: 71745
				[Token(Token = "0x4011841")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x04011842 RID: 71746
				[Token(Token = "0x4011842")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x04011843 RID: 71747
				[Token(Token = "0x4011843")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x04011844 RID: 71748
				[Token(Token = "0x4011844")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x04011845 RID: 71749
				[Token(Token = "0x4011845")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x04011846 RID: 71750
				[Token(Token = "0x4011846")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x04011847 RID: 71751
				[Token(Token = "0x4011847")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025E2 RID: 9698
			[Token(Token = "0x20025E2")]
			private class RebornState : Enemy.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x170021AC RID: 8620
				// (get) Token: 0x0600FC26 RID: 64550 RVA: 0x0005F358 File Offset: 0x0005D558
				[Token(Token = "0x170021AC")]
				public long attributeMask
				{
					[Token(Token = "0x600FC26")]
					[Address(RVA = "0x74E570", Offset = "0x74D170", VA = "0x18074E570", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021AD RID: 8621
				// (get) Token: 0x0600FC27 RID: 64551 RVA: 0x0005F370 File Offset: 0x0005D570
				[Token(Token = "0x170021AD")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600FC27")]
					[Address(RVA = "0x74E4B0", Offset = "0x74D0B0", VA = "0x18074E4B0", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021AE RID: 8622
				// (get) Token: 0x0600FC28 RID: 64552 RVA: 0x0005F388 File Offset: 0x0005D588
				[Token(Token = "0x170021AE")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600FC28")]
					[Address(RVA = "0x74E510", Offset = "0x74D110", VA = "0x18074E510", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021AF RID: 8623
				// (get) Token: 0x0600FC29 RID: 64553 RVA: 0x0005F3A0 File Offset: 0x0005D5A0
				[Token(Token = "0x170021AF")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600FC29")]
					[Address(RVA = "0x74E390", Offset = "0x74CF90", VA = "0x18074E390", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021B0 RID: 8624
				// (get) Token: 0x0600FC2A RID: 64554 RVA: 0x0005F3B8 File Offset: 0x0005D5B8
				[Token(Token = "0x170021B0")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600FC2A")]
					[Address(RVA = "0x74E450", Offset = "0x74D050", VA = "0x18074E450", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021B1 RID: 8625
				// (get) Token: 0x0600FC2B RID: 64555 RVA: 0x0005F3D0 File Offset: 0x0005D5D0
				[Token(Token = "0x170021B1")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600FC2B")]
					[Address(RVA = "0x74E3F0", Offset = "0x74CFF0", VA = "0x18074E3F0", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FC2C RID: 64556 RVA: 0x0005F3E8 File Offset: 0x0005D5E8
				[Token(Token = "0x600FC2C")]
				[Address(RVA = "0x74D000", Offset = "0x74BC00", VA = "0x18074D000", Slot = "20")]
				public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600FC2D RID: 64557 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC2D")]
				[Address(RVA = "0x74D0E0", Offset = "0x74BCE0", VA = "0x18074D0E0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FC2E RID: 64558 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC2E")]
				[Address(RVA = "0x74D900", Offset = "0x74C500", VA = "0x18074D900", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FC2F RID: 64559 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC2F")]
				[Address(RVA = "0x74D690", Offset = "0x74C290", VA = "0x18074D690", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FC30 RID: 64560 RVA: 0x0005F400 File Offset: 0x0005D600
				[Token(Token = "0x600FC30")]
				[Address(RVA = "0x74CF10", Offset = "0x74BB10", VA = "0x18074CF10", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600FC31 RID: 64561 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC31")]
				[Address(RVA = "0x74DC00", Offset = "0x74C800", VA = "0x18074DC00")]
				private void _CheckRemainingTime(FP deltaTime)
				{
				}

				// Token: 0x0600FC32 RID: 64562 RVA: 0x0005F418 File Offset: 0x0005D618
				[Token(Token = "0x600FC32")]
				[Address(RVA = "0x74DDD0", Offset = "0x74C9D0", VA = "0x18074DDD0")]
				private float _PlayAnimation()
				{
					return 0f;
				}

				// Token: 0x0600FC33 RID: 64563 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC33")]
				[Address(RVA = "0x74E2E0", Offset = "0x74CEE0", VA = "0x18074E2E0")]
				public RebornState()
				{
				}

				// Token: 0x0401184B RID: 71755
				[Token(Token = "0x401184B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_remainingTime;

				// Token: 0x0401184C RID: 71756
				[Token(Token = "0x401184C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Unit.RebornData m_data;

				// Token: 0x0401184D RID: 71757
				[Token(Token = "0x401184D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private ITweenHandler m_tween;

				// Token: 0x0401184E RID: 71758
				[Token(Token = "0x401184E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private bool m_rebornAfterWave;

				// Token: 0x0401184F RID: 71759
				[Token(Token = "0x401184F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
				private int m_rebornAfterWaveCnt;

				// Token: 0x04011850 RID: 71760
				[Token(Token = "0x4011850")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private int m_currentWaveCnt;

				// Token: 0x04011851 RID: 71761
				[Token(Token = "0x4011851")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private List<Effect> m_effectList;

				// Token: 0x04011852 RID: 71762
				[Token(Token = "0x4011852")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private FP m_recoverStartHp;

				// Token: 0x04011853 RID: 71763
				[Token(Token = "0x4011853")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x04011854 RID: 71764
				[Token(Token = "0x4011854")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x04011855 RID: 71765
				[Token(Token = "0x4011855")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x04011856 RID: 71766
				[Token(Token = "0x4011856")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x04011857 RID: 71767
				[Token(Token = "0x4011857")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x04011858 RID: 71768
				[Token(Token = "0x4011858")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x04011859 RID: 71769
				[Token(Token = "0x4011859")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x0401185A RID: 71770
				[Token(Token = "0x401185A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x0401185B RID: 71771
				[Token(Token = "0x401185B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x0401185C RID: 71772
				[Token(Token = "0x401185C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x0401185D RID: 71773
				[Token(Token = "0x401185D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_CheckSwitchOut;

				// Token: 0x0401185E RID: 71774
				[Token(Token = "0x401185E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0__CheckRemainingTime;

				// Token: 0x0401185F RID: 71775
				[Token(Token = "0x401185F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0__PlayAnimation;

				// Token: 0x04011860 RID: 71776
				[Token(Token = "0x4011860")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020025E3 RID: 9699
			[Token(Token = "0x20025E3")]
			private class DialogState : Enemy.States.BasicState, Attributes.IAttributesModifier
			{
				// Token: 0x170021B2 RID: 8626
				// (get) Token: 0x0600FC37 RID: 64567 RVA: 0x0005F448 File Offset: 0x0005D648
				[Token(Token = "0x170021B2")]
				public long attributeMask
				{
					[Token(Token = "0x600FC37")]
					[Address(RVA = "0x740AD0", Offset = "0x73F6D0", VA = "0x180740AD0", Slot = "14")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021B3 RID: 8627
				// (get) Token: 0x0600FC38 RID: 64568 RVA: 0x0005F460 File Offset: 0x0005D660
				[Token(Token = "0x170021B3")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600FC38")]
					[Address(RVA = "0x740A10", Offset = "0x73F610", VA = "0x180740A10", Slot = "15")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021B4 RID: 8628
				// (get) Token: 0x0600FC39 RID: 64569 RVA: 0x0005F478 File Offset: 0x0005D678
				[Token(Token = "0x170021B4")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600FC39")]
					[Address(RVA = "0x740A70", Offset = "0x73F670", VA = "0x180740A70", Slot = "16")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021B5 RID: 8629
				// (get) Token: 0x0600FC3A RID: 64570 RVA: 0x0005F490 File Offset: 0x0005D690
				[Token(Token = "0x170021B5")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600FC3A")]
					[Address(RVA = "0x7408F0", Offset = "0x73F4F0", VA = "0x1807408F0", Slot = "17")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021B6 RID: 8630
				// (get) Token: 0x0600FC3B RID: 64571 RVA: 0x0005F4A8 File Offset: 0x0005D6A8
				[Token(Token = "0x170021B6")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600FC3B")]
					[Address(RVA = "0x7409B0", Offset = "0x73F5B0", VA = "0x1807409B0", Slot = "18")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x170021B7 RID: 8631
				// (get) Token: 0x0600FC3C RID: 64572 RVA: 0x0005F4C0 File Offset: 0x0005D6C0
				[Token(Token = "0x170021B7")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600FC3C")]
					[Address(RVA = "0x740950", Offset = "0x73F550", VA = "0x180740950", Slot = "19")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600FC3D RID: 64573 RVA: 0x0005F4D8 File Offset: 0x0005D6D8
				[Token(Token = "0x600FC3D")]
				[Address(RVA = "0x73FBB0", Offset = "0x73E7B0", VA = "0x18073FBB0", Slot = "20")]
				public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x170021B8 RID: 8632
				// (get) Token: 0x0600FC3E RID: 64574 RVA: 0x0005F4F0 File Offset: 0x0005D6F0
				// (set) Token: 0x0600FC3F RID: 64575 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x170021B8")]
				private bool isHanging
				{
					[Token(Token = "0x600FC3E")]
					[Address(RVA = "0x740B30", Offset = "0x73F730", VA = "0x180740B30")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x600FC3F")]
					[Address(RVA = "0x740BB0", Offset = "0x73F7B0", VA = "0x180740BB0")]
					set
					{
					}
				}

				// Token: 0x0600FC40 RID: 64576 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC40")]
				[Address(RVA = "0x73FC90", Offset = "0x73E890", VA = "0x18073FC90", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600FC41 RID: 64577 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC41")]
				[Address(RVA = "0x7400E0", Offset = "0x73ECE0", VA = "0x1807400E0", Slot = "12")]
				public override void OnTick(FP deltaTime)
				{
				}

				// Token: 0x0600FC42 RID: 64578 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC42")]
				[Address(RVA = "0x73FF70", Offset = "0x73EB70", VA = "0x18073FF70", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600FC43 RID: 64579 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC43")]
				[Address(RVA = "0x7402F0", Offset = "0x73EEF0", VA = "0x1807402F0")]
				public void UpdateMoveAnimation()
				{
				}

				// Token: 0x0600FC44 RID: 64580 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC44")]
				[Address(RVA = "0x740460", Offset = "0x73F060", VA = "0x180740460")]
				private void _PlayAnim(object param)
				{
				}

				// Token: 0x0600FC45 RID: 64581 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600FC45")]
				[Address(RVA = "0x740810", Offset = "0x73F410", VA = "0x180740810")]
				public DialogState()
				{
				}

				// Token: 0x04011861 RID: 71777
				[Token(Token = "0x4011861")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_remainingEscapeTime;

				// Token: 0x04011862 RID: 71778
				[Token(Token = "0x4011862")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Entity.AnimBundle m_lastPlayedBundle;

				// Token: 0x04011863 RID: 71779
				[Token(Token = "0x4011863")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x04011864 RID: 71780
				[Token(Token = "0x4011864")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x04011865 RID: 71781
				[Token(Token = "0x4011865")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x04011866 RID: 71782
				[Token(Token = "0x4011866")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x04011867 RID: 71783
				[Token(Token = "0x4011867")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x04011868 RID: 71784
				[Token(Token = "0x4011868")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x04011869 RID: 71785
				[Token(Token = "0x4011869")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x0401186A RID: 71786
				[Token(Token = "0x401186A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_get_isHanging;

				// Token: 0x0401186B RID: 71787
				[Token(Token = "0x401186B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_set_isHanging;

				// Token: 0x0401186C RID: 71788
				[Token(Token = "0x401186C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_OnEnter;

				// Token: 0x0401186D RID: 71789
				[Token(Token = "0x401186D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x0401186E RID: 71790
				[Token(Token = "0x401186E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_OnExit;

				// Token: 0x0401186F RID: 71791
				[Token(Token = "0x401186F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_UpdateMoveAnimation;

				// Token: 0x04011870 RID: 71792
				[Token(Token = "0x4011870")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0__PlayAnim;

				// Token: 0x04011871 RID: 71793
				[Token(Token = "0x4011871")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x020025E4 RID: 9700
		[Token(Token = "0x20025E4")]
		public class AttackWrapper : IHotfixable
		{
			// Token: 0x170021B9 RID: 8633
			// (get) Token: 0x0600FC46 RID: 64582 RVA: 0x0005F508 File Offset: 0x0005D708
			[Token(Token = "0x170021B9")]
			public bool isValid
			{
				[Token(Token = "0x600FC46")]
				[Address(RVA = "0x73A8D0", Offset = "0x7394D0", VA = "0x18073A8D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170021BA RID: 8634
			// (get) Token: 0x0600FC47 RID: 64583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021BA")]
			protected Ability mainAttack
			{
				[Token(Token = "0x600FC47")]
				[Address(RVA = "0x73AA10", Offset = "0x739610", VA = "0x18073AA10")]
				get
				{
					return null;
				}
			}

			// Token: 0x170021BB RID: 8635
			// (get) Token: 0x0600FC48 RID: 64584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021BB")]
			protected TargetTrigger mainTrigger
			{
				[Token(Token = "0x600FC48")]
				[Address(RVA = "0x73AAA0", Offset = "0x7396A0", VA = "0x18073AAA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170021BC RID: 8636
			// (get) Token: 0x0600FC49 RID: 64585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021BC")]
			protected List<EnemySkill> skills
			{
				[Token(Token = "0x600FC49")]
				[Address(RVA = "0x73AB30", Offset = "0x739730", VA = "0x18073AB30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170021BD RID: 8637
			// (get) Token: 0x0600FC4A RID: 64586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021BD")]
			public Ability lastAbility
			{
				[Token(Token = "0x600FC4A")]
				[Address(RVA = "0x73A950", Offset = "0x739550", VA = "0x18073A950")]
				get
				{
					return null;
				}
			}

			// Token: 0x170021BE RID: 8638
			// (get) Token: 0x0600FC4B RID: 64587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021BE")]
			public EnemySkill lastSkill
			{
				[Token(Token = "0x600FC4B")]
				[Address(RVA = "0x73A9B0", Offset = "0x7395B0", VA = "0x18073A9B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600FC4C RID: 64588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC4C")]
			[Address(RVA = "0x739E10", Offset = "0x738A10", VA = "0x180739E10")]
			public void Reset()
			{
			}

			// Token: 0x0600FC4D RID: 64589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC4D")]
			[Address(RVA = "0x73A850", Offset = "0x739450", VA = "0x18073A850")]
			public AttackWrapper(Enemy enemy)
			{
			}

			// Token: 0x0600FC4E RID: 64590 RVA: 0x0005F520 File Offset: 0x0005D720
			[Token(Token = "0x600FC4E")]
			[Address(RVA = "0x739E90", Offset = "0x738A90", VA = "0x180739E90")]
			public bool SearchTarget()
			{
				return default(bool);
			}

			// Token: 0x0600FC4F RID: 64591 RVA: 0x0005F538 File Offset: 0x0005D738
			[Token(Token = "0x600FC4F")]
			[Address(RVA = "0x739A50", Offset = "0x738650", VA = "0x180739A50")]
			public bool Cast(out Ability ability, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
			{
				return default(bool);
			}

			// Token: 0x0600FC50 RID: 64592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC50")]
			[Address(RVA = "0x73A700", Offset = "0x739300", VA = "0x18073A700")]
			private void _OnCastFinish(Ability ability, Ability.FinishReason reason, bool resetCd)
			{
			}

			// Token: 0x0600FC51 RID: 64593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC51")]
			[Address(RVA = "0x739990", Offset = "0x738590", VA = "0x180739990")]
			public void AssignAbility(Ability ability, Entity target, EnemySkill skill)
			{
			}

			// Token: 0x0600FC52 RID: 64594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600FC52")]
			[Address(RVA = "0x73A5B0", Offset = "0x7391B0", VA = "0x18073A5B0")]
			public EnemySkill TryGetFirstAttachedSkill(string skillName)
			{
				return null;
			}

			// Token: 0x04011872 RID: 71794
			[Token(Token = "0x4011872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Enemy m_enemy;

			// Token: 0x04011873 RID: 71795
			[Token(Token = "0x4011873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Entity m_curTarget;

			// Token: 0x04011874 RID: 71796
			[Token(Token = "0x4011874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private EnemySkill m_curSkill;

			// Token: 0x04011875 RID: 71797
			[Token(Token = "0x4011875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Ability m_curAbility;

			// Token: 0x04011876 RID: 71798
			[Token(Token = "0x4011876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Ability m_lastAbility;

			// Token: 0x04011877 RID: 71799
			[Token(Token = "0x4011877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private EnemySkill m_lastSkill;

			// Token: 0x04011878 RID: 71800
			[Token(Token = "0x4011878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isValid;

			// Token: 0x04011879 RID: 71801
			[Token(Token = "0x4011879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_mainAttack;

			// Token: 0x0401187A RID: 71802
			[Token(Token = "0x401187A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_mainTrigger;

			// Token: 0x0401187B RID: 71803
			[Token(Token = "0x401187B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_skills;

			// Token: 0x0401187C RID: 71804
			[Token(Token = "0x401187C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_lastAbility;

			// Token: 0x0401187D RID: 71805
			[Token(Token = "0x401187D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_lastSkill;

			// Token: 0x0401187E RID: 71806
			[Token(Token = "0x401187E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0401187F RID: 71807
			[Token(Token = "0x401187F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04011880 RID: 71808
			[Token(Token = "0x4011880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_SearchTarget;

			// Token: 0x04011881 RID: 71809
			[Token(Token = "0x4011881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Cast;

			// Token: 0x04011882 RID: 71810
			[Token(Token = "0x4011882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__OnCastFinish;

			// Token: 0x04011883 RID: 71811
			[Token(Token = "0x4011883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_AssignAbility;

			// Token: 0x04011884 RID: 71812
			[Token(Token = "0x4011884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_TryGetFirstAttachedSkill;
		}

		// Token: 0x020025E6 RID: 9702
		[Token(Token = "0x20025E6")]
		public class CombatWrapper : IHotfixable
		{
			// Token: 0x170021BF RID: 8639
			// (get) Token: 0x0600FC55 RID: 64597 RVA: 0x0005F568 File Offset: 0x0005D768
			[Token(Token = "0x170021BF")]
			public bool isValid
			{
				[Token(Token = "0x600FC55")]
				[Address(RVA = "0x73EDA0", Offset = "0x73D9A0", VA = "0x18073EDA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170021C0 RID: 8640
			// (get) Token: 0x0600FC56 RID: 64598 RVA: 0x0005F580 File Offset: 0x0005D780
			// (set) Token: 0x0600FC57 RID: 64599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170021C0")]
			public bool isCombatInterrupted
			{
				[Token(Token = "0x600FC56")]
				[Address(RVA = "0x73ED40", Offset = "0x73D940", VA = "0x18073ED40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600FC57")]
				[Address(RVA = "0x73F010", Offset = "0x73DC10", VA = "0x18073F010")]
				set
				{
				}
			}

			// Token: 0x0600FC58 RID: 64600 RVA: 0x0005F598 File Offset: 0x0005D798
			[Token(Token = "0x600FC58")]
			[Address(RVA = "0x73DEC0", Offset = "0x73CAC0", VA = "0x18073DEC0")]
			public bool PickCombatAbility()
			{
				return default(bool);
			}

			// Token: 0x170021C1 RID: 8641
			// (get) Token: 0x0600FC59 RID: 64601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021C1")]
			protected List<EnemySkill> skills
			{
				[Token(Token = "0x600FC59")]
				[Address(RVA = "0x73EFA0", Offset = "0x73DBA0", VA = "0x18073EFA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170021C2 RID: 8642
			// (get) Token: 0x0600FC5A RID: 64602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021C2")]
			public Ability mainCombat
			{
				[Token(Token = "0x600FC5A")]
				[Address(RVA = "0x73EF10", Offset = "0x73DB10", VA = "0x18073EF10")]
				get
				{
					return null;
				}
			}

			// Token: 0x170021C3 RID: 8643
			// (get) Token: 0x0600FC5B RID: 64603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021C3")]
			public Ability lastAbility
			{
				[Token(Token = "0x600FC5B")]
				[Address(RVA = "0x73EE50", Offset = "0x73DA50", VA = "0x18073EE50")]
				get
				{
					return null;
				}
			}

			// Token: 0x170021C4 RID: 8644
			// (get) Token: 0x0600FC5C RID: 64604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021C4")]
			public EnemySkill lastSkill
			{
				[Token(Token = "0x600FC5C")]
				[Address(RVA = "0x73EEB0", Offset = "0x73DAB0", VA = "0x18073EEB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600FC5D RID: 64605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC5D")]
			[Address(RVA = "0x73E020", Offset = "0x73CC20", VA = "0x18073E020")]
			public void Reset()
			{
			}

			// Token: 0x0600FC5E RID: 64606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC5E")]
			[Address(RVA = "0x73ECC0", Offset = "0x73D8C0", VA = "0x18073ECC0")]
			public CombatWrapper(Enemy enemy)
			{
			}

			// Token: 0x0600FC5F RID: 64607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600FC5F")]
			[Address(RVA = "0x73DC80", Offset = "0x73C880", VA = "0x18073DC80")]
			public Character GetTarget()
			{
				return null;
			}

			// Token: 0x0600FC60 RID: 64608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC60")]
			[Address(RVA = "0x73DCF0", Offset = "0x73C8F0", VA = "0x18073DCF0")]
			public void NextCombatOrExit(bool firstAttack)
			{
			}

			// Token: 0x0600FC61 RID: 64609 RVA: 0x0005F5B0 File Offset: 0x0005D7B0
			[Token(Token = "0x600FC61")]
			[Address(RVA = "0x73E0C0", Offset = "0x73CCC0", VA = "0x18073E0C0")]
			public bool StartCombat(bool firstAttack)
			{
				return default(bool);
			}

			// Token: 0x0600FC62 RID: 64610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC62")]
			[Address(RVA = "0x73DA40", Offset = "0x73C640", VA = "0x18073DA40")]
			private void CombatFinishCallback(Ability ability, Ability.FinishReason reason, bool resetCd)
			{
			}

			// Token: 0x0600FC63 RID: 64611 RVA: 0x0005F5C8 File Offset: 0x0005D7C8
			[Token(Token = "0x600FC63")]
			[Address(RVA = "0x73D810", Offset = "0x73C410", VA = "0x18073D810")]
			public bool CastToTarget(Entity target, out Ability ability, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
			{
				return default(bool);
			}

			// Token: 0x0600FC64 RID: 64612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC64")]
			[Address(RVA = "0x73D790", Offset = "0x73C390", VA = "0x18073D790")]
			public void AssignAbility(Ability ability)
			{
			}

			// Token: 0x0600FC65 RID: 64613 RVA: 0x0005F5E0 File Offset: 0x0005D7E0
			[Token(Token = "0x600FC65")]
			[Address(RVA = "0x73D940", Offset = "0x73C540", VA = "0x18073D940")]
			public bool CastWithAssignedSkill(Ability ability, Entity target, EnemySkill skill)
			{
				return default(bool);
			}

			// Token: 0x0600FC66 RID: 64614 RVA: 0x0005F5F8 File Offset: 0x0005D7F8
			[Token(Token = "0x600FC66")]
			[Address(RVA = "0x73E320", Offset = "0x73CF20", VA = "0x18073E320")]
			private bool _DoCast(Ability ability, Entity target, EnemySkill skill, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
			{
				return default(bool);
			}

			// Token: 0x0600FC67 RID: 64615 RVA: 0x0005F610 File Offset: 0x0005D810
			[Token(Token = "0x600FC67")]
			[Address(RVA = "0x73E5D0", Offset = "0x73D1D0", VA = "0x18073E5D0")]
			private bool _EarlyPickAbility()
			{
				return default(bool);
			}

			// Token: 0x0600FC68 RID: 64616 RVA: 0x0005F628 File Offset: 0x0005D828
			[Token(Token = "0x600FC68")]
			[Address(RVA = "0x73E7C0", Offset = "0x73D3C0", VA = "0x18073E7C0")]
			private bool _PickAbility(out Ability ability, out EnemySkill skill)
			{
				return default(bool);
			}

			// Token: 0x0600FC69 RID: 64617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC69")]
			[Address(RVA = "0x73E640", Offset = "0x73D240", VA = "0x18073E640")]
			private void _OnCastFinish(Ability ability, Ability.FinishReason reason, bool resetCd)
			{
			}

			// Token: 0x04011886 RID: 71814
			[Token(Token = "0x4011886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Enemy m_enemy;

			// Token: 0x04011887 RID: 71815
			[Token(Token = "0x4011887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Ability m_pickedAbility;

			// Token: 0x04011888 RID: 71816
			[Token(Token = "0x4011888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private EnemySkill m_pickedSkill;

			// Token: 0x04011889 RID: 71817
			[Token(Token = "0x4011889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool m_combatAbilityPicked;

			// Token: 0x0401188A RID: 71818
			[Token(Token = "0x401188A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			private bool m_isCombatInterrupted;

			// Token: 0x0401188B RID: 71819
			[Token(Token = "0x401188B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Ability m_lastAbility;

			// Token: 0x0401188C RID: 71820
			[Token(Token = "0x401188C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private EnemySkill m_lastSkill;

			// Token: 0x0401188D RID: 71821
			[Token(Token = "0x401188D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isValid;

			// Token: 0x0401188E RID: 71822
			[Token(Token = "0x401188E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isCombatInterrupted;

			// Token: 0x0401188F RID: 71823
			[Token(Token = "0x401188F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_isCombatInterrupted;

			// Token: 0x04011890 RID: 71824
			[Token(Token = "0x4011890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PickCombatAbility;

			// Token: 0x04011891 RID: 71825
			[Token(Token = "0x4011891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_skills;

			// Token: 0x04011892 RID: 71826
			[Token(Token = "0x4011892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_mainCombat;

			// Token: 0x04011893 RID: 71827
			[Token(Token = "0x4011893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_lastAbility;

			// Token: 0x04011894 RID: 71828
			[Token(Token = "0x4011894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_lastSkill;

			// Token: 0x04011895 RID: 71829
			[Token(Token = "0x4011895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x04011896 RID: 71830
			[Token(Token = "0x4011896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04011897 RID: 71831
			[Token(Token = "0x4011897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_GetTarget;

			// Token: 0x04011898 RID: 71832
			[Token(Token = "0x4011898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_NextCombatOrExit;

			// Token: 0x04011899 RID: 71833
			[Token(Token = "0x4011899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_StartCombat;

			// Token: 0x0401189A RID: 71834
			[Token(Token = "0x401189A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_CombatFinishCallback;

			// Token: 0x0401189B RID: 71835
			[Token(Token = "0x401189B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_CastToTarget;

			// Token: 0x0401189C RID: 71836
			[Token(Token = "0x401189C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_AssignAbility;

			// Token: 0x0401189D RID: 71837
			[Token(Token = "0x401189D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_CastWithAssignedSkill;

			// Token: 0x0401189E RID: 71838
			[Token(Token = "0x401189E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0__DoCast;

			// Token: 0x0401189F RID: 71839
			[Token(Token = "0x401189F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0__EarlyPickAbility;

			// Token: 0x040118A0 RID: 71840
			[Token(Token = "0x40118A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0__PickAbility;

			// Token: 0x040118A1 RID: 71841
			[Token(Token = "0x40118A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0__OnCastFinish;
		}

		// Token: 0x020025E7 RID: 9703
		[Token(Token = "0x20025E7")]
		public class FearController
		{
			// Token: 0x170021C5 RID: 8645
			// (get) Token: 0x0600FC6A RID: 64618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021C5")]
			public DirectionCursor fearCursor
			{
				[Token(Token = "0x600FC6A")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x170021C6 RID: 8646
			// (get) Token: 0x0600FC6B RID: 64619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021C6")]
			public ListDict<Buff, List<Tile>> fearBuffDict
			{
				[Token(Token = "0x600FC6B")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600FC6C RID: 64620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC6C")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			public void Reset(Enemy owner)
			{
			}

			// Token: 0x0600FC6D RID: 64621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC6D")]
			[Address(RVA = "0x7452B0", Offset = "0x743EB0", VA = "0x1807452B0")]
			public void OnInit()
			{
			}

			// Token: 0x0600FC6E RID: 64622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC6E")]
			[Address(RVA = "0x73AD30", Offset = "0x739930", VA = "0x18073AD30")]
			public void OnTick(FP deltaTime, bool checkReached)
			{
			}

			// Token: 0x0600FC6F RID: 64623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC6F")]
			[Address(RVA = "0x7451C0", Offset = "0x743DC0", VA = "0x1807451C0")]
			public void AddFearTargetTiles(Buff buff, List<Tile> targetTiles)
			{
			}

			// Token: 0x0600FC70 RID: 64624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC70")]
			[Address(RVA = "0x745390", Offset = "0x743F90", VA = "0x180745390")]
			public void RemoveFearTargetTiles(Buff buff)
			{
			}

			// Token: 0x0600FC71 RID: 64625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC71")]
			[Address(RVA = "0x745450", Offset = "0x744050", VA = "0x180745450")]
			public void UpdateFearCursor(bool force = false)
			{
			}

			// Token: 0x0600FC72 RID: 64626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600FC72")]
			[Address(RVA = "0x745780", Offset = "0x744380", VA = "0x180745780")]
			private RouteData _InitializeFearRouteData()
			{
				return null;
			}

			// Token: 0x0600FC73 RID: 64627 RVA: 0x0005F640 File Offset: 0x0005D840
			[Token(Token = "0x600FC73")]
			[Address(RVA = "0x745A80", Offset = "0x744680", VA = "0x180745A80")]
			private bool _TryGetFearRouteReachable(RouteData routeData, Buff currentBuff)
			{
				return default(bool);
			}

			// Token: 0x0600FC74 RID: 64628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC74")]
			[Address(RVA = "0x745D10", Offset = "0x744910", VA = "0x180745D10")]
			private void _UpdateFearRoute(RouteData routeData)
			{
			}

			// Token: 0x0600FC75 RID: 64629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC75")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FearController()
			{
			}

			// Token: 0x040118A2 RID: 71842
			[Token(Token = "0x40118A2")]
			private const float MAX_FEAR_MOVE_DISTANCE = 5f;

			// Token: 0x040118A3 RID: 71843
			[Token(Token = "0x40118A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Enemy m_owner;

			// Token: 0x040118A4 RID: 71844
			[Token(Token = "0x40118A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private ListDict<Buff, List<Tile>> m_fearBuffDict;

			// Token: 0x040118A5 RID: 71845
			[Token(Token = "0x40118A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private DirectionCursor m_fearCursor;

			// Token: 0x040118A6 RID: 71846
			[Token(Token = "0x40118A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Route m_fearRoute;
		}

		// Token: 0x020025E8 RID: 9704
		[Token(Token = "0x20025E8")]
		public class AttractController
		{
			// Token: 0x170021C7 RID: 8647
			// (get) Token: 0x0600FC76 RID: 64630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170021C7")]
			public DirectionCursor attractCursor
			{
				[Token(Token = "0x600FC76")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600FC77 RID: 64631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC77")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			public void Reset(Enemy owner)
			{
			}

			// Token: 0x0600FC78 RID: 64632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC78")]
			[Address(RVA = "0x73AC50", Offset = "0x739850", VA = "0x18073AC50")]
			public void OnInit()
			{
			}

			// Token: 0x0600FC79 RID: 64633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC79")]
			[Address(RVA = "0x73AD30", Offset = "0x739930", VA = "0x18073AD30")]
			public void OnTick(FP deltaTime, bool checkReached)
			{
			}

			// Token: 0x0600FC7A RID: 64634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC7A")]
			[Address(RVA = "0x73ABA0", Offset = "0x7397A0", VA = "0x18073ABA0")]
			public void AddTileAttract(Buff buff, Tile tile)
			{
			}

			// Token: 0x0600FC7B RID: 64635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC7B")]
			[Address(RVA = "0x73AEC0", Offset = "0x739AC0", VA = "0x18073AEC0")]
			public void UpdateAttractCursor(bool force = false)
			{
			}

			// Token: 0x0600FC7C RID: 64636 RVA: 0x0005F658 File Offset: 0x0005D858
			[Token(Token = "0x600FC7C")]
			[Address(RVA = "0x73AD50", Offset = "0x739950", VA = "0x18073AD50")]
			public bool TryGetAttractRouteReachable(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x0600FC7D RID: 64637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600FC7D")]
			[Address(RVA = "0x73B2A0", Offset = "0x739EA0", VA = "0x18073B2A0")]
			private RouteData _InitializeAttractRouteData()
			{
				return null;
			}

			// Token: 0x0600FC7E RID: 64638 RVA: 0x0005F670 File Offset: 0x0005D870
			[Token(Token = "0x600FC7E")]
			[Address(RVA = "0x73B4D0", Offset = "0x73A0D0", VA = "0x18073B4D0")]
			private bool _TryGetAttractRouteReachable(RouteData routeData, Buff currentBuff)
			{
				return default(bool);
			}

			// Token: 0x0600FC7F RID: 64639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC7F")]
			[Address(RVA = "0x73B650", Offset = "0x73A250", VA = "0x18073B650")]
			private void _UpdateAttractRoute(RouteData routeData)
			{
			}

			// Token: 0x0600FC80 RID: 64640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC80")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AttractController()
			{
			}

			// Token: 0x040118A7 RID: 71847
			[Token(Token = "0x40118A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Enemy m_owner;

			// Token: 0x040118A8 RID: 71848
			[Token(Token = "0x40118A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private ListDict<ObjectPtr<Buff>, Tile> m_attractBuffDict;

			// Token: 0x040118A9 RID: 71849
			[Token(Token = "0x40118A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private DirectionCursor m_attractCursor;

			// Token: 0x040118AA RID: 71850
			[Token(Token = "0x40118AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Route m_attractRoute;
		}

		// Token: 0x020025E9 RID: 9705
		[Token(Token = "0x20025E9")]
		[Serializable]
		public class SpecialBlockCondition
		{
			// Token: 0x0600FC81 RID: 64641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC81")]
			[Address(RVA = "0x74E970", Offset = "0x74D570", VA = "0x18074E970")]
			public void SetCondition(Enemy.SpecialBlockCondition.Type type, Enemy.SpecialBlockCondition.BuffKeyPair[] buffKeyPairs, string[] filterTags)
			{
			}

			// Token: 0x170021C8 RID: 8648
			// (get) Token: 0x0600FC82 RID: 64642 RVA: 0x0005F688 File Offset: 0x0005D888
			[Token(Token = "0x170021C8")]
			private bool filterBuffKeyPairs
			{
				[Token(Token = "0x600FC82")]
				[Address(RVA = "0x74E9B0", Offset = "0x74D5B0", VA = "0x18074E9B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170021C9 RID: 8649
			// (get) Token: 0x0600FC83 RID: 64643 RVA: 0x0005F6A0 File Offset: 0x0005D8A0
			[Token(Token = "0x170021C9")]
			private bool filterTags
			{
				[Token(Token = "0x600FC83")]
				[Address(RVA = "0x74E9D0", Offset = "0x74D5D0", VA = "0x18074E9D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600FC84 RID: 64644 RVA: 0x0005F6B8 File Offset: 0x0005D8B8
			[Token(Token = "0x600FC84")]
			[Address(RVA = "0x74E5D0", Offset = "0x74D1D0", VA = "0x18074E5D0")]
			public bool CheckBlockable(Character blocker, Entity blockee)
			{
				return default(bool);
			}

			// Token: 0x0600FC85 RID: 64645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC85")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpecialBlockCondition()
			{
			}

			// Token: 0x040118AB RID: 71851
			[Token(Token = "0x40118AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Enemy.SpecialBlockCondition.Type _type;

			// Token: 0x040118AC RID: 71852
			[Token(Token = "0x40118AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Enemy.SpecialBlockCondition.BuffKeyPair[] _buffKeyPairs;

			// Token: 0x040118AD RID: 71853
			[Token(Token = "0x40118AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private string[] _filterTags;

			// Token: 0x020025EA RID: 9706
			[Token(Token = "0x20025EA")]
			[Serializable]
			public enum Type
			{
				// Token: 0x040118AF RID: 71855
				[Token(Token = "0x40118AF")]
				NONE,
				// Token: 0x040118B0 RID: 71856
				[Token(Token = "0x40118B0")]
				BUFF_KEY_PAIR_OR,
				// Token: 0x040118B1 RID: 71857
				[Token(Token = "0x40118B1")]
				BUFF_KEY_MATCH_AND,
				// Token: 0x040118B2 RID: 71858
				[Token(Token = "0x40118B2")]
				FILTER_TAGS
			}

			// Token: 0x020025EB RID: 9707
			[Token(Token = "0x20025EB")]
			[Serializable]
			public struct BuffKeyPair
			{
				// Token: 0x040118B3 RID: 71859
				[Token(Token = "0x40118B3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[SerializeField]
				public string blockerBuffKey;

				// Token: 0x040118B4 RID: 71860
				[Token(Token = "0x40118B4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[SerializeField]
				public string blockeeBuffKey;
			}
		}

		// Token: 0x020025EC RID: 9708
		[Token(Token = "0x20025EC")]
		public class HeightController : IHotfixable
		{
			// Token: 0x0600FC86 RID: 64646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC86")]
			[Address(RVA = "0x7491D0", Offset = "0x747DD0", VA = "0x1807491D0")]
			public void OnInit(float initHeight)
			{
			}

			// Token: 0x0600FC87 RID: 64647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC87")]
			[Address(RVA = "0x749470", Offset = "0x748070", VA = "0x180749470")]
			public void Reset(Enemy owner)
			{
			}

			// Token: 0x0600FC88 RID: 64648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC88")]
			[Address(RVA = "0x749610", Offset = "0x748210", VA = "0x180749610")]
			public void SetEnemyHeight(float height)
			{
			}

			// Token: 0x170021CA RID: 8650
			// (get) Token: 0x0600FC89 RID: 64649 RVA: 0x0005F6D0 File Offset: 0x0005D8D0
			[Token(Token = "0x170021CA")]
			public float curHeight
			{
				[Token(Token = "0x600FC89")]
				[Address(RVA = "0x749F40", Offset = "0x748B40", VA = "0x180749F40")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600FC8A RID: 64650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC8A")]
			[Address(RVA = "0x749510", Offset = "0x748110", VA = "0x180749510")]
			public void SetEnemyHeightOffset(float offset, bool instant, bool isSet)
			{
			}

			// Token: 0x0600FC8B RID: 64651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC8B")]
			[Address(RVA = "0x7490D0", Offset = "0x747CD0", VA = "0x1807490D0")]
			public void AdjustEnemyHeightByInitial(float offset, bool instant)
			{
			}

			// Token: 0x0600FC8C RID: 64652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC8C")]
			[Address(RVA = "0x749730", Offset = "0x748330", VA = "0x180749730")]
			public void SetHeightImmediatelyChange()
			{
			}

			// Token: 0x0600FC8D RID: 64653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC8D")]
			[Address(RVA = "0x7496A0", Offset = "0x7482A0", VA = "0x1807496A0")]
			public void SetEnemyLevitateOffset(float offset)
			{
			}

			// Token: 0x0600FC8E RID: 64654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC8E")]
			[Address(RVA = "0x749330", Offset = "0x747F30", VA = "0x180749330")]
			public void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600FC8F RID: 64655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC8F")]
			[Address(RVA = "0x7497A0", Offset = "0x7483A0", VA = "0x1807497A0")]
			private void _UpdateHeight(float destHeight)
			{
			}

			// Token: 0x0600FC90 RID: 64656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC90")]
			[Address(RVA = "0x749A20", Offset = "0x748620", VA = "0x180749A20")]
			private void _UpdateSpineHeightControl(float height, bool changeImmediately)
			{
			}

			// Token: 0x0600FC91 RID: 64657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FC91")]
			[Address(RVA = "0x749EC0", Offset = "0x748AC0", VA = "0x180749EC0")]
			public HeightController()
			{
			}

			// Token: 0x040118B5 RID: 71861
			[Token(Token = "0x40118B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static float DELTA_OFFSET;

			// Token: 0x040118B6 RID: 71862
			[Token(Token = "0x40118B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Enemy m_owner;

			// Token: 0x040118B7 RID: 71863
			[Token(Token = "0x40118B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_curHeight;

			// Token: 0x040118B8 RID: 71864
			[Token(Token = "0x40118B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private float m_lastRootTileHeight;

			// Token: 0x040118B9 RID: 71865
			[Token(Token = "0x40118B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float m_targetHeight;

			// Token: 0x040118BA RID: 71866
			[Token(Token = "0x40118BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float m_levitateHeight;

			// Token: 0x040118BB RID: 71867
			[Token(Token = "0x40118BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float m_rootTileHeightOffset;

			// Token: 0x040118BC RID: 71868
			[Token(Token = "0x40118BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool m_changeHeightImmediately;

			// Token: 0x040118BD RID: 71869
			[Token(Token = "0x40118BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			private bool m_initSpineLikeHeight;

			// Token: 0x040118BE RID: 71870
			[Token(Token = "0x40118BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x040118BF RID: 71871
			[Token(Token = "0x40118BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x040118C0 RID: 71872
			[Token(Token = "0x40118C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetEnemyHeight;

			// Token: 0x040118C1 RID: 71873
			[Token(Token = "0x40118C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_curHeight;

			// Token: 0x040118C2 RID: 71874
			[Token(Token = "0x40118C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_SetEnemyHeightOffset;

			// Token: 0x040118C3 RID: 71875
			[Token(Token = "0x40118C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AdjustEnemyHeightByInitial;

			// Token: 0x040118C4 RID: 71876
			[Token(Token = "0x40118C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_SetHeightImmediatelyChange;

			// Token: 0x040118C5 RID: 71877
			[Token(Token = "0x40118C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_SetEnemyLevitateOffset;

			// Token: 0x040118C6 RID: 71878
			[Token(Token = "0x40118C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x040118C7 RID: 71879
			[Token(Token = "0x40118C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__UpdateHeight;

			// Token: 0x040118C8 RID: 71880
			[Token(Token = "0x40118C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__UpdateSpineHeightControl;

			// Token: 0x040118C9 RID: 71881
			[Token(Token = "0x40118C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
