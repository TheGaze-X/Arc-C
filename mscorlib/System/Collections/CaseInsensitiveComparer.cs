using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005C9 RID: 1481
	[Token(Token = "0x20005C9")]
	[System.Serializable]
	public class CaseInsensitiveComparer : IComparer
	{
		// Token: 0x06002BDF RID: 11231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x4C5B110", Offset = "0x4C59D10", VA = "0x184C5B110")]
		public CaseInsensitiveComparer()
		{
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x4C5B1B0", Offset = "0x4C59DB0", VA = "0x184C5B1B0")]
		public CaseInsensitiveComparer(System.Globalization.CultureInfo culture)
		{
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006D6")]
		public static CaseInsensitiveComparer Default
		{
			[Token(Token = "0x6002BE1")]
			[Address(RVA = "0x4C5B260", Offset = "0x4C59E60", VA = "0x184C5B260")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000181E0 File Offset: 0x000163E0
		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0x4C5AE90", Offset = "0x4C59A90", VA = "0x184C5AE90", Slot = "4")]
		public int Compare(object a, object b)
		{
			return 0;
		}

		// Token: 0x0400198D RID: 6541
		[Token(Token = "0x400198D")]
		[FieldOffset(Offset = "0x10")]
		private System.Globalization.CompareInfo _compareInfo;
	}
}
