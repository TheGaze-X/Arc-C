using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C45 RID: 23621
	[Token(Token = "0x2005C45")]
	public class ClimbTowerEntryFloatSeasonProgressView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060223BD RID: 140221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223BD")]
		[Address(RVA = "0x1CA4DE0", Offset = "0x1CA39E0", VA = "0x181CA4DE0")]
		public void Render(ClimbTowerEntryFloatPanelViewModel viewModel)
		{
		}

		// Token: 0x060223BE RID: 140222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223BE")]
		[Address(RVA = "0x1CA4FA0", Offset = "0x1CA3BA0", VA = "0x181CA4FA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060223BF RID: 140223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223BF")]
		[Address(RVA = "0x1CA50C0", Offset = "0x1CA3CC0", VA = "0x181CA50C0")]
		public ClimbTowerEntryFloatSeasonProgressView()
		{
		}

		// Token: 0x0402EF93 RID: 192403
		[Token(Token = "0x402EF93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402EF94 RID: 192404
		[Token(Token = "0x402EF94")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasInited;

		// Token: 0x0402EF95 RID: 192405
		[Token(Token = "0x402EF95")]
		[FieldOffset(Offset = "0x24")]
		private int m_periodSum;

		// Token: 0x0402EF96 RID: 192406
		[Token(Token = "0x402EF96")]
		[FieldOffset(Offset = "0x28")]
		private int m_periodCurr;

		// Token: 0x0402EF97 RID: 192407
		[Token(Token = "0x402EF97")]
		[FieldOffset(Offset = "0x30")]
		private ClimbTowerEntryFloatSeasonProgressView.Adapter m_adapter;

		// Token: 0x0402EF98 RID: 192408
		[Token(Token = "0x402EF98")]
		[FieldOffset(Offset = "0x38")]
		private string m_seasonId;

		// Token: 0x0402EF99 RID: 192409
		[Token(Token = "0x402EF99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EF9A RID: 192410
		[Token(Token = "0x402EF9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EF9B RID: 192411
		[Token(Token = "0x402EF9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C46 RID: 23622
		[Token(Token = "0x2005C46")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060223C0 RID: 140224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223C0")]
			[Address(RVA = "0x1CA0CB0", Offset = "0x1C9F8B0", VA = "0x181CA0CB0")]
			public Adapter(ClimbTowerEntryFloatSeasonProgressView closure)
			{
			}

			// Token: 0x17005053 RID: 20563
			// (get) Token: 0x060223C1 RID: 140225 RVA: 0x000BCCB8 File Offset: 0x000BAEB8
			[Token(Token = "0x17005053")]
			public override int count
			{
				[Token(Token = "0x60223C1")]
				[Address(RVA = "0x1CA10B0", Offset = "0x1C9FCB0", VA = "0x181CA10B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060223C2 RID: 140226 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60223C2")]
			[Address(RVA = "0x1CA06F0", Offset = "0x1C9F2F0", VA = "0x181CA06F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402EF9C RID: 192412
			[Token(Token = "0x402EF9C")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryFloatSeasonProgressView m_closure;

			// Token: 0x0402EF9D RID: 192413
			[Token(Token = "0x402EF9D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EF9E RID: 192414
			[Token(Token = "0x402EF9E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EF9F RID: 192415
			[Token(Token = "0x402EF9F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
