using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042EB RID: 17131
	[Token(Token = "0x20042EB")]
	public class SandboxV2DungeonRiftFloatViewModel : SandboxV2DungeonFloatViewModel
	{
		// Token: 0x0601A561 RID: 107873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A561")]
		[Address(RVA = "0x133B700", Offset = "0x133A300", VA = "0x18133B700")]
		public void UpdateData(SandboxV2DungeonRiftFloatViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A562 RID: 107874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A562")]
		[Address(RVA = "0x133BA40", Offset = "0x133A640", VA = "0x18133BA40")]
		public SandboxV2DungeonRiftFloatViewModel()
		{
		}

		// Token: 0x04021671 RID: 136817
		[Token(Token = "0x4021671")]
		private const string RIFT_FLOAT_UNIQUE_ID = "rift_float";

		// Token: 0x04021672 RID: 136818
		[Token(Token = "0x4021672")]
		[FieldOffset(Offset = "0x60")]
		public float hpRatio;

		// Token: 0x04021673 RID: 136819
		[Token(Token = "0x4021673")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04021674 RID: 136820
		[Token(Token = "0x4021674")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042EC RID: 17132
		[Token(Token = "0x20042EC")]
		public struct UpdateParam
		{
			// Token: 0x04021675 RID: 136821
			[Token(Token = "0x4021675")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04021676 RID: 136822
			[Token(Token = "0x4021676")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2DungeonNodeViewModel nodeViewModel;

			// Token: 0x04021677 RID: 136823
			[Token(Token = "0x4021677")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2Data topicDetailData;

			// Token: 0x04021678 RID: 136824
			[Token(Token = "0x4021678")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.RiftInfo.GameInfo.RiftFloat playerRiftFloatData;
		}
	}
}
