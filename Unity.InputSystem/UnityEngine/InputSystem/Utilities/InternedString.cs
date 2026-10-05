using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	public struct InternedString : IEquatable<InternedString>, IComparable<InternedString>
	{
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x170005CD")]
		public int length
		{
			[Token(Token = "0x60014B0")]
			[Address(RVA = "0x5607140", Offset = "0x5605D40", VA = "0x185607140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x5607070", Offset = "0x5605C70", VA = "0x185607070")]
		public InternedString(string text)
		{
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x16AE5D0", Offset = "0x16AD1D0", VA = "0x1816AE5D0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
		public string ToLower()
		{
			return null;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x5606E80", Offset = "0x5605A80", VA = "0x185606E80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x5606FC0", Offset = "0x5605BC0", VA = "0x185606FC0", Slot = "4")]
		public bool Equals(InternedString other)
		{
			return default(bool);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x5606E60", Offset = "0x5605A60", VA = "0x185606E60", Slot = "5")]
		public int CompareTo(InternedString other)
		{
			return 0;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x5606FD0", Offset = "0x5605BD0", VA = "0x185606FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x5607020", Offset = "0x5605C20", VA = "0x185607020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x5607150", Offset = "0x5605D50", VA = "0x185607150")]
		public static bool operator ==(InternedString a, InternedString b)
		{
			return default(bool);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x56072C0", Offset = "0x5605EC0", VA = "0x1856072C0")]
		public static bool operator !=(InternedString a, InternedString b)
		{
			return default(bool);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0000AE18 File Offset: 0x00009018
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x5607200", Offset = "0x5605E00", VA = "0x185607200")]
		public static bool operator ==(InternedString a, string b)
		{
			return default(bool);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x5607370", Offset = "0x5605F70", VA = "0x185607370")]
		public static bool operator !=(InternedString a, string b)
		{
			return default(bool);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x5607170", Offset = "0x5605D70", VA = "0x185607170")]
		public static bool operator ==(string a, InternedString b)
		{
			return default(bool);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x56072E0", Offset = "0x5605EE0", VA = "0x1856072E0")]
		public static bool operator !=(string a, InternedString b)
		{
			return default(bool);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x5607400", Offset = "0x5606000", VA = "0x185607400")]
		public static bool operator <(InternedString left, InternedString right)
		{
			return default(bool);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x5607290", Offset = "0x5605E90", VA = "0x185607290")]
		public static bool operator >(InternedString left, InternedString right)
		{
			return default(bool);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x5607020", Offset = "0x5605C20", VA = "0x185607020")]
		public static implicit operator string(InternedString str)
		{
			return null;
		}

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x0")]
		private readonly string m_StringOriginalCase;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x8")]
		private readonly string m_StringLowerCase;
	}
}
