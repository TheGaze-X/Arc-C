using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042DA RID: 17114
	[Token(Token = "0x20042DA")]
	public struct SandboxV2DungeonProgressViewModel : IHotfixable
	{
		// Token: 0x040215EE RID: 136686
		[Token(Token = "0x40215EE")]
		[FieldOffset(Offset = "0x0")]
		public SandboxV2ProgressAppearanceType appearanceType;

		// Token: 0x040215EF RID: 136687
		[Token(Token = "0x40215EF")]
		[FieldOffset(Offset = "0x4")]
		public bool valid;

		// Token: 0x040215F0 RID: 136688
		[Token(Token = "0x40215F0")]
		[FieldOffset(Offset = "0x8")]
		public float currProgress;
	}
}
