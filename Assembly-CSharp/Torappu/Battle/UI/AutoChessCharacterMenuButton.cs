using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032AA RID: 12970
	[Token(Token = "0x20032AA")]
	public class AutoChessCharacterMenuButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x060149D3 RID: 84435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D3")]
		[Address(RVA = "0xCDA4E0", Offset = "0xCD90E0", VA = "0x180CDA4E0")]
		public void Render(AutoChessCharacterMenuButton.Param param)
		{
		}

		// Token: 0x060149D4 RID: 84436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D4")]
		[Address(RVA = "0xCDA180", Offset = "0xCD8D80", VA = "0x180CDA180")]
		public void Hide()
		{
		}

		// Token: 0x060149D5 RID: 84437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D5")]
		[Address(RVA = "0xCDA390", Offset = "0xCD8F90", VA = "0x180CDA390")]
		private void InitIfNot()
		{
		}

		// Token: 0x060149D6 RID: 84438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D6")]
		[Address(RVA = "0xCDA470", Offset = "0xCD9070", VA = "0x180CDA470")]
		public void OnClick()
		{
		}

		// Token: 0x060149D7 RID: 84439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D7")]
		[Address(RVA = "0xCDA840", Offset = "0xCD9440", VA = "0x180CDA840")]
		public void TutorialOnly_RegisterCharacterShopMenuCoinPanel()
		{
		}

		// Token: 0x060149D8 RID: 84440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D8")]
		[Address(RVA = "0xCDA920", Offset = "0xCD9520", VA = "0x180CDA920")]
		public void TutorialOnly_RegisterShopCharacterMenuBtn()
		{
		}

		// Token: 0x060149D9 RID: 84441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D9")]
		[Address(RVA = "0xCDACF0", Offset = "0xCD98F0", VA = "0x180CDACF0")]
		private void _RevertRotateIfNeed()
		{
		}

		// Token: 0x060149DA RID: 84442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149DA")]
		[Address(RVA = "0xCDAEA0", Offset = "0xCD9AA0", VA = "0x180CDAEA0")]
		private void _RotateIfNeed(AutoChessCharacterMenuButton.Param param)
		{
		}

		// Token: 0x060149DB RID: 84443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149DB")]
		[Address(RVA = "0xCDAA00", Offset = "0xCD9600", VA = "0x180CDAA00")]
		private void _RenderCoin(AutoChessCharacterMenuButton.Param param)
		{
		}

		// Token: 0x060149DC RID: 84444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149DC")]
		[Address(RVA = "0xCDB1C0", Offset = "0xCD9DC0", VA = "0x180CDB1C0")]
		private void _UpdateValid(bool isValid, AutoChessCharacterMenuButton.DisplayTypeSetting setting)
		{
		}

		// Token: 0x060149DD RID: 84445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149DD")]
		[Address(RVA = "0xCDB440", Offset = "0xCDA040", VA = "0x180CDB440")]
		public AutoChessCharacterMenuButton()
		{
		}

		// Token: 0x0401864B RID: 99915
		[Token(Token = "0x401864B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AutoChessCharacterMenuButton.DisplayTypeSetting[] _settings;

		// Token: 0x0401864C RID: 99916
		[Token(Token = "0x401864C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessCharacterMenuButton.LiteTextIconPairSetting[] _liteSettings;

		// Token: 0x0401864D RID: 99917
		[Token(Token = "0x401864D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _btnText;

		// Token: 0x0401864E RID: 99918
		[Token(Token = "0x401864E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0401864F RID: 99919
		[Token(Token = "0x401864F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _coinText;

		// Token: 0x04018650 RID: 99920
		[Token(Token = "0x4018650")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _displayBg;

		// Token: 0x04018651 RID: 99921
		[Token(Token = "0x4018651")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _coinBg;

		// Token: 0x04018652 RID: 99922
		[Token(Token = "0x4018652")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _utilBtn;

		// Token: 0x04018653 RID: 99923
		[Token(Token = "0x4018653")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _utilBtnRoot;

		// Token: 0x04018654 RID: 99924
		[Token(Token = "0x4018654")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _coinRoot;

		// Token: 0x04018655 RID: 99925
		[Token(Token = "0x4018655")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _rotateRoot;

		// Token: 0x04018656 RID: 99926
		[Token(Token = "0x4018656")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Sprite _iconBgEnough;

		// Token: 0x04018657 RID: 99927
		[Token(Token = "0x4018657")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Sprite _bgNotValid;

		// Token: 0x04018658 RID: 99928
		[Token(Token = "0x4018658")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Sprite _iconBgNotEnough;

		// Token: 0x04018659 RID: 99929
		[Token(Token = "0x4018659")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _defaultIconColor;

		// Token: 0x0401865A RID: 99930
		[Token(Token = "0x401865A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _notValidIconColor;

		// Token: 0x0401865B RID: 99931
		[Token(Token = "0x401865B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _defaultTextColor;

		// Token: 0x0401865C RID: 99932
		[Token(Token = "0x401865C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _notValidTextColor;

		// Token: 0x0401865D RID: 99933
		[Token(Token = "0x401865D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _defaultPriceTextColor;

		// Token: 0x0401865E RID: 99934
		[Token(Token = "0x401865E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Color _notValidPriceTextColor;

		// Token: 0x0401865F RID: 99935
		[Token(Token = "0x401865F")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Button _button;

		// Token: 0x04018660 RID: 99936
		[Token(Token = "0x4018660")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Follower2D _follower;

		// Token: 0x04018661 RID: 99937
		[Token(Token = "0x4018661")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _maskRoot;

		// Token: 0x04018662 RID: 99938
		[Token(Token = "0x4018662")]
		[FieldOffset(Offset = "0x100")]
		[Group("Tutorial Only")]
		[SerializeField]
		private GameObject _tutorialOnlyCoinPanel;

		// Token: 0x04018663 RID: 99939
		[Token(Token = "0x4018663")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _tutorialOnlyButton;

		// Token: 0x04018664 RID: 99940
		[Token(Token = "0x4018664")]
		[FieldOffset(Offset = "0x110")]
		private bool m_inited;

		// Token: 0x04018665 RID: 99941
		[Token(Token = "0x4018665")]
		[FieldOffset(Offset = "0x111")]
		private bool m_hasRotated;

		// Token: 0x04018666 RID: 99942
		[Token(Token = "0x4018666")]
		[FieldOffset(Offset = "0x112")]
		private bool m_isShowed;

		// Token: 0x04018667 RID: 99943
		[Token(Token = "0x4018667")]
		[FieldOffset(Offset = "0x118")]
		private ListDict<AutoChessCharacterMenuButton.DisplayType, AutoChessCharacterMenuButton.DisplayTypeSetting> m_displayTypeSettings;

		// Token: 0x04018668 RID: 99944
		[Token(Token = "0x4018668")]
		[FieldOffset(Offset = "0x120")]
		private AutoChessCharacterMenuButton.Param m_param;

		// Token: 0x04018669 RID: 99945
		[Token(Token = "0x4018669")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401866A RID: 99946
		[Token(Token = "0x401866A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401866B RID: 99947
		[Token(Token = "0x401866B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0401866C RID: 99948
		[Token(Token = "0x401866C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401866D RID: 99949
		[Token(Token = "0x401866D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterCharacterShopMenuCoinPanel;

		// Token: 0x0401866E RID: 99950
		[Token(Token = "0x401866E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterShopCharacterMenuBtn;

		// Token: 0x0401866F RID: 99951
		[Token(Token = "0x401866F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RevertRotateIfNeed;

		// Token: 0x04018670 RID: 99952
		[Token(Token = "0x4018670")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RotateIfNeed;

		// Token: 0x04018671 RID: 99953
		[Token(Token = "0x4018671")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderCoin;

		// Token: 0x04018672 RID: 99954
		[Token(Token = "0x4018672")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateValid;

		// Token: 0x04018673 RID: 99955
		[Token(Token = "0x4018673")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032AB RID: 12971
		[Token(Token = "0x20032AB")]
		public enum DisplayType
		{
			// Token: 0x04018675 RID: 99957
			[Token(Token = "0x4018675")]
			SELL,
			// Token: 0x04018676 RID: 99958
			[Token(Token = "0x4018676")]
			DESTROY
		}

		// Token: 0x020032AC RID: 12972
		[Token(Token = "0x20032AC")]
		public struct Param
		{
			// Token: 0x04018677 RID: 99959
			[Token(Token = "0x4018677")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessCharacterMenuButton.DisplayType displayType;

			// Token: 0x04018678 RID: 99960
			[Token(Token = "0x4018678")]
			[FieldOffset(Offset = "0x8")]
			public string btnText;

			// Token: 0x04018679 RID: 99961
			[Token(Token = "0x4018679")]
			[FieldOffset(Offset = "0x10")]
			public bool isValid;

			// Token: 0x0401867A RID: 99962
			[Token(Token = "0x401867A")]
			[FieldOffset(Offset = "0x11")]
			public bool displayCoin;

			// Token: 0x0401867B RID: 99963
			[Token(Token = "0x401867B")]
			[FieldOffset(Offset = "0x12")]
			public bool displayCoinAsNotEnough;

			// Token: 0x0401867C RID: 99964
			[Token(Token = "0x401867C")]
			[FieldOffset(Offset = "0x13")]
			public bool displayCoinAdd;

			// Token: 0x0401867D RID: 99965
			[Token(Token = "0x401867D")]
			[FieldOffset(Offset = "0x14")]
			public int coinValue;

			// Token: 0x0401867E RID: 99966
			[Token(Token = "0x401867E")]
			[FieldOffset(Offset = "0x18")]
			public Action onClick;

			// Token: 0x0401867F RID: 99967
			[Token(Token = "0x401867F")]
			[FieldOffset(Offset = "0x20")]
			public Transform mountPoint;

			// Token: 0x04018680 RID: 99968
			[Token(Token = "0x4018680")]
			[FieldOffset(Offset = "0x28")]
			public Canvas canvas;
		}

		// Token: 0x020032AD RID: 12973
		[Token(Token = "0x20032AD")]
		[Serializable]
		public class DisplayTypeSetting
		{
			// Token: 0x060149DE RID: 84446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60149DE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DisplayTypeSetting()
			{
			}

			// Token: 0x04018681 RID: 99969
			[Token(Token = "0x4018681")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessCharacterMenuButton.DisplayType displayType;

			// Token: 0x04018682 RID: 99970
			[Token(Token = "0x4018682")]
			[FieldOffset(Offset = "0x14")]
			public bool needRotate;

			// Token: 0x04018683 RID: 99971
			[Token(Token = "0x4018683")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x04018684 RID: 99972
			[Token(Token = "0x4018684")]
			[FieldOffset(Offset = "0x20")]
			public Sprite bg;

			// Token: 0x04018685 RID: 99973
			[Token(Token = "0x4018685")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 rotatedPos;

			// Token: 0x04018686 RID: 99974
			[Token(Token = "0x4018686")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 rotatedOffsetPos;

			// Token: 0x04018687 RID: 99975
			[Token(Token = "0x4018687")]
			[FieldOffset(Offset = "0x40")]
			public GameObject layerMaskRef;
		}

		// Token: 0x020032AE RID: 12974
		[Token(Token = "0x20032AE")]
		[Serializable]
		public class LiteTextIconPairSetting
		{
			// Token: 0x060149DF RID: 84447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60149DF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LiteTextIconPairSetting()
			{
			}

			// Token: 0x04018688 RID: 99976
			[Token(Token = "0x4018688")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 textPos;
		}
	}
}
