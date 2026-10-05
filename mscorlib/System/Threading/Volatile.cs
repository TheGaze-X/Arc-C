using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	public static class Volatile
	{
		// Token: 0x06001390 RID: 5008 RVA: 0x0000EF88 File Offset: 0x0000D188
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x4AF2DA0", Offset = "0x4AF19A0", VA = "0x184AF2DA0")]
		[Intrinsic]
		public static bool Read(ref bool location)
		{
			return default(bool);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x4AF2D80", Offset = "0x4AF1980", VA = "0x184AF2D80")]
		[Intrinsic]
		public static int Read(ref int location)
		{
			return 0;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x4AF2DC0", Offset = "0x4AF19C0", VA = "0x184AF2DC0")]
		[Intrinsic]
		public static void Write(ref int location, int value)
		{
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001393")]
		[Intrinsic]
		public static T Read<T>(ref T location) where T : class
		{
			return null;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001394")]
		[Intrinsic]
		public static void Write<T>(ref T location, T value) where T : class
		{
		}

		// Token: 0x02000240 RID: 576
		[Token(Token = "0x2000240")]
		private struct VolatileBoolean
		{
			// Token: 0x04000B05 RID: 2821
			[Token(Token = "0x4000B05")]
			[FieldOffset(Offset = "0x0")]
			public bool Value;
		}

		// Token: 0x02000241 RID: 577
		[Token(Token = "0x2000241")]
		private struct VolatileInt32
		{
			// Token: 0x04000B06 RID: 2822
			[Token(Token = "0x4000B06")]
			[FieldOffset(Offset = "0x0")]
			public int Value;
		}

		// Token: 0x02000242 RID: 578
		[Token(Token = "0x2000242")]
		private struct VolatileObject
		{
			// Token: 0x04000B07 RID: 2823
			[Token(Token = "0x4000B07")]
			[FieldOffset(Offset = "0x0")]
			public object Value;
		}
	}
}
