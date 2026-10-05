using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[Serializable]
	public struct TSVector2 : IEquatable<TSVector2>
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600036B RID: 875 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x17000044")]
		public static TSVector2 zero
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x550E400", Offset = "0x550D000", VA = "0x18550E400")]
			get
			{
				return default(TSVector2);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x17000045")]
		public static TSVector2 one
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x550E2E0", Offset = "0x550CEE0", VA = "0x18550E2E0")]
			get
			{
				return default(TSVector2);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x17000046")]
		public static TSVector2 right
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x550E340", Offset = "0x550CF40", VA = "0x18550E340")]
			get
			{
				return default(TSVector2);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x17000047")]
		public static TSVector2 left
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x550E170", Offset = "0x550CD70", VA = "0x18550E170")]
			get
			{
				return default(TSVector2);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x17000048")]
		public static TSVector2 up
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x550E3A0", Offset = "0x550CFA0", VA = "0x18550E3A0")]
			get
			{
				return default(TSVector2);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x17000049")]
		public static TSVector2 down
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x550E110", Offset = "0x550CD10", VA = "0x18550E110")]
			get
			{
				return default(TSVector2);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1787730", Offset = "0x1786330", VA = "0x181787730")]
		public TSVector2(FP x, FP y)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x550E100", Offset = "0x550CD00", VA = "0x18550E100")]
		public TSVector2(FP value)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1787730", Offset = "0x1786330", VA = "0x181787730")]
		public void Set(FP x, FP y)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x550B8E0", Offset = "0x550A4E0", VA = "0x18550B8E0")]
		public Vector2 AsVector2()
		{
			return default(Vector2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x550E6C0", Offset = "0x550D2C0", VA = "0x18550E6C0")]
		public static implicit operator TSVector2(Vector2 value)
		{
			return default(TSVector2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x550D910", Offset = "0x550C510", VA = "0x18550D910")]
		public static void Reflect(ref TSVector2 vector, ref TSVector2 normal, out TSVector2 result)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x550D740", Offset = "0x550C340", VA = "0x18550D740")]
		public static TSVector2 Reflect(TSVector2 vector, TSVector2 normal)
		{
			return default(TSVector2);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x550B5E0", Offset = "0x550A1E0", VA = "0x18550B5E0")]
		public static TSVector2 Add(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x550B670", Offset = "0x550A270", VA = "0x18550B670")]
		public static void Add(ref TSVector2 value1, ref TSVector2 value2, out TSVector2 result)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x550BA40", Offset = "0x550A640", VA = "0x18550BA40")]
		public static TSVector2 Barycentric(TSVector2 value1, TSVector2 value2, TSVector2 value3, FP amount1, FP amount2)
		{
			return default(TSVector2);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x550B950", Offset = "0x550A550", VA = "0x18550B950")]
		public static void Barycentric(ref TSVector2 value1, ref TSVector2 value2, ref TSVector2 value3, FP amount1, FP amount2, out TSVector2 result)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x550BC10", Offset = "0x550A810", VA = "0x18550BC10")]
		public static TSVector2 CatmullRom(TSVector2 value1, TSVector2 value2, TSVector2 value3, TSVector2 value4, FP amount)
		{
			return default(TSVector2);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x550BB10", Offset = "0x550A710", VA = "0x18550BB10")]
		public static void CatmullRom(ref TSVector2 value1, ref TSVector2 value2, ref TSVector2 value3, ref TSVector2 value4, FP amount, out TSVector2 result)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x550BF80", Offset = "0x550AB80", VA = "0x18550BF80")]
		public static TSVector2 Clamp(TSVector2 value1, TSVector2 min, TSVector2 max)
		{
			return default(TSVector2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x550BEC0", Offset = "0x550AAC0", VA = "0x18550BEC0")]
		public static void Clamp(ref TSVector2 value1, ref TSVector2 min, ref TSVector2 max, out TSVector2 result)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x550C190", Offset = "0x550AD90", VA = "0x18550C190")]
		public static FP Distance(TSVector2 value1, TSVector2 value2)
		{
			return default(FP);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x550C230", Offset = "0x550AE30", VA = "0x18550C230")]
		public static void Distance(ref TSVector2 value1, ref TSVector2 value2, out FP result)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00004B2C File Offset: 0x00002D2C
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x550C120", Offset = "0x550AD20", VA = "0x18550C120")]
		public static FP DistanceSquared(TSVector2 value1, TSVector2 value2)
		{
			return default(FP);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x550C030", Offset = "0x550AC30", VA = "0x18550C030")]
		public static void DistanceSquared(ref TSVector2 value1, ref TSVector2 value2, out FP result)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x550C4C0", Offset = "0x550B0C0", VA = "0x18550C4C0")]
		public static TSVector2 Divide(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x550C2D0", Offset = "0x550AED0", VA = "0x18550C2D0")]
		public static void Divide(ref TSVector2 value1, ref TSVector2 value2, out TSVector2 result)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x550C410", Offset = "0x550B010", VA = "0x18550C410")]
		public static TSVector2 Divide(TSVector2 value1, FP divider)
		{
			return default(TSVector2);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x550C370", Offset = "0x550AF70", VA = "0x18550C370")]
		public static void Divide(ref TSVector2 value1, FP divider, out TSVector2 result)
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00004B74 File Offset: 0x00002D74
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x550C600", Offset = "0x550B200", VA = "0x18550C600")]
		public static FP Dot(TSVector2 value1, TSVector2 value2)
		{
			return default(FP);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x550C550", Offset = "0x550B150", VA = "0x18550C550")]
		public static void Dot(ref TSVector2 value1, ref TSVector2 value2, out FP result)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x550C770", Offset = "0x550B370", VA = "0x18550C770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x550C690", Offset = "0x550B290", VA = "0x18550C690", Slot = "4")]
		public bool Equals(TSVector2 other)
		{
			return default(bool);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x550C890", Offset = "0x550B490", VA = "0x18550C890", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x550C9F0", Offset = "0x550B5F0", VA = "0x18550C9F0")]
		public static TSVector2 Hermite(TSVector2 value1, TSVector2 tangent1, TSVector2 value2, TSVector2 tangent2, FP amount)
		{
			return default(TSVector2);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x550C900", Offset = "0x550B500", VA = "0x18550C900")]
		public static void Hermite(ref TSVector2 value1, ref TSVector2 tangent1, ref TSVector2 value2, ref TSVector2 tangent2, FP amount, out TSVector2 result)
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x1700004A")]
		public FP magnitude
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x550E1D0", Offset = "0x550CDD0", VA = "0x18550E1D0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x550BCF0", Offset = "0x550A8F0", VA = "0x18550BCF0")]
		public static TSVector2 ClampMagnitude(TSVector2 vector, FP maxLength)
		{
			return default(TSVector2);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x550CAF0", Offset = "0x550B6F0", VA = "0x18550CAF0")]
		public FP LengthSquared()
		{
			return default(FP);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x550CCC0", Offset = "0x550B8C0", VA = "0x18550CCC0")]
		public static TSVector2 Lerp(TSVector2 value1, TSVector2 value2, FP amount)
		{
			return default(TSVector2);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x550CB60", Offset = "0x550B760", VA = "0x18550CB60")]
		public static TSVector2 LerpUnclamped(TSVector2 value1, TSVector2 value2, FP amount)
		{
			return default(TSVector2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x550CC10", Offset = "0x550B810", VA = "0x18550CC10")]
		public static void LerpUnclamped(ref TSVector2 value1, ref TSVector2 value2, FP amount, out TSVector2 result)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x550CED0", Offset = "0x550BAD0", VA = "0x18550CED0")]
		public static TSVector2 Max(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x550CDB0", Offset = "0x550B9B0", VA = "0x18550CDB0")]
		public static void Max(ref TSVector2 value1, ref TSVector2 value2, out TSVector2 result)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x550D110", Offset = "0x550BD10", VA = "0x18550D110")]
		public static TSVector2 Min(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x550CFF0", Offset = "0x550BBF0", VA = "0x18550CFF0")]
		public static void Min(ref TSVector2 value1, ref TSVector2 value2, out TSVector2 result)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x550DAA0", Offset = "0x550C6A0", VA = "0x18550DAA0")]
		public void Scale(TSVector2 other)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x550DB20", Offset = "0x550C720", VA = "0x18550DB20")]
		public static TSVector2 Scale(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x550D2C0", Offset = "0x550BEC0", VA = "0x18550D2C0")]
		public static TSVector2 Multiply(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x550D3F0", Offset = "0x550BFF0", VA = "0x18550D3F0")]
		public static TSVector2 Multiply(TSVector2 value1, FP scaleFactor)
		{
			return default(TSVector2);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x550D230", Offset = "0x550BE30", VA = "0x18550D230")]
		public static void Multiply(ref TSVector2 value1, FP scaleFactor, out TSVector2 result)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x550D350", Offset = "0x550BF50", VA = "0x18550D350")]
		public static void Multiply(ref TSVector2 value1, ref TSVector2 value2, out TSVector2 result)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00004CDC File Offset: 0x00002EDC
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x550D500", Offset = "0x550C100", VA = "0x18550D500")]
		public static TSVector2 Negate(TSVector2 value)
		{
			return default(TSVector2);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x550D480", Offset = "0x550C080", VA = "0x18550D480")]
		public static void Negate(ref TSVector2 value, out TSVector2 result)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x550D6F0", Offset = "0x550C2F0", VA = "0x18550D6F0")]
		public void Normalize()
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x550D680", Offset = "0x550C280", VA = "0x18550D680")]
		public static TSVector2 Normalize(TSVector2 value)
		{
			return default(TSVector2);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x1700004B")]
		public TSVector2 normalized
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x550E270", Offset = "0x550CE70", VA = "0x18550E270")]
			get
			{
				return default(TSVector2);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x550D580", Offset = "0x550C180", VA = "0x18550D580")]
		public static void Normalize(ref TSVector2 value, out TSVector2 result)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x550DC60", Offset = "0x550C860", VA = "0x18550DC60")]
		public static TSVector2 SmoothStep(TSVector2 value1, TSVector2 value2, FP amount)
		{
			return default(TSVector2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x550DBB0", Offset = "0x550C7B0", VA = "0x18550DBB0")]
		public static void SmoothStep(ref TSVector2 value1, ref TSVector2 value2, FP amount, out TSVector2 result)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x550DDB0", Offset = "0x550C9B0", VA = "0x18550DDB0")]
		public static TSVector2 Subtract(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x550DD10", Offset = "0x550C910", VA = "0x18550DD10")]
		public static void Subtract(ref TSVector2 value1, ref TSVector2 value2, out TSVector2 result)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x550B710", Offset = "0x550A310", VA = "0x18550B710")]
		public static FP Angle(TSVector2 a, TSVector2 b)
		{
			return default(FP);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x550DF00", Offset = "0x550CB00", VA = "0x18550DF00")]
		public TSVector3 ToTSVector()
		{
			return default(TSVector3);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x550DE40", Offset = "0x550CA40", VA = "0x18550DE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x550EA60", Offset = "0x550D660", VA = "0x18550EA60")]
		public static TSVector2 operator -(TSVector2 value)
		{
			return default(TSVector2);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x550E630", Offset = "0x550D230", VA = "0x18550E630")]
		public static bool operator ==(TSVector2 value1, TSVector2 value2)
		{
			return default(bool);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x550E740", Offset = "0x550D340", VA = "0x18550E740")]
		public static bool operator !=(TSVector2 value1, TSVector2 value2)
		{
			return default(bool);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00004DCC File Offset: 0x00002FCC
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x550E460", Offset = "0x550D060", VA = "0x18550E460")]
		public static TSVector2 operator +(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x550E9D0", Offset = "0x550D5D0", VA = "0x18550E9D0")]
		public static TSVector2 operator -(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00004DFC File Offset: 0x00002FFC
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x550E8F0", Offset = "0x550D4F0", VA = "0x18550E8F0")]
		public static FP operator *(TSVector2 value1, TSVector2 value2)
		{
			return default(FP);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x550E860", Offset = "0x550D460", VA = "0x18550E860")]
		public static TSVector2 operator *(TSVector2 value, FP scaleFactor)
		{
			return default(TSVector2);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00004E2C File Offset: 0x0000302C
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x550E7D0", Offset = "0x550D3D0", VA = "0x18550E7D0")]
		public static TSVector2 operator *(FP scaleFactor, TSVector2 value)
		{
			return default(TSVector2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x550E4F0", Offset = "0x550D0F0", VA = "0x18550E4F0")]
		public static TSVector2 operator /(TSVector2 value1, TSVector2 value2)
		{
			return default(TSVector2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00004E5C File Offset: 0x0000305C
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x550E580", Offset = "0x550D180", VA = "0x18550E580")]
		public static TSVector2 operator /(TSVector2 value1, FP divider)
		{
			return default(TSVector2);
		}

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x0")]
		private static TSVector2 zeroVector;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x10")]
		private static TSVector2 oneVector;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x20")]
		private static TSVector2 rightVector;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x30")]
		private static TSVector2 leftVector;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x40")]
		private static TSVector2 upVector;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x50")]
		private static TSVector2 downVector;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x0")]
		public FP x;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x8")]
		public FP y;
	}
}
