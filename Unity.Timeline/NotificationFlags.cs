using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[Flags]
	[Serializable]
	public enum NotificationFlags : short
	{
		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		TriggerInEditMode = 1,
		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		Retroactive = 2,
		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		TriggerOnce = 4
	}
}
