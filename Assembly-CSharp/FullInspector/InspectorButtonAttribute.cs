using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BAB RID: 31659
	[Token(Token = "0x2007BAB")]
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class InspectorButtonAttribute : Attribute
	{
		// Token: 0x0602C514 RID: 181524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C514")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public InspectorButtonAttribute()
		{
		}

		// Token: 0x0602C515 RID: 181525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C515")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		[Obsolete("Please use InspectorName to set the name of the button")]
		public InspectorButtonAttribute(string displayName)
		{
		}

		// Token: 0x040401FE RID: 262654
		[Token(Token = "0x40401FE")]
		[FieldOffset(Offset = "0x10")]
		[Obsolete("Please use InspectorName to get the custom name of the button")]
		public string DisplayName;
	}
}
