using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DF7 RID: 24055
	[Token(Token = "0x2005DF7")]
	public class CharacterShowV2LeftInfoView : DataBinder<CharacterShowProp>
	{
		// Token: 0x06022DAA RID: 142762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DAA")]
		[Address(RVA = "0x1D70790", Offset = "0x1D6F390", VA = "0x181D70790", Slot = "7")]
		public override void OnValueChanged(CharacterShowProp property)
		{
		}

		// Token: 0x06022DAB RID: 142763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DAB")]
		[Address(RVA = "0x1D70FA0", Offset = "0x1D6FBA0", VA = "0x181D70FA0")]
		private void _UpdateAttackRange()
		{
		}

		// Token: 0x06022DAC RID: 142764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DAC")]
		[Address(RVA = "0x1D717A0", Offset = "0x1D703A0", VA = "0x181D717A0")]
		private void _UpdateCharInfo()
		{
		}

		// Token: 0x06022DAD RID: 142765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DAD")]
		[Address(RVA = "0x1D71040", Offset = "0x1D6FC40", VA = "0x181D71040")]
		private void _UpdateAttrs()
		{
		}

		// Token: 0x06022DAE RID: 142766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DAE")]
		[Address(RVA = "0x1D70D40", Offset = "0x1D6F940", VA = "0x181D70D40")]
		private void _LoadCharIllust()
		{
		}

		// Token: 0x06022DAF RID: 142767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DAF")]
		[Address(RVA = "0x1D70AF0", Offset = "0x1D6F6F0", VA = "0x181D70AF0")]
		private string _GetAttrValWithFavor(int totalVal, int favorVal)
		{
			return null;
		}

		// Token: 0x06022DB0 RID: 142768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DB0")]
		[Address(RVA = "0x1D70C10", Offset = "0x1D6F810", VA = "0x181D70C10")]
		private string _GetAttrValWithFavor(float totalVal, float favorVal)
		{
			return null;
		}

		// Token: 0x06022DB1 RID: 142769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DB1")]
		[Address(RVA = "0x1D71920", Offset = "0x1D70520", VA = "0x181D71920")]
		public CharacterShowV2LeftInfoView()
		{
		}

		// Token: 0x0402FFFA RID: 196602
		[Token(Token = "0x402FFFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Attribute")]
		private Text _maxHp;

		// Token: 0x0402FFFB RID: 196603
		[Token(Token = "0x402FFFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Attribute")]
		private Text _reviveTime;

		// Token: 0x0402FFFC RID: 196604
		[Token(Token = "0x402FFFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Attribute")]
		private Text _atk;

		// Token: 0x0402FFFD RID: 196605
		[Token(Token = "0x402FFFD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Attribute")]
		private Text _cost;

		// Token: 0x0402FFFE RID: 196606
		[Token(Token = "0x402FFFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Attribute")]
		private Text _def;

		// Token: 0x0402FFFF RID: 196607
		[Token(Token = "0x402FFFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Attribute")]
		private Text _blockNum;

		// Token: 0x04030000 RID: 196608
		[Token(Token = "0x4030000")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Attribute")]
		private Text _res;

		// Token: 0x04030001 RID: 196609
		[Token(Token = "0x4030001")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Attribute")]
		private Text _atkSpeed;

		// Token: 0x04030002 RID: 196610
		[Token(Token = "0x4030002")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x04030003 RID: 196611
		[Token(Token = "0x4030003")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgEvolve;

		// Token: 0x04030004 RID: 196612
		[Token(Token = "0x4030004")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgPotential;

		// Token: 0x04030005 RID: 196613
		[Token(Token = "0x4030005")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharacterInfoIllustWrapper _illustWrapper;

		// Token: 0x04030006 RID: 196614
		[Token(Token = "0x4030006")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _raritySprite;

		// Token: 0x04030007 RID: 196615
		[Token(Token = "0x4030007")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _campSprite;

		// Token: 0x04030008 RID: 196616
		[Token(Token = "0x4030008")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _name;

		// Token: 0x04030009 RID: 196617
		[Token(Token = "0x4030009")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _appellation;

		// Token: 0x0403000A RID: 196618
		[Token(Token = "0x403000A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textPosition;

		// Token: 0x0403000B RID: 196619
		[Token(Token = "0x403000B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textTags;

		// Token: 0x0403000C RID: 196620
		[Token(Token = "0x403000C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0403000D RID: 196621
		[Token(Token = "0x403000D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x0403000E RID: 196622
		[Token(Token = "0x403000E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _textFavorPoint;

		// Token: 0x0403000F RID: 196623
		[Token(Token = "0x403000F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Slider _sliderFavorPoint;

		// Token: 0x04030010 RID: 196624
		[Token(Token = "0x4030010")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04030011 RID: 196625
		[Token(Token = "0x4030011")]
		[FieldOffset(Offset = "0xE0")]
		private CharacterShowV2Model m_charShowModel;

		// Token: 0x04030012 RID: 196626
		[Token(Token = "0x4030012")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030013 RID: 196627
		[Token(Token = "0x4030013")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateAttackRange;

		// Token: 0x04030014 RID: 196628
		[Token(Token = "0x4030014")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateCharInfo;

		// Token: 0x04030015 RID: 196629
		[Token(Token = "0x4030015")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateAttrs;

		// Token: 0x04030016 RID: 196630
		[Token(Token = "0x4030016")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadCharIllust;

		// Token: 0x04030017 RID: 196631
		[Token(Token = "0x4030017")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetAttrValWithFavor;

		// Token: 0x04030018 RID: 196632
		[Token(Token = "0x4030018")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1__GetAttrValWithFavor;

		// Token: 0x04030019 RID: 196633
		[Token(Token = "0x4030019")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
