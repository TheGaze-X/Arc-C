using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D88 RID: 23944
	[Token(Token = "0x2005D88")]
	public class ClimbTowerSquadSingleEditCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051E9 RID: 20969
		// (get) Token: 0x06022B4F RID: 142159 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022B50 RID: 142160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051E9")]
		public Action<int> onCharSelect
		{
			[Token(Token = "0x6022B4F")]
			[Address(RVA = "0x1D43050", Offset = "0x1D41C50", VA = "0x181D43050")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022B50")]
			[Address(RVA = "0x1D430B0", Offset = "0x1D41CB0", VA = "0x181D430B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022B51 RID: 142161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B51")]
		[Address(RVA = "0x1D429F0", Offset = "0x1D415F0", VA = "0x181D429F0")]
		public void UpdateViewData(ClimbTowerSquadItemModel squadItemModel, int selectCardId)
		{
		}

		// Token: 0x06022B52 RID: 142162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B52")]
		[Address(RVA = "0x1D42C50", Offset = "0x1D41850", VA = "0x181D42C50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022B53 RID: 142163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B53")]
		[Address(RVA = "0x1D42E70", Offset = "0x1D41A70", VA = "0x181D42E70")]
		private void _OnCharClick(int _)
		{
		}

		// Token: 0x06022B54 RID: 142164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B54")]
		[Address(RVA = "0x1D42FE0", Offset = "0x1D41BE0", VA = "0x181D42FE0")]
		public ClimbTowerSquadSingleEditCharItemView()
		{
		}

		// Token: 0x0402FB6A RID: 195434
		[Token(Token = "0x402FB6A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _charCardRoot;

		// Token: 0x0402FB6B RID: 195435
		[Token(Token = "0x402FB6B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _charCardScale;

		// Token: 0x0402FB6C RID: 195436
		[Token(Token = "0x402FB6C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x0402FB6D RID: 195437
		[Token(Token = "0x402FB6D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _trackNewGo;

		// Token: 0x0402FB6E RID: 195438
		[Token(Token = "0x402FB6E")]
		[FieldOffset(Offset = "0x38")]
		private UICharacterCardPanel m_charCard;

		// Token: 0x0402FB6F RID: 195439
		[Token(Token = "0x402FB6F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402FB70 RID: 195440
		[Token(Token = "0x402FB70")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerSquadItemModel m_squadItemModel;

		// Token: 0x0402FB71 RID: 195441
		[Token(Token = "0x402FB71")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isSelect;

		// Token: 0x0402FB73 RID: 195443
		[Token(Token = "0x402FB73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCharSelect;

		// Token: 0x0402FB74 RID: 195444
		[Token(Token = "0x402FB74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCharSelect;

		// Token: 0x0402FB75 RID: 195445
		[Token(Token = "0x402FB75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateViewData;

		// Token: 0x0402FB76 RID: 195446
		[Token(Token = "0x402FB76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FB77 RID: 195447
		[Token(Token = "0x402FB77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCharClick;

		// Token: 0x0402FB78 RID: 195448
		[Token(Token = "0x402FB78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
