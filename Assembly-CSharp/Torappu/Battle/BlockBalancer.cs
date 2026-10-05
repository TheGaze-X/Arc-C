using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002655 RID: 9813
	[Token(Token = "0x2002655")]
	public static class BlockBalancer
	{
		// Token: 0x060100BA RID: 65722 RVA: 0x00061E48 File Offset: 0x00060048
		[Token(Token = "0x60100BA")]
		[Address(RVA = "0x7C1050", Offset = "0x7BFC50", VA = "0x1807C1050")]
		public static Vector2 CalculateBlockOffset(IList<Enemy> blockees, Enemy target, Character source)
		{
			return default(Vector2);
		}

		// Token: 0x04011D94 RID: 73108
		[Token(Token = "0x4011D94")]
		private const float MIN_DIST_BTW_BLOCKEES_SQR = 0.010000001f;

		// Token: 0x04011D95 RID: 73109
		[Token(Token = "0x4011D95")]
		private const float CLOSE_DIST_BTW_BLOCKEERS = 0.4f;

		// Token: 0x04011D96 RID: 73110
		[Token(Token = "0x4011D96")]
		private const float CLOSE_DIST_BTW_BLOCKEES_SQR = 0.16000001f;

		// Token: 0x04011D97 RID: 73111
		[Token(Token = "0x4011D97")]
		private const float MERGE_FACTOR_OF_SEPARATION = 0.2f;
	}
}
