using System;
using Il2CppDummyDll;
using Torappu.Battle.Racing;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023EC RID: 9196
	[Token(Token = "0x20023EC")]
	public class RacingSchedulerPreprocessor : RandomGroupSchedulerPreprocessor
	{
		// Token: 0x0600EADB RID: 60123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADB")]
		[Address(RVA = "0x60CEF0", Offset = "0x60BAF0", VA = "0x18060CEF0")]
		public RacingSchedulerPreprocessor(RacingInput input)
		{
		}

		// Token: 0x0600EADC RID: 60124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADC")]
		[Address(RVA = "0x60CAE0", Offset = "0x60B6E0", VA = "0x18060CAE0", Slot = "5")]
		public override void DoPreprocess(LevelData levelData)
		{
		}

		// Token: 0x0600EADD RID: 60125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADD")]
		[Address(RVA = "0x60CA70", Offset = "0x60B670", VA = "0x18060CA70", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x0600EADE RID: 60126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADE")]
		[Address(RVA = "0x60CEE0", Offset = "0x60BAE0", VA = "0x18060CEE0")]
		private void <>xLuaBaseProxy_DoPreprocess(LevelData P0)
		{
		}

		// Token: 0x0600EADF RID: 60127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADF")]
		[Address(RVA = "0x60CED0", Offset = "0x60BAD0", VA = "0x18060CED0")]
		private void <>xLuaBaseProxy_Dispose()
		{
		}

		// Token: 0x0401035A RID: 66394
		[Token(Token = "0x401035A")]
		private const string RACING_WAVE_NAME = "racing_data_wave";

		// Token: 0x0401035B RID: 66395
		[Token(Token = "0x401035B")]
		[FieldOffset(Offset = "0x38")]
		private RacingInput m_racingInput;

		// Token: 0x0401035C RID: 66396
		[Token(Token = "0x401035C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401035D RID: 66397
		[Token(Token = "0x401035D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x0401035E RID: 66398
		[Token(Token = "0x401035E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
