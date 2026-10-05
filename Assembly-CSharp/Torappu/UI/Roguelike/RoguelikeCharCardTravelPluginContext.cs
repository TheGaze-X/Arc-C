using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005475 RID: 21621
	[Token(Token = "0x2005475")]
	public class RoguelikeCharCardTravelPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x0601FD1D RID: 130333 RVA: 0x000B3598 File Offset: 0x000B1798
		[Token(Token = "0x601FD1D")]
		[Address(RVA = "0x19EA800", Offset = "0x19E9400", VA = "0x1819EA800")]
		private bool _IsInTravel(int troopInstId)
		{
			return default(bool);
		}

		// Token: 0x17004AA0 RID: 19104
		// (get) Token: 0x0601FD1E RID: 130334 RVA: 0x000B35B0 File Offset: 0x000B17B0
		[Token(Token = "0x17004AA0")]
		public override RoguelikeCharCardViewPluginPriority pluginPriority
		{
			[Token(Token = "0x601FD1E")]
			[Address(RVA = "0x19EAB00", Offset = "0x19E9700", VA = "0x1819EAB00", Slot = "15")]
			get
			{
				return RoguelikeCharCardViewPluginPriority.HIGHEST;
			}
		}

		// Token: 0x17004AA1 RID: 19105
		// (get) Token: 0x0601FD1F RID: 130335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AA1")]
		public override List<RoguelikeCharCardComparer> additionalComparers
		{
			[Token(Token = "0x601FD1F")]
			[Address(RVA = "0x19EA9A0", Offset = "0x19E95A0", VA = "0x1819EA9A0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FD20 RID: 130336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD20")]
		[Address(RVA = "0x19EA3C0", Offset = "0x19E8FC0", VA = "0x1819EA3C0", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601FD21 RID: 130337 RVA: 0x000B35C8 File Offset: 0x000B17C8
		[Token(Token = "0x601FD21")]
		[Address(RVA = "0x19EA210", Offset = "0x19E8E10", VA = "0x1819EA210", Slot = "17")]
		public override bool CheckCharSelectValid(RoguelikeSelectCharViewModel groupModel, RoguelikeCharCardViewModel charModel, out string invalidToast)
		{
			return default(bool);
		}

		// Token: 0x0601FD22 RID: 130338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD22")]
		[Address(RVA = "0x19EA2E0", Offset = "0x19E8EE0", VA = "0x1819EA2E0", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x0601FD23 RID: 130339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD23")]
		[Address(RVA = "0x19EA8A0", Offset = "0x19E94A0", VA = "0x1819EA8A0")]
		public RoguelikeCharCardTravelPluginContext()
		{
		}

		// Token: 0x0601FD25 RID: 130341 RVA: 0x000B35F8 File Offset: 0x000B17F8
		[Token(Token = "0x601FD25")]
		[Address(RVA = "0x19EA700", Offset = "0x19E9300", VA = "0x1819EA700")]
		private RoguelikeCharCardViewPluginPriority <>xLuaBaseProxy_get_pluginPriority()
		{
			return RoguelikeCharCardViewPluginPriority.HIGHEST;
		}

		// Token: 0x0601FD26 RID: 130342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD26")]
		[Address(RVA = "0x19E7FF0", Offset = "0x19E6BF0", VA = "0x1819E7FF0")]
		private List<RoguelikeCharCardComparer> <>xLuaBaseProxy_get_additionalComparers()
		{
			return null;
		}

		// Token: 0x0601FD27 RID: 130343 RVA: 0x000B3610 File Offset: 0x000B1810
		[Token(Token = "0x601FD27")]
		[Address(RVA = "0x19E7FE0", Offset = "0x19E6BE0", VA = "0x1819E7FE0")]
		private bool <>xLuaBaseProxy_CheckCharSelectValid(RoguelikeSelectCharViewModel P0, RoguelikeCharCardViewModel P1, out string P2)
		{
			return default(bool);
		}

		// Token: 0x0402ADF5 RID: 175605
		[Token(Token = "0x402ADF5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeSelectCharTravelConflictPanel _travelConflictPrefab;

		// Token: 0x0402ADF6 RID: 175606
		[Token(Token = "0x402ADF6")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<int> m_travelCharList;

		// Token: 0x0402ADF7 RID: 175607
		[Token(Token = "0x402ADF7")]
		[FieldOffset(Offset = "0x28")]
		private string m_travelConflictToast;

		// Token: 0x0402ADF8 RID: 175608
		[Token(Token = "0x402ADF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__IsInTravel;

		// Token: 0x0402ADF9 RID: 175609
		[Token(Token = "0x402ADF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pluginPriority;

		// Token: 0x0402ADFA RID: 175610
		[Token(Token = "0x402ADFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_additionalComparers;

		// Token: 0x0402ADFB RID: 175611
		[Token(Token = "0x402ADFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402ADFC RID: 175612
		[Token(Token = "0x402ADFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckCharSelectValid;

		// Token: 0x0402ADFD RID: 175613
		[Token(Token = "0x402ADFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402ADFE RID: 175614
		[Token(Token = "0x402ADFE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005476 RID: 21622
		[Token(Token = "0x2005476")]
		public class RoguelikeCharCardTravelViewPlugin : RoguelikeCharCardPlugin<RoguelikeCharCardTravelPluginContext>
		{
			// Token: 0x0601FD28 RID: 130344 RVA: 0x000B3628 File Offset: 0x000B1828
			[Token(Token = "0x601FD28")]
			[Address(RVA = "0x19EAB60", Offset = "0x19E9760", VA = "0x1819EAB60", Slot = "16")]
			public override bool OverrideConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out RoguelikeSelectCharConflictPanel prefab)
			{
				return default(bool);
			}

			// Token: 0x0601FD29 RID: 130345 RVA: 0x000B3640 File Offset: 0x000B1840
			[Token(Token = "0x601FD29")]
			[Address(RVA = "0x19EAC50", Offset = "0x19E9850", VA = "0x1819EAC50", Slot = "17")]
			public override bool OverrideValid(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out bool valid)
			{
				return default(bool);
			}

			// Token: 0x0601FD2A RID: 130346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FD2A")]
			[Address(RVA = "0x19EAD20", Offset = "0x19E9920", VA = "0x1819EAD20")]
			public RoguelikeCharCardTravelViewPlugin()
			{
			}

			// Token: 0x0402ADFF RID: 175615
			[Token(Token = "0x402ADFF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideConflictPanel;

			// Token: 0x0402AE00 RID: 175616
			[Token(Token = "0x402AE00")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OverrideValid;

			// Token: 0x0402AE01 RID: 175617
			[Token(Token = "0x402AE01")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
