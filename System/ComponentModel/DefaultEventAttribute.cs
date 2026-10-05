using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultEventAttribute : Attribute
	{
		// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DefaultEventAttribute(string name)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000203")]
		public string Name
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x5142E30", Offset = "0x5141A30", VA = "0x185142E30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DefaultEventAttribute Default;
	}
}
