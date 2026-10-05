using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058DD RID: 22749
	[Token(Token = "0x20058DD")]
	public static class CrossAppShareDisplayEffects
	{
		// Token: 0x060212D2 RID: 135890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212D2")]
		[Address(RVA = "0x1B736D0", Offset = "0x1B722D0", VA = "0x181B736D0")]
		public static Tween CameraSizeTweenEffect(Vector2 shotCanvasSize, Camera remakeCamera, RectTransform remakeContent)
		{
			return null;
		}

		// Token: 0x0402D31F RID: 185119
		[Token(Token = "0x402D31F")]
		private const float DISPLAY_SCREEN_WIDTH_RATIO = 0.835f;

		// Token: 0x0402D320 RID: 185120
		[Token(Token = "0x402D320")]
		private const float DISPLAY_SCREEN_HEIGHT_RATIO = 0.7f;

		// Token: 0x0402D321 RID: 185121
		[Token(Token = "0x402D321")]
		private const float DISPLAY_SCREEN_MOVE_UP_HEIGHT_RATIO = 0.1f;

		// Token: 0x0402D322 RID: 185122
		[Token(Token = "0x402D322")]
		private const float CAMERA_SIZE_TWEEN_DURATION = 1.2f;

		// Token: 0x020058DE RID: 22750
		[Token(Token = "0x20058DE")]
		public enum EffectType
		{
			// Token: 0x0402D324 RID: 185124
			[Token(Token = "0x402D324")]
			CAMERA_SIZE_TWEEN,
			// Token: 0x0402D325 RID: 185125
			[Token(Token = "0x402D325")]
			ENUM
		}
	}
}
