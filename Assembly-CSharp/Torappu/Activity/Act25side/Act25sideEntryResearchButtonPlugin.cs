using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074D6 RID: 29910
	[Token(Token = "0x20074D6")]
	public class Act25sideEntryResearchButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A2AE RID: 172718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2AE")]
		[Address(RVA = "0x25C8A20", Offset = "0x25C7620", VA = "0x1825C8A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A2AF RID: 172719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2AF")]
		[Address(RVA = "0x25C8690", Offset = "0x25C7290", VA = "0x1825C8690", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A2B0 RID: 172720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B0")]
		[Address(RVA = "0x25C8570", Offset = "0x25C7170", VA = "0x1825C8570")]
		public void OnClicked()
		{
		}

		// Token: 0x0602A2B1 RID: 172721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B1")]
		[Address(RVA = "0x25C8B50", Offset = "0x25C7750", VA = "0x1825C8B50")]
		public Act25sideEntryResearchButtonPlugin()
		{
		}

		// Token: 0x0403C922 RID: 248098
		[Token(Token = "0x403C922")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403C923 RID: 248099
		[Token(Token = "0x403C923")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasContent;

		// Token: 0x0403C924 RID: 248100
		[Token(Token = "0x403C924")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x0403C925 RID: 248101
		[Token(Token = "0x403C925")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x0403C926 RID: 248102
		[Token(Token = "0x403C926")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403C927 RID: 248103
		[Token(Token = "0x403C927")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _trackPointContainer;

		// Token: 0x0403C928 RID: 248104
		[Token(Token = "0x403C928")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _alphaInaccessible;

		// Token: 0x0403C929 RID: 248105
		[Token(Token = "0x403C929")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_hasInited;

		// Token: 0x0403C92A RID: 248106
		[Token(Token = "0x403C92A")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_trackPoint;

		// Token: 0x0403C92B RID: 248107
		[Token(Token = "0x403C92B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C92C RID: 248108
		[Token(Token = "0x403C92C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C92D RID: 248109
		[Token(Token = "0x403C92D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403C92E RID: 248110
		[Token(Token = "0x403C92E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
