using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class PasswordPropertyTextAttribute : Attribute
	{
		// Token: 0x06000C3C RID: 3132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x5152F00", Offset = "0x5151B00", VA = "0x185152F00")]
		public PasswordPropertyTextAttribute()
		{
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public PasswordPropertyTextAttribute(bool password)
		{
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x17000282")]
		public bool Password
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x5152CE0", Offset = "0x51518E0", VA = "0x185152CE0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x5152D70", Offset = "0x5151970", VA = "0x185152D70", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PasswordPropertyTextAttribute Yes;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x8")]
		public static readonly PasswordPropertyTextAttribute No;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly PasswordPropertyTextAttribute Default;
	}
}
