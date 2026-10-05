using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F6 RID: 22774
	[Token(Token = "0x20058F6")]
	public class CrossAppShareRemakeCharSpineComponent : CrossAppShareRemakeBaseComponent<CrossAppShareCharSpineModel>, IHotfixable
	{
		// Token: 0x06021337 RID: 135991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021337")]
		[Address(RVA = "0x1B76010", Offset = "0x1B74C10", VA = "0x181B76010", Slot = "5")]
		protected override void ApplyTypedModel(CrossAppShareCharSpineModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06021338 RID: 135992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021338")]
		[Address(RVA = "0x1B76220", Offset = "0x1B74E20", VA = "0x181B76220")]
		public CrossAppShareRemakeCharSpineComponent()
		{
		}

		// Token: 0x0402D391 RID: 185233
		[Token(Token = "0x402D391")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISpineHolder _spineHolder;

		// Token: 0x0402D392 RID: 185234
		[Token(Token = "0x402D392")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyTypedModel;

		// Token: 0x0402D393 RID: 185235
		[Token(Token = "0x402D393")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
