using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BE7 RID: 31719
	[Token(Token = "0x2007BE7")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class InspectorHeaderAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x0602C64A RID: 181834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C64A")]
		[Address(RVA = "0x28614D0", Offset = "0x28600D0", VA = "0x1828614D0")]
		public InspectorHeaderAttribute(string header)
		{
		}

		// Token: 0x170067F8 RID: 26616
		// (get) Token: 0x0602C64B RID: 181835 RVA: 0x000DFF20 File Offset: 0x000DE120
		[Token(Token = "0x170067F8")]
		private double Order
		{
			[Token(Token = "0x602C64B")]
			[Address(RVA = "0x28614A0", Offset = "0x28600A0", VA = "0x1828614A0", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0404027F RID: 262783
		[Token(Token = "0x404027F")]
		[FieldOffset(Offset = "0x10")]
		public double Order;

		// Token: 0x04040280 RID: 262784
		[Token(Token = "0x4040280")]
		[FieldOffset(Offset = "0x18")]
		public string Header;
	}
}
