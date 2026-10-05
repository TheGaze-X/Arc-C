using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	internal interface IGroupManager
	{
		// Token: 0x0600010C RID: 268
		[Token(Token = "0x600010C")]
		void OnOptionSelectionChanged(IGroupBoxOption selectedOption);

		// Token: 0x0600010D RID: 269
		[Token(Token = "0x600010D")]
		void RegisterOption(IGroupBoxOption option);

		// Token: 0x0600010E RID: 270
		[Token(Token = "0x600010E")]
		void UnregisterOption(IGroupBoxOption option);
	}
}
