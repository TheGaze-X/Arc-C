using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	public interface IPointerEvent
	{
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000C84 RID: 3204
		[Token(Token = "0x170002C1")]
		int pointerId { [Token(Token = "0x6000C84")] get; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000C85 RID: 3205
		[Token(Token = "0x170002C2")]
		string pointerType { [Token(Token = "0x6000C85")] get; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000C86 RID: 3206
		[Token(Token = "0x170002C3")]
		bool isPrimary { [Token(Token = "0x6000C86")] get; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000C87 RID: 3207
		[Token(Token = "0x170002C4")]
		int button { [Token(Token = "0x6000C87")] get; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000C88 RID: 3208
		[Token(Token = "0x170002C5")]
		int pressedButtons { [Token(Token = "0x6000C88")] get; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000C89 RID: 3209
		[Token(Token = "0x170002C6")]
		Vector3 position { [Token(Token = "0x6000C89")] get; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000C8A RID: 3210
		[Token(Token = "0x170002C7")]
		Vector3 localPosition { [Token(Token = "0x6000C8A")] get; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000C8B RID: 3211
		[Token(Token = "0x170002C8")]
		Vector3 deltaPosition { [Token(Token = "0x6000C8B")] get; }

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000C8C RID: 3212
		[Token(Token = "0x170002C9")]
		float deltaTime { [Token(Token = "0x6000C8C")] get; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C8D RID: 3213
		[Token(Token = "0x170002CA")]
		int clickCount { [Token(Token = "0x6000C8D")] get; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C8E RID: 3214
		[Token(Token = "0x170002CB")]
		float pressure { [Token(Token = "0x6000C8E")] get; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000C8F RID: 3215
		[Token(Token = "0x170002CC")]
		float tangentialPressure { [Token(Token = "0x6000C8F")] get; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000C90 RID: 3216
		[Token(Token = "0x170002CD")]
		float altitudeAngle { [Token(Token = "0x6000C90")] get; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000C91 RID: 3217
		[Token(Token = "0x170002CE")]
		float azimuthAngle { [Token(Token = "0x6000C91")] get; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000C92 RID: 3218
		[Token(Token = "0x170002CF")]
		float twist { [Token(Token = "0x6000C92")] get; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000C93 RID: 3219
		[Token(Token = "0x170002D0")]
		Vector2 radius { [Token(Token = "0x6000C93")] get; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000C94 RID: 3220
		[Token(Token = "0x170002D1")]
		Vector2 radiusVariance { [Token(Token = "0x6000C94")] get; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000C95 RID: 3221
		[Token(Token = "0x170002D2")]
		EventModifiers modifiers { [Token(Token = "0x6000C95")] get; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000C96 RID: 3222
		[Token(Token = "0x170002D3")]
		bool shiftKey { [Token(Token = "0x6000C96")] get; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000C97 RID: 3223
		[Token(Token = "0x170002D4")]
		bool ctrlKey { [Token(Token = "0x6000C97")] get; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000C98 RID: 3224
		[Token(Token = "0x170002D5")]
		bool commandKey { [Token(Token = "0x6000C98")] get; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000C99 RID: 3225
		[Token(Token = "0x170002D6")]
		bool altKey { [Token(Token = "0x6000C99")] get; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000C9A RID: 3226
		[Token(Token = "0x170002D7")]
		bool actionKey { [Token(Token = "0x6000C9A")] get; }
	}
}
