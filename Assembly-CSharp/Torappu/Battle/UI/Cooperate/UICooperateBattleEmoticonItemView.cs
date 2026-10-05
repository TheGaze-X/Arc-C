using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Emoticon;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003408 RID: 13320
	[Token(Token = "0x2003408")]
	public class UICooperateBattleEmoticonItemView : EmoticonEmojiItemBaseView
	{
		// Token: 0x06015496 RID: 87190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015496")]
		[Address(RVA = "0xDB0040", Offset = "0xDAEC40", VA = "0x180DB0040", Slot = "4")]
		public override void Render(EmojiItemModel model, bool isPopItem, ILoadAsset assetLoader)
		{
		}

		// Token: 0x06015497 RID: 87191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015497")]
		[Address(RVA = "0xDB0160", Offset = "0xDAED60", VA = "0x180DB0160")]
		public UICooperateBattleEmoticonItemView()
		{
		}

		// Token: 0x06015498 RID: 87192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015498")]
		[Address(RVA = "0xDB0150", Offset = "0xDAED50", VA = "0x180DB0150")]
		private void <>xLuaBaseProxy_Render(EmojiItemModel P0, bool P1, ILoadAsset P2)
		{
		}

		// Token: 0x040196E4 RID: 104164
		[Token(Token = "0x40196E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _emojiIcon;

		// Token: 0x040196E5 RID: 104165
		[Token(Token = "0x40196E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040196E6 RID: 104166
		[Token(Token = "0x40196E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
