using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	public sealed class LicenseManager
	{
		// Token: 0x06000B45 RID: 2885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private LicenseManager()
		{
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000247")]
		public static LicenseContext CurrentContext
		{
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x5149660", Offset = "0x5148260", VA = "0x185149660")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x5149920", Offset = "0x5148520", VA = "0x185149920")]
			set
			{
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x17000248")]
		public static LicenseUsageMode UsageMode
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x5149850", Offset = "0x5148450", VA = "0x185149850")]
			get
			{
				return LicenseUsageMode.Runtime;
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x5147E80", Offset = "0x5146A80", VA = "0x185147E80")]
		private static void CacheProvider(Type type, LicenseProvider provider)
		{
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x5148340", Offset = "0x5146F40", VA = "0x185148340")]
		public static object CreateWithContext(Type type, LicenseContext creationContext)
		{
			return null;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x51480F0", Offset = "0x5146CF0", VA = "0x1851480F0")]
		public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args)
		{
			return null;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00006378 File Offset: 0x00004578
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x51483D0", Offset = "0x5146FD0", VA = "0x1851483D0")]
		private static bool GetCachedNoLicenseProvider(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x51485C0", Offset = "0x51471C0", VA = "0x1851485C0")]
		private static LicenseProvider GetCachedProvider(Type type)
		{
			return null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x51484B0", Offset = "0x51470B0", VA = "0x1851484B0")]
		private static LicenseProvider GetCachedProviderInstance(Type providerType)
		{
			return null;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x51486D0", Offset = "0x51472D0", VA = "0x1851486D0")]
		public static bool IsLicensed(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000063A8 File Offset: 0x000045A8
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x5148840", Offset = "0x5147440", VA = "0x185148840")]
		public static bool IsValid(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x51487C0", Offset = "0x51473C0", VA = "0x1851487C0")]
		public static bool IsValid(Type type, object instance, out License license)
		{
			return default(bool);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x5148930", Offset = "0x5147530", VA = "0x185148930")]
		public static void LockContext(object contextUser)
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x5148AB0", Offset = "0x51476B0", VA = "0x185148AB0")]
		public static void UnlockContext(object contextUser)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x5149290", Offset = "0x5147E90", VA = "0x185149290")]
		private static bool ValidateInternal(Type type, object instance, bool allowExceptions, out License license)
		{
			return default(bool);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x5148C30", Offset = "0x5147830", VA = "0x185148C30")]
		private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, out License license, out string licenseKey)
		{
			return default(bool);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x5149460", Offset = "0x5148060", VA = "0x185149460")]
		public static void Validate(Type type)
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x5149340", Offset = "0x5147F40", VA = "0x185149340")]
		public static License Validate(Type type, object instance)
		{
			return null;
		}

		// Token: 0x040006BA RID: 1722
		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object s_selfLock;

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x8")]
		private static LicenseContext s_context;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x10")]
		private static object s_contextLockHolder;

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x18")]
		private static Hashtable s_providers;

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x20")]
		private static Hashtable s_providerInstances;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x28")]
		private static readonly object s_internalSyncObject;
	}
}
