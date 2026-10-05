using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079DC RID: 31196
	[Token(Token = "0x20079DC")]
	public class Act13SideEachMissionInfo
	{
		// Token: 0x0602BBE7 RID: 179175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBE7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13SideEachMissionInfo()
		{
		}

		// Token: 0x0403F48A RID: 259210
		[Token(Token = "0x403F48A")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x0403F48B RID: 259211
		[Token(Token = "0x403F48B")]
		[FieldOffset(Offset = "0x18")]
		public Act13SidePrestigeService prestige;
	}
}
