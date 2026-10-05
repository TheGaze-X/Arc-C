using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DF4 RID: 24052
	[Token(Token = "0x2005DF4")]
	public class CharacterShowSkillItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022DA0 RID: 142752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DA0")]
		[Address(RVA = "0x1D6EAE0", Offset = "0x1D6D6E0", VA = "0x181D6EAE0")]
		public void Render(CharacterShowSkillModel skillModel, bool isSelected, bool isSelectedVisible)
		{
		}

		// Token: 0x06022DA1 RID: 142753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DA1")]
		[Address(RVA = "0x1D6EF30", Offset = "0x1D6DB30", VA = "0x181D6EF30")]
		private void _SetSkillItemShowType(bool isEmpty, bool isUnlock, bool isSelected, bool isSelectedVisible)
		{
		}

		// Token: 0x06022DA2 RID: 142754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DA2")]
		[Address(RVA = "0x1D6E9D0", Offset = "0x1D6D5D0", VA = "0x181D6E9D0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x06022DA3 RID: 142755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DA3")]
		[Address(RVA = "0x1D6F020", Offset = "0x1D6DC20", VA = "0x181D6F020")]
		public CharacterShowSkillItem()
		{
		}

		// Token: 0x0402FFCF RID: 196559
		[Token(Token = "0x402FFCF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEnable;

		// Token: 0x0402FFD0 RID: 196560
		[Token(Token = "0x402FFD0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0402FFD1 RID: 196561
		[Token(Token = "0x402FFD1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402FFD2 RID: 196562
		[Token(Token = "0x402FFD2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectFrame;

		// Token: 0x0402FFD3 RID: 196563
		[Token(Token = "0x402FFD3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageSkill;

		// Token: 0x0402FFD4 RID: 196564
		[Token(Token = "0x402FFD4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x0402FFD5 RID: 196565
		[Token(Token = "0x402FFD5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textInit;

		// Token: 0x0402FFD6 RID: 196566
		[Token(Token = "0x402FFD6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402FFD7 RID: 196567
		[Token(Token = "0x402FFD7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _skillCost;

		// Token: 0x0402FFD8 RID: 196568
		[Token(Token = "0x402FFD8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _skillInit;

		// Token: 0x0402FFD9 RID: 196569
		[Token(Token = "0x402FFD9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _iconSpecGo;

		// Token: 0x0402FFDA RID: 196570
		[Token(Token = "0x402FFDA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgSpecIcon;

		// Token: 0x0402FFDB RID: 196571
		[Token(Token = "0x402FFDB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textMainLv;

		// Token: 0x0402FFDC RID: 196572
		[Token(Token = "0x402FFDC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402FFDD RID: 196573
		[Token(Token = "0x402FFDD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _skillUnselectAlpha;

		// Token: 0x0402FFDE RID: 196574
		[Token(Token = "0x402FFDE")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402FFDF RID: 196575
		[Token(Token = "0x402FFDF")]
		[FieldOffset(Offset = "0xA0")]
		private CharacterShowSkillModel m_skillModel;

		// Token: 0x0402FFE0 RID: 196576
		[Token(Token = "0x402FFE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FFE1 RID: 196577
		[Token(Token = "0x402FFE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetSkillItemShowType;

		// Token: 0x0402FFE2 RID: 196578
		[Token(Token = "0x402FFE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0402FFE3 RID: 196579
		[Token(Token = "0x402FFE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
