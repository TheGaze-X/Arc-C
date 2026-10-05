using System;
using Il2CppDummyDll;

namespace UnityEngine.Playables
{
	// Token: 0x02000292 RID: 658
	[Token(Token = "0x2000292")]
	public enum PlayState
	{
		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		Paused,
		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		Playing,
		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		[Obsolete("Delayed is obsolete; use a custom ScriptPlayable to implement this feature", false)]
		Delayed
	}
}
