using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200128B RID: 4747
	[Token(Token = "0x200128B")]
	public class SandboxV2MapData
	{
		// Token: 0x06007202 RID: 29186 RVA: 0x00032C10 File Offset: 0x00030E10
		[Token(Token = "0x6007202")]
		[Address(RVA = "0x22102F0", Offset = "0x220EEF0", VA = "0x1822102F0")]
		public bool ShouldSerializezones()
		{
			return default(bool);
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007203")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2MapData()
		{
		}

		// Token: 0x040068A9 RID: 26793
		[Token(Token = "0x40068A9")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SandboxV2NodeData> nodes;

		// Token: 0x040068AA RID: 26794
		[Token(Token = "0x40068AA")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SandboxV2MapZoneData> zones;

		// Token: 0x040068AB RID: 26795
		[Token(Token = "0x40068AB")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2MapConfig mapConfig;

		// Token: 0x040068AC RID: 26796
		[Token(Token = "0x40068AC")]
		[FieldOffset(Offset = "0x28")]
		public string centerNodeId;

		// Token: 0x040068AD RID: 26797
		[Token(Token = "0x40068AD")]
		[FieldOffset(Offset = "0x30")]
		public string monthModeNodeId;
	}
}
