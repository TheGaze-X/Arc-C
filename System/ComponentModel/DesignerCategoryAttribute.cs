using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class DesignerCategoryAttribute : Attribute
	{
		// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x5122D80", Offset = "0x5121980", VA = "0x185122D80")]
		public DesignerCategoryAttribute()
		{
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DesignerCategoryAttribute(string category)
		{
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BC")]
		public string Category
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x5122A70", Offset = "0x5121670", VA = "0x185122A70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x5122AF0", Offset = "0x51216F0", VA = "0x185122AF0", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BD")]
		public override object TypeId
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x5122DE0", Offset = "0x51219E0", VA = "0x185122DE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DesignerCategoryAttribute Component;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DesignerCategoryAttribute Default;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DesignerCategoryAttribute Form;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DesignerCategoryAttribute Generic;
	}
}
