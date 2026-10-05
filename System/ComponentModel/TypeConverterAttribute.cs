using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class TypeConverterAttribute : Attribute
	{
		// Token: 0x06000CF2 RID: 3314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x51750F0", Offset = "0x5173CF0", VA = "0x1851750F0")]
		public TypeConverterAttribute()
		{
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x51471B0", Offset = "0x5145DB0", VA = "0x1851471B0")]
		public TypeConverterAttribute(Type type)
		{
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public TypeConverterAttribute(string typeName)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AD")]
		public string ConverterTypeName
		{
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x5174FD0", Offset = "0x5173BD0", VA = "0x185174FD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TypeConverterAttribute Default;
	}
}
