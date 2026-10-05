using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Numerics
{
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	[Intrinsic]
	public struct Vector<T> : System.IEquatable<Vector<T>>, System.IFormattable where T : struct
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x00015F00 File Offset: 0x00014100
		[Token(Token = "0x170005CB")]
		public static int Count
		{
			[Token(Token = "0x6002828")]
			[Intrinsic]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x00015F18 File Offset: 0x00014118
		[Token(Token = "0x170005CC")]
		public static Vector<T> Zero
		{
			[Token(Token = "0x6002829")]
			[Intrinsic]
			get
			{
				return default(Vector<T>);
			}
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x600282A")]
		private static int InitializeCount()
		{
			return 0;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282B")]
		[Intrinsic]
		public Vector(T value)
		{
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282C")]
		internal unsafe Vector(void* dataPointer)
		{
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282D")]
		internal unsafe Vector(void* dataPointer, int offset)
		{
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282E")]
		private Vector(ref Register existingRegister)
		{
		}

		// Token: 0x170005CD RID: 1485
		[Token(Token = "0x170005CD")]
		public T this[int index]
		{
			[Token(Token = "0x600282F")]
			[Intrinsic]
			get
			{
				return null;
			}
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00015F48 File Offset: 0x00014148
		[Token(Token = "0x6002830")]
		[MethodImpl(256)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00015F60 File Offset: 0x00014160
		[Token(Token = "0x6002831")]
		[Intrinsic]
		public bool Equals(Vector<T> other)
		{
			return default(bool);
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00015F78 File Offset: 0x00014178
		[Token(Token = "0x6002832")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002833")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002834")]
		public string ToString(string format, System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00015F90 File Offset: 0x00014190
		[Token(Token = "0x6002835")]
		[MethodImpl(256)]
		public static bool operator ==(Vector<T> left, Vector<T> right)
		{
			return default(bool);
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x00015FA8 File Offset: 0x000141A8
		[Token(Token = "0x6002836")]
		[MethodImpl(256)]
		public static bool operator !=(Vector<T> left, Vector<T> right)
		{
			return default(bool);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00015FC0 File Offset: 0x000141C0
		[Token(Token = "0x6002837")]
		[System.CLSCompliant(false)]
		[Intrinsic]
		public static explicit operator Vector<ulong>(Vector<T> value)
		{
			return default(Vector<ulong>);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00015FD8 File Offset: 0x000141D8
		[Token(Token = "0x6002838")]
		[Intrinsic]
		[MethodImpl(256)]
		internal static Vector<T> Equals(Vector<T> left, Vector<T> right)
		{
			return default(Vector<T>);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00015FF0 File Offset: 0x000141F0
		[Token(Token = "0x6002839")]
		[MethodImpl(256)]
		private static bool ScalarEquals(T left, T right)
		{
			return default(bool);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600283A")]
		[MethodImpl(256)]
		private static T GetOneValue()
		{
			return null;
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600283B")]
		[MethodImpl(256)]
		private static T GetAllBitsSetValue()
		{
			return null;
		}

		// Token: 0x04001689 RID: 5769
		[Token(Token = "0x4001689")]
		[FieldOffset(Offset = "0x0")]
		private Register register;

		// Token: 0x0400168A RID: 5770
		[Token(Token = "0x400168A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int s_count;

		// Token: 0x0400168B RID: 5771
		[Token(Token = "0x400168B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector<T> s_zero;

		// Token: 0x0400168C RID: 5772
		[Token(Token = "0x400168C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector<T> s_one;

		// Token: 0x0400168D RID: 5773
		[Token(Token = "0x400168D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector<T> s_allOnes;

		// Token: 0x02000556 RID: 1366
		[Token(Token = "0x2000556")]
		private struct VectorSizeHelper
		{
			// Token: 0x0400168E RID: 5774
			[Token(Token = "0x400168E")]
			[FieldOffset(Offset = "0x0")]
			internal Vector<T> _placeholder;

			// Token: 0x0400168F RID: 5775
			[Token(Token = "0x400168F")]
			[FieldOffset(Offset = "0x0")]
			internal byte _byte;
		}
	}
}
