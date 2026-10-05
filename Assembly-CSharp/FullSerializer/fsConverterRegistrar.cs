using System;
using System.Collections.Generic;
using FullSerializer.Internal.DirectConverters;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B63 RID: 31587
	[Token(Token = "0x2007B63")]
	public class fsConverterRegistrar
	{
		// Token: 0x0602C35D RID: 181085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C35D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsConverterRegistrar()
		{
		}

		// Token: 0x0404017B RID: 262523
		[Token(Token = "0x404017B")]
		[FieldOffset(Offset = "0x0")]
		public static AnimationCurve_DirectConverter Register_AnimationCurve_DirectConverter;

		// Token: 0x0404017C RID: 262524
		[Token(Token = "0x404017C")]
		[FieldOffset(Offset = "0x8")]
		public static Bounds_DirectConverter Register_Bounds_DirectConverter;

		// Token: 0x0404017D RID: 262525
		[Token(Token = "0x404017D")]
		[FieldOffset(Offset = "0x10")]
		public static Gradient_DirectConverter Register_Gradient_DirectConverter;

		// Token: 0x0404017E RID: 262526
		[Token(Token = "0x404017E")]
		[FieldOffset(Offset = "0x18")]
		public static GUIStyleState_DirectConverter Register_GUIStyleState_DirectConverter;

		// Token: 0x0404017F RID: 262527
		[Token(Token = "0x404017F")]
		[FieldOffset(Offset = "0x20")]
		public static GUIStyle_DirectConverter Register_GUIStyle_DirectConverter;

		// Token: 0x04040180 RID: 262528
		[Token(Token = "0x4040180")]
		[FieldOffset(Offset = "0x28")]
		public static Keyframe_DirectConverter Register_Keyframe_DirectConverter;

		// Token: 0x04040181 RID: 262529
		[Token(Token = "0x4040181")]
		[FieldOffset(Offset = "0x30")]
		public static LayerMask_DirectConverter Register_LayerMask_DirectConverter;

		// Token: 0x04040182 RID: 262530
		[Token(Token = "0x4040182")]
		[FieldOffset(Offset = "0x38")]
		public static RectOffset_DirectConverter Register_RectOffset_DirectConverter;

		// Token: 0x04040183 RID: 262531
		[Token(Token = "0x4040183")]
		[FieldOffset(Offset = "0x40")]
		public static Rect_DirectConverter Register_Rect_DirectConverter;

		// Token: 0x04040184 RID: 262532
		[Token(Token = "0x4040184")]
		[FieldOffset(Offset = "0x48")]
		public static List<Type> Converters;
	}
}
