using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B4F RID: 19279
	[Token(Token = "0x2004B4F")]
	public interface IMultiFormHandler : IHotfixable
	{
		// Token: 0x0601D087 RID: 118919
		[Token(Token = "0x601D087")]
		void OnMultiFormChanged(HomeDisplayMultiFormItemModel formModel, bool shouldReset);
	}
}
