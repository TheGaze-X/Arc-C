using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	[Serializable]
	public struct TSQuaternion
	{
		// Token: 0x06000326 RID: 806 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x4A09210", Offset = "0x4A07E10", VA = "0x184A09210")]
		public TSQuaternion(FP x, FP y, FP z, FP w)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x4A09210", Offset = "0x4A07E10", VA = "0x184A09210")]
		public void Set(FP new_x, FP new_y, FP new_z, FP new_w)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x5508D70", Offset = "0x5507970", VA = "0x185508D70")]
		public void SetFromToRotation(TSVector3 fromDirection, TSVector3 toDirection)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x17000040")]
		public TSVector3 eulerAngles
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x5509890", Offset = "0x5508490", VA = "0x185509890")]
			get
			{
				return default(TSVector3);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x55064D0", Offset = "0x55050D0", VA = "0x1855064D0")]
		public static FP Angle(TSQuaternion a, TSQuaternion b)
		{
			return default(FP);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x5506200", Offset = "0x5504E00", VA = "0x185506200")]
		public static TSQuaternion Add(TSQuaternion quaternion1, TSQuaternion quaternion2)
		{
			return default(TSQuaternion);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x5507DD0", Offset = "0x55069D0", VA = "0x185507DD0")]
		public static TSQuaternion LookRotation(TSVector3 forward)
		{
			return default(TSQuaternion);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x5507FB0", Offset = "0x5506BB0", VA = "0x185507FB0")]
		public static TSQuaternion LookRotation(TSVector3 forward, TSVector3 upwards)
		{
			return default(TSQuaternion);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x5508E60", Offset = "0x5507A60", VA = "0x185508E60")]
		public static TSQuaternion Slerp(TSQuaternion from, TSQuaternion to, FP t)
		{
			return default(TSQuaternion);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x5508760", Offset = "0x5507360", VA = "0x185508760")]
		public static TSQuaternion RotateTowards(TSQuaternion from, TSQuaternion to, FP maxDegreesDelta)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x5507090", Offset = "0x5505C90", VA = "0x185507090")]
		public static TSQuaternion Euler(FP x, FP y, FP z)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x55071B0", Offset = "0x5505DB0", VA = "0x1855071B0")]
		public static TSQuaternion Euler(TSVector3 eulerAngles)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x5506280", Offset = "0x5504E80", VA = "0x185506280")]
		public static TSQuaternion AngleAxis(FP angle, TSVector3 axis)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x5506CE0", Offset = "0x55058E0", VA = "0x185506CE0")]
		public static void CreateFromYawPitchRoll(FP yaw, FP pitch, FP roll, out TSQuaternion result)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x5506130", Offset = "0x5504D30", VA = "0x185506130")]
		public static void Add(ref TSQuaternion quaternion1, ref TSQuaternion quaternion2, out TSQuaternion result)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x5506690", Offset = "0x5505290", VA = "0x185506690")]
		public static TSQuaternion Conjugate(TSQuaternion value)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x5506F40", Offset = "0x5505B40", VA = "0x185506F40")]
		public static FP Dot(TSQuaternion a, TSQuaternion b)
		{
			return default(FP);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x5507690", Offset = "0x5506290", VA = "0x185507690")]
		public static TSQuaternion Inverse(TSQuaternion rotation)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x5507340", Offset = "0x5505F40", VA = "0x185507340")]
		public static TSQuaternion FromToRotation(TSVector3 fromVector, TSVector3 toVector)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000046AC File Offset: 0x000028AC
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x5507C90", Offset = "0x5506890", VA = "0x185507C90")]
		public static TSQuaternion Lerp(TSQuaternion a, TSQuaternion b, FP t)
		{
			return default(TSQuaternion);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x5507980", Offset = "0x5506580", VA = "0x185507980")]
		public static TSQuaternion LerpUnclamped(TSQuaternion a, TSQuaternion b, FP t)
		{
			return default(TSQuaternion);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x5509440", Offset = "0x5508040", VA = "0x185509440")]
		public static TSQuaternion Subtract(TSQuaternion quaternion1, TSQuaternion quaternion2)
		{
			return default(TSQuaternion);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x55094C0", Offset = "0x55080C0", VA = "0x1855094C0")]
		public static void Subtract(ref TSQuaternion quaternion1, ref TSQuaternion quaternion2, out TSQuaternion result)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x55085A0", Offset = "0x55071A0", VA = "0x1855085A0")]
		public static TSQuaternion Multiply(TSQuaternion quaternion1, TSQuaternion quaternion2)
		{
			return default(TSQuaternion);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x5508300", Offset = "0x5506F00", VA = "0x185508300")]
		public static void Multiply(ref TSQuaternion quaternion1, ref TSQuaternion quaternion2, out TSQuaternion result)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000470C File Offset: 0x0000290C
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x5508150", Offset = "0x5506D50", VA = "0x185508150")]
		public static TSQuaternion Multiply(TSQuaternion quaternion1, FP scaleFactor)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x5508240", Offset = "0x5506E40", VA = "0x185508240")]
		public static void Multiply(ref TSQuaternion quaternion1, FP scaleFactor, out TSQuaternion result)
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x5508620", Offset = "0x5507220", VA = "0x185508620")]
		public void Normalize()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00004724 File Offset: 0x00002924
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x5506C70", Offset = "0x5505870", VA = "0x185506C70")]
		public static TSQuaternion CreateFromMatrix(TSMatrix matrix)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x5506760", Offset = "0x5505360", VA = "0x185506760")]
		public static void CreateFromMatrix(ref TSMatrix matrix, out TSQuaternion result)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x550A290", Offset = "0x5508E90", VA = "0x18550A290")]
		public static TSQuaternion operator *(TSQuaternion value1, TSQuaternion value2)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x5509D10", Offset = "0x5508910", VA = "0x185509D10")]
		public static TSQuaternion operator +(TSQuaternion value1, TSQuaternion value2)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x550A310", Offset = "0x5508F10", VA = "0x18550A310")]
		public static TSQuaternion operator -(TSQuaternion value1, TSQuaternion value2)
		{
			return default(TSQuaternion);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x5509D90", Offset = "0x5508990", VA = "0x185509D90")]
		public static TSVector3 operator *(TSQuaternion quat, TSVector3 vec)
		{
			return default(TSVector3);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x5509590", Offset = "0x5508190", VA = "0x185509590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x0")]
		public FP x;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x8")]
		public FP y;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x10")]
		public FP z;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x18")]
		public FP w;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TSQuaternion identity;
	}
}
