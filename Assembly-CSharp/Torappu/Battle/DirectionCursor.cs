using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002377 RID: 9079
	[Token(Token = "0x2002377")]
	public class DirectionCursor : BasicCursor
	{
		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x0600E62E RID: 58926 RVA: 0x00053958 File Offset: 0x00051B58
		[Token(Token = "0x17001CEB")]
		public virtual float distToExit
		{
			[Token(Token = "0x600E62E")]
			[Address(RVA = "0x5BF060", Offset = "0x5BDC60", VA = "0x1805BF060", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x0600E62F RID: 58927 RVA: 0x00053970 File Offset: 0x00051B70
		[Token(Token = "0x17001CEC")]
		public virtual float distToExitPrecise
		{
			[Token(Token = "0x600E62F")]
			[Address(RVA = "0x5BED20", Offset = "0x5BD920", VA = "0x1805BED20", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x0600E630 RID: 58928 RVA: 0x00053988 File Offset: 0x00051B88
		// (set) Token: 0x0600E631 RID: 58929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001CED")]
		public float totalDist
		{
			[Token(Token = "0x600E630")]
			[Address(RVA = "0x5BF1F0", Offset = "0x5BDDF0", VA = "0x1805BF1F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600E631")]
			[Address(RVA = "0x5BF250", Offset = "0x5BDE50", VA = "0x1805BF250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x0600E632 RID: 58930 RVA: 0x000539A0 File Offset: 0x00051BA0
		[Token(Token = "0x17001CEE")]
		public int cursorIndex
		{
			[Token(Token = "0x600E632")]
			[Address(RVA = "0x5BECC0", Offset = "0x5BD8C0", VA = "0x1805BECC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x0600E633 RID: 58931 RVA: 0x000539B8 File Offset: 0x00051BB8
		[Token(Token = "0x17001CEF")]
		public override bool alwaysCheckCurrentPoint
		{
			[Token(Token = "0x600E633")]
			[Address(RVA = "0x5BEC60", Offset = "0x5BD860", VA = "0x1805BEC60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E634 RID: 58932 RVA: 0x000539D0 File Offset: 0x00051BD0
		[Token(Token = "0x600E634")]
		[Address(RVA = "0x5BD720", Offset = "0x5BC320", VA = "0x1805BD720")]
		public bool TryGetCurrentCheckpointType(out CheckpointType cpType)
		{
			return default(bool);
		}

		// Token: 0x0600E635 RID: 58933 RVA: 0x000539E8 File Offset: 0x00051BE8
		[Token(Token = "0x600E635")]
		[Address(RVA = "0x5BBB70", Offset = "0x5BA770", VA = "0x1805BBB70")]
		public bool CheckObstacleLikeOrInvalid()
		{
			return default(bool);
		}

		// Token: 0x0600E636 RID: 58934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E636")]
		[Address(RVA = "0x5BBB00", Offset = "0x5BA700", VA = "0x1805BBB00")]
		public void AssignHostRouteProgress(int hostCursorIndex)
		{
		}

		// Token: 0x0600E637 RID: 58935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E637")]
		[Address(RVA = "0x5BEA50", Offset = "0x5BD650", VA = "0x1805BEA50")]
		public DirectionCursor(Route route, Scheduler.SchedulerSnapshot snapshot, Vector2 offset, BObject obj, bool ignoreAllButMoveCp = false, bool visitEveryTileCenter = false, bool visitEveryNodeCenter = false, bool alwaysCheckCurrentPoint = false)
		{
		}

		// Token: 0x0600E638 RID: 58936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E638")]
		[Address(RVA = "0x5BD340", Offset = "0x5BBF40", VA = "0x1805BD340", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x0600E639 RID: 58937 RVA: 0x00053A00 File Offset: 0x00051C00
		[Token(Token = "0x600E639")]
		[Address(RVA = "0x5BBD70", Offset = "0x5BA970", VA = "0x1805BBD70", Slot = "9")]
		public virtual bool CheckReached()
		{
			return default(bool);
		}

		// Token: 0x0600E63A RID: 58938 RVA: 0x00053A18 File Offset: 0x00051C18
		[Token(Token = "0x600E63A")]
		[Address(RVA = "0x5BD1B0", Offset = "0x5BBDB0", VA = "0x1805BD1B0", Slot = "10")]
		public virtual bool PredictReached(float stepDistance, out Vector2 direction, out Vector2 nextPos)
		{
			return default(bool);
		}

		// Token: 0x0600E63B RID: 58939 RVA: 0x00053A30 File Offset: 0x00051C30
		[Token(Token = "0x600E63B")]
		[Address(RVA = "0x5BC8A0", Offset = "0x5BB4A0", VA = "0x1805BC8A0")]
		public Vector2 GetNextTarget()
		{
			return default(Vector2);
		}

		// Token: 0x0600E63C RID: 58940 RVA: 0x00053A48 File Offset: 0x00051C48
		[Token(Token = "0x600E63C")]
		[Address(RVA = "0x5BE3A0", Offset = "0x5BCFA0", VA = "0x1805BE3A0", Slot = "11")]
		protected virtual Vector2 _GetNextTarget()
		{
			return default(Vector2);
		}

		// Token: 0x0600E63D RID: 58941 RVA: 0x00053A60 File Offset: 0x00051C60
		[Token(Token = "0x600E63D")]
		[Address(RVA = "0x5BC6F0", Offset = "0x5BB2F0", VA = "0x1805BC6F0")]
		public GridPosition GetNextPosRelatedCheckPointGridPosition()
		{
			return default(GridPosition);
		}

		// Token: 0x0600E63E RID: 58942 RVA: 0x00053A78 File Offset: 0x00051C78
		[Token(Token = "0x600E63E")]
		[Address(RVA = "0x5BBF70", Offset = "0x5BAB70", VA = "0x1805BBF70", Slot = "12")]
		public virtual Vector2 GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0600E63F RID: 58943 RVA: 0x00053A90 File Offset: 0x00051C90
		[Token(Token = "0x600E63F")]
		[Address(RVA = "0x5BC940", Offset = "0x5BB540", VA = "0x1805BC940")]
		public Vector2 GetNextTurn(Vector2 moveDir)
		{
			return default(Vector2);
		}

		// Token: 0x0600E640 RID: 58944 RVA: 0x00053AA8 File Offset: 0x00051CA8
		[Token(Token = "0x600E640")]
		[Address(RVA = "0x5BCE30", Offset = "0x5BBA30", VA = "0x1805BCE30")]
		public Vector2 PredictFuturePosition(float predictDist, bool updateCursor = false, bool skipDisappearCheckpoint = false)
		{
			return default(Vector2);
		}

		// Token: 0x0600E641 RID: 58945 RVA: 0x00053AC0 File Offset: 0x00051CC0
		[Token(Token = "0x600E641")]
		[Address(RVA = "0x5BDAA0", Offset = "0x5BC6A0", VA = "0x1805BDAA0")]
		public bool TryGetDistanceToNextCheckpoint(out float distance)
		{
			return default(bool);
		}

		// Token: 0x0600E642 RID: 58946 RVA: 0x00053AD8 File Offset: 0x00051CD8
		[Token(Token = "0x600E642")]
		[Address(RVA = "0x5BD580", Offset = "0x5BC180", VA = "0x1805BD580")]
		public bool TryGetCheckpointTargetPos(int cursorOffset, out GridPosition targetGrid)
		{
			return default(bool);
		}

		// Token: 0x0600E643 RID: 58947 RVA: 0x00053AF0 File Offset: 0x00051CF0
		[Token(Token = "0x600E643")]
		[Address(RVA = "0x5BDC80", Offset = "0x5BC880", VA = "0x1805BDC80")]
		public bool TryGetNextAppearCheckpoint(out int nextMoveCp, out Vector2 mapPos)
		{
			return default(bool);
		}

		// Token: 0x0600E644 RID: 58948 RVA: 0x00053B08 File Offset: 0x00051D08
		[Token(Token = "0x600E644")]
		[Address(RVA = "0x5BD7F0", Offset = "0x5BC3F0", VA = "0x1805BD7F0")]
		public bool TryGetDistanceToMapPosInCheckpointsAhead(GridPosition gridPos, out float distance)
		{
			return default(bool);
		}

		// Token: 0x0600E645 RID: 58949 RVA: 0x00053B20 File Offset: 0x00051D20
		[Token(Token = "0x600E645")]
		[Address(RVA = "0x5BDF90", Offset = "0x5BCB90", VA = "0x1805BDF90")]
		private bool _CheckNextCpShouldNotSkip(int cur_cursor)
		{
			return default(bool);
		}

		// Token: 0x0600E646 RID: 58950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E646")]
		[Address(RVA = "0x5BCCF0", Offset = "0x5BB8F0", VA = "0x1805BCCF0")]
		public void OnTick(FP deltaTime, bool checkReached = true)
		{
		}

		// Token: 0x0600E647 RID: 58951 RVA: 0x00053B38 File Offset: 0x00051D38
		[Token(Token = "0x600E647")]
		[Address(RVA = "0x5BBE30", Offset = "0x5BAA30", VA = "0x1805BBE30")]
		public CheckpointType GetCurCheckpointType()
		{
			return CheckpointType.MOVE;
		}

		// Token: 0x0600E648 RID: 58952 RVA: 0x00053B50 File Offset: 0x00051D50
		[Token(Token = "0x600E648")]
		[Address(RVA = "0x5BDE10", Offset = "0x5BCA10", VA = "0x1805BDE10")]
		public bool TrySkipIfCurrentCheckpointIsWaitForSeconds(bool _useSkipInsteadOfSetToZero = false)
		{
			return default(bool);
		}

		// Token: 0x0600E649 RID: 58953 RVA: 0x00053B68 File Offset: 0x00051D68
		[Token(Token = "0x600E649")]
		[Address(RVA = "0x5BE160", Offset = "0x5BCD60", VA = "0x1805BE160")]
		protected GridPosition _GetNextGrid(GridPosition gridPos)
		{
			return default(GridPosition);
		}

		// Token: 0x0600E64A RID: 58954 RVA: 0x00053B80 File Offset: 0x00051D80
		[Token(Token = "0x600E64A")]
		[Address(RVA = "0x5BBEE0", Offset = "0x5BAAE0", VA = "0x1805BBEE0")]
		public Vector2 GetLocatorPosition()
		{
			return default(Vector2);
		}

		// Token: 0x0600E64B RID: 58955 RVA: 0x00053B98 File Offset: 0x00051D98
		[Token(Token = "0x600E64B")]
		[Address(RVA = "0x5BC670", Offset = "0x5BB270", VA = "0x1805BC670")]
		public GridPosition GetNextGrid(GridPosition gridPos)
		{
			return default(GridPosition);
		}

		// Token: 0x0600E64C RID: 58956 RVA: 0x00053BB0 File Offset: 0x00051DB0
		[Token(Token = "0x600E64C")]
		[Address(RVA = "0x5B6D80", Offset = "0x5B5980", VA = "0x1805B6D80")]
		private bool <>xLuaBaseProxy_get_alwaysCheckCurrentPoint()
		{
			return default(bool);
		}

		// Token: 0x0600E64D RID: 58957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E64D")]
		[Address(RVA = "0x5BDF80", Offset = "0x5BCB80", VA = "0x1805BDF80")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x0400FDAD RID: 64941
		[Token(Token = "0x400FDAD")]
		[FieldOffset(Offset = "0x60")]
		protected bool[,] m_visitedMap;

		// Token: 0x0400FDAE RID: 64942
		[Token(Token = "0x400FDAE")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_offset;

		// Token: 0x0400FDAF RID: 64943
		[Token(Token = "0x400FDAF")]
		[FieldOffset(Offset = "0x70")]
		protected GridPosition m_nextGrid;

		// Token: 0x0400FDB0 RID: 64944
		[Token(Token = "0x400FDB0")]
		[FieldOffset(Offset = "0x78")]
		private bool m_alwaysCheckCurrentPoint;

		// Token: 0x0400FDB2 RID: 64946
		[Token(Token = "0x400FDB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_distToExit;

		// Token: 0x0400FDB3 RID: 64947
		[Token(Token = "0x400FDB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_distToExitPrecise;

		// Token: 0x0400FDB4 RID: 64948
		[Token(Token = "0x400FDB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_totalDist;

		// Token: 0x0400FDB5 RID: 64949
		[Token(Token = "0x400FDB5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_totalDist;

		// Token: 0x0400FDB6 RID: 64950
		[Token(Token = "0x400FDB6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cursorIndex;

		// Token: 0x0400FDB7 RID: 64951
		[Token(Token = "0x400FDB7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysCheckCurrentPoint;

		// Token: 0x0400FDB8 RID: 64952
		[Token(Token = "0x400FDB8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryGetCurrentCheckpointType;

		// Token: 0x0400FDB9 RID: 64953
		[Token(Token = "0x400FDB9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckObstacleLikeOrInvalid;

		// Token: 0x0400FDBA RID: 64954
		[Token(Token = "0x400FDBA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AssignHostRouteProgress;

		// Token: 0x0400FDBB RID: 64955
		[Token(Token = "0x400FDBB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FDBC RID: 64956
		[Token(Token = "0x400FDBC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400FDBD RID: 64957
		[Token(Token = "0x400FDBD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckReached;

		// Token: 0x0400FDBE RID: 64958
		[Token(Token = "0x400FDBE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_PredictReached;

		// Token: 0x0400FDBF RID: 64959
		[Token(Token = "0x400FDBF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetNextTarget;

		// Token: 0x0400FDC0 RID: 64960
		[Token(Token = "0x400FDC0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetNextTarget;

		// Token: 0x0400FDC1 RID: 64961
		[Token(Token = "0x400FDC1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetNextPosRelatedCheckPointGridPosition;

		// Token: 0x0400FDC2 RID: 64962
		[Token(Token = "0x400FDC2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetNextDirection;

		// Token: 0x0400FDC3 RID: 64963
		[Token(Token = "0x400FDC3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetNextTurn;

		// Token: 0x0400FDC4 RID: 64964
		[Token(Token = "0x400FDC4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_PredictFuturePosition;

		// Token: 0x0400FDC5 RID: 64965
		[Token(Token = "0x400FDC5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_TryGetDistanceToNextCheckpoint;

		// Token: 0x0400FDC6 RID: 64966
		[Token(Token = "0x400FDC6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_TryGetCheckpointTargetPos;

		// Token: 0x0400FDC7 RID: 64967
		[Token(Token = "0x400FDC7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryGetNextAppearCheckpoint;

		// Token: 0x0400FDC8 RID: 64968
		[Token(Token = "0x400FDC8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TryGetDistanceToMapPosInCheckpointsAhead;

		// Token: 0x0400FDC9 RID: 64969
		[Token(Token = "0x400FDC9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CheckNextCpShouldNotSkip;

		// Token: 0x0400FDCA RID: 64970
		[Token(Token = "0x400FDCA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FDCB RID: 64971
		[Token(Token = "0x400FDCB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetCurCheckpointType;

		// Token: 0x0400FDCC RID: 64972
		[Token(Token = "0x400FDCC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TrySkipIfCurrentCheckpointIsWaitForSeconds;

		// Token: 0x0400FDCD RID: 64973
		[Token(Token = "0x400FDCD")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetNextGrid;

		// Token: 0x0400FDCE RID: 64974
		[Token(Token = "0x400FDCE")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetLocatorPosition;

		// Token: 0x0400FDCF RID: 64975
		[Token(Token = "0x400FDCF")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetNextGrid;
	}
}
