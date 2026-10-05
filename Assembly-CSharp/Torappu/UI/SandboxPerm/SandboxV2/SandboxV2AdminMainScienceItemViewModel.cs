using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040C5 RID: 16581
	[Token(Token = "0x20040C5")]
	public class SandboxV2AdminMainScienceItemViewModel : IHotfixable
	{
		// Token: 0x06019A5F RID: 105055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A5F")]
		[Address(RVA = "0x1277FE0", Offset = "0x1276BE0", VA = "0x181277FE0")]
		public SandboxV2AdminMainScienceItemViewModel()
		{
		}

		// Token: 0x040200D4 RID: 131284
		[Token(Token = "0x40200D4")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040200D5 RID: 131285
		[Token(Token = "0x40200D5")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2DevelopmentData buffData;

		// Token: 0x040200D6 RID: 131286
		[Token(Token = "0x40200D6")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 position;

		// Token: 0x040200D7 RID: 131287
		[Token(Token = "0x40200D7")]
		[FieldOffset(Offset = "0x28")]
		public SANDBOX_DEVELOP_NODE_LIGHT_STATE nodeLightState;

		// Token: 0x040200D8 RID: 131288
		[Token(Token = "0x40200D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
