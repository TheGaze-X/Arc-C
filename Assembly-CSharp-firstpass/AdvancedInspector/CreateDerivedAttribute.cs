using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class CreateDerivedAttribute : Attribute, IListAttribute
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public bool HideClassName
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public CreateDerivedAttribute()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public CreateDerivedAttribute(bool hideClassName)
		{
		}

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x10")]
		private bool hideClassName;
	}
}
