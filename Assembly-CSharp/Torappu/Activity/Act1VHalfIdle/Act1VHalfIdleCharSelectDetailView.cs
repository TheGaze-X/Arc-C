using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007702 RID: 30466
	[Token(Token = "0x2007702")]
	public class Act1VHalfIdleCharSelectDetailView : TemplateCharSelectDetailViewBase<CommonCharSelectDetailDefaultViewModel>
	{
		// Token: 0x0602ACDA RID: 175322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACDA")]
		[Address(RVA = "0x2698B90", Offset = "0x2697790", VA = "0x182698B90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602ACDB RID: 175323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACDB")]
		[Address(RVA = "0x2698830", Offset = "0x2697430", VA = "0x182698830", Slot = "11")]
		protected override void OnRenderViewModel()
		{
		}

		// Token: 0x0602ACDC RID: 175324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACDC")]
		[Address(RVA = "0x2698D30", Offset = "0x2697930", VA = "0x182698D30")]
		private void _OnDetailClick(CommonCharSelectDetailDefaultViewModel detailViewModel)
		{
		}

		// Token: 0x0602ACDD RID: 175325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACDD")]
		[Address(RVA = "0x2698AE0", Offset = "0x26976E0", VA = "0x182698AE0", Slot = "9")]
		public override void RegisterTutorialGO()
		{
		}

		// Token: 0x0602ACDE RID: 175326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACDE")]
		[Address(RVA = "0x26990B0", Offset = "0x2697CB0", VA = "0x1826990B0")]
		public Act1VHalfIdleCharSelectDetailView()
		{
		}

		// Token: 0x0602ACDF RID: 175327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACDF")]
		[Address(RVA = "0x2698B80", Offset = "0x2697780", VA = "0x182698B80")]
		private void <>xLuaBaseProxy_RegisterTutorialGO()
		{
		}

		// Token: 0x0403DAEE RID: 252654
		[Token(Token = "0x403DAEE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CommonCharSelectDetailPlugin _detailPlugin;

		// Token: 0x0403DAEF RID: 252655
		[Token(Token = "0x403DAEF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _btnDetailGO;

		// Token: 0x0403DAF0 RID: 252656
		[Token(Token = "0x403DAF0")]
		[FieldOffset(Offset = "0x40")]
		private List<string> m_charList;

		// Token: 0x0403DAF1 RID: 252657
		[Token(Token = "0x403DAF1")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0403DAF2 RID: 252658
		[Token(Token = "0x403DAF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DAF3 RID: 252659
		[Token(Token = "0x403DAF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0403DAF4 RID: 252660
		[Token(Token = "0x403DAF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnDetailClick;

		// Token: 0x0403DAF5 RID: 252661
		[Token(Token = "0x403DAF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DAF6 RID: 252662
		[Token(Token = "0x403DAF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
