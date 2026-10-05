using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021F3 RID: 8691
	[Token(Token = "0x20021F3")]
	public class RangeLineEffectHandler : IHotfixable
	{
		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x0600D979 RID: 55673 RVA: 0x0004EF90 File Offset: 0x0004D190
		[Token(Token = "0x17001AD5")]
		protected Vector3 defaultHighlandOffset
		{
			[Token(Token = "0x600D979")]
			[Address(RVA = "0x35EB350", Offset = "0x35E9F50", VA = "0x1835EB350")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (set) Token: 0x0600D97A RID: 55674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001AD6")]
		public bool isDisabled
		{
			[Token(Token = "0x600D97A")]
			[Address(RVA = "0x35EB590", Offset = "0x35EA190", VA = "0x1835EB590")]
			set
			{
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (set) Token: 0x0600D97B RID: 55675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001AD7")]
		public bool animatorState
		{
			[Token(Token = "0x600D97B")]
			[Address(RVA = "0x35EB510", Offset = "0x35EA110", VA = "0x1835EB510")]
			set
			{
			}
		}

		// Token: 0x0600D97C RID: 55676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D97C")]
		[Address(RVA = "0x35E86E0", Offset = "0x35E72E0", VA = "0x1835E86E0")]
		public void Init(RangeLineEffectHandler.InitParms initParms, Blackboard blackboard)
		{
		}

		// Token: 0x0600D97D RID: 55677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D97D")]
		[Address(RVA = "0x35E8A90", Offset = "0x35E7690", VA = "0x1835E8A90")]
		public void SetTileStatus(GridPosition grid, bool isInside)
		{
		}

		// Token: 0x0600D97E RID: 55678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D97E")]
		[Address(RVA = "0x35E8800", Offset = "0x35E7400", VA = "0x1835E8800")]
		public void OnTick()
		{
		}

		// Token: 0x0600D97F RID: 55679 RVA: 0x0004EFA8 File Offset: 0x0004D1A8
		[Token(Token = "0x600D97F")]
		[Address(RVA = "0x35E8BA0", Offset = "0x35E77A0", VA = "0x1835E8BA0")]
		private bool _CheckUpdateEdgeLine()
		{
			return default(bool);
		}

		// Token: 0x0600D980 RID: 55680 RVA: 0x0004EFC0 File Offset: 0x0004D1C0
		[Token(Token = "0x600D980")]
		[Address(RVA = "0x35E8D90", Offset = "0x35E7990", VA = "0x1835E8D90")]
		private bool _CheckUpdateHeightOffset()
		{
			return default(bool);
		}

		// Token: 0x0600D981 RID: 55681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D981")]
		[Address(RVA = "0x35E9390", Offset = "0x35E7F90", VA = "0x1835E9390", Slot = "4")]
		protected virtual void _InitMapIfNot()
		{
		}

		// Token: 0x0600D982 RID: 55682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D982")]
		[Address(RVA = "0x35E8DF0", Offset = "0x35E79F0", VA = "0x1835E8DF0")]
		private void _ClearEffects()
		{
		}

		// Token: 0x0600D983 RID: 55683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D983")]
		[Address(RVA = "0x35E9B90", Offset = "0x35E8790", VA = "0x1835E9B90", Slot = "5")]
		protected virtual void _RenderLine()
		{
		}

		// Token: 0x0600D984 RID: 55684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D984")]
		[Address(RVA = "0x35E8F90", Offset = "0x35E7B90", VA = "0x1835E8F90")]
		private List<GridPosition> _DFSGetNewLineFromCurrentPoint(GridPosition currentPos)
		{
			return null;
		}

		// Token: 0x0600D985 RID: 55685 RVA: 0x0004EFD8 File Offset: 0x0004D1D8
		[Token(Token = "0x600D985")]
		[Address(RVA = "0x35E9820", Offset = "0x35E8420", VA = "0x1835E9820")]
		private bool _IsValidMove(GridPosition pos, GridPosition offset)
		{
			return default(bool);
		}

		// Token: 0x0600D986 RID: 55686 RVA: 0x0004EFF0 File Offset: 0x0004D1F0
		[Token(Token = "0x600D986")]
		[Address(RVA = "0x35E94A0", Offset = "0x35E80A0", VA = "0x1835E94A0")]
		private bool _IsStraightMove(GridPosition pos, GridPosition offset)
		{
			return default(bool);
		}

		// Token: 0x0600D987 RID: 55687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D987")]
		[Address(RVA = "0x35EA4B0", Offset = "0x35E90B0", VA = "0x1835EA4B0", Slot = "6")]
		protected virtual void _UpdateEdgeCornerStatus()
		{
		}

		// Token: 0x0600D988 RID: 55688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D988")]
		protected static void _ResizeList<T>(List<List<T>> target, int height, int width)
		{
		}

		// Token: 0x0600D989 RID: 55689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D989")]
		[Address(RVA = "0x35EAD80", Offset = "0x35E9980", VA = "0x1835EAD80")]
		private void _UpdateEffectAnimatorState()
		{
		}

		// Token: 0x0600D98A RID: 55690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D98A")]
		[Address(RVA = "0x35EAF70", Offset = "0x35E9B70", VA = "0x1835EAF70")]
		public RangeLineEffectHandler()
		{
		}

		// Token: 0x0400EA8C RID: 60044
		[Token(Token = "0x400EA8C")]
		[FieldOffset(Offset = "0x10")]
		protected RangeLineEffectHandler.InitParms m_initParms;

		// Token: 0x0400EA8D RID: 60045
		[Token(Token = "0x400EA8D")]
		[FieldOffset(Offset = "0x40")]
		protected readonly List<List<int>> m_isEdgePassingCorner;

		// Token: 0x0400EA8E RID: 60046
		[Token(Token = "0x400EA8E")]
		[FieldOffset(Offset = "0x48")]
		protected readonly List<List<bool>> m_isTileInEdges;

		// Token: 0x0400EA8F RID: 60047
		[Token(Token = "0x400EA8F")]
		[FieldOffset(Offset = "0x50")]
		protected readonly List<List<GridPosition>> m_edgeLines;

		// Token: 0x0400EA90 RID: 60048
		[Token(Token = "0x400EA90")]
		[FieldOffset(Offset = "0x58")]
		protected readonly List<ObjectPtr<Effect>> m_edgeEffects;

		// Token: 0x0400EA91 RID: 60049
		[Token(Token = "0x400EA91")]
		[FieldOffset(Offset = "0x60")]
		protected int m_width;

		// Token: 0x0400EA92 RID: 60050
		[Token(Token = "0x400EA92")]
		[FieldOffset(Offset = "0x64")]
		protected int m_height;

		// Token: 0x0400EA93 RID: 60051
		[Token(Token = "0x400EA93")]
		[FieldOffset(Offset = "0x68")]
		private bool m_needUpdateEdges;

		// Token: 0x0400EA94 RID: 60052
		[Token(Token = "0x400EA94")]
		[FieldOffset(Offset = "0x69")]
		private bool m_isDisabled;

		// Token: 0x0400EA95 RID: 60053
		[Token(Token = "0x400EA95")]
		[FieldOffset(Offset = "0x6A")]
		protected bool m_init;

		// Token: 0x0400EA96 RID: 60054
		[Token(Token = "0x400EA96")]
		[FieldOffset(Offset = "0x6B")]
		private bool m_animatorState;

		// Token: 0x0400EA97 RID: 60055
		[Token(Token = "0x400EA97")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_animatorStateDirty;

		// Token: 0x0400EA98 RID: 60056
		[Token(Token = "0x400EA98")]
		[FieldOffset(Offset = "0x6D")]
		private bool m_defaultHighlandOffsetInited;

		// Token: 0x0400EA99 RID: 60057
		[Token(Token = "0x400EA99")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 m_defaultHighlandOffsetCache;

		// Token: 0x0400EA9A RID: 60058
		[Token(Token = "0x400EA9A")]
		[FieldOffset(Offset = "0x80")]
		protected readonly List<GridPosition> m_gridPosOffset;

		// Token: 0x0400EA9B RID: 60059
		[Token(Token = "0x400EA9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_defaultHighlandOffset;

		// Token: 0x0400EA9C RID: 60060
		[Token(Token = "0x400EA9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isDisabled;

		// Token: 0x0400EA9D RID: 60061
		[Token(Token = "0x400EA9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_animatorState;

		// Token: 0x0400EA9E RID: 60062
		[Token(Token = "0x400EA9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EA9F RID: 60063
		[Token(Token = "0x400EA9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetTileStatus;

		// Token: 0x0400EAA0 RID: 60064
		[Token(Token = "0x400EAA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400EAA1 RID: 60065
		[Token(Token = "0x400EAA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckUpdateEdgeLine;

		// Token: 0x0400EAA2 RID: 60066
		[Token(Token = "0x400EAA2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckUpdateHeightOffset;

		// Token: 0x0400EAA3 RID: 60067
		[Token(Token = "0x400EAA3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitMapIfNot;

		// Token: 0x0400EAA4 RID: 60068
		[Token(Token = "0x400EAA4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x0400EAA5 RID: 60069
		[Token(Token = "0x400EAA5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderLine;

		// Token: 0x0400EAA6 RID: 60070
		[Token(Token = "0x400EAA6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DFSGetNewLineFromCurrentPoint;

		// Token: 0x0400EAA7 RID: 60071
		[Token(Token = "0x400EAA7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__IsValidMove;

		// Token: 0x0400EAA8 RID: 60072
		[Token(Token = "0x400EAA8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__IsStraightMove;

		// Token: 0x0400EAA9 RID: 60073
		[Token(Token = "0x400EAA9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateEdgeCornerStatus;

		// Token: 0x0400EAAA RID: 60074
		[Token(Token = "0x400EAAA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResizeList;

		// Token: 0x0400EAAB RID: 60075
		[Token(Token = "0x400EAAB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateEffectAnimatorState;

		// Token: 0x0400EAAC RID: 60076
		[Token(Token = "0x400EAAC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020021F4 RID: 8692
		[Token(Token = "0x20021F4")]
		public struct InitParms
		{
			// Token: 0x0400EAAD RID: 60077
			[Token(Token = "0x400EAAD")]
			[FieldOffset(Offset = "0x0")]
			public string edgeLineRendererEffectKey;

			// Token: 0x0400EAAE RID: 60078
			[Token(Token = "0x400EAAE")]
			[FieldOffset(Offset = "0x8")]
			public string disableBlackboardKey;

			// Token: 0x0400EAAF RID: 60079
			[Token(Token = "0x400EAAF")]
			[FieldOffset(Offset = "0x10")]
			public float heightOffset;

			// Token: 0x0400EAB0 RID: 60080
			[Token(Token = "0x400EAB0")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 lineOffsetToMapCenter;

			// Token: 0x0400EAB1 RID: 60081
			[Token(Token = "0x400EAB1")]
			[FieldOffset(Offset = "0x20")]
			public Func<List<GridPosition>, float> heightOffsetGetterFunc;

			// Token: 0x0400EAB2 RID: 60082
			[Token(Token = "0x400EAB2")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<int, string> effectKeyByStatus;
		}
	}
}
