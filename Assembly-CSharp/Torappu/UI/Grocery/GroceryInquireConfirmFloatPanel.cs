using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CC3 RID: 19651
	[Token(Token = "0x2004CC3")]
	public class GroceryInquireConfirmFloatPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x0601D704 RID: 120580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004506")]
		public UIFadeFloatPanel fadeFloatPanel
		{
			[Token(Token = "0x601D704")]
			[Address(RVA = "0x16FA640", Offset = "0x16F9240", VA = "0x1816FA640")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D705 RID: 120581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D705")]
		[Address(RVA = "0x16FA280", Offset = "0x16F8E80", VA = "0x1816FA280")]
		public void Render(GroceryInquireConfirmFloatPanel.ParamBase input)
		{
		}

		// Token: 0x0601D706 RID: 120582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D706")]
		[Address(RVA = "0x16FA180", Offset = "0x16F8D80", VA = "0x1816FA180")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0601D707 RID: 120583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D707")]
		[Address(RVA = "0x16FA1F0", Offset = "0x16F8DF0", VA = "0x1816FA1F0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601D708 RID: 120584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D708")]
		[Address(RVA = "0x16FA4D0", Offset = "0x16F90D0", VA = "0x1816FA4D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D709 RID: 120585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D709")]
		[Address(RVA = "0x16FA5E0", Offset = "0x16F91E0", VA = "0x1816FA5E0")]
		public GroceryInquireConfirmFloatPanel()
		{
		}

		// Token: 0x04026CC4 RID: 158916
		[Token(Token = "0x4026CC4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFadeFloatPanel _fadeFloatPanel;

		// Token: 0x04026CC5 RID: 158917
		[Token(Token = "0x4026CC5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtInquireInfo;

		// Token: 0x04026CC6 RID: 158918
		[Token(Token = "0x4026CC6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtInquireTips;

		// Token: 0x04026CC7 RID: 158919
		[Token(Token = "0x4026CC7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rectBackBtn;

		// Token: 0x04026CC8 RID: 158920
		[Token(Token = "0x4026CC8")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04026CC9 RID: 158921
		[Token(Token = "0x4026CC9")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedGoodId;

		// Token: 0x04026CCA RID: 158922
		[Token(Token = "0x4026CCA")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedShopId;

		// Token: 0x04026CCB RID: 158923
		[Token(Token = "0x4026CCB")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isDataValid;

		// Token: 0x04026CCC RID: 158924
		[Token(Token = "0x4026CCC")]
		[FieldOffset(Offset = "0x58")]
		private Action<string, string> m_onConfirm;

		// Token: 0x04026CCD RID: 158925
		[Token(Token = "0x4026CCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fadeFloatPanel;

		// Token: 0x04026CCE RID: 158926
		[Token(Token = "0x4026CCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026CCF RID: 158927
		[Token(Token = "0x4026CCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x04026CD0 RID: 158928
		[Token(Token = "0x4026CD0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x04026CD1 RID: 158929
		[Token(Token = "0x4026CD1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026CD2 RID: 158930
		[Token(Token = "0x4026CD2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CC4 RID: 19652
		[Token(Token = "0x2004CC4")]
		public abstract class ParamBase : IHotfixable
		{
			// Token: 0x0601D70A RID: 120586
			[Token(Token = "0x601D70A")]
			public abstract bool IsValid();

			// Token: 0x0601D70B RID: 120587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D70B")]
			[Address(RVA = "0x170C6B0", Offset = "0x170B2B0", VA = "0x18170C6B0")]
			protected ParamBase()
			{
			}

			// Token: 0x04026CD3 RID: 158931
			[Token(Token = "0x4026CD3")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x04026CD4 RID: 158932
			[Token(Token = "0x4026CD4")]
			[FieldOffset(Offset = "0x18")]
			public string shopId;

			// Token: 0x04026CD5 RID: 158933
			[Token(Token = "0x4026CD5")]
			[FieldOffset(Offset = "0x20")]
			public string confirmInfo;

			// Token: 0x04026CD6 RID: 158934
			[Token(Token = "0x4026CD6")]
			[FieldOffset(Offset = "0x28")]
			public string confirmTips;

			// Token: 0x04026CD7 RID: 158935
			[Token(Token = "0x4026CD7")]
			[FieldOffset(Offset = "0x30")]
			public Action<string, string> onConfirm;

			// Token: 0x04026CD8 RID: 158936
			[Token(Token = "0x4026CD8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004CC5 RID: 19653
		[Token(Token = "0x2004CC5")]
		public class OrderInputParams : GroceryInquireConfirmFloatPanel.ParamBase
		{
			// Token: 0x0601D70C RID: 120588 RVA: 0x000AB708 File Offset: 0x000A9908
			[Token(Token = "0x601D70C")]
			[Address(RVA = "0x170C590", Offset = "0x170B190", VA = "0x18170C590", Slot = "4")]
			public override bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x0601D70D RID: 120589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D70D")]
			[Address(RVA = "0x170C610", Offset = "0x170B210", VA = "0x18170C610")]
			public OrderInputParams()
			{
			}

			// Token: 0x04026CD9 RID: 158937
			[Token(Token = "0x4026CD9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsValid;

			// Token: 0x04026CDA RID: 158938
			[Token(Token = "0x4026CDA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004CC6 RID: 19654
		[Token(Token = "0x2004CC6")]
		public class SellInputParams : GroceryInquireConfirmFloatPanel.ParamBase
		{
			// Token: 0x0601D70E RID: 120590 RVA: 0x000AB720 File Offset: 0x000A9920
			[Token(Token = "0x601D70E")]
			[Address(RVA = "0x170C770", Offset = "0x170B370", VA = "0x18170C770", Slot = "4")]
			public override bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x0601D70F RID: 120591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D70F")]
			[Address(RVA = "0x170C7E0", Offset = "0x170B3E0", VA = "0x18170C7E0")]
			public SellInputParams()
			{
			}

			// Token: 0x04026CDB RID: 158939
			[Token(Token = "0x4026CDB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsValid;

			// Token: 0x04026CDC RID: 158940
			[Token(Token = "0x4026CDC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
