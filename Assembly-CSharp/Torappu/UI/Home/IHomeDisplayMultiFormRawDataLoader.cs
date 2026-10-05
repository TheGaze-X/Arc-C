using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B48 RID: 19272
	[Token(Token = "0x2004B48")]
	public interface IHomeDisplayMultiFormRawDataLoader
	{
		// Token: 0x0601D073 RID: 118899
		[Token(Token = "0x601D073")]
		HomeDisplayMultiFormRawData Load(string mainId);

		// Token: 0x0601D074 RID: 118900
		[Token(Token = "0x601D074")]
		bool IsMultiForm(string mainId);

		// Token: 0x0601D075 RID: 118901
		[Token(Token = "0x601D075")]
		HomeMultiFormChangeRule QueryRule(string mainId);
	}
}
