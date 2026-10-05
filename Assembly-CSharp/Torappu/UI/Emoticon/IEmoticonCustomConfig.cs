using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050D7 RID: 20695
	[Token(Token = "0x20050D7")]
	public interface IEmoticonCustomConfig : IHotfixable
	{
		// Token: 0x0601E99F RID: 125343
		[Token(Token = "0x601E99F")]
		string GetFocusEmoticonThemeId(ValueBundle vb);

		// Token: 0x0601E9A0 RID: 125344
		[Token(Token = "0x601E9A0")]
		void SaveSendEmoticonThemeId(ValueBundle vb, string themeId);

		// Token: 0x0601E9A1 RID: 125345
		[Token(Token = "0x601E9A1")]
		List<string> GetEnabledEmoticonList(ValueBundle vb);

		// Token: 0x0601E9A2 RID: 125346 RVA: 0x000AF0E0 File Offset: 0x000AD2E0
		[Token(Token = "0x601E9A2")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "3")]
		bool KeepEmoticonPanelAfterClick()
		{
			return default(bool);
		}
	}
}
