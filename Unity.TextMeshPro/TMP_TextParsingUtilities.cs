using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	public class TMP_TextParsingUtilities
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700016D")]
		public static TMP_TextParsingUtilities instance
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x58D3090", Offset = "0x58D1C90", VA = "0x1858D3090")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x58D2D70", Offset = "0x58D1970", VA = "0x1858D2D70")]
		public static int GetHashCode(string s)
		{
			return 0;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x58D2D10", Offset = "0x58D1910", VA = "0x1858D2D10")]
		public static int GetHashCodeCaseSensitive(string s)
		{
			return 0;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x58D2E90", Offset = "0x58D1A90", VA = "0x1858D2E90")]
		public static char ToLowerASCIIFast(char c)
		{
			return '\0';
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x58D2FB0", Offset = "0x58D1BB0", VA = "0x1858D2FB0")]
		public static char ToUpperASCIIFast(char c)
		{
			return '\0';
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x58D2F50", Offset = "0x58D1B50", VA = "0x1858D2F50")]
		public static uint ToUpperASCIIFast(uint c)
		{
			return 0U;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x58D2EF0", Offset = "0x58D1AF0", VA = "0x1858D2EF0")]
		public static uint ToLowerASCIIFast(uint c)
		{
			return 0U;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x58D2E50", Offset = "0x58D1A50", VA = "0x1858D2E50")]
		public static bool IsHighSurrogate(uint c)
		{
			return default(bool);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x58D2E70", Offset = "0x58D1A70", VA = "0x1858D2E70")]
		public static bool IsLowSurrogate(uint c)
		{
			return default(bool);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x58D2D00", Offset = "0x58D1900", VA = "0x1858D2D00")]
		internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
		{
			return 0U;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TMP_TextParsingUtilities()
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_TextParsingUtilities s_Instance;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
	}
}
