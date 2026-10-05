using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200546B RID: 21611
	[Token(Token = "0x200546B")]
	public abstract class RoguelikeCharCardExpeditionManagerPluginContextBase : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x17004A99 RID: 19097
		// (get) Token: 0x0601FCEA RID: 130282 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FCEB RID: 130283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A99")]
		protected string topicId
		{
			[Token(Token = "0x601FCEA")]
			[Address(RVA = "0x19E85A0", Offset = "0x19E71A0", VA = "0x1819E85A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601FCEB")]
			[Address(RVA = "0x19E8600", Offset = "0x19E7200", VA = "0x1819E8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A9A RID: 19098
		// (get) Token: 0x0601FCEC RID: 130284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A9A")]
		public override List<RoguelikeCharCardComparer> additionalComparers
		{
			[Token(Token = "0x601FCEC")]
			[Address(RVA = "0x19E8440", Offset = "0x19E7040", VA = "0x1819E8440", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FCED RID: 130285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FCED")]
		[Address(RVA = "0x19E7D20", Offset = "0x19E6920", VA = "0x1819E7D20", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x0601FCEE RID: 130286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCEE")]
		[Address(RVA = "0x19E8130", Offset = "0x19E6D30", VA = "0x1819E8130")]
		private void _ResetCache()
		{
		}

		// Token: 0x0601FCEF RID: 130287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCEF")]
		[Address(RVA = "0x19E7EF0", Offset = "0x19E6AF0", VA = "0x1819E7EF0", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601FCF0 RID: 130288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCF0")]
		[Address(RVA = "0x19E6DE0", Offset = "0x19E59E0", VA = "0x1819E6DE0", Slot = "26")]
		protected virtual void CustomLoadData()
		{
		}

		// Token: 0x0601FCF1 RID: 130289
		[Token(Token = "0x601FCF1")]
		protected abstract string GetExpedConflictToast(PlayerRoguelikeV2.CurrentData.Troop.ExpedType expedType);

		// Token: 0x0601FCF2 RID: 130290 RVA: 0x000B33D0 File Offset: 0x000B15D0
		[Token(Token = "0x601FCF2")]
		[Address(RVA = "0x19E7E00", Offset = "0x19E6A00", VA = "0x1819E7E00", Slot = "28")]
		protected virtual bool IsInExpedition(int troopInstId)
		{
			return default(bool);
		}

		// Token: 0x0601FCF3 RID: 130291 RVA: 0x000B33E8 File Offset: 0x000B15E8
		[Token(Token = "0x601FCF3")]
		[Address(RVA = "0x19E7A10", Offset = "0x19E6610", VA = "0x1819E7A10", Slot = "17")]
		public override bool CheckCharSelectValid(RoguelikeSelectCharViewModel groupModel, RoguelikeCharCardViewModel charModel, out string invalidToast)
		{
			return default(bool);
		}

		// Token: 0x0601FCF4 RID: 130292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FCF4")]
		[Address(RVA = "0x19E7BD0", Offset = "0x19E67D0", VA = "0x1819E7BD0", Slot = "29")]
		protected virtual RoguelikeSelectCharConflictPanel GetConflictPanel(int troopInstId)
		{
			return null;
		}

		// Token: 0x0601FCF5 RID: 130293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCF5")]
		[Address(RVA = "0x19E8340", Offset = "0x19E6F40", VA = "0x1819E8340")]
		protected RoguelikeCharCardExpeditionManagerPluginContextBase()
		{
		}

		// Token: 0x0601FCF7 RID: 130295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FCF7")]
		[Address(RVA = "0x19E7FF0", Offset = "0x19E6BF0", VA = "0x1819E7FF0")]
		private List<RoguelikeCharCardComparer> <>xLuaBaseProxy_get_additionalComparers()
		{
			return null;
		}

		// Token: 0x0601FCF8 RID: 130296 RVA: 0x000B3418 File Offset: 0x000B1618
		[Token(Token = "0x601FCF8")]
		[Address(RVA = "0x19E7FE0", Offset = "0x19E6BE0", VA = "0x1819E7FE0")]
		private bool <>xLuaBaseProxy_CheckCharSelectValid(RoguelikeSelectCharViewModel P0, RoguelikeCharCardViewModel P1, out string P2)
		{
			return default(bool);
		}

		// Token: 0x0402ADC6 RID: 175558
		[Token(Token = "0x402ADC6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeCharCardExpeditionManagerPluginContextBase.RoguelikeSelectCharConflictConfig[] _availExpeds;

		// Token: 0x0402ADC7 RID: 175559
		[Token(Token = "0x402ADC7")]
		[FieldOffset(Offset = "0x20")]
		private EnumIntDictionary<PlayerRoguelikeV2.CurrentData.Troop.ExpedType, RoguelikeSelectCharConflictPanel> m_expedPanels;

		// Token: 0x0402ADC9 RID: 175561
		[Token(Token = "0x402ADC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402ADCA RID: 175562
		[Token(Token = "0x402ADCA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402ADCB RID: 175563
		[Token(Token = "0x402ADCB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_additionalComparers;

		// Token: 0x0402ADCC RID: 175564
		[Token(Token = "0x402ADCC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402ADCD RID: 175565
		[Token(Token = "0x402ADCD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetCache;

		// Token: 0x0402ADCE RID: 175566
		[Token(Token = "0x402ADCE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402ADCF RID: 175567
		[Token(Token = "0x402ADCF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CustomLoadData;

		// Token: 0x0402ADD0 RID: 175568
		[Token(Token = "0x402ADD0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsInExpedition;

		// Token: 0x0402ADD1 RID: 175569
		[Token(Token = "0x402ADD1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckCharSelectValid;

		// Token: 0x0402ADD2 RID: 175570
		[Token(Token = "0x402ADD2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetConflictPanel;

		// Token: 0x0402ADD3 RID: 175571
		[Token(Token = "0x402ADD3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200546C RID: 21612
		[Token(Token = "0x200546C")]
		[Serializable]
		public class RoguelikeSelectCharConflictConfig : IHotfixable
		{
			// Token: 0x17004A9B RID: 19099
			// (get) Token: 0x0601FCF9 RID: 130297 RVA: 0x000B3430 File Offset: 0x000B1630
			[Token(Token = "0x17004A9B")]
			public PlayerRoguelikeV2.CurrentData.Troop.ExpedType expedType
			{
				[Token(Token = "0x601FCF9")]
				[Address(RVA = "0x19FC540", Offset = "0x19FB140", VA = "0x1819FC540")]
				get
				{
					return PlayerRoguelikeV2.CurrentData.Troop.ExpedType.EXPED;
				}
			}

			// Token: 0x17004A9C RID: 19100
			// (get) Token: 0x0601FCFA RID: 130298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004A9C")]
			public RoguelikeSelectCharConflictPanel conflictPanel
			{
				[Token(Token = "0x601FCFA")]
				[Address(RVA = "0x19FC4E0", Offset = "0x19FB0E0", VA = "0x1819FC4E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601FCFB RID: 130299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FCFB")]
			[Address(RVA = "0x19FC480", Offset = "0x19FB080", VA = "0x1819FC480")]
			public RoguelikeSelectCharConflictConfig()
			{
			}

			// Token: 0x0402ADD4 RID: 175572
			[Token(Token = "0x402ADD4")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private PlayerRoguelikeV2.CurrentData.Troop.ExpedType _expedType;

			// Token: 0x0402ADD5 RID: 175573
			[Token(Token = "0x402ADD5")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private RoguelikeSelectCharConflictPanel _conflictPanel;

			// Token: 0x0402ADD6 RID: 175574
			[Token(Token = "0x402ADD6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_expedType;

			// Token: 0x0402ADD7 RID: 175575
			[Token(Token = "0x402ADD7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_conflictPanel;

			// Token: 0x0402ADD8 RID: 175576
			[Token(Token = "0x402ADD8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200546D RID: 21613
		[Token(Token = "0x200546D")]
		public class RoguelikeCharCardExpeditionPlugin : RoguelikeCharCardPlugin<RoguelikeCharCardExpeditionManagerPluginContextBase>
		{
			// Token: 0x0601FCFC RID: 130300 RVA: 0x000B3448 File Offset: 0x000B1648
			[Token(Token = "0x601FCFC")]
			[Address(RVA = "0x19E8E30", Offset = "0x19E7A30", VA = "0x1819E8E30", Slot = "16")]
			public override bool OverrideConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out RoguelikeSelectCharConflictPanel prefab)
			{
				return default(bool);
			}

			// Token: 0x0601FCFD RID: 130301 RVA: 0x000B3460 File Offset: 0x000B1660
			[Token(Token = "0x601FCFD")]
			[Address(RVA = "0x19E8FC0", Offset = "0x19E7BC0", VA = "0x1819E8FC0", Slot = "17")]
			public override bool OverrideValid(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out bool valid)
			{
				return default(bool);
			}

			// Token: 0x0601FCFE RID: 130302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FCFE")]
			[Address(RVA = "0x19E90C0", Offset = "0x19E7CC0", VA = "0x1819E90C0")]
			public RoguelikeCharCardExpeditionPlugin()
			{
			}

			// Token: 0x0402ADD9 RID: 175577
			[Token(Token = "0x402ADD9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideConflictPanel;

			// Token: 0x0402ADDA RID: 175578
			[Token(Token = "0x402ADDA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OverrideValid;

			// Token: 0x0402ADDB RID: 175579
			[Token(Token = "0x402ADDB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
