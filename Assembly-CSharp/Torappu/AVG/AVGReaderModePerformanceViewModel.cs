using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F39 RID: 7993
	[Token(Token = "0x2001F39")]
	public class AVGReaderModePerformanceViewModel : IHotfixable
	{
		// Token: 0x0600C6C0 RID: 50880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6C0")]
		[Address(RVA = "0x347FE80", Offset = "0x347EA80", VA = "0x18347FE80")]
		public AVGReaderModePerformanceViewModel()
		{
		}

		// Token: 0x0600C6C1 RID: 50881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6C1")]
		[Address(RVA = "0x347F380", Offset = "0x347DF80", VA = "0x18347F380")]
		public void UpdateCommand(Command command)
		{
		}

		// Token: 0x0600C6C2 RID: 50882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6C2")]
		[Address(RVA = "0x347F060", Offset = "0x347DC60", VA = "0x18347F060")]
		public void ClearCommand()
		{
		}

		// Token: 0x0600C6C3 RID: 50883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6C3")]
		[Address(RVA = "0x347F0E0", Offset = "0x347DCE0", VA = "0x18347F0E0")]
		public void Clear()
		{
		}

		// Token: 0x0600C6C4 RID: 50884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C6C4")]
		[Address(RVA = "0x347F290", Offset = "0x347DE90", VA = "0x18347F290")]
		public Command GetCommand(string commandName)
		{
			return null;
		}

		// Token: 0x0600C6C5 RID: 50885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C6C5")]
		[Address(RVA = "0x347F170", Offset = "0x347DD70", VA = "0x18347F170")]
		public Command GetCharViewCommand(string slot)
		{
			return null;
		}

		// Token: 0x0600C6C6 RID: 50886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6C6")]
		[Address(RVA = "0x347F450", Offset = "0x347E050", VA = "0x18347F450")]
		private void _GeneralProcessor(Command command)
		{
		}

		// Token: 0x0600C6C7 RID: 50887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6C7")]
		[Address(RVA = "0x347FA20", Offset = "0x347E620", VA = "0x18347FA20")]
		private void _ProcessCharslot(Command command)
		{
		}

		// Token: 0x0600C6C8 RID: 50888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C6C8")]
		[Address(RVA = "0x347F620", Offset = "0x347E220", VA = "0x18347F620")]
		private string _NormalizeSlotName(string slot)
		{
			return null;
		}

		// Token: 0x0600C6C9 RID: 50889 RVA: 0x00048930 File Offset: 0x00046B30
		[Token(Token = "0x600C6C9")]
		[Address(RVA = "0x347F540", Offset = "0x347E140", VA = "0x18347F540")]
		private bool _IsStandardSlot(string slot)
		{
			return default(bool);
		}

		// Token: 0x0600C6CA RID: 50890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6CA")]
		[Address(RVA = "0x347F740", Offset = "0x347E340", VA = "0x18347F740")]
		private void _ProcessCharacter(Command command)
		{
		}

		// Token: 0x0400CC34 RID: 52276
		[Token(Token = "0x400CC34")]
		private const string SLOT_LEFT = "left";

		// Token: 0x0400CC35 RID: 52277
		[Token(Token = "0x400CC35")]
		private const string SLOT_MIDDLE = "middle";

		// Token: 0x0400CC36 RID: 52278
		[Token(Token = "0x400CC36")]
		private const string SLOT_RIGHT = "right";

		// Token: 0x0400CC37 RID: 52279
		[Token(Token = "0x400CC37")]
		private const string SLOT_ALIAS_LEFT = "l";

		// Token: 0x0400CC38 RID: 52280
		[Token(Token = "0x400CC38")]
		private const string SLOT_ALIAS_MIDDLE = "m";

		// Token: 0x0400CC39 RID: 52281
		[Token(Token = "0x400CC39")]
		private const string SLOT_ALIAS_RIGHT = "r";

		// Token: 0x0400CC3A RID: 52282
		[Token(Token = "0x400CC3A")]
		private const string COMMAND_CHARACTER = "character";

		// Token: 0x0400CC3B RID: 52283
		[Token(Token = "0x400CC3B")]
		private const string COMMAND_CHARSLOT = "charslot";

		// Token: 0x0400CC3C RID: 52284
		[Token(Token = "0x400CC3C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Command> m_cmdDict;

		// Token: 0x0400CC3D RID: 52285
		[Token(Token = "0x400CC3D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Action<Command>> m_cmdProcessorDict;

		// Token: 0x0400CC3E RID: 52286
		[Token(Token = "0x400CC3E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Command> m_charCmdDict;

		// Token: 0x0400CC3F RID: 52287
		[Token(Token = "0x400CC3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400CC40 RID: 52288
		[Token(Token = "0x400CC40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateCommand;

		// Token: 0x0400CC41 RID: 52289
		[Token(Token = "0x400CC41")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearCommand;

		// Token: 0x0400CC42 RID: 52290
		[Token(Token = "0x400CC42")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400CC43 RID: 52291
		[Token(Token = "0x400CC43")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCommand;

		// Token: 0x0400CC44 RID: 52292
		[Token(Token = "0x400CC44")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCharViewCommand;

		// Token: 0x0400CC45 RID: 52293
		[Token(Token = "0x400CC45")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GeneralProcessor;

		// Token: 0x0400CC46 RID: 52294
		[Token(Token = "0x400CC46")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ProcessCharslot;

		// Token: 0x0400CC47 RID: 52295
		[Token(Token = "0x400CC47")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__NormalizeSlotName;

		// Token: 0x0400CC48 RID: 52296
		[Token(Token = "0x400CC48")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__IsStandardSlot;

		// Token: 0x0400CC49 RID: 52297
		[Token(Token = "0x400CC49")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ProcessCharacter;
	}
}
