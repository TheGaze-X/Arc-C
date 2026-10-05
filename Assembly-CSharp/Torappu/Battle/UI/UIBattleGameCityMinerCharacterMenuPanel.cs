using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032D4 RID: 13012
	[Token(Token = "0x20032D4")]
	public class UIBattleGameCityMinerCharacterMenuPanel : MonoBehaviour, UICharacterMenuState.IUICharacterMenuPanel, IHotfixable
	{
		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x06014B09 RID: 84745 RVA: 0x00087FC0 File Offset: 0x000861C0
		// (set) Token: 0x06014B0A RID: 84746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003102")]
		public bool isOpen
		{
			[Token(Token = "0x6014B09")]
			[Address(RVA = "0xD1E960", Offset = "0xD1D560", VA = "0x180D1E960")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014B0A")]
			[Address(RVA = "0xD1EA20", Offset = "0xD1D620", VA = "0x180D1EA20")]
			private set
			{
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x06014B0B RID: 84747 RVA: 0x00087FD8 File Offset: 0x000861D8
		// (set) Token: 0x06014B0C RID: 84748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003103")]
		private protected bool isSkillCasting
		{
			[Token(Token = "0x6014B0B")]
			[Address(RVA = "0xD1E9C0", Offset = "0xD1D5C0", VA = "0x180D1E9C0")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6014B0C")]
			[Address(RVA = "0xD1EB00", Offset = "0xD1D700", VA = "0x180D1EB00")]
			private set
			{
			}
		}

		// Token: 0x06014B0D RID: 84749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B0D")]
		[Address(RVA = "0xD1D320", Offset = "0xD1BF20", VA = "0x180D1D320")]
		public void OnInit()
		{
		}

		// Token: 0x06014B0E RID: 84750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B0E")]
		[Address(RVA = "0xD1D3E0", Offset = "0xD1BFE0", VA = "0x180D1D3E0")]
		public void OnSkillButtonClicked()
		{
		}

		// Token: 0x06014B0F RID: 84751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B0F")]
		[Address(RVA = "0xD1D520", Offset = "0xD1C120", VA = "0x180D1D520", Slot = "4")]
		public void Show(Character character)
		{
		}

		// Token: 0x06014B10 RID: 84752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B10")]
		[Address(RVA = "0xD1D250", Offset = "0xD1BE50", VA = "0x180D1D250", Slot = "5")]
		public void Hide()
		{
		}

		// Token: 0x06014B11 RID: 84753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B11")]
		[Address(RVA = "0xD1DE60", Offset = "0xD1CA60", VA = "0x180D1DE60")]
		private void _SetSkillCastingInternal(bool value, bool force)
		{
		}

		// Token: 0x06014B12 RID: 84754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B12")]
		[Address(RVA = "0xD1D740", Offset = "0xD1C340", VA = "0x180D1D740")]
		private void _SetData(Character character)
		{
		}

		// Token: 0x06014B13 RID: 84755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B13")]
		[Address(RVA = "0xD1DF30", Offset = "0xD1CB30", VA = "0x180D1DF30")]
		private void _UpdateData()
		{
		}

		// Token: 0x06014B14 RID: 84756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B14")]
		[Address(RVA = "0xD1E6F0", Offset = "0xD1D2F0", VA = "0x180D1E6F0")]
		private void _UpdateSkillCount(Character character, bool force)
		{
		}

		// Token: 0x06014B15 RID: 84757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B15")]
		[Address(RVA = "0xD1DDB0", Offset = "0xD1C9B0", VA = "0x180D1DDB0")]
		private void _SetOpenInternal(bool value, bool force)
		{
		}

		// Token: 0x06014B16 RID: 84758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B16")]
		[Address(RVA = "0xD1D6E0", Offset = "0xD1C2E0", VA = "0x180D1D6E0")]
		private void Update()
		{
		}

		// Token: 0x06014B17 RID: 84759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B17")]
		[Address(RVA = "0xD1E900", Offset = "0xD1D500", VA = "0x180D1E900")]
		public UIBattleGameCityMinerCharacterMenuPanel()
		{
		}

		// Token: 0x040188CD RID: 100557
		[Token(Token = "0x40188CD")]
		private const string UI_LEFT_BLACKBOARD_KEY = "is_left";

		// Token: 0x040188CE RID: 100558
		[Token(Token = "0x40188CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBattleGameCityMinerCharacterMenuPanel.MenuInfo _leftMenu;

		// Token: 0x040188CF RID: 100559
		[Token(Token = "0x40188CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIBattleGameCityMinerCharacterMenuPanel.MenuInfo _rightMenu;

		// Token: 0x040188D0 RID: 100560
		[Token(Token = "0x40188D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Follower2D _follower;

		// Token: 0x040188D1 RID: 100561
		[Token(Token = "0x40188D1")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Character> m_character;

		// Token: 0x040188D2 RID: 100562
		[Token(Token = "0x40188D2")]
		[FieldOffset(Offset = "0x40")]
		private Deck.Card m_card;

		// Token: 0x040188D3 RID: 100563
		[Token(Token = "0x40188D3")]
		[FieldOffset(Offset = "0x48")]
		private UIBattleGameCityMinerCharacterMenuPanel.MenuInfo m_curMenu;

		// Token: 0x040188D4 RID: 100564
		[Token(Token = "0x40188D4")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isSkillCasting;

		// Token: 0x040188D5 RID: 100565
		[Token(Token = "0x40188D5")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isSkillAmountShown;

		// Token: 0x040188D6 RID: 100566
		[Token(Token = "0x40188D6")]
		[FieldOffset(Offset = "0x52")]
		private bool m_isOpen;

		// Token: 0x040188D7 RID: 100567
		[Token(Token = "0x40188D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOpen;

		// Token: 0x040188D8 RID: 100568
		[Token(Token = "0x40188D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isOpen;

		// Token: 0x040188D9 RID: 100569
		[Token(Token = "0x40188D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSkillCasting;

		// Token: 0x040188DA RID: 100570
		[Token(Token = "0x40188DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isSkillCasting;

		// Token: 0x040188DB RID: 100571
		[Token(Token = "0x40188DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040188DC RID: 100572
		[Token(Token = "0x40188DC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSkillButtonClicked;

		// Token: 0x040188DD RID: 100573
		[Token(Token = "0x40188DD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040188DE RID: 100574
		[Token(Token = "0x40188DE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040188DF RID: 100575
		[Token(Token = "0x40188DF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetSkillCastingInternal;

		// Token: 0x040188E0 RID: 100576
		[Token(Token = "0x40188E0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x040188E1 RID: 100577
		[Token(Token = "0x40188E1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x040188E2 RID: 100578
		[Token(Token = "0x40188E2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateSkillCount;

		// Token: 0x040188E3 RID: 100579
		[Token(Token = "0x40188E3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetOpenInternal;

		// Token: 0x040188E4 RID: 100580
		[Token(Token = "0x40188E4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040188E5 RID: 100581
		[Token(Token = "0x40188E5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032D5 RID: 13013
		[Token(Token = "0x20032D5")]
		[Serializable]
		public class MenuInfo
		{
			// Token: 0x06014B18 RID: 84760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014B18")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MenuInfo()
			{
			}

			// Token: 0x040188E6 RID: 100582
			[Token(Token = "0x40188E6")]
			[FieldOffset(Offset = "0x10")]
			public Button skillButton;

			// Token: 0x040188E7 RID: 100583
			[Token(Token = "0x40188E7")]
			[FieldOffset(Offset = "0x18")]
			public Slider skillToNextSlider;

			// Token: 0x040188E8 RID: 100584
			[Token(Token = "0x40188E8")]
			[FieldOffset(Offset = "0x20")]
			public Slider skillCastingSlider;

			// Token: 0x040188E9 RID: 100585
			[Token(Token = "0x40188E9")]
			[FieldOffset(Offset = "0x28")]
			public Image skillIcon;

			// Token: 0x040188EA RID: 100586
			[Token(Token = "0x40188EA")]
			[FieldOffset(Offset = "0x30")]
			public Image skillReadyMark;

			// Token: 0x040188EB RID: 100587
			[Token(Token = "0x40188EB")]
			[FieldOffset(Offset = "0x38")]
			public Image skillNotReadyMark;

			// Token: 0x040188EC RID: 100588
			[Token(Token = "0x40188EC")]
			[FieldOffset(Offset = "0x40")]
			public Image skillStopMark;

			// Token: 0x040188ED RID: 100589
			[Token(Token = "0x40188ED")]
			[FieldOffset(Offset = "0x48")]
			public MaskableGraphic skillAutoMark;

			// Token: 0x040188EE RID: 100590
			[Token(Token = "0x40188EE")]
			[FieldOffset(Offset = "0x50")]
			public Transform skillAmountPanel;

			// Token: 0x040188EF RID: 100591
			[Token(Token = "0x40188EF")]
			[FieldOffset(Offset = "0x58")]
			public Text skillName;

			// Token: 0x040188F0 RID: 100592
			[Token(Token = "0x40188F0")]
			[FieldOffset(Offset = "0x60")]
			public Text skillNameShadow;

			// Token: 0x040188F1 RID: 100593
			[Token(Token = "0x40188F1")]
			[FieldOffset(Offset = "0x68")]
			public Text skillAmountNum;

			// Token: 0x040188F2 RID: 100594
			[Token(Token = "0x40188F2")]
			[FieldOffset(Offset = "0x70")]
			public Text skillProgressLabel;

			// Token: 0x040188F3 RID: 100595
			[Token(Token = "0x40188F3")]
			[FieldOffset(Offset = "0x78")]
			public Color skillProgressLabelNormalColor;

			// Token: 0x040188F4 RID: 100596
			[Token(Token = "0x40188F4")]
			[FieldOffset(Offset = "0x88")]
			public Transform skillPanel;
		}
	}
}
