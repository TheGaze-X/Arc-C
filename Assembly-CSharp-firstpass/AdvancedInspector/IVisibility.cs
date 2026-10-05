using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public interface IVisibility
	{
		// Token: 0x060002B4 RID: 692
		[Token(Token = "0x60002B4")]
		bool IsItemVisible(object[] instances, object[] values);

		// Token: 0x060002B5 RID: 693
		[Token(Token = "0x60002B5")]
		InspectorLevel GetItemLevel(object[] instances, object[] values);

		// Token: 0x060002B6 RID: 694
		[Token(Token = "0x60002B6")]
		int GetItemPriority(object[] instances, object[] values);
	}
}
