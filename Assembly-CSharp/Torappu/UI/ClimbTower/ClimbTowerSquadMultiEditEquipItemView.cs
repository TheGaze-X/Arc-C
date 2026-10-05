using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D78 RID: 23928
	[Token(Token = "0x2005D78")]
	public class ClimbTowerSquadMultiEditEquipItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051C8 RID: 20936
		// (get) Token: 0x06022AD6 RID: 142038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022AD7 RID: 142039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051C8")]
		public Action<int, string> onEquipSelect
		{
			[Token(Token = "0x6022AD6")]
			[Address(RVA = "0x1D3DB80", Offset = "0x1D3C780", VA = "0x181D3DB80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022AD7")]
			[Address(RVA = "0x1D3DBE0", Offset = "0x1D3C7E0", VA = "0x181D3DBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022AD8 RID: 142040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AD8")]
		[Address(RVA = "0x1D3D7A0", Offset = "0x1D3C3A0", VA = "0x181D3D7A0")]
		public void Render(int cardId, bool isSelect, ClimbTowerEquipItemModel equipItemModel)
		{
		}

		// Token: 0x06022AD9 RID: 142041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AD9")]
		[Address(RVA = "0x1D3DA70", Offset = "0x1D3C670", VA = "0x181D3DA70")]
		private void _HideAll()
		{
		}

		// Token: 0x06022ADA RID: 142042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ADA")]
		[Address(RVA = "0x1D3D6A0", Offset = "0x1D3C2A0", VA = "0x181D3D6A0")]
		public void OnEquipSelect()
		{
		}

		// Token: 0x06022ADB RID: 142043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ADB")]
		[Address(RVA = "0x1D3DB10", Offset = "0x1D3C710", VA = "0x181D3DB10")]
		public ClimbTowerSquadMultiEditEquipItemView()
		{
		}

		// Token: 0x0402FAAF RID: 195247
		[Token(Token = "0x402FAAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectBgGo;

		// Token: 0x0402FAB0 RID: 195248
		[Token(Token = "0x402FAB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconSelectGo;

		// Token: 0x0402FAB1 RID: 195249
		[Token(Token = "0x402FAB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0402FAB2 RID: 195250
		[Token(Token = "0x402FAB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0402FAB3 RID: 195251
		[Token(Token = "0x402FAB3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x0402FAB4 RID: 195252
		[Token(Token = "0x402FAB4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _levelGo;

		// Token: 0x0402FAB5 RID: 195253
		[Token(Token = "0x402FAB5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x0402FAB6 RID: 195254
		[Token(Token = "0x402FAB6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textEquipName;

		// Token: 0x0402FAB7 RID: 195255
		[Token(Token = "0x402FAB7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgEquipIcon;

		// Token: 0x0402FAB8 RID: 195256
		[Token(Token = "0x402FAB8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgEquipType;

		// Token: 0x0402FAB9 RID: 195257
		[Token(Token = "0x402FAB9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402FABA RID: 195258
		[Token(Token = "0x402FABA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _unselectAlpha;

		// Token: 0x0402FABB RID: 195259
		[Token(Token = "0x402FABB")]
		[FieldOffset(Offset = "0x74")]
		private int m_cardId;

		// Token: 0x0402FABC RID: 195260
		[Token(Token = "0x402FABC")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isSelect;

		// Token: 0x0402FABD RID: 195261
		[Token(Token = "0x402FABD")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerEquipItemModel m_equipModel;

		// Token: 0x0402FABF RID: 195263
		[Token(Token = "0x402FABF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEquipSelect;

		// Token: 0x0402FAC0 RID: 195264
		[Token(Token = "0x402FAC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEquipSelect;

		// Token: 0x0402FAC1 RID: 195265
		[Token(Token = "0x402FAC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FAC2 RID: 195266
		[Token(Token = "0x402FAC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideAll;

		// Token: 0x0402FAC3 RID: 195267
		[Token(Token = "0x402FAC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEquipSelect;

		// Token: 0x0402FAC4 RID: 195268
		[Token(Token = "0x402FAC4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
