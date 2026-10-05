using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x200021C")]
	internal static class ComputedTransitionUtils
	{
		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x5B05820", Offset = "0x5B04420", VA = "0x185B05820")]
		internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x5B05320", Offset = "0x5B03F20", VA = "0x185B05320")]
		internal static bool HasTransitionProperty(this ComputedStyle computedStyle, StylePropertyId id)
		{
			return default(bool);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x5B05200", Offset = "0x5B03E00", VA = "0x185B05200")]
		internal static bool GetTransitionProperty(this ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result)
		{
			return default(bool);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x5B04BD0", Offset = "0x5B037D0", VA = "0x185B04BD0")]
		private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle)
		{
			return null;
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x5B04D90", Offset = "0x5B03990", VA = "0x185B04D90")]
		private static int GetTransitionHashCode(ref ComputedStyle cs)
		{
			return 0;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x5B05520", Offset = "0x5B04120", VA = "0x185B05520")]
		internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y)
		{
			return default(bool);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x5B053F0", Offset = "0x5B03FF0", VA = "0x185B053F0")]
		private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b)
		{
			return default(bool);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00007B00 File Offset: 0x00005D00
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x5B05720", Offset = "0x5B04320", VA = "0x185B05720")]
		private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b)
		{
			return default(bool);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x5B03770", Offset = "0x5B02370", VA = "0x185B03770")]
		private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData)
		{
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000ECE")]
		private static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue)
		{
			return null;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x5B04BA0", Offset = "0x5B037A0", VA = "0x185B04BA0")]
		private static int ConvertTransitionTime(TimeValue time)
		{
			return 0;
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x5B03AC0", Offset = "0x5B026C0", VA = "0x185B03AC0")]
		private static Func<float, float> ConvertTransitionFunction(EasingMode mode)
		{
			return null;
		}

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x0")]
		private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer;
	}
}
