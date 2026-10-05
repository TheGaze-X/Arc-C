using System;
using Il2CppDummyDll;
using Torappu.UI.Emoticon;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003409 RID: 13321
	[Token(Token = "0x2003409")]
	public class UICooperateBattleEmoticonPagerPanelPlugin : EmoticonPagerPanelPlugin
	{
		// Token: 0x06015499 RID: 87193 RVA: 0x0008B320 File Offset: 0x00089520
		[Token(Token = "0x6015499")]
		[Address(RVA = "0xDB01C0", Offset = "0xDAEDC0", VA = "0x180DB01C0", Slot = "4")]
		public override float AdjustPagerRectHeight(EmoticonPagerPanelModel model)
		{
			return 0f;
		}

		// Token: 0x0601549A RID: 87194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601549A")]
		[Address(RVA = "0xDB0480", Offset = "0xDAF080", VA = "0x180DB0480")]
		public UICooperateBattleEmoticonPagerPanelPlugin()
		{
		}

		// Token: 0x040196E7 RID: 104167
		[Token(Token = "0x40196E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HorizontalLayoutGroup _themeGroupLayoutGroup;

		// Token: 0x040196E8 RID: 104168
		[Token(Token = "0x40196E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridLayoutGroup _themeEmojiGridLayoutGroup;

		// Token: 0x040196E9 RID: 104169
		[Token(Token = "0x40196E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _pagerPlusPadding;

		// Token: 0x040196EA RID: 104170
		[Token(Token = "0x40196EA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _dotInactivePadding;

		// Token: 0x040196EB RID: 104171
		[Token(Token = "0x40196EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AdjustPagerRectHeight;

		// Token: 0x040196EC RID: 104172
		[Token(Token = "0x40196EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
