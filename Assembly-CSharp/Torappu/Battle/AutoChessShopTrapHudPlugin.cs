using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024B9 RID: 9401
	[Token(Token = "0x20024B9")]
	public class AutoChessShopTrapHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x0600F1E7 RID: 61927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1E7")]
		[Address(RVA = "0x682EF0", Offset = "0x681AF0", VA = "0x180682EF0", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x0600F1E8 RID: 61928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1E8")]
		[Address(RVA = "0x682F90", Offset = "0x681B90", VA = "0x180682F90", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F1E9 RID: 61929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1E9")]
		[Address(RVA = "0x683300", Offset = "0x681F00", VA = "0x180683300")]
		private void _UpdateInternal(object arg)
		{
		}

		// Token: 0x0600F1EA RID: 61930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1EA")]
		[Address(RVA = "0x6831E0", Offset = "0x681DE0", VA = "0x1806831E0")]
		private void _UpdateCoinDisplay(bool isEnough, bool force = false)
		{
		}

		// Token: 0x0600F1EB RID: 61931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1EB")]
		[Address(RVA = "0x683100", Offset = "0x681D00", VA = "0x180683100")]
		private void _UpdateCoinAmount(int amount, bool force = false)
		{
		}

		// Token: 0x0600F1EC RID: 61932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1EC")]
		[Address(RVA = "0x683360", Offset = "0x681F60", VA = "0x180683360")]
		public AutoChessShopTrapHudPlugin()
		{
		}

		// Token: 0x0600F1ED RID: 61933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1ED")]
		[Address(RVA = "0x683020", Offset = "0x681C20", VA = "0x180683020")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x0600F1EE RID: 61934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1EE")]
		[Address(RVA = "0x6830A0", Offset = "0x681CA0", VA = "0x1806830A0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010BB1 RID: 68529
		[Token(Token = "0x4010BB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _chessLevelText;

		// Token: 0x04010BB2 RID: 68530
		[Token(Token = "0x4010BB2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _root;

		// Token: 0x04010BB3 RID: 68531
		[Token(Token = "0x4010BB3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _levelRoot;

		// Token: 0x04010BB4 RID: 68532
		[Token(Token = "0x4010BB4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _coinRoot;

		// Token: 0x04010BB5 RID: 68533
		[Token(Token = "0x4010BB5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _coinImg;

		// Token: 0x04010BB6 RID: 68534
		[Token(Token = "0x4010BB6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite _coinNotEnoughSprite;

		// Token: 0x04010BB7 RID: 68535
		[Token(Token = "0x4010BB7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite _coinEnoughSprite;

		// Token: 0x04010BB8 RID: 68536
		[Token(Token = "0x4010BB8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _coinText;

		// Token: 0x04010BB9 RID: 68537
		[Token(Token = "0x4010BB9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorEnough;

		// Token: 0x04010BBA RID: 68538
		[Token(Token = "0x4010BBA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorNotEnough;

		// Token: 0x04010BBB RID: 68539
		[Token(Token = "0x4010BBB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<AutoChessShopTrapHudPlugin.UtilTrapSetting> _utilTrapSettings;

		// Token: 0x04010BBC RID: 68540
		[Token(Token = "0x4010BBC")]
		[FieldOffset(Offset = "0x98")]
		private AutoChessShopTrapHudPlugin.CoinDisplayType m_coinDisplayType;

		// Token: 0x04010BBD RID: 68541
		[Token(Token = "0x4010BBD")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_hideCoinWhenLevelMax;

		// Token: 0x04010BBE RID: 68542
		[Token(Token = "0x4010BBE")]
		[FieldOffset(Offset = "0x9D")]
		private bool m_displayLevel;

		// Token: 0x04010BBF RID: 68543
		[Token(Token = "0x4010BBF")]
		[FieldOffset(Offset = "0xA0")]
		private int m_currentLevel;

		// Token: 0x04010BC0 RID: 68544
		[Token(Token = "0x4010BC0")]
		[FieldOffset(Offset = "0xA4")]
		private int m_coinAmount;

		// Token: 0x04010BC1 RID: 68545
		[Token(Token = "0x4010BC1")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isCoinDisplayedEnough;

		// Token: 0x04010BC2 RID: 68546
		[Token(Token = "0x4010BC2")]
		private const string SHOP_LEVEL_FORMAT = "LV.{0}";

		// Token: 0x04010BC3 RID: 68547
		[Token(Token = "0x4010BC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010BC4 RID: 68548
		[Token(Token = "0x4010BC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010BC5 RID: 68549
		[Token(Token = "0x4010BC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateInternal;

		// Token: 0x04010BC6 RID: 68550
		[Token(Token = "0x4010BC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateCoinDisplay;

		// Token: 0x04010BC7 RID: 68551
		[Token(Token = "0x4010BC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateCoinAmount;

		// Token: 0x04010BC8 RID: 68552
		[Token(Token = "0x4010BC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020024BA RID: 9402
		[Token(Token = "0x20024BA")]
		public enum CoinDisplayType
		{
			// Token: 0x04010BCA RID: 68554
			[Token(Token = "0x4010BCA")]
			NONE,
			// Token: 0x04010BCB RID: 68555
			[Token(Token = "0x4010BCB")]
			REFRESH_PRICE,
			// Token: 0x04010BCC RID: 68556
			[Token(Token = "0x4010BCC")]
			UPGRADE_PRICE
		}

		// Token: 0x020024BB RID: 9403
		[Token(Token = "0x20024BB")]
		[Serializable]
		public class UtilTrapSetting
		{
			// Token: 0x0600F1EF RID: 61935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F1EF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UtilTrapSetting()
			{
			}

			// Token: 0x04010BCD RID: 68557
			[Token(Token = "0x4010BCD")]
			[FieldOffset(Offset = "0x10")]
			public string tag;

			// Token: 0x04010BCE RID: 68558
			[Token(Token = "0x4010BCE")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessShopTrapHudPlugin.CoinDisplayType coinDisplayType;

			// Token: 0x04010BCF RID: 68559
			[Token(Token = "0x4010BCF")]
			[FieldOffset(Offset = "0x1C")]
			public bool hideCoinWhenLevelMax;

			// Token: 0x04010BD0 RID: 68560
			[Token(Token = "0x4010BD0")]
			[FieldOffset(Offset = "0x1D")]
			public bool displayLevel;
		}
	}
}
