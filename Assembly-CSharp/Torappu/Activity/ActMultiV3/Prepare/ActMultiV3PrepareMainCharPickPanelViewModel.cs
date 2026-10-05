using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using Torappu.Multiplayer.Servers;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007053 RID: 28755
	[Token(Token = "0x2007053")]
	public class ActMultiV3PrepareMainCharPickPanelViewModel : IHotfixable
	{
		// Token: 0x1700607E RID: 24702
		// (get) Token: 0x06028D41 RID: 167233 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028D42 RID: 167234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700607E")]
		public string activityId
		{
			[Token(Token = "0x6028D41")]
			[Address(RVA = "0x2435E80", Offset = "0x2434A80", VA = "0x182435E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028D42")]
			[Address(RVA = "0x24362A0", Offset = "0x2434EA0", VA = "0x1824362A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700607F RID: 24703
		// (get) Token: 0x06028D43 RID: 167235 RVA: 0x000D3260 File Offset: 0x000D1460
		// (set) Token: 0x06028D44 RID: 167236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700607F")]
		public bool reverse
		{
			[Token(Token = "0x6028D43")]
			[Address(RVA = "0x2436180", Offset = "0x2434D80", VA = "0x182436180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028D44")]
			[Address(RVA = "0x2436650", Offset = "0x2435250", VA = "0x182436650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006080 RID: 24704
		// (get) Token: 0x06028D45 RID: 167237 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028D46 RID: 167238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006080")]
		public List<ActMultiV3PrepareMainCharCardModel> remainCharList
		{
			[Token(Token = "0x6028D45")]
			[Address(RVA = "0x2436120", Offset = "0x2434D20", VA = "0x182436120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028D46")]
			[Address(RVA = "0x24365D0", Offset = "0x24351D0", VA = "0x1824365D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006081 RID: 24705
		// (get) Token: 0x06028D47 RID: 167239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028D48 RID: 167240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006081")]
		public List<ActMultiV3PrepareMainCharCardModel> gotCharList
		{
			[Token(Token = "0x6028D47")]
			[Address(RVA = "0x2435F40", Offset = "0x2434B40", VA = "0x182435F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028D48")]
			[Address(RVA = "0x2436390", Offset = "0x2434F90", VA = "0x182436390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006082 RID: 24706
		// (get) Token: 0x06028D49 RID: 167241 RVA: 0x000D3278 File Offset: 0x000D1478
		// (set) Token: 0x06028D4A RID: 167242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006082")]
		public bool noNeedPick
		{
			[Token(Token = "0x6028D49")]
			[Address(RVA = "0x2436000", Offset = "0x2434C00", VA = "0x182436000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028D4A")]
			[Address(RVA = "0x2436480", Offset = "0x2435080", VA = "0x182436480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006083 RID: 24707
		// (get) Token: 0x06028D4B RID: 167243 RVA: 0x000D3290 File Offset: 0x000D1490
		// (set) Token: 0x06028D4C RID: 167244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006083")]
		public bool myTurn
		{
			[Token(Token = "0x6028D4B")]
			[Address(RVA = "0x2435FA0", Offset = "0x2434BA0", VA = "0x182435FA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028D4C")]
			[Address(RVA = "0x2436410", Offset = "0x2435010", VA = "0x182436410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006084 RID: 24708
		// (get) Token: 0x06028D4D RID: 167245 RVA: 0x000D32A8 File Offset: 0x000D14A8
		// (set) Token: 0x06028D4E RID: 167246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006084")]
		public bool turnFromSkip
		{
			[Token(Token = "0x6028D4D")]
			[Address(RVA = "0x2436240", Offset = "0x2434E40", VA = "0x182436240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028D4E")]
			[Address(RVA = "0x2436730", Offset = "0x2435330", VA = "0x182436730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006085 RID: 24709
		// (get) Token: 0x06028D4F RID: 167247 RVA: 0x000D32C0 File Offset: 0x000D14C0
		// (set) Token: 0x06028D50 RID: 167248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006085")]
		public bool canSkip
		{
			[Token(Token = "0x6028D4F")]
			[Address(RVA = "0x2435EE0", Offset = "0x2434AE0", VA = "0x182435EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028D50")]
			[Address(RVA = "0x2436320", Offset = "0x2434F20", VA = "0x182436320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006086 RID: 24710
		// (get) Token: 0x06028D51 RID: 167249 RVA: 0x000D32D8 File Offset: 0x000D14D8
		// (set) Token: 0x06028D52 RID: 167250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006086")]
		public int pickCnt
		{
			[Token(Token = "0x6028D51")]
			[Address(RVA = "0x2436060", Offset = "0x2434C60", VA = "0x182436060")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028D52")]
			[Address(RVA = "0x24364F0", Offset = "0x24350F0", VA = "0x1824364F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006087 RID: 24711
		// (get) Token: 0x06028D53 RID: 167251 RVA: 0x000D32F0 File Offset: 0x000D14F0
		// (set) Token: 0x06028D54 RID: 167252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006087")]
		public int pickMax
		{
			[Token(Token = "0x6028D53")]
			[Address(RVA = "0x24360C0", Offset = "0x2434CC0", VA = "0x1824360C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028D54")]
			[Address(RVA = "0x2436560", Offset = "0x2435160", VA = "0x182436560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006088 RID: 24712
		// (get) Token: 0x06028D55 RID: 167253 RVA: 0x000D3308 File Offset: 0x000D1508
		// (set) Token: 0x06028D56 RID: 167254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006088")]
		public bool showReserveList
		{
			[Token(Token = "0x6028D55")]
			[Address(RVA = "0x24361E0", Offset = "0x2434DE0", VA = "0x1824361E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028D56")]
			[Address(RVA = "0x24366C0", Offset = "0x24352C0", VA = "0x1824366C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028D57 RID: 167255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D57")]
		[Address(RVA = "0x24345D0", Offset = "0x24331D0", VA = "0x1824345D0")]
		public void LoadStableData(string actId)
		{
		}

		// Token: 0x06028D58 RID: 167256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D58")]
		[Address(RVA = "0x2434800", Offset = "0x2433400", VA = "0x182434800")]
		public void Update()
		{
		}

		// Token: 0x06028D59 RID: 167257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D59")]
		[Address(RVA = "0x2434680", Offset = "0x2433280", VA = "0x182434680")]
		public void Reset()
		{
		}

		// Token: 0x06028D5A RID: 167258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D5A")]
		[Address(RVA = "0x2435970", Offset = "0x2434570", VA = "0x182435970")]
		private void _UpdateGotList(TeamInfo teaminfo)
		{
		}

		// Token: 0x06028D5B RID: 167259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D5B")]
		[Address(RVA = "0x2435770", Offset = "0x2434370", VA = "0x182435770")]
		private ActMultiV3PrepareMainCharCardModel _FindOrLoadChar(string charId)
		{
			return null;
		}

		// Token: 0x06028D5C RID: 167260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D5C")]
		[Address(RVA = "0x2435270", Offset = "0x2433E70", VA = "0x182435270")]
		private void _CacheAllDuplicateChar(TeamProtocol.STTurnPickStatus turnPick)
		{
		}

		// Token: 0x06028D5D RID: 167261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D5D")]
		[Address(RVA = "0x2434350", Offset = "0x2432F50", VA = "0x182434350")]
		public static ActMultiV3PrepareMainCharCardModel LoadCharCardViewModelFromPrefer(string charId)
		{
			return null;
		}

		// Token: 0x06028D5E RID: 167262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D5E")]
		[Address(RVA = "0x2435630", Offset = "0x2434230", VA = "0x182435630")]
		private static TeamProtocol.STBasicChar _FindCharFromSquadWithCharId(List<TeamProtocol.STBasicChar> squad, string charId)
		{
			return null;
		}

		// Token: 0x06028D5F RID: 167263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D5F")]
		[Address(RVA = "0x24341E0", Offset = "0x2432DE0", VA = "0x1824341E0")]
		public ActMultiV3PrepareMainCharCardModel FindChar(int instId)
		{
			return null;
		}

		// Token: 0x06028D60 RID: 167264 RVA: 0x000D3320 File Offset: 0x000D1520
		[Token(Token = "0x6028D60")]
		[Address(RVA = "0x24346E0", Offset = "0x24332E0", VA = "0x1824346E0")]
		public bool SetReserveList(bool v)
		{
			return default(bool);
		}

		// Token: 0x06028D61 RID: 167265 RVA: 0x000D3338 File Offset: 0x000D1538
		[Token(Token = "0x6028D61")]
		[Address(RVA = "0x2435480", Offset = "0x2434080", VA = "0x182435480")]
		private int _CompareChar(ActMultiV3PrepareMainCharCardModel a, ActMultiV3PrepareMainCharCardModel b)
		{
			return 0;
		}

		// Token: 0x06028D62 RID: 167266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D62")]
		[Address(RVA = "0x2435E20", Offset = "0x2434A20", VA = "0x182435E20")]
		public ActMultiV3PrepareMainCharPickPanelViewModel()
		{
		}

		// Token: 0x0403A3C3 RID: 238531
		[Token(Token = "0x403A3C3")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, ActMultiV3PrepareMainCharCardModel> m_allDumpChar;

		// Token: 0x0403A3C4 RID: 238532
		[Token(Token = "0x403A3C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403A3C5 RID: 238533
		[Token(Token = "0x403A3C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x0403A3C6 RID: 238534
		[Token(Token = "0x403A3C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_reverse;

		// Token: 0x0403A3C7 RID: 238535
		[Token(Token = "0x403A3C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_reverse;

		// Token: 0x0403A3C8 RID: 238536
		[Token(Token = "0x403A3C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_remainCharList;

		// Token: 0x0403A3C9 RID: 238537
		[Token(Token = "0x403A3C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_remainCharList;

		// Token: 0x0403A3CA RID: 238538
		[Token(Token = "0x403A3CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_gotCharList;

		// Token: 0x0403A3CB RID: 238539
		[Token(Token = "0x403A3CB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_gotCharList;

		// Token: 0x0403A3CC RID: 238540
		[Token(Token = "0x403A3CC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_noNeedPick;

		// Token: 0x0403A3CD RID: 238541
		[Token(Token = "0x403A3CD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_noNeedPick;

		// Token: 0x0403A3CE RID: 238542
		[Token(Token = "0x403A3CE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_myTurn;

		// Token: 0x0403A3CF RID: 238543
		[Token(Token = "0x403A3CF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_myTurn;

		// Token: 0x0403A3D0 RID: 238544
		[Token(Token = "0x403A3D0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_turnFromSkip;

		// Token: 0x0403A3D1 RID: 238545
		[Token(Token = "0x403A3D1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_turnFromSkip;

		// Token: 0x0403A3D2 RID: 238546
		[Token(Token = "0x403A3D2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_canSkip;

		// Token: 0x0403A3D3 RID: 238547
		[Token(Token = "0x403A3D3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_canSkip;

		// Token: 0x0403A3D4 RID: 238548
		[Token(Token = "0x403A3D4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_pickCnt;

		// Token: 0x0403A3D5 RID: 238549
		[Token(Token = "0x403A3D5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_pickCnt;

		// Token: 0x0403A3D6 RID: 238550
		[Token(Token = "0x403A3D6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_pickMax;

		// Token: 0x0403A3D7 RID: 238551
		[Token(Token = "0x403A3D7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_pickMax;

		// Token: 0x0403A3D8 RID: 238552
		[Token(Token = "0x403A3D8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_showReserveList;

		// Token: 0x0403A3D9 RID: 238553
		[Token(Token = "0x403A3D9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_showReserveList;

		// Token: 0x0403A3DA RID: 238554
		[Token(Token = "0x403A3DA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadStableData;

		// Token: 0x0403A3DB RID: 238555
		[Token(Token = "0x403A3DB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403A3DC RID: 238556
		[Token(Token = "0x403A3DC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0403A3DD RID: 238557
		[Token(Token = "0x403A3DD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UpdateGotList;

		// Token: 0x0403A3DE RID: 238558
		[Token(Token = "0x403A3DE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__FindOrLoadChar;

		// Token: 0x0403A3DF RID: 238559
		[Token(Token = "0x403A3DF")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CacheAllDuplicateChar;

		// Token: 0x0403A3E0 RID: 238560
		[Token(Token = "0x403A3E0")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_LoadCharCardViewModelFromPrefer;

		// Token: 0x0403A3E1 RID: 238561
		[Token(Token = "0x403A3E1")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__FindCharFromSquadWithCharId;

		// Token: 0x0403A3E2 RID: 238562
		[Token(Token = "0x403A3E2")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_FindChar;

		// Token: 0x0403A3E3 RID: 238563
		[Token(Token = "0x403A3E3")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SetReserveList;

		// Token: 0x0403A3E4 RID: 238564
		[Token(Token = "0x403A3E4")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CompareChar;

		// Token: 0x0403A3E5 RID: 238565
		[Token(Token = "0x403A3E5")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
