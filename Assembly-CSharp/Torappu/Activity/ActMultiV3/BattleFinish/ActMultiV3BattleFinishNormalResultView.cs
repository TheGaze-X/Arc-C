using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200708F RID: 28815
	[Token(Token = "0x200708F")]
	public class ActMultiV3BattleFinishNormalResultView : ActMultiV3BattleFinishResultViewBase
	{
		// Token: 0x170060DD RID: 24797
		// (get) Token: 0x06028EF5 RID: 167669 RVA: 0x000D3A28 File Offset: 0x000D1C28
		[Token(Token = "0x170060DD")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028EF5")]
			[Address(RVA = "0x244D7E0", Offset = "0x244C3E0", VA = "0x18244D7E0", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028EF6 RID: 167670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EF6")]
		[Address(RVA = "0x244D6E0", Offset = "0x244C2E0", VA = "0x18244D6E0", Slot = "5")]
		protected override void OnRender()
		{
		}

		// Token: 0x06028EF7 RID: 167671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EF7")]
		[Address(RVA = "0x244D740", Offset = "0x244C340", VA = "0x18244D740")]
		public ActMultiV3BattleFinishNormalResultView()
		{
		}

		// Token: 0x0403A69C RID: 239260
		[Token(Token = "0x403A69C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A69D RID: 239261
		[Token(Token = "0x403A69D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403A69E RID: 239262
		[Token(Token = "0x403A69E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
