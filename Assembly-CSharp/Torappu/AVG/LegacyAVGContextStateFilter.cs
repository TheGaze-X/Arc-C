using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E27 RID: 7719
	[Token(Token = "0x2001E27")]
	public static class LegacyAVGContextStateFilter
	{
		// Token: 0x0600BEB9 RID: 48825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB9")]
		[Address(RVA = "0x33C5380", Offset = "0x33C3F80", VA = "0x1833C5380")]
		private static void ProcessBg(Command command, ref Command bgCommand)
		{
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBA")]
		[Address(RVA = "0x33C5380", Offset = "0x33C3F80", VA = "0x1833C5380")]
		private static void ProcessShowItem(Command command, ref Command itemCommand)
		{
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBB")]
		[Address(RVA = "0x33C55D0", Offset = "0x33C41D0", VA = "0x1833C55D0")]
		private static void ProcessHideItem(Command command, ref Command itemCommand)
		{
		}

		// Token: 0x0600BEBC RID: 48828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBC")]
		[Address(RVA = "0x33C5380", Offset = "0x33C3F80", VA = "0x1833C5380")]
		private static void ProcessCgItem(Command command, ref Command cgitemCommand)
		{
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBD")]
		[Address(RVA = "0x33C55D0", Offset = "0x33C41D0", VA = "0x1833C55D0")]
		private static void ProcessHideCgItem(Command command, ref Command cgitemCommand)
		{
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBE")]
		[Address(RVA = "0x33C5380", Offset = "0x33C3F80", VA = "0x1833C5380")]
		private static void ProcessPlayMusic(Command command, ref Command musicCommand)
		{
		}

		// Token: 0x0600BEBF RID: 48831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBF")]
		[Address(RVA = "0x33C55D0", Offset = "0x33C41D0", VA = "0x1833C55D0")]
		private static void ProcessStopMusic(Command command, ref Command musicCommand)
		{
		}

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC0")]
		[Address(RVA = "0x33C5EF0", Offset = "0x33C4AF0", VA = "0x1833C5EF0")]
		private static void ProcessSticker(Command command, ref List<Command> stickerCommands)
		{
		}

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC1")]
		[Address(RVA = "0x33C5E90", Offset = "0x33C4A90", VA = "0x1833C5E90")]
		private static void ProcessStickerClear(Command command, ref List<Command> stickerCommands)
		{
		}

		// Token: 0x0600BEC2 RID: 48834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC2")]
		[Address(RVA = "0x33C5FB0", Offset = "0x33C4BB0", VA = "0x1833C5FB0")]
		private static void ProcessTimerSticker(Command command, ref List<Command> stickerCommands)
		{
		}

		// Token: 0x0600BEC3 RID: 48835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC3")]
		[Address(RVA = "0x33C5F50", Offset = "0x33C4B50", VA = "0x1833C5F50")]
		private static void ProcessTimerClear(Command command, ref List<Command> stickerCommands)
		{
		}

		// Token: 0x0600BEC4 RID: 48836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC4")]
		[Address(RVA = "0x33C55F0", Offset = "0x33C41F0", VA = "0x1833C55F0")]
		private static void ProcessMultiline(Command command, ref List<Command> multilineCmdList)
		{
		}

		// Token: 0x0600BEC5 RID: 48837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC5")]
		[Address(RVA = "0x33C53A0", Offset = "0x33C3FA0", VA = "0x1833C53A0")]
		private static void ProcessCharslot(Command command, ref Command leftCommand, ref Command middleCommand, ref Command rightCommand)
		{
		}

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BEC6")]
		[Address(RVA = "0x33C4FA0", Offset = "0x33C3BA0", VA = "0x1833C4FA0")]
		public static List<Command> FilterContextStateCommands(IList<Command> commands, int endIndex)
		{
			return null;
		}

		// Token: 0x0600BEC7 RID: 48839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC7")]
		[Address(RVA = "0x33C56C0", Offset = "0x33C42C0", VA = "0x1833C56C0")]
		private static void ProcessSingleCommand(Command cmd, int index, LegacyAVGContextStateFilter.FilterState state)
		{
		}

		// Token: 0x0600BEC8 RID: 48840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BEC8")]
		[Address(RVA = "0x33C4D00", Offset = "0x33C3900", VA = "0x1833C4D00")]
		private static List<Command> BuildResultList(LegacyAVGContextStateFilter.FilterState state)
		{
			return null;
		}

		// Token: 0x0400BFA8 RID: 49064
		[Token(Token = "0x400BFA8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> SKIP_COMMANDS;

		// Token: 0x0400BFA9 RID: 49065
		[Token(Token = "0x400BFA9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<string> OVERRIDE_COMMANDS;

		// Token: 0x0400BFAA RID: 49066
		[Token(Token = "0x400BFAA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly HashSet<string> BG_COMMANDS;

		// Token: 0x0400BFAB RID: 49067
		[Token(Token = "0x400BFAB")]
		[FieldOffset(Offset = "0x18")]
		private static readonly HashSet<string> ITEM_COMMANDS;

		// Token: 0x0400BFAC RID: 49068
		[Token(Token = "0x400BFAC")]
		[FieldOffset(Offset = "0x20")]
		private static readonly HashSet<string> CGITEM_COMMANDS;

		// Token: 0x0400BFAD RID: 49069
		[Token(Token = "0x400BFAD")]
		[FieldOffset(Offset = "0x28")]
		private static readonly HashSet<string> MUSIC_COMMANDS;

		// Token: 0x0400BFAE RID: 49070
		[Token(Token = "0x400BFAE")]
		[FieldOffset(Offset = "0x30")]
		private static readonly HashSet<string> STICKER_COMMANDS;

		// Token: 0x0400BFAF RID: 49071
		[Token(Token = "0x400BFAF")]
		[FieldOffset(Offset = "0x38")]
		private static readonly HashSet<string> DECISION_COMMANDS;

		// Token: 0x0400BFB0 RID: 49072
		[Token(Token = "0x400BFB0")]
		[FieldOffset(Offset = "0x40")]
		private static readonly HashSet<string> PREDICATE_COMMANDS;

		// Token: 0x0400BFB1 RID: 49073
		[Token(Token = "0x400BFB1")]
		[FieldOffset(Offset = "0x48")]
		private static readonly HashSet<string> CHARSLOT_COMMANDS;

		// Token: 0x0400BFB2 RID: 49074
		[Token(Token = "0x400BFB2")]
		[FieldOffset(Offset = "0x50")]
		private static readonly HashSet<string> MULTILINE_COMMANDS;

		// Token: 0x0400BFB3 RID: 49075
		[Token(Token = "0x400BFB3")]
		[FieldOffset(Offset = "0x58")]
		private static readonly Dictionary<string, LegacyAVGContextStateFilter.BackgroundCommandProcessor> s_bgCommandProcessors;

		// Token: 0x0400BFB4 RID: 49076
		[Token(Token = "0x400BFB4")]
		[FieldOffset(Offset = "0x60")]
		private static readonly Dictionary<string, LegacyAVGContextStateFilter.ItemCommandProcessor> s_itemCommandProcessors;

		// Token: 0x0400BFB5 RID: 49077
		[Token(Token = "0x400BFB5")]
		[FieldOffset(Offset = "0x68")]
		private static readonly Dictionary<string, LegacyAVGContextStateFilter.CGItemCommandProcessor> s_cgitemCommandProcessors;

		// Token: 0x0400BFB6 RID: 49078
		[Token(Token = "0x400BFB6")]
		[FieldOffset(Offset = "0x70")]
		private static readonly Dictionary<string, LegacyAVGContextStateFilter.MusicCommandProcessor> s_musicCommandProcessors;

		// Token: 0x0400BFB7 RID: 49079
		[Token(Token = "0x400BFB7")]
		[FieldOffset(Offset = "0x78")]
		private static readonly Dictionary<string, LegacyAVGContextStateFilter.StickerCommandProcessor> s_stickerCommandProcessors;

		// Token: 0x0400BFB8 RID: 49080
		[Token(Token = "0x400BFB8")]
		[FieldOffset(Offset = "0x80")]
		private static readonly Dictionary<string, LegacyAVGContextStateFilter.MultilineCommandProcessor> s_multilineCommandProcessors;

		// Token: 0x0400BFB9 RID: 49081
		[Token(Token = "0x400BFB9")]
		[FieldOffset(Offset = "0x88")]
		private static readonly Dictionary<string, LegacyAVGContextStateFilter.CharSlotCommandProcessor> s_charslotCommandProcessors;

		// Token: 0x02001E28 RID: 7720
		// (Invoke) Token: 0x0600BECB RID: 48843
		[Token(Token = "0x2001E28")]
		private delegate void BackgroundCommandProcessor(Command command, ref Command bgCommand);

		// Token: 0x02001E29 RID: 7721
		// (Invoke) Token: 0x0600BECF RID: 48847
		[Token(Token = "0x2001E29")]
		private delegate void ItemCommandProcessor(Command command, ref Command itemCommand);

		// Token: 0x02001E2A RID: 7722
		// (Invoke) Token: 0x0600BED3 RID: 48851
		[Token(Token = "0x2001E2A")]
		private delegate void CGItemCommandProcessor(Command command, ref Command cgitemCommand);

		// Token: 0x02001E2B RID: 7723
		// (Invoke) Token: 0x0600BED7 RID: 48855
		[Token(Token = "0x2001E2B")]
		private delegate void MusicCommandProcessor(Command command, ref Command musicCommand);

		// Token: 0x02001E2C RID: 7724
		// (Invoke) Token: 0x0600BEDB RID: 48859
		[Token(Token = "0x2001E2C")]
		private delegate void StickerCommandProcessor(Command command, ref List<Command> stickerCommands);

		// Token: 0x02001E2D RID: 7725
		// (Invoke) Token: 0x0600BEDF RID: 48863
		[Token(Token = "0x2001E2D")]
		private delegate void MultilineCommandProcessor(Command command, ref List<Command> multilineCmdList);

		// Token: 0x02001E2E RID: 7726
		// (Invoke) Token: 0x0600BEE3 RID: 48867
		[Token(Token = "0x2001E2E")]
		private delegate void CharSlotCommandProcessor(Command command, ref Command leftCommand, ref Command middleCommand, ref Command rightCommand);

		// Token: 0x02001E2F RID: 7727
		[Token(Token = "0x2001E2F")]
		private sealed class FilterState
		{
			// Token: 0x0600BEE6 RID: 48870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BEE6")]
			[Address(RVA = "0x33C4B80", Offset = "0x33C3780", VA = "0x1833C4B80")]
			public FilterState()
			{
			}

			// Token: 0x0400BFBA RID: 49082
			[Token(Token = "0x400BFBA")]
			[FieldOffset(Offset = "0x10")]
			internal readonly Dictionary<string, Command> LastOverrideCommands;

			// Token: 0x0400BFBB RID: 49083
			[Token(Token = "0x400BFBB")]
			[FieldOffset(Offset = "0x18")]
			internal Command BgCommand;

			// Token: 0x0400BFBC RID: 49084
			[Token(Token = "0x400BFBC")]
			[FieldOffset(Offset = "0x20")]
			internal Command ItemCommand;

			// Token: 0x0400BFBD RID: 49085
			[Token(Token = "0x400BFBD")]
			[FieldOffset(Offset = "0x28")]
			internal Command CgitemCommand;

			// Token: 0x0400BFBE RID: 49086
			[Token(Token = "0x400BFBE")]
			[FieldOffset(Offset = "0x30")]
			internal Command MusicCommand;

			// Token: 0x0400BFBF RID: 49087
			[Token(Token = "0x400BFBF")]
			[FieldOffset(Offset = "0x38")]
			internal List<Command> StickerCommands;

			// Token: 0x0400BFC0 RID: 49088
			[Token(Token = "0x400BFC0")]
			[FieldOffset(Offset = "0x40")]
			internal List<Command> MultilineCmdList;

			// Token: 0x0400BFC1 RID: 49089
			[Token(Token = "0x400BFC1")]
			[FieldOffset(Offset = "0x48")]
			internal Command LastDecisionCommand;

			// Token: 0x0400BFC2 RID: 49090
			[Token(Token = "0x400BFC2")]
			[FieldOffset(Offset = "0x50")]
			internal int LastDecisionIndex;

			// Token: 0x0400BFC3 RID: 49091
			[Token(Token = "0x400BFC3")]
			[FieldOffset(Offset = "0x58")]
			internal Command LeftSlotCommand;

			// Token: 0x0400BFC4 RID: 49092
			[Token(Token = "0x400BFC4")]
			[FieldOffset(Offset = "0x60")]
			internal Command MiddleSlotCommand;

			// Token: 0x0400BFC5 RID: 49093
			[Token(Token = "0x400BFC5")]
			[FieldOffset(Offset = "0x68")]
			internal Command RightSlotCommand;
		}
	}
}
