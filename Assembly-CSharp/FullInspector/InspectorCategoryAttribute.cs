using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BAC RID: 31660
	[Token(Token = "0x2007BAC")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public sealed class InspectorCategoryAttribute : Attribute
	{
		// Token: 0x0602C516 RID: 181526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C516")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public InspectorCategoryAttribute(string category)
		{
		}

		// Token: 0x040401FF RID: 262655
		[Token(Token = "0x40401FF")]
		[FieldOffset(Offset = "0x10")]
		public string Category;
	}
}
