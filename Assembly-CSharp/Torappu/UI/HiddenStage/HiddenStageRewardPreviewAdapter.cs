using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CA0 RID: 19616
	[Token(Token = "0x2004CA0")]
	public class HiddenStageRewardPreviewAdapter : SimpleLayoutAdapter
	{
		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x0601D670 RID: 120432 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D671 RID: 120433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044FC")]
		public List<StageRewardViewModel> cardModels
		{
			[Token(Token = "0x601D670")]
			[Address(RVA = "0x16E1A20", Offset = "0x16E0620", VA = "0x1816E1A20")]
			get
			{
				return null;
			}
			[Token(Token = "0x601D671")]
			[Address(RVA = "0x16E1B90", Offset = "0x16E0790", VA = "0x1816E1B90")]
			set
			{
			}
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x0601D672 RID: 120434 RVA: 0x000AB618 File Offset: 0x000A9818
		[Token(Token = "0x170044FD")]
		public override int count
		{
			[Token(Token = "0x601D672")]
			[Address(RVA = "0x16E1A80", Offset = "0x16E0680", VA = "0x1816E1A80", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601D673 RID: 120435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D673")]
		[Address(RVA = "0x16E1800", Offset = "0x16E0400", VA = "0x1816E1800", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0601D674 RID: 120436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D674")]
		[Address(RVA = "0x16E19C0", Offset = "0x16E05C0", VA = "0x1816E19C0")]
		public HiddenStageRewardPreviewAdapter()
		{
		}

		// Token: 0x04026B79 RID: 158585
		[Token(Token = "0x4026B79")]
		private const int MAX_ITEM_COUNT = 3;

		// Token: 0x04026B7A RID: 158586
		[Token(Token = "0x4026B7A")]
		[FieldOffset(Offset = "0x20")]
		private List<StageRewardViewModel> m_cardModels;

		// Token: 0x04026B7B RID: 158587
		[Token(Token = "0x4026B7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardModels;

		// Token: 0x04026B7C RID: 158588
		[Token(Token = "0x4026B7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_cardModels;

		// Token: 0x04026B7D RID: 158589
		[Token(Token = "0x4026B7D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04026B7E RID: 158590
		[Token(Token = "0x4026B7E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04026B7F RID: 158591
		[Token(Token = "0x4026B7F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
