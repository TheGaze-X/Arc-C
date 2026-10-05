using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001938 RID: 6456
	[Token(Token = "0x2001938")]
	public class DIYFurnitureDetailPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A266 RID: 41574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A266")]
		[Address(RVA = "0x31BEF40", Offset = "0x31BDB40", VA = "0x1831BEF40")]
		private IEnumerator _LayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A267")]
		[Address(RVA = "0x31BE6E0", Offset = "0x31BD2E0", VA = "0x1831BE6E0")]
		public void Setup(IDIYItem diyItem, string themeName, string groupName, int count)
		{
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A268")]
		[Address(RVA = "0x31BE290", Offset = "0x31BCE90", VA = "0x1831BE290")]
		public void SetupTheme(DIYPage.FurnitureThemeViewData diyItemViewData)
		{
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A269")]
		[Address(RVA = "0x31BEC10", Offset = "0x31BD810", VA = "0x1831BEC10")]
		public void Show()
		{
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A26A")]
		[Address(RVA = "0x31BDF80", Offset = "0x31BCB80", VA = "0x1831BDF80")]
		public void Hide()
		{
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A26B")]
		[Address(RVA = "0x31BE0F0", Offset = "0x31BCCF0", VA = "0x1831BE0F0")]
		public void OnCloseButtonPressed()
		{
		}

		// Token: 0x0600A26C RID: 41580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A26C")]
		[Address(RVA = "0x31BEFF0", Offset = "0x31BDBF0", VA = "0x1831BEFF0")]
		public DIYFurnitureDetailPanel()
		{
		}

		// Token: 0x040098A6 RID: 39078
		[Token(Token = "0x40098A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _furnitureNameLabel;

		// Token: 0x040098A7 RID: 39079
		[Token(Token = "0x40098A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _themeLabel;

		// Token: 0x040098A8 RID: 39080
		[Token(Token = "0x40098A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _groupLabel;

		// Token: 0x040098A9 RID: 39081
		[Token(Token = "0x40098A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _themeGroupPanel;

		// Token: 0x040098AA RID: 39082
		[Token(Token = "0x40098AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DIYFurnitureDetailPanel.UsageDescGroup _lowerGroup;

		// Token: 0x040098AB RID: 39083
		[Token(Token = "0x40098AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DIYFurnitureDetailPanel.UsageDescGroup _upperGroup;

		// Token: 0x040098AC RID: 39084
		[Token(Token = "0x40098AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _furnitureIcon;

		// Token: 0x040098AD RID: 39085
		[Token(Token = "0x40098AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _meetingOnlyIcon;

		// Token: 0x040098AE RID: 39086
		[Token(Token = "0x40098AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _comfortPanel;

		// Token: 0x040098AF RID: 39087
		[Token(Token = "0x40098AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _comfortLabel;

		// Token: 0x040098B0 RID: 39088
		[Token(Token = "0x40098B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObjectArrayCountControl _rarityStarArray;

		// Token: 0x040098B1 RID: 39089
		[Token(Token = "0x40098B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _okButton;

		// Token: 0x040098B2 RID: 39090
		[Token(Token = "0x40098B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _panelCanvasGroup;

		// Token: 0x040098B3 RID: 39091
		[Token(Token = "0x40098B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _background;

		// Token: 0x040098B4 RID: 39092
		[Token(Token = "0x40098B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LayoutCoroutine;

		// Token: 0x040098B5 RID: 39093
		[Token(Token = "0x40098B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x040098B6 RID: 39094
		[Token(Token = "0x40098B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetupTheme;

		// Token: 0x040098B7 RID: 39095
		[Token(Token = "0x40098B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040098B8 RID: 39096
		[Token(Token = "0x40098B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040098B9 RID: 39097
		[Token(Token = "0x40098B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCloseButtonPressed;

		// Token: 0x040098BA RID: 39098
		[Token(Token = "0x40098BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001939 RID: 6457
		[Token(Token = "0x2001939")]
		[Serializable]
		public class UsageDescGroup
		{
			// Token: 0x0600A26E RID: 41582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A26E")]
			[Address(RVA = "0x31D5DE0", Offset = "0x31D49E0", VA = "0x1831D5DE0")]
			public void Setup(bool show, [Optional] string desc, [Optional] string usage)
			{
			}

			// Token: 0x0600A26F RID: 41583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A26F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UsageDescGroup()
			{
			}

			// Token: 0x040098BB RID: 39099
			[Token(Token = "0x40098BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panel;

			// Token: 0x040098BC RID: 39100
			[Token(Token = "0x40098BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _descPanel;

			// Token: 0x040098BD RID: 39101
			[Token(Token = "0x40098BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _usageLabel;
		}
	}
}
