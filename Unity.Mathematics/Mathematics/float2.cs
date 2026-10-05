using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[DebuggerTypeProxy(typeof(float2.DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct float2 : IEquatable<float2>, IFormattable
	{
		// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x4F1E50", Offset = "0x4F0A50", VA = "0x1804F1E50")]
		[MethodImpl(256)]
		public float2(float x, float y)
		{
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x57A9A70", Offset = "0x57A8670", VA = "0x1857A9A70")]
		[MethodImpl(256)]
		public float2(float2 xy)
		{
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x57A9A30", Offset = "0x57A8630", VA = "0x1857A9A30")]
		[MethodImpl(256)]
		public float2(float v)
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x57A9B10", Offset = "0x57A8710", VA = "0x1857A9B10")]
		[MethodImpl(256)]
		public float2(bool v)
		{
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x57A9A00", Offset = "0x57A8600", VA = "0x1857A9A00")]
		[MethodImpl(256)]
		public float2(bool2 v)
		{
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x57A9AD0", Offset = "0x57A86D0", VA = "0x1857A9AD0")]
		[MethodImpl(256)]
		public float2(int v)
		{
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x57A9AB0", Offset = "0x57A86B0", VA = "0x1857A9AB0")]
		[MethodImpl(256)]
		public float2(int2 v)
		{
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101E")]
		[Address(RVA = "0x57A9A90", Offset = "0x57A8690", VA = "0x1857A9A90")]
		[MethodImpl(256)]
		public float2(uint v)
		{
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101F")]
		[Address(RVA = "0x57A9A40", Offset = "0x57A8640", VA = "0x1857A9A40")]
		[MethodImpl(256)]
		public float2(uint2 v)
		{
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001020")]
		[Address(RVA = "0x56FCDA0", Offset = "0x56FB9A0", VA = "0x1856FCDA0")]
		[MethodImpl(256)]
		public float2(half v)
		{
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x56FCE80", Offset = "0x56FBA80", VA = "0x1856FCE80")]
		[MethodImpl(256)]
		public float2(half2 v)
		{
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x57A9AF0", Offset = "0x57A86F0", VA = "0x1857A9AF0")]
		[MethodImpl(256)]
		public float2(double v)
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x57A9B40", Offset = "0x57A8740", VA = "0x1857A9B40")]
		[MethodImpl(256)]
		public float2(double2 v)
		{
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00017B68 File Offset: 0x00015D68
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x5716000", Offset = "0x5714C00", VA = "0x185716000")]
		[MethodImpl(256)]
		public static implicit operator float2(float v)
		{
			return default(float2);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00017B80 File Offset: 0x00015D80
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x5715CE0", Offset = "0x57148E0", VA = "0x185715CE0")]
		[MethodImpl(256)]
		public static explicit operator float2(bool v)
		{
			return default(float2);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00017B98 File Offset: 0x00015D98
		[Token(Token = "0x6001026")]
		[Address(RVA = "0x5715D30", Offset = "0x5714930", VA = "0x185715D30")]
		[MethodImpl(256)]
		public static explicit operator float2(bool2 v)
		{
			return default(float2);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00017BB0 File Offset: 0x00015DB0
		[Token(Token = "0x6001027")]
		[Address(RVA = "0x5715D80", Offset = "0x5714980", VA = "0x185715D80")]
		[MethodImpl(256)]
		public static implicit operator float2(int v)
		{
			return default(float2);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00017BC8 File Offset: 0x00015DC8
		[Token(Token = "0x6001028")]
		[Address(RVA = "0x5715DA0", Offset = "0x57149A0", VA = "0x185715DA0")]
		[MethodImpl(256)]
		public static implicit operator float2(int2 v)
		{
			return default(float2);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00017BE0 File Offset: 0x00015DE0
		[Token(Token = "0x6001029")]
		[Address(RVA = "0x5715ED0", Offset = "0x5714AD0", VA = "0x185715ED0")]
		[MethodImpl(256)]
		public static implicit operator float2(uint v)
		{
			return default(float2);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00017BF8 File Offset: 0x00015DF8
		[Token(Token = "0x600102A")]
		[Address(RVA = "0x5715DC0", Offset = "0x57149C0", VA = "0x185715DC0")]
		[MethodImpl(256)]
		public static implicit operator float2(uint2 v)
		{
			return default(float2);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00017C10 File Offset: 0x00015E10
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x5715F10", Offset = "0x5714B10", VA = "0x185715F10")]
		[MethodImpl(256)]
		public static implicit operator float2(half v)
		{
			return default(float2);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00017C28 File Offset: 0x00015E28
		[Token(Token = "0x600102C")]
		[Address(RVA = "0x5715DF0", Offset = "0x57149F0", VA = "0x185715DF0")]
		[MethodImpl(256)]
		public static implicit operator float2(half2 v)
		{
			return default(float2);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00017C40 File Offset: 0x00015E40
		[Token(Token = "0x600102D")]
		[Address(RVA = "0x5715FE0", Offset = "0x5714BE0", VA = "0x185715FE0")]
		[MethodImpl(256)]
		public static explicit operator float2(double v)
		{
			return default(float2);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00017C58 File Offset: 0x00015E58
		[Token(Token = "0x600102E")]
		[Address(RVA = "0x5715D10", Offset = "0x5714910", VA = "0x185715D10")]
		[MethodImpl(256)]
		public static explicit operator float2(double2 v)
		{
			return default(float2);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00017C70 File Offset: 0x00015E70
		[Token(Token = "0x600102F")]
		[Address(RVA = "0x57AA510", Offset = "0x57A9110", VA = "0x1857AA510")]
		[MethodImpl(256)]
		public static float2 operator *(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00017C88 File Offset: 0x00015E88
		[Token(Token = "0x6001030")]
		[Address(RVA = "0x57AA4B0", Offset = "0x57A90B0", VA = "0x1857AA4B0")]
		[MethodImpl(256)]
		public static float2 operator *(float2 lhs, float rhs)
		{
			return default(float2);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00017CA0 File Offset: 0x00015EA0
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x57AA4E0", Offset = "0x57A90E0", VA = "0x1857AA4E0")]
		[MethodImpl(256)]
		public static float2 operator *(float lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00017CB8 File Offset: 0x00015EB8
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x57A9ED0", Offset = "0x57A8AD0", VA = "0x1857A9ED0")]
		[MethodImpl(256)]
		public static float2 operator +(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00017CD0 File Offset: 0x00015ED0
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x57A9EA0", Offset = "0x57A8AA0", VA = "0x1857A9EA0")]
		[MethodImpl(256)]
		public static float2 operator +(float2 lhs, float rhs)
		{
			return default(float2);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00017CE8 File Offset: 0x00015EE8
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x57A9F10", Offset = "0x57A8B10", VA = "0x1857A9F10")]
		[MethodImpl(256)]
		public static float2 operator +(float lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00017D00 File Offset: 0x00015F00
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x57AA550", Offset = "0x57A9150", VA = "0x1857AA550")]
		[MethodImpl(256)]
		public static float2 operator -(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00017D18 File Offset: 0x00015F18
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x57AA5B0", Offset = "0x57A91B0", VA = "0x1857AA5B0")]
		[MethodImpl(256)]
		public static float2 operator -(float2 lhs, float rhs)
		{
			return default(float2);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00017D30 File Offset: 0x00015F30
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x57AA590", Offset = "0x57A9190", VA = "0x1857AA590")]
		[MethodImpl(256)]
		public static float2 operator -(float lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00017D48 File Offset: 0x00015F48
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x1579520", Offset = "0x1578120", VA = "0x181579520")]
		[MethodImpl(256)]
		public static float2 operator /(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00017D60 File Offset: 0x00015F60
		[Token(Token = "0x6001039")]
		[Address(RVA = "0x57A9F70", Offset = "0x57A8B70", VA = "0x1857A9F70")]
		[MethodImpl(256)]
		public static float2 operator /(float2 lhs, float rhs)
		{
			return default(float2);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00017D78 File Offset: 0x00015F78
		[Token(Token = "0x600103A")]
		[Address(RVA = "0x57A9FA0", Offset = "0x57A8BA0", VA = "0x1857A9FA0")]
		[MethodImpl(256)]
		public static float2 operator /(float lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00017D90 File Offset: 0x00015F90
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x571A6B0", Offset = "0x57192B0", VA = "0x18571A6B0")]
		[MethodImpl(256)]
		public static float2 operator %(float2 lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00017DA8 File Offset: 0x00015FA8
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x57AA460", Offset = "0x57A9060", VA = "0x1857AA460")]
		[MethodImpl(256)]
		public static float2 operator %(float2 lhs, float rhs)
		{
			return default(float2);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00017DC0 File Offset: 0x00015FC0
		[Token(Token = "0x600103D")]
		[Address(RVA = "0x57AA410", Offset = "0x57A9010", VA = "0x1857AA410")]
		[MethodImpl(256)]
		public static float2 operator %(float lhs, float2 rhs)
		{
			return default(float2);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00017DD8 File Offset: 0x00015FD8
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x57AA1D0", Offset = "0x57A8DD0", VA = "0x1857AA1D0")]
		[MethodImpl(256)]
		public static float2 operator ++(float2 val)
		{
			return default(float2);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00017DF0 File Offset: 0x00015FF0
		[Token(Token = "0x600103F")]
		[Address(RVA = "0x57A9F40", Offset = "0x57A8B40", VA = "0x1857A9F40")]
		[MethodImpl(256)]
		public static float2 operator --(float2 val)
		{
			return default(float2);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00017E08 File Offset: 0x00016008
		[Token(Token = "0x6001040")]
		[Address(RVA = "0x57AA3B0", Offset = "0x57A8FB0", VA = "0x1857AA3B0")]
		[MethodImpl(256)]
		public static bool2 operator <(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00017E20 File Offset: 0x00016020
		[Token(Token = "0x6001041")]
		[Address(RVA = "0x57AA3F0", Offset = "0x57A8FF0", VA = "0x1857AA3F0")]
		[MethodImpl(256)]
		public static bool2 operator <(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00017E38 File Offset: 0x00016038
		[Token(Token = "0x6001042")]
		[Address(RVA = "0x57AA380", Offset = "0x57A8F80", VA = "0x1857AA380")]
		[MethodImpl(256)]
		public static bool2 operator <(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00017E50 File Offset: 0x00016050
		[Token(Token = "0x6001043")]
		[Address(RVA = "0x57AA320", Offset = "0x57A8F20", VA = "0x1857AA320")]
		[MethodImpl(256)]
		public static bool2 operator <=(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00017E68 File Offset: 0x00016068
		[Token(Token = "0x6001044")]
		[Address(RVA = "0x57AA360", Offset = "0x57A8F60", VA = "0x1857AA360")]
		[MethodImpl(256)]
		public static bool2 operator <=(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00017E80 File Offset: 0x00016080
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x57AA2F0", Offset = "0x57A8EF0", VA = "0x1857AA2F0")]
		[MethodImpl(256)]
		public static bool2 operator <=(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00017E98 File Offset: 0x00016098
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x57AA170", Offset = "0x57A8D70", VA = "0x1857AA170")]
		[MethodImpl(256)]
		public static bool2 operator >(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00017EB0 File Offset: 0x000160B0
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x57AA140", Offset = "0x57A8D40", VA = "0x1857AA140")]
		[MethodImpl(256)]
		public static bool2 operator >(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00017EC8 File Offset: 0x000160C8
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x57AA1B0", Offset = "0x57A8DB0", VA = "0x1857AA1B0")]
		[MethodImpl(256)]
		public static bool2 operator >(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00017EE0 File Offset: 0x000160E0
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x57AA0B0", Offset = "0x57A8CB0", VA = "0x1857AA0B0")]
		[MethodImpl(256)]
		public static bool2 operator >=(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00017EF8 File Offset: 0x000160F8
		[Token(Token = "0x600104A")]
		[Address(RVA = "0x57AA110", Offset = "0x57A8D10", VA = "0x1857AA110")]
		[MethodImpl(256)]
		public static bool2 operator >=(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00017F10 File Offset: 0x00016110
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x57AA0F0", Offset = "0x57A8CF0", VA = "0x1857AA0F0")]
		[MethodImpl(256)]
		public static bool2 operator >=(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00017F28 File Offset: 0x00016128
		[Token(Token = "0x600104C")]
		[Address(RVA = "0x57AA5E0", Offset = "0x57A91E0", VA = "0x1857AA5E0")]
		[MethodImpl(256)]
		public static float2 operator -(float2 val)
		{
			return default(float2);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00017F40 File Offset: 0x00016140
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x5715EF0", Offset = "0x5714AF0", VA = "0x185715EF0")]
		[MethodImpl(256)]
		public static float2 operator +(float2 val)
		{
			return default(float2);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00017F58 File Offset: 0x00016158
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x57A9FC0", Offset = "0x57A8BC0", VA = "0x1857A9FC0")]
		[MethodImpl(256)]
		public static bool2 operator ==(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00017F70 File Offset: 0x00016170
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x57AA020", Offset = "0x57A8C20", VA = "0x1857AA020")]
		[MethodImpl(256)]
		public static bool2 operator ==(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00017F88 File Offset: 0x00016188
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x57AA070", Offset = "0x57A8C70", VA = "0x1857AA070")]
		[MethodImpl(256)]
		public static bool2 operator ==(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00017FA0 File Offset: 0x000161A0
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x57AA290", Offset = "0x57A8E90", VA = "0x1857AA290")]
		[MethodImpl(256)]
		public static bool2 operator !=(float2 lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00017FB8 File Offset: 0x000161B8
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x57AA200", Offset = "0x57A8E00", VA = "0x1857AA200")]
		[MethodImpl(256)]
		public static bool2 operator !=(float2 lhs, float rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00017FD0 File Offset: 0x000161D0
		[Token(Token = "0x6001053")]
		[Address(RVA = "0x57AA250", Offset = "0x57A8E50", VA = "0x1857AA250")]
		[MethodImpl(256)]
		public static bool2 operator !=(float lhs, float2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00017FE8 File Offset: 0x000161E8
		[Token(Token = "0x170003DB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxx
		{
			[Token(Token = "0x6001054")]
			[Address(RVA = "0x57A9BA0", Offset = "0x57A87A0", VA = "0x1857A9BA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00018000 File Offset: 0x00016200
		[Token(Token = "0x170003DC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxy
		{
			[Token(Token = "0x6001055")]
			[Address(RVA = "0x57A9BB0", Offset = "0x57A87B0", VA = "0x1857A9BB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00018018 File Offset: 0x00016218
		[Token(Token = "0x170003DD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyx
		{
			[Token(Token = "0x6001056")]
			[Address(RVA = "0x57A9BF0", Offset = "0x57A87F0", VA = "0x1857A9BF0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00018030 File Offset: 0x00016230
		[Token(Token = "0x170003DE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyy
		{
			[Token(Token = "0x6001057")]
			[Address(RVA = "0x57A9C10", Offset = "0x57A8810", VA = "0x1857A9C10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00018048 File Offset: 0x00016248
		[Token(Token = "0x170003DF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxx
		{
			[Token(Token = "0x6001058")]
			[Address(RVA = "0x57A9C50", Offset = "0x57A8850", VA = "0x1857A9C50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00018060 File Offset: 0x00016260
		[Token(Token = "0x170003E0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy
		{
			[Token(Token = "0x6001059")]
			[Address(RVA = "0x57A9C70", Offset = "0x57A8870", VA = "0x1857A9C70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00018078 File Offset: 0x00016278
		[Token(Token = "0x170003E1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyx
		{
			[Token(Token = "0x600105A")]
			[Address(RVA = "0x57A9CB0", Offset = "0x57A88B0", VA = "0x1857A9CB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00018090 File Offset: 0x00016290
		[Token(Token = "0x170003E2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyy
		{
			[Token(Token = "0x600105B")]
			[Address(RVA = "0x57A9CD0", Offset = "0x57A88D0", VA = "0x1857A9CD0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x000180A8 File Offset: 0x000162A8
		[Token(Token = "0x170003E3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxx
		{
			[Token(Token = "0x600105C")]
			[Address(RVA = "0x57A9D30", Offset = "0x57A8930", VA = "0x1857A9D30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x000180C0 File Offset: 0x000162C0
		[Token(Token = "0x170003E4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy
		{
			[Token(Token = "0x600105D")]
			[Address(RVA = "0x57A9D50", Offset = "0x57A8950", VA = "0x1857A9D50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x000180D8 File Offset: 0x000162D8
		[Token(Token = "0x170003E5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyx
		{
			[Token(Token = "0x600105E")]
			[Address(RVA = "0x57A9D90", Offset = "0x57A8990", VA = "0x1857A9D90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x000180F0 File Offset: 0x000162F0
		[Token(Token = "0x170003E6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyy
		{
			[Token(Token = "0x600105F")]
			[Address(RVA = "0x57A9DB0", Offset = "0x57A89B0", VA = "0x1857A9DB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x00018108 File Offset: 0x00016308
		[Token(Token = "0x170003E7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxx
		{
			[Token(Token = "0x6001060")]
			[Address(RVA = "0x57A9E10", Offset = "0x57A8A10", VA = "0x1857A9E10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00018120 File Offset: 0x00016320
		[Token(Token = "0x170003E8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxy
		{
			[Token(Token = "0x6001061")]
			[Address(RVA = "0x57A9E30", Offset = "0x57A8A30", VA = "0x1857A9E30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x00018138 File Offset: 0x00016338
		[Token(Token = "0x170003E9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyx
		{
			[Token(Token = "0x6001062")]
			[Address(RVA = "0x57A9E70", Offset = "0x57A8A70", VA = "0x1857A9E70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00018150 File Offset: 0x00016350
		[Token(Token = "0x170003EA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyy
		{
			[Token(Token = "0x6001063")]
			[Address(RVA = "0x57A9E90", Offset = "0x57A8A90", VA = "0x1857A9E90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00018168 File Offset: 0x00016368
		[Token(Token = "0x170003EB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx
		{
			[Token(Token = "0x6001064")]
			[Address(RVA = "0x57A9B80", Offset = "0x57A8780", VA = "0x1857A9B80")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x00018180 File Offset: 0x00016380
		[Token(Token = "0x170003EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxy
		{
			[Token(Token = "0x6001065")]
			[Address(RVA = "0x57A9BD0", Offset = "0x57A87D0", VA = "0x1857A9BD0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00018198 File Offset: 0x00016398
		[Token(Token = "0x170003ED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyx
		{
			[Token(Token = "0x6001066")]
			[Address(RVA = "0x57A9C30", Offset = "0x57A8830", VA = "0x1857A9C30")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x000181B0 File Offset: 0x000163B0
		[Token(Token = "0x170003EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyy
		{
			[Token(Token = "0x6001067")]
			[Address(RVA = "0x57A9C90", Offset = "0x57A8890", VA = "0x1857A9C90")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x000181C8 File Offset: 0x000163C8
		[Token(Token = "0x170003EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxx
		{
			[Token(Token = "0x6001068")]
			[Address(RVA = "0x57A9D10", Offset = "0x57A8910", VA = "0x1857A9D10")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x000181E0 File Offset: 0x000163E0
		[Token(Token = "0x170003F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxy
		{
			[Token(Token = "0x6001069")]
			[Address(RVA = "0x57A9D70", Offset = "0x57A8970", VA = "0x1857A9D70")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x000181F8 File Offset: 0x000163F8
		[Token(Token = "0x170003F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyx
		{
			[Token(Token = "0x600106A")]
			[Address(RVA = "0x57A9DF0", Offset = "0x57A89F0", VA = "0x1857A9DF0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00018210 File Offset: 0x00016410
		[Token(Token = "0x170003F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyy
		{
			[Token(Token = "0x600106B")]
			[Address(RVA = "0x57A9E50", Offset = "0x57A8A50", VA = "0x1857A9E50")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00018228 File Offset: 0x00016428
		[Token(Token = "0x170003F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx
		{
			[Token(Token = "0x600106C")]
			[Address(RVA = "0x57A9B70", Offset = "0x57A8770", VA = "0x1857A9B70")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00018240 File Offset: 0x00016440
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy
		{
			[Token(Token = "0x600106D")]
			[Address(RVA = "0x15795C0", Offset = "0x15781C0", VA = "0x1815795C0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x600106E")]
			[Address(RVA = "0x57A9A70", Offset = "0x57A8670", VA = "0x1857A9A70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x00018258 File Offset: 0x00016458
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx
		{
			[Token(Token = "0x600106F")]
			[Address(RVA = "0x57A9CF0", Offset = "0x57A88F0", VA = "0x1857A9CF0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x6001070")]
			[Address(RVA = "0x57AA620", Offset = "0x57A9220", VA = "0x1857AA620")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00018270 File Offset: 0x00016470
		[Token(Token = "0x170003F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy
		{
			[Token(Token = "0x6001071")]
			[Address(RVA = "0x57A9DD0", Offset = "0x57A89D0", VA = "0x1857A9DD0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x170003F7 RID: 1015
		[Token(Token = "0x170003F7")]
		public float this[int index]
		{
			[Token(Token = "0x6001072")]
			[Address(RVA = "0x57A9B60", Offset = "0x57A8760", VA = "0x1857A9B60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001073")]
			[Address(RVA = "0x57AA610", Offset = "0x57A9210", VA = "0x1857AA610")]
			set
			{
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x000182A0 File Offset: 0x000164A0
		[Token(Token = "0x6001074")]
		[Address(RVA = "0x57A9790", Offset = "0x57A8390", VA = "0x1857A9790", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000182B8 File Offset: 0x000164B8
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x57A97C0", Offset = "0x57A83C0", VA = "0x1857A97C0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x000182D0 File Offset: 0x000164D0
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x57A9860", Offset = "0x57A8460", VA = "0x1857A9860", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x57A9970", Offset = "0x57A8570", VA = "0x1857A9970", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001078")]
		[Address(RVA = "0x57A98E0", Offset = "0x57A84E0", VA = "0x1857A98E0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x000182E8 File Offset: 0x000164E8
		[Token(Token = "0x6001079")]
		[Address(RVA = "0x5715EF0", Offset = "0x5714AF0", VA = "0x185715EF0")]
		public static implicit operator Vector2(float2 v)
		{
			return default(Vector2);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00018300 File Offset: 0x00016500
		[Token(Token = "0x600107A")]
		[Address(RVA = "0x5715EF0", Offset = "0x5714AF0", VA = "0x185715EF0")]
		public static implicit operator float2(Vector2 v)
		{
			return default(float2);
		}

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float2 zero;

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x0600107B RID: 4219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600107B")]
			[Address(RVA = "0x57A9710", Offset = "0x57A8310", VA = "0x1857A9710")]
			public DebuggerProxy(float2 v)
			{
			}

			// Token: 0x04000098 RID: 152
			[Token(Token = "0x4000098")]
			[FieldOffset(Offset = "0x10")]
			public float x;

			// Token: 0x04000099 RID: 153
			[Token(Token = "0x4000099")]
			[FieldOffset(Offset = "0x14")]
			public float y;
		}
	}
}
