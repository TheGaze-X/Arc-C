using System;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	[System.Serializable]
	public sealed class Version : System.ICloneable, System.IComparable, System.IComparable<System.Version>, System.IEquatable<System.Version>, ISpanFormattable
	{
		// Token: 0x06000C4D RID: 3149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x4D0C290", Offset = "0x4D0AE90", VA = "0x184D0C290")]
		public Version(int major, int minor, int build, int revision)
		{
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x4D0C100", Offset = "0x4D0AD00", VA = "0x184D0C100")]
		public Version(int major, int minor, int build)
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x4D0BEF0", Offset = "0x4D0AAF0", VA = "0x184D0BEF0")]
		public Version(int major, int minor)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x4D0C000", Offset = "0x4D0AC00", VA = "0x184D0C000")]
		public Version(string version)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x4D0C4E0", Offset = "0x4D0B0E0", VA = "0x184D0C4E0")]
		public Version()
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x4D0C490", Offset = "0x4D0B090", VA = "0x184D0C490")]
		private Version(System.Version version)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x4D0A9D0", Offset = "0x4D095D0", VA = "0x184D0A9D0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0000BD48 File Offset: 0x00009F48
		[Token(Token = "0x17000108")]
		public int Major
		{
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0000BD60 File Offset: 0x00009F60
		[Token(Token = "0x17000109")]
		public int Minor
		{
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x1700010A")]
		public int Build
		{
			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x1700010B")]
		public int Revision
		{
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x4D0AA50", Offset = "0x4D09650", VA = "0x184D0AA50", Slot = "5")]
		public int CompareTo(object version)
		{
			return 0;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x4D0AB40", Offset = "0x4D09740", VA = "0x184D0AB40", Slot = "6")]
		public int CompareTo(System.Version value)
		{
			return 0;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x4D0ABC0", Offset = "0x4D097C0", VA = "0x184D0ABC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x4D0AB80", Offset = "0x4D09780", VA = "0x184D0AB80", Slot = "7")]
		public bool Equals(System.Version obj)
		{
			return default(bool);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x4D0AC60", Offset = "0x4D09860", VA = "0x184D0AC60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x4D0BC60", Offset = "0x4D0A860", VA = "0x184D0BC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x4D0BBD0", Offset = "0x4D0A7D0", VA = "0x184D0BBD0")]
		public string ToString(int fieldCount)
		{
			return null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0000BE20 File Offset: 0x0000A020
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x4D0B7B0", Offset = "0x4D0A3B0", VA = "0x184D0B7B0")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0000BE38 File Offset: 0x0000A038
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x4D0BC90", Offset = "0x4D0A890", VA = "0x184D0BC90")]
		public bool TryFormat(System.Span<char> destination, int fieldCount, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x4D0B7B0", Offset = "0x4D0A3B0", VA = "0x184D0B7B0", Slot = "8")]
		private bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format, System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0000BE68 File Offset: 0x0000A068
		[Token(Token = "0x1700010C")]
		private int DefaultFormatFieldCount
		{
			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x4D0C510", Offset = "0x4D0B110", VA = "0x184D0C510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x4D0B8B0", Offset = "0x4D0A4B0", VA = "0x184D0B8B0")]
		private System.Text.StringBuilder ToCachedStringBuilder(int fieldCount)
		{
			return null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x4D0B6F0", Offset = "0x4D0A2F0", VA = "0x184D0B6F0")]
		public static System.Version Parse(string input)
		{
			return null;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x4D0AC90", Offset = "0x4D09890", VA = "0x184D0AC90")]
		private static System.Version ParseVersion(System.ReadOnlySpan<char> input, bool throwOnFailure)
		{
			return null;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x4D0BDB0", Offset = "0x4D0A9B0", VA = "0x184D0BDB0")]
		private static bool TryParseComponent(System.ReadOnlySpan<char> component, string componentName, bool throwOnFailure, out int parsedComponent)
		{
			return default(bool);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x4D0C530", Offset = "0x4D0B130", VA = "0x184D0C530")]
		public static bool operator ==(System.Version v1, System.Version v2)
		{
			return default(bool);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x4D0C6E0", Offset = "0x4D0B2E0", VA = "0x184D0C6E0")]
		public static bool operator !=(System.Version v1, System.Version v2)
		{
			return default(bool);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x4D0C7F0", Offset = "0x4D0B3F0", VA = "0x184D0C7F0")]
		public static bool operator <(System.Version v1, System.Version v2)
		{
			return default(bool);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x4D0C720", Offset = "0x4D0B320", VA = "0x184D0C720")]
		public static bool operator <=(System.Version v1, System.Version v2)
		{
			return default(bool);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x4D0C640", Offset = "0x4D0B240", VA = "0x184D0C640")]
		public static bool operator >(System.Version v1, System.Version v2)
		{
			return default(bool);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x4D0C570", Offset = "0x4D0B170", VA = "0x184D0C570")]
		public static bool operator >=(System.Version v1, System.Version v2)
		{
			return default(bool);
		}

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _Major;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x14")]
		private readonly int _Minor;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _Build;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int _Revision;
	}
}
