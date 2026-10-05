using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public static class MathUtils
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4E50B30", Offset = "0x4E4F730", VA = "0x184E50B30")]
		public static float Sin(float radians)
		{
			return 0f;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4E506C0", Offset = "0x4E4F2C0", VA = "0x184E506C0")]
		public static float Cos(float radians)
		{
			return 0f;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000034C4 File Offset: 0x000016C4
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x4E50AD0", Offset = "0x4E4F6D0", VA = "0x184E50AD0")]
		public static float SinDeg(float degrees)
		{
			return 0f;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x4E50660", Offset = "0x4E4F260", VA = "0x184E50660")]
		public static float CosDeg(float degrees)
		{
			return 0f;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x4E505D0", Offset = "0x4E4F1D0", VA = "0x184E505D0")]
		public static float Atan2(float y, float x)
		{
			return 0f;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x4E50640", Offset = "0x4E4F240", VA = "0x184E50640")]
		public static float Clamp(float value, float min, float max)
		{
			return 0f;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x4E508E0", Offset = "0x4E4F4E0", VA = "0x184E508E0")]
		public static float RandomTriangle(float min, float max)
		{
			return 0f;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x4E50720", Offset = "0x4E4F320", VA = "0x184E50720")]
		public static float RandomTriangle(float min, float max, float mode)
		{
			return 0f;
		}

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		public const float PI = 3.1415927f;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		public const float PI2 = 6.2831855f;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		public const float RadDeg = 57.295776f;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		public const float DegRad = 0.017453292f;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x0")]
		private static Random random;
	}
}
