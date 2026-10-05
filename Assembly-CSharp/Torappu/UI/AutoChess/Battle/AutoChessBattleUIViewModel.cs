using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006485 RID: 25733
	[Token(Token = "0x2006485")]
	public class AutoChessBattleUIViewModel : IHotfixable
	{
		// Token: 0x17005739 RID: 22329
		// (get) Token: 0x06024FF3 RID: 151539 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024FF4 RID: 151540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005739")]
		public string actId
		{
			[Token(Token = "0x6024FF3")]
			[Address(RVA = "0x1FD4850", Offset = "0x1FD3450", VA = "0x181FD4850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024FF4")]
			[Address(RVA = "0x1FD5630", Offset = "0x1FD4230", VA = "0x181FD5630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700573A RID: 22330
		// (get) Token: 0x06024FF5 RID: 151541 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024FF6 RID: 151542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700573A")]
		public AutoChessData autoChessData
		{
			[Token(Token = "0x6024FF5")]
			[Address(RVA = "0x1FD4910", Offset = "0x1FD3510", VA = "0x181FD4910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024FF6")]
			[Address(RVA = "0x1FD5730", Offset = "0x1FD4330", VA = "0x181FD5730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700573B RID: 22331
		// (get) Token: 0x06024FF7 RID: 151543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024FF8 RID: 151544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700573B")]
		public ActAutoChessData autoChessActData
		{
			[Token(Token = "0x6024FF7")]
			[Address(RVA = "0x1FD48B0", Offset = "0x1FD34B0", VA = "0x181FD48B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024FF8")]
			[Address(RVA = "0x1FD56B0", Offset = "0x1FD42B0", VA = "0x181FD56B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700573C RID: 22332
		// (get) Token: 0x06024FF9 RID: 151545 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024FFA RID: 151546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700573C")]
		public string modeId
		{
			[Token(Token = "0x6024FF9")]
			[Address(RVA = "0x1FD5030", Offset = "0x1FD3C30", VA = "0x181FD5030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024FFA")]
			[Address(RVA = "0x1FD5DB0", Offset = "0x1FD49B0", VA = "0x181FD5DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700573D RID: 22333
		// (get) Token: 0x06024FFB RID: 151547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024FFC RID: 151548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700573D")]
		public List<string> bannedBonds
		{
			[Token(Token = "0x6024FFB")]
			[Address(RVA = "0x1FD4970", Offset = "0x1FD3570", VA = "0x181FD4970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024FFC")]
			[Address(RVA = "0x1FD57B0", Offset = "0x1FD43B0", VA = "0x181FD57B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700573E RID: 22334
		// (get) Token: 0x06024FFD RID: 151549 RVA: 0x000C6018 File Offset: 0x000C4218
		// (set) Token: 0x06024FFE RID: 151550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700573E")]
		public AutoChessGameStateType statusState
		{
			[Token(Token = "0x6024FFD")]
			[Address(RVA = "0x1FD54B0", Offset = "0x1FD40B0", VA = "0x181FD54B0")]
			[CompilerGenerated]
			get
			{
				return AutoChessGameStateType.NONE;
			}
			[Token(Token = "0x6024FFE")]
			[Address(RVA = "0x1FD6250", Offset = "0x1FD4E50", VA = "0x181FD6250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700573F RID: 22335
		// (get) Token: 0x06024FFF RID: 151551 RVA: 0x000C6030 File Offset: 0x000C4230
		// (set) Token: 0x06025000 RID: 151552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700573F")]
		public AutoChessGameStatus.SubState subStatusState
		{
			[Token(Token = "0x6024FFF")]
			[Address(RVA = "0x1FD5510", Offset = "0x1FD4110", VA = "0x181FD5510")]
			[CompilerGenerated]
			get
			{
				return AutoChessGameStatus.SubState.NONE;
			}
			[Token(Token = "0x6025000")]
			[Address(RVA = "0x1FD62C0", Offset = "0x1FD4EC0", VA = "0x181FD62C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005740 RID: 22336
		// (get) Token: 0x06025001 RID: 151553 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025002 RID: 151554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005740")]
		public AutoChessShopDataModel shopData
		{
			[Token(Token = "0x6025001")]
			[Address(RVA = "0x1FD53F0", Offset = "0x1FD3FF0", VA = "0x181FD53F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025002")]
			[Address(RVA = "0x1FD61D0", Offset = "0x1FD4DD0", VA = "0x181FD61D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005741 RID: 22337
		// (get) Token: 0x06025003 RID: 151555 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025004 RID: 151556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005741")]
		public AutoChessSettleDataModel settleData
		{
			[Token(Token = "0x6025003")]
			[Address(RVA = "0x1FD5390", Offset = "0x1FD3F90", VA = "0x181FD5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025004")]
			[Address(RVA = "0x1FD6150", Offset = "0x1FD4D50", VA = "0x181FD6150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005742 RID: 22338
		// (get) Token: 0x06025005 RID: 151557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025006 RID: 151558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005742")]
		public AutoChessBattleStatusDataModel battleStatusData
		{
			[Token(Token = "0x6025005")]
			[Address(RVA = "0x1FD49D0", Offset = "0x1FD35D0", VA = "0x181FD49D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025006")]
			[Address(RVA = "0x1FD5830", Offset = "0x1FD4430", VA = "0x181FD5830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005743 RID: 22339
		// (get) Token: 0x06025007 RID: 151559 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025008 RID: 151560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005743")]
		public AutoChessSquadModel chessSquadData
		{
			[Token(Token = "0x6025007")]
			[Address(RVA = "0x1FD4AF0", Offset = "0x1FD36F0", VA = "0x181FD4AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025008")]
			[Address(RVA = "0x1FD58B0", Offset = "0x1FD44B0", VA = "0x181FD58B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005744 RID: 22340
		// (get) Token: 0x06025009 RID: 151561 RVA: 0x000C6048 File Offset: 0x000C4248
		// (set) Token: 0x0602500A RID: 151562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005744")]
		public int selfPlayerIdx
		{
			[Token(Token = "0x6025009")]
			[Address(RVA = "0x1FD52D0", Offset = "0x1FD3ED0", VA = "0x181FD52D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602500A")]
			[Address(RVA = "0x1FD6070", Offset = "0x1FD4C70", VA = "0x181FD6070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005745 RID: 22341
		// (get) Token: 0x0602500B RID: 151563 RVA: 0x000C6060 File Offset: 0x000C4260
		// (set) Token: 0x0602500C RID: 151564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005745")]
		public int viewPlayerIdx
		{
			[Token(Token = "0x602500B")]
			[Address(RVA = "0x1FD55D0", Offset = "0x1FD41D0", VA = "0x181FD55D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602500C")]
			[Address(RVA = "0x1FD63B0", Offset = "0x1FD4FB0", VA = "0x181FD63B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005746 RID: 22342
		// (get) Token: 0x0602500D RID: 151565 RVA: 0x000C6078 File Offset: 0x000C4278
		// (set) Token: 0x0602500E RID: 151566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005746")]
		public int realPlayerIdx
		{
			[Token(Token = "0x602500D")]
			[Address(RVA = "0x1FD5210", Offset = "0x1FD3E10", VA = "0x181FD5210")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602500E")]
			[Address(RVA = "0x1FD5F90", Offset = "0x1FD4B90", VA = "0x181FD5F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005747 RID: 22343
		// (get) Token: 0x0602500F RID: 151567 RVA: 0x000C6090 File Offset: 0x000C4290
		// (set) Token: 0x06025010 RID: 151568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005747")]
		public int curRound
		{
			[Token(Token = "0x602500F")]
			[Address(RVA = "0x1FD4B50", Offset = "0x1FD3750", VA = "0x181FD4B50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6025010")]
			[Address(RVA = "0x1FD5930", Offset = "0x1FD4530", VA = "0x181FD5930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005748 RID: 22344
		// (get) Token: 0x06025011 RID: 151569 RVA: 0x000C60A8 File Offset: 0x000C42A8
		// (set) Token: 0x06025012 RID: 151570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005748")]
		public AutoChessGameStateType lastStatusState
		{
			[Token(Token = "0x6025011")]
			[Address(RVA = "0x1FD4FD0", Offset = "0x1FD3BD0", VA = "0x181FD4FD0")]
			[CompilerGenerated]
			get
			{
				return AutoChessGameStateType.NONE;
			}
			[Token(Token = "0x6025012")]
			[Address(RVA = "0x1FD5D40", Offset = "0x1FD4940", VA = "0x181FD5D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005749 RID: 22345
		// (get) Token: 0x06025013 RID: 151571 RVA: 0x000C60C0 File Offset: 0x000C42C0
		// (set) Token: 0x06025014 RID: 151572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005749")]
		public AutoChessGameStateType nextStatusState
		{
			[Token(Token = "0x6025013")]
			[Address(RVA = "0x1FD50F0", Offset = "0x1FD3CF0", VA = "0x181FD50F0")]
			[CompilerGenerated]
			get
			{
				return AutoChessGameStateType.NONE;
			}
			[Token(Token = "0x6025014")]
			[Address(RVA = "0x1FD5EA0", Offset = "0x1FD4AA0", VA = "0x181FD5EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700574A RID: 22346
		// (get) Token: 0x06025015 RID: 151573 RVA: 0x000C60D8 File Offset: 0x000C42D8
		// (set) Token: 0x06025016 RID: 151574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700574A")]
		public AutoChessGameStateType serverStatusState
		{
			[Token(Token = "0x6025015")]
			[Address(RVA = "0x1FD5330", Offset = "0x1FD3F30", VA = "0x181FD5330")]
			[CompilerGenerated]
			get
			{
				return AutoChessGameStateType.NONE;
			}
			[Token(Token = "0x6025016")]
			[Address(RVA = "0x1FD60E0", Offset = "0x1FD4CE0", VA = "0x181FD60E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700574B RID: 22347
		// (get) Token: 0x06025017 RID: 151575 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025018 RID: 151576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700574B")]
		public AutoChessEffectChooseDataModel effectChooseData
		{
			[Token(Token = "0x6025017")]
			[Address(RVA = "0x1FD4BB0", Offset = "0x1FD37B0", VA = "0x181FD4BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025018")]
			[Address(RVA = "0x1FD59A0", Offset = "0x1FD45A0", VA = "0x181FD59A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700574C RID: 22348
		// (get) Token: 0x06025019 RID: 151577 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602501A RID: 151578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700574C")]
		public AutoChessPlayerDataModel playerDataModel
		{
			[Token(Token = "0x6025019")]
			[Address(RVA = "0x1FD5150", Offset = "0x1FD3D50", VA = "0x181FD5150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602501A")]
			[Address(RVA = "0x1FD5F10", Offset = "0x1FD4B10", VA = "0x181FD5F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700574D RID: 22349
		// (get) Token: 0x0602501B RID: 151579 RVA: 0x000C60F0 File Offset: 0x000C42F0
		// (set) Token: 0x0602501C RID: 151580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700574D")]
		public bool isPlayerDead
		{
			[Token(Token = "0x602501B")]
			[Address(RVA = "0x1FD4EB0", Offset = "0x1FD3AB0", VA = "0x181FD4EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602501C")]
			[Address(RVA = "0x1FD5BE0", Offset = "0x1FD47E0", VA = "0x181FD5BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700574E RID: 22350
		// (get) Token: 0x0602501D RID: 151581 RVA: 0x000C6108 File Offset: 0x000C4308
		// (set) Token: 0x0602501E RID: 151582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700574E")]
		public bool inObMode
		{
			[Token(Token = "0x602501D")]
			[Address(RVA = "0x1FD4D90", Offset = "0x1FD3990", VA = "0x181FD4D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602501E")]
			[Address(RVA = "0x1FD5A90", Offset = "0x1FD4690", VA = "0x181FD5A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700574F RID: 22351
		// (get) Token: 0x0602501F RID: 151583 RVA: 0x000C6120 File Offset: 0x000C4320
		// (set) Token: 0x06025020 RID: 151584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700574F")]
		public bool hasDeadObIndex
		{
			[Token(Token = "0x602501F")]
			[Address(RVA = "0x1FD4CD0", Offset = "0x1FD38D0", VA = "0x181FD4CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025020")]
			[Address(RVA = "0x1FD5A20", Offset = "0x1FD4620", VA = "0x181FD5A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005750 RID: 22352
		// (get) Token: 0x06025021 RID: 151585 RVA: 0x000C6138 File Offset: 0x000C4338
		// (set) Token: 0x06025022 RID: 151586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005750")]
		public bool isSelfReady
		{
			[Token(Token = "0x6025021")]
			[Address(RVA = "0x1FD4F10", Offset = "0x1FD3B10", VA = "0x181FD4F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025022")]
			[Address(RVA = "0x1FD5C50", Offset = "0x1FD4850", VA = "0x181FD5C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005751 RID: 22353
		// (get) Token: 0x06025023 RID: 151587 RVA: 0x000C6150 File Offset: 0x000C4350
		// (set) Token: 0x06025024 RID: 151588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005751")]
		public bool isHandFull
		{
			[Token(Token = "0x6025023")]
			[Address(RVA = "0x1FD4DF0", Offset = "0x1FD39F0", VA = "0x181FD4DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025024")]
			[Address(RVA = "0x1FD5B00", Offset = "0x1FD4700", VA = "0x181FD5B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005752 RID: 22354
		// (get) Token: 0x06025025 RID: 151589 RVA: 0x000C6168 File Offset: 0x000C4368
		// (set) Token: 0x06025026 RID: 151590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005752")]
		public int remainAvalidChrCnt
		{
			[Token(Token = "0x6025025")]
			[Address(RVA = "0x1FD5270", Offset = "0x1FD3E70", VA = "0x181FD5270")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6025026")]
			[Address(RVA = "0x1FD6000", Offset = "0x1FD4C00", VA = "0x181FD6000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005753 RID: 22355
		// (get) Token: 0x06025027 RID: 151591 RVA: 0x000C6180 File Offset: 0x000C4380
		// (set) Token: 0x06025028 RID: 151592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005753")]
		public bool isHandOverflow
		{
			[Token(Token = "0x6025027")]
			[Address(RVA = "0x1FD4E50", Offset = "0x1FD3A50", VA = "0x181FD4E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025028")]
			[Address(RVA = "0x1FD5B70", Offset = "0x1FD4770", VA = "0x181FD5B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005754 RID: 22356
		// (get) Token: 0x06025029 RID: 151593 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602502A RID: 151594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005754")]
		public Dictionary<int, int> lastBattleResult
		{
			[Token(Token = "0x6025029")]
			[Address(RVA = "0x1FD4F70", Offset = "0x1FD3B70", VA = "0x181FD4F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602502A")]
			[Address(RVA = "0x1FD5CC0", Offset = "0x1FD48C0", VA = "0x181FD5CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005755 RID: 22357
		// (get) Token: 0x0602502B RID: 151595 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602502C RID: 151596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005755")]
		public AutoChessGameStatus uiStatus
		{
			[Token(Token = "0x602502B")]
			[Address(RVA = "0x1FD5570", Offset = "0x1FD4170", VA = "0x181FD5570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602502C")]
			[Address(RVA = "0x1FD6330", Offset = "0x1FD4F30", VA = "0x181FD6330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005756 RID: 22358
		// (get) Token: 0x0602502D RID: 151597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005756")]
		public AutoChessBattleShopViewModel shopModel
		{
			[Token(Token = "0x602502D")]
			[Address(RVA = "0x1FD5450", Offset = "0x1FD4050", VA = "0x181FD5450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17005757 RID: 22359
		// (get) Token: 0x0602502E RID: 151598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005757")]
		public AutoChessBattleEffectChooseViewModel effectChooseModel
		{
			[Token(Token = "0x602502E")]
			[Address(RVA = "0x1FD4C10", Offset = "0x1FD3810", VA = "0x181FD4C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17005758 RID: 22360
		// (get) Token: 0x0602502F RID: 151599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005758")]
		public AutoChessBattlePlayerStatusGroupModel playerGroupModel
		{
			[Token(Token = "0x602502F")]
			[Address(RVA = "0x1FD51B0", Offset = "0x1FD3DB0", VA = "0x181FD51B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17005759 RID: 22361
		// (get) Token: 0x06025030 RID: 151600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005759")]
		public AutoChessBattleBossRoundModel bossRoundModel
		{
			[Token(Token = "0x6025030")]
			[Address(RVA = "0x1FD4A30", Offset = "0x1FD3630", VA = "0x181FD4A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700575A RID: 22362
		// (get) Token: 0x06025031 RID: 151601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700575A")]
		public AutoChessBattleUIHUDModel hudModel
		{
			[Token(Token = "0x6025031")]
			[Address(RVA = "0x1FD4D30", Offset = "0x1FD3930", VA = "0x181FD4D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700575B RID: 22363
		// (get) Token: 0x06025032 RID: 151602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700575B")]
		public AutoChessBattleUIEquipReplaceViewModel equipReplaceModel
		{
			[Token(Token = "0x6025032")]
			[Address(RVA = "0x1FD4C70", Offset = "0x1FD3870", VA = "0x181FD4C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700575C RID: 22364
		// (get) Token: 0x06025033 RID: 151603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700575C")]
		public AutoChessBattleUIBottomTipsViewModel bottomTipsViewModel
		{
			[Token(Token = "0x6025033")]
			[Address(RVA = "0x1FD4A90", Offset = "0x1FD3690", VA = "0x181FD4A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700575D RID: 22365
		// (get) Token: 0x06025034 RID: 151604 RVA: 0x000C6198 File Offset: 0x000C4398
		// (set) Token: 0x06025035 RID: 151605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700575D")]
		public ActAutoChessModeType modeType
		{
			[Token(Token = "0x6025034")]
			[Address(RVA = "0x1FD5090", Offset = "0x1FD3C90", VA = "0x181FD5090")]
			[CompilerGenerated]
			get
			{
				return ActAutoChessModeType.LOCAL;
			}
			[Token(Token = "0x6025035")]
			[Address(RVA = "0x1FD5E30", Offset = "0x1FD4A30", VA = "0x181FD5E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06025036 RID: 151606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025036")]
		[Address(RVA = "0x1FD27B0", Offset = "0x1FD13B0", VA = "0x181FD27B0")]
		public void InitData(string actId)
		{
		}

		// Token: 0x06025037 RID: 151607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025037")]
		[Address(RVA = "0x1FD3600", Offset = "0x1FD2200", VA = "0x181FD3600")]
		public void LoadData()
		{
		}

		// Token: 0x06025038 RID: 151608 RVA: 0x000C61B0 File Offset: 0x000C43B0
		[Token(Token = "0x6025038")]
		[Address(RVA = "0x1FD2F00", Offset = "0x1FD1B00", VA = "0x181FD2F00")]
		public bool IsEffectChooseShow()
		{
			return default(bool);
		}

		// Token: 0x06025039 RID: 151609 RVA: 0x000C61C8 File Offset: 0x000C43C8
		[Token(Token = "0x6025039")]
		[Address(RVA = "0x1FD2E90", Offset = "0x1FD1A90", VA = "0x181FD2E90")]
		public bool IsCountdownPanelShow()
		{
			return default(bool);
		}

		// Token: 0x0602503A RID: 151610 RVA: 0x000C61E0 File Offset: 0x000C43E0
		[Token(Token = "0x602503A")]
		[Address(RVA = "0x1FD2DB0", Offset = "0x1FD19B0", VA = "0x181FD2DB0")]
		public bool IsCountdownHintShow()
		{
			return default(bool);
		}

		// Token: 0x0602503B RID: 151611 RVA: 0x000C61F8 File Offset: 0x000C43F8
		[Token(Token = "0x602503B")]
		[Address(RVA = "0x1FD25E0", Offset = "0x1FD11E0", VA = "0x181FD25E0")]
		public AutoChessBattleUICountdownViewModel.TimeInfo GetCurrentForceEndTs(DateTime currentTime)
		{
			return default(AutoChessBattleUICountdownViewModel.TimeInfo);
		}

		// Token: 0x0602503C RID: 151612 RVA: 0x000C6210 File Offset: 0x000C4410
		[Token(Token = "0x602503C")]
		[Address(RVA = "0x1FD32C0", Offset = "0x1FD1EC0", VA = "0x181FD32C0")]
		public bool IsPrepReadyPanelShow()
		{
			return default(bool);
		}

		// Token: 0x0602503D RID: 151613 RVA: 0x000C6228 File Offset: 0x000C4428
		[Token(Token = "0x602503D")]
		[Address(RVA = "0x1FD21E0", Offset = "0x1FD0DE0", VA = "0x181FD21E0")]
		public bool CheckIfNeedRoundRemainTip(out int remainRoundCnt)
		{
			return default(bool);
		}

		// Token: 0x0602503E RID: 151614 RVA: 0x000C6240 File Offset: 0x000C4440
		[Token(Token = "0x602503E")]
		[Address(RVA = "0x1FD2690", Offset = "0x1FD1290", VA = "0x181FD2690")]
		public int GetRoundStartCoin()
		{
			return 0;
		}

		// Token: 0x0602503F RID: 151615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602503F")]
		[Address(RVA = "0x1FD2350", Offset = "0x1FD0F50", VA = "0x181FD2350")]
		public void GetBattleResultStatus(out int viewPlayerLostResult, out bool isAllPrefect)
		{
		}

		// Token: 0x06025040 RID: 151616 RVA: 0x000C6258 File Offset: 0x000C4458
		[Token(Token = "0x6025040")]
		[Address(RVA = "0x1FD30A0", Offset = "0x1FD1CA0", VA = "0x181FD30A0")]
		public bool IsNeedToShowPreReadyTipGold()
		{
			return default(bool);
		}

		// Token: 0x06025041 RID: 151617 RVA: 0x000C6270 File Offset: 0x000C4470
		[Token(Token = "0x6025041")]
		[Address(RVA = "0x1FD3420", Offset = "0x1FD2020", VA = "0x181FD3420")]
		public bool IsWaitingPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06025042 RID: 151618 RVA: 0x000C6288 File Offset: 0x000C4488
		[Token(Token = "0x6025042")]
		[Address(RVA = "0x1FD4340", Offset = "0x1FD2F40", VA = "0x181FD4340")]
		private int _GetTotalRoundCntToFirstBoss(AutoChessData autoChessData, string modeId)
		{
			return 0;
		}

		// Token: 0x06025043 RID: 151619 RVA: 0x000C62A0 File Offset: 0x000C44A0
		[Token(Token = "0x6025043")]
		[Address(RVA = "0x1FD4230", Offset = "0x1FD2E30", VA = "0x181FD4230")]
		private ActAutoChessModeType _GetModeType()
		{
			return ActAutoChessModeType.LOCAL;
		}

		// Token: 0x06025044 RID: 151620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025044")]
		[Address(RVA = "0x1FD3660", Offset = "0x1FD2260", VA = "0x181FD3660")]
		private void _ApplyData()
		{
		}

		// Token: 0x06025045 RID: 151621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025045")]
		[Address(RVA = "0x1FD4560", Offset = "0x1FD3160", VA = "0x181FD4560")]
		public AutoChessBattleUIViewModel()
		{
		}

		// Token: 0x04033C93 RID: 212115
		[Token(Token = "0x4033C93")]
		[FieldOffset(Offset = "0xF0")]
		private AutoChessBattleUICountdownViewModel m_countdownViewModel;

		// Token: 0x04033C94 RID: 212116
		[Token(Token = "0x4033C94")]
		[FieldOffset(Offset = "0xF8")]
		private int m_totalRoundCntToFirstBoss;

		// Token: 0x04033C95 RID: 212117
		[Token(Token = "0x4033C95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04033C96 RID: 212118
		[Token(Token = "0x4033C96")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04033C97 RID: 212119
		[Token(Token = "0x4033C97")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_autoChessData;

		// Token: 0x04033C98 RID: 212120
		[Token(Token = "0x4033C98")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_autoChessData;

		// Token: 0x04033C99 RID: 212121
		[Token(Token = "0x4033C99")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_autoChessActData;

		// Token: 0x04033C9A RID: 212122
		[Token(Token = "0x4033C9A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_autoChessActData;

		// Token: 0x04033C9B RID: 212123
		[Token(Token = "0x4033C9B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_modeId;

		// Token: 0x04033C9C RID: 212124
		[Token(Token = "0x4033C9C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_modeId;

		// Token: 0x04033C9D RID: 212125
		[Token(Token = "0x4033C9D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bannedBonds;

		// Token: 0x04033C9E RID: 212126
		[Token(Token = "0x4033C9E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_bannedBonds;

		// Token: 0x04033C9F RID: 212127
		[Token(Token = "0x4033C9F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_statusState;

		// Token: 0x04033CA0 RID: 212128
		[Token(Token = "0x4033CA0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_statusState;

		// Token: 0x04033CA1 RID: 212129
		[Token(Token = "0x4033CA1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_subStatusState;

		// Token: 0x04033CA2 RID: 212130
		[Token(Token = "0x4033CA2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_subStatusState;

		// Token: 0x04033CA3 RID: 212131
		[Token(Token = "0x4033CA3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_shopData;

		// Token: 0x04033CA4 RID: 212132
		[Token(Token = "0x4033CA4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_shopData;

		// Token: 0x04033CA5 RID: 212133
		[Token(Token = "0x4033CA5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_settleData;

		// Token: 0x04033CA6 RID: 212134
		[Token(Token = "0x4033CA6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_settleData;

		// Token: 0x04033CA7 RID: 212135
		[Token(Token = "0x4033CA7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_battleStatusData;

		// Token: 0x04033CA8 RID: 212136
		[Token(Token = "0x4033CA8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_battleStatusData;

		// Token: 0x04033CA9 RID: 212137
		[Token(Token = "0x4033CA9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_chessSquadData;

		// Token: 0x04033CAA RID: 212138
		[Token(Token = "0x4033CAA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_chessSquadData;

		// Token: 0x04033CAB RID: 212139
		[Token(Token = "0x4033CAB")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_selfPlayerIdx;

		// Token: 0x04033CAC RID: 212140
		[Token(Token = "0x4033CAC")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_selfPlayerIdx;

		// Token: 0x04033CAD RID: 212141
		[Token(Token = "0x4033CAD")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_viewPlayerIdx;

		// Token: 0x04033CAE RID: 212142
		[Token(Token = "0x4033CAE")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_viewPlayerIdx;

		// Token: 0x04033CAF RID: 212143
		[Token(Token = "0x4033CAF")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_realPlayerIdx;

		// Token: 0x04033CB0 RID: 212144
		[Token(Token = "0x4033CB0")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_realPlayerIdx;

		// Token: 0x04033CB1 RID: 212145
		[Token(Token = "0x4033CB1")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_curRound;

		// Token: 0x04033CB2 RID: 212146
		[Token(Token = "0x4033CB2")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_curRound;

		// Token: 0x04033CB3 RID: 212147
		[Token(Token = "0x4033CB3")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_lastStatusState;

		// Token: 0x04033CB4 RID: 212148
		[Token(Token = "0x4033CB4")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_lastStatusState;

		// Token: 0x04033CB5 RID: 212149
		[Token(Token = "0x4033CB5")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_nextStatusState;

		// Token: 0x04033CB6 RID: 212150
		[Token(Token = "0x4033CB6")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_set_nextStatusState;

		// Token: 0x04033CB7 RID: 212151
		[Token(Token = "0x4033CB7")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_serverStatusState;

		// Token: 0x04033CB8 RID: 212152
		[Token(Token = "0x4033CB8")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_serverStatusState;

		// Token: 0x04033CB9 RID: 212153
		[Token(Token = "0x4033CB9")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_effectChooseData;

		// Token: 0x04033CBA RID: 212154
		[Token(Token = "0x4033CBA")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_set_effectChooseData;

		// Token: 0x04033CBB RID: 212155
		[Token(Token = "0x4033CBB")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_playerDataModel;

		// Token: 0x04033CBC RID: 212156
		[Token(Token = "0x4033CBC")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_set_playerDataModel;

		// Token: 0x04033CBD RID: 212157
		[Token(Token = "0x4033CBD")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_isPlayerDead;

		// Token: 0x04033CBE RID: 212158
		[Token(Token = "0x4033CBE")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_set_isPlayerDead;

		// Token: 0x04033CBF RID: 212159
		[Token(Token = "0x4033CBF")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_inObMode;

		// Token: 0x04033CC0 RID: 212160
		[Token(Token = "0x4033CC0")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_set_inObMode;

		// Token: 0x04033CC1 RID: 212161
		[Token(Token = "0x4033CC1")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_hasDeadObIndex;

		// Token: 0x04033CC2 RID: 212162
		[Token(Token = "0x4033CC2")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_set_hasDeadObIndex;

		// Token: 0x04033CC3 RID: 212163
		[Token(Token = "0x4033CC3")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_isSelfReady;

		// Token: 0x04033CC4 RID: 212164
		[Token(Token = "0x4033CC4")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_set_isSelfReady;

		// Token: 0x04033CC5 RID: 212165
		[Token(Token = "0x4033CC5")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_isHandFull;

		// Token: 0x04033CC6 RID: 212166
		[Token(Token = "0x4033CC6")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_set_isHandFull;

		// Token: 0x04033CC7 RID: 212167
		[Token(Token = "0x4033CC7")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_remainAvalidChrCnt;

		// Token: 0x04033CC8 RID: 212168
		[Token(Token = "0x4033CC8")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_set_remainAvalidChrCnt;

		// Token: 0x04033CC9 RID: 212169
		[Token(Token = "0x4033CC9")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_isHandOverflow;

		// Token: 0x04033CCA RID: 212170
		[Token(Token = "0x4033CCA")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_set_isHandOverflow;

		// Token: 0x04033CCB RID: 212171
		[Token(Token = "0x4033CCB")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_lastBattleResult;

		// Token: 0x04033CCC RID: 212172
		[Token(Token = "0x4033CCC")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_set_lastBattleResult;

		// Token: 0x04033CCD RID: 212173
		[Token(Token = "0x4033CCD")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_uiStatus;

		// Token: 0x04033CCE RID: 212174
		[Token(Token = "0x4033CCE")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_set_uiStatus;

		// Token: 0x04033CCF RID: 212175
		[Token(Token = "0x4033CCF")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_shopModel;

		// Token: 0x04033CD0 RID: 212176
		[Token(Token = "0x4033CD0")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_get_effectChooseModel;

		// Token: 0x04033CD1 RID: 212177
		[Token(Token = "0x4033CD1")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_get_playerGroupModel;

		// Token: 0x04033CD2 RID: 212178
		[Token(Token = "0x4033CD2")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_get_bossRoundModel;

		// Token: 0x04033CD3 RID: 212179
		[Token(Token = "0x4033CD3")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_hudModel;

		// Token: 0x04033CD4 RID: 212180
		[Token(Token = "0x4033CD4")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_get_equipReplaceModel;

		// Token: 0x04033CD5 RID: 212181
		[Token(Token = "0x4033CD5")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_get_bottomTipsViewModel;

		// Token: 0x04033CD6 RID: 212182
		[Token(Token = "0x4033CD6")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x04033CD7 RID: 212183
		[Token(Token = "0x4033CD7")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_set_modeType;

		// Token: 0x04033CD8 RID: 212184
		[Token(Token = "0x4033CD8")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04033CD9 RID: 212185
		[Token(Token = "0x4033CD9")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033CDA RID: 212186
		[Token(Token = "0x4033CDA")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_IsEffectChooseShow;

		// Token: 0x04033CDB RID: 212187
		[Token(Token = "0x4033CDB")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_IsCountdownPanelShow;

		// Token: 0x04033CDC RID: 212188
		[Token(Token = "0x4033CDC")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_IsCountdownHintShow;

		// Token: 0x04033CDD RID: 212189
		[Token(Token = "0x4033CDD")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_GetCurrentForceEndTs;

		// Token: 0x04033CDE RID: 212190
		[Token(Token = "0x4033CDE")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_IsPrepReadyPanelShow;

		// Token: 0x04033CDF RID: 212191
		[Token(Token = "0x4033CDF")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_CheckIfNeedRoundRemainTip;

		// Token: 0x04033CE0 RID: 212192
		[Token(Token = "0x4033CE0")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_GetRoundStartCoin;

		// Token: 0x04033CE1 RID: 212193
		[Token(Token = "0x4033CE1")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_GetBattleResultStatus;

		// Token: 0x04033CE2 RID: 212194
		[Token(Token = "0x4033CE2")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_IsNeedToShowPreReadyTipGold;

		// Token: 0x04033CE3 RID: 212195
		[Token(Token = "0x4033CE3")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_IsWaitingPanelShow;

		// Token: 0x04033CE4 RID: 212196
		[Token(Token = "0x4033CE4")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__GetTotalRoundCntToFirstBoss;

		// Token: 0x04033CE5 RID: 212197
		[Token(Token = "0x4033CE5")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__GetModeType;

		// Token: 0x04033CE6 RID: 212198
		[Token(Token = "0x4033CE6")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__ApplyData;

		// Token: 0x04033CE7 RID: 212199
		[Token(Token = "0x4033CE7")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006486 RID: 25734
		[Token(Token = "0x2006486")]
		public enum AutoChessGiveUpTipType
		{
			// Token: 0x04033CE9 RID: 212201
			[Token(Token = "0x4033CE9")]
			GIVE_UP_VIOLATION,
			// Token: 0x04033CEA RID: 212202
			[Token(Token = "0x4033CEA")]
			GIVE_UP_WITH_PUNISH,
			// Token: 0x04033CEB RID: 212203
			[Token(Token = "0x4033CEB")]
			GIVE_UP_WITHOUT_PUNISH,
			// Token: 0x04033CEC RID: 212204
			[Token(Token = "0x4033CEC")]
			TEMP_LEAVE
		}
	}
}
