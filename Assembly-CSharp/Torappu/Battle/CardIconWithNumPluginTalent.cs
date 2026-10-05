using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024AA RID: 9386
	[Token(Token = "0x20024AA")]
	public class CardIconWithNumPluginTalent : CommonUICardPluginTalent
	{
		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x0600F150 RID: 61776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F5F")]
		public string iconId
		{
			[Token(Token = "0x600F150")]
			[Address(RVA = "0x686D60", Offset = "0x685960", VA = "0x180686D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F151 RID: 61777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F151")]
		[Address(RVA = "0x686660", Offset = "0x685260", VA = "0x180686660", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F152 RID: 61778 RVA: 0x00058ED8 File Offset: 0x000570D8
		[Token(Token = "0x600F152")]
		[Address(RVA = "0x686760", Offset = "0x685360", VA = "0x180686760", Slot = "38")]
		public virtual int GetIconNum(Deck.Card card)
		{
			return 0;
		}

		// Token: 0x0600F153 RID: 61779 RVA: 0x00058EF0 File Offset: 0x000570F0
		[Token(Token = "0x600F153")]
		[Address(RVA = "0x686800", Offset = "0x685400", VA = "0x180686800", Slot = "39")]
		public virtual bool NeedShow(Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x0600F154 RID: 61780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F154")]
		[Address(RVA = "0x686C80", Offset = "0x685880", VA = "0x180686C80")]
		public CardIconWithNumPluginTalent()
		{
		}

		// Token: 0x0600F155 RID: 61781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F155")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x04010B05 RID: 68357
		[Token(Token = "0x4010B05")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _iconId;

		// Token: 0x04010B06 RID: 68358
		[Token(Token = "0x4010B06")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _filterStackedDeckBuffKey;

		// Token: 0x04010B07 RID: 68359
		[Token(Token = "0x4010B07")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _alsoDisplayNumByBuffKey;

		// Token: 0x04010B08 RID: 68360
		[Token(Token = "0x4010B08")]
		[FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool _useTokenCardAsSourceCard;

		// Token: 0x04010B09 RID: 68361
		[Token(Token = "0x4010B09")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected DeckSelector _deckSelector;

		// Token: 0x04010B0A RID: 68362
		[Token(Token = "0x4010B0A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CardUtil.SelectOrderMask _selectOrder;

		// Token: 0x04010B0B RID: 68363
		[Token(Token = "0x4010B0B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<CardUtil.SelectOrderSelector> _extraCheckGroups;

		// Token: 0x04010B0C RID: 68364
		[Token(Token = "0x4010B0C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TargetValidator _showValidator;

		// Token: 0x04010B0D RID: 68365
		[Token(Token = "0x4010B0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_iconId;

		// Token: 0x04010B0E RID: 68366
		[Token(Token = "0x4010B0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010B0F RID: 68367
		[Token(Token = "0x4010B0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetIconNum;

		// Token: 0x04010B10 RID: 68368
		[Token(Token = "0x4010B10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NeedShow;

		// Token: 0x04010B11 RID: 68369
		[Token(Token = "0x4010B11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
