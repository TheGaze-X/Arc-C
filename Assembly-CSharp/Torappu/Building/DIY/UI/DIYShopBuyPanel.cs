using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001940 RID: 6464
	[Token(Token = "0x2001940")]
	public class DIYShopBuyPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000047 RID: 71
		// (add) Token: 0x0600A294 RID: 41620 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A295 RID: 41621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000047")]
		public event Action<IDIYShopItem, int, int> commandButtonPressed
		{
			[Token(Token = "0x600A294")]
			[Address(RVA = "0x31C1B80", Offset = "0x31C0780", VA = "0x1831C1B80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A295")]
			[Address(RVA = "0x31C1C80", Offset = "0x31C0880", VA = "0x1831C1C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A296")]
		[Address(RVA = "0x31C1180", Offset = "0x31BFD80", VA = "0x1831C1180")]
		private IEnumerator _LayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A297")]
		[Address(RVA = "0x31C0470", Offset = "0x31BF070", VA = "0x1831C0470")]
		public void Setup(DIYShopBuyPanel.Argument arg)
		{
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A298")]
		[Address(RVA = "0x31C1600", Offset = "0x31C0200", VA = "0x1831C1600")]
		private void _SetupAsPart(int originPrice, int discount, int price, int maxBuyCount, GameObject[] activeObjects, GameObject[] inactiveObjects)
		{
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A299")]
		[Address(RVA = "0x31C1320", Offset = "0x31BFF20", VA = "0x1831C1320")]
		private void _SetupAsCash()
		{
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A29A")]
		[Address(RVA = "0x31C1490", Offset = "0x31C0090", VA = "0x1831C1490")]
		private void _SetupAsFurnitureCoin()
		{
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A29B")]
		[Address(RVA = "0x31C0E70", Offset = "0x31BFA70", VA = "0x1831C0E70")]
		public void Show()
		{
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A29C")]
		[Address(RVA = "0x31BFFA0", Offset = "0x31BEBA0", VA = "0x1831BFFA0")]
		public void Hide()
		{
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A29D")]
		[Address(RVA = "0x31C0120", Offset = "0x31BED20", VA = "0x1831C0120")]
		public void OnBuyButtonPressed()
		{
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A29E")]
		[Address(RVA = "0x31C0240", Offset = "0x31BEE40", VA = "0x1831C0240")]
		public void OnCancelButtonPressed()
		{
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A29F")]
		[Address(RVA = "0x31C02A0", Offset = "0x31BEEA0", VA = "0x1831C02A0")]
		public void OnCashSwitchPressed()
		{
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A0")]
		[Address(RVA = "0x31C0410", Offset = "0x31BF010", VA = "0x1831C0410")]
		public void OnFurnitureCoinSwitchPressed()
		{
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A1")]
		[Address(RVA = "0x31C1230", Offset = "0x31BFE30", VA = "0x1831C1230")]
		private void _OnLineCountChanged(int count)
		{
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A2")]
		[Address(RVA = "0x31C0300", Offset = "0x31BEF00", VA = "0x1831C0300")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A3")]
		[Address(RVA = "0x31C1B20", Offset = "0x31C0720", VA = "0x1831C1B20")]
		public DIYShopBuyPanel()
		{
		}

		// Token: 0x040098DF RID: 39135
		[Token(Token = "0x40098DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _furnitureNameLabel;

		// Token: 0x040098E0 RID: 39136
		[Token(Token = "0x40098E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _originPriceLabel;

		// Token: 0x040098E1 RID: 39137
		[Token(Token = "0x40098E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _originPriceStrike;

		// Token: 0x040098E2 RID: 39138
		[Token(Token = "0x40098E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _discountPanel;

		// Token: 0x040098E3 RID: 39139
		[Token(Token = "0x40098E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _discountLabel;

		// Token: 0x040098E4 RID: 39140
		[Token(Token = "0x40098E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _priceLabel;

		// Token: 0x040098E5 RID: 39141
		[Token(Token = "0x40098E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _hasFurnitureCountLabel;

		// Token: 0x040098E6 RID: 39142
		[Token(Token = "0x40098E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _themeLabel;

		// Token: 0x040098E7 RID: 39143
		[Token(Token = "0x40098E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _groupLabel;

		// Token: 0x040098E8 RID: 39144
		[Token(Token = "0x40098E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _themeGroupPanel;

		// Token: 0x040098E9 RID: 39145
		[Token(Token = "0x40098E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private DIYShopBuyPanel.UsageDescGroup _lowerGroup;

		// Token: 0x040098EA RID: 39146
		[Token(Token = "0x40098EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DIYShopBuyPanel.UsageDescGroup _upperGroup;

		// Token: 0x040098EB RID: 39147
		[Token(Token = "0x40098EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _furnitureIcon;

		// Token: 0x040098EC RID: 39148
		[Token(Token = "0x40098EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _buyLimitPanel;

		// Token: 0x040098ED RID: 39149
		[Token(Token = "0x40098ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _buyLimitLabel;

		// Token: 0x040098EE RID: 39150
		[Token(Token = "0x40098EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _comfortLabel;

		// Token: 0x040098EF RID: 39151
		[Token(Token = "0x40098EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObjectArrayCountControl _rarityStarArray;

		// Token: 0x040098F0 RID: 39152
		[Token(Token = "0x40098F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private DIYShopBuyItemLine _buyItemLine;

		// Token: 0x040098F1 RID: 39153
		[Token(Token = "0x40098F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _paySwitchObject;

		// Token: 0x040098F2 RID: 39154
		[Token(Token = "0x40098F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject[] _cashOnlyObjects;

		// Token: 0x040098F3 RID: 39155
		[Token(Token = "0x40098F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject[] _furnitureCoinOnlyObjects;

		// Token: 0x040098F4 RID: 39156
		[Token(Token = "0x40098F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button _okButton;

		// Token: 0x040098F5 RID: 39157
		[Token(Token = "0x40098F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _originPriceValidColor;

		// Token: 0x040098F6 RID: 39158
		[Token(Token = "0x40098F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Color _originPriceInvalidColor;

		// Token: 0x040098F7 RID: 39159
		[Token(Token = "0x40098F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CanvasGroup _panelCanvasGroup;

		// Token: 0x040098F8 RID: 39160
		[Token(Token = "0x40098F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image _background;

		// Token: 0x040098F9 RID: 39161
		[Token(Token = "0x40098F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private DIYShopBuyPanel.Argument m_currentArgument;

		// Token: 0x040098FA RID: 39162
		[Token(Token = "0x40098FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private DIYShopBuyPanel.SwitchState m_currentSwitchState;

		// Token: 0x040098FC RID: 39164
		[Token(Token = "0x40098FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_commandButtonPressed;

		// Token: 0x040098FD RID: 39165
		[Token(Token = "0x40098FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_commandButtonPressed;

		// Token: 0x040098FE RID: 39166
		[Token(Token = "0x40098FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LayoutCoroutine;

		// Token: 0x040098FF RID: 39167
		[Token(Token = "0x40098FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009900 RID: 39168
		[Token(Token = "0x4009900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetupAsPart;

		// Token: 0x04009901 RID: 39169
		[Token(Token = "0x4009901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetupAsCash;

		// Token: 0x04009902 RID: 39170
		[Token(Token = "0x4009902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetupAsFurnitureCoin;

		// Token: 0x04009903 RID: 39171
		[Token(Token = "0x4009903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04009904 RID: 39172
		[Token(Token = "0x4009904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04009905 RID: 39173
		[Token(Token = "0x4009905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBuyButtonPressed;

		// Token: 0x04009906 RID: 39174
		[Token(Token = "0x4009906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCancelButtonPressed;

		// Token: 0x04009907 RID: 39175
		[Token(Token = "0x4009907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCashSwitchPressed;

		// Token: 0x04009908 RID: 39176
		[Token(Token = "0x4009908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnFurnitureCoinSwitchPressed;

		// Token: 0x04009909 RID: 39177
		[Token(Token = "0x4009909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnLineCountChanged;

		// Token: 0x0400990A RID: 39178
		[Token(Token = "0x400990A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400990B RID: 39179
		[Token(Token = "0x400990B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001941 RID: 6465
		[Token(Token = "0x2001941")]
		public class Argument
		{
			// Token: 0x0600A2A5 RID: 41637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A2A5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Argument()
			{
			}

			// Token: 0x0400990C RID: 39180
			[Token(Token = "0x400990C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IDIYShopItem shopItem;

			// Token: 0x0400990D RID: 39181
			[Token(Token = "0x400990D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int cashMaxCount;

			// Token: 0x0400990E RID: 39182
			[Token(Token = "0x400990E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int furnitureCoinMaxCount;

			// Token: 0x0400990F RID: 39183
			[Token(Token = "0x400990F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int hasCount;

			// Token: 0x04009910 RID: 39184
			[Token(Token = "0x4009910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string themeName;

			// Token: 0x04009911 RID: 39185
			[Token(Token = "0x4009911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string groupName;
		}

		// Token: 0x02001942 RID: 6466
		[Token(Token = "0x2001942")]
		[Serializable]
		public class UsageDescGroup
		{
			// Token: 0x0600A2A6 RID: 41638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A2A6")]
			[Address(RVA = "0x31D5EF0", Offset = "0x31D4AF0", VA = "0x1831D5EF0")]
			public void Setup(bool show, [Optional] string desc, [Optional] string usage)
			{
			}

			// Token: 0x0600A2A7 RID: 41639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A2A7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UsageDescGroup()
			{
			}

			// Token: 0x04009912 RID: 39186
			[Token(Token = "0x4009912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panel;

			// Token: 0x04009913 RID: 39187
			[Token(Token = "0x4009913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _descPanel;

			// Token: 0x04009914 RID: 39188
			[Token(Token = "0x4009914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _usageLabel;
		}

		// Token: 0x02001943 RID: 6467
		[Token(Token = "0x2001943")]
		private enum SwitchState
		{
			// Token: 0x04009916 RID: 39190
			[Token(Token = "0x4009916")]
			None,
			// Token: 0x04009917 RID: 39191
			[Token(Token = "0x4009917")]
			Cash,
			// Token: 0x04009918 RID: 39192
			[Token(Token = "0x4009918")]
			FurnitureCoin
		}
	}
}
