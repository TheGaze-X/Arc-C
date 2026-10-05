using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005478 RID: 21624
	[Token(Token = "0x2005478")]
	public abstract class RoguelikeCharCardPlugin<TContext> : IRoguelikeCharCardPlugin, IHotfixable where TContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x0601FD35 RID: 130357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD35")]
		public void SetContext(RoguelikeCharCardViewPluginContext context)
		{
		}

		// Token: 0x0601FD36 RID: 130358 RVA: 0x000B3658 File Offset: 0x000B1858
		[Token(Token = "0x601FD36")]
		public virtual bool OverrideRaritySprite(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x0601FD37 RID: 130359 RVA: 0x000B3670 File Offset: 0x000B1870
		[Token(Token = "0x601FD37")]
		public virtual bool OverrideCharNameColor(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out Color color)
		{
			return default(bool);
		}

		// Token: 0x0601FD38 RID: 130360 RVA: 0x000B3688 File Offset: 0x000B1888
		[Token(Token = "0x601FD38")]
		public virtual bool OverrideConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out RoguelikeSelectCharConflictPanel prefab)
		{
			return default(bool);
		}

		// Token: 0x0601FD39 RID: 130361 RVA: 0x000B36A0 File Offset: 0x000B18A0
		[Token(Token = "0x601FD39")]
		public virtual bool OverrideValid(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out bool valid)
		{
			return default(bool);
		}

		// Token: 0x0601FD3A RID: 130362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD3A")]
		public virtual void RenderConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, RoguelikeSelectCharConflictPanel panel)
		{
		}

		// Token: 0x0601FD3B RID: 130363 RVA: 0x000B36B8 File Offset: 0x000B18B8
		[Token(Token = "0x601FD3B")]
		public virtual bool DisableUpText(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex)
		{
			return default(bool);
		}

		// Token: 0x0601FD3C RID: 130364 RVA: 0x000B36D0 File Offset: 0x000B18D0
		[Token(Token = "0x601FD3C")]
		public virtual bool OverrideCharSelectOutlineSpriteData(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out SpriteRenderData sprite)
		{
			return default(bool);
		}

		// Token: 0x0601FD3D RID: 130365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD3D")]
		public virtual void SetDecoAssets(RoguelikeCharCardViewModel viewModel, ref List<RoguelikeCharCardDecoPanelPluginBase> decoPanels)
		{
		}

		// Token: 0x0601FD3E RID: 130366 RVA: 0x000B36E8 File Offset: 0x000B18E8
		[Token(Token = "0x601FD3E")]
		public virtual bool OverrideShowUpgradeFlag(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, out bool isShow)
		{
			return default(bool);
		}

		// Token: 0x0601FD3F RID: 130367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD3F")]
		protected RoguelikeCharCardPlugin()
		{
		}

		// Token: 0x0402AE02 RID: 175618
		[Token(Token = "0x402AE02")]
		[FieldOffset(Offset = "0x0")]
		protected TContext context;

		// Token: 0x0402AE03 RID: 175619
		[Token(Token = "0x402AE03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetContext;

		// Token: 0x0402AE04 RID: 175620
		[Token(Token = "0x402AE04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideRaritySprite;

		// Token: 0x0402AE05 RID: 175621
		[Token(Token = "0x402AE05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideCharNameColor;

		// Token: 0x0402AE06 RID: 175622
		[Token(Token = "0x402AE06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideConflictPanel;

		// Token: 0x0402AE07 RID: 175623
		[Token(Token = "0x402AE07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideValid;

		// Token: 0x0402AE08 RID: 175624
		[Token(Token = "0x402AE08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderConflictPanel;

		// Token: 0x0402AE09 RID: 175625
		[Token(Token = "0x402AE09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DisableUpText;

		// Token: 0x0402AE0A RID: 175626
		[Token(Token = "0x402AE0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideCharSelectOutlineSpriteData;

		// Token: 0x0402AE0B RID: 175627
		[Token(Token = "0x402AE0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetDecoAssets;

		// Token: 0x0402AE0C RID: 175628
		[Token(Token = "0x402AE0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideShowUpgradeFlag;

		// Token: 0x0402AE0D RID: 175629
		[Token(Token = "0x402AE0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
