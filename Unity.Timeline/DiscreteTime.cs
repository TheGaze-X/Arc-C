using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	internal struct DiscreteTime : IComparable
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00003254 File Offset: 0x00001454
		[Token(Token = "0x1700009B")]
		public static double tickValue
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x58E9020", Offset = "0x58E7C20", VA = "0x1858E9020")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public DiscreteTime(DiscreteTime time)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		private DiscreteTime(long time)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x58E8FC0", Offset = "0x58E7BC0", VA = "0x1858E8FC0")]
		public DiscreteTime(double time)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x58E8ED0", Offset = "0x58E7AD0", VA = "0x1858E8ED0")]
		public DiscreteTime(float time)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x58E8F30", Offset = "0x58E7B30", VA = "0x1858E8F30")]
		public DiscreteTime(int time)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x58E8E60", Offset = "0x58E7A60", VA = "0x1858E8E60")]
		public DiscreteTime(int frame, double fps)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x58E8C60", Offset = "0x58E7860", VA = "0x1858E8C60")]
		public DiscreteTime OneTickBefore()
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00003284 File Offset: 0x00001484
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x58E8C50", Offset = "0x58E7850", VA = "0x1858E8C50")]
		public DiscreteTime OneTickAfter()
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
		public long GetTick()
		{
			return 0L;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x6000217")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static DiscreteTime FromTicks(long ticks)
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000032CC File Offset: 0x000014CC
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x58E8870", Offset = "0x58E7470", VA = "0x1858E8870", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030")]
		public bool Equals(DiscreteTime other)
		{
			return default(bool);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x58E89A0", Offset = "0x58E75A0", VA = "0x1858E89A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x58E8910", Offset = "0x58E7510", VA = "0x1858E8910")]
		private static long DoubleToDiscreteTime(double time)
		{
			return 0L;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x58E8A40", Offset = "0x58E7640", VA = "0x1858E8A40")]
		private static long FloatToDiscreteTime(float time)
		{
			return 0L;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003344 File Offset: 0x00001544
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x58E8B40", Offset = "0x58E7740", VA = "0x1858E8B40")]
		private static long IntToDiscreteTime(int time)
		{
			return 0L;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x58E8D80", Offset = "0x58E7980", VA = "0x1858E8D80")]
		private static double ToDouble(long time)
		{
			return 0.0;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x58E8DA0", Offset = "0x58E79A0", VA = "0x1858E8DA0")]
		private static float ToFloat(long time)
		{
			return 0f;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x58E90C0", Offset = "0x58E7CC0", VA = "0x1858E90C0")]
		public static explicit operator double(DiscreteTime b)
		{
			return 0.0;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000033A4 File Offset: 0x000015A4
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x58E9030", Offset = "0x58E7C30", VA = "0x1858E9030")]
		public static explicit operator float(DiscreteTime b)
		{
			return 0f;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator long(DiscreteTime b)
		{
			return 0L;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x58E9160", Offset = "0x58E7D60", VA = "0x1858E9160")]
		public static explicit operator DiscreteTime(double time)
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000033EC File Offset: 0x000015EC
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x58E9110", Offset = "0x58E7D10", VA = "0x1858E9110")]
		public static explicit operator DiscreteTime(float time)
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00003404 File Offset: 0x00001604
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x58E91B0", Offset = "0x58E7DB0", VA = "0x1858E91B0")]
		public static implicit operator DiscreteTime(int time)
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x6000226")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator DiscreteTime(long time)
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(bool);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x58E9230", Offset = "0x58E7E30", VA = "0x1858E9230")]
		public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(bool);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4D00420", Offset = "0x4CFF020", VA = "0x184D00420")]
		public static bool operator >(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(bool);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4D00450", Offset = "0x4CFF050", VA = "0x184D00450")]
		public static bool operator <(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(bool);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x4D00440", Offset = "0x4CFF040", VA = "0x184D00440")]
		public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(bool);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4D00410", Offset = "0x4CFF010", VA = "0x184D00410")]
		public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(bool);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000034C4 File Offset: 0x000016C4
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x3D28AE0", Offset = "0x3D276E0", VA = "0x183D28AE0")]
		public static DiscreteTime operator +(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(DiscreteTime);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x54E0E80", Offset = "0x54DFA80", VA = "0x1854E0E80")]
		public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(DiscreteTime);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x58E8E00", Offset = "0x58E7A00", VA = "0x1858E8E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x58E8AD0", Offset = "0x58E76D0", VA = "0x1858E8AD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x58E8BF0", Offset = "0x58E77F0", VA = "0x1858E8BF0")]
		public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x58E8B90", Offset = "0x58E7790", VA = "0x1858E8B90")]
		public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(DiscreteTime);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x58E8D10", Offset = "0x58E7910", VA = "0x1858E8D10")]
		public static double SnapToNearestTick(double time)
		{
			return 0.0;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x58E8C70", Offset = "0x58E7870", VA = "0x1858E8C70")]
		public static float SnapToNearestTick(float time)
		{
			return 0f;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000356C File Offset: 0x0000176C
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x58E8AF0", Offset = "0x58E76F0", VA = "0x1858E8AF0")]
		public static long GetNearestTick(double time)
		{
			return 0L;
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		private const double k_Tick = 1E-12;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DiscreteTime kMaxTime;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x0")]
		private readonly long m_DiscreteTime;
	}
}
