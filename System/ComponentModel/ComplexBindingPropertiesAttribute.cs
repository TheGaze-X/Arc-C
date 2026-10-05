using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ComplexBindingPropertiesAttribute : Attribute
	{
		// Token: 0x060009D7 RID: 2519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ComplexBindingPropertiesAttribute()
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public ComplexBindingPropertiesAttribute(string dataSource)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public ComplexBindingPropertiesAttribute(string dataSource, string dataMember)
		{
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F5")]
		public string DataSource
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F6")]
		public string DataMember
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x513B020", Offset = "0x5139C20", VA = "0x18513B020", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ComplexBindingPropertiesAttribute Default;
	}
}
