using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Emoticon;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FE1 RID: 20449
	[Token(Token = "0x2004FE1")]
	public class EnemyDuelEmoticonItemView : EmoticonEmojiItemBaseView
	{
		// Token: 0x0601E5BC RID: 124348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5BC")]
		[Address(RVA = "0x18186C0", Offset = "0x18172C0", VA = "0x1818186C0", Slot = "4")]
		public override void Render(EmojiItemModel model, bool isPopItem, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601E5BD RID: 124349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5BD")]
		[Address(RVA = "0x1818900", Offset = "0x1817500", VA = "0x181818900")]
		private void _PlayClickAnim()
		{
		}

		// Token: 0x0601E5BE RID: 124350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5BE")]
		[Address(RVA = "0x1818A10", Offset = "0x1817610", VA = "0x181818A10")]
		public EnemyDuelEmoticonItemView()
		{
		}

		// Token: 0x0601E5BF RID: 124351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5BF")]
		[Address(RVA = "0xDB0150", Offset = "0xDAED50", VA = "0x180DB0150")]
		private void <>xLuaBaseProxy_Render(EmojiItemModel P0, bool P1, ILoadAsset P2)
		{
		}

		// Token: 0x04028985 RID: 166277
		[Token(Token = "0x4028985")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _emojiIcon;

		// Token: 0x04028986 RID: 166278
		[Token(Token = "0x4028986")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _clickAnim;

		// Token: 0x04028987 RID: 166279
		[Token(Token = "0x4028987")]
		[FieldOffset(Offset = "0x60")]
		private SeqNumSource.Checker m_onSendChecker;

		// Token: 0x04028988 RID: 166280
		[Token(Token = "0x4028988")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_clickTween;

		// Token: 0x04028989 RID: 166281
		[Token(Token = "0x4028989")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402898A RID: 166282
		[Token(Token = "0x402898A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayClickAnim;

		// Token: 0x0402898B RID: 166283
		[Token(Token = "0x402898B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
