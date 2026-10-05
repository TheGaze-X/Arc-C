using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.TPhysic2D;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002443 RID: 9283
	[Token(Token = "0x2002443")]
	public class SeparateMoveController : MoveController
	{
		// Token: 0x0600ED59 RID: 60761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED59")]
		[Address(RVA = "0x64C6D0", Offset = "0x64B2D0", VA = "0x18064C6D0", Slot = "8")]
		protected override void CalculateIsHanging(Vector2 direction, ref Vector2 resultForce)
		{
		}

		// Token: 0x0600ED5A RID: 60762 RVA: 0x00056B68 File Offset: 0x00054D68
		[Token(Token = "0x600ED5A")]
		[Address(RVA = "0x64C870", Offset = "0x64B470", VA = "0x18064C870")]
		private Vector2 _CalculateSeparationForce()
		{
			return default(Vector2);
		}

		// Token: 0x0600ED5B RID: 60763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED5B")]
		[Address(RVA = "0x64D2A0", Offset = "0x64BEA0", VA = "0x18064D2A0")]
		public SeparateMoveController()
		{
		}

		// Token: 0x0600ED5C RID: 60764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED5C")]
		[Address(RVA = "0x64C860", Offset = "0x64B460", VA = "0x18064C860")]
		private void <>xLuaBaseProxy_CalculateIsHanging(Vector2 P0, ref Vector2 P1)
		{
		}

		// Token: 0x04010679 RID: 67193
		[Token(Token = "0x4010679")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _separationForceFactor;

		// Token: 0x0401067A RID: 67194
		[Token(Token = "0x401067A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _separationRadius;

		// Token: 0x0401067B RID: 67195
		[Token(Token = "0x401067B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _minSeparationSumDelta;

		// Token: 0x0401067C RID: 67196
		[Token(Token = "0x401067C")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int _separationTickPeriod;

		// Token: 0x0401067D RID: 67197
		[Token(Token = "0x401067D")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<ObjectPtr<Enemy>> m_relevantUnitsPtr;

		// Token: 0x0401067E RID: 67198
		[Token(Token = "0x401067E")]
		[FieldOffset(Offset = "0x78")]
		private TCircle m_circle;

		// Token: 0x0401067F RID: 67199
		[Token(Token = "0x401067F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CalculateIsHanging;

		// Token: 0x04010680 RID: 67200
		[Token(Token = "0x4010680")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CalculateSeparationForce;

		// Token: 0x04010681 RID: 67201
		[Token(Token = "0x4010681")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
