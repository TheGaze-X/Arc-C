using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029E0 RID: 10720
	[Token(Token = "0x20029E0")]
	public class MovementSwitchControllerBasedOnTime : MovementSwitchController
	{
		// Token: 0x06011C61 RID: 72801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C61")]
		[Address(RVA = "0x99DDD0", Offset = "0x99C9D0", VA = "0x18099DDD0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile, GroupedMovement groupedMovement)
		{
		}

		// Token: 0x06011C62 RID: 72802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C62")]
		[Address(RVA = "0x99E1C0", Offset = "0x99CDC0", VA = "0x18099E1C0", Slot = "6")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011C63 RID: 72803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C63")]
		[Address(RVA = "0x99E440", Offset = "0x99D040", VA = "0x18099E440")]
		private void _UpdateMovementIndexAndTimer()
		{
		}

		// Token: 0x06011C64 RID: 72804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C64")]
		[Address(RVA = "0x99E570", Offset = "0x99D170", VA = "0x18099E570")]
		public MovementSwitchControllerBasedOnTime()
		{
		}

		// Token: 0x06011C65 RID: 72805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C65")]
		[Address(RVA = "0x99E3D0", Offset = "0x99CFD0", VA = "0x18099E3D0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2, GroupedMovement P3)
		{
		}

		// Token: 0x06011C66 RID: 72806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C66")]
		[Address(RVA = "0x99E3E0", Offset = "0x99CFE0", VA = "0x18099E3E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013F26 RID: 81702
		[Token(Token = "0x4013F26")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _periodTimeBBKeys;

		// Token: 0x04013F27 RID: 81703
		[Token(Token = "0x4013F27")]
		[FieldOffset(Offset = "0x48")]
		private List<float> m_timeSlots;

		// Token: 0x04013F28 RID: 81704
		[Token(Token = "0x4013F28")]
		[FieldOffset(Offset = "0x50")]
		private PeriodicTimer m_timer;

		// Token: 0x04013F29 RID: 81705
		[Token(Token = "0x4013F29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013F2A RID: 81706
		[Token(Token = "0x4013F2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013F2B RID: 81707
		[Token(Token = "0x4013F2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateMovementIndexAndTimer;

		// Token: 0x04013F2C RID: 81708
		[Token(Token = "0x4013F2C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
