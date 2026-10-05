using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062D3 RID: 25299
	[Token(Token = "0x20062D3")]
	public class AutoChessMultiMatchViewModel : IHotfixable
	{
		// Token: 0x170055CF RID: 21967
		// (get) Token: 0x0602474A RID: 149322 RVA: 0x000C4380 File Offset: 0x000C2580
		[Token(Token = "0x170055CF")]
		public bool isMatching
		{
			[Token(Token = "0x602474A")]
			[Address(RVA = "0x1F489B0", Offset = "0x1F475B0", VA = "0x181F489B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170055D0 RID: 21968
		// (get) Token: 0x0602474B RID: 149323 RVA: 0x000C4398 File Offset: 0x000C2598
		[Token(Token = "0x170055D0")]
		public int waitSeconds
		{
			[Token(Token = "0x602474B")]
			[Address(RVA = "0x1F48CA0", Offset = "0x1F478A0", VA = "0x181F48CA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170055D1 RID: 21969
		// (get) Token: 0x0602474C RID: 149324 RVA: 0x000C43B0 File Offset: 0x000C25B0
		// (set) Token: 0x0602474D RID: 149325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D1")]
		public int matchStatusSeqNum
		{
			[Token(Token = "0x602474C")]
			[Address(RVA = "0x1F48B20", Offset = "0x1F47720", VA = "0x181F48B20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602474D")]
			[Address(RVA = "0x1F48ED0", Offset = "0x1F47AD0", VA = "0x181F48ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055D2 RID: 21970
		// (get) Token: 0x0602474E RID: 149326 RVA: 0x000C43C8 File Offset: 0x000C25C8
		// (set) Token: 0x0602474F RID: 149327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D2")]
		public AutoChessMultiMatchStatus matchStatus
		{
			[Token(Token = "0x602474E")]
			[Address(RVA = "0x1F48B80", Offset = "0x1F47780", VA = "0x181F48B80")]
			[CompilerGenerated]
			get
			{
				return AutoChessMultiMatchStatus.NONE;
			}
			[Token(Token = "0x602474F")]
			[Address(RVA = "0x1F48F40", Offset = "0x1F47B40", VA = "0x181F48F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055D3 RID: 21971
		// (get) Token: 0x06024750 RID: 149328 RVA: 0x000C43E0 File Offset: 0x000C25E0
		// (set) Token: 0x06024751 RID: 149329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D3")]
		public AutoChessMultiMatchResult matchResult
		{
			[Token(Token = "0x6024750")]
			[Address(RVA = "0x1F48AC0", Offset = "0x1F476C0", VA = "0x181F48AC0")]
			[CompilerGenerated]
			get
			{
				return AutoChessMultiMatchResult.NONE;
			}
			[Token(Token = "0x6024751")]
			[Address(RVA = "0x1F48E60", Offset = "0x1F47A60", VA = "0x181F48E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055D4 RID: 21972
		// (get) Token: 0x06024752 RID: 149330 RVA: 0x000C43F8 File Offset: 0x000C25F8
		// (set) Token: 0x06024753 RID: 149331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D4")]
		public bool isPrecise
		{
			[Token(Token = "0x6024752")]
			[Address(RVA = "0x1F48A60", Offset = "0x1F47660", VA = "0x181F48A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024753")]
			[Address(RVA = "0x1F48DF0", Offset = "0x1F479F0", VA = "0x181F48DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055D5 RID: 21973
		// (get) Token: 0x06024754 RID: 149332 RVA: 0x000C4410 File Offset: 0x000C2610
		// (set) Token: 0x06024755 RID: 149333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D5")]
		public ActAutoChessModeDifficultyType difficultyType
		{
			[Token(Token = "0x6024754")]
			[Address(RVA = "0x1F488F0", Offset = "0x1F474F0", VA = "0x181F488F0")]
			[CompilerGenerated]
			get
			{
				return ActAutoChessModeDifficultyType.TRAINING;
			}
			[Token(Token = "0x6024755")]
			[Address(RVA = "0x1F48D00", Offset = "0x1F47900", VA = "0x181F48D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055D6 RID: 21974
		// (get) Token: 0x06024756 RID: 149334 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024757 RID: 149335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D6")]
		public string modeName
		{
			[Token(Token = "0x6024756")]
			[Address(RVA = "0x1F48BE0", Offset = "0x1F477E0", VA = "0x181F48BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024757")]
			[Address(RVA = "0x1F48FB0", Offset = "0x1F47BB0", VA = "0x181F48FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055D7 RID: 21975
		// (get) Token: 0x06024758 RID: 149336 RVA: 0x000C4428 File Offset: 0x000C2628
		// (set) Token: 0x06024759 RID: 149337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D7")]
		public bool showCancelBtn
		{
			[Token(Token = "0x6024758")]
			[Address(RVA = "0x1F48C40", Offset = "0x1F47840", VA = "0x181F48C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024759")]
			[Address(RVA = "0x1F49030", Offset = "0x1F47C30", VA = "0x181F49030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055D8 RID: 21976
		// (get) Token: 0x0602475A RID: 149338 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602475B RID: 149339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D8")]
		public string gameTipText
		{
			[Token(Token = "0x602475A")]
			[Address(RVA = "0x1F48950", Offset = "0x1F47550", VA = "0x181F48950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602475B")]
			[Address(RVA = "0x1F48D70", Offset = "0x1F47970", VA = "0x181F48D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602475C RID: 149340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602475C")]
		[Address(RVA = "0x1F48070", Offset = "0x1F46C70", VA = "0x181F48070")]
		public void InitMatchViewModel(string actId, bool isPrecise, string modeId, bool canCancel)
		{
		}

		// Token: 0x0602475D RID: 149341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602475D")]
		[Address(RVA = "0x1F48530", Offset = "0x1F47130", VA = "0x181F48530")]
		public void MarkStartMatch()
		{
		}

		// Token: 0x0602475E RID: 149342 RVA: 0x000C4440 File Offset: 0x000C2640
		[Token(Token = "0x602475E")]
		[Address(RVA = "0x1F48730", Offset = "0x1F47330", VA = "0x181F48730")]
		public bool TickMatchSecs(float timeDelta)
		{
			return default(bool);
		}

		// Token: 0x0602475F RID: 149343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602475F")]
		[Address(RVA = "0x1F48400", Offset = "0x1F47000", VA = "0x181F48400")]
		public void MarkEndMatch(AutoChessMultiMatchResult result)
		{
		}

		// Token: 0x06024760 RID: 149344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024760")]
		[Address(RVA = "0x1F48680", Offset = "0x1F47280", VA = "0x181F48680")]
		public void SetGameTipText(string gameTipText)
		{
		}

		// Token: 0x06024761 RID: 149345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024761")]
		[Address(RVA = "0x1F48860", Offset = "0x1F47460", VA = "0x181F48860")]
		public AutoChessMultiMatchViewModel()
		{
		}

		// Token: 0x04032C57 RID: 207959
		[Token(Token = "0x4032C57")]
		[FieldOffset(Offset = "0x40")]
		private float m_matchingSecsFloat;

		// Token: 0x04032C58 RID: 207960
		[Token(Token = "0x4032C58")]
		[FieldOffset(Offset = "0x44")]
		private int m_matchingSecsInt;

		// Token: 0x04032C59 RID: 207961
		[Token(Token = "0x4032C59")]
		[FieldOffset(Offset = "0x48")]
		private float m_matchTimeMax;

		// Token: 0x04032C5A RID: 207962
		[Token(Token = "0x4032C5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isMatching;

		// Token: 0x04032C5B RID: 207963
		[Token(Token = "0x4032C5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_waitSeconds;

		// Token: 0x04032C5C RID: 207964
		[Token(Token = "0x4032C5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_matchStatusSeqNum;

		// Token: 0x04032C5D RID: 207965
		[Token(Token = "0x4032C5D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_matchStatusSeqNum;

		// Token: 0x04032C5E RID: 207966
		[Token(Token = "0x4032C5E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_matchStatus;

		// Token: 0x04032C5F RID: 207967
		[Token(Token = "0x4032C5F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_matchStatus;

		// Token: 0x04032C60 RID: 207968
		[Token(Token = "0x4032C60")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_matchResult;

		// Token: 0x04032C61 RID: 207969
		[Token(Token = "0x4032C61")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_matchResult;

		// Token: 0x04032C62 RID: 207970
		[Token(Token = "0x4032C62")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isPrecise;

		// Token: 0x04032C63 RID: 207971
		[Token(Token = "0x4032C63")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isPrecise;

		// Token: 0x04032C64 RID: 207972
		[Token(Token = "0x4032C64")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_difficultyType;

		// Token: 0x04032C65 RID: 207973
		[Token(Token = "0x4032C65")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_difficultyType;

		// Token: 0x04032C66 RID: 207974
		[Token(Token = "0x4032C66")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_modeName;

		// Token: 0x04032C67 RID: 207975
		[Token(Token = "0x4032C67")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_modeName;

		// Token: 0x04032C68 RID: 207976
		[Token(Token = "0x4032C68")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_showCancelBtn;

		// Token: 0x04032C69 RID: 207977
		[Token(Token = "0x4032C69")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_showCancelBtn;

		// Token: 0x04032C6A RID: 207978
		[Token(Token = "0x4032C6A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_gameTipText;

		// Token: 0x04032C6B RID: 207979
		[Token(Token = "0x4032C6B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_gameTipText;

		// Token: 0x04032C6C RID: 207980
		[Token(Token = "0x4032C6C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_InitMatchViewModel;

		// Token: 0x04032C6D RID: 207981
		[Token(Token = "0x4032C6D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_MarkStartMatch;

		// Token: 0x04032C6E RID: 207982
		[Token(Token = "0x4032C6E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_TickMatchSecs;

		// Token: 0x04032C6F RID: 207983
		[Token(Token = "0x4032C6F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_MarkEndMatch;

		// Token: 0x04032C70 RID: 207984
		[Token(Token = "0x4032C70")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetGameTipText;

		// Token: 0x04032C71 RID: 207985
		[Token(Token = "0x4032C71")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
