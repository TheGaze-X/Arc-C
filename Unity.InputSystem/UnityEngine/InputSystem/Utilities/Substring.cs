using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2000261")]
	internal struct Substring : IComparable<Substring>, IEquatable<Substring>
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x0000BD18 File Offset: 0x00009F18
		[Token(Token = "0x170005E6")]
		public bool isEmpty
		{
			[Token(Token = "0x60015FE")]
			[Address(RVA = "0x5617210", Offset = "0x5615E10", VA = "0x185617210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x56170F0", Offset = "0x5615CF0", VA = "0x1856170F0")]
		public Substring(string str)
		{
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x32B0C50", Offset = "0x32AF850", VA = "0x1832B0C50")]
		public Substring(string str, int index, int length)
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x5617130", Offset = "0x5615D30", VA = "0x185617130")]
		public Substring(string str, int index)
		{
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x5616CE0", Offset = "0x56158E0", VA = "0x185616CE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x0000BD48 File Offset: 0x00009F48
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x5616E50", Offset = "0x5615A50", VA = "0x185616E50")]
		public bool Equals(string other)
		{
			return default(bool);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0000BD60 File Offset: 0x00009F60
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x5616E20", Offset = "0x5615A20", VA = "0x185616E20", Slot = "5")]
		public bool Equals(Substring other)
		{
			return default(bool);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x5616C40", Offset = "0x5615840", VA = "0x185616C40")]
		public bool Equals(InternedString other)
		{
			return default(bool);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x5616B30", Offset = "0x5615730", VA = "0x185616B30", Slot = "4")]
		public int CompareTo(Substring other)
		{
			return 0;
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x5616BF0", Offset = "0x56157F0", VA = "0x185616BF0")]
		public static int Compare(Substring left, Substring right, StringComparison comparison)
		{
			return 0;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x5616FC0", Offset = "0x5615BC0", VA = "0x185616FC0")]
		public bool StartsWith(string str)
		{
			return default(bool);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x5617050", Offset = "0x5615C50", VA = "0x185617050")]
		public string Substr(int index = 0, int length = -1)
		{
			return null;
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x5617090", Offset = "0x5615C90", VA = "0x185617090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x5616F00", Offset = "0x5615B00", VA = "0x185616F00", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x5616E20", Offset = "0x5615A20", VA = "0x185616E20")]
		public static bool operator ==(Substring a, Substring b)
		{
			return default(bool);
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x5617380", Offset = "0x5615F80", VA = "0x185617380")]
		public static bool operator !=(Substring a, Substring b)
		{
			return default(bool);
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x0000BE20 File Offset: 0x0000A020
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x56172A0", Offset = "0x5615EA0", VA = "0x1856172A0")]
		public static bool operator ==(Substring a, InternedString b)
		{
			return default(bool);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0000BE38 File Offset: 0x0000A038
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x56173B0", Offset = "0x5615FB0", VA = "0x1856173B0")]
		public static bool operator !=(Substring a, InternedString b)
		{
			return default(bool);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x5617220", Offset = "0x5615E20", VA = "0x185617220")]
		public static bool operator ==(InternedString a, Substring b)
		{
			return default(bool);
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0000BE68 File Offset: 0x0000A068
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x5617430", Offset = "0x5616030", VA = "0x185617430")]
		public static bool operator !=(InternedString a, Substring b)
		{
			return default(bool);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x5617320", Offset = "0x5615F20", VA = "0x185617320")]
		public static implicit operator Substring(string s)
		{
			return default(Substring);
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x170005E7")]
		public int length
		{
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Token(Token = "0x170005E8")]
		public int index
		{
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005E9 RID: 1513
		[Token(Token = "0x170005E9")]
		public char this[int index]
		{
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x5617180", Offset = "0x5615D80", VA = "0x185617180")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x0")]
		private readonly string m_String;

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x8")]
		private readonly int m_Index;

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0xC")]
		private readonly int m_Length;
	}
}
