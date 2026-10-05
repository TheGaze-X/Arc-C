using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050F8 RID: 20728
	[Token(Token = "0x20050F8")]
	public class UIDebugLogger : SingletonMonoBehaviour<UIDebugLogger>, ISingletonNotAutoCreate
	{
		// Token: 0x0601EA0D RID: 125453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA0D")]
		[Address(RVA = "0x18653E0", Offset = "0x1863FE0", VA = "0x1818653E0")]
		public UIDebugLogger()
		{
		}

		// Token: 0x040290EC RID: 168172
		[Token(Token = "0x40290EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _logPanelPrefab;

		// Token: 0x040290ED RID: 168173
		[Token(Token = "0x40290ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020050F9 RID: 20729
		[Token(Token = "0x20050F9")]
		public class Log
		{
			// Token: 0x0601EA0E RID: 125454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA0E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Log()
			{
			}

			// Token: 0x040290EE RID: 168174
			[Token(Token = "0x40290EE")]
			[FieldOffset(Offset = "0x10")]
			public LogType logType;

			// Token: 0x040290EF RID: 168175
			[Token(Token = "0x40290EF")]
			[FieldOffset(Offset = "0x18")]
			public string logString;

			// Token: 0x040290F0 RID: 168176
			[Token(Token = "0x40290F0")]
			[FieldOffset(Offset = "0x20")]
			public string stacktrace;

			// Token: 0x040290F1 RID: 168177
			[Token(Token = "0x40290F1")]
			[FieldOffset(Offset = "0x28")]
			public Action<string> callback;
		}
	}
}
