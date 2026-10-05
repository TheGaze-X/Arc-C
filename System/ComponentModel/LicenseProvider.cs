using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	public abstract class LicenseProvider
	{
		// Token: 0x06000B59 RID: 2905
		[Token(Token = "0x6000B59")]
		public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions);

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected LicenseProvider()
		{
		}
	}
}
