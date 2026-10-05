using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	[RequiredByNativeCode]
	public interface INotificationReceiver
	{
		// Token: 0x06000E89 RID: 3721
		[Token(Token = "0x6000E89")]
		[RequiredByNativeCode]
		void OnNotify(Playable origin, INotification notification, object context);
	}
}
