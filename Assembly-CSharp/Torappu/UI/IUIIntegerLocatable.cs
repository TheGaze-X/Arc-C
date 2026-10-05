using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200394C RID: 14668
	[Token(Token = "0x200394C")]
	public interface IUIIntegerLocatable : IUILocatable, IHotfixable
	{
		// Token: 0x060172DC RID: 94940
		[Token(Token = "0x60172DC")]
		bool IsLocatable(int identity);

		// Token: 0x060172DD RID: 94941
		[Token(Token = "0x60172DD")]
		void LocateTo(int identity, bool immediate = false, [Optional] Action onComplete);

		// Token: 0x060172DE RID: 94942
		[Token(Token = "0x60172DE")]
		void OnLocatingStateChange(bool locating);

		// Token: 0x060172DF RID: 94943
		[Token(Token = "0x60172DF")]
		object GetLocationMeta(int identity);

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x060172E0 RID: 94944
		// (remove) Token: 0x060172E1 RID: 94945
		[Token(Token = "0x14000077")]
		event Action metaChange;

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x060172E2 RID: 94946
		// (remove) Token: 0x060172E3 RID: 94947
		[Token(Token = "0x14000078")]
		event Action<int> locatedChange;
	}
}
