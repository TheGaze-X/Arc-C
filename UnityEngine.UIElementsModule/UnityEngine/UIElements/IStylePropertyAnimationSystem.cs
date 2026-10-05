using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	internal interface IStylePropertyAnimationSystem
	{
		// Token: 0x060003D7 RID: 983
		[Token(Token = "0x60003D7")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003D8 RID: 984
		[Token(Token = "0x60003D8")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003D9 RID: 985
		[Token(Token = "0x60003D9")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003DA RID: 986
		[Token(Token = "0x60003DA")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003DB RID: 987
		[Token(Token = "0x60003DB")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003DC RID: 988
		[Token(Token = "0x60003DC")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003DD RID: 989
		[Token(Token = "0x60003DD")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003DE RID: 990
		[Token(Token = "0x60003DE")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003DF RID: 991
		[Token(Token = "0x60003DF")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003E0 RID: 992
		[Token(Token = "0x60003E0")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003E1 RID: 993
		[Token(Token = "0x60003E1")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003E2 RID: 994
		[Token(Token = "0x60003E2")]
		bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [NotNull] Func<float, float> easingCurve);

		// Token: 0x060003E3 RID: 995
		[Token(Token = "0x60003E3")]
		void CancelAllAnimations();

		// Token: 0x060003E4 RID: 996
		[Token(Token = "0x60003E4")]
		void CancelAllAnimations(VisualElement owner);

		// Token: 0x060003E5 RID: 997
		[Token(Token = "0x60003E5")]
		void CancelAnimation(VisualElement owner, StylePropertyId id);

		// Token: 0x060003E6 RID: 998
		[Token(Token = "0x60003E6")]
		void UpdateAnimation(VisualElement owner, StylePropertyId id);

		// Token: 0x060003E7 RID: 999
		[Token(Token = "0x60003E7")]
		void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds);

		// Token: 0x060003E8 RID: 1000
		[Token(Token = "0x60003E8")]
		void Update();
	}
}
