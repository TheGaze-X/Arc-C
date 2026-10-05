using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AF2 RID: 23282
	[Token(Token = "0x2005AF2")]
	public class LMTGSResourceItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D5A RID: 138586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D5A")]
		[Address(RVA = "0x1C440D0", Offset = "0x1C42CD0", VA = "0x181C440D0")]
		public void Render(LMTGSShopSchedule schedule)
		{
		}

		// Token: 0x06021D5B RID: 138587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D5B")]
		[Address(RVA = "0x1C442D0", Offset = "0x1C42ED0", VA = "0x181C442D0")]
		public LMTGSResourceItem()
		{
		}

		// Token: 0x0402E544 RID: 189764
		[Token(Token = "0x402E544")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconColor;

		// Token: 0x0402E545 RID: 189765
		[Token(Token = "0x402E545")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _resBackColor;

		// Token: 0x0402E546 RID: 189766
		[Token(Token = "0x402E546")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _coinCount;

		// Token: 0x0402E547 RID: 189767
		[Token(Token = "0x402E547")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E548 RID: 189768
		[Token(Token = "0x402E548")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
