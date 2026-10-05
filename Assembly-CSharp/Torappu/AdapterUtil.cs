using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x2000595")]
	public static class AdapterUtil
	{
		// Token: 0x06005C3E RID: 23614 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		[Token(Token = "0x6005C3E")]
		[Address(RVA = "0x1CE4410", Offset = "0x1CE3010", VA = "0x181CE4410")]
		public static Vector2 CurrentResolution()
		{
			return default(Vector2);
		}

		// Token: 0x06005C3F RID: 23615 RVA: 0x0002F208 File Offset: 0x0002D408
		[Token(Token = "0x6005C3F")]
		[Address(RVA = "0x1CE4690", Offset = "0x1CE3290", VA = "0x181CE4690")]
		public static bool TryCalculateLerpRatio(Vector2 fromResolution, Vector2 toResolution, Vector2 curResolution, AdapterUtil.FitMode fitMode, out float ratio)
		{
			return default(bool);
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x0002F220 File Offset: 0x0002D420
		[Token(Token = "0x6005C40")]
		[Address(RVA = "0x1CE4480", Offset = "0x1CE3080", VA = "0x181CE4480")]
		public static float FitHeightLerpRatio4By3(bool clamp01 = true)
		{
			return 0f;
		}

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector2 RESOLUTION_4_3;

		// Token: 0x040021F2 RID: 8690
		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Vector2 RESOLUTION_16_9;

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Vector2 RESOLUTION_21_9;

		// Token: 0x02000596 RID: 1430
		[Token(Token = "0x2000596")]
		public enum FitMode
		{
			// Token: 0x040021F5 RID: 8693
			[Token(Token = "0x40021F5")]
			FIT_WIDTH = 1,
			// Token: 0x040021F6 RID: 8694
			[Token(Token = "0x40021F6")]
			FIT_HEIGHT
		}
	}
}
