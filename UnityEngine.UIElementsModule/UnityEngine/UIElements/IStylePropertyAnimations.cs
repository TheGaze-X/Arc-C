using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	internal interface IStylePropertyAnimations
	{
		// Token: 0x06000262 RID: 610
		[Token(Token = "0x6000262")]
		bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x06000263 RID: 611
		[Token(Token = "0x6000263")]
		bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x06000264 RID: 612
		[Token(Token = "0x6000264")]
		bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x06000265 RID: 613
		[Token(Token = "0x6000265")]
		bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x06000266 RID: 614
		[Token(Token = "0x6000266")]
		bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x06000267 RID: 615
		[Token(Token = "0x6000267")]
		bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x06000268 RID: 616
		[Token(Token = "0x6000268")]
		bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x06000269 RID: 617
		[Token(Token = "0x6000269")]
		bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x0600026A RID: 618
		[Token(Token = "0x600026A")]
		bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x0600026B RID: 619
		[Token(Token = "0x600026B")]
		bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x0600026C RID: 620
		[Token(Token = "0x600026C")]
		bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x0600026D RID: 621
		[Token(Token = "0x600026D")]
		bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x0600026E RID: 622
		[Token(Token = "0x600026E")]
		bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve);

		// Token: 0x0600026F RID: 623
		[Token(Token = "0x600026F")]
		void UpdateAnimation(StylePropertyId id);

		// Token: 0x06000270 RID: 624
		[Token(Token = "0x6000270")]
		void GetAllAnimations(List<StylePropertyId> outPropertyIds);

		// Token: 0x06000271 RID: 625
		[Token(Token = "0x6000271")]
		void CancelAnimation(StylePropertyId id);

		// Token: 0x06000272 RID: 626
		[Token(Token = "0x6000272")]
		void CancelAllAnimations();

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000273 RID: 627
		// (set) Token: 0x06000274 RID: 628
		[Token(Token = "0x1700008C")]
		int runningAnimationCount { [Token(Token = "0x6000273")] get; [Token(Token = "0x6000274")] set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000275 RID: 629
		// (set) Token: 0x06000276 RID: 630
		[Token(Token = "0x1700008D")]
		int completedAnimationCount { [Token(Token = "0x6000275")] get; [Token(Token = "0x6000276")] set; }
	}
}
