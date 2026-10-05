using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultBindingPropertyAttribute : Attribute
	{
		// Token: 0x06000A29 RID: 2601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public DefaultBindingPropertyAttribute()
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DefaultBindingPropertyAttribute(string name)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000202")]
		public string Name
		{
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x5142D40", Offset = "0x5141940", VA = "0x185142D40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DefaultBindingPropertyAttribute Default;
	}
}
