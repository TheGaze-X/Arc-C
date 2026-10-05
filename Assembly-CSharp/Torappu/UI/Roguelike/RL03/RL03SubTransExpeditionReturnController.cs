using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005881 RID: 22657
	[Token(Token = "0x2005881")]
	public class RL03SubTransExpeditionReturnController : RoguelikeTransitionView.SubTransitionBase<RL03SubTransExpeditionReturnController.ExpeditionReturnModel>
	{
		// Token: 0x06021149 RID: 135497 RVA: 0x000B87B8 File Offset: 0x000B69B8
		[Token(Token = "0x6021149")]
		[Address(RVA = "0x1B5EDD0", Offset = "0x1B5D9D0", VA = "0x181B5EDD0")]
		private bool _EnsureExpeditionReturn()
		{
			return default(bool);
		}

		// Token: 0x0602114A RID: 135498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602114A")]
		[Address(RVA = "0x1B5E7D0", Offset = "0x1B5D3D0", VA = "0x181B5E7D0", Slot = "9")]
		protected override RL03SubTransExpeditionReturnController.ExpeditionReturnModel GetParam(RoguelikeTransitionView.TransOptions transOptions)
		{
			return null;
		}

		// Token: 0x0602114B RID: 135499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602114B")]
		[Address(RVA = "0x1B5EAD0", Offset = "0x1B5D6D0", VA = "0x181B5EAD0", Slot = "10")]
		protected override void SetParam(RL03SubTransExpeditionReturnController.ExpeditionReturnModel expeditionReturnModel)
		{
		}

		// Token: 0x0602114C RID: 135500 RVA: 0x000B87D0 File Offset: 0x000B69D0
		[Token(Token = "0x602114C")]
		[Address(RVA = "0x1B5E970", Offset = "0x1B5D570", VA = "0x181B5E970", Slot = "11")]
		public override RoguelikeTransitionView.SubTransType GetTransType()
		{
			return RoguelikeTransitionView.SubTransType.NONE;
		}

		// Token: 0x0602114D RID: 135501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602114D")]
		[Address(RVA = "0x1B5ED20", Offset = "0x1B5D920", VA = "0x181B5ED20", Slot = "12")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x0602114E RID: 135502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602114E")]
		[Address(RVA = "0x1B5E9D0", Offset = "0x1B5D5D0", VA = "0x181B5E9D0", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x0602114F RID: 135503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602114F")]
		[Address(RVA = "0x1B5EEA0", Offset = "0x1B5DAA0", VA = "0x181B5EEA0")]
		private void _SendExpeditionDialogRequest()
		{
		}

		// Token: 0x06021150 RID: 135504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021150")]
		[Address(RVA = "0x1B5F0C0", Offset = "0x1B5DCC0", VA = "0x181B5F0C0")]
		public RL03SubTransExpeditionReturnController()
		{
		}

		// Token: 0x0402D093 RID: 184467
		[Token(Token = "0x402D093")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL03SubTransExpeditionReturnView _view;

		// Token: 0x0402D094 RID: 184468
		[Token(Token = "0x402D094")]
		[FieldOffset(Offset = "0x20")]
		private bool m_waitForConfirm;

		// Token: 0x0402D095 RID: 184469
		[Token(Token = "0x402D095")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureExpeditionReturn;

		// Token: 0x0402D096 RID: 184470
		[Token(Token = "0x402D096")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetParam;

		// Token: 0x0402D097 RID: 184471
		[Token(Token = "0x402D097")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x0402D098 RID: 184472
		[Token(Token = "0x402D098")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTransType;

		// Token: 0x0402D099 RID: 184473
		[Token(Token = "0x402D099")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402D09A RID: 184474
		[Token(Token = "0x402D09A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402D09B RID: 184475
		[Token(Token = "0x402D09B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendExpeditionDialogRequest;

		// Token: 0x0402D09C RID: 184476
		[Token(Token = "0x402D09C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005882 RID: 22658
		[Token(Token = "0x2005882")]
		public class ExpeditionReturnSingleModel : IHotfixable
		{
			// Token: 0x06021153 RID: 135507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021153")]
			[Address(RVA = "0x1B5C1B0", Offset = "0x1B5ADB0", VA = "0x181B5C1B0")]
			public void LoadData(string topicId, PlayerRoguelikeV2.CurrentData.Troop playerTroop, PlayerRoguelikeV2.CurrentData.ExpeditionReturn.Char returnChar)
			{
			}

			// Token: 0x06021154 RID: 135508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021154")]
			[Address(RVA = "0x1B5C3B0", Offset = "0x1B5AFB0", VA = "0x181B5C3B0")]
			public ExpeditionReturnSingleModel()
			{
			}

			// Token: 0x0402D09D RID: 184477
			[Token(Token = "0x402D09D")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402D09E RID: 184478
			[Token(Token = "0x402D09E")]
			[FieldOffset(Offset = "0x18")]
			public string instId;

			// Token: 0x0402D09F RID: 184479
			[Token(Token = "0x402D09F")]
			[FieldOffset(Offset = "0x20")]
			public string charId;

			// Token: 0x0402D0A0 RID: 184480
			[Token(Token = "0x402D0A0")]
			[FieldOffset(Offset = "0x28")]
			public string charName;

			// Token: 0x0402D0A1 RID: 184481
			[Token(Token = "0x402D0A1")]
			[FieldOffset(Offset = "0x30")]
			public bool isUpgrade;

			// Token: 0x0402D0A2 RID: 184482
			[Token(Token = "0x402D0A2")]
			[FieldOffset(Offset = "0x38")]
			public List<ItemBundle> rewards;

			// Token: 0x0402D0A3 RID: 184483
			[Token(Token = "0x402D0A3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402D0A4 RID: 184484
			[Token(Token = "0x402D0A4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005883 RID: 22659
		[Token(Token = "0x2005883")]
		public class ExpeditionReturnModel : IHotfixable
		{
			// Token: 0x06021155 RID: 135509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021155")]
			[Address(RVA = "0x1B5BE00", Offset = "0x1B5AA00", VA = "0x181B5BE00")]
			public void LoadData(string topicId, PlayerRoguelikeV2.CurrentData.Troop playerTroop)
			{
			}

			// Token: 0x06021156 RID: 135510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021156")]
			[Address(RVA = "0x1B5C150", Offset = "0x1B5AD50", VA = "0x181B5C150")]
			public ExpeditionReturnModel()
			{
			}

			// Token: 0x0402D0A5 RID: 184485
			[Token(Token = "0x402D0A5")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402D0A6 RID: 184486
			[Token(Token = "0x402D0A6")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<string, RL03SubTransExpeditionReturnController.ExpeditionReturnSingleModel> expeditionReturnChars;

			// Token: 0x0402D0A7 RID: 184487
			[Token(Token = "0x402D0A7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402D0A8 RID: 184488
			[Token(Token = "0x402D0A8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
