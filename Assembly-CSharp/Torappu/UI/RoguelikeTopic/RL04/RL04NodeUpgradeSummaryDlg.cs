using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.RL04;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046B4 RID: 18100
	[Token(Token = "0x20046B4")]
	public class RL04NodeUpgradeSummaryDlg : UICompDialog<RL04NodeUpgradeSummaryDlg.Input>, INodeConfigFetcher
	{
		// Token: 0x0601B739 RID: 112441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B739")]
		[Address(RVA = "0x14CA9E0", Offset = "0x14C95E0", VA = "0x1814CA9E0", Slot = "18")]
		protected override void OnRender(RL04NodeUpgradeSummaryDlg.Input input)
		{
		}

		// Token: 0x0601B73A RID: 112442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B73A")]
		[Address(RVA = "0x14CB140", Offset = "0x14C9D40", VA = "0x1814CB140")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B73B RID: 112443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B73B")]
		[Address(RVA = "0x14CAF60", Offset = "0x14C9B60", VA = "0x1814CAF60")]
		private void _EventOnBtnTypeClick(RoguelikeEventType nodeType)
		{
		}

		// Token: 0x0601B73C RID: 112444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B73C")]
		[Address(RVA = "0x14CAEA0", Offset = "0x14C9AA0", VA = "0x1814CAEA0")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x0601B73D RID: 112445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B73D")]
		[Address(RVA = "0x14CA7F0", Offset = "0x14C93F0", VA = "0x1814CA7F0", Slot = "19")]
		public RL04NodeUpgradeConfig GetNodeConfig(RoguelikeEventType type)
		{
			return null;
		}

		// Token: 0x0601B73E RID: 112446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B73E")]
		[Address(RVA = "0x14CB2C0", Offset = "0x14C9EC0", VA = "0x1814CB2C0")]
		public RL04NodeUpgradeSummaryDlg()
		{
		}

		// Token: 0x04023888 RID: 145544
		[Token(Token = "0x4023888")]
		private const string GUIDE_SUB_SIGNAL = "rl04_node_upgrade";

		// Token: 0x04023889 RID: 145545
		[Token(Token = "0x4023889")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RL04NodeUpgradeSummaryView _view;

		// Token: 0x0402388A RID: 145546
		[Token(Token = "0x402388A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402388B RID: 145547
		[Token(Token = "0x402388B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIGuidebookTrigger _guideBookTrigger;

		// Token: 0x0402388C RID: 145548
		[Token(Token = "0x402388C")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402388D RID: 145549
		[Token(Token = "0x402388D")]
		[FieldOffset(Offset = "0x90")]
		private string m_topicId;

		// Token: 0x0402388E RID: 145550
		[Token(Token = "0x402388E")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, RL04NodeUpgradeConfig> m_nodeConfigDict;

		// Token: 0x0402388F RID: 145551
		[Token(Token = "0x402388F")]
		[FieldOffset(Offset = "0xA0")]
		private RL04NodeUpgradeSummaryProp m_prop;

		// Token: 0x04023890 RID: 145552
		[Token(Token = "0x4023890")]
		[FieldOffset(Offset = "0xA8")]
		private CommonTopMenu m_topMenu;

		// Token: 0x04023891 RID: 145553
		[Token(Token = "0x4023891")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04023892 RID: 145554
		[Token(Token = "0x4023892")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023893 RID: 145555
		[Token(Token = "0x4023893")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnBtnTypeClick;

		// Token: 0x04023894 RID: 145556
		[Token(Token = "0x4023894")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04023895 RID: 145557
		[Token(Token = "0x4023895")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetNodeConfig;

		// Token: 0x04023896 RID: 145558
		[Token(Token = "0x4023896")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046B5 RID: 18101
		[Token(Token = "0x20046B5")]
		public class Input
		{
			// Token: 0x0601B73F RID: 112447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B73F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04023897 RID: 145559
			[Token(Token = "0x4023897")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}
	}
}
