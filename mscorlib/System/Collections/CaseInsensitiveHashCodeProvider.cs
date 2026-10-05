using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005CA RID: 1482
	[Token(Token = "0x20005CA")]
	[System.Obsolete("Please use StringComparer instead.")]
	[System.Serializable]
	public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
	{
		// Token: 0x06002BE3 RID: 11235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x4C5B4A0", Offset = "0x4C5A0A0", VA = "0x184C5B4A0")]
		public CaseInsensitiveHashCodeProvider()
		{
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x4C5B540", Offset = "0x4C5A140", VA = "0x184C5B540")]
		public CaseInsensitiveHashCodeProvider(System.Globalization.CultureInfo culture)
		{
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006D7")]
		public static CaseInsensitiveHashCodeProvider Default
		{
			[Token(Token = "0x6002BE5")]
			[Address(RVA = "0x4C5B5F0", Offset = "0x4C5A1F0", VA = "0x184C5B5F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000181F8 File Offset: 0x000163F8
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x4C5B370", Offset = "0x4C59F70", VA = "0x184C5B370", Slot = "4")]
		public int GetHashCode(object obj)
		{
			return 0;
		}

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.Globalization.CompareInfo _compareInfo;
	}
}
