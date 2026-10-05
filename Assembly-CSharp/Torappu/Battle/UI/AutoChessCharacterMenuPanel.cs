using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200329E RID: 12958
	[Token(Token = "0x200329E")]
	public class AutoChessCharacterMenuPanel : MonoBehaviour, UICharacterMenuState.IUICharacterMenuPanel, IHotfixable
	{
		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x06014958 RID: 84312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030BD")]
		private UIBattleUnderframePanel underframePanel
		{
			[Token(Token = "0x6014958")]
			[Address(RVA = "0xCC6840", Offset = "0xCC5440", VA = "0x180CC6840")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x06014959 RID: 84313 RVA: 0x00087930 File Offset: 0x00085B30
		[Token(Token = "0x170030BE")]
		private bool isGameStatusStateValid
		{
			[Token(Token = "0x6014959")]
			[Address(RVA = "0xCC67A0", Offset = "0xCC53A0", VA = "0x180CC67A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601495A RID: 84314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601495A")]
		[Address(RVA = "0xCC5460", Offset = "0xCC4060", VA = "0x180CC5460")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601495B RID: 84315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601495B")]
		[Address(RVA = "0xCC48A0", Offset = "0xCC34A0", VA = "0x180CC48A0", Slot = "4")]
		public void Show(Character character)
		{
		}

		// Token: 0x0601495C RID: 84316 RVA: 0x00087948 File Offset: 0x00085B48
		[Token(Token = "0x601495C")]
		[Address(RVA = "0xCC5300", Offset = "0xCC3F00", VA = "0x180CC5300")]
		private bool _DoRender(Character character)
		{
			return default(bool);
		}

		// Token: 0x0601495D RID: 84317 RVA: 0x00087960 File Offset: 0x00085B60
		[Token(Token = "0x601495D")]
		[Address(RVA = "0xCC5040", Offset = "0xCC3C40", VA = "0x180CC5040")]
		private bool _DoRenderDummy(Character character)
		{
			return default(bool);
		}

		// Token: 0x0601495E RID: 84318 RVA: 0x00087978 File Offset: 0x00085B78
		[Token(Token = "0x601495E")]
		[Address(RVA = "0xCC6320", Offset = "0xCC4F20", VA = "0x180CC6320")]
		private bool _RenderHand(Character character)
		{
			return default(bool);
		}

		// Token: 0x0601495F RID: 84319 RVA: 0x00087990 File Offset: 0x00085B90
		[Token(Token = "0x601495F")]
		[Address(RVA = "0xCC5BE0", Offset = "0xCC47E0", VA = "0x180CC5BE0")]
		private bool _RenderBattleField(Character character, Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06014960 RID: 84320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014960")]
		[Address(RVA = "0xCC6120", Offset = "0xCC4D20", VA = "0x180CC6120")]
		private void _RenderDestoryMagic(Character character)
		{
		}

		// Token: 0x06014961 RID: 84321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014961")]
		[Address(RVA = "0xCC6480", Offset = "0xCC5080", VA = "0x180CC6480")]
		private void _RenderSellCharacter(string chessId, Character character)
		{
		}

		// Token: 0x06014962 RID: 84322 RVA: 0x000879A8 File Offset: 0x00085BA8
		[Token(Token = "0x6014962")]
		[Address(RVA = "0xCC4E40", Offset = "0xCC3A40", VA = "0x180CC4E40")]
		private AutoChessUnderFramePanelButton.Param _ConstructSellCharacterBtnParam(string chessId, Character character)
		{
			return default(AutoChessUnderFramePanelButton.Param);
		}

		// Token: 0x06014963 RID: 84323 RVA: 0x000879C0 File Offset: 0x00085BC0
		[Token(Token = "0x6014963")]
		[Address(RVA = "0xCC4C80", Offset = "0xCC3880", VA = "0x180CC4C80")]
		private AutoChessUnderFramePanelButton.Param _ConstructDestroyUnitBtnParam(Character character)
		{
			return default(AutoChessUnderFramePanelButton.Param);
		}

		// Token: 0x06014964 RID: 84324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014964")]
		[Address(RVA = "0xCC4780", Offset = "0xCC3380", VA = "0x180CC4780", Slot = "5")]
		public void Hide()
		{
		}

		// Token: 0x06014965 RID: 84325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014965")]
		[Address(RVA = "0xCC59D0", Offset = "0xCC45D0", VA = "0x180CC59D0")]
		private void _OnWithdrawClicked()
		{
		}

		// Token: 0x06014966 RID: 84326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014966")]
		[Address(RVA = "0xCC56F0", Offset = "0xCC42F0", VA = "0x180CC56F0")]
		private void _OnDestroyClicked()
		{
		}

		// Token: 0x06014967 RID: 84327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014967")]
		[Address(RVA = "0xCC5860", Offset = "0xCC4460", VA = "0x180CC5860")]
		private void _OnSellClicked()
		{
		}

		// Token: 0x06014968 RID: 84328 RVA: 0x000879D8 File Offset: 0x00085BD8
		[Token(Token = "0x6014968")]
		[Address(RVA = "0xCC5620", Offset = "0xCC4220", VA = "0x180CC5620")]
		private bool _IsSellOrDestoryValid()
		{
			return default(bool);
		}

		// Token: 0x06014969 RID: 84329 RVA: 0x000879F0 File Offset: 0x00085BF0
		[Token(Token = "0x6014969")]
		[Address(RVA = "0xCC4B50", Offset = "0xCC3750", VA = "0x180CC4B50")]
		private bool _CheckUtilFastClicked(string key)
		{
			return default(bool);
		}

		// Token: 0x0601496A RID: 84330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601496A")]
		[Address(RVA = "0xCC66C0", Offset = "0xCC52C0", VA = "0x180CC66C0")]
		public AutoChessCharacterMenuPanel()
		{
		}

		// Token: 0x0401859E RID: 99742
		[Token(Token = "0x401859E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AutoChessCharacterMenuButton _menuButton;

		// Token: 0x0401859F RID: 99743
		[Token(Token = "0x401859F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Canvas _rootCanvas;

		// Token: 0x040185A0 RID: 99744
		[Token(Token = "0x40185A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _underframePanelPrefabPath;

		// Token: 0x040185A1 RID: 99745
		[Token(Token = "0x40185A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _withdrawTrapIcon;

		// Token: 0x040185A2 RID: 99746
		[Token(Token = "0x40185A2")]
		private const float FAST_CLICK_SWALLOW_TIME = 0.15f;

		// Token: 0x040185A3 RID: 99747
		[Token(Token = "0x40185A3")]
		private const string COMMON_CLICK_KEY = "common";

		// Token: 0x040185A4 RID: 99748
		[Token(Token = "0x40185A4")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x040185A5 RID: 99749
		[Token(Token = "0x40185A5")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<string, float> m_lastClick;

		// Token: 0x040185A6 RID: 99750
		[Token(Token = "0x40185A6")]
		[FieldOffset(Offset = "0x48")]
		private ObjectPtr<Character> m_character;

		// Token: 0x040185A7 RID: 99751
		[Token(Token = "0x40185A7")]
		[FieldOffset(Offset = "0x58")]
		private Tile m_tile;

		// Token: 0x040185A8 RID: 99752
		[Token(Token = "0x40185A8")]
		[FieldOffset(Offset = "0x60")]
		private UIBattleUnderframePanel m_underframePanel;

		// Token: 0x040185A9 RID: 99753
		[Token(Token = "0x40185A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_underframePanel;

		// Token: 0x040185AA RID: 99754
		[Token(Token = "0x40185AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isGameStatusStateValid;

		// Token: 0x040185AB RID: 99755
		[Token(Token = "0x40185AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040185AC RID: 99756
		[Token(Token = "0x40185AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040185AD RID: 99757
		[Token(Token = "0x40185AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x040185AE RID: 99758
		[Token(Token = "0x40185AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoRenderDummy;

		// Token: 0x040185AF RID: 99759
		[Token(Token = "0x40185AF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderHand;

		// Token: 0x040185B0 RID: 99760
		[Token(Token = "0x40185B0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderBattleField;

		// Token: 0x040185B1 RID: 99761
		[Token(Token = "0x40185B1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderDestoryMagic;

		// Token: 0x040185B2 RID: 99762
		[Token(Token = "0x40185B2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderSellCharacter;

		// Token: 0x040185B3 RID: 99763
		[Token(Token = "0x40185B3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ConstructSellCharacterBtnParam;

		// Token: 0x040185B4 RID: 99764
		[Token(Token = "0x40185B4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ConstructDestroyUnitBtnParam;

		// Token: 0x040185B5 RID: 99765
		[Token(Token = "0x40185B5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040185B6 RID: 99766
		[Token(Token = "0x40185B6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnWithdrawClicked;

		// Token: 0x040185B7 RID: 99767
		[Token(Token = "0x40185B7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnDestroyClicked;

		// Token: 0x040185B8 RID: 99768
		[Token(Token = "0x40185B8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnSellClicked;

		// Token: 0x040185B9 RID: 99769
		[Token(Token = "0x40185B9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__IsSellOrDestoryValid;

		// Token: 0x040185BA RID: 99770
		[Token(Token = "0x40185BA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckUtilFastClicked;

		// Token: 0x040185BB RID: 99771
		[Token(Token = "0x40185BB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
