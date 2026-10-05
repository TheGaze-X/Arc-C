using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200352E RID: 13614
	[Token(Token = "0x200352E")]
	public abstract class UICharacterCardScrollAdapter<ViewHolder> : LoopScrollAdapter<ViewHolder, CharacterCardViewModel> where ViewHolder : new()
	{
		// Token: 0x06015B11 RID: 88849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B11")]
		protected void OnCardClick(int chrInstId)
		{
		}

		// Token: 0x06015B12 RID: 88850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B12")]
		protected UICharacterCardScrollAdapter()
		{
		}

		// Token: 0x0401A0EC RID: 106732
		[Token(Token = "0x401A0EC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected UICharacterCardSelectEvent _cardSelectEvent;

		// Token: 0x0401A0ED RID: 106733
		[Token(Token = "0x401A0ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x0401A0EE RID: 106734
		[Token(Token = "0x401A0EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
