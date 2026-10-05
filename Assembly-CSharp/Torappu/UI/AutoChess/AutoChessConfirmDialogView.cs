using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062C0 RID: 25280
	[Token(Token = "0x20062C0")]
	public class AutoChessConfirmDialogView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170055BD RID: 21949
		// (get) Token: 0x060246C0 RID: 149184 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060246BF RID: 149183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055BD")]
		public Action onConfirm
		{
			[Token(Token = "0x60246C0")]
			[Address(RVA = "0x1F3CE80", Offset = "0x1F3BA80", VA = "0x181F3CE80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60246BF")]
			[Address(RVA = "0x1F3CF60", Offset = "0x1F3BB60", VA = "0x181F3CF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170055BE RID: 21950
		// (get) Token: 0x060246C2 RID: 149186 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060246C1 RID: 149185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055BE")]
		public Action onCancel
		{
			[Token(Token = "0x60246C2")]
			[Address(RVA = "0x1F3CE20", Offset = "0x1F3BA20", VA = "0x181F3CE20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60246C1")]
			[Address(RVA = "0x1F3CEE0", Offset = "0x1F3BAE0", VA = "0x181F3CEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060246C3 RID: 149187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246C3")]
		[Address(RVA = "0x1F3C740", Offset = "0x1F3B340", VA = "0x181F3C740")]
		public void Render(AutoChessConfirmDialogConfig config)
		{
		}

		// Token: 0x060246C4 RID: 149188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246C4")]
		[Address(RVA = "0x1F3CCC0", Offset = "0x1F3B8C0", VA = "0x181F3CCC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060246C5 RID: 149189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246C5")]
		[Address(RVA = "0x1F3CC40", Offset = "0x1F3B840", VA = "0x181F3CC40")]
		private void _ConfirmCheckBox()
		{
		}

		// Token: 0x060246C6 RID: 149190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246C6")]
		[Address(RVA = "0x1F3C360", Offset = "0x1F3AF60", VA = "0x181F3C360")]
		public void EventOnCheckboxClick()
		{
		}

		// Token: 0x060246C7 RID: 149191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246C7")]
		[Address(RVA = "0x1F3C430", Offset = "0x1F3B030", VA = "0x181F3C430")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x060246C8 RID: 149192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246C8")]
		[Address(RVA = "0x1F3C2A0", Offset = "0x1F3AEA0", VA = "0x181F3C2A0")]
		public void EventOnCancel()
		{
		}

		// Token: 0x060246C9 RID: 149193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246C9")]
		[Address(RVA = "0x1F3C550", Offset = "0x1F3B150", VA = "0x181F3C550")]
		public void OnBackPressed()
		{
		}

		// Token: 0x060246CA RID: 149194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246CA")]
		[Address(RVA = "0x1F3CDC0", Offset = "0x1F3B9C0", VA = "0x181F3CDC0")]
		public AutoChessConfirmDialogView()
		{
		}

		// Token: 0x04032B12 RID: 207634
		[Token(Token = "0x4032B12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("content")]
		private GameObject _contentWithoutCheckObj;

		// Token: 0x04032B13 RID: 207635
		[Token(Token = "0x4032B13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("content")]
		private Text _dialogContentText;

		// Token: 0x04032B14 RID: 207636
		[Token(Token = "0x4032B14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("content with check box")]
		private GameObject _contentWithCheckObj;

		// Token: 0x04032B15 RID: 207637
		[Token(Token = "0x4032B15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("content with check box")]
		private Text _dialogContentWithCheckText;

		// Token: 0x04032B16 RID: 207638
		[Token(Token = "0x4032B16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("check box")]
		private Text _checkBoxMsgText;

		// Token: 0x04032B17 RID: 207639
		[Token(Token = "0x4032B17")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("check box")]
		private CanvasGroup _checkBox;

		// Token: 0x04032B18 RID: 207640
		[Token(Token = "0x4032B18")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("btns")]
		private GameObject _cancelBtnObj;

		// Token: 0x04032B19 RID: 207641
		[Token(Token = "0x4032B19")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("btns")]
		private Text _cancelBtnText;

		// Token: 0x04032B1A RID: 207642
		[Token(Token = "0x4032B1A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("btns")]
		private GameObject _confirmBtnGreenBgObj;

		// Token: 0x04032B1B RID: 207643
		[Token(Token = "0x4032B1B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("btns")]
		private GameObject _confirmBtnRedBgObj;

		// Token: 0x04032B1C RID: 207644
		[Token(Token = "0x4032B1C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("btns")]
		private Text _confirmBtnText;

		// Token: 0x04032B1D RID: 207645
		[Token(Token = "0x4032B1D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("btns")]
		private Image _confirmBtnIcon;

		// Token: 0x04032B1E RID: 207646
		[Token(Token = "0x4032B1E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("btns")]
		private Color _colGreenBtnText;

		// Token: 0x04032B1F RID: 207647
		[Token(Token = "0x4032B1F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("btns")]
		private Color _colRedBtnText;

		// Token: 0x04032B20 RID: 207648
		[Token(Token = "0x4032B20")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("btns")]
		private Color _colGreenBtnIcon;

		// Token: 0x04032B21 RID: 207649
		[Token(Token = "0x4032B21")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("btns")]
		private Color _colRedBtnIcon;

		// Token: 0x04032B24 RID: 207652
		[Token(Token = "0x4032B24")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x04032B25 RID: 207653
		[Token(Token = "0x4032B25")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_checkBoxChecked;

		// Token: 0x04032B26 RID: 207654
		[Token(Token = "0x4032B26")]
		[FieldOffset(Offset = "0xCA")]
		private bool m_haveCheckBox;

		// Token: 0x04032B27 RID: 207655
		[Token(Token = "0x4032B27")]
		[FieldOffset(Offset = "0xD0")]
		private Action m_onCheckBoxConfirm;

		// Token: 0x04032B28 RID: 207656
		[Token(Token = "0x4032B28")]
		[FieldOffset(Offset = "0xD8")]
		private FadeSwitchTween m_checkBoxFade;

		// Token: 0x04032B29 RID: 207657
		[Token(Token = "0x4032B29")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_hasCancelBtn;

		// Token: 0x04032B2A RID: 207658
		[Token(Token = "0x4032B2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onConfirm;

		// Token: 0x04032B2B RID: 207659
		[Token(Token = "0x4032B2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onConfirm;

		// Token: 0x04032B2C RID: 207660
		[Token(Token = "0x4032B2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onCancel;

		// Token: 0x04032B2D RID: 207661
		[Token(Token = "0x4032B2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onCancel;

		// Token: 0x04032B2E RID: 207662
		[Token(Token = "0x4032B2E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032B2F RID: 207663
		[Token(Token = "0x4032B2F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032B30 RID: 207664
		[Token(Token = "0x4032B30")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConfirmCheckBox;

		// Token: 0x04032B31 RID: 207665
		[Token(Token = "0x4032B31")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnCheckboxClick;

		// Token: 0x04032B32 RID: 207666
		[Token(Token = "0x4032B32")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04032B33 RID: 207667
		[Token(Token = "0x4032B33")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnCancel;

		// Token: 0x04032B34 RID: 207668
		[Token(Token = "0x4032B34")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBackPressed;

		// Token: 0x04032B35 RID: 207669
		[Token(Token = "0x4032B35")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
