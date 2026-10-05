using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[DebuggerTypeProxy(typeof(double2.DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct double2 : IEquatable<double2>, IFormattable
	{
		// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x4007240", Offset = "0x4005E40", VA = "0x184007240")]
		[MethodImpl(256)]
		public double2(double x, double y)
		{
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x57835D0", Offset = "0x57821D0", VA = "0x1857835D0")]
		[MethodImpl(256)]
		public double2(double2 xy)
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x5783660", Offset = "0x5782260", VA = "0x185783660")]
		[MethodImpl(256)]
		public double2(double v)
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x5783670", Offset = "0x5782270", VA = "0x185783670")]
		[MethodImpl(256)]
		public double2(bool v)
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x57835E0", Offset = "0x57821E0", VA = "0x1857835E0")]
		[MethodImpl(256)]
		public double2(bool2 v)
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x57836C0", Offset = "0x57822C0", VA = "0x1857836C0")]
		[MethodImpl(256)]
		public double2(int v)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x5783640", Offset = "0x5782240", VA = "0x185783640")]
		[MethodImpl(256)]
		public double2(int2 v)
		{
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x57836A0", Offset = "0x57822A0", VA = "0x1857836A0")]
		[MethodImpl(256)]
		public double2(uint v)
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x57836D0", Offset = "0x57822D0", VA = "0x1857836D0")]
		[MethodImpl(256)]
		public double2(uint2 v)
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x56FB470", Offset = "0x56FA070", VA = "0x1856FB470")]
		[MethodImpl(256)]
		public double2(half v)
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x56FB370", Offset = "0x56F9F70", VA = "0x1856FB370")]
		[MethodImpl(256)]
		public double2(half2 v)
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x57836F0", Offset = "0x57822F0", VA = "0x1857836F0")]
		[MethodImpl(256)]
		public double2(float v)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x5783610", Offset = "0x5782210", VA = "0x185783610")]
		[MethodImpl(256)]
		public double2(float2 v)
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00011658 File Offset: 0x0000F858
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x570E290", Offset = "0x570CE90", VA = "0x18570E290")]
		[MethodImpl(256)]
		public static implicit operator double2(double v)
		{
			return default(double2);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00011670 File Offset: 0x0000F870
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x570E250", Offset = "0x570CE50", VA = "0x18570E250")]
		[MethodImpl(256)]
		public static explicit operator double2(bool v)
		{
			return default(double2);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00011688 File Offset: 0x0000F888
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x570E050", Offset = "0x570CC50", VA = "0x18570E050")]
		[MethodImpl(256)]
		public static explicit operator double2(bool2 v)
		{
			return default(double2);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000116A0 File Offset: 0x0000F8A0
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x570E0F0", Offset = "0x570CCF0", VA = "0x18570E0F0")]
		[MethodImpl(256)]
		public static implicit operator double2(int v)
		{
			return default(double2);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x000116B8 File Offset: 0x0000F8B8
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x570E090", Offset = "0x570CC90", VA = "0x18570E090")]
		[MethodImpl(256)]
		public static implicit operator double2(int2 v)
		{
			return default(double2);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000116D0 File Offset: 0x0000F8D0
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x570E000", Offset = "0x570CC00", VA = "0x18570E000")]
		[MethodImpl(256)]
		public static implicit operator double2(uint v)
		{
			return default(double2);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000116E8 File Offset: 0x0000F8E8
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x570E0C0", Offset = "0x570CCC0", VA = "0x18570E0C0")]
		[MethodImpl(256)]
		public static implicit operator double2(uint2 v)
		{
			return default(double2);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00011700 File Offset: 0x0000F900
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x5783D40", Offset = "0x5782940", VA = "0x185783D40")]
		[MethodImpl(256)]
		public static implicit operator double2(half v)
		{
			return default(double2);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x5783D20", Offset = "0x5782920", VA = "0x185783D20")]
		[MethodImpl(256)]
		public static implicit operator double2(half2 v)
		{
			return default(double2);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00011730 File Offset: 0x0000F930
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x570E110", Offset = "0x570CD10", VA = "0x18570E110")]
		[MethodImpl(256)]
		public static implicit operator double2(float v)
		{
			return default(double2);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x570E020", Offset = "0x570CC20", VA = "0x18570E020")]
		[MethodImpl(256)]
		public static implicit operator double2(float2 v)
		{
			return default(double2);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00011760 File Offset: 0x0000F960
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x5783FE0", Offset = "0x5782BE0", VA = "0x185783FE0")]
		[MethodImpl(256)]
		public static double2 operator *(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x5784030", Offset = "0x5782C30", VA = "0x185784030")]
		[MethodImpl(256)]
		public static double2 operator *(double2 lhs, double rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00011790 File Offset: 0x0000F990
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x5784010", Offset = "0x5782C10", VA = "0x185784010")]
		[MethodImpl(256)]
		public static double2 operator *(double lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x5783AA0", Offset = "0x57826A0", VA = "0x185783AA0")]
		[MethodImpl(256)]
		public static double2 operator +(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x5783A80", Offset = "0x5782680", VA = "0x185783A80")]
		[MethodImpl(256)]
		public static double2 operator +(double2 lhs, double rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x5783A60", Offset = "0x5782660", VA = "0x185783A60")]
		[MethodImpl(256)]
		public static double2 operator +(double lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x5784090", Offset = "0x5782C90", VA = "0x185784090")]
		[MethodImpl(256)]
		public static double2 operator -(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x5784050", Offset = "0x5782C50", VA = "0x185784050")]
		[MethodImpl(256)]
		public static double2 operator -(double2 lhs, double rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00011820 File Offset: 0x0000FA20
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x5784070", Offset = "0x5782C70", VA = "0x185784070")]
		[MethodImpl(256)]
		public static double2 operator -(double lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x5783B30", Offset = "0x5782730", VA = "0x185783B30")]
		[MethodImpl(256)]
		public static double2 operator /(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x5783B10", Offset = "0x5782710", VA = "0x185783B10")]
		[MethodImpl(256)]
		public static double2 operator /(double2 lhs, double rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x5783AF0", Offset = "0x57826F0", VA = "0x185783AF0")]
		[MethodImpl(256)]
		public static double2 operator /(double lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x571A800", Offset = "0x5719400", VA = "0x18571A800")]
		[MethodImpl(256)]
		public static double2 operator %(double2 lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x5783F40", Offset = "0x5782B40", VA = "0x185783F40")]
		[MethodImpl(256)]
		public static double2 operator %(double2 lhs, double rhs)
		{
			return default(double2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x5783F90", Offset = "0x5782B90", VA = "0x185783F90")]
		[MethodImpl(256)]
		public static double2 operator %(double lhs, double2 rhs)
		{
			return default(double2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x5783D60", Offset = "0x5782960", VA = "0x185783D60")]
		[MethodImpl(256)]
		public static double2 operator ++(double2 val)
		{
			return default(double2);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x5783AD0", Offset = "0x57826D0", VA = "0x185783AD0")]
		[MethodImpl(256)]
		public static double2 operator --(double2 val)
		{
			return default(double2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000118F8 File Offset: 0x0000FAF8
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x5783F10", Offset = "0x5782B10", VA = "0x185783F10")]
		[MethodImpl(256)]
		public static bool2 operator <(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x5783EF0", Offset = "0x5782AF0", VA = "0x185783EF0")]
		[MethodImpl(256)]
		public static bool2 operator <(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00011928 File Offset: 0x0000FB28
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x5783EC0", Offset = "0x5782AC0", VA = "0x185783EC0")]
		[MethodImpl(256)]
		public static bool2 operator <(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00011940 File Offset: 0x0000FB40
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x5783E40", Offset = "0x5782A40", VA = "0x185783E40")]
		[MethodImpl(256)]
		public static bool2 operator <=(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x5783EA0", Offset = "0x5782AA0", VA = "0x185783EA0")]
		[MethodImpl(256)]
		public static bool2 operator <=(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x5783E70", Offset = "0x5782A70", VA = "0x185783E70")]
		[MethodImpl(256)]
		public static bool2 operator <=(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00011988 File Offset: 0x0000FB88
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x5783CA0", Offset = "0x57828A0", VA = "0x185783CA0")]
		[MethodImpl(256)]
		public static bool2 operator >(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000119A0 File Offset: 0x0000FBA0
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x5783CF0", Offset = "0x57828F0", VA = "0x185783CF0")]
		[MethodImpl(256)]
		public static bool2 operator >(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000119B8 File Offset: 0x0000FBB8
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x5783CD0", Offset = "0x57828D0", VA = "0x185783CD0")]
		[MethodImpl(256)]
		public static bool2 operator >(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x000119D0 File Offset: 0x0000FBD0
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x5783C40", Offset = "0x5782840", VA = "0x185783C40")]
		[MethodImpl(256)]
		public static bool2 operator >=(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000119E8 File Offset: 0x0000FBE8
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x5783C70", Offset = "0x5782870", VA = "0x185783C70")]
		[MethodImpl(256)]
		public static bool2 operator >=(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00011A00 File Offset: 0x0000FC00
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x5783C20", Offset = "0x5782820", VA = "0x185783C20")]
		[MethodImpl(256)]
		public static bool2 operator >=(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00011A18 File Offset: 0x0000FC18
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x57840C0", Offset = "0x5782CC0", VA = "0x1857840C0")]
		[MethodImpl(256)]
		public static double2 operator -(double2 val)
		{
			return default(double2);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00011A30 File Offset: 0x0000FC30
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x5510D10", Offset = "0x550F910", VA = "0x185510D10")]
		[MethodImpl(256)]
		public static double2 operator +(double2 val)
		{
			return default(double2);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00011A48 File Offset: 0x0000FC48
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x5783B60", Offset = "0x5782760", VA = "0x185783B60")]
		[MethodImpl(256)]
		public static bool2 operator ==(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00011A60 File Offset: 0x0000FC60
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x5783BA0", Offset = "0x57827A0", VA = "0x185783BA0")]
		[MethodImpl(256)]
		public static bool2 operator ==(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00011A78 File Offset: 0x0000FC78
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x5783BE0", Offset = "0x57827E0", VA = "0x185783BE0")]
		[MethodImpl(256)]
		public static bool2 operator ==(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00011A90 File Offset: 0x0000FC90
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x5783E00", Offset = "0x5782A00", VA = "0x185783E00")]
		[MethodImpl(256)]
		public static bool2 operator !=(double2 lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x5783DC0", Offset = "0x57829C0", VA = "0x185783DC0")]
		[MethodImpl(256)]
		public static bool2 operator !=(double2 lhs, double rhs)
		{
			return default(bool2);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x5783D80", Offset = "0x5782980", VA = "0x185783D80")]
		[MethodImpl(256)]
		public static bool2 operator !=(double lhs, double2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[Token(Token = "0x170001EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxx
		{
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x5783750", Offset = "0x5782350", VA = "0x185783750")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[Token(Token = "0x170001EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxy
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x5783770", Offset = "0x5782370", VA = "0x185783770")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x170001F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyx
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x57837B0", Offset = "0x57823B0", VA = "0x1857837B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00011B20 File Offset: 0x0000FD20
		[Token(Token = "0x170001F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyy
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x57837D0", Offset = "0x57823D0", VA = "0x1857837D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00011B38 File Offset: 0x0000FD38
		[Token(Token = "0x170001F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxx
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x5783810", Offset = "0x5782410", VA = "0x185783810")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00011B50 File Offset: 0x0000FD50
		[Token(Token = "0x170001F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxy
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x5783830", Offset = "0x5782430", VA = "0x185783830")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00011B68 File Offset: 0x0000FD68
		[Token(Token = "0x170001F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyx
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x5783870", Offset = "0x5782470", VA = "0x185783870")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00011B80 File Offset: 0x0000FD80
		[Token(Token = "0x170001F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyy
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x5783890", Offset = "0x5782490", VA = "0x185783890")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00011B98 File Offset: 0x0000FD98
		[Token(Token = "0x170001F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxx
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x57838F0", Offset = "0x57824F0", VA = "0x1857838F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		[Token(Token = "0x170001F7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxy
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x5783910", Offset = "0x5782510", VA = "0x185783910")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[Token(Token = "0x170001F8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyx
		{
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x5783950", Offset = "0x5782550", VA = "0x185783950")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		[Token(Token = "0x170001F9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyy
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x5783970", Offset = "0x5782570", VA = "0x185783970")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		[Token(Token = "0x170001FA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxx
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x57839C0", Offset = "0x57825C0", VA = "0x1857839C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00011C10 File Offset: 0x0000FE10
		[Token(Token = "0x170001FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxy
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x57839E0", Offset = "0x57825E0", VA = "0x1857839E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00011C28 File Offset: 0x0000FE28
		[Token(Token = "0x170001FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyx
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x5783A20", Offset = "0x5782620", VA = "0x185783A20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00011C40 File Offset: 0x0000FE40
		[Token(Token = "0x170001FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyy
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x5783A40", Offset = "0x5782640", VA = "0x185783A40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x170001FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxx
		{
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x5783730", Offset = "0x5782330", VA = "0x185783730")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00011C70 File Offset: 0x0000FE70
		[Token(Token = "0x170001FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxy
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x5783790", Offset = "0x5782390", VA = "0x185783790")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00011C88 File Offset: 0x0000FE88
		[Token(Token = "0x17000200")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyx
		{
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x57837F0", Offset = "0x57823F0", VA = "0x1857837F0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		[Token(Token = "0x17000201")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyy
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x5783850", Offset = "0x5782450", VA = "0x185783850")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		[Token(Token = "0x17000202")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxx
		{
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x57838D0", Offset = "0x57824D0", VA = "0x1857838D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00011CD0 File Offset: 0x0000FED0
		[Token(Token = "0x17000203")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxy
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x5783930", Offset = "0x5782530", VA = "0x185783930")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		[Token(Token = "0x17000204")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyx
		{
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x57839A0", Offset = "0x57825A0", VA = "0x1857839A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00011D00 File Offset: 0x0000FF00
		[Token(Token = "0x17000205")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyy
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x5783A00", Offset = "0x5782600", VA = "0x185783A00")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00011D18 File Offset: 0x0000FF18
		[Token(Token = "0x17000206")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xx
		{
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x5783720", Offset = "0x5782320", VA = "0x185783720")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00011D30 File Offset: 0x0000FF30
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000207")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xy
		{
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x5510D10", Offset = "0x550F910", VA = "0x185510D10")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x57835D0", Offset = "0x57821D0", VA = "0x1857835D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00011D48 File Offset: 0x0000FF48
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000208")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yx
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x57838B0", Offset = "0x57824B0", VA = "0x1857838B0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x57840F0", Offset = "0x5782CF0", VA = "0x1857840F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00011D60 File Offset: 0x0000FF60
		[Token(Token = "0x17000209")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yy
		{
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x5783990", Offset = "0x5782590", VA = "0x185783990")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x1700020A RID: 522
		[Token(Token = "0x1700020A")]
		public double this[int index]
		{
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x5783710", Offset = "0x5782310", VA = "0x185783710")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x57840E0", Offset = "0x5782CE0", VA = "0x1857840E0")]
			set
			{
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00011D90 File Offset: 0x0000FF90
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x57833F0", Offset = "0x5781FF0", VA = "0x1857833F0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(double2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x5783410", Offset = "0x5782010", VA = "0x185783410", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x571E6C0", Offset = "0x571D2C0", VA = "0x18571E6C0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x5783540", Offset = "0x5782140", VA = "0x185783540", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x57834B0", Offset = "0x57820B0", VA = "0x1857834B0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double2 zero;

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x577F740", Offset = "0x577E340", VA = "0x18577F740")]
			public DebuggerProxy(double2 v)
			{
			}

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			[FieldOffset(Offset = "0x10")]
			public double x;

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x18")]
			public double y;
		}
	}
}
