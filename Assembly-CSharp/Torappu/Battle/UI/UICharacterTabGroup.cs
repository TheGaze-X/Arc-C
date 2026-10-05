using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032CF RID: 13007
	[Token(Token = "0x20032CF")]
	public class UICharacterTabGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x06014AE7 RID: 84711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F7")]
		public Transform infoTabRoot
		{
			[Token(Token = "0x6014AE7")]
			[Address(RVA = "0xD28560", Offset = "0xD27160", VA = "0x180D28560")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x06014AE8 RID: 84712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F8")]
		public Transform infoTabDetailPanelRoot
		{
			[Token(Token = "0x6014AE8")]
			[Address(RVA = "0xD28500", Offset = "0xD27100", VA = "0x180D28500")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06014AE9 RID: 84713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F9")]
		private List<UICharacterTabSwitchButton> tabButtons
		{
			[Token(Token = "0x6014AE9")]
			[Address(RVA = "0xD285C0", Offset = "0xD271C0", VA = "0x180D285C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014AEA RID: 84714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AEA")]
		[Address(RVA = "0xD27DB0", Offset = "0xD269B0", VA = "0x180D27DB0")]
		public void Reset()
		{
		}

		// Token: 0x06014AEB RID: 84715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AEB")]
		[Address(RVA = "0xD27B70", Offset = "0xD26770", VA = "0x180D27B70")]
		public void EnableTabInfomation(int mask)
		{
		}

		// Token: 0x06014AEC RID: 84716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AEC")]
		[Address(RVA = "0xD28080", Offset = "0xD26C80", VA = "0x180D28080")]
		public void ShowTabInfomation(int mask)
		{
		}

		// Token: 0x06014AED RID: 84717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AED")]
		[Address(RVA = "0xD28200", Offset = "0xD26E00", VA = "0x180D28200")]
		private void _OnTabClickedToShow(UICharacterTabSwitchButton button)
		{
		}

		// Token: 0x06014AEE RID: 84718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AEE")]
		[Address(RVA = "0xD28450", Offset = "0xD27050", VA = "0x180D28450")]
		public UICharacterTabGroup()
		{
		}

		// Token: 0x0401888D RID: 100493
		[Token(Token = "0x401888D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _root;

		// Token: 0x0401888E RID: 100494
		[Token(Token = "0x401888E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _rectRoot;

		// Token: 0x0401888F RID: 100495
		[Token(Token = "0x401888F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _infoTabRoot;

		// Token: 0x04018890 RID: 100496
		[Token(Token = "0x4018890")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _infoTabDetailPanelRoot;

		// Token: 0x04018891 RID: 100497
		[Token(Token = "0x4018891")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<float> _widthWhenShow;

		// Token: 0x04018892 RID: 100498
		[Token(Token = "0x4018892")]
		[FieldOffset(Offset = "0x40")]
		private List<UICharacterTabSwitchButton> m_tabButtons;

		// Token: 0x04018893 RID: 100499
		[Token(Token = "0x4018893")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_infoTabRoot;

		// Token: 0x04018894 RID: 100500
		[Token(Token = "0x4018894")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_infoTabDetailPanelRoot;

		// Token: 0x04018895 RID: 100501
		[Token(Token = "0x4018895")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tabButtons;

		// Token: 0x04018896 RID: 100502
		[Token(Token = "0x4018896")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04018897 RID: 100503
		[Token(Token = "0x4018897")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EnableTabInfomation;

		// Token: 0x04018898 RID: 100504
		[Token(Token = "0x4018898")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowTabInfomation;

		// Token: 0x04018899 RID: 100505
		[Token(Token = "0x4018899")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnTabClickedToShow;

		// Token: 0x0401889A RID: 100506
		[Token(Token = "0x401889A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032D0 RID: 13008
		[Token(Token = "0x20032D0")]
		public enum TabInfomationStyleEnum
		{
			// Token: 0x0401889C RID: 100508
			[Token(Token = "0x401889C")]
			SKILL,
			// Token: 0x0401889D RID: 100509
			[Token(Token = "0x401889D")]
			SUBPROFESSION_TRAIT,
			// Token: 0x0401889E RID: 100510
			[Token(Token = "0x401889E")]
			TRAIT,
			// Token: 0x0401889F RID: 100511
			[Token(Token = "0x401889F")]
			TALENT,
			// Token: 0x040188A0 RID: 100512
			[Token(Token = "0x40188A0")]
			LEGIONMODE_BUFF,
			// Token: 0x040188A1 RID: 100513
			[Token(Token = "0x40188A1")]
			AUTOCHESS_EQUIP,
			// Token: 0x040188A2 RID: 100514
			[Token(Token = "0x40188A2")]
			ENUM
		}
	}
}
