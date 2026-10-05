using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050C9 RID: 20681
	[Token(Token = "0x20050C9")]
	public abstract class EmoticonEmojiItemBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E980 RID: 125312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E980")]
		[Address(RVA = "0x18395D0", Offset = "0x18381D0", VA = "0x1818395D0", Slot = "4")]
		public virtual void Render(EmojiItemModel model, bool isPopItem, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601E981 RID: 125313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E981")]
		[Address(RVA = "0x1839550", Offset = "0x1838150", VA = "0x181839550")]
		public void OnClickEmojiItem()
		{
		}

		// Token: 0x0601E982 RID: 125314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E982")]
		[Address(RVA = "0x18396E0", Offset = "0x18382E0", VA = "0x1818396E0")]
		protected EmoticonEmojiItemBaseView()
		{
		}

		// Token: 0x04028FDF RID: 167903
		[Token(Token = "0x4028FDF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIButton _button;

		// Token: 0x04028FE0 RID: 167904
		[Token(Token = "0x4028FE0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x04028FE1 RID: 167905
		[Token(Token = "0x4028FE1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04028FE2 RID: 167906
		[Token(Token = "0x4028FE2")]
		[FieldOffset(Offset = "0x30")]
		protected string m_cachedEmojiItemId;

		// Token: 0x04028FE3 RID: 167907
		[Token(Token = "0x4028FE3")]
		[FieldOffset(Offset = "0x38")]
		protected string m_cachedThemeItemId;

		// Token: 0x04028FE4 RID: 167908
		[Token(Token = "0x4028FE4")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string, string> onClickEmojiItem;

		// Token: 0x04028FE5 RID: 167909
		[Token(Token = "0x4028FE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028FE6 RID: 167910
		[Token(Token = "0x4028FE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickEmojiItem;

		// Token: 0x04028FE7 RID: 167911
		[Token(Token = "0x4028FE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
