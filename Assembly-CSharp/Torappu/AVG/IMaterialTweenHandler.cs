using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001E63 RID: 7779
	[Token(Token = "0x2001E63")]
	public interface IMaterialTweenHandler
	{
		// Token: 0x0600C0FB RID: 49403
		[Token(Token = "0x600C0FB")]
		bool PlayTweens(Material mat, List<MaterialTweenParam> tweens, Action onComplete);

		// Token: 0x0600C0FC RID: 49404
		[Token(Token = "0x600C0FC")]
		void KillAll(Material mat);
	}
}
