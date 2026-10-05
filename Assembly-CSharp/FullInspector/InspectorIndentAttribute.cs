using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BB0 RID: 31664
	[Token(Token = "0x2007BB0")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class InspectorIndentAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x170067B9 RID: 26553
		// (get) Token: 0x0602C51A RID: 181530 RVA: 0x000DF8D8 File Offset: 0x000DDAD8
		[Token(Token = "0x170067B9")]
		private double Order
		{
			[Token(Token = "0x602C51A")]
			[Address(RVA = "0x28614A0", Offset = "0x28600A0", VA = "0x1828614A0", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0602C51B RID: 181531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C51B")]
		[Address(RVA = "0x2861520", Offset = "0x2860120", VA = "0x182861520")]
		public InspectorIndentAttribute()
		{
		}

		// Token: 0x04040202 RID: 262658
		[Token(Token = "0x4040202")]
		[FieldOffset(Offset = "0x10")]
		public double Order;
	}
}
