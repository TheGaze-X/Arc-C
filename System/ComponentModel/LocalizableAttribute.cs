using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class LocalizableAttribute : Attribute
	{
		// Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public LocalizableAttribute(bool isLocalizable)
		{
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x170001CA")]
		public bool IsLocalizable
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x5123C60", Offset = "0x5122860", VA = "0x185123C60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x5123D20", Offset = "0x5122920", VA = "0x185123D20", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LocalizableAttribute Yes;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x8")]
		public static readonly LocalizableAttribute No;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x10")]
		public static readonly LocalizableAttribute Default;
	}
}
