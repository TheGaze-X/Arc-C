using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct int3x2 : IEquatable<int3x2>, IFormattable
	{
		// Token: 0x06001A49 RID: 6729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x3746830", Offset = "0x3745430", VA = "0x183746830")]
		[MethodImpl(256)]
		public int3x2(int3 c0, int3 c1)
		{
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x57E0C90", Offset = "0x57DF890", VA = "0x1857E0C90")]
		[MethodImpl(256)]
		public int3x2(int m00, int m01, int m10, int m11, int m20, int m21)
		{
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x57E0D90", Offset = "0x57DF990", VA = "0x1857E0D90")]
		[MethodImpl(256)]
		public int3x2(int v)
		{
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x56FF3B0", Offset = "0x56FDFB0", VA = "0x1856FF3B0")]
		[MethodImpl(256)]
		public int3x2(bool v)
		{
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x56FF420", Offset = "0x56FE020", VA = "0x1856FF420")]
		[MethodImpl(256)]
		public int3x2(bool3x2 v)
		{
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x57E0D90", Offset = "0x57DF990", VA = "0x1857E0D90")]
		[MethodImpl(256)]
		public int3x2(uint v)
		{
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x57E0D10", Offset = "0x57DF910", VA = "0x1857E0D10")]
		[MethodImpl(256)]
		public int3x2(uint3x2 v)
		{
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x57E0CD0", Offset = "0x57DF8D0", VA = "0x1857E0CD0")]
		[MethodImpl(256)]
		public int3x2(float v)
		{
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x57E0DC0", Offset = "0x57DF9C0", VA = "0x1857E0DC0")]
		[MethodImpl(256)]
		public int3x2(float3x2 v)
		{
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x57E0E40", Offset = "0x57DFA40", VA = "0x1857E0E40")]
		[MethodImpl(256)]
		public int3x2(double v)
		{
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x57E0C10", Offset = "0x57DF810", VA = "0x1857E0C10")]
		[MethodImpl(256)]
		public int3x2(double3x2 v)
		{
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00024360 File Offset: 0x00022560
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x5729820", Offset = "0x5728420", VA = "0x185729820")]
		[MethodImpl(256)]
		public static implicit operator int3x2(int v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00024378 File Offset: 0x00022578
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x5729860", Offset = "0x5728460", VA = "0x185729860")]
		[MethodImpl(256)]
		public static explicit operator int3x2(bool v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00024390 File Offset: 0x00022590
		[Token(Token = "0x6001A56")]
		[Address(RVA = "0x57E1C00", Offset = "0x57E0800", VA = "0x1857E1C00")]
		[MethodImpl(256)]
		public static explicit operator int3x2(bool3x2 v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000243A8 File Offset: 0x000225A8
		[Token(Token = "0x6001A57")]
		[Address(RVA = "0x5729820", Offset = "0x5728420", VA = "0x185729820")]
		[MethodImpl(256)]
		public static explicit operator int3x2(uint v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x000243C0 File Offset: 0x000225C0
		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x57296D0", Offset = "0x57282D0", VA = "0x1857296D0")]
		[MethodImpl(256)]
		public static explicit operator int3x2(uint3x2 v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x000243D8 File Offset: 0x000225D8
		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x57299B0", Offset = "0x57285B0", VA = "0x1857299B0")]
		[MethodImpl(256)]
		public static explicit operator int3x2(float v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000243F0 File Offset: 0x000225F0
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x5729750", Offset = "0x5728350", VA = "0x185729750")]
		[MethodImpl(256)]
		public static explicit operator int3x2(float3x2 v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00024408 File Offset: 0x00022608
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x57299F0", Offset = "0x57285F0", VA = "0x1857299F0")]
		[MethodImpl(256)]
		public static explicit operator int3x2(double v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00024420 File Offset: 0x00022620
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x5729670", Offset = "0x5728270", VA = "0x185729670")]
		[MethodImpl(256)]
		public static explicit operator int3x2(double3x2 v)
		{
			return default(int3x2);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00024438 File Offset: 0x00022638
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x57E29C0", Offset = "0x57E15C0", VA = "0x1857E29C0")]
		[MethodImpl(256)]
		public static int3x2 operator *(int3x2 lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00024450 File Offset: 0x00022650
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x57E2B50", Offset = "0x57E1750", VA = "0x1857E2B50")]
		[MethodImpl(256)]
		public static int3x2 operator *(int3x2 lhs, int rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00024468 File Offset: 0x00022668
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x57E2AB0", Offset = "0x57E16B0", VA = "0x1857E2AB0")]
		[MethodImpl(256)]
		public static int3x2 operator *(int lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00024480 File Offset: 0x00022680
		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x57E0F10", Offset = "0x57DFB10", VA = "0x1857E0F10")]
		[MethodImpl(256)]
		public static int3x2 operator +(int3x2 lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00024498 File Offset: 0x00022698
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x57E0E80", Offset = "0x57DFA80", VA = "0x1857E0E80")]
		[MethodImpl(256)]
		public static int3x2 operator +(int3x2 lhs, int rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x000244B0 File Offset: 0x000226B0
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x57E1000", Offset = "0x57DFC00", VA = "0x1857E1000")]
		[MethodImpl(256)]
		public static int3x2 operator +(int lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x000244C8 File Offset: 0x000226C8
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x57E2DC0", Offset = "0x57E19C0", VA = "0x1857E2DC0")]
		[MethodImpl(256)]
		public static int3x2 operator -(int3x2 lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000244E0 File Offset: 0x000226E0
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x57E2EB0", Offset = "0x57E1AB0", VA = "0x1857E2EB0")]
		[MethodImpl(256)]
		public static int3x2 operator -(int3x2 lhs, int rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x000244F8 File Offset: 0x000226F8
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x57E2D20", Offset = "0x57E1920", VA = "0x1857E2D20")]
		[MethodImpl(256)]
		public static int3x2 operator -(int lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00024510 File Offset: 0x00022710
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x57E1620", Offset = "0x57E0220", VA = "0x1857E1620")]
		[MethodImpl(256)]
		public static int3x2 operator /(int3x2 lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00024528 File Offset: 0x00022728
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x57E1580", Offset = "0x57E0180", VA = "0x1857E1580")]
		[MethodImpl(256)]
		public static int3x2 operator /(int3x2 lhs, int rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00024540 File Offset: 0x00022740
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x57E1720", Offset = "0x57E0320", VA = "0x1857E1720")]
		[MethodImpl(256)]
		public static int3x2 operator /(int lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00024558 File Offset: 0x00022758
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x57E2760", Offset = "0x57E1360", VA = "0x1857E2760")]
		[MethodImpl(256)]
		public static int3x2 operator %(int3x2 lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00024570 File Offset: 0x00022770
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x57E2910", Offset = "0x57E1510", VA = "0x1857E2910")]
		[MethodImpl(256)]
		public static int3x2 operator %(int3x2 lhs, int rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00024588 File Offset: 0x00022788
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x57E2860", Offset = "0x57E1460", VA = "0x1857E2860")]
		[MethodImpl(256)]
		public static int3x2 operator %(int lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x000245A0 File Offset: 0x000227A0
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x57E2040", Offset = "0x57E0C40", VA = "0x1857E2040")]
		[MethodImpl(256)]
		public static int3x2 operator ++(int3x2 val)
		{
			return default(int3x2);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x000245B8 File Offset: 0x000227B8
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x57E1500", Offset = "0x57E0100", VA = "0x1857E1500")]
		[MethodImpl(256)]
		public static int3x2 operator --(int3x2 val)
		{
			return default(int3x2);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000245D0 File Offset: 0x000227D0
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x57E25F0", Offset = "0x57E11F0", VA = "0x1857E25F0")]
		[MethodImpl(256)]
		public static bool3x2 operator <(int3x2 lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x000245E8 File Offset: 0x000227E8
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x57E26D0", Offset = "0x57E12D0", VA = "0x1857E26D0")]
		[MethodImpl(256)]
		public static bool3x2 operator <(int3x2 lhs, int rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00024600 File Offset: 0x00022800
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x57E2560", Offset = "0x57E1160", VA = "0x1857E2560")]
		[MethodImpl(256)]
		public static bool3x2 operator <(int lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00024618 File Offset: 0x00022818
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x57E2480", Offset = "0x57E1080", VA = "0x1857E2480")]
		[MethodImpl(256)]
		public static bool3x2 operator <=(int3x2 lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00024630 File Offset: 0x00022830
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x57E23F0", Offset = "0x57E0FF0", VA = "0x1857E23F0")]
		[MethodImpl(256)]
		public static bool3x2 operator <=(int3x2 lhs, int rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00024648 File Offset: 0x00022848
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x57E2360", Offset = "0x57E0F60", VA = "0x1857E2360")]
		[MethodImpl(256)]
		public static bool3x2 operator <=(int lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00024660 File Offset: 0x00022860
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x57E1E40", Offset = "0x57E0A40", VA = "0x1857E1E40")]
		[MethodImpl(256)]
		public static bool3x2 operator >(int3x2 lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00024678 File Offset: 0x00022878
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x57E1F20", Offset = "0x57E0B20", VA = "0x1857E1F20")]
		[MethodImpl(256)]
		public static bool3x2 operator >(int3x2 lhs, int rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00024690 File Offset: 0x00022890
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x57E1FB0", Offset = "0x57E0BB0", VA = "0x1857E1FB0")]
		[MethodImpl(256)]
		public static bool3x2 operator >(int lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000246A8 File Offset: 0x000228A8
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x57E1CD0", Offset = "0x57E08D0", VA = "0x1857E1CD0")]
		[MethodImpl(256)]
		public static bool3x2 operator >=(int3x2 lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000246C0 File Offset: 0x000228C0
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x57E1DB0", Offset = "0x57E09B0", VA = "0x1857E1DB0")]
		[MethodImpl(256)]
		public static bool3x2 operator >=(int3x2 lhs, int rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x000246D8 File Offset: 0x000228D8
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x57E1C40", Offset = "0x57E0840", VA = "0x1857E1C40")]
		[MethodImpl(256)]
		public static bool3x2 operator >=(int lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000246F0 File Offset: 0x000228F0
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x57E2F50", Offset = "0x57E1B50", VA = "0x1857E2F50")]
		[MethodImpl(256)]
		public static int3x2 operator -(int3x2 val)
		{
			return default(int3x2);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00024708 File Offset: 0x00022908
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x57E2FE0", Offset = "0x57E1BE0", VA = "0x1857E2FE0")]
		[MethodImpl(256)]
		public static int3x2 operator +(int3x2 val)
		{
			return default(int3x2);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00024720 File Offset: 0x00022920
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x57E22C0", Offset = "0x57E0EC0", VA = "0x1857E22C0")]
		[MethodImpl(256)]
		public static int3x2 operator <<(int3x2 x, int n)
		{
			return default(int3x2);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00024738 File Offset: 0x00022938
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x57E2C80", Offset = "0x57E1880", VA = "0x1857E2C80")]
		[MethodImpl(256)]
		public static int3x2 operator >>(int3x2 x, int n)
		{
			return default(int3x2);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00024750 File Offset: 0x00022950
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x57E17D0", Offset = "0x57E03D0", VA = "0x1857E17D0")]
		[MethodImpl(256)]
		public static bool3x2 operator ==(int3x2 lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00024768 File Offset: 0x00022968
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x57E18B0", Offset = "0x57E04B0", VA = "0x1857E18B0")]
		[MethodImpl(256)]
		public static bool3x2 operator ==(int3x2 lhs, int rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00024780 File Offset: 0x00022980
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x57E1940", Offset = "0x57E0540", VA = "0x1857E1940")]
		[MethodImpl(256)]
		public static bool3x2 operator ==(int lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00024798 File Offset: 0x00022998
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x57E20C0", Offset = "0x57E0CC0", VA = "0x1857E20C0")]
		[MethodImpl(256)]
		public static bool3x2 operator !=(int3x2 lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000247B0 File Offset: 0x000229B0
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x57E21A0", Offset = "0x57E0DA0", VA = "0x1857E21A0")]
		[MethodImpl(256)]
		public static bool3x2 operator !=(int3x2 lhs, int rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000247C8 File Offset: 0x000229C8
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x57E2230", Offset = "0x57E0E30", VA = "0x1857E2230")]
		[MethodImpl(256)]
		public static bool3x2 operator !=(int lhs, int3x2 rhs)
		{
			return default(bool3x2);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000247E0 File Offset: 0x000229E0
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x57E2BF0", Offset = "0x57E17F0", VA = "0x1857E2BF0")]
		[MethodImpl(256)]
		public static int3x2 operator ~(int3x2 val)
		{
			return default(int3x2);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000247F8 File Offset: 0x000229F8
		[Token(Token = "0x6001A85")]
		[Address(RVA = "0x57E10A0", Offset = "0x57DFCA0", VA = "0x1857E10A0")]
		[MethodImpl(256)]
		public static int3x2 operator &(int3x2 lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00024810 File Offset: 0x00022A10
		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x57E1230", Offset = "0x57DFE30", VA = "0x1857E1230")]
		[MethodImpl(256)]
		public static int3x2 operator &(int3x2 lhs, int rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00024828 File Offset: 0x00022A28
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x57E1190", Offset = "0x57DFD90", VA = "0x1857E1190")]
		[MethodImpl(256)]
		public static int3x2 operator &(int lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00024840 File Offset: 0x00022A40
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x57E1370", Offset = "0x57DFF70", VA = "0x1857E1370")]
		[MethodImpl(256)]
		public static int3x2 operator |(int3x2 lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00024858 File Offset: 0x00022A58
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x57E12D0", Offset = "0x57DFED0", VA = "0x1857E12D0")]
		[MethodImpl(256)]
		public static int3x2 operator |(int3x2 lhs, int rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00024870 File Offset: 0x00022A70
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x57E1460", Offset = "0x57E0060", VA = "0x1857E1460")]
		[MethodImpl(256)]
		public static int3x2 operator |(int lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00024888 File Offset: 0x00022A88
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x57E1A70", Offset = "0x57E0670", VA = "0x1857E1A70")]
		[MethodImpl(256)]
		public static int3x2 operator ^(int3x2 lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000248A0 File Offset: 0x00022AA0
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x57E19D0", Offset = "0x57E05D0", VA = "0x1857E19D0")]
		[MethodImpl(256)]
		public static int3x2 operator ^(int3x2 lhs, int rhs)
		{
			return default(int3x2);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000248B8 File Offset: 0x00022AB8
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x57E1B60", Offset = "0x57E0760", VA = "0x1857E1B60")]
		[MethodImpl(256)]
		public static int3x2 operator ^(int lhs, int3x2 rhs)
		{
			return default(int3x2);
		}

		// Token: 0x17000846 RID: 2118
		[Token(Token = "0x17000846")]
		public int3 this[int index]
		{
			[Token(Token = "0x6001A8E")]
			[Address(RVA = "0x3D281B0", Offset = "0x3D26DB0", VA = "0x183D281B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000248D0 File Offset: 0x00022AD0
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x57E04D0", Offset = "0x57DF0D0", VA = "0x1857E04D0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int3x2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000248E8 File Offset: 0x00022AE8
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x57E0550", Offset = "0x57DF150", VA = "0x1857E0550", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00024900 File Offset: 0x00022B00
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x57E0640", Offset = "0x57DF240", VA = "0x1857E0640", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x57E0940", Offset = "0x57DF540", VA = "0x1857E0940", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x57E0670", Offset = "0x57DF270", VA = "0x1857E0670", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x0")]
		public int3 c0;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xC")]
		public int3 c1;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int3x2 zero;
	}
}
