using System;
using Il2CppDummyDll;
using Torappu.Building.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019D3 RID: 6611
	[Token(Token = "0x20019D3")]
	public class DIYPresetDataSaveStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600A60E RID: 42510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A60E")]
		[Address(RVA = "0x31F29C0", Offset = "0x31F15C0", VA = "0x1831F29C0")]
		public DIYPresetDataSaveStateBean()
		{
		}

		// Token: 0x04009DEE RID: 40430
		[Token(Token = "0x4009DEE")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D presetPreviewTex;

		// Token: 0x04009DEF RID: 40431
		[Token(Token = "0x4009DEF")]
		[FieldOffset(Offset = "0x18")]
		public int presetIndex;

		// Token: 0x04009DF0 RID: 40432
		[Token(Token = "0x4009DF0")]
		[FieldOffset(Offset = "0x20")]
		public IDIYPreset preset;

		// Token: 0x04009DF1 RID: 40433
		[Token(Token = "0x4009DF1")]
		[FieldOffset(Offset = "0x28")]
		public DIYPage.UIHandler pageHandler;

		// Token: 0x04009DF2 RID: 40434
		[Token(Token = "0x4009DF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
