using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000190 RID: 400
	[Token(Token = "0x2000190")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultPropertyAttribute : Attribute
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DefaultPropertyAttribute(string name)
		{
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000204")]
		public string Name
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00005F10 File Offset: 0x00004110
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x5142F30", Offset = "0x5141B30", VA = "0x185142F30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00005F28 File Offset: 0x00004128
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DefaultPropertyAttribute Default;
	}
}
