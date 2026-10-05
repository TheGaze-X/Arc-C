using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200546E RID: 21614
	[Token(Token = "0x200546E")]
	[Obsolete("for common char expedition, can use RoguelikeCharCardExpeditionManagePluginContextBase instead")]
	public class RoguelikeCharCardExpeditionPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x0601FCFF RID: 130303 RVA: 0x000B3478 File Offset: 0x000B1678
		[Token(Token = "0x601FCFF")]
		[Address(RVA = "0x19E8BE0", Offset = "0x19E77E0", VA = "0x1819E8BE0")]
		private bool _IsInExpedition(int troopInstId)
		{
			return default(bool);
		}

		// Token: 0x17004A9D RID: 19101
		// (get) Token: 0x0601FD00 RID: 130304 RVA: 0x000B3490 File Offset: 0x000B1690
		[Token(Token = "0x17004A9D")]
		public override RoguelikeCharCardViewPluginPriority pluginPriority
		{
			[Token(Token = "0x601FD00")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
			get
			{
				return RoguelikeCharCardViewPluginPriority.HIGHEST;
			}
		}

		// Token: 0x17004A9E RID: 19102
		// (get) Token: 0x0601FD01 RID: 130305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A9E")]
		public override List<RoguelikeCharCardComparer> additionalComparers
		{
			[Token(Token = "0x601FD01")]
			[Address(RVA = "0x19E8D00", Offset = "0x19E7900", VA = "0x1819E8D00", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FD02 RID: 130306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD02")]
		[Address(RVA = "0x19E87D0", Offset = "0x19E73D0", VA = "0x1819E87D0", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601FD03 RID: 130307 RVA: 0x000B34A8 File Offset: 0x000B16A8
		[Token(Token = "0x601FD03")]
		[Address(RVA = "0x19E8680", Offset = "0x19E7280", VA = "0x1819E8680", Slot = "17")]
		public override bool CheckCharSelectValid(RoguelikeSelectCharViewModel groupModel, RoguelikeCharCardViewModel charModel, out string invalidToast)
		{
			return default(bool);
		}

		// Token: 0x0601FD04 RID: 130308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD04")]
		[Address(RVA = "0x19E8730", Offset = "0x19E7330", VA = "0x1819E8730", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x0601FD05 RID: 130309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD05")]
		[Address(RVA = "0x19E8C40", Offset = "0x19E7840", VA = "0x1819E8C40")]
		public RoguelikeCharCardExpeditionPluginContext()
		{
		}

		// Token: 0x0402ADDC RID: 175580
		[Token(Token = "0x402ADDC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeSelectCharExpeditionConflictPanel _expeditionConflictPrefab;

		// Token: 0x0402ADDD RID: 175581
		[Token(Token = "0x402ADDD")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<int> m_expeditionCharList;

		// Token: 0x0402ADDE RID: 175582
		[Token(Token = "0x402ADDE")]
		[FieldOffset(Offset = "0x28")]
		private string m_expeditionConflictToast;

		// Token: 0x0200546F RID: 21615
		[Token(Token = "0x200546F")]
		public class RoguelikeCharCardExpeditionViewPlugin : RoguelikeCharCardPlugin<RoguelikeCharCardExpeditionPluginContext>
		{
			// Token: 0x0601FD07 RID: 130311 RVA: 0x000B34D8 File Offset: 0x000B16D8
			[Token(Token = "0x601FD07")]
			[Address(RVA = "0x19E9130", Offset = "0x19E7D30", VA = "0x1819E9130", Slot = "16")]
			public override bool OverrideConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out RoguelikeSelectCharConflictPanel prefab)
			{
				return default(bool);
			}

			// Token: 0x0601FD08 RID: 130312 RVA: 0x000B34F0 File Offset: 0x000B16F0
			[Token(Token = "0x601FD08")]
			[Address(RVA = "0x19E9260", Offset = "0x19E7E60", VA = "0x1819E9260", Slot = "17")]
			public override bool OverrideValid(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out bool valid)
			{
				return default(bool);
			}

			// Token: 0x0601FD09 RID: 130313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FD09")]
			[Address(RVA = "0x19E9370", Offset = "0x19E7F70", VA = "0x1819E9370")]
			public RoguelikeCharCardExpeditionViewPlugin()
			{
			}

			// Token: 0x0402ADDF RID: 175583
			[Token(Token = "0x402ADDF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideConflictPanel;

			// Token: 0x0402ADE0 RID: 175584
			[Token(Token = "0x402ADE0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OverrideValid;

			// Token: 0x0402ADE1 RID: 175585
			[Token(Token = "0x402ADE1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
