using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002615 RID: 9749
	[Token(Token = "0x2002615")]
	public class TraceTargetEnemy : Enemy
	{
		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x0600FE55 RID: 65109 RVA: 0x00060870 File Offset: 0x0005EA70
		[Token(Token = "0x1700226A")]
		protected bool searchAroundBall
		{
			[Token(Token = "0x600FE55")]
			[Address(RVA = "0x7651A0", Offset = "0x763DA0", VA = "0x1807651A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FE56 RID: 65110 RVA: 0x00060888 File Offset: 0x0005EA88
		[Token(Token = "0x600FE56")]
		[Address(RVA = "0x764720", Offset = "0x763320", VA = "0x180764720", Slot = "217")]
		protected override Vector2 _MoveByRoute(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FE57 RID: 65111 RVA: 0x000608A0 File Offset: 0x0005EAA0
		[Token(Token = "0x600FE57")]
		[Address(RVA = "0x764B90", Offset = "0x763790", VA = "0x180764B90")]
		private Vector2 _MoveToTarget(float deltaTime, out bool isHanging, Unit target)
		{
			return default(Vector2);
		}

		// Token: 0x0600FE58 RID: 65112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE58")]
		[Address(RVA = "0x765120", Offset = "0x763D20", VA = "0x180765120")]
		public TraceTargetEnemy()
		{
		}

		// Token: 0x0600FE59 RID: 65113 RVA: 0x000608B8 File Offset: 0x0005EAB8
		[Token(Token = "0x600FE59")]
		[Address(RVA = "0x6F0050", Offset = "0x6EEC50", VA = "0x1806F0050")]
		private Vector2 <>xLuaBaseProxy__MoveByRoute(float P0, out bool P1)
		{
			return default(Vector2);
		}

		// Token: 0x04011AA3 RID: 72355
		[Token(Token = "0x4011AA3")]
		[FieldOffset(Offset = "0x528")]
		[SerializeField]
		private Ability _searchTargetAbility;

		// Token: 0x04011AA4 RID: 72356
		[Token(Token = "0x4011AA4")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		private bool _searchAroundBall;

		// Token: 0x04011AA5 RID: 72357
		[Token(Token = "0x4011AA5")]
		[FieldOffset(Offset = "0x538")]
		[SerializeField]
		[Inspect("searchAroundBall")]
		private Ability _searchBallAbility;

		// Token: 0x04011AA6 RID: 72358
		[Token(Token = "0x4011AA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_searchAroundBall;

		// Token: 0x04011AA7 RID: 72359
		[Token(Token = "0x4011AA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__MoveByRoute;

		// Token: 0x04011AA8 RID: 72360
		[Token(Token = "0x4011AA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MoveToTarget;

		// Token: 0x04011AA9 RID: 72361
		[Token(Token = "0x4011AA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
