using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(double3.DebuggerProxy))]
	[Serializable]
	public struct double3 : IEquatable<double3>, IFormattable
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x5789EF0", Offset = "0x5788AF0", VA = "0x185789EF0")]
		[MethodImpl(256)]
		public double3(double x, double y, double z)
		{
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x5789DA0", Offset = "0x57889A0", VA = "0x185789DA0")]
		[MethodImpl(256)]
		public double3(double x, double2 yz)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x5789D50", Offset = "0x5788950", VA = "0x185789D50")]
		[MethodImpl(256)]
		public double3(double2 xy, double z)
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x5789DE0", Offset = "0x57889E0", VA = "0x185789DE0")]
		[MethodImpl(256)]
		public double3(double3 xyz)
		{
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x5789E50", Offset = "0x5788A50", VA = "0x185789E50")]
		[MethodImpl(256)]
		public double3(double v)
		{
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x5789E60", Offset = "0x5788A60", VA = "0x185789E60")]
		[MethodImpl(256)]
		public double3(bool v)
		{
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x5789E00", Offset = "0x5788A00", VA = "0x185789E00")]
		[MethodImpl(256)]
		public double3(bool3 v)
		{
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x5789DC0", Offset = "0x57889C0", VA = "0x185789DC0")]
		[MethodImpl(256)]
		public double3(int v)
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x5789D70", Offset = "0x5788970", VA = "0x185789D70")]
		[MethodImpl(256)]
		public double3(int3 v)
		{
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x5789EA0", Offset = "0x5788AA0", VA = "0x185789EA0")]
		[MethodImpl(256)]
		public double3(uint v)
		{
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x5789EC0", Offset = "0x5788AC0", VA = "0x185789EC0")]
		[MethodImpl(256)]
		public double3(uint3 v)
		{
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x56FB610", Offset = "0x56FA210", VA = "0x1856FB610")]
		[MethodImpl(256)]
		public double3(half v)
		{
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x56FB760", Offset = "0x56FA360", VA = "0x1856FB760")]
		[MethodImpl(256)]
		public double3(half3 v)
		{
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x5789D20", Offset = "0x5788920", VA = "0x185789D20")]
		[MethodImpl(256)]
		public double3(float v)
		{
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x5789CF0", Offset = "0x57888F0", VA = "0x185789CF0")]
		[MethodImpl(256)]
		public double3(float3 v)
		{
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x570F120", Offset = "0x570DD20", VA = "0x18570F120")]
		[MethodImpl(256)]
		public static implicit operator double3(double v)
		{
			return default(double3);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00012BB8 File Offset: 0x00010DB8
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x570F280", Offset = "0x570DE80", VA = "0x18570F280")]
		[MethodImpl(256)]
		public static explicit operator double3(bool v)
		{
			return default(double3);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00012BD0 File Offset: 0x00010DD0
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x570F130", Offset = "0x570DD30", VA = "0x18570F130")]
		[MethodImpl(256)]
		public static explicit operator double3(bool3 v)
		{
			return default(double3);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00012BE8 File Offset: 0x00010DE8
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x570F240", Offset = "0x570DE40", VA = "0x18570F240")]
		[MethodImpl(256)]
		public static implicit operator double3(int v)
		{
			return default(double3);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00012C00 File Offset: 0x00010E00
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x570EF10", Offset = "0x570DB10", VA = "0x18570EF10")]
		[MethodImpl(256)]
		public static implicit operator double3(int3 v)
		{
			return default(double3);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00012C18 File Offset: 0x00010E18
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x570F0E0", Offset = "0x570DCE0", VA = "0x18570F0E0")]
		[MethodImpl(256)]
		public static implicit operator double3(uint v)
		{
			return default(double3);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00012C30 File Offset: 0x00010E30
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x570F1B0", Offset = "0x570DDB0", VA = "0x18570F1B0")]
		[MethodImpl(256)]
		public static implicit operator double3(uint3 v)
		{
			return default(double3);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00012C48 File Offset: 0x00010E48
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x578AEE0", Offset = "0x5789AE0", VA = "0x18578AEE0")]
		[MethodImpl(256)]
		public static implicit operator double3(half v)
		{
			return default(double3);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00012C60 File Offset: 0x00010E60
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x578AF10", Offset = "0x5789B10", VA = "0x18578AF10")]
		[MethodImpl(256)]
		public static implicit operator double3(half3 v)
		{
			return default(double3);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00012C78 File Offset: 0x00010E78
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x570EEE0", Offset = "0x570DAE0", VA = "0x18570EEE0")]
		[MethodImpl(256)]
		public static implicit operator double3(float v)
		{
			return default(double3);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00012C90 File Offset: 0x00010E90
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x570F410", Offset = "0x570E010", VA = "0x18570F410")]
		[MethodImpl(256)]
		public static implicit operator double3(float3 v)
		{
			return default(double3);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x578B2F0", Offset = "0x5789EF0", VA = "0x18578B2F0")]
		[MethodImpl(256)]
		public static double3 operator *(double3 lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00012CC0 File Offset: 0x00010EC0
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x578B2D0", Offset = "0x5789ED0", VA = "0x18578B2D0")]
		[MethodImpl(256)]
		public static double3 operator *(double3 lhs, double rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x578B2B0", Offset = "0x5789EB0", VA = "0x18578B2B0")]
		[MethodImpl(256)]
		public static double3 operator *(double lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00012CF0 File Offset: 0x00010EF0
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x578AB90", Offset = "0x5789790", VA = "0x18578AB90")]
		[MethodImpl(256)]
		public static double3 operator +(double3 lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x578AB70", Offset = "0x5789770", VA = "0x18578AB70")]
		[MethodImpl(256)]
		public static double3 operator +(double3 lhs, double rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00012D20 File Offset: 0x00010F20
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x578AB50", Offset = "0x5789750", VA = "0x18578AB50")]
		[MethodImpl(256)]
		public static double3 operator +(double lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00012D38 File Offset: 0x00010F38
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x578B350", Offset = "0x5789F50", VA = "0x18578B350")]
		[MethodImpl(256)]
		public static double3 operator -(double3 lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x578B330", Offset = "0x5789F30", VA = "0x18578B330")]
		[MethodImpl(256)]
		public static double3 operator -(double3 lhs, double rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00012D68 File Offset: 0x00010F68
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x578B390", Offset = "0x5789F90", VA = "0x18578B390")]
		[MethodImpl(256)]
		public static double3 operator -(double lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00012D80 File Offset: 0x00010F80
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x578AC00", Offset = "0x5789800", VA = "0x18578AC00")]
		[MethodImpl(256)]
		public static double3 operator /(double3 lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00012D98 File Offset: 0x00010F98
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x578AC40", Offset = "0x5789840", VA = "0x18578AC40")]
		[MethodImpl(256)]
		public static double3 operator /(double3 lhs, double rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x578AC60", Offset = "0x5789860", VA = "0x18578AC60")]
		[MethodImpl(256)]
		public static double3 operator /(double lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x571A640", Offset = "0x5719240", VA = "0x18571A640")]
		[MethodImpl(256)]
		public static double3 operator %(double3 lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00012DE0 File Offset: 0x00010FE0
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x578B1F0", Offset = "0x5789DF0", VA = "0x18578B1F0")]
		[MethodImpl(256)]
		public static double3 operator %(double3 lhs, double rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x578B250", Offset = "0x5789E50", VA = "0x18578B250")]
		[MethodImpl(256)]
		public static double3 operator %(double lhs, double3 rhs)
		{
			return default(double3);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00012E10 File Offset: 0x00011010
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x578AF50", Offset = "0x5789B50", VA = "0x18578AF50")]
		[MethodImpl(256)]
		public static double3 operator ++(double3 val)
		{
			return default(double3);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00012E28 File Offset: 0x00011028
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x578ABD0", Offset = "0x57897D0", VA = "0x18578ABD0")]
		[MethodImpl(256)]
		public static double3 operator --(double3 val)
		{
			return default(double3);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00012E40 File Offset: 0x00011040
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x578B140", Offset = "0x5789D40", VA = "0x18578B140")]
		[MethodImpl(256)]
		public static bool3 operator <(double3 lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00012E58 File Offset: 0x00011058
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x578B180", Offset = "0x5789D80", VA = "0x18578B180")]
		[MethodImpl(256)]
		public static bool3 operator <(double3 lhs, double rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x578B1B0", Offset = "0x5789DB0", VA = "0x18578B1B0")]
		[MethodImpl(256)]
		public static bool3 operator <(double lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00012E88 File Offset: 0x00011088
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x578B090", Offset = "0x5789C90", VA = "0x18578B090")]
		[MethodImpl(256)]
		public static bool3 operator <=(double3 lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00012EA0 File Offset: 0x000110A0
		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x578B110", Offset = "0x5789D10", VA = "0x18578B110")]
		[MethodImpl(256)]
		public static bool3 operator <=(double3 lhs, double rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x578B0D0", Offset = "0x5789CD0", VA = "0x18578B0D0")]
		[MethodImpl(256)]
		public static bool3 operator <=(double lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x578AE70", Offset = "0x5789A70", VA = "0x18578AE70")]
		[MethodImpl(256)]
		public static bool3 operator >(double3 lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00012EE8 File Offset: 0x000110E8
		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x578AE40", Offset = "0x5789A40", VA = "0x18578AE40")]
		[MethodImpl(256)]
		public static bool3 operator >(double3 lhs, double rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x578AEB0", Offset = "0x5789AB0", VA = "0x18578AEB0")]
		[MethodImpl(256)]
		public static bool3 operator >(double lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x578ADD0", Offset = "0x57899D0", VA = "0x18578ADD0")]
		[MethodImpl(256)]
		public static bool3 operator >=(double3 lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x578AE10", Offset = "0x5789A10", VA = "0x18578AE10")]
		[MethodImpl(256)]
		public static bool3 operator >=(double3 lhs, double rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x578ADA0", Offset = "0x57899A0", VA = "0x18578ADA0")]
		[MethodImpl(256)]
		public static bool3 operator >=(double lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x578B3C0", Offset = "0x5789FC0", VA = "0x18578B3C0")]
		[MethodImpl(256)]
		public static double3 operator -(double3 val)
		{
			return default(double3);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x578A010", Offset = "0x5788C10", VA = "0x18578A010")]
		[MethodImpl(256)]
		public static double3 operator +(double3 val)
		{
			return default(double3);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00012F90 File Offset: 0x00011190
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x578AC90", Offset = "0x5789890", VA = "0x18578AC90")]
		[MethodImpl(256)]
		public static bool3 operator ==(double3 lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00012FA8 File Offset: 0x000111A8
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x578ACF0", Offset = "0x57898F0", VA = "0x18578ACF0")]
		[MethodImpl(256)]
		public static bool3 operator ==(double3 lhs, double rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x578AD50", Offset = "0x5789950", VA = "0x18578AD50")]
		[MethodImpl(256)]
		public static bool3 operator ==(double lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x578AFE0", Offset = "0x5789BE0", VA = "0x18578AFE0")]
		[MethodImpl(256)]
		public static bool3 operator !=(double3 lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00012FF0 File Offset: 0x000111F0
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x578AF80", Offset = "0x5789B80", VA = "0x18578AF80")]
		[MethodImpl(256)]
		public static bool3 operator !=(double3 lhs, double rhs)
		{
			return default(bool3);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x578B040", Offset = "0x5789C40", VA = "0x18578B040")]
		[MethodImpl(256)]
		public static bool3 operator !=(double lhs, double3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x1700020E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxx
		{
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x5783750", Offset = "0x5782350", VA = "0x185783750")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x1700020F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxy
		{
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x5783770", Offset = "0x5782370", VA = "0x185783770")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x17000210")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxxz
		{
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x5789F00", Offset = "0x5788B00", VA = "0x185789F00")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x17000211")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyx
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x57837B0", Offset = "0x57823B0", VA = "0x1857837B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x17000212")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyy
		{
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x57837D0", Offset = "0x57823D0", VA = "0x1857837D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00013098 File Offset: 0x00011298
		[Token(Token = "0x17000213")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxyz
		{
			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x5789F20", Offset = "0x5788B20", VA = "0x185789F20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x000130B0 File Offset: 0x000112B0
		[Token(Token = "0x17000214")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxzx
		{
			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x5789F60", Offset = "0x5788B60", VA = "0x185789F60")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x000130C8 File Offset: 0x000112C8
		[Token(Token = "0x17000215")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxzy
		{
			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x5789F80", Offset = "0x5788B80", VA = "0x185789F80")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x17000216")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xxzz
		{
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x5789FA0", Offset = "0x5788BA0", VA = "0x185789FA0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000130F8 File Offset: 0x000112F8
		[Token(Token = "0x17000217")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxx
		{
			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x5783810", Offset = "0x5782410", VA = "0x185783810")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00013110 File Offset: 0x00011310
		[Token(Token = "0x17000218")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxy
		{
			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x5783830", Offset = "0x5782430", VA = "0x185783830")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00013128 File Offset: 0x00011328
		[Token(Token = "0x17000219")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyxz
		{
			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x5789FC0", Offset = "0x5788BC0", VA = "0x185789FC0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x1700021A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyx
		{
			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x5783870", Offset = "0x5782470", VA = "0x185783870")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x1700021B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyy
		{
			[Token(Token = "0x6000C48")]
			[Address(RVA = "0x5783890", Offset = "0x5782490", VA = "0x185783890")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00013170 File Offset: 0x00011370
		[Token(Token = "0x1700021C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyyz
		{
			[Token(Token = "0x6000C49")]
			[Address(RVA = "0x5789FF0", Offset = "0x5788BF0", VA = "0x185789FF0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00013188 File Offset: 0x00011388
		[Token(Token = "0x1700021D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyzx
		{
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x578A030", Offset = "0x5788C30", VA = "0x18578A030")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x1700021E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyzy
		{
			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x578A060", Offset = "0x5788C60", VA = "0x18578A060")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x1700021F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xyzz
		{
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x578A090", Offset = "0x5788C90", VA = "0x18578A090")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x000131D0 File Offset: 0x000113D0
		[Token(Token = "0x17000220")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzxx
		{
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x578A0F0", Offset = "0x5788CF0", VA = "0x18578A0F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x17000221")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzxy
		{
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0x578A110", Offset = "0x5788D10", VA = "0x18578A110")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00013200 File Offset: 0x00011400
		[Token(Token = "0x17000222")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzxz
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x578A140", Offset = "0x5788D40", VA = "0x18578A140")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00013218 File Offset: 0x00011418
		[Token(Token = "0x17000223")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzyx
		{
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x578A180", Offset = "0x5788D80", VA = "0x18578A180")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x17000224")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzyy
		{
			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x578A1B0", Offset = "0x5788DB0", VA = "0x18578A1B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x17000225")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzyz
		{
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x578A1D0", Offset = "0x5788DD0", VA = "0x18578A1D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x17000226")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzzx
		{
			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x578A220", Offset = "0x5788E20", VA = "0x18578A220")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x17000227")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzzy
		{
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x578A240", Offset = "0x5788E40", VA = "0x18578A240")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x17000228")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 xzzz
		{
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x578A260", Offset = "0x5788E60", VA = "0x18578A260")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x000132A8 File Offset: 0x000114A8
		[Token(Token = "0x17000229")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxx
		{
			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x57838F0", Offset = "0x57824F0", VA = "0x1857838F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x000132C0 File Offset: 0x000114C0
		[Token(Token = "0x1700022A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxy
		{
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x5783910", Offset = "0x5782510", VA = "0x185783910")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x1700022B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxxz
		{
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x578A280", Offset = "0x5788E80", VA = "0x18578A280")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x000132F0 File Offset: 0x000114F0
		[Token(Token = "0x1700022C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyx
		{
			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x5783950", Offset = "0x5782550", VA = "0x185783950")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00013308 File Offset: 0x00011508
		[Token(Token = "0x1700022D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyy
		{
			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x5783970", Offset = "0x5782570", VA = "0x185783970")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00013320 File Offset: 0x00011520
		[Token(Token = "0x1700022E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxyz
		{
			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x578A2A0", Offset = "0x5788EA0", VA = "0x18578A2A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00013338 File Offset: 0x00011538
		[Token(Token = "0x1700022F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxzx
		{
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x578A2F0", Offset = "0x5788EF0", VA = "0x18578A2F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00013350 File Offset: 0x00011550
		[Token(Token = "0x17000230")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxzy
		{
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x578A320", Offset = "0x5788F20", VA = "0x18578A320")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00013368 File Offset: 0x00011568
		[Token(Token = "0x17000231")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yxzz
		{
			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x578A350", Offset = "0x5788F50", VA = "0x18578A350")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00013380 File Offset: 0x00011580
		[Token(Token = "0x17000232")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxx
		{
			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x57839C0", Offset = "0x57825C0", VA = "0x1857839C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x17000233")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxy
		{
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x57839E0", Offset = "0x57825E0", VA = "0x1857839E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x17000234")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyxz
		{
			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x578A370", Offset = "0x5788F70", VA = "0x18578A370")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000133C8 File Offset: 0x000115C8
		[Token(Token = "0x17000235")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyx
		{
			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x5783A20", Offset = "0x5782620", VA = "0x185783A20")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x000133E0 File Offset: 0x000115E0
		[Token(Token = "0x17000236")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyy
		{
			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x5783A40", Offset = "0x5782640", VA = "0x185783A40")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000133F8 File Offset: 0x000115F8
		[Token(Token = "0x17000237")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyyz
		{
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x578A390", Offset = "0x5788F90", VA = "0x18578A390")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00013410 File Offset: 0x00011610
		[Token(Token = "0x17000238")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyzx
		{
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x578A3D0", Offset = "0x5788FD0", VA = "0x18578A3D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00013428 File Offset: 0x00011628
		[Token(Token = "0x17000239")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyzy
		{
			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x578A3F0", Offset = "0x5788FF0", VA = "0x18578A3F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00013440 File Offset: 0x00011640
		[Token(Token = "0x1700023A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yyzz
		{
			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x578A410", Offset = "0x5789010", VA = "0x18578A410")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00013458 File Offset: 0x00011658
		[Token(Token = "0x1700023B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzxx
		{
			[Token(Token = "0x6000C68")]
			[Address(RVA = "0x578A470", Offset = "0x5789070", VA = "0x18578A470")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00013470 File Offset: 0x00011670
		[Token(Token = "0x1700023C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzxy
		{
			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x578A490", Offset = "0x5789090", VA = "0x18578A490")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00013488 File Offset: 0x00011688
		[Token(Token = "0x1700023D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzxz
		{
			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x578A4C0", Offset = "0x57890C0", VA = "0x18578A4C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000134A0 File Offset: 0x000116A0
		[Token(Token = "0x1700023E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzyx
		{
			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x578A510", Offset = "0x5789110", VA = "0x18578A510")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000134B8 File Offset: 0x000116B8
		[Token(Token = "0x1700023F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzyy
		{
			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x578A540", Offset = "0x5789140", VA = "0x18578A540")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000134D0 File Offset: 0x000116D0
		[Token(Token = "0x17000240")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzyz
		{
			[Token(Token = "0x6000C6D")]
			[Address(RVA = "0x578A560", Offset = "0x5789160", VA = "0x18578A560")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x17000241")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzzx
		{
			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x578A5B0", Offset = "0x57891B0", VA = "0x18578A5B0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00013500 File Offset: 0x00011700
		[Token(Token = "0x17000242")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzzy
		{
			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x578A5D0", Offset = "0x57891D0", VA = "0x18578A5D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00013518 File Offset: 0x00011718
		[Token(Token = "0x17000243")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 yzzz
		{
			[Token(Token = "0x6000C70")]
			[Address(RVA = "0x578A5F0", Offset = "0x57891F0", VA = "0x18578A5F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00013530 File Offset: 0x00011730
		[Token(Token = "0x17000244")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxxx
		{
			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x578A650", Offset = "0x5789250", VA = "0x18578A650")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00013548 File Offset: 0x00011748
		[Token(Token = "0x17000245")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxxy
		{
			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x578A670", Offset = "0x5789270", VA = "0x18578A670")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00013560 File Offset: 0x00011760
		[Token(Token = "0x17000246")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxxz
		{
			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x578A690", Offset = "0x5789290", VA = "0x18578A690")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x17000247")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxyx
		{
			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x578A6D0", Offset = "0x57892D0", VA = "0x18578A6D0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00013590 File Offset: 0x00011790
		[Token(Token = "0x17000248")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxyy
		{
			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x578A700", Offset = "0x5789300", VA = "0x18578A700")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x000135A8 File Offset: 0x000117A8
		[Token(Token = "0x17000249")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxyz
		{
			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x578A720", Offset = "0x5789320", VA = "0x18578A720")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000135C0 File Offset: 0x000117C0
		[Token(Token = "0x1700024A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxzx
		{
			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x578A770", Offset = "0x5789370", VA = "0x18578A770")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x000135D8 File Offset: 0x000117D8
		[Token(Token = "0x1700024B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxzy
		{
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x578A790", Offset = "0x5789390", VA = "0x18578A790")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000135F0 File Offset: 0x000117F0
		[Token(Token = "0x1700024C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zxzz
		{
			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x578A7C0", Offset = "0x57893C0", VA = "0x18578A7C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00013608 File Offset: 0x00011808
		[Token(Token = "0x1700024D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyxx
		{
			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x578A820", Offset = "0x5789420", VA = "0x18578A820")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00013620 File Offset: 0x00011820
		[Token(Token = "0x1700024E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyxy
		{
			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x578A840", Offset = "0x5789440", VA = "0x18578A840")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00013638 File Offset: 0x00011838
		[Token(Token = "0x1700024F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyxz
		{
			[Token(Token = "0x6000C7C")]
			[Address(RVA = "0x578A870", Offset = "0x5789470", VA = "0x18578A870")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00013650 File Offset: 0x00011850
		[Token(Token = "0x17000250")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyyx
		{
			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x578A8C0", Offset = "0x57894C0", VA = "0x18578A8C0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00013668 File Offset: 0x00011868
		[Token(Token = "0x17000251")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyyy
		{
			[Token(Token = "0x6000C7E")]
			[Address(RVA = "0x578A8E0", Offset = "0x57894E0", VA = "0x18578A8E0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00013680 File Offset: 0x00011880
		[Token(Token = "0x17000252")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyyz
		{
			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0x578A900", Offset = "0x5789500", VA = "0x18578A900")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00013698 File Offset: 0x00011898
		[Token(Token = "0x17000253")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyzx
		{
			[Token(Token = "0x6000C80")]
			[Address(RVA = "0x578A940", Offset = "0x5789540", VA = "0x18578A940")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x000136B0 File Offset: 0x000118B0
		[Token(Token = "0x17000254")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyzy
		{
			[Token(Token = "0x6000C81")]
			[Address(RVA = "0x578A970", Offset = "0x5789570", VA = "0x18578A970")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x17000255")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zyzz
		{
			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x578A9A0", Offset = "0x57895A0", VA = "0x18578A9A0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x17000256")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzxx
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x578A9F0", Offset = "0x57895F0", VA = "0x18578A9F0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x17000257")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzxy
		{
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x578AA10", Offset = "0x5789610", VA = "0x18578AA10")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00013710 File Offset: 0x00011910
		[Token(Token = "0x17000258")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzxz
		{
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x578AA30", Offset = "0x5789630", VA = "0x18578AA30")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00013728 File Offset: 0x00011928
		[Token(Token = "0x17000259")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzyx
		{
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x578AA70", Offset = "0x5789670", VA = "0x18578AA70")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00013740 File Offset: 0x00011940
		[Token(Token = "0x1700025A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzyy
		{
			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x578AA90", Offset = "0x5789690", VA = "0x18578AA90")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00013758 File Offset: 0x00011958
		[Token(Token = "0x1700025B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzyz
		{
			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x578AAB0", Offset = "0x57896B0", VA = "0x18578AAB0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00013770 File Offset: 0x00011970
		[Token(Token = "0x1700025C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzzx
		{
			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x578AAF0", Offset = "0x57896F0", VA = "0x18578AAF0")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00013788 File Offset: 0x00011988
		[Token(Token = "0x1700025D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzzy
		{
			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x578AB10", Offset = "0x5789710", VA = "0x18578AB10")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x1700025E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double4 zzzz
		{
			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x578AB30", Offset = "0x5789730", VA = "0x18578AB30")]
			[MethodImpl(256)]
			get
			{
				return default(double4);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x000137B8 File Offset: 0x000119B8
		[Token(Token = "0x1700025F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxx
		{
			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x5783730", Offset = "0x5782330", VA = "0x185783730")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x000137D0 File Offset: 0x000119D0
		[Token(Token = "0x17000260")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxy
		{
			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x5783790", Offset = "0x5782390", VA = "0x185783790")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x17000261")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xxz
		{
			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0x5789F40", Offset = "0x5788B40", VA = "0x185789F40")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00013800 File Offset: 0x00011A00
		[Token(Token = "0x17000262")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyx
		{
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x57837F0", Offset = "0x57823F0", VA = "0x1857837F0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00013818 File Offset: 0x00011A18
		[Token(Token = "0x17000263")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyy
		{
			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x5783850", Offset = "0x5782450", VA = "0x185783850")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00013830 File Offset: 0x00011A30
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000264")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyz
		{
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x578A010", Offset = "0x5788C10", VA = "0x18578A010")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x5789DE0", Offset = "0x57889E0", VA = "0x185789DE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00013848 File Offset: 0x00011A48
		[Token(Token = "0x17000265")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xzx
		{
			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x578A0D0", Offset = "0x5788CD0", VA = "0x18578A0D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00013860 File Offset: 0x00011A60
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000266")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xzy
		{
			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x578A160", Offset = "0x5788D60", VA = "0x18578A160")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x578B400", Offset = "0x578A000", VA = "0x18578B400")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00013878 File Offset: 0x00011A78
		[Token(Token = "0x17000267")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xzz
		{
			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x578A200", Offset = "0x5788E00", VA = "0x18578A200")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00013890 File Offset: 0x00011A90
		[Token(Token = "0x17000268")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxx
		{
			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x57838D0", Offset = "0x57824D0", VA = "0x1857838D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x000138A8 File Offset: 0x00011AA8
		[Token(Token = "0x17000269")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxy
		{
			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x5783930", Offset = "0x5782530", VA = "0x185783930")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000138C0 File Offset: 0x00011AC0
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yxz
		{
			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x578A2D0", Offset = "0x5788ED0", VA = "0x18578A2D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x578B420", Offset = "0x578A020", VA = "0x18578B420")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x000138D8 File Offset: 0x00011AD8
		[Token(Token = "0x1700026B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyx
		{
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x57839A0", Offset = "0x57825A0", VA = "0x1857839A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x000138F0 File Offset: 0x00011AF0
		[Token(Token = "0x1700026C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyy
		{
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x5783A00", Offset = "0x5782600", VA = "0x185783A00")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00013908 File Offset: 0x00011B08
		[Token(Token = "0x1700026D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yyz
		{
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x578A3B0", Offset = "0x5788FB0", VA = "0x18578A3B0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00013920 File Offset: 0x00011B20
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzx
		{
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x578A450", Offset = "0x5789050", VA = "0x18578A450")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x578B450", Offset = "0x578A050", VA = "0x18578B450")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00013938 File Offset: 0x00011B38
		[Token(Token = "0x1700026F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzy
		{
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x578A4F0", Offset = "0x57890F0", VA = "0x18578A4F0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00013950 File Offset: 0x00011B50
		[Token(Token = "0x17000270")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzz
		{
			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x578A590", Offset = "0x5789190", VA = "0x18578A590")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00013968 File Offset: 0x00011B68
		[Token(Token = "0x17000271")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxx
		{
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x578A630", Offset = "0x5789230", VA = "0x18578A630")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00013980 File Offset: 0x00011B80
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxy
		{
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x578A6B0", Offset = "0x57892B0", VA = "0x18578A6B0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x578B480", Offset = "0x578A080", VA = "0x18578B480")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x17000273")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxz
		{
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x578A750", Offset = "0x5789350", VA = "0x18578A750")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x000139B0 File Offset: 0x00011BB0
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000274")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zyx
		{
			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x578A800", Offset = "0x5789400", VA = "0x18578A800")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x578B4B0", Offset = "0x578A0B0", VA = "0x18578B4B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000139C8 File Offset: 0x00011BC8
		[Token(Token = "0x17000275")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zyy
		{
			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x578A8A0", Offset = "0x57894A0", VA = "0x18578A8A0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000139E0 File Offset: 0x00011BE0
		[Token(Token = "0x17000276")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zyz
		{
			[Token(Token = "0x6000CA9")]
			[Address(RVA = "0x578A920", Offset = "0x5789520", VA = "0x18578A920")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x000139F8 File Offset: 0x00011BF8
		[Token(Token = "0x17000277")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zzx
		{
			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x578A9D0", Offset = "0x57895D0", VA = "0x18578A9D0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00013A10 File Offset: 0x00011C10
		[Token(Token = "0x17000278")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zzy
		{
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x578AA50", Offset = "0x5789650", VA = "0x18578AA50")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00013A28 File Offset: 0x00011C28
		[Token(Token = "0x17000279")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zzz
		{
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x578AAD0", Offset = "0x57896D0", VA = "0x18578AAD0")]
			[MethodImpl(256)]
			get
			{
				return default(double3);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00013A40 File Offset: 0x00011C40
		[Token(Token = "0x1700027A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xx
		{
			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x5783720", Offset = "0x5782320", VA = "0x185783720")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00013A58 File Offset: 0x00011C58
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xy
		{
			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x5510D10", Offset = "0x550F910", VA = "0x185510D10")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x57835D0", Offset = "0x57821D0", VA = "0x1857835D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00013A70 File Offset: 0x00011C70
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 xz
		{
			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x578A0B0", Offset = "0x5788CB0", VA = "0x18578A0B0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x578B3F0", Offset = "0x5789FF0", VA = "0x18578B3F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00013A88 File Offset: 0x00011C88
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yx
		{
			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x57838B0", Offset = "0x57824B0", VA = "0x1857838B0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x57840F0", Offset = "0x5782CF0", VA = "0x1857840F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00013AA0 File Offset: 0x00011CA0
		[Token(Token = "0x1700027E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yy
		{
			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x5783990", Offset = "0x5782590", VA = "0x185783990")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00013AB8 File Offset: 0x00011CB8
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 yz
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x578A430", Offset = "0x5789030", VA = "0x18578A430")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x578B440", Offset = "0x578A040", VA = "0x18578B440")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00013AD0 File Offset: 0x00011CD0
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000280")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 zx
		{
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x578A610", Offset = "0x5789210", VA = "0x18578A610")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x578B470", Offset = "0x578A070", VA = "0x18578B470")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00013AE8 File Offset: 0x00011CE8
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000281")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 zy
		{
			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x578A7E0", Offset = "0x57893E0", VA = "0x18578A7E0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x578B4A0", Offset = "0x578A0A0", VA = "0x18578B4A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00013B00 File Offset: 0x00011D00
		[Token(Token = "0x17000282")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double2 zz
		{
			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x578A9C0", Offset = "0x57895C0", VA = "0x18578A9C0")]
			[MethodImpl(256)]
			get
			{
				return default(double2);
			}
		}

		// Token: 0x17000283 RID: 643
		[Token(Token = "0x17000283")]
		public double this[int index]
		{
			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x5783710", Offset = "0x5782310", VA = "0x185783710")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000CBD")]
			[Address(RVA = "0x57840E0", Offset = "0x5782CE0", VA = "0x1857840E0")]
			set
			{
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00013B30 File Offset: 0x00011D30
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x5789B30", Offset = "0x5788730", VA = "0x185789B30", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(double3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00013B48 File Offset: 0x00011D48
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x5789A70", Offset = "0x5788670", VA = "0x185789A70", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00013B60 File Offset: 0x00011D60
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x571F030", Offset = "0x571DC30", VA = "0x18571F030", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x5789C30", Offset = "0x5788830", VA = "0x185789C30", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x5789B70", Offset = "0x5788770", VA = "0x185789B70", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x10")]
		public double z;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double3 zero;

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x577F780", Offset = "0x577E380", VA = "0x18577F780")]
			public DebuggerProxy(double3 v)
			{
			}

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			[FieldOffset(Offset = "0x10")]
			public double x;

			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			[FieldOffset(Offset = "0x18")]
			public double y;

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			[FieldOffset(Offset = "0x20")]
			public double z;
		}
	}
}
