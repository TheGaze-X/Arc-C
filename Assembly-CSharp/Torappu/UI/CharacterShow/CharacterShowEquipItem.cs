using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DEF RID: 24047
	[Token(Token = "0x2005DEF")]
	public class CharacterShowEquipItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022D8E RID: 142734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D8E")]
		[Address(RVA = "0x1D6CB00", Offset = "0x1D6B700", VA = "0x181D6CB00")]
		public void Render(CharacterShowEquipModel equipModel, bool isSelected, bool isSelectedVisible)
		{
		}

		// Token: 0x06022D8F RID: 142735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D8F")]
		[Address(RVA = "0x1D6CFC0", Offset = "0x1D6BBC0", VA = "0x181D6CFC0")]
		private void _SetEquipItemShowType(bool isEmpty, bool isUnlock, bool isSelected, bool isSelectedVisible)
		{
		}

		// Token: 0x06022D90 RID: 142736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D90")]
		[Address(RVA = "0x1D6C9F0", Offset = "0x1D6B5F0", VA = "0x181D6C9F0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x06022D91 RID: 142737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D91")]
		[Address(RVA = "0x1D6D0B0", Offset = "0x1D6BCB0", VA = "0x181D6D0B0")]
		public CharacterShowEquipItem()
		{
		}

		// Token: 0x0402FF8B RID: 196491
		[Token(Token = "0x402FF8B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0402FF8C RID: 196492
		[Token(Token = "0x402FF8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0402FF8D RID: 196493
		[Token(Token = "0x402FF8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0402FF8E RID: 196494
		[Token(Token = "0x402FF8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectedPartGo;

		// Token: 0x0402FF8F RID: 196495
		[Token(Token = "0x402FF8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgEquipIcon;

		// Token: 0x0402FF90 RID: 196496
		[Token(Token = "0x402FF90")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgShining;

		// Token: 0x0402FF91 RID: 196497
		[Token(Token = "0x402FF91")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelSingleType;

		// Token: 0x0402FF92 RID: 196498
		[Token(Token = "0x402FF92")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelMultiType;

		// Token: 0x0402FF93 RID: 196499
		[Token(Token = "0x402FF93")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textSingleTypeDesc;

		// Token: 0x0402FF94 RID: 196500
		[Token(Token = "0x402FF94")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textMultiTypeDesc;

		// Token: 0x0402FF95 RID: 196501
		[Token(Token = "0x402FF95")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgMultiType;

		// Token: 0x0402FF96 RID: 196502
		[Token(Token = "0x402FF96")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402FF97 RID: 196503
		[Token(Token = "0x402FF97")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _levelPanelGo;

		// Token: 0x0402FF98 RID: 196504
		[Token(Token = "0x402FF98")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0402FF99 RID: 196505
		[Token(Token = "0x402FF99")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402FF9A RID: 196506
		[Token(Token = "0x402FF9A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _skillUnselectAlpha;

		// Token: 0x0402FF9B RID: 196507
		[Token(Token = "0x402FF9B")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402FF9C RID: 196508
		[Token(Token = "0x402FF9C")]
		[FieldOffset(Offset = "0xA8")]
		private CharacterShowEquipModel m_equipModel;

		// Token: 0x0402FF9D RID: 196509
		[Token(Token = "0x402FF9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FF9E RID: 196510
		[Token(Token = "0x402FF9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetEquipItemShowType;

		// Token: 0x0402FF9F RID: 196511
		[Token(Token = "0x402FF9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0402FFA0 RID: 196512
		[Token(Token = "0x402FFA0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
