using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public abstract class Enum : System.ValueType, System.IComparable, System.IFormattable, System.IConvertible
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x4D17CA0", Offset = "0x4D168A0", VA = "0x184D17CA0")]
		private static System.Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames)
		{
			return null;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x4D18C40", Offset = "0x4D17840", VA = "0x184D18C40")]
		private static string InternalFormattedHexString(object value)
		{
			return null;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x4D18A40", Offset = "0x4D17640", VA = "0x184D18A40")]
		private static string InternalFormat(RuntimeType eT, object value)
		{
			return null;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x4D18840", Offset = "0x4D17440", VA = "0x184D18840")]
		private static string InternalFlagsFormat(RuntimeType eT, object value)
		{
			return null;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x4D1BFB0", Offset = "0x4D1ABB0", VA = "0x184D1BFB0")]
		internal static ulong ToUInt64(object value)
		{
			return 0UL;
		}

		// Token: 0x06000E06 RID: 3590
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x4D18830", Offset = "0x4D17430", VA = "0x184D18830")]
		[MethodImpl(4096)]
		private static extern int InternalCompareTo(object o1, object o2);

		// Token: 0x06000E07 RID: 3591
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x4D191B0", Offset = "0x4D17DB0", VA = "0x184D191B0")]
		[MethodImpl(4096)]
		internal static extern RuntimeType InternalGetUnderlyingType(RuntimeType enumType);

		// Token: 0x06000E08 RID: 3592
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x4D17E50", Offset = "0x4D16A50", VA = "0x184D17E50")]
		[MethodImpl(4096)]
		private static extern bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names);

		// Token: 0x06000E09 RID: 3593
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x4D18820", Offset = "0x4D17420", VA = "0x184D18820")]
		[MethodImpl(4096)]
		private static extern object InternalBoxEnum(RuntimeType enumType, long value);

		// Token: 0x06000E0A RID: 3594 RVA: 0x0000C870 File Offset: 0x0000AA70
		[Token(Token = "0x6000E0A")]
		public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct
		{
			return default(bool);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x6000E0B")]
		public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct
		{
			return default(bool);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x4D19440", Offset = "0x4D18040", VA = "0x184D19440")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object Parse(System.Type enumType, string value)
		{
			return null;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x4D19320", Offset = "0x4D17F20", VA = "0x184D19320")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object Parse(System.Type enumType, string value, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x4D1C150", Offset = "0x4D1AD50", VA = "0x184D1C150")]
		private static bool TryParseEnum(System.Type enumType, string value, bool ignoreCase, ref System.Enum.EnumResult parseResult)
		{
			return default(bool);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x4D18480", Offset = "0x4D17080", VA = "0x184D18480")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static System.Type GetUnderlyingType(System.Type enumType)
		{
			return null;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x4D18570", Offset = "0x4D17170", VA = "0x184D18570")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static System.Array GetValues(System.Type enumType)
		{
			return null;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x4D191C0", Offset = "0x4D17DC0", VA = "0x184D191C0")]
		internal static ulong[] InternalGetValues(RuntimeType enumType)
		{
			return null;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x4D17E70", Offset = "0x4D16A70", VA = "0x184D17E70")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static string GetName(System.Type enumType, object value)
		{
			return null;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x4D17F60", Offset = "0x4D16B60", VA = "0x184D17F60")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static string[] GetNames(System.Type enumType)
		{
			return null;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x4D19150", Offset = "0x4D17D50", VA = "0x184D19150")]
		internal static string[] InternalGetNames(RuntimeType enumType)
		{
			return null;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x4D1B250", Offset = "0x4D19E50", VA = "0x184D1B250")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object ToObject(System.Type enumType, object value)
		{
			return null;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x4D19230", Offset = "0x4D17E30", VA = "0x184D19230")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static bool IsDefined(System.Type enumType, object value)
		{
			return default(bool);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x4D17570", Offset = "0x4D16170", VA = "0x184D17570")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static string Format(System.Type enumType, object value, string format)
		{
			return null;
		}

		// Token: 0x06000E18 RID: 3608
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x4D18560", Offset = "0x4D17160", VA = "0x184D18560")]
		[MethodImpl(4096)]
		private extern object get_value();

		// Token: 0x06000E19 RID: 3609 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x4D18560", Offset = "0x4D17160", VA = "0x184D18560")]
		internal object GetValue()
		{
			return null;
		}

		// Token: 0x06000E1A RID: 3610
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x4D19220", Offset = "0x4D17E20", VA = "0x184D19220")]
		[MethodImpl(4096)]
		private extern bool InternalHasFlag(System.Enum flags);

		// Token: 0x06000E1B RID: 3611
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x4D17E60", Offset = "0x4D16A60", VA = "0x184D17E60")]
		[MethodImpl(4096)]
		private extern int get_hashcode();

		// Token: 0x06000E1C RID: 3612 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x4D17560", Offset = "0x4D16160", VA = "0x184D17560", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x4D17E60", Offset = "0x4D16A60", VA = "0x184D17E60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x4D1BC80", Offset = "0x4D1A880", VA = "0x184D1BC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x4D1BC70", Offset = "0x4D1A870", VA = "0x184D1BC70", Slot = "5")]
		[System.Obsolete("The provider argument is not used. Please use ToString(String).")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0000C900 File Offset: 0x0000AB00
		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x4D17340", Offset = "0x4D15F40", VA = "0x184D17340", Slot = "4")]
		public int CompareTo(object target)
		{
			return 0;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x4D1BD70", Offset = "0x4D1A970", VA = "0x184D1BD70")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x4C6F3A0", Offset = "0x4C6DFA0", VA = "0x184C6F3A0", Slot = "21")]
		[System.Obsolete("The provider argument is not used. Please use ToString().")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x4D18650", Offset = "0x4D17250", VA = "0x184D18650")]
		public bool HasFlag(System.Enum flag)
		{
			return default(bool);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x4D18040", Offset = "0x4D16C40", VA = "0x184D18040", Slot = "6")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x4D19570", Offset = "0x4D18170", VA = "0x184D19570", Slot = "7")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x4D19690", Offset = "0x4D18290", VA = "0x184D19690", Slot = "8")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x4D19B10", Offset = "0x4D18710", VA = "0x184D19B10", Slot = "9")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x4D19600", Offset = "0x4D18200", VA = "0x184D19600", Slot = "10")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x4D19960", Offset = "0x4D18560", VA = "0x184D19960", Slot = "11")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x4D19CA0", Offset = "0x4D188A0", VA = "0x184D19CA0", Slot = "12")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x4D199F0", Offset = "0x4D185F0", VA = "0x184D199F0", Slot = "13")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x4D19D30", Offset = "0x4D18930", VA = "0x184D19D30", Slot = "14")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x4D19A80", Offset = "0x4D18680", VA = "0x184D19A80", Slot = "15")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x4D19DC0", Offset = "0x4D189C0", VA = "0x184D19DC0", Slot = "16")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0000CA38 File Offset: 0x0000AC38
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x4D19BA0", Offset = "0x4D187A0", VA = "0x184D19BA0", Slot = "17")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0000CA50 File Offset: 0x0000AC50
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x4D198D0", Offset = "0x4D184D0", VA = "0x184D198D0", Slot = "18")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x4D19820", Offset = "0x4D18420", VA = "0x184D19820", Slot = "19")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x4D19720", Offset = "0x4D18320", VA = "0x184D19720", Slot = "20")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x4D19C30", Offset = "0x4D18830", VA = "0x184D19C30", Slot = "22")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x4D1B9F0", Offset = "0x4D1A5F0", VA = "0x184D1B9F0")]
		[System.CLSCompliant(false)]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object ToObject(System.Type enumType, sbyte value)
		{
			return null;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x4D19E50", Offset = "0x4D18A50", VA = "0x184D19E50")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object ToObject(System.Type enumType, short value)
		{
			return null;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x4D1A350", Offset = "0x4D18F50", VA = "0x184D1A350")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object ToObject(System.Type enumType, int value)
		{
			return null;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x4D1AAD0", Offset = "0x4D196D0", VA = "0x184D1AAD0")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object ToObject(System.Type enumType, byte value)
		{
			return null;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x4D1AD50", Offset = "0x4D19950", VA = "0x184D1AD50")]
		[System.CLSCompliant(false)]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object ToObject(System.Type enumType, ushort value)
		{
			return null;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x4D1AFD0", Offset = "0x4D19BD0", VA = "0x184D1AFD0")]
		[System.Runtime.InteropServices.ComVisible(true)]
		[System.CLSCompliant(false)]
		public static object ToObject(System.Type enumType, uint value)
		{
			return null;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x4D1A5D0", Offset = "0x4D191D0", VA = "0x184D1A5D0")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public static object ToObject(System.Type enumType, long value)
		{
			return null;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x4D1B770", Offset = "0x4D1A370", VA = "0x184D1B770")]
		[System.Runtime.InteropServices.ComVisible(true)]
		[System.CLSCompliant(false)]
		public static object ToObject(System.Type enumType, ulong value)
		{
			return null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x4D1A850", Offset = "0x4D19450", VA = "0x184D1A850")]
		private static object ToObject(System.Type enumType, char value)
		{
			return null;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x4D1A0D0", Offset = "0x4D18CD0", VA = "0x184D1A0D0")]
		private static object ToObject(System.Type enumType, bool value)
		{
			return null;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected Enum()
		{
		}

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] enumSeperatorCharArray;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		private const string enumSeperator = ", ";

		// Token: 0x02000183 RID: 387
		[Token(Token = "0x2000183")]
		private enum ParseFailureKind
		{
			// Token: 0x04000602 RID: 1538
			[Token(Token = "0x4000602")]
			None,
			// Token: 0x04000603 RID: 1539
			[Token(Token = "0x4000603")]
			Argument,
			// Token: 0x04000604 RID: 1540
			[Token(Token = "0x4000604")]
			ArgumentNull,
			// Token: 0x04000605 RID: 1541
			[Token(Token = "0x4000605")]
			ArgumentWithParameter,
			// Token: 0x04000606 RID: 1542
			[Token(Token = "0x4000606")]
			UnhandledException
		}

		// Token: 0x02000184 RID: 388
		[Token(Token = "0x2000184")]
		private struct EnumResult
		{
			// Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x4D171F0", Offset = "0x4D15DF0", VA = "0x184D171F0")]
			internal void Init(bool canMethodThrow)
			{
			}

			// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x4D17260", Offset = "0x4D15E60", VA = "0x184D17260")]
			internal void SetFailure(System.Exception unhandledException)
			{
			}

			// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x4D17280", Offset = "0x4D15E80", VA = "0x184D17280")]
			internal void SetFailure(System.Enum.ParseFailureKind failure, string failureParameter)
			{
			}

			// Token: 0x06000E43 RID: 3651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x4D172D0", Offset = "0x4D15ED0", VA = "0x184D172D0")]
			internal void SetFailure(System.Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
			{
			}

			// Token: 0x06000E44 RID: 3652 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000E44")]
			[Address(RVA = "0x4D17050", Offset = "0x4D15C50", VA = "0x184D17050")]
			internal System.Exception GetEnumParseException()
			{
				return null;
			}

			// Token: 0x04000607 RID: 1543
			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal object parsedEnum;

			// Token: 0x04000608 RID: 1544
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal bool canThrow;

			// Token: 0x04000609 RID: 1545
			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal System.Enum.ParseFailureKind m_failure;

			// Token: 0x0400060A RID: 1546
			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string m_failureMessageID;

			// Token: 0x0400060B RID: 1547
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string m_failureParameter;

			// Token: 0x0400060C RID: 1548
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal object m_failureMessageFormatArgument;

			// Token: 0x0400060D RID: 1549
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal System.Exception m_innerException;
		}

		// Token: 0x02000185 RID: 389
		[Token(Token = "0x2000185")]
		private class ValuesAndNames
		{
			// Token: 0x06000E45 RID: 3653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E45")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public ValuesAndNames(ulong[] values, string[] names)
			{
			}

			// Token: 0x0400060E RID: 1550
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong[] Values;

			// Token: 0x0400060F RID: 1551
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] Names;
		}
	}
}
