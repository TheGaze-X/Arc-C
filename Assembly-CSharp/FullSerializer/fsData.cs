using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B6E RID: 31598
	[Token(Token = "0x2007B6E")]
	public sealed class fsData
	{
		// Token: 0x0602C380 RID: 181120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C380")]
		[Address(RVA = "0x2824600", Offset = "0x2823200", VA = "0x182824600")]
		public fsData()
		{
		}

		// Token: 0x0602C381 RID: 181121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C381")]
		[Address(RVA = "0x2824590", Offset = "0x2823190", VA = "0x182824590")]
		public fsData(bool boolean)
		{
		}

		// Token: 0x0602C382 RID: 181122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C382")]
		[Address(RVA = "0x2824630", Offset = "0x2823230", VA = "0x182824630")]
		public fsData(double f)
		{
		}

		// Token: 0x0602C383 RID: 181123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C383")]
		[Address(RVA = "0x2824520", Offset = "0x2823120", VA = "0x182824520")]
		public fsData(long i)
		{
		}

		// Token: 0x0602C384 RID: 181124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C384")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public fsData(string str)
		{
		}

		// Token: 0x0602C385 RID: 181125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C385")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public fsData(Dictionary<string, fsData> dict)
		{
		}

		// Token: 0x0602C386 RID: 181126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C386")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public fsData(List<fsData> list)
		{
		}

		// Token: 0x0602C387 RID: 181127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C387")]
		[Address(RVA = "0x2823AC0", Offset = "0x28226C0", VA = "0x182823AC0")]
		public static fsData CreateDictionary()
		{
			return null;
		}

		// Token: 0x0602C388 RID: 181128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C388")]
		[Address(RVA = "0x2823D10", Offset = "0x2822910", VA = "0x182823D10")]
		public static fsData CreateList()
		{
			return null;
		}

		// Token: 0x0602C389 RID: 181129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C389")]
		[Address(RVA = "0x2823C60", Offset = "0x2822860", VA = "0x182823C60")]
		public static fsData CreateList(int capacity)
		{
			return null;
		}

		// Token: 0x0602C38A RID: 181130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C38A")]
		[Address(RVA = "0x28239B0", Offset = "0x28225B0", VA = "0x1828239B0")]
		internal void BecomeDictionary()
		{
		}

		// Token: 0x0602C38B RID: 181131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C38B")]
		[Address(RVA = "0x2823A30", Offset = "0x2822630", VA = "0x182823A30")]
		internal fsData Clone()
		{
			return null;
		}

		// Token: 0x17006793 RID: 26515
		// (get) Token: 0x0602C38C RID: 181132 RVA: 0x000DE720 File Offset: 0x000DC920
		[Token(Token = "0x17006793")]
		public fsDataType Type
		{
			[Token(Token = "0x602C38C")]
			[Address(RVA = "0x2824A90", Offset = "0x2823690", VA = "0x182824A90")]
			get
			{
				return fsDataType.Array;
			}
		}

		// Token: 0x17006794 RID: 26516
		// (get) Token: 0x0602C38D RID: 181133 RVA: 0x000DE738 File Offset: 0x000DC938
		[Token(Token = "0x17006794")]
		public bool IsNull
		{
			[Token(Token = "0x602C38D")]
			[Address(RVA = "0x2824A30", Offset = "0x2823630", VA = "0x182824A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006795 RID: 26517
		// (get) Token: 0x0602C38E RID: 181134 RVA: 0x000DE750 File Offset: 0x000DC950
		[Token(Token = "0x17006795")]
		public bool IsDouble
		{
			[Token(Token = "0x602C38E")]
			[Address(RVA = "0x2824900", Offset = "0x2823500", VA = "0x182824900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006796 RID: 26518
		// (get) Token: 0x0602C38F RID: 181135 RVA: 0x000DE768 File Offset: 0x000DC968
		[Token(Token = "0x17006796")]
		public bool IsInt64
		{
			[Token(Token = "0x602C38F")]
			[Address(RVA = "0x2824950", Offset = "0x2823550", VA = "0x182824950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006797 RID: 26519
		// (get) Token: 0x0602C390 RID: 181136 RVA: 0x000DE780 File Offset: 0x000DC980
		[Token(Token = "0x17006797")]
		public bool IsBool
		{
			[Token(Token = "0x602C390")]
			[Address(RVA = "0x2824820", Offset = "0x2823420", VA = "0x182824820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006798 RID: 26520
		// (get) Token: 0x0602C391 RID: 181137 RVA: 0x000DE798 File Offset: 0x000DC998
		[Token(Token = "0x17006798")]
		public bool IsString
		{
			[Token(Token = "0x602C391")]
			[Address(RVA = "0x2824A40", Offset = "0x2823640", VA = "0x182824A40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006799 RID: 26521
		// (get) Token: 0x0602C392 RID: 181138 RVA: 0x000DE7B0 File Offset: 0x000DC9B0
		[Token(Token = "0x17006799")]
		public bool IsDictionary
		{
			[Token(Token = "0x602C392")]
			[Address(RVA = "0x2824870", Offset = "0x2823470", VA = "0x182824870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700679A RID: 26522
		// (get) Token: 0x0602C393 RID: 181139 RVA: 0x000DE7C8 File Offset: 0x000DC9C8
		[Token(Token = "0x1700679A")]
		public bool IsList
		{
			[Token(Token = "0x602C393")]
			[Address(RVA = "0x28249A0", Offset = "0x28235A0", VA = "0x1828249A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700679B RID: 26523
		// (get) Token: 0x0602C394 RID: 181140 RVA: 0x000DE7E0 File Offset: 0x000DC9E0
		[Token(Token = "0x1700679B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public double AsDouble
		{
			[Token(Token = "0x602C394")]
			[Address(RVA = "0x2824720", Offset = "0x2823320", VA = "0x182824720")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700679C RID: 26524
		// (get) Token: 0x0602C395 RID: 181141 RVA: 0x000DE7F8 File Offset: 0x000DC9F8
		[Token(Token = "0x1700679C")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public long AsInt64
		{
			[Token(Token = "0x602C395")]
			[Address(RVA = "0x2824760", Offset = "0x2823360", VA = "0x182824760")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700679D RID: 26525
		// (get) Token: 0x0602C396 RID: 181142 RVA: 0x000DE810 File Offset: 0x000DCA10
		[Token(Token = "0x1700679D")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool AsBool
		{
			[Token(Token = "0x602C396")]
			[Address(RVA = "0x28246A0", Offset = "0x28232A0", VA = "0x1828246A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700679E RID: 26526
		// (get) Token: 0x0602C397 RID: 181143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700679E")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string AsString
		{
			[Token(Token = "0x602C397")]
			[Address(RVA = "0x28247E0", Offset = "0x28233E0", VA = "0x1828247E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700679F RID: 26527
		// (get) Token: 0x0602C398 RID: 181144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700679F")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Dictionary<string, fsData> AsDictionary
		{
			[Token(Token = "0x602C398")]
			[Address(RVA = "0x28246E0", Offset = "0x28232E0", VA = "0x1828246E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067A0 RID: 26528
		// (get) Token: 0x0602C399 RID: 181145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067A0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public List<fsData> AsList
		{
			[Token(Token = "0x602C399")]
			[Address(RVA = "0x28247A0", Offset = "0x28233A0", VA = "0x1828247A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C39A RID: 181146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C39A")]
		private T Cast<T>()
		{
			return null;
		}

		// Token: 0x0602C39B RID: 181147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C39B")]
		[Address(RVA = "0x2824360", Offset = "0x2822F60", VA = "0x182824360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0602C39C RID: 181148 RVA: 0x000DE828 File Offset: 0x000DCA28
		[Token(Token = "0x602C39C")]
		[Address(RVA = "0x28242B0", Offset = "0x2822EB0", VA = "0x1828242B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0602C39D RID: 181149 RVA: 0x000DE840 File Offset: 0x000DCA40
		[Token(Token = "0x602C39D")]
		[Address(RVA = "0x2823DC0", Offset = "0x28229C0", VA = "0x182823DC0")]
		public bool Equals(fsData other)
		{
			return default(bool);
		}

		// Token: 0x0602C39E RID: 181150 RVA: 0x000DE858 File Offset: 0x000DCA58
		[Token(Token = "0x602C39E")]
		[Address(RVA = "0x2824C20", Offset = "0x2823820", VA = "0x182824C20")]
		public static bool operator ==(fsData a, fsData b)
		{
			return default(bool);
		}

		// Token: 0x0602C39F RID: 181151 RVA: 0x000DE870 File Offset: 0x000DCA70
		[Token(Token = "0x602C39F")]
		[Address(RVA = "0x2824D20", Offset = "0x2823920", VA = "0x182824D20")]
		public static bool operator !=(fsData a, fsData b)
		{
			return default(bool);
		}

		// Token: 0x0602C3A0 RID: 181152 RVA: 0x000DE888 File Offset: 0x000DCA88
		[Token(Token = "0x602C3A0")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040401A3 RID: 262563
		[Token(Token = "0x40401A3")]
		[FieldOffset(Offset = "0x10")]
		private object _value;

		// Token: 0x040401A4 RID: 262564
		[Token(Token = "0x40401A4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly fsData True;

		// Token: 0x040401A5 RID: 262565
		[Token(Token = "0x40401A5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly fsData False;

		// Token: 0x040401A6 RID: 262566
		[Token(Token = "0x40401A6")]
		[FieldOffset(Offset = "0x10")]
		public static readonly fsData Null;
	}
}
