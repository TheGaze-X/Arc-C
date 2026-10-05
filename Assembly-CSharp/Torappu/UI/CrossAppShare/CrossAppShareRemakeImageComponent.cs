using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058FA RID: 22778
	[Token(Token = "0x20058FA")]
	public class CrossAppShareRemakeImageComponent : CrossAppShareRemakeBaseComponent<CrossAppShareImageModel>, IHotfixable
	{
		// Token: 0x0602133F RID: 135999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602133F")]
		[Address(RVA = "0x1B776D0", Offset = "0x1B762D0", VA = "0x181B776D0", Slot = "5")]
		protected override void ApplyTypedModel(CrossAppShareImageModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06021340 RID: 136000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021340")]
		[Address(RVA = "0x1B77880", Offset = "0x1B76480", VA = "0x181B77880")]
		public CrossAppShareRemakeImageComponent()
		{
		}

		// Token: 0x0402D39D RID: 185245
		[Token(Token = "0x402D39D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _image;

		// Token: 0x0402D39E RID: 185246
		[Token(Token = "0x402D39E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyTypedModel;

		// Token: 0x0402D39F RID: 185247
		[Token(Token = "0x402D39F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
