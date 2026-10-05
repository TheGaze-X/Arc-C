using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003308 RID: 13064
	[Token(Token = "0x2003308")]
	public class UICharacterMenuPanel : MonoBehaviour, UICharacterMenuState.IUICharacterMenuPanel, IHotfixable
	{
		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x06014BE8 RID: 84968 RVA: 0x00088350 File Offset: 0x00086550
		// (set) Token: 0x06014BE9 RID: 84969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700311D")]
		public bool isOpen
		{
			[Token(Token = "0x6014BE8")]
			[Address(RVA = "0xD271A0", Offset = "0xD25DA0", VA = "0x180D271A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014BE9")]
			[Address(RVA = "0xD27320", Offset = "0xD25F20", VA = "0x180D27320")]
			private set
			{
			}
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x06014BEA RID: 84970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700311E")]
		public Transform withdrawPanel
		{
			[Token(Token = "0x6014BEA")]
			[Address(RVA = "0xD272C0", Offset = "0xD25EC0", VA = "0x180D272C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x06014BEB RID: 84971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700311F")]
		public Button withdrawButton
		{
			[Token(Token = "0x6014BEB")]
			[Address(RVA = "0xD27260", Offset = "0xD25E60", VA = "0x180D27260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x06014BEC RID: 84972 RVA: 0x00088368 File Offset: 0x00086568
		// (set) Token: 0x06014BED RID: 84973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003120")]
		private protected bool isSkillCasting
		{
			[Token(Token = "0x6014BEC")]
			[Address(RVA = "0xD27200", Offset = "0xD25E00", VA = "0x180D27200")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6014BED")]
			[Address(RVA = "0xD273A0", Offset = "0xD25FA0", VA = "0x180D273A0")]
			private set
			{
			}
		}

		// Token: 0x06014BEE RID: 84974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BEE")]
		[Address(RVA = "0xD25040", Offset = "0xD23C40", VA = "0x180D25040")]
		public void OnInit()
		{
		}

		// Token: 0x06014BEF RID: 84975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BEF")]
		[Address(RVA = "0xD254B0", Offset = "0xD240B0", VA = "0x180D254B0")]
		public void OnWithdrawButtonClicked()
		{
		}

		// Token: 0x06014BF0 RID: 84976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF0")]
		[Address(RVA = "0xD25110", Offset = "0xD23D10", VA = "0x180D25110")]
		public void OnSkillButtonClicked()
		{
		}

		// Token: 0x06014BF1 RID: 84977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF1")]
		[Address(RVA = "0xD25390", Offset = "0xD23F90", VA = "0x180D25390")]
		public void OnSkillRetriggerButtonClicked()
		{
		}

		// Token: 0x06014BF2 RID: 84978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF2")]
		[Address(RVA = "0xD25250", Offset = "0xD23E50", VA = "0x180D25250")]
		public void OnSkillRangeToggled()
		{
		}

		// Token: 0x06014BF3 RID: 84979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF3")]
		[Address(RVA = "0xD255F0", Offset = "0xD241F0", VA = "0x180D255F0", Slot = "4")]
		public void Show(Character character)
		{
		}

		// Token: 0x06014BF4 RID: 84980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF4")]
		[Address(RVA = "0xD24F00", Offset = "0xD23B00", VA = "0x180D24F00", Slot = "5")]
		public void Hide()
		{
		}

		// Token: 0x06014BF5 RID: 84981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF5")]
		[Address(RVA = "0xD261A0", Offset = "0xD24DA0", VA = "0x180D261A0")]
		private void _SetSkillCastingInternal(bool value, bool force)
		{
		}

		// Token: 0x06014BF6 RID: 84982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF6")]
		[Address(RVA = "0xD25940", Offset = "0xD24540", VA = "0x180D25940")]
		private void _SetData(Character character)
		{
		}

		// Token: 0x06014BF7 RID: 84983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF7")]
		[Address(RVA = "0xD26E10", Offset = "0xD25A10", VA = "0x180D26E10")]
		private void _UpdateSkillToggle(Character character)
		{
		}

		// Token: 0x06014BF8 RID: 84984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF8")]
		[Address(RVA = "0xD26F30", Offset = "0xD25B30", VA = "0x180D26F30")]
		private void _UpdateWithDrawablePanel(Character character, bool force)
		{
		}

		// Token: 0x06014BF9 RID: 84985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BF9")]
		[Address(RVA = "0xD262E0", Offset = "0xD24EE0", VA = "0x180D262E0")]
		private void _UpdateData()
		{
		}

		// Token: 0x06014BFA RID: 84986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BFA")]
		[Address(RVA = "0xD26BC0", Offset = "0xD257C0", VA = "0x180D26BC0")]
		private void _UpdateSkillCount(Character character, bool force)
		{
		}

		// Token: 0x06014BFB RID: 84987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BFB")]
		[Address(RVA = "0xD260E0", Offset = "0xD24CE0", VA = "0x180D260E0")]
		private void _SetOpenInternal(bool value, bool force)
		{
		}

		// Token: 0x06014BFC RID: 84988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BFC")]
		[Address(RVA = "0xD25820", Offset = "0xD24420", VA = "0x180D25820")]
		private void _DoUpdateRangeToShow(Character character)
		{
		}

		// Token: 0x06014BFD RID: 84989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BFD")]
		[Address(RVA = "0xD257C0", Offset = "0xD243C0", VA = "0x180D257C0")]
		private void Update()
		{
		}

		// Token: 0x06014BFE RID: 84990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BFE")]
		[Address(RVA = "0xD27140", Offset = "0xD25D40", VA = "0x180D27140")]
		public UICharacterMenuPanel()
		{
		}

		// Token: 0x04018AA7 RID: 101031
		[Token(Token = "0x4018AA7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIButton _skillButton;

		// Token: 0x04018AA8 RID: 101032
		[Token(Token = "0x4018AA8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _withdrawButton;

		// Token: 0x04018AA9 RID: 101033
		[Token(Token = "0x4018AA9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _withdrawPanel;

		// Token: 0x04018AAA RID: 101034
		[Token(Token = "0x4018AAA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _skillToNextSlider;

		// Token: 0x04018AAB RID: 101035
		[Token(Token = "0x4018AAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _skillCastingSlider;

		// Token: 0x04018AAC RID: 101036
		[Token(Token = "0x4018AAC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x04018AAD RID: 101037
		[Token(Token = "0x4018AAD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _skillReadyMark;

		// Token: 0x04018AAE RID: 101038
		[Token(Token = "0x4018AAE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _skillNotReadyMark;

		// Token: 0x04018AAF RID: 101039
		[Token(Token = "0x4018AAF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _skillStopMark;

		// Token: 0x04018AB0 RID: 101040
		[Token(Token = "0x4018AB0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _skillBulletMark;

		// Token: 0x04018AB1 RID: 101041
		[Token(Token = "0x4018AB1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _skillBulletLabel;

		// Token: 0x04018AB2 RID: 101042
		[Token(Token = "0x4018AB2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _skillReadyButShowStackProcessMark;

		// Token: 0x04018AB3 RID: 101043
		[Token(Token = "0x4018AB3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIBattleRetriggerSkillPanel _retriggerSkillPanel;

		// Token: 0x04018AB4 RID: 101044
		[Token(Token = "0x4018AB4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private MaskableGraphic _skillAutoMark;

		// Token: 0x04018AB5 RID: 101045
		[Token(Token = "0x4018AB5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _skillAmountPanel;

		// Token: 0x04018AB6 RID: 101046
		[Token(Token = "0x4018AB6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _skillAmountNum;

		// Token: 0x04018AB7 RID: 101047
		[Token(Token = "0x4018AB7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _skillProgressLabel;

		// Token: 0x04018AB8 RID: 101048
		[Token(Token = "0x4018AB8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _skillProgressLabelNormalColor;

		// Token: 0x04018AB9 RID: 101049
		[Token(Token = "0x4018AB9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _skillProgressLabelStackColor;

		// Token: 0x04018ABA RID: 101050
		[Token(Token = "0x4018ABA")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Toggle _skillRangeToggle;

		// Token: 0x04018ABB RID: 101051
		[Token(Token = "0x4018ABB")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform _skillPanel;

		// Token: 0x04018ABC RID: 101052
		[Token(Token = "0x4018ABC")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Follower2D _follower;

		// Token: 0x04018ABD RID: 101053
		[Token(Token = "0x4018ABD")]
		[FieldOffset(Offset = "0xD8")]
		private ObjectPtr<Character> m_character;

		// Token: 0x04018ABE RID: 101054
		[Token(Token = "0x4018ABE")]
		[FieldOffset(Offset = "0xE8")]
		private Deck.Card m_card;

		// Token: 0x04018ABF RID: 101055
		[Token(Token = "0x4018ABF")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isSkillCasting;

		// Token: 0x04018AC0 RID: 101056
		[Token(Token = "0x4018AC0")]
		[FieldOffset(Offset = "0xF1")]
		private bool m_isSkillAmountShown;

		// Token: 0x04018AC1 RID: 101057
		[Token(Token = "0x4018AC1")]
		[FieldOffset(Offset = "0xF2")]
		private bool m_isOpen;

		// Token: 0x04018AC2 RID: 101058
		[Token(Token = "0x4018AC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOpen;

		// Token: 0x04018AC3 RID: 101059
		[Token(Token = "0x4018AC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isOpen;

		// Token: 0x04018AC4 RID: 101060
		[Token(Token = "0x4018AC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_withdrawPanel;

		// Token: 0x04018AC5 RID: 101061
		[Token(Token = "0x4018AC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_withdrawButton;

		// Token: 0x04018AC6 RID: 101062
		[Token(Token = "0x4018AC6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isSkillCasting;

		// Token: 0x04018AC7 RID: 101063
		[Token(Token = "0x4018AC7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isSkillCasting;

		// Token: 0x04018AC8 RID: 101064
		[Token(Token = "0x4018AC8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018AC9 RID: 101065
		[Token(Token = "0x4018AC9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnWithdrawButtonClicked;

		// Token: 0x04018ACA RID: 101066
		[Token(Token = "0x4018ACA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSkillButtonClicked;

		// Token: 0x04018ACB RID: 101067
		[Token(Token = "0x4018ACB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSkillRetriggerButtonClicked;

		// Token: 0x04018ACC RID: 101068
		[Token(Token = "0x4018ACC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSkillRangeToggled;

		// Token: 0x04018ACD RID: 101069
		[Token(Token = "0x4018ACD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04018ACE RID: 101070
		[Token(Token = "0x4018ACE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04018ACF RID: 101071
		[Token(Token = "0x4018ACF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetSkillCastingInternal;

		// Token: 0x04018AD0 RID: 101072
		[Token(Token = "0x4018AD0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x04018AD1 RID: 101073
		[Token(Token = "0x4018AD1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateSkillToggle;

		// Token: 0x04018AD2 RID: 101074
		[Token(Token = "0x4018AD2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateWithDrawablePanel;

		// Token: 0x04018AD3 RID: 101075
		[Token(Token = "0x4018AD3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04018AD4 RID: 101076
		[Token(Token = "0x4018AD4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateSkillCount;

		// Token: 0x04018AD5 RID: 101077
		[Token(Token = "0x4018AD5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetOpenInternal;

		// Token: 0x04018AD6 RID: 101078
		[Token(Token = "0x4018AD6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DoUpdateRangeToShow;

		// Token: 0x04018AD7 RID: 101079
		[Token(Token = "0x4018AD7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018AD8 RID: 101080
		[Token(Token = "0x4018AD8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
