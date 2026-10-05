using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029E1 RID: 10721
	[Token(Token = "0x20029E1")]
	public class MovementSwitchControllerForWhitw2 : MovementSwitchController
	{
		// Token: 0x06011C67 RID: 72807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C67")]
		[Address(RVA = "0x99E620", Offset = "0x99D220", VA = "0x18099E620", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile, GroupedMovement groupedMovement)
		{
		}

		// Token: 0x06011C68 RID: 72808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C68")]
		[Address(RVA = "0x99EBD0", Offset = "0x99D7D0", VA = "0x18099EBD0", Slot = "6")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011C69 RID: 72809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C69")]
		[Address(RVA = "0x99FAB0", Offset = "0x99E6B0", VA = "0x18099FAB0")]
		private void _SwitchToMovementType(MovementSwitchControllerForWhitw2.MovementType targetMovementType)
		{
		}

		// Token: 0x06011C6A RID: 72810 RVA: 0x0006CD68 File Offset: 0x0006AF68
		[Token(Token = "0x6011C6A")]
		[Address(RVA = "0x99F1A0", Offset = "0x99DDA0", VA = "0x18099F1A0", Slot = "7")]
		public override bool UpdateTarget()
		{
			return default(bool);
		}

		// Token: 0x06011C6B RID: 72811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C6B")]
		[Address(RVA = "0x99F610", Offset = "0x99E210", VA = "0x18099F610")]
		private void _AddTraceTargetBuff()
		{
		}

		// Token: 0x06011C6C RID: 72812 RVA: 0x0006CD80 File Offset: 0x0006AF80
		[Token(Token = "0x6011C6C")]
		[Address(RVA = "0x99F900", Offset = "0x99E500", VA = "0x18099F900")]
		private bool _CheckProjectileMissTarget()
		{
			return default(bool);
		}

		// Token: 0x06011C6D RID: 72813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C6D")]
		[Address(RVA = "0x99FB80", Offset = "0x99E780", VA = "0x18099FB80")]
		public MovementSwitchControllerForWhitw2()
		{
		}

		// Token: 0x06011C6E RID: 72814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C6E")]
		[Address(RVA = "0x99E3D0", Offset = "0x99CFD0", VA = "0x18099E3D0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2, GroupedMovement P3)
		{
		}

		// Token: 0x06011C6F RID: 72815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C6F")]
		[Address(RVA = "0x99E3E0", Offset = "0x99CFE0", VA = "0x18099E3E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011C70 RID: 72816 RVA: 0x0006CD98 File Offset: 0x0006AF98
		[Token(Token = "0x6011C70")]
		[Address(RVA = "0x99F190", Offset = "0x99DD90", VA = "0x18099F190")]
		private bool <>xLuaBaseProxy_UpdateTarget()
		{
			return default(bool);
		}

		// Token: 0x04013F2D RID: 81709
		[Token(Token = "0x4013F2D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x04013F2E RID: 81710
		[Token(Token = "0x4013F2E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<string> _periodTimeBBKeys;

		// Token: 0x04013F2F RID: 81711
		[Token(Token = "0x4013F2F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<MovementSwitchControllerForWhitw2.MovementType> _movementTypes;

		// Token: 0x04013F30 RID: 81712
		[Token(Token = "0x4013F30")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private BuffData _traceTargetBuff;

		// Token: 0x04013F31 RID: 81713
		[Token(Token = "0x4013F31")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _traceTargetBuffManagerBuffKey;

		// Token: 0x04013F32 RID: 81714
		[Token(Token = "0x4013F32")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Vector3 _randomOffsetMin;

		// Token: 0x04013F33 RID: 81715
		[Token(Token = "0x4013F33")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private Vector3 _randomOffsetMax;

		// Token: 0x04013F34 RID: 81716
		[Token(Token = "0x4013F34")]
		[FieldOffset(Offset = "0xD8")]
		private List<float> m_timeSlots;

		// Token: 0x04013F35 RID: 81717
		[Token(Token = "0x4013F35")]
		[FieldOffset(Offset = "0xE0")]
		private PeriodicTimer m_timer;

		// Token: 0x04013F36 RID: 81718
		[Token(Token = "0x4013F36")]
		[FieldOffset(Offset = "0xE8")]
		private MovementSwitchControllerForWhitw2.MovementType m_curMovementType;

		// Token: 0x04013F37 RID: 81719
		[Token(Token = "0x4013F37")]
		[FieldOffset(Offset = "0xF0")]
		private ILocatable m_curTargetLocation;

		// Token: 0x04013F38 RID: 81720
		[Token(Token = "0x4013F38")]
		[FieldOffset(Offset = "0xF8")]
		private Entity m_curTarget;

		// Token: 0x04013F39 RID: 81721
		[Token(Token = "0x4013F39")]
		[FieldOffset(Offset = "0x100")]
		private Vector3 m_randomOffsetAfterAttach;

		// Token: 0x04013F3A RID: 81722
		[Token(Token = "0x4013F3A")]
		private const float LARGE_VALUE = 100000000f;

		// Token: 0x04013F3B RID: 81723
		[Token(Token = "0x4013F3B")]
		private const string PROJECTILE_EFFECT_APPEAR = "wolf_appear";

		// Token: 0x04013F3C RID: 81724
		[Token(Token = "0x4013F3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013F3D RID: 81725
		[Token(Token = "0x4013F3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013F3E RID: 81726
		[Token(Token = "0x4013F3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SwitchToMovementType;

		// Token: 0x04013F3F RID: 81727
		[Token(Token = "0x4013F3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateTarget;

		// Token: 0x04013F40 RID: 81728
		[Token(Token = "0x4013F40")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AddTraceTargetBuff;

		// Token: 0x04013F41 RID: 81729
		[Token(Token = "0x4013F41")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckProjectileMissTarget;

		// Token: 0x04013F42 RID: 81730
		[Token(Token = "0x4013F42")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029E2 RID: 10722
		[Token(Token = "0x20029E2")]
		public enum MovementType
		{
			// Token: 0x04013F44 RID: 81732
			[Token(Token = "0x4013F44")]
			INIT_STRAIGHT_LINE,
			// Token: 0x04013F45 RID: 81733
			[Token(Token = "0x4013F45")]
			TRACE_TARGET_CURVE,
			// Token: 0x04013F46 RID: 81734
			[Token(Token = "0x4013F46")]
			ATTACH_TARGET,
			// Token: 0x04013F47 RID: 81735
			[Token(Token = "0x4013F47")]
			HOVERING_IN_PLACE
		}
	}
}
