using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(float4.DebuggerProxy))]
	[Serializable]
	public struct float4 : IEquatable<float4>, IFormattable
	{
		// Token: 0x060012E0 RID: 4832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		[MethodImpl(256)]
		public float4(float x, float y, float z, float w)
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x57C0230", Offset = "0x57BEE30", VA = "0x1857C0230")]
		[MethodImpl(256)]
		public float4(float x, float y, float2 zw)
		{
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x57C03C0", Offset = "0x57BEFC0", VA = "0x1857C03C0")]
		[MethodImpl(256)]
		public float4(float x, float2 yz, float w)
		{
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x57C03F0", Offset = "0x57BEFF0", VA = "0x1857C03F0")]
		[MethodImpl(256)]
		public float4(float x, float3 yzw)
		{
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x57C01D0", Offset = "0x57BEDD0", VA = "0x1857C01D0")]
		[MethodImpl(256)]
		public float4(float2 xy, float z, float w)
		{
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x57C0100", Offset = "0x57BED00", VA = "0x1857C0100")]
		[MethodImpl(256)]
		public float4(float2 xy, float2 zw)
		{
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x57C01B0", Offset = "0x57BEDB0", VA = "0x1857C01B0")]
		[MethodImpl(256)]
		public float4(float3 xyz, float w)
		{
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
		[MethodImpl(256)]
		public float4(float4 xyzw)
		{
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x57C0160", Offset = "0x57BED60", VA = "0x1857C0160")]
		[MethodImpl(256)]
		public float4(float v)
		{
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x57C0260", Offset = "0x57BEE60", VA = "0x1857C0260")]
		[MethodImpl(256)]
		public float4(bool v)
		{
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x57C0320", Offset = "0x57BEF20", VA = "0x1857C0320")]
		[MethodImpl(256)]
		public float4(bool4 v)
		{
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x57C02A0", Offset = "0x57BEEA0", VA = "0x1857C02A0")]
		[MethodImpl(256)]
		public float4(int v)
		{
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x57C0380", Offset = "0x57BEF80", VA = "0x1857C0380")]
		[MethodImpl(256)]
		public float4(int4 v)
		{
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x57C0140", Offset = "0x57BED40", VA = "0x1857C0140")]
		[MethodImpl(256)]
		public float4(uint v)
		{
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x57C02B0", Offset = "0x57BEEB0", VA = "0x1857C02B0")]
		[MethodImpl(256)]
		public float4(uint4 v)
		{
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x56FE000", Offset = "0x56FCC00", VA = "0x1856FE000")]
		[MethodImpl(256)]
		public float4(half v)
		{
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x56FDE40", Offset = "0x56FCA40", VA = "0x1856FDE40")]
		[MethodImpl(256)]
		public float4(half4 v)
		{
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x57C0200", Offset = "0x57BEE00", VA = "0x1857C0200")]
		[MethodImpl(256)]
		public float4(double v)
		{
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x57C0170", Offset = "0x57BED70", VA = "0x1857C0170")]
		[MethodImpl(256)]
		public float4(double4 v)
		{
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0001B150 File Offset: 0x00019350
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x5718780", Offset = "0x5717380", VA = "0x185718780")]
		[MethodImpl(256)]
		public static implicit operator float4(float v)
		{
			return default(float4);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0001B168 File Offset: 0x00019368
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x5718A80", Offset = "0x5717680", VA = "0x185718A80")]
		[MethodImpl(256)]
		public static explicit operator float4(bool v)
		{
			return default(float4);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0001B180 File Offset: 0x00019380
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x5718720", Offset = "0x5717320", VA = "0x185718720")]
		[MethodImpl(256)]
		public static explicit operator float4(bool4 v)
		{
			return default(float4);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0001B198 File Offset: 0x00019398
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x57189B0", Offset = "0x57175B0", VA = "0x1857189B0")]
		[MethodImpl(256)]
		public static implicit operator float4(int v)
		{
			return default(float4);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x5718A20", Offset = "0x5717620", VA = "0x185718A20")]
		[MethodImpl(256)]
		public static implicit operator float4(int4 v)
		{
			return default(float4);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0001B1C8 File Offset: 0x000193C8
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x5718A00", Offset = "0x5717600", VA = "0x185718A00")]
		[MethodImpl(256)]
		public static implicit operator float4(uint v)
		{
			return default(float4);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0001B1E0 File Offset: 0x000193E0
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x5718B40", Offset = "0x5717740", VA = "0x185718B40")]
		[MethodImpl(256)]
		public static implicit operator float4(uint4 v)
		{
			return default(float4);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0001B1F8 File Offset: 0x000193F8
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x57C1ED0", Offset = "0x57C0AD0", VA = "0x1857C1ED0")]
		[MethodImpl(256)]
		public static implicit operator float4(half v)
		{
			return default(float4);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0001B210 File Offset: 0x00019410
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x5718790", Offset = "0x5717390", VA = "0x185718790")]
		[MethodImpl(256)]
		public static implicit operator float4(half4 v)
		{
			return default(float4);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0001B228 File Offset: 0x00019428
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x56FE1A0", Offset = "0x56FCDA0", VA = "0x1856FE1A0")]
		[MethodImpl(256)]
		public static explicit operator float4(double v)
		{
			return default(float4);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0001B240 File Offset: 0x00019440
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x57186D0", Offset = "0x57172D0", VA = "0x1857186D0")]
		[MethodImpl(256)]
		public static explicit operator float4(double4 v)
		{
			return default(float4);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0001B258 File Offset: 0x00019458
		[Token(Token = "0x60012FE")]
		[Address(RVA = "0x57C22C0", Offset = "0x57C0EC0", VA = "0x1857C22C0")]
		[MethodImpl(256)]
		public static float4 operator *(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0001B270 File Offset: 0x00019470
		[Token(Token = "0x60012FF")]
		[Address(RVA = "0x56FE1D0", Offset = "0x56FCDD0", VA = "0x1856FE1D0")]
		[MethodImpl(256)]
		public static float4 operator *(float4 lhs, float rhs)
		{
			return default(float4);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0001B288 File Offset: 0x00019488
		[Token(Token = "0x6001300")]
		[Address(RVA = "0x57C2310", Offset = "0x57C0F10", VA = "0x1857C2310")]
		[MethodImpl(256)]
		public static float4 operator *(float lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0001B2A0 File Offset: 0x000194A0
		[Token(Token = "0x6001301")]
		[Address(RVA = "0x57C1AE0", Offset = "0x57C06E0", VA = "0x1857C1AE0")]
		[MethodImpl(256)]
		public static float4 operator +(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0001B2B8 File Offset: 0x000194B8
		[Token(Token = "0x6001302")]
		[Address(RVA = "0x57C1B30", Offset = "0x57C0730", VA = "0x1857C1B30")]
		[MethodImpl(256)]
		public static float4 operator +(float4 lhs, float rhs)
		{
			return default(float4);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0001B2D0 File Offset: 0x000194D0
		[Token(Token = "0x6001303")]
		[Address(RVA = "0x57C1AC0", Offset = "0x57C06C0", VA = "0x1857C1AC0")]
		[MethodImpl(256)]
		public static float4 operator +(float lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0001B2E8 File Offset: 0x000194E8
		[Token(Token = "0x6001304")]
		[Address(RVA = "0x57C2350", Offset = "0x57C0F50", VA = "0x1857C2350")]
		[MethodImpl(256)]
		public static float4 operator -(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0001B300 File Offset: 0x00019500
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x57C2330", Offset = "0x57C0F30", VA = "0x1857C2330")]
		[MethodImpl(256)]
		public static float4 operator -(float4 lhs, float rhs)
		{
			return default(float4);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0001B318 File Offset: 0x00019518
		[Token(Token = "0x6001306")]
		[Address(RVA = "0x56FE1F0", Offset = "0x56FCDF0", VA = "0x1856FE1F0")]
		[MethodImpl(256)]
		public static float4 operator -(float lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0001B330 File Offset: 0x00019530
		[Token(Token = "0x6001307")]
		[Address(RVA = "0x57C1B70", Offset = "0x57C0770", VA = "0x1857C1B70")]
		[MethodImpl(256)]
		public static float4 operator /(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0001B348 File Offset: 0x00019548
		[Token(Token = "0x6001308")]
		[Address(RVA = "0x57C1C00", Offset = "0x57C0800", VA = "0x1857C1C00")]
		[MethodImpl(256)]
		public static float4 operator /(float4 lhs, float rhs)
		{
			return default(float4);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0001B360 File Offset: 0x00019560
		[Token(Token = "0x6001309")]
		[Address(RVA = "0x57C1BC0", Offset = "0x57C07C0", VA = "0x1857C1BC0")]
		[MethodImpl(256)]
		public static float4 operator /(float lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0001B378 File Offset: 0x00019578
		[Token(Token = "0x600130A")]
		[Address(RVA = "0x571A700", Offset = "0x5719300", VA = "0x18571A700")]
		[MethodImpl(256)]
		public static float4 operator %(float4 lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0001B390 File Offset: 0x00019590
		[Token(Token = "0x600130B")]
		[Address(RVA = "0x57C21C0", Offset = "0x57C0DC0", VA = "0x1857C21C0")]
		[MethodImpl(256)]
		public static float4 operator %(float4 lhs, float rhs)
		{
			return default(float4);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[Token(Token = "0x600130C")]
		[Address(RVA = "0x57C2240", Offset = "0x57C0E40", VA = "0x1857C2240")]
		[MethodImpl(256)]
		public static float4 operator %(float lhs, float4 rhs)
		{
			return default(float4);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0001B3C0 File Offset: 0x000195C0
		[Token(Token = "0x600130D")]
		[Address(RVA = "0x57C1EF0", Offset = "0x57C0AF0", VA = "0x1857C1EF0")]
		[MethodImpl(256)]
		public static float4 operator ++(float4 val)
		{
			return default(float4);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0001B3D8 File Offset: 0x000195D8
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x57C1B50", Offset = "0x57C0750", VA = "0x1857C1B50")]
		[MethodImpl(256)]
		public static float4 operator --(float4 val)
		{
			return default(float4);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0001B3F0 File Offset: 0x000195F0
		[Token(Token = "0x600130F")]
		[Address(RVA = "0x57C2180", Offset = "0x57C0D80", VA = "0x1857C2180")]
		[MethodImpl(256)]
		public static bool4 operator <(float4 lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0001B408 File Offset: 0x00019608
		[Token(Token = "0x6001310")]
		[Address(RVA = "0x57C2110", Offset = "0x57C0D10", VA = "0x1857C2110")]
		[MethodImpl(256)]
		public static bool4 operator <(float4 lhs, float rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0001B420 File Offset: 0x00019620
		[Token(Token = "0x6001311")]
		[Address(RVA = "0x57C2140", Offset = "0x57C0D40", VA = "0x1857C2140")]
		[MethodImpl(256)]
		public static bool4 operator <(float lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0001B438 File Offset: 0x00019638
		[Token(Token = "0x6001312")]
		[Address(RVA = "0x57C2060", Offset = "0x57C0C60", VA = "0x1857C2060")]
		[MethodImpl(256)]
		public static bool4 operator <=(float4 lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0001B450 File Offset: 0x00019650
		[Token(Token = "0x6001313")]
		[Address(RVA = "0x57C20E0", Offset = "0x57C0CE0", VA = "0x1857C20E0")]
		[MethodImpl(256)]
		public static bool4 operator <=(float4 lhs, float rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0001B468 File Offset: 0x00019668
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x57C20A0", Offset = "0x57C0CA0", VA = "0x1857C20A0")]
		[MethodImpl(256)]
		public static bool4 operator <=(float lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0001B480 File Offset: 0x00019680
		[Token(Token = "0x6001315")]
		[Address(RVA = "0x57C1E20", Offset = "0x57C0A20", VA = "0x1857C1E20")]
		[MethodImpl(256)]
		public static bool4 operator >(float4 lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0001B498 File Offset: 0x00019698
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x57C1E60", Offset = "0x57C0A60", VA = "0x1857C1E60")]
		[MethodImpl(256)]
		public static bool4 operator >(float4 lhs, float rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0001B4B0 File Offset: 0x000196B0
		[Token(Token = "0x6001317")]
		[Address(RVA = "0x57C1EA0", Offset = "0x57C0AA0", VA = "0x1857C1EA0")]
		[MethodImpl(256)]
		public static bool4 operator >(float lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0001B4C8 File Offset: 0x000196C8
		[Token(Token = "0x6001318")]
		[Address(RVA = "0x57C1DE0", Offset = "0x57C09E0", VA = "0x1857C1DE0")]
		[MethodImpl(256)]
		public static bool4 operator >=(float4 lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0001B4E0 File Offset: 0x000196E0
		[Token(Token = "0x6001319")]
		[Address(RVA = "0x57C1D70", Offset = "0x57C0970", VA = "0x1857C1D70")]
		[MethodImpl(256)]
		public static bool4 operator >=(float4 lhs, float rhs)
		{
			return default(bool4);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0001B4F8 File Offset: 0x000196F8
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x57C1DB0", Offset = "0x57C09B0", VA = "0x1857C1DB0")]
		[MethodImpl(256)]
		public static bool4 operator >=(float lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0001B510 File Offset: 0x00019710
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x57C23A0", Offset = "0x57C0FA0", VA = "0x1857C23A0")]
		[MethodImpl(256)]
		public static float4 operator -(float4 val)
		{
			return default(float4);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0001B528 File Offset: 0x00019728
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
		[MethodImpl(256)]
		public static float4 operator +(float4 val)
		{
			return default(float4);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0001B540 File Offset: 0x00019740
		[Token(Token = "0x600131D")]
		[Address(RVA = "0x57C1D00", Offset = "0x57C0900", VA = "0x1857C1D00")]
		[MethodImpl(256)]
		public static bool4 operator ==(float4 lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0001B558 File Offset: 0x00019758
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x57C1C80", Offset = "0x57C0880", VA = "0x1857C1C80")]
		[MethodImpl(256)]
		public static bool4 operator ==(float4 lhs, float rhs)
		{
			return default(bool4);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0001B570 File Offset: 0x00019770
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x57C1C20", Offset = "0x57C0820", VA = "0x1857C1C20")]
		[MethodImpl(256)]
		public static bool4 operator ==(float lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0001B588 File Offset: 0x00019788
		[Token(Token = "0x6001320")]
		[Address(RVA = "0x57C1F10", Offset = "0x57C0B10", VA = "0x1857C1F10")]
		[MethodImpl(256)]
		public static bool4 operator !=(float4 lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0001B5A0 File Offset: 0x000197A0
		[Token(Token = "0x6001321")]
		[Address(RVA = "0x57C1FE0", Offset = "0x57C0BE0", VA = "0x1857C1FE0")]
		[MethodImpl(256)]
		public static bool4 operator !=(float4 lhs, float rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0001B5B8 File Offset: 0x000197B8
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x57C1F80", Offset = "0x57C0B80", VA = "0x1857C1F80")]
		[MethodImpl(256)]
		public static bool4 operator !=(float lhs, float4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x0001B5D0 File Offset: 0x000197D0
		[Token(Token = "0x17000474")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxx
		{
			[Token(Token = "0x6001323")]
			[Address(RVA = "0x57A9BA0", Offset = "0x57A87A0", VA = "0x1857A9BA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0001B5E8 File Offset: 0x000197E8
		[Token(Token = "0x17000475")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxy
		{
			[Token(Token = "0x6001324")]
			[Address(RVA = "0x57A9BB0", Offset = "0x57A87B0", VA = "0x1857A9BB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x0001B600 File Offset: 0x00019800
		[Token(Token = "0x17000476")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxz
		{
			[Token(Token = "0x6001325")]
			[Address(RVA = "0x57B0710", Offset = "0x57AF310", VA = "0x1857B0710")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0001B618 File Offset: 0x00019818
		[Token(Token = "0x17000477")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxw
		{
			[Token(Token = "0x6001326")]
			[Address(RVA = "0x57C1020", Offset = "0x57BFC20", VA = "0x1857C1020")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x0001B630 File Offset: 0x00019830
		[Token(Token = "0x17000478")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyx
		{
			[Token(Token = "0x6001327")]
			[Address(RVA = "0x57A9BF0", Offset = "0x57A87F0", VA = "0x1857A9BF0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0001B648 File Offset: 0x00019848
		[Token(Token = "0x17000479")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyy
		{
			[Token(Token = "0x6001328")]
			[Address(RVA = "0x57A9C10", Offset = "0x57A8810", VA = "0x1857A9C10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x0001B660 File Offset: 0x00019860
		[Token(Token = "0x1700047A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyz
		{
			[Token(Token = "0x6001329")]
			[Address(RVA = "0x57B0730", Offset = "0x57AF330", VA = "0x1857B0730")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x0001B678 File Offset: 0x00019878
		[Token(Token = "0x1700047B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyw
		{
			[Token(Token = "0x600132A")]
			[Address(RVA = "0x57C1040", Offset = "0x57BFC40", VA = "0x1857C1040")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0001B690 File Offset: 0x00019890
		[Token(Token = "0x1700047C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzx
		{
			[Token(Token = "0x600132B")]
			[Address(RVA = "0x57B0770", Offset = "0x57AF370", VA = "0x1857B0770")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0001B6A8 File Offset: 0x000198A8
		[Token(Token = "0x1700047D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzy
		{
			[Token(Token = "0x600132C")]
			[Address(RVA = "0x57B0790", Offset = "0x57AF390", VA = "0x1857B0790")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0001B6C0 File Offset: 0x000198C0
		[Token(Token = "0x1700047E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzz
		{
			[Token(Token = "0x600132D")]
			[Address(RVA = "0x57B07B0", Offset = "0x57AF3B0", VA = "0x1857B07B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0001B6D8 File Offset: 0x000198D8
		[Token(Token = "0x1700047F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzw
		{
			[Token(Token = "0x600132E")]
			[Address(RVA = "0x57C1060", Offset = "0x57BFC60", VA = "0x1857C1060")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0001B6F0 File Offset: 0x000198F0
		[Token(Token = "0x17000480")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxwx
		{
			[Token(Token = "0x600132F")]
			[Address(RVA = "0x57C0FC0", Offset = "0x57BFBC0", VA = "0x1857C0FC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0001B708 File Offset: 0x00019908
		[Token(Token = "0x17000481")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxwy
		{
			[Token(Token = "0x6001330")]
			[Address(RVA = "0x57C0FE0", Offset = "0x57BFBE0", VA = "0x1857C0FE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0001B720 File Offset: 0x00019920
		[Token(Token = "0x17000482")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxwz
		{
			[Token(Token = "0x6001331")]
			[Address(RVA = "0x57C1000", Offset = "0x57BFC00", VA = "0x1857C1000")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0001B738 File Offset: 0x00019938
		[Token(Token = "0x17000483")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxww
		{
			[Token(Token = "0x6001332")]
			[Address(RVA = "0x57C0FA0", Offset = "0x57BFBA0", VA = "0x1857C0FA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x0001B750 File Offset: 0x00019950
		[Token(Token = "0x17000484")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxx
		{
			[Token(Token = "0x6001333")]
			[Address(RVA = "0x57A9C50", Offset = "0x57A8850", VA = "0x1857A9C50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0001B768 File Offset: 0x00019968
		[Token(Token = "0x17000485")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy
		{
			[Token(Token = "0x6001334")]
			[Address(RVA = "0x57A9C70", Offset = "0x57A8870", VA = "0x1857A9C70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0001B780 File Offset: 0x00019980
		[Token(Token = "0x17000486")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxz
		{
			[Token(Token = "0x6001335")]
			[Address(RVA = "0x57B07D0", Offset = "0x57AF3D0", VA = "0x1857B07D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0001B798 File Offset: 0x00019998
		[Token(Token = "0x17000487")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxw
		{
			[Token(Token = "0x6001336")]
			[Address(RVA = "0x57C10E0", Offset = "0x57BFCE0", VA = "0x1857C10E0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0001B7B0 File Offset: 0x000199B0
		[Token(Token = "0x17000488")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyx
		{
			[Token(Token = "0x6001337")]
			[Address(RVA = "0x57A9CB0", Offset = "0x57A88B0", VA = "0x1857A9CB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x0001B7C8 File Offset: 0x000199C8
		[Token(Token = "0x17000489")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyy
		{
			[Token(Token = "0x6001338")]
			[Address(RVA = "0x57A9CD0", Offset = "0x57A88D0", VA = "0x1857A9CD0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x0001B7E0 File Offset: 0x000199E0
		[Token(Token = "0x1700048A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyz
		{
			[Token(Token = "0x6001339")]
			[Address(RVA = "0x57B07F0", Offset = "0x57AF3F0", VA = "0x1857B07F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0001B7F8 File Offset: 0x000199F8
		[Token(Token = "0x1700048B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyw
		{
			[Token(Token = "0x600133A")]
			[Address(RVA = "0x57C1100", Offset = "0x57BFD00", VA = "0x1857C1100")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0001B810 File Offset: 0x00019A10
		[Token(Token = "0x1700048C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx
		{
			[Token(Token = "0x600133B")]
			[Address(RVA = "0x57B0810", Offset = "0x57AF410", VA = "0x1857B0810")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0001B828 File Offset: 0x00019A28
		[Token(Token = "0x1700048D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzy
		{
			[Token(Token = "0x600133C")]
			[Address(RVA = "0x57B0830", Offset = "0x57AF430", VA = "0x1857B0830")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x0001B840 File Offset: 0x00019A40
		[Token(Token = "0x1700048E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzz
		{
			[Token(Token = "0x600133D")]
			[Address(RVA = "0x57B0850", Offset = "0x57AF450", VA = "0x1857B0850")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x0001B858 File Offset: 0x00019A58
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzw
		{
			[Token(Token = "0x600133E")]
			[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x600133F")]
			[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x0001B870 File Offset: 0x00019A70
		[Token(Token = "0x17000490")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xywx
		{
			[Token(Token = "0x6001340")]
			[Address(RVA = "0x57C10A0", Offset = "0x57BFCA0", VA = "0x1857C10A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x0001B888 File Offset: 0x00019A88
		[Token(Token = "0x17000491")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xywy
		{
			[Token(Token = "0x6001341")]
			[Address(RVA = "0x57C10C0", Offset = "0x57BFCC0", VA = "0x1857C10C0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0001B8A0 File Offset: 0x00019AA0
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000492")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xywz
		{
			[Token(Token = "0x6001342")]
			[Address(RVA = "0x576B320", Offset = "0x5769F20", VA = "0x18576B320")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x6001343")]
			[Address(RVA = "0x576D850", Offset = "0x576C450", VA = "0x18576D850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		[Token(Token = "0x17000493")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyww
		{
			[Token(Token = "0x6001344")]
			[Address(RVA = "0x57C1080", Offset = "0x57BFC80", VA = "0x1857C1080")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x0001B8D0 File Offset: 0x00019AD0
		[Token(Token = "0x17000494")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxx
		{
			[Token(Token = "0x6001345")]
			[Address(RVA = "0x57B08B0", Offset = "0x57AF4B0", VA = "0x1857B08B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		[Token(Token = "0x17000495")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxy
		{
			[Token(Token = "0x6001346")]
			[Address(RVA = "0x57B08D0", Offset = "0x57AF4D0", VA = "0x1857B08D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x0001B900 File Offset: 0x00019B00
		[Token(Token = "0x17000496")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxz
		{
			[Token(Token = "0x6001347")]
			[Address(RVA = "0x57B08F0", Offset = "0x57AF4F0", VA = "0x1857B08F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0001B918 File Offset: 0x00019B18
		[Token(Token = "0x17000497")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxw
		{
			[Token(Token = "0x6001348")]
			[Address(RVA = "0x57C1180", Offset = "0x57BFD80", VA = "0x1857C1180")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0001B930 File Offset: 0x00019B30
		[Token(Token = "0x17000498")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyx
		{
			[Token(Token = "0x6001349")]
			[Address(RVA = "0x57B0910", Offset = "0x57AF510", VA = "0x1857B0910")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0001B948 File Offset: 0x00019B48
		[Token(Token = "0x17000499")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyy
		{
			[Token(Token = "0x600134A")]
			[Address(RVA = "0x57B0930", Offset = "0x57AF530", VA = "0x1857B0930")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x0001B960 File Offset: 0x00019B60
		[Token(Token = "0x1700049A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyz
		{
			[Token(Token = "0x600134B")]
			[Address(RVA = "0x57B0950", Offset = "0x57AF550", VA = "0x1857B0950")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x0001B978 File Offset: 0x00019B78
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyw
		{
			[Token(Token = "0x600134C")]
			[Address(RVA = "0x576B6A0", Offset = "0x576A2A0", VA = "0x18576B6A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x600134D")]
			[Address(RVA = "0x576D8E0", Offset = "0x576C4E0", VA = "0x18576D8E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0001B990 File Offset: 0x00019B90
		[Token(Token = "0x1700049C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzx
		{
			[Token(Token = "0x600134E")]
			[Address(RVA = "0x57B0990", Offset = "0x57AF590", VA = "0x1857B0990")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x0001B9A8 File Offset: 0x00019BA8
		[Token(Token = "0x1700049D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzy
		{
			[Token(Token = "0x600134F")]
			[Address(RVA = "0x57B09B0", Offset = "0x57AF5B0", VA = "0x1857B09B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		[Token(Token = "0x1700049E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzz
		{
			[Token(Token = "0x6001350")]
			[Address(RVA = "0x57B09D0", Offset = "0x57AF5D0", VA = "0x1857B09D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x0001B9D8 File Offset: 0x00019BD8
		[Token(Token = "0x1700049F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzw
		{
			[Token(Token = "0x6001351")]
			[Address(RVA = "0x57C11A0", Offset = "0x57BFDA0", VA = "0x1857C11A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		[Token(Token = "0x170004A0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzwx
		{
			[Token(Token = "0x6001352")]
			[Address(RVA = "0x57C1140", Offset = "0x57BFD40", VA = "0x1857C1140")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x0001BA08 File Offset: 0x00019C08
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzwy
		{
			[Token(Token = "0x6001353")]
			[Address(RVA = "0x576B5A0", Offset = "0x576A1A0", VA = "0x18576B5A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x6001354")]
			[Address(RVA = "0x576D8A0", Offset = "0x576C4A0", VA = "0x18576D8A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x0001BA20 File Offset: 0x00019C20
		[Token(Token = "0x170004A2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzwz
		{
			[Token(Token = "0x6001355")]
			[Address(RVA = "0x57C1160", Offset = "0x57BFD60", VA = "0x1857C1160")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x0001BA38 File Offset: 0x00019C38
		[Token(Token = "0x170004A3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzww
		{
			[Token(Token = "0x6001356")]
			[Address(RVA = "0x57C1120", Offset = "0x57BFD20", VA = "0x1857C1120")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x0001BA50 File Offset: 0x00019C50
		[Token(Token = "0x170004A4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwxx
		{
			[Token(Token = "0x6001357")]
			[Address(RVA = "0x57C0E60", Offset = "0x57BFA60", VA = "0x1857C0E60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0001BA68 File Offset: 0x00019C68
		[Token(Token = "0x170004A5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwxy
		{
			[Token(Token = "0x6001358")]
			[Address(RVA = "0x57C0E80", Offset = "0x57BFA80", VA = "0x1857C0E80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x0001BA80 File Offset: 0x00019C80
		[Token(Token = "0x170004A6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwxz
		{
			[Token(Token = "0x6001359")]
			[Address(RVA = "0x57C0EA0", Offset = "0x57BFAA0", VA = "0x1857C0EA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0001BA98 File Offset: 0x00019C98
		[Token(Token = "0x170004A7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwxw
		{
			[Token(Token = "0x600135A")]
			[Address(RVA = "0x57C0E40", Offset = "0x57BFA40", VA = "0x1857C0E40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x0001BAB0 File Offset: 0x00019CB0
		[Token(Token = "0x170004A8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwyx
		{
			[Token(Token = "0x600135B")]
			[Address(RVA = "0x57C0EE0", Offset = "0x57BFAE0", VA = "0x1857C0EE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		[Token(Token = "0x170004A9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwyy
		{
			[Token(Token = "0x600135C")]
			[Address(RVA = "0x57C0F00", Offset = "0x57BFB00", VA = "0x1857C0F00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwyz
		{
			[Token(Token = "0x600135D")]
			[Address(RVA = "0x576AF40", Offset = "0x5769B40", VA = "0x18576AF40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x600135E")]
			[Address(RVA = "0x576D7C0", Offset = "0x576C3C0", VA = "0x18576D7C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		[Token(Token = "0x170004AB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwyw
		{
			[Token(Token = "0x600135F")]
			[Address(RVA = "0x57C0EC0", Offset = "0x57BFAC0", VA = "0x1857C0EC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0001BB10 File Offset: 0x00019D10
		[Token(Token = "0x170004AC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwzx
		{
			[Token(Token = "0x6001360")]
			[Address(RVA = "0x57C0F40", Offset = "0x57BFB40", VA = "0x1857C0F40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0001BB28 File Offset: 0x00019D28
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwzy
		{
			[Token(Token = "0x6001361")]
			[Address(RVA = "0x576AFC0", Offset = "0x5769BC0", VA = "0x18576AFC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x6001362")]
			[Address(RVA = "0x576D800", Offset = "0x576C400", VA = "0x18576D800")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x0001BB40 File Offset: 0x00019D40
		[Token(Token = "0x170004AE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwzz
		{
			[Token(Token = "0x6001363")]
			[Address(RVA = "0x57C0F60", Offset = "0x57BFB60", VA = "0x1857C0F60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0001BB58 File Offset: 0x00019D58
		[Token(Token = "0x170004AF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwzw
		{
			[Token(Token = "0x6001364")]
			[Address(RVA = "0x57C0F20", Offset = "0x57BFB20", VA = "0x1857C0F20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x0001BB70 File Offset: 0x00019D70
		[Token(Token = "0x170004B0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwwx
		{
			[Token(Token = "0x6001365")]
			[Address(RVA = "0x57C0DC0", Offset = "0x57BF9C0", VA = "0x1857C0DC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0001BB88 File Offset: 0x00019D88
		[Token(Token = "0x170004B1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwwy
		{
			[Token(Token = "0x6001366")]
			[Address(RVA = "0x57C0DE0", Offset = "0x57BF9E0", VA = "0x1857C0DE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		[Token(Token = "0x170004B2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwwz
		{
			[Token(Token = "0x6001367")]
			[Address(RVA = "0x57C0E00", Offset = "0x57BFA00", VA = "0x1857C0E00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0001BBB8 File Offset: 0x00019DB8
		[Token(Token = "0x170004B3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xwww
		{
			[Token(Token = "0x6001368")]
			[Address(RVA = "0x57C0DA0", Offset = "0x57BF9A0", VA = "0x1857C0DA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[Token(Token = "0x170004B4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxx
		{
			[Token(Token = "0x6001369")]
			[Address(RVA = "0x57A9D30", Offset = "0x57A8930", VA = "0x1857A9D30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0001BBE8 File Offset: 0x00019DE8
		[Token(Token = "0x170004B5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy
		{
			[Token(Token = "0x600136A")]
			[Address(RVA = "0x57A9D50", Offset = "0x57A8950", VA = "0x1857A9D50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0001BC00 File Offset: 0x00019E00
		[Token(Token = "0x170004B6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxz
		{
			[Token(Token = "0x600136B")]
			[Address(RVA = "0x57B09F0", Offset = "0x57AF5F0", VA = "0x1857B09F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0001BC18 File Offset: 0x00019E18
		[Token(Token = "0x170004B7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxw
		{
			[Token(Token = "0x600136C")]
			[Address(RVA = "0x57C1460", Offset = "0x57C0060", VA = "0x1857C1460")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0001BC30 File Offset: 0x00019E30
		[Token(Token = "0x170004B8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyx
		{
			[Token(Token = "0x600136D")]
			[Address(RVA = "0x57A9D90", Offset = "0x57A8990", VA = "0x1857A9D90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0001BC48 File Offset: 0x00019E48
		[Token(Token = "0x170004B9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyy
		{
			[Token(Token = "0x600136E")]
			[Address(RVA = "0x57A9DB0", Offset = "0x57A89B0", VA = "0x1857A9DB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x0001BC60 File Offset: 0x00019E60
		[Token(Token = "0x170004BA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyz
		{
			[Token(Token = "0x600136F")]
			[Address(RVA = "0x57B0A10", Offset = "0x57AF610", VA = "0x1857B0A10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0001BC78 File Offset: 0x00019E78
		[Token(Token = "0x170004BB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyw
		{
			[Token(Token = "0x6001370")]
			[Address(RVA = "0x57C1480", Offset = "0x57C0080", VA = "0x1857C1480")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x0001BC90 File Offset: 0x00019E90
		[Token(Token = "0x170004BC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzx
		{
			[Token(Token = "0x6001371")]
			[Address(RVA = "0x57B0A30", Offset = "0x57AF630", VA = "0x1857B0A30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0001BCA8 File Offset: 0x00019EA8
		[Token(Token = "0x170004BD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzy
		{
			[Token(Token = "0x6001372")]
			[Address(RVA = "0x57B0A50", Offset = "0x57AF650", VA = "0x1857B0A50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		[Token(Token = "0x170004BE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzz
		{
			[Token(Token = "0x6001373")]
			[Address(RVA = "0x57B0A70", Offset = "0x57AF670", VA = "0x1857B0A70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzw
		{
			[Token(Token = "0x6001374")]
			[Address(RVA = "0x576BC80", Offset = "0x576A880", VA = "0x18576BC80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x6001375")]
			[Address(RVA = "0x576DA00", Offset = "0x576C600", VA = "0x18576DA00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0001BCF0 File Offset: 0x00019EF0
		[Token(Token = "0x170004C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxwx
		{
			[Token(Token = "0x6001376")]
			[Address(RVA = "0x57C1420", Offset = "0x57C0020", VA = "0x1857C1420")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x0001BD08 File Offset: 0x00019F08
		[Token(Token = "0x170004C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxwy
		{
			[Token(Token = "0x6001377")]
			[Address(RVA = "0x57C1440", Offset = "0x57C0040", VA = "0x1857C1440")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x0001BD20 File Offset: 0x00019F20
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxwz
		{
			[Token(Token = "0x6001378")]
			[Address(RVA = "0x576BB00", Offset = "0x576A700", VA = "0x18576BB00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x6001379")]
			[Address(RVA = "0x576D9C0", Offset = "0x576C5C0", VA = "0x18576D9C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x0001BD38 File Offset: 0x00019F38
		[Token(Token = "0x170004C3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxww
		{
			[Token(Token = "0x600137A")]
			[Address(RVA = "0x57C1400", Offset = "0x57C0000", VA = "0x1857C1400")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0001BD50 File Offset: 0x00019F50
		[Token(Token = "0x170004C4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxx
		{
			[Token(Token = "0x600137B")]
			[Address(RVA = "0x57A9E10", Offset = "0x57A8A10", VA = "0x1857A9E10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0001BD68 File Offset: 0x00019F68
		[Token(Token = "0x170004C5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxy
		{
			[Token(Token = "0x600137C")]
			[Address(RVA = "0x57A9E30", Offset = "0x57A8A30", VA = "0x1857A9E30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0001BD80 File Offset: 0x00019F80
		[Token(Token = "0x170004C6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxz
		{
			[Token(Token = "0x600137D")]
			[Address(RVA = "0x57B0A90", Offset = "0x57AF690", VA = "0x1857B0A90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x0001BD98 File Offset: 0x00019F98
		[Token(Token = "0x170004C7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxw
		{
			[Token(Token = "0x600137E")]
			[Address(RVA = "0x57C1550", Offset = "0x57C0150", VA = "0x1857C1550")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		[Token(Token = "0x170004C8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyx
		{
			[Token(Token = "0x600137F")]
			[Address(RVA = "0x57A9E70", Offset = "0x57A8A70", VA = "0x1857A9E70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0001BDC8 File Offset: 0x00019FC8
		[Token(Token = "0x170004C9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyy
		{
			[Token(Token = "0x6001380")]
			[Address(RVA = "0x57A9E90", Offset = "0x57A8A90", VA = "0x1857A9E90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		[Token(Token = "0x170004CA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyz
		{
			[Token(Token = "0x6001381")]
			[Address(RVA = "0x57B0AB0", Offset = "0x57AF6B0", VA = "0x1857B0AB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		[Token(Token = "0x170004CB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyw
		{
			[Token(Token = "0x6001382")]
			[Address(RVA = "0x57C1570", Offset = "0x57C0170", VA = "0x1857C1570")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0001BE10 File Offset: 0x0001A010
		[Token(Token = "0x170004CC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzx
		{
			[Token(Token = "0x6001383")]
			[Address(RVA = "0x57B0AF0", Offset = "0x57AF6F0", VA = "0x1857B0AF0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0001BE28 File Offset: 0x0001A028
		[Token(Token = "0x170004CD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzy
		{
			[Token(Token = "0x6001384")]
			[Address(RVA = "0x57B0B10", Offset = "0x57AF710", VA = "0x1857B0B10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0001BE40 File Offset: 0x0001A040
		[Token(Token = "0x170004CE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzz
		{
			[Token(Token = "0x6001385")]
			[Address(RVA = "0x57B0B30", Offset = "0x57AF730", VA = "0x1857B0B30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x0001BE58 File Offset: 0x0001A058
		[Token(Token = "0x170004CF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzw
		{
			[Token(Token = "0x6001386")]
			[Address(RVA = "0x57C1590", Offset = "0x57C0190", VA = "0x1857C1590")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0001BE70 File Offset: 0x0001A070
		[Token(Token = "0x170004D0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yywx
		{
			[Token(Token = "0x6001387")]
			[Address(RVA = "0x57C14F0", Offset = "0x57C00F0", VA = "0x1857C14F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x0001BE88 File Offset: 0x0001A088
		[Token(Token = "0x170004D1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yywy
		{
			[Token(Token = "0x6001388")]
			[Address(RVA = "0x57C1510", Offset = "0x57C0110", VA = "0x1857C1510")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0001BEA0 File Offset: 0x0001A0A0
		[Token(Token = "0x170004D2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yywz
		{
			[Token(Token = "0x6001389")]
			[Address(RVA = "0x57C1530", Offset = "0x57C0130", VA = "0x1857C1530")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		[Token(Token = "0x170004D3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyww
		{
			[Token(Token = "0x600138A")]
			[Address(RVA = "0x57C14C0", Offset = "0x57C00C0", VA = "0x1857C14C0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		[Token(Token = "0x170004D4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxx
		{
			[Token(Token = "0x600138B")]
			[Address(RVA = "0x57B0B60", Offset = "0x57AF760", VA = "0x1857B0B60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
		[Token(Token = "0x170004D5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy
		{
			[Token(Token = "0x600138C")]
			[Address(RVA = "0x57B0B80", Offset = "0x57AF780", VA = "0x1857B0B80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0001BF00 File Offset: 0x0001A100
		[Token(Token = "0x170004D6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz
		{
			[Token(Token = "0x600138D")]
			[Address(RVA = "0x57B0BA0", Offset = "0x57AF7A0", VA = "0x1857B0BA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x0001BF18 File Offset: 0x0001A118
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxw
		{
			[Token(Token = "0x600138E")]
			[Address(RVA = "0x576C070", Offset = "0x576AC70", VA = "0x18576C070")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x600138F")]
			[Address(RVA = "0x576DA90", Offset = "0x576C690", VA = "0x18576DA90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x0001BF30 File Offset: 0x0001A130
		[Token(Token = "0x170004D8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyx
		{
			[Token(Token = "0x6001390")]
			[Address(RVA = "0x57B0BE0", Offset = "0x57AF7E0", VA = "0x1857B0BE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0001BF48 File Offset: 0x0001A148
		[Token(Token = "0x170004D9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyy
		{
			[Token(Token = "0x6001391")]
			[Address(RVA = "0x57B0C00", Offset = "0x57AF800", VA = "0x1857B0C00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x0001BF60 File Offset: 0x0001A160
		[Token(Token = "0x170004DA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyz
		{
			[Token(Token = "0x6001392")]
			[Address(RVA = "0x57B0C20", Offset = "0x57AF820", VA = "0x1857B0C20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0001BF78 File Offset: 0x0001A178
		[Token(Token = "0x170004DB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyw
		{
			[Token(Token = "0x6001393")]
			[Address(RVA = "0x57C1610", Offset = "0x57C0210", VA = "0x1857C1610")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x0001BF90 File Offset: 0x0001A190
		[Token(Token = "0x170004DC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzx
		{
			[Token(Token = "0x6001394")]
			[Address(RVA = "0x57B0C70", Offset = "0x57AF870", VA = "0x1857B0C70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		[Token(Token = "0x170004DD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzy
		{
			[Token(Token = "0x6001395")]
			[Address(RVA = "0x57B0C90", Offset = "0x57AF890", VA = "0x1857B0C90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		[Token(Token = "0x170004DE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzz
		{
			[Token(Token = "0x6001396")]
			[Address(RVA = "0x57B0CC0", Offset = "0x57AF8C0", VA = "0x1857B0CC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		[Token(Token = "0x170004DF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzw
		{
			[Token(Token = "0x6001397")]
			[Address(RVA = "0x57C1630", Offset = "0x57C0230", VA = "0x1857C1630")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzwx
		{
			[Token(Token = "0x6001398")]
			[Address(RVA = "0x576BFF0", Offset = "0x576ABF0", VA = "0x18576BFF0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x6001399")]
			[Address(RVA = "0x576DA50", Offset = "0x576C650", VA = "0x18576DA50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0001C008 File Offset: 0x0001A208
		[Token(Token = "0x170004E1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzwy
		{
			[Token(Token = "0x600139A")]
			[Address(RVA = "0x57C15D0", Offset = "0x57C01D0", VA = "0x1857C15D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0001C020 File Offset: 0x0001A220
		[Token(Token = "0x170004E2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzwz
		{
			[Token(Token = "0x600139B")]
			[Address(RVA = "0x57C15F0", Offset = "0x57C01F0", VA = "0x1857C15F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0001C038 File Offset: 0x0001A238
		[Token(Token = "0x170004E3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzww
		{
			[Token(Token = "0x600139C")]
			[Address(RVA = "0x57C15B0", Offset = "0x57C01B0", VA = "0x1857C15B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x0001C050 File Offset: 0x0001A250
		[Token(Token = "0x170004E4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywxx
		{
			[Token(Token = "0x600139D")]
			[Address(RVA = "0x57C12B0", Offset = "0x57BFEB0", VA = "0x1857C12B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0001C068 File Offset: 0x0001A268
		[Token(Token = "0x170004E5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywxy
		{
			[Token(Token = "0x600139E")]
			[Address(RVA = "0x57C12D0", Offset = "0x57BFED0", VA = "0x1857C12D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x0001C080 File Offset: 0x0001A280
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywxz
		{
			[Token(Token = "0x600139F")]
			[Address(RVA = "0x576B900", Offset = "0x576A500", VA = "0x18576B900")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013A0")]
			[Address(RVA = "0x576D930", Offset = "0x576C530", VA = "0x18576D930")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0001C098 File Offset: 0x0001A298
		[Token(Token = "0x170004E7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywxw
		{
			[Token(Token = "0x60013A1")]
			[Address(RVA = "0x57C1290", Offset = "0x57BFE90", VA = "0x1857C1290")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		[Token(Token = "0x170004E8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywyx
		{
			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x57C1340", Offset = "0x57BFF40", VA = "0x1857C1340")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		[Token(Token = "0x170004E9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywyy
		{
			[Token(Token = "0x60013A3")]
			[Address(RVA = "0x57C1360", Offset = "0x57BFF60", VA = "0x1857C1360")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		[Token(Token = "0x170004EA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywyz
		{
			[Token(Token = "0x60013A4")]
			[Address(RVA = "0x57C1380", Offset = "0x57BFF80", VA = "0x1857C1380")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		[Token(Token = "0x170004EB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywyw
		{
			[Token(Token = "0x60013A5")]
			[Address(RVA = "0x57C1310", Offset = "0x57BFF10", VA = "0x1857C1310")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0001C110 File Offset: 0x0001A310
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywzx
		{
			[Token(Token = "0x60013A6")]
			[Address(RVA = "0x576BA00", Offset = "0x576A600", VA = "0x18576BA00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013A7")]
			[Address(RVA = "0x576D970", Offset = "0x576C570", VA = "0x18576D970")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0001C128 File Offset: 0x0001A328
		[Token(Token = "0x170004ED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywzy
		{
			[Token(Token = "0x60013A8")]
			[Address(RVA = "0x57C13C0", Offset = "0x57BFFC0", VA = "0x1857C13C0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0001C140 File Offset: 0x0001A340
		[Token(Token = "0x170004EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywzz
		{
			[Token(Token = "0x60013A9")]
			[Address(RVA = "0x57C13E0", Offset = "0x57BFFE0", VA = "0x1857C13E0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0001C158 File Offset: 0x0001A358
		[Token(Token = "0x170004EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywzw
		{
			[Token(Token = "0x60013AA")]
			[Address(RVA = "0x57C13A0", Offset = "0x57BFFA0", VA = "0x1857C13A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0001C170 File Offset: 0x0001A370
		[Token(Token = "0x170004F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywwx
		{
			[Token(Token = "0x60013AB")]
			[Address(RVA = "0x57C1220", Offset = "0x57BFE20", VA = "0x1857C1220")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0001C188 File Offset: 0x0001A388
		[Token(Token = "0x170004F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywwy
		{
			[Token(Token = "0x60013AC")]
			[Address(RVA = "0x57C1240", Offset = "0x57BFE40", VA = "0x1857C1240")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		[Token(Token = "0x170004F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywwz
		{
			[Token(Token = "0x60013AD")]
			[Address(RVA = "0x57C1270", Offset = "0x57BFE70", VA = "0x1857C1270")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		[Token(Token = "0x170004F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 ywww
		{
			[Token(Token = "0x60013AE")]
			[Address(RVA = "0x57C1200", Offset = "0x57BFE00", VA = "0x1857C1200")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		[Token(Token = "0x170004F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxx
		{
			[Token(Token = "0x60013AF")]
			[Address(RVA = "0x57B0D20", Offset = "0x57AF920", VA = "0x1857B0D20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0001C1E8 File Offset: 0x0001A3E8
		[Token(Token = "0x170004F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxy
		{
			[Token(Token = "0x60013B0")]
			[Address(RVA = "0x57B0D40", Offset = "0x57AF940", VA = "0x1857B0D40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x0001C200 File Offset: 0x0001A400
		[Token(Token = "0x170004F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxz
		{
			[Token(Token = "0x60013B1")]
			[Address(RVA = "0x57B0D60", Offset = "0x57AF960", VA = "0x1857B0D60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0001C218 File Offset: 0x0001A418
		[Token(Token = "0x170004F7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxw
		{
			[Token(Token = "0x60013B2")]
			[Address(RVA = "0x57C18D0", Offset = "0x57C04D0", VA = "0x1857C18D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0001C230 File Offset: 0x0001A430
		[Token(Token = "0x170004F8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyx
		{
			[Token(Token = "0x60013B3")]
			[Address(RVA = "0x57B0D80", Offset = "0x57AF980", VA = "0x1857B0D80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0001C248 File Offset: 0x0001A448
		[Token(Token = "0x170004F9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy
		{
			[Token(Token = "0x60013B4")]
			[Address(RVA = "0x57B0DA0", Offset = "0x57AF9A0", VA = "0x1857B0DA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0001C260 File Offset: 0x0001A460
		[Token(Token = "0x170004FA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz
		{
			[Token(Token = "0x60013B5")]
			[Address(RVA = "0x57B0DC0", Offset = "0x57AF9C0", VA = "0x1857B0DC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0001C278 File Offset: 0x0001A478
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyw
		{
			[Token(Token = "0x60013B6")]
			[Address(RVA = "0x576C630", Offset = "0x576B230", VA = "0x18576C630")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013B7")]
			[Address(RVA = "0x576DBB0", Offset = "0x576C7B0", VA = "0x18576DBB0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0001C290 File Offset: 0x0001A490
		[Token(Token = "0x170004FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzx
		{
			[Token(Token = "0x60013B8")]
			[Address(RVA = "0x57B0E00", Offset = "0x57AFA00", VA = "0x1857B0E00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
		[Token(Token = "0x170004FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzy
		{
			[Token(Token = "0x60013B9")]
			[Address(RVA = "0x57B0E20", Offset = "0x57AFA20", VA = "0x1857B0E20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
		[Token(Token = "0x170004FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzz
		{
			[Token(Token = "0x60013BA")]
			[Address(RVA = "0x57B0E40", Offset = "0x57AFA40", VA = "0x1857B0E40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x0001C2D8 File Offset: 0x0001A4D8
		[Token(Token = "0x170004FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzw
		{
			[Token(Token = "0x60013BB")]
			[Address(RVA = "0x57C18F0", Offset = "0x57C04F0", VA = "0x1857C18F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0001C2F0 File Offset: 0x0001A4F0
		[Token(Token = "0x17000500")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxwx
		{
			[Token(Token = "0x60013BC")]
			[Address(RVA = "0x57C1890", Offset = "0x57C0490", VA = "0x1857C1890")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0001C308 File Offset: 0x0001A508
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000501")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxwy
		{
			[Token(Token = "0x60013BD")]
			[Address(RVA = "0x576C530", Offset = "0x576B130", VA = "0x18576C530")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013BE")]
			[Address(RVA = "0x576DB70", Offset = "0x576C770", VA = "0x18576DB70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0001C320 File Offset: 0x0001A520
		[Token(Token = "0x17000502")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxwz
		{
			[Token(Token = "0x60013BF")]
			[Address(RVA = "0x57C18B0", Offset = "0x57C04B0", VA = "0x1857C18B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x0001C338 File Offset: 0x0001A538
		[Token(Token = "0x17000503")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxww
		{
			[Token(Token = "0x60013C0")]
			[Address(RVA = "0x57C1870", Offset = "0x57C0470", VA = "0x1857C1870")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0001C350 File Offset: 0x0001A550
		[Token(Token = "0x17000504")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxx
		{
			[Token(Token = "0x60013C1")]
			[Address(RVA = "0x57B0E80", Offset = "0x57AFA80", VA = "0x1857B0E80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0001C368 File Offset: 0x0001A568
		[Token(Token = "0x17000505")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxy
		{
			[Token(Token = "0x60013C2")]
			[Address(RVA = "0x57B0EA0", Offset = "0x57AFAA0", VA = "0x1857B0EA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0001C380 File Offset: 0x0001A580
		[Token(Token = "0x17000506")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxz
		{
			[Token(Token = "0x60013C3")]
			[Address(RVA = "0x57B0EC0", Offset = "0x57AFAC0", VA = "0x1857B0EC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0001C398 File Offset: 0x0001A598
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000507")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxw
		{
			[Token(Token = "0x60013C4")]
			[Address(RVA = "0x576C830", Offset = "0x576B430", VA = "0x18576C830")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013C5")]
			[Address(RVA = "0x576DC40", Offset = "0x576C840", VA = "0x18576DC40")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		[Token(Token = "0x17000508")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyx
		{
			[Token(Token = "0x60013C6")]
			[Address(RVA = "0x57B0F00", Offset = "0x57AFB00", VA = "0x1857B0F00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
		[Token(Token = "0x17000509")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyy
		{
			[Token(Token = "0x60013C7")]
			[Address(RVA = "0x57B0F20", Offset = "0x57AFB20", VA = "0x1857B0F20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		[Token(Token = "0x1700050A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyz
		{
			[Token(Token = "0x60013C8")]
			[Address(RVA = "0x57B0F40", Offset = "0x57AFB40", VA = "0x1857B0F40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		[Token(Token = "0x1700050B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyw
		{
			[Token(Token = "0x60013C9")]
			[Address(RVA = "0x57C1970", Offset = "0x57C0570", VA = "0x1857C1970")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0001C410 File Offset: 0x0001A610
		[Token(Token = "0x1700050C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzx
		{
			[Token(Token = "0x60013CA")]
			[Address(RVA = "0x57B0F90", Offset = "0x57AFB90", VA = "0x1857B0F90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0001C428 File Offset: 0x0001A628
		[Token(Token = "0x1700050D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzy
		{
			[Token(Token = "0x60013CB")]
			[Address(RVA = "0x57B0FB0", Offset = "0x57AFBB0", VA = "0x1857B0FB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0001C440 File Offset: 0x0001A640
		[Token(Token = "0x1700050E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzz
		{
			[Token(Token = "0x60013CC")]
			[Address(RVA = "0x57B0FE0", Offset = "0x57AFBE0", VA = "0x1857B0FE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0001C458 File Offset: 0x0001A658
		[Token(Token = "0x1700050F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzw
		{
			[Token(Token = "0x60013CD")]
			[Address(RVA = "0x57C1990", Offset = "0x57C0590", VA = "0x1857C1990")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0001C470 File Offset: 0x0001A670
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000510")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zywx
		{
			[Token(Token = "0x60013CE")]
			[Address(RVA = "0x576C7B0", Offset = "0x576B3B0", VA = "0x18576C7B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013CF")]
			[Address(RVA = "0x576DC00", Offset = "0x576C800", VA = "0x18576DC00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0001C488 File Offset: 0x0001A688
		[Token(Token = "0x17000511")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zywy
		{
			[Token(Token = "0x60013D0")]
			[Address(RVA = "0x57C1930", Offset = "0x57C0530", VA = "0x1857C1930")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		[Token(Token = "0x17000512")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zywz
		{
			[Token(Token = "0x60013D1")]
			[Address(RVA = "0x57C1950", Offset = "0x57C0550", VA = "0x1857C1950")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0001C4B8 File Offset: 0x0001A6B8
		[Token(Token = "0x17000513")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyww
		{
			[Token(Token = "0x60013D2")]
			[Address(RVA = "0x57C1910", Offset = "0x57C0510", VA = "0x1857C1910")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0001C4D0 File Offset: 0x0001A6D0
		[Token(Token = "0x17000514")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxx
		{
			[Token(Token = "0x60013D3")]
			[Address(RVA = "0x57B1040", Offset = "0x57AFC40", VA = "0x1857B1040")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		[Token(Token = "0x17000515")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxy
		{
			[Token(Token = "0x60013D4")]
			[Address(RVA = "0x57B1060", Offset = "0x57AFC60", VA = "0x1857B1060")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0001C500 File Offset: 0x0001A700
		[Token(Token = "0x17000516")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxz
		{
			[Token(Token = "0x60013D5")]
			[Address(RVA = "0x57B1080", Offset = "0x57AFC80", VA = "0x1857B1080")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0001C518 File Offset: 0x0001A718
		[Token(Token = "0x17000517")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxw
		{
			[Token(Token = "0x60013D6")]
			[Address(RVA = "0x57C1A60", Offset = "0x57C0660", VA = "0x1857C1A60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0001C530 File Offset: 0x0001A730
		[Token(Token = "0x17000518")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyx
		{
			[Token(Token = "0x60013D7")]
			[Address(RVA = "0x57B10C0", Offset = "0x57AFCC0", VA = "0x1857B10C0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0001C548 File Offset: 0x0001A748
		[Token(Token = "0x17000519")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyy
		{
			[Token(Token = "0x60013D8")]
			[Address(RVA = "0x57B10E0", Offset = "0x57AFCE0", VA = "0x1857B10E0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0001C560 File Offset: 0x0001A760
		[Token(Token = "0x1700051A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyz
		{
			[Token(Token = "0x60013D9")]
			[Address(RVA = "0x57B1110", Offset = "0x57AFD10", VA = "0x1857B1110")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0001C578 File Offset: 0x0001A778
		[Token(Token = "0x1700051B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyw
		{
			[Token(Token = "0x60013DA")]
			[Address(RVA = "0x57C1A80", Offset = "0x57C0680", VA = "0x1857C1A80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0001C590 File Offset: 0x0001A790
		[Token(Token = "0x1700051C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzx
		{
			[Token(Token = "0x60013DB")]
			[Address(RVA = "0x57B1150", Offset = "0x57AFD50", VA = "0x1857B1150")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		[Token(Token = "0x1700051D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzy
		{
			[Token(Token = "0x60013DC")]
			[Address(RVA = "0x57B1170", Offset = "0x57AFD70", VA = "0x1857B1170")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		[Token(Token = "0x1700051E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzz
		{
			[Token(Token = "0x60013DD")]
			[Address(RVA = "0x57B1190", Offset = "0x57AFD90", VA = "0x1857B1190")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		[Token(Token = "0x1700051F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzw
		{
			[Token(Token = "0x60013DE")]
			[Address(RVA = "0x57C1AA0", Offset = "0x57C06A0", VA = "0x1857C1AA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		[Token(Token = "0x17000520")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzwx
		{
			[Token(Token = "0x60013DF")]
			[Address(RVA = "0x57C1A00", Offset = "0x57C0600", VA = "0x1857C1A00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0001C608 File Offset: 0x0001A808
		[Token(Token = "0x17000521")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzwy
		{
			[Token(Token = "0x60013E0")]
			[Address(RVA = "0x57C1A20", Offset = "0x57C0620", VA = "0x1857C1A20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0001C620 File Offset: 0x0001A820
		[Token(Token = "0x17000522")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzwz
		{
			[Token(Token = "0x60013E1")]
			[Address(RVA = "0x57C1A40", Offset = "0x57C0640", VA = "0x1857C1A40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0001C638 File Offset: 0x0001A838
		[Token(Token = "0x17000523")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzww
		{
			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x57C19D0", Offset = "0x57C05D0", VA = "0x1857C19D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0001C650 File Offset: 0x0001A850
		[Token(Token = "0x17000524")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwxx
		{
			[Token(Token = "0x60013E3")]
			[Address(RVA = "0x57C1720", Offset = "0x57C0320", VA = "0x1857C1720")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0001C668 File Offset: 0x0001A868
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000525")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwxy
		{
			[Token(Token = "0x60013E4")]
			[Address(RVA = "0x576C330", Offset = "0x576AF30", VA = "0x18576C330")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013E5")]
			[Address(RVA = "0x576DAE0", Offset = "0x576C6E0", VA = "0x18576DAE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0001C680 File Offset: 0x0001A880
		[Token(Token = "0x17000526")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwxz
		{
			[Token(Token = "0x60013E6")]
			[Address(RVA = "0x57C1740", Offset = "0x57C0340", VA = "0x1857C1740")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0001C698 File Offset: 0x0001A898
		[Token(Token = "0x17000527")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwxw
		{
			[Token(Token = "0x60013E7")]
			[Address(RVA = "0x57C1700", Offset = "0x57C0300", VA = "0x1857C1700")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000528")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwyx
		{
			[Token(Token = "0x60013E8")]
			[Address(RVA = "0x576C3B0", Offset = "0x576AFB0", VA = "0x18576C3B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013E9")]
			[Address(RVA = "0x576DB20", Offset = "0x576C720", VA = "0x18576DB20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
		[Token(Token = "0x17000529")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwyy
		{
			[Token(Token = "0x60013EA")]
			[Address(RVA = "0x57C1780", Offset = "0x57C0380", VA = "0x1857C1780")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		[Token(Token = "0x1700052A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwyz
		{
			[Token(Token = "0x60013EB")]
			[Address(RVA = "0x57C17A0", Offset = "0x57C03A0", VA = "0x1857C17A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		[Token(Token = "0x1700052B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwyw
		{
			[Token(Token = "0x60013EC")]
			[Address(RVA = "0x57C1760", Offset = "0x57C0360", VA = "0x1857C1760")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0001C710 File Offset: 0x0001A910
		[Token(Token = "0x1700052C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwzx
		{
			[Token(Token = "0x60013ED")]
			[Address(RVA = "0x57C1810", Offset = "0x57C0410", VA = "0x1857C1810")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0001C728 File Offset: 0x0001A928
		[Token(Token = "0x1700052D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwzy
		{
			[Token(Token = "0x60013EE")]
			[Address(RVA = "0x57C1830", Offset = "0x57C0430", VA = "0x1857C1830")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0001C740 File Offset: 0x0001A940
		[Token(Token = "0x1700052E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwzz
		{
			[Token(Token = "0x60013EF")]
			[Address(RVA = "0x57C1850", Offset = "0x57C0450", VA = "0x1857C1850")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0001C758 File Offset: 0x0001A958
		[Token(Token = "0x1700052F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwzw
		{
			[Token(Token = "0x60013F0")]
			[Address(RVA = "0x57C17E0", Offset = "0x57C03E0", VA = "0x1857C17E0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0001C770 File Offset: 0x0001A970
		[Token(Token = "0x17000530")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwwx
		{
			[Token(Token = "0x60013F1")]
			[Address(RVA = "0x57C1690", Offset = "0x57C0290", VA = "0x1857C1690")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0001C788 File Offset: 0x0001A988
		[Token(Token = "0x17000531")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwwy
		{
			[Token(Token = "0x60013F2")]
			[Address(RVA = "0x57C16B0", Offset = "0x57C02B0", VA = "0x1857C16B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		[Token(Token = "0x17000532")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwwz
		{
			[Token(Token = "0x60013F3")]
			[Address(RVA = "0x57C16D0", Offset = "0x57C02D0", VA = "0x1857C16D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		[Token(Token = "0x17000533")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwww
		{
			[Token(Token = "0x60013F4")]
			[Address(RVA = "0x57C1670", Offset = "0x57C0270", VA = "0x1857C1670")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		[Token(Token = "0x17000534")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxxx
		{
			[Token(Token = "0x60013F5")]
			[Address(RVA = "0x57C07C0", Offset = "0x57BF3C0", VA = "0x1857C07C0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0001C7E8 File Offset: 0x0001A9E8
		[Token(Token = "0x17000535")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxxy
		{
			[Token(Token = "0x60013F6")]
			[Address(RVA = "0x57C07E0", Offset = "0x57BF3E0", VA = "0x1857C07E0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0001C800 File Offset: 0x0001AA00
		[Token(Token = "0x17000536")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxxz
		{
			[Token(Token = "0x60013F7")]
			[Address(RVA = "0x57C0800", Offset = "0x57BF400", VA = "0x1857C0800")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0001C818 File Offset: 0x0001AA18
		[Token(Token = "0x17000537")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxxw
		{
			[Token(Token = "0x60013F8")]
			[Address(RVA = "0x57C07A0", Offset = "0x57BF3A0", VA = "0x1857C07A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0001C830 File Offset: 0x0001AA30
		[Token(Token = "0x17000538")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxyx
		{
			[Token(Token = "0x60013F9")]
			[Address(RVA = "0x57C0840", Offset = "0x57BF440", VA = "0x1857C0840")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0001C848 File Offset: 0x0001AA48
		[Token(Token = "0x17000539")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxyy
		{
			[Token(Token = "0x60013FA")]
			[Address(RVA = "0x57C0860", Offset = "0x57BF460", VA = "0x1857C0860")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0001C860 File Offset: 0x0001AA60
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxyz
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x576A760", Offset = "0x5769360", VA = "0x18576A760")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x60013FC")]
			[Address(RVA = "0x576D610", Offset = "0x576C210", VA = "0x18576D610")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0001C878 File Offset: 0x0001AA78
		[Token(Token = "0x1700053B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxyw
		{
			[Token(Token = "0x60013FD")]
			[Address(RVA = "0x57C0820", Offset = "0x57BF420", VA = "0x1857C0820")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0001C890 File Offset: 0x0001AA90
		[Token(Token = "0x1700053C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxzx
		{
			[Token(Token = "0x60013FE")]
			[Address(RVA = "0x57C08A0", Offset = "0x57BF4A0", VA = "0x1857C08A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxzy
		{
			[Token(Token = "0x60013FF")]
			[Address(RVA = "0x576A7E0", Offset = "0x57693E0", VA = "0x18576A7E0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x6001400")]
			[Address(RVA = "0x576D650", Offset = "0x576C250", VA = "0x18576D650")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		[Token(Token = "0x1700053E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxzz
		{
			[Token(Token = "0x6001401")]
			[Address(RVA = "0x57C08C0", Offset = "0x57BF4C0", VA = "0x1857C08C0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		[Token(Token = "0x1700053F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxzw
		{
			[Token(Token = "0x6001402")]
			[Address(RVA = "0x57C0880", Offset = "0x57BF480", VA = "0x1857C0880")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		[Token(Token = "0x17000540")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxwx
		{
			[Token(Token = "0x6001403")]
			[Address(RVA = "0x57C0720", Offset = "0x57BF320", VA = "0x1857C0720")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0001C908 File Offset: 0x0001AB08
		[Token(Token = "0x17000541")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxwy
		{
			[Token(Token = "0x6001404")]
			[Address(RVA = "0x57C0740", Offset = "0x57BF340", VA = "0x1857C0740")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0001C920 File Offset: 0x0001AB20
		[Token(Token = "0x17000542")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxwz
		{
			[Token(Token = "0x6001405")]
			[Address(RVA = "0x57C0760", Offset = "0x57BF360", VA = "0x1857C0760")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0001C938 File Offset: 0x0001AB38
		[Token(Token = "0x17000543")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wxww
		{
			[Token(Token = "0x6001406")]
			[Address(RVA = "0x57C0700", Offset = "0x57BF300", VA = "0x1857C0700")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0001C950 File Offset: 0x0001AB50
		[Token(Token = "0x17000544")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyxx
		{
			[Token(Token = "0x6001407")]
			[Address(RVA = "0x57C09D0", Offset = "0x57BF5D0", VA = "0x1857C09D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0001C968 File Offset: 0x0001AB68
		[Token(Token = "0x17000545")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyxy
		{
			[Token(Token = "0x6001408")]
			[Address(RVA = "0x57C09F0", Offset = "0x57BF5F0", VA = "0x1857C09F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0001C980 File Offset: 0x0001AB80
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000546")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyxz
		{
			[Token(Token = "0x6001409")]
			[Address(RVA = "0x576A960", Offset = "0x5769560", VA = "0x18576A960")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x600140A")]
			[Address(RVA = "0x576D6A0", Offset = "0x576C2A0", VA = "0x18576D6A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0001C998 File Offset: 0x0001AB98
		[Token(Token = "0x17000547")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyxw
		{
			[Token(Token = "0x600140B")]
			[Address(RVA = "0x57C09B0", Offset = "0x57BF5B0", VA = "0x1857C09B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		[Token(Token = "0x17000548")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyyx
		{
			[Token(Token = "0x600140C")]
			[Address(RVA = "0x57C0A60", Offset = "0x57BF660", VA = "0x1857C0A60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		[Token(Token = "0x17000549")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyyy
		{
			[Token(Token = "0x600140D")]
			[Address(RVA = "0x57C0A80", Offset = "0x57BF680", VA = "0x1857C0A80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		[Token(Token = "0x1700054A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyyz
		{
			[Token(Token = "0x600140E")]
			[Address(RVA = "0x57C0AA0", Offset = "0x57BF6A0", VA = "0x1857C0AA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		[Token(Token = "0x1700054B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyyw
		{
			[Token(Token = "0x600140F")]
			[Address(RVA = "0x57C0A30", Offset = "0x57BF630", VA = "0x1857C0A30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0001CA10 File Offset: 0x0001AC10
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyzx
		{
			[Token(Token = "0x6001410")]
			[Address(RVA = "0x576AA60", Offset = "0x5769660", VA = "0x18576AA60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x6001411")]
			[Address(RVA = "0x576D6E0", Offset = "0x576C2E0", VA = "0x18576D6E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0001CA28 File Offset: 0x0001AC28
		[Token(Token = "0x1700054D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyzy
		{
			[Token(Token = "0x6001412")]
			[Address(RVA = "0x57C0AE0", Offset = "0x57BF6E0", VA = "0x1857C0AE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0001CA40 File Offset: 0x0001AC40
		[Token(Token = "0x1700054E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyzz
		{
			[Token(Token = "0x6001413")]
			[Address(RVA = "0x57C0B00", Offset = "0x57BF700", VA = "0x1857C0B00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0001CA58 File Offset: 0x0001AC58
		[Token(Token = "0x1700054F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyzw
		{
			[Token(Token = "0x6001414")]
			[Address(RVA = "0x57C0AC0", Offset = "0x57BF6C0", VA = "0x1857C0AC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0001CA70 File Offset: 0x0001AC70
		[Token(Token = "0x17000550")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wywx
		{
			[Token(Token = "0x6001415")]
			[Address(RVA = "0x57C0940", Offset = "0x57BF540", VA = "0x1857C0940")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0001CA88 File Offset: 0x0001AC88
		[Token(Token = "0x17000551")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wywy
		{
			[Token(Token = "0x6001416")]
			[Address(RVA = "0x57C0960", Offset = "0x57BF560", VA = "0x1857C0960")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		[Token(Token = "0x17000552")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wywz
		{
			[Token(Token = "0x6001417")]
			[Address(RVA = "0x57C0990", Offset = "0x57BF590", VA = "0x1857C0990")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		[Token(Token = "0x17000553")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wyww
		{
			[Token(Token = "0x6001418")]
			[Address(RVA = "0x57C0920", Offset = "0x57BF520", VA = "0x1857C0920")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		[Token(Token = "0x17000554")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzxx
		{
			[Token(Token = "0x6001419")]
			[Address(RVA = "0x57C0C10", Offset = "0x57BF810", VA = "0x1857C0C10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0001CAE8 File Offset: 0x0001ACE8
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000555")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzxy
		{
			[Token(Token = "0x600141A")]
			[Address(RVA = "0x576ABE0", Offset = "0x57697E0", VA = "0x18576ABE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x600141B")]
			[Address(RVA = "0x576D730", Offset = "0x576C330", VA = "0x18576D730")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0001CB00 File Offset: 0x0001AD00
		[Token(Token = "0x17000556")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzxz
		{
			[Token(Token = "0x600141C")]
			[Address(RVA = "0x57C0C30", Offset = "0x57BF830", VA = "0x1857C0C30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0001CB18 File Offset: 0x0001AD18
		[Token(Token = "0x17000557")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzxw
		{
			[Token(Token = "0x600141D")]
			[Address(RVA = "0x57C0BF0", Offset = "0x57BF7F0", VA = "0x1857C0BF0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0001CB30 File Offset: 0x0001AD30
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000558")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzyx
		{
			[Token(Token = "0x600141E")]
			[Address(RVA = "0x576AC60", Offset = "0x5769860", VA = "0x18576AC60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
			[Token(Token = "0x600141F")]
			[Address(RVA = "0x576D770", Offset = "0x576C370", VA = "0x18576D770")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0001CB48 File Offset: 0x0001AD48
		[Token(Token = "0x17000559")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzyy
		{
			[Token(Token = "0x6001420")]
			[Address(RVA = "0x57C0C70", Offset = "0x57BF870", VA = "0x1857C0C70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0001CB60 File Offset: 0x0001AD60
		[Token(Token = "0x1700055A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzyz
		{
			[Token(Token = "0x6001421")]
			[Address(RVA = "0x57C0C90", Offset = "0x57BF890", VA = "0x1857C0C90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0001CB78 File Offset: 0x0001AD78
		[Token(Token = "0x1700055B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzyw
		{
			[Token(Token = "0x6001422")]
			[Address(RVA = "0x57C0C50", Offset = "0x57BF850", VA = "0x1857C0C50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0001CB90 File Offset: 0x0001AD90
		[Token(Token = "0x1700055C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzzx
		{
			[Token(Token = "0x6001423")]
			[Address(RVA = "0x57C0D00", Offset = "0x57BF900", VA = "0x1857C0D00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
		[Token(Token = "0x1700055D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzzy
		{
			[Token(Token = "0x6001424")]
			[Address(RVA = "0x57C0D20", Offset = "0x57BF920", VA = "0x1857C0D20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
		[Token(Token = "0x1700055E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzzz
		{
			[Token(Token = "0x6001425")]
			[Address(RVA = "0x57C0D40", Offset = "0x57BF940", VA = "0x1857C0D40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		[Token(Token = "0x1700055F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzzw
		{
			[Token(Token = "0x6001426")]
			[Address(RVA = "0x57C0CD0", Offset = "0x57BF8D0", VA = "0x1857C0CD0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		[Token(Token = "0x17000560")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzwx
		{
			[Token(Token = "0x6001427")]
			[Address(RVA = "0x57C0B80", Offset = "0x57BF780", VA = "0x1857C0B80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0001CC08 File Offset: 0x0001AE08
		[Token(Token = "0x17000561")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzwy
		{
			[Token(Token = "0x6001428")]
			[Address(RVA = "0x57C0BA0", Offset = "0x57BF7A0", VA = "0x1857C0BA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0001CC20 File Offset: 0x0001AE20
		[Token(Token = "0x17000562")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzwz
		{
			[Token(Token = "0x6001429")]
			[Address(RVA = "0x57C0BC0", Offset = "0x57BF7C0", VA = "0x1857C0BC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0001CC38 File Offset: 0x0001AE38
		[Token(Token = "0x17000563")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzww
		{
			[Token(Token = "0x600142A")]
			[Address(RVA = "0x57C0B60", Offset = "0x57BF760", VA = "0x1857C0B60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0001CC50 File Offset: 0x0001AE50
		[Token(Token = "0x17000564")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwxx
		{
			[Token(Token = "0x600142B")]
			[Address(RVA = "0x57C0500", Offset = "0x57BF100", VA = "0x1857C0500")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0001CC68 File Offset: 0x0001AE68
		[Token(Token = "0x17000565")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwxy
		{
			[Token(Token = "0x600142C")]
			[Address(RVA = "0x57C0520", Offset = "0x57BF120", VA = "0x1857C0520")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0001CC80 File Offset: 0x0001AE80
		[Token(Token = "0x17000566")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwxz
		{
			[Token(Token = "0x600142D")]
			[Address(RVA = "0x57C0540", Offset = "0x57BF140", VA = "0x1857C0540")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0001CC98 File Offset: 0x0001AE98
		[Token(Token = "0x17000567")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwxw
		{
			[Token(Token = "0x600142E")]
			[Address(RVA = "0x57C04E0", Offset = "0x57BF0E0", VA = "0x1857C04E0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		[Token(Token = "0x17000568")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwyx
		{
			[Token(Token = "0x600142F")]
			[Address(RVA = "0x57C05A0", Offset = "0x57BF1A0", VA = "0x1857C05A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0001CCC8 File Offset: 0x0001AEC8
		[Token(Token = "0x17000569")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwyy
		{
			[Token(Token = "0x6001430")]
			[Address(RVA = "0x57C05C0", Offset = "0x57BF1C0", VA = "0x1857C05C0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		[Token(Token = "0x1700056A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwyz
		{
			[Token(Token = "0x6001431")]
			[Address(RVA = "0x57C05F0", Offset = "0x57BF1F0", VA = "0x1857C05F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
		[Token(Token = "0x1700056B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwyw
		{
			[Token(Token = "0x6001432")]
			[Address(RVA = "0x57C0580", Offset = "0x57BF180", VA = "0x1857C0580")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0001CD10 File Offset: 0x0001AF10
		[Token(Token = "0x1700056C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwzx
		{
			[Token(Token = "0x6001433")]
			[Address(RVA = "0x57C0650", Offset = "0x57BF250", VA = "0x1857C0650")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0001CD28 File Offset: 0x0001AF28
		[Token(Token = "0x1700056D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwzy
		{
			[Token(Token = "0x6001434")]
			[Address(RVA = "0x57C0670", Offset = "0x57BF270", VA = "0x1857C0670")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0001CD40 File Offset: 0x0001AF40
		[Token(Token = "0x1700056E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwzz
		{
			[Token(Token = "0x6001435")]
			[Address(RVA = "0x57C0690", Offset = "0x57BF290", VA = "0x1857C0690")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0001CD58 File Offset: 0x0001AF58
		[Token(Token = "0x1700056F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwzw
		{
			[Token(Token = "0x6001436")]
			[Address(RVA = "0x57C0630", Offset = "0x57BF230", VA = "0x1857C0630")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0001CD70 File Offset: 0x0001AF70
		[Token(Token = "0x17000570")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwwx
		{
			[Token(Token = "0x6001437")]
			[Address(RVA = "0x57C0460", Offset = "0x57BF060", VA = "0x1857C0460")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0001CD88 File Offset: 0x0001AF88
		[Token(Token = "0x17000571")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwwy
		{
			[Token(Token = "0x6001438")]
			[Address(RVA = "0x57C0480", Offset = "0x57BF080", VA = "0x1857C0480")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0001CDA0 File Offset: 0x0001AFA0
		[Token(Token = "0x17000572")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwwz
		{
			[Token(Token = "0x6001439")]
			[Address(RVA = "0x57C04A0", Offset = "0x57BF0A0", VA = "0x1857C04A0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		[Token(Token = "0x17000573")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwww
		{
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x57C0450", Offset = "0x57BF050", VA = "0x1857C0450")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
		[Token(Token = "0x17000574")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx
		{
			[Token(Token = "0x600143B")]
			[Address(RVA = "0x57A9B80", Offset = "0x57A8780", VA = "0x1857A9B80")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
		[Token(Token = "0x17000575")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxy
		{
			[Token(Token = "0x600143C")]
			[Address(RVA = "0x57A9BD0", Offset = "0x57A87D0", VA = "0x1857A9BD0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0001CE00 File Offset: 0x0001B000
		[Token(Token = "0x17000576")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxz
		{
			[Token(Token = "0x600143D")]
			[Address(RVA = "0x57B0750", Offset = "0x57AF350", VA = "0x1857B0750")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0001CE18 File Offset: 0x0001B018
		[Token(Token = "0x17000577")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxw
		{
			[Token(Token = "0x600143E")]
			[Address(RVA = "0x57C0F80", Offset = "0x57BFB80", VA = "0x1857C0F80")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0001CE30 File Offset: 0x0001B030
		[Token(Token = "0x17000578")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyx
		{
			[Token(Token = "0x600143F")]
			[Address(RVA = "0x57A9C30", Offset = "0x57A8830", VA = "0x1857A9C30")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0001CE48 File Offset: 0x0001B048
		[Token(Token = "0x17000579")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyy
		{
			[Token(Token = "0x6001440")]
			[Address(RVA = "0x57A9C90", Offset = "0x57A8890", VA = "0x1857A9C90")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0001CE60 File Offset: 0x0001B060
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz
		{
			[Token(Token = "0x6001441")]
			[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001442")]
			[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x0001CE78 File Offset: 0x0001B078
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyw
		{
			[Token(Token = "0x6001443")]
			[Address(RVA = "0x576B2A0", Offset = "0x5769EA0", VA = "0x18576B2A0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001444")]
			[Address(RVA = "0x576D830", Offset = "0x576C430", VA = "0x18576D830")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0001CE90 File Offset: 0x0001B090
		[Token(Token = "0x1700057C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzx
		{
			[Token(Token = "0x6001445")]
			[Address(RVA = "0x57B0890", Offset = "0x57AF490", VA = "0x1857B0890")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzy
		{
			[Token(Token = "0x6001446")]
			[Address(RVA = "0x576B680", Offset = "0x576A280", VA = "0x18576B680")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001447")]
			[Address(RVA = "0x576D8C0", Offset = "0x576C4C0", VA = "0x18576D8C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		[Token(Token = "0x1700057E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzz
		{
			[Token(Token = "0x6001448")]
			[Address(RVA = "0x57B0970", Offset = "0x57AF570", VA = "0x1857B0970")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0001CED8 File Offset: 0x0001B0D8
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzw
		{
			[Token(Token = "0x6001449")]
			[Address(RVA = "0x576B540", Offset = "0x576A140", VA = "0x18576B540")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600144A")]
			[Address(RVA = "0x576D880", Offset = "0x576C480", VA = "0x18576D880")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		[Token(Token = "0x17000580")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xwx
		{
			[Token(Token = "0x600144B")]
			[Address(RVA = "0x57C0E20", Offset = "0x57BFA20", VA = "0x1857C0E20")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0001CF08 File Offset: 0x0001B108
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000581")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xwy
		{
			[Token(Token = "0x600144C")]
			[Address(RVA = "0x576AEC0", Offset = "0x5769AC0", VA = "0x18576AEC0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600144D")]
			[Address(RVA = "0x576D7A0", Offset = "0x576C3A0", VA = "0x18576D7A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0001CF20 File Offset: 0x0001B120
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000582")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xwz
		{
			[Token(Token = "0x600144E")]
			[Address(RVA = "0x576AF60", Offset = "0x5769B60", VA = "0x18576AF60")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600144F")]
			[Address(RVA = "0x576D7E0", Offset = "0x576C3E0", VA = "0x18576D7E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0001CF38 File Offset: 0x0001B138
		[Token(Token = "0x17000583")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xww
		{
			[Token(Token = "0x6001450")]
			[Address(RVA = "0x57C0D80", Offset = "0x57BF980", VA = "0x1857C0D80")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0001CF50 File Offset: 0x0001B150
		[Token(Token = "0x17000584")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxx
		{
			[Token(Token = "0x6001451")]
			[Address(RVA = "0x57A9D10", Offset = "0x57A8910", VA = "0x1857A9D10")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0001CF68 File Offset: 0x0001B168
		[Token(Token = "0x17000585")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxy
		{
			[Token(Token = "0x6001452")]
			[Address(RVA = "0x57A9D70", Offset = "0x57A8970", VA = "0x1857A9D70")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0001CF80 File Offset: 0x0001B180
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000586")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxz
		{
			[Token(Token = "0x6001453")]
			[Address(RVA = "0x576BC60", Offset = "0x576A860", VA = "0x18576BC60")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001454")]
			[Address(RVA = "0x576D9E0", Offset = "0x576C5E0", VA = "0x18576D9E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0001CF98 File Offset: 0x0001B198
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000587")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxw
		{
			[Token(Token = "0x6001455")]
			[Address(RVA = "0x576BA80", Offset = "0x576A680", VA = "0x18576BA80")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001456")]
			[Address(RVA = "0x576D9A0", Offset = "0x576C5A0", VA = "0x18576D9A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		[Token(Token = "0x17000588")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyx
		{
			[Token(Token = "0x6001457")]
			[Address(RVA = "0x57A9DF0", Offset = "0x57A89F0", VA = "0x1857A9DF0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		[Token(Token = "0x17000589")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyy
		{
			[Token(Token = "0x6001458")]
			[Address(RVA = "0x57A9E50", Offset = "0x57A8A50", VA = "0x1857A9E50")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0001CFE0 File Offset: 0x0001B1E0
		[Token(Token = "0x1700058A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyz
		{
			[Token(Token = "0x6001459")]
			[Address(RVA = "0x57B0AD0", Offset = "0x57AF6D0", VA = "0x1857B0AD0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
		[Token(Token = "0x1700058B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyw
		{
			[Token(Token = "0x600145A")]
			[Address(RVA = "0x57C14A0", Offset = "0x57C00A0", VA = "0x1857C14A0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0001D010 File Offset: 0x0001B210
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx
		{
			[Token(Token = "0x600145B")]
			[Address(RVA = "0x576C050", Offset = "0x576AC50", VA = "0x18576C050")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600145C")]
			[Address(RVA = "0x576DA70", Offset = "0x576C670", VA = "0x18576DA70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0001D028 File Offset: 0x0001B228
		[Token(Token = "0x1700058D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzy
		{
			[Token(Token = "0x600145D")]
			[Address(RVA = "0x57B0BC0", Offset = "0x57AF7C0", VA = "0x1857B0BC0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0001D040 File Offset: 0x0001B240
		[Token(Token = "0x1700058E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzz
		{
			[Token(Token = "0x600145E")]
			[Address(RVA = "0x57B0C50", Offset = "0x57AF850", VA = "0x1857B0C50")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0001D058 File Offset: 0x0001B258
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzw
		{
			[Token(Token = "0x600145F")]
			[Address(RVA = "0x576BFB0", Offset = "0x576ABB0", VA = "0x18576BFB0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001460")]
			[Address(RVA = "0x576DA30", Offset = "0x576C630", VA = "0x18576DA30")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0001D070 File Offset: 0x0001B270
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000590")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 ywx
		{
			[Token(Token = "0x6001461")]
			[Address(RVA = "0x576B880", Offset = "0x576A480", VA = "0x18576B880")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001462")]
			[Address(RVA = "0x576D910", Offset = "0x576C510", VA = "0x18576D910")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0001D088 File Offset: 0x0001B288
		[Token(Token = "0x17000591")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 ywy
		{
			[Token(Token = "0x6001463")]
			[Address(RVA = "0x57C12F0", Offset = "0x57BFEF0", VA = "0x1857C12F0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000592")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 ywz
		{
			[Token(Token = "0x6001464")]
			[Address(RVA = "0x576B9C0", Offset = "0x576A5C0", VA = "0x18576B9C0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001465")]
			[Address(RVA = "0x576D950", Offset = "0x576C550", VA = "0x18576D950")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
		[Token(Token = "0x17000593")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yww
		{
			[Token(Token = "0x6001466")]
			[Address(RVA = "0x57C11E0", Offset = "0x57BFDE0", VA = "0x1857C11E0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
		[Token(Token = "0x17000594")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxx
		{
			[Token(Token = "0x6001467")]
			[Address(RVA = "0x57B0D00", Offset = "0x57AF900", VA = "0x1857B0D00")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000595")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxy
		{
			[Token(Token = "0x6001468")]
			[Address(RVA = "0x576C610", Offset = "0x576B210", VA = "0x18576C610")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001469")]
			[Address(RVA = "0x576DB90", Offset = "0x576C790", VA = "0x18576DB90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0001D100 File Offset: 0x0001B300
		[Token(Token = "0x17000596")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxz
		{
			[Token(Token = "0x600146A")]
			[Address(RVA = "0x57B0DE0", Offset = "0x57AF9E0", VA = "0x1857B0DE0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0001D118 File Offset: 0x0001B318
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000597")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxw
		{
			[Token(Token = "0x600146B")]
			[Address(RVA = "0x576C4D0", Offset = "0x576B0D0", VA = "0x18576C4D0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600146C")]
			[Address(RVA = "0x576DB50", Offset = "0x576C750", VA = "0x18576DB50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0001D130 File Offset: 0x0001B330
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000598")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyx
		{
			[Token(Token = "0x600146D")]
			[Address(RVA = "0x576C810", Offset = "0x576B410", VA = "0x18576C810")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x576DC20", Offset = "0x576C820", VA = "0x18576DC20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0001D148 File Offset: 0x0001B348
		[Token(Token = "0x17000599")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyy
		{
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x57B0EE0", Offset = "0x57AFAE0", VA = "0x1857B0EE0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0001D160 File Offset: 0x0001B360
		[Token(Token = "0x1700059A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyz
		{
			[Token(Token = "0x6001470")]
			[Address(RVA = "0x57B0F70", Offset = "0x57AFB70", VA = "0x1857B0F70")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0001D178 File Offset: 0x0001B378
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyw
		{
			[Token(Token = "0x6001471")]
			[Address(RVA = "0x576C770", Offset = "0x576B370", VA = "0x18576C770")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001472")]
			[Address(RVA = "0x576DBE0", Offset = "0x576C7E0", VA = "0x18576DBE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0001D190 File Offset: 0x0001B390
		[Token(Token = "0x1700059C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzx
		{
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x57B1020", Offset = "0x57AFC20", VA = "0x1857B1020")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0001D1A8 File Offset: 0x0001B3A8
		[Token(Token = "0x1700059D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzy
		{
			[Token(Token = "0x6001474")]
			[Address(RVA = "0x57B10A0", Offset = "0x57AFCA0", VA = "0x1857B10A0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		[Token(Token = "0x1700059E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzz
		{
			[Token(Token = "0x6001475")]
			[Address(RVA = "0x57B1130", Offset = "0x57AFD30", VA = "0x1857B1130")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0001D1D8 File Offset: 0x0001B3D8
		[Token(Token = "0x1700059F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzw
		{
			[Token(Token = "0x6001476")]
			[Address(RVA = "0x57C19B0", Offset = "0x57C05B0", VA = "0x1857C19B0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zwx
		{
			[Token(Token = "0x6001477")]
			[Address(RVA = "0x576C2D0", Offset = "0x576AED0", VA = "0x18576C2D0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001478")]
			[Address(RVA = "0x576DAC0", Offset = "0x576C6C0", VA = "0x18576DAC0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0001D208 File Offset: 0x0001B408
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zwy
		{
			[Token(Token = "0x6001479")]
			[Address(RVA = "0x576C370", Offset = "0x576AF70", VA = "0x18576C370")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600147A")]
			[Address(RVA = "0x576DB00", Offset = "0x576C700", VA = "0x18576DB00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0001D220 File Offset: 0x0001B420
		[Token(Token = "0x170005A2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zwz
		{
			[Token(Token = "0x600147B")]
			[Address(RVA = "0x57C17C0", Offset = "0x57C03C0", VA = "0x1857C17C0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0001D238 File Offset: 0x0001B438
		[Token(Token = "0x170005A3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zww
		{
			[Token(Token = "0x600147C")]
			[Address(RVA = "0x57C1650", Offset = "0x57C0250", VA = "0x1857C1650")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0001D250 File Offset: 0x0001B450
		[Token(Token = "0x170005A4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wxx
		{
			[Token(Token = "0x600147D")]
			[Address(RVA = "0x57C0780", Offset = "0x57BF380", VA = "0x1857C0780")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0001D268 File Offset: 0x0001B468
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wxy
		{
			[Token(Token = "0x600147E")]
			[Address(RVA = "0x576A6E0", Offset = "0x57692E0", VA = "0x18576A6E0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600147F")]
			[Address(RVA = "0x576D5F0", Offset = "0x576C1F0", VA = "0x18576D5F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0001D280 File Offset: 0x0001B480
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wxz
		{
			[Token(Token = "0x6001480")]
			[Address(RVA = "0x576A780", Offset = "0x5769380", VA = "0x18576A780")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001481")]
			[Address(RVA = "0x576D630", Offset = "0x576C230", VA = "0x18576D630")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0001D298 File Offset: 0x0001B498
		[Token(Token = "0x170005A7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wxw
		{
			[Token(Token = "0x6001482")]
			[Address(RVA = "0x57C06E0", Offset = "0x57BF2E0", VA = "0x1857C06E0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0001D2B0 File Offset: 0x0001B4B0
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wyx
		{
			[Token(Token = "0x6001483")]
			[Address(RVA = "0x576A8E0", Offset = "0x57694E0", VA = "0x18576A8E0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001484")]
			[Address(RVA = "0x576D680", Offset = "0x576C280", VA = "0x18576D680")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		[Token(Token = "0x170005A9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wyy
		{
			[Token(Token = "0x6001485")]
			[Address(RVA = "0x57C0A10", Offset = "0x57BF610", VA = "0x1857C0A10")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wyz
		{
			[Token(Token = "0x6001486")]
			[Address(RVA = "0x576AA20", Offset = "0x5769620", VA = "0x18576AA20")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x6001487")]
			[Address(RVA = "0x576D6C0", Offset = "0x576C2C0", VA = "0x18576D6C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		[Token(Token = "0x170005AB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wyw
		{
			[Token(Token = "0x6001488")]
			[Address(RVA = "0x57C0900", Offset = "0x57BF500", VA = "0x1857C0900")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0001D310 File Offset: 0x0001B510
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzx
		{
			[Token(Token = "0x6001489")]
			[Address(RVA = "0x576AB80", Offset = "0x5769780", VA = "0x18576AB80")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600148A")]
			[Address(RVA = "0x576D710", Offset = "0x576C310", VA = "0x18576D710")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0001D328 File Offset: 0x0001B528
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzy
		{
			[Token(Token = "0x600148B")]
			[Address(RVA = "0x576AC20", Offset = "0x5769820", VA = "0x18576AC20")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x600148C")]
			[Address(RVA = "0x576D750", Offset = "0x576C350", VA = "0x18576D750")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0001D340 File Offset: 0x0001B540
		[Token(Token = "0x170005AE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzz
		{
			[Token(Token = "0x600148D")]
			[Address(RVA = "0x57C0CB0", Offset = "0x57BF8B0", VA = "0x1857C0CB0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0001D358 File Offset: 0x0001B558
		[Token(Token = "0x170005AF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzw
		{
			[Token(Token = "0x600148E")]
			[Address(RVA = "0x57C0B40", Offset = "0x57BF740", VA = "0x1857C0B40")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0001D370 File Offset: 0x0001B570
		[Token(Token = "0x170005B0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wwx
		{
			[Token(Token = "0x600148F")]
			[Address(RVA = "0x57C04C0", Offset = "0x57BF0C0", VA = "0x1857C04C0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0001D388 File Offset: 0x0001B588
		[Token(Token = "0x170005B1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wwy
		{
			[Token(Token = "0x6001490")]
			[Address(RVA = "0x57C0560", Offset = "0x57BF160", VA = "0x1857C0560")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
		[Token(Token = "0x170005B2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wwz
		{
			[Token(Token = "0x6001491")]
			[Address(RVA = "0x57C0610", Offset = "0x57BF210", VA = "0x1857C0610")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
		[Token(Token = "0x170005B3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 www
		{
			[Token(Token = "0x6001492")]
			[Address(RVA = "0x57C0430", Offset = "0x57BF030", VA = "0x1857C0430")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0001D3D0 File Offset: 0x0001B5D0
		[Token(Token = "0x170005B4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx
		{
			[Token(Token = "0x6001493")]
			[Address(RVA = "0x57A9B70", Offset = "0x57A8770", VA = "0x1857A9B70")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy
		{
			[Token(Token = "0x6001494")]
			[Address(RVA = "0x15795C0", Offset = "0x15781C0", VA = "0x1815795C0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x6001495")]
			[Address(RVA = "0x57A9A70", Offset = "0x57A8670", VA = "0x1857A9A70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0001D400 File Offset: 0x0001B600
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz
		{
			[Token(Token = "0x6001496")]
			[Address(RVA = "0x57B0870", Offset = "0x57AF470", VA = "0x1857B0870")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x6001497")]
			[Address(RVA = "0x57B19F0", Offset = "0x57B05F0", VA = "0x1857B19F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0001D418 File Offset: 0x0001B618
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xw
		{
			[Token(Token = "0x6001498")]
			[Address(RVA = "0x57C0D60", Offset = "0x57BF960", VA = "0x1857C0D60")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x6001499")]
			[Address(RVA = "0x57C2420", Offset = "0x57C1020", VA = "0x1857C2420")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0001D430 File Offset: 0x0001B630
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx
		{
			[Token(Token = "0x600149A")]
			[Address(RVA = "0x57A9CF0", Offset = "0x57A88F0", VA = "0x1857A9CF0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x600149B")]
			[Address(RVA = "0x57AA620", Offset = "0x57A9220", VA = "0x1857AA620")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0001D448 File Offset: 0x0001B648
		[Token(Token = "0x170005B9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy
		{
			[Token(Token = "0x600149C")]
			[Address(RVA = "0x57A9DD0", Offset = "0x57A89D0", VA = "0x1857A9DD0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0001D460 File Offset: 0x0001B660
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yz
		{
			[Token(Token = "0x600149D")]
			[Address(RVA = "0x15ABE60", Offset = "0x15AAA60", VA = "0x1815ABE60")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x600149E")]
			[Address(RVA = "0x57B1A10", Offset = "0x57B0610", VA = "0x1857B1A10")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0001D478 File Offset: 0x0001B678
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yw
		{
			[Token(Token = "0x600149F")]
			[Address(RVA = "0x57C11C0", Offset = "0x57BFDC0", VA = "0x1857C11C0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60014A0")]
			[Address(RVA = "0x57C2440", Offset = "0x57C1040", VA = "0x1857C2440")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0001D490 File Offset: 0x0001B690
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zx
		{
			[Token(Token = "0x60014A1")]
			[Address(RVA = "0x57B0CE0", Offset = "0x57AF8E0", VA = "0x1857B0CE0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60014A2")]
			[Address(RVA = "0x57B1A30", Offset = "0x57B0630", VA = "0x1857B1A30")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zy
		{
			[Token(Token = "0x60014A3")]
			[Address(RVA = "0x57B0E60", Offset = "0x57AFA60", VA = "0x1857B0E60")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60014A4")]
			[Address(RVA = "0x57B1A50", Offset = "0x57B0650", VA = "0x1857B1A50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
		[Token(Token = "0x170005BE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zz
		{
			[Token(Token = "0x60014A5")]
			[Address(RVA = "0x57B1000", Offset = "0x57AFC00", VA = "0x1857B1000")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zw
		{
			[Token(Token = "0x60014A6")]
			[Address(RVA = "0x15795A0", Offset = "0x15781A0", VA = "0x1815795A0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60014A7")]
			[Address(RVA = "0x57C2460", Offset = "0x57C1060", VA = "0x1857C2460")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 wx
		{
			[Token(Token = "0x60014A8")]
			[Address(RVA = "0x57C06C0", Offset = "0x57BF2C0", VA = "0x1857C06C0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60014A9")]
			[Address(RVA = "0x57C23C0", Offset = "0x57C0FC0", VA = "0x1857C23C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0001D508 File Offset: 0x0001B708
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 wy
		{
			[Token(Token = "0x60014AA")]
			[Address(RVA = "0x57C08E0", Offset = "0x57BF4E0", VA = "0x1857C08E0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60014AB")]
			[Address(RVA = "0x57C23E0", Offset = "0x57C0FE0", VA = "0x1857C23E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0001D520 File Offset: 0x0001B720
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 wz
		{
			[Token(Token = "0x60014AC")]
			[Address(RVA = "0x57C0B20", Offset = "0x57BF720", VA = "0x1857C0B20")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60014AD")]
			[Address(RVA = "0x57C2400", Offset = "0x57C1000", VA = "0x1857C2400")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x0001D538 File Offset: 0x0001B738
		[Token(Token = "0x170005C3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 ww
		{
			[Token(Token = "0x60014AE")]
			[Address(RVA = "0x57C0410", Offset = "0x57BF010", VA = "0x1857C0410")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x170005C4 RID: 1476
		[Token(Token = "0x170005C4")]
		public float this[int index]
		{
			[Token(Token = "0x60014AF")]
			[Address(RVA = "0x57A9B60", Offset = "0x57A8760", VA = "0x1857A9B60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60014B0")]
			[Address(RVA = "0x57AA610", Offset = "0x57A9210", VA = "0x1857AA610")]
			set
			{
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0001D568 File Offset: 0x0001B768
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x4E32FB0", Offset = "0x4E31BB0", VA = "0x184E32FB0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float4 rhs)
		{
			return default(bool);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0001D580 File Offset: 0x0001B780
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x57BFC20", Offset = "0x57BE820", VA = "0x1857BFC20", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0001D598 File Offset: 0x0001B798
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x571D580", Offset = "0x571C180", VA = "0x18571D580", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x57BFCE0", Offset = "0x57BE8E0", VA = "0x1857BFCE0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x57BFEF0", Offset = "0x57BEAF0", VA = "0x1857BFEF0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
		public static implicit operator float4(Vector4 v)
		{
			return default(float4);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
		public static implicit operator Vector4(float4 v)
		{
			return default(Vector4);
		}

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0xC")]
		public float w;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float4 zero;

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014B8")]
			[Address(RVA = "0x5764CD0", Offset = "0x57638D0", VA = "0x185764CD0")]
			public DebuggerProxy(float4 v)
			{
			}

			// Token: 0x040000C0 RID: 192
			[Token(Token = "0x40000C0")]
			[FieldOffset(Offset = "0x10")]
			public float x;

			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			[FieldOffset(Offset = "0x14")]
			public float y;

			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			[FieldOffset(Offset = "0x18")]
			public float z;

			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x40000C3")]
			[FieldOffset(Offset = "0x1C")]
			public float w;
		}
	}
}
