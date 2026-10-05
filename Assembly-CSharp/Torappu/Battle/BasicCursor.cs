using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002369 RID: 9065
	[Token(Token = "0x2002369")]
	public class BasicCursor : IHotfixable
	{
		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x00053370 File Offset: 0x00051570
		// (set) Token: 0x0600E5BB RID: 58811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001CCF")]
		public bool ignoreAllButMoveCp
		{
			[Token(Token = "0x600E5BA")]
			[Address(RVA = "0x5B6DE0", Offset = "0x5B59E0", VA = "0x1805B6DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E5BB")]
			[Address(RVA = "0x5B7160", Offset = "0x5B5D60", VA = "0x1805B7160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x0600E5BC RID: 58812 RVA: 0x00053388 File Offset: 0x00051588
		// (set) Token: 0x0600E5BD RID: 58813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001CD0")]
		public bool visitEveryTileCenter
		{
			[Token(Token = "0x600E5BC")]
			[Address(RVA = "0x5B7100", Offset = "0x5B5D00", VA = "0x1805B7100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E5BD")]
			[Address(RVA = "0x5B7340", Offset = "0x5B5F40", VA = "0x1805B7340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x0600E5BE RID: 58814 RVA: 0x000533A0 File Offset: 0x000515A0
		// (set) Token: 0x0600E5BF RID: 58815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001CD1")]
		public bool visitEveryNodeCenter
		{
			[Token(Token = "0x600E5BE")]
			[Address(RVA = "0x5B7040", Offset = "0x5B5C40", VA = "0x1805B7040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E5BF")]
			[Address(RVA = "0x5B7260", Offset = "0x5B5E60", VA = "0x1805B7260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x000533B8 File Offset: 0x000515B8
		[Token(Token = "0x17001CD2")]
		public MotionMode motionMode
		{
			[Token(Token = "0x600E5C0")]
			[Address(RVA = "0x5B6E40", Offset = "0x5B5A40", VA = "0x1805B6E40")]
			get
			{
				return MotionMode.WALK;
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CD3")]
		public Route route
		{
			[Token(Token = "0x600E5C1")]
			[Address(RVA = "0x5B6F60", Offset = "0x5B5B60", VA = "0x1805B6F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x000533D0 File Offset: 0x000515D0
		// (set) Token: 0x0600E5C3 RID: 58819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001CD4")]
		public Scheduler.SchedulerSnapshot snapshot
		{
			[Token(Token = "0x600E5C2")]
			[Address(RVA = "0x5B6FC0", Offset = "0x5B5BC0", VA = "0x1805B6FC0")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.SchedulerSnapshot);
			}
			[Token(Token = "0x600E5C3")]
			[Address(RVA = "0x5B71D0", Offset = "0x5B5DD0", VA = "0x1805B71D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x0600E5C4 RID: 58820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CD5")]
		public System.Random random
		{
			[Token(Token = "0x600E5C4")]
			[Address(RVA = "0x5B6EB0", Offset = "0x5B5AB0", VA = "0x1805B6EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x000533E8 File Offset: 0x000515E8
		[Token(Token = "0x17001CD6")]
		public virtual bool alwaysCheckCurrentPoint
		{
			[Token(Token = "0x600E5C5")]
			[Address(RVA = "0x5B6D80", Offset = "0x5B5980", VA = "0x1805B6D80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x0600E5C6 RID: 58822 RVA: 0x00053400 File Offset: 0x00051600
		// (set) Token: 0x0600E5C7 RID: 58823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001CD7")]
		private protected bool visitEveryNodeStably
		{
			[Token(Token = "0x600E5C6")]
			[Address(RVA = "0x5B70A0", Offset = "0x5B5CA0", VA = "0x1805B70A0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600E5C7")]
			[Address(RVA = "0x5B72D0", Offset = "0x5B5ED0", VA = "0x1805B72D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600E5C8 RID: 58824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5C8")]
		[Address(RVA = "0x5B68E0", Offset = "0x5B54E0", VA = "0x1805B68E0")]
		protected BasicCursor(Route route, Scheduler.SchedulerSnapshot snapshot, BObject obj, bool ignoreAllButMoveCp = false, bool visitEveryTileCenter = false, bool visitEveryNodeCenter = false)
		{
		}

		// Token: 0x0600E5C9 RID: 58825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5C9")]
		[Address(RVA = "0x5B5C10", Offset = "0x5B4810", VA = "0x1805B5C10")]
		public void OnRouteChanged(Route route)
		{
		}

		// Token: 0x0600E5CA RID: 58826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5CA")]
		[Address(RVA = "0x5B5F30", Offset = "0x5B4B30", VA = "0x1805B5F30", Slot = "5")]
		public virtual void Reset()
		{
		}

		// Token: 0x0600E5CB RID: 58827 RVA: 0x00053418 File Offset: 0x00051618
		[Token(Token = "0x600E5CB")]
		[Address(RVA = "0x5B5840", Offset = "0x5B4440", VA = "0x1805B5840", Slot = "6")]
		public virtual Vector2 GetContDirectionAfterEnd()
		{
			return default(Vector2);
		}

		// Token: 0x0600E5CC RID: 58828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5CC")]
		[Address(RVA = "0x5B6060", Offset = "0x5B4C60", VA = "0x1805B6060")]
		public void SkipNextCheckPoint(bool skipWait = false)
		{
		}

		// Token: 0x0600E5CD RID: 58829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5CD")]
		[Address(RVA = "0x5B6640", Offset = "0x5B5240", VA = "0x1805B6640")]
		protected void _MoveNext()
		{
		}

		// Token: 0x0600E5CE RID: 58830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E5CE")]
		[Address(RVA = "0x5B6120", Offset = "0x5B4D20", VA = "0x1805B6120")]
		private BasicCursor.Checkpoint _CreateCheckpoint(RouteData.CheckpointData data, Route.Node[,] nextMap)
		{
			return null;
		}

		// Token: 0x0600E5CF RID: 58831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5CF")]
		[Address(RVA = "0x5B5A60", Offset = "0x5B4660", VA = "0x1805B5A60")]
		public void IgnoreAllButMoveCp(bool value)
		{
		}

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5D0")]
		[Address(RVA = "0x5B5FE0", Offset = "0x5B4BE0", VA = "0x1805B5FE0")]
		public void SkipCheckPoint()
		{
		}

		// Token: 0x0400FD83 RID: 64899
		[Token(Token = "0x400FD83")]
		[FieldOffset(Offset = "0x10")]
		protected Route m_route;

		// Token: 0x0400FD84 RID: 64900
		[Token(Token = "0x400FD84")]
		[FieldOffset(Offset = "0x18")]
		protected int m_cursor;

		// Token: 0x0400FD85 RID: 64901
		[Token(Token = "0x400FD85")]
		[FieldOffset(Offset = "0x1C")]
		protected Vector2 m_cachedDirection;

		// Token: 0x0400FD86 RID: 64902
		[Token(Token = "0x400FD86")]
		[FieldOffset(Offset = "0x28")]
		protected BasicCursor.Checkpoint[] m_checkpoints;

		// Token: 0x0400FD87 RID: 64903
		[Token(Token = "0x400FD87")]
		[FieldOffset(Offset = "0x30")]
		protected BObject m_obj;

		// Token: 0x0400FD8D RID: 64909
		[Token(Token = "0x400FD8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ignoreAllButMoveCp;

		// Token: 0x0400FD8E RID: 64910
		[Token(Token = "0x400FD8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ignoreAllButMoveCp;

		// Token: 0x0400FD8F RID: 64911
		[Token(Token = "0x400FD8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_visitEveryTileCenter;

		// Token: 0x0400FD90 RID: 64912
		[Token(Token = "0x400FD90")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_visitEveryTileCenter;

		// Token: 0x0400FD91 RID: 64913
		[Token(Token = "0x400FD91")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_visitEveryNodeCenter;

		// Token: 0x0400FD92 RID: 64914
		[Token(Token = "0x400FD92")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_visitEveryNodeCenter;

		// Token: 0x0400FD93 RID: 64915
		[Token(Token = "0x400FD93")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_motionMode;

		// Token: 0x0400FD94 RID: 64916
		[Token(Token = "0x400FD94")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_route;

		// Token: 0x0400FD95 RID: 64917
		[Token(Token = "0x400FD95")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_snapshot;

		// Token: 0x0400FD96 RID: 64918
		[Token(Token = "0x400FD96")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_snapshot;

		// Token: 0x0400FD97 RID: 64919
		[Token(Token = "0x400FD97")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_random;

		// Token: 0x0400FD98 RID: 64920
		[Token(Token = "0x400FD98")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_alwaysCheckCurrentPoint;

		// Token: 0x0400FD99 RID: 64921
		[Token(Token = "0x400FD99")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_visitEveryNodeStably;

		// Token: 0x0400FD9A RID: 64922
		[Token(Token = "0x400FD9A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_visitEveryNodeStably;

		// Token: 0x0400FD9B RID: 64923
		[Token(Token = "0x400FD9B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FD9C RID: 64924
		[Token(Token = "0x400FD9C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnRouteChanged;

		// Token: 0x0400FD9D RID: 64925
		[Token(Token = "0x400FD9D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400FD9E RID: 64926
		[Token(Token = "0x400FD9E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetContDirectionAfterEnd;

		// Token: 0x0400FD9F RID: 64927
		[Token(Token = "0x400FD9F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SkipNextCheckPoint;

		// Token: 0x0400FDA0 RID: 64928
		[Token(Token = "0x400FDA0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__MoveNext;

		// Token: 0x0400FDA1 RID: 64929
		[Token(Token = "0x400FDA1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CreateCheckpoint;

		// Token: 0x0400FDA2 RID: 64930
		[Token(Token = "0x400FDA2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IgnoreAllButMoveCp;

		// Token: 0x0400FDA3 RID: 64931
		[Token(Token = "0x400FDA3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SkipCheckPoint;

		// Token: 0x0200236A RID: 9066
		[Token(Token = "0x200236A")]
		protected abstract class Checkpoint
		{
			// Token: 0x17001CD8 RID: 7384
			// (get) Token: 0x0600E5D1 RID: 58833 RVA: 0x00053430 File Offset: 0x00051630
			[Token(Token = "0x17001CD8")]
			public CheckpointType type
			{
				[Token(Token = "0x600E5D1")]
				[Address(RVA = "0x5BA1B0", Offset = "0x5B8DB0", VA = "0x1805BA1B0")]
				get
				{
					return CheckpointType.MOVE;
				}
			}

			// Token: 0x17001CD9 RID: 7385
			// (get) Token: 0x0600E5D2 RID: 58834 RVA: 0x00053448 File Offset: 0x00051648
			[Token(Token = "0x17001CD9")]
			public virtual bool needUpdateLocationAfterReached
			{
				[Token(Token = "0x600E5D2")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001CDA RID: 7386
			// (get) Token: 0x0600E5D3 RID: 58835 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600E5D4 RID: 58836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001CDA")]
			private protected RouteData.CheckpointData data
			{
				[Token(Token = "0x600E5D3")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600E5D4")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001CDB RID: 7387
			// (get) Token: 0x0600E5D5 RID: 58837 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600E5D6 RID: 58838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001CDB")]
			private protected BasicCursor cursor
			{
				[Token(Token = "0x600E5D5")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600E5D6")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001CDC RID: 7388
			// (get) Token: 0x0600E5D7 RID: 58839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001CDC")]
			protected BObject obj
			{
				[Token(Token = "0x600E5D7")]
				[Address(RVA = "0x5BA120", Offset = "0x5B8D20", VA = "0x1805BA120")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001CDD RID: 7389
			// (get) Token: 0x0600E5D8 RID: 58840 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001CDD")]
			protected Route route
			{
				[Token(Token = "0x600E5D8")]
				[Address(RVA = "0x5BA140", Offset = "0x5B8D40", VA = "0x1805BA140")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600E5D9 RID: 58841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5D9")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public Checkpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E5DA RID: 58842
			[Token(Token = "0x600E5DA")]
			public abstract Vector2 GetNextDirection(Vector2 pos);

			// Token: 0x0600E5DB RID: 58843
			[Token(Token = "0x600E5DB")]
			public abstract GridPosition GetNextGrid(GridPosition grid);

			// Token: 0x0600E5DC RID: 58844
			[Token(Token = "0x600E5DC")]
			public abstract bool CheckReached(Vector2 pos);

			// Token: 0x0600E5DD RID: 58845
			[Token(Token = "0x600E5DD")]
			public abstract bool CheckReached(GridPosition grid);

			// Token: 0x0600E5DE RID: 58846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5DE")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600E5DF RID: 58847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5DF")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
			public virtual void OnBegin()
			{
			}

			// Token: 0x0600E5E0 RID: 58848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5E0")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
			public virtual void OnEnd()
			{
			}

			// Token: 0x0600E5E1 RID: 58849 RVA: 0x00053460 File Offset: 0x00051660
			[Token(Token = "0x600E5E1")]
			[Address(RVA = "0x5BA110", Offset = "0x5B8D10", VA = "0x1805BA110", Slot = "12")]
			public virtual int NextCursor(int cur_cursor)
			{
				return 0;
			}
		}

		// Token: 0x0200236B RID: 9067
		[Token(Token = "0x200236B")]
		protected abstract class PosRelatedCheckpoint : BasicCursor.Checkpoint
		{
			// Token: 0x17001CDE RID: 7390
			// (get) Token: 0x0600E5E2 RID: 58850
			[Token(Token = "0x17001CDE")]
			public abstract GridPosition targetGrid { [Token(Token = "0x600E5E2")] get; }

			// Token: 0x17001CDF RID: 7391
			// (get) Token: 0x0600E5E3 RID: 58851
			[Token(Token = "0x17001CDF")]
			public abstract Vector2 targetPos { [Token(Token = "0x600E5E3")] get; }

			// Token: 0x0600E5E4 RID: 58852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5E4")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public PosRelatedCheckpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}
		}

		// Token: 0x0200236C RID: 9068
		[Token(Token = "0x200236C")]
		protected class MoveCheckpoint : BasicCursor.PosRelatedCheckpoint
		{
			// Token: 0x17001CE0 RID: 7392
			// (get) Token: 0x0600E5E5 RID: 58853 RVA: 0x00053478 File Offset: 0x00051678
			[Token(Token = "0x17001CE0")]
			public override GridPosition targetGrid
			{
				[Token(Token = "0x600E5E5")]
				[Address(RVA = "0x5B5460", Offset = "0x5B4060", VA = "0x1805B5460", Slot = "13")]
				get
				{
					return default(GridPosition);
				}
			}

			// Token: 0x17001CE1 RID: 7393
			// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x00053490 File Offset: 0x00051690
			[Token(Token = "0x17001CE1")]
			public override Vector2 targetPos
			{
				[Token(Token = "0x600E5E6")]
				[Address(RVA = "0x5C5620", Offset = "0x5C4220", VA = "0x1805C5620", Slot = "14")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x0600E5E7 RID: 58855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5E7")]
			[Address(RVA = "0x5C55B0", Offset = "0x5C41B0", VA = "0x1805C55B0")]
			public MoveCheckpoint(RouteData.CheckpointData data, Route.Node[,] nextMap, BasicCursor cursor)
			{
			}

			// Token: 0x0600E5E8 RID: 58856 RVA: 0x000534A8 File Offset: 0x000516A8
			[Token(Token = "0x600E5E8")]
			[Address(RVA = "0x5C5220", Offset = "0x5C3E20", VA = "0x1805C5220", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E5E9 RID: 58857 RVA: 0x000534C0 File Offset: 0x000516C0
			[Token(Token = "0x600E5E9")]
			[Address(RVA = "0x5C5400", Offset = "0x5C4000", VA = "0x1805C5400", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E5EA RID: 58858 RVA: 0x000534D8 File Offset: 0x000516D8
			[Token(Token = "0x600E5EA")]
			[Address(RVA = "0x5C5470", Offset = "0x5C4070", VA = "0x1805C5470")]
			public Vector2 GetNextTurn(GridPosition grid)
			{
				return default(Vector2);
			}

			// Token: 0x0600E5EB RID: 58859 RVA: 0x000534F0 File Offset: 0x000516F0
			[Token(Token = "0x600E5EB")]
			[Address(RVA = "0x5C4D40", Offset = "0x5C3940", VA = "0x1805C4D40", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E5EC RID: 58860 RVA: 0x00053508 File Offset: 0x00051708
			[Token(Token = "0x600E5EC")]
			[Address(RVA = "0x5C4BD0", Offset = "0x5C37D0", VA = "0x1805C4BD0", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}

			// Token: 0x0600E5ED RID: 58861 RVA: 0x00053520 File Offset: 0x00051720
			[Token(Token = "0x600E5ED")]
			[Address(RVA = "0x5C4F60", Offset = "0x5C3B60", VA = "0x1805C4F60")]
			public float GetEstimatedDistToFinal(Vector2 pos)
			{
				return 0f;
			}

			// Token: 0x0600E5EE RID: 58862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5EE")]
			[Address(RVA = "0x5C54D0", Offset = "0x5C40D0", VA = "0x1805C54D0", Slot = "10")]
			public override void OnBegin()
			{
			}

			// Token: 0x0400FDA6 RID: 64934
			[Token(Token = "0x400FDA6")]
			[FieldOffset(Offset = "0x20")]
			protected Vector2 m_offset;

			// Token: 0x0400FDA7 RID: 64935
			[Token(Token = "0x400FDA7")]
			[FieldOffset(Offset = "0x28")]
			protected Route.Node[,] m_nextmap;
		}

		// Token: 0x0200236D RID: 9069
		[Token(Token = "0x200236D")]
		protected class PatrolMoveCheckpoint : BasicCursor.MoveCheckpoint
		{
			// Token: 0x0600E5EF RID: 58863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5EF")]
			[Address(RVA = "0x5C2690", Offset = "0x5C1290", VA = "0x1805C2690")]
			public PatrolMoveCheckpoint(RouteData.CheckpointData data, Route.Node[,] nextMap, BasicCursor cursor)
			{
			}

			// Token: 0x0600E5F0 RID: 58864 RVA: 0x00053538 File Offset: 0x00051738
			[Token(Token = "0x600E5F0")]
			[Address(RVA = "0x5C59D0", Offset = "0x5C45D0", VA = "0x1805C59D0")]
			private bool IsValidPatrolCheckPoint(BasicCursor.Checkpoint cp)
			{
				return default(bool);
			}

			// Token: 0x0600E5F1 RID: 58865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5F1")]
			[Address(RVA = "0x5C5CE0", Offset = "0x5C48E0", VA = "0x1805C5CE0", Slot = "9")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600E5F2 RID: 58866 RVA: 0x00053550 File Offset: 0x00051750
			[Token(Token = "0x600E5F2")]
			[Address(RVA = "0x5C5A00", Offset = "0x5C4600", VA = "0x1805C5A00", Slot = "12")]
			public override int NextCursor(int cur_cursor)
			{
				return 0;
			}

			// Token: 0x0400FDA8 RID: 64936
			[Token(Token = "0x400FDA8")]
			private const int LOOP_MAX = 50;

			// Token: 0x0400FDA9 RID: 64937
			[Token(Token = "0x400FDA9")]
			[FieldOffset(Offset = "0x30")]
			private int m_loopCursor;
		}

		// Token: 0x0200236E RID: 9070
		[Token(Token = "0x200236E")]
		protected class DisappearCheckpoint : BasicCursor.Checkpoint
		{
			// Token: 0x0600E5F3 RID: 58867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5F3")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public DisappearCheckpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E5F4 RID: 58868 RVA: 0x00053568 File Offset: 0x00051768
			[Token(Token = "0x600E5F4")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}

			// Token: 0x0600E5F5 RID: 58869 RVA: 0x00053580 File Offset: 0x00051780
			[Token(Token = "0x600E5F5")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E5F6 RID: 58870 RVA: 0x00053598 File Offset: 0x00051798
			[Token(Token = "0x600E5F6")]
			[Address(RVA = "0x4E40F0", Offset = "0x4E2CF0", VA = "0x1804E40F0", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E5F7 RID: 58871 RVA: 0x000535B0 File Offset: 0x000517B0
			[Token(Token = "0x600E5F7")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E5F8 RID: 58872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5F8")]
			[Address(RVA = "0x5BF490", Offset = "0x5BE090", VA = "0x1805BF490", Slot = "10")]
			public override void OnBegin()
			{
			}
		}

		// Token: 0x0200236F RID: 9071
		[Token(Token = "0x200236F")]
		protected class AppearAtPosCheckpoint : BasicCursor.PosRelatedCheckpoint
		{
			// Token: 0x17001CE2 RID: 7394
			// (get) Token: 0x0600E5F9 RID: 58873 RVA: 0x000535C8 File Offset: 0x000517C8
			[Token(Token = "0x17001CE2")]
			public override GridPosition targetGrid
			{
				[Token(Token = "0x600E5F9")]
				[Address(RVA = "0x5B5460", Offset = "0x5B4060", VA = "0x1805B5460", Slot = "13")]
				get
				{
					return default(GridPosition);
				}
			}

			// Token: 0x17001CE3 RID: 7395
			// (get) Token: 0x0600E5FA RID: 58874 RVA: 0x000535E0 File Offset: 0x000517E0
			[Token(Token = "0x17001CE3")]
			public override Vector2 targetPos
			{
				[Token(Token = "0x600E5FA")]
				[Address(RVA = "0x5B5480", Offset = "0x5B4080", VA = "0x1805B5480", Slot = "14")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17001CE4 RID: 7396
			// (get) Token: 0x0600E5FB RID: 58875 RVA: 0x000535F8 File Offset: 0x000517F8
			[Token(Token = "0x17001CE4")]
			public override bool needUpdateLocationAfterReached
			{
				[Token(Token = "0x600E5FB")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E5FC RID: 58876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5FC")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public AppearAtPosCheckpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E5FD RID: 58877 RVA: 0x00053610 File Offset: 0x00051810
			[Token(Token = "0x600E5FD")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}

			// Token: 0x0600E5FE RID: 58878 RVA: 0x00053628 File Offset: 0x00051828
			[Token(Token = "0x600E5FE")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E5FF RID: 58879 RVA: 0x00053640 File Offset: 0x00051840
			[Token(Token = "0x600E5FF")]
			[Address(RVA = "0x4E40F0", Offset = "0x4E2CF0", VA = "0x1804E40F0", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E600 RID: 58880 RVA: 0x00053658 File Offset: 0x00051858
			[Token(Token = "0x600E600")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E601 RID: 58881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E601")]
			[Address(RVA = "0x5B53E0", Offset = "0x5B3FE0", VA = "0x1805B53E0", Slot = "10")]
			public override void OnBegin()
			{
			}
		}

		// Token: 0x02002370 RID: 9072
		[Token(Token = "0x2002370")]
		protected class WaitForSecondsCheckpoint : BasicCursor.Checkpoint
		{
			// Token: 0x17001CE5 RID: 7397
			// (get) Token: 0x0600E602 RID: 58882 RVA: 0x00053670 File Offset: 0x00051870
			[Token(Token = "0x17001CE5")]
			public bool isReached
			{
				[Token(Token = "0x600E602")]
				[Address(RVA = "0x5CCC50", Offset = "0x5CB850", VA = "0x1805CCC50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E603 RID: 58883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E603")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public WaitForSecondsCheckpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E604 RID: 58884 RVA: 0x00053688 File Offset: 0x00051888
			[Token(Token = "0x600E604")]
			[Address(RVA = "0x4E40F0", Offset = "0x4E2CF0", VA = "0x1804E40F0", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E605 RID: 58885 RVA: 0x000536A0 File Offset: 0x000518A0
			[Token(Token = "0x600E605")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E606 RID: 58886 RVA: 0x000536B8 File Offset: 0x000518B8
			[Token(Token = "0x600E606")]
			[Address(RVA = "0x5CCC50", Offset = "0x5CB850", VA = "0x1805CCC50", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E607 RID: 58887 RVA: 0x000536D0 File Offset: 0x000518D0
			[Token(Token = "0x600E607")]
			[Address(RVA = "0x5CCC50", Offset = "0x5CB850", VA = "0x1805CCC50", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}

			// Token: 0x0600E608 RID: 58888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E608")]
			[Address(RVA = "0x5CCCB0", Offset = "0x5CB8B0", VA = "0x1805CCCB0", Slot = "10")]
			public override void OnBegin()
			{
			}

			// Token: 0x0600E609 RID: 58889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E609")]
			[Address(RVA = "0x5CCD20", Offset = "0x5CB920", VA = "0x1805CCD20", Slot = "9")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600E60A RID: 58890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E60A")]
			[Address(RVA = "0x5CCDD0", Offset = "0x5CB9D0", VA = "0x1805CCDD0")]
			public void Skip()
			{
			}

			// Token: 0x0400FDAA RID: 64938
			[Token(Token = "0x400FDAA")]
			[FieldOffset(Offset = "0x20")]
			private FP m_time;
		}

		// Token: 0x02002371 RID: 9073
		[Token(Token = "0x2002371")]
		protected class WaitForPlayTimeCheckpoint : BasicCursor.Checkpoint
		{
			// Token: 0x17001CE6 RID: 7398
			// (get) Token: 0x0600E60B RID: 58891 RVA: 0x000536E8 File Offset: 0x000518E8
			[Token(Token = "0x17001CE6")]
			public bool isReached
			{
				[Token(Token = "0x600E60B")]
				[Address(RVA = "0x5CCBA0", Offset = "0x5CB7A0", VA = "0x1805CCBA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E60C RID: 58892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E60C")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public WaitForPlayTimeCheckpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E60D RID: 58893 RVA: 0x00053700 File Offset: 0x00051900
			[Token(Token = "0x600E60D")]
			[Address(RVA = "0x4E40F0", Offset = "0x4E2CF0", VA = "0x1804E40F0", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E60E RID: 58894 RVA: 0x00053718 File Offset: 0x00051918
			[Token(Token = "0x600E60E")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E60F RID: 58895 RVA: 0x00053730 File Offset: 0x00051930
			[Token(Token = "0x600E60F")]
			[Address(RVA = "0x5CCB90", Offset = "0x5CB790", VA = "0x1805CCB90", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E610 RID: 58896 RVA: 0x00053748 File Offset: 0x00051948
			[Token(Token = "0x600E610")]
			[Address(RVA = "0x5CCB90", Offset = "0x5CB790", VA = "0x1805CCB90", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}
		}

		// Token: 0x02002372 RID: 9074
		[Token(Token = "0x2002372")]
		protected class WaitCurrentWaveTimeCheckpoint : BasicCursor.Checkpoint
		{
			// Token: 0x17001CE7 RID: 7399
			// (get) Token: 0x0600E611 RID: 58897 RVA: 0x00053760 File Offset: 0x00051960
			[Token(Token = "0x17001CE7")]
			public bool isReached
			{
				[Token(Token = "0x600E611")]
				[Address(RVA = "0x5CCA60", Offset = "0x5CB660", VA = "0x1805CCA60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E612 RID: 58898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E612")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public WaitCurrentWaveTimeCheckpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E613 RID: 58899 RVA: 0x00053778 File Offset: 0x00051978
			[Token(Token = "0x600E613")]
			[Address(RVA = "0x4E40F0", Offset = "0x4E2CF0", VA = "0x1804E40F0", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E614 RID: 58900 RVA: 0x00053790 File Offset: 0x00051990
			[Token(Token = "0x600E614")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E615 RID: 58901 RVA: 0x000537A8 File Offset: 0x000519A8
			[Token(Token = "0x600E615")]
			[Address(RVA = "0x5CCA50", Offset = "0x5CB650", VA = "0x1805CCA50", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E616 RID: 58902 RVA: 0x000537C0 File Offset: 0x000519C0
			[Token(Token = "0x600E616")]
			[Address(RVA = "0x5CCA50", Offset = "0x5CB650", VA = "0x1805CCA50", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}
		}

		// Token: 0x02002373 RID: 9075
		[Token(Token = "0x2002373")]
		protected class WaitCurrentFragmentTimeCheckpoint : BasicCursor.Checkpoint
		{
			// Token: 0x17001CE8 RID: 7400
			// (get) Token: 0x0600E617 RID: 58903 RVA: 0x000537D8 File Offset: 0x000519D8
			[Token(Token = "0x17001CE8")]
			public bool isReached
			{
				[Token(Token = "0x600E617")]
				[Address(RVA = "0x5CC920", Offset = "0x5CB520", VA = "0x1805CC920")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E618 RID: 58904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E618")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public WaitCurrentFragmentTimeCheckpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E619 RID: 58905 RVA: 0x000537F0 File Offset: 0x000519F0
			[Token(Token = "0x600E619")]
			[Address(RVA = "0x4E40F0", Offset = "0x4E2CF0", VA = "0x1804E40F0", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E61A RID: 58906 RVA: 0x00053808 File Offset: 0x00051A08
			[Token(Token = "0x600E61A")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E61B RID: 58907 RVA: 0x00053820 File Offset: 0x00051A20
			[Token(Token = "0x600E61B")]
			[Address(RVA = "0x5CC910", Offset = "0x5CB510", VA = "0x1805CC910", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E61C RID: 58908 RVA: 0x00053838 File Offset: 0x00051A38
			[Token(Token = "0x600E61C")]
			[Address(RVA = "0x5CC910", Offset = "0x5CB510", VA = "0x1805CC910", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}
		}

		// Token: 0x02002374 RID: 9076
		[Token(Token = "0x2002374")]
		protected class AlertCheckpoint : BasicCursor.Checkpoint
		{
			// Token: 0x0600E61D RID: 58909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E61D")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public AlertCheckpoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E61E RID: 58910 RVA: 0x00053850 File Offset: 0x00051A50
			[Token(Token = "0x600E61E")]
			[Address(RVA = "0x4E40F0", Offset = "0x4E2CF0", VA = "0x1804E40F0", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E61F RID: 58911 RVA: 0x00053868 File Offset: 0x00051A68
			[Token(Token = "0x600E61F")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E620 RID: 58912 RVA: 0x00053880 File Offset: 0x00051A80
			[Token(Token = "0x600E620")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E621 RID: 58913 RVA: 0x00053898 File Offset: 0x00051A98
			[Token(Token = "0x600E621")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}

			// Token: 0x0600E622 RID: 58914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E622")]
			[Address(RVA = "0x5B5220", Offset = "0x5B3E20", VA = "0x1805B5220", Slot = "10")]
			public override void OnBegin()
			{
			}
		}

		// Token: 0x02002375 RID: 9077
		[Token(Token = "0x2002375")]
		protected class WaitBossrushWaveCheckPoint : BasicCursor.Checkpoint
		{
			// Token: 0x17001CE9 RID: 7401
			// (get) Token: 0x0600E623 RID: 58915 RVA: 0x000538B0 File Offset: 0x00051AB0
			[Token(Token = "0x17001CE9")]
			public bool isReached
			{
				[Token(Token = "0x600E623")]
				[Address(RVA = "0x5CC500", Offset = "0x5CB100", VA = "0x1805CC500")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E624 RID: 58916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E624")]
			[Address(RVA = "0x5CC7A0", Offset = "0x5CB3A0", VA = "0x1805CC7A0")]
			public WaitBossrushWaveCheckPoint(RouteData.CheckpointData data, BasicCursor cursor)
			{
			}

			// Token: 0x0600E625 RID: 58917 RVA: 0x000538C8 File Offset: 0x00051AC8
			[Token(Token = "0x600E625")]
			[Address(RVA = "0x5CC500", Offset = "0x5CB100", VA = "0x1805CC500", Slot = "8")]
			public override bool CheckReached(GridPosition grid)
			{
				return default(bool);
			}

			// Token: 0x0600E626 RID: 58918 RVA: 0x000538E0 File Offset: 0x00051AE0
			[Token(Token = "0x600E626")]
			[Address(RVA = "0x5CC500", Offset = "0x5CB100", VA = "0x1805CC500", Slot = "7")]
			public override bool CheckReached(Vector2 pos)
			{
				return default(bool);
			}

			// Token: 0x0600E627 RID: 58919 RVA: 0x000538F8 File Offset: 0x00051AF8
			[Token(Token = "0x600E627")]
			[Address(RVA = "0x4E40F0", Offset = "0x4E2CF0", VA = "0x1804E40F0", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}

			// Token: 0x0600E628 RID: 58920 RVA: 0x00053910 File Offset: 0x00051B10
			[Token(Token = "0x600E628")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
			public override GridPosition GetNextGrid(GridPosition grid)
			{
				return default(GridPosition);
			}

			// Token: 0x0600E629 RID: 58921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E629")]
			[Address(RVA = "0x5CC540", Offset = "0x5CB140", VA = "0x1805CC540", Slot = "10")]
			public override void OnBegin()
			{
			}

			// Token: 0x0400FDAB RID: 64939
			[Token(Token = "0x400FDAB")]
			[FieldOffset(Offset = "0x20")]
			private int m_bossrushWave;

			// Token: 0x0400FDAC RID: 64940
			[Token(Token = "0x400FDAC")]
			[FieldOffset(Offset = "0x28")]
			private GameModeFactory.BossRushGameMode m_bossRushGameMode;
		}

		// Token: 0x02002376 RID: 9078
		[Token(Token = "0x2002376")]
		protected class MapOffsetMoveCheckpoint : BasicCursor.PatrolMoveCheckpoint
		{
			// Token: 0x17001CEA RID: 7402
			// (get) Token: 0x0600E62A RID: 58922 RVA: 0x00053928 File Offset: 0x00051B28
			[Token(Token = "0x17001CEA")]
			public override Vector2 targetPos
			{
				[Token(Token = "0x600E62A")]
				[Address(RVA = "0x5C2700", Offset = "0x5C1300", VA = "0x1805C2700", Slot = "14")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x0600E62B RID: 58923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E62B")]
			[Address(RVA = "0x5C2690", Offset = "0x5C1290", VA = "0x1805C2690")]
			public MapOffsetMoveCheckpoint(RouteData.CheckpointData data, Route.Node[,] nextMap, BasicCursor cursor)
			{
			}

			// Token: 0x0600E62C RID: 58924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E62C")]
			[Address(RVA = "0x5C2580", Offset = "0x5C1180", VA = "0x1805C2580", Slot = "10")]
			public override void OnBegin()
			{
			}

			// Token: 0x0600E62D RID: 58925 RVA: 0x00053940 File Offset: 0x00051B40
			[Token(Token = "0x600E62D")]
			[Address(RVA = "0x5C2380", Offset = "0x5C0F80", VA = "0x1805C2380", Slot = "5")]
			public override Vector2 GetNextDirection(Vector2 pos)
			{
				return default(Vector2);
			}
		}
	}
}
