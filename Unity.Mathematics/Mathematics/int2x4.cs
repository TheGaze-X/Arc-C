using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct int2x4 : IEquatable<int2x4>, IFormattable
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x4A09210", Offset = "0x4A07E10", VA = "0x184A09210")]
		[MethodImpl(256)]
		public int2x4(int2 c0, int2 c1, int2 c2, int2 c3)
		{
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x57DD900", Offset = "0x57DC500", VA = "0x1857DD900")]
		[MethodImpl(256)]
		public int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13)
		{
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x57DD9E0", Offset = "0x57DC5E0", VA = "0x1857DD9E0")]
		[MethodImpl(256)]
		public int2x4(int v)
		{
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x56FF310", Offset = "0x56FDF10", VA = "0x1856FF310")]
		[MethodImpl(256)]
		public int2x4(bool v)
		{
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001932")]
		[Address(RVA = "0x56FF1E0", Offset = "0x56FDDE0", VA = "0x1856FF1E0")]
		[MethodImpl(256)]
		public int2x4(bool2x4 v)
		{
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x57DD9E0", Offset = "0x57DC5E0", VA = "0x1857DD9E0")]
		[MethodImpl(256)]
		public int2x4(uint v)
		{
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x57DD890", Offset = "0x57DC490", VA = "0x1857DD890")]
		[MethodImpl(256)]
		public int2x4(uint2x4 v)
		{
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x57DDA30", Offset = "0x57DC630", VA = "0x1857DDA30")]
		[MethodImpl(256)]
		public int2x4(float v)
		{
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x57DD810", Offset = "0x57DC410", VA = "0x1857DD810")]
		[MethodImpl(256)]
		public int2x4(float2x4 v)
		{
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001937")]
		[Address(RVA = "0x57DDA80", Offset = "0x57DC680", VA = "0x1857DDA80")]
		[MethodImpl(256)]
		public int2x4(double v)
		{
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x57DD960", Offset = "0x57DC560", VA = "0x1857DD960")]
		[MethodImpl(256)]
		public int2x4(double2x4 v)
		{
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00022CE0 File Offset: 0x00020EE0
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x5729130", Offset = "0x5727D30", VA = "0x185729130")]
		[MethodImpl(256)]
		public static implicit operator int2x4(int v)
		{
			return default(int2x4);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00022CF8 File Offset: 0x00020EF8
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x57DE740", Offset = "0x57DD340", VA = "0x1857DE740")]
		[MethodImpl(256)]
		public static explicit operator int2x4(bool v)
		{
			return default(int2x4);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00022D10 File Offset: 0x00020F10
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x57DE770", Offset = "0x57DD370", VA = "0x1857DE770")]
		[MethodImpl(256)]
		public static explicit operator int2x4(bool2x4 v)
		{
			return default(int2x4);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00022D28 File Offset: 0x00020F28
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x5729130", Offset = "0x5727D30", VA = "0x185729130")]
		[MethodImpl(256)]
		public static explicit operator int2x4(uint v)
		{
			return default(int2x4);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00022D40 File Offset: 0x00020F40
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x5729180", Offset = "0x5727D80", VA = "0x185729180")]
		[MethodImpl(256)]
		public static explicit operator int2x4(uint2x4 v)
		{
			return default(int2x4);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00022D58 File Offset: 0x00020F58
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x5729410", Offset = "0x5728010", VA = "0x185729410")]
		[MethodImpl(256)]
		public static explicit operator int2x4(float v)
		{
			return default(int2x4);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00022D70 File Offset: 0x00020F70
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x5729370", Offset = "0x5727F70", VA = "0x185729370")]
		[MethodImpl(256)]
		public static explicit operator int2x4(float2x4 v)
		{
			return default(int2x4);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00022D88 File Offset: 0x00020F88
		[Token(Token = "0x6001940")]
		[Address(RVA = "0x5729320", Offset = "0x5727F20", VA = "0x185729320")]
		[MethodImpl(256)]
		public static explicit operator int2x4(double v)
		{
			return default(int2x4);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00022DA0 File Offset: 0x00020FA0
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x5729460", Offset = "0x5728060", VA = "0x185729460")]
		[MethodImpl(256)]
		public static explicit operator int2x4(double2x4 v)
		{
			return default(int2x4);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00022DB8 File Offset: 0x00020FB8
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x57DF530", Offset = "0x57DE130", VA = "0x1857DF530")]
		[MethodImpl(256)]
		public static int2x4 operator *(int2x4 lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00022DD0 File Offset: 0x00020FD0
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x57DF5F0", Offset = "0x57DE1F0", VA = "0x1857DF5F0")]
		[MethodImpl(256)]
		public static int2x4 operator *(int2x4 lhs, int rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00022DE8 File Offset: 0x00020FE8
		[Token(Token = "0x6001944")]
		[Address(RVA = "0x57DF490", Offset = "0x57DE090", VA = "0x1857DF490")]
		[MethodImpl(256)]
		public static int2x4 operator *(int lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00022E00 File Offset: 0x00021000
		[Token(Token = "0x6001945")]
		[Address(RVA = "0x57DDBF0", Offset = "0x57DC7F0", VA = "0x1857DDBF0")]
		[MethodImpl(256)]
		public static int2x4 operator +(int2x4 lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00022E18 File Offset: 0x00021018
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x57DDB60", Offset = "0x57DC760", VA = "0x1857DDB60")]
		[MethodImpl(256)]
		public static int2x4 operator +(int2x4 lhs, int rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00022E30 File Offset: 0x00021030
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x57DDAD0", Offset = "0x57DC6D0", VA = "0x1857DDAD0")]
		[MethodImpl(256)]
		public static int2x4 operator +(int lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00022E48 File Offset: 0x00021048
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x57DF7C0", Offset = "0x57DE3C0", VA = "0x1857DF7C0")]
		[MethodImpl(256)]
		public static int2x4 operator -(int2x4 lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00022E60 File Offset: 0x00021060
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x57DF920", Offset = "0x57DE520", VA = "0x1857DF920")]
		[MethodImpl(256)]
		public static int2x4 operator -(int2x4 lhs, int rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00022E78 File Offset: 0x00021078
		[Token(Token = "0x600194A")]
		[Address(RVA = "0x57DF880", Offset = "0x57DE480", VA = "0x1857DF880")]
		[MethodImpl(256)]
		public static int2x4 operator -(int lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00022E90 File Offset: 0x00021090
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x57DE290", Offset = "0x57DCE90", VA = "0x1857DE290")]
		[MethodImpl(256)]
		public static int2x4 operator /(int2x4 lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00022EA8 File Offset: 0x000210A8
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x57DE130", Offset = "0x57DCD30", VA = "0x1857DE130")]
		[MethodImpl(256)]
		public static int2x4 operator /(int2x4 lhs, int rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00022EC0 File Offset: 0x000210C0
		[Token(Token = "0x600194D")]
		[Address(RVA = "0x57DE1E0", Offset = "0x57DCDE0", VA = "0x1857DE1E0")]
		[MethodImpl(256)]
		public static int2x4 operator /(int lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00022ED8 File Offset: 0x000210D8
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x57DF300", Offset = "0x57DDF00", VA = "0x1857DF300")]
		[MethodImpl(256)]
		public static int2x4 operator %(int2x4 lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00022EF0 File Offset: 0x000210F0
		[Token(Token = "0x600194F")]
		[Address(RVA = "0x57DF3E0", Offset = "0x57DDFE0", VA = "0x1857DF3E0")]
		[MethodImpl(256)]
		public static int2x4 operator %(int2x4 lhs, int rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00022F08 File Offset: 0x00021108
		[Token(Token = "0x6001950")]
		[Address(RVA = "0x57DF250", Offset = "0x57DDE50", VA = "0x1857DF250")]
		[MethodImpl(256)]
		public static int2x4 operator %(int lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00022F20 File Offset: 0x00021120
		[Token(Token = "0x6001951")]
		[Address(RVA = "0x57DEB60", Offset = "0x57DD760", VA = "0x1857DEB60")]
		[MethodImpl(256)]
		public static int2x4 operator ++(int2x4 val)
		{
			return default(int2x4);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00022F38 File Offset: 0x00021138
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x57DE080", Offset = "0x57DCC80", VA = "0x1857DE080")]
		[MethodImpl(256)]
		public static int2x4 operator --(int2x4 val)
		{
			return default(int2x4);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00022F50 File Offset: 0x00021150
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x57DF100", Offset = "0x57DDD00", VA = "0x1857DF100")]
		[MethodImpl(256)]
		public static bool2x4 operator <(int2x4 lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00022F68 File Offset: 0x00021168
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x57DF070", Offset = "0x57DDC70", VA = "0x1857DF070")]
		[MethodImpl(256)]
		public static bool2x4 operator <(int2x4 lhs, int rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00022F80 File Offset: 0x00021180
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x57DF1C0", Offset = "0x57DDDC0", VA = "0x1857DF1C0")]
		[MethodImpl(256)]
		public static bool2x4 operator <(int lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00022F98 File Offset: 0x00021198
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x57DEFB0", Offset = "0x57DDBB0", VA = "0x1857DEFB0")]
		[MethodImpl(256)]
		public static bool2x4 operator <=(int2x4 lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00022FB0 File Offset: 0x000211B0
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x57DEE90", Offset = "0x57DDA90", VA = "0x1857DEE90")]
		[MethodImpl(256)]
		public static bool2x4 operator <=(int2x4 lhs, int rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00022FC8 File Offset: 0x000211C8
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x57DEF20", Offset = "0x57DDB20", VA = "0x1857DEF20")]
		[MethodImpl(256)]
		public static bool2x4 operator <=(int lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00022FE0 File Offset: 0x000211E0
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x57DE980", Offset = "0x57DD580", VA = "0x1857DE980")]
		[MethodImpl(256)]
		public static bool2x4 operator >(int2x4 lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00022FF8 File Offset: 0x000211F8
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x57DEA40", Offset = "0x57DD640", VA = "0x1857DEA40")]
		[MethodImpl(256)]
		public static bool2x4 operator >(int2x4 lhs, int rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00023010 File Offset: 0x00021210
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x57DEAD0", Offset = "0x57DD6D0", VA = "0x1857DEAD0")]
		[MethodImpl(256)]
		public static bool2x4 operator >(int lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00023028 File Offset: 0x00021228
		[Token(Token = "0x600195C")]
		[Address(RVA = "0x57DE7A0", Offset = "0x57DD3A0", VA = "0x1857DE7A0")]
		[MethodImpl(256)]
		public static bool2x4 operator >=(int2x4 lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00023040 File Offset: 0x00021240
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x57DE860", Offset = "0x57DD460", VA = "0x1857DE860")]
		[MethodImpl(256)]
		public static bool2x4 operator >=(int2x4 lhs, int rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00023058 File Offset: 0x00021258
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x57DE8F0", Offset = "0x57DD4F0", VA = "0x1857DE8F0")]
		[MethodImpl(256)]
		public static bool2x4 operator >=(int lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00023070 File Offset: 0x00021270
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x57DF9C0", Offset = "0x57DE5C0", VA = "0x1857DF9C0")]
		[MethodImpl(256)]
		public static int2x4 operator -(int2x4 val)
		{
			return default(int2x4);
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00023088 File Offset: 0x00021288
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x57DFA50", Offset = "0x57DE650", VA = "0x1857DFA50")]
		[MethodImpl(256)]
		public static int2x4 operator +(int2x4 val)
		{
			return default(int2x4);
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x000230A0 File Offset: 0x000212A0
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x57DEDF0", Offset = "0x57DD9F0", VA = "0x1857DEDF0")]
		[MethodImpl(256)]
		public static int2x4 operator <<(int2x4 x, int n)
		{
			return default(int2x4);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000230B8 File Offset: 0x000212B8
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x57DF720", Offset = "0x57DE320", VA = "0x1857DF720")]
		[MethodImpl(256)]
		public static int2x4 operator >>(int2x4 x, int n)
		{
			return default(int2x4);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000230D0 File Offset: 0x000212D0
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x57DE370", Offset = "0x57DCF70", VA = "0x1857DE370")]
		[MethodImpl(256)]
		public static bool2x4 operator ==(int2x4 lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000230E8 File Offset: 0x000212E8
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x57DE430", Offset = "0x57DD030", VA = "0x1857DE430")]
		[MethodImpl(256)]
		public static bool2x4 operator ==(int2x4 lhs, int rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00023100 File Offset: 0x00021300
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x57DE4C0", Offset = "0x57DD0C0", VA = "0x1857DE4C0")]
		[MethodImpl(256)]
		public static bool2x4 operator ==(int lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00023118 File Offset: 0x00021318
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x57DED30", Offset = "0x57DD930", VA = "0x1857DED30")]
		[MethodImpl(256)]
		public static bool2x4 operator !=(int2x4 lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00023130 File Offset: 0x00021330
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x57DECA0", Offset = "0x57DD8A0", VA = "0x1857DECA0")]
		[MethodImpl(256)]
		public static bool2x4 operator !=(int2x4 lhs, int rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00023148 File Offset: 0x00021348
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x57DEC10", Offset = "0x57DD810", VA = "0x1857DEC10")]
		[MethodImpl(256)]
		public static bool2x4 operator !=(int lhs, int2x4 rhs)
		{
			return default(bool2x4);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00023160 File Offset: 0x00021360
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x57DF690", Offset = "0x57DE290", VA = "0x1857DF690")]
		[MethodImpl(256)]
		public static int2x4 operator ~(int2x4 val)
		{
			return default(int2x4);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00023178 File Offset: 0x00021378
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x57DDDD0", Offset = "0x57DC9D0", VA = "0x1857DDDD0")]
		[MethodImpl(256)]
		public static int2x4 operator &(int2x4 lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00023190 File Offset: 0x00021390
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x57DDCA0", Offset = "0x57DC8A0", VA = "0x1857DDCA0")]
		[MethodImpl(256)]
		public static int2x4 operator &(int2x4 lhs, int rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000231A8 File Offset: 0x000213A8
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x57DDD40", Offset = "0x57DC940", VA = "0x1857DDD40")]
		[MethodImpl(256)]
		public static int2x4 operator &(int lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000231C0 File Offset: 0x000213C0
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x57DDFC0", Offset = "0x57DCBC0", VA = "0x1857DDFC0")]
		[MethodImpl(256)]
		public static int2x4 operator |(int2x4 lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x000231D8 File Offset: 0x000213D8
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x57DDE90", Offset = "0x57DCA90", VA = "0x1857DDE90")]
		[MethodImpl(256)]
		public static int2x4 operator |(int2x4 lhs, int rhs)
		{
			return default(int2x4);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000231F0 File Offset: 0x000213F0
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x57DDF30", Offset = "0x57DCB30", VA = "0x1857DDF30")]
		[MethodImpl(256)]
		public static int2x4 operator |(int lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00023208 File Offset: 0x00021408
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x57DE5F0", Offset = "0x57DD1F0", VA = "0x1857DE5F0")]
		[MethodImpl(256)]
		public static int2x4 operator ^(int2x4 lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00023220 File Offset: 0x00021420
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x57DE550", Offset = "0x57DD150", VA = "0x1857DE550")]
		[MethodImpl(256)]
		public static int2x4 operator ^(int2x4 lhs, int rhs)
		{
			return default(int2x4);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00023238 File Offset: 0x00021438
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x57DE6B0", Offset = "0x57DD2B0", VA = "0x1857DE6B0")]
		[MethodImpl(256)]
		public static int2x4 operator ^(int lhs, int2x4 rhs)
		{
			return default(int2x4);
		}

		// Token: 0x170007CF RID: 1999
		[Token(Token = "0x170007CF")]
		public int2 this[int index]
		{
			[Token(Token = "0x6001973")]
			[Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00023250 File Offset: 0x00021450
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x57DD050", Offset = "0x57DBC50", VA = "0x1857DD050", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int2x4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00023268 File Offset: 0x00021468
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x57DCF50", Offset = "0x57DBB50", VA = "0x1857DCF50", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00023280 File Offset: 0x00021480
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x57DD0D0", Offset = "0x57DBCD0", VA = "0x1857DD0D0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x57DD480", Offset = "0x57DC080", VA = "0x1857DD480", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x57DD100", Offset = "0x57DBD00", VA = "0x1857DD100", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x0")]
		public int2 c0;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x8")]
		public int2 c1;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x10")]
		public int2 c2;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x18")]
		public int2 c3;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int2x4 zero;
	}
}
