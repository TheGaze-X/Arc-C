using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BF5 RID: 31733
	[Token(Token = "0x2007BF5")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorCollectionShowItemDropdownAttribute : Attribute
	{
		// Token: 0x0602C66C RID: 181868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C66C")]
		[Address(RVA = "0x4EEA80", Offset = "0x4ED680", VA = "0x1804EEA80")]
		public InspectorCollectionShowItemDropdownAttribute()
		{
		}

		// Token: 0x04040294 RID: 262804
		[Token(Token = "0x4040294")]
		[FieldOffset(Offset = "0x10")]
		public bool IsCollapsedByDefault;
	}
}
