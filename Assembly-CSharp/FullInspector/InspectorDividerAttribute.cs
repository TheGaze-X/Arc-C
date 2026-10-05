using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BE6 RID: 31718
	[Token(Token = "0x2007BE6")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class InspectorDividerAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x170067F7 RID: 26615
		// (get) Token: 0x0602C648 RID: 181832 RVA: 0x000DFF08 File Offset: 0x000DE108
		[Token(Token = "0x170067F7")]
		private double Order
		{
			[Token(Token = "0x602C648")]
			[Address(RVA = "0x28614A0", Offset = "0x28600A0", VA = "0x1828614A0", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0602C649 RID: 181833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C649")]
		[Address(RVA = "0x28614B0", Offset = "0x28600B0", VA = "0x1828614B0")]
		public InspectorDividerAttribute()
		{
		}

		// Token: 0x0404027E RID: 262782
		[Token(Token = "0x404027E")]
		[FieldOffset(Offset = "0x10")]
		public double Order;
	}
}
