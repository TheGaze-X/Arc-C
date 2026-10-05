using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[Serializable]
	public struct FP : IEquatable<FP>, IComparable<FP>, ILuaCallCSharp
	{
		// Token: 0x0600029F RID: 671 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x54E1DD0", Offset = "0x54E09D0", VA = "0x1854E1DD0")]
		public static int Sign(FP value)
		{
			return 0;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x54DFDE0", Offset = "0x54DE9E0", VA = "0x1854DFDE0")]
		public static FP Abs(FP value)
		{
			return default(FP);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x54E0B00", Offset = "0x54DF700", VA = "0x1854E0B00")]
		public static FP FastAbs(FP value)
		{
			return default(FP);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x54E0E90", Offset = "0x54DFA90", VA = "0x1854E0E90")]
		public static FP Floor(FP value)
		{
			return default(FP);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x54E08E0", Offset = "0x54DF4E0", VA = "0x1854E08E0")]
		public static FP Ceiling(FP value)
		{
			return default(FP);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003B9C File Offset: 0x00001D9C
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x54E1D20", Offset = "0x54E0920", VA = "0x1854E1D20")]
		public static FP Round(FP value)
		{
			return default(FP);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x3D28AE0", Offset = "0x3D276E0", VA = "0x183D28AE0")]
		public static FP operator +(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00003BCC File Offset: 0x00001DCC
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x54E1AD0", Offset = "0x54E06D0", VA = "0x1854E1AD0")]
		public static FP OverflowAdd(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x3D28AE0", Offset = "0x3D276E0", VA = "0x183D28AE0")]
		public static FP FastAdd(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x54E0E80", Offset = "0x54DFA80", VA = "0x1854E0E80")]
		public static FP operator -(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003C14 File Offset: 0x00001E14
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x54E1CE0", Offset = "0x54E08E0", VA = "0x1854E1CE0")]
		public static FP OverflowSub(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x54E0E80", Offset = "0x54DFA80", VA = "0x1854E0E80")]
		public static FP FastSub(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x54E00F0", Offset = "0x54DECF0", VA = "0x1854E00F0")]
		private static long AddOverflowHelper(long x, long y, ref bool overflow)
		{
			return 0L;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x54E0CE0", Offset = "0x54DF8E0", VA = "0x1854E0CE0")]
		public static FP operator *(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x54E1B10", Offset = "0x54E0710", VA = "0x1854E1B10")]
		public static FP OverflowMul(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x54E0CE0", Offset = "0x54DF8E0", VA = "0x1854E0CE0")]
		public static FP FastMul(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x54E0A40", Offset = "0x54DF640", VA = "0x1854E0A40")]
		public static int CountLeadingZeroes(ulong x)
		{
			return 0;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00003CBC File Offset: 0x00001EBC
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x54E2B60", Offset = "0x54E1760", VA = "0x1854E2B60")]
		public static FP operator /(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x54E2F30", Offset = "0x54E1B30", VA = "0x1854E2F30")]
		public static FP operator %(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x54E0CD0", Offset = "0x54DF8D0", VA = "0x1854E0CD0")]
		public static FP FastMod(FP x, FP y)
		{
			return default(FP);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x54E2F70", Offset = "0x54E1B70", VA = "0x1854E2F70")]
		public static FP operator -(FP x)
		{
			return default(FP);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(FP x, FP y)
		{
			return default(bool);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(FP x, FP y)
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x4D00420", Offset = "0x4CFF020", VA = "0x184D00420")]
		public static bool operator >(FP x, FP y)
		{
			return default(bool);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4D00450", Offset = "0x4CFF050", VA = "0x184D00450")]
		public static bool operator <(FP x, FP y)
		{
			return default(bool);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x4D00410", Offset = "0x4CFF010", VA = "0x184D00410")]
		public static bool operator >=(FP x, FP y)
		{
			return default(bool);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003D94 File Offset: 0x00001F94
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4D00440", Offset = "0x4CFF040", VA = "0x184D00440")]
		public static bool operator <=(FP x, FP y)
		{
			return default(bool);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x54E2050", Offset = "0x54E0C50", VA = "0x1854E2050")]
		public static FP Sqrt(FP x)
		{
			return default(FP);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x54E1DF0", Offset = "0x54E09F0", VA = "0x1854E1DF0")]
		public static FP Sin(FP x)
		{
			return default(FP);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x54E0D10", Offset = "0x54DF910", VA = "0x1854E0D10")]
		public static FP FastSin(FP x)
		{
			return default(FP);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x54E0950", Offset = "0x54DF550", VA = "0x1854E0950")]
		public static long ClampSinValue(long angle, out bool flipHorizontal, out bool flipVertical)
		{
			return 0L;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x54E09D0", Offset = "0x54DF5D0", VA = "0x1854E09D0")]
		public static FP Cos(FP x)
		{
			return default(FP);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003E24 File Offset: 0x00002024
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x54E0B10", Offset = "0x54DF710", VA = "0x1854E0B10")]
		public static FP FastCos(FP x)
		{
			return default(FP);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00003E3C File Offset: 0x0000203C
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x54E2180", Offset = "0x54E0D80", VA = "0x1854E2180")]
		public static FP Tan(FP x)
		{
			return default(FP);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x54E0880", Offset = "0x54DF480", VA = "0x1854E0880")]
		public static FP Atan(FP y)
		{
			return default(FP);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00003E6C File Offset: 0x0000206C
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x54E0370", Offset = "0x54DEF70", VA = "0x1854E0370")]
		public static FP Atan2(FP y, FP x)
		{
			return default(FP);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00003E84 File Offset: 0x00002084
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x54E02F0", Offset = "0x54DEEF0", VA = "0x1854E02F0")]
		public static FP Asin(FP value)
		{
			return default(FP);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00003E9C File Offset: 0x0000209C
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x54DFE60", Offset = "0x54DEA60", VA = "0x1854DFE60")]
		public static FP Acos(FP value)
		{
			return default(FP);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00003EB4 File Offset: 0x000020B4
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x54E2F10", Offset = "0x54E1B10", VA = "0x1854E2F10")]
		public static implicit operator FP(long value)
		{
			return default(FP);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003ECC File Offset: 0x000020CC
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x54E2D40", Offset = "0x54E1940", VA = "0x1854E2D40")]
		public static explicit operator long(FP value)
		{
			return 0L;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00003EE4 File Offset: 0x000020E4
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x54E2F00", Offset = "0x54E1B00", VA = "0x1854E2F00")]
		public static implicit operator FP(float value)
		{
			return default(FP);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003EFC File Offset: 0x000020FC
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x54E2E10", Offset = "0x54E1A10", VA = "0x1854E2E10")]
		public static explicit operator float(FP value)
		{
			return 0f;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x54E2F20", Offset = "0x54E1B20", VA = "0x1854E2F20")]
		public static implicit operator FP(double value)
		{
			return default(FP);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x54E2D50", Offset = "0x54E1950", VA = "0x1854E2D50")]
		public static explicit operator double(FP value)
		{
			return 0.0;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x54E2D70", Offset = "0x54E1970", VA = "0x1854E2D70")]
		public static explicit operator FP(decimal value)
		{
			return default(FP);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x54E2EF0", Offset = "0x54E1AF0", VA = "0x1854E2EF0")]
		public static implicit operator FP(int value)
		{
			return default(FP);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x54E2E30", Offset = "0x54E1A30", VA = "0x1854E2E30")]
		public static explicit operator decimal(FP value)
		{
			return 0m;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x54E01F0", Offset = "0x54DEDF0", VA = "0x1854E01F0")]
		public float AsFloat()
		{
			return 0f;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x54E0250", Offset = "0x54DEE50", VA = "0x1854E0250")]
		public int AsInt()
		{
			return 0;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003FBC File Offset: 0x000021BC
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x54E02A0", Offset = "0x54DEEA0", VA = "0x1854E02A0")]
		public long AsLong()
		{
			return 0L;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x54E0190", Offset = "0x54DED90", VA = "0x1854E0190")]
		public double AsDouble()
		{
			return 0.0;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x54E0120", Offset = "0x54DED20", VA = "0x1854E0120")]
		public decimal AsDecimal()
		{
			return 0m;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x54E2330", Offset = "0x54E0F30", VA = "0x1854E2330")]
		public static float ToFloat(FP value)
		{
			return 0f;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x54E2380", Offset = "0x54E0F80", VA = "0x1854E2380")]
		public static int ToInt(FP value)
		{
			return 0;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x54E0EA0", Offset = "0x54DFAA0", VA = "0x1854E0EA0")]
		public static FP FromFloat(float value)
		{
			return default(FP);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x54E19F0", Offset = "0x54E05F0", VA = "0x1854E19F0")]
		public static bool IsInfinity(FP value)
		{
			return default(bool);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x54E1A70", Offset = "0x54E0670", VA = "0x1854E1A70")]
		public static bool IsNaN(FP value)
		{
			return default(bool);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x54E0A70", Offset = "0x54DF670", VA = "0x1854E0A70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4F0F8E0", Offset = "0x4F0E4E0", VA = "0x184F0F8E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(FP other)
		{
			return default(bool);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x4F0F840", Offset = "0x4F0E440", VA = "0x184F0F840", Slot = "5")]
		public int CompareTo(FP other)
		{
			return 0;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x54E23D0", Offset = "0x54E0FD0", VA = "0x1854E23D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static FP FromRaw(long rawValue)
		{
			return default(FP);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x54E0F00", Offset = "0x54DFB00", VA = "0x1854E0F00")]
		internal static void GenerateAcosLut()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x54E1210", Offset = "0x54DFE10", VA = "0x1854E1210")]
		internal static void GenerateSinLut()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x54E1550", Offset = "0x54E0150", VA = "0x1854E1550")]
		internal static void GenerateTanLut()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x1700003E")]
		public long RawValue
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		private FP(long rawValue)
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x54E2B50", Offset = "0x54E1750", VA = "0x1854E2B50")]
		public FP(int value)
		{
		}

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public long _serializedValue;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[NonSerialized]
		public const long MAX_VALUE = 9223372036854775807L;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[NonSerialized]
		public const long MIN_VALUE = -9223372036854775808L;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[NonSerialized]
		public const int NUM_BITS = 64;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[NonSerialized]
		public const int FRACTIONAL_PLACES = 32;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[NonSerialized]
		public const long ONE = 4294967296L;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[NonSerialized]
		public const long TEN = 42949672960L;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[NonSerialized]
		public const long HALF = 2147483648L;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[NonSerialized]
		public const long PI_TIMES_2 = 26986075409L;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[NonSerialized]
		public const long PI = 13493037704L;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[NonSerialized]
		public const long PI_OVER_2 = 6746518852L;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[NonSerialized]
		public const int LUT_SIZE = 205887;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly decimal Precision;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public static readonly FP MaxValue;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public static readonly FP MinValue;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public static readonly FP One;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public static readonly FP Ten;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public static readonly FP Half;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public static readonly FP Zero;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public static readonly FP PositiveInfinity;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public static readonly FP NegativeInfinity;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public static readonly FP NaN;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public static readonly FP EN1;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public static readonly FP EN2;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public static readonly FP EN3;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public static readonly FP EN4;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public static readonly FP EN5;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public static readonly FP EN6;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public static readonly FP EN7;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public static readonly FP EN8;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public static readonly FP Epsilon;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public static readonly FP Pi;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public static readonly FP PiOver2;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public static readonly FP PiTimes2;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public static readonly FP PiInv;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		public static readonly FP PiOver2Inv;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public static readonly FP Deg2Rad;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public static readonly FP Rad2Deg;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public static readonly FP LutInterval;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		public static readonly long[] AcosLut;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public static readonly long[] SinLut;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public static readonly long[] TanLut;
	}
}
