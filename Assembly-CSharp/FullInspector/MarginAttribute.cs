using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BE9 RID: 31721
	[Token(Token = "0x2007BE9")]
	[Obsolete("Please use [InspectorMargin] instead of [Margin]")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class MarginAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x0602C64E RID: 181838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C64E")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public MarginAttribute(int margin)
		{
		}

		// Token: 0x170067FA RID: 26618
		// (get) Token: 0x0602C64F RID: 181839 RVA: 0x000DFF50 File Offset: 0x000DE150
		[Token(Token = "0x170067FA")]
		private double Order
		{
			[Token(Token = "0x602C64F")]
			[Address(RVA = "0x28615D0", Offset = "0x28601D0", VA = "0x1828615D0", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04040281 RID: 262785
		[Token(Token = "0x4040281")]
		[FieldOffset(Offset = "0x10")]
		public int Margin;

		// Token: 0x04040282 RID: 262786
		[Token(Token = "0x4040282")]
		[FieldOffset(Offset = "0x18")]
		public double Order;
	}
}
