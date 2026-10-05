using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200394D RID: 14669
	[Token(Token = "0x200394D")]
	public interface IUIStringLocatable : IUILocatable, IHotfixable
	{
		// Token: 0x060172E4 RID: 94948
		[Token(Token = "0x60172E4")]
		bool IsLocatable(string identity);

		// Token: 0x060172E5 RID: 94949
		[Token(Token = "0x60172E5")]
		void LocateTo(string identity, bool immediate = false, [Optional] Action onComplete);

		// Token: 0x060172E6 RID: 94950
		[Token(Token = "0x60172E6")]
		void OnLocatingStateChange(bool locating);

		// Token: 0x060172E7 RID: 94951
		[Token(Token = "0x60172E7")]
		object GetLocationMeta(string identity);

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x060172E8 RID: 94952
		// (remove) Token: 0x060172E9 RID: 94953
		[Token(Token = "0x14000079")]
		event Action metaChange;

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x060172EA RID: 94954
		// (remove) Token: 0x060172EB RID: 94955
		[Token(Token = "0x1400007A")]
		event Action<string> locatedChange;
	}
}
