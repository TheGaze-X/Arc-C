using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BEC RID: 31724
	[Token(Token = "0x2007BEC")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorTextAreaAttribute : Attribute
	{
		// Token: 0x0602C654 RID: 181844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C654")]
		[Address(RVA = "0x2861720", Offset = "0x2860320", VA = "0x182861720")]
		public InspectorTextAreaAttribute()
		{
		}

		// Token: 0x0602C655 RID: 181845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C655")]
		[Address(RVA = "0x28616F0", Offset = "0x28602F0", VA = "0x1828616F0")]
		public InspectorTextAreaAttribute(float height)
		{
		}

		// Token: 0x04040285 RID: 262789
		[Token(Token = "0x4040285")]
		[FieldOffset(Offset = "0x10")]
		public float Height;
	}
}
