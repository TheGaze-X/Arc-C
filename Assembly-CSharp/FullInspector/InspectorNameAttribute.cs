using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BB1 RID: 31665
	[Token(Token = "0x2007BB1")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorNameAttribute : Attribute
	{
		// Token: 0x0602C51C RID: 181532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C51C")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public InspectorNameAttribute(string displayName)
		{
		}

		// Token: 0x04040203 RID: 262659
		[Token(Token = "0x4040203")]
		[FieldOffset(Offset = "0x10")]
		public string DisplayName;
	}
}
