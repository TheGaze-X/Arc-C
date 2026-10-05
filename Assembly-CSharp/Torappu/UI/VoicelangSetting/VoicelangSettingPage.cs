using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BB0 RID: 15280
	[Token(Token = "0x2003BB0")]
	public class VoicelangSettingPage : StateEnginePage, IHotfixable
	{
		// Token: 0x06017EF8 RID: 98040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EF8")]
		[Address(RVA = "0x10710C0", Offset = "0x106FCC0", VA = "0x1810710C0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06017EF9 RID: 98041 RVA: 0x00098B98 File Offset: 0x00096D98
		[Token(Token = "0x6017EF9")]
		[Address(RVA = "0x1070E20", Offset = "0x106FA20", VA = "0x181070E20", Slot = "18")]
		public override bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x06017EFA RID: 98042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EFA")]
		[Address(RVA = "0x1070F50", Offset = "0x106FB50", VA = "0x181070F50")]
		public void EventOnFilterClick()
		{
		}

		// Token: 0x06017EFB RID: 98043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EFB")]
		[Address(RVA = "0x1071120", Offset = "0x106FD20", VA = "0x181071120")]
		public void ReturnPage()
		{
		}

		// Token: 0x06017EFC RID: 98044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EFC")]
		[Address(RVA = "0x1071040", Offset = "0x106FC40", VA = "0x181071040", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06017EFD RID: 98045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EFD")]
		[Address(RVA = "0x10712A0", Offset = "0x106FEA0", VA = "0x1810712A0")]
		public VoicelangSettingPage()
		{
		}

		// Token: 0x06017EFE RID: 98046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EFE")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06017EFF RID: 98047 RVA: 0x00098BB0 File Offset: 0x00096DB0
		[Token(Token = "0x6017EFF")]
		[Address(RVA = "0x1071280", Offset = "0x106FE80", VA = "0x181071280")]
		private bool <>xLuaBaseProxy_CustomSetActive(bool P0)
		{
			return default(bool);
		}

		// Token: 0x06017F00 RID: 98048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F00")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401CF1B RID: 118555
		[Token(Token = "0x401CF1B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private LoopScrollRect _scrollRectToStop;

		// Token: 0x0401CF1C RID: 118556
		[Token(Token = "0x401CF1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0401CF1D RID: 118557
		[Token(Token = "0x401CF1D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x0401CF1E RID: 118558
		[Token(Token = "0x401CF1E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnFilterClick;

		// Token: 0x0401CF1F RID: 118559
		[Token(Token = "0x401CF1F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReturnPage;

		// Token: 0x0401CF20 RID: 118560
		[Token(Token = "0x401CF20")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401CF21 RID: 118561
		[Token(Token = "0x401CF21")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
