using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BF8 RID: 31736
	[Token(Token = "0x2007BF8")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class InspectorKeyWidthAttribute : Attribute
	{
		// Token: 0x0602C66F RID: 181871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C66F")]
		[Address(RVA = "0x2861540", Offset = "0x2860140", VA = "0x182861540")]
		public InspectorKeyWidthAttribute(float widthPercentage)
		{
		}

		// Token: 0x04040295 RID: 262805
		[Token(Token = "0x4040295")]
		[FieldOffset(Offset = "0x10")]
		public float WidthPercentage;
	}
}
