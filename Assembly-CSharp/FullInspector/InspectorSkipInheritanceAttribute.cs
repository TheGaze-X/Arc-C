using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BEB RID: 31723
	[Token(Token = "0x2007BEB")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorSkipInheritanceAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x170067FC RID: 26620
		// (get) Token: 0x0602C652 RID: 181842 RVA: 0x000DFF80 File Offset: 0x000DE180
		[Token(Token = "0x170067FC")]
		private double Order
		{
			[Token(Token = "0x602C652")]
			[Address(RVA = "0x28616E0", Offset = "0x28602E0", VA = "0x1828616E0", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0602C653 RID: 181843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C653")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public InspectorSkipInheritanceAttribute()
		{
		}
	}
}
