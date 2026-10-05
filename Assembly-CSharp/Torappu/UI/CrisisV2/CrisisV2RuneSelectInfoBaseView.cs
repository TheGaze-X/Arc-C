using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059DF RID: 23007
	[Token(Token = "0x20059DF")]
	public abstract class CrisisV2RuneSelectInfoBaseView : MonoBehaviour, IHotfixable, ILayoutElement
	{
		// Token: 0x06021846 RID: 137286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021846")]
		[Address(RVA = "0x1BDB550", Offset = "0x1BDA150", VA = "0x181BDB550", Slot = "4")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06021847 RID: 137287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021847")]
		[Address(RVA = "0x1BDB5B0", Offset = "0x1BDA1B0", VA = "0x181BDB5B0", Slot = "5")]
		public void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x17004EBA RID: 20154
		// (get) Token: 0x06021848 RID: 137288 RVA: 0x000BA828 File Offset: 0x000B8A28
		[Token(Token = "0x17004EBA")]
		public float minWidth
		{
			[Token(Token = "0x6021848")]
			[Address(RVA = "0x1BDBA40", Offset = "0x1BDA640", VA = "0x181BDBA40", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004EBB RID: 20155
		// (get) Token: 0x06021849 RID: 137289 RVA: 0x000BA840 File Offset: 0x000B8A40
		[Token(Token = "0x17004EBB")]
		public float flexibleWidth
		{
			[Token(Token = "0x6021849")]
			[Address(RVA = "0x1BDB8E0", Offset = "0x1BDA4E0", VA = "0x181BDB8E0", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004EBC RID: 20156
		// (get) Token: 0x0602184A RID: 137290 RVA: 0x000BA858 File Offset: 0x000B8A58
		[Token(Token = "0x17004EBC")]
		public float minHeight
		{
			[Token(Token = "0x602184A")]
			[Address(RVA = "0x1BDB9C0", Offset = "0x1BDA5C0", VA = "0x181BDB9C0", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004EBD RID: 20157
		// (get) Token: 0x0602184B RID: 137291 RVA: 0x000BA870 File Offset: 0x000B8A70
		[Token(Token = "0x17004EBD")]
		public float flexibleHeight
		{
			[Token(Token = "0x602184B")]
			[Address(RVA = "0x1BDB860", Offset = "0x1BDA460", VA = "0x181BDB860", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004EBE RID: 20158
		// (get) Token: 0x0602184C RID: 137292 RVA: 0x000BA888 File Offset: 0x000B8A88
		[Token(Token = "0x17004EBE")]
		public int layoutPriority
		{
			[Token(Token = "0x602184C")]
			[Address(RVA = "0x1BDB960", Offset = "0x1BDA560", VA = "0x181BDB960", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004EBF RID: 20159
		// (get) Token: 0x0602184D RID: 137293
		[Token(Token = "0x17004EBF")]
		public abstract float preferredWidth { [Token(Token = "0x602184D")] get; }

		// Token: 0x17004EC0 RID: 20160
		// (get) Token: 0x0602184E RID: 137294
		[Token(Token = "0x17004EC0")]
		public abstract float preferredHeight { [Token(Token = "0x602184E")] get; }

		// Token: 0x17004EC1 RID: 20161
		// (get) Token: 0x0602184F RID: 137295
		[Token(Token = "0x17004EC1")]
		public abstract CanvasGroup alphaHandler { [Token(Token = "0x602184F")] get; }

		// Token: 0x06021850 RID: 137296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021850")]
		[Address(RVA = "0x1BDB6D0", Offset = "0x1BDA2D0", VA = "0x181BDB6D0")]
		public void Render(CrisisV2RuneBaseViewModel viewModel)
		{
		}

		// Token: 0x06021851 RID: 137297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021851")]
		[Address(RVA = "0x1BDB760", Offset = "0x1BDA360", VA = "0x181BDB760")]
		public void SetFocus(bool isFocused)
		{
		}

		// Token: 0x06021852 RID: 137298
		[Token(Token = "0x6021852")]
		protected abstract void OnDataUpdated(CrisisV2RuneBaseViewModel viewModel);

		// Token: 0x06021853 RID: 137299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021853")]
		[Address(RVA = "0x1BDB670", Offset = "0x1BDA270", VA = "0x181BDB670", Slot = "17")]
		protected virtual void OnFocusStatusChanged(bool isFocused)
		{
		}

		// Token: 0x06021854 RID: 137300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021854")]
		[Address(RVA = "0x1BDB610", Offset = "0x1BDA210", VA = "0x181BDB610", Slot = "18")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06021855 RID: 137301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021855")]
		[Address(RVA = "0x1BDB800", Offset = "0x1BDA400", VA = "0x181BDB800")]
		protected CrisisV2RuneSelectInfoBaseView()
		{
		}

		// Token: 0x0402DCCC RID: 187596
		[Token(Token = "0x402DCCC")]
		protected const float FOCUS_STAY_DUR = 1.5f;

		// Token: 0x0402DCCD RID: 187597
		[Token(Token = "0x402DCCD")]
		protected const float OUTER_GLOW_FOCUS_FADE_IN_DUR = 0.16f;

		// Token: 0x0402DCCE RID: 187598
		[Token(Token = "0x402DCCE")]
		protected const float OUTER_GLOW_FOCUS_FADE_OUT_DUR = 0.8f;

		// Token: 0x0402DCCF RID: 187599
		[Token(Token = "0x402DCCF")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isFocused;

		// Token: 0x0402DCD0 RID: 187600
		[Token(Token = "0x402DCD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x0402DCD1 RID: 187601
		[Token(Token = "0x402DCD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x0402DCD2 RID: 187602
		[Token(Token = "0x402DCD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x0402DCD3 RID: 187603
		[Token(Token = "0x402DCD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x0402DCD4 RID: 187604
		[Token(Token = "0x402DCD4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x0402DCD5 RID: 187605
		[Token(Token = "0x402DCD5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x0402DCD6 RID: 187606
		[Token(Token = "0x402DCD6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_layoutPriority;

		// Token: 0x0402DCD7 RID: 187607
		[Token(Token = "0x402DCD7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DCD8 RID: 187608
		[Token(Token = "0x402DCD8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetFocus;

		// Token: 0x0402DCD9 RID: 187609
		[Token(Token = "0x402DCD9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFocusStatusChanged;

		// Token: 0x0402DCDA RID: 187610
		[Token(Token = "0x402DCDA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402DCDB RID: 187611
		[Token(Token = "0x402DCDB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
