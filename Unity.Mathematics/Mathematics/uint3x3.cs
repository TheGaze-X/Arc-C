using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct uint3x3 : IEquatable<uint3x3>, IFormattable
	{
		// Token: 0x060020FD RID: 8445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x57B5D70", Offset = "0x57B4970", VA = "0x1857B5D70")]
		[MethodImpl(256)]
		public uint3x3(uint3 c0, uint3 c1, uint3 c2)
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x57E3BE0", Offset = "0x57E27E0", VA = "0x1857E3BE0")]
		[MethodImpl(256)]
		public uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22)
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x57E3B40", Offset = "0x57E2740", VA = "0x1857E3B40")]
		[MethodImpl(256)]
		public uint3x3(uint v)
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x56FF630", Offset = "0x56FE230", VA = "0x1856FF630")]
		[MethodImpl(256)]
		public uint3x3(bool v)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x56FF500", Offset = "0x56FE100", VA = "0x1856FF500")]
		[MethodImpl(256)]
		public uint3x3(bool3x3 v)
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x57E3B40", Offset = "0x57E2740", VA = "0x1857E3B40")]
		[MethodImpl(256)]
		public uint3x3(int v)
		{
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x57E3C40", Offset = "0x57E2840", VA = "0x1857E3C40")]
		[MethodImpl(256)]
		public uint3x3(int3x3 v)
		{
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x5703F00", Offset = "0x5702B00", VA = "0x185703F00")]
		[MethodImpl(256)]
		public uint3x3(float v)
		{
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x5704120", Offset = "0x5702D20", VA = "0x185704120")]
		[MethodImpl(256)]
		public uint3x3(float3x3 v)
		{
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x5703E30", Offset = "0x5702A30", VA = "0x185703E30")]
		[MethodImpl(256)]
		public uint3x3(double v)
		{
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x5703FD0", Offset = "0x5702BD0", VA = "0x185703FD0")]
		[MethodImpl(256)]
		public uint3x3(double3x3 v)
		{
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x5729A30", Offset = "0x5728630", VA = "0x185729A30")]
		[MethodImpl(256)]
		public static implicit operator uint3x3(uint v)
		{
			return default(uint3x3);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x57E51D0", Offset = "0x57E3DD0", VA = "0x1857E51D0")]
		[MethodImpl(256)]
		public static explicit operator uint3x3(bool v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x57E5200", Offset = "0x57E3E00", VA = "0x1857E5200")]
		[MethodImpl(256)]
		public static explicit operator uint3x3(bool3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x0002C910 File Offset: 0x0002AB10
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x5729A30", Offset = "0x5728630", VA = "0x185729A30")]
		[MethodImpl(256)]
		public static explicit operator uint3x3(int v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x0002C928 File Offset: 0x0002AB28
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x5729AD0", Offset = "0x57286D0", VA = "0x185729AD0")]
		[MethodImpl(256)]
		public static explicit operator uint3x3(int3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0002C940 File Offset: 0x0002AB40
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x5817350", Offset = "0x5815F50", VA = "0x185817350")]
		[MethodImpl(256)]
		public static explicit operator uint3x3(float v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0002C958 File Offset: 0x0002AB58
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x5817300", Offset = "0x5815F00", VA = "0x185817300")]
		[MethodImpl(256)]
		public static explicit operator uint3x3(float3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x0002C970 File Offset: 0x0002AB70
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x5817380", Offset = "0x5815F80", VA = "0x185817380")]
		[MethodImpl(256)]
		public static explicit operator uint3x3(double v)
		{
			return default(uint3x3);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x0002C988 File Offset: 0x0002AB88
		[Token(Token = "0x6002110")]
		[Address(RVA = "0x58172A0", Offset = "0x5815EA0", VA = "0x1858172A0")]
		[MethodImpl(256)]
		public static explicit operator uint3x3(double3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x57E6600", Offset = "0x57E5200", VA = "0x1857E6600")]
		[MethodImpl(256)]
		public static uint3x3 operator *(uint3x3 lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x57E6860", Offset = "0x57E5460", VA = "0x1857E6860")]
		[MethodImpl(256)]
		public static uint3x3 operator *(uint3x3 lhs, uint rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x57E6770", Offset = "0x57E5370", VA = "0x1857E6770")]
		[MethodImpl(256)]
		public static uint3x3 operator *(uint lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x57E3DF0", Offset = "0x57E29F0", VA = "0x1857E3DF0")]
		[MethodImpl(256)]
		public static uint3x3 operator +(uint3x3 lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x0002CA00 File Offset: 0x0002AC00
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x57E3F60", Offset = "0x57E2B60", VA = "0x1857E3F60")]
		[MethodImpl(256)]
		public static uint3x3 operator +(uint3x3 lhs, uint rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0002CA18 File Offset: 0x0002AC18
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x57E4040", Offset = "0x57E2C40", VA = "0x1857E4040")]
		[MethodImpl(256)]
		public static uint3x3 operator +(uint lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0002CA30 File Offset: 0x0002AC30
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x57E6CB0", Offset = "0x57E58B0", VA = "0x1857E6CB0")]
		[MethodImpl(256)]
		public static uint3x3 operator -(uint3x3 lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x0002CA48 File Offset: 0x0002AC48
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x57E6AF0", Offset = "0x57E56F0", VA = "0x1857E6AF0")]
		[MethodImpl(256)]
		public static uint3x3 operator -(uint3x3 lhs, uint rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0002CA60 File Offset: 0x0002AC60
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x57E6BD0", Offset = "0x57E57D0", VA = "0x1857E6BD0")]
		[MethodImpl(256)]
		public static uint3x3 operator -(uint lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0002CA78 File Offset: 0x0002AC78
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x5817020", Offset = "0x5815C20", VA = "0x185817020")]
		[MethodImpl(256)]
		public static uint3x3 operator /(uint3x3 lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0002CA90 File Offset: 0x0002AC90
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x5816F20", Offset = "0x5815B20", VA = "0x185816F20")]
		[MethodImpl(256)]
		public static uint3x3 operator /(uint3x3 lhs, uint rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x58171A0", Offset = "0x5815DA0", VA = "0x1858171A0")]
		[MethodImpl(256)]
		public static uint3x3 operator /(uint lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x5818070", Offset = "0x5816C70", VA = "0x185818070")]
		[MethodImpl(256)]
		public static uint3x3 operator %(uint3x3 lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x58181F0", Offset = "0x5816DF0", VA = "0x1858181F0")]
		[MethodImpl(256)]
		public static uint3x3 operator %(uint3x3 lhs, uint rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0002CAF0 File Offset: 0x0002ACF0
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x5817F70", Offset = "0x5816B70", VA = "0x185817F70")]
		[MethodImpl(256)]
		public static uint3x3 operator %(uint lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0002CB08 File Offset: 0x0002AD08
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x57E5820", Offset = "0x57E4420", VA = "0x1857E5820")]
		[MethodImpl(256)]
		public static uint3x3 operator ++(uint3x3 val)
		{
			return default(uint3x3);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x0002CB20 File Offset: 0x0002AD20
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x57E4780", Offset = "0x57E3380", VA = "0x1857E4780")]
		[MethodImpl(256)]
		public static uint3x3 operator --(uint3x3 val)
		{
			return default(uint3x3);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0002CB38 File Offset: 0x0002AD38
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x5817C80", Offset = "0x5816880", VA = "0x185817C80")]
		[MethodImpl(256)]
		public static bool3x3 operator <(uint3x3 lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x0002CB50 File Offset: 0x0002AD50
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x5817EA0", Offset = "0x5816AA0", VA = "0x185817EA0")]
		[MethodImpl(256)]
		public static bool3x3 operator <(uint3x3 lhs, uint rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x0002CB68 File Offset: 0x0002AD68
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x5817DD0", Offset = "0x58169D0", VA = "0x185817DD0")]
		[MethodImpl(256)]
		public static bool3x3 operator <(uint lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0002CB80 File Offset: 0x0002AD80
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x5817B30", Offset = "0x5816730", VA = "0x185817B30")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(uint3x3 lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0002CB98 File Offset: 0x0002AD98
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x5817990", Offset = "0x5816590", VA = "0x185817990")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(uint3x3 lhs, uint rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x5817A60", Offset = "0x5816660", VA = "0x185817A60")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(uint lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x5817770", Offset = "0x5816370", VA = "0x185817770")]
		[MethodImpl(256)]
		public static bool3x3 operator >(uint3x3 lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x58176A0", Offset = "0x58162A0", VA = "0x1858176A0")]
		[MethodImpl(256)]
		public static bool3x3 operator >(uint3x3 lhs, uint rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
		[Token(Token = "0x600212A")]
		[Address(RVA = "0x58178C0", Offset = "0x58164C0", VA = "0x1858178C0")]
		[MethodImpl(256)]
		public static bool3x3 operator >(uint lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0002CC10 File Offset: 0x0002AE10
		[Token(Token = "0x600212B")]
		[Address(RVA = "0x58173B0", Offset = "0x5815FB0", VA = "0x1858173B0")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(uint3x3 lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x0002CC28 File Offset: 0x0002AE28
		[Token(Token = "0x600212C")]
		[Address(RVA = "0x5817500", Offset = "0x5816100", VA = "0x185817500")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(uint3x3 lhs, uint rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x0002CC40 File Offset: 0x0002AE40
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x58175D0", Offset = "0x58161D0", VA = "0x1858175D0")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(uint lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x0002CC58 File Offset: 0x0002AE58
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x57E6E10", Offset = "0x57E5A10", VA = "0x1857E6E10")]
		[MethodImpl(256)]
		public static uint3x3 operator -(uint3x3 val)
		{
			return default(uint3x3);
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x0002CC70 File Offset: 0x0002AE70
		[Token(Token = "0x600212F")]
		[Address(RVA = "0x57E6EE0", Offset = "0x57E5AE0", VA = "0x1857E6EE0")]
		[MethodImpl(256)]
		public static uint3x3 operator +(uint3x3 val)
		{
			return default(uint3x3);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0002CC88 File Offset: 0x0002AE88
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x57E5BD0", Offset = "0x57E47D0", VA = "0x1857E5BD0")]
		[MethodImpl(256)]
		public static uint3x3 operator <<(uint3x3 x, int n)
		{
			return default(uint3x3);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x58182E0", Offset = "0x5816EE0", VA = "0x1858182E0")]
		[MethodImpl(256)]
		public static uint3x3 operator >>(uint3x3 x, int n)
		{
			return default(uint3x3);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x57E4D50", Offset = "0x57E3950", VA = "0x1857E4D50")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(uint3x3 lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x57E4C80", Offset = "0x57E3880", VA = "0x1857E4C80")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(uint3x3 lhs, uint rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
		[Token(Token = "0x6002134")]
		[Address(RVA = "0x57E4BB0", Offset = "0x57E37B0", VA = "0x1857E4BB0")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(uint lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x0002CD00 File Offset: 0x0002AF00
		[Token(Token = "0x6002135")]
		[Address(RVA = "0x57E5A80", Offset = "0x57E4680", VA = "0x1857E5A80")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(uint3x3 lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x0002CD18 File Offset: 0x0002AF18
		[Token(Token = "0x6002136")]
		[Address(RVA = "0x57E58E0", Offset = "0x57E44E0", VA = "0x1857E58E0")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(uint3x3 lhs, uint rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0002CD30 File Offset: 0x0002AF30
		[Token(Token = "0x6002137")]
		[Address(RVA = "0x57E59B0", Offset = "0x57E45B0", VA = "0x1857E59B0")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(uint lhs, uint3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0002CD48 File Offset: 0x0002AF48
		[Token(Token = "0x6002138")]
		[Address(RVA = "0x57E6940", Offset = "0x57E5540", VA = "0x1857E6940")]
		[MethodImpl(256)]
		public static uint3x3 operator ~(uint3x3 val)
		{
			return default(uint3x3);
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x0002CD60 File Offset: 0x0002AF60
		[Token(Token = "0x6002139")]
		[Address(RVA = "0x57E4120", Offset = "0x57E2D20", VA = "0x1857E4120")]
		[MethodImpl(256)]
		public static uint3x3 operator &(uint3x3 lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x0002CD78 File Offset: 0x0002AF78
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x57E4370", Offset = "0x57E2F70", VA = "0x1857E4370")]
		[MethodImpl(256)]
		public static uint3x3 operator &(uint3x3 lhs, uint rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0002CD90 File Offset: 0x0002AF90
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x57E4290", Offset = "0x57E2E90", VA = "0x1857E4290")]
		[MethodImpl(256)]
		public static uint3x3 operator &(uint lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x57E4530", Offset = "0x57E3130", VA = "0x1857E4530")]
		[MethodImpl(256)]
		public static uint3x3 operator |(uint3x3 lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x57E4450", Offset = "0x57E3050", VA = "0x1857E4450")]
		[MethodImpl(256)]
		public static uint3x3 operator |(uint3x3 lhs, uint rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x57E46A0", Offset = "0x57E32A0", VA = "0x1857E46A0")]
		[MethodImpl(256)]
		public static uint3x3 operator |(uint lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x57E4EA0", Offset = "0x57E3AA0", VA = "0x1857E4EA0")]
		[MethodImpl(256)]
		public static uint3x3 operator ^(uint3x3 lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0002CE08 File Offset: 0x0002B008
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x57E5010", Offset = "0x57E3C10", VA = "0x1857E5010")]
		[MethodImpl(256)]
		public static uint3x3 operator ^(uint3x3 lhs, uint rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x0002CE20 File Offset: 0x0002B020
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x57E50F0", Offset = "0x57E3CF0", VA = "0x1857E50F0")]
		[MethodImpl(256)]
		public static uint3x3 operator ^(uint lhs, uint3x3 rhs)
		{
			return default(uint3x3);
		}

		// Token: 0x17000A34 RID: 2612
		[Token(Token = "0x17000A34")]
		public uint3 this[int index]
		{
			[Token(Token = "0x6002142")]
			[Address(RVA = "0x3D281B0", Offset = "0x3D26DB0", VA = "0x183D281B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0002CE38 File Offset: 0x0002B038
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x57E3190", Offset = "0x57E1D90", VA = "0x1857E3190", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(uint3x3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0002CE50 File Offset: 0x0002B050
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x5816590", Offset = "0x5815190", VA = "0x185816590", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0002CE68 File Offset: 0x0002B068
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x58166B0", Offset = "0x58152B0", VA = "0x1858166B0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x58166E0", Offset = "0x58152E0", VA = "0x1858166E0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x5816AD0", Offset = "0x58156D0", VA = "0x185816AD0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x0")]
		public uint3 c0;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xC")]
		public uint3 c1;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x18")]
		public uint3 c2;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint3x3 identity;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x24")]
		public static readonly uint3x3 zero;
	}
}
