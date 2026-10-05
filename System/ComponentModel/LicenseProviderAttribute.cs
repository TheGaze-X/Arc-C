using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class LicenseProviderAttribute : Attribute
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x5149C80", Offset = "0x5148880", VA = "0x185149C80")]
		public LicenseProviderAttribute()
		{
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x24BE8D0", Offset = "0x24BD4D0", VA = "0x1824BE8D0")]
		public LicenseProviderAttribute(string typeName)
		{
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public LicenseProviderAttribute(Type type)
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000249")]
		public Type LicenseProvider
		{
			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x5149CB0", Offset = "0x51488B0", VA = "0x185149CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024A")]
		public override object TypeId
		{
			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0x5149D80", Offset = "0x5148980", VA = "0x185149D80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x5149AB0", Offset = "0x51486B0", VA = "0x185149AB0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LicenseProviderAttribute Default;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0x10")]
		private Type _licenseProviderType;

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x18")]
		private string _licenseProviderName;
	}
}
