using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200055D RID: 1373
	[Token(Token = "0x200055D")]
	[System.Flags]
	public enum CultureTypes
	{
		// Token: 0x040016AB RID: 5803
		[Token(Token = "0x40016AB")]
		NeutralCultures = 1,
		// Token: 0x040016AC RID: 5804
		[Token(Token = "0x40016AC")]
		SpecificCultures = 2,
		// Token: 0x040016AD RID: 5805
		[Token(Token = "0x40016AD")]
		InstalledWin32Cultures = 4,
		// Token: 0x040016AE RID: 5806
		[Token(Token = "0x40016AE")]
		AllCultures = 7,
		// Token: 0x040016AF RID: 5807
		[Token(Token = "0x40016AF")]
		UserCustomCulture = 8,
		// Token: 0x040016B0 RID: 5808
		[Token(Token = "0x40016B0")]
		ReplacementCultures = 16,
		// Token: 0x040016B1 RID: 5809
		[Token(Token = "0x40016B1")]
		[System.Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		WindowsOnlyCultures = 32,
		// Token: 0x040016B2 RID: 5810
		[Token(Token = "0x40016B2")]
		[System.Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		FrameworkCultures = 64
	}
}
