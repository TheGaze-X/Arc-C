using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class DisplayNameAttribute : Attribute
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x5123370", Offset = "0x5121F70", VA = "0x185123370")]
		public DisplayNameAttribute()
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DisplayNameAttribute(string displayName)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BF")]
		public virtual string DisplayName
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C0")]
		protected string DisplayNameValue
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x51230F0", Offset = "0x5121CF0", VA = "0x1851230F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x51225C0", Offset = "0x51211C0", VA = "0x1851225C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x5123220", Offset = "0x5121E20", VA = "0x185123220", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DisplayNameAttribute Default;
	}
}
