using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000577 RID: 1399
	[Token(Token = "0x2000577")]
	public class SceneFontHolder : SingletonMonoBehaviour<SceneFontHolder>, ISingletonNotAutoCreate
	{
		// Token: 0x06005BAA RID: 23466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0x1AFAB20", Offset = "0x1AF9720", VA = "0x181AFAB20")]
		public void SetFontPlugin(FontSelect fontSelect)
		{
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0x1AFAD90", Offset = "0x1AF9990", VA = "0x181AFAD90")]
		public void UnRegisterFontPlugin()
		{
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0x1AFABA0", Offset = "0x1AF97A0", VA = "0x181AFABA0")]
		public bool TryGetFont(string name, out Font font)
		{
			return default(bool);
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0x1AFAE00", Offset = "0x1AF9A00", VA = "0x181AFAE00")]
		public SceneFontHolder()
		{
		}

		// Token: 0x04002131 RID: 8497
		[Token(Token = "0x4002131")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FontSelect _fontSel;

		// Token: 0x04002132 RID: 8498
		[Token(Token = "0x4002132")]
		[FieldOffset(Offset = "0x20")]
		private FontSelect m_fontSelectPlugin;

		// Token: 0x04002133 RID: 8499
		[Token(Token = "0x4002133")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetFontPlugin;

		// Token: 0x04002134 RID: 8500
		[Token(Token = "0x4002134")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UnRegisterFontPlugin;

		// Token: 0x04002135 RID: 8501
		[Token(Token = "0x4002135")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetFont;

		// Token: 0x04002136 RID: 8502
		[Token(Token = "0x4002136")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
