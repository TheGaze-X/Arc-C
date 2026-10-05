using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct float3x2 : IEquatable<float3x2>, IFormattable
	{
		// Token: 0x06001208 RID: 4616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x3746830", Offset = "0x3745430", VA = "0x183746830")]
		[MethodImpl(256)]
		public float3x2(float3 c0, float3 c1)
		{
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x57B2240", Offset = "0x57B0E40", VA = "0x1857B2240")]
		[MethodImpl(256)]
		public float3x2(float m00, float m01, float m10, float m11, float m20, float m21)
		{
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120A")]
		[Address(RVA = "0x57B2190", Offset = "0x57B0D90", VA = "0x1857B2190")]
		[MethodImpl(256)]
		public float3x2(float v)
		{
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x56FD390", Offset = "0x56FBF90", VA = "0x1856FD390")]
		[MethodImpl(256)]
		public float3x2(bool v)
		{
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120C")]
		[Address(RVA = "0x56FD420", Offset = "0x56FC020", VA = "0x1856FD420")]
		[MethodImpl(256)]
		public float3x2(bool3x2 v)
		{
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120D")]
		[Address(RVA = "0x57B2150", Offset = "0x57B0D50", VA = "0x1857B2150")]
		[MethodImpl(256)]
		public float3x2(int v)
		{
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120E")]
		[Address(RVA = "0x57B2410", Offset = "0x57B1010", VA = "0x1857B2410")]
		[MethodImpl(256)]
		public float3x2(int3x2 v)
		{
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120F")]
		[Address(RVA = "0x57B2290", Offset = "0x57B0E90", VA = "0x1857B2290")]
		[MethodImpl(256)]
		public float3x2(uint v)
		{
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x57B2320", Offset = "0x57B0F20", VA = "0x1857B2320")]
		[MethodImpl(256)]
		public float3x2(uint3x2 v)
		{
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x57B22E0", Offset = "0x57B0EE0", VA = "0x1857B22E0")]
		[MethodImpl(256)]
		public float3x2(double v)
		{
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001212")]
		[Address(RVA = "0x57B21D0", Offset = "0x57B0DD0", VA = "0x1857B21D0")]
		[MethodImpl(256)]
		public float3x2(double3x2 v)
		{
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0001A148 File Offset: 0x00018348
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x57175D0", Offset = "0x57161D0", VA = "0x1857175D0")]
		[MethodImpl(256)]
		public static implicit operator float3x2(float v)
		{
			return default(float3x2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0001A160 File Offset: 0x00018360
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x57B2BB0", Offset = "0x57B17B0", VA = "0x1857B2BB0")]
		[MethodImpl(256)]
		public static explicit operator float3x2(bool v)
		{
			return default(float3x2);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0001A178 File Offset: 0x00018378
		[Token(Token = "0x6001215")]
		[Address(RVA = "0x5717510", Offset = "0x5716110", VA = "0x185717510")]
		[MethodImpl(256)]
		public static explicit operator float3x2(bool3x2 v)
		{
			return default(float3x2);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0001A190 File Offset: 0x00018390
		[Token(Token = "0x6001216")]
		[Address(RVA = "0x57172F0", Offset = "0x5715EF0", VA = "0x1857172F0")]
		[MethodImpl(256)]
		public static implicit operator float3x2(int v)
		{
			return default(float3x2);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0001A1A8 File Offset: 0x000183A8
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x5717390", Offset = "0x5715F90", VA = "0x185717390")]
		[MethodImpl(256)]
		public static implicit operator float3x2(int3x2 v)
		{
			return default(float3x2);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0001A1C0 File Offset: 0x000183C0
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x57174C0", Offset = "0x57160C0", VA = "0x1857174C0")]
		[MethodImpl(256)]
		public static implicit operator float3x2(uint v)
		{
			return default(float3x2);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0001A1D8 File Offset: 0x000183D8
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x5717180", Offset = "0x5715D80", VA = "0x185717180")]
		[MethodImpl(256)]
		public static implicit operator float3x2(uint3x2 v)
		{
			return default(float3x2);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0001A1F0 File Offset: 0x000183F0
		[Token(Token = "0x600121A")]
		[Address(RVA = "0x5717340", Offset = "0x5715F40", VA = "0x185717340")]
		[MethodImpl(256)]
		public static explicit operator float3x2(double v)
		{
			return default(float3x2);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0001A208 File Offset: 0x00018408
		[Token(Token = "0x600121B")]
		[Address(RVA = "0x5717100", Offset = "0x5715D00", VA = "0x185717100")]
		[MethodImpl(256)]
		public static explicit operator float3x2(double3x2 v)
		{
			return default(float3x2);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0001A220 File Offset: 0x00018420
		[Token(Token = "0x600121C")]
		[Address(RVA = "0x57B39C0", Offset = "0x57B25C0", VA = "0x1857B39C0")]
		[MethodImpl(256)]
		public static float3x2 operator *(float3x2 lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0001A238 File Offset: 0x00018438
		[Token(Token = "0x600121D")]
		[Address(RVA = "0x57B3B10", Offset = "0x57B2710", VA = "0x1857B3B10")]
		[MethodImpl(256)]
		public static float3x2 operator *(float3x2 lhs, float rhs)
		{
			return default(float3x2);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0001A250 File Offset: 0x00018450
		[Token(Token = "0x600121E")]
		[Address(RVA = "0x57B3A80", Offset = "0x57B2680", VA = "0x1857B3A80")]
		[MethodImpl(256)]
		public static float3x2 operator *(float lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0001A268 File Offset: 0x00018468
		[Token(Token = "0x600121F")]
		[Address(RVA = "0x57B2550", Offset = "0x57B1150", VA = "0x1857B2550")]
		[MethodImpl(256)]
		public static float3x2 operator +(float3x2 lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0001A280 File Offset: 0x00018480
		[Token(Token = "0x6001220")]
		[Address(RVA = "0x57B2610", Offset = "0x57B1210", VA = "0x1857B2610")]
		[MethodImpl(256)]
		public static float3x2 operator +(float3x2 lhs, float rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0001A298 File Offset: 0x00018498
		[Token(Token = "0x6001221")]
		[Address(RVA = "0x57B24C0", Offset = "0x57B10C0", VA = "0x1857B24C0")]
		[MethodImpl(256)]
		public static float3x2 operator +(float lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0001A2B0 File Offset: 0x000184B0
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x57B3BA0", Offset = "0x57B27A0", VA = "0x1857B3BA0")]
		[MethodImpl(256)]
		public static float3x2 operator -(float3x2 lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0001A2C8 File Offset: 0x000184C8
		[Token(Token = "0x6001223")]
		[Address(RVA = "0x57B3C50", Offset = "0x57B2850", VA = "0x1857B3C50")]
		[MethodImpl(256)]
		public static float3x2 operator -(float3x2 lhs, float rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0001A2E0 File Offset: 0x000184E0
		[Token(Token = "0x6001224")]
		[Address(RVA = "0x57B3CE0", Offset = "0x57B28E0", VA = "0x1857B3CE0")]
		[MethodImpl(256)]
		public static float3x2 operator -(float lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0001A2F8 File Offset: 0x000184F8
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x57B27D0", Offset = "0x57B13D0", VA = "0x1857B27D0")]
		[MethodImpl(256)]
		public static float3x2 operator /(float3x2 lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0001A310 File Offset: 0x00018510
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x57B2740", Offset = "0x57B1340", VA = "0x1857B2740")]
		[MethodImpl(256)]
		public static float3x2 operator /(float3x2 lhs, float rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0001A328 File Offset: 0x00018528
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x57B2880", Offset = "0x57B1480", VA = "0x1857B2880")]
		[MethodImpl(256)]
		public static float3x2 operator /(float lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0001A340 File Offset: 0x00018540
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x57B3670", Offset = "0x57B2270", VA = "0x1857B3670")]
		[MethodImpl(256)]
		public static float3x2 operator %(float3x2 lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0001A358 File Offset: 0x00018558
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x57B38B0", Offset = "0x57B24B0", VA = "0x1857B38B0")]
		[MethodImpl(256)]
		public static float3x2 operator %(float3x2 lhs, float rhs)
		{
			return default(float3x2);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0001A370 File Offset: 0x00018570
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x57B37A0", Offset = "0x57B23A0", VA = "0x1857B37A0")]
		[MethodImpl(256)]
		public static float3x2 operator %(float lhs, float3x2 rhs)
		{
			return default(float3x2);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0001A388 File Offset: 0x00018588
		[Token(Token = "0x600122B")]
		[Address(RVA = "0x57B2FA0", Offset = "0x57B1BA0", VA = "0x1857B2FA0")]
		[MethodImpl(256)]
		public static float3x2 operator ++(float3x2 val)
		{
			return default(float3x2);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0001A3A0 File Offset: 0x000185A0
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x57B26A0", Offset = "0x57B12A0", VA = "0x1857B26A0")]
		[MethodImpl(256)]
		public static float3x2 operator --(float3x2 val)
		{
			return default(float3x2);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0001A3B8 File Offset: 0x000185B8
		[Token(Token = "0x600122D")]
		[Address(RVA = "0x57B3530", Offset = "0x57B2130", VA = "0x1857B3530")]
		[MethodImpl(256)]
		public static bool3x2 operator <(float3x2 lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0001A3D0 File Offset: 0x000185D0
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x57B35F0", Offset = "0x57B21F0", VA = "0x1857B35F0")]
		[MethodImpl(256)]
		public static bool3x2 operator <(float3x2 lhs, float rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0001A3E8 File Offset: 0x000185E8
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x57B34A0", Offset = "0x57B20A0", VA = "0x1857B34A0")]
		[MethodImpl(256)]
		public static bool3x2 operator <(float lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0001A400 File Offset: 0x00018600
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x57B33E0", Offset = "0x57B1FE0", VA = "0x1857B33E0")]
		[MethodImpl(256)]
		public static bool3x2 operator <=(float3x2 lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0001A418 File Offset: 0x00018618
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x57B3360", Offset = "0x57B1F60", VA = "0x1857B3360")]
		[MethodImpl(256)]
		public static bool3x2 operator <=(float3x2 lhs, float rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0001A430 File Offset: 0x00018630
		[Token(Token = "0x6001232")]
		[Address(RVA = "0x57B32D0", Offset = "0x57B1ED0", VA = "0x1857B32D0")]
		[MethodImpl(256)]
		public static bool3x2 operator <=(float lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0001A448 File Offset: 0x00018648
		[Token(Token = "0x6001233")]
		[Address(RVA = "0x57B2E50", Offset = "0x57B1A50", VA = "0x1857B2E50")]
		[MethodImpl(256)]
		public static bool3x2 operator >(float3x2 lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0001A460 File Offset: 0x00018660
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x57B2DC0", Offset = "0x57B19C0", VA = "0x1857B2DC0")]
		[MethodImpl(256)]
		public static bool3x2 operator >(float3x2 lhs, float rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0001A478 File Offset: 0x00018678
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x57B2F10", Offset = "0x57B1B10", VA = "0x1857B2F10")]
		[MethodImpl(256)]
		public static bool3x2 operator >(float lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0001A490 File Offset: 0x00018690
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x57B2D00", Offset = "0x57B1900", VA = "0x1857B2D00")]
		[MethodImpl(256)]
		public static bool3x2 operator >=(float3x2 lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0001A4A8 File Offset: 0x000186A8
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x57B2BE0", Offset = "0x57B17E0", VA = "0x1857B2BE0")]
		[MethodImpl(256)]
		public static bool3x2 operator >=(float3x2 lhs, float rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0001A4C0 File Offset: 0x000186C0
		[Token(Token = "0x6001238")]
		[Address(RVA = "0x57B2C70", Offset = "0x57B1870", VA = "0x1857B2C70")]
		[MethodImpl(256)]
		public static bool3x2 operator >=(float lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0001A4D8 File Offset: 0x000186D8
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x57B3D80", Offset = "0x57B2980", VA = "0x1857B3D80")]
		[MethodImpl(256)]
		public static float3x2 operator -(float3x2 val)
		{
			return default(float3x2);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0001A4F0 File Offset: 0x000186F0
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x57B3E10", Offset = "0x57B2A10", VA = "0x1857B3E10")]
		[MethodImpl(256)]
		public static float3x2 operator +(float3x2 val)
		{
			return default(float3x2);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0001A508 File Offset: 0x00018708
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x57B2AB0", Offset = "0x57B16B0", VA = "0x1857B2AB0")]
		[MethodImpl(256)]
		public static bool3x2 operator ==(float3x2 lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0001A520 File Offset: 0x00018720
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x57B2920", Offset = "0x57B1520", VA = "0x1857B2920")]
		[MethodImpl(256)]
		public static bool3x2 operator ==(float3x2 lhs, float rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0001A538 File Offset: 0x00018738
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x57B29F0", Offset = "0x57B15F0", VA = "0x1857B29F0")]
		[MethodImpl(256)]
		public static bool3x2 operator ==(float lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0001A550 File Offset: 0x00018750
		[Token(Token = "0x600123E")]
		[Address(RVA = "0x57B31D0", Offset = "0x57B1DD0", VA = "0x1857B31D0")]
		[MethodImpl(256)]
		public static bool3x2 operator !=(float3x2 lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0001A568 File Offset: 0x00018768
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x57B3040", Offset = "0x57B1C40", VA = "0x1857B3040")]
		[MethodImpl(256)]
		public static bool3x2 operator !=(float3x2 lhs, float rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0001A580 File Offset: 0x00018780
		[Token(Token = "0x6001240")]
		[Address(RVA = "0x57B3110", Offset = "0x57B1D10", VA = "0x1857B3110")]
		[MethodImpl(256)]
		public static bool3x2 operator !=(float lhs, float3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x17000471 RID: 1137
		[Token(Token = "0x17000471")]
		public float3 this[int index]
		{
			[Token(Token = "0x6001241")]
			[Address(RVA = "0x3D281B0", Offset = "0x3D26DB0", VA = "0x183D281B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0001A598 File Offset: 0x00018798
		[Token(Token = "0x6001242")]
		[Address(RVA = "0x577BBB0", Offset = "0x577A7B0", VA = "0x18577BBB0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float3x2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0001A5B0 File Offset: 0x000187B0
		[Token(Token = "0x6001243")]
		[Address(RVA = "0x57B1A70", Offset = "0x57B0670", VA = "0x1857B1A70", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0001A5C8 File Offset: 0x000187C8
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x57B1B70", Offset = "0x57B0770", VA = "0x1857B1B70", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x57B1E70", Offset = "0x57B0A70", VA = "0x1857B1E70", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x57B1BA0", Offset = "0x57B07A0", VA = "0x1857B1BA0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		public float3 c0;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0xC")]
		public float3 c1;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float3x2 zero;
	}
}
