using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200119A RID: 4506
	[Token(Token = "0x200119A")]
	public class RoguelikeTotemBuffData
	{
		// Token: 0x06006F88 RID: 28552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F88")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTotemBuffData()
		{
		}

		// Token: 0x0400607C RID: 24700
		[Token(Token = "0x400607C")]
		[FieldOffset(Offset = "0x10")]
		public string totemId;

		// Token: 0x0400607D RID: 24701
		[Token(Token = "0x400607D")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTotemColorType color;

		// Token: 0x0400607E RID: 24702
		[Token(Token = "0x400607E")]
		[FieldOffset(Offset = "0x1C")]
		public RoguelikeTotemPosType pos;

		// Token: 0x0400607F RID: 24703
		[Token(Token = "0x400607F")]
		[FieldOffset(Offset = "0x20")]
		public string rhythm;

		// Token: 0x04006080 RID: 24704
		[Token(Token = "0x4006080")]
		[FieldOffset(Offset = "0x28")]
		public string normalDesc;

		// Token: 0x04006081 RID: 24705
		[Token(Token = "0x4006081")]
		[FieldOffset(Offset = "0x30")]
		public string synergyDesc;

		// Token: 0x04006082 RID: 24706
		[Token(Token = "0x4006082")]
		[FieldOffset(Offset = "0x38")]
		public string archiveDesc;

		// Token: 0x04006083 RID: 24707
		[Token(Token = "0x4006083")]
		[FieldOffset(Offset = "0x40")]
		public string combineGroupName;

		// Token: 0x04006084 RID: 24708
		[Token(Token = "0x4006084")]
		[FieldOffset(Offset = "0x48")]
		public string bgIconId;

		// Token: 0x04006085 RID: 24709
		[Token(Token = "0x4006085")]
		[FieldOffset(Offset = "0x50")]
		public bool isManual;

		// Token: 0x04006086 RID: 24710
		[Token(Token = "0x4006086")]
		[FieldOffset(Offset = "0x58")]
		public RoguelikeTotemLinkedNodeTypeData linkedNodeTypeData;

		// Token: 0x04006087 RID: 24711
		[Token(Token = "0x4006087")]
		[FieldOffset(Offset = "0x60")]
		public int distanceMin;

		// Token: 0x04006088 RID: 24712
		[Token(Token = "0x4006088")]
		[FieldOffset(Offset = "0x64")]
		public int distanceMax;

		// Token: 0x04006089 RID: 24713
		[Token(Token = "0x4006089")]
		[FieldOffset(Offset = "0x68")]
		public bool vertPassable;

		// Token: 0x0400608A RID: 24714
		[Token(Token = "0x400608A")]
		[FieldOffset(Offset = "0x6C")]
		public int expandLength;

		// Token: 0x0400608B RID: 24715
		[Token(Token = "0x400608B")]
		[FieldOffset(Offset = "0x70")]
		public bool onlyForVert;

		// Token: 0x0400608C RID: 24716
		[Token(Token = "0x400608C")]
		[FieldOffset(Offset = "0x78")]
		public RoguelikeTotemLinkedNodeTypeData portalLinkedNodeTypeData;
	}
}
