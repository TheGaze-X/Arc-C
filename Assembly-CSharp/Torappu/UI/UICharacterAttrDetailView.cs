using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.CharacterShow;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003528 RID: 13608
	[Token(Token = "0x2003528")]
	public class UICharacterAttrDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015B01 RID: 88833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B01")]
		[Address(RVA = "0xE485A0", Offset = "0xE471A0", VA = "0x180E485A0")]
		public void Render(CharacterShowV2Model charShowModel)
		{
		}

		// Token: 0x06015B02 RID: 88834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B02")]
		[Address(RVA = "0xE48D20", Offset = "0xE47920", VA = "0x180E48D20")]
		private void _RenderBasicInfo(CharacterShowV2Model charShowModel)
		{
		}

		// Token: 0x06015B03 RID: 88835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B03")]
		[Address(RVA = "0xE488A0", Offset = "0xE474A0", VA = "0x180E488A0")]
		private void _RenderAttrs(CharacterShowV2Model charShowModel)
		{
		}

		// Token: 0x06015B04 RID: 88836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B04")]
		[Address(RVA = "0xE487F0", Offset = "0xE473F0", VA = "0x180E487F0")]
		private void _RenderAttackRange(CharacterShowV2Model charShowModel)
		{
		}

		// Token: 0x06015B05 RID: 88837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B05")]
		[Address(RVA = "0xE48FA0", Offset = "0xE47BA0", VA = "0x180E48FA0")]
		private void _RenderFavorPoint(CharacterShowV2Model charShowModel)
		{
		}

		// Token: 0x06015B06 RID: 88838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B06")]
		[Address(RVA = "0xE49120", Offset = "0xE47D20", VA = "0x180E49120")]
		public UICharacterAttrDetailView()
		{
		}

		// Token: 0x0401A0AA RID: 106666
		[Token(Token = "0x401A0AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Attribute")]
		private Text _maxHp;

		// Token: 0x0401A0AB RID: 106667
		[Token(Token = "0x401A0AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Attribute")]
		private Text _reviveTime;

		// Token: 0x0401A0AC RID: 106668
		[Token(Token = "0x401A0AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Attribute")]
		private Text _atk;

		// Token: 0x0401A0AD RID: 106669
		[Token(Token = "0x401A0AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Attribute")]
		private Text _cost;

		// Token: 0x0401A0AE RID: 106670
		[Token(Token = "0x401A0AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Attribute")]
		private Text _def;

		// Token: 0x0401A0AF RID: 106671
		[Token(Token = "0x401A0AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Attribute")]
		private Text _blockNum;

		// Token: 0x0401A0B0 RID: 106672
		[Token(Token = "0x401A0B0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Attribute")]
		private Text _res;

		// Token: 0x0401A0B1 RID: 106673
		[Token(Token = "0x401A0B1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Attribute")]
		private Text _atkSpeed;

		// Token: 0x0401A0B2 RID: 106674
		[Token(Token = "0x401A0B2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Attribute")]
		private Slider _sliderMaxHpVal;

		// Token: 0x0401A0B3 RID: 106675
		[Token(Token = "0x401A0B3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Attribute")]
		private Slider _sliderAtkVal;

		// Token: 0x0401A0B4 RID: 106676
		[Token(Token = "0x401A0B4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Attribute")]
		private Slider _sliderDefVal;

		// Token: 0x0401A0B5 RID: 106677
		[Token(Token = "0x401A0B5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Attribute")]
		private Slider _sliderResVal;

		// Token: 0x0401A0B6 RID: 106678
		[Token(Token = "0x401A0B6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("BasicInfo")]
		private Text _textPosition;

		// Token: 0x0401A0B7 RID: 106679
		[Token(Token = "0x401A0B7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("BasicInfo")]
		private Text _textTags;

		// Token: 0x0401A0B8 RID: 106680
		[Token(Token = "0x401A0B8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("BasicInfo")]
		private Image _imgProfession;

		// Token: 0x0401A0B9 RID: 106681
		[Token(Token = "0x401A0B9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("BasicInfo")]
		private Image _raritySprite;

		// Token: 0x0401A0BA RID: 106682
		[Token(Token = "0x401A0BA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("BasicInfo")]
		private Image _campSprite;

		// Token: 0x0401A0BB RID: 106683
		[Token(Token = "0x401A0BB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("BasicInfo")]
		private Text _name;

		// Token: 0x0401A0BC RID: 106684
		[Token(Token = "0x401A0BC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("BasicInfo")]
		private Text _appellation;

		// Token: 0x0401A0BD RID: 106685
		[Token(Token = "0x401A0BD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Favor Point")]
		private Text _textFavorPoint;

		// Token: 0x0401A0BE RID: 106686
		[Token(Token = "0x401A0BE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Favor Point")]
		private Slider _sliderFavorPoint;

		// Token: 0x0401A0BF RID: 106687
		[Token(Token = "0x401A0BF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x0401A0C0 RID: 106688
		[Token(Token = "0x401A0C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A0C1 RID: 106689
		[Token(Token = "0x401A0C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderBasicInfo;

		// Token: 0x0401A0C2 RID: 106690
		[Token(Token = "0x401A0C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderAttrs;

		// Token: 0x0401A0C3 RID: 106691
		[Token(Token = "0x401A0C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderAttackRange;

		// Token: 0x0401A0C4 RID: 106692
		[Token(Token = "0x401A0C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderFavorPoint;

		// Token: 0x0401A0C5 RID: 106693
		[Token(Token = "0x401A0C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
