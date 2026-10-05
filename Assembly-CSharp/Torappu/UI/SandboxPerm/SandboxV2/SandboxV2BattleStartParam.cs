using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200441B RID: 17435
	[Token(Token = "0x200441B")]
	public struct SandboxV2BattleStartParam
	{
		// Token: 0x0601A9EA RID: 109034 RVA: 0x000A28E8 File Offset: 0x000A0AE8
		[Token(Token = "0x601A9EA")]
		[Address(RVA = "0x13A8EA0", Offset = "0x13A7AA0", VA = "0x1813A8EA0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x04021F1C RID: 139036
		[Token(Token = "0x4021F1C")]
		[FieldOffset(Offset = "0x0")]
		public string topicId;

		// Token: 0x04021F1D RID: 139037
		[Token(Token = "0x4021F1D")]
		[FieldOffset(Offset = "0x8")]
		public string nodeId;

		// Token: 0x04021F1E RID: 139038
		[Token(Token = "0x4021F1E")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2NodeType nodeType;

		// Token: 0x04021F1F RID: 139039
		[Token(Token = "0x4021F1F")]
		[FieldOffset(Offset = "0x14")]
		public SandboxV2SeasonType nodeSeasonType;

		// Token: 0x04021F20 RID: 139040
		[Token(Token = "0x4021F20")]
		[FieldOffset(Offset = "0x18")]
		public string nodeWeatherId;

		// Token: 0x04021F21 RID: 139041
		[Token(Token = "0x4021F21")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x04021F22 RID: 139042
		[Token(Token = "0x4021F22")]
		[FieldOffset(Offset = "0x28")]
		public int squadIdx;

		// Token: 0x04021F23 RID: 139043
		[Token(Token = "0x4021F23")]
		[FieldOffset(Offset = "0x30")]
		public BattleFinishIllust charIllust;

		// Token: 0x04021F24 RID: 139044
		[Token(Token = "0x4021F24")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, int> toolDict;

		// Token: 0x04021F25 RID: 139045
		[Token(Token = "0x4021F25")]
		[FieldOffset(Offset = "0x60")]
		public IList<AdvancedCharacterInst> battleSlots;

		// Token: 0x04021F26 RID: 139046
		[Token(Token = "0x4021F26")]
		[FieldOffset(Offset = "0x68")]
		public string monthlyRushId;

		// Token: 0x04021F27 RID: 139047
		[Token(Token = "0x4021F27")]
		[FieldOffset(Offset = "0x70")]
		public SandboxV2Const.SandboxV2BattleBgmType bgmType;

		// Token: 0x04021F28 RID: 139048
		[Token(Token = "0x4021F28")]
		[FieldOffset(Offset = "0x78")]
		public string racerInstId;
	}
}
