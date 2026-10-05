using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003950 RID: 14672
	[Token(Token = "0x2003950")]
	public interface IUIStringLocateRegistry : IUILocateRegistry, IHotfixable
	{
		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x060172F2 RID: 94962
		[Token(Token = "0x1700376B")]
		IReadOnlyCollection<string> metasObserved { [Token(Token = "0x60172F2")] get; }

		// Token: 0x060172F3 RID: 94963
		[Token(Token = "0x60172F3")]
		void OnMetaChange(string id, object meta);

		// Token: 0x060172F4 RID: 94964
		[Token(Token = "0x60172F4")]
		void OnLocatedChange(string located);

		// Token: 0x060172F5 RID: 94965
		[Token(Token = "0x60172F5")]
		void OnLocatingStateChange(bool locating);

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x060172F6 RID: 94966
		// (remove) Token: 0x060172F7 RID: 94967
		[Token(Token = "0x1400007C")]
		event Action<string> requestLocate;
	}
}
