using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BE8 RID: 31720
	[Token(Token = "0x2007BE8")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class InspectorHidePrimaryAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x170067F9 RID: 26617
		// (get) Token: 0x0602C64C RID: 181836 RVA: 0x000DFF38 File Offset: 0x000DE138
		[Token(Token = "0x170067F9")]
		private double Order
		{
			[Token(Token = "0x602C64C")]
			[Address(RVA = "0x2861510", Offset = "0x2860110", VA = "0x182861510", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0602C64D RID: 181837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C64D")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public InspectorHidePrimaryAttribute()
		{
		}
	}
}
