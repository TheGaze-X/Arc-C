using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[Serializable]
	public struct TSVector3
	{
		// Token: 0x060003B8 RID: 952 RVA: 0x00004E74 File Offset: 0x00003074
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x550EAE0", Offset = "0x550D6E0", VA = "0x18550EAE0")]
		public static TSVector3 Abs(TSVector3 other)
		{
			return default(TSVector3);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00004E8C File Offset: 0x0000308C
		[Token(Token = "0x1700004C")]
		public FP sqrMagnitude
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x5511840", Offset = "0x5510440", VA = "0x185511840")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00004EA4 File Offset: 0x000030A4
		[Token(Token = "0x1700004D")]
		public FP magnitude
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x55116F0", Offset = "0x55102F0", VA = "0x1855116F0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x550EF10", Offset = "0x550DB10", VA = "0x18550EF10")]
		public static TSVector3 ClampMagnitude(TSVector3 vector, FP maxLength)
		{
			return default(TSVector3);
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00004ED4 File Offset: 0x000030D4
		[Token(Token = "0x1700004E")]
		public TSVector3 normalized
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x55117A0", Offset = "0x55103A0", VA = "0x1855117A0")]
			get
			{
				return default(TSVector3);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x5511650", Offset = "0x5510250", VA = "0x185511650")]
		public TSVector3(int x, int y, int z)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x4C2F060", Offset = "0x4C2DC60", VA = "0x184C2F060")]
		public TSVector3(FP x, FP y, FP z)
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x55108D0", Offset = "0x550F4D0", VA = "0x1855108D0")]
		public void Scale(TSVector3 other)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4C2F060", Offset = "0x4C2DC60", VA = "0x184C2F060")]
		public void Set(FP x, FP y, FP z)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x55116E0", Offset = "0x55102E0", VA = "0x1855116E0")]
		public TSVector3(FP xyz)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00004EEC File Offset: 0x000030EC
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x550FA80", Offset = "0x550E680", VA = "0x18550FA80")]
		public static TSVector3 Lerp(TSVector3 from, TSVector3 to, FP percent)
		{
			return default(TSVector3);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x5510C20", Offset = "0x550F820", VA = "0x185510C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00004F04 File Offset: 0x00003104
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x550F7A0", Offset = "0x550E3A0", VA = "0x18550F7A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00004F1C File Offset: 0x0000311C
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x55109A0", Offset = "0x550F5A0", VA = "0x1855109A0")]
		public static TSVector3 Scale(TSVector3 vecA, TSVector3 vecB)
		{
			return default(TSVector3);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00004F34 File Offset: 0x00003134
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x55119E0", Offset = "0x55105E0", VA = "0x1855119E0")]
		public static bool operator ==(TSVector3 value1, TSVector3 value2)
		{
			return default(bool);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00004F4C File Offset: 0x0000314C
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x5511B10", Offset = "0x5510710", VA = "0x185511B10")]
		public static bool operator !=(TSVector3 value1, TSVector3 value2)
		{
			return default(bool);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00004F64 File Offset: 0x00003164
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x5510100", Offset = "0x550ED00", VA = "0x185510100")]
		public static TSVector3 Min(TSVector3 value1, TSVector3 value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x550FFF0", Offset = "0x550EBF0", VA = "0x18550FFF0")]
		public static void Min(ref TSVector3 value1, ref TSVector3 value2, out TSVector3 result)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00004F7C File Offset: 0x0000317C
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x550FDB0", Offset = "0x550E9B0", VA = "0x18550FDB0")]
		public static TSVector3 Max(TSVector3 value1, TSVector3 value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00004F94 File Offset: 0x00003194
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x550F370", Offset = "0x550DF70", VA = "0x18550F370")]
		public static FP Distance(TSVector3 v1, TSVector3 v2)
		{
			return default(FP);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x550FEE0", Offset = "0x550EAE0", VA = "0x18550FEE0")]
		public static void Max(ref TSVector3 value1, ref TSVector3 value2, out TSVector3 result)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x550FD20", Offset = "0x550E920", VA = "0x18550FD20")]
		public void MakeZero()
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00004FAC File Offset: 0x000031AC
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x550F9F0", Offset = "0x550E5F0", VA = "0x18550F9F0")]
		public bool IsZero()
		{
			return default(bool);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00004FC4 File Offset: 0x000031C4
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x550F950", Offset = "0x550E550", VA = "0x18550F950")]
		public bool IsNearlyZero()
		{
			return default(bool);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00004FDC File Offset: 0x000031DC
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x5510EB0", Offset = "0x550FAB0", VA = "0x185510EB0")]
		public static TSVector3 Transform(TSVector3 position, TSMatrix matrix)
		{
			return default(TSVector3);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x5510D30", Offset = "0x550F930", VA = "0x185510D30")]
		public static void Transform(ref TSVector3 position, ref TSMatrix matrix, out TSVector3 result)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x5510F30", Offset = "0x550FB30", VA = "0x185510F30")]
		public static void TransposedTransform(ref TSVector3 position, ref TSMatrix matrix, out TSVector3 result)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00004FF4 File Offset: 0x000031F4
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x550F680", Offset = "0x550E280", VA = "0x18550F680")]
		public static FP Dot(TSVector3 vector1, TSVector3 vector2)
		{
			return default(FP);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000500C File Offset: 0x0000320C
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x550F6E0", Offset = "0x550E2E0", VA = "0x18550F6E0")]
		public static FP Dot(ref TSVector3 vector1, ref TSVector3 vector2)
		{
			return default(FP);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00005024 File Offset: 0x00003224
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x550EBB0", Offset = "0x550D7B0", VA = "0x18550EBB0")]
		public static TSVector3 Add(TSVector3 value1, TSVector3 value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x550EC30", Offset = "0x550D830", VA = "0x18550EC30")]
		public static void Add(ref TSVector3 value1, ref TSVector3 value2, out TSVector3 result)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000503C File Offset: 0x0000323C
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x550F560", Offset = "0x550E160", VA = "0x18550F560")]
		public static TSVector3 Divide(TSVector3 value1, FP scaleFactor)
		{
			return default(TSVector3);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x550F5E0", Offset = "0x550E1E0", VA = "0x18550F5E0")]
		public static void Divide(ref TSVector3 value1, FP scaleFactor, out TSVector3 result)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00005054 File Offset: 0x00003254
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x5510AB0", Offset = "0x550F6B0", VA = "0x185510AB0")]
		public static TSVector3 Subtract(TSVector3 value1, TSVector3 value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x5510B30", Offset = "0x550F730", VA = "0x185510B30")]
		public static void Subtract(ref TSVector3 value1, ref TSVector3 value2, out TSVector3 result)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000506C File Offset: 0x0000326C
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x550F1D0", Offset = "0x550DDD0", VA = "0x18550F1D0")]
		public static TSVector3 Cross(TSVector3 vector1, TSVector3 vector2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x550F250", Offset = "0x550DE50", VA = "0x18550F250")]
		public static void Cross(ref TSVector3 vector1, ref TSVector3 vector2, out TSVector3 result)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00005084 File Offset: 0x00003284
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x550F8D0", Offset = "0x550E4D0", VA = "0x18550F8D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x5510430", Offset = "0x550F030", VA = "0x185510430")]
		public void Negate()
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000509C File Offset: 0x0000329C
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x5510350", Offset = "0x550EF50", VA = "0x185510350")]
		public static TSVector3 Negate(TSVector3 value)
		{
			return default(TSVector3);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x55104B0", Offset = "0x550F0B0", VA = "0x1855104B0")]
		public static void Negate(ref TSVector3 value, out TSVector3 result)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x5510550", Offset = "0x550F150", VA = "0x185510550")]
		public static TSVector3 Normalize(TSVector3 value)
		{
			return default(TSVector3);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x55106C0", Offset = "0x550F2C0", VA = "0x1855106C0")]
		public void Normalize()
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x55107C0", Offset = "0x550F3C0", VA = "0x1855107C0")]
		public static void Normalize(ref TSVector3 value, out TSVector3 result)
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x5510BF0", Offset = "0x550F7F0", VA = "0x185510BF0")]
		public static void Swap(ref TSVector3 vector1, ref TSVector3 vector2)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000050CC File Offset: 0x000032CC
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x55102D0", Offset = "0x550EED0", VA = "0x1855102D0")]
		public static TSVector3 Multiply(TSVector3 value1, FP scaleFactor)
		{
			return default(TSVector3);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x5510230", Offset = "0x550EE30", VA = "0x185510230")]
		public static void Multiply(ref TSVector3 value1, FP scaleFactor, out TSVector3 result)
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000050E4 File Offset: 0x000032E4
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x5511C40", Offset = "0x5510840", VA = "0x185511C40")]
		public static TSVector3 operator %(TSVector3 value1, TSVector3 value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000050FC File Offset: 0x000032FC
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x5511CC0", Offset = "0x55108C0", VA = "0x185511CC0")]
		public static FP operator *(TSVector3 value1, TSVector3 value2)
		{
			return default(FP);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00005114 File Offset: 0x00003314
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x5511DA0", Offset = "0x55109A0", VA = "0x185511DA0")]
		public static TSVector3 operator *(TSVector3 value1, FP value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000512C File Offset: 0x0000332C
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x5511D20", Offset = "0x5510920", VA = "0x185511D20")]
		public static TSVector3 operator *(FP value1, TSVector3 value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00005144 File Offset: 0x00003344
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x5511E20", Offset = "0x5510A20", VA = "0x185511E20")]
		public static TSVector3 operator -(TSVector3 value1, TSVector3 value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000515C File Offset: 0x0000335C
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x55118E0", Offset = "0x55104E0", VA = "0x1855118E0")]
		public static TSVector3 operator +(TSVector3 value1, TSVector3 value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00005174 File Offset: 0x00003374
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x5511960", Offset = "0x5510560", VA = "0x185511960")]
		public static TSVector3 operator /(TSVector3 value1, FP value2)
		{
			return default(TSVector3);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000518C File Offset: 0x0000338C
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x550ECF0", Offset = "0x550D8F0", VA = "0x18550ECF0")]
		public static FP Angle(TSVector3 a, TSVector3 b)
		{
			return default(FP);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000051A4 File Offset: 0x000033A4
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x5510D10", Offset = "0x550F910", VA = "0x185510D10")]
		public TSVector2 ToTSVector2()
		{
			return default(TSVector2);
		}

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x0")]
		private static FP ZeroEpsilonSq;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x8")]
		internal static TSVector3 InternalZero;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x20")]
		internal static TSVector3 Arbitrary;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x0")]
		public FP x;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x8")]
		public FP y;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x10")]
		public FP z;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x38")]
		public static readonly TSVector3 zero;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x50")]
		public static readonly TSVector3 left;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x68")]
		public static readonly TSVector3 right;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x80")]
		public static readonly TSVector3 up;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x98")]
		public static readonly TSVector3 down;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly TSVector3 back;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly TSVector3 forward;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly TSVector3 one;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly TSVector3 MinValue;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x110")]
		public static readonly TSVector3 MaxValue;
	}
}
