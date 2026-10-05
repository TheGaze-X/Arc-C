using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct double4x4 : IEquatable<double4x4>, IFormattable
	{
		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x57A2260", Offset = "0x57A0E60", VA = "0x1857A2260")]
		[MethodImpl(256)]
		public double4x4(double4 c0, double4 c1, double4 c2, double4 c3)
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x57A2310", Offset = "0x57A0F10", VA = "0x1857A2310")]
		[MethodImpl(256)]
		public double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
		{
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x57A2190", Offset = "0x57A0D90", VA = "0x1857A2190")]
		[MethodImpl(256)]
		public double4x4(double v)
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x57A21F0", Offset = "0x57A0DF0", VA = "0x1857A21F0")]
		[MethodImpl(256)]
		public double4x4(bool v)
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x56FCAE0", Offset = "0x56FB6E0", VA = "0x1856FCAE0")]
		[MethodImpl(256)]
		public double4x4(bool4x4 v)
		{
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x57A22B0", Offset = "0x57A0EB0", VA = "0x1857A22B0")]
		[MethodImpl(256)]
		public double4x4(int v)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x56FCC30", Offset = "0x56FB830", VA = "0x1856FCC30")]
		[MethodImpl(256)]
		public double4x4(int4x4 v)
		{
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x56FCA50", Offset = "0x56FB650", VA = "0x1856FCA50")]
		[MethodImpl(256)]
		public double4x4(uint v)
		{
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x56FC8D0", Offset = "0x56FB4D0", VA = "0x1856FC8D0")]
		[MethodImpl(256)]
		public double4x4(uint4x4 v)
		{
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x56FC710", Offset = "0x56FB310", VA = "0x1856FC710")]
		[MethodImpl(256)]
		public double4x4(float v)
		{
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x56FC7B0", Offset = "0x56FB3B0", VA = "0x1856FC7B0")]
		[MethodImpl(256)]
		public double4x4(float4x4 v)
		{
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000176D0 File Offset: 0x000158D0
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x5711660", Offset = "0x5710260", VA = "0x185711660")]
		[MethodImpl(256)]
		public static implicit operator double4x4(double v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x000176E8 File Offset: 0x000158E8
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x57116C0", Offset = "0x57102C0", VA = "0x1857116C0")]
		[MethodImpl(256)]
		public static explicit operator double4x4(bool v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00017700 File Offset: 0x00015900
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x5711BF0", Offset = "0x57107F0", VA = "0x185711BF0")]
		[MethodImpl(256)]
		public static explicit operator double4x4(bool4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00017718 File Offset: 0x00015918
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x5711C40", Offset = "0x5710840", VA = "0x185711C40")]
		[MethodImpl(256)]
		public static implicit operator double4x4(int v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00017730 File Offset: 0x00015930
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x57A3C40", Offset = "0x57A2840", VA = "0x1857A3C40")]
		[MethodImpl(256)]
		public static implicit operator double4x4(int4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00017748 File Offset: 0x00015948
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x57A3D60", Offset = "0x57A2960", VA = "0x1857A3D60")]
		[MethodImpl(256)]
		public static implicit operator double4x4(uint v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00017760 File Offset: 0x00015960
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x57A3CF0", Offset = "0x57A28F0", VA = "0x1857A3CF0")]
		[MethodImpl(256)]
		public static implicit operator double4x4(uint4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00017778 File Offset: 0x00015978
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x57A3CB0", Offset = "0x57A28B0", VA = "0x1857A3CB0")]
		[MethodImpl(256)]
		public static implicit operator double4x4(float v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00017790 File Offset: 0x00015990
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x57A3DA0", Offset = "0x57A29A0", VA = "0x1857A3DA0")]
		[MethodImpl(256)]
		public static implicit operator double4x4(float4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000177A8 File Offset: 0x000159A8
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x57A5710", Offset = "0x57A4310", VA = "0x1857A5710")]
		[MethodImpl(256)]
		public static double4x4 operator *(double4x4 lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x000177C0 File Offset: 0x000159C0
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x57A53D0", Offset = "0x57A3FD0", VA = "0x1857A53D0")]
		[MethodImpl(256)]
		public static double4x4 operator *(double4x4 lhs, double rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000177D8 File Offset: 0x000159D8
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x57A5570", Offset = "0x57A4170", VA = "0x1857A5570")]
		[MethodImpl(256)]
		public static double4x4 operator *(double lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000177F0 File Offset: 0x000159F0
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x57A2720", Offset = "0x57A1320", VA = "0x1857A2720")]
		[MethodImpl(256)]
		public static double4x4 operator +(double4x4 lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00017808 File Offset: 0x00015A08
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x57A2580", Offset = "0x57A1180", VA = "0x1857A2580")]
		[MethodImpl(256)]
		public static double4x4 operator +(double4x4 lhs, double rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00017820 File Offset: 0x00015A20
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x57A23E0", Offset = "0x57A0FE0", VA = "0x1857A23E0")]
		[MethodImpl(256)]
		public static double4x4 operator +(double lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00017838 File Offset: 0x00015A38
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x57A58F0", Offset = "0x57A44F0", VA = "0x1857A58F0")]
		[MethodImpl(256)]
		public static double4x4 operator -(double4x4 lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00017850 File Offset: 0x00015A50
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x57A5C90", Offset = "0x57A4890", VA = "0x1857A5C90")]
		[MethodImpl(256)]
		public static double4x4 operator -(double4x4 lhs, double rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00017868 File Offset: 0x00015A68
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x57A5AD0", Offset = "0x57A46D0", VA = "0x1857A5AD0")]
		[MethodImpl(256)]
		public static double4x4 operator -(double lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00017880 File Offset: 0x00015A80
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x57A2DB0", Offset = "0x57A19B0", VA = "0x1857A2DB0")]
		[MethodImpl(256)]
		public static double4x4 operator /(double4x4 lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00017898 File Offset: 0x00015A98
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x57A2C10", Offset = "0x57A1810", VA = "0x1857A2C10")]
		[MethodImpl(256)]
		public static double4x4 operator /(double4x4 lhs, double rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x000178B0 File Offset: 0x00015AB0
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x57A2A50", Offset = "0x57A1650", VA = "0x1857A2A50")]
		[MethodImpl(256)]
		public static double4x4 operator /(double lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x000178C8 File Offset: 0x00015AC8
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x57A5110", Offset = "0x57A3D10", VA = "0x1857A5110")]
		[MethodImpl(256)]
		public static double4x4 operator %(double4x4 lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000178E0 File Offset: 0x00015AE0
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x57A4E90", Offset = "0x57A3A90", VA = "0x1857A4E90")]
		[MethodImpl(256)]
		public static double4x4 operator %(double4x4 lhs, double rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000178F8 File Offset: 0x00015AF8
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x57A4C10", Offset = "0x57A3810", VA = "0x1857A4C10")]
		[MethodImpl(256)]
		public static double4x4 operator %(double lhs, double4x4 rhs)
		{
			return default(double4x4);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00017910 File Offset: 0x00015B10
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x57A3E10", Offset = "0x57A2A10", VA = "0x1857A3E10")]
		[MethodImpl(256)]
		public static double4x4 operator ++(double4x4 val)
		{
			return default(double4x4);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00017928 File Offset: 0x00015B28
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x57A2900", Offset = "0x57A1500", VA = "0x1857A2900")]
		[MethodImpl(256)]
		public static double4x4 operator --(double4x4 val)
		{
			return default(double4x4);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00017940 File Offset: 0x00015B40
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x57A4AD0", Offset = "0x57A36D0", VA = "0x1857A4AD0")]
		[MethodImpl(256)]
		public static bool4x4 operator <(double4x4 lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00017958 File Offset: 0x00015B58
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x57A49D0", Offset = "0x57A35D0", VA = "0x1857A49D0")]
		[MethodImpl(256)]
		public static bool4x4 operator <(double4x4 lhs, double rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00017970 File Offset: 0x00015B70
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x57A48D0", Offset = "0x57A34D0", VA = "0x1857A48D0")]
		[MethodImpl(256)]
		public static bool4x4 operator <(double lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00017988 File Offset: 0x00015B88
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x57A4590", Offset = "0x57A3190", VA = "0x1857A4590")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(double4x4 lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000179A0 File Offset: 0x00015BA0
		[Token(Token = "0x6001000")]
		[Address(RVA = "0x57A47D0", Offset = "0x57A33D0", VA = "0x1857A47D0")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(double4x4 lhs, double rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000179B8 File Offset: 0x00015BB8
		[Token(Token = "0x6001001")]
		[Address(RVA = "0x57A46D0", Offset = "0x57A32D0", VA = "0x1857A46D0")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(double lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000179D0 File Offset: 0x00015BD0
		[Token(Token = "0x6001002")]
		[Address(RVA = "0x57A3A00", Offset = "0x57A2600", VA = "0x1857A3A00")]
		[MethodImpl(256)]
		public static bool4x4 operator >(double4x4 lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000179E8 File Offset: 0x00015BE8
		[Token(Token = "0x6001003")]
		[Address(RVA = "0x57A3900", Offset = "0x57A2500", VA = "0x1857A3900")]
		[MethodImpl(256)]
		public static bool4x4 operator >(double4x4 lhs, double rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00017A00 File Offset: 0x00015C00
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x57A3B40", Offset = "0x57A2740", VA = "0x1857A3B40")]
		[MethodImpl(256)]
		public static bool4x4 operator >(double lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00017A18 File Offset: 0x00015C18
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x57A37C0", Offset = "0x57A23C0", VA = "0x1857A37C0")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(double4x4 lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00017A30 File Offset: 0x00015C30
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x57A36C0", Offset = "0x57A22C0", VA = "0x1857A36C0")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(double4x4 lhs, double rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00017A48 File Offset: 0x00015C48
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x57A35C0", Offset = "0x57A21C0", VA = "0x1857A35C0")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(double lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00017A60 File Offset: 0x00015C60
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x57A5E30", Offset = "0x57A4A30", VA = "0x1857A5E30")]
		[MethodImpl(256)]
		public static double4x4 operator -(double4x4 val)
		{
			return default(double4x4);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00017A78 File Offset: 0x00015C78
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x57A5FC0", Offset = "0x57A4BC0", VA = "0x1857A5FC0")]
		[MethodImpl(256)]
		public static double4x4 operator +(double4x4 val)
		{
			return default(double4x4);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00017A90 File Offset: 0x00015C90
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x57A3370", Offset = "0x57A1F70", VA = "0x1857A3370")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(double4x4 lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00017AA8 File Offset: 0x00015CA8
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x57A3170", Offset = "0x57A1D70", VA = "0x1857A3170")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(double4x4 lhs, double rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00017AC0 File Offset: 0x00015CC0
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x57A2F90", Offset = "0x57A1B90", VA = "0x1857A2F90")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(double lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00017AD8 File Offset: 0x00015CD8
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x57A4340", Offset = "0x57A2F40", VA = "0x1857A4340")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(double4x4 lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00017AF0 File Offset: 0x00015CF0
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x57A3F60", Offset = "0x57A2B60", VA = "0x1857A3F60")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(double4x4 lhs, double rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00017B08 File Offset: 0x00015D08
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x57A4160", Offset = "0x57A2D60", VA = "0x1857A4160")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(double lhs, double4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x170003DA RID: 986
		[Token(Token = "0x170003DA")]
		public double4 this[int index]
		{
			[Token(Token = "0x6001010")]
			[Address(RVA = "0x3D281A0", Offset = "0x3D26DA0", VA = "0x183D281A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00017B20 File Offset: 0x00015D20
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x57928D0", Offset = "0x57914D0", VA = "0x1857928D0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(double4x4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00017B38 File Offset: 0x00015D38
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x57A1260", Offset = "0x579FE60", VA = "0x1857A1260", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00017B50 File Offset: 0x00015D50
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x57A1360", Offset = "0x579FF60", VA = "0x1857A1360", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x57A1A20", Offset = "0x57A0620", VA = "0x1857A1A20", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x57A13C0", Offset = "0x579FFC0", VA = "0x1857A13C0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x0")]
		public double4 c0;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x20")]
		public double4 c1;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x40")]
		public double4 c2;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x60")]
		public double4 c3;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double4x4 identity;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x80")]
		public static readonly double4x4 zero;
	}
}
