using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005905 RID: 22789
	[Token(Token = "0x2005905")]
	public class CrisisV2AchievementPage : StateEnginePage, IHotfixable
	{
		// Token: 0x06021360 RID: 136032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021360")]
		[Address(RVA = "0x1B8A840", Offset = "0x1B89440", VA = "0x181B8A840")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x06021361 RID: 136033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021361")]
		[Address(RVA = "0x1B8A980", Offset = "0x1B89580", VA = "0x181B8A980")]
		public CrisisV2AchievementPage()
		{
		}

		// Token: 0x0402D3CB RID: 185291
		[Token(Token = "0x402D3CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0402D3CC RID: 185292
		[Token(Token = "0x402D3CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
