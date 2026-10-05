using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AEF RID: 23279
	[Token(Token = "0x2005AEF")]
	public class LMTGSControllerButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D4F RID: 138575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D4F")]
		[Address(RVA = "0x1C43470", Offset = "0x1C42070", VA = "0x181C43470")]
		public void RenderImage(List<string> onLMGTSList)
		{
		}

		// Token: 0x06021D50 RID: 138576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D50")]
		[Address(RVA = "0x1C43530", Offset = "0x1C42130", VA = "0x181C43530")]
		public LMTGSControllerButton()
		{
		}

		// Token: 0x0402E532 RID: 189746
		[Token(Token = "0x402E532")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _lmgtsOnImg;

		// Token: 0x0402E533 RID: 189747
		[Token(Token = "0x402E533")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _lmgtsOffImg;

		// Token: 0x0402E534 RID: 189748
		[Token(Token = "0x402E534")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderImage;

		// Token: 0x0402E535 RID: 189749
		[Token(Token = "0x402E535")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
