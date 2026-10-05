using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C0B RID: 23563
	[Token(Token = "0x2005C0B")]
	public class CommonCharSelectDetailDefaultView : TemplateCharSelectDetailViewBase<CommonCharSelectDetailDefaultViewModel>
	{
		// Token: 0x06022288 RID: 139912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022288")]
		[Address(RVA = "0x1CAAE90", Offset = "0x1CA9A90", VA = "0x181CAAE90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022289 RID: 139913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022289")]
		[Address(RVA = "0x1CAABE0", Offset = "0x1CA97E0", VA = "0x181CAABE0", Slot = "11")]
		protected override void OnRenderViewModel()
		{
		}

		// Token: 0x0602228A RID: 139914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602228A")]
		[Address(RVA = "0x1CAB030", Offset = "0x1CA9C30", VA = "0x181CAB030")]
		private void _OnDetailClick(CommonCharSelectDetailDefaultViewModel detailViewModel)
		{
		}

		// Token: 0x0602228B RID: 139915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602228B")]
		[Address(RVA = "0x1CAB210", Offset = "0x1CA9E10", VA = "0x181CAB210")]
		public CommonCharSelectDetailDefaultView()
		{
		}

		// Token: 0x0402ED68 RID: 191848
		[Token(Token = "0x402ED68")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CommonCharSelectDetailPlugin _detailPlugin;

		// Token: 0x0402ED69 RID: 191849
		[Token(Token = "0x402ED69")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0402ED6A RID: 191850
		[Token(Token = "0x402ED6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402ED6B RID: 191851
		[Token(Token = "0x402ED6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0402ED6C RID: 191852
		[Token(Token = "0x402ED6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnDetailClick;

		// Token: 0x0402ED6D RID: 191853
		[Token(Token = "0x402ED6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
