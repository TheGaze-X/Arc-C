using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000ECE RID: 3790
	[Token(Token = "0x2000ECE")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class AbnormalComboImmuneMetaAttribute : Attribute
	{
		// Token: 0x06006BA5 RID: 27557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA5")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public AbnormalComboImmuneMetaAttribute()
		{
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA6")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public AbnormalComboImmuneMetaAttribute(AbnormalCombo abnormalCombo)
		{
		}

		// Token: 0x0400500B RID: 20491
		[Token(Token = "0x400500B")]
		[FieldOffset(Offset = "0x10")]
		public AbnormalCombo AbnormalCombo;
	}
}
