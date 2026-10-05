using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005477 RID: 21623
	[Token(Token = "0x2005477")]
	public interface IRoguelikeCharCardPlugin : IHotfixable
	{
		// Token: 0x0601FD2B RID: 130347
		[Token(Token = "0x601FD2B")]
		void SetContext(RoguelikeCharCardViewPluginContext context);

		// Token: 0x0601FD2C RID: 130348
		[Token(Token = "0x601FD2C")]
		bool OverrideRaritySprite(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out Sprite sprite);

		// Token: 0x0601FD2D RID: 130349
		[Token(Token = "0x601FD2D")]
		bool OverrideCharNameColor(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out Color color);

		// Token: 0x0601FD2E RID: 130350
		[Token(Token = "0x601FD2E")]
		bool OverrideConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out RoguelikeSelectCharConflictPanel prefab);

		// Token: 0x0601FD2F RID: 130351
		[Token(Token = "0x601FD2F")]
		bool OverrideValid(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out bool valid);

		// Token: 0x0601FD30 RID: 130352
		[Token(Token = "0x601FD30")]
		void RenderConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, RoguelikeSelectCharConflictPanel panel);

		// Token: 0x0601FD31 RID: 130353
		[Token(Token = "0x601FD31")]
		bool DisableUpText(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex);

		// Token: 0x0601FD32 RID: 130354
		[Token(Token = "0x601FD32")]
		bool OverrideCharSelectOutlineSpriteData(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out SpriteRenderData sprite);

		// Token: 0x0601FD33 RID: 130355
		[Token(Token = "0x601FD33")]
		void SetDecoAssets(RoguelikeCharCardViewModel viewModel, ref List<RoguelikeCharCardDecoPanelPluginBase> decoPanels);

		// Token: 0x0601FD34 RID: 130356
		[Token(Token = "0x601FD34")]
		bool OverrideShowUpgradeFlag(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, out bool isShow);
	}
}
