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
	// Token: 0x020032C7 RID: 12999
	[Token(Token = "0x20032C7")]
	public class UICharacterInfoStatusSubPanel : UICharacterInfoSubPanel
	{
		// Token: 0x06014AAD RID: 84653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AAD")]
		[Address(RVA = "0xCF08E0", Offset = "0xCEF4E0", VA = "0x180CF08E0", Slot = "5")]
		public override void SetData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AAE RID: 84654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AAE")]
		[Address(RVA = "0xCF20D0", Offset = "0xCF0CD0", VA = "0x180CF20D0")]
		private void _UpdateUniequipTypeIcon(List<CharacterData.UniqueEquipPair> queries, bool isToken)
		{
		}

		// Token: 0x06014AAF RID: 84655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AAF")]
		[Address(RVA = "0xCF15C0", Offset = "0xCF01C0", VA = "0x180CF15C0", Slot = "6")]
		public override void UpdateData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AB0 RID: 84656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB0")]
		[Address(RVA = "0xCF1E80", Offset = "0xCF0A80", VA = "0x180CF1E80", Slot = "7")]
		public override void UpdateExtraData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AB1 RID: 84657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB1")]
		[Address(RVA = "0xCF23D0", Offset = "0xCF0FD0", VA = "0x180CF23D0")]
		public UICharacterInfoStatusSubPanel()
		{
		}

		// Token: 0x06014AB2 RID: 84658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB2")]
		[Address(RVA = "0xCF1410", Offset = "0xCF0010", VA = "0x180CF1410")]
		private void <>xLuaBaseProxy_SetData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x06014AB3 RID: 84659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB3")]
		[Address(RVA = "0xCF14A0", Offset = "0xCF00A0", VA = "0x180CF14A0")]
		private void <>xLuaBaseProxy_UpdateData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x06014AB4 RID: 84660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB4")]
		[Address(RVA = "0xCF1530", Offset = "0xCF0130", VA = "0x180CF1530")]
		private void <>xLuaBaseProxy_UpdateExtraData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x0401880B RID: 100363
		[Token(Token = "0x401880B")]
		private const string DEFAULT_LABEL_DISPLAY = "0/0";

		// Token: 0x0401880C RID: 100364
		[Token(Token = "0x401880C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Config")]
		private Image _eliteIcon;

		// Token: 0x0401880D RID: 100365
		[Token(Token = "0x401880D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Config")]
		private Text _nameEnLabel;

		// Token: 0x0401880E RID: 100366
		[Token(Token = "0x401880E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Config")]
		private Text _nameCnLabel;

		// Token: 0x0401880F RID: 100367
		[Token(Token = "0x401880F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Config")]
		private Text _lvlLabel;

		// Token: 0x04018810 RID: 100368
		[Token(Token = "0x4018810")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Config")]
		[Collection(4)]
		private Sprite[] _evolveIcons;

		// Token: 0x04018811 RID: 100369
		[Token(Token = "0x4018811")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Status")]
		private Slider _hpSlider;

		// Token: 0x04018812 RID: 100370
		[Token(Token = "0x4018812")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Status")]
		private Slider _spSlider;

		// Token: 0x04018813 RID: 100371
		[Token(Token = "0x4018813")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Status")]
		private Text _hpLabel;

		// Token: 0x04018814 RID: 100372
		[Token(Token = "0x4018814")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Status")]
		private Text _atkLabel;

		// Token: 0x04018815 RID: 100373
		[Token(Token = "0x4018815")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Status")]
		private Text _defLabel;

		// Token: 0x04018816 RID: 100374
		[Token(Token = "0x4018816")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Status")]
		private Text _magicResistLabel;

		// Token: 0x04018817 RID: 100375
		[Token(Token = "0x4018817")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Status")]
		private Text _blockLabel;

		// Token: 0x04018818 RID: 100376
		[Token(Token = "0x4018818")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Status")]
		private Text _spLabel;

		// Token: 0x04018819 RID: 100377
		[Token(Token = "0x4018819")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Attack Range")]
		private RectTransform _attackRangeContainer;

		// Token: 0x0401881A RID: 100378
		[Token(Token = "0x401881A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Attack Range")]
		private UICharacterAttackRangeWidget _attackRangeWidget;

		// Token: 0x0401881B RID: 100379
		[Token(Token = "0x401881B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Profession")]
		protected UICharacterInfoStatusSubPanel.ProfessionSpritePair[] _professionIcons;

		// Token: 0x0401881C RID: 100380
		[Token(Token = "0x401881C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Profession")]
		protected Image _professionImage;

		// Token: 0x0401881D RID: 100381
		[Token(Token = "0x401881D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Profession")]
		private Image _uniEquipTypeIcon;

		// Token: 0x0401881E RID: 100382
		[Token(Token = "0x401881E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401881F RID: 100383
		[Token(Token = "0x401881F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateUniequipTypeIcon;

		// Token: 0x04018820 RID: 100384
		[Token(Token = "0x4018820")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04018821 RID: 100385
		[Token(Token = "0x4018821")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateExtraData;

		// Token: 0x04018822 RID: 100386
		[Token(Token = "0x4018822")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032C8 RID: 13000
		[Token(Token = "0x20032C8")]
		[Serializable]
		protected struct ProfessionSpritePair
		{
			// Token: 0x04018823 RID: 100387
			[Token(Token = "0x4018823")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory profession;

			// Token: 0x04018824 RID: 100388
			[Token(Token = "0x4018824")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;
		}
	}
}
