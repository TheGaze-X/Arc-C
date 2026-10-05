using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AngleAttribute : Attribute, IListAttribute
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public float Snap
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			set
			{
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4E6590", Offset = "0x4E5190", VA = "0x1804E6590")]
		public AngleAttribute()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4E65A0", Offset = "0x4E51A0", VA = "0x1804E65A0")]
		public AngleAttribute(float snap)
		{
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		private float snap;
	}
}
