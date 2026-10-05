using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005606 RID: 22022
	[Token(Token = "0x2005606")]
	public class RL05RoguelikeCharCardDecoPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x06020515 RID: 132373 RVA: 0x000B55A8 File Offset: 0x000B37A8
		[Token(Token = "0x17004BB2")]
		public SpriteRenderData selectOutlineSpriteData
		{
			[Token(Token = "0x6020515")]
			[Address(RVA = "0x1A6DE50", Offset = "0x1A6CA50", VA = "0x181A6DE50")]
			get
			{
				return default(SpriteRenderData);
			}
		}

		// Token: 0x06020516 RID: 132374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020516")]
		[Address(RVA = "0x1A6DBE0", Offset = "0x1A6C7E0", VA = "0x181A6DBE0", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x06020517 RID: 132375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020517")]
		[Address(RVA = "0x1A6DCC0", Offset = "0x1A6C8C0", VA = "0x181A6DCC0", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020518 RID: 132376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020518")]
		[Address(RVA = "0x1A6DD40", Offset = "0x1A6C940", VA = "0x181A6DD40")]
		public RL05RoguelikeCharCardDecoPluginContext()
		{
		}

		// Token: 0x0402BBDE RID: 179166
		[Token(Token = "0x402BBDE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeCharCardDecoPanelPluginBase[] _decoAssets;

		// Token: 0x0402BBDF RID: 179167
		[Token(Token = "0x402BBDF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _selectOutlineSpriteObject;

		// Token: 0x0402BBE0 RID: 179168
		[Token(Token = "0x402BBE0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _selectOutlineSpriteName;

		// Token: 0x0402BBE1 RID: 179169
		[Token(Token = "0x402BBE1")]
		[FieldOffset(Offset = "0x30")]
		private List<RoguelikeCharCardDecoPanelPluginBase> m_decoAssets;

		// Token: 0x0402BBE2 RID: 179170
		[Token(Token = "0x402BBE2")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0402BBE3 RID: 179171
		[Token(Token = "0x402BBE3")]
		[FieldOffset(Offset = "0x40")]
		private SpriteRenderData m_selectOutlineSpriteData;

		// Token: 0x0402BBE4 RID: 179172
		[Token(Token = "0x402BBE4")]
		[FieldOffset(Offset = "0x80")]
		private string m_topicId;

		// Token: 0x0402BBE5 RID: 179173
		[Token(Token = "0x402BBE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectOutlineSpriteData;

		// Token: 0x0402BBE6 RID: 179174
		[Token(Token = "0x402BBE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402BBE7 RID: 179175
		[Token(Token = "0x402BBE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BBE8 RID: 179176
		[Token(Token = "0x402BBE8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005607 RID: 22023
		[Token(Token = "0x2005607")]
		public class RL05RoguelikeCharCardDecoPlugin : RoguelikeCharCardPlugin<RL05RoguelikeCharCardDecoPluginContext>
		{
			// Token: 0x06020519 RID: 132377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020519")]
			[Address(RVA = "0x1A6E3E0", Offset = "0x1A6CFE0", VA = "0x181A6E3E0", Slot = "21")]
			public override void SetDecoAssets(RoguelikeCharCardViewModel viewModel, ref List<RoguelikeCharCardDecoPanelPluginBase> decoPanels)
			{
			}

			// Token: 0x0602051A RID: 132378 RVA: 0x000B55C0 File Offset: 0x000B37C0
			[Token(Token = "0x602051A")]
			[Address(RVA = "0x1A6DF90", Offset = "0x1A6CB90", VA = "0x181A6DF90", Slot = "19")]
			public override bool DisableUpText(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex)
			{
				return default(bool);
			}

			// Token: 0x0602051B RID: 132379 RVA: 0x000B55D8 File Offset: 0x000B37D8
			[Token(Token = "0x602051B")]
			[Address(RVA = "0x1A6E030", Offset = "0x1A6CC30", VA = "0x181A6E030", Slot = "20")]
			public override bool OverrideCharSelectOutlineSpriteData(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out SpriteRenderData sprite)
			{
				return default(bool);
			}

			// Token: 0x0602051C RID: 132380 RVA: 0x000B55F0 File Offset: 0x000B37F0
			[Token(Token = "0x602051C")]
			[Address(RVA = "0x1A6E2D0", Offset = "0x1A6CED0", VA = "0x181A6E2D0", Slot = "22")]
			public override bool OverrideShowUpgradeFlag(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, out bool isShow)
			{
				return default(bool);
			}

			// Token: 0x0602051D RID: 132381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602051D")]
			[Address(RVA = "0x1A6E520", Offset = "0x1A6D120", VA = "0x181A6E520")]
			public RL05RoguelikeCharCardDecoPlugin()
			{
			}

			// Token: 0x0402BBE9 RID: 179177
			[Token(Token = "0x402BBE9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetDecoAssets;

			// Token: 0x0402BBEA RID: 179178
			[Token(Token = "0x402BBEA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DisableUpText;

			// Token: 0x0402BBEB RID: 179179
			[Token(Token = "0x402BBEB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OverrideCharSelectOutlineSpriteData;

			// Token: 0x0402BBEC RID: 179180
			[Token(Token = "0x402BBEC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideShowUpgradeFlag;

			// Token: 0x0402BBED RID: 179181
			[Token(Token = "0x402BBED")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
