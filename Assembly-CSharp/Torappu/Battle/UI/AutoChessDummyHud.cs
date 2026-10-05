using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032AF RID: 12975
	[Token(Token = "0x20032AF")]
	public class AutoChessDummyHud : BattleReusableUI
	{
		// Token: 0x060149E0 RID: 84448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149E0")]
		[Address(RVA = "0xCDB570", Offset = "0xCDA170", VA = "0x180CDB570")]
		public void InitIfNot()
		{
		}

		// Token: 0x060149E1 RID: 84449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149E1")]
		[Address(RVA = "0xCDB5E0", Offset = "0xCDA1E0", VA = "0x180CDB5E0")]
		public void SetData(AutoChessDummyHud.Param param)
		{
		}

		// Token: 0x060149E2 RID: 84450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149E2")]
		[Address(RVA = "0xCDB710", Offset = "0xCDA310", VA = "0x180CDB710")]
		public void UpdateGameInfo()
		{
		}

		// Token: 0x060149E3 RID: 84451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149E3")]
		[Address(RVA = "0xCDB500", Offset = "0xCDA100", VA = "0x180CDB500")]
		public void Hide()
		{
		}

		// Token: 0x060149E4 RID: 84452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149E4")]
		[Address(RVA = "0xCDB780", Offset = "0xCDA380", VA = "0x180CDB780")]
		private void _UpdataInternal(bool needUpdateShopState = false)
		{
		}

		// Token: 0x060149E5 RID: 84453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149E5")]
		[Address(RVA = "0xCDBB20", Offset = "0xCDA720", VA = "0x180CDBB20")]
		private void _UpdateShopState()
		{
		}

		// Token: 0x060149E6 RID: 84454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149E6")]
		[Address(RVA = "0xCDB8F0", Offset = "0xCDA4F0", VA = "0x180CDB8F0")]
		private void _UpdateBattleState()
		{
		}

		// Token: 0x060149E7 RID: 84455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149E7")]
		[Address(RVA = "0xCDBE20", Offset = "0xCDAA20", VA = "0x180CDBE20")]
		public AutoChessDummyHud()
		{
		}

		// Token: 0x04018689 RID: 99977
		[Token(Token = "0x4018689")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFollower _follower;

		// Token: 0x0401868A RID: 99978
		[Token(Token = "0x401868A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _root;

		// Token: 0x0401868B RID: 99979
		[Token(Token = "0x401868B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _chessLevelRoot;

		// Token: 0x0401868C RID: 99980
		[Token(Token = "0x401868C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _chessLevelImage;

		// Token: 0x0401868D RID: 99981
		[Token(Token = "0x401868D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite[] _chessLevelSprites;

		// Token: 0x0401868E RID: 99982
		[Token(Token = "0x401868E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _shopPart;

		// Token: 0x0401868F RID: 99983
		[Token(Token = "0x401868F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _equipRoot;

		// Token: 0x04018690 RID: 99984
		[Token(Token = "0x4018690")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _equip1Icon;

		// Token: 0x04018691 RID: 99985
		[Token(Token = "0x4018691")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _equip2Icon;

		// Token: 0x04018692 RID: 99986
		[Token(Token = "0x4018692")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite _goldSprite;

		// Token: 0x04018693 RID: 99987
		[Token(Token = "0x4018693")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Sprite _whiteSprite;

		// Token: 0x04018694 RID: 99988
		[Token(Token = "0x4018694")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _tokenRoot;

		// Token: 0x04018695 RID: 99989
		[Token(Token = "0x4018695")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _tokenCntText;

		// Token: 0x04018696 RID: 99990
		[Token(Token = "0x4018696")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _invalidUpgradeColor;

		// Token: 0x04018697 RID: 99991
		[Token(Token = "0x4018697")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Battle State")]
		private Transform _battleStateRoot;

		// Token: 0x04018698 RID: 99992
		[Token(Token = "0x4018698")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Battle State")]
		private Transform _respawnReadyRoot;

		// Token: 0x04018699 RID: 99993
		[Token(Token = "0x4018699")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Battle State")]
		private Transform _respawnCountdownRoot;

		// Token: 0x0401869A RID: 99994
		[Token(Token = "0x401869A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Battle State")]
		private Image _respawnCountdownFill;

		// Token: 0x0401869B RID: 99995
		[Token(Token = "0x401869B")]
		private const string TOKEN_CNT_FORMAT = "X{0}";

		// Token: 0x0401869C RID: 99996
		[Token(Token = "0x401869C")]
		[FieldOffset(Offset = "0xB8")]
		private AutoChessDummyHud.Param m_param;

		// Token: 0x0401869D RID: 99997
		[Token(Token = "0x401869D")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_inited;

		// Token: 0x0401869E RID: 99998
		[Token(Token = "0x401869E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0401869F RID: 99999
		[Token(Token = "0x401869F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040186A0 RID: 100000
		[Token(Token = "0x40186A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x040186A1 RID: 100001
		[Token(Token = "0x40186A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040186A2 RID: 100002
		[Token(Token = "0x40186A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdataInternal;

		// Token: 0x040186A3 RID: 100003
		[Token(Token = "0x40186A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateShopState;

		// Token: 0x040186A4 RID: 100004
		[Token(Token = "0x40186A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateBattleState;

		// Token: 0x040186A5 RID: 100005
		[Token(Token = "0x40186A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032B0 RID: 12976
		[Token(Token = "0x20032B0")]
		public struct Param
		{
			// Token: 0x170030D1 RID: 12497
			// (get) Token: 0x060149E8 RID: 84456 RVA: 0x00087C90 File Offset: 0x00085E90
			[Token(Token = "0x170030D1")]
			public static AutoChessDummyHud.Param DEFAULT_BATTLESTATE
			{
				[Token(Token = "0x60149E8")]
				[Address(RVA = "0xCE06D0", Offset = "0xCDF2D0", VA = "0x180CE06D0")]
				get
				{
					return default(AutoChessDummyHud.Param);
				}
			}

			// Token: 0x170030D2 RID: 12498
			// (get) Token: 0x060149E9 RID: 84457 RVA: 0x00087CA8 File Offset: 0x00085EA8
			[Token(Token = "0x170030D2")]
			public static AutoChessDummyHud.Param DEFAULT_SHOPSTATE_HAND
			{
				[Token(Token = "0x60149E9")]
				[Address(RVA = "0xCE06F0", Offset = "0xCDF2F0", VA = "0x180CE06F0")]
				get
				{
					return default(AutoChessDummyHud.Param);
				}
			}

			// Token: 0x170030D3 RID: 12499
			// (get) Token: 0x060149EA RID: 84458 RVA: 0x00087CC0 File Offset: 0x00085EC0
			[Token(Token = "0x170030D3")]
			public static AutoChessDummyHud.Param DEFAULT_SHOPSTATE_BATTLE
			{
				[Token(Token = "0x60149EA")]
				[Address(RVA = "0xCE06F0", Offset = "0xCDF2F0", VA = "0x180CE06F0")]
				get
				{
					return default(AutoChessDummyHud.Param);
				}
			}

			// Token: 0x040186A6 RID: 100006
			[Token(Token = "0x40186A6")]
			[FieldOffset(Offset = "0x0")]
			public bool hideAll;

			// Token: 0x040186A7 RID: 100007
			[Token(Token = "0x40186A7")]
			[FieldOffset(Offset = "0x1")]
			public bool displayAsShopState;

			// Token: 0x040186A8 RID: 100008
			[Token(Token = "0x40186A8")]
			[FieldOffset(Offset = "0x2")]
			public bool displayChessLevel;

			// Token: 0x040186A9 RID: 100009
			[Token(Token = "0x40186A9")]
			[FieldOffset(Offset = "0x4")]
			public int chessLevel;

			// Token: 0x040186AA RID: 100010
			[Token(Token = "0x40186AA")]
			[FieldOffset(Offset = "0x8")]
			public bool displayEquipPart;

			// Token: 0x040186AB RID: 100011
			[Token(Token = "0x40186AB")]
			[FieldOffset(Offset = "0x9")]
			public bool displayEquip1;

			// Token: 0x040186AC RID: 100012
			[Token(Token = "0x40186AC")]
			[FieldOffset(Offset = "0xA")]
			public bool displayEquip1Golden;

			// Token: 0x040186AD RID: 100013
			[Token(Token = "0x40186AD")]
			[FieldOffset(Offset = "0xB")]
			public bool displayEquip2;

			// Token: 0x040186AE RID: 100014
			[Token(Token = "0x40186AE")]
			[FieldOffset(Offset = "0xC")]
			public bool displayEquip2Golden;

			// Token: 0x040186AF RID: 100015
			[Token(Token = "0x40186AF")]
			[FieldOffset(Offset = "0xD")]
			public bool displayTokenCnt;

			// Token: 0x040186B0 RID: 100016
			[Token(Token = "0x40186B0")]
			[FieldOffset(Offset = "0x10")]
			public int tokenCnt;

			// Token: 0x040186B1 RID: 100017
			[Token(Token = "0x40186B1")]
			[FieldOffset(Offset = "0x14")]
			public bool displayAsBattleState;

			// Token: 0x040186B2 RID: 100018
			[Token(Token = "0x40186B2")]
			[FieldOffset(Offset = "0x18")]
			public float ratio;

			// Token: 0x040186B3 RID: 100019
			[Token(Token = "0x40186B3")]
			[FieldOffset(Offset = "0x20")]
			public Transform mountUIPoint;

			// Token: 0x040186B4 RID: 100020
			[Token(Token = "0x40186B4")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 hudOffset;

			// Token: 0x040186B5 RID: 100021
			[Token(Token = "0x40186B5")]
			[FieldOffset(Offset = "0x30")]
			public Deck.Card card;
		}
	}
}
