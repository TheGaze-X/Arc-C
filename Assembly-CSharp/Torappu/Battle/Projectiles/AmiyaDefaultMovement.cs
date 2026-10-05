using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029CD RID: 10701
	[Token(Token = "0x20029CD")]
	public class AmiyaDefaultMovement : BasicMovement
	{
		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x06011BBE RID: 72638 RVA: 0x0006CA50 File Offset: 0x0006AC50
		[Token(Token = "0x1700271E")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011BBE")]
			[Address(RVA = "0x994AB0", Offset = "0x9936B0", VA = "0x180994AB0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011BBF RID: 72639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BBF")]
		[Address(RVA = "0x9941F0", Offset = "0x992DF0", VA = "0x1809941F0", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BC0 RID: 72640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BC0")]
		[Address(RVA = "0x9946C0", Offset = "0x9932C0", VA = "0x1809946C0", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011BC1 RID: 72641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BC1")]
		[Address(RVA = "0x994A40", Offset = "0x993640", VA = "0x180994A40")]
		public AmiyaDefaultMovement()
		{
		}

		// Token: 0x06011BC5 RID: 72645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BC5")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BC6 RID: 72646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BC6")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013E35 RID: 81461
		[Token(Token = "0x4013E35")]
		private const float MIN_FULL_HEIGHT = 0f;

		// Token: 0x04013E36 RID: 81462
		[Token(Token = "0x4013E36")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _startDistance;

		// Token: 0x04013E37 RID: 81463
		[Token(Token = "0x4013E37")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _zOffset;

		// Token: 0x04013E38 RID: 81464
		[Token(Token = "0x4013E38")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _startDuration;

		// Token: 0x04013E39 RID: 81465
		[Token(Token = "0x4013E39")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _time;

		// Token: 0x04013E3A RID: 81466
		[Token(Token = "0x4013E3A")]
		[FieldOffset(Offset = "0xB8")]
		private float m_velocityN;

		// Token: 0x04013E3B RID: 81467
		[Token(Token = "0x4013E3B")]
		[FieldOffset(Offset = "0xBC")]
		private float m_remainingTime;

		// Token: 0x04013E3C RID: 81468
		[Token(Token = "0x4013E3C")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_startPhaseFinished;

		// Token: 0x04013E3D RID: 81469
		[Token(Token = "0x4013E3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013E3E RID: 81470
		[Token(Token = "0x4013E3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E3F RID: 81471
		[Token(Token = "0x4013E3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E40 RID: 81472
		[Token(Token = "0x4013E40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
