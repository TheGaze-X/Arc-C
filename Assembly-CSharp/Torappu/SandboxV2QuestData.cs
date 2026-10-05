using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012B3 RID: 4787
	[Token(Token = "0x20012B3")]
	public class SandboxV2QuestData
	{
		// Token: 0x06007233 RID: 29235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007233")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2QuestData()
		{
		}

		// Token: 0x040069BF RID: 27071
		[Token(Token = "0x40069BF")]
		[FieldOffset(Offset = "0x10")]
		public string questId;

		// Token: 0x040069C0 RID: 27072
		[Token(Token = "0x40069C0")]
		[FieldOffset(Offset = "0x18")]
		public string questLine;

		// Token: 0x040069C1 RID: 27073
		[Token(Token = "0x40069C1")]
		[FieldOffset(Offset = "0x20")]
		public string questTitle;

		// Token: 0x040069C2 RID: 27074
		[Token(Token = "0x40069C2")]
		[FieldOffset(Offset = "0x28")]
		public string questDesc;

		// Token: 0x040069C3 RID: 27075
		[Token(Token = "0x40069C3")]
		[FieldOffset(Offset = "0x30")]
		public string questTargetDesc;

		// Token: 0x040069C4 RID: 27076
		[Token(Token = "0x40069C4")]
		[FieldOffset(Offset = "0x38")]
		public bool isDisplay;

		// Token: 0x040069C5 RID: 27077
		[Token(Token = "0x40069C5")]
		[FieldOffset(Offset = "0x3C")]
		public SandboxV2QuestRouteType questRouteType;

		// Token: 0x040069C6 RID: 27078
		[Token(Token = "0x40069C6")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2QuestLineType questLineType;

		// Token: 0x040069C7 RID: 27079
		[Token(Token = "0x40069C7")]
		[FieldOffset(Offset = "0x48")]
		public string questRouteParam;

		// Token: 0x040069C8 RID: 27080
		[Token(Token = "0x40069C8")]
		[FieldOffset(Offset = "0x50")]
		public int showProgressIndex;
	}
}
