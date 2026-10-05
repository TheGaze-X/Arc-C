using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005197 RID: 20887
	[Token(Token = "0x2005197")]
	public class UIRoguelikeExpedReturnDialog : UIRoguelikeExpeditionReturnDialogBase
	{
		// Token: 0x0601EDBE RID: 126398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDBE")]
		[Address(RVA = "0x18AC700", Offset = "0x18AB300", VA = "0x1818AC700", Slot = "14")]
		protected override void RenderSingle(ExpeditionReturnDialogSingleData singleModel, bool isLast)
		{
		}

		// Token: 0x0601EDBF RID: 126399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDBF")]
		[Address(RVA = "0x18ACA00", Offset = "0x18AB600", VA = "0x1818ACA00")]
		public UIRoguelikeExpedReturnDialog()
		{
		}

		// Token: 0x0402965D RID: 169565
		[Token(Token = "0x402965D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _charText;

		// Token: 0x0402965E RID: 169566
		[Token(Token = "0x402965E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0402965F RID: 169567
		[Token(Token = "0x402965F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _pnlClose;

		// Token: 0x04029660 RID: 169568
		[Token(Token = "0x4029660")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _pnlNext;

		// Token: 0x04029661 RID: 169569
		[Token(Token = "0x4029661")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _imgExped;

		// Token: 0x04029662 RID: 169570
		[Token(Token = "0x4029662")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _imgTravel;

		// Token: 0x04029663 RID: 169571
		[Token(Token = "0x4029663")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04029664 RID: 169572
		[Token(Token = "0x4029664")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSingle;

		// Token: 0x04029665 RID: 169573
		[Token(Token = "0x4029665")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
