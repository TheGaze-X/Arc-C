using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class MergablePropertyAttribute : Attribute
	{
		// Token: 0x0600092A RID: 2346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public MergablePropertyAttribute(bool allowMerge)
		{
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x170001CB")]
		public bool AllowMerge
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x5123E90", Offset = "0x5122A90", VA = "0x185123E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x5123F50", Offset = "0x5122B50", VA = "0x185123F50", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MergablePropertyAttribute Yes;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x8")]
		public static readonly MergablePropertyAttribute No;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x10")]
		public static readonly MergablePropertyAttribute Default;
	}
}
