using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	[AttributeUsage(AttributeTargets.All)]
	public class DescriptionAttribute : Attribute
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x5122780", Offset = "0x5121380", VA = "0x185122780")]
		public DescriptionAttribute()
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DescriptionAttribute(string description)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B9")]
		public virtual string Description
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BA")]
		protected string DescriptionValue
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x5122490", Offset = "0x5121090", VA = "0x185122490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x51225C0", Offset = "0x51211C0", VA = "0x1851225C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x5122630", Offset = "0x5121230", VA = "0x185122630", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DescriptionAttribute Default;
	}
}
