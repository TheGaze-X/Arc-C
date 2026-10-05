using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CDE RID: 19678
	[Token(Token = "0x2004CDE")]
	public class GroceryOrderGoodMyStrategyBriefViewModel : IHotfixable
	{
		// Token: 0x17004534 RID: 17716
		// (get) Token: 0x0601D7CD RID: 120781 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D7CE RID: 120782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004534")]
		public string goodId
		{
			[Token(Token = "0x601D7CD")]
			[Address(RVA = "0x170E850", Offset = "0x170D450", VA = "0x18170E850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D7CE")]
			[Address(RVA = "0x170E9F0", Offset = "0x170D5F0", VA = "0x18170E9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x0601D7CF RID: 120783 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D7D0 RID: 120784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004535")]
		public string goodDesc
		{
			[Token(Token = "0x601D7CF")]
			[Address(RVA = "0x170E7F0", Offset = "0x170D3F0", VA = "0x18170E7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D7D0")]
			[Address(RVA = "0x170E970", Offset = "0x170D570", VA = "0x18170E970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x0601D7D1 RID: 120785 RVA: 0x000ABA50 File Offset: 0x000A9C50
		// (set) Token: 0x0601D7D2 RID: 120786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004536")]
		public int index
		{
			[Token(Token = "0x601D7D1")]
			[Address(RVA = "0x170E8B0", Offset = "0x170D4B0", VA = "0x18170E8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D7D2")]
			[Address(RVA = "0x170EA70", Offset = "0x170D670", VA = "0x18170EA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x0601D7D3 RID: 120787 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D7D4 RID: 120788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004537")]
		public string strategy
		{
			[Token(Token = "0x601D7D3")]
			[Address(RVA = "0x170E910", Offset = "0x170D510", VA = "0x18170E910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D7D4")]
			[Address(RVA = "0x170EAE0", Offset = "0x170D6E0", VA = "0x18170EAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601D7D5 RID: 120789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7D5")]
		[Address(RVA = "0x170E440", Offset = "0x170D040", VA = "0x18170E440")]
		public void LoadData(string goodId, string goodDesc, List<string> strategyNameList)
		{
		}

		// Token: 0x0601D7D6 RID: 120790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7D6")]
		[Address(RVA = "0x170E590", Offset = "0x170D190", VA = "0x18170E590")]
		public void RefreshStrategy(int strategyIndex)
		{
		}

		// Token: 0x0601D7D7 RID: 120791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7D7")]
		[Address(RVA = "0x170E740", Offset = "0x170D340", VA = "0x18170E740")]
		public GroceryOrderGoodMyStrategyBriefViewModel()
		{
		}

		// Token: 0x04026E4E RID: 159310
		[Token(Token = "0x4026E4E")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_strategyNameList;

		// Token: 0x04026E4F RID: 159311
		[Token(Token = "0x4026E4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_goodId;

		// Token: 0x04026E50 RID: 159312
		[Token(Token = "0x4026E50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_goodId;

		// Token: 0x04026E51 RID: 159313
		[Token(Token = "0x4026E51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_goodDesc;

		// Token: 0x04026E52 RID: 159314
		[Token(Token = "0x4026E52")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_goodDesc;

		// Token: 0x04026E53 RID: 159315
		[Token(Token = "0x4026E53")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x04026E54 RID: 159316
		[Token(Token = "0x4026E54")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x04026E55 RID: 159317
		[Token(Token = "0x4026E55")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_strategy;

		// Token: 0x04026E56 RID: 159318
		[Token(Token = "0x4026E56")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_strategy;

		// Token: 0x04026E57 RID: 159319
		[Token(Token = "0x4026E57")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026E58 RID: 159320
		[Token(Token = "0x4026E58")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshStrategy;

		// Token: 0x04026E59 RID: 159321
		[Token(Token = "0x4026E59")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
