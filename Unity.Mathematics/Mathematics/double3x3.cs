using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct double3x3 : IEquatable<double3x3>, IFormattable
	{
		// Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x578E020", Offset = "0x578CC20", VA = "0x18578E020")]
		[MethodImpl(256)]
		public double3x3(double3 c0, double3 c1, double3 c2)
		{
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x578E440", Offset = "0x578D040", VA = "0x18578E440")]
		[MethodImpl(256)]
		public double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x578E060", Offset = "0x578CC60", VA = "0x18578E060")]
		[MethodImpl(256)]
		public double3x3(double v)
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x578E3C0", Offset = "0x578CFC0", VA = "0x18578E3C0")]
		[MethodImpl(256)]
		public double3x3(bool v)
		{
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x56FB8D0", Offset = "0x56FA4D0", VA = "0x1856FB8D0")]
		[MethodImpl(256)]
		public double3x3(bool3x3 v)
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x578E2A0", Offset = "0x578CEA0", VA = "0x18578E2A0")]
		[MethodImpl(256)]
		public double3x3(int v)
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x578E2E0", Offset = "0x578CEE0", VA = "0x18578E2E0")]
		[MethodImpl(256)]
		public double3x3(int3x3 v)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x578E0A0", Offset = "0x578CCA0", VA = "0x18578E0A0")]
		[MethodImpl(256)]
		public double3x3(uint v)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x578E1B0", Offset = "0x578CDB0", VA = "0x18578E1B0")]
		[MethodImpl(256)]
		public double3x3(uint3x3 v)
		{
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x578DFA0", Offset = "0x578CBA0", VA = "0x18578DFA0")]
		[MethodImpl(256)]
		public double3x3(float v)
		{
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x578E0F0", Offset = "0x578CCF0", VA = "0x18578E0F0")]
		[MethodImpl(256)]
		public double3x3(float3x3 v)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00014010 File Offset: 0x00012210
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x570FE90", Offset = "0x570EA90", VA = "0x18570FE90")]
		[MethodImpl(256)]
		public static implicit operator double3x3(double v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00014028 File Offset: 0x00012228
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x570FCC0", Offset = "0x570E8C0", VA = "0x18570FCC0")]
		[MethodImpl(256)]
		public static explicit operator double3x3(bool v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00014040 File Offset: 0x00012240
		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x578EE00", Offset = "0x578DA00", VA = "0x18578EE00")]
		[MethodImpl(256)]
		public static explicit operator double3x3(bool3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00014058 File Offset: 0x00012258
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x570FC70", Offset = "0x570E870", VA = "0x18570FC70")]
		[MethodImpl(256)]
		public static implicit operator double3x3(int v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00014070 File Offset: 0x00012270
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x570FB80", Offset = "0x570E780", VA = "0x18570FB80")]
		[MethodImpl(256)]
		public static implicit operator double3x3(int3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00014088 File Offset: 0x00012288
		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x570FB30", Offset = "0x570E730", VA = "0x18570FB30")]
		[MethodImpl(256)]
		public static implicit operator double3x3(uint v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000140A0 File Offset: 0x000122A0
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x570FD90", Offset = "0x570E990", VA = "0x18570FD90")]
		[MethodImpl(256)]
		public static implicit operator double3x3(uint3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000140B8 File Offset: 0x000122B8
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x570F8C0", Offset = "0x570E4C0", VA = "0x18570F8C0")]
		[MethodImpl(256)]
		public static implicit operator double3x3(float v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000140D0 File Offset: 0x000122D0
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x570FA20", Offset = "0x570E620", VA = "0x18570FA20")]
		[MethodImpl(256)]
		public static implicit operator double3x3(float3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000140E8 File Offset: 0x000122E8
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x57900E0", Offset = "0x578ECE0", VA = "0x1857900E0")]
		[MethodImpl(256)]
		public static double3x3 operator *(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00014100 File Offset: 0x00012300
		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x57901D0", Offset = "0x578EDD0", VA = "0x1857901D0")]
		[MethodImpl(256)]
		public static double3x3 operator *(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00014118 File Offset: 0x00012318
		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x5790010", Offset = "0x578EC10", VA = "0x185790010")]
		[MethodImpl(256)]
		public static double3x3 operator *(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00014130 File Offset: 0x00012330
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x578E4A0", Offset = "0x578D0A0", VA = "0x18578E4A0")]
		[MethodImpl(256)]
		public static double3x3 operator +(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00014148 File Offset: 0x00012348
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x578E660", Offset = "0x578D260", VA = "0x18578E660")]
		[MethodImpl(256)]
		public static double3x3 operator +(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00014160 File Offset: 0x00012360
		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x578E590", Offset = "0x578D190", VA = "0x18578E590")]
		[MethodImpl(256)]
		public static double3x3 operator +(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00014178 File Offset: 0x00012378
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x5790380", Offset = "0x578EF80", VA = "0x185790380")]
		[MethodImpl(256)]
		public static double3x3 operator -(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00014190 File Offset: 0x00012390
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x5790470", Offset = "0x578F070", VA = "0x185790470")]
		[MethodImpl(256)]
		public static double3x3 operator -(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000141A8 File Offset: 0x000123A8
		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x57902A0", Offset = "0x578EEA0", VA = "0x1857902A0")]
		[MethodImpl(256)]
		public static double3x3 operator -(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000141C0 File Offset: 0x000123C0
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x578E800", Offset = "0x578D400", VA = "0x18578E800")]
		[MethodImpl(256)]
		public static double3x3 operator /(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000141D8 File Offset: 0x000123D8
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x578E8F0", Offset = "0x578D4F0", VA = "0x18578E8F0")]
		[MethodImpl(256)]
		public static double3x3 operator /(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000141F0 File Offset: 0x000123F0
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x578E9C0", Offset = "0x578D5C0", VA = "0x18578E9C0")]
		[MethodImpl(256)]
		public static double3x3 operator /(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00014208 File Offset: 0x00012408
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x578FCE0", Offset = "0x578E8E0", VA = "0x18578FCE0")]
		[MethodImpl(256)]
		public static double3x3 operator %(double3x3 lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00014220 File Offset: 0x00012420
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x578FB60", Offset = "0x578E760", VA = "0x18578FB60")]
		[MethodImpl(256)]
		public static double3x3 operator %(double3x3 lhs, double rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00014238 File Offset: 0x00012438
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x578FE90", Offset = "0x578EA90", VA = "0x18578FE90")]
		[MethodImpl(256)]
		public static double3x3 operator %(double lhs, double3x3 rhs)
		{
			return default(double3x3);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00014250 File Offset: 0x00012450
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x578F2B0", Offset = "0x578DEB0", VA = "0x18578F2B0")]
		[MethodImpl(256)]
		public static double3x3 operator ++(double3x3 val)
		{
			return default(double3x3);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00014268 File Offset: 0x00012468
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x578E730", Offset = "0x578D330", VA = "0x18578E730")]
		[MethodImpl(256)]
		public static double3x3 operator --(double3x3 val)
		{
			return default(double3x3);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00014280 File Offset: 0x00012480
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x578F9D0", Offset = "0x578E5D0", VA = "0x18578F9D0")]
		[MethodImpl(256)]
		public static bool3x3 operator <(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00014298 File Offset: 0x00012498
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x578F920", Offset = "0x578E520", VA = "0x18578F920")]
		[MethodImpl(256)]
		public static bool3x3 operator <(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000142B0 File Offset: 0x000124B0
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x578FAA0", Offset = "0x578E6A0", VA = "0x18578FAA0")]
		[MethodImpl(256)]
		public static bool3x3 operator <(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x578F7A0", Offset = "0x578E3A0", VA = "0x18578F7A0")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000142E0 File Offset: 0x000124E0
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x578F870", Offset = "0x578E470", VA = "0x18578F870")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000142F8 File Offset: 0x000124F8
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x578F6E0", Offset = "0x578E2E0", VA = "0x18578F6E0")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00014310 File Offset: 0x00012510
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x578F1E0", Offset = "0x578DDE0", VA = "0x18578F1E0")]
		[MethodImpl(256)]
		public static bool3x3 operator >(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00014328 File Offset: 0x00012528
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x578F080", Offset = "0x578DC80", VA = "0x18578F080")]
		[MethodImpl(256)]
		public static bool3x3 operator >(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00014340 File Offset: 0x00012540
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x578F130", Offset = "0x578DD30", VA = "0x18578F130")]
		[MethodImpl(256)]
		public static bool3x3 operator >(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00014358 File Offset: 0x00012558
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x578EF00", Offset = "0x578DB00", VA = "0x18578EF00")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00014370 File Offset: 0x00012570
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x578EFD0", Offset = "0x578DBD0", VA = "0x18578EFD0")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00014388 File Offset: 0x00012588
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x578EE50", Offset = "0x578DA50", VA = "0x18578EE50")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000143A0 File Offset: 0x000125A0
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x5790540", Offset = "0x578F140", VA = "0x185790540")]
		[MethodImpl(256)]
		public static double3x3 operator -(double3x3 val)
		{
			return default(double3x3);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x000143B8 File Offset: 0x000125B8
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x5790610", Offset = "0x578F210", VA = "0x185790610")]
		[MethodImpl(256)]
		public static double3x3 operator +(double3x3 val)
		{
			return default(double3x3);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000143D0 File Offset: 0x000125D0
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x578EBC0", Offset = "0x578D7C0", VA = "0x18578EBC0")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000143E8 File Offset: 0x000125E8
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x578EAA0", Offset = "0x578D6A0", VA = "0x18578EAA0")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00014400 File Offset: 0x00012600
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x578ED00", Offset = "0x578D900", VA = "0x18578ED00")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00014418 File Offset: 0x00012618
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x578F380", Offset = "0x578DF80", VA = "0x18578F380")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(double3x3 lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00014430 File Offset: 0x00012630
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x578F4C0", Offset = "0x578E0C0", VA = "0x18578F4C0")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(double3x3 lhs, double rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00014448 File Offset: 0x00012648
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x578F5E0", Offset = "0x578E1E0", VA = "0x18578F5E0")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(double lhs, double3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x17000285 RID: 645
		[Token(Token = "0x17000285")]
		public double3 this[int index]
		{
			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x3D28170", Offset = "0x3D26D70", VA = "0x183D28170")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00014460 File Offset: 0x00012660
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x577EE50", Offset = "0x577DA50", VA = "0x18577EE50", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(double3x3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00014478 File Offset: 0x00012678
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x578D630", Offset = "0x578C230", VA = "0x18578D630", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00014490 File Offset: 0x00012690
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x578D6F0", Offset = "0x578C2F0", VA = "0x18578D6F0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x578D740", Offset = "0x578C340", VA = "0x18578D740", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x578DB60", Offset = "0x578C760", VA = "0x18578DB60", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		public double3 c0;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x18")]
		public double3 c1;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x30")]
		public double3 c2;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double3x3 identity;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x48")]
		public static readonly double3x3 zero;
	}
}
