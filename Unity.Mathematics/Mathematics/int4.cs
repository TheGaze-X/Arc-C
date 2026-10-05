using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[DebuggerTypeProxy(typeof(int4.DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct int4 : IEquatable<int4>, IFormattable
	{
		// Token: 0x06001B2B RID: 6955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x1CA1750", Offset = "0x1CA0350", VA = "0x181CA1750")]
		[MethodImpl(256)]
		public int4(int x, int y, int z, int w)
		{
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x576A1D0", Offset = "0x5768DD0", VA = "0x18576A1D0")]
		[MethodImpl(256)]
		public int4(int x, int y, int2 zw)
		{
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x576A190", Offset = "0x5768D90", VA = "0x18576A190")]
		[MethodImpl(256)]
		public int4(int x, int2 yz, int w)
		{
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x576A120", Offset = "0x5768D20", VA = "0x18576A120")]
		[MethodImpl(256)]
		public int4(int x, int3 yzw)
		{
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0x576A100", Offset = "0x5768D00", VA = "0x18576A100")]
		[MethodImpl(256)]
		public int4(int2 xy, int z, int w)
		{
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x576A2D0", Offset = "0x5768ED0", VA = "0x18576A2D0")]
		[MethodImpl(256)]
		public int4(int2 xy, int2 zw)
		{
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x576A090", Offset = "0x5768C90", VA = "0x18576A090")]
		[MethodImpl(256)]
		public int4(int3 xyz, int w)
		{
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
		[MethodImpl(256)]
		public int4(int4 xyzw)
		{
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x576A010", Offset = "0x5768C10", VA = "0x18576A010")]
		[MethodImpl(256)]
		public int4(int v)
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x576A1F0", Offset = "0x5768DF0", VA = "0x18576A1F0")]
		[MethodImpl(256)]
		public int4(bool v)
		{
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x576A140", Offset = "0x5768D40", VA = "0x18576A140")]
		[MethodImpl(256)]
		public int4(bool4 v)
		{
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x576A010", Offset = "0x5768C10", VA = "0x18576A010")]
		[MethodImpl(256)]
		public int4(uint v)
		{
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
		[MethodImpl(256)]
		public int4(uint4 v)
		{
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x57E9B30", Offset = "0x57E8730", VA = "0x1857E9B30")]
		[MethodImpl(256)]
		public int4(float v)
		{
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x57E9B70", Offset = "0x57E8770", VA = "0x1857E9B70")]
		[MethodImpl(256)]
		public int4(float4 v)
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x57E9B40", Offset = "0x57E8740", VA = "0x1857E9B40")]
		[MethodImpl(256)]
		public int4(double v)
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x57E9B50", Offset = "0x57E8750", VA = "0x1857E9B50")]
		[MethodImpl(256)]
		public int4(double4 v)
		{
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00025488 File Offset: 0x00023688
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x572A4C0", Offset = "0x57290C0", VA = "0x18572A4C0")]
		[MethodImpl(256)]
		public static implicit operator int4(int v)
		{
			return default(int4);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000254A0 File Offset: 0x000236A0
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x572A4D0", Offset = "0x57290D0", VA = "0x18572A4D0")]
		[MethodImpl(256)]
		public static explicit operator int4(bool v)
		{
			return default(int4);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000254B8 File Offset: 0x000236B8
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x572A530", Offset = "0x5729130", VA = "0x18572A530")]
		[MethodImpl(256)]
		public static explicit operator int4(bool4 v)
		{
			return default(int4);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000254D0 File Offset: 0x000236D0
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x572A4C0", Offset = "0x57290C0", VA = "0x18572A4C0")]
		[MethodImpl(256)]
		public static explicit operator int4(uint v)
		{
			return default(int4);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x000254E8 File Offset: 0x000236E8
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x572A480", Offset = "0x5729080", VA = "0x18572A480")]
		[MethodImpl(256)]
		public static explicit operator int4(uint4 v)
		{
			return default(int4);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00025500 File Offset: 0x00023700
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x572A5D0", Offset = "0x57291D0", VA = "0x18572A5D0")]
		[MethodImpl(256)]
		public static explicit operator int4(float v)
		{
			return default(int4);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00025518 File Offset: 0x00023718
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x572A6B0", Offset = "0x57292B0", VA = "0x18572A6B0")]
		[MethodImpl(256)]
		public static explicit operator int4(float4 v)
		{
			return default(int4);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00025530 File Offset: 0x00023730
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x572A5B0", Offset = "0x57291B0", VA = "0x18572A5B0")]
		[MethodImpl(256)]
		public static explicit operator int4(double v)
		{
			return default(int4);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00025548 File Offset: 0x00023748
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x572A580", Offset = "0x5729180", VA = "0x18572A580")]
		[MethodImpl(256)]
		public static explicit operator int4(double4 v)
		{
			return default(int4);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00025560 File Offset: 0x00023760
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x576D460", Offset = "0x576C060", VA = "0x18576D460")]
		[MethodImpl(256)]
		public static int4 operator *(int4 lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00025578 File Offset: 0x00023778
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x576D430", Offset = "0x576C030", VA = "0x18576D430")]
		[MethodImpl(256)]
		public static int4 operator *(int4 lhs, int rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00025590 File Offset: 0x00023790
		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x576D490", Offset = "0x576C090", VA = "0x18576D490")]
		[MethodImpl(256)]
		public static int4 operator *(int lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x000255A8 File Offset: 0x000237A8
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x576CC80", Offset = "0x576B880", VA = "0x18576CC80")]
		[MethodImpl(256)]
		public static int4 operator +(int4 lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x000255C0 File Offset: 0x000237C0
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x576CCB0", Offset = "0x576B8B0", VA = "0x18576CCB0")]
		[MethodImpl(256)]
		public static int4 operator +(int4 lhs, int rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000255D8 File Offset: 0x000237D8
		[Token(Token = "0x6001B4A")]
		[Address(RVA = "0x576CCE0", Offset = "0x576B8E0", VA = "0x18576CCE0")]
		[MethodImpl(256)]
		public static int4 operator +(int lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x000255F0 File Offset: 0x000237F0
		[Token(Token = "0x6001B4B")]
		[Address(RVA = "0x576D580", Offset = "0x576C180", VA = "0x18576D580")]
		[MethodImpl(256)]
		public static int4 operator -(int4 lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00025608 File Offset: 0x00023808
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0x576D550", Offset = "0x576C150", VA = "0x18576D550")]
		[MethodImpl(256)]
		public static int4 operator -(int4 lhs, int rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00025620 File Offset: 0x00023820
		[Token(Token = "0x6001B4D")]
		[Address(RVA = "0x576D520", Offset = "0x576C120", VA = "0x18576D520")]
		[MethodImpl(256)]
		public static int4 operator -(int lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00025638 File Offset: 0x00023838
		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0x57E9B90", Offset = "0x57E8790", VA = "0x1857E9B90")]
		[MethodImpl(256)]
		public static int4 operator /(int4 lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00025650 File Offset: 0x00023850
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x57E9C00", Offset = "0x57E8800", VA = "0x1857E9C00")]
		[MethodImpl(256)]
		public static int4 operator /(int4 lhs, int rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00025668 File Offset: 0x00023868
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0x57E9BD0", Offset = "0x57E87D0", VA = "0x1857E9BD0")]
		[MethodImpl(256)]
		public static int4 operator /(int lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00025680 File Offset: 0x00023880
		[Token(Token = "0x6001B51")]
		[Address(RVA = "0x57E9EA0", Offset = "0x57E8AA0", VA = "0x1857E9EA0")]
		[MethodImpl(256)]
		public static int4 operator %(int4 lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00025698 File Offset: 0x00023898
		[Token(Token = "0x6001B52")]
		[Address(RVA = "0x57E9EE0", Offset = "0x57E8AE0", VA = "0x1857E9EE0")]
		[MethodImpl(256)]
		public static int4 operator %(int4 lhs, int rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x000256B0 File Offset: 0x000238B0
		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x57E9E70", Offset = "0x57E8A70", VA = "0x1857E9E70")]
		[MethodImpl(256)]
		public static int4 operator %(int lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x000256C8 File Offset: 0x000238C8
		[Token(Token = "0x6001B54")]
		[Address(RVA = "0x576D160", Offset = "0x576BD60", VA = "0x18576D160")]
		[MethodImpl(256)]
		public static int4 operator ++(int4 val)
		{
			return default(int4);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000256E0 File Offset: 0x000238E0
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x576CE30", Offset = "0x576BA30", VA = "0x18576CE30")]
		[MethodImpl(256)]
		public static int4 operator --(int4 val)
		{
			return default(int4);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x000256F8 File Offset: 0x000238F8
		[Token(Token = "0x6001B56")]
		[Address(RVA = "0x57E9E10", Offset = "0x57E8A10", VA = "0x1857E9E10")]
		[MethodImpl(256)]
		public static bool4 operator <(int4 lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00025710 File Offset: 0x00023910
		[Token(Token = "0x6001B57")]
		[Address(RVA = "0x57E9E40", Offset = "0x57E8A40", VA = "0x1857E9E40")]
		[MethodImpl(256)]
		public static bool4 operator <(int4 lhs, int rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00025728 File Offset: 0x00023928
		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x57E9DE0", Offset = "0x57E89E0", VA = "0x1857E9DE0")]
		[MethodImpl(256)]
		public static bool4 operator <(int lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00025740 File Offset: 0x00023940
		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x57E9D80", Offset = "0x57E8980", VA = "0x1857E9D80")]
		[MethodImpl(256)]
		public static bool4 operator <=(int4 lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00025758 File Offset: 0x00023958
		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x57E9DB0", Offset = "0x57E89B0", VA = "0x1857E9DB0")]
		[MethodImpl(256)]
		public static bool4 operator <=(int4 lhs, int rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00025770 File Offset: 0x00023970
		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x57E9D50", Offset = "0x57E8950", VA = "0x1857E9D50")]
		[MethodImpl(256)]
		public static bool4 operator <=(int lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00025788 File Offset: 0x00023988
		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x57E9D20", Offset = "0x57E8920", VA = "0x1857E9D20")]
		[MethodImpl(256)]
		public static bool4 operator >(int4 lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x000257A0 File Offset: 0x000239A0
		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x57E9CC0", Offset = "0x57E88C0", VA = "0x1857E9CC0")]
		[MethodImpl(256)]
		public static bool4 operator >(int4 lhs, int rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x000257B8 File Offset: 0x000239B8
		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x57E9CF0", Offset = "0x57E88F0", VA = "0x1857E9CF0")]
		[MethodImpl(256)]
		public static bool4 operator >(int lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x000257D0 File Offset: 0x000239D0
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x57E9C90", Offset = "0x57E8890", VA = "0x1857E9C90")]
		[MethodImpl(256)]
		public static bool4 operator >=(int4 lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x000257E8 File Offset: 0x000239E8
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x57E9C30", Offset = "0x57E8830", VA = "0x1857E9C30")]
		[MethodImpl(256)]
		public static bool4 operator >=(int4 lhs, int rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00025800 File Offset: 0x00023A00
		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x57E9C60", Offset = "0x57E8860", VA = "0x1857E9C60")]
		[MethodImpl(256)]
		public static bool4 operator >=(int lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00025818 File Offset: 0x00023A18
		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x576D5B0", Offset = "0x576C1B0", VA = "0x18576D5B0")]
		[MethodImpl(256)]
		public static int4 operator -(int4 val)
		{
			return default(int4);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00025830 File Offset: 0x00023A30
		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
		[MethodImpl(256)]
		public static int4 operator +(int4 val)
		{
			return default(int4);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00025848 File Offset: 0x00023A48
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x576D220", Offset = "0x576BE20", VA = "0x18576D220")]
		[MethodImpl(256)]
		public static int4 operator <<(int4 x, int n)
		{
			return default(int4);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00025860 File Offset: 0x00023A60
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x57E9F10", Offset = "0x57E8B10", VA = "0x1857E9F10")]
		[MethodImpl(256)]
		public static int4 operator >>(int4 x, int n)
		{
			return default(int4);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00025878 File Offset: 0x00023A78
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x576CF20", Offset = "0x576BB20", VA = "0x18576CF20")]
		[MethodImpl(256)]
		public static bool4 operator ==(int4 lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00025890 File Offset: 0x00023A90
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x576CF80", Offset = "0x576BB80", VA = "0x18576CF80")]
		[MethodImpl(256)]
		public static bool4 operator ==(int4 lhs, int rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000258A8 File Offset: 0x00023AA8
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x576CF50", Offset = "0x576BB50", VA = "0x18576CF50")]
		[MethodImpl(256)]
		public static bool4 operator ==(int lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x000258C0 File Offset: 0x00023AC0
		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x576D190", Offset = "0x576BD90", VA = "0x18576D190")]
		[MethodImpl(256)]
		public static bool4 operator !=(int4 lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x000258D8 File Offset: 0x00023AD8
		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x576D1F0", Offset = "0x576BDF0", VA = "0x18576D1F0")]
		[MethodImpl(256)]
		public static bool4 operator !=(int4 lhs, int rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x000258F0 File Offset: 0x00023AF0
		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x576D1C0", Offset = "0x576BDC0", VA = "0x18576D1C0")]
		[MethodImpl(256)]
		public static bool4 operator !=(int lhs, int4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00025908 File Offset: 0x00023B08
		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x576D4C0", Offset = "0x576C0C0", VA = "0x18576D4C0")]
		[MethodImpl(256)]
		public static int4 operator ~(int4 val)
		{
			return default(int4);
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x00025920 File Offset: 0x00023B20
		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x576CD10", Offset = "0x576B910", VA = "0x18576CD10")]
		[MethodImpl(256)]
		public static int4 operator &(int4 lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00025938 File Offset: 0x00023B38
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x576CD70", Offset = "0x576B970", VA = "0x18576CD70")]
		[MethodImpl(256)]
		public static int4 operator &(int4 lhs, int rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00025950 File Offset: 0x00023B50
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x576CD40", Offset = "0x576B940", VA = "0x18576CD40")]
		[MethodImpl(256)]
		public static int4 operator &(int lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00025968 File Offset: 0x00023B68
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x576CE00", Offset = "0x576BA00", VA = "0x18576CE00")]
		[MethodImpl(256)]
		public static int4 operator |(int4 lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00025980 File Offset: 0x00023B80
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x576CDD0", Offset = "0x576B9D0", VA = "0x18576CDD0")]
		[MethodImpl(256)]
		public static int4 operator |(int4 lhs, int rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00025998 File Offset: 0x00023B98
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x576CDA0", Offset = "0x576B9A0", VA = "0x18576CDA0")]
		[MethodImpl(256)]
		public static int4 operator |(int lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000259B0 File Offset: 0x00023BB0
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x576D010", Offset = "0x576BC10", VA = "0x18576D010")]
		[MethodImpl(256)]
		public static int4 operator ^(int4 lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000259C8 File Offset: 0x00023BC8
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x576CFE0", Offset = "0x576BBE0", VA = "0x18576CFE0")]
		[MethodImpl(256)]
		public static int4 operator ^(int4 lhs, int rhs)
		{
			return default(int4);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x000259E0 File Offset: 0x00023BE0
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x576CFB0", Offset = "0x576BBB0", VA = "0x18576CFB0")]
		[MethodImpl(256)]
		public static int4 operator ^(int lhs, int4 rhs)
		{
			return default(int4);
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000259F8 File Offset: 0x00023BF8
		[Token(Token = "0x17000849")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxx
		{
			[Token(Token = "0x6001B76")]
			[Address(RVA = "0x576B0E0", Offset = "0x5769CE0", VA = "0x18576B0E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x00025A10 File Offset: 0x00023C10
		[Token(Token = "0x1700084A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxy
		{
			[Token(Token = "0x6001B77")]
			[Address(RVA = "0x576B100", Offset = "0x5769D00", VA = "0x18576B100")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00025A28 File Offset: 0x00023C28
		[Token(Token = "0x1700084B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxz
		{
			[Token(Token = "0x6001B78")]
			[Address(RVA = "0x576B120", Offset = "0x5769D20", VA = "0x18576B120")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x00025A40 File Offset: 0x00023C40
		[Token(Token = "0x1700084C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxw
		{
			[Token(Token = "0x6001B79")]
			[Address(RVA = "0x576B0C0", Offset = "0x5769CC0", VA = "0x18576B0C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00025A58 File Offset: 0x00023C58
		[Token(Token = "0x1700084D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyx
		{
			[Token(Token = "0x6001B7A")]
			[Address(RVA = "0x576B180", Offset = "0x5769D80", VA = "0x18576B180")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x00025A70 File Offset: 0x00023C70
		[Token(Token = "0x1700084E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyy
		{
			[Token(Token = "0x6001B7B")]
			[Address(RVA = "0x576B1A0", Offset = "0x5769DA0", VA = "0x18576B1A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00025A88 File Offset: 0x00023C88
		[Token(Token = "0x1700084F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyz
		{
			[Token(Token = "0x6001B7C")]
			[Address(RVA = "0x576B1C0", Offset = "0x5769DC0", VA = "0x18576B1C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x00025AA0 File Offset: 0x00023CA0
		[Token(Token = "0x17000850")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyw
		{
			[Token(Token = "0x6001B7D")]
			[Address(RVA = "0x576B160", Offset = "0x5769D60", VA = "0x18576B160")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00025AB8 File Offset: 0x00023CB8
		[Token(Token = "0x17000851")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxzx
		{
			[Token(Token = "0x6001B7E")]
			[Address(RVA = "0x576B220", Offset = "0x5769E20", VA = "0x18576B220")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x00025AD0 File Offset: 0x00023CD0
		[Token(Token = "0x17000852")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxzy
		{
			[Token(Token = "0x6001B7F")]
			[Address(RVA = "0x576B240", Offset = "0x5769E40", VA = "0x18576B240")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x00025AE8 File Offset: 0x00023CE8
		[Token(Token = "0x17000853")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxzz
		{
			[Token(Token = "0x6001B80")]
			[Address(RVA = "0x576B260", Offset = "0x5769E60", VA = "0x18576B260")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x00025B00 File Offset: 0x00023D00
		[Token(Token = "0x17000854")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxzw
		{
			[Token(Token = "0x6001B81")]
			[Address(RVA = "0x576B200", Offset = "0x5769E00", VA = "0x18576B200")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x00025B18 File Offset: 0x00023D18
		[Token(Token = "0x17000855")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxwx
		{
			[Token(Token = "0x6001B82")]
			[Address(RVA = "0x576B050", Offset = "0x5769C50", VA = "0x18576B050")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x00025B30 File Offset: 0x00023D30
		[Token(Token = "0x17000856")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxwy
		{
			[Token(Token = "0x6001B83")]
			[Address(RVA = "0x576B070", Offset = "0x5769C70", VA = "0x18576B070")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00025B48 File Offset: 0x00023D48
		[Token(Token = "0x17000857")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxwz
		{
			[Token(Token = "0x6001B84")]
			[Address(RVA = "0x576B090", Offset = "0x5769C90", VA = "0x18576B090")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x00025B60 File Offset: 0x00023D60
		[Token(Token = "0x17000858")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxww
		{
			[Token(Token = "0x6001B85")]
			[Address(RVA = "0x576B030", Offset = "0x5769C30", VA = "0x18576B030")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x00025B78 File Offset: 0x00023D78
		[Token(Token = "0x17000859")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxx
		{
			[Token(Token = "0x6001B86")]
			[Address(RVA = "0x576B380", Offset = "0x5769F80", VA = "0x18576B380")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x00025B90 File Offset: 0x00023D90
		[Token(Token = "0x1700085A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxy
		{
			[Token(Token = "0x6001B87")]
			[Address(RVA = "0x576B3A0", Offset = "0x5769FA0", VA = "0x18576B3A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00025BA8 File Offset: 0x00023DA8
		[Token(Token = "0x1700085B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxz
		{
			[Token(Token = "0x6001B88")]
			[Address(RVA = "0x576B3C0", Offset = "0x5769FC0", VA = "0x18576B3C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00025BC0 File Offset: 0x00023DC0
		[Token(Token = "0x1700085C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxw
		{
			[Token(Token = "0x6001B89")]
			[Address(RVA = "0x576B360", Offset = "0x5769F60", VA = "0x18576B360")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00025BD8 File Offset: 0x00023DD8
		[Token(Token = "0x1700085D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyx
		{
			[Token(Token = "0x6001B8A")]
			[Address(RVA = "0x576B420", Offset = "0x576A020", VA = "0x18576B420")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x00025BF0 File Offset: 0x00023DF0
		[Token(Token = "0x1700085E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyy
		{
			[Token(Token = "0x6001B8B")]
			[Address(RVA = "0x576B440", Offset = "0x576A040", VA = "0x18576B440")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00025C08 File Offset: 0x00023E08
		[Token(Token = "0x1700085F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyz
		{
			[Token(Token = "0x6001B8C")]
			[Address(RVA = "0x576B460", Offset = "0x576A060", VA = "0x18576B460")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x00025C20 File Offset: 0x00023E20
		[Token(Token = "0x17000860")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyw
		{
			[Token(Token = "0x6001B8D")]
			[Address(RVA = "0x576B400", Offset = "0x576A000", VA = "0x18576B400")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x00025C38 File Offset: 0x00023E38
		[Token(Token = "0x17000861")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyzx
		{
			[Token(Token = "0x6001B8E")]
			[Address(RVA = "0x576B4C0", Offset = "0x576A0C0", VA = "0x18576B4C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00025C50 File Offset: 0x00023E50
		[Token(Token = "0x17000862")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyzy
		{
			[Token(Token = "0x6001B8F")]
			[Address(RVA = "0x576B4E0", Offset = "0x576A0E0", VA = "0x18576B4E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x00025C68 File Offset: 0x00023E68
		[Token(Token = "0x17000863")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyzz
		{
			[Token(Token = "0x6001B90")]
			[Address(RVA = "0x576B500", Offset = "0x576A100", VA = "0x18576B500")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00025C80 File Offset: 0x00023E80
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000864")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyzw
		{
			[Token(Token = "0x6001B91")]
			[Address(RVA = "0x576B4A0", Offset = "0x576A0A0", VA = "0x18576B4A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001B92")]
			[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x00025C98 File Offset: 0x00023E98
		[Token(Token = "0x17000865")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xywx
		{
			[Token(Token = "0x6001B93")]
			[Address(RVA = "0x576B2E0", Offset = "0x5769EE0", VA = "0x18576B2E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00025CB0 File Offset: 0x00023EB0
		[Token(Token = "0x17000866")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xywy
		{
			[Token(Token = "0x6001B94")]
			[Address(RVA = "0x576B300", Offset = "0x5769F00", VA = "0x18576B300")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x00025CC8 File Offset: 0x00023EC8
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000867")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xywz
		{
			[Token(Token = "0x6001B95")]
			[Address(RVA = "0x576B320", Offset = "0x5769F20", VA = "0x18576B320")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001B96")]
			[Address(RVA = "0x576D850", Offset = "0x576C450", VA = "0x18576D850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x00025CE0 File Offset: 0x00023EE0
		[Token(Token = "0x17000868")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyww
		{
			[Token(Token = "0x6001B97")]
			[Address(RVA = "0x576B2C0", Offset = "0x5769EC0", VA = "0x18576B2C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x00025CF8 File Offset: 0x00023EF8
		[Token(Token = "0x17000869")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzxx
		{
			[Token(Token = "0x6001B98")]
			[Address(RVA = "0x576B620", Offset = "0x576A220", VA = "0x18576B620")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x00025D10 File Offset: 0x00023F10
		[Token(Token = "0x1700086A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzxy
		{
			[Token(Token = "0x6001B99")]
			[Address(RVA = "0x576B640", Offset = "0x576A240", VA = "0x18576B640")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00025D28 File Offset: 0x00023F28
		[Token(Token = "0x1700086B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzxz
		{
			[Token(Token = "0x6001B9A")]
			[Address(RVA = "0x576B660", Offset = "0x576A260", VA = "0x18576B660")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x00025D40 File Offset: 0x00023F40
		[Token(Token = "0x1700086C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzxw
		{
			[Token(Token = "0x6001B9B")]
			[Address(RVA = "0x576B600", Offset = "0x576A200", VA = "0x18576B600")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00025D58 File Offset: 0x00023F58
		[Token(Token = "0x1700086D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzyx
		{
			[Token(Token = "0x6001B9C")]
			[Address(RVA = "0x576B6C0", Offset = "0x576A2C0", VA = "0x18576B6C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x00025D70 File Offset: 0x00023F70
		[Token(Token = "0x1700086E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzyy
		{
			[Token(Token = "0x6001B9D")]
			[Address(RVA = "0x576B6E0", Offset = "0x576A2E0", VA = "0x18576B6E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00025D88 File Offset: 0x00023F88
		[Token(Token = "0x1700086F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzyz
		{
			[Token(Token = "0x6001B9E")]
			[Address(RVA = "0x576B700", Offset = "0x576A300", VA = "0x18576B700")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x00025DA0 File Offset: 0x00023FA0
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000870")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzyw
		{
			[Token(Token = "0x6001B9F")]
			[Address(RVA = "0x576B6A0", Offset = "0x576A2A0", VA = "0x18576B6A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BA0")]
			[Address(RVA = "0x576D8E0", Offset = "0x576C4E0", VA = "0x18576D8E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00025DB8 File Offset: 0x00023FB8
		[Token(Token = "0x17000871")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzzx
		{
			[Token(Token = "0x6001BA1")]
			[Address(RVA = "0x576B760", Offset = "0x576A360", VA = "0x18576B760")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00025DD0 File Offset: 0x00023FD0
		[Token(Token = "0x17000872")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzzy
		{
			[Token(Token = "0x6001BA2")]
			[Address(RVA = "0x576B780", Offset = "0x576A380", VA = "0x18576B780")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00025DE8 File Offset: 0x00023FE8
		[Token(Token = "0x17000873")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzzz
		{
			[Token(Token = "0x6001BA3")]
			[Address(RVA = "0x576B7A0", Offset = "0x576A3A0", VA = "0x18576B7A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x00025E00 File Offset: 0x00024000
		[Token(Token = "0x17000874")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzzw
		{
			[Token(Token = "0x6001BA4")]
			[Address(RVA = "0x576B740", Offset = "0x576A340", VA = "0x18576B740")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00025E18 File Offset: 0x00024018
		[Token(Token = "0x17000875")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzwx
		{
			[Token(Token = "0x6001BA5")]
			[Address(RVA = "0x576B580", Offset = "0x576A180", VA = "0x18576B580")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00025E30 File Offset: 0x00024030
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000876")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzwy
		{
			[Token(Token = "0x6001BA6")]
			[Address(RVA = "0x576B5A0", Offset = "0x576A1A0", VA = "0x18576B5A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BA7")]
			[Address(RVA = "0x576D8A0", Offset = "0x576C4A0", VA = "0x18576D8A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00025E48 File Offset: 0x00024048
		[Token(Token = "0x17000877")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzwz
		{
			[Token(Token = "0x6001BA8")]
			[Address(RVA = "0x576B5C0", Offset = "0x576A1C0", VA = "0x18576B5C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x00025E60 File Offset: 0x00024060
		[Token(Token = "0x17000878")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzww
		{
			[Token(Token = "0x6001BA9")]
			[Address(RVA = "0x576B560", Offset = "0x576A160", VA = "0x18576B560")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00025E78 File Offset: 0x00024078
		[Token(Token = "0x17000879")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwxx
		{
			[Token(Token = "0x6001BAA")]
			[Address(RVA = "0x576AE60", Offset = "0x5769A60", VA = "0x18576AE60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x00025E90 File Offset: 0x00024090
		[Token(Token = "0x1700087A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwxy
		{
			[Token(Token = "0x6001BAB")]
			[Address(RVA = "0x576AE80", Offset = "0x5769A80", VA = "0x18576AE80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00025EA8 File Offset: 0x000240A8
		[Token(Token = "0x1700087B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwxz
		{
			[Token(Token = "0x6001BAC")]
			[Address(RVA = "0x576AEA0", Offset = "0x5769AA0", VA = "0x18576AEA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00025EC0 File Offset: 0x000240C0
		[Token(Token = "0x1700087C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwxw
		{
			[Token(Token = "0x6001BAD")]
			[Address(RVA = "0x576AE40", Offset = "0x5769A40", VA = "0x18576AE40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00025ED8 File Offset: 0x000240D8
		[Token(Token = "0x1700087D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwyx
		{
			[Token(Token = "0x6001BAE")]
			[Address(RVA = "0x576AF00", Offset = "0x5769B00", VA = "0x18576AF00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x00025EF0 File Offset: 0x000240F0
		[Token(Token = "0x1700087E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwyy
		{
			[Token(Token = "0x6001BAF")]
			[Address(RVA = "0x576AF20", Offset = "0x5769B20", VA = "0x18576AF20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00025F08 File Offset: 0x00024108
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700087F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwyz
		{
			[Token(Token = "0x6001BB0")]
			[Address(RVA = "0x576AF40", Offset = "0x5769B40", VA = "0x18576AF40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BB1")]
			[Address(RVA = "0x576D7C0", Offset = "0x576C3C0", VA = "0x18576D7C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00025F20 File Offset: 0x00024120
		[Token(Token = "0x17000880")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwyw
		{
			[Token(Token = "0x6001BB2")]
			[Address(RVA = "0x576AEE0", Offset = "0x5769AE0", VA = "0x18576AEE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00025F38 File Offset: 0x00024138
		[Token(Token = "0x17000881")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwzx
		{
			[Token(Token = "0x6001BB3")]
			[Address(RVA = "0x576AFA0", Offset = "0x5769BA0", VA = "0x18576AFA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00025F50 File Offset: 0x00024150
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000882")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwzy
		{
			[Token(Token = "0x6001BB4")]
			[Address(RVA = "0x576AFC0", Offset = "0x5769BC0", VA = "0x18576AFC0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BB5")]
			[Address(RVA = "0x576D800", Offset = "0x576C400", VA = "0x18576D800")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00025F68 File Offset: 0x00024168
		[Token(Token = "0x17000883")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwzz
		{
			[Token(Token = "0x6001BB6")]
			[Address(RVA = "0x576AFE0", Offset = "0x5769BE0", VA = "0x18576AFE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00025F80 File Offset: 0x00024180
		[Token(Token = "0x17000884")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwzw
		{
			[Token(Token = "0x6001BB7")]
			[Address(RVA = "0x576AF80", Offset = "0x5769B80", VA = "0x18576AF80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00025F98 File Offset: 0x00024198
		[Token(Token = "0x17000885")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwwx
		{
			[Token(Token = "0x6001BB8")]
			[Address(RVA = "0x576ADC0", Offset = "0x57699C0", VA = "0x18576ADC0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00025FB0 File Offset: 0x000241B0
		[Token(Token = "0x17000886")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwwy
		{
			[Token(Token = "0x6001BB9")]
			[Address(RVA = "0x576ADE0", Offset = "0x57699E0", VA = "0x18576ADE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00025FC8 File Offset: 0x000241C8
		[Token(Token = "0x17000887")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwwz
		{
			[Token(Token = "0x6001BBA")]
			[Address(RVA = "0x576AE00", Offset = "0x5769A00", VA = "0x18576AE00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00025FE0 File Offset: 0x000241E0
		[Token(Token = "0x17000888")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xwww
		{
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x576ADA0", Offset = "0x57699A0", VA = "0x18576ADA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00025FF8 File Offset: 0x000241F8
		[Token(Token = "0x17000889")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxx
		{
			[Token(Token = "0x6001BBC")]
			[Address(RVA = "0x576BB60", Offset = "0x576A760", VA = "0x18576BB60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00026010 File Offset: 0x00024210
		[Token(Token = "0x1700088A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxy
		{
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x576BB80", Offset = "0x576A780", VA = "0x18576BB80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00026028 File Offset: 0x00024228
		[Token(Token = "0x1700088B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxz
		{
			[Token(Token = "0x6001BBE")]
			[Address(RVA = "0x576BBA0", Offset = "0x576A7A0", VA = "0x18576BBA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00026040 File Offset: 0x00024240
		[Token(Token = "0x1700088C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxw
		{
			[Token(Token = "0x6001BBF")]
			[Address(RVA = "0x576BB40", Offset = "0x576A740", VA = "0x18576BB40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00026058 File Offset: 0x00024258
		[Token(Token = "0x1700088D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyx
		{
			[Token(Token = "0x6001BC0")]
			[Address(RVA = "0x576BC00", Offset = "0x576A800", VA = "0x18576BC00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00026070 File Offset: 0x00024270
		[Token(Token = "0x1700088E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyy
		{
			[Token(Token = "0x6001BC1")]
			[Address(RVA = "0x576BC20", Offset = "0x576A820", VA = "0x18576BC20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00026088 File Offset: 0x00024288
		[Token(Token = "0x1700088F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyz
		{
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0x576BC40", Offset = "0x576A840", VA = "0x18576BC40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x000260A0 File Offset: 0x000242A0
		[Token(Token = "0x17000890")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyw
		{
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x576BBE0", Offset = "0x576A7E0", VA = "0x18576BBE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x000260B8 File Offset: 0x000242B8
		[Token(Token = "0x17000891")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxzx
		{
			[Token(Token = "0x6001BC4")]
			[Address(RVA = "0x576BCA0", Offset = "0x576A8A0", VA = "0x18576BCA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x000260D0 File Offset: 0x000242D0
		[Token(Token = "0x17000892")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxzy
		{
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0x576BCC0", Offset = "0x576A8C0", VA = "0x18576BCC0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x000260E8 File Offset: 0x000242E8
		[Token(Token = "0x17000893")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxzz
		{
			[Token(Token = "0x6001BC6")]
			[Address(RVA = "0x576BCE0", Offset = "0x576A8E0", VA = "0x18576BCE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00026100 File Offset: 0x00024300
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000894")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxzw
		{
			[Token(Token = "0x6001BC7")]
			[Address(RVA = "0x576BC80", Offset = "0x576A880", VA = "0x18576BC80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BC8")]
			[Address(RVA = "0x576DA00", Offset = "0x576C600", VA = "0x18576DA00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00026118 File Offset: 0x00024318
		[Token(Token = "0x17000895")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxwx
		{
			[Token(Token = "0x6001BC9")]
			[Address(RVA = "0x576BAC0", Offset = "0x576A6C0", VA = "0x18576BAC0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00026130 File Offset: 0x00024330
		[Token(Token = "0x17000896")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxwy
		{
			[Token(Token = "0x6001BCA")]
			[Address(RVA = "0x576BAE0", Offset = "0x576A6E0", VA = "0x18576BAE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00026148 File Offset: 0x00024348
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000897")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxwz
		{
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x576BB00", Offset = "0x576A700", VA = "0x18576BB00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BCC")]
			[Address(RVA = "0x576D9C0", Offset = "0x576C5C0", VA = "0x18576D9C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00026160 File Offset: 0x00024360
		[Token(Token = "0x17000898")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxww
		{
			[Token(Token = "0x6001BCD")]
			[Address(RVA = "0x576BAA0", Offset = "0x576A6A0", VA = "0x18576BAA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00026178 File Offset: 0x00024378
		[Token(Token = "0x17000899")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxx
		{
			[Token(Token = "0x6001BCE")]
			[Address(RVA = "0x576BE00", Offset = "0x576AA00", VA = "0x18576BE00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00026190 File Offset: 0x00024390
		[Token(Token = "0x1700089A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxy
		{
			[Token(Token = "0x6001BCF")]
			[Address(RVA = "0x576BE20", Offset = "0x576AA20", VA = "0x18576BE20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x000261A8 File Offset: 0x000243A8
		[Token(Token = "0x1700089B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxz
		{
			[Token(Token = "0x6001BD0")]
			[Address(RVA = "0x576BE40", Offset = "0x576AA40", VA = "0x18576BE40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x000261C0 File Offset: 0x000243C0
		[Token(Token = "0x1700089C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxw
		{
			[Token(Token = "0x6001BD1")]
			[Address(RVA = "0x576BDE0", Offset = "0x576A9E0", VA = "0x18576BDE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000261D8 File Offset: 0x000243D8
		[Token(Token = "0x1700089D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyx
		{
			[Token(Token = "0x6001BD2")]
			[Address(RVA = "0x576BE90", Offset = "0x576AA90", VA = "0x18576BE90")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x000261F0 File Offset: 0x000243F0
		[Token(Token = "0x1700089E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyy
		{
			[Token(Token = "0x6001BD3")]
			[Address(RVA = "0x576BEB0", Offset = "0x576AAB0", VA = "0x18576BEB0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00026208 File Offset: 0x00024408
		[Token(Token = "0x1700089F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyz
		{
			[Token(Token = "0x6001BD4")]
			[Address(RVA = "0x576BED0", Offset = "0x576AAD0", VA = "0x18576BED0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00026220 File Offset: 0x00024420
		[Token(Token = "0x170008A0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyw
		{
			[Token(Token = "0x6001BD5")]
			[Address(RVA = "0x576BE70", Offset = "0x576AA70", VA = "0x18576BE70")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00026238 File Offset: 0x00024438
		[Token(Token = "0x170008A1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyzx
		{
			[Token(Token = "0x6001BD6")]
			[Address(RVA = "0x576BF30", Offset = "0x576AB30", VA = "0x18576BF30")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00026250 File Offset: 0x00024450
		[Token(Token = "0x170008A2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyzy
		{
			[Token(Token = "0x6001BD7")]
			[Address(RVA = "0x576BF50", Offset = "0x576AB50", VA = "0x18576BF50")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00026268 File Offset: 0x00024468
		[Token(Token = "0x170008A3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyzz
		{
			[Token(Token = "0x6001BD8")]
			[Address(RVA = "0x576BF70", Offset = "0x576AB70", VA = "0x18576BF70")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00026280 File Offset: 0x00024480
		[Token(Token = "0x170008A4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyzw
		{
			[Token(Token = "0x6001BD9")]
			[Address(RVA = "0x576BF10", Offset = "0x576AB10", VA = "0x18576BF10")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x00026298 File Offset: 0x00024498
		[Token(Token = "0x170008A5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yywx
		{
			[Token(Token = "0x6001BDA")]
			[Address(RVA = "0x576BD60", Offset = "0x576A960", VA = "0x18576BD60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x000262B0 File Offset: 0x000244B0
		[Token(Token = "0x170008A6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yywy
		{
			[Token(Token = "0x6001BDB")]
			[Address(RVA = "0x576BD80", Offset = "0x576A980", VA = "0x18576BD80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x000262C8 File Offset: 0x000244C8
		[Token(Token = "0x170008A7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yywz
		{
			[Token(Token = "0x6001BDC")]
			[Address(RVA = "0x576BDA0", Offset = "0x576A9A0", VA = "0x18576BDA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000262E0 File Offset: 0x000244E0
		[Token(Token = "0x170008A8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyww
		{
			[Token(Token = "0x6001BDD")]
			[Address(RVA = "0x576BD40", Offset = "0x576A940", VA = "0x18576BD40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000262F8 File Offset: 0x000244F8
		[Token(Token = "0x170008A9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzxx
		{
			[Token(Token = "0x6001BDE")]
			[Address(RVA = "0x576C090", Offset = "0x576AC90", VA = "0x18576C090")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00026310 File Offset: 0x00024510
		[Token(Token = "0x170008AA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzxy
		{
			[Token(Token = "0x6001BDF")]
			[Address(RVA = "0x576C0B0", Offset = "0x576ACB0", VA = "0x18576C0B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00026328 File Offset: 0x00024528
		[Token(Token = "0x170008AB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzxz
		{
			[Token(Token = "0x6001BE0")]
			[Address(RVA = "0x576C0D0", Offset = "0x576ACD0", VA = "0x18576C0D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00026340 File Offset: 0x00024540
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzxw
		{
			[Token(Token = "0x6001BE1")]
			[Address(RVA = "0x576C070", Offset = "0x576AC70", VA = "0x18576C070")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BE2")]
			[Address(RVA = "0x576DA90", Offset = "0x576C690", VA = "0x18576DA90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x00026358 File Offset: 0x00024558
		[Token(Token = "0x170008AD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzyx
		{
			[Token(Token = "0x6001BE3")]
			[Address(RVA = "0x576C130", Offset = "0x576AD30", VA = "0x18576C130")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00026370 File Offset: 0x00024570
		[Token(Token = "0x170008AE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzyy
		{
			[Token(Token = "0x6001BE4")]
			[Address(RVA = "0x576C150", Offset = "0x576AD50", VA = "0x18576C150")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x00026388 File Offset: 0x00024588
		[Token(Token = "0x170008AF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzyz
		{
			[Token(Token = "0x6001BE5")]
			[Address(RVA = "0x576C170", Offset = "0x576AD70", VA = "0x18576C170")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000263A0 File Offset: 0x000245A0
		[Token(Token = "0x170008B0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzyw
		{
			[Token(Token = "0x6001BE6")]
			[Address(RVA = "0x576C110", Offset = "0x576AD10", VA = "0x18576C110")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x000263B8 File Offset: 0x000245B8
		[Token(Token = "0x170008B1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzzx
		{
			[Token(Token = "0x6001BE7")]
			[Address(RVA = "0x576C1D0", Offset = "0x576ADD0", VA = "0x18576C1D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x000263D0 File Offset: 0x000245D0
		[Token(Token = "0x170008B2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzzy
		{
			[Token(Token = "0x6001BE8")]
			[Address(RVA = "0x576C1F0", Offset = "0x576ADF0", VA = "0x18576C1F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x000263E8 File Offset: 0x000245E8
		[Token(Token = "0x170008B3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzzz
		{
			[Token(Token = "0x6001BE9")]
			[Address(RVA = "0x576C210", Offset = "0x576AE10", VA = "0x18576C210")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x00026400 File Offset: 0x00024600
		[Token(Token = "0x170008B4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzzw
		{
			[Token(Token = "0x6001BEA")]
			[Address(RVA = "0x576C1B0", Offset = "0x576ADB0", VA = "0x18576C1B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x00026418 File Offset: 0x00024618
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzwx
		{
			[Token(Token = "0x6001BEB")]
			[Address(RVA = "0x576BFF0", Offset = "0x576ABF0", VA = "0x18576BFF0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BEC")]
			[Address(RVA = "0x576DA50", Offset = "0x576C650", VA = "0x18576DA50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x00026430 File Offset: 0x00024630
		[Token(Token = "0x170008B6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzwy
		{
			[Token(Token = "0x6001BED")]
			[Address(RVA = "0x576C010", Offset = "0x576AC10", VA = "0x18576C010")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00026448 File Offset: 0x00024648
		[Token(Token = "0x170008B7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzwz
		{
			[Token(Token = "0x6001BEE")]
			[Address(RVA = "0x576C030", Offset = "0x576AC30", VA = "0x18576C030")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x00026460 File Offset: 0x00024660
		[Token(Token = "0x170008B8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzww
		{
			[Token(Token = "0x6001BEF")]
			[Address(RVA = "0x576BFD0", Offset = "0x576ABD0", VA = "0x18576BFD0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x00026478 File Offset: 0x00024678
		[Token(Token = "0x170008B9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywxx
		{
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0x576B8C0", Offset = "0x576A4C0", VA = "0x18576B8C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00026490 File Offset: 0x00024690
		[Token(Token = "0x170008BA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywxy
		{
			[Token(Token = "0x6001BF1")]
			[Address(RVA = "0x576B8E0", Offset = "0x576A4E0", VA = "0x18576B8E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000264A8 File Offset: 0x000246A8
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008BB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywxz
		{
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0x576B900", Offset = "0x576A500", VA = "0x18576B900")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0x576D930", Offset = "0x576C530", VA = "0x18576D930")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x000264C0 File Offset: 0x000246C0
		[Token(Token = "0x170008BC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywxw
		{
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0x576B8A0", Offset = "0x576A4A0", VA = "0x18576B8A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x000264D8 File Offset: 0x000246D8
		[Token(Token = "0x170008BD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywyx
		{
			[Token(Token = "0x6001BF5")]
			[Address(RVA = "0x576B960", Offset = "0x576A560", VA = "0x18576B960")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x000264F0 File Offset: 0x000246F0
		[Token(Token = "0x170008BE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywyy
		{
			[Token(Token = "0x6001BF6")]
			[Address(RVA = "0x576B980", Offset = "0x576A580", VA = "0x18576B980")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00026508 File Offset: 0x00024708
		[Token(Token = "0x170008BF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywyz
		{
			[Token(Token = "0x6001BF7")]
			[Address(RVA = "0x576B9A0", Offset = "0x576A5A0", VA = "0x18576B9A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00026520 File Offset: 0x00024720
		[Token(Token = "0x170008C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywyw
		{
			[Token(Token = "0x6001BF8")]
			[Address(RVA = "0x576B940", Offset = "0x576A540", VA = "0x18576B940")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x00026538 File Offset: 0x00024738
		// (set) Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywzx
		{
			[Token(Token = "0x6001BF9")]
			[Address(RVA = "0x576BA00", Offset = "0x576A600", VA = "0x18576BA00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001BFA")]
			[Address(RVA = "0x576D970", Offset = "0x576C570", VA = "0x18576D970")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x00026550 File Offset: 0x00024750
		[Token(Token = "0x170008C2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywzy
		{
			[Token(Token = "0x6001BFB")]
			[Address(RVA = "0x576BA20", Offset = "0x576A620", VA = "0x18576BA20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x00026568 File Offset: 0x00024768
		[Token(Token = "0x170008C3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywzz
		{
			[Token(Token = "0x6001BFC")]
			[Address(RVA = "0x576BA40", Offset = "0x576A640", VA = "0x18576BA40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00026580 File Offset: 0x00024780
		[Token(Token = "0x170008C4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywzw
		{
			[Token(Token = "0x6001BFD")]
			[Address(RVA = "0x576B9E0", Offset = "0x576A5E0", VA = "0x18576B9E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00026598 File Offset: 0x00024798
		[Token(Token = "0x170008C5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywwx
		{
			[Token(Token = "0x6001BFE")]
			[Address(RVA = "0x576B820", Offset = "0x576A420", VA = "0x18576B820")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x000265B0 File Offset: 0x000247B0
		[Token(Token = "0x170008C6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywwy
		{
			[Token(Token = "0x6001BFF")]
			[Address(RVA = "0x576B840", Offset = "0x576A440", VA = "0x18576B840")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x000265C8 File Offset: 0x000247C8
		[Token(Token = "0x170008C7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywwz
		{
			[Token(Token = "0x6001C00")]
			[Address(RVA = "0x576B860", Offset = "0x576A460", VA = "0x18576B860")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x000265E0 File Offset: 0x000247E0
		[Token(Token = "0x170008C8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 ywww
		{
			[Token(Token = "0x6001C01")]
			[Address(RVA = "0x576B800", Offset = "0x576A400", VA = "0x18576B800")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000265F8 File Offset: 0x000247F8
		[Token(Token = "0x170008C9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxxx
		{
			[Token(Token = "0x6001C02")]
			[Address(RVA = "0x576C5B0", Offset = "0x576B1B0", VA = "0x18576C5B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x00026610 File Offset: 0x00024810
		[Token(Token = "0x170008CA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxxy
		{
			[Token(Token = "0x6001C03")]
			[Address(RVA = "0x576C5D0", Offset = "0x576B1D0", VA = "0x18576C5D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x00026628 File Offset: 0x00024828
		[Token(Token = "0x170008CB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxxz
		{
			[Token(Token = "0x6001C04")]
			[Address(RVA = "0x576C5F0", Offset = "0x576B1F0", VA = "0x18576C5F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00026640 File Offset: 0x00024840
		[Token(Token = "0x170008CC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxxw
		{
			[Token(Token = "0x6001C05")]
			[Address(RVA = "0x576C590", Offset = "0x576B190", VA = "0x18576C590")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00026658 File Offset: 0x00024858
		[Token(Token = "0x170008CD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxyx
		{
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0x576C650", Offset = "0x576B250", VA = "0x18576C650")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x00026670 File Offset: 0x00024870
		[Token(Token = "0x170008CE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxyy
		{
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0x576C670", Offset = "0x576B270", VA = "0x18576C670")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00026688 File Offset: 0x00024888
		[Token(Token = "0x170008CF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxyz
		{
			[Token(Token = "0x6001C08")]
			[Address(RVA = "0x576C690", Offset = "0x576B290", VA = "0x18576C690")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x000266A0 File Offset: 0x000248A0
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxyw
		{
			[Token(Token = "0x6001C09")]
			[Address(RVA = "0x576C630", Offset = "0x576B230", VA = "0x18576C630")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x576DBB0", Offset = "0x576C7B0", VA = "0x18576DBB0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x000266B8 File Offset: 0x000248B8
		[Token(Token = "0x170008D1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxzx
		{
			[Token(Token = "0x6001C0B")]
			[Address(RVA = "0x576C6F0", Offset = "0x576B2F0", VA = "0x18576C6F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000266D0 File Offset: 0x000248D0
		[Token(Token = "0x170008D2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxzy
		{
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0x576C710", Offset = "0x576B310", VA = "0x18576C710")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x000266E8 File Offset: 0x000248E8
		[Token(Token = "0x170008D3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxzz
		{
			[Token(Token = "0x6001C0D")]
			[Address(RVA = "0x576C730", Offset = "0x576B330", VA = "0x18576C730")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00026700 File Offset: 0x00024900
		[Token(Token = "0x170008D4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxzw
		{
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0x576C6D0", Offset = "0x576B2D0", VA = "0x18576C6D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x00026718 File Offset: 0x00024918
		[Token(Token = "0x170008D5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxwx
		{
			[Token(Token = "0x6001C0F")]
			[Address(RVA = "0x576C510", Offset = "0x576B110", VA = "0x18576C510")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00026730 File Offset: 0x00024930
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxwy
		{
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x576C530", Offset = "0x576B130", VA = "0x18576C530")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C11")]
			[Address(RVA = "0x576DB70", Offset = "0x576C770", VA = "0x18576DB70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00026748 File Offset: 0x00024948
		[Token(Token = "0x170008D7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxwz
		{
			[Token(Token = "0x6001C12")]
			[Address(RVA = "0x576C550", Offset = "0x576B150", VA = "0x18576C550")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x00026760 File Offset: 0x00024960
		[Token(Token = "0x170008D8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxww
		{
			[Token(Token = "0x6001C13")]
			[Address(RVA = "0x576C4F0", Offset = "0x576B0F0", VA = "0x18576C4F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00026778 File Offset: 0x00024978
		[Token(Token = "0x170008D9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyxx
		{
			[Token(Token = "0x6001C14")]
			[Address(RVA = "0x576C850", Offset = "0x576B450", VA = "0x18576C850")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x00026790 File Offset: 0x00024990
		[Token(Token = "0x170008DA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyxy
		{
			[Token(Token = "0x6001C15")]
			[Address(RVA = "0x576C870", Offset = "0x576B470", VA = "0x18576C870")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000267A8 File Offset: 0x000249A8
		[Token(Token = "0x170008DB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyxz
		{
			[Token(Token = "0x6001C16")]
			[Address(RVA = "0x576C890", Offset = "0x576B490", VA = "0x18576C890")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x000267C0 File Offset: 0x000249C0
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyxw
		{
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0x576C830", Offset = "0x576B430", VA = "0x18576C830")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x576DC40", Offset = "0x576C840", VA = "0x18576DC40")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x000267D8 File Offset: 0x000249D8
		[Token(Token = "0x170008DD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyyx
		{
			[Token(Token = "0x6001C19")]
			[Address(RVA = "0x576C8F0", Offset = "0x576B4F0", VA = "0x18576C8F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x000267F0 File Offset: 0x000249F0
		[Token(Token = "0x170008DE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyyy
		{
			[Token(Token = "0x6001C1A")]
			[Address(RVA = "0x576C910", Offset = "0x576B510", VA = "0x18576C910")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x00026808 File Offset: 0x00024A08
		[Token(Token = "0x170008DF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyyz
		{
			[Token(Token = "0x6001C1B")]
			[Address(RVA = "0x576C930", Offset = "0x576B530", VA = "0x18576C930")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00026820 File Offset: 0x00024A20
		[Token(Token = "0x170008E0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyyw
		{
			[Token(Token = "0x6001C1C")]
			[Address(RVA = "0x576C8D0", Offset = "0x576B4D0", VA = "0x18576C8D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x00026838 File Offset: 0x00024A38
		[Token(Token = "0x170008E1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyzx
		{
			[Token(Token = "0x6001C1D")]
			[Address(RVA = "0x576C990", Offset = "0x576B590", VA = "0x18576C990")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00026850 File Offset: 0x00024A50
		[Token(Token = "0x170008E2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyzy
		{
			[Token(Token = "0x6001C1E")]
			[Address(RVA = "0x576C9B0", Offset = "0x576B5B0", VA = "0x18576C9B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x00026868 File Offset: 0x00024A68
		[Token(Token = "0x170008E3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyzz
		{
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0x576C9D0", Offset = "0x576B5D0", VA = "0x18576C9D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00026880 File Offset: 0x00024A80
		[Token(Token = "0x170008E4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyzw
		{
			[Token(Token = "0x6001C20")]
			[Address(RVA = "0x576C970", Offset = "0x576B570", VA = "0x18576C970")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00026898 File Offset: 0x00024A98
		// (set) Token: 0x06001C22 RID: 7202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zywx
		{
			[Token(Token = "0x6001C21")]
			[Address(RVA = "0x576C7B0", Offset = "0x576B3B0", VA = "0x18576C7B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C22")]
			[Address(RVA = "0x576DC00", Offset = "0x576C800", VA = "0x18576DC00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x000268B0 File Offset: 0x00024AB0
		[Token(Token = "0x170008E6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zywy
		{
			[Token(Token = "0x6001C23")]
			[Address(RVA = "0x576C7D0", Offset = "0x576B3D0", VA = "0x18576C7D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x000268C8 File Offset: 0x00024AC8
		[Token(Token = "0x170008E7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zywz
		{
			[Token(Token = "0x6001C24")]
			[Address(RVA = "0x576C7F0", Offset = "0x576B3F0", VA = "0x18576C7F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x000268E0 File Offset: 0x00024AE0
		[Token(Token = "0x170008E8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyww
		{
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x576C790", Offset = "0x576B390", VA = "0x18576C790")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000268F8 File Offset: 0x00024AF8
		[Token(Token = "0x170008E9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzxx
		{
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0x576CAF0", Offset = "0x576B6F0", VA = "0x18576CAF0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00026910 File Offset: 0x00024B10
		[Token(Token = "0x170008EA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzxy
		{
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x576CB10", Offset = "0x576B710", VA = "0x18576CB10")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00026928 File Offset: 0x00024B28
		[Token(Token = "0x170008EB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzxz
		{
			[Token(Token = "0x6001C28")]
			[Address(RVA = "0x576CB30", Offset = "0x576B730", VA = "0x18576CB30")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x00026940 File Offset: 0x00024B40
		[Token(Token = "0x170008EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzxw
		{
			[Token(Token = "0x6001C29")]
			[Address(RVA = "0x576CAD0", Offset = "0x576B6D0", VA = "0x18576CAD0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00026958 File Offset: 0x00024B58
		[Token(Token = "0x170008ED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzyx
		{
			[Token(Token = "0x6001C2A")]
			[Address(RVA = "0x576CB90", Offset = "0x576B790", VA = "0x18576CB90")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x00026970 File Offset: 0x00024B70
		[Token(Token = "0x170008EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzyy
		{
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0x576CBB0", Offset = "0x576B7B0", VA = "0x18576CBB0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00026988 File Offset: 0x00024B88
		[Token(Token = "0x170008EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzyz
		{
			[Token(Token = "0x6001C2C")]
			[Address(RVA = "0x576CBD0", Offset = "0x576B7D0", VA = "0x18576CBD0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000269A0 File Offset: 0x00024BA0
		[Token(Token = "0x170008F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzyw
		{
			[Token(Token = "0x6001C2D")]
			[Address(RVA = "0x576CB70", Offset = "0x576B770", VA = "0x18576CB70")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x000269B8 File Offset: 0x00024BB8
		[Token(Token = "0x170008F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzzx
		{
			[Token(Token = "0x6001C2E")]
			[Address(RVA = "0x576CC20", Offset = "0x576B820", VA = "0x18576CC20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x000269D0 File Offset: 0x00024BD0
		[Token(Token = "0x170008F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzzy
		{
			[Token(Token = "0x6001C2F")]
			[Address(RVA = "0x576CC40", Offset = "0x576B840", VA = "0x18576CC40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x000269E8 File Offset: 0x00024BE8
		[Token(Token = "0x170008F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzzz
		{
			[Token(Token = "0x6001C30")]
			[Address(RVA = "0x576CC60", Offset = "0x576B860", VA = "0x18576CC60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00026A00 File Offset: 0x00024C00
		[Token(Token = "0x170008F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzzw
		{
			[Token(Token = "0x6001C31")]
			[Address(RVA = "0x576CC00", Offset = "0x576B800", VA = "0x18576CC00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00026A18 File Offset: 0x00024C18
		[Token(Token = "0x170008F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzwx
		{
			[Token(Token = "0x6001C32")]
			[Address(RVA = "0x576CA50", Offset = "0x576B650", VA = "0x18576CA50")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x00026A30 File Offset: 0x00024C30
		[Token(Token = "0x170008F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzwy
		{
			[Token(Token = "0x6001C33")]
			[Address(RVA = "0x576CA70", Offset = "0x576B670", VA = "0x18576CA70")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00026A48 File Offset: 0x00024C48
		[Token(Token = "0x170008F7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzwz
		{
			[Token(Token = "0x6001C34")]
			[Address(RVA = "0x576CA90", Offset = "0x576B690", VA = "0x18576CA90")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x00026A60 File Offset: 0x00024C60
		[Token(Token = "0x170008F8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzww
		{
			[Token(Token = "0x6001C35")]
			[Address(RVA = "0x576CA30", Offset = "0x576B630", VA = "0x18576CA30")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00026A78 File Offset: 0x00024C78
		[Token(Token = "0x170008F9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwxx
		{
			[Token(Token = "0x6001C36")]
			[Address(RVA = "0x576C310", Offset = "0x576AF10", VA = "0x18576C310")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x00026A90 File Offset: 0x00024C90
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwxy
		{
			[Token(Token = "0x6001C37")]
			[Address(RVA = "0x576C330", Offset = "0x576AF30", VA = "0x18576C330")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C38")]
			[Address(RVA = "0x576DAE0", Offset = "0x576C6E0", VA = "0x18576DAE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x00026AA8 File Offset: 0x00024CA8
		[Token(Token = "0x170008FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwxz
		{
			[Token(Token = "0x6001C39")]
			[Address(RVA = "0x576C350", Offset = "0x576AF50", VA = "0x18576C350")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x00026AC0 File Offset: 0x00024CC0
		[Token(Token = "0x170008FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwxw
		{
			[Token(Token = "0x6001C3A")]
			[Address(RVA = "0x576C2F0", Offset = "0x576AEF0", VA = "0x18576C2F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x00026AD8 File Offset: 0x00024CD8
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwyx
		{
			[Token(Token = "0x6001C3B")]
			[Address(RVA = "0x576C3B0", Offset = "0x576AFB0", VA = "0x18576C3B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C3C")]
			[Address(RVA = "0x576DB20", Offset = "0x576C720", VA = "0x18576DB20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00026AF0 File Offset: 0x00024CF0
		[Token(Token = "0x170008FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwyy
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x576C3D0", Offset = "0x576AFD0", VA = "0x18576C3D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00026B08 File Offset: 0x00024D08
		[Token(Token = "0x170008FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwyz
		{
			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0x576C3F0", Offset = "0x576AFF0", VA = "0x18576C3F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00026B20 File Offset: 0x00024D20
		[Token(Token = "0x17000900")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwyw
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x576C390", Offset = "0x576AF90", VA = "0x18576C390")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00026B38 File Offset: 0x00024D38
		[Token(Token = "0x17000901")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwzx
		{
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x576C450", Offset = "0x576B050", VA = "0x18576C450")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00026B50 File Offset: 0x00024D50
		[Token(Token = "0x17000902")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwzy
		{
			[Token(Token = "0x6001C41")]
			[Address(RVA = "0x576C470", Offset = "0x576B070", VA = "0x18576C470")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00026B68 File Offset: 0x00024D68
		[Token(Token = "0x17000903")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwzz
		{
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0x576C490", Offset = "0x576B090", VA = "0x18576C490")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x00026B80 File Offset: 0x00024D80
		[Token(Token = "0x17000904")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwzw
		{
			[Token(Token = "0x6001C43")]
			[Address(RVA = "0x576C430", Offset = "0x576B030", VA = "0x18576C430")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00026B98 File Offset: 0x00024D98
		[Token(Token = "0x17000905")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwwx
		{
			[Token(Token = "0x6001C44")]
			[Address(RVA = "0x576C270", Offset = "0x576AE70", VA = "0x18576C270")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x00026BB0 File Offset: 0x00024DB0
		[Token(Token = "0x17000906")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwwy
		{
			[Token(Token = "0x6001C45")]
			[Address(RVA = "0x576C290", Offset = "0x576AE90", VA = "0x18576C290")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00026BC8 File Offset: 0x00024DC8
		[Token(Token = "0x17000907")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwwz
		{
			[Token(Token = "0x6001C46")]
			[Address(RVA = "0x576C2B0", Offset = "0x576AEB0", VA = "0x18576C2B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00026BE0 File Offset: 0x00024DE0
		[Token(Token = "0x17000908")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zwww
		{
			[Token(Token = "0x6001C47")]
			[Address(RVA = "0x576C250", Offset = "0x576AE50", VA = "0x18576C250")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00026BF8 File Offset: 0x00024DF8
		[Token(Token = "0x17000909")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxxx
		{
			[Token(Token = "0x6001C48")]
			[Address(RVA = "0x576A680", Offset = "0x5769280", VA = "0x18576A680")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00026C10 File Offset: 0x00024E10
		[Token(Token = "0x1700090A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxxy
		{
			[Token(Token = "0x6001C49")]
			[Address(RVA = "0x576A6A0", Offset = "0x57692A0", VA = "0x18576A6A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x00026C28 File Offset: 0x00024E28
		[Token(Token = "0x1700090B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxxz
		{
			[Token(Token = "0x6001C4A")]
			[Address(RVA = "0x576A6C0", Offset = "0x57692C0", VA = "0x18576A6C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00026C40 File Offset: 0x00024E40
		[Token(Token = "0x1700090C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxxw
		{
			[Token(Token = "0x6001C4B")]
			[Address(RVA = "0x576A660", Offset = "0x5769260", VA = "0x18576A660")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00026C58 File Offset: 0x00024E58
		[Token(Token = "0x1700090D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxyx
		{
			[Token(Token = "0x6001C4C")]
			[Address(RVA = "0x576A720", Offset = "0x5769320", VA = "0x18576A720")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x00026C70 File Offset: 0x00024E70
		[Token(Token = "0x1700090E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxyy
		{
			[Token(Token = "0x6001C4D")]
			[Address(RVA = "0x576A740", Offset = "0x5769340", VA = "0x18576A740")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00026C88 File Offset: 0x00024E88
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700090F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxyz
		{
			[Token(Token = "0x6001C4E")]
			[Address(RVA = "0x576A760", Offset = "0x5769360", VA = "0x18576A760")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C4F")]
			[Address(RVA = "0x576D610", Offset = "0x576C210", VA = "0x18576D610")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00026CA0 File Offset: 0x00024EA0
		[Token(Token = "0x17000910")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxyw
		{
			[Token(Token = "0x6001C50")]
			[Address(RVA = "0x576A700", Offset = "0x5769300", VA = "0x18576A700")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00026CB8 File Offset: 0x00024EB8
		[Token(Token = "0x17000911")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxzx
		{
			[Token(Token = "0x6001C51")]
			[Address(RVA = "0x576A7C0", Offset = "0x57693C0", VA = "0x18576A7C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00026CD0 File Offset: 0x00024ED0
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000912")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxzy
		{
			[Token(Token = "0x6001C52")]
			[Address(RVA = "0x576A7E0", Offset = "0x57693E0", VA = "0x18576A7E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C53")]
			[Address(RVA = "0x576D650", Offset = "0x576C250", VA = "0x18576D650")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00026CE8 File Offset: 0x00024EE8
		[Token(Token = "0x17000913")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxzz
		{
			[Token(Token = "0x6001C54")]
			[Address(RVA = "0x576A800", Offset = "0x5769400", VA = "0x18576A800")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00026D00 File Offset: 0x00024F00
		[Token(Token = "0x17000914")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxzw
		{
			[Token(Token = "0x6001C55")]
			[Address(RVA = "0x576A7A0", Offset = "0x57693A0", VA = "0x18576A7A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00026D18 File Offset: 0x00024F18
		[Token(Token = "0x17000915")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxwx
		{
			[Token(Token = "0x6001C56")]
			[Address(RVA = "0x576A5E0", Offset = "0x57691E0", VA = "0x18576A5E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00026D30 File Offset: 0x00024F30
		[Token(Token = "0x17000916")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxwy
		{
			[Token(Token = "0x6001C57")]
			[Address(RVA = "0x576A600", Offset = "0x5769200", VA = "0x18576A600")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00026D48 File Offset: 0x00024F48
		[Token(Token = "0x17000917")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxwz
		{
			[Token(Token = "0x6001C58")]
			[Address(RVA = "0x576A620", Offset = "0x5769220", VA = "0x18576A620")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x00026D60 File Offset: 0x00024F60
		[Token(Token = "0x17000918")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wxww
		{
			[Token(Token = "0x6001C59")]
			[Address(RVA = "0x576A5C0", Offset = "0x57691C0", VA = "0x18576A5C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00026D78 File Offset: 0x00024F78
		[Token(Token = "0x17000919")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyxx
		{
			[Token(Token = "0x6001C5A")]
			[Address(RVA = "0x576A920", Offset = "0x5769520", VA = "0x18576A920")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00026D90 File Offset: 0x00024F90
		[Token(Token = "0x1700091A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyxy
		{
			[Token(Token = "0x6001C5B")]
			[Address(RVA = "0x576A940", Offset = "0x5769540", VA = "0x18576A940")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00026DA8 File Offset: 0x00024FA8
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyxz
		{
			[Token(Token = "0x6001C5C")]
			[Address(RVA = "0x576A960", Offset = "0x5769560", VA = "0x18576A960")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C5D")]
			[Address(RVA = "0x576D6A0", Offset = "0x576C2A0", VA = "0x18576D6A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00026DC0 File Offset: 0x00024FC0
		[Token(Token = "0x1700091C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyxw
		{
			[Token(Token = "0x6001C5E")]
			[Address(RVA = "0x576A900", Offset = "0x5769500", VA = "0x18576A900")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00026DD8 File Offset: 0x00024FD8
		[Token(Token = "0x1700091D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyyx
		{
			[Token(Token = "0x6001C5F")]
			[Address(RVA = "0x576A9C0", Offset = "0x57695C0", VA = "0x18576A9C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00026DF0 File Offset: 0x00024FF0
		[Token(Token = "0x1700091E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyyy
		{
			[Token(Token = "0x6001C60")]
			[Address(RVA = "0x576A9E0", Offset = "0x57695E0", VA = "0x18576A9E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00026E08 File Offset: 0x00025008
		[Token(Token = "0x1700091F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyyz
		{
			[Token(Token = "0x6001C61")]
			[Address(RVA = "0x576AA00", Offset = "0x5769600", VA = "0x18576AA00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00026E20 File Offset: 0x00025020
		[Token(Token = "0x17000920")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyyw
		{
			[Token(Token = "0x6001C62")]
			[Address(RVA = "0x576A9A0", Offset = "0x57695A0", VA = "0x18576A9A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00026E38 File Offset: 0x00025038
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000921")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyzx
		{
			[Token(Token = "0x6001C63")]
			[Address(RVA = "0x576AA60", Offset = "0x5769660", VA = "0x18576AA60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C64")]
			[Address(RVA = "0x576D6E0", Offset = "0x576C2E0", VA = "0x18576D6E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00026E50 File Offset: 0x00025050
		[Token(Token = "0x17000922")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyzy
		{
			[Token(Token = "0x6001C65")]
			[Address(RVA = "0x576AA80", Offset = "0x5769680", VA = "0x18576AA80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00026E68 File Offset: 0x00025068
		[Token(Token = "0x17000923")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyzz
		{
			[Token(Token = "0x6001C66")]
			[Address(RVA = "0x576AAA0", Offset = "0x57696A0", VA = "0x18576AAA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00026E80 File Offset: 0x00025080
		[Token(Token = "0x17000924")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyzw
		{
			[Token(Token = "0x6001C67")]
			[Address(RVA = "0x576AA40", Offset = "0x5769640", VA = "0x18576AA40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x00026E98 File Offset: 0x00025098
		[Token(Token = "0x17000925")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wywx
		{
			[Token(Token = "0x6001C68")]
			[Address(RVA = "0x576A880", Offset = "0x5769480", VA = "0x18576A880")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00026EB0 File Offset: 0x000250B0
		[Token(Token = "0x17000926")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wywy
		{
			[Token(Token = "0x6001C69")]
			[Address(RVA = "0x576A8A0", Offset = "0x57694A0", VA = "0x18576A8A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00026EC8 File Offset: 0x000250C8
		[Token(Token = "0x17000927")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wywz
		{
			[Token(Token = "0x6001C6A")]
			[Address(RVA = "0x576A8C0", Offset = "0x57694C0", VA = "0x18576A8C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x00026EE0 File Offset: 0x000250E0
		[Token(Token = "0x17000928")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wyww
		{
			[Token(Token = "0x6001C6B")]
			[Address(RVA = "0x576A860", Offset = "0x5769460", VA = "0x18576A860")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00026EF8 File Offset: 0x000250F8
		[Token(Token = "0x17000929")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzxx
		{
			[Token(Token = "0x6001C6C")]
			[Address(RVA = "0x576ABC0", Offset = "0x57697C0", VA = "0x18576ABC0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x00026F10 File Offset: 0x00025110
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzxy
		{
			[Token(Token = "0x6001C6D")]
			[Address(RVA = "0x576ABE0", Offset = "0x57697E0", VA = "0x18576ABE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C6E")]
			[Address(RVA = "0x576D730", Offset = "0x576C330", VA = "0x18576D730")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x00026F28 File Offset: 0x00025128
		[Token(Token = "0x1700092B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzxz
		{
			[Token(Token = "0x6001C6F")]
			[Address(RVA = "0x576AC00", Offset = "0x5769800", VA = "0x18576AC00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00026F40 File Offset: 0x00025140
		[Token(Token = "0x1700092C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzxw
		{
			[Token(Token = "0x6001C70")]
			[Address(RVA = "0x576ABA0", Offset = "0x57697A0", VA = "0x18576ABA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00026F58 File Offset: 0x00025158
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzyx
		{
			[Token(Token = "0x6001C71")]
			[Address(RVA = "0x576AC60", Offset = "0x5769860", VA = "0x18576AC60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
			[Token(Token = "0x6001C72")]
			[Address(RVA = "0x576D770", Offset = "0x576C370", VA = "0x18576D770")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x00026F70 File Offset: 0x00025170
		[Token(Token = "0x1700092E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzyy
		{
			[Token(Token = "0x6001C73")]
			[Address(RVA = "0x576AC80", Offset = "0x5769880", VA = "0x18576AC80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00026F88 File Offset: 0x00025188
		[Token(Token = "0x1700092F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzyz
		{
			[Token(Token = "0x6001C74")]
			[Address(RVA = "0x576ACA0", Offset = "0x57698A0", VA = "0x18576ACA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00026FA0 File Offset: 0x000251A0
		[Token(Token = "0x17000930")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzyw
		{
			[Token(Token = "0x6001C75")]
			[Address(RVA = "0x576AC40", Offset = "0x5769840", VA = "0x18576AC40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00026FB8 File Offset: 0x000251B8
		[Token(Token = "0x17000931")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzzx
		{
			[Token(Token = "0x6001C76")]
			[Address(RVA = "0x576AD00", Offset = "0x5769900", VA = "0x18576AD00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00026FD0 File Offset: 0x000251D0
		[Token(Token = "0x17000932")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzzy
		{
			[Token(Token = "0x6001C77")]
			[Address(RVA = "0x576AD20", Offset = "0x5769920", VA = "0x18576AD20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00026FE8 File Offset: 0x000251E8
		[Token(Token = "0x17000933")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzzz
		{
			[Token(Token = "0x6001C78")]
			[Address(RVA = "0x576AD40", Offset = "0x5769940", VA = "0x18576AD40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00027000 File Offset: 0x00025200
		[Token(Token = "0x17000934")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzzw
		{
			[Token(Token = "0x6001C79")]
			[Address(RVA = "0x576ACE0", Offset = "0x57698E0", VA = "0x18576ACE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00027018 File Offset: 0x00025218
		[Token(Token = "0x17000935")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzwx
		{
			[Token(Token = "0x6001C7A")]
			[Address(RVA = "0x576AB20", Offset = "0x5769720", VA = "0x18576AB20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x00027030 File Offset: 0x00025230
		[Token(Token = "0x17000936")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzwy
		{
			[Token(Token = "0x6001C7B")]
			[Address(RVA = "0x576AB40", Offset = "0x5769740", VA = "0x18576AB40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x00027048 File Offset: 0x00025248
		[Token(Token = "0x17000937")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzwz
		{
			[Token(Token = "0x6001C7C")]
			[Address(RVA = "0x576AB60", Offset = "0x5769760", VA = "0x18576AB60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x00027060 File Offset: 0x00025260
		[Token(Token = "0x17000938")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wzww
		{
			[Token(Token = "0x6001C7D")]
			[Address(RVA = "0x576AB00", Offset = "0x5769700", VA = "0x18576AB00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00027078 File Offset: 0x00025278
		[Token(Token = "0x17000939")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwxx
		{
			[Token(Token = "0x6001C7E")]
			[Address(RVA = "0x576A3E0", Offset = "0x5768FE0", VA = "0x18576A3E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x00027090 File Offset: 0x00025290
		[Token(Token = "0x1700093A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwxy
		{
			[Token(Token = "0x6001C7F")]
			[Address(RVA = "0x576A400", Offset = "0x5769000", VA = "0x18576A400")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x000270A8 File Offset: 0x000252A8
		[Token(Token = "0x1700093B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwxz
		{
			[Token(Token = "0x6001C80")]
			[Address(RVA = "0x576A420", Offset = "0x5769020", VA = "0x18576A420")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x000270C0 File Offset: 0x000252C0
		[Token(Token = "0x1700093C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwxw
		{
			[Token(Token = "0x6001C81")]
			[Address(RVA = "0x576A3C0", Offset = "0x5768FC0", VA = "0x18576A3C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x000270D8 File Offset: 0x000252D8
		[Token(Token = "0x1700093D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwyx
		{
			[Token(Token = "0x6001C82")]
			[Address(RVA = "0x576A480", Offset = "0x5769080", VA = "0x18576A480")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x000270F0 File Offset: 0x000252F0
		[Token(Token = "0x1700093E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwyy
		{
			[Token(Token = "0x6001C83")]
			[Address(RVA = "0x576A4A0", Offset = "0x57690A0", VA = "0x18576A4A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00027108 File Offset: 0x00025308
		[Token(Token = "0x1700093F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwyz
		{
			[Token(Token = "0x6001C84")]
			[Address(RVA = "0x576A4C0", Offset = "0x57690C0", VA = "0x18576A4C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00027120 File Offset: 0x00025320
		[Token(Token = "0x17000940")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwyw
		{
			[Token(Token = "0x6001C85")]
			[Address(RVA = "0x576A460", Offset = "0x5769060", VA = "0x18576A460")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00027138 File Offset: 0x00025338
		[Token(Token = "0x17000941")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwzx
		{
			[Token(Token = "0x6001C86")]
			[Address(RVA = "0x576A520", Offset = "0x5769120", VA = "0x18576A520")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00027150 File Offset: 0x00025350
		[Token(Token = "0x17000942")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwzy
		{
			[Token(Token = "0x6001C87")]
			[Address(RVA = "0x576A540", Offset = "0x5769140", VA = "0x18576A540")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00027168 File Offset: 0x00025368
		[Token(Token = "0x17000943")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwzz
		{
			[Token(Token = "0x6001C88")]
			[Address(RVA = "0x576A560", Offset = "0x5769160", VA = "0x18576A560")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00027180 File Offset: 0x00025380
		[Token(Token = "0x17000944")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwzw
		{
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x576A500", Offset = "0x5769100", VA = "0x18576A500")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00027198 File Offset: 0x00025398
		[Token(Token = "0x17000945")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwwx
		{
			[Token(Token = "0x6001C8A")]
			[Address(RVA = "0x576A340", Offset = "0x5768F40", VA = "0x18576A340")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x000271B0 File Offset: 0x000253B0
		[Token(Token = "0x17000946")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwwy
		{
			[Token(Token = "0x6001C8B")]
			[Address(RVA = "0x576A360", Offset = "0x5768F60", VA = "0x18576A360")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000271C8 File Offset: 0x000253C8
		[Token(Token = "0x17000947")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwwz
		{
			[Token(Token = "0x6001C8C")]
			[Address(RVA = "0x576A380", Offset = "0x5768F80", VA = "0x18576A380")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x000271E0 File Offset: 0x000253E0
		[Token(Token = "0x17000948")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 wwww
		{
			[Token(Token = "0x6001C8D")]
			[Address(RVA = "0x576A320", Offset = "0x5768F20", VA = "0x18576A320")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x000271F8 File Offset: 0x000253F8
		[Token(Token = "0x17000949")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxx
		{
			[Token(Token = "0x6001C8E")]
			[Address(RVA = "0x576B0B0", Offset = "0x5769CB0", VA = "0x18576B0B0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00027210 File Offset: 0x00025410
		[Token(Token = "0x1700094A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxy
		{
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0x576B140", Offset = "0x5769D40", VA = "0x18576B140")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00027228 File Offset: 0x00025428
		[Token(Token = "0x1700094B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxz
		{
			[Token(Token = "0x6001C90")]
			[Address(RVA = "0x576B1E0", Offset = "0x5769DE0", VA = "0x18576B1E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00027240 File Offset: 0x00025440
		[Token(Token = "0x1700094C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxw
		{
			[Token(Token = "0x6001C91")]
			[Address(RVA = "0x576B010", Offset = "0x5769C10", VA = "0x18576B010")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00027258 File Offset: 0x00025458
		[Token(Token = "0x1700094D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyx
		{
			[Token(Token = "0x6001C92")]
			[Address(RVA = "0x576B340", Offset = "0x5769F40", VA = "0x18576B340")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00027270 File Offset: 0x00025470
		[Token(Token = "0x1700094E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyy
		{
			[Token(Token = "0x6001C93")]
			[Address(RVA = "0x576B3E0", Offset = "0x5769FE0", VA = "0x18576B3E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00027288 File Offset: 0x00025488
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyz
		{
			[Token(Token = "0x6001C94")]
			[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001C95")]
			[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x000272A0 File Offset: 0x000254A0
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000950")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyw
		{
			[Token(Token = "0x6001C96")]
			[Address(RVA = "0x576B2A0", Offset = "0x5769EA0", VA = "0x18576B2A0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001C97")]
			[Address(RVA = "0x576D830", Offset = "0x576C430", VA = "0x18576D830")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x000272B8 File Offset: 0x000254B8
		[Token(Token = "0x17000951")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzx
		{
			[Token(Token = "0x6001C98")]
			[Address(RVA = "0x576B5E0", Offset = "0x576A1E0", VA = "0x18576B5E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x000272D0 File Offset: 0x000254D0
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000952")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzy
		{
			[Token(Token = "0x6001C99")]
			[Address(RVA = "0x576B680", Offset = "0x576A280", VA = "0x18576B680")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001C9A")]
			[Address(RVA = "0x576D8C0", Offset = "0x576C4C0", VA = "0x18576D8C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x000272E8 File Offset: 0x000254E8
		[Token(Token = "0x17000953")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzz
		{
			[Token(Token = "0x6001C9B")]
			[Address(RVA = "0x576B720", Offset = "0x576A320", VA = "0x18576B720")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x00027300 File Offset: 0x00025500
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000954")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzw
		{
			[Token(Token = "0x6001C9C")]
			[Address(RVA = "0x576B540", Offset = "0x576A140", VA = "0x18576B540")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001C9D")]
			[Address(RVA = "0x576D880", Offset = "0x576C480", VA = "0x18576D880")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00027318 File Offset: 0x00025518
		[Token(Token = "0x17000955")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xwx
		{
			[Token(Token = "0x6001C9E")]
			[Address(RVA = "0x576AE20", Offset = "0x5769A20", VA = "0x18576AE20")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x00027330 File Offset: 0x00025530
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000956")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xwy
		{
			[Token(Token = "0x6001C9F")]
			[Address(RVA = "0x576AEC0", Offset = "0x5769AC0", VA = "0x18576AEC0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CA0")]
			[Address(RVA = "0x576D7A0", Offset = "0x576C3A0", VA = "0x18576D7A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x00027348 File Offset: 0x00025548
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000957")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xwz
		{
			[Token(Token = "0x6001CA1")]
			[Address(RVA = "0x576AF60", Offset = "0x5769B60", VA = "0x18576AF60")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CA2")]
			[Address(RVA = "0x576D7E0", Offset = "0x576C3E0", VA = "0x18576D7E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00027360 File Offset: 0x00025560
		[Token(Token = "0x17000958")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xww
		{
			[Token(Token = "0x6001CA3")]
			[Address(RVA = "0x576AD80", Offset = "0x5769980", VA = "0x18576AD80")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x00027378 File Offset: 0x00025578
		[Token(Token = "0x17000959")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxx
		{
			[Token(Token = "0x6001CA4")]
			[Address(RVA = "0x576BB20", Offset = "0x576A720", VA = "0x18576BB20")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x00027390 File Offset: 0x00025590
		[Token(Token = "0x1700095A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxy
		{
			[Token(Token = "0x6001CA5")]
			[Address(RVA = "0x576BBC0", Offset = "0x576A7C0", VA = "0x18576BBC0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x000273A8 File Offset: 0x000255A8
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxz
		{
			[Token(Token = "0x6001CA6")]
			[Address(RVA = "0x576BC60", Offset = "0x576A860", VA = "0x18576BC60")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CA7")]
			[Address(RVA = "0x576D9E0", Offset = "0x576C5E0", VA = "0x18576D9E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x000273C0 File Offset: 0x000255C0
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxw
		{
			[Token(Token = "0x6001CA8")]
			[Address(RVA = "0x576BA80", Offset = "0x576A680", VA = "0x18576BA80")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CA9")]
			[Address(RVA = "0x576D9A0", Offset = "0x576C5A0", VA = "0x18576D9A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x000273D8 File Offset: 0x000255D8
		[Token(Token = "0x1700095D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyx
		{
			[Token(Token = "0x6001CAA")]
			[Address(RVA = "0x576BDC0", Offset = "0x576A9C0", VA = "0x18576BDC0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x000273F0 File Offset: 0x000255F0
		[Token(Token = "0x1700095E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyy
		{
			[Token(Token = "0x6001CAB")]
			[Address(RVA = "0x576BE60", Offset = "0x576AA60", VA = "0x18576BE60")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00027408 File Offset: 0x00025608
		[Token(Token = "0x1700095F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyz
		{
			[Token(Token = "0x6001CAC")]
			[Address(RVA = "0x576BEF0", Offset = "0x576AAF0", VA = "0x18576BEF0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00027420 File Offset: 0x00025620
		[Token(Token = "0x17000960")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyw
		{
			[Token(Token = "0x6001CAD")]
			[Address(RVA = "0x576BD20", Offset = "0x576A920", VA = "0x18576BD20")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00027438 File Offset: 0x00025638
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000961")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yzx
		{
			[Token(Token = "0x6001CAE")]
			[Address(RVA = "0x576C050", Offset = "0x576AC50", VA = "0x18576C050")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CAF")]
			[Address(RVA = "0x576DA70", Offset = "0x576C670", VA = "0x18576DA70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00027450 File Offset: 0x00025650
		[Token(Token = "0x17000962")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yzy
		{
			[Token(Token = "0x6001CB0")]
			[Address(RVA = "0x576C0F0", Offset = "0x576ACF0", VA = "0x18576C0F0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00027468 File Offset: 0x00025668
		[Token(Token = "0x17000963")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yzz
		{
			[Token(Token = "0x6001CB1")]
			[Address(RVA = "0x576C190", Offset = "0x576AD90", VA = "0x18576C190")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00027480 File Offset: 0x00025680
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000964")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yzw
		{
			[Token(Token = "0x6001CB2")]
			[Address(RVA = "0x576BFB0", Offset = "0x576ABB0", VA = "0x18576BFB0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CB3")]
			[Address(RVA = "0x576DA30", Offset = "0x576C630", VA = "0x18576DA30")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00027498 File Offset: 0x00025698
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000965")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 ywx
		{
			[Token(Token = "0x6001CB4")]
			[Address(RVA = "0x576B880", Offset = "0x576A480", VA = "0x18576B880")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CB5")]
			[Address(RVA = "0x576D910", Offset = "0x576C510", VA = "0x18576D910")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x000274B0 File Offset: 0x000256B0
		[Token(Token = "0x17000966")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 ywy
		{
			[Token(Token = "0x6001CB6")]
			[Address(RVA = "0x576B920", Offset = "0x576A520", VA = "0x18576B920")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x000274C8 File Offset: 0x000256C8
		// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000967")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 ywz
		{
			[Token(Token = "0x6001CB7")]
			[Address(RVA = "0x576B9C0", Offset = "0x576A5C0", VA = "0x18576B9C0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CB8")]
			[Address(RVA = "0x576D950", Offset = "0x576C550", VA = "0x18576D950")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x000274E0 File Offset: 0x000256E0
		[Token(Token = "0x17000968")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yww
		{
			[Token(Token = "0x6001CB9")]
			[Address(RVA = "0x576B7E0", Offset = "0x576A3E0", VA = "0x18576B7E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x000274F8 File Offset: 0x000256F8
		[Token(Token = "0x17000969")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zxx
		{
			[Token(Token = "0x6001CBA")]
			[Address(RVA = "0x576C570", Offset = "0x576B170", VA = "0x18576C570")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00027510 File Offset: 0x00025710
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zxy
		{
			[Token(Token = "0x6001CBB")]
			[Address(RVA = "0x576C610", Offset = "0x576B210", VA = "0x18576C610")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CBC")]
			[Address(RVA = "0x576DB90", Offset = "0x576C790", VA = "0x18576DB90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00027528 File Offset: 0x00025728
		[Token(Token = "0x1700096B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zxz
		{
			[Token(Token = "0x6001CBD")]
			[Address(RVA = "0x576C6B0", Offset = "0x576B2B0", VA = "0x18576C6B0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00027540 File Offset: 0x00025740
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zxw
		{
			[Token(Token = "0x6001CBE")]
			[Address(RVA = "0x576C4D0", Offset = "0x576B0D0", VA = "0x18576C4D0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CBF")]
			[Address(RVA = "0x576DB50", Offset = "0x576C750", VA = "0x18576DB50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x00027558 File Offset: 0x00025758
		// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zyx
		{
			[Token(Token = "0x6001CC0")]
			[Address(RVA = "0x576C810", Offset = "0x576B410", VA = "0x18576C810")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CC1")]
			[Address(RVA = "0x576DC20", Offset = "0x576C820", VA = "0x18576DC20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x00027570 File Offset: 0x00025770
		[Token(Token = "0x1700096E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zyy
		{
			[Token(Token = "0x6001CC2")]
			[Address(RVA = "0x576C8B0", Offset = "0x576B4B0", VA = "0x18576C8B0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00027588 File Offset: 0x00025788
		[Token(Token = "0x1700096F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zyz
		{
			[Token(Token = "0x6001CC3")]
			[Address(RVA = "0x576C950", Offset = "0x576B550", VA = "0x18576C950")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x000275A0 File Offset: 0x000257A0
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000970")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zyw
		{
			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0x576C770", Offset = "0x576B370", VA = "0x18576C770")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x576DBE0", Offset = "0x576C7E0", VA = "0x18576DBE0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x000275B8 File Offset: 0x000257B8
		[Token(Token = "0x17000971")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zzx
		{
			[Token(Token = "0x6001CC6")]
			[Address(RVA = "0x576CAB0", Offset = "0x576B6B0", VA = "0x18576CAB0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x000275D0 File Offset: 0x000257D0
		[Token(Token = "0x17000972")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zzy
		{
			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0x576CB50", Offset = "0x576B750", VA = "0x18576CB50")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000275E8 File Offset: 0x000257E8
		[Token(Token = "0x17000973")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zzz
		{
			[Token(Token = "0x6001CC8")]
			[Address(RVA = "0x576CBF0", Offset = "0x576B7F0", VA = "0x18576CBF0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00027600 File Offset: 0x00025800
		[Token(Token = "0x17000974")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zzw
		{
			[Token(Token = "0x6001CC9")]
			[Address(RVA = "0x576CA10", Offset = "0x576B610", VA = "0x18576CA10")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00027618 File Offset: 0x00025818
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000975")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zwx
		{
			[Token(Token = "0x6001CCA")]
			[Address(RVA = "0x576C2D0", Offset = "0x576AED0", VA = "0x18576C2D0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CCB")]
			[Address(RVA = "0x576DAC0", Offset = "0x576C6C0", VA = "0x18576DAC0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x00027630 File Offset: 0x00025830
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000976")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zwy
		{
			[Token(Token = "0x6001CCC")]
			[Address(RVA = "0x576C370", Offset = "0x576AF70", VA = "0x18576C370")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CCD")]
			[Address(RVA = "0x576DB00", Offset = "0x576C700", VA = "0x18576DB00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00027648 File Offset: 0x00025848
		[Token(Token = "0x17000977")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zwz
		{
			[Token(Token = "0x6001CCE")]
			[Address(RVA = "0x576C410", Offset = "0x576B010", VA = "0x18576C410")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00027660 File Offset: 0x00025860
		[Token(Token = "0x17000978")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zww
		{
			[Token(Token = "0x6001CCF")]
			[Address(RVA = "0x576C230", Offset = "0x576AE30", VA = "0x18576C230")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00027678 File Offset: 0x00025878
		[Token(Token = "0x17000979")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wxx
		{
			[Token(Token = "0x6001CD0")]
			[Address(RVA = "0x576A640", Offset = "0x5769240", VA = "0x18576A640")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00027690 File Offset: 0x00025890
		// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wxy
		{
			[Token(Token = "0x6001CD1")]
			[Address(RVA = "0x576A6E0", Offset = "0x57692E0", VA = "0x18576A6E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CD2")]
			[Address(RVA = "0x576D5F0", Offset = "0x576C1F0", VA = "0x18576D5F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x000276A8 File Offset: 0x000258A8
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wxz
		{
			[Token(Token = "0x6001CD3")]
			[Address(RVA = "0x576A780", Offset = "0x5769380", VA = "0x18576A780")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CD4")]
			[Address(RVA = "0x576D630", Offset = "0x576C230", VA = "0x18576D630")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x000276C0 File Offset: 0x000258C0
		[Token(Token = "0x1700097C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wxw
		{
			[Token(Token = "0x6001CD5")]
			[Address(RVA = "0x576A5A0", Offset = "0x57691A0", VA = "0x18576A5A0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000276D8 File Offset: 0x000258D8
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wyx
		{
			[Token(Token = "0x6001CD6")]
			[Address(RVA = "0x576A8E0", Offset = "0x57694E0", VA = "0x18576A8E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CD7")]
			[Address(RVA = "0x576D680", Offset = "0x576C280", VA = "0x18576D680")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000276F0 File Offset: 0x000258F0
		[Token(Token = "0x1700097E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wyy
		{
			[Token(Token = "0x6001CD8")]
			[Address(RVA = "0x576A980", Offset = "0x5769580", VA = "0x18576A980")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x00027708 File Offset: 0x00025908
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wyz
		{
			[Token(Token = "0x6001CD9")]
			[Address(RVA = "0x576AA20", Offset = "0x5769620", VA = "0x18576AA20")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CDA")]
			[Address(RVA = "0x576D6C0", Offset = "0x576C2C0", VA = "0x18576D6C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00027720 File Offset: 0x00025920
		[Token(Token = "0x17000980")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wyw
		{
			[Token(Token = "0x6001CDB")]
			[Address(RVA = "0x576A840", Offset = "0x5769440", VA = "0x18576A840")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00027738 File Offset: 0x00025938
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000981")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wzx
		{
			[Token(Token = "0x6001CDC")]
			[Address(RVA = "0x576AB80", Offset = "0x5769780", VA = "0x18576AB80")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CDD")]
			[Address(RVA = "0x576D710", Offset = "0x576C310", VA = "0x18576D710")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x00027750 File Offset: 0x00025950
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000982")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wzy
		{
			[Token(Token = "0x6001CDE")]
			[Address(RVA = "0x576AC20", Offset = "0x5769820", VA = "0x18576AC20")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001CDF")]
			[Address(RVA = "0x576D750", Offset = "0x576C350", VA = "0x18576D750")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00027768 File Offset: 0x00025968
		[Token(Token = "0x17000983")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wzz
		{
			[Token(Token = "0x6001CE0")]
			[Address(RVA = "0x576ACC0", Offset = "0x57698C0", VA = "0x18576ACC0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x00027780 File Offset: 0x00025980
		[Token(Token = "0x17000984")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wzw
		{
			[Token(Token = "0x6001CE1")]
			[Address(RVA = "0x576AAE0", Offset = "0x57696E0", VA = "0x18576AAE0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00027798 File Offset: 0x00025998
		[Token(Token = "0x17000985")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wwx
		{
			[Token(Token = "0x6001CE2")]
			[Address(RVA = "0x576A3A0", Offset = "0x5768FA0", VA = "0x18576A3A0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000277B0 File Offset: 0x000259B0
		[Token(Token = "0x17000986")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wwy
		{
			[Token(Token = "0x6001CE3")]
			[Address(RVA = "0x576A440", Offset = "0x5769040", VA = "0x18576A440")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x000277C8 File Offset: 0x000259C8
		[Token(Token = "0x17000987")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 wwz
		{
			[Token(Token = "0x6001CE4")]
			[Address(RVA = "0x576A4E0", Offset = "0x57690E0", VA = "0x18576A4E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x000277E0 File Offset: 0x000259E0
		[Token(Token = "0x17000988")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 www
		{
			[Token(Token = "0x6001CE5")]
			[Address(RVA = "0x576A310", Offset = "0x5768F10", VA = "0x18576A310")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x000277F8 File Offset: 0x000259F8
		[Token(Token = "0x17000989")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xx
		{
			[Token(Token = "0x6001CE6")]
			[Address(RVA = "0x576B000", Offset = "0x5769C00", VA = "0x18576B000")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x00027810 File Offset: 0x00025A10
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy
		{
			[Token(Token = "0x6001CE7")]
			[Address(RVA = "0x576B280", Offset = "0x5769E80", VA = "0x18576B280")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CE8")]
			[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x00027828 File Offset: 0x00025A28
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xz
		{
			[Token(Token = "0x6001CE9")]
			[Address(RVA = "0x576B520", Offset = "0x576A120", VA = "0x18576B520")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CEA")]
			[Address(RVA = "0x576D870", Offset = "0x576C470", VA = "0x18576D870")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x00027840 File Offset: 0x00025A40
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xw
		{
			[Token(Token = "0x6001CEB")]
			[Address(RVA = "0x576AD60", Offset = "0x5769960", VA = "0x18576AD60")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CEC")]
			[Address(RVA = "0x576D790", Offset = "0x576C390", VA = "0x18576D790")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x00027858 File Offset: 0x00025A58
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yx
		{
			[Token(Token = "0x6001CED")]
			[Address(RVA = "0x576BA60", Offset = "0x576A660", VA = "0x18576BA60")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CEE")]
			[Address(RVA = "0x576D990", Offset = "0x576C590", VA = "0x18576D990")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x00027870 File Offset: 0x00025A70
		[Token(Token = "0x1700098E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yy
		{
			[Token(Token = "0x6001CEF")]
			[Address(RVA = "0x576BD00", Offset = "0x576A900", VA = "0x18576BD00")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00027888 File Offset: 0x00025A88
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yz
		{
			[Token(Token = "0x6001CF0")]
			[Address(RVA = "0x576BF90", Offset = "0x576AB90", VA = "0x18576BF90")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CF1")]
			[Address(RVA = "0x576DA20", Offset = "0x576C620", VA = "0x18576DA20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x000278A0 File Offset: 0x00025AA0
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000990")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yw
		{
			[Token(Token = "0x6001CF2")]
			[Address(RVA = "0x576B7C0", Offset = "0x576A3C0", VA = "0x18576B7C0")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CF3")]
			[Address(RVA = "0x576D900", Offset = "0x576C500", VA = "0x18576D900")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x000278B8 File Offset: 0x00025AB8
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000991")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zx
		{
			[Token(Token = "0x6001CF4")]
			[Address(RVA = "0x576C4B0", Offset = "0x576B0B0", VA = "0x18576C4B0")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CF5")]
			[Address(RVA = "0x576DB40", Offset = "0x576C740", VA = "0x18576DB40")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000278D0 File Offset: 0x00025AD0
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000992")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zy
		{
			[Token(Token = "0x6001CF6")]
			[Address(RVA = "0x576C750", Offset = "0x576B350", VA = "0x18576C750")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CF7")]
			[Address(RVA = "0x576DBD0", Offset = "0x576C7D0", VA = "0x18576DBD0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x000278E8 File Offset: 0x00025AE8
		[Token(Token = "0x17000993")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zz
		{
			[Token(Token = "0x6001CF8")]
			[Address(RVA = "0x576C9F0", Offset = "0x576B5F0", VA = "0x18576C9F0")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x00027900 File Offset: 0x00025B00
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000994")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zw
		{
			[Token(Token = "0x6001CF9")]
			[Address(RVA = "0x569DF00", Offset = "0x569CB00", VA = "0x18569DF00")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CFA")]
			[Address(RVA = "0x576DAB0", Offset = "0x576C6B0", VA = "0x18576DAB0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x00027918 File Offset: 0x00025B18
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000995")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 wx
		{
			[Token(Token = "0x6001CFB")]
			[Address(RVA = "0x576A580", Offset = "0x5769180", VA = "0x18576A580")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CFC")]
			[Address(RVA = "0x576D5E0", Offset = "0x576C1E0", VA = "0x18576D5E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x00027930 File Offset: 0x00025B30
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000996")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 wy
		{
			[Token(Token = "0x6001CFD")]
			[Address(RVA = "0x576A820", Offset = "0x5769420", VA = "0x18576A820")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001CFE")]
			[Address(RVA = "0x576D670", Offset = "0x576C270", VA = "0x18576D670")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x00027948 File Offset: 0x00025B48
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000997")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 wz
		{
			[Token(Token = "0x6001CFF")]
			[Address(RVA = "0x576AAC0", Offset = "0x57696C0", VA = "0x18576AAC0")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001D00")]
			[Address(RVA = "0x576D700", Offset = "0x576C300", VA = "0x18576D700")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x00027960 File Offset: 0x00025B60
		[Token(Token = "0x17000998")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 ww
		{
			[Token(Token = "0x6001D01")]
			[Address(RVA = "0x576A2F0", Offset = "0x5768EF0", VA = "0x18576A2F0")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x17000999 RID: 2457
		[Token(Token = "0x17000999")]
		public int this[int index]
		{
			[Token(Token = "0x6001D02")]
			[Address(RVA = "0x3D284D0", Offset = "0x3D270D0", VA = "0x183D284D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D03")]
			[Address(RVA = "0x3D288C0", Offset = "0x3D274C0", VA = "0x183D288C0")]
			set
			{
			}
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00027990 File Offset: 0x00025B90
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x4CD5190", Offset = "0x4CD3D90", VA = "0x184CD5190", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000279A8 File Offset: 0x00025BA8
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x57E9660", Offset = "0x57E8260", VA = "0x1857E9660", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000279C0 File Offset: 0x00025BC0
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x5721BB0", Offset = "0x57207B0", VA = "0x185721BB0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x57E9720", Offset = "0x57E8320", VA = "0x1857E9720", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x57E9920", Offset = "0x57E8520", VA = "0x1857E9920", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x8")]
		public int z;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0xC")]
		public int w;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int4 zero;

		// Token: 0x02000047 RID: 71
		[Token(Token = "0x2000047")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06001D09 RID: 7433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D09")]
			[Address(RVA = "0x5764CD0", Offset = "0x57638D0", VA = "0x185764CD0")]
			public DebuggerProxy(int4 v)
			{
			}

			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			[FieldOffset(Offset = "0x10")]
			public int x;

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x14")]
			public int y;

			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x18")]
			public int z;

			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			[FieldOffset(Offset = "0x1C")]
			public int w;
		}
	}
}
