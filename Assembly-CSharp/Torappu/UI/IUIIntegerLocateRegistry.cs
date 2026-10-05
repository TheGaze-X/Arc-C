using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200394F RID: 14671
	[Token(Token = "0x200394F")]
	public interface IUIIntegerLocateRegistry : IUILocateRegistry, IHotfixable
	{
		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x060172EC RID: 94956
		[Token(Token = "0x1700376A")]
		IReadOnlyCollection<int> metasObserved { [Token(Token = "0x60172EC")] get; }

		// Token: 0x060172ED RID: 94957
		[Token(Token = "0x60172ED")]
		void OnMetaChange(int id, object meta);

		// Token: 0x060172EE RID: 94958
		[Token(Token = "0x60172EE")]
		void OnLocatedChange(int located);

		// Token: 0x060172EF RID: 94959
		[Token(Token = "0x60172EF")]
		void OnLocatingStateChange(bool locating);

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x060172F0 RID: 94960
		// (remove) Token: 0x060172F1 RID: 94961
		[Token(Token = "0x1400007B")]
		event Action<int> requestLocate;
	}
}
