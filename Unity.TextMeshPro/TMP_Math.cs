using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public static class TMP_Math
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x58A3490", Offset = "0x58A2090", VA = "0x1858A3490")]
		public static bool Approximately(float a, float b)
		{
			return default(bool);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x54DFCF0", Offset = "0x54DE8F0", VA = "0x1854DFCF0")]
		public static int Mod(int a, int b)
		{
			return 0;
		}

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		public const float FLOAT_MAX = 32767f;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		public const float FLOAT_MIN = -32767f;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		public const int INT_MAX = 2147483647;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		public const int INT_MIN = -2147483647;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		public const float FLOAT_UNSET = -32767f;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		public const int INT_UNSET = -32767;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x0")]
		public static Vector2 MAX_16BIT;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x8")]
		public static Vector2 MIN_16BIT;
	}
}
