using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	internal static class NotificationUtilities
	{
		// Token: 0x06000340 RID: 832 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x58FBF90", Offset = "0x58FAB90", VA = "0x1858FBF90")]
		public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, double duration, DirectorWrapMode extrapolationMode)
		{
			return default(ScriptPlayable<TimeNotificationBehaviour>);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x58FC4D0", Offset = "0x58FB0D0", VA = "0x1858FC4D0")]
		public static bool TrackTypeSupportsNotifications(Type type)
		{
			return default(bool);
		}
	}
}
