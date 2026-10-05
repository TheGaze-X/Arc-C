using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001169 RID: 4457
	[Token(Token = "0x2001169")]
	public class RoguelikeDungeonZone
	{
		// Token: 0x06006F54 RID: 28500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F54")]
		[Address(RVA = "0x2111530", Offset = "0x2110130", VA = "0x182111530")]
		public RoguelikeDungeonLayer GetLayer(int depth)
		{
			return null;
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F55")]
		[Address(RVA = "0x21115C0", Offset = "0x21101C0", VA = "0x1821115C0")]
		public RoguelikeDungeonNode GetNode(int depth, int index)
		{
			return null;
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x00032658 File Offset: 0x00030858
		[Token(Token = "0x6006F56")]
		[Address(RVA = "0x21116D0", Offset = "0x21102D0", VA = "0x1821116D0")]
		public int GetZoneMaxDepth()
		{
			return 0;
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x00032670 File Offset: 0x00030870
		[Token(Token = "0x6006F57")]
		[Address(RVA = "0x2111710", Offset = "0x2110310", VA = "0x182111710")]
		public int GetZoneMaxIndex()
		{
			return 0;
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F58")]
		[Address(RVA = "0x2111820", Offset = "0x2110420", VA = "0x182111820")]
		public RoguelikeDungeonZone()
		{
		}

		// Token: 0x04005F7B RID: 24443
		[Token(Token = "0x4005F7B")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x04005F7C RID: 24444
		[Token(Token = "0x4005F7C")]
		[FieldOffset(Offset = "0x18")]
		public int zoneIndex;

		// Token: 0x04005F7D RID: 24445
		[Token(Token = "0x4005F7D")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeDungeonLayer> layers;

		// Token: 0x04005F7E RID: 24446
		[Token(Token = "0x4005F7E")]
		[FieldOffset(Offset = "0x28")]
		public List<string> variations;

		// Token: 0x04005F7F RID: 24447
		[Token(Token = "0x4005F7F")]
		[FieldOffset(Offset = "0x30")]
		public PlayerRoguelikeZoneType zoneType;
	}
}
