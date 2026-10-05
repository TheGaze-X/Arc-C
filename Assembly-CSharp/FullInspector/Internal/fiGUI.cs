using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007C84 RID: 31876
	[Token(Token = "0x2007C84")]
	public static class fiGUI
	{
		// Token: 0x0602C887 RID: 182407 RVA: 0x000E0940 File Offset: 0x000DEB40
		[Token(Token = "0x602C887")]
		[Address(RVA = "0x28689D0", Offset = "0x28675D0", VA = "0x1828689D0")]
		public static float PushLabelWidth(GUIContent controlLabel, float controlWidth)
		{
			return 0f;
		}

		// Token: 0x0602C888 RID: 182408 RVA: 0x000E0958 File Offset: 0x000DEB58
		[Token(Token = "0x602C888")]
		[Address(RVA = "0x2868920", Offset = "0x2867520", VA = "0x182868920")]
		public static float PopLabelWidth()
		{
			return 0f;
		}

		// Token: 0x0602C889 RID: 182409 RVA: 0x000E0970 File Offset: 0x000DEB70
		[Token(Token = "0x602C889")]
		[Address(RVA = "0x2868700", Offset = "0x2867300", VA = "0x182868700")]
		public static float ComputeActualLabelWidth(float inspectorWidth, GUIContent controlLabel, float controlWidth)
		{
			return 0f;
		}

		// Token: 0x04040371 RID: 263025
		[Token(Token = "0x4040371")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<float> s_regionWidths;

		// Token: 0x04040372 RID: 263026
		[Token(Token = "0x4040372")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Stack<float> s_savedLabelWidths;
	}
}
