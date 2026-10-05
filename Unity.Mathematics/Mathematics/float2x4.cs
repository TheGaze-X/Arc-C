using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct float2x4 : IEquatable<float2x4>, IFormattable
	{
		// Token: 0x060010FF RID: 4351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x57AE510", Offset = "0x57AD110", VA = "0x1857AE510")]
		[MethodImpl(256)]
		public float2x4(float2 c0, float2 c1, float2 c2, float2 c3)
		{
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001100")]
		[Address(RVA = "0x57AE450", Offset = "0x57AD050", VA = "0x1857AE450")]
		[MethodImpl(256)]
		public float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13)
		{
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x57AE530", Offset = "0x57AD130", VA = "0x1857AE530")]
		[MethodImpl(256)]
		public float2x4(float v)
		{
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x56FCFD0", Offset = "0x56FBBD0", VA = "0x1856FCFD0")]
		[MethodImpl(256)]
		public float2x4(bool v)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001103")]
		[Address(RVA = "0x56FD050", Offset = "0x56FBC50", VA = "0x1856FD050")]
		[MethodImpl(256)]
		public float2x4(bool2x4 v)
		{
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x57AE6F0", Offset = "0x57AD2F0", VA = "0x1857AE6F0")]
		[MethodImpl(256)]
		public float2x4(int v)
		{
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001105")]
		[Address(RVA = "0x57AE550", Offset = "0x57AD150", VA = "0x1857AE550")]
		[MethodImpl(256)]
		public float2x4(int2x4 v)
		{
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001106")]
		[Address(RVA = "0x57AE6C0", Offset = "0x57AD2C0", VA = "0x1857AE6C0")]
		[MethodImpl(256)]
		public float2x4(uint v)
		{
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001107")]
		[Address(RVA = "0x57AE5D0", Offset = "0x57AD1D0", VA = "0x1857AE5D0")]
		[MethodImpl(256)]
		public float2x4(uint2x4 v)
		{
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x57AE690", Offset = "0x57AD290", VA = "0x1857AE690")]
		[MethodImpl(256)]
		public float2x4(double v)
		{
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x57AE4A0", Offset = "0x57AD0A0", VA = "0x1857AE4A0")]
		[MethodImpl(256)]
		public float2x4(double2x4 v)
		{
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00018CA8 File Offset: 0x00016EA8
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x5716990", Offset = "0x5715590", VA = "0x185716990")]
		[MethodImpl(256)]
		public static implicit operator float2x4(float v)
		{
			return default(float2x4);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00018CC0 File Offset: 0x00016EC0
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x57AEEA0", Offset = "0x57ADAA0", VA = "0x1857AEEA0")]
		[MethodImpl(256)]
		public static explicit operator float2x4(bool v)
		{
			return default(float2x4);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00018CD8 File Offset: 0x00016ED8
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x57AEE70", Offset = "0x57ADA70", VA = "0x1857AEE70")]
		[MethodImpl(256)]
		public static explicit operator float2x4(bool2x4 v)
		{
			return default(float2x4);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00018CF0 File Offset: 0x00016EF0
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x5716970", Offset = "0x5715570", VA = "0x185716970")]
		[MethodImpl(256)]
		public static implicit operator float2x4(int v)
		{
			return default(float2x4);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00018D08 File Offset: 0x00016F08
		[Token(Token = "0x600110E")]
		[Address(RVA = "0x5716AD0", Offset = "0x57156D0", VA = "0x185716AD0")]
		[MethodImpl(256)]
		public static implicit operator float2x4(int2x4 v)
		{
			return default(float2x4);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00018D20 File Offset: 0x00016F20
		[Token(Token = "0x600110F")]
		[Address(RVA = "0x57168F0", Offset = "0x57154F0", VA = "0x1857168F0")]
		[MethodImpl(256)]
		public static implicit operator float2x4(uint v)
		{
			return default(float2x4);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00018D38 File Offset: 0x00016F38
		[Token(Token = "0x6001110")]
		[Address(RVA = "0x57169C0", Offset = "0x57155C0", VA = "0x1857169C0")]
		[MethodImpl(256)]
		public static implicit operator float2x4(uint2x4 v)
		{
			return default(float2x4);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00018D50 File Offset: 0x00016F50
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x57169A0", Offset = "0x57155A0", VA = "0x1857169A0")]
		[MethodImpl(256)]
		public static explicit operator float2x4(double v)
		{
			return default(float2x4);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00018D68 File Offset: 0x00016F68
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x5716790", Offset = "0x5715390", VA = "0x185716790")]
		[MethodImpl(256)]
		public static explicit operator float2x4(double2x4 v)
		{
			return default(float2x4);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00018D80 File Offset: 0x00016F80
		[Token(Token = "0x6001113")]
		[Address(RVA = "0x57AFEE0", Offset = "0x57AEAE0", VA = "0x1857AFEE0")]
		[MethodImpl(256)]
		public static float2x4 operator *(float2x4 lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00018D98 File Offset: 0x00016F98
		[Token(Token = "0x6001114")]
		[Address(RVA = "0x57AFF90", Offset = "0x57AEB90", VA = "0x1857AFF90")]
		[MethodImpl(256)]
		public static float2x4 operator *(float2x4 lhs, float rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00018DB0 File Offset: 0x00016FB0
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x57AFE60", Offset = "0x57AEA60", VA = "0x1857AFE60")]
		[MethodImpl(256)]
		public static float2x4 operator *(float lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00018DC8 File Offset: 0x00016FC8
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x57AE720", Offset = "0x57AD320", VA = "0x1857AE720")]
		[MethodImpl(256)]
		public static float2x4 operator +(float2x4 lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00018DE0 File Offset: 0x00016FE0
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x57AE7D0", Offset = "0x57AD3D0", VA = "0x1857AE7D0")]
		[MethodImpl(256)]
		public static float2x4 operator +(float2x4 lhs, float rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00018DF8 File Offset: 0x00016FF8
		[Token(Token = "0x6001118")]
		[Address(RVA = "0x57AE850", Offset = "0x57AD450", VA = "0x1857AE850")]
		[MethodImpl(256)]
		public static float2x4 operator +(float lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00018E10 File Offset: 0x00017010
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x57B0090", Offset = "0x57AEC90", VA = "0x1857B0090")]
		[MethodImpl(256)]
		public static float2x4 operator -(float2x4 lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00018E28 File Offset: 0x00017028
		[Token(Token = "0x600111A")]
		[Address(RVA = "0x57B0010", Offset = "0x57AEC10", VA = "0x1857B0010")]
		[MethodImpl(256)]
		public static float2x4 operator -(float2x4 lhs, float rhs)
		{
			return default(float2x4);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00018E40 File Offset: 0x00017040
		[Token(Token = "0x600111B")]
		[Address(RVA = "0x57B0140", Offset = "0x57AED40", VA = "0x1857B0140")]
		[MethodImpl(256)]
		public static float2x4 operator -(float lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00018E58 File Offset: 0x00017058
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x57AEA40", Offset = "0x57AD640", VA = "0x1857AEA40")]
		[MethodImpl(256)]
		public static float2x4 operator /(float2x4 lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00018E70 File Offset: 0x00017070
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x57AEAF0", Offset = "0x57AD6F0", VA = "0x1857AEAF0")]
		[MethodImpl(256)]
		public static float2x4 operator /(float2x4 lhs, float rhs)
		{
			return default(float2x4);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00018E88 File Offset: 0x00017088
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x57AE9A0", Offset = "0x57AD5A0", VA = "0x1857AE9A0")]
		[MethodImpl(256)]
		public static float2x4 operator /(float lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00018EA0 File Offset: 0x000170A0
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x57AFBE0", Offset = "0x57AE7E0", VA = "0x1857AFBE0")]
		[MethodImpl(256)]
		public static float2x4 operator %(float2x4 lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00018EB8 File Offset: 0x000170B8
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x57AFD20", Offset = "0x57AE920", VA = "0x1857AFD20")]
		[MethodImpl(256)]
		public static float2x4 operator %(float2x4 lhs, float rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00018ED0 File Offset: 0x000170D0
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x57AFAA0", Offset = "0x57AE6A0", VA = "0x1857AFAA0")]
		[MethodImpl(256)]
		public static float2x4 operator %(float lhs, float2x4 rhs)
		{
			return default(float2x4);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00018EE8 File Offset: 0x000170E8
		[Token(Token = "0x6001122")]
		[Address(RVA = "0x57AF2D0", Offset = "0x57ADED0", VA = "0x1857AF2D0")]
		[MethodImpl(256)]
		public static float2x4 operator ++(float2x4 val)
		{
			return default(float2x4);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00018F00 File Offset: 0x00017100
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x57AE8D0", Offset = "0x57AD4D0", VA = "0x1857AE8D0")]
		[MethodImpl(256)]
		public static float2x4 operator --(float2x4 val)
		{
			return default(float2x4);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00018F18 File Offset: 0x00017118
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x57AF9E0", Offset = "0x57AE5E0", VA = "0x1857AF9E0")]
		[MethodImpl(256)]
		public static bool2x4 operator <(float2x4 lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00018F30 File Offset: 0x00017130
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x57AF950", Offset = "0x57AE550", VA = "0x1857AF950")]
		[MethodImpl(256)]
		public static bool2x4 operator <(float2x4 lhs, float rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00018F48 File Offset: 0x00017148
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x57AF8A0", Offset = "0x57AE4A0", VA = "0x1857AF8A0")]
		[MethodImpl(256)]
		public static bool2x4 operator <(float lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00018F60 File Offset: 0x00017160
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x57AF7E0", Offset = "0x57AE3E0", VA = "0x1857AF7E0")]
		[MethodImpl(256)]
		public static bool2x4 operator <=(float2x4 lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00018F78 File Offset: 0x00017178
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x57AF6A0", Offset = "0x57AE2A0", VA = "0x1857AF6A0")]
		[MethodImpl(256)]
		public static bool2x4 operator <=(float2x4 lhs, float rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00018F90 File Offset: 0x00017190
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x57AF730", Offset = "0x57AE330", VA = "0x1857AF730")]
		[MethodImpl(256)]
		public static bool2x4 operator <=(float lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00018FA8 File Offset: 0x000171A8
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x57AF0D0", Offset = "0x57ADCD0", VA = "0x1857AF0D0")]
		[MethodImpl(256)]
		public static bool2x4 operator >(float2x4 lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00018FC0 File Offset: 0x000171C0
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x57AF220", Offset = "0x57ADE20", VA = "0x1857AF220")]
		[MethodImpl(256)]
		public static bool2x4 operator >(float2x4 lhs, float rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00018FD8 File Offset: 0x000171D8
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x57AF190", Offset = "0x57ADD90", VA = "0x1857AF190")]
		[MethodImpl(256)]
		public static bool2x4 operator >(float lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00018FF0 File Offset: 0x000171F0
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x57AF010", Offset = "0x57ADC10", VA = "0x1857AF010")]
		[MethodImpl(256)]
		public static bool2x4 operator >=(float2x4 lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00019008 File Offset: 0x00017208
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x57AEED0", Offset = "0x57ADAD0", VA = "0x1857AEED0")]
		[MethodImpl(256)]
		public static bool2x4 operator >=(float2x4 lhs, float rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00019020 File Offset: 0x00017220
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x57AEF80", Offset = "0x57ADB80", VA = "0x1857AEF80")]
		[MethodImpl(256)]
		public static bool2x4 operator >=(float lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00019038 File Offset: 0x00017238
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x57B01E0", Offset = "0x57AEDE0", VA = "0x1857B01E0")]
		[MethodImpl(256)]
		public static float2x4 operator -(float2x4 val)
		{
			return default(float2x4);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00019050 File Offset: 0x00017250
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x57B0260", Offset = "0x57AEE60", VA = "0x1857B0260")]
		[MethodImpl(256)]
		public static float2x4 operator +(float2x4 val)
		{
			return default(float2x4);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00019068 File Offset: 0x00017268
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x57AEB70", Offset = "0x57AD770", VA = "0x1857AEB70")]
		[MethodImpl(256)]
		public static bool2x4 operator ==(float2x4 lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00019080 File Offset: 0x00017280
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x57AEC90", Offset = "0x57AD890", VA = "0x1857AEC90")]
		[MethodImpl(256)]
		public static bool2x4 operator ==(float2x4 lhs, float rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00019098 File Offset: 0x00017298
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x57AED90", Offset = "0x57AD990", VA = "0x1857AED90")]
		[MethodImpl(256)]
		public static bool2x4 operator ==(float lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x000190B0 File Offset: 0x000172B0
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x57AF4A0", Offset = "0x57AE0A0", VA = "0x1857AF4A0")]
		[MethodImpl(256)]
		public static bool2x4 operator !=(float2x4 lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000190C8 File Offset: 0x000172C8
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x57AF3A0", Offset = "0x57ADFA0", VA = "0x1857AF3A0")]
		[MethodImpl(256)]
		public static bool2x4 operator !=(float2x4 lhs, float rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x000190E0 File Offset: 0x000172E0
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x57AF5C0", Offset = "0x57AE1C0", VA = "0x1857AF5C0")]
		[MethodImpl(256)]
		public static bool2x4 operator !=(float lhs, float2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x170003FA RID: 1018
		[Token(Token = "0x170003FA")]
		public float2 this[int index]
		{
			[Token(Token = "0x6001138")]
			[Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x000190F8 File Offset: 0x000172F8
		[Token(Token = "0x6001139")]
		[Address(RVA = "0x57A6AD0", Offset = "0x57A56D0", VA = "0x1857A6AD0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float2x4 rhs)
		{
			return default(bool);
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00019110 File Offset: 0x00017310
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x57ADC50", Offset = "0x57AC850", VA = "0x1857ADC50", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00019128 File Offset: 0x00017328
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x57ADCF0", Offset = "0x57AC8F0", VA = "0x1857ADCF0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x57AE0A0", Offset = "0x57ACCA0", VA = "0x1857AE0A0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x57ADD20", Offset = "0x57AC920", VA = "0x1857ADD20", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x0")]
		public float2 c0;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x8")]
		public float2 c1;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x10")]
		public float2 c2;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x18")]
		public float2 c3;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float2x4 zero;
	}
}
