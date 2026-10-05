using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	public interface IDataChanged
	{
		// Token: 0x06000298 RID: 664
		[Token(Token = "0x6000298")]
		void DataChanged();

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000299 RID: 665
		// (remove) Token: 0x0600029A RID: 666
		[Token(Token = "0x14000003")]
		event GenericEventHandler OnDataChanged;
	}
}
