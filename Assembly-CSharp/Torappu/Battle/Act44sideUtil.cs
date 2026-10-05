using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020F9 RID: 8441
	[Token(Token = "0x20020F9")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act44sideUtil
	{
		// Token: 0x0600CEFD RID: 52989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEFD")]
		[Address(RVA = "0x34F7A60", Offset = "0x34F6660", VA = "0x1834F7A60")]
		public static void CalculateSourceCollisionForce(Enemy source, Enemy target, out Vector2 direction, out int forceVal)
		{
		}

		// Token: 0x0600CEFE RID: 52990 RVA: 0x0004ABC8 File Offset: 0x00048DC8
		[Token(Token = "0x600CEFE")]
		[Address(RVA = "0x34F7F30", Offset = "0x34F6B30", VA = "0x1834F7F30")]
		private static int _CalculateForceValueByCollisionForce(float collisionForce)
		{
			return 0;
		}

		// Token: 0x0400DCAA RID: 56490
		[Token(Token = "0x400DCAA")]
		private const float COLLISION_SAFE_ANGLE_COS = 0.5f;

		// Token: 0x0400DCAB RID: 56491
		[Token(Token = "0x400DCAB")]
		private const int COLLISION_SAFE_FORCE_LEVEL = 2;

		// Token: 0x0400DCAC RID: 56492
		[Token(Token = "0x400DCAC")]
		private const int MAX_FORCE_LEVEL = 10;

		// Token: 0x0400DCAD RID: 56493
		[Token(Token = "0x400DCAD")]
		private const int COLLISION_FORCE_MULTIPLIER = 10;

		// Token: 0x0400DCAE RID: 56494
		[Token(Token = "0x400DCAE")]
		private const float COLLISION_FORCE_MASS_FACTOR = 0.6f;

		// Token: 0x0400DCAF RID: 56495
		[Token(Token = "0x400DCAF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] collisionForceLimit;

		// Token: 0x0400DCB0 RID: 56496
		[Token(Token = "0x400DCB0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] transforForceValue;

		// Token: 0x0400DCB1 RID: 56497
		[Token(Token = "0x400DCB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalculateSourceCollisionForce;

		// Token: 0x0400DCB2 RID: 56498
		[Token(Token = "0x400DCB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalculateForceValueByCollisionForce;
	}
}
