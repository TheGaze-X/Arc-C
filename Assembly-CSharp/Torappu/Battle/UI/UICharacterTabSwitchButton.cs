using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032D2 RID: 13010
	[Token(Token = "0x20032D2")]
	public class UICharacterTabSwitchButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x06014AF4 RID: 84724 RVA: 0x00087F90 File Offset: 0x00086190
		[Token(Token = "0x170030FC")]
		public UICharacterTabGroup.TabInfomationStyleEnum buttonType
		{
			[Token(Token = "0x6014AF4")]
			[Address(RVA = "0xD28A10", Offset = "0xD27610", VA = "0x180D28A10")]
			get
			{
				return UICharacterTabGroup.TabInfomationStyleEnum.SKILL;
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x06014AF5 RID: 84725 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014AF6 RID: 84726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030FD")]
		public Action<UICharacterTabSwitchButton> onTabClicked
		{
			[Token(Token = "0x6014AF5")]
			[Address(RVA = "0xD28A70", Offset = "0xD27670", VA = "0x180D28A70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6014AF6")]
			[Address(RVA = "0xD28B30", Offset = "0xD27730", VA = "0x180D28B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x06014AF7 RID: 84727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030FE")]
		public Image splitImage
		{
			[Token(Token = "0x6014AF7")]
			[Address(RVA = "0xD28AD0", Offset = "0xD276D0", VA = "0x180D28AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014AF8 RID: 84728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AF8")]
		[Address(RVA = "0xD288A0", Offset = "0xD274A0", VA = "0x180D288A0")]
		public void Show()
		{
		}

		// Token: 0x06014AF9 RID: 84729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AF9")]
		[Address(RVA = "0xD28790", Offset = "0xD27390", VA = "0x180D28790")]
		public void Hide()
		{
		}

		// Token: 0x06014AFA RID: 84730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AFA")]
		[Address(RVA = "0xD28680", Offset = "0xD27280", VA = "0x180D28680")]
		public void EventOnTabClicked()
		{
		}

		// Token: 0x06014AFB RID: 84731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AFB")]
		[Address(RVA = "0xD289B0", Offset = "0xD275B0", VA = "0x180D289B0")]
		public UICharacterTabSwitchButton()
		{
		}

		// Token: 0x040188AD RID: 100525
		[Token(Token = "0x40188AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _splitImage;

		// Token: 0x040188AE RID: 100526
		[Token(Token = "0x40188AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _displayedPanel;

		// Token: 0x040188AF RID: 100527
		[Token(Token = "0x40188AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _highlightTriangleGraphic;

		// Token: 0x040188B0 RID: 100528
		[Token(Token = "0x40188B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _highlightGraphic;

		// Token: 0x040188B1 RID: 100529
		[Token(Token = "0x40188B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x040188B2 RID: 100530
		[Token(Token = "0x40188B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Text Color")]
		private Color _textHideColor;

		// Token: 0x040188B3 RID: 100531
		[Token(Token = "0x40188B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Text Color")]
		private Color _textShowColor;

		// Token: 0x040188B4 RID: 100532
		[Token(Token = "0x40188B4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICharacterTabGroup.TabInfomationStyleEnum _buttonType;

		// Token: 0x040188B6 RID: 100534
		[Token(Token = "0x40188B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buttonType;

		// Token: 0x040188B7 RID: 100535
		[Token(Token = "0x40188B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onTabClicked;

		// Token: 0x040188B8 RID: 100536
		[Token(Token = "0x40188B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onTabClicked;

		// Token: 0x040188B9 RID: 100537
		[Token(Token = "0x40188B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_splitImage;

		// Token: 0x040188BA RID: 100538
		[Token(Token = "0x40188BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040188BB RID: 100539
		[Token(Token = "0x40188BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040188BC RID: 100540
		[Token(Token = "0x40188BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnTabClicked;

		// Token: 0x040188BD RID: 100541
		[Token(Token = "0x40188BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
