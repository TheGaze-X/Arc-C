using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057B8 RID: 22456
	[Token(Token = "0x20057B8")]
	public class RL01ScrollReportEndingFrameViewModelPlugin : RoguelikeScrollReportEndingFrameViewModelPlugin
	{
		// Token: 0x06020D70 RID: 134512 RVA: 0x000B7870 File Offset: 0x000B5A70
		[Token(Token = "0x6020D70")]
		[Address(RVA = "0x1B1C720", Offset = "0x1B1B320", VA = "0x181B1C720", Slot = "4")]
		public override bool CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x06020D71 RID: 134513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D71")]
		[Address(RVA = "0x1B1CD20", Offset = "0x1B1B920", VA = "0x181B1CD20", Slot = "5")]
		public override string GetSummaryActor()
		{
			return null;
		}

		// Token: 0x06020D72 RID: 134514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D72")]
		[Address(RVA = "0x1B1CCA0", Offset = "0x1B1B8A0", VA = "0x181B1CCA0", Slot = "7")]
		public override IRoguelikeScrollEndingText GetEndingText()
		{
			return null;
		}

		// Token: 0x06020D73 RID: 134515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D73")]
		[Address(RVA = "0x1B1C900", Offset = "0x1B1B500", VA = "0x181B1C900", Slot = "8")]
		public override List<string> ExportZoneAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Zone zoneInfo)
		{
			return null;
		}

		// Token: 0x06020D74 RID: 134516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D74")]
		[Address(RVA = "0x1B1C7A0", Offset = "0x1B1B3A0", VA = "0x181B1C7A0", Slot = "14")]
		public override List<string> ExportNodeBattleAdditionInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020D75 RID: 134517 RVA: 0x000B7888 File Offset: 0x000B5A88
		[Token(Token = "0x6020D75")]
		[Address(RVA = "0x1B1CDB0", Offset = "0x1B1B9B0", VA = "0x181B1CDB0", Slot = "28")]
		protected override bool _CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return default(bool);
		}

		// Token: 0x06020D76 RID: 134518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D76")]
		[Address(RVA = "0x1B1CE20", Offset = "0x1B1BA20", VA = "0x181B1CE20")]
		public RL01ScrollReportEndingFrameViewModelPlugin()
		{
		}

		// Token: 0x06020D77 RID: 134519 RVA: 0x000B78A0 File Offset: 0x000B5AA0
		[Token(Token = "0x6020D77")]
		[Address(RVA = "0x1A5ABE0", Offset = "0x1A597E0", VA = "0x181A5ABE0")]
		private bool <>xLuaBaseProxy_CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x06020D78 RID: 134520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D78")]
		[Address(RVA = "0x1A5AC80", Offset = "0x1A59880", VA = "0x181A5AC80")]
		private string <>xLuaBaseProxy_GetSummaryActor()
		{
			return null;
		}

		// Token: 0x06020D79 RID: 134521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D79")]
		[Address(RVA = "0x1A5AC70", Offset = "0x1A59870", VA = "0x181A5AC70")]
		private IRoguelikeScrollEndingText <>xLuaBaseProxy_GetEndingText()
		{
			return null;
		}

		// Token: 0x06020D7A RID: 134522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D7A")]
		[Address(RVA = "0x1A5AC60", Offset = "0x1A59860", VA = "0x181A5AC60")]
		private List<string> <>xLuaBaseProxy_ExportZoneAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Zone P1)
		{
			return null;
		}

		// Token: 0x06020D7B RID: 134523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D7B")]
		[Address(RVA = "0x1A5ABF0", Offset = "0x1A597F0", VA = "0x181A5ABF0")]
		private List<string> <>xLuaBaseProxy_ExportNodeBattleAdditionInfo(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return null;
		}

		// Token: 0x06020D7C RID: 134524 RVA: 0x000B78B8 File Offset: 0x000B5AB8
		[Token(Token = "0x6020D7C")]
		[Address(RVA = "0x1A5AC90", Offset = "0x1A59890", VA = "0x181A5AC90")]
		private bool <>xLuaBaseProxy__CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return default(bool);
		}

		// Token: 0x0402CA03 RID: 182787
		[Token(Token = "0x402CA03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckRogueEndingTextValid;

		// Token: 0x0402CA04 RID: 182788
		[Token(Token = "0x402CA04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSummaryActor;

		// Token: 0x0402CA05 RID: 182789
		[Token(Token = "0x402CA05")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEndingText;

		// Token: 0x0402CA06 RID: 182790
		[Token(Token = "0x402CA06")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ExportZoneAdditionInfo;

		// Token: 0x0402CA07 RID: 182791
		[Token(Token = "0x402CA07")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ExportNodeBattleAdditionInfo;

		// Token: 0x0402CA08 RID: 182792
		[Token(Token = "0x402CA08")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIsSpecialNodeBattle;

		// Token: 0x0402CA09 RID: 182793
		[Token(Token = "0x402CA09")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
