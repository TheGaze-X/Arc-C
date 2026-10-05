using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BB7 RID: 31671
	[Token(Token = "0x2007BB7")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorTooltipAttribute : Attribute
	{
		// Token: 0x0602C523 RID: 181539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C523")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public InspectorTooltipAttribute(string tooltip)
		{
		}

		// Token: 0x04040207 RID: 262663
		[Token(Token = "0x4040207")]
		[FieldOffset(Offset = "0x10")]
		public string Tooltip;
	}
}
