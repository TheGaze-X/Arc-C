using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ListBindableAttribute : Attribute
	{
		// Token: 0x06000B63 RID: 2915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x514A090", Offset = "0x5148C90", VA = "0x18514A090")]
		public ListBindableAttribute(bool listBindable)
		{
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x514A0C0", Offset = "0x5148CC0", VA = "0x18514A0C0")]
		public ListBindableAttribute(BindableSupport flags)
		{
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x1700024B")]
		public bool ListBindable
		{
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x5149E70", Offset = "0x5148A70", VA = "0x185149E70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x5149EF0", Offset = "0x5148AF0", VA = "0x185149EF0", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ListBindableAttribute Yes;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ListBindableAttribute No;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ListBindableAttribute Default;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x10")]
		private bool _isDefault;
	}
}
