using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BEA RID: 31722
	[Token(Token = "0x2007BEA")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class InspectorMarginAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x0602C650 RID: 181840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C650")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public InspectorMarginAttribute(int margin)
		{
		}

		// Token: 0x170067FB RID: 26619
		// (get) Token: 0x0602C651 RID: 181841 RVA: 0x000DFF68 File Offset: 0x000DE168
		[Token(Token = "0x170067FB")]
		private double Order
		{
			[Token(Token = "0x602C651")]
			[Address(RVA = "0x28615D0", Offset = "0x28601D0", VA = "0x1828615D0", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04040283 RID: 262787
		[Token(Token = "0x4040283")]
		[FieldOffset(Offset = "0x10")]
		public int Margin;

		// Token: 0x04040284 RID: 262788
		[Token(Token = "0x4040284")]
		[FieldOffset(Offset = "0x18")]
		public double Order;
	}
}
