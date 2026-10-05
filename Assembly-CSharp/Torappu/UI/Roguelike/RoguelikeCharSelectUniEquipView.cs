using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054A4 RID: 21668
	[Token(Token = "0x20054A4")]
	public class RoguelikeCharSelectUniEquipView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FE1C RID: 130588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE1C")]
		[Address(RVA = "0x1A02E20", Offset = "0x1A01A20", VA = "0x181A02E20")]
		public void Render(UniEquipData equipData, bool needUpgrade)
		{
		}

		// Token: 0x0601FE1D RID: 130589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE1D")]
		[Address(RVA = "0x1A03060", Offset = "0x1A01C60", VA = "0x181A03060")]
		public RoguelikeCharSelectUniEquipView()
		{
		}

		// Token: 0x0402AFCC RID: 176076
		[Token(Token = "0x402AFCC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _equipIcon;

		// Token: 0x0402AFCD RID: 176077
		[Token(Token = "0x402AFCD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSingleType;

		// Token: 0x0402AFCE RID: 176078
		[Token(Token = "0x402AFCE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelMultiType;

		// Token: 0x0402AFCF RID: 176079
		[Token(Token = "0x402AFCF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _uniEquipSingleTypeDesc;

		// Token: 0x0402AFD0 RID: 176080
		[Token(Token = "0x402AFD0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _uniEquipMultiTypeDesc;

		// Token: 0x0402AFD1 RID: 176081
		[Token(Token = "0x402AFD1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _uniEquipMultiTypeDescImg;

		// Token: 0x0402AFD2 RID: 176082
		[Token(Token = "0x402AFD2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectedObj;

		// Token: 0x0402AFD3 RID: 176083
		[Token(Token = "0x402AFD3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _originDesc;

		// Token: 0x0402AFD4 RID: 176084
		[Token(Token = "0x402AFD4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _equipName;

		// Token: 0x0402AFD5 RID: 176085
		[Token(Token = "0x402AFD5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _equipLevel;

		// Token: 0x0402AFD6 RID: 176086
		[Token(Token = "0x402AFD6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _equipConstLevel;

		// Token: 0x0402AFD7 RID: 176087
		[Token(Token = "0x402AFD7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockedObj;

		// Token: 0x0402AFD8 RID: 176088
		[Token(Token = "0x402AFD8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AFD9 RID: 176089
		[Token(Token = "0x402AFD9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
