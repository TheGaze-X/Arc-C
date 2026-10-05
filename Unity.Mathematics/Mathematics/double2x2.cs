using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct double2x2 : IEquatable<double2x2>, IFormattable
	{
		// Token: 0x06000B3E RID: 2878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x371F730", Offset = "0x371E330", VA = "0x18371F730")]
		[MethodImpl(256)]
		public double2x2(double2 c0, double2 c1)
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x57847A0", Offset = "0x57833A0", VA = "0x1857847A0")]
		[MethodImpl(256)]
		public double2x2(double m00, double m01, double m10, double m11)
		{
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x5784780", Offset = "0x5783380", VA = "0x185784780")]
		[MethodImpl(256)]
		public double2x2(double v)
		{
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x5784750", Offset = "0x5783350", VA = "0x185784750")]
		[MethodImpl(256)]
		public double2x2(bool v)
		{
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x57846D0", Offset = "0x57832D0", VA = "0x1857846D0")]
		[MethodImpl(256)]
		public double2x2(bool2x2 v)
		{
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x5784730", Offset = "0x5783330", VA = "0x185784730")]
		[MethodImpl(256)]
		public double2x2(int v)
		{
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x57848A0", Offset = "0x57834A0", VA = "0x1857848A0")]
		[MethodImpl(256)]
		public double2x2(int2x2 v)
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x57847C0", Offset = "0x57833C0", VA = "0x1857847C0")]
		[MethodImpl(256)]
		public double2x2(uint v)
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x5784820", Offset = "0x5783420", VA = "0x185784820")]
		[MethodImpl(256)]
		public double2x2(uint2x2 v)
		{
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x5784870", Offset = "0x5783470", VA = "0x185784870")]
		[MethodImpl(256)]
		public double2x2(float v)
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x57847E0", Offset = "0x57833E0", VA = "0x1857847E0")]
		[MethodImpl(256)]
		public double2x2(float2x2 v)
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x570E310", Offset = "0x570CF10", VA = "0x18570E310")]
		[MethodImpl(256)]
		public static implicit operator double2x2(double v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x570E540", Offset = "0x570D140", VA = "0x18570E540")]
		[MethodImpl(256)]
		public static explicit operator double2x2(bool v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00011E08 File Offset: 0x00010008
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x570E330", Offset = "0x570CF30", VA = "0x18570E330")]
		[MethodImpl(256)]
		public static explicit operator double2x2(bool2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00011E20 File Offset: 0x00010020
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x570E440", Offset = "0x570D040", VA = "0x18570E440")]
		[MethodImpl(256)]
		public static implicit operator double2x2(int v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x570E460", Offset = "0x570D060", VA = "0x18570E460")]
		[MethodImpl(256)]
		public static implicit operator double2x2(int2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00011E50 File Offset: 0x00010050
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x570E390", Offset = "0x570CF90", VA = "0x18570E390")]
		[MethodImpl(256)]
		public static implicit operator double2x2(uint v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00011E68 File Offset: 0x00010068
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x570E4D0", Offset = "0x570D0D0", VA = "0x18570E4D0")]
		[MethodImpl(256)]
		public static implicit operator double2x2(uint2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00011E80 File Offset: 0x00010080
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x570E2A0", Offset = "0x570CEA0", VA = "0x18570E2A0")]
		[MethodImpl(256)]
		public static implicit operator double2x2(float v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x570E3F0", Offset = "0x570CFF0", VA = "0x18570E3F0")]
		[MethodImpl(256)]
		public static implicit operator double2x2(float2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x5785580", Offset = "0x5784180", VA = "0x185785580")]
		[MethodImpl(256)]
		public static double2x2 operator *(double2x2 lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00011EC8 File Offset: 0x000100C8
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x5785500", Offset = "0x5784100", VA = "0x185785500")]
		[MethodImpl(256)]
		public static double2x2 operator *(double2x2 lhs, double rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x5785540", Offset = "0x5784140", VA = "0x185785540")]
		[MethodImpl(256)]
		public static double2x2 operator *(double lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00011EF8 File Offset: 0x000100F8
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x57848F0", Offset = "0x57834F0", VA = "0x1857848F0")]
		[MethodImpl(256)]
		public static double2x2 operator +(double2x2 lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00011F10 File Offset: 0x00010110
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x5784940", Offset = "0x5783540", VA = "0x185784940")]
		[MethodImpl(256)]
		public static double2x2 operator +(double2x2 lhs, double rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00011F28 File Offset: 0x00010128
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x5784980", Offset = "0x5783580", VA = "0x185784980")]
		[MethodImpl(256)]
		public static double2x2 operator +(double lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00011F40 File Offset: 0x00010140
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x5785660", Offset = "0x5784260", VA = "0x185785660")]
		[MethodImpl(256)]
		public static double2x2 operator -(double2x2 lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00011F58 File Offset: 0x00010158
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x5785620", Offset = "0x5784220", VA = "0x185785620")]
		[MethodImpl(256)]
		public static double2x2 operator -(double2x2 lhs, double rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00011F70 File Offset: 0x00010170
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x57855D0", Offset = "0x57841D0", VA = "0x1857855D0")]
		[MethodImpl(256)]
		public static double2x2 operator -(double lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00011F88 File Offset: 0x00010188
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x5784A50", Offset = "0x5783650", VA = "0x185784A50")]
		[MethodImpl(256)]
		public static double2x2 operator /(double2x2 lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00011FA0 File Offset: 0x000101A0
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x5784A10", Offset = "0x5783610", VA = "0x185784A10")]
		[MethodImpl(256)]
		public static double2x2 operator /(double2x2 lhs, double rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00011FB8 File Offset: 0x000101B8
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x5784AA0", Offset = "0x57836A0", VA = "0x185784AA0")]
		[MethodImpl(256)]
		public static double2x2 operator /(double lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00011FD0 File Offset: 0x000101D0
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x57852E0", Offset = "0x5783EE0", VA = "0x1857852E0")]
		[MethodImpl(256)]
		public static double2x2 operator %(double2x2 lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00011FE8 File Offset: 0x000101E8
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x5785450", Offset = "0x5784050", VA = "0x185785450")]
		[MethodImpl(256)]
		public static double2x2 operator %(double2x2 lhs, double rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x57853A0", Offset = "0x5783FA0", VA = "0x1857853A0")]
		[MethodImpl(256)]
		public static double2x2 operator %(double lhs, double2x2 rhs)
		{
			return default(double2x2);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00012018 File Offset: 0x00010218
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x5784EC0", Offset = "0x5783AC0", VA = "0x185784EC0")]
		[MethodImpl(256)]
		public static double2x2 operator ++(double2x2 val)
		{
			return default(double2x2);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00012030 File Offset: 0x00010230
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x57849C0", Offset = "0x57835C0", VA = "0x1857849C0")]
		[MethodImpl(256)]
		public static double2x2 operator --(double2x2 val)
		{
			return default(double2x2);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00012048 File Offset: 0x00010248
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x5785280", Offset = "0x5783E80", VA = "0x185785280")]
		[MethodImpl(256)]
		public static bool2x2 operator <(double2x2 lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00012060 File Offset: 0x00010260
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x5785230", Offset = "0x5783E30", VA = "0x185785230")]
		[MethodImpl(256)]
		public static bool2x2 operator <(double2x2 lhs, double rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00012078 File Offset: 0x00010278
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x57851D0", Offset = "0x5783DD0", VA = "0x1857851D0")]
		[MethodImpl(256)]
		public static bool2x2 operator <(double lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00012090 File Offset: 0x00010290
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x5785110", Offset = "0x5783D10", VA = "0x185785110")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(double2x2 lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000120A8 File Offset: 0x000102A8
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x57850C0", Offset = "0x5783CC0", VA = "0x1857850C0")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(double2x2 lhs, double rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000120C0 File Offset: 0x000102C0
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x5785170", Offset = "0x5783D70", VA = "0x185785170")]
		[MethodImpl(256)]
		public static bool2x2 operator <=(double lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000120D8 File Offset: 0x000102D8
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x5784DB0", Offset = "0x57839B0", VA = "0x185784DB0")]
		[MethodImpl(256)]
		public static bool2x2 operator >(double2x2 lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x000120F0 File Offset: 0x000102F0
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x5784E10", Offset = "0x5783A10", VA = "0x185784E10")]
		[MethodImpl(256)]
		public static bool2x2 operator >(double2x2 lhs, double rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00012108 File Offset: 0x00010308
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x5784E70", Offset = "0x5783A70", VA = "0x185784E70")]
		[MethodImpl(256)]
		public static bool2x2 operator >(double lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00012120 File Offset: 0x00010320
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x5784CF0", Offset = "0x57838F0", VA = "0x185784CF0")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(double2x2 lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00012138 File Offset: 0x00010338
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x5784D50", Offset = "0x5783950", VA = "0x185784D50")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(double2x2 lhs, double rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00012150 File Offset: 0x00010350
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x5784CA0", Offset = "0x57838A0", VA = "0x185784CA0")]
		[MethodImpl(256)]
		public static bool2x2 operator >=(double lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00012168 File Offset: 0x00010368
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x57856B0", Offset = "0x57842B0", VA = "0x1857856B0")]
		[MethodImpl(256)]
		public static double2x2 operator -(double2x2 val)
		{
			return default(double2x2);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00012180 File Offset: 0x00010380
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x57856F0", Offset = "0x57842F0", VA = "0x1857856F0")]
		[MethodImpl(256)]
		public static double2x2 operator +(double2x2 val)
		{
			return default(double2x2);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00012198 File Offset: 0x00010398
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x5784AF0", Offset = "0x57836F0", VA = "0x185784AF0")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(double2x2 lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x5784B90", Offset = "0x5783790", VA = "0x185784B90")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(double2x2 lhs, double rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x5784C20", Offset = "0x5783820", VA = "0x185784C20")]
		[MethodImpl(256)]
		public static bool2x2 operator ==(double lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000121E0 File Offset: 0x000103E0
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x5784F10", Offset = "0x5783B10", VA = "0x185784F10")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(double2x2 lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000121F8 File Offset: 0x000103F8
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x5785030", Offset = "0x5783C30", VA = "0x185785030")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(double2x2 lhs, double rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00012210 File Offset: 0x00010410
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x5784FB0", Offset = "0x5783BB0", VA = "0x185784FB0")]
		[MethodImpl(256)]
		public static bool2x2 operator !=(double lhs, double2x2 rhs)
		{
			return default(bool2x2);
		}

		// Token: 0x1700020B RID: 523
		[Token(Token = "0x1700020B")]
		public double2 this[int index]
		{
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x3D28160", Offset = "0x3D26D60", VA = "0x183D28160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x5784100", Offset = "0x5782D00", VA = "0x185784100", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(double2x2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00012240 File Offset: 0x00010440
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x5784160", Offset = "0x5782D60", VA = "0x185784160", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00012258 File Offset: 0x00010458
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x5784230", Offset = "0x5782E30", VA = "0x185784230", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x5784260", Offset = "0x5782E60", VA = "0x185784260", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x5784470", Offset = "0x5783070", VA = "0x185784470", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x0")]
		public double2 c0;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x10")]
		public double2 c1;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double2x2 identity;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x20")]
		public static readonly double2x2 zero;
	}
}
