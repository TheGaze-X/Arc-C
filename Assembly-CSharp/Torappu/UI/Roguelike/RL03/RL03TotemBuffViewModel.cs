using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.TotemBuff;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200586B RID: 22635
	[Token(Token = "0x200586B")]
	public class RL03TotemBuffViewModel : IRoguelikeTotemBuffViewModel, IHotfixable
	{
		// Token: 0x17004D8C RID: 19852
		// (get) Token: 0x060210EC RID: 135404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D8C")]
		public string topicId
		{
			[Token(Token = "0x60210EC")]
			[Address(RVA = "0x1B68280", Offset = "0x1B66E80", VA = "0x181B68280")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D8D RID: 19853
		// (get) Token: 0x060210ED RID: 135405 RVA: 0x000B85C0 File Offset: 0x000B67C0
		[Token(Token = "0x17004D8D")]
		public bool isViewOnlyMode
		{
			[Token(Token = "0x60210ED")]
			[Address(RVA = "0x1B68220", Offset = "0x1B66E20", VA = "0x181B68220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060210EE RID: 135406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210EE")]
		[Address(RVA = "0x1B67430", Offset = "0x1B66030", VA = "0x181B67430", Slot = "4")]
		public void LoadData(string topicId, bool isOpenDirectFromDungeon)
		{
		}

		// Token: 0x060210EF RID: 135407 RVA: 0x000B85D8 File Offset: 0x000B67D8
		[Token(Token = "0x60210EF")]
		[Address(RVA = "0x1B66E80", Offset = "0x1B65A80", VA = "0x181B66E80", Slot = "5")]
		public bool CheckIfShowMenuBottomBar()
		{
			return default(bool);
		}

		// Token: 0x060210F0 RID: 135408 RVA: 0x000B85F0 File Offset: 0x000B67F0
		[Token(Token = "0x60210F0")]
		[Address(RVA = "0x1B67290", Offset = "0x1B65E90", VA = "0x181B67290")]
		public TotemItemDisplayType GetTotemItemDisplayType(string totemId, string instId)
		{
			return TotemItemDisplayType.NONE;
		}

		// Token: 0x060210F1 RID: 135409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210F1")]
		[Address(RVA = "0x1B67D80", Offset = "0x1B66980", VA = "0x181B67D80")]
		public void SelectTotemItem(string totemId, string instId)
		{
		}

		// Token: 0x060210F2 RID: 135410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210F2")]
		[Address(RVA = "0x1B67AC0", Offset = "0x1B666C0", VA = "0x181B67AC0")]
		public void SelectMapNode(int depth, int index)
		{
		}

		// Token: 0x060210F3 RID: 135411 RVA: 0x000B8608 File Offset: 0x000B6808
		[Token(Token = "0x60210F3")]
		[Address(RVA = "0x1B66DF0", Offset = "0x1B659F0", VA = "0x181B66DF0")]
		public bool CheckIfCanUseTotem()
		{
			return default(bool);
		}

		// Token: 0x060210F4 RID: 135412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60210F4")]
		[Address(RVA = "0x1B67130", Offset = "0x1B65D30", VA = "0x181B67130")]
		public List<string> GetCurTotemIndexList()
		{
			return null;
		}

		// Token: 0x060210F5 RID: 135413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60210F5")]
		[Address(RVA = "0x1B66F10", Offset = "0x1B65B10", VA = "0x181B66F10")]
		public List<string> GetCurSelectNodeList()
		{
			return null;
		}

		// Token: 0x060210F6 RID: 135414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210F6")]
		[Address(RVA = "0x1B68030", Offset = "0x1B66C30", VA = "0x181B68030")]
		public RL03TotemBuffViewModel()
		{
		}

		// Token: 0x0402CFC9 RID: 184265
		[Token(Token = "0x402CFC9")]
		[FieldOffset(Offset = "0x10")]
		public RL03TotemListViewProperty listViewProperty;

		// Token: 0x0402CFCA RID: 184266
		[Token(Token = "0x402CFCA")]
		[FieldOffset(Offset = "0x18")]
		public RL03TotemMapViewProperty mapViewProperty;

		// Token: 0x0402CFCB RID: 184267
		[Token(Token = "0x402CFCB")]
		[FieldOffset(Offset = "0x20")]
		public RL03TotemBottomViewProperty bottomViewProperty;

		// Token: 0x0402CFCC RID: 184268
		[Token(Token = "0x402CFCC")]
		[FieldOffset(Offset = "0x28")]
		private string m_topicId;

		// Token: 0x0402CFCD RID: 184269
		[Token(Token = "0x402CFCD")]
		[FieldOffset(Offset = "0x30")]
		private TotemViewShowType m_showType;

		// Token: 0x0402CFCE RID: 184270
		[Token(Token = "0x402CFCE")]
		[FieldOffset(Offset = "0x34")]
		private int m_sequenceNum;

		// Token: 0x0402CFCF RID: 184271
		[Token(Token = "0x402CFCF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402CFD0 RID: 184272
		[Token(Token = "0x402CFD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isViewOnlyMode;

		// Token: 0x0402CFD1 RID: 184273
		[Token(Token = "0x402CFD1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CFD2 RID: 184274
		[Token(Token = "0x402CFD2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfShowMenuBottomBar;

		// Token: 0x0402CFD3 RID: 184275
		[Token(Token = "0x402CFD3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetTotemItemDisplayType;

		// Token: 0x0402CFD4 RID: 184276
		[Token(Token = "0x402CFD4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SelectTotemItem;

		// Token: 0x0402CFD5 RID: 184277
		[Token(Token = "0x402CFD5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SelectMapNode;

		// Token: 0x0402CFD6 RID: 184278
		[Token(Token = "0x402CFD6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfCanUseTotem;

		// Token: 0x0402CFD7 RID: 184279
		[Token(Token = "0x402CFD7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCurTotemIndexList;

		// Token: 0x0402CFD8 RID: 184280
		[Token(Token = "0x402CFD8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetCurSelectNodeList;

		// Token: 0x0402CFD9 RID: 184281
		[Token(Token = "0x402CFD9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
