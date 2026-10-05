using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	[System.Serializable]
	public sealed class String : System.IComparable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<char>, System.IComparable<string>, System.IEquatable<string>, System.IConvertible, System.ICloneable
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4BF2AB0", Offset = "0x4BF16B0", VA = "0x184BF2AB0")]
		[MethodImpl(256)]
		private static bool EqualsHelper(string strA, string strB)
		{
			return default(bool);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x4BEEB30", Offset = "0x4BED730", VA = "0x184BEEB30")]
		[MethodImpl(256)]
		private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
		{
			return 0;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x4BEE9D0", Offset = "0x4BED5D0", VA = "0x184BEE9D0")]
		private static int CompareOrdinalHelper(string strA, string strB)
		{
			return 0;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4BEEEC0", Offset = "0x4BEDAC0", VA = "0x184BEEEC0")]
		public static int Compare(string strA, string strB)
		{
			return 0;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x4BEF5F0", Offset = "0x4BEE1F0", VA = "0x184BEF5F0")]
		public static int Compare(string strA, string strB, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x4BEF760", Offset = "0x4BEE360", VA = "0x184BEF760")]
		public static int Compare(string strA, string strB, System.StringComparison comparisonType)
		{
			return 0;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x4BEFBC0", Offset = "0x4BEE7C0", VA = "0x184BEFBC0")]
		public static int Compare(string strA, string strB, System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options)
		{
			return 0;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x4BEFAE0", Offset = "0x4BEE6E0", VA = "0x184BEFAE0")]
		public static int Compare(string strA, string strB, bool ignoreCase, System.Globalization.CultureInfo culture)
		{
			return 0;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x4BEFCA0", Offset = "0x4BEE8A0", VA = "0x184BEFCA0")]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length)
		{
			return 0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x4BEF600", Offset = "0x4BEE200", VA = "0x184BEF600")]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4BEF110", Offset = "0x4BEDD10", VA = "0x184BEF110")]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, System.StringComparison comparisonType)
		{
			return 0;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x4BEEE80", Offset = "0x4BEDA80", VA = "0x184BEEE80")]
		public static int CompareOrdinal(string strA, string strB)
		{
			return 0;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x4BEEB80", Offset = "0x4BED780", VA = "0x184BEEB80")]
		[MethodImpl(256)]
		internal static int CompareOrdinal(System.ReadOnlySpan<char> strA, System.ReadOnlySpan<char> strB)
		{
			return 0;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x4BEEC20", Offset = "0x4BED820", VA = "0x184BEEC20")]
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			return 0;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x4BEEFA0", Offset = "0x4BEDBA0", VA = "0x184BEEFA0", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x4BEEEC0", Offset = "0x4BEDAC0", VA = "0x184BEEEC0", Slot = "7")]
		public int CompareTo(string strB)
		{
			return 0;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4BF29A0", Offset = "0x4BF15A0", VA = "0x184BF29A0")]
		public bool EndsWith(string value)
		{
			return default(bool);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x4BF2660", Offset = "0x4BF1260", VA = "0x184BF2660")]
		public bool EndsWith(string value, System.StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x4BF2B20", Offset = "0x4BF1720", VA = "0x184BF2B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x4BF3180", Offset = "0x4BF1D80", VA = "0x184BF3180", Slot = "8")]
		public bool Equals(string value)
		{
			return default(bool);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x4BF2BB0", Offset = "0x4BF17B0", VA = "0x184BF2BB0")]
		public bool Equals(string value, System.StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x4BF2AE0", Offset = "0x4BF16E0", VA = "0x184BF2AE0")]
		public static bool Equals(string a, string b)
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x4BF2E90", Offset = "0x4BF1A90", VA = "0x184BF2E90")]
		public static bool Equals(string a, string b, System.StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4BF2AE0", Offset = "0x4BF16E0", VA = "0x184BF2AE0")]
		public static bool operator ==(string a, string b)
		{
			return default(bool);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x4BFAE30", Offset = "0x4BF9A30", VA = "0x184BFAE30")]
		public static bool operator !=(string a, string b)
		{
			return default(bool);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4BF3F60", Offset = "0x4BF2B60", VA = "0x184BF3F60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x4BF3F60", Offset = "0x4BF2B60", VA = "0x184BF3F60")]
		internal int GetLegacyNonRandomizedHashCode()
		{
			return 0;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x4BF9680", Offset = "0x4BF8280", VA = "0x184BF9680")]
		public bool StartsWith(string value)
		{
			return default(bool);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x4BF9360", Offset = "0x4BF7F60", VA = "0x184BF9360")]
		public bool StartsWith(string value, System.StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x4BEE9B0", Offset = "0x4BED5B0", VA = "0x184BEE9B0")]
		internal static void CheckStringComparison(System.StringComparison comparisonType)
		{
		}

		// Token: 0x060002BE RID: 702
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x4BFAAF0", Offset = "0x4BF96F0", VA = "0x184BFAAF0")]
		[MethodImpl(4096)]
		public extern String(char[] value);

		// Token: 0x060002BF RID: 703 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x4BF1D80", Offset = "0x4BF0980", VA = "0x184BF1D80")]
		private static string Ctor(char[] value)
		{
			return null;
		}

		// Token: 0x060002C0 RID: 704
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x4BFAAF0", Offset = "0x4BF96F0", VA = "0x184BFAAF0")]
		[MethodImpl(4096)]
		public extern String(char[] value, int startIndex, int length);

		// Token: 0x060002C1 RID: 705 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x4BF2400", Offset = "0x4BF1000", VA = "0x184BF2400")]
		private static string Ctor(char[] value, int startIndex, int length)
		{
			return null;
		}

		// Token: 0x060002C2 RID: 706
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4BFAAF0", Offset = "0x4BF96F0", VA = "0x184BFAAF0")]
		[System.CLSCompliant(false)]
		[MethodImpl(4096)]
		public unsafe extern String(char* value);

		// Token: 0x060002C3 RID: 707 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x4BF1B30", Offset = "0x4BF0730", VA = "0x184BF1B30")]
		private unsafe static string Ctor(char* ptr)
		{
			return null;
		}

		// Token: 0x060002C4 RID: 708
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4BFAAF0", Offset = "0x4BF96F0", VA = "0x184BFAAF0")]
		[System.CLSCompliant(false)]
		[MethodImpl(4096)]
		public unsafe extern String(char* value, int startIndex, int length);

		// Token: 0x060002C5 RID: 709 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x4BF21B0", Offset = "0x4BF0DB0", VA = "0x184BF21B0")]
		private unsafe static string Ctor(char* ptr, int startIndex, int length)
		{
			return null;
		}

		// Token: 0x060002C6 RID: 710
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x4BFAAF0", Offset = "0x4BF96F0", VA = "0x184BFAAF0")]
		[System.CLSCompliant(false)]
		[MethodImpl(4096)]
		public unsafe extern String(sbyte* value, int startIndex, int length);

		// Token: 0x060002C7 RID: 711 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x4BF18C0", Offset = "0x4BF04C0", VA = "0x184BF18C0")]
		private unsafe static string Ctor(sbyte* value, int startIndex, int length)
		{
			return null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x4BF1200", Offset = "0x4BEFE00", VA = "0x184BF1200")]
		private unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
		{
			return null;
		}

		// Token: 0x060002C9 RID: 713
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x4BFAAF0", Offset = "0x4BF96F0", VA = "0x184BFAAF0")]
		[System.CLSCompliant(false)]
		[MethodImpl(4096)]
		public unsafe extern String(sbyte* value, int startIndex, int length, System.Text.Encoding enc);

		// Token: 0x060002CA RID: 714 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x4BF1F30", Offset = "0x4BF0B30", VA = "0x184BF1F30")]
		private unsafe static string Ctor(sbyte* value, int startIndex, int length, System.Text.Encoding enc)
		{
			return null;
		}

		// Token: 0x060002CB RID: 715
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x4BFAAF0", Offset = "0x4BF96F0", VA = "0x184BFAAF0")]
		[MethodImpl(4096)]
		public extern String(char c, int count);

		// Token: 0x060002CC RID: 716 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x4BF1E20", Offset = "0x4BF0A20", VA = "0x184BF1E20")]
		private static string Ctor(char c, int count)
		{
			return null;
		}

		// Token: 0x060002CD RID: 717
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x4BFAB00", Offset = "0x4BF9700", VA = "0x184BFAB00")]
		[MethodImpl(4096)]
		public extern String(System.ReadOnlySpan<char> value);

		// Token: 0x060002CE RID: 718 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x4BF1CC0", Offset = "0x4BF08C0", VA = "0x184BF1CC0")]
		private static string Ctor(System.ReadOnlySpan<char> value)
		{
			return null;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002CF")]
		public static string Create<TState>(int length, TState state, System.Buffers.SpanAction<char, TState> action)
		{
			return null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x4BFADB0", Offset = "0x4BF99B0", VA = "0x184BFADB0")]
		[MethodImpl(256)]
		public static implicit operator System.ReadOnlySpan<char>(string value)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "26")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x4BF1130", Offset = "0x4BEFD30", VA = "0x184BF1130")]
		public static string Copy(string str)
		{
			return null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x4BF0EC0", Offset = "0x4BEFAC0", VA = "0x184BF0EC0")]
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x4BFA090", Offset = "0x4BF8C90", VA = "0x184BFA090")]
		public char[] ToCharArray()
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x4BF51F0", Offset = "0x4BF3DF0", VA = "0x184BF51F0")]
		[NonVersionable]
		public static bool IsNullOrEmpty(string value)
		{
			return default(bool);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x4BF5210", Offset = "0x4BF3E10", VA = "0x184BF5210")]
		public static bool IsNullOrWhiteSpace(string value)
		{
			return default(bool);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x4BF3FB0", Offset = "0x4BF2BB0", VA = "0x184BF3FB0")]
		internal ref char GetRawStringData()
		{
			return null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x4BF1280", Offset = "0x4BEFE80", VA = "0x184BF1280")]
		internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, System.Text.Encoding encoding)
		{
			return null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4BF11D0", Offset = "0x4BEFDD0", VA = "0x184BF11D0")]
		internal static string CreateFromChar(char c)
		{
			return null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x4BFAF80", Offset = "0x4BF9B80", VA = "0x184BFAF80")]
		internal unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "24")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x4BF3F00", Offset = "0x4BF2B00", VA = "0x184BF3F00")]
		public System.CharEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x4BF9A00", Offset = "0x4BF8600", VA = "0x184BF9A00", Slot = "6")]
		private System.Collections.Generic.IEnumerator<char> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x4BF9A60", Offset = "0x4BF8660", VA = "0x184BF9A60", Slot = "5")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x4BFAE80", Offset = "0x4BF9A80", VA = "0x184BFAE80")]
		internal unsafe static int wcslen(char* ptr)
		{
			return 0;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x4BF3FC0", Offset = "0x4BF2BC0", VA = "0x184BF3FC0", Slot = "9")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x4BF9AC0", Offset = "0x4BF86C0", VA = "0x184BF9AC0", Slot = "10")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x4BF9B80", Offset = "0x4BF8780", VA = "0x184BF9B80", Slot = "11")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x4BF9E40", Offset = "0x4BF8A40", VA = "0x184BF9E40", Slot = "12")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x4BF9B20", Offset = "0x4BF8720", VA = "0x184BF9B20", Slot = "13")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x4BF9D20", Offset = "0x4BF8920", VA = "0x184BF9D20", Slot = "14")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x4BF9F70", Offset = "0x4BF8B70", VA = "0x184BF9F70", Slot = "15")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x4BF9D80", Offset = "0x4BF8980", VA = "0x184BF9D80", Slot = "16")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x4BF9FD0", Offset = "0x4BF8BD0", VA = "0x184BF9FD0", Slot = "17")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x4BF9DE0", Offset = "0x4BF89E0", VA = "0x184BF9DE0", Slot = "18")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x4BFA030", Offset = "0x4BF8C30", VA = "0x184BFA030", Slot = "19")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x4BF9EA0", Offset = "0x4BF8AA0", VA = "0x184BF9EA0", Slot = "20")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x4BF9CC0", Offset = "0x4BF88C0", VA = "0x184BF9CC0", Slot = "21")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x4BF9C40", Offset = "0x4BF8840", VA = "0x184BF9C40", Slot = "22")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x4BF9BE0", Offset = "0x4BF87E0", VA = "0x184BF9BE0", Slot = "23")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x4BF9F00", Offset = "0x4BF8B00", VA = "0x184BF9F00", Slot = "25")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4BF71A0", Offset = "0x4BF5DA0", VA = "0x184BF71A0")]
		public string Normalize(System.Text.NormalizationForm normalizationForm)
		{
			return null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4BF31C0", Offset = "0x4BF1DC0", VA = "0x184BF31C0")]
		private static void FillStringChecked(string dest, int destPos, string src)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4BF0390", Offset = "0x4BEEF90", VA = "0x184BF0390")]
		public static string Concat(object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x4BF0690", Offset = "0x4BEF290", VA = "0x184BF0690")]
		public static string Concat(object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x4BF0970", Offset = "0x4BEF570", VA = "0x184BF0970")]
		public static string Concat(params object[] args)
		{
			return null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x4BF07C0", Offset = "0x4BEF3C0", VA = "0x184BF07C0")]
		public static string Concat(string str0, string str1)
		{
			return null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x4BF0460", Offset = "0x4BEF060", VA = "0x184BF0460")]
		public static string Concat(string str0, string str1, string str2)
		{
			return null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x4BEFE00", Offset = "0x4BEEA00", VA = "0x184BEFE00")]
		public static string Concat(string str0, string str1, string str2, string str3)
		{
			return null;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x4BF00C0", Offset = "0x4BEECC0", VA = "0x184BF00C0")]
		public static string Concat(params string[] values)
		{
			return null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x4BF3AF0", Offset = "0x4BF26F0", VA = "0x184BF3AF0")]
		public static string Format(string format, object arg0)
		{
			return null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x4BF3DB0", Offset = "0x4BF29B0", VA = "0x184BF3DB0")]
		public static string Format(string format, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4BF39A0", Offset = "0x4BF25A0", VA = "0x184BF39A0")]
		public static string Format(string format, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x4BF37F0", Offset = "0x4BF23F0", VA = "0x184BF37F0")]
		public static string Format(string format, params object[] args)
		{
			return null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x4BF3370", Offset = "0x4BF1F70", VA = "0x184BF3370")]
		public static string Format(System.IFormatProvider provider, string format, object arg0)
		{
			return null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x4BF3690", Offset = "0x4BF2290", VA = "0x184BF3690")]
		public static string Format(System.IFormatProvider provider, string format, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x4BF3C40", Offset = "0x4BF2840", VA = "0x184BF3C40")]
		public static string Format(System.IFormatProvider provider, string format, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x4BF34D0", Offset = "0x4BF20D0", VA = "0x184BF34D0")]
		public static string Format(System.IFormatProvider provider, string format, params object[] args)
		{
			return null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x4BF3250", Offset = "0x4BF1E50", VA = "0x184BF3250")]
		private static string FormatHelper(System.IFormatProvider provider, string format, ParamsArray args)
		{
			return null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x4BF4F40", Offset = "0x4BF3B40", VA = "0x184BF4F40")]
		public string Insert(int startIndex, string value)
		{
			return null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x4BF57A0", Offset = "0x4BF43A0", VA = "0x184BF57A0")]
		public static string Join(string separator, params string[] value)
		{
			return null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000305")]
		public static string Join<T>(string separator, System.Collections.Generic.IEnumerable<T> values)
		{
			return null;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x4BF5880", Offset = "0x4BF4480", VA = "0x184BF5880")]
		public static string Join(string separator, System.Collections.Generic.IEnumerable<string> values)
		{
			return null;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x4BF5CF0", Offset = "0x4BF48F0", VA = "0x184BF5CF0")]
		public static string Join(string separator, string[] value, int startIndex, int count)
		{
			return null;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000308")]
		private unsafe static string JoinCore<T>(char* separator, int separatorLength, System.Collections.Generic.IEnumerable<T> values)
		{
			return null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x4BF52C0", Offset = "0x4BF3EC0", VA = "0x184BF52C0")]
		private unsafe static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count)
		{
			return null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x4BF7200", Offset = "0x4BF5E00", VA = "0x184BF7200")]
		public string PadLeft(int totalWidth, char paddingChar)
		{
			return null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x4BF7300", Offset = "0x4BF5F00", VA = "0x184BF7300")]
		public string PadRight(int totalWidth, char paddingChar)
		{
			return null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x4BF7410", Offset = "0x4BF6010", VA = "0x184BF7410")]
		public string Remove(int startIndex, int count)
		{
			return null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x4BF7640", Offset = "0x4BF6240", VA = "0x184BF7640")]
		public string Remove(int startIndex)
		{
			return null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x4BF7B20", Offset = "0x4BF6720", VA = "0x184BF7B20")]
		public string Replace(char oldChar, char newChar)
		{
			return null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x4BF7C00", Offset = "0x4BF6800", VA = "0x184BF7C00")]
		public string Replace(string oldValue, string newValue)
		{
			return null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x4BF7730", Offset = "0x4BF6330", VA = "0x184BF7730")]
		private string ReplaceHelper(int oldValueLength, string newValue, System.ReadOnlySpan<int> indices)
		{
			return null;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x4BF9290", Offset = "0x4BF7E90", VA = "0x184BF9290")]
		public string[] Split(char separator, System.StringSplitOptions options = System.StringSplitOptions.None)
		{
			return null;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x4BF9100", Offset = "0x4BF7D00", VA = "0x184BF9100")]
		public string[] Split(params char[] separator)
		{
			return null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x4BF9180", Offset = "0x4BF7D80", VA = "0x184BF9180")]
		public string[] Split(char[] separator, int count)
		{
			return null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x4BF9200", Offset = "0x4BF7E00", VA = "0x184BF9200")]
		public string[] Split(char[] separator, System.StringSplitOptions options)
		{
			return null;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x4BF7EF0", Offset = "0x4BF6AF0", VA = "0x184BF7EF0")]
		private string[] SplitInternal(System.ReadOnlySpan<char> separators, int count, System.StringSplitOptions options)
		{
			return null;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x4BF90D0", Offset = "0x4BF7CD0", VA = "0x184BF90D0")]
		public string[] Split(string[] separator, System.StringSplitOptions options)
		{
			return null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x4BF8600", Offset = "0x4BF7200", VA = "0x184BF8600")]
		private string[] SplitInternal(string separator, string[] separators, int count, System.StringSplitOptions options)
		{
			return null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x4BF8290", Offset = "0x4BF6E90", VA = "0x184BF8290")]
		private string[] SplitInternal(string separator, int count, System.StringSplitOptions options)
		{
			return null;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x4BF8AD0", Offset = "0x4BF76D0", VA = "0x184BF8AD0")]
		private string[] SplitKeepEmptyEntries(System.ReadOnlySpan<int> sepList, System.ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			return null;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x4BF8D70", Offset = "0x4BF7970", VA = "0x184BF8D70")]
		private string[] SplitOmitEmptyEntries(System.ReadOnlySpan<int> sepList, System.ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			return null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x4BF6EA0", Offset = "0x4BF5AA0", VA = "0x184BF6EA0")]
		private void MakeSeparatorList(System.ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x4BF6A90", Offset = "0x4BF5690", VA = "0x184BF6A90")]
		private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x4BF6C80", Offset = "0x4BF5880", VA = "0x184BF6C80")]
		private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x4BF97A0", Offset = "0x4BF83A0", VA = "0x184BF97A0")]
		public string Substring(int startIndex)
		{
			return null;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x4BF97B0", Offset = "0x4BF83B0", VA = "0x184BF97B0")]
		public string Substring(int startIndex, int length)
		{
			return null;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x4BF5160", Offset = "0x4BF3D60", VA = "0x184BF5160")]
		private string InternalSubString(int startIndex, int length)
		{
			return null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x4BFA240", Offset = "0x4BF8E40", VA = "0x184BFA240")]
		public string ToLower()
		{
			return null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x4BFA300", Offset = "0x4BF8F00", VA = "0x184BFA300")]
		public string ToLower(System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x4BFA180", Offset = "0x4BF8D80", VA = "0x184BFA180")]
		public string ToLowerInvariant()
		{
			return null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x4BFA4A0", Offset = "0x4BF90A0", VA = "0x184BFA4A0")]
		public string ToUpper()
		{
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x4BFA560", Offset = "0x4BF9160", VA = "0x184BFA560")]
		public string ToUpper(System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x4BFA3E0", Offset = "0x4BF8FE0", VA = "0x184BFA3E0")]
		public string ToUpperInvariant()
		{
			return null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x4BFAAB0", Offset = "0x4BF96B0", VA = "0x184BFAAB0")]
		public string Trim()
		{
			return null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x4BFAAC0", Offset = "0x4BF96C0", VA = "0x184BFAAC0")]
		public string Trim(char trimChar)
		{
			return null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x4BFAA60", Offset = "0x4BF9660", VA = "0x184BFAA60")]
		public string Trim(params char[] trimChars)
		{
			return null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x4BFA8D0", Offset = "0x4BF94D0", VA = "0x184BFA8D0")]
		public string TrimStart()
		{
			return null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x4BFA850", Offset = "0x4BF9450", VA = "0x184BFA850")]
		public string TrimStart(char trimChar)
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x4BFA880", Offset = "0x4BF9480", VA = "0x184BFA880")]
		public string TrimStart(params char[] trimChars)
		{
			return null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x4BFA640", Offset = "0x4BF9240", VA = "0x184BFA640")]
		public string TrimEnd()
		{
			return null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x4BFA6A0", Offset = "0x4BF92A0", VA = "0x184BFA6A0")]
		public string TrimEnd(char trimChar)
		{
			return null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x4BFA650", Offset = "0x4BF9250", VA = "0x184BFA650")]
		public string TrimEnd(params char[] trimChars)
		{
			return null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x4BFA8E0", Offset = "0x4BF94E0", VA = "0x184BFA8E0")]
		private string TrimWhiteSpaceHelper(string.TrimType trimType)
		{
			return null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x4BFA6D0", Offset = "0x4BF92D0", VA = "0x184BFA6D0")]
		private unsafe string TrimHelper(char* trimChars, int trimCharsLength, string.TrimType trimType)
		{
			return null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x4BF1820", Offset = "0x4BF0420", VA = "0x184BF1820")]
		private string CreateTrimmedString(int start, int end)
		{
			return null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x4BF0C80", Offset = "0x4BEF880", VA = "0x184BF0C80")]
		public bool Contains(string value)
		{
			return default(bool);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x4BF0E70", Offset = "0x4BEFA70", VA = "0x184BF0E70")]
		public bool Contains(string value, System.StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x4BF0EA0", Offset = "0x4BEFAA0", VA = "0x184BF0EA0")]
		public bool Contains(char value)
		{
			return default(bool);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x4BF4D50", Offset = "0x4BF3950", VA = "0x184BF4D50")]
		public int IndexOf(char value)
		{
			return 0;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x4BF4890", Offset = "0x4BF3490", VA = "0x184BF4890")]
		public int IndexOf(char value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x4BF4D60", Offset = "0x4BF3960", VA = "0x184BF4D60")]
		public int IndexOf(char value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x4BF4370", Offset = "0x4BF2F70", VA = "0x184BF4370")]
		public int IndexOfAny(char[] anyOf)
		{
			return 0;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x4BF3FD0", Offset = "0x4BF2BD0", VA = "0x184BF3FD0")]
		public int IndexOfAny(char[] anyOf, int startIndex)
		{
			return 0;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x4BF3FF0", Offset = "0x4BF2BF0", VA = "0x184BF3FF0")]
		public int IndexOfAny(char[] anyOf, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x4BF43E0", Offset = "0x4BF2FE0", VA = "0x184BF43E0")]
		private int IndexOfAny(char value1, char value2, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x4BF4390", Offset = "0x4BF2F90", VA = "0x184BF4390")]
		private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x4BF4460", Offset = "0x4BF3060", VA = "0x184BF4460")]
		private int IndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x4BF4E80", Offset = "0x4BF3A80", VA = "0x184BF4E80")]
		private unsafe static void InitializeProbabilisticMap(uint* charMap, System.ReadOnlySpan<char> anyOf)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x4BEE960", Offset = "0x4BED560", VA = "0x184BEE960")]
		private static bool ArrayContains(char searchChar, char[] anyOf)
		{
			return default(bool);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x4BF51D0", Offset = "0x4BF3DD0", VA = "0x184BF51D0")]
		private unsafe static bool IsCharBitSet(uint* charMap, byte value)
		{
			return default(bool);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x4BF7ED0", Offset = "0x4BF6AD0", VA = "0x184BF7ED0")]
		private unsafe static void SetCharBit(uint* charMap, byte value)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x4BF4D10", Offset = "0x4BF3910", VA = "0x184BF4D10")]
		public int IndexOf(string value)
		{
			return 0;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x4BF4D30", Offset = "0x4BF3930", VA = "0x184BF4D30")]
		public int IndexOf(string value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x4BF48E0", Offset = "0x4BF34E0", VA = "0x184BF48E0")]
		public int IndexOf(string value, System.StringComparison comparisonType)
		{
			return 0;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x4BF48B0", Offset = "0x4BF34B0", VA = "0x184BF48B0")]
		public int IndexOf(string value, int startIndex, System.StringComparison comparisonType)
		{
			return 0;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x4BF4910", Offset = "0x4BF3510", VA = "0x184BF4910")]
		public int IndexOf(string value, int startIndex, int count, System.StringComparison comparisonType)
		{
			return 0;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x4BF6910", Offset = "0x4BF5510", VA = "0x184BF6910")]
		public int LastIndexOf(char value)
		{
			return 0;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x4BF68C0", Offset = "0x4BF54C0", VA = "0x184BF68C0")]
		public int LastIndexOf(char value, int startIndex)
		{
			return 0;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x4BF6950", Offset = "0x4BF5550", VA = "0x184BF6950")]
		public int LastIndexOf(char value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x4BF5D90", Offset = "0x4BF4990", VA = "0x184BF5D90")]
		public int LastIndexOfAny(char[] anyOf)
		{
			return 0;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x4BF6060", Offset = "0x4BF4C60", VA = "0x184BF6060")]
		public int LastIndexOfAny(char[] anyOf, int startIndex)
		{
			return 0;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x4BF5DB0", Offset = "0x4BF49B0", VA = "0x184BF5DB0")]
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x4BF6080", Offset = "0x4BF4C80", VA = "0x184BF6080")]
		private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x4BF6920", Offset = "0x4BF5520", VA = "0x184BF6920")]
		public int LastIndexOf(string value)
		{
			return 0;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x4BF68E0", Offset = "0x4BF54E0", VA = "0x184BF68E0")]
		public int LastIndexOf(string value, System.StringComparison comparisonType)
		{
			return 0;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x4BF6490", Offset = "0x4BF5090", VA = "0x184BF6490")]
		public int LastIndexOf(string value, int startIndex, int count, System.StringComparison comparisonType)
		{
			return 0;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x17000041")]
		public int Length
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x4BF47A0", Offset = "0x4BF33A0", VA = "0x184BF47A0")]
		internal int IndexOfUnchecked(string value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x4BF45A0", Offset = "0x4BF31A0", VA = "0x184BF45A0")]
		internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x4BF63B0", Offset = "0x4BF4FB0", VA = "0x184BF63B0")]
		internal int LastIndexOfUnchecked(string value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x4BF61C0", Offset = "0x4BF4DC0", VA = "0x184BF61C0")]
		internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x4BF9310", Offset = "0x4BF7F10", VA = "0x184BF9310")]
		internal bool StartsWithOrdinalUnchecked(string value)
		{
			return default(bool);
		}

		// Token: 0x06000358 RID: 856
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x4BF31B0", Offset = "0x4BF1DB0", VA = "0x184BF31B0")]
		[MethodImpl(4096)]
		internal static extern string FastAllocateString(int length);

		// Token: 0x06000359 RID: 857
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x4BF5150", Offset = "0x4BF3D50", VA = "0x184BF5150")]
		[MethodImpl(4096)]
		private static extern string InternalIntern(string str);

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x4BFACC0", Offset = "0x4BF98C0", VA = "0x184BFACC0")]
		private unsafe static void memset(byte* dest, int val, int len)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x4BFACA0", Offset = "0x4BF98A0", VA = "0x184BFACA0")]
		private unsafe static void memcpy(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x4BFAB40", Offset = "0x4BF9740", VA = "0x184BFAB40")]
		internal unsafe static void bzero(byte* dest, int len)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x3745E30", Offset = "0x3744A30", VA = "0x183745E30")]
		internal unsafe static void bzero_aligned_1(byte* dest, int len)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x4BFAB20", Offset = "0x4BF9720", VA = "0x184BFAB20")]
		internal unsafe static void bzero_aligned_2(byte* dest, int len)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x3EE1D70", Offset = "0x3EE0970", VA = "0x183EE1D70")]
		internal unsafe static void bzero_aligned_4(byte* dest, int len)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x4BFAB30", Offset = "0x4BF9730", VA = "0x184BFAB30")]
		internal unsafe static void bzero_aligned_8(byte* dest, int len)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x4BFAC60", Offset = "0x4BF9860", VA = "0x184BFAC60")]
		internal unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x4BFAC70", Offset = "0x4BF9870", VA = "0x184BFAC70")]
		internal unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x4BFAC80", Offset = "0x4BF9880", VA = "0x184BFAC80")]
		internal unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x4BFAC90", Offset = "0x4BF9890", VA = "0x184BFAC90")]
		internal unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x4BF1730", Offset = "0x4BF0330", VA = "0x184BF1730")]
		private unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			return null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x4BF1460", Offset = "0x4BF0060", VA = "0x184BF1460")]
		private unsafe string CreateString(char* value)
		{
			return null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x4BF15D0", Offset = "0x4BF01D0", VA = "0x184BF15D0")]
		private unsafe string CreateString(char* value, int startIndex, int length)
		{
			return null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x4BF1750", Offset = "0x4BF0350", VA = "0x184BF1750")]
		private string CreateString(char[] val, int startIndex, int length)
		{
			return null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x4BF1770", Offset = "0x4BF0370", VA = "0x184BF1770")]
		private string CreateString(char[] val)
		{
			return null;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x4BF1620", Offset = "0x4BF0220", VA = "0x184BF1620")]
		private string CreateString(char c, int count)
		{
			return null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x4BF15F0", Offset = "0x4BF01F0", VA = "0x184BF15F0")]
		private unsafe string CreateString(sbyte* value, int startIndex, int length, System.Text.Encoding enc)
		{
			return null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x4BF1390", Offset = "0x4BEFF90", VA = "0x184BF1390")]
		private string CreateString(System.ReadOnlySpan<char> value)
		{
			return null;
		}

		// Token: 0x17000042 RID: 66
		[Token(Token = "0x17000042")]
		[IndexerName("Chars")]
		public char this[int index]
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x4BFAC10", Offset = "0x4BF9810", VA = "0x184BFAC10")]
			[Intrinsic]
			get
			{
				return '\0';
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x4BF50E0", Offset = "0x4BF3CE0", VA = "0x184BF50E0")]
		public static string Intern(string str)
		{
			return null;
		}

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		private const int StackallocIntBufferSizeLimit = 128;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		private const int PROBABILISTICMAP_SIZE = 8;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[System.NonSerialized]
		private int _stringLength;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[System.NonSerialized]
		private char _firstChar;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string Empty;

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		private enum TrimType
		{
			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			Head,
			// Token: 0x04000277 RID: 631
			[Token(Token = "0x4000277")]
			Tail,
			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			Both
		}

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		[StructLayout(2)]
		private struct ProbabilisticMap
		{
		}
	}
}
