using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AB6 RID: 23222
	[Token(Token = "0x2005AB6")]
	public class ShopDetailProgressGPView : ShopDetailCommonView, IHotfixable
	{
		// Token: 0x06021C41 RID: 138305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C41")]
		[Address(RVA = "0x1C3E1B0", Offset = "0x1C3CDB0", VA = "0x181C3E1B0", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021C42 RID: 138306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C42")]
		[Address(RVA = "0x1C3E5C0", Offset = "0x1C3D1C0", VA = "0x181C3E5C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021C43 RID: 138307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C43")]
		[Address(RVA = "0x1C3E700", Offset = "0x1C3D300", VA = "0x181C3E700")]
		public ShopDetailProgressGPView()
		{
		}

		// Token: 0x06021C44 RID: 138308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C44")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x0402E33E RID: 189246
		[Token(Token = "0x402E33E")]
		private const string CHECK_IN_PROGRESS_FORMAT = "<color=#0098dc>{0}</color>/{1}";

		// Token: 0x0402E33F RID: 189247
		[Token(Token = "0x402E33F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0402E340 RID: 189248
		[Token(Token = "0x402E340")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Remain")]
		private GameObject _panelRemain;

		// Token: 0x0402E341 RID: 189249
		[Token(Token = "0x402E341")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Remain")]
		private Text _textRemainCount;

		// Token: 0x0402E342 RID: 189250
		[Token(Token = "0x402E342")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private SimpleLayoutContent _contentReward;

		// Token: 0x0402E343 RID: 189251
		[Token(Token = "0x402E343")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402E344 RID: 189252
		[Token(Token = "0x402E344")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Image _spriteImage;

		// Token: 0x0402E345 RID: 189253
		[Token(Token = "0x402E345")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInited;

		// Token: 0x0402E346 RID: 189254
		[Token(Token = "0x402E346")]
		[FieldOffset(Offset = "0xE0")]
		private List<DetailProgressGPViewModel.CheckInRewardModel> m_cachedModelList;

		// Token: 0x0402E347 RID: 189255
		[Token(Token = "0x402E347")]
		[FieldOffset(Offset = "0xE8")]
		private ShopDetailProgressGPView.Adapter m_adapter;

		// Token: 0x0402E348 RID: 189256
		[Token(Token = "0x402E348")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E349 RID: 189257
		[Token(Token = "0x402E349")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E34A RID: 189258
		[Token(Token = "0x402E34A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005AB7 RID: 23223
		[Token(Token = "0x2005AB7")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06021C45 RID: 138309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021C45")]
			[Address(RVA = "0x1C2F990", Offset = "0x1C2E590", VA = "0x181C2F990")]
			public Adapter(ShopDetailProgressGPView closure)
			{
			}

			// Token: 0x17004F16 RID: 20246
			// (get) Token: 0x06021C46 RID: 138310 RVA: 0x000BB3B0 File Offset: 0x000B95B0
			[Token(Token = "0x17004F16")]
			public override int count
			{
				[Token(Token = "0x6021C46")]
				[Address(RVA = "0x1C2FA90", Offset = "0x1C2E690", VA = "0x181C2FA90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021C47 RID: 138311 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C47")]
			[Address(RVA = "0x1C2F7E0", Offset = "0x1C2E3E0", VA = "0x181C2F7E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402E34B RID: 189259
			[Token(Token = "0x402E34B")]
			[FieldOffset(Offset = "0x20")]
			private ShopDetailProgressGPView m_closure;

			// Token: 0x0402E34C RID: 189260
			[Token(Token = "0x402E34C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E34D RID: 189261
			[Token(Token = "0x402E34D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E34E RID: 189262
			[Token(Token = "0x402E34E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
