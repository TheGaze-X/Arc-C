using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029BB RID: 10683
	[Token(Token = "0x20029BB")]
	public class StopWithAnimBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011B11 RID: 72465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B11")]
		[Address(RVA = "0x98B610", Offset = "0x98A210", VA = "0x18098B610", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011B12 RID: 72466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B12")]
		[Address(RVA = "0x98B710", Offset = "0x98A310", VA = "0x18098B710")]
		public StopWithAnimBehaviour()
		{
		}

		// Token: 0x06011B13 RID: 72467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B13")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013D4F RID: 81231
		[Token(Token = "0x4013D4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _triggerKey;

		// Token: 0x04013D50 RID: 81232
		[Token(Token = "0x4013D50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013D51 RID: 81233
		[Token(Token = "0x4013D51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
