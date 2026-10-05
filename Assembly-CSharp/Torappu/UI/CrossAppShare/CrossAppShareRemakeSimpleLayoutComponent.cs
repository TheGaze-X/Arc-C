using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058FE RID: 22782
	[Token(Token = "0x20058FE")]
	public class CrossAppShareRemakeSimpleLayoutComponent : CrossAppShareRemakeBaseComponent<CrossAppShareSimpleLayoutContentModel>
	{
		// Token: 0x06021347 RID: 136007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021347")]
		[Address(RVA = "0x1B78930", Offset = "0x1B77530", VA = "0x181B78930", Slot = "5")]
		protected override void ApplyTypedModel(CrossAppShareSimpleLayoutContentModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06021348 RID: 136008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021348")]
		[Address(RVA = "0x1B78A90", Offset = "0x1B77690", VA = "0x181B78A90")]
		public CrossAppShareRemakeSimpleLayoutComponent()
		{
		}

		// Token: 0x0402D3AA RID: 185258
		[Token(Token = "0x402D3AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _layoutContainer;

		// Token: 0x0402D3AB RID: 185259
		[Token(Token = "0x402D3AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrossAppShareRemakeComponentGroup _group;

		// Token: 0x0402D3AC RID: 185260
		[Token(Token = "0x402D3AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyTypedModel;

		// Token: 0x0402D3AD RID: 185261
		[Token(Token = "0x402D3AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
