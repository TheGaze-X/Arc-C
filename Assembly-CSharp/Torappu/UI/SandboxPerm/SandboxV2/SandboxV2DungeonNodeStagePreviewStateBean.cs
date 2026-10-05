using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041F5 RID: 16885
	[Token(Token = "0x20041F5")]
	public class SandboxV2DungeonNodeStagePreviewStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601A0FE RID: 106750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0FE")]
		[Address(RVA = "0x12EC340", Offset = "0x12EAF40", VA = "0x1812EC340")]
		public SandboxV2DungeonNodeStagePreviewStateBean()
		{
		}

		// Token: 0x04020D3D RID: 134461
		[Token(Token = "0x4020D3D")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04020D3E RID: 134462
		[Token(Token = "0x4020D3E")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04020D3F RID: 134463
		[Token(Token = "0x4020D3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
