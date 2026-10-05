using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011C4 RID: 4548
	[Token(Token = "0x20011C4")]
	public class RoguelikeSkyNodeData
	{
		// Token: 0x06006FB0 RID: 28592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeSkyNodeData()
		{
		}

		// Token: 0x04006159 RID: 24921
		[Token(Token = "0x4006159")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeSkyZoneNodeType evtType;

		// Token: 0x0400615A RID: 24922
		[Token(Token = "0x400615A")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400615B RID: 24923
		[Token(Token = "0x400615B")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x0400615C RID: 24924
		[Token(Token = "0x400615C")]
		[FieldOffset(Offset = "0x28")]
		public string effId;

		// Token: 0x0400615D RID: 24925
		[Token(Token = "0x400615D")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x0400615E RID: 24926
		[Token(Token = "0x400615E")]
		[FieldOffset(Offset = "0x38")]
		public string nameBkgClr;

		// Token: 0x0400615F RID: 24927
		[Token(Token = "0x400615F")]
		[FieldOffset(Offset = "0x40")]
		public string selectClr;

		// Token: 0x04006160 RID: 24928
		[Token(Token = "0x4006160")]
		[FieldOffset(Offset = "0x48")]
		public bool isRepeatedly;
	}
}
