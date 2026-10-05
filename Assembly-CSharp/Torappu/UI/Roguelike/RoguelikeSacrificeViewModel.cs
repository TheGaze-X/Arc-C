using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005463 RID: 21603
	[Token(Token = "0x2005463")]
	public class RoguelikeSacrificeViewModel : IHotfixable
	{
		// Token: 0x17004A8B RID: 19083
		// (get) Token: 0x0601FCC6 RID: 130246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FCC7 RID: 130247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A8B")]
		public string topicId
		{
			[Token(Token = "0x601FCC6")]
			[Address(RVA = "0x19FAF90", Offset = "0x19F9B90", VA = "0x1819FAF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601FCC7")]
			[Address(RVA = "0x19FB150", Offset = "0x19F9D50", VA = "0x1819FB150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x0601FCC8 RID: 130248 RVA: 0x000B3370 File Offset: 0x000B1570
		// (set) Token: 0x0601FCC9 RID: 130249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A8C")]
		public RoguelikeSacrificeType sacrificeType
		{
			[Token(Token = "0x601FCC8")]
			[Address(RVA = "0x19FAE70", Offset = "0x19F9A70", VA = "0x1819FAE70")]
			[CompilerGenerated]
			get
			{
				return RoguelikeSacrificeType.RELIC;
			}
			[Token(Token = "0x601FCC9")]
			[Address(RVA = "0x19FB0E0", Offset = "0x19F9CE0", VA = "0x1819FB0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x0601FCCA RID: 130250 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FCCB RID: 130251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A8D")]
		public string costItemId
		{
			[Token(Token = "0x601FCCA")]
			[Address(RVA = "0x19FAA50", Offset = "0x19F9650", VA = "0x1819FAA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601FCCB")]
			[Address(RVA = "0x19FB060", Offset = "0x19F9C60", VA = "0x1819FB060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x0601FCCC RID: 130252 RVA: 0x000B3388 File Offset: 0x000B1588
		// (set) Token: 0x0601FCCD RID: 130253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A8E")]
		public int costItemCount
		{
			[Token(Token = "0x601FCCC")]
			[Address(RVA = "0x19FA9F0", Offset = "0x19F95F0", VA = "0x1819FA9F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601FCCD")]
			[Address(RVA = "0x19FAFF0", Offset = "0x19F9BF0", VA = "0x1819FAFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x0601FCCE RID: 130254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A8F")]
		public string selectedIndexId
		{
			[Token(Token = "0x601FCCE")]
			[Address(RVA = "0x19FAED0", Offset = "0x19F9AD0", VA = "0x1819FAED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x0601FCCF RID: 130255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A90")]
		public IRoguelikeSacrifice selectedItem
		{
			[Token(Token = "0x601FCCF")]
			[Address(RVA = "0x19FAF30", Offset = "0x19F9B30", VA = "0x1819FAF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A91 RID: 19089
		// (get) Token: 0x0601FCD0 RID: 130256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A91")]
		public string emptyTip
		{
			[Token(Token = "0x601FCD0")]
			[Address(RVA = "0x19FAB70", Offset = "0x19F9770", VA = "0x1819FAB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A92 RID: 19090
		// (get) Token: 0x0601FCD1 RID: 130257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A92")]
		public string defaultNameText
		{
			[Token(Token = "0x601FCD1")]
			[Address(RVA = "0x19FAAB0", Offset = "0x19F96B0", VA = "0x1819FAAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A93 RID: 19091
		// (get) Token: 0x0601FCD2 RID: 130258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A93")]
		public string defaultUsageText
		{
			[Token(Token = "0x601FCD2")]
			[Address(RVA = "0x19FAB10", Offset = "0x19F9710", VA = "0x1819FAB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A94 RID: 19092
		// (get) Token: 0x0601FCD3 RID: 130259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A94")]
		public List<IRoguelikeSacrifice> itemList
		{
			[Token(Token = "0x601FCD3")]
			[Address(RVA = "0x19FABD0", Offset = "0x19F97D0", VA = "0x1819FABD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FCD4 RID: 130260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCD4")]
		[Address(RVA = "0x19FA4A0", Offset = "0x19F90A0", VA = "0x1819FA4A0")]
		public void LoadData(string topicId, RoguelikeSacrificeModelParamBuilder builder)
		{
		}

		// Token: 0x0601FCD5 RID: 130261 RVA: 0x000B33A0 File Offset: 0x000B15A0
		[Token(Token = "0x601FCD5")]
		[Address(RVA = "0x19FA860", Offset = "0x19F9460", VA = "0x1819FA860")]
		public bool SelectItem(string indexId)
		{
			return default(bool);
		}

		// Token: 0x0601FCD6 RID: 130262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCD6")]
		[Address(RVA = "0x19FA990", Offset = "0x19F9590", VA = "0x1819FA990")]
		public RoguelikeSacrificeViewModel()
		{
		}

		// Token: 0x0402AD87 RID: 175495
		[Token(Token = "0x402AD87")]
		[FieldOffset(Offset = "0x10")]
		public bool isInit;

		// Token: 0x0402AD88 RID: 175496
		[Token(Token = "0x402AD88")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, IRoguelikeSacrifice> m_itemDict;

		// Token: 0x0402AD89 RID: 175497
		[Token(Token = "0x402AD89")]
		[FieldOffset(Offset = "0x20")]
		private List<IRoguelikeSacrifice> m_itemList;

		// Token: 0x0402AD8A RID: 175498
		[Token(Token = "0x402AD8A")]
		[FieldOffset(Offset = "0x28")]
		private string m_selectedIndexId;

		// Token: 0x0402AD8B RID: 175499
		[Token(Token = "0x402AD8B")]
		[FieldOffset(Offset = "0x30")]
		private IRoguelikeSacrifice m_selectedItem;

		// Token: 0x0402AD8C RID: 175500
		[Token(Token = "0x402AD8C")]
		[FieldOffset(Offset = "0x38")]
		private string m_emptyTip;

		// Token: 0x0402AD8D RID: 175501
		[Token(Token = "0x402AD8D")]
		[FieldOffset(Offset = "0x40")]
		private string m_defaultNameText;

		// Token: 0x0402AD8E RID: 175502
		[Token(Token = "0x402AD8E")]
		[FieldOffset(Offset = "0x48")]
		private string m_defaultUsageText;

		// Token: 0x0402AD93 RID: 175507
		[Token(Token = "0x402AD93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402AD94 RID: 175508
		[Token(Token = "0x402AD94")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402AD95 RID: 175509
		[Token(Token = "0x402AD95")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sacrificeType;

		// Token: 0x0402AD96 RID: 175510
		[Token(Token = "0x402AD96")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_sacrificeType;

		// Token: 0x0402AD97 RID: 175511
		[Token(Token = "0x402AD97")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_costItemId;

		// Token: 0x0402AD98 RID: 175512
		[Token(Token = "0x402AD98")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_costItemId;

		// Token: 0x0402AD99 RID: 175513
		[Token(Token = "0x402AD99")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_costItemCount;

		// Token: 0x0402AD9A RID: 175514
		[Token(Token = "0x402AD9A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_costItemCount;

		// Token: 0x0402AD9B RID: 175515
		[Token(Token = "0x402AD9B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectedIndexId;

		// Token: 0x0402AD9C RID: 175516
		[Token(Token = "0x402AD9C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x0402AD9D RID: 175517
		[Token(Token = "0x402AD9D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_emptyTip;

		// Token: 0x0402AD9E RID: 175518
		[Token(Token = "0x402AD9E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_defaultNameText;

		// Token: 0x0402AD9F RID: 175519
		[Token(Token = "0x402AD9F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_defaultUsageText;

		// Token: 0x0402ADA0 RID: 175520
		[Token(Token = "0x402ADA0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_itemList;

		// Token: 0x0402ADA1 RID: 175521
		[Token(Token = "0x402ADA1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402ADA2 RID: 175522
		[Token(Token = "0x402ADA2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x0402ADA3 RID: 175523
		[Token(Token = "0x402ADA3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
