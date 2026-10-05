using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C01 RID: 19457
	[Token(Token = "0x2004C01")]
	[CreateAssetMenu(menuName = "Torappu/UI/Business/HomeBg/HomeBackgroundAssetsHub")]
	public class HomeBackgroundAssetsHub : ScriptableObject, IHotfixable
	{
		// Token: 0x0601D3B4 RID: 119732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3B4")]
		[Address(RVA = "0x16C6BE0", Offset = "0x16C57E0", VA = "0x1816C6BE0")]
		public HomeBackgroundAssetsHub()
		{
		}

		// Token: 0x0402668F RID: 157327
		[Token(Token = "0x402668F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> _keys;

		// Token: 0x04026690 RID: 157328
		[Token(Token = "0x4026690")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<HomeBackgroundAssetsPathConfig> _values;

		// Token: 0x04026691 RID: 157329
		[Token(Token = "0x4026691")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
