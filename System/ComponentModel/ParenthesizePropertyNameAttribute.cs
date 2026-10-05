using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000229")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ParenthesizePropertyNameAttribute : Attribute
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x5152F00", Offset = "0x5151B00", VA = "0x185152F00")]
		public ParenthesizePropertyNameAttribute()
		{
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public ParenthesizePropertyNameAttribute(bool needParenthesis)
		{
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x17000311")]
		public bool NeedParenthesis
		{
			[Token(Token = "0x6000F58")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x51875C0", Offset = "0x51861C0", VA = "0x1851875C0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x5187650", Offset = "0x5186250", VA = "0x185187650", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ParenthesizePropertyNameAttribute Default;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x10")]
		private bool needParenthesis;
	}
}
