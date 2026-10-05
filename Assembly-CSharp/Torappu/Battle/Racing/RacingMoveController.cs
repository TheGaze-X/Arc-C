using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Racing
{
	// Token: 0x02002983 RID: 10627
	[Token(Token = "0x2002983")]
	public class RacingMoveController : MoveController
	{
		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x0601193E RID: 71998 RVA: 0x0006C168 File Offset: 0x0006A368
		// (set) Token: 0x0601193F RID: 71999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170026D9")]
		public Vector2 dragForce
		{
			[Token(Token = "0x601193E")]
			[Address(RVA = "0x95E1D0", Offset = "0x95CDD0", VA = "0x18095E1D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x601193F")]
			[Address(RVA = "0x95E240", Offset = "0x95CE40", VA = "0x18095E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06011940 RID: 72000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011940")]
		[Address(RVA = "0x95DD40", Offset = "0x95C940", VA = "0x18095DD40")]
		public void InitRacingMoveController(RacingEnemy owner)
		{
		}

		// Token: 0x06011941 RID: 72001 RVA: 0x0006C180 File Offset: 0x0006A380
		[Token(Token = "0x6011941")]
		[Address(RVA = "0x95DC10", Offset = "0x95C810", VA = "0x18095DC10", Slot = "6")]
		public override Vector2 CalculateMoveDelta(Vector2 direction, float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x06011942 RID: 72002 RVA: 0x0006C198 File Offset: 0x0006A398
		[Token(Token = "0x6011942")]
		[Address(RVA = "0x95DF00", Offset = "0x95CB00", VA = "0x18095DF00", Slot = "7")]
		protected override Vector2 _CalculateSteeringForce(Vector2 moveForce, Vector2 direction)
		{
			return default(Vector2);
		}

		// Token: 0x06011943 RID: 72003 RVA: 0x0006C1B0 File Offset: 0x0006A3B0
		[Token(Token = "0x6011943")]
		[Address(RVA = "0x95DE20", Offset = "0x95CA20", VA = "0x18095DE20")]
		private float _CalculateRacingSteeringFactor()
		{
			return 0f;
		}

		// Token: 0x06011944 RID: 72004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011944")]
		[Address(RVA = "0x95E170", Offset = "0x95CD70", VA = "0x18095E170")]
		public RacingMoveController()
		{
		}

		// Token: 0x06011945 RID: 72005 RVA: 0x0006C1C8 File Offset: 0x0006A3C8
		[Token(Token = "0x6011945")]
		[Address(RVA = "0x95DE00", Offset = "0x95CA00", VA = "0x18095DE00")]
		private Vector2 <>xLuaBaseProxy_CalculateMoveDelta(Vector2 P0, float P1, out bool P2)
		{
			return default(Vector2);
		}

		// Token: 0x06011946 RID: 72006 RVA: 0x0006C1E0 File Offset: 0x0006A3E0
		[Token(Token = "0x6011946")]
		[Address(RVA = "0x95DE10", Offset = "0x95CA10", VA = "0x18095DE10")]
		private Vector2 <>xLuaBaseProxy__CalculateSteeringForce(Vector2 P0, Vector2 P1)
		{
			return default(Vector2);
		}

		// Token: 0x04013A67 RID: 80487
		[Token(Token = "0x4013A67")]
		[FieldOffset(Offset = "0x60")]
		private ObjectPtr<RacingEnemy> m_owner;

		// Token: 0x04013A69 RID: 80489
		[Token(Token = "0x4013A69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dragForce;

		// Token: 0x04013A6A RID: 80490
		[Token(Token = "0x4013A6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dragForce;

		// Token: 0x04013A6B RID: 80491
		[Token(Token = "0x4013A6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitRacingMoveController;

		// Token: 0x04013A6C RID: 80492
		[Token(Token = "0x4013A6C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalculateMoveDelta;

		// Token: 0x04013A6D RID: 80493
		[Token(Token = "0x4013A6D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CalculateSteeringForce;

		// Token: 0x04013A6E RID: 80494
		[Token(Token = "0x4013A6E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalculateRacingSteeringFactor;

		// Token: 0x04013A6F RID: 80495
		[Token(Token = "0x4013A6F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
