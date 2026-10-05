using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AB2 RID: 23218
	[Token(Token = "0x2005AB2")]
	public class ShopDetailProgressGPItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021C38 RID: 138296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C38")]
		[Address(RVA = "0x1C3DB80", Offset = "0x1C3C780", VA = "0x181C3DB80")]
		public void Render(DetailProgressGPViewModel.CheckInRewardModel viewModel)
		{
		}

		// Token: 0x06021C39 RID: 138297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C39")]
		[Address(RVA = "0x1C3DDE0", Offset = "0x1C3C9E0", VA = "0x181C3DDE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021C3A RID: 138298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C3A")]
		[Address(RVA = "0x1C3DF00", Offset = "0x1C3CB00", VA = "0x181C3DF00")]
		public ShopDetailProgressGPItemView()
		{
		}

		// Token: 0x0402E32D RID: 189229
		[Token(Token = "0x402E32D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCheckInProgress;

		// Token: 0x0402E32E RID: 189230
		[Token(Token = "0x402E32E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _contentRewards;

		// Token: 0x0402E32F RID: 189231
		[Token(Token = "0x402E32F")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0402E330 RID: 189232
		[Token(Token = "0x402E330")]
		[FieldOffset(Offset = "0x30")]
		private List<ItemBundle> m_cachedRewards;

		// Token: 0x0402E331 RID: 189233
		[Token(Token = "0x402E331")]
		[FieldOffset(Offset = "0x38")]
		private ShopDetailProgressGPItemView.Adapter m_adapter;

		// Token: 0x0402E332 RID: 189234
		[Token(Token = "0x402E332")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E333 RID: 189235
		[Token(Token = "0x402E333")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E334 RID: 189236
		[Token(Token = "0x402E334")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005AB3 RID: 23219
		[Token(Token = "0x2005AB3")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06021C3B RID: 138299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021C3B")]
			[Address(RVA = "0x1C2FA10", Offset = "0x1C2E610", VA = "0x181C2FA10")]
			public Adapter(ShopDetailProgressGPItemView closure)
			{
			}

			// Token: 0x17004F15 RID: 20245
			// (get) Token: 0x06021C3C RID: 138300 RVA: 0x000BB398 File Offset: 0x000B9598
			[Token(Token = "0x17004F15")]
			public override int count
			{
				[Token(Token = "0x6021C3C")]
				[Address(RVA = "0x1C2FB10", Offset = "0x1C2E710", VA = "0x181C2FB10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021C3D RID: 138301 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021C3D")]
			[Address(RVA = "0x1C2F4E0", Offset = "0x1C2E0E0", VA = "0x181C2F4E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402E335 RID: 189237
			[Token(Token = "0x402E335")]
			[FieldOffset(Offset = "0x20")]
			private ShopDetailProgressGPItemView m_closure;

			// Token: 0x0402E336 RID: 189238
			[Token(Token = "0x402E336")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E337 RID: 189239
			[Token(Token = "0x402E337")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E338 RID: 189240
			[Token(Token = "0x402E338")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
