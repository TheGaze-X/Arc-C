using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	public struct Angle : IEquatable<Angle>
	{
		// Token: 0x06000E2C RID: 3628 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x5B02150", Offset = "0x5B00D50", VA = "0x185B02150")]
		internal static Angle None()
		{
			return default(Angle);
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x1700033B")]
		public float value
		{
			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0x877290", Offset = "0x875E90", VA = "0x180877290")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x46B3760", Offset = "0x46B2360", VA = "0x1846B3760")]
		public Angle(float value, AngleUnit unit)
		{
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x46B3760", Offset = "0x46B2360", VA = "0x1846B3760")]
		private Angle(float value, Angle.Unit unit)
		{
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00007128 File Offset: 0x00005328
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x5B02170", Offset = "0x5B00D70", VA = "0x185B02170")]
		public float ToDegrees()
		{
			return 0f;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x5B02370", Offset = "0x5B00F70", VA = "0x185B02370")]
		public static implicit operator Angle(float value)
		{
			return default(Angle);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x5B02340", Offset = "0x5B00F40", VA = "0x185B02340")]
		public static bool operator ==(Angle lhs, Angle rhs)
		{
			return default(bool);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x5B02100", Offset = "0x5B00D00", VA = "0x185B02100", Slot = "4")]
		public bool Equals(Angle other)
		{
			return default(bool);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x5B02050", Offset = "0x5B00C50", VA = "0x185B02050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x5B02130", Offset = "0x5B00D30", VA = "0x185B02130", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x5B021D0", Offset = "0x5B00DD0", VA = "0x185B021D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x0")]
		private float m_Value;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x4")]
		private Angle.Unit m_Unit;

		// Token: 0x02000218 RID: 536
		[Token(Token = "0x2000218")]
		private enum Unit
		{
			// Token: 0x0400079C RID: 1948
			[Token(Token = "0x400079C")]
			Degree,
			// Token: 0x0400079D RID: 1949
			[Token(Token = "0x400079D")]
			Gradian,
			// Token: 0x0400079E RID: 1950
			[Token(Token = "0x400079E")]
			Radian,
			// Token: 0x0400079F RID: 1951
			[Token(Token = "0x400079F")]
			Turn,
			// Token: 0x040007A0 RID: 1952
			[Token(Token = "0x40007A0")]
			None
		}
	}
}
