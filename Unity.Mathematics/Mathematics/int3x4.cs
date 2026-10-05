using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct int3x4 : IEquatable<int3x4>, IFormattable
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x57659C0", Offset = "0x57645C0", VA = "0x1857659C0")]
		[MethodImpl(256)]
		public int3x4(int3 c0, int3 c1, int3 c2, int3 c3)
		{
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x5765850", Offset = "0x5764450", VA = "0x185765850")]
		[MethodImpl(256)]
		public int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23)
		{
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x57657F0", Offset = "0x57643F0", VA = "0x1857657F0")]
		[MethodImpl(256)]
		public int3x4(int v)
		{
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x56FF6D0", Offset = "0x56FE2D0", VA = "0x1856FF6D0")]
		[MethodImpl(256)]
		public int3x4(bool v)
		{
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x56FF790", Offset = "0x56FE390", VA = "0x1856FF790")]
		[MethodImpl(256)]
		public int3x4(bool3x4 v)
		{
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x57657F0", Offset = "0x57643F0", VA = "0x1857657F0")]
		[MethodImpl(256)]
		public int3x4(uint v)
		{
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x57658E0", Offset = "0x57644E0", VA = "0x1857658E0")]
		[MethodImpl(256)]
		public int3x4(uint3x4 v)
		{
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x57E7B60", Offset = "0x57E6760", VA = "0x1857E7B60")]
		[MethodImpl(256)]
		public int3x4(float v)
		{
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x57E7A80", Offset = "0x57E6680", VA = "0x1857E7A80")]
		[MethodImpl(256)]
		public int3x4(float3x4 v)
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x57E7BC0", Offset = "0x57E67C0", VA = "0x1857E7BC0")]
		[MethodImpl(256)]
		public int3x4(double v)
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x57E7C20", Offset = "0x57E6820", VA = "0x1857E7C20")]
		[MethodImpl(256)]
		public int3x4(double3x4 v)
		{
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00024ED0 File Offset: 0x000230D0
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x572A120", Offset = "0x5728D20", VA = "0x18572A120")]
		[MethodImpl(256)]
		public static implicit operator int3x4(int v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00024EE8 File Offset: 0x000230E8
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x5767470", Offset = "0x5766070", VA = "0x185767470")]
		[MethodImpl(256)]
		public static explicit operator int3x4(bool v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00024F00 File Offset: 0x00023100
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x572A0E0", Offset = "0x5728CE0", VA = "0x18572A0E0")]
		[MethodImpl(256)]
		public static explicit operator int3x4(bool3x4 v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00024F18 File Offset: 0x00023118
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x572A120", Offset = "0x5728D20", VA = "0x18572A120")]
		[MethodImpl(256)]
		public static explicit operator int3x4(uint v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00024F30 File Offset: 0x00023130
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x572A3A0", Offset = "0x5728FA0", VA = "0x18572A3A0")]
		[MethodImpl(256)]
		public static explicit operator int3x4(uint3x4 v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00024F48 File Offset: 0x00023148
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x572A2B0", Offset = "0x5728EB0", VA = "0x18572A2B0")]
		[MethodImpl(256)]
		public static explicit operator int3x4(float v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00024F60 File Offset: 0x00023160
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x572A180", Offset = "0x5728D80", VA = "0x18572A180")]
		[MethodImpl(256)]
		public static explicit operator int3x4(float3x4 v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00024F78 File Offset: 0x00023178
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x572A250", Offset = "0x5728E50", VA = "0x18572A250")]
		[MethodImpl(256)]
		public static explicit operator int3x4(double v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00024F90 File Offset: 0x00023190
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x572A030", Offset = "0x5728C30", VA = "0x18572A030")]
		[MethodImpl(256)]
		public static explicit operator int3x4(double3x4 v)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00024FA8 File Offset: 0x000231A8
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x5768FC0", Offset = "0x5767BC0", VA = "0x185768FC0")]
		[MethodImpl(256)]
		public static int3x4 operator *(int3x4 lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00024FC0 File Offset: 0x000231C0
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x57691B0", Offset = "0x5767DB0", VA = "0x1857691B0")]
		[MethodImpl(256)]
		public static int3x4 operator *(int3x4 lhs, int rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00024FD8 File Offset: 0x000231D8
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x5768E90", Offset = "0x5767A90", VA = "0x185768E90")]
		[MethodImpl(256)]
		public static int3x4 operator *(int lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00024FF0 File Offset: 0x000231F0
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x5765A10", Offset = "0x5764610", VA = "0x185765A10")]
		[MethodImpl(256)]
		public static int3x4 operator +(int3x4 lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00025008 File Offset: 0x00023208
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x5765C00", Offset = "0x5764800", VA = "0x185765C00")]
		[MethodImpl(256)]
		public static int3x4 operator +(int3x4 lhs, int rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00025020 File Offset: 0x00023220
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x5765D20", Offset = "0x5764920", VA = "0x185765D20")]
		[MethodImpl(256)]
		public static int3x4 operator +(int lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00025038 File Offset: 0x00023238
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x5769750", Offset = "0x5768350", VA = "0x185769750")]
		[MethodImpl(256)]
		public static int3x4 operator -(int3x4 lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00025050 File Offset: 0x00023250
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x5769510", Offset = "0x5768110", VA = "0x185769510")]
		[MethodImpl(256)]
		public static int3x4 operator -(int3x4 lhs, int rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00025068 File Offset: 0x00023268
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x5769630", Offset = "0x5768230", VA = "0x185769630")]
		[MethodImpl(256)]
		public static int3x4 operator -(int lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00025080 File Offset: 0x00023280
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x57E7D00", Offset = "0x57E6900", VA = "0x1857E7D00")]
		[MethodImpl(256)]
		public static int3x4 operator /(int3x4 lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00025098 File Offset: 0x00023298
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x57E7F00", Offset = "0x57E6B00", VA = "0x1857E7F00")]
		[MethodImpl(256)]
		public static int3x4 operator /(int3x4 lhs, int rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000250B0 File Offset: 0x000232B0
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x57E8040", Offset = "0x57E6C40", VA = "0x1857E8040")]
		[MethodImpl(256)]
		public static int3x4 operator /(int lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x000250C8 File Offset: 0x000232C8
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x57E9200", Offset = "0x57E7E00", VA = "0x1857E9200")]
		[MethodImpl(256)]
		public static int3x4 operator %(int3x4 lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000250E0 File Offset: 0x000232E0
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x57E90C0", Offset = "0x57E7CC0", VA = "0x1857E90C0")]
		[MethodImpl(256)]
		public static int3x4 operator %(int3x4 lhs, int rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000250F8 File Offset: 0x000232F8
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x57E9400", Offset = "0x57E8000", VA = "0x1857E9400")]
		[MethodImpl(256)]
		public static int3x4 operator %(int lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00025110 File Offset: 0x00023310
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x5767C70", Offset = "0x5766870", VA = "0x185767C70")]
		[MethodImpl(256)]
		public static int3x4 operator ++(int3x4 val)
		{
			return default(int3x4);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00025128 File Offset: 0x00023328
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x57666A0", Offset = "0x57652A0", VA = "0x1857666A0")]
		[MethodImpl(256)]
		public static int3x4 operator --(int3x4 val)
		{
			return default(int3x4);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00025140 File Offset: 0x00023340
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x57E8E00", Offset = "0x57E7A00", VA = "0x1857E8E00")]
		[MethodImpl(256)]
		public static bool3x4 operator <(int3x4 lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00025158 File Offset: 0x00023358
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x57E8FB0", Offset = "0x57E7BB0", VA = "0x1857E8FB0")]
		[MethodImpl(256)]
		public static bool3x4 operator <(int3x4 lhs, int rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00025170 File Offset: 0x00023370
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x57E8CF0", Offset = "0x57E78F0", VA = "0x1857E8CF0")]
		[MethodImpl(256)]
		public static bool3x4 operator <(int lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00025188 File Offset: 0x00023388
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x57E8B40", Offset = "0x57E7740", VA = "0x1857E8B40")]
		[MethodImpl(256)]
		public static bool3x4 operator <=(int3x4 lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000251A0 File Offset: 0x000233A0
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x57E8A30", Offset = "0x57E7630", VA = "0x1857E8A30")]
		[MethodImpl(256)]
		public static bool3x4 operator <=(int3x4 lhs, int rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000251B8 File Offset: 0x000233B8
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x57E8920", Offset = "0x57E7520", VA = "0x1857E8920")]
		[MethodImpl(256)]
		public static bool3x4 operator <=(int lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000251D0 File Offset: 0x000233D0
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x57E8770", Offset = "0x57E7370", VA = "0x1857E8770")]
		[MethodImpl(256)]
		public static bool3x4 operator >(int3x4 lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000251E8 File Offset: 0x000233E8
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x57E8550", Offset = "0x57E7150", VA = "0x1857E8550")]
		[MethodImpl(256)]
		public static bool3x4 operator >(int3x4 lhs, int rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00025200 File Offset: 0x00023400
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x57E8660", Offset = "0x57E7260", VA = "0x1857E8660")]
		[MethodImpl(256)]
		public static bool3x4 operator >(int lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00025218 File Offset: 0x00023418
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x57E8290", Offset = "0x57E6E90", VA = "0x1857E8290")]
		[MethodImpl(256)]
		public static bool3x4 operator >=(int3x4 lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00025230 File Offset: 0x00023430
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x57E8180", Offset = "0x57E6D80", VA = "0x1857E8180")]
		[MethodImpl(256)]
		public static bool3x4 operator >=(int3x4 lhs, int rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00025248 File Offset: 0x00023448
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x57E8440", Offset = "0x57E7040", VA = "0x1857E8440")]
		[MethodImpl(256)]
		public static bool3x4 operator >=(int lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00025260 File Offset: 0x00023460
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x5769930", Offset = "0x5768530", VA = "0x185769930")]
		[MethodImpl(256)]
		public static int3x4 operator -(int3x4 val)
		{
			return default(int3x4);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00025278 File Offset: 0x00023478
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x5769A40", Offset = "0x5768640", VA = "0x185769A40")]
		[MethodImpl(256)]
		public static int3x4 operator +(int3x4 val)
		{
			return default(int3x4);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00025290 File Offset: 0x00023490
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x5768130", Offset = "0x5766D30", VA = "0x185768130")]
		[MethodImpl(256)]
		public static int3x4 operator <<(int3x4 x, int n)
		{
			return default(int3x4);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000252A8 File Offset: 0x000234A8
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x57E9540", Offset = "0x57E8140", VA = "0x1857E9540")]
		[MethodImpl(256)]
		public static int3x4 operator >>(int3x4 x, int n)
		{
			return default(int3x4);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x000252C0 File Offset: 0x000234C0
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x5766D50", Offset = "0x5765950", VA = "0x185766D50")]
		[MethodImpl(256)]
		public static bool3x4 operator ==(int3x4 lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x000252D8 File Offset: 0x000234D8
		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x5766C40", Offset = "0x5765840", VA = "0x185766C40")]
		[MethodImpl(256)]
		public static bool3x4 operator ==(int3x4 lhs, int rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x000252F0 File Offset: 0x000234F0
		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x5766F00", Offset = "0x5765B00", VA = "0x185766F00")]
		[MethodImpl(256)]
		public static bool3x4 operator ==(int lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00025308 File Offset: 0x00023508
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x5767D60", Offset = "0x5766960", VA = "0x185767D60")]
		[MethodImpl(256)]
		public static bool3x4 operator !=(int3x4 lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00025320 File Offset: 0x00023520
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x5768020", Offset = "0x5766C20", VA = "0x185768020")]
		[MethodImpl(256)]
		public static bool3x4 operator !=(int3x4 lhs, int rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00025338 File Offset: 0x00023538
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x5767F10", Offset = "0x5766B10", VA = "0x185767F10")]
		[MethodImpl(256)]
		public static bool3x4 operator !=(int lhs, int3x4 rhs)
		{
			return default(bool3x4);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00025350 File Offset: 0x00023550
		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x57692E0", Offset = "0x5767EE0", VA = "0x1857692E0")]
		[MethodImpl(256)]
		public static int3x4 operator ~(int3x4 val)
		{
			return default(int3x4);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00025368 File Offset: 0x00023568
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x5766080", Offset = "0x5764C80", VA = "0x185766080")]
		[MethodImpl(256)]
		public static int3x4 operator &(int3x4 lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00025380 File Offset: 0x00023580
		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x5765E40", Offset = "0x5764A40", VA = "0x185765E40")]
		[MethodImpl(256)]
		public static int3x4 operator &(int3x4 lhs, int rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00025398 File Offset: 0x00023598
		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x5765F60", Offset = "0x5764B60", VA = "0x185765F60")]
		[MethodImpl(256)]
		public static int3x4 operator &(int lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000253B0 File Offset: 0x000235B0
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x57664B0", Offset = "0x57650B0", VA = "0x1857664B0")]
		[MethodImpl(256)]
		public static int3x4 operator |(int3x4 lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000253C8 File Offset: 0x000235C8
		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x5766270", Offset = "0x5764E70", VA = "0x185766270")]
		[MethodImpl(256)]
		public static int3x4 operator |(int3x4 lhs, int rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000253E0 File Offset: 0x000235E0
		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x5766390", Offset = "0x5764F90", VA = "0x185766390")]
		[MethodImpl(256)]
		public static int3x4 operator |(int lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x000253F8 File Offset: 0x000235F8
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x5767250", Offset = "0x5765E50", VA = "0x185767250")]
		[MethodImpl(256)]
		public static int3x4 operator ^(int3x4 lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00025410 File Offset: 0x00023610
		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x5767010", Offset = "0x5765C10", VA = "0x185767010")]
		[MethodImpl(256)]
		public static int3x4 operator ^(int3x4 lhs, int rhs)
		{
			return default(int3x4);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x00025428 File Offset: 0x00023628
		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x5767130", Offset = "0x5765D30", VA = "0x185767130")]
		[MethodImpl(256)]
		public static int3x4 operator ^(int lhs, int3x4 rhs)
		{
			return default(int3x4);
		}

		// Token: 0x17000848 RID: 2120
		[Token(Token = "0x17000848")]
		public int3 this[int index]
		{
			[Token(Token = "0x6001B25")]
			[Address(RVA = "0x3D281B0", Offset = "0x3D26DB0", VA = "0x183D281B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00025440 File Offset: 0x00023640
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x5761E30", Offset = "0x5760A30", VA = "0x185761E30", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int3x4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00025458 File Offset: 0x00023658
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x57E6FA0", Offset = "0x57E5BA0", VA = "0x1857E6FA0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x00025470 File Offset: 0x00023670
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x57E7050", Offset = "0x57E5C50", VA = "0x1857E7050", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x57E7080", Offset = "0x57E5C80", VA = "0x1857E7080", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x57E7590", Offset = "0x57E6190", VA = "0x1857E7590", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x0")]
		public int3 c0;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xC")]
		public int3 c1;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x18")]
		public int3 c2;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x24")]
		public int3 c3;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int3x4 zero;
	}
}
