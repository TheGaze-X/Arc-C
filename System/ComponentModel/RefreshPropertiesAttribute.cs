using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class RefreshPropertiesAttribute : Attribute
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public RefreshPropertiesAttribute(RefreshProperties refresh)
		{
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x17000312")]
		public RefreshProperties RefreshProperties
		{
			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return RefreshProperties.None;
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x5187760", Offset = "0x5186360", VA = "0x185187760", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x51877F0", Offset = "0x51863F0", VA = "0x1851877F0", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RefreshPropertiesAttribute All;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RefreshPropertiesAttribute Repaint;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x10")]
		public static readonly RefreshPropertiesAttribute Default;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x10")]
		private RefreshProperties refresh;
	}
}
