using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F9 RID: 22777
	[Token(Token = "0x20058F9")]
	public class CrossAppShareRemakeDynImageComponent : CrossAppShareRemakeBaseComponent<CrossAppShareDynImageModel>, IHotfixable
	{
		// Token: 0x0602133D RID: 135997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602133D")]
		[Address(RVA = "0x1B77560", Offset = "0x1B76160", VA = "0x181B77560", Slot = "5")]
		protected override void ApplyTypedModel(CrossAppShareDynImageModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602133E RID: 135998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602133E")]
		[Address(RVA = "0x1B77660", Offset = "0x1B76260", VA = "0x181B77660")]
		public CrossAppShareRemakeDynImageComponent()
		{
		}

		// Token: 0x0402D39A RID: 185242
		[Token(Token = "0x402D39A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIDynImage _image;

		// Token: 0x0402D39B RID: 185243
		[Token(Token = "0x402D39B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyTypedModel;

		// Token: 0x0402D39C RID: 185244
		[Token(Token = "0x402D39C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
