using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000ECD RID: 3789
	[Token(Token = "0x2000ECD")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class AbnormalImmuneMetaAttribute : Attribute
	{
		// Token: 0x06006BA3 RID: 27555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA3")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public AbnormalImmuneMetaAttribute()
		{
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA4")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public AbnormalImmuneMetaAttribute(AbnormalFlag abnormalFlag)
		{
		}

		// Token: 0x0400500A RID: 20490
		[Token(Token = "0x400500A")]
		[FieldOffset(Offset = "0x10")]
		public AbnormalFlag AbnormalFlag;
	}
}
