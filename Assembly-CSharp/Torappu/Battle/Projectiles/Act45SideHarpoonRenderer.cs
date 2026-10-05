using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002986 RID: 10630
	[Token(Token = "0x2002986")]
	public class Act45SideHarpoonRenderer : HarpoonRenderer
	{
		// Token: 0x06011958 RID: 72024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011958")]
		[Address(RVA = "0x9665D0", Offset = "0x9651D0", VA = "0x1809665D0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011959 RID: 72025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011959")]
		[Address(RVA = "0x966950", Offset = "0x965550", VA = "0x180966950")]
		public void TriggerRenderer(bool trigger)
		{
		}

		// Token: 0x0601195A RID: 72026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601195A")]
		[Address(RVA = "0x966820", Offset = "0x965420", VA = "0x180966820")]
		public void SetRendererActive(bool active)
		{
		}

		// Token: 0x0601195B RID: 72027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601195B")]
		[Address(RVA = "0x9668F0", Offset = "0x9654F0", VA = "0x1809668F0")]
		public void StopProjectile()
		{
		}

		// Token: 0x0601195C RID: 72028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601195C")]
		[Address(RVA = "0x966AC0", Offset = "0x9656C0", VA = "0x180966AC0")]
		public Act45SideHarpoonRenderer()
		{
		}

		// Token: 0x0601195D RID: 72029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601195D")]
		[Address(RVA = "0x966AB0", Offset = "0x9656B0", VA = "0x180966AB0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x04013A80 RID: 80512
		[Token(Token = "0x4013A80")]
		private const string LINE_ON_KEY = "act45side_line_on";

		// Token: 0x04013A81 RID: 80513
		[Token(Token = "0x4013A81")]
		private const string LINE_OFF_KEY = "act45side_line_off";

		// Token: 0x04013A82 RID: 80514
		[Token(Token = "0x4013A82")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _switchKey;

		// Token: 0x04013A83 RID: 80515
		[Token(Token = "0x4013A83")]
		[FieldOffset(Offset = "0x98")]
		private Animator m_animator;

		// Token: 0x04013A84 RID: 80516
		[Token(Token = "0x4013A84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013A85 RID: 80517
		[Token(Token = "0x4013A85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TriggerRenderer;

		// Token: 0x04013A86 RID: 80518
		[Token(Token = "0x4013A86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetRendererActive;

		// Token: 0x04013A87 RID: 80519
		[Token(Token = "0x4013A87")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StopProjectile;

		// Token: 0x04013A88 RID: 80520
		[Token(Token = "0x4013A88")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
