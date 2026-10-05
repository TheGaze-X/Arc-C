using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066D7 RID: 26327
	[Token(Token = "0x20066D7")]
	[Serializable]
	public class HandBookV2GroupPosData
	{
		// Token: 0x06025C94 RID: 154772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C94")]
		[Address(RVA = "0x20C2070", Offset = "0x20C0C70", VA = "0x1820C2070")]
		public HandBookV2GroupPosData()
		{
		}

		// Token: 0x04035203 RID: 217603
		[Token(Token = "0x4035203")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04035204 RID: 217604
		[Token(Token = "0x4035204")]
		[FieldOffset(Offset = "0x18")]
		public List<HandBookV2GroupPosData.ForceData> forceDataList;

		// Token: 0x04035205 RID: 217605
		[Token(Token = "0x4035205")]
		[FieldOffset(Offset = "0x20")]
		public List<HandBookV2GroupPosData.CharData> charList;

		// Token: 0x04035206 RID: 217606
		[Token(Token = "0x4035206")]
		[FieldOffset(Offset = "0x28")]
		public List<HandBookV2GroupPosData.LineData> lineList;

		// Token: 0x04035207 RID: 217607
		[Token(Token = "0x4035207")]
		[FieldOffset(Offset = "0x30")]
		public float minScale;

		// Token: 0x04035208 RID: 217608
		[Token(Token = "0x4035208")]
		[FieldOffset(Offset = "0x34")]
		public float maxScale;

		// Token: 0x020066D8 RID: 26328
		[Token(Token = "0x20066D8")]
		[Serializable]
		public class CharData
		{
			// Token: 0x06025C95 RID: 154773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C95")]
			[Address(RVA = "0x20B6EB0", Offset = "0x20B5AB0", VA = "0x1820B6EB0")]
			public CharData()
			{
			}

			// Token: 0x04035209 RID: 217609
			[Token(Token = "0x4035209")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0403520A RID: 217610
			[Token(Token = "0x403520A")]
			[FieldOffset(Offset = "0x18")]
			public float scale;

			// Token: 0x0403520B RID: 217611
			[Token(Token = "0x403520B")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 pos;

			// Token: 0x0403520C RID: 217612
			[Token(Token = "0x403520C")]
			[FieldOffset(Offset = "0x28")]
			public List<HandBookV2GroupPosData.Connection> connectionList;

			// Token: 0x0403520D RID: 217613
			[Token(Token = "0x403520D")]
			[FieldOffset(Offset = "0x30")]
			public bool haveOutLine;
		}

		// Token: 0x020066D9 RID: 26329
		[Token(Token = "0x20066D9")]
		[Serializable]
		public class Connection
		{
			// Token: 0x06025C96 RID: 154774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C96")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Connection()
			{
			}

			// Token: 0x0403520E RID: 217614
			[Token(Token = "0x403520E")]
			[FieldOffset(Offset = "0x10")]
			public HexagonDirection direction;

			// Token: 0x0403520F RID: 217615
			[Token(Token = "0x403520F")]
			[FieldOffset(Offset = "0x18")]
			public string charId;

			// Token: 0x04035210 RID: 217616
			[Token(Token = "0x4035210")]
			[FieldOffset(Offset = "0x20")]
			public string forceId;
		}

		// Token: 0x020066DA RID: 26330
		[Token(Token = "0x20066DA")]
		[Serializable]
		public class ColoringBlockData
		{
			// Token: 0x06025C97 RID: 154775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C97")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ColoringBlockData()
			{
			}

			// Token: 0x04035211 RID: 217617
			[Token(Token = "0x4035211")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04035212 RID: 217618
			[Token(Token = "0x4035212")]
			[FieldOffset(Offset = "0x18")]
			public string forceId;

			// Token: 0x04035213 RID: 217619
			[Token(Token = "0x4035213")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 pos;

			// Token: 0x04035214 RID: 217620
			[Token(Token = "0x4035214")]
			[FieldOffset(Offset = "0x28")]
			public string color;

			// Token: 0x04035215 RID: 217621
			[Token(Token = "0x4035215")]
			[FieldOffset(Offset = "0x30")]
			public List<HandBookV2GroupPosData.Connection> connectionList;
		}

		// Token: 0x020066DB RID: 26331
		[Token(Token = "0x20066DB")]
		[Serializable]
		public class ForceData
		{
			// Token: 0x06025C98 RID: 154776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C98")]
			[Address(RVA = "0x20B6ED0", Offset = "0x20B5AD0", VA = "0x1820B6ED0")]
			public ForceData()
			{
			}

			// Token: 0x04035216 RID: 217622
			[Token(Token = "0x4035216")]
			[FieldOffset(Offset = "0x10")]
			public string color;

			// Token: 0x04035217 RID: 217623
			[Token(Token = "0x4035217")]
			[FieldOffset(Offset = "0x18")]
			public List<string> charList;

			// Token: 0x04035218 RID: 217624
			[Token(Token = "0x4035218")]
			[FieldOffset(Offset = "0x20")]
			public string forceId;

			// Token: 0x04035219 RID: 217625
			[Token(Token = "0x4035219")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 pos;

			// Token: 0x0403521A RID: 217626
			[Token(Token = "0x403521A")]
			[FieldOffset(Offset = "0x30")]
			public bool isThisGroup;

			// Token: 0x0403521B RID: 217627
			[Token(Token = "0x403521B")]
			[FieldOffset(Offset = "0x34")]
			public HexagonDirection connectPos;

			// Token: 0x0403521C RID: 217628
			[Token(Token = "0x403521C")]
			[FieldOffset(Offset = "0x38")]
			public Vector2 focusPos;

			// Token: 0x0403521D RID: 217629
			[Token(Token = "0x403521D")]
			[FieldOffset(Offset = "0x40")]
			public List<HandBookV2GroupPosData.ColoringBlockData> colorBlocks;
		}

		// Token: 0x020066DC RID: 26332
		[Token(Token = "0x20066DC")]
		[Serializable]
		public class LineData
		{
			// Token: 0x06025C99 RID: 154777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C99")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LineData()
			{
			}

			// Token: 0x0403521E RID: 217630
			[Token(Token = "0x403521E")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x0403521F RID: 217631
			[Token(Token = "0x403521F")]
			[FieldOffset(Offset = "0x14")]
			public HandBookLineType lineType;

			// Token: 0x04035220 RID: 217632
			[Token(Token = "0x4035220")]
			[FieldOffset(Offset = "0x18")]
			public string char1;

			// Token: 0x04035221 RID: 217633
			[Token(Token = "0x4035221")]
			[FieldOffset(Offset = "0x20")]
			public string char2;
		}
	}
}
