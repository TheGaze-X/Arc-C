using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005888 RID: 22664
	[Token(Token = "0x2005888")]
	public class RL03SubTransPredictController : RoguelikeTransitionView.SubTransitionBase<RL03SubTransPredictController.PredictModel>
	{
		// Token: 0x06021176 RID: 135542 RVA: 0x000B8878 File Offset: 0x000B6A78
		[Token(Token = "0x6021176")]
		[Address(RVA = "0x1B60040", Offset = "0x1B5EC40", VA = "0x181B60040")]
		private bool _EnsurePendingEvent()
		{
			return default(bool);
		}

		// Token: 0x06021177 RID: 135543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021177")]
		[Address(RVA = "0x1B5F9E0", Offset = "0x1B5E5E0", VA = "0x181B5F9E0", Slot = "9")]
		protected override RL03SubTransPredictController.PredictModel GetParam(RoguelikeTransitionView.TransOptions transOptions)
		{
			return null;
		}

		// Token: 0x06021178 RID: 135544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021178")]
		[Address(RVA = "0x1B5FF10", Offset = "0x1B5EB10", VA = "0x181B5FF10", Slot = "10")]
		protected override void SetParam(RL03SubTransPredictController.PredictModel predictModel)
		{
		}

		// Token: 0x06021179 RID: 135545 RVA: 0x000B8890 File Offset: 0x000B6A90
		[Token(Token = "0x6021179")]
		[Address(RVA = "0x1B5FBB0", Offset = "0x1B5E7B0", VA = "0x181B5FBB0", Slot = "11")]
		public override RoguelikeTransitionView.SubTransType GetTransType()
		{
			return RoguelikeTransitionView.SubTransType.NONE;
		}

		// Token: 0x0602117A RID: 135546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602117A")]
		[Address(RVA = "0x1B5FF90", Offset = "0x1B5EB90", VA = "0x181B5FF90", Slot = "12")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x0602117B RID: 135547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602117B")]
		[Address(RVA = "0x1B5FE30", Offset = "0x1B5EA30", VA = "0x181B5FE30", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x0602117C RID: 135548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602117C")]
		[Address(RVA = "0x1B5FC10", Offset = "0x1B5E810", VA = "0x181B5FC10")]
		public void OnConfirmBtnClicked()
		{
		}

		// Token: 0x0602117D RID: 135549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602117D")]
		[Address(RVA = "0x1B60130", Offset = "0x1B5ED30", VA = "0x181B60130")]
		public RL03SubTransPredictController()
		{
		}

		// Token: 0x0402D0D1 RID: 184529
		[Token(Token = "0x402D0D1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL03SubTransPredictView _view;

		// Token: 0x0402D0D2 RID: 184530
		[Token(Token = "0x402D0D2")]
		[FieldOffset(Offset = "0x20")]
		private bool m_waitForConfirm;

		// Token: 0x0402D0D3 RID: 184531
		[Token(Token = "0x402D0D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsurePendingEvent;

		// Token: 0x0402D0D4 RID: 184532
		[Token(Token = "0x402D0D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetParam;

		// Token: 0x0402D0D5 RID: 184533
		[Token(Token = "0x402D0D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x0402D0D6 RID: 184534
		[Token(Token = "0x402D0D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTransType;

		// Token: 0x0402D0D7 RID: 184535
		[Token(Token = "0x402D0D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402D0D8 RID: 184536
		[Token(Token = "0x402D0D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402D0D9 RID: 184537
		[Token(Token = "0x402D0D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClicked;

		// Token: 0x0402D0DA RID: 184538
		[Token(Token = "0x402D0DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005889 RID: 22665
		[Token(Token = "0x2005889")]
		public class TotemModel : IHotfixable
		{
			// Token: 0x06021180 RID: 135552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021180")]
			[Address(RVA = "0x1B6D610", Offset = "0x1B6C210", VA = "0x181B6D610")]
			public void LoadData(string topicId, string totemItemId)
			{
			}

			// Token: 0x06021181 RID: 135553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021181")]
			[Address(RVA = "0x1B6D740", Offset = "0x1B6C340", VA = "0x181B6D740")]
			public TotemModel()
			{
			}

			// Token: 0x0402D0DB RID: 184539
			[Token(Token = "0x402D0DB")]
			[FieldOffset(Offset = "0x10")]
			public RL03TotemViewModel totem;

			// Token: 0x0402D0DC RID: 184540
			[Token(Token = "0x402D0DC")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x0402D0DD RID: 184541
			[Token(Token = "0x402D0DD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402D0DE RID: 184542
			[Token(Token = "0x402D0DE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200588A RID: 22666
		[Token(Token = "0x200588A")]
		public class ChaosModel : IHotfixable
		{
			// Token: 0x06021182 RID: 135554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021182")]
			[Address(RVA = "0x1B5B8C0", Offset = "0x1B5A4C0", VA = "0x181B5B8C0")]
			public void LoadData(string topicId, string chaosId)
			{
			}

			// Token: 0x06021183 RID: 135555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021183")]
			[Address(RVA = "0x1B5BAF0", Offset = "0x1B5A6F0", VA = "0x181B5BAF0")]
			public ChaosModel()
			{
			}

			// Token: 0x0402D0DF RID: 184543
			[Token(Token = "0x402D0DF")]
			[FieldOffset(Offset = "0x10")]
			public string chaosId;

			// Token: 0x0402D0E0 RID: 184544
			[Token(Token = "0x402D0E0")]
			[FieldOffset(Offset = "0x18")]
			public string chaosName;

			// Token: 0x0402D0E1 RID: 184545
			[Token(Token = "0x402D0E1")]
			[FieldOffset(Offset = "0x20")]
			public string chaosDesc;

			// Token: 0x0402D0E2 RID: 184546
			[Token(Token = "0x402D0E2")]
			[FieldOffset(Offset = "0x28")]
			public string chaosIconId;

			// Token: 0x0402D0E3 RID: 184547
			[Token(Token = "0x402D0E3")]
			[FieldOffset(Offset = "0x30")]
			public int chaosLevel;

			// Token: 0x0402D0E4 RID: 184548
			[Token(Token = "0x402D0E4")]
			[FieldOffset(Offset = "0x38")]
			public string description;

			// Token: 0x0402D0E5 RID: 184549
			[Token(Token = "0x402D0E5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402D0E6 RID: 184550
			[Token(Token = "0x402D0E6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200588B RID: 22667
		[Token(Token = "0x200588B")]
		public class PredictModel : IHotfixable
		{
			// Token: 0x06021184 RID: 135556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021184")]
			[Address(RVA = "0x1B5C540", Offset = "0x1B5B140", VA = "0x181B5C540")]
			public void LoadData(string topicId, string predictChaosId, string predictTotemId)
			{
			}

			// Token: 0x06021185 RID: 135557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021185")]
			[Address(RVA = "0x1B5C830", Offset = "0x1B5B430", VA = "0x181B5C830")]
			public PredictModel()
			{
			}

			// Token: 0x0402D0E7 RID: 184551
			[Token(Token = "0x402D0E7")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402D0E8 RID: 184552
			[Token(Token = "0x402D0E8")]
			[FieldOffset(Offset = "0x18")]
			public RL03SubTransPredictController.TotemModel predictTotemModel;

			// Token: 0x0402D0E9 RID: 184553
			[Token(Token = "0x402D0E9")]
			[FieldOffset(Offset = "0x20")]
			public RL03SubTransPredictController.ChaosModel predictChaosModel;

			// Token: 0x0402D0EA RID: 184554
			[Token(Token = "0x402D0EA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402D0EB RID: 184555
			[Token(Token = "0x402D0EB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
