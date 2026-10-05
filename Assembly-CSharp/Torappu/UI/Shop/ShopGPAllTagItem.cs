using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AEB RID: 23275
	[Token(Token = "0x2005AEB")]
	public class ShopGPAllTagItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D43 RID: 138563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D43")]
		[Address(RVA = "0x1C4B810", Offset = "0x1C4A410", VA = "0x181C4B810")]
		public void Render(bool isAllSelected)
		{
		}

		// Token: 0x06021D44 RID: 138564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D44")]
		[Address(RVA = "0x1C4B760", Offset = "0x1C4A360", VA = "0x181C4B760")]
		public void OnClick()
		{
		}

		// Token: 0x06021D45 RID: 138565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D45")]
		[Address(RVA = "0x1C4B890", Offset = "0x1C4A490", VA = "0x181C4B890")]
		public ShopGPAllTagItem()
		{
		}

		// Token: 0x0402E513 RID: 189715
		[Token(Token = "0x402E513")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _selectedToggle;

		// Token: 0x0402E514 RID: 189716
		[Token(Token = "0x402E514")]
		[FieldOffset(Offset = "0x20")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402E515 RID: 189717
		[Token(Token = "0x402E515")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E516 RID: 189718
		[Token(Token = "0x402E516")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E517 RID: 189719
		[Token(Token = "0x402E517")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
