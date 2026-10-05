using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005858 RID: 22616
	[Token(Token = "0x2005858")]
	public class RL03TotemBuffBottomConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602108C RID: 135308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602108C")]
		[Address(RVA = "0x1B606F0", Offset = "0x1B5F2F0", VA = "0x181B606F0")]
		public void Render(RL03TotemBuffBottomViewModel viewModel)
		{
		}

		// Token: 0x0602108D RID: 135309 RVA: 0x000B8428 File Offset: 0x000B6628
		[Token(Token = "0x602108D")]
		[Address(RVA = "0x1B60A10", Offset = "0x1B5F610", VA = "0x181B60A10")]
		private Color _GetConfirmBgColor(bool isResonance, bool isBoss, RL03TotemBuffBottomViewModel viewModel)
		{
			return default(Color);
		}

		// Token: 0x0602108E RID: 135310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602108E")]
		[Address(RVA = "0x1B60B30", Offset = "0x1B5F730", VA = "0x181B60B30")]
		public RL03TotemBuffBottomConfirmView()
		{
		}

		// Token: 0x0402CEF5 RID: 184053
		[Token(Token = "0x402CEF5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelInvalid;

		// Token: 0x0402CEF6 RID: 184054
		[Token(Token = "0x402CEF6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelValid;

		// Token: 0x0402CEF7 RID: 184055
		[Token(Token = "0x402CEF7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtWaitTips;

		// Token: 0x0402CEF8 RID: 184056
		[Token(Token = "0x402CEF8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelBgNormal;

		// Token: 0x0402CEF9 RID: 184057
		[Token(Token = "0x402CEF9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelBgBoss;

		// Token: 0x0402CEFA RID: 184058
		[Token(Token = "0x402CEFA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Graphic _graphicConfirmFog;

		// Token: 0x0402CEFB RID: 184059
		[Token(Token = "0x402CEFB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorNoResonance;

		// Token: 0x0402CEFC RID: 184060
		[Token(Token = "0x402CEFC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorRed;

		// Token: 0x0402CEFD RID: 184061
		[Token(Token = "0x402CEFD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorBlue;

		// Token: 0x0402CEFE RID: 184062
		[Token(Token = "0x402CEFE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorGreen;

		// Token: 0x0402CEFF RID: 184063
		[Token(Token = "0x402CEFF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorBoss;

		// Token: 0x0402CF00 RID: 184064
		[Token(Token = "0x402CF00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CF01 RID: 184065
		[Token(Token = "0x402CF01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetConfirmBgColor;

		// Token: 0x0402CF02 RID: 184066
		[Token(Token = "0x402CF02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
