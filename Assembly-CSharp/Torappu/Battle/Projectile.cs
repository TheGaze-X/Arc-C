using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023D8 RID: 9176
	[Token(Token = "0x20023D8")]
	public abstract class Projectile : BObject, IEffectSource, IBuffSource, IHotfixable
	{
		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x0600E9C7 RID: 59847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DA8")]
		public Effect mainEffect
		{
			[Token(Token = "0x600E9C7")]
			[Address(RVA = "0x5FF920", Offset = "0x5FE520", VA = "0x1805FF920")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DA9")]
		public EffectReplacePair[] effectReplacePairs
		{
			[Token(Token = "0x600E9C8")]
			[Address(RVA = "0x5FF620", Offset = "0x5FE220", VA = "0x1805FF620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x0600E9C9 RID: 59849 RVA: 0x00055968 File Offset: 0x00053B68
		// (set) Token: 0x0600E9CA RID: 59850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DAA")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public FP currentTime
		{
			[Token(Token = "0x600E9C9")]
			[Address(RVA = "0x5FF560", Offset = "0x5FE160", VA = "0x1805FF560")]
			[CompilerGenerated]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x600E9CA")]
			[Address(RVA = "0x600040", Offset = "0x5FEC40", VA = "0x180600040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x0600E9CB RID: 59851 RVA: 0x00055980 File Offset: 0x00053B80
		[Token(Token = "0x17001DAB")]
		public FP lifeTime
		{
			[Token(Token = "0x600E9CB")]
			[Address(RVA = "0x5FF8C0", Offset = "0x5FE4C0", VA = "0x1805FF8C0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x0600E9CC RID: 59852 RVA: 0x00055998 File Offset: 0x00053B98
		[Token(Token = "0x17001DAC")]
		public FP remainingTime
		{
			[Token(Token = "0x600E9CC")]
			[Address(RVA = "0x5FFAB0", Offset = "0x5FE6B0", VA = "0x1805FFAB0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x0600E9CD RID: 59853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DAD")]
		public Transform bodyTransform
		{
			[Token(Token = "0x600E9CD")]
			[Address(RVA = "0x5FF470", Offset = "0x5FE070", VA = "0x1805FF470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x0600E9CE RID: 59854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DAE")]
		public Entity source
		{
			[Token(Token = "0x600E9CE")]
			[Address(RVA = "0x5FFC50", Offset = "0x5FE850", VA = "0x1805FFC50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x0600E9CF RID: 59855 RVA: 0x000559B0 File Offset: 0x00053BB0
		[Token(Token = "0x17001DAF")]
		public Vector2 sourceMapPos
		{
			[Token(Token = "0x600E9CF")]
			[Address(RVA = "0x5FFBE0", Offset = "0x5FE7E0", VA = "0x1805FFBE0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x0600E9D0 RID: 59856 RVA: 0x000559C8 File Offset: 0x00053BC8
		[Token(Token = "0x17001DB0")]
		public Vector2 startMapPos
		{
			[Token(Token = "0x600E9D0")]
			[Address(RVA = "0x5FFCC0", Offset = "0x5FE8C0", VA = "0x1805FFCC0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x0600E9D1 RID: 59857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DB1")]
		[Inspect(InspectorLevel.Basic)]
		public Entity traceTarget
		{
			[Token(Token = "0x600E9D1")]
			[Address(RVA = "0x5FFF70", Offset = "0x5FEB70", VA = "0x1805FFF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x0600E9D2 RID: 59858 RVA: 0x000559E0 File Offset: 0x00053BE0
		[Token(Token = "0x17001DB2")]
		public Vector2? traceTargetMapPos
		{
			[Token(Token = "0x600E9D2")]
			[Address(RVA = "0x5FFEF0", Offset = "0x5FEAF0", VA = "0x1805FFEF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x0600E9D3 RID: 59859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DB3")]
		public Ability ability
		{
			[Token(Token = "0x600E9D3")]
			[Address(RVA = "0x5FF1D0", Offset = "0x5FDDD0", VA = "0x1805FF1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x0600E9D4 RID: 59860 RVA: 0x000559F8 File Offset: 0x00053BF8
		[Token(Token = "0x17001DB4")]
		public Projectile.Type type
		{
			[Token(Token = "0x600E9D4")]
			[Address(RVA = "0x5FFFE0", Offset = "0x5FEBE0", VA = "0x1805FFFE0")]
			get
			{
				return Projectile.Type.NORMAL;
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x0600E9D5 RID: 59861 RVA: 0x00055A10 File Offset: 0x00053C10
		[Token(Token = "0x17001DB5")]
		public Projectile.ProjectileType projectileType
		{
			[Token(Token = "0x600E9D5")]
			[Address(RVA = "0x5FFA50", Offset = "0x5FE650", VA = "0x1805FFA50")]
			get
			{
				return Projectile.ProjectileType.DEFAULT;
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x0600E9D6 RID: 59862 RVA: 0x00055A28 File Offset: 0x00053C28
		[Token(Token = "0x17001DB6")]
		public float timeRatio
		{
			[Token(Token = "0x600E9D6")]
			[Address(RVA = "0x5FFD90", Offset = "0x5FE990", VA = "0x1805FFD90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x0600E9D7 RID: 59863 RVA: 0x00055A40 File Offset: 0x00053C40
		// (set) Token: 0x0600E9D8 RID: 59864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DB7")]
		public bool movementAdjustable
		{
			[Token(Token = "0x600E9D7")]
			[Address(RVA = "0x5FF990", Offset = "0x5FE590", VA = "0x1805FF990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9D8")]
			[Address(RVA = "0x600210", Offset = "0x5FEE10", VA = "0x180600210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x0600E9D9 RID: 59865 RVA: 0x00055A58 File Offset: 0x00053C58
		// (set) Token: 0x0600E9DA RID: 59866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DB8")]
		public virtual bool eliminatable
		{
			[Token(Token = "0x600E9D9")]
			[Address(RVA = "0x5FF680", Offset = "0x5FE280", VA = "0x1805FF680", Slot = "37")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9DA")]
			[Address(RVA = "0x600120", Offset = "0x5FED20", VA = "0x180600120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x0600E9DB RID: 59867 RVA: 0x00055A70 File Offset: 0x00053C70
		[Token(Token = "0x17001DB9")]
		public bool isEliminated
		{
			[Token(Token = "0x600E9DB")]
			[Address(RVA = "0x5FF7A0", Offset = "0x5FE3A0", VA = "0x1805FF7A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x0600E9DC RID: 59868 RVA: 0x00055A88 File Offset: 0x00053C88
		[Token(Token = "0x17001DBA")]
		public bool hasHitTraceTarget
		{
			[Token(Token = "0x600E9DC")]
			[Address(RVA = "0x5FF6E0", Offset = "0x5FE2E0", VA = "0x1805FF6E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x0600E9DD RID: 59869 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E9DE RID: 59870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DBB")]
		private protected Transform targetTransform
		{
			[Token(Token = "0x600E9DD")]
			[Address(RVA = "0x5FFD30", Offset = "0x5FE930", VA = "0x1805FFD30")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600E9DE")]
			[Address(RVA = "0x600300", Offset = "0x5FEF00", VA = "0x180600300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x0600E9DF RID: 59871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DBC")]
		protected Context context
		{
			[Token(Token = "0x600E9DF")]
			[Address(RVA = "0x5FF4D0", Offset = "0x5FE0D0", VA = "0x1805FF4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x0600E9E0 RID: 59872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DBD")]
		public Blackboard blackboard
		{
			[Token(Token = "0x600E9E0")]
			[Address(RVA = "0x5FF400", Offset = "0x5FE000", VA = "0x1805FF400")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x0600E9E1 RID: 59873
		[Token(Token = "0x17001DBE")]
		protected abstract bool stopAfterMaxHit { [Token(Token = "0x600E9E1")] get; }

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x0600E9E2 RID: 59874
		[Token(Token = "0x17001DBF")]
		protected abstract bool stopAfterFirstHit { [Token(Token = "0x600E9E2")] get; }

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x0600E9E3 RID: 59875
		[Token(Token = "0x17001DC0")]
		protected abstract bool stopWhenSourceInvalid { [Token(Token = "0x600E9E3")] get; }

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x0600E9E4 RID: 59876
		[Token(Token = "0x17001DC1")]
		protected abstract bool alwaysHitTraceTargetInTheEnd { [Token(Token = "0x600E9E4")] get; }

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x0600E9E5 RID: 59877
		[Token(Token = "0x17001DC2")]
		protected abstract bool alwaysHitTraceTargetWhenReached { [Token(Token = "0x600E9E5")] get; }

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x0600E9E6 RID: 59878
		[Token(Token = "0x17001DC3")]
		protected abstract bool alwaysReachInTheEnd { [Token(Token = "0x600E9E6")] get; }

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x0600E9E7 RID: 59879 RVA: 0x00055AA0 File Offset: 0x00053CA0
		[Token(Token = "0x17001DC4")]
		public bool alwaysHitTraceTarget
		{
			[Token(Token = "0x600E9E7")]
			[Address(RVA = "0x5FF240", Offset = "0x5FDE40", VA = "0x1805FF240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x0600E9E8 RID: 59880 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E9E9 RID: 59881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DC5")]
		public string key
		{
			[Token(Token = "0x600E9E8")]
			[Address(RVA = "0x5FF860", Offset = "0x5FE460", VA = "0x1805FF860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600E9E9")]
			[Address(RVA = "0x600190", Offset = "0x5FED90", VA = "0x180600190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x0600E9EA RID: 59882 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E9EB RID: 59883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DC6")]
		public string originalKey
		{
			[Token(Token = "0x600E9EA")]
			[Address(RVA = "0x5FF9F0", Offset = "0x5FE5F0", VA = "0x1805FF9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600E9EB")]
			[Address(RVA = "0x600280", Offset = "0x5FEE80", VA = "0x180600280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x0600E9EC RID: 59884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DC7")]
		public string audioSignalKey
		{
			[Token(Token = "0x600E9EC")]
			[Address(RVA = "0x5FF2F0", Offset = "0x5FDEF0", VA = "0x1805FF2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x0600E9ED RID: 59885 RVA: 0x00055AB8 File Offset: 0x00053CB8
		[Token(Token = "0x17001DC8")]
		public bool isStopped
		{
			[Token(Token = "0x600E9ED")]
			[Address(RVA = "0x5FF800", Offset = "0x5FE400", VA = "0x1805FF800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x0600E9EE RID: 59886 RVA: 0x00055AD0 File Offset: 0x00053CD0
		[Token(Token = "0x17001DC9")]
		public bool hasReached
		{
			[Token(Token = "0x600E9EE")]
			[Address(RVA = "0x5FF740", Offset = "0x5FE340", VA = "0x1805FF740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x0600E9EF RID: 59887 RVA: 0x00055AE8 File Offset: 0x00053CE8
		// (set) Token: 0x0600E9F0 RID: 59888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001DCA")]
		public bool damageMissFlag
		{
			[Token(Token = "0x600E9EF")]
			[Address(RVA = "0x5FF5C0", Offset = "0x5FE1C0", VA = "0x1805FF5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9F0")]
			[Address(RVA = "0x6000B0", Offset = "0x5FECB0", VA = "0x1806000B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x0600E9F1 RID: 59889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DCB")]
		public Projectile.Behaviour[] behaviours
		{
			[Token(Token = "0x600E9F1")]
			[Address(RVA = "0x5FF3A0", Offset = "0x5FDFA0", VA = "0x1805FF3A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E9F2 RID: 59890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9F2")]
		[Address(RVA = "0x5FB6C0", Offset = "0x5FA2C0", VA = "0x1805FB6C0", Slot = "25")]
		public override void OnAllocate()
		{
		}

		// Token: 0x0600E9F3 RID: 59891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9F3")]
		[Address(RVA = "0x5FA100", Offset = "0x5F8D00", VA = "0x1805FA100")]
		public void Init(string key, ILocatable start, ILocatable target, Ability ability, Projectile.Type type, string originalKey, EffectReplacePair[] effectReplacePairs)
		{
		}

		// Token: 0x0600E9F4 RID: 59892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9F4")]
		[Address(RVA = "0x5FA930", Offset = "0x5F9530", VA = "0x1805FA930")]
		public void Init(string key, Entity source, ILocatable start, ILocatable target, Ability ability, Projectile.Type type, string originalKey, EffectReplacePair[] effectReplacePairs)
		{
		}

		// Token: 0x0600E9F5 RID: 59893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9F5")]
		[Address(RVA = "0x5FAEE0", Offset = "0x5F9AE0", VA = "0x1805FAEE0")]
		public void Init(string key, Projectile sourceProjectile, ILocatable target, Projectile.Type type, string originalKey, EffectReplacePair[] effectReplacePairs)
		{
		}

		// Token: 0x0600E9F6 RID: 59894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9F6")]
		[Address(RVA = "0x5FE450", Offset = "0x5FD050", VA = "0x1805FE450")]
		private void _InitInline(ILocatable target, ILocatable start)
		{
		}

		// Token: 0x0600E9F7 RID: 59895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9F7")]
		[Address(RVA = "0x5FD000", Offset = "0x5FBC00", VA = "0x1805FD000")]
		public void RegisterMovement(BasicMovement movement)
		{
		}

		// Token: 0x0600E9F8 RID: 59896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9F8")]
		[Address(RVA = "0x5FD3F0", Offset = "0x5FBFF0", VA = "0x1805FD3F0")]
		public void SetTraceTarget(ILocatable target)
		{
		}

		// Token: 0x0600E9F9 RID: 59897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9F9")]
		[Address(RVA = "0x5F9240", Offset = "0x5F7E40", VA = "0x1805F9240")]
		public void AttachGraphicProjectile(Projectile projectile)
		{
		}

		// Token: 0x0600E9FA RID: 59898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9FA")]
		[Address(RVA = "0x5FB660", Offset = "0x5FA260", VA = "0x1805FB660")]
		public void Interrupt()
		{
		}

		// Token: 0x0600E9FB RID: 59899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9FB")]
		[Address(RVA = "0x5FD860", Offset = "0x5FC460", VA = "0x1805FD860")]
		public void Trigger()
		{
		}

		// Token: 0x0600E9FC RID: 59900 RVA: 0x00055B00 File Offset: 0x00053D00
		[Token(Token = "0x600E9FC")]
		[Address(RVA = "0x5FD970", Offset = "0x5FC570", VA = "0x1805FD970")]
		public bool TryEliminate()
		{
			return default(bool);
		}

		// Token: 0x0600E9FD RID: 59901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9FD")]
		[Address(RVA = "0x5FC990", Offset = "0x5FB590", VA = "0x1805FC990")]
		public void RegisterActions(Projectile.Event ev, IList<ActionNode> actions, bool additive = true, bool cacheAtk = false)
		{
		}

		// Token: 0x0600E9FE RID: 59902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9FE")]
		[Address(RVA = "0x5FCBA0", Offset = "0x5FB7A0", VA = "0x1805FCBA0")]
		public void RegisterBuffs(IList<BuffData> buffDataList, bool additive = true)
		{
		}

		// Token: 0x0600E9FF RID: 59903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9FF")]
		[Address(RVA = "0x5FCDA0", Offset = "0x5FB9A0", VA = "0x1805FCDA0")]
		public void RegisterExtraBlackboard(Blackboard extraBlackboard, bool additive = true)
		{
		}

		// Token: 0x0600EA00 RID: 59904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA00")]
		[Address(RVA = "0x5FC420", Offset = "0x5FB020", VA = "0x1805FC420", Slot = "27")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EA01 RID: 59905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA01")]
		[Address(RVA = "0x5FDCC0", Offset = "0x5FC8C0", VA = "0x1805FDCC0")]
		public void UpdateTargetGroundPosZ(ILocatable target, ref float targetGroundPosZ)
		{
		}

		// Token: 0x0600EA02 RID: 59906 RVA: 0x00055B18 File Offset: 0x00053D18
		[Token(Token = "0x600EA02")]
		[Address(RVA = "0x5F7D00", Offset = "0x5F6900", VA = "0x1805F7D00", Slot = "44")]
		protected virtual bool ExtraCheckToFinish()
		{
			return default(bool);
		}

		// Token: 0x0600EA03 RID: 59907 RVA: 0x00055B30 File Offset: 0x00053D30
		[Token(Token = "0x600EA03")]
		[Address(RVA = "0x5F9880", Offset = "0x5F8480", VA = "0x1805F9880")]
		public bool DealHitTarget(Entity target, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600EA04 RID: 59908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA04")]
		[Address(RVA = "0x5F97E0", Offset = "0x5F83E0", VA = "0x1805F97E0", Slot = "45")]
		public virtual void DealHitTargetLeft(Entity target)
		{
		}

		// Token: 0x0600EA05 RID: 59909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA05")]
		[Address(RVA = "0x5F9C90", Offset = "0x5F8890", VA = "0x1805F9C90")]
		public void EnsureLifeTime(FP duration, bool clearTraceTarget)
		{
		}

		// Token: 0x0600EA06 RID: 59910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA06")]
		[Address(RVA = "0x5F9E50", Offset = "0x5F8A50", VA = "0x1805F9E50", Slot = "35")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600EA07 RID: 59911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA07")]
		[Address(RVA = "0x5F9DA0", Offset = "0x5F89A0", VA = "0x1805F9DA0", Slot = "46")]
		public virtual void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600EA08 RID: 59912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA08")]
		[Address(RVA = "0x5FCC50", Offset = "0x5FB850", VA = "0x1805FCC50")]
		public void RegisterEventCallback(Projectile.Event ev, Action<Projectile> cb)
		{
		}

		// Token: 0x0600EA09 RID: 59913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA09")]
		[Address(RVA = "0x5F8CD0", Offset = "0x5F78D0", VA = "0x1805F8CD0")]
		public void ApplyAtkScaleToDamageNode(FP atkScale, bool alsoApplyToElementDamage = false, bool overwrite = false, bool oneShot = false)
		{
		}

		// Token: 0x0600EA0A RID: 59914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA0A")]
		[Address(RVA = "0x5FC820", Offset = "0x5FB420", VA = "0x1805FC820")]
		public void PlayBehaviourAudio(Vector3 pos)
		{
		}

		// Token: 0x0600EA0B RID: 59915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA0B")]
		[Address(RVA = "0x5FB730", Offset = "0x5FA330", VA = "0x1805FB730")]
		public void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x0600EA0C RID: 59916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA0C")]
		[Address(RVA = "0x5FD1B0", Offset = "0x5FBDB0", VA = "0x1805FD1B0")]
		protected void ResetAll()
		{
		}

		// Token: 0x0600EA0D RID: 59917
		[Token(Token = "0x600EA0D")]
		protected abstract float GetLifeTime();

		// Token: 0x0600EA0E RID: 59918
		[Token(Token = "0x600EA0E")]
		public abstract int GetMaxHitNum();

		// Token: 0x0600EA0F RID: 59919 RVA: 0x00055B48 File Offset: 0x00053D48
		[Token(Token = "0x600EA0F")]
		[Address(RVA = "0x5FA070", Offset = "0x5F8C70", VA = "0x1805FA070", Slot = "49")]
		protected virtual FP GetKeepAlreadyHitTime()
		{
			return default(FP);
		}

		// Token: 0x0600EA10 RID: 59920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA10")]
		[Address(RVA = "0x5FBDF0", Offset = "0x5FA9F0", VA = "0x1805FBDF0", Slot = "50")]
		protected virtual void OnProjectileBorn()
		{
		}

		// Token: 0x0600EA11 RID: 59921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA11")]
		[Address(RVA = "0x5FC1A0", Offset = "0x5FADA0", VA = "0x1805FC1A0", Slot = "51")]
		protected virtual void OnProjectileStop()
		{
		}

		// Token: 0x0600EA12 RID: 59922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA12")]
		[Address(RVA = "0x5FBBE0", Offset = "0x5FA7E0", VA = "0x1805FBBE0", Slot = "52")]
		protected virtual void OnHitTarget(Entity target)
		{
		}

		// Token: 0x0600EA13 RID: 59923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA13")]
		[Address(RVA = "0x5FB830", Offset = "0x5FA430", VA = "0x1805FB830")]
		protected void OnBehavioursHitTarget(Entity target)
		{
		}

		// Token: 0x0600EA14 RID: 59924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA14")]
		[Address(RVA = "0x5FB930", Offset = "0x5FA530", VA = "0x1805FB930")]
		protected void OnHitTargetLeft(Entity target)
		{
		}

		// Token: 0x0600EA15 RID: 59925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA15")]
		[Address(RVA = "0x5FC080", Offset = "0x5FAC80", VA = "0x1805FC080")]
		protected void OnProjectileReached()
		{
		}

		// Token: 0x0600EA16 RID: 59926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA16")]
		[Address(RVA = "0x5F99F0", Offset = "0x5F85F0", VA = "0x1805F99F0")]
		protected void DealProjectileReached()
		{
		}

		// Token: 0x0600EA17 RID: 59927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA17")]
		[Address(RVA = "0x5FD390", Offset = "0x5FBF90", VA = "0x1805FD390")]
		public void SetHasReached()
		{
		}

		// Token: 0x0600EA18 RID: 59928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA18")]
		[Address(RVA = "0x5FD760", Offset = "0x5FC360", VA = "0x1805FD760")]
		public void SetUnReached()
		{
		}

		// Token: 0x0600EA19 RID: 59929 RVA: 0x00055B60 File Offset: 0x00053D60
		[Token(Token = "0x600EA19")]
		[Address(RVA = "0x5F9320", Offset = "0x5F7F20", VA = "0x1805F9320", Slot = "53")]
		protected virtual bool CheckTargetAlreadyHitAndUpdate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600EA1A RID: 59930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA1A")]
		[Address(RVA = "0x5FDB30", Offset = "0x5FC730", VA = "0x1805FDB30")]
		protected void UpdateAlreadyHit(Entity target)
		{
		}

		// Token: 0x0600EA1B RID: 59931 RVA: 0x00055B78 File Offset: 0x00053D78
		[Token(Token = "0x600EA1B")]
		[Address(RVA = "0x5F93C0", Offset = "0x5F7FC0", VA = "0x1805F93C0")]
		protected bool CheckTargetAlreadyHit(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600EA1C RID: 59932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA1C")]
		[Address(RVA = "0x5F9760", Offset = "0x5F8360", VA = "0x1805F9760")]
		public void ClearTargetsAlreadyHitList()
		{
		}

		// Token: 0x0600EA1D RID: 59933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA1D")]
		[Address(RVA = "0x5FD7C0", Offset = "0x5FC3C0", VA = "0x1805FD7C0")]
		protected void StopMe()
		{
		}

		// Token: 0x0600EA1E RID: 59934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA1E")]
		[Address(RVA = "0x5FC930", Offset = "0x5FB530", VA = "0x1805FC930")]
		public void RecycleSelfImmediately()
		{
		}

		// Token: 0x0600EA1F RID: 59935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA1F")]
		[Address(RVA = "0x5FE100", Offset = "0x5FCD00", VA = "0x1805FE100")]
		private void _DealHitTraceTarget()
		{
		}

		// Token: 0x0600EA20 RID: 59936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA20")]
		[Address(RVA = "0x5FE1C0", Offset = "0x5FCDC0", VA = "0x1805FE1C0")]
		private void _DelayToBorn()
		{
		}

		// Token: 0x0600EA21 RID: 59937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA21")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FCB60", VA = "0x1805FDF60")]
		private void _CreateMainEffect(string effect)
		{
		}

		// Token: 0x0600EA22 RID: 59938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA22")]
		[Address(RVA = "0x5F9550", Offset = "0x5F8150", VA = "0x1805F9550")]
		public void ClearMainEffectIfNot()
		{
		}

		// Token: 0x0600EA23 RID: 59939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA23")]
		[Address(RVA = "0x5FEBF0", Offset = "0x5FD7F0", VA = "0x1805FEBF0")]
		private void _StopGraphicProjectileIfNot()
		{
		}

		// Token: 0x0600EA24 RID: 59940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA24")]
		[Address(RVA = "0x5FD130", Offset = "0x5FBD30", VA = "0x1805FD130")]
		public void ReplaceMainEffect(string effect)
		{
		}

		// Token: 0x0600EA25 RID: 59941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA25")]
		[Address(RVA = "0x5FECC0", Offset = "0x5FD8C0", VA = "0x1805FECC0")]
		private void _TryClearMainEffectWhenReachedIfNot()
		{
		}

		// Token: 0x0600EA26 RID: 59942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA26")]
		[Address(RVA = "0x5F92C0", Offset = "0x5F7EC0", VA = "0x1805F92C0")]
		private void Awake()
		{
		}

		// Token: 0x0600EA27 RID: 59943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA27")]
		[Address(RVA = "0x5FD080", Offset = "0x5FBC80", VA = "0x1805FD080")]
		public void ReplaceActionNodes(Projectile.Event ev, List<ActionNode> newActionNodes)
		{
		}

		// Token: 0x0600EA28 RID: 59944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA28")]
		[Address(RVA = "0x5F9FD0", Offset = "0x5F8BD0", VA = "0x1805F9FD0")]
		public IList<ActionNode> GetActionNodes(Projectile.Event ev)
		{
			return null;
		}

		// Token: 0x0600EA29 RID: 59945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA29")]
		[Address(RVA = "0x5FD2F0", Offset = "0x5FBEF0", VA = "0x1805FD2F0")]
		public void RunActions(Projectile.Event ev, Tile tile)
		{
		}

		// Token: 0x0600EA2A RID: 59946 RVA: 0x00055B90 File Offset: 0x00053D90
		[Token(Token = "0x600EA2A")]
		[Address(RVA = "0x5FE260", Offset = "0x5FCE60", VA = "0x1805FE260")]
		private FP _GetProjectileTimeScale()
		{
			return default(FP);
		}

		// Token: 0x0600EA2B RID: 59947 RVA: 0x00055BA8 File Offset: 0x00053DA8
		[Token(Token = "0x600EA2B")]
		[Address(RVA = "0x5FCEE0", Offset = "0x5FBAE0", VA = "0x1805FCEE0")]
		public bool RegisterMoveScale(FP moveScale)
		{
			return default(bool);
		}

		// Token: 0x0600EA2C RID: 59948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA2C")]
		[Address(RVA = "0x5FDA20", Offset = "0x5FC620", VA = "0x1805FDA20")]
		public void UnregisterMoveScale(FP moveScale)
		{
		}

		// Token: 0x0600EA2D RID: 59949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA2D")]
		[Address(RVA = "0x5FED30", Offset = "0x5FD930", VA = "0x1805FED30")]
		private void _UpdateEffectTimeScale()
		{
		}

		// Token: 0x0600EA2E RID: 59950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA2E")]
		[Address(RVA = "0x5FE990", Offset = "0x5FD590", VA = "0x1805FE990")]
		private void _InitOuterAdjustableSettings()
		{
		}

		// Token: 0x0600EA2F RID: 59951 RVA: 0x00055BC0 File Offset: 0x00053DC0
		[Token(Token = "0x600EA2F")]
		[Address(RVA = "0x5FDE50", Offset = "0x5FCA50", VA = "0x1805FDE50")]
		private bool _CalculateEliminatable()
		{
			return default(bool);
		}

		// Token: 0x0600EA30 RID: 59952 RVA: 0x00055BD8 File Offset: 0x00053DD8
		[Token(Token = "0x600EA30")]
		[Address(RVA = "0x5FDED0", Offset = "0x5FCAD0", VA = "0x1805FDED0")]
		private bool _CalculateMovementAdjustable()
		{
			return default(bool);
		}

		// Token: 0x0600EA31 RID: 59953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA31")]
		[Address(RVA = "0x5FE380", Offset = "0x5FCF80", VA = "0x1805FE380")]
		private Projectile.Behaviour[] _InitBahavioursIfNot()
		{
			return null;
		}

		// Token: 0x0600EA32 RID: 59954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA32")]
		[Address(RVA = "0x5FEEE0", Offset = "0x5FDAE0", VA = "0x1805FEEE0")]
		protected Projectile()
		{
		}

		// Token: 0x0600EA33 RID: 59955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA33")]
		[Address(RVA = "0x5FDA10", Offset = "0x5FC610", VA = "0x1805FDA10")]
		private void <>xLuaBaseProxy_OnAllocate()
		{
		}

		// Token: 0x0600EA34 RID: 59956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA34")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040101F3 RID: 66035
		[Token(Token = "0x40101F3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _randomDelayToBorn;

		// Token: 0x040101F4 RID: 66036
		[Token(Token = "0x40101F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _bodyTransform;

		// Token: 0x040101F5 RID: 66037
		[Token(Token = "0x40101F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _keepAlreadyHitTime;

		// Token: 0x040101F6 RID: 66038
		[Token(Token = "0x40101F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _mainEffect;

		// Token: 0x040101F7 RID: 66039
		[Token(Token = "0x40101F7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("If there is a weird line renderer bending issue, check this.")]
		private bool _clearMainEffectWhenReached;

		// Token: 0x040101F8 RID: 66040
		[Token(Token = "0x40101F8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Projectile.ActionController _actionController;

		// Token: 0x040101F9 RID: 66041
		[Token(Token = "0x40101F9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _fixDealHitTargetLeft;

		// Token: 0x040101FA RID: 66042
		[Token(Token = "0x40101FA")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _stopGraphicProjectileWhenClearMainEffect;

		// Token: 0x040101FB RID: 66043
		[Token(Token = "0x40101FB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _overrideAudioSignal;

		// Token: 0x040101FC RID: 66044
		[Token(Token = "0x40101FC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _fireProjectileReachedEvent;

		// Token: 0x040101FD RID: 66045
		[Token(Token = "0x40101FD")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Projectile.OuterAdjustable _eliminatableStatus;

		// Token: 0x040101FE RID: 66046
		[Token(Token = "0x40101FE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Projectile.OuterAdjustable _movementAdjustableStatus;

		// Token: 0x040101FF RID: 66047
		[Token(Token = "0x40101FF")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool _managedBySource;

		// Token: 0x04010200 RID: 66048
		[Token(Token = "0x4010200")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Projectile.ProjectileType _projectileType;

		// Token: 0x04010201 RID: 66049
		[Token(Token = "0x4010201")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private bool _containsChildrenBehaviours;

		// Token: 0x04010202 RID: 66050
		[Token(Token = "0x4010202")]
		[FieldOffset(Offset = "0x8D")]
		[SerializeField]
		private bool _canHitSameTargetMultipleTimes;

		// Token: 0x04010203 RID: 66051
		[Token(Token = "0x4010203")]
		[FieldOffset(Offset = "0x90")]
		private Action<Projectile>[] m_eventCallbacks;

		// Token: 0x04010204 RID: 66052
		[Token(Token = "0x4010204")]
		[FieldOffset(Offset = "0x98")]
		private FP m_lifeTime;

		// Token: 0x04010205 RID: 66053
		[Token(Token = "0x4010205")]
		[FieldOffset(Offset = "0xA0")]
		private int m_maxHitNum;

		// Token: 0x04010206 RID: 66054
		[Token(Token = "0x4010206")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_isStopped;

		// Token: 0x04010207 RID: 66055
		[Token(Token = "0x4010207")]
		[FieldOffset(Offset = "0xA5")]
		private bool m_isEliminated;

		// Token: 0x04010208 RID: 66056
		[Token(Token = "0x4010208")]
		[FieldOffset(Offset = "0xA6")]
		private bool m_hasReached;

		// Token: 0x04010209 RID: 66057
		[Token(Token = "0x4010209")]
		[FieldOffset(Offset = "0xA7")]
		private bool m_hasHitTraceTarget;

		// Token: 0x0401020A RID: 66058
		[Token(Token = "0x401020A")]
		[FieldOffset(Offset = "0xA8")]
		private int m_currentHitNum;

		// Token: 0x0401020B RID: 66059
		[Token(Token = "0x401020B")]
		[FieldOffset(Offset = "0xB0")]
		private FP m_keepAlreadyHitTime;

		// Token: 0x0401020C RID: 66060
		[Token(Token = "0x401020C")]
		[FieldOffset(Offset = "0xB8")]
		private ObjectPtr<Effect> m_mainEffect;

		// Token: 0x0401020D RID: 66061
		[Token(Token = "0x401020D")]
		[FieldOffset(Offset = "0xC8")]
		private Projectile.Type m_type;

		// Token: 0x0401020E RID: 66062
		[Token(Token = "0x401020E")]
		[FieldOffset(Offset = "0xD0")]
		private EffectReplacePair[] m_effectReplacePairs;

		// Token: 0x0401020F RID: 66063
		[Token(Token = "0x401020F")]
		[FieldOffset(Offset = "0xD8")]
		protected Projectile m_graphicProjectile;

		// Token: 0x04010210 RID: 66064
		[Token(Token = "0x4010210")]
		[FieldOffset(Offset = "0xE0")]
		protected List<int> m_ExtraLogIds;

		// Token: 0x04010211 RID: 66065
		[Token(Token = "0x4010211")]
		[FieldOffset(Offset = "0xE8")]
		private BasicMovement m_movement;

		// Token: 0x04010212 RID: 66066
		[Token(Token = "0x4010212")]
		[FieldOffset(Offset = "0xF0")]
		protected ObjectPtr<Entity> m_source;

		// Token: 0x04010213 RID: 66067
		[Token(Token = "0x4010213")]
		[FieldOffset(Offset = "0x100")]
		protected Vector2 m_sourceMapPos;

		// Token: 0x04010214 RID: 66068
		[Token(Token = "0x4010214")]
		[FieldOffset(Offset = "0x108")]
		protected Vector2 m_startMapPos;

		// Token: 0x04010215 RID: 66069
		[Token(Token = "0x4010215")]
		[FieldOffset(Offset = "0x110")]
		protected ObjectPtr<Entity> m_traceTarget;

		// Token: 0x04010216 RID: 66070
		[Token(Token = "0x4010216")]
		[FieldOffset(Offset = "0x120")]
		protected Vector2? m_traceTargetMapPos;

		// Token: 0x04010217 RID: 66071
		[Token(Token = "0x4010217")]
		[FieldOffset(Offset = "0x130")]
		protected ObjectPtr<Ability> m_ability;

		// Token: 0x04010218 RID: 66072
		[Token(Token = "0x4010218")]
		[FieldOffset(Offset = "0x140")]
		private Projectile.Behaviour[] m_behaviours;

		// Token: 0x04010219 RID: 66073
		[Token(Token = "0x4010219")]
		[FieldOffset(Offset = "0x148")]
		private bool m_behavioursInited;

		// Token: 0x0401021A RID: 66074
		[Token(Token = "0x401021A")]
		[FieldOffset(Offset = "0x150")]
		private Dictionary<ObjectPtr<Entity>, FP> m_targetsAlreadyHit;

		// Token: 0x04010222 RID: 66082
		[Token(Token = "0x4010222")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainEffect;

		// Token: 0x04010223 RID: 66083
		[Token(Token = "0x4010223")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_effectReplacePairs;

		// Token: 0x04010224 RID: 66084
		[Token(Token = "0x4010224")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04010225 RID: 66085
		[Token(Token = "0x4010225")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_currentTime;

		// Token: 0x04010226 RID: 66086
		[Token(Token = "0x4010226")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_lifeTime;

		// Token: 0x04010227 RID: 66087
		[Token(Token = "0x4010227")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_remainingTime;

		// Token: 0x04010228 RID: 66088
		[Token(Token = "0x4010228")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bodyTransform;

		// Token: 0x04010229 RID: 66089
		[Token(Token = "0x4010229")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_source;

		// Token: 0x0401022A RID: 66090
		[Token(Token = "0x401022A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_sourceMapPos;

		// Token: 0x0401022B RID: 66091
		[Token(Token = "0x401022B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_startMapPos;

		// Token: 0x0401022C RID: 66092
		[Token(Token = "0x401022C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_traceTarget;

		// Token: 0x0401022D RID: 66093
		[Token(Token = "0x401022D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_traceTargetMapPos;

		// Token: 0x0401022E RID: 66094
		[Token(Token = "0x401022E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_ability;

		// Token: 0x0401022F RID: 66095
		[Token(Token = "0x401022F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010230 RID: 66096
		[Token(Token = "0x4010230")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_projectileType;

		// Token: 0x04010231 RID: 66097
		[Token(Token = "0x4010231")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_timeRatio;

		// Token: 0x04010232 RID: 66098
		[Token(Token = "0x4010232")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04010233 RID: 66099
		[Token(Token = "0x4010233")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_movementAdjustable;

		// Token: 0x04010234 RID: 66100
		[Token(Token = "0x4010234")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_eliminatable;

		// Token: 0x04010235 RID: 66101
		[Token(Token = "0x4010235")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_eliminatable;

		// Token: 0x04010236 RID: 66102
		[Token(Token = "0x4010236")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_isEliminated;

		// Token: 0x04010237 RID: 66103
		[Token(Token = "0x4010237")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_hasHitTraceTarget;

		// Token: 0x04010238 RID: 66104
		[Token(Token = "0x4010238")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_targetTransform;

		// Token: 0x04010239 RID: 66105
		[Token(Token = "0x4010239")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_targetTransform;

		// Token: 0x0401023A RID: 66106
		[Token(Token = "0x401023A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x0401023B RID: 66107
		[Token(Token = "0x401023B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_blackboard;

		// Token: 0x0401023C RID: 66108
		[Token(Token = "0x401023C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_alwaysHitTraceTarget;

		// Token: 0x0401023D RID: 66109
		[Token(Token = "0x401023D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_key;

		// Token: 0x0401023E RID: 66110
		[Token(Token = "0x401023E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set_key;

		// Token: 0x0401023F RID: 66111
		[Token(Token = "0x401023F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_originalKey;

		// Token: 0x04010240 RID: 66112
		[Token(Token = "0x4010240")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_originalKey;

		// Token: 0x04010241 RID: 66113
		[Token(Token = "0x4010241")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_audioSignalKey;

		// Token: 0x04010242 RID: 66114
		[Token(Token = "0x4010242")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_isStopped;

		// Token: 0x04010243 RID: 66115
		[Token(Token = "0x4010243")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_hasReached;

		// Token: 0x04010244 RID: 66116
		[Token(Token = "0x4010244")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_damageMissFlag;

		// Token: 0x04010245 RID: 66117
		[Token(Token = "0x4010245")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_damageMissFlag;

		// Token: 0x04010246 RID: 66118
		[Token(Token = "0x4010246")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_behaviours;

		// Token: 0x04010247 RID: 66119
		[Token(Token = "0x4010247")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04010248 RID: 66120
		[Token(Token = "0x4010248")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04010249 RID: 66121
		[Token(Token = "0x4010249")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x0401024A RID: 66122
		[Token(Token = "0x401024A")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix2_Init;

		// Token: 0x0401024B RID: 66123
		[Token(Token = "0x401024B")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__InitInline;

		// Token: 0x0401024C RID: 66124
		[Token(Token = "0x401024C")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_RegisterMovement;

		// Token: 0x0401024D RID: 66125
		[Token(Token = "0x401024D")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_SetTraceTarget;

		// Token: 0x0401024E RID: 66126
		[Token(Token = "0x401024E")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_AttachGraphicProjectile;

		// Token: 0x0401024F RID: 66127
		[Token(Token = "0x401024F")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_Interrupt;

		// Token: 0x04010250 RID: 66128
		[Token(Token = "0x4010250")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_Trigger;

		// Token: 0x04010251 RID: 66129
		[Token(Token = "0x4010251")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_TryEliminate;

		// Token: 0x04010252 RID: 66130
		[Token(Token = "0x4010252")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_RegisterActions;

		// Token: 0x04010253 RID: 66131
		[Token(Token = "0x4010253")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_RegisterBuffs;

		// Token: 0x04010254 RID: 66132
		[Token(Token = "0x4010254")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_RegisterExtraBlackboard;

		// Token: 0x04010255 RID: 66133
		[Token(Token = "0x4010255")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010256 RID: 66134
		[Token(Token = "0x4010256")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_UpdateTargetGroundPosZ;

		// Token: 0x04010257 RID: 66135
		[Token(Token = "0x4010257")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_ExtraCheckToFinish;

		// Token: 0x04010258 RID: 66136
		[Token(Token = "0x4010258")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04010259 RID: 66137
		[Token(Token = "0x4010259")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_DealHitTargetLeft;

		// Token: 0x0401025A RID: 66138
		[Token(Token = "0x401025A")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_EnsureLifeTime;

		// Token: 0x0401025B RID: 66139
		[Token(Token = "0x401025B")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401025C RID: 66140
		[Token(Token = "0x401025C")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0401025D RID: 66141
		[Token(Token = "0x401025D")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_RegisterEventCallback;

		// Token: 0x0401025E RID: 66142
		[Token(Token = "0x401025E")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_ApplyAtkScaleToDamageNode;

		// Token: 0x0401025F RID: 66143
		[Token(Token = "0x401025F")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_PlayBehaviourAudio;

		// Token: 0x04010260 RID: 66144
		[Token(Token = "0x4010260")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04010261 RID: 66145
		[Token(Token = "0x4010261")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_ResetAll;

		// Token: 0x04010262 RID: 66146
		[Token(Token = "0x4010262")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_GetKeepAlreadyHitTime;

		// Token: 0x04010263 RID: 66147
		[Token(Token = "0x4010263")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04010264 RID: 66148
		[Token(Token = "0x4010264")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04010265 RID: 66149
		[Token(Token = "0x4010265")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04010266 RID: 66150
		[Token(Token = "0x4010266")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_OnBehavioursHitTarget;

		// Token: 0x04010267 RID: 66151
		[Token(Token = "0x4010267")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_OnHitTargetLeft;

		// Token: 0x04010268 RID: 66152
		[Token(Token = "0x4010268")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04010269 RID: 66153
		[Token(Token = "0x4010269")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_DealProjectileReached;

		// Token: 0x0401026A RID: 66154
		[Token(Token = "0x401026A")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_SetHasReached;

		// Token: 0x0401026B RID: 66155
		[Token(Token = "0x401026B")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_SetUnReached;

		// Token: 0x0401026C RID: 66156
		[Token(Token = "0x401026C")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_CheckTargetAlreadyHitAndUpdate;

		// Token: 0x0401026D RID: 66157
		[Token(Token = "0x401026D")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_UpdateAlreadyHit;

		// Token: 0x0401026E RID: 66158
		[Token(Token = "0x401026E")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_CheckTargetAlreadyHit;

		// Token: 0x0401026F RID: 66159
		[Token(Token = "0x401026F")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_ClearTargetsAlreadyHitList;

		// Token: 0x04010270 RID: 66160
		[Token(Token = "0x4010270")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_StopMe;

		// Token: 0x04010271 RID: 66161
		[Token(Token = "0x4010271")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_RecycleSelfImmediately;

		// Token: 0x04010272 RID: 66162
		[Token(Token = "0x4010272")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__DealHitTraceTarget;

		// Token: 0x04010273 RID: 66163
		[Token(Token = "0x4010273")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__DelayToBorn;

		// Token: 0x04010274 RID: 66164
		[Token(Token = "0x4010274")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__CreateMainEffect;

		// Token: 0x04010275 RID: 66165
		[Token(Token = "0x4010275")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_ClearMainEffectIfNot;

		// Token: 0x04010276 RID: 66166
		[Token(Token = "0x4010276")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__StopGraphicProjectileIfNot;

		// Token: 0x04010277 RID: 66167
		[Token(Token = "0x4010277")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_ReplaceMainEffect;

		// Token: 0x04010278 RID: 66168
		[Token(Token = "0x4010278")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__TryClearMainEffectWhenReachedIfNot;

		// Token: 0x04010279 RID: 66169
		[Token(Token = "0x4010279")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401027A RID: 66170
		[Token(Token = "0x401027A")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_ReplaceActionNodes;

		// Token: 0x0401027B RID: 66171
		[Token(Token = "0x401027B")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_GetActionNodes;

		// Token: 0x0401027C RID: 66172
		[Token(Token = "0x401027C")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_RunActions;

		// Token: 0x0401027D RID: 66173
		[Token(Token = "0x401027D")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__GetProjectileTimeScale;

		// Token: 0x0401027E RID: 66174
		[Token(Token = "0x401027E")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_RegisterMoveScale;

		// Token: 0x0401027F RID: 66175
		[Token(Token = "0x401027F")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_UnregisterMoveScale;

		// Token: 0x04010280 RID: 66176
		[Token(Token = "0x4010280")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__UpdateEffectTimeScale;

		// Token: 0x04010281 RID: 66177
		[Token(Token = "0x4010281")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__InitOuterAdjustableSettings;

		// Token: 0x04010282 RID: 66178
		[Token(Token = "0x4010282")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__CalculateEliminatable;

		// Token: 0x04010283 RID: 66179
		[Token(Token = "0x4010283")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0__CalculateMovementAdjustable;

		// Token: 0x04010284 RID: 66180
		[Token(Token = "0x4010284")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__InitBahavioursIfNot;

		// Token: 0x04010285 RID: 66181
		[Token(Token = "0x4010285")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020023D9 RID: 9177
		[Token(Token = "0x20023D9")]
		public enum Event
		{
			// Token: 0x04010287 RID: 66183
			[Token(Token = "0x4010287")]
			ON_HIT_OBJECT,
			// Token: 0x04010288 RID: 66184
			[Token(Token = "0x4010288")]
			ON_REACHED_TARGET,
			// Token: 0x04010289 RID: 66185
			[Token(Token = "0x4010289")]
			ON_HIT_TILE,
			// Token: 0x0401028A RID: 66186
			[Token(Token = "0x401028A")]
			ON_PROJECTILE_STOP,
			// Token: 0x0401028B RID: 66187
			[Token(Token = "0x401028B")]
			ON_PROJECTILE_ELIMINATE,
			// Token: 0x0401028C RID: 66188
			[Token(Token = "0x401028C")]
			ON_PROJECTILE_BORN,
			// Token: 0x0401028D RID: 66189
			[Token(Token = "0x401028D")]
			ON_PROJECTILE_TRIGGER,
			// Token: 0x0401028E RID: 66190
			[Token(Token = "0x401028E")]
			E_NUM
		}

		// Token: 0x020023DA RID: 9178
		[Token(Token = "0x20023DA")]
		public enum Type
		{
			// Token: 0x04010290 RID: 66192
			[Token(Token = "0x4010290")]
			NORMAL,
			// Token: 0x04010291 RID: 66193
			[Token(Token = "0x4010291")]
			ONLY_LOGIC,
			// Token: 0x04010292 RID: 66194
			[Token(Token = "0x4010292")]
			ONLY_GRAPHIC
		}

		// Token: 0x020023DB RID: 9179
		[Token(Token = "0x20023DB")]
		public enum ProjectileType
		{
			// Token: 0x04010294 RID: 66196
			[Token(Token = "0x4010294")]
			DEFAULT,
			// Token: 0x04010295 RID: 66197
			[Token(Token = "0x4010295")]
			ALCHEMY_UNIT
		}

		// Token: 0x020023DC RID: 9180
		[Token(Token = "0x20023DC")]
		public enum OuterAdjustable
		{
			// Token: 0x04010297 RID: 66199
			[Token(Token = "0x4010297")]
			AUTOMATIC,
			// Token: 0x04010298 RID: 66200
			[Token(Token = "0x4010298")]
			YES,
			// Token: 0x04010299 RID: 66201
			[Token(Token = "0x4010299")]
			NO
		}

		// Token: 0x020023DD RID: 9181
		[Token(Token = "0x20023DD")]
		public abstract class FriendComponent : MonoBehaviour, IHotfixable
		{
			// Token: 0x0600EA35 RID: 59957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA35")]
			[Address(RVA = "0x5F2470", Offset = "0x5F1070", VA = "0x1805F2470")]
			protected void StopProjectile(Projectile projectileCachedByFriendComp)
			{
			}

			// Token: 0x0600EA36 RID: 59958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA36")]
			[Address(RVA = "0x5F24F0", Offset = "0x5F10F0", VA = "0x1805F24F0")]
			protected FriendComponent()
			{
			}

			// Token: 0x0401029A RID: 66202
			[Token(Token = "0x401029A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_StopProjectile;

			// Token: 0x0401029B RID: 66203
			[Token(Token = "0x401029B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020023DE RID: 9182
		[Token(Token = "0x20023DE")]
		public abstract class Behaviour : Projectile.FriendComponent
		{
			// Token: 0x17001DCC RID: 7628
			// (get) Token: 0x0600EA37 RID: 59959 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600EA38 RID: 59960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001DCC")]
			private protected Projectile projectile
			{
				[Token(Token = "0x600EA37")]
				[Address(RVA = "0x5F11C0", Offset = "0x5EFDC0", VA = "0x1805F11C0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600EA38")]
				[Address(RVA = "0x5F1510", Offset = "0x5F0110", VA = "0x1805F1510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001DCD RID: 7629
			// (get) Token: 0x0600EA39 RID: 59961 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001DCD")]
			protected Entity traceTarget
			{
				[Token(Token = "0x600EA39")]
				[Address(RVA = "0x5F1360", Offset = "0x5EFF60", VA = "0x1805F1360")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001DCE RID: 7630
			// (get) Token: 0x0600EA3A RID: 59962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001DCE")]
			protected Entity source
			{
				[Token(Token = "0x600EA3A")]
				[Address(RVA = "0x5F1220", Offset = "0x5EFE20", VA = "0x1805F1220")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001DCF RID: 7631
			// (get) Token: 0x0600EA3B RID: 59963 RVA: 0x00055BF0 File Offset: 0x00053DF0
			[Token(Token = "0x17001DCF")]
			protected int currentHitNum
			{
				[Token(Token = "0x600EA3B")]
				[Address(RVA = "0x5F0E00", Offset = "0x5EFA00", VA = "0x1805F0E00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001DD0 RID: 7632
			// (get) Token: 0x0600EA3C RID: 59964 RVA: 0x00055C08 File Offset: 0x00053E08
			[Token(Token = "0x17001DD0")]
			protected bool isStopped
			{
				[Token(Token = "0x600EA3C")]
				[Address(RVA = "0x5F1080", Offset = "0x5EFC80", VA = "0x1805F1080")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001DD1 RID: 7633
			// (get) Token: 0x0600EA3D RID: 59965 RVA: 0x00055C20 File Offset: 0x00053E20
			[Token(Token = "0x17001DD1")]
			protected bool hasReached
			{
				[Token(Token = "0x600EA3D")]
				[Address(RVA = "0x5F0F40", Offset = "0x5EFB40", VA = "0x1805F0F40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001DD2 RID: 7634
			// (get) Token: 0x0600EA3E RID: 59966 RVA: 0x00055C38 File Offset: 0x00053E38
			[Token(Token = "0x17001DD2")]
			protected bool behavioursInited
			{
				[Token(Token = "0x600EA3E")]
				[Address(RVA = "0x5F0D50", Offset = "0x5EF950", VA = "0x1805F0D50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001DD3 RID: 7635
			// (get) Token: 0x0600EA3F RID: 59967 RVA: 0x00055C50 File Offset: 0x00053E50
			// (set) Token: 0x0600EA40 RID: 59968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001DD3")]
			private protected uint behaviourUniqueId
			{
				[Token(Token = "0x600EA3F")]
				[Address(RVA = "0x5F0CF0", Offset = "0x5EF8F0", VA = "0x1805F0CF0")]
				[CompilerGenerated]
				protected get
				{
					return 0U;
				}
				[Token(Token = "0x600EA40")]
				[Address(RVA = "0x5F14A0", Offset = "0x5F00A0", VA = "0x1805F14A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600EA41 RID: 59969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA41")]
			[Address(RVA = "0x5F0600", Offset = "0x5EF200", VA = "0x1805F0600", Slot = "4")]
			public virtual void Init(ILocatable start, ILocatable target, Projectile projectile)
			{
			}

			// Token: 0x0600EA42 RID: 59970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA42")]
			[Address(RVA = "0x5EEBA0", Offset = "0x5ED7A0", VA = "0x1805EEBA0", Slot = "5")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600EA43 RID: 59971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA43")]
			[Address(RVA = "0x5F0870", Offset = "0x5EF470", VA = "0x1805F0870", Slot = "6")]
			public virtual void OnProjectileBorn()
			{
			}

			// Token: 0x0600EA44 RID: 59972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA44")]
			[Address(RVA = "0x5EEB40", Offset = "0x5ED740", VA = "0x1805EEB40", Slot = "7")]
			public virtual void OnProjectileStop()
			{
			}

			// Token: 0x0600EA45 RID: 59973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA45")]
			[Address(RVA = "0x5F08D0", Offset = "0x5EF4D0", VA = "0x1805F08D0", Slot = "8")]
			public virtual void OnProjectileTrigger()
			{
			}

			// Token: 0x0600EA46 RID: 59974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA46")]
			[Address(RVA = "0x5EEAE0", Offset = "0x5ED6E0", VA = "0x1805EEAE0", Slot = "9")]
			public virtual void OnProjectileReached()
			{
			}

			// Token: 0x0600EA47 RID: 59975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA47")]
			[Address(RVA = "0x5F0810", Offset = "0x5EF410", VA = "0x1805F0810", Slot = "10")]
			public virtual void OnHitTarget(Entity target)
			{
			}

			// Token: 0x0600EA48 RID: 59976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA48")]
			[Address(RVA = "0x5F07B0", Offset = "0x5EF3B0", VA = "0x1805F07B0", Slot = "11")]
			public virtual void OnHitTargetLeft(Entity target)
			{
			}

			// Token: 0x0600EA49 RID: 59977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA49")]
			[Address(RVA = "0x5F0750", Offset = "0x5EF350", VA = "0x1805F0750", Slot = "12")]
			public virtual void OnAttackTimeChanged(FP newValue)
			{
			}

			// Token: 0x0600EA4A RID: 59978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA4A")]
			[Address(RVA = "0x5F0BF0", Offset = "0x5EF7F0", VA = "0x1805F0BF0", Slot = "13")]
			public virtual void TryRegisterExtraActionNode()
			{
			}

			// Token: 0x0600EA4B RID: 59979 RVA: 0x00055C68 File Offset: 0x00053E68
			[Token(Token = "0x600EA4B")]
			[Address(RVA = "0x5EEA40", Offset = "0x5ED640", VA = "0x1805EEA40", Slot = "14")]
			public virtual FP GetTimeScale()
			{
				return default(FP);
			}

			// Token: 0x0600EA4C RID: 59980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA4C")]
			[Address(RVA = "0x5F09E0", Offset = "0x5EF5E0", VA = "0x1805F09E0")]
			protected void Stop()
			{
			}

			// Token: 0x0600EA4D RID: 59981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA4D")]
			[Address(RVA = "0x5F0930", Offset = "0x5EF530", VA = "0x1805F0930")]
			protected void Reached()
			{
			}

			// Token: 0x0600EA4E RID: 59982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA4E")]
			[Address(RVA = "0x5F0A90", Offset = "0x5EF690", VA = "0x1805F0A90")]
			protected void TouchReached()
			{
			}

			// Token: 0x0600EA4F RID: 59983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA4F")]
			[Address(RVA = "0x5F0B40", Offset = "0x5EF740", VA = "0x1805F0B40")]
			protected void TryClearMainEffectWhenReachedIfNot()
			{
			}

			// Token: 0x0600EA50 RID: 59984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA50")]
			[Address(RVA = "0x5F0400", Offset = "0x5EF000", VA = "0x1805F0400")]
			protected void GetNewEffectIfHooked(ref string effectKey)
			{
			}

			// Token: 0x0600EA51 RID: 59985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA51")]
			[Address(RVA = "0x5F0260", Offset = "0x5EEE60", VA = "0x1805F0260")]
			protected void AssignBodyTransformLocalPos(Vector3 localPos)
			{
			}

			// Token: 0x0600EA52 RID: 59986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA52")]
			[Address(RVA = "0x5F0C50", Offset = "0x5EF850", VA = "0x1805F0C50")]
			protected Behaviour()
			{
			}

			// Token: 0x0401029E RID: 66206
			[Token(Token = "0x401029E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_projectile;

			// Token: 0x0401029F RID: 66207
			[Token(Token = "0x401029F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_projectile;

			// Token: 0x040102A0 RID: 66208
			[Token(Token = "0x40102A0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_traceTarget;

			// Token: 0x040102A1 RID: 66209
			[Token(Token = "0x40102A1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_source;

			// Token: 0x040102A2 RID: 66210
			[Token(Token = "0x40102A2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_currentHitNum;

			// Token: 0x040102A3 RID: 66211
			[Token(Token = "0x40102A3")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_isStopped;

			// Token: 0x040102A4 RID: 66212
			[Token(Token = "0x40102A4")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_hasReached;

			// Token: 0x040102A5 RID: 66213
			[Token(Token = "0x40102A5")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_behavioursInited;

			// Token: 0x040102A6 RID: 66214
			[Token(Token = "0x40102A6")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_behaviourUniqueId;

			// Token: 0x040102A7 RID: 66215
			[Token(Token = "0x40102A7")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_set_behaviourUniqueId;

			// Token: 0x040102A8 RID: 66216
			[Token(Token = "0x40102A8")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x040102A9 RID: 66217
			[Token(Token = "0x40102A9")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x040102AA RID: 66218
			[Token(Token = "0x40102AA")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnProjectileBorn;

			// Token: 0x040102AB RID: 66219
			[Token(Token = "0x40102AB")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnProjectileStop;

			// Token: 0x040102AC RID: 66220
			[Token(Token = "0x40102AC")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_OnProjectileTrigger;

			// Token: 0x040102AD RID: 66221
			[Token(Token = "0x40102AD")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnProjectileReached;

			// Token: 0x040102AE RID: 66222
			[Token(Token = "0x40102AE")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnHitTarget;

			// Token: 0x040102AF RID: 66223
			[Token(Token = "0x40102AF")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_OnHitTargetLeft;

			// Token: 0x040102B0 RID: 66224
			[Token(Token = "0x40102B0")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

			// Token: 0x040102B1 RID: 66225
			[Token(Token = "0x40102B1")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_TryRegisterExtraActionNode;

			// Token: 0x040102B2 RID: 66226
			[Token(Token = "0x40102B2")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_GetTimeScale;

			// Token: 0x040102B3 RID: 66227
			[Token(Token = "0x40102B3")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_Stop;

			// Token: 0x040102B4 RID: 66228
			[Token(Token = "0x40102B4")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_Reached;

			// Token: 0x040102B5 RID: 66229
			[Token(Token = "0x40102B5")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_TouchReached;

			// Token: 0x040102B6 RID: 66230
			[Token(Token = "0x40102B6")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_TryClearMainEffectWhenReachedIfNot;

			// Token: 0x040102B7 RID: 66231
			[Token(Token = "0x40102B7")]
			[FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_GetNewEffectIfHooked;

			// Token: 0x040102B8 RID: 66232
			[Token(Token = "0x40102B8")]
			[FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_AssignBodyTransformLocalPos;

			// Token: 0x040102B9 RID: 66233
			[Token(Token = "0x40102B9")]
			[FieldOffset(Offset = "0xD8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020023DF RID: 9183
		[Token(Token = "0x20023DF")]
		[Serializable]
		public class ActionController
		{
			// Token: 0x17001DD4 RID: 7636
			// (get) Token: 0x0600EA53 RID: 59987 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600EA54 RID: 59988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001DD4")]
			public Blackboard blackboard
			{
				[Token(Token = "0x600EA53")]
				[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600EA54")]
				[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001DD5 RID: 7637
			// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600EA56 RID: 59990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001DD5")]
			public Projectile projectile
			{
				[Token(Token = "0x600EA55")]
				[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600EA56")]
				[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001DD6 RID: 7638
			// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001DD6")]
			public BuffData[] extraBuffsInTheEnd
			{
				[Token(Token = "0x600EA57")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001DD7 RID: 7639
			// (get) Token: 0x0600EA58 RID: 59992 RVA: 0x00055C80 File Offset: 0x00053E80
			[Token(Token = "0x17001DD7")]
			public bool hasExtraBuffsInTheEnd
			{
				[Token(Token = "0x600EA58")]
				[Address(RVA = "0x5EC470", Offset = "0x5EB070", VA = "0x1805EC470")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001DD8 RID: 7640
			// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001DD8")]
			public List<ActionNode>[] actionsToAttach
			{
				[Token(Token = "0x600EA59")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600EA5A RID: 59994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA5A")]
			[Address(RVA = "0x5EA520", Offset = "0x5E9120", VA = "0x1805EA520")]
			public void Init(Ability ability, Projectile projectile)
			{
			}

			// Token: 0x0600EA5B RID: 59995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA5B")]
			[Address(RVA = "0x5EA380", Offset = "0x5E8F80", VA = "0x1805EA380")]
			public void InitFromProjectile(Projectile sourceProjectile, Projectile projectile)
			{
			}

			// Token: 0x0600EA5C RID: 59996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA5C")]
			[Address(RVA = "0x5EADA0", Offset = "0x5E99A0", VA = "0x1805EADA0")]
			public void RegisterActions(Projectile.Event ev, IList<ActionNode> actions, bool additive)
			{
			}

			// Token: 0x0600EA5D RID: 59997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA5D")]
			[Address(RVA = "0x5EAF80", Offset = "0x5E9B80", VA = "0x1805EAF80")]
			public void RegisterBuffs(IList<BuffData> buffDataList, bool additive)
			{
			}

			// Token: 0x0600EA5E RID: 59998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA5E")]
			[Address(RVA = "0x5EB090", Offset = "0x5E9C90", VA = "0x1805EB090")]
			public void RegisterExtraBlackboard(Blackboard extraBlackboard, bool additive)
			{
			}

			// Token: 0x0600EA5F RID: 59999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA5F")]
			[Address(RVA = "0x5EA7F0", Offset = "0x5E93F0", VA = "0x1805EA7F0")]
			public void OnHitTarget(Entity target)
			{
			}

			// Token: 0x0600EA60 RID: 60000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA60")]
			[Address(RVA = "0x5EA700", Offset = "0x5E9300", VA = "0x1805EA700")]
			public void OnHitTargetLeft(Entity target)
			{
			}

			// Token: 0x0600EA61 RID: 60001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA61")]
			[Address(RVA = "0x5EA9E0", Offset = "0x5E95E0", VA = "0x1805EA9E0")]
			public void OnProjectileStop()
			{
			}

			// Token: 0x0600EA62 RID: 60002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA62")]
			[Address(RVA = "0x5EAD90", Offset = "0x5E9990", VA = "0x1805EAD90")]
			public void OnProjectileTrigger()
			{
			}

			// Token: 0x0600EA63 RID: 60003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA63")]
			[Address(RVA = "0x5EA980", Offset = "0x5E9580", VA = "0x1805EA980")]
			public void OnProjectileBorn()
			{
			}

			// Token: 0x0600EA64 RID: 60004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA64")]
			[Address(RVA = "0x5EA990", Offset = "0x5E9590", VA = "0x1805EA990")]
			public void OnProjectileReached()
			{
			}

			// Token: 0x0600EA65 RID: 60005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EA65")]
			[Address(RVA = "0x5EA350", Offset = "0x5E8F50", VA = "0x1805EA350")]
			public IList<ActionNode> GetActionNodes(Projectile.Event ev)
			{
				return null;
			}

			// Token: 0x0600EA66 RID: 60006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA66")]
			[Address(RVA = "0x5EB160", Offset = "0x5E9D60", VA = "0x1805EB160")]
			public void ReplaceActionNodes(Projectile.Event ev, List<ActionNode> newActionNodes)
			{
			}

			// Token: 0x0600EA67 RID: 60007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA67")]
			[Address(RVA = "0x5EC040", Offset = "0x5EAC40", VA = "0x1805EC040")]
			private void _RunActions(Projectile.Event ev, Entity rewriteTarget)
			{
			}

			// Token: 0x0600EA68 RID: 60008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA68")]
			[Address(RVA = "0x5EB180", Offset = "0x5E9D80", VA = "0x1805EB180")]
			internal void RunActionsOnTile(Projectile.Event ev, Tile tile)
			{
			}

			// Token: 0x0600EA69 RID: 60009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA69")]
			[Address(RVA = "0x5EB460", Offset = "0x5EA060", VA = "0x1805EB460")]
			private void _AttachBuffs(IList<BuffData> buffs, Entity target)
			{
			}

			// Token: 0x0600EA6A RID: 60010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA6A")]
			[Address(RVA = "0x5EBC00", Offset = "0x5EA800", VA = "0x1805EBC00")]
			private void _AttachExtraBuffWhenStopHit(Entity target)
			{
			}

			// Token: 0x0600EA6B RID: 60011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA6B")]
			[Address(RVA = "0x5EBE60", Offset = "0x5EAA60", VA = "0x1805EBE60")]
			private void _AttachExtraBuffWhenStop()
			{
			}

			// Token: 0x0600EA6C RID: 60012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA6C")]
			[Address(RVA = "0x5EB9A0", Offset = "0x5EA5A0", VA = "0x1805EB9A0")]
			private void _AttachExtraBuffWhenReached(Entity target)
			{
			}

			// Token: 0x0600EA6D RID: 60013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA6D")]
			[Address(RVA = "0x5EA1B0", Offset = "0x5E8DB0", VA = "0x1805EA1B0")]
			private void AttachExtraBuffsToTargetMap(Entity target, Buff buff)
			{
			}

			// Token: 0x0600EA6E RID: 60014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA6E")]
			[Address(RVA = "0x5EC350", Offset = "0x5EAF50", VA = "0x1805EC350")]
			public ActionController()
			{
			}

			// Token: 0x040102BA RID: 66234
			[Token(Token = "0x40102BA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _detachBuffsWhenTargetLeave;

			// Token: 0x040102BB RID: 66235
			[Token(Token = "0x40102BB")]
			[FieldOffset(Offset = "0x11")]
			[SerializeField]
			private bool _detachAllBuffsWhenStopped;

			// Token: 0x040102BC RID: 66236
			[Token(Token = "0x40102BC")]
			[FieldOffset(Offset = "0x12")]
			[SerializeField]
			private bool _onlyAddBuffsToTraceTarget;

			// Token: 0x040102BD RID: 66237
			[Token(Token = "0x40102BD")]
			[FieldOffset(Offset = "0x13")]
			[SerializeField]
			private bool _onlyAddBuffsToTargetOnce;

			// Token: 0x040102BE RID: 66238
			[Token(Token = "0x40102BE")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private bool _dontAddBuffs;

			// Token: 0x040102BF RID: 66239
			[Token(Token = "0x40102BF")]
			[FieldOffset(Offset = "0x15")]
			[SerializeField]
			private bool _excludeAttachments;

			// Token: 0x040102C0 RID: 66240
			[Token(Token = "0x40102C0")]
			[FieldOffset(Offset = "0x16")]
			[SerializeField]
			private bool _useSelfBlackboard;

			// Token: 0x040102C1 RID: 66241
			[Token(Token = "0x40102C1")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private BuffData[] _extraBuffsInTheEnd;

			// Token: 0x040102C2 RID: 66242
			[Token(Token = "0x40102C2")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Inspect("hasExtraBuffsInTheEnd")]
			private bool _useExtraBuffsWhenStopHit;

			// Token: 0x040102C3 RID: 66243
			[Token(Token = "0x40102C3")]
			[FieldOffset(Offset = "0x21")]
			[SerializeField]
			[Inspect("hasExtraBuffsInTheEnd")]
			private bool _addExtraBuffsWhenReached;

			// Token: 0x040102C4 RID: 66244
			[Token(Token = "0x40102C4")]
			[FieldOffset(Offset = "0x22")]
			[SerializeField]
			[Inspect("hasExtraBuffsInTheEnd")]
			private bool _detachAllExtraBuffsWhenStopped;

			// Token: 0x040102C5 RID: 66245
			[Token(Token = "0x40102C5")]
			[FieldOffset(Offset = "0x24")]
			private int m_addBuffsToTargetCnt;

			// Token: 0x040102C6 RID: 66246
			[Token(Token = "0x40102C6")]
			[FieldOffset(Offset = "0x28")]
			private List<ActionNode>[] m_actionsToAttach;

			// Token: 0x040102C7 RID: 66247
			[Token(Token = "0x40102C7")]
			[FieldOffset(Offset = "0x30")]
			private List<BuffData> m_buffsToAttach;

			// Token: 0x040102C8 RID: 66248
			[Token(Token = "0x40102C8")]
			[FieldOffset(Offset = "0x38")]
			private IList<IAbilityAttachment> m_attachmentsToAttach;

			// Token: 0x040102C9 RID: 66249
			[Token(Token = "0x40102C9")]
			[FieldOffset(Offset = "0x40")]
			private Dictionary<ObjectPtr<Entity>, List<uint>> m_attachedBuffsForTargetMap;

			// Token: 0x040102CA RID: 66250
			[Token(Token = "0x40102CA")]
			[FieldOffset(Offset = "0x48")]
			private Dictionary<ObjectPtr<Entity>, List<uint>> m_attachedExtraBuffsForTargetMap;
		}

		// Token: 0x020023E0 RID: 9184
		[Token(Token = "0x20023E0")]
		[Serializable]
		public class EventToActionPair : ActionKV<Projectile.Event>
		{
			// Token: 0x0600EA6F RID: 60015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA6F")]
			[Address(RVA = "0x5F2430", Offset = "0x5F1030", VA = "0x1805F2430")]
			public EventToActionPair()
			{
			}
		}

		// Token: 0x020023E1 RID: 9185
		[Token(Token = "0x20023E1")]
		[Serializable]
		public class EventToActionMap : ActionDict<Projectile.Event, Projectile.EventToActionPair>
		{
			// Token: 0x0600EA70 RID: 60016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EA70")]
			[Address(RVA = "0x5F23F0", Offset = "0x5F0FF0", VA = "0x1805F23F0")]
			public EventToActionMap()
			{
			}
		}
	}
}
