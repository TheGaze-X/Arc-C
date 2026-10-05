using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C15 RID: 19477
	[Token(Token = "0x2004C15")]
	public abstract class HomeSecretaryCardScrollAdapter<ViewHolder> : LoopScrollAdapter<ViewHolder, HomeSecretaryCardViewModel> where ViewHolder : new()
	{
		// Token: 0x0601D425 RID: 119845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D425")]
		protected void OnCardClick(int chrInstId)
		{
		}

		// Token: 0x0601D426 RID: 119846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D426")]
		protected HomeSecretaryCardScrollAdapter()
		{
		}

		// Token: 0x04026768 RID: 157544
		[Token(Token = "0x4026768")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected UICharacterCardSelectEvent _cardSelectEvent;

		// Token: 0x04026769 RID: 157545
		[Token(Token = "0x4026769")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x0402676A RID: 157546
		[Token(Token = "0x402676A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
