using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F2 RID: 22770
	[Token(Token = "0x20058F2")]
	public abstract class CrossAppShareRemakeBaseLayoutElement : CrossAppShareRemakeModelApplier
	{
		// Token: 0x17004DEE RID: 19950
		// (get) Token: 0x06021325 RID: 135973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004DEE")]
		public string elementKey
		{
			[Token(Token = "0x6021325")]
			[Address(RVA = "0x1B75FB0", Offset = "0x1B74BB0", VA = "0x181B75FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021326 RID: 135974
		[Token(Token = "0x6021326")]
		public abstract override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset);

		// Token: 0x06021327 RID: 135975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021327")]
		[Address(RVA = "0x1B75F10", Offset = "0x1B74B10", VA = "0x181B75F10")]
		protected CrossAppShareRemakeBaseLayoutElement()
		{
		}

		// Token: 0x0402D381 RID: 185217
		[Token(Token = "0x402D381")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _elementKey;

		// Token: 0x0402D382 RID: 185218
		[Token(Token = "0x402D382")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_elementKey;

		// Token: 0x0402D383 RID: 185219
		[Token(Token = "0x402D383")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
