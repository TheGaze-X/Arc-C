using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C17 RID: 11287
	[Token(Token = "0x2002C17")]
	public class ElimateProjectileByExitRangeTime : ProjectileAuraAbility.ProjectileAuraBehaviour
	{
		// Token: 0x060130F1 RID: 78065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F1")]
		[Address(RVA = "0xB1A8D0", Offset = "0xB194D0", VA = "0x180B1A8D0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x060130F2 RID: 78066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F2")]
		[Address(RVA = "0xB19F80", Offset = "0xB18B80", VA = "0x180B19F80", Slot = "16")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060130F3 RID: 78067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F3")]
		[Address(RVA = "0xB19C60", Offset = "0xB18860", VA = "0x180B19C60", Slot = "17")]
		public override void OnProjectileEnter(Projectile projectile)
		{
		}

		// Token: 0x060130F4 RID: 78068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F4")]
		[Address(RVA = "0xB19D90", Offset = "0xB18990", VA = "0x180B19D90", Slot = "18")]
		public override void OnProjectileExit(Projectile projectile)
		{
		}

		// Token: 0x060130F5 RID: 78069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F5")]
		[Address(RVA = "0xB19BD0", Offset = "0xB187D0", VA = "0x180B19BD0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060130F6 RID: 78070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F6")]
		[Address(RVA = "0xB1A9B0", Offset = "0xB195B0", VA = "0x180B1A9B0")]
		private void _Reset()
		{
		}

		// Token: 0x060130F7 RID: 78071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F7")]
		[Address(RVA = "0xB1AA30", Offset = "0xB19630", VA = "0x180B1AA30")]
		public ElimateProjectileByExitRangeTime()
		{
		}

		// Token: 0x060130F8 RID: 78072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F8")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x060130F9 RID: 78073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F9")]
		[Address(RVA = "0xB14140", Offset = "0xB12D40", VA = "0x180B14140")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x060130FA RID: 78074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130FA")]
		[Address(RVA = "0xB1A990", Offset = "0xB19590", VA = "0x180B1A990")]
		private void <>xLuaBaseProxy_OnProjectileEnter(Projectile P0)
		{
		}

		// Token: 0x060130FB RID: 78075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130FB")]
		[Address(RVA = "0xB1A9A0", Offset = "0xB195A0", VA = "0x180B1A9A0")]
		private void <>xLuaBaseProxy_OnProjectileExit(Projectile P0)
		{
		}

		// Token: 0x060130FC RID: 78076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130FC")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0401585C RID: 88156
		[Token(Token = "0x401585C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _keepAliveIfContainsTraceTarget;

		// Token: 0x0401585D RID: 88157
		[Token(Token = "0x401585D")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ObjectPtr<Projectile>, FP> m_projectileExitTime;

		// Token: 0x0401585E RID: 88158
		[Token(Token = "0x401585E")]
		[FieldOffset(Offset = "0x30")]
		private float m_delay;

		// Token: 0x0401585F RID: 88159
		[Token(Token = "0x401585F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04015860 RID: 88160
		[Token(Token = "0x4015860")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015861 RID: 88161
		[Token(Token = "0x4015861")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileEnter;

		// Token: 0x04015862 RID: 88162
		[Token(Token = "0x4015862")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileExit;

		// Token: 0x04015863 RID: 88163
		[Token(Token = "0x4015863")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015864 RID: 88164
		[Token(Token = "0x4015864")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x04015865 RID: 88165
		[Token(Token = "0x4015865")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
