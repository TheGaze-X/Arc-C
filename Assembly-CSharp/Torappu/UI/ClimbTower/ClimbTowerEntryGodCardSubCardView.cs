using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C4D RID: 23629
	[Token(Token = "0x2005C4D")]
	public class ClimbTowerEntryGodCardSubCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700505D RID: 20573
		// (get) Token: 0x060223E4 RID: 140260 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223E5 RID: 140261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700505D")]
		public UIPage page
		{
			[Token(Token = "0x60223E4")]
			[Address(RVA = "0x1CA75F0", Offset = "0x1CA61F0", VA = "0x181CA75F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223E5")]
			[Address(RVA = "0x1CA7650", Offset = "0x1CA6250", VA = "0x181CA7650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223E6 RID: 140262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223E6")]
		[Address(RVA = "0x1CA7370", Offset = "0x1CA5F70", VA = "0x181CA7370")]
		public void Render(ClimbTowerEntrySubCardModel cardModel)
		{
		}

		// Token: 0x060223E7 RID: 140263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223E7")]
		[Address(RVA = "0x1CA7590", Offset = "0x1CA6190", VA = "0x181CA7590")]
		public ClimbTowerEntryGodCardSubCardView()
		{
		}

		// Token: 0x0402EFEF RID: 192495
		[Token(Token = "0x402EFEF")]
		private const float ALPHA_USED = 1f;

		// Token: 0x0402EFF0 RID: 192496
		[Token(Token = "0x402EFF0")]
		private const float ALPHA_UNUSED = 0.2f;

		// Token: 0x0402EFF1 RID: 192497
		[Token(Token = "0x402EFF1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroupComplete;

		// Token: 0x0402EFF2 RID: 192498
		[Token(Token = "0x402EFF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCardName;

		// Token: 0x0402EFF3 RID: 192499
		[Token(Token = "0x402EFF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402EFF4 RID: 192500
		[Token(Token = "0x402EFF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402EFF6 RID: 192502
		[Token(Token = "0x402EFF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402EFF7 RID: 192503
		[Token(Token = "0x402EFF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402EFF8 RID: 192504
		[Token(Token = "0x402EFF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EFF9 RID: 192505
		[Token(Token = "0x402EFF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
