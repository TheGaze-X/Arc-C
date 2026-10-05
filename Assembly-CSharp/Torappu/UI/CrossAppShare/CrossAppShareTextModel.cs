using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058CA RID: 22730
	[Token(Token = "0x20058CA")]
	public class CrossAppShareTextModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x06021294 RID: 135828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021294")]
		[Address(RVA = "0x1B79630", Offset = "0x1B78230", VA = "0x181B79630")]
		public void InitModel(Text iText)
		{
		}

		// Token: 0x06021295 RID: 135829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021295")]
		[Address(RVA = "0x1B79780", Offset = "0x1B78380", VA = "0x181B79780")]
		public CrossAppShareTextModel()
		{
		}

		// Token: 0x0402D2A8 RID: 185000
		[Token(Token = "0x402D2A8")]
		[FieldOffset(Offset = "0x18")]
		public string text;

		// Token: 0x0402D2A9 RID: 185001
		[Token(Token = "0x402D2A9")]
		[FieldOffset(Offset = "0x20")]
		public Color color;

		// Token: 0x0402D2AA RID: 185002
		[Token(Token = "0x402D2AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0402D2AB RID: 185003
		[Token(Token = "0x402D2AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
