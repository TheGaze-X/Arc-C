using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005780 RID: 22400
	[Token(Token = "0x2005780")]
	public class RL02ExpeditionPluginContext : RoguelikeExpeditionPluginContext
	{
		// Token: 0x17004CDD RID: 19677
		// (get) Token: 0x06020C7B RID: 134267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CDD")]
		public override GameObject charCardPrefab
		{
			[Token(Token = "0x6020C7B")]
			[Address(RVA = "0x1B21BB0", Offset = "0x1B207B0", VA = "0x181B21BB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004CDE RID: 19678
		// (get) Token: 0x06020C7C RID: 134268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CDE")]
		public override RoguelikeExpeditionSelectingCharView selectingCharPrefab
		{
			[Token(Token = "0x6020C7C")]
			[Address(RVA = "0x1B21C10", Offset = "0x1B20810", VA = "0x181B21C10", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020C7D RID: 134269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C7D")]
		[Address(RVA = "0x1B219F0", Offset = "0x1B205F0", VA = "0x181B219F0", Slot = "6")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020C7E RID: 134270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C7E")]
		[Address(RVA = "0x1B21830", Offset = "0x1B20430", VA = "0x181B21830", Slot = "7")]
		public override string GetSelectDesc(RoguelikeExpeditionModel model)
		{
			return null;
		}

		// Token: 0x06020C7F RID: 134271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C7F")]
		[Address(RVA = "0x1B21770", Offset = "0x1B20370", VA = "0x181B21770", Slot = "8")]
		public override RoguelikeExpeditionPluginContext.RoguelikeExpeditionCharListSort GetExpeditionCharListSort(RoguelikeExpeditionModel expeditionModel)
		{
			return null;
		}

		// Token: 0x06020C80 RID: 134272 RVA: 0x000B7438 File Offset: 0x000B5638
		[Token(Token = "0x6020C80")]
		[Address(RVA = "0x1B215D0", Offset = "0x1B201D0", VA = "0x181B215D0")]
		public RoguelikeCharBuffModel GetCharBuff(string charInstId)
		{
			return default(RoguelikeCharBuffModel);
		}

		// Token: 0x06020C81 RID: 134273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C81")]
		[Address(RVA = "0x1B21A70", Offset = "0x1B20670", VA = "0x181B21A70")]
		public RL02ExpeditionPluginContext()
		{
		}

		// Token: 0x0402C859 RID: 182361
		[Token(Token = "0x402C859")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _charCardPrefab;

		// Token: 0x0402C85A RID: 182362
		[Token(Token = "0x402C85A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL02ExpeditionSelectingCharView _selectingCharPrefab;

		// Token: 0x0402C85B RID: 182363
		[Token(Token = "0x402C85B")]
		[FieldOffset(Offset = "0x28")]
		private RL02ExpeditionPluginContext.RL02ExpeditionPluginModel m_viewModel;

		// Token: 0x0402C85C RID: 182364
		[Token(Token = "0x402C85C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charCardPrefab;

		// Token: 0x0402C85D RID: 182365
		[Token(Token = "0x402C85D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectingCharPrefab;

		// Token: 0x0402C85E RID: 182366
		[Token(Token = "0x402C85E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C85F RID: 182367
		[Token(Token = "0x402C85F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectDesc;

		// Token: 0x0402C860 RID: 182368
		[Token(Token = "0x402C860")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetExpeditionCharListSort;

		// Token: 0x0402C861 RID: 182369
		[Token(Token = "0x402C861")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCharBuff;

		// Token: 0x0402C862 RID: 182370
		[Token(Token = "0x402C862")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005781 RID: 22401
		[Token(Token = "0x2005781")]
		public class RL02ExpeditionPluginModel : IHotfixable
		{
			// Token: 0x06020C82 RID: 134274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C82")]
			[Address(RVA = "0x1B21D90", Offset = "0x1B20990", VA = "0x181B21D90")]
			public void LoadData(string topicId)
			{
			}

			// Token: 0x06020C83 RID: 134275 RVA: 0x000B7450 File Offset: 0x000B5650
			[Token(Token = "0x6020C83")]
			[Address(RVA = "0x1B22100", Offset = "0x1B20D00", VA = "0x181B22100")]
			public int OverrideExpeditionCharListSort(RoguelikeExpeditionCharCardViewModel lhs, RoguelikeExpeditionCharCardViewModel rhs)
			{
				return 0;
			}

			// Token: 0x06020C84 RID: 134276 RVA: 0x000B7468 File Offset: 0x000B5668
			[Token(Token = "0x6020C84")]
			[Address(RVA = "0x1B21C70", Offset = "0x1B20870", VA = "0x181B21C70")]
			public RoguelikeCharBuffModel GetCharBuff(string charInstId)
			{
				return default(RoguelikeCharBuffModel);
			}

			// Token: 0x06020C85 RID: 134277 RVA: 0x000B7480 File Offset: 0x000B5680
			[Token(Token = "0x6020C85")]
			[Address(RVA = "0x1B222A0", Offset = "0x1B20EA0", VA = "0x181B222A0")]
			private bool _HasMutationCharBuff(string charInstId)
			{
				return default(bool);
			}

			// Token: 0x06020C86 RID: 134278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C86")]
			[Address(RVA = "0x1B22380", Offset = "0x1B20F80", VA = "0x181B22380")]
			public RL02ExpeditionPluginModel()
			{
			}

			// Token: 0x0402C863 RID: 182371
			[Token(Token = "0x402C863")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, RoguelikeCharBuffModel> charBuffs;

			// Token: 0x0402C864 RID: 182372
			[Token(Token = "0x402C864")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402C865 RID: 182373
			[Token(Token = "0x402C865")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OverrideExpeditionCharListSort;

			// Token: 0x0402C866 RID: 182374
			[Token(Token = "0x402C866")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetCharBuff;

			// Token: 0x0402C867 RID: 182375
			[Token(Token = "0x402C867")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__HasMutationCharBuff;

			// Token: 0x0402C868 RID: 182376
			[Token(Token = "0x402C868")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
