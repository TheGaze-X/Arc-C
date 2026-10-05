using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005702 RID: 22274
	[Token(Token = "0x2005702")]
	public class RL04TempNodeUpgradeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020AB6 RID: 133814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AB6")]
		[Address(RVA = "0x1ACF120", Offset = "0x1ACDD20", VA = "0x181ACF120")]
		public void Render(RL04TempNodeUpgradeItemModel tempNodeModel, RL04NodeUpgradeConfig styleConfig, bool isCurrToDo)
		{
		}

		// Token: 0x06020AB7 RID: 133815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AB7")]
		[Address(RVA = "0x1ACF390", Offset = "0x1ACDF90", VA = "0x181ACF390")]
		public RL04TempNodeUpgradeItemView()
		{
		}

		// Token: 0x0402C55E RID: 181598
		[Token(Token = "0x402C55E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgDescBg;

		// Token: 0x0402C55F RID: 181599
		[Token(Token = "0x402C55F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _colorInactiveBg;

		// Token: 0x0402C560 RID: 181600
		[Token(Token = "0x402C560")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402C561 RID: 181601
		[Token(Token = "0x402C561")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorInactiveDesc;

		// Token: 0x0402C562 RID: 181602
		[Token(Token = "0x402C562")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorActiveDesc;

		// Token: 0x0402C563 RID: 181603
		[Token(Token = "0x402C563")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _bgToDoGo;

		// Token: 0x0402C564 RID: 181604
		[Token(Token = "0x402C564")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C565 RID: 181605
		[Token(Token = "0x402C565")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
