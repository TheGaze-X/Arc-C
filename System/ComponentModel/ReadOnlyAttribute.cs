using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ReadOnlyAttribute : Attribute
	{
		// Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public ReadOnlyAttribute(bool isReadOnly)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x170001CC")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x5125760", Offset = "0x5124360", VA = "0x185125760", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x5125820", Offset = "0x5124420", VA = "0x185125820", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ReadOnlyAttribute Yes;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ReadOnlyAttribute No;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ReadOnlyAttribute Default;
	}
}
