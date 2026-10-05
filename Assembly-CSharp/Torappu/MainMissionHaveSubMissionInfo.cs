using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200110B RID: 4363
	[Token(Token = "0x200110B")]
	[Serializable]
	public class MainMissionHaveSubMissionInfo
	{
		// Token: 0x06006ECD RID: 28365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MainMissionHaveSubMissionInfo()
		{
		}

		// Token: 0x04005D8D RID: 23949
		[Token(Token = "0x4005D8D")]
		[FieldOffset(Offset = "0x10")]
		public string mainMissionId;

		// Token: 0x04005D8E RID: 23950
		[Token(Token = "0x4005D8E")]
		[FieldOffset(Offset = "0x18")]
		public bool haveSubMissionToUnlock;
	}
}
