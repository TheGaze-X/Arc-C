using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050CA RID: 20682
	[Token(Token = "0x20050CA")]
	public abstract class EmoticonPanelBaseModel : IHotfixable
	{
		// Token: 0x0601E983 RID: 125315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E983")]
		[Address(RVA = "0x183BB40", Offset = "0x183A740", VA = "0x18183BB40", Slot = "4")]
		public virtual void ShowPanelLoadData(IEmoticonCustomConfig customConfig, ValueBundle vb, EmojiSceneType chatSceneType, GOPositionHolder showPos)
		{
		}

		// Token: 0x0601E984 RID: 125316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E984")]
		[Address(RVA = "0x183BA60", Offset = "0x183A660", VA = "0x18183BA60", Slot = "5")]
		public virtual void HidePanel(bool isFastMode)
		{
		}

		// Token: 0x0601E985 RID: 125317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E985")]
		[Address(RVA = "0x183BAE0", Offset = "0x183A6E0", VA = "0x18183BAE0")]
		public void NotifyShowSeqPlus()
		{
		}

		// Token: 0x0601E986 RID: 125318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E986")]
		[Address(RVA = "0x183C190", Offset = "0x183AD90", VA = "0x18183C190")]
		protected EmoticonPanelBaseModel()
		{
		}

		// Token: 0x04028FE8 RID: 167912
		[Token(Token = "0x4028FE8")]
		[FieldOffset(Offset = "0x10")]
		public bool isShowChatPanel;

		// Token: 0x04028FE9 RID: 167913
		[Token(Token = "0x4028FE9")]
		[FieldOffset(Offset = "0x18")]
		public GOPositionHolder showPos;

		// Token: 0x04028FEA RID: 167914
		[Token(Token = "0x4028FEA")]
		[FieldOffset(Offset = "0x20")]
		public int hideFastModeSeqNum;

		// Token: 0x04028FEB RID: 167915
		[Token(Token = "0x4028FEB")]
		[FieldOffset(Offset = "0x24")]
		public int showSeqNum;

		// Token: 0x04028FEC RID: 167916
		[Token(Token = "0x4028FEC")]
		[FieldOffset(Offset = "0x28")]
		public bool isEmpty;

		// Token: 0x04028FED RID: 167917
		[Token(Token = "0x4028FED")]
		[FieldOffset(Offset = "0x30")]
		public string focusThemeId;

		// Token: 0x04028FEE RID: 167918
		[Token(Token = "0x4028FEE")]
		[FieldOffset(Offset = "0x38")]
		public EmojiSceneType chatSceneType;

		// Token: 0x04028FEF RID: 167919
		[Token(Token = "0x4028FEF")]
		[FieldOffset(Offset = "0x40")]
		public ListDict<string, EmoticonThemeItemModel> emoticonThemeDict;

		// Token: 0x04028FF0 RID: 167920
		[Token(Token = "0x4028FF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowPanelLoadData;

		// Token: 0x04028FF1 RID: 167921
		[Token(Token = "0x4028FF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HidePanel;

		// Token: 0x04028FF2 RID: 167922
		[Token(Token = "0x4028FF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyShowSeqPlus;

		// Token: 0x04028FF3 RID: 167923
		[Token(Token = "0x4028FF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
