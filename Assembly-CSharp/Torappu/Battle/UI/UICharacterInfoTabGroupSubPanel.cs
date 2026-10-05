using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032CD RID: 13005
	[Token(Token = "0x20032CD")]
	public class UICharacterInfoTabGroupSubPanel : UICharacterInfoSubPanel
	{
		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x06014AC9 RID: 84681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F6")]
		public UICharacterTabGroup uiCharacterTabGroup
		{
			[Token(Token = "0x6014AC9")]
			[Address(RVA = "0xCF3E40", Offset = "0xCF2A40", VA = "0x180CF3E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014ACA RID: 84682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ACA")]
		[Address(RVA = "0xCF26D0", Offset = "0xCF12D0", VA = "0x180CF26D0", Slot = "4")]
		public override void OnInit(UICharacterInfoPanel parent)
		{
		}

		// Token: 0x06014ACB RID: 84683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ACB")]
		[Address(RVA = "0xCF2770", Offset = "0xCF1370", VA = "0x180CF2770", Slot = "8")]
		public virtual void Reset()
		{
		}

		// Token: 0x06014ACC RID: 84684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ACC")]
		[Address(RVA = "0xCF28A0", Offset = "0xCF14A0", VA = "0x180CF28A0", Slot = "5")]
		public override void SetData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014ACD RID: 84685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ACD")]
		[Address(RVA = "0xCF2610", Offset = "0xCF1210", VA = "0x180CF2610")]
		public void ActiveAdditionTabs(int addtionMask, bool isActive)
		{
		}

		// Token: 0x06014ACE RID: 84686 RVA: 0x00087F30 File Offset: 0x00086130
		[Token(Token = "0x6014ACE")]
		[Address(RVA = "0xCF3950", Offset = "0xCF2550", VA = "0x180CF3950")]
		private bool _UpdateTalent(CharacterData data, List<CharacterData.UniqueEquipPair> queries, bool isToken, int level, EvolvePhase phase, int potential)
		{
			return default(bool);
		}

		// Token: 0x06014ACF RID: 84687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ACF")]
		[Address(RVA = "0xCF3640", Offset = "0xCF2240", VA = "0x180CF3640")]
		private void _UpdateSkillData(SkillData data, BattleCharacterData battleCharacterData)
		{
		}

		// Token: 0x06014AD0 RID: 84688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014AD0")]
		[Address(RVA = "0xCF34A0", Offset = "0xCF20A0", VA = "0x180CF34A0")]
		private string _ParseSkillDescription(string description, Blackboard blackboard, BattleCharacterData battleCharacterData)
		{
			return null;
		}

		// Token: 0x06014AD1 RID: 84689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD1")]
		[Address(RVA = "0xCF3310", Offset = "0xCF1F10", VA = "0x180CF3310", Slot = "6")]
		public override void UpdateData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AD2 RID: 84690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD2")]
		[Address(RVA = "0xCF3CF0", Offset = "0xCF28F0", VA = "0x180CF3CF0")]
		public UICharacterInfoTabGroupSubPanel()
		{
		}

		// Token: 0x06014AD3 RID: 84691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD3")]
		[Address(RVA = "0xCEF9B0", Offset = "0xCEE5B0", VA = "0x180CEF9B0")]
		private void <>xLuaBaseProxy_OnInit(UICharacterInfoPanel P0)
		{
		}

		// Token: 0x06014AD4 RID: 84692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD4")]
		[Address(RVA = "0xCF1410", Offset = "0xCF0010", VA = "0x180CF1410")]
		private void <>xLuaBaseProxy_SetData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x06014AD5 RID: 84693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AD5")]
		[Address(RVA = "0xCF14A0", Offset = "0xCF00A0", VA = "0x180CF14A0")]
		private void <>xLuaBaseProxy_UpdateData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x0401884B RID: 100427
		[Token(Token = "0x401884B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICharacterTabGroup _uiCharacterTabGroup;

		// Token: 0x0401884C RID: 100428
		[Token(Token = "0x401884C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Profession")]
		private Text _subProfessionTraitDescriptionLabel;

		// Token: 0x0401884D RID: 100429
		[Token(Token = "0x401884D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Profession")]
		private Text _traitDescriptionText;

		// Token: 0x0401884E RID: 100430
		[Token(Token = "0x401884E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Profession")]
		private Text _subProfessionText;

		// Token: 0x0401884F RID: 100431
		[Token(Token = "0x401884F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Profession")]
		private Image _subProfessionImage;

		// Token: 0x04018850 RID: 100432
		[Token(Token = "0x4018850")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Skill")]
		private UIAutoSlideRect _skillDescAutoSlide;

		// Token: 0x04018851 RID: 100433
		[Token(Token = "0x4018851")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Skill")]
		private Text _skillNameLabel;

		// Token: 0x04018852 RID: 100434
		[Token(Token = "0x4018852")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Skill")]
		private Text _skillDescriptionLabel;

		// Token: 0x04018853 RID: 100435
		[Token(Token = "0x4018853")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Skill")]
		private Image _skillIcon;

		// Token: 0x04018854 RID: 100436
		[Token(Token = "0x4018854")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Skill")]
		private UISkillTagGroup _skillTagGroup;

		// Token: 0x04018855 RID: 100437
		[Token(Token = "0x4018855")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Skill")]
		private RectTransform _skillPanel;

		// Token: 0x04018856 RID: 100438
		[Token(Token = "0x4018856")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Talent")]
		private UICharacterTalentPair _talentTextPair;

		// Token: 0x04018857 RID: 100439
		[Token(Token = "0x4018857")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Talent")]
		private LayoutGroup _talentLayoutGroup;

		// Token: 0x04018858 RID: 100440
		[Token(Token = "0x4018858")]
		private const int MAX_TALENT_SHOW_COUNT = 2;

		// Token: 0x04018859 RID: 100441
		[Token(Token = "0x4018859")]
		[FieldOffset(Offset = "0x88")]
		private List<UICharacterTalentPair> m_talentTextPair;

		// Token: 0x0401885A RID: 100442
		[Token(Token = "0x401885A")]
		[FieldOffset(Offset = "0x90")]
		private bool m_needUpdateAutoSlide;

		// Token: 0x0401885B RID: 100443
		[Token(Token = "0x401885B")]
		[FieldOffset(Offset = "0x98")]
		private List<SkillTagViewModel> m_skillTagsCache;

		// Token: 0x0401885C RID: 100444
		[Token(Token = "0x401885C")]
		[FieldOffset(Offset = "0xA0")]
		private int m_infoTabEnableMask;

		// Token: 0x0401885D RID: 100445
		[Token(Token = "0x401885D")]
		[FieldOffset(Offset = "0xA8")]
		private List<TalentData> m_sharedTalentList;

		// Token: 0x0401885E RID: 100446
		[Token(Token = "0x401885E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiCharacterTabGroup;

		// Token: 0x0401885F RID: 100447
		[Token(Token = "0x401885F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018860 RID: 100448
		[Token(Token = "0x4018860")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04018861 RID: 100449
		[Token(Token = "0x4018861")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018862 RID: 100450
		[Token(Token = "0x4018862")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ActiveAdditionTabs;

		// Token: 0x04018863 RID: 100451
		[Token(Token = "0x4018863")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateTalent;

		// Token: 0x04018864 RID: 100452
		[Token(Token = "0x4018864")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateSkillData;

		// Token: 0x04018865 RID: 100453
		[Token(Token = "0x4018865")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ParseSkillDescription;

		// Token: 0x04018866 RID: 100454
		[Token(Token = "0x4018866")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04018867 RID: 100455
		[Token(Token = "0x4018867")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
