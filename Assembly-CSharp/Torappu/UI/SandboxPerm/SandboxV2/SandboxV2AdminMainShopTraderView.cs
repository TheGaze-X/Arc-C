using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040E5 RID: 16613
	[Token(Token = "0x20040E5")]
	public class SandboxV2AdminMainShopTraderView : DataBinder<SandboxV2AdminMainShopProperty>, IHotfixable
	{
		// Token: 0x06019B2C RID: 105260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B2C")]
		[Address(RVA = "0x1285860", Offset = "0x1284460", VA = "0x181285860", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainShopProperty property)
		{
		}

		// Token: 0x06019B2D RID: 105261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B2D")]
		[Address(RVA = "0x1285A90", Offset = "0x1284690", VA = "0x181285A90")]
		private void _PlayTextTween(string dialog)
		{
		}

		// Token: 0x06019B2E RID: 105262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B2E")]
		[Address(RVA = "0x1285C10", Offset = "0x1284810", VA = "0x181285C10")]
		public SandboxV2AdminMainShopTraderView()
		{
		}

		// Token: 0x0402024A RID: 131658
		[Token(Token = "0x402024A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402024B RID: 131659
		[Token(Token = "0x402024B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402024C RID: 131660
		[Token(Token = "0x402024C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _textTweenDuration;

		// Token: 0x0402024D RID: 131661
		[Token(Token = "0x402024D")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_textTweener;

		// Token: 0x0402024E RID: 131662
		[Token(Token = "0x402024E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402024F RID: 131663
		[Token(Token = "0x402024F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayTextTween;

		// Token: 0x04020250 RID: 131664
		[Token(Token = "0x4020250")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
