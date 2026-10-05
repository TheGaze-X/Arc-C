using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200335A RID: 13146
	[Token(Token = "0x200335A")]
	public class UIHudCharMinusHpSlider : UIFollowHpSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x06014FA8 RID: 85928 RVA: 0x00089E20 File Offset: 0x00088020
		[Token(Token = "0x170031CA")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FA8")]
			[Address(RVA = "0xD5C780", Offset = "0xD5B380", VA = "0x180D5C780", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x06014FA9 RID: 85929 RVA: 0x00089E38 File Offset: 0x00088038
		[Token(Token = "0x170031CB")]
		public bool needToShow
		{
			[Token(Token = "0x6014FA9")]
			[Address(RVA = "0xD5C7E0", Offset = "0xD5B3E0", VA = "0x180D5C7E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FAA RID: 85930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FAA")]
		[Address(RVA = "0xD5BDF0", Offset = "0xD5A9F0", VA = "0x180D5BDF0", Slot = "11")]
		public virtual void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FAB RID: 85931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FAB")]
		[Address(RVA = "0xD5C020", Offset = "0xD5AC20", VA = "0x180D5C020", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FAC RID: 85932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FAC")]
		[Address(RVA = "0xD5C340", Offset = "0xD5AF40", VA = "0x180D5C340", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FAD RID: 85933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FAD")]
		[Address(RVA = "0xD5C690", Offset = "0xD5B290", VA = "0x180D5C690")]
		private void _OnSideSwitch(object arg)
		{
		}

		// Token: 0x06014FAE RID: 85934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FAE")]
		[Address(RVA = "0xD5C150", Offset = "0xD5AD50", VA = "0x180D5C150", Slot = "12")]
		protected virtual void SetHpSliderFillColorBySideAndHealth()
		{
		}

		// Token: 0x06014FAF RID: 85935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FAF")]
		[Address(RVA = "0xD5C720", Offset = "0xD5B320", VA = "0x180D5C720")]
		public UIHudCharMinusHpSlider()
		{
		}

		// Token: 0x04018F3F RID: 102207
		[Token(Token = "0x4018F3F")]
		[FieldOffset(Offset = "0x48")]
		private Character m_char;

		// Token: 0x04018F40 RID: 102208
		[Token(Token = "0x4018F40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F41 RID: 102209
		[Token(Token = "0x4018F41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F42 RID: 102210
		[Token(Token = "0x4018F42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F43 RID: 102211
		[Token(Token = "0x4018F43")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F44 RID: 102212
		[Token(Token = "0x4018F44")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F45 RID: 102213
		[Token(Token = "0x4018F45")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSideSwitch;

		// Token: 0x04018F46 RID: 102214
		[Token(Token = "0x4018F46")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetHpSliderFillColorBySideAndHealth;

		// Token: 0x04018F47 RID: 102215
		[Token(Token = "0x4018F47")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
