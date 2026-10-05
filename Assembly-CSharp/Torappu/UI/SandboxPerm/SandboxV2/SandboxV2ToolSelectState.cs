using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200444E RID: 17486
	[Token(Token = "0x200444E")]
	public class SandboxV2ToolSelectState : PopupFadeState
	{
		// Token: 0x0601AB88 RID: 109448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB88")]
		[Address(RVA = "0x13E9C10", Offset = "0x13E8810", VA = "0x1813E9C10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601AB89 RID: 109449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB89")]
		[Address(RVA = "0x13E9C70", Offset = "0x13E8870", VA = "0x1813E9C70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601AB8A RID: 109450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB8A")]
		[Address(RVA = "0x13EA080", Offset = "0x13E8C80", VA = "0x1813EA080", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601AB8B RID: 109451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB8B")]
		[Address(RVA = "0x13EA380", Offset = "0x13E8F80", VA = "0x1813EA380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AB8C RID: 109452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB8C")]
		[Address(RVA = "0x13EA270", Offset = "0x13E8E70", VA = "0x1813EA270")]
		private void _EventOnToolItemClick(int toolIdx)
		{
		}

		// Token: 0x0601AB8D RID: 109453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB8D")]
		[Address(RVA = "0x13EA1F0", Offset = "0x13E8DF0", VA = "0x1813EA1F0")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x0601AB8E RID: 109454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB8E")]
		[Address(RVA = "0x13E9660", Offset = "0x13E8260", VA = "0x1813E9660")]
		public void EventOnBtnBack()
		{
		}

		// Token: 0x0601AB8F RID: 109455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB8F")]
		[Address(RVA = "0x13E9710", Offset = "0x13E8310", VA = "0x1813E9710")]
		public void EventOnBtnClear()
		{
		}

		// Token: 0x0601AB90 RID: 109456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB90")]
		[Address(RVA = "0x13E98A0", Offset = "0x13E84A0", VA = "0x1813E98A0")]
		public void EventOnBtnConfirm()
		{
		}

		// Token: 0x0601AB91 RID: 109457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB91")]
		[Address(RVA = "0x13E9980", Offset = "0x13E8580", VA = "0x1813E9980")]
		public void EventOnBtnNavWorkbench()
		{
		}

		// Token: 0x0601AB92 RID: 109458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB92")]
		[Address(RVA = "0x13EA550", Offset = "0x13E9150", VA = "0x1813EA550")]
		public SandboxV2ToolSelectState()
		{
		}

		// Token: 0x0601AB93 RID: 109459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB93")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601AB94 RID: 109460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB94")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040221FE RID: 139774
		[Token(Token = "0x40221FE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x040221FF RID: 139775
		[Token(Token = "0x40221FF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2ToolSelectView _view;

		// Token: 0x04022200 RID: 139776
		[Token(Token = "0x4022200")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04022201 RID: 139777
		[Token(Token = "0x4022201")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2ToolSelectStateBean m_stateBean;

		// Token: 0x04022202 RID: 139778
		[Token(Token = "0x4022202")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022203 RID: 139779
		[Token(Token = "0x4022203")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022204 RID: 139780
		[Token(Token = "0x4022204")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04022205 RID: 139781
		[Token(Token = "0x4022205")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022206 RID: 139782
		[Token(Token = "0x4022206")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnToolItemClick;

		// Token: 0x04022207 RID: 139783
		[Token(Token = "0x4022207")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04022208 RID: 139784
		[Token(Token = "0x4022208")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnBack;

		// Token: 0x04022209 RID: 139785
		[Token(Token = "0x4022209")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnClear;

		// Token: 0x0402220A RID: 139786
		[Token(Token = "0x402220A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBtnConfirm;

		// Token: 0x0402220B RID: 139787
		[Token(Token = "0x402220B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBtnNavWorkbench;

		// Token: 0x0402220C RID: 139788
		[Token(Token = "0x402220C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
