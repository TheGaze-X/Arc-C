using System;
using Il2CppDummyDll;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058FC RID: 22780
	[Token(Token = "0x20058FC")]
	public interface ISimpleCrossAppShareRemakeModelCollector : ICrossAppShareModelCollector, IHotfixable
	{
		// Token: 0x06021343 RID: 136003
		[Token(Token = "0x6021343")]
		SimpleCrossAppShareRemakeModel GetSimpleModel();
	}
}
