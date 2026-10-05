using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002705 RID: 9989
	[Token(Token = "0x2002705")]
	public class AutoChessBroadcastParser
	{
		// Token: 0x06010436 RID: 66614 RVA: 0x00063630 File Offset: 0x00061830
		[Token(Token = "0x6010436")]
		[Address(RVA = "0x7F6E20", Offset = "0x7F5A20", VA = "0x1807F6E20")]
		public AutoChessBroadcastMsg ParseMsg(AutoChessBroadcast broadcast)
		{
			return default(AutoChessBroadcastMsg);
		}

		// Token: 0x06010437 RID: 66615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010437")]
		[Address(RVA = "0x7F69B0", Offset = "0x7F55B0", VA = "0x1807F69B0")]
		public void CheckShopLevel(int playerIndex, int newShopLevel)
		{
		}

		// Token: 0x06010438 RID: 66616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010438")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void CheckBossHit(int playerIndex, float hitPercent)
		{
		}

		// Token: 0x06010439 RID: 66617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010439")]
		[Address(RVA = "0x7F7230", Offset = "0x7F5E30", VA = "0x1807F7230")]
		private AutoChessBroadcastParser.ParserBase _GetParser(AutoChessBroadcastType bcType)
		{
			return null;
		}

		// Token: 0x0601043A RID: 66618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601043A")]
		[Address(RVA = "0x7F7060", Offset = "0x7F5C60", VA = "0x1807F7060")]
		private static AutoChessBroadcastParser.ParserBase _CreateParser(AutoChessBroadcastType bct)
		{
			return null;
		}

		// Token: 0x0601043B RID: 66619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601043B")]
		[Address(RVA = "0x7F7420", Offset = "0x7F6020", VA = "0x1807F7420")]
		private static IEnumerable<AutoChessData.AutoChessBroadcastData> _TravaseBroadcast(AutoChessBroadcastType bctype)
		{
			return null;
		}

		// Token: 0x0601043C RID: 66620 RVA: 0x00063648 File Offset: 0x00061848
		[Token(Token = "0x601043C")]
		[Address(RVA = "0x7F7490", Offset = "0x7F6090", VA = "0x1807F7490")]
		private static bool _TryGetBroadcastData(string id, out AutoChessData.AutoChessBroadcastData bcData)
		{
			return default(bool);
		}

		// Token: 0x0601043D RID: 66621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601043D")]
		[Address(RVA = "0x7F71D0", Offset = "0x7F5DD0", VA = "0x1807F71D0")]
		private static List<AutoChessData.AutoChessBroadcastData> _GetBroadcastDataList()
		{
			return null;
		}

		// Token: 0x0601043E RID: 66622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601043E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessBroadcastParser()
		{
		}

		// Token: 0x040122C7 RID: 74439
		[Token(Token = "0x40122C7")]
		[FieldOffset(Offset = "0x10")]
		private EnumIntDictionary<AutoChessBroadcastType, AutoChessBroadcastParser.ParserBase> m_parsers;

		// Token: 0x02002706 RID: 9990
		[Token(Token = "0x2002706")]
		private abstract class ParserBase
		{
			// Token: 0x1700238A RID: 9098
			// (get) Token: 0x0601043F RID: 66623 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06010440 RID: 66624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700238A")]
			public AutoChessData.AutoChessBroadcastData data
			{
				[Token(Token = "0x601043F")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6010440")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06010441 RID: 66625 RVA: 0x00063660 File Offset: 0x00061860
			[Token(Token = "0x6010441")]
			[Address(RVA = "0x80A390", Offset = "0x808F90", VA = "0x18080A390")]
			public bool Reset(AutoChessData.AutoChessBroadcastData newData)
			{
				return default(bool);
			}

			// Token: 0x1700238B RID: 9099
			// (get) Token: 0x06010442 RID: 66626
			[Token(Token = "0x1700238B")]
			public abstract AutoChessBroadcastType type { [Token(Token = "0x6010442")] get; }

			// Token: 0x06010443 RID: 66627
			[Token(Token = "0x6010443")]
			protected abstract bool OnReset();

			// Token: 0x06010444 RID: 66628
			[Token(Token = "0x6010444")]
			public abstract string ParseMsg(string playerName, AutoChessBroadcast broadcast);

			// Token: 0x06010445 RID: 66629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010445")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected ParserBase()
			{
			}
		}

		// Token: 0x02002707 RID: 9991
		[Token(Token = "0x2002707")]
		private class GoldenChar : AutoChessBroadcastParser.ParserBase
		{
			// Token: 0x1700238C RID: 9100
			// (get) Token: 0x06010446 RID: 66630 RVA: 0x00063678 File Offset: 0x00061878
			[Token(Token = "0x1700238C")]
			public override AutoChessBroadcastType type
			{
				[Token(Token = "0x6010446")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
				get
				{
					return AutoChessBroadcastType.NONE;
				}
			}

			// Token: 0x06010447 RID: 66631 RVA: 0x00063690 File Offset: 0x00061890
			[Token(Token = "0x6010447")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
			protected override bool OnReset()
			{
				return default(bool);
			}

			// Token: 0x06010448 RID: 66632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010448")]
			[Address(RVA = "0x807CF0", Offset = "0x8068F0", VA = "0x180807CF0", Slot = "6")]
			public override string ParseMsg(string playerName, AutoChessBroadcast broadcast)
			{
				return null;
			}

			// Token: 0x06010449 RID: 66633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010449")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GoldenChar()
			{
			}
		}

		// Token: 0x02002708 RID: 9992
		[Token(Token = "0x2002708")]
		private class CharGift : AutoChessBroadcastParser.ParserBase
		{
			// Token: 0x1700238D RID: 9101
			// (get) Token: 0x0601044A RID: 66634 RVA: 0x000636A8 File Offset: 0x000618A8
			[Token(Token = "0x1700238D")]
			public override AutoChessBroadcastType type
			{
				[Token(Token = "0x601044A")]
				[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "4")]
				get
				{
					return AutoChessBroadcastType.NONE;
				}
			}

			// Token: 0x0601044B RID: 66635 RVA: 0x000636C0 File Offset: 0x000618C0
			[Token(Token = "0x601044B")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
			protected override bool OnReset()
			{
				return default(bool);
			}

			// Token: 0x0601044C RID: 66636 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601044C")]
			[Address(RVA = "0x803920", Offset = "0x802520", VA = "0x180803920", Slot = "6")]
			public override string ParseMsg(string playerName, AutoChessBroadcast broadcast)
			{
				return null;
			}

			// Token: 0x0601044D RID: 66637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601044D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharGift()
			{
			}
		}

		// Token: 0x02002709 RID: 9993
		[Token(Token = "0x2002709")]
		private class ShopLevel : AutoChessBroadcastParser.ParserBase
		{
			// Token: 0x1700238E RID: 9102
			// (get) Token: 0x0601044E RID: 66638 RVA: 0x000636D8 File Offset: 0x000618D8
			[Token(Token = "0x1700238E")]
			public override AutoChessBroadcastType type
			{
				[Token(Token = "0x601044E")]
				[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
				get
				{
					return AutoChessBroadcastType.NONE;
				}
			}

			// Token: 0x1700238F RID: 9103
			// (get) Token: 0x0601044F RID: 66639 RVA: 0x000636F0 File Offset: 0x000618F0
			// (set) Token: 0x06010450 RID: 66640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700238F")]
			public int shopLevel
			{
				[Token(Token = "0x601044F")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6010450")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06010451 RID: 66641 RVA: 0x00063708 File Offset: 0x00061908
			[Token(Token = "0x6010451")]
			[Address(RVA = "0x80B4D0", Offset = "0x80A0D0", VA = "0x18080B4D0", Slot = "5")]
			protected override bool OnReset()
			{
				return default(bool);
			}

			// Token: 0x06010452 RID: 66642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010452")]
			[Address(RVA = "0x80B550", Offset = "0x80A150", VA = "0x18080B550", Slot = "6")]
			public override string ParseMsg(string playerName, AutoChessBroadcast broadcast)
			{
				return null;
			}

			// Token: 0x06010453 RID: 66643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010453")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopLevel()
			{
			}
		}

		// Token: 0x0200270A RID: 9994
		[Token(Token = "0x200270A")]
		private class BossHit : AutoChessBroadcastParser.ParserBase
		{
			// Token: 0x17002390 RID: 9104
			// (get) Token: 0x06010454 RID: 66644 RVA: 0x00063720 File Offset: 0x00061920
			[Token(Token = "0x17002390")]
			public override AutoChessBroadcastType type
			{
				[Token(Token = "0x6010454")]
				[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
				get
				{
					return AutoChessBroadcastType.NONE;
				}
			}

			// Token: 0x17002391 RID: 9105
			// (get) Token: 0x06010455 RID: 66645 RVA: 0x00063738 File Offset: 0x00061938
			// (set) Token: 0x06010456 RID: 66646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002391")]
			public float percent
			{
				[Token(Token = "0x6010455")]
				[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6010456")]
				[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06010457 RID: 66647 RVA: 0x00063750 File Offset: 0x00061950
			[Token(Token = "0x6010457")]
			[Address(RVA = "0x803670", Offset = "0x802270", VA = "0x180803670", Slot = "5")]
			protected override bool OnReset()
			{
				return default(bool);
			}

			// Token: 0x06010458 RID: 66648 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010458")]
			[Address(RVA = "0x803700", Offset = "0x802300", VA = "0x180803700", Slot = "6")]
			public override string ParseMsg(string playerName, AutoChessBroadcast broadcast)
			{
				return null;
			}

			// Token: 0x06010459 RID: 66649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010459")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BossHit()
			{
			}
		}

		// Token: 0x0200270B RID: 9995
		[Token(Token = "0x200270B")]
		private class BondEffect : AutoChessBroadcastParser.ParserBase
		{
			// Token: 0x17002392 RID: 9106
			// (get) Token: 0x0601045A RID: 66650 RVA: 0x00063768 File Offset: 0x00061968
			[Token(Token = "0x17002392")]
			public override AutoChessBroadcastType type
			{
				[Token(Token = "0x601045A")]
				[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "4")]
				get
				{
					return AutoChessBroadcastType.NONE;
				}
			}

			// Token: 0x0601045B RID: 66651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601045B")]
			[Address(RVA = "0x8033D0", Offset = "0x801FD0", VA = "0x1808033D0", Slot = "6")]
			public override string ParseMsg(string playerName, AutoChessBroadcast broadcast)
			{
				return null;
			}

			// Token: 0x0601045C RID: 66652 RVA: 0x00063780 File Offset: 0x00061980
			[Token(Token = "0x601045C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
			protected override bool OnReset()
			{
				return default(bool);
			}

			// Token: 0x0601045D RID: 66653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601045D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BondEffect()
			{
			}
		}
	}
}
