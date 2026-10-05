using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class LookupBindingPropertiesAttribute : Attribute
	{
		// Token: 0x06000B8F RID: 2959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x514AB50", Offset = "0x5149750", VA = "0x18514AB50")]
		public LookupBindingPropertiesAttribute()
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x514ABB0", Offset = "0x51497B0", VA = "0x18514ABB0")]
		public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000259")]
		public string DataSource
		{
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025A")]
		public string DisplayMember
		{
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025B")]
		public string ValueMember
		{
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025C")]
		public string LookupMember
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x514A9D0", Offset = "0x51495D0", VA = "0x18514A9D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LookupBindingPropertiesAttribute Default;
	}
}
