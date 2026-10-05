using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ImmutableObjectAttribute : Attribute
	{
		// Token: 0x06000917 RID: 2327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public ImmutableObjectAttribute(bool immutable)
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x170001C8")]
		public bool Immutable
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x5123890", Offset = "0x5122490", VA = "0x185123890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x5123950", Offset = "0x5122550", VA = "0x185123950", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ImmutableObjectAttribute Yes;

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ImmutableObjectAttribute No;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ImmutableObjectAttribute Default;
	}
}
