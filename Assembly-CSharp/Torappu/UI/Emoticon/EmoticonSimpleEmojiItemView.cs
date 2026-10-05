using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050E4 RID: 20708
	[Token(Token = "0x20050E4")]
	public class EmoticonSimpleEmojiItemView : EmoticonEmojiItemBaseView
	{
		// Token: 0x0601E9D9 RID: 125401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9D9")]
		[Address(RVA = "0x18614E0", Offset = "0x18600E0", VA = "0x1818614E0", Slot = "4")]
		public override void Render(EmojiItemModel model, bool isPopItem, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601E9DA RID: 125402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9DA")]
		[Address(RVA = "0x18616C0", Offset = "0x18602C0", VA = "0x1818616C0")]
		public EmoticonSimpleEmojiItemView()
		{
		}

		// Token: 0x0601E9DB RID: 125403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9DB")]
		[Address(RVA = "0xDB0150", Offset = "0xDAED50", VA = "0x180DB0150")]
		private void <>xLuaBaseProxy_Render(EmojiItemModel P0, bool P1, ILoadAsset P2)
		{
		}

		// Token: 0x04029083 RID: 168067
		[Token(Token = "0x4029083")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04029084 RID: 168068
		[Token(Token = "0x4029084")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _emojiIcon;

		// Token: 0x04029085 RID: 168069
		[Token(Token = "0x4029085")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _emojiBg;

		// Token: 0x04029086 RID: 168070
		[Token(Token = "0x4029086")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029087 RID: 168071
		[Token(Token = "0x4029087")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
