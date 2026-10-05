using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	public class AtlasMaxRect
	{
		// Token: 0x0600044C RID: 1100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x54219B0", Offset = "0x54205B0", VA = "0x1854219B0")]
		public AtlasMaxRect(int width, int height)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x17000089")]
		public bool empty
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x24EB330", Offset = "0x24E9F30", VA = "0x1824EB330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x1700008A")]
		public int maxFreeRectWidth
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x1700008B")]
		public int maxFreeRectHeight
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x541DFE0", Offset = "0x541CBE0", VA = "0x18541DFE0")]
		public RectInt InsertRect(int width, int height)
		{
			return default(RectInt);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x541DEF0", Offset = "0x541CAF0", VA = "0x18541DEF0")]
		public RectInt InsertRectBestShortSideFit(int width, int height)
		{
			return default(RectInt);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x541DF70", Offset = "0x541CB70", VA = "0x18541DF70")]
		public RectInt InsertRectContactPoint(int width, int height)
		{
			return default(RectInt);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x541DE70", Offset = "0x541CA70", VA = "0x18541DE70")]
		public RectInt InsertRectBestLongSideFit(int width, int height)
		{
			return default(RectInt);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x541DDF0", Offset = "0x541C9F0", VA = "0x18541DDF0")]
		public RectInt InsertRectBestAreaFit(int width, int height)
		{
			return default(RectInt);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x541E2B0", Offset = "0x541CEB0", VA = "0x18541E2B0")]
		public void InsertRects(List<RectInt> rects, List<RectInt> dst, AtlasMaxRect.FreeRectChoiceHeuristic method)
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x541E540", Offset = "0x541D140", VA = "0x18541E540")]
		public void RemoveRect(RectInt rect)
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x541D9E0", Offset = "0x541C5E0", VA = "0x18541D9E0")]
		public void FreeRects(List<RectInt> rects)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x541E820", Offset = "0x541D420", VA = "0x18541E820")]
		public void Reset()
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x5420DC0", Offset = "0x541F9C0", VA = "0x185420DC0")]
		private void _PlaceRect(RectInt node)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x54213B0", Offset = "0x541FFB0", VA = "0x1854213B0")]
		private RectInt _ScoreRect(int width, int height, AtlasMaxRect.FreeRectChoiceHeuristic method, out int score1, out int score2)
		{
			return default(RectInt);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x54214F0", Offset = "0x54200F0", VA = "0x1854214F0")]
		private bool _SplitFreeNode(RectInt freeNode, RectInt usedNode)
		{
			return default(bool);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x541FC20", Offset = "0x541E820", VA = "0x18541FC20")]
		private void _InsertNewFreeRectangle(RectInt newFreeRect, ref int newFreeRectanglesLastSize)
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x5420FB0", Offset = "0x541FBB0", VA = "0x185420FB0")]
		private void _PruneFreeList()
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x54212A0", Offset = "0x541FEA0", VA = "0x1854212A0")]
		private void _RecalculateMaxFreeRectWidthHeight()
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x54207A0", Offset = "0x541F3A0", VA = "0x1854207A0")]
		private void _PlaceFreeRect(RectInt node)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x541E9E0", Offset = "0x541D5E0", VA = "0x18541E9E0")]
		private void _AlignRectWidth(ref RectInt src, RectInt dst)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x541E960", Offset = "0x541D560", VA = "0x18541E960")]
		private void _AlignRectHeight(ref RectInt src, RectInt dst)
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x5420040", Offset = "0x541EC40", VA = "0x185420040")]
		private void _MergeFreeRect(ref RectInt r)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x541FF50", Offset = "0x541EB50", VA = "0x18541FF50")]
		private bool _IsContainedIn(RectInt a, RectInt b)
		{
			return default(bool);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x541EA60", Offset = "0x541D660", VA = "0x18541EA60")]
		private int _CommonIntervalCount(int i1Start, int i1End, int i2Start, int i2End)
		{
			return 0;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x541EA90", Offset = "0x541D690", VA = "0x18541EA90")]
		private int _ContactPointScoreNode(int x, int y, int width, int height)
		{
			return 0;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x541F420", Offset = "0x541E020", VA = "0x18541F420")]
		private RectInt _FindPositionForNewNodeBestShortSideFit(int width, int height, out int bestShortSideFit, out int bestLongSideFit)
		{
			return default(RectInt);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x541F6E0", Offset = "0x541E2E0", VA = "0x18541F6E0")]
		private RectInt _FindPositionForNewNodeBottomLeft(int width, int height, out int bestY, out int bestX)
		{
			return default(RectInt);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x541F9A0", Offset = "0x541E5A0", VA = "0x18541F9A0")]
		private RectInt _FindPositionForNewNodeContactPoint(int width, int height, out int bestContactScore)
		{
			return default(RectInt);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x541F160", Offset = "0x541DD60", VA = "0x18541F160")]
		private RectInt _FindPositionForNewNodeBestLongSideFit(int width, int height, out int bestShortSideFit, out int bestLongSideFit)
		{
			return default(RectInt);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x541EE10", Offset = "0x541DA10", VA = "0x18541EE10")]
		private RectInt _FindPositionForNewNodeBestAreaFit(int width, int height, out int bestAreaFit, out int bestShortSideFit)
		{
			return default(RectInt);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x54219A0", Offset = "0x54205A0", VA = "0x1854219A0")]
		private static long _Tuple(int x, int y)
		{
			return 0L;
		}

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x10")]
		private readonly int m_binWidth;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x14")]
		private readonly int m_binHeight;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<RectInt> m_newFreeRectangles;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<RectInt> m_freeRectangles;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<long, RectInt> m_usedRectangles;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x30")]
		private int m_usedRectSize;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x34")]
		private int m_maxFreeRectWidth;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x38")]
		private int m_maxFreeRectHeight;

		// Token: 0x020000FC RID: 252
		[Token(Token = "0x20000FC")]
		public enum FreeRectChoiceHeuristic
		{
			// Token: 0x040005CB RID: 1483
			[Token(Token = "0x40005CB")]
			RectBestShortSideFit,
			// Token: 0x040005CC RID: 1484
			[Token(Token = "0x40005CC")]
			RectBestLongSideFit,
			// Token: 0x040005CD RID: 1485
			[Token(Token = "0x40005CD")]
			RectBestAreaFit,
			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			RectBottomLeftRule,
			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			RectContactPointRule
		}
	}
}
