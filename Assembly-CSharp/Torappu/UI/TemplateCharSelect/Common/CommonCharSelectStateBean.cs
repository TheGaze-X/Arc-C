using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C04 RID: 23556
	[Token(Token = "0x2005C04")]
	public class CommonCharSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004FF3 RID: 20467
		// (get) Token: 0x0602224D RID: 139853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FF3")]
		public TemplateCharSelectMainProperty property
		{
			[Token(Token = "0x602224D")]
			[Address(RVA = "0x1C88B90", Offset = "0x1C87790", VA = "0x181C88B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602224E RID: 139854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602224E")]
		[Address(RVA = "0x1C888C0", Offset = "0x1C874C0", VA = "0x181C888C0")]
		public void SetInputData(TemplateCharSelectController.InputParam inputParam)
		{
		}

		// Token: 0x0602224F RID: 139855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602224F")]
		[Address(RVA = "0x1C88800", Offset = "0x1C87400", VA = "0x181C88800")]
		public void SetCustom(CommonCharSelectCustomization custom)
		{
		}

		// Token: 0x17004FF4 RID: 20468
		// (get) Token: 0x06022250 RID: 139856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FF4")]
		public TemplateCharSelectController.InputParam inputParam
		{
			[Token(Token = "0x6022250")]
			[Address(RVA = "0x1C88B30", Offset = "0x1C87730", VA = "0x181C88B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004FF5 RID: 20469
		// (get) Token: 0x06022251 RID: 139857 RVA: 0x000BC688 File Offset: 0x000BA888
		[Token(Token = "0x17004FF5")]
		public CommonCharSelectCustomization customization
		{
			[Token(Token = "0x6022251")]
			[Address(RVA = "0x1C88A90", Offset = "0x1C87690", VA = "0x181C88A90")]
			get
			{
				return default(CommonCharSelectCustomization);
			}
		}

		// Token: 0x06022252 RID: 139858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022252")]
		[Address(RVA = "0x1C88940", Offset = "0x1C87540", VA = "0x181C88940")]
		public CommonCharSelectStateBean()
		{
		}

		// Token: 0x0402ED09 RID: 191753
		[Token(Token = "0x402ED09")]
		[FieldOffset(Offset = "0x10")]
		private TemplateCharSelectController.InputParam m_param;

		// Token: 0x0402ED0A RID: 191754
		[Token(Token = "0x402ED0A")]
		[FieldOffset(Offset = "0x18")]
		private TemplateCharSelectMainProperty m_property;

		// Token: 0x0402ED0B RID: 191755
		[Token(Token = "0x402ED0B")]
		[FieldOffset(Offset = "0x20")]
		public CommonCharSelectCustomization m_custom;

		// Token: 0x0402ED0C RID: 191756
		[Token(Token = "0x402ED0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x0402ED0D RID: 191757
		[Token(Token = "0x402ED0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetInputData;

		// Token: 0x0402ED0E RID: 191758
		[Token(Token = "0x402ED0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCustom;

		// Token: 0x0402ED0F RID: 191759
		[Token(Token = "0x402ED0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_inputParam;

		// Token: 0x0402ED10 RID: 191760
		[Token(Token = "0x402ED10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_customization;

		// Token: 0x0402ED11 RID: 191761
		[Token(Token = "0x402ED11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
