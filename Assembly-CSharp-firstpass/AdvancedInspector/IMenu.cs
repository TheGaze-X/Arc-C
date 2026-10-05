using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public interface IMenu : IRuntimeAttribute
	{
		// Token: 0x060002A3 RID: 675
		[Token(Token = "0x60002A3")]
		void Invoke(int index, object instance, object value);

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002A4 RID: 676
		[Token(Token = "0x17000095")]
		string MenuItemName { [Token(Token = "0x60002A4")] get; }
	}
}
