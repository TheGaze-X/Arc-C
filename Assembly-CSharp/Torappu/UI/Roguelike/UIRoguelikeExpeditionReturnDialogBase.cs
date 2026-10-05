using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005195 RID: 20885
	[Token(Token = "0x2005195")]
	public abstract class UIRoguelikeExpeditionReturnDialogBase : UICustomDialog<UIRoguelikeExpeditionReturnDialogBase.Options>
	{
		// Token: 0x0601EDB9 RID: 126393
		[Token(Token = "0x601EDB9")]
		protected abstract void RenderSingle(ExpeditionReturnDialogSingleData single, bool isLast);

		// Token: 0x0601EDBA RID: 126394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDBA")]
		[Address(RVA = "0x18ACD50", Offset = "0x18AB950", VA = "0x1818ACD50", Slot = "15")]
		protected virtual void PostProcessSingleList(ExpeditionReturnDialogData dialogData)
		{
		}

		// Token: 0x0601EDBB RID: 126395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDBB")]
		[Address(RVA = "0x18ACC10", Offset = "0x18AB810", VA = "0x1818ACC10", Slot = "7")]
		protected sealed override void OnRender(UIRoguelikeExpeditionReturnDialogBase.Options options)
		{
		}

		// Token: 0x0601EDBC RID: 126396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDBC")]
		[Address(RVA = "0x18ACB40", Offset = "0x18AB740", VA = "0x1818ACB40")]
		public void OnConfirmed()
		{
		}

		// Token: 0x0601EDBD RID: 126397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDBD")]
		[Address(RVA = "0x18ACDB0", Offset = "0x18AB9B0", VA = "0x1818ACDB0")]
		protected UIRoguelikeExpeditionReturnDialogBase()
		{
		}

		// Token: 0x04029654 RID: 169556
		[Token(Token = "0x4029654")]
		[FieldOffset(Offset = "0x50")]
		private Action m_onConfirmed;

		// Token: 0x04029655 RID: 169557
		[Token(Token = "0x4029655")]
		[FieldOffset(Offset = "0x58")]
		private readonly ExpeditionReturnDialogData m_dialogData;

		// Token: 0x04029656 RID: 169558
		[Token(Token = "0x4029656")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PostProcessSingleList;

		// Token: 0x04029657 RID: 169559
		[Token(Token = "0x4029657")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04029658 RID: 169560
		[Token(Token = "0x4029658")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmed;

		// Token: 0x04029659 RID: 169561
		[Token(Token = "0x4029659")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005196 RID: 20886
		[Token(Token = "0x2005196")]
		public struct Options
		{
			// Token: 0x0402965A RID: 169562
			[Token(Token = "0x402965A")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402965B RID: 169563
			[Token(Token = "0x402965B")]
			[FieldOffset(Offset = "0x8")]
			public PlayerRoguelikeV2.CurrentData.Troop playerTroop;

			// Token: 0x0402965C RID: 169564
			[Token(Token = "0x402965C")]
			[FieldOffset(Offset = "0x10")]
			public Action onConfirm;
		}
	}
}
