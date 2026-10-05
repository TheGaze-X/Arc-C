using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050DE RID: 20702
	[Token(Token = "0x20050DE")]
	public class EmoticonPagerPanelModel : EmoticonPanelBaseModel
	{
		// Token: 0x17004769 RID: 18281
		// (get) Token: 0x0601E9BE RID: 125374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004769")]
		public EmoticonThemeItemModel curEmoticonThemeModel
		{
			[Token(Token = "0x601E9BE")]
			[Address(RVA = "0x183A8B0", Offset = "0x18394B0", VA = "0x18183A8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E9BF RID: 125375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9BF")]
		[Address(RVA = "0x183A570", Offset = "0x1839170", VA = "0x18183A570", Slot = "4")]
		public override void ShowPanelLoadData(IEmoticonCustomConfig customConfig, ValueBundle vb, EmojiSceneType chatSceneType, GOPositionHolder showPos)
		{
		}

		// Token: 0x0601E9C0 RID: 125376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9C0")]
		[Address(RVA = "0x183A4C0", Offset = "0x18390C0", VA = "0x18183A4C0")]
		public void PagerMove(int target)
		{
		}

		// Token: 0x0601E9C1 RID: 125377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9C1")]
		[Address(RVA = "0x183A7C0", Offset = "0x18393C0", VA = "0x18183A7C0")]
		public EmoticonPagerPanelModel()
		{
		}

		// Token: 0x0601E9C2 RID: 125378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9C2")]
		[Address(RVA = "0x183A780", Offset = "0x1839380", VA = "0x18183A780")]
		private void <>xLuaBaseProxy_ShowPanelLoadData(IEmoticonCustomConfig P0, ValueBundle P1, EmojiSceneType P2, GOPositionHolder P3)
		{
		}

		// Token: 0x04029049 RID: 168009
		[Token(Token = "0x4029049")]
		[FieldOffset(Offset = "0x48")]
		public int pagerIndex;

		// Token: 0x0402904A RID: 168010
		[Token(Token = "0x402904A")]
		[FieldOffset(Offset = "0x4C")]
		public bool isOnlyOneTheme;

		// Token: 0x0402904B RID: 168011
		[Token(Token = "0x402904B")]
		[FieldOffset(Offset = "0x50")]
		public int maxThemeEmojiCnt;

		// Token: 0x0402904C RID: 168012
		[Token(Token = "0x402904C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curEmoticonThemeModel;

		// Token: 0x0402904D RID: 168013
		[Token(Token = "0x402904D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowPanelLoadData;

		// Token: 0x0402904E RID: 168014
		[Token(Token = "0x402904E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PagerMove;

		// Token: 0x0402904F RID: 168015
		[Token(Token = "0x402904F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
