using System;
using Il2CppDummyDll;
using Torappu.Mission;
using UnityEngine;

namespace Torappu.UI.Mission
{
	// Token: 0x0200489F RID: 18591
	[Token(Token = "0x200489F")]
	[Serializable]
	public class MissionBookPageSimpleConfig
	{
		// Token: 0x0601C0E0 RID: 114912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0E0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MissionBookPageSimpleConfig()
		{
		}

		// Token: 0x04024A2A RID: 150058
		[Token(Token = "0x4024A2A")]
		[FieldOffset(Offset = "0x10")]
		public MissionSinglePage pagePrefab;

		// Token: 0x04024A2B RID: 150059
		[Token(Token = "0x4024A2B")]
		[FieldOffset(Offset = "0x18")]
		public MissionPageType pageType;

		// Token: 0x04024A2C RID: 150060
		[Token(Token = "0x4024A2C")]
		[FieldOffset(Offset = "0x20")]
		public Sprite icon;
	}
}
