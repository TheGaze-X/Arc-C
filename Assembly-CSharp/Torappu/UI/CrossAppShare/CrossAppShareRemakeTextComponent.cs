using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058FF RID: 22783
	[Token(Token = "0x20058FF")]
	public class CrossAppShareRemakeTextComponent : CrossAppShareRemakeBaseComponent<CrossAppShareTextModel>, IHotfixable
	{
		// Token: 0x06021349 RID: 136009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021349")]
		[Address(RVA = "0x1B78B00", Offset = "0x1B77700", VA = "0x181B78B00", Slot = "5")]
		protected override void ApplyTypedModel(CrossAppShareTextModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602134A RID: 136010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602134A")]
		[Address(RVA = "0x1B78C50", Offset = "0x1B77850", VA = "0x181B78C50")]
		public CrossAppShareRemakeTextComponent()
		{
		}

		// Token: 0x0402D3AE RID: 185262
		[Token(Token = "0x402D3AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _text;

		// Token: 0x0402D3AF RID: 185263
		[Token(Token = "0x402D3AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyTypedModel;

		// Token: 0x0402D3B0 RID: 185264
		[Token(Token = "0x402D3B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
