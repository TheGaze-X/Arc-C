using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002657 RID: 9815
	[Token(Token = "0x2002657")]
	public static class DeterministicUtil
	{
		// Token: 0x060100C3 RID: 65731 RVA: 0x00061F08 File Offset: 0x00060108
		[Token(Token = "0x60100C3")]
		[Address(RVA = "0x7C2FE0", Offset = "0x7C1BE0", VA = "0x1807C2FE0")]
		public static Vector2 TruncateLocalPos(Vector2 v)
		{
			return default(Vector2);
		}

		// Token: 0x060100C4 RID: 65732 RVA: 0x00061F20 File Offset: 0x00060120
		[Token(Token = "0x60100C4")]
		[Address(RVA = "0x7C2F60", Offset = "0x7C1B60", VA = "0x1807C2F60")]
		public static Vector3 TruncateLocalPos(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x060100C5 RID: 65733 RVA: 0x00061F38 File Offset: 0x00060138
		[Token(Token = "0x60100C5")]
		[Address(RVA = "0x7C3030", Offset = "0x7C1C30", VA = "0x1807C3030")]
		private static float _TruncateInternal(float val, int digits)
		{
			return 0f;
		}

		// Token: 0x04011DA0 RID: 73120
		[Token(Token = "0x4011DA0")]
		private const int TRUNCATE_DIGIT_NUM = 4;
	}
}
