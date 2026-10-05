using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class InheritanceAttribute : Attribute
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x5147080", Offset = "0x5145C80", VA = "0x185147080")]
		public InheritanceAttribute()
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public InheritanceAttribute(InheritanceLevel inheritanceLevel)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00005F58 File Offset: 0x00004158
		[Token(Token = "0x17000206")]
		public InheritanceLevel InheritanceLevel
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return (InheritanceLevel)0;
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x5146D20", Offset = "0x5145920", VA = "0x185146D20", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00005F88 File Offset: 0x00004188
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x5146DC0", Offset = "0x51459C0", VA = "0x185146DC0", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x5146E50", Offset = "0x5145A50", VA = "0x185146E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly InheritanceAttribute Inherited;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly InheritanceAttribute InheritedReadOnly;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly InheritanceAttribute NotInherited;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x18")]
		public static readonly InheritanceAttribute Default;
	}
}
