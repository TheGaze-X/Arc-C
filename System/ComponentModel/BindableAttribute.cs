using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BindableAttribute : Attribute
	{
		// Token: 0x06000978 RID: 2424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x513A380", Offset = "0x5138F80", VA = "0x18513A380")]
		public BindableAttribute(bool bindable)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x513A300", Offset = "0x5138F00", VA = "0x18513A300")]
		public BindableAttribute(bool bindable, BindingDirection direction)
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x513A340", Offset = "0x5138F40", VA = "0x18513A340")]
		public BindableAttribute(BindableSupport flags)
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x513A3B0", Offset = "0x5138FB0", VA = "0x18513A3B0")]
		public BindableAttribute(BindableSupport flags, BindingDirection direction)
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x170001DA")]
		public bool Bindable
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x170001DB")]
		public BindingDirection Direction
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return BindingDirection.OneWay;
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x513A050", Offset = "0x5138C50", VA = "0x18513A050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x513A0F0", Offset = "0x5138CF0", VA = "0x18513A0F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x513A150", Offset = "0x5138D50", VA = "0x18513A150", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BindableAttribute Yes;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly BindableAttribute No;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly BindableAttribute Default;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x10")]
		private bool _isDefault;
	}
}
