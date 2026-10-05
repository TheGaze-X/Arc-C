using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Emoticon;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064F2 RID: 25842
	[Token(Token = "0x20064F2")]
	public class AutoChessEmojiItemView : EmoticonEmojiItemBaseView
	{
		// Token: 0x06025228 RID: 152104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025228")]
		[Address(RVA = "0x2023E60", Offset = "0x2022A60", VA = "0x182023E60", Slot = "4")]
		public override void Render(EmojiItemModel model, bool isPopItem, ILoadAsset assetLoader)
		{
		}

		// Token: 0x06025229 RID: 152105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025229")]
		[Address(RVA = "0x20240A0", Offset = "0x2022CA0", VA = "0x1820240A0")]
		private void _PlayClickAnim()
		{
		}

		// Token: 0x0602522A RID: 152106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602522A")]
		[Address(RVA = "0x20241B0", Offset = "0x2022DB0", VA = "0x1820241B0")]
		public AutoChessEmojiItemView()
		{
		}

		// Token: 0x0602522B RID: 152107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602522B")]
		[Address(RVA = "0xDB0150", Offset = "0xDAED50", VA = "0x180DB0150")]
		private void <>xLuaBaseProxy_Render(EmojiItemModel P0, bool P1, ILoadAsset P2)
		{
		}

		// Token: 0x040340FC RID: 213244
		[Token(Token = "0x40340FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _emojiIcon;

		// Token: 0x040340FD RID: 213245
		[Token(Token = "0x40340FD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _clickAnim;

		// Token: 0x040340FE RID: 213246
		[Token(Token = "0x40340FE")]
		[FieldOffset(Offset = "0x60")]
		private SeqNumSource.Checker m_onSendChecker;

		// Token: 0x040340FF RID: 213247
		[Token(Token = "0x40340FF")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_clickTween;

		// Token: 0x04034100 RID: 213248
		[Token(Token = "0x4034100")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034101 RID: 213249
		[Token(Token = "0x4034101")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayClickAnim;

		// Token: 0x04034102 RID: 213250
		[Token(Token = "0x4034102")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
