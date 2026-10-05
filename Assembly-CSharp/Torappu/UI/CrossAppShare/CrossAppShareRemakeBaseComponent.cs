using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F4 RID: 22772
	[Token(Token = "0x20058F4")]
	public abstract class CrossAppShareRemakeBaseComponent<TModel> : CrossAppShareRemakeBaseComponent where TModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x06021331 RID: 135985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021331")]
		public sealed override void ApplyComponentModel(CrossAppShareComponentBaseModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06021332 RID: 135986
		[Token(Token = "0x6021332")]
		protected abstract void ApplyTypedModel(TModel model, ILoadAsset iLoadAsset);

		// Token: 0x06021333 RID: 135987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021333")]
		protected CrossAppShareRemakeBaseComponent()
		{
		}

		// Token: 0x0402D38C RID: 185228
		[Token(Token = "0x402D38C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModel;

		// Token: 0x0402D38D RID: 185229
		[Token(Token = "0x402D38D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
