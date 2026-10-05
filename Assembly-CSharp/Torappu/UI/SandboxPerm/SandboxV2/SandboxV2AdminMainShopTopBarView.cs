using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040E4 RID: 16612
	[Token(Token = "0x20040E4")]
	public class SandboxV2AdminMainShopTopBarView : DataBinder<SandboxV2AdminMainShopProperty>, IHotfixable
	{
		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x06019B28 RID: 105256 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019B29 RID: 105257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D4F")]
		public UIPage page
		{
			[Token(Token = "0x6019B28")]
			[Address(RVA = "0x1285780", Offset = "0x1284380", VA = "0x181285780")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019B29")]
			[Address(RVA = "0x12857E0", Offset = "0x12843E0", VA = "0x1812857E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019B2A RID: 105258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B2A")]
		[Address(RVA = "0x1285390", Offset = "0x1283F90", VA = "0x181285390", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainShopProperty property)
		{
		}

		// Token: 0x06019B2B RID: 105259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B2B")]
		[Address(RVA = "0x1285710", Offset = "0x1284310", VA = "0x181285710")]
		public SandboxV2AdminMainShopTopBarView()
		{
		}

		// Token: 0x0402023E RID: 131646
		[Token(Token = "0x402023E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelGold;

		// Token: 0x0402023F RID: 131647
		[Token(Token = "0x402023F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgGold;

		// Token: 0x04020240 RID: 131648
		[Token(Token = "0x4020240")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textGold;

		// Token: 0x04020241 RID: 131649
		[Token(Token = "0x4020241")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelDimensionCoin;

		// Token: 0x04020242 RID: 131650
		[Token(Token = "0x4020242")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgDimensionCoin;

		// Token: 0x04020243 RID: 131651
		[Token(Token = "0x4020243")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDimensionCoin;

		// Token: 0x04020244 RID: 131652
		[Token(Token = "0x4020244")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textRefreshRemain;

		// Token: 0x04020246 RID: 131654
		[Token(Token = "0x4020246")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04020247 RID: 131655
		[Token(Token = "0x4020247")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04020248 RID: 131656
		[Token(Token = "0x4020248")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020249 RID: 131657
		[Token(Token = "0x4020249")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
