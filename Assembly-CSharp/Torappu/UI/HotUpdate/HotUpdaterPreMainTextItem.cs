using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A92 RID: 19090
	[Token(Token = "0x2004A92")]
	public class HotUpdaterPreMainTextItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601CB0B RID: 117515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB0B")]
		[Address(RVA = "0x162D710", Offset = "0x162C310", VA = "0x18162D710")]
		public void Render(string text)
		{
		}

		// Token: 0x0601CB0C RID: 117516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB0C")]
		[Address(RVA = "0x162D7B0", Offset = "0x162C3B0", VA = "0x18162D7B0")]
		public HotUpdaterPreMainTextItem()
		{
		}

		// Token: 0x04025A87 RID: 154247
		[Token(Token = "0x4025A87")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04025A88 RID: 154248
		[Token(Token = "0x4025A88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025A89 RID: 154249
		[Token(Token = "0x4025A89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
