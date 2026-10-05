using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x0200046C RID: 1132
	[Token(Token = "0x200046C")]
	public class TouchWrapper
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x0002CE98 File Offset: 0x0002B098
		[Token(Token = "0x170001C1")]
		public static int TouchCount
		{
			[Token(Token = "0x6004B70")]
			[Address(RVA = "0x1697EA0", Offset = "0x1696AA0", VA = "0x181697EA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		public static WrappedTouch Touch0
		{
			[Token(Token = "0x6004B71")]
			[Address(RVA = "0x1697D70", Offset = "0x1696970", VA = "0x181697D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06004B72 RID: 19314 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
		[Token(Token = "0x170001C3")]
		public static bool IsFingerDown
		{
			[Token(Token = "0x6004B72")]
			[Address(RVA = "0x1697D30", Offset = "0x1696930", VA = "0x181697D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06004B73 RID: 19315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C4")]
		public static List<WrappedTouch> Touches
		{
			[Token(Token = "0x6004B73")]
			[Address(RVA = "0x1697EE0", Offset = "0x1696AE0", VA = "0x181697EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B74")]
		[Address(RVA = "0x1697960", Offset = "0x1696560", VA = "0x181697960")]
		private static List<WrappedTouch> GetTouchesFromInputTouches()
		{
			return null;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06004B75 RID: 19317 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
		[Token(Token = "0x170001C5")]
		public static Vector2 AverageTouchPos
		{
			[Token(Token = "0x6004B75")]
			[Address(RVA = "0x1697B20", Offset = "0x1696720", VA = "0x181697B20")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		[Token(Token = "0x6004B76")]
		[Address(RVA = "0x1697790", Offset = "0x1696390", VA = "0x181697790")]
		private static Vector2 GetAverageTouchPosFromInputTouches()
		{
			return default(Vector2);
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B77")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TouchWrapper()
		{
		}
	}
}
