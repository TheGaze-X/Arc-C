using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF5 RID: 31477
	[Token(Token = "0x2007AF5")]
	public class Act12D6OuterBuffDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006746 RID: 26438
		// (get) Token: 0x0602C13D RID: 180541 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C13E RID: 180542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006746")]
		public UIStringEvent onClicked
		{
			[Token(Token = "0x602C13D")]
			[Address(RVA = "0x27F50F0", Offset = "0x27F3CF0", VA = "0x1827F50F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C13E")]
			[Address(RVA = "0x27F5150", Offset = "0x27F3D50", VA = "0x1827F5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C13F RID: 180543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C13F")]
		[Address(RVA = "0x27F4410", Offset = "0x27F3010", VA = "0x1827F4410")]
		public void Render(Act12D6OuterBuffDetailStateBean stateBean)
		{
		}

		// Token: 0x0602C140 RID: 180544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C140")]
		[Address(RVA = "0x27F4EB0", Offset = "0x27F3AB0", VA = "0x1827F4EB0")]
		private void _ScrollToNextInfo()
		{
		}

		// Token: 0x0602C141 RID: 180545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C141")]
		[Address(RVA = "0x27F4D40", Offset = "0x27F3940", VA = "0x1827F4D40")]
		private void _OnScrollRectTween(float pos)
		{
		}

		// Token: 0x0602C142 RID: 180546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C142")]
		[Address(RVA = "0x27F42F0", Offset = "0x27F2EF0", VA = "0x1827F42F0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602C143 RID: 180547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C143")]
		[Address(RVA = "0x27F5090", Offset = "0x27F3C90", VA = "0x1827F5090")]
		public Act12D6OuterBuffDetailView()
		{
		}

		// Token: 0x0403FDF6 RID: 261622
		[Token(Token = "0x403FDF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgLevelBg;

		// Token: 0x0403FDF7 RID: 261623
		[Token(Token = "0x403FDF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgLevel;

		// Token: 0x0403FDF8 RID: 261624
		[Token(Token = "0x403FDF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403FDF9 RID: 261625
		[Token(Token = "0x403FDF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtLevel;

		// Token: 0x0403FDFA RID: 261626
		[Token(Token = "0x403FDFA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtPrevLevel;

		// Token: 0x0403FDFB RID: 261627
		[Token(Token = "0x403FDFB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtNameLevel;

		// Token: 0x0403FDFC RID: 261628
		[Token(Token = "0x403FDFC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x0403FDFD RID: 261629
		[Token(Token = "0x403FDFD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollRect _effects;

		// Token: 0x0403FDFE RID: 261630
		[Token(Token = "0x403FDFE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _confirmTip;

		// Token: 0x0403FDFF RID: 261631
		[Token(Token = "0x403FDFF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _effectTxtObj;

		// Token: 0x0403FE01 RID: 261633
		[Token(Token = "0x403FE01")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isFullFlag;

		// Token: 0x0403FE02 RID: 261634
		[Token(Token = "0x403FE02")]
		[FieldOffset(Offset = "0x78")]
		private string m_buffId;

		// Token: 0x0403FE03 RID: 261635
		[Token(Token = "0x403FE03")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedNextLevel;

		// Token: 0x0403FE04 RID: 261636
		[Token(Token = "0x403FE04")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedFullLevel;

		// Token: 0x0403FE05 RID: 261637
		[Token(Token = "0x403FE05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0403FE06 RID: 261638
		[Token(Token = "0x403FE06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0403FE07 RID: 261639
		[Token(Token = "0x403FE07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FE08 RID: 261640
		[Token(Token = "0x403FE08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ScrollToNextInfo;

		// Token: 0x0403FE09 RID: 261641
		[Token(Token = "0x403FE09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnScrollRectTween;

		// Token: 0x0403FE0A RID: 261642
		[Token(Token = "0x403FE0A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403FE0B RID: 261643
		[Token(Token = "0x403FE0B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
