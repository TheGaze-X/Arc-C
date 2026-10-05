using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020FB RID: 8443
	[Token(Token = "0x20020FB")]
	public class Act6FunMoveController : MoveController
	{
		// Token: 0x0600CF08 RID: 53000 RVA: 0x0004AC58 File Offset: 0x00048E58
		[Token(Token = "0x600CF08")]
		[Address(RVA = "0x35084D0", Offset = "0x35070D0", VA = "0x1835084D0", Slot = "6")]
		public override Vector2 CalculateMoveDelta(Vector2 direction, float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600CF09 RID: 53001 RVA: 0x0004AC70 File Offset: 0x00048E70
		[Token(Token = "0x600CF09")]
		[Address(RVA = "0x3508960", Offset = "0x3507560", VA = "0x183508960")]
		private Vector2 _CalculateTotalForceWithoutAvoidForce(Vector2 direction, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600CF0A RID: 53002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF0A")]
		[Address(RVA = "0x3508B70", Offset = "0x3507770", VA = "0x183508B70")]
		public Act6FunMoveController()
		{
		}

		// Token: 0x0600CF0B RID: 53003 RVA: 0x0004AC88 File Offset: 0x00048E88
		[Token(Token = "0x600CF0B")]
		[Address(RVA = "0x95DE00", Offset = "0x95CA00", VA = "0x18095DE00")]
		private Vector2 <>xLuaBaseProxy_CalculateMoveDelta(Vector2 P0, float P1, out bool P2)
		{
			return default(Vector2);
		}

		// Token: 0x0400DCC5 RID: 56517
		[Token(Token = "0x400DCC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CalculateMoveDelta;

		// Token: 0x0400DCC6 RID: 56518
		[Token(Token = "0x400DCC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CalculateTotalForceWithoutAvoidForce;

		// Token: 0x0400DCC7 RID: 56519
		[Token(Token = "0x400DCC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
