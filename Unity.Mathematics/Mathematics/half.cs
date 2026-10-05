using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct half : IEquatable<half>, IFormattable
	{
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0001E678 File Offset: 0x0001C878
		[Token(Token = "0x170005C8")]
		public static float MaxValue
		{
			[Token(Token = "0x6001598")]
			[Address(RVA = "0x57D68C0", Offset = "0x57D54C0", VA = "0x1857D68C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x0001E690 File Offset: 0x0001C890
		[Token(Token = "0x170005C9")]
		public static float MinValue
		{
			[Token(Token = "0x6001599")]
			[Address(RVA = "0x57D68E0", Offset = "0x57D54E0", VA = "0x1857D68E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		[Token(Token = "0x170005CA")]
		public static half MaxValueAsHalf
		{
			[Token(Token = "0x600159A")]
			[Address(RVA = "0x57D68B0", Offset = "0x57D54B0", VA = "0x1857D68B0")]
			get
			{
				return default(half);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x0001E6C0 File Offset: 0x0001C8C0
		[Token(Token = "0x170005CB")]
		public static half MinValueAsHalf
		{
			[Token(Token = "0x600159B")]
			[Address(RVA = "0x57D68D0", Offset = "0x57D54D0", VA = "0x1857D68D0")]
			get
			{
				return default(half);
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x4EDD9F0", Offset = "0x4EDC5F0", VA = "0x184EDD9F0")]
		[MethodImpl(256)]
		public half(half x)
		{
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x57D6890", Offset = "0x57D5490", VA = "0x1857D6890")]
		[MethodImpl(256)]
		public half(float v)
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x57D6870", Offset = "0x57D5470", VA = "0x1857D6870")]
		[MethodImpl(256)]
		public half(double v)
		{
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0001E6D8 File Offset: 0x0001C8D8
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x571B980", Offset = "0x571A580", VA = "0x18571B980")]
		[MethodImpl(256)]
		public static explicit operator half(float v)
		{
			return default(half);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x571B970", Offset = "0x571A570", VA = "0x18571B970")]
		[MethodImpl(256)]
		public static explicit operator half(double v)
		{
			return default(half);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0001E708 File Offset: 0x0001C908
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x57D6960", Offset = "0x57D5560", VA = "0x1857D6960")]
		[MethodImpl(256)]
		public static implicit operator float(half d)
		{
			return 0f;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0001E720 File Offset: 0x0001C920
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x57D68F0", Offset = "0x57D54F0", VA = "0x1857D68F0")]
		[MethodImpl(256)]
		public static implicit operator double(half d)
		{
			return 0.0;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0001E738 File Offset: 0x0001C938
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x4EDDA00", Offset = "0x4EDC600", VA = "0x184EDDA00")]
		[MethodImpl(256)]
		public static bool operator ==(half lhs, half rhs)
		{
			return default(bool);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0001E750 File Offset: 0x0001C950
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x57D69D0", Offset = "0x57D55D0", VA = "0x1857D69D0")]
		[MethodImpl(256)]
		public static bool operator !=(half lhs, half rhs)
		{
			return default(bool);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0001E768 File Offset: 0x0001C968
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x4CA90E0", Offset = "0x4CA7CE0", VA = "0x184CA90E0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(half rhs)
		{
			return default(bool);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0001E780 File Offset: 0x0001C980
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x57D6760", Offset = "0x57D5360", VA = "0x1857D6760", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0001E798 File Offset: 0x0001C998
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x3D28B50", Offset = "0x3D27750", VA = "0x183D28B50", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x57D67F0", Offset = "0x57D53F0", VA = "0x1857D67F0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x57D0780", Offset = "0x57CF380", VA = "0x1857D0780", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x0")]
		public ushort value;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly half zero;
	}
}
