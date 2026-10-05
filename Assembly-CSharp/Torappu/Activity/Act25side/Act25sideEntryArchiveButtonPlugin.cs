using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074D5 RID: 29909
	[Token(Token = "0x20074D5")]
	public class Act25sideEntryArchiveButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A2AB RID: 172715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2AB")]
		[Address(RVA = "0x25C82E0", Offset = "0x25C6EE0", VA = "0x1825C82E0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A2AC RID: 172716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2AC")]
		[Address(RVA = "0x25C8030", Offset = "0x25C6C30", VA = "0x1825C8030")]
		public void OnClicked()
		{
		}

		// Token: 0x0602A2AD RID: 172717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2AD")]
		[Address(RVA = "0x25C8500", Offset = "0x25C7100", VA = "0x1825C8500")]
		public Act25sideEntryArchiveButtonPlugin()
		{
		}

		// Token: 0x0403C91A RID: 248090
		[Token(Token = "0x403C91A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403C91B RID: 248091
		[Token(Token = "0x403C91B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasContent;

		// Token: 0x0403C91C RID: 248092
		[Token(Token = "0x403C91C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x0403C91D RID: 248093
		[Token(Token = "0x403C91D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403C91E RID: 248094
		[Token(Token = "0x403C91E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _alphaInaccessible;

		// Token: 0x0403C91F RID: 248095
		[Token(Token = "0x403C91F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C920 RID: 248096
		[Token(Token = "0x403C920")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403C921 RID: 248097
		[Token(Token = "0x403C921")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
