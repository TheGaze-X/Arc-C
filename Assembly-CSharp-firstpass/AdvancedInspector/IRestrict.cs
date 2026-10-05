using System;
using System.Collections;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public interface IRestrict
	{
		// Token: 0x060002A8 RID: 680
		[Token(Token = "0x60002A8")]
		IList GetRestricted(object[] instances, object[] values);

		// Token: 0x060002A9 RID: 681
		[Token(Token = "0x60002A9")]
		RestrictDisplay GetDisplay(object[] instances, object[] values);

		// Token: 0x060002AA RID: 682
		[Token(Token = "0x60002AA")]
		int GetItemsPerRow(object[] instances, object[] values);
	}
}
