using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct float2x2 : IEquatable<float2x2>, IFormattable
	{
		// Token: 0x0600107C RID: 4220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x1787730", Offset = "0x1786330", VA = "0x181787730")]
		[MethodImpl(256)]
		public float2x2(float2 c0, float2 c1)
		{
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107D")]
		[Address(RVA = "0x57AAED0", Offset = "0x57A9AD0", VA = "0x1857AAED0")]
		[MethodImpl(256)]
		public float2x2(float m00, float m01, float m10, float m11)
		{
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x57AAE90", Offset = "0x57A9A90", VA = "0x1857AAE90")]
		[MethodImpl(256)]
		public float2x2(float v)
		{
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x57AAD50", Offset = "0x57A9950", VA = "0x1857AAD50")]
		[MethodImpl(256)]
		public float2x2(bool v)
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x57AAE30", Offset = "0x57A9A30", VA = "0x1857AAE30")]
		[MethodImpl(256)]
		public float2x2(bool2x2 v)
		{
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x57AAEB0", Offset = "0x57A9AB0", VA = "0x1857AAEB0")]
		[MethodImpl(256)]
		public float2x2(int v)
		{
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x57AAF30", Offset = "0x57A9B30", VA = "0x1857AAF30")]
		[MethodImpl(256)]
		public float2x2(int2x2 v)
		{
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x57AAF70", Offset = "0x57A9B70", VA = "0x1857AAF70")]
		[MethodImpl(256)]
		public float2x2(uint v)
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x57AADB0", Offset = "0x57A99B0", VA = "0x1857AADB0")]
		[MethodImpl(256)]
		public float2x2(uint2x2 v)
		{
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x57AAE10", Offset = "0x57A9A10", VA = "0x1857AAE10")]
		[MethodImpl(256)]
		public float2x2(double v)
		{
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x57AAEF0", Offset = "0x57A9AF0", VA = "0x1857AAEF0")]
		[MethodImpl(256)]
		public float2x2(double2x2 v)
		{
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00018318 File Offset: 0x00016518
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x5716010", Offset = "0x5714C10", VA = "0x185716010")]
		[MethodImpl(256)]
		public static implicit operator float2x2(float v)
		{
			return default(float2x2);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00018330 File Offset: 0x00016530
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x5716210", Offset = "0x5714E10", VA = "0x185716210")]
		[MethodImpl(256)]
		public static explicit operator float2x2(bool v)
		{
			return default(float2x2);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00018348 File Offset: 0x00016548
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x5716270", Offset = "0x5714E70", VA = "0x185716270")]
		[MethodImpl(256)]
		public static explicit operator float2x2(bool2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00018360 File Offset: 0x00016560
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x57160E0", Offset = "0x5714CE0", VA = "0x1857160E0")]
		[MethodImpl(256)]
		public static implicit operator float2x2(int v)
		{
			return default(float2x2);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00018378 File Offset: 0x00016578
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x57161A0", Offset = "0x5714DA0", VA = "0x1857161A0")]
		[MethodImpl(256)]
		public static implicit operator float2x2(int2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00018390 File Offset: 0x00016590
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x5716160", Offset = "0x5714D60", VA = "0x185716160")]
		[MethodImpl(256)]
		public static implicit operator float2x2(uint v)
		{
			return default(float2x2);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x000183A8 File Offset: 0x000165A8
		[Token(Token = "0x600108D")]
		[Address(RVA = "0x5716060", Offset = "0x5714C60", VA = "0x185716060")]
		[MethodImpl(256)]
		public static implicit operator float2x2(uint2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000183C0 File Offset: 0x000165C0
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x5716180", Offset = "0x5714D80", VA = "0x185716180")]
		[MethodImpl(256)]
		public static explicit operator float2x2(double v)
		{
			return default(float2x2);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000183D8 File Offset: 0x000165D8
		[Token(Token = "0x600108F")]
		[Address(RVA = "0x5716100", Offset = "0x5714D00", VA = "0x185716100")]
		[MethodImpl(256)]
		public static explicit operator float2x2(double2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x000183F0 File Offset: 0x000165F0
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x57ABC60", Offset = "0x57AA860", VA = "0x1857ABC60")]
		[MethodImpl(256)]
		public static float2x2 operator *(float2x2 lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00018408 File Offset: 0x00016608
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x57ABD10", Offset = "0x57AA910", VA = "0x1857ABD10")]
		[MethodImpl(256)]
		public static float2x2 operator *(float2x2 lhs, float rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00018420 File Offset: 0x00016620
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x57ABCC0", Offset = "0x57AA8C0", VA = "0x1857ABCC0")]
		[MethodImpl(256)]
		public static float2x2 operator *(float lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00018438 File Offset: 0x00016638
		[Token(Token = "0x6001093")]
		[Address(RVA = "0x57AAFA0", Offset = "0x57A9BA0", VA = "0x1857AAFA0")]
		[MethodImpl(256)]
		public static float2x2 operator +(float2x2 lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00018450 File Offset: 0x00016650
		[Token(Token = "0x6001094")]
		[Address(RVA = "0x57AB050", Offset = "0x57A9C50", VA = "0x1857AB050")]
		[MethodImpl(256)]
		public static float2x2 operator +(float2x2 lhs, float rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00018468 File Offset: 0x00016668
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x57AB000", Offset = "0x57A9C00", VA = "0x1857AB000")]
		[MethodImpl(256)]
		public static float2x2 operator +(float lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00018480 File Offset: 0x00016680
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x57ABE00", Offset = "0x57AAA00", VA = "0x1857ABE00")]
		[MethodImpl(256)]
		public static float2x2 operator -(float2x2 lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00018498 File Offset: 0x00016698
		[Token(Token = "0x6001097")]
		[Address(RVA = "0x57ABDB0", Offset = "0x57AA9B0", VA = "0x1857ABDB0")]
		[MethodImpl(256)]
		public static float2x2 operator -(float2x2 lhs, float rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x000184B0 File Offset: 0x000166B0
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x57ABD60", Offset = "0x57AA960", VA = "0x1857ABD60")]
		[MethodImpl(256)]
		public static float2x2 operator -(float lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x000184C8 File Offset: 0x000166C8
		[Token(Token = "0x6001099")]
		[Address(RVA = "0x57AB100", Offset = "0x57A9D00", VA = "0x1857AB100")]
		[MethodImpl(256)]
		public static float2x2 operator /(float2x2 lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x000184E0 File Offset: 0x000166E0
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x57AB1B0", Offset = "0x57A9DB0", VA = "0x1857AB1B0")]
		[MethodImpl(256)]
		public static float2x2 operator /(float2x2 lhs, float rhs)
		{
			return default(float2x2);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x000184F8 File Offset: 0x000166F8
		[Token(Token = "0x600109B")]
		[Address(RVA = "0x57AB160", Offset = "0x57A9D60", VA = "0x1857AB160")]
		[MethodImpl(256)]
		public static float2x2 operator /(float lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00018510 File Offset: 0x00016710
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x57ABBA0", Offset = "0x57AA7A0", VA = "0x1857ABBA0")]
		[MethodImpl(256)]
		public static float2x2 operator %(float2x2 lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00018528 File Offset: 0x00016728
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x57ABA40", Offset = "0x57AA640", VA = "0x1857ABA40")]
		[MethodImpl(256)]
		public static float2x2 operator %(float2x2 lhs, float rhs)
		{
			return default(float2x2);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00018540 File Offset: 0x00016740
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x57ABAF0", Offset = "0x57AA6F0", VA = "0x1857ABAF0")]
		[MethodImpl(256)]
		public static float2x2 operator %(float lhs, float2x2 rhs)
		{
			return default(float2x2);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00018558 File Offset: 0x00016758
		[Token(Token = "0x600109F")]
		[Address(RVA = "0x57AB5F0", Offset = "0x57AA1F0", VA = "0x1857AB5F0")]
		[MethodImpl(256)]
		public static float2x2 operator ++(float2x2 val)
		{
			return default(float2x2);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00018570 File Offset: 0x00016770
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x57AB0A0", Offset = "0x57A9CA0", VA = "0x1857AB0A0")]
		[MethodImpl(256)]
		public static float2x2 operator --(float2x2 val)
		{
			return default(float2x2);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00018588 File Offset: 0x00016788
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x57AB980", Offset = "0x57AA580", VA = "0x1857AB980")]
		[MethodImpl(256)]
		public static bool2x2 operator <(float2x2 lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x000185A0 File Offset: 0x000167A0
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x57AB9F0", Offset = "0x57AA5F0", VA = "0x1857AB9F0")]
		[MethodImpl(256)]
		public static bool2x2 operator <(float2x2 lhs, float rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x000185B8 File Offset: 0x000167B8
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x57AB920", Offset = "0x57AA520", VA = "0x1857AB920")]
		[MethodImpl(256)]
		public static bool2x2 operator <(float lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000185D0 File Offset: 0x000167D0
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x57AB860", Offset = "0x57AA460", VA = "0x1857AB860")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(float2x2 lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x000185E8 File Offset: 0x000167E8
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x57AB8D0", Offset = "0x57AA4D0", VA = "0x1857AB8D0")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(float2x2 lhs, float rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00018600 File Offset: 0x00016800
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x57AB800", Offset = "0x57AA400", VA = "0x1857AB800")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(float lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00018618 File Offset: 0x00016818
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x57AB520", Offset = "0x57AA120", VA = "0x1857AB520")]
		[MethodImpl(256)]
		public static bool2x2 operator >(float2x2 lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00018630 File Offset: 0x00016830
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x57AB590", Offset = "0x57AA190", VA = "0x1857AB590")]
		[MethodImpl(256)]
		public static bool2x2 operator >(float2x2 lhs, float rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00018648 File Offset: 0x00016848
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x57AB4D0", Offset = "0x57AA0D0", VA = "0x1857AB4D0")]
		[MethodImpl(256)]
		public static bool2x2 operator >(float lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00018660 File Offset: 0x00016860
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x57AB410", Offset = "0x57AA010", VA = "0x1857AB410")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(float2x2 lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00018678 File Offset: 0x00016878
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x57AB3B0", Offset = "0x57A9FB0", VA = "0x1857AB3B0")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(float2x2 lhs, float rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00018690 File Offset: 0x00016890
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x57AB480", Offset = "0x57AA080", VA = "0x1857AB480")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(float lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000186A8 File Offset: 0x000168A8
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x57ABE60", Offset = "0x57AAA60", VA = "0x1857ABE60")]
		[MethodImpl(256)]
		public static float2x2 operator -(float2x2 val)
		{
			return default(float2x2);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000186C0 File Offset: 0x000168C0
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x57ABEB0", Offset = "0x57AAAB0", VA = "0x1857ABEB0")]
		[MethodImpl(256)]
		public static float2x2 operator +(float2x2 val)
		{
			return default(float2x2);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x000186D8 File Offset: 0x000168D8
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x57AB200", Offset = "0x57A9E00", VA = "0x1857AB200")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(float2x2 lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x000186F0 File Offset: 0x000168F0
		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x57AB2A0", Offset = "0x57A9EA0", VA = "0x1857AB2A0")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(float2x2 lhs, float rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00018708 File Offset: 0x00016908
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x57AB330", Offset = "0x57A9F30", VA = "0x1857AB330")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(float lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00018720 File Offset: 0x00016920
		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x57AB650", Offset = "0x57AA250", VA = "0x1857AB650")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(float2x2 lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00018738 File Offset: 0x00016938
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x57AB770", Offset = "0x57AA370", VA = "0x1857AB770")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(float2x2 lhs, float rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00018750 File Offset: 0x00016950
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x57AB6F0", Offset = "0x57AA2F0", VA = "0x1857AB6F0")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(float lhs, float2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x170003F8 RID: 1016
		[Token(Token = "0x170003F8")]
		public float2 this[int index]
		{
			[Token(Token = "0x60010B5")]
			[Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00018768 File Offset: 0x00016968
		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x57AA640", Offset = "0x57A9240", VA = "0x1857AA640", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float2x2 rhs)
		{
			return default(bool);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00018780 File Offset: 0x00016980
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x57AA690", Offset = "0x57A9290", VA = "0x1857AA690", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00018798 File Offset: 0x00016998
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x57AA750", Offset = "0x57A9350", VA = "0x1857AA750", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x57AAB00", Offset = "0x57A9700", VA = "0x1857AAB00", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x57AA8F0", Offset = "0x57A94F0", VA = "0x1857AA8F0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x000187B0 File Offset: 0x000169B0
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x57AA770", Offset = "0x57A9370", VA = "0x1857AA770")]
		[MethodImpl(256)]
		public static float2x2 Rotate(float angle)
		{
			return default(float2x2);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x000187C8 File Offset: 0x000169C8
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x57AA880", Offset = "0x57A9480", VA = "0x1857AA880")]
		[MethodImpl(256)]
		public static float2x2 Scale(float s)
		{
			return default(float2x2);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x000187E0 File Offset: 0x000169E0
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x57AA850", Offset = "0x57A9450", VA = "0x1857AA850")]
		[MethodImpl(256)]
		public static float2x2 Scale(float x, float y)
		{
			return default(float2x2);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000187F8 File Offset: 0x000169F8
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x57AA8B0", Offset = "0x57A94B0", VA = "0x1857AA8B0")]
		[MethodImpl(256)]
		public static float2x2 Scale(float2 v)
		{
			return default(float2x2);
		}

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x0")]
		public float2 c0;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x8")]
		public float2 c1;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float2x2 identity;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly float2x2 zero;
	}
}
