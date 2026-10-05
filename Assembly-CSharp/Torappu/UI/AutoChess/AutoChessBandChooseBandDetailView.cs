using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200628A RID: 25226
	[Token(Token = "0x200628A")]
	public class AutoChessBandChooseBandDetailView : DataBinder<AutoChessBandChooseProperty>, IHotfixable
	{
		// Token: 0x06024607 RID: 148999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024607")]
		[Address(RVA = "0x1F22B30", Offset = "0x1F21730", VA = "0x181F22B30", Slot = "7")]
		public sealed override void OnValueChanged(AutoChessBandChooseProperty property)
		{
		}

		// Token: 0x06024608 RID: 149000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024608")]
		[Address(RVA = "0x1F22AA0", Offset = "0x1F216A0", VA = "0x181F22AA0")]
		public void EventOnSelectBtnClicked()
		{
		}

		// Token: 0x06024609 RID: 149001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024609")]
		[Address(RVA = "0x1F22F50", Offset = "0x1F21B50", VA = "0x181F22F50")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x0602460A RID: 149002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602460A")]
		[Address(RVA = "0x1F230B0", Offset = "0x1F21CB0", VA = "0x181F230B0")]
		public AutoChessBandChooseBandDetailView()
		{
		}

		// Token: 0x04032981 RID: 207233
		[Token(Token = "0x4032981")]
		private const int DISPLAY_COMPLETE_TIME = 0;

		// Token: 0x04032982 RID: 207234
		[Token(Token = "0x4032982")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x04032983 RID: 207235
		[Token(Token = "0x4032983")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelVictor;

		// Token: 0x04032984 RID: 207236
		[Token(Token = "0x4032984")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCompleteDesc;

		// Token: 0x04032985 RID: 207237
		[Token(Token = "0x4032985")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textHp;

		// Token: 0x04032986 RID: 207238
		[Token(Token = "0x4032986")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04032987 RID: 207239
		[Token(Token = "0x4032987")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04032988 RID: 207240
		[Token(Token = "0x4032988")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04032989 RID: 207241
		[Token(Token = "0x4032989")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelWaiting;

		// Token: 0x0403298A RID: 207242
		[Token(Token = "0x403298A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelSelect;

		// Token: 0x0403298B RID: 207243
		[Token(Token = "0x403298B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelOtherSelected;

		// Token: 0x0403298C RID: 207244
		[Token(Token = "0x403298C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelDetailFocus;

		// Token: 0x0403298D RID: 207245
		[Token(Token = "0x403298D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelConfirmFocus;

		// Token: 0x0403298E RID: 207246
		[Token(Token = "0x403298E")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403298F RID: 207247
		[Token(Token = "0x403298F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032990 RID: 207248
		[Token(Token = "0x4032990")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnSelectBtnClicked;

		// Token: 0x04032991 RID: 207249
		[Token(Token = "0x4032991")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x04032992 RID: 207250
		[Token(Token = "0x4032992")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
