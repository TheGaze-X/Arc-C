using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	internal sealed class RegexFC
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x50FB5B0", Offset = "0x50FA1B0", VA = "0x1850FB5B0")]
		public RegexFC(bool nullable)
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x50FB4B0", Offset = "0x50FA0B0", VA = "0x1850FB4B0")]
		public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x50FB640", Offset = "0x50FA240", VA = "0x1850FB640")]
		public RegexFC(string charClass, bool nullable, bool caseInsensitive)
		{
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x50FB2C0", Offset = "0x50F9EC0", VA = "0x1850FB2C0")]
		public bool AddFC(RegexFC fc, bool concatenate)
		{
			return default(bool);
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00004260 File Offset: 0x00002460
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F5")]
		public bool CaseInsensitive
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x50FB350", Offset = "0x50F9F50", VA = "0x1850FB350")]
		public string GetFirstChars(CultureInfo culture)
		{
			return null;
		}

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x10")]
		private RegexCharClass _cc;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x18")]
		public bool _nullable;
	}
}
