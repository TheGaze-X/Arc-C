using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200451A RID: 17690
	[Token(Token = "0x200451A")]
	public class RoguelikeCommonOuterBuffSummaryDifficultyItemModel : IHotfixable
	{
		// Token: 0x0601AFA4 RID: 110500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFA4")]
		[Address(RVA = "0x1421310", Offset = "0x141FF10", VA = "0x181421310")]
		public RoguelikeCommonOuterBuffSummaryDifficultyItemModel()
		{
		}

		// Token: 0x04022A35 RID: 141877
		[Token(Token = "0x4022A35")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04022A36 RID: 141878
		[Token(Token = "0x4022A36")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04022A37 RID: 141879
		[Token(Token = "0x4022A37")]
		[FieldOffset(Offset = "0x20")]
		public string decoId;

		// Token: 0x04022A38 RID: 141880
		[Token(Token = "0x4022A38")]
		[FieldOffset(Offset = "0x28")]
		public string lightId;

		// Token: 0x04022A39 RID: 141881
		[Token(Token = "0x4022A39")]
		[FieldOffset(Offset = "0x30")]
		public string enableDesc;

		// Token: 0x04022A3A RID: 141882
		[Token(Token = "0x4022A3A")]
		[FieldOffset(Offset = "0x38")]
		public List<string> effectDescs;

		// Token: 0x04022A3B RID: 141883
		[Token(Token = "0x4022A3B")]
		[FieldOffset(Offset = "0x40")]
		public bool isInGame;

		// Token: 0x04022A3C RID: 141884
		[Token(Token = "0x4022A3C")]
		[FieldOffset(Offset = "0x41")]
		public bool isEffective;

		// Token: 0x04022A3D RID: 141885
		[Token(Token = "0x4022A3D")]
		[FieldOffset(Offset = "0x42")]
		public bool isActive;

		// Token: 0x04022A3E RID: 141886
		[Token(Token = "0x4022A3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
