using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C0F RID: 23567
	[Token(Token = "0x2005C0F")]
	public class CommonCharSelectEnsureDefaultView : TemplateCharSelectEnsureView
	{
		// Token: 0x060222AE RID: 139950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222AE")]
		[Address(RVA = "0x1CACB90", Offset = "0x1CAB790", VA = "0x181CACB90")]
		public void EventOnClear()
		{
		}

		// Token: 0x060222AF RID: 139951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222AF")]
		[Address(RVA = "0x1CACC20", Offset = "0x1CAB820", VA = "0x181CACC20")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x060222B0 RID: 139952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B0")]
		[Address(RVA = "0x1CACCB0", Offset = "0x1CAB8B0", VA = "0x181CACCB0", Slot = "10")]
		protected override void OnRenderViewModel(TemplateCharSelectMainViewModel templateModel)
		{
		}

		// Token: 0x060222B1 RID: 139953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B1")]
		[Address(RVA = "0x1CACD50", Offset = "0x1CAB950", VA = "0x181CACD50")]
		public CommonCharSelectEnsureDefaultView()
		{
		}

		// Token: 0x060222B2 RID: 139954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222B2")]
		[Address(RVA = "0x1CACD40", Offset = "0x1CAB940", VA = "0x181CACD40")]
		private void <>xLuaBaseProxy_OnRenderViewModel(TemplateCharSelectMainViewModel P0)
		{
		}

		// Token: 0x0402EDB8 RID: 191928
		[Token(Token = "0x402EDB8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _clearBtn;

		// Token: 0x0402EDB9 RID: 191929
		[Token(Token = "0x402EDB9")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402EDBA RID: 191930
		[Token(Token = "0x402EDBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnClear;

		// Token: 0x0402EDBB RID: 191931
		[Token(Token = "0x402EDBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0402EDBC RID: 191932
		[Token(Token = "0x402EDBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0402EDBD RID: 191933
		[Token(Token = "0x402EDBD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
