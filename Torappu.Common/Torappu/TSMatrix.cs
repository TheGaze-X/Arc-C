using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public struct TSMatrix
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00004334 File Offset: 0x00002534
		[Token(Token = "0x1700003F")]
		public TSVector3 eulerAngles
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x5505460", Offset = "0x5504060", VA = "0x185505460")]
			get
			{
				return default(TSVector3);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x5502C20", Offset = "0x5501820", VA = "0x185502C20")]
		public static TSMatrix CreateFromYawPitchRoll(FP yaw, FP pitch, FP roll)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00004364 File Offset: 0x00002564
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x5502D00", Offset = "0x5501900", VA = "0x185502D00")]
		public static TSMatrix CreateRotationX(FP radians)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x5502DD0", Offset = "0x55019D0", VA = "0x185502DD0")]
		public static void CreateRotationX(FP radians, out TSMatrix result)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000437C File Offset: 0x0000257C
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x5502FD0", Offset = "0x5501BD0", VA = "0x185502FD0")]
		public static TSMatrix CreateRotationY(FP radians)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x5502ED0", Offset = "0x5501AD0", VA = "0x185502ED0")]
		public static void CreateRotationY(FP radians, out TSMatrix result)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00004394 File Offset: 0x00002594
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x55031B0", Offset = "0x5501DB0", VA = "0x1855031B0")]
		public static TSMatrix CreateRotationZ(FP radians)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x55030B0", Offset = "0x5501CB0", VA = "0x1855030B0")]
		public static void CreateRotationZ(FP radians, out TSMatrix result)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x5505410", Offset = "0x5504010", VA = "0x185505410")]
		public TSMatrix(FP m11, FP m12, FP m13, FP m21, FP m22, FP m23, FP m31, FP m32, FP m33)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x5504790", Offset = "0x5503390", VA = "0x185504790")]
		public static TSMatrix Multiply(TSMatrix matrix1, TSMatrix matrix2)
		{
			return default(TSMatrix);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x5504820", Offset = "0x5503420", VA = "0x185504820")]
		public static void Multiply(ref TSMatrix matrix1, ref TSMatrix matrix2, out TSMatrix result)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x5502200", Offset = "0x5500E00", VA = "0x185502200")]
		public static TSMatrix Add(TSMatrix matrix1, TSMatrix matrix2)
		{
			return default(TSMatrix);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x55020D0", Offset = "0x5500CD0", VA = "0x1855020D0")]
		public static void Add(ref TSMatrix matrix1, ref TSMatrix matrix2, out TSMatrix result)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x5503790", Offset = "0x5502390", VA = "0x185503790")]
		public static TSMatrix Inverse(TSMatrix matrix)
		{
			return default(TSMatrix);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000043F4 File Offset: 0x000025F4
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x5503290", Offset = "0x5501E90", VA = "0x185503290")]
		public FP Determinant()
		{
			return default(FP);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x5503FD0", Offset = "0x5502BD0", VA = "0x185503FD0")]
		public static void Invert(ref TSMatrix matrix, out TSMatrix result)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x5503810", Offset = "0x5502410", VA = "0x185503810")]
		public static void Inverse(ref TSMatrix matrix, out TSMatrix result)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000440C File Offset: 0x0000260C
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x5504700", Offset = "0x5503300", VA = "0x185504700")]
		public static TSMatrix Multiply(TSMatrix matrix1, FP scaleFactor)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x5504BF0", Offset = "0x55037F0", VA = "0x185504BF0")]
		public static void Multiply(ref TSMatrix matrix1, FP scaleFactor, out TSMatrix result)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00004424 File Offset: 0x00002624
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x5502690", Offset = "0x5501290", VA = "0x185502690")]
		public static TSMatrix CreateFromLookAt(TSVector3 position, TSVector3 target)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000443C File Offset: 0x0000263C
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x5504320", Offset = "0x5502F20", VA = "0x185504320")]
		public static TSMatrix LookAt(TSVector3 forward, TSVector3 upwards)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x55043D0", Offset = "0x5502FD0", VA = "0x1855043D0")]
		public static void LookAt(TSVector3 forward, TSVector3 upwards, out TSMatrix result)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x5502870", Offset = "0x5501470", VA = "0x185502870")]
		public static TSMatrix CreateFromQuaternion(TSQuaternion quaternion)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x55028F0", Offset = "0x55014F0", VA = "0x1855028F0")]
		public static void CreateFromQuaternion(ref TSQuaternion quaternion, out TSMatrix result)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000446C File Offset: 0x0000266C
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x55051C0", Offset = "0x5503DC0", VA = "0x1855051C0")]
		public static TSMatrix Transpose(TSMatrix matrix)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x5505270", Offset = "0x5503E70", VA = "0x185505270")]
		public static void Transpose(ref TSMatrix matrix, out TSMatrix result)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00004484 File Offset: 0x00002684
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x5505FC0", Offset = "0x5504BC0", VA = "0x185505FC0")]
		public static TSMatrix operator *(TSMatrix value1, TSMatrix value2)
		{
			return default(TSMatrix);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000449C File Offset: 0x0000269C
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x5505140", Offset = "0x5503D40", VA = "0x185505140")]
		public FP Trace()
		{
			return default(FP);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000044B4 File Offset: 0x000026B4
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x5505790", Offset = "0x5504390", VA = "0x185505790")]
		public static TSMatrix operator +(TSMatrix value1, TSMatrix value2)
		{
			return default(TSMatrix);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x5506050", Offset = "0x5504C50", VA = "0x185506050")]
		public static TSMatrix operator -(TSMatrix value1, TSMatrix value2)
		{
			return default(TSMatrix);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000044E4 File Offset: 0x000026E4
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x5505820", Offset = "0x5504420", VA = "0x185505820")]
		public static bool operator ==(TSMatrix value1, TSMatrix value2)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x5505BF0", Offset = "0x55047F0", VA = "0x185505BF0")]
		public static bool operator !=(TSMatrix value1, TSMatrix value2)
		{
			return default(bool);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x5503400", Offset = "0x5502000", VA = "0x185503400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x5503680", Offset = "0x5502280", VA = "0x185503680", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x5502320", Offset = "0x5500F20", VA = "0x185502320")]
		public static void CreateFromAxisAngle(ref TSVector3 axis, FP angle, out TSMatrix result)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x5502290", Offset = "0x5500E90", VA = "0x185502290")]
		public static TSMatrix AngleAxis(FP angle, TSVector3 axis)
		{
			return default(TSMatrix);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x5504D10", Offset = "0x5503910", VA = "0x185504D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x0")]
		public FP M11;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x8")]
		public FP M12;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x10")]
		public FP M13;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x18")]
		public FP M21;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x20")]
		public FP M22;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x28")]
		public FP M23;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x30")]
		public FP M31;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x38")]
		public FP M32;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x40")]
		public FP M33;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x0")]
		internal static TSMatrix InternalIdentity;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x48")]
		public static readonly TSMatrix Identity;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x90")]
		public static readonly TSMatrix Zero;
	}
}
