using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct int4x4 : IEquatable<int4x4>, IFormattable
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x5776110", Offset = "0x5774D10", VA = "0x185776110")]
		[MethodImpl(256)]
		public int4x4(int4 c0, int4 c1, int4 c2, int4 c3)
		{
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x5776140", Offset = "0x5774D40", VA = "0x185776140")]
		[MethodImpl(256)]
		public int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33)
		{
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x57760B0", Offset = "0x5774CB0", VA = "0x1857760B0")]
		[MethodImpl(256)]
		public int4x4(int v)
		{
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0x57F1720", Offset = "0x57F0320", VA = "0x1857F1720")]
		[MethodImpl(256)]
		public int4x4(bool v)
		{
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA4")]
		[Address(RVA = "0x56FFC90", Offset = "0x56FE890", VA = "0x1856FFC90")]
		[MethodImpl(256)]
		public int4x4(bool4x4 v)
		{
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA5")]
		[Address(RVA = "0x57760B0", Offset = "0x5774CB0", VA = "0x1857760B0")]
		[MethodImpl(256)]
		public int4x4(uint v)
		{
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0x56FFB90", Offset = "0x56FE790", VA = "0x1856FFB90")]
		[MethodImpl(256)]
		public int4x4(uint4x4 v)
		{
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0x57F1770", Offset = "0x57F0370", VA = "0x1857F1770")]
		[MethodImpl(256)]
		public int4x4(float v)
		{
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0x56FFE60", Offset = "0x56FEA60", VA = "0x1856FFE60")]
		[MethodImpl(256)]
		public int4x4(float4x4 v)
		{
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x57F16B0", Offset = "0x57F02B0", VA = "0x1857F16B0")]
		[MethodImpl(256)]
		public int4x4(double v)
		{
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAA")]
		[Address(RVA = "0x57F17E0", Offset = "0x57F03E0", VA = "0x1857F17E0")]
		[MethodImpl(256)]
		public int4x4(double4x4 v)
		{
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00028548 File Offset: 0x00026748
		[Token(Token = "0x6001DAB")]
		[Address(RVA = "0x572B040", Offset = "0x5729C40", VA = "0x18572B040")]
		[MethodImpl(256)]
		public static implicit operator int4x4(int v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00028560 File Offset: 0x00026760
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x572AEF0", Offset = "0x5729AF0", VA = "0x18572AEF0")]
		[MethodImpl(256)]
		public static explicit operator int4x4(bool v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00028578 File Offset: 0x00026778
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x572B110", Offset = "0x5729D10", VA = "0x18572B110")]
		[MethodImpl(256)]
		public static explicit operator int4x4(bool4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00028590 File Offset: 0x00026790
		[Token(Token = "0x6001DAE")]
		[Address(RVA = "0x572B040", Offset = "0x5729C40", VA = "0x18572B040")]
		[MethodImpl(256)]
		public static explicit operator int4x4(uint v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000285A8 File Offset: 0x000267A8
		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0x5777EE0", Offset = "0x5776AE0", VA = "0x185777EE0")]
		[MethodImpl(256)]
		public static explicit operator int4x4(uint4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000285C0 File Offset: 0x000267C0
		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x572B0A0", Offset = "0x5729CA0", VA = "0x18572B0A0")]
		[MethodImpl(256)]
		public static explicit operator int4x4(float v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000285D8 File Offset: 0x000267D8
		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0x57F1DC0", Offset = "0x57F09C0", VA = "0x1857F1DC0")]
		[MethodImpl(256)]
		public static explicit operator int4x4(float4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x000285F0 File Offset: 0x000267F0
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0x572B310", Offset = "0x5729F10", VA = "0x18572B310")]
		[MethodImpl(256)]
		public static explicit operator int4x4(double v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00028608 File Offset: 0x00026808
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0x572B220", Offset = "0x5729E20", VA = "0x18572B220")]
		[MethodImpl(256)]
		public static explicit operator int4x4(double4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00028620 File Offset: 0x00026820
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0x5779EC0", Offset = "0x5778AC0", VA = "0x185779EC0")]
		[MethodImpl(256)]
		public static int4x4 operator *(int4x4 lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00028638 File Offset: 0x00026838
		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0x5779D70", Offset = "0x5778970", VA = "0x185779D70")]
		[MethodImpl(256)]
		public static int4x4 operator *(int4x4 lhs, int rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00028650 File Offset: 0x00026850
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x577A0C0", Offset = "0x5778CC0", VA = "0x18577A0C0")]
		[MethodImpl(256)]
		public static int4x4 operator *(int lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00028668 File Offset: 0x00026868
		[Token(Token = "0x6001DB7")]
		[Address(RVA = "0x5776480", Offset = "0x5775080", VA = "0x185776480")]
		[MethodImpl(256)]
		public static int4x4 operator +(int4x4 lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00028680 File Offset: 0x00026880
		[Token(Token = "0x6001DB8")]
		[Address(RVA = "0x5776330", Offset = "0x5774F30", VA = "0x185776330")]
		[MethodImpl(256)]
		public static int4x4 operator +(int4x4 lhs, int rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00028698 File Offset: 0x00026898
		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0x57761F0", Offset = "0x5774DF0", VA = "0x1857761F0")]
		[MethodImpl(256)]
		public static int4x4 operator +(int lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x000286B0 File Offset: 0x000268B0
		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0x577A5C0", Offset = "0x57791C0", VA = "0x18577A5C0")]
		[MethodImpl(256)]
		public static int4x4 operator -(int4x4 lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x000286C8 File Offset: 0x000268C8
		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0x577A480", Offset = "0x5779080", VA = "0x18577A480")]
		[MethodImpl(256)]
		public static int4x4 operator -(int4x4 lhs, int rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x000286E0 File Offset: 0x000268E0
		[Token(Token = "0x6001DBC")]
		[Address(RVA = "0x577A7B0", Offset = "0x57793B0", VA = "0x18577A7B0")]
		[MethodImpl(256)]
		public static int4x4 operator -(int lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x000286F8 File Offset: 0x000268F8
		[Token(Token = "0x6001DBD")]
		[Address(RVA = "0x57F1BB0", Offset = "0x57F07B0", VA = "0x1857F1BB0")]
		[MethodImpl(256)]
		public static int4x4 operator /(int4x4 lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00028710 File Offset: 0x00026910
		[Token(Token = "0x6001DBE")]
		[Address(RVA = "0x57F1A50", Offset = "0x57F0650", VA = "0x1857F1A50")]
		[MethodImpl(256)]
		public static int4x4 operator /(int4x4 lhs, int rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00028728 File Offset: 0x00026928
		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x57F18D0", Offset = "0x57F04D0", VA = "0x1857F18D0")]
		[MethodImpl(256)]
		public static int4x4 operator /(int lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00028740 File Offset: 0x00026940
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x57F3180", Offset = "0x57F1D80", VA = "0x1857F3180")]
		[MethodImpl(256)]
		public static int4x4 operator %(int4x4 lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00028758 File Offset: 0x00026958
		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0x57F3020", Offset = "0x57F1C20", VA = "0x1857F3020")]
		[MethodImpl(256)]
		public static int4x4 operator %(int4x4 lhs, int rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00028770 File Offset: 0x00026970
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x57F3390", Offset = "0x57F1F90", VA = "0x1857F3390")]
		[MethodImpl(256)]
		public static int4x4 operator %(int lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00028788 File Offset: 0x00026988
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x5778840", Offset = "0x5777440", VA = "0x185778840")]
		[MethodImpl(256)]
		public static int4x4 operator ++(int4x4 val)
		{
			return default(int4x4);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000287A0 File Offset: 0x000269A0
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x5776F50", Offset = "0x5775B50", VA = "0x185776F50")]
		[MethodImpl(256)]
		public static int4x4 operator --(int4x4 val)
		{
			return default(int4x4);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000287B8 File Offset: 0x000269B8
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x57F2E20", Offset = "0x57F1A20", VA = "0x1857F2E20")]
		[MethodImpl(256)]
		public static bool4x4 operator <(int4x4 lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x000287D0 File Offset: 0x000269D0
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x57F2CE0", Offset = "0x57F18E0", VA = "0x1857F2CE0")]
		[MethodImpl(256)]
		public static bool4x4 operator <(int4x4 lhs, int rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x000287E8 File Offset: 0x000269E8
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x57F2BA0", Offset = "0x57F17A0", VA = "0x1857F2BA0")]
		[MethodImpl(256)]
		public static bool4x4 operator <(int lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00028800 File Offset: 0x00026A00
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x57F2860", Offset = "0x57F1460", VA = "0x1857F2860")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(int4x4 lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00028818 File Offset: 0x00026A18
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0x57F2720", Offset = "0x57F1320", VA = "0x1857F2720")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(int4x4 lhs, int rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00028830 File Offset: 0x00026A30
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x57F2A60", Offset = "0x57F1660", VA = "0x1857F2A60")]
		[MethodImpl(256)]
		public static bool4x4 operator <=(int lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00028848 File Offset: 0x00026A48
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0x57F22A0", Offset = "0x57F0EA0", VA = "0x1857F22A0")]
		[MethodImpl(256)]
		public static bool4x4 operator >(int4x4 lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00028860 File Offset: 0x00026A60
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0x57F24A0", Offset = "0x57F10A0", VA = "0x1857F24A0")]
		[MethodImpl(256)]
		public static bool4x4 operator >(int4x4 lhs, int rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00028878 File Offset: 0x00026A78
		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0x57F25E0", Offset = "0x57F11E0", VA = "0x1857F25E0")]
		[MethodImpl(256)]
		public static bool4x4 operator >(int lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00028890 File Offset: 0x00026A90
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0x57F1F60", Offset = "0x57F0B60", VA = "0x1857F1F60")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(int4x4 lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000288A8 File Offset: 0x00026AA8
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x57F1E20", Offset = "0x57F0A20", VA = "0x1857F1E20")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(int4x4 lhs, int rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x000288C0 File Offset: 0x00026AC0
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x57F2160", Offset = "0x57F0D60", VA = "0x1857F2160")]
		[MethodImpl(256)]
		public static bool4x4 operator >=(int lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x000288D8 File Offset: 0x00026AD8
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x577A920", Offset = "0x5779520", VA = "0x18577A920")]
		[MethodImpl(256)]
		public static int4x4 operator -(int4x4 val)
		{
			return default(int4x4);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000288F0 File Offset: 0x00026AF0
		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0x577AA50", Offset = "0x5779650", VA = "0x18577AA50")]
		[MethodImpl(256)]
		public static int4x4 operator +(int4x4 val)
		{
			return default(int4x4);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00028908 File Offset: 0x00026B08
		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0x5778E10", Offset = "0x5777A10", VA = "0x185778E10")]
		[MethodImpl(256)]
		public static int4x4 operator <<(int4x4 x, int n)
		{
			return default(int4x4);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00028920 File Offset: 0x00026B20
		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0x57F3510", Offset = "0x57F2110", VA = "0x1857F3510")]
		[MethodImpl(256)]
		public static int4x4 operator >>(int4x4 x, int n)
		{
			return default(int4x4);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00028938 File Offset: 0x00026B38
		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0x57775C0", Offset = "0x57761C0", VA = "0x1857775C0")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(int4x4 lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00028950 File Offset: 0x00026B50
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x5777900", Offset = "0x5776500", VA = "0x185777900")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(int4x4 lhs, int rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00028968 File Offset: 0x00026B68
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0x57777C0", Offset = "0x57763C0", VA = "0x1857777C0")]
		[MethodImpl(256)]
		public static bool4x4 operator ==(int lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00028980 File Offset: 0x00026B80
		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0x5778C10", Offset = "0x5777810", VA = "0x185778C10")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(int4x4 lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00028998 File Offset: 0x00026B98
		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0x5778AD0", Offset = "0x57776D0", VA = "0x185778AD0")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(int4x4 lhs, int rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x000289B0 File Offset: 0x00026BB0
		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0x5778990", Offset = "0x5777590", VA = "0x185778990")]
		[MethodImpl(256)]
		public static bool4x4 operator !=(int lhs, int4x4 rhs)
		{
			return default(bool4x4);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000289C8 File Offset: 0x00026BC8
		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0x577A210", Offset = "0x5778E10", VA = "0x18577A210")]
		[MethodImpl(256)]
		public static int4x4 operator ~(int4x4 val)
		{
			return default(int4x4);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x000289E0 File Offset: 0x00026BE0
		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0x5776670", Offset = "0x5775270", VA = "0x185776670")]
		[MethodImpl(256)]
		public static int4x4 operator &(int4x4 lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000289F8 File Offset: 0x00026BF8
		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x57769A0", Offset = "0x57755A0", VA = "0x1857769A0")]
		[MethodImpl(256)]
		public static int4x4 operator &(int4x4 lhs, int rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00028A10 File Offset: 0x00026C10
		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0x5776860", Offset = "0x5775460", VA = "0x185776860")]
		[MethodImpl(256)]
		public static int4x4 operator &(int lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00028A28 File Offset: 0x00026C28
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0x5776AE0", Offset = "0x57756E0", VA = "0x185776AE0")]
		[MethodImpl(256)]
		public static int4x4 operator |(int4x4 lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00028A40 File Offset: 0x00026C40
		[Token(Token = "0x6001DE0")]
		[Address(RVA = "0x5776CD0", Offset = "0x57758D0", VA = "0x185776CD0")]
		[MethodImpl(256)]
		public static int4x4 operator |(int4x4 lhs, int rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00028A58 File Offset: 0x00026C58
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0x5776E10", Offset = "0x5775A10", VA = "0x185776E10")]
		[MethodImpl(256)]
		public static int4x4 operator |(int lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00028A70 File Offset: 0x00026C70
		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0x5777CC0", Offset = "0x57768C0", VA = "0x185777CC0")]
		[MethodImpl(256)]
		public static int4x4 operator ^(int4x4 lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00028A88 File Offset: 0x00026C88
		[Token(Token = "0x6001DE3")]
		[Address(RVA = "0x5777A40", Offset = "0x5776640", VA = "0x185777A40")]
		[MethodImpl(256)]
		public static int4x4 operator ^(int4x4 lhs, int rhs)
		{
			return default(int4x4);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00028AA0 File Offset: 0x00026CA0
		[Token(Token = "0x6001DE4")]
		[Address(RVA = "0x5777B80", Offset = "0x5776780", VA = "0x185777B80")]
		[MethodImpl(256)]
		public static int4x4 operator ^(int lhs, int4x4 rhs)
		{
			return default(int4x4);
		}

		// Token: 0x1700099C RID: 2460
		[Token(Token = "0x1700099C")]
		public int4 this[int index]
		{
			[Token(Token = "0x6001DE5")]
			[Address(RVA = "0x3D28160", Offset = "0x3D26D60", VA = "0x183D28160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00028AB8 File Offset: 0x00026CB8
		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0x5763EE0", Offset = "0x5762AE0", VA = "0x185763EE0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int4x4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00028AD0 File Offset: 0x00026CD0
		[Token(Token = "0x6001DE7")]
		[Address(RVA = "0x57F0860", Offset = "0x57EF460", VA = "0x1857F0860", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00028AE8 File Offset: 0x00026CE8
		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x57F0910", Offset = "0x57EF510", VA = "0x1857F0910", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x57F0FB0", Offset = "0x57EFBB0", VA = "0x1857F0FB0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x57F0950", Offset = "0x57EF550", VA = "0x1857F0950", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x0")]
		public int4 c0;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x10")]
		public int4 c1;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x20")]
		public int4 c2;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x30")]
		public int4 c3;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int4x4 identity;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int4x4 zero;
	}
}
