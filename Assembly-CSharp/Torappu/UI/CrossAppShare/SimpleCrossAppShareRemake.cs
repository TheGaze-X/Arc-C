using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x02005900 RID: 22784
	[Token(Token = "0x2005900")]
	public class SimpleCrossAppShareRemake : CrossAppShareRemakeModelApplier
	{
		// Token: 0x0602134B RID: 136011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602134B")]
		[Address(RVA = "0x1B833B0", Offset = "0x1B81FB0", VA = "0x181B833B0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602134C RID: 136012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602134C")]
		[Address(RVA = "0x1B836F0", Offset = "0x1B822F0", VA = "0x181B836F0")]
		public SimpleCrossAppShareRemake()
		{
		}

		// Token: 0x0402D3B1 RID: 185265
		[Token(Token = "0x402D3B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrossAppShareRemakeComponentGroup _componentGroup;

		// Token: 0x0402D3B2 RID: 185266
		[Token(Token = "0x402D3B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0402D3B3 RID: 185267
		[Token(Token = "0x402D3B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
