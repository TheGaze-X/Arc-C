using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	public class LicenseContext : IServiceProvider
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x17000246")]
		public virtual LicenseUsageMode UsageMode
		{
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return LicenseUsageMode.Runtime;
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			return null;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public virtual object GetService(Type type)
		{
			return null;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void SetSavedLicenseKey(Type type, string key)
		{
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LicenseContext()
		{
		}
	}
}
