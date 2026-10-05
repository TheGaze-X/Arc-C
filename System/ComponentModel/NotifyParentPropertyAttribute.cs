using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NotifyParentPropertyAttribute : Attribute
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public NotifyParentPropertyAttribute(bool notifyParent)
		{
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x17000310")]
		public bool NotifyParent
		{
			[Token(Token = "0x6000F51")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x5184EB0", Offset = "0x5183AB0", VA = "0x185184EB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x5184F50", Offset = "0x5183B50", VA = "0x185184F50", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NotifyParentPropertyAttribute Yes;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x8")]
		public static readonly NotifyParentPropertyAttribute No;

		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x10")]
		public static readonly NotifyParentPropertyAttribute Default;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x10")]
		private bool notifyParent;
	}
}
