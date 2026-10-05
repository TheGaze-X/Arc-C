using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002668 RID: 9832
	[Token(Token = "0x2002668")]
	public class PreviewCursor : BObject, IMovable, ILocatable
	{
		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x06010137 RID: 65847 RVA: 0x00062298 File Offset: 0x00060498
		[Token(Token = "0x17002309")]
		public float moveSpeed
		{
			[Token(Token = "0x6010137")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CDA20", VA = "0x1807CEE20", Slot = "35")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x06010138 RID: 65848 RVA: 0x000622B0 File Offset: 0x000604B0
		// (set) Token: 0x06010139 RID: 65849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700230A")]
		public MotionMode pathMotionMode
		{
			[Token(Token = "0x6010138")]
			[Address(RVA = "0x7CEE30", Offset = "0x7CDA30", VA = "0x1807CEE30", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return MotionMode.WALK;
			}
			[Token(Token = "0x6010139")]
			[Address(RVA = "0x7CEE40", Offset = "0x7CDA40", VA = "0x1807CEE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0601013A RID: 65850 RVA: 0x000622C8 File Offset: 0x000604C8
		[Token(Token = "0x1700230B")]
		public Vector2 footMapPosition
		{
			[Token(Token = "0x601013A")]
			[Address(RVA = "0x72B8A0", Offset = "0x72A4A0", VA = "0x18072B8A0", Slot = "38")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x0601013B RID: 65851 RVA: 0x000622E0 File Offset: 0x000604E0
		[Token(Token = "0x1700230C")]
		public Vector2 offsetMapPosition
		{
			[Token(Token = "0x601013B")]
			[Address(RVA = "0x72B8A0", Offset = "0x72A4A0", VA = "0x18072B8A0", Slot = "39")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x0601013C RID: 65852 RVA: 0x000622F8 File Offset: 0x000604F8
		[Token(Token = "0x1700230D")]
		public bool canMove
		{
			[Token(Token = "0x601013C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x0601013D RID: 65853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700230E")]
		public DirectionCursor cursor
		{
			[Token(Token = "0x601013D")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601013E RID: 65854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601013E")]
		[Address(RVA = "0x7CDF20", Offset = "0x7CCB20", VA = "0x1807CDF20")]
		public void Spawn(Route route, Scheduler.SchedulerSnapshot snapshot, Action onFinish, [Optional] string overrideEffect)
		{
		}

		// Token: 0x0601013F RID: 65855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601013F")]
		[Address(RVA = "0x7CDD90", Offset = "0x7CC990", VA = "0x1807CDD90", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x06010140 RID: 65856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010140")]
		[Address(RVA = "0x7CDD00", Offset = "0x7CC900", VA = "0x1807CDD00", Slot = "26")]
		public override void OnRecycle()
		{
		}

		// Token: 0x06010141 RID: 65857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010141")]
		[Address(RVA = "0x7CDD20", Offset = "0x7CC920", VA = "0x1807CDD20", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x06010142 RID: 65858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010142")]
		[Address(RVA = "0x7CDCC0", Offset = "0x7CC8C0", VA = "0x1807CDCC0", Slot = "34")]
		protected override void OnDisappearChanged(bool newValue)
		{
		}

		// Token: 0x06010143 RID: 65859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010143")]
		[Address(RVA = "0x7CE830", Offset = "0x7CD430", VA = "0x1807CE830")]
		private void _TryCreateOverrideEffect(string effect)
		{
		}

		// Token: 0x06010144 RID: 65860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010144")]
		[Address(RVA = "0x7CE710", Offset = "0x7CD310", VA = "0x1807CE710")]
		private void _TryClearOverrideEffect()
		{
		}

		// Token: 0x06010145 RID: 65861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010145")]
		[Address(RVA = "0x7CE590", Offset = "0x7CD190", VA = "0x1807CE590")]
		private void _Reborn()
		{
		}

		// Token: 0x06010146 RID: 65862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010146")]
		[Address(RVA = "0x7CE320", Offset = "0x7CCF20", VA = "0x1807CE320")]
		private void _FaceTo(Vector2 direction)
		{
		}

		// Token: 0x06010147 RID: 65863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010147")]
		[Address(RVA = "0x7CEAC0", Offset = "0x7CD6C0", VA = "0x1807CEAC0")]
		private void _UpdateMovement(float deltaTime)
		{
		}

		// Token: 0x06010148 RID: 65864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010148")]
		[Address(RVA = "0x7CE980", Offset = "0x7CD580", VA = "0x1807CE980")]
		private void _UpdateHeight()
		{
		}

		// Token: 0x06010149 RID: 65865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010149")]
		[Address(RVA = "0x7CE690", Offset = "0x7CD290", VA = "0x1807CE690")]
		private void _ResetTrails()
		{
		}

		// Token: 0x0601014A RID: 65866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601014A")]
		[Address(RVA = "0x7CE3F0", Offset = "0x7CCFF0", VA = "0x1807CE3F0")]
		private void _OnFinish()
		{
		}

		// Token: 0x0601014B RID: 65867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601014B")]
		[Address(RVA = "0x7CE2D0", Offset = "0x7CCED0", VA = "0x1807CE2D0")]
		private void _CollectTrails()
		{
		}

		// Token: 0x0601014C RID: 65868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601014C")]
		[Address(RVA = "0x7CE250", Offset = "0x7CCE50", VA = "0x1807CE250")]
		private void _ClearTrailRefs()
		{
		}

		// Token: 0x0601014D RID: 65869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601014D")]
		[Address(RVA = "0x7CDC00", Offset = "0x7CC800", VA = "0x1807CDC00")]
		private void Awake()
		{
		}

		// Token: 0x0601014E RID: 65870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601014E")]
		[Address(RVA = "0x7CEE00", Offset = "0x7CDA00", VA = "0x1807CEE00")]
		public PreviewCursor()
		{
		}

		// Token: 0x04011E12 RID: 73234
		[Token(Token = "0x4011E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _height;

		// Token: 0x04011E13 RID: 73235
		[Token(Token = "0x4011E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _moveSpeed;

		// Token: 0x04011E14 RID: 73236
		[Token(Token = "0x4011E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _faceToDirection;

		// Token: 0x04011E15 RID: 73237
		[Token(Token = "0x4011E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _times;

		// Token: 0x04011E16 RID: 73238
		[Token(Token = "0x4011E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _bodyTransform;

		// Token: 0x04011E17 RID: 73239
		[Token(Token = "0x4011E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _delayToRecycle;

		// Token: 0x04011E18 RID: 73240
		[Token(Token = "0x4011E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _defaultEffect;

		// Token: 0x04011E19 RID: 73241
		[Token(Token = "0x4011E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action m_onFinishOnce;

		// Token: 0x04011E1A RID: 73242
		[Token(Token = "0x4011E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private DirectionCursor m_cursor;

		// Token: 0x04011E1B RID: 73243
		[Token(Token = "0x4011E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_remainingTime;

		// Token: 0x04011E1C RID: 73244
		[Token(Token = "0x4011E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool m_reached;

		// Token: 0x04011E1D RID: 73245
		[Token(Token = "0x4011E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_direction;

		// Token: 0x04011E1E RID: 73246
		[Token(Token = "0x4011E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TrailRenderer[] m_trails;

		// Token: 0x04011E1F RID: 73247
		[Token(Token = "0x4011E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ObjectPtr<Effect> m_effect;
	}
}
