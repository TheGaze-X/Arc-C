using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
	[StructLayout(0)]
	public class Gradient : IEquatable<Gradient>
	{
		// Token: 0x060006ED RID: 1773
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x594ADD0", Offset = "0x59499D0", VA = "0x18594ADD0")]
		[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern IntPtr Init();

		// Token: 0x060006EE RID: 1774
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x594AA30", Offset = "0x5949630", VA = "0x18594AA30")]
		[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void Cleanup();

		// Token: 0x060006EF RID: 1775
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x594AE00", Offset = "0x5949A00", VA = "0x18594AE00")]
		[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = true, HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern bool Internal_Equals(IntPtr other);

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x594AE50", Offset = "0x5949A50", VA = "0x18594AE50")]
		[RequiredByNativeCode]
		public Gradient()
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x594AD50", Offset = "0x5949950", VA = "0x18594AD50", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x594ACF0", Offset = "0x59498F0", VA = "0x18594ACF0")]
		[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = true, HasExplicitThis = true)]
		public Color Evaluate(float time)
		{
			return default(Color);
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060006F3 RID: 1779
		// (set) Token: 0x060006F4 RID: 1780
		[Token(Token = "0x170001A6")]
		public extern GradientColorKey[] colorKeys { [Token(Token = "0x60006F3")] [Address(RVA = "0x594AED0", Offset = "0x5949AD0", VA = "0x18594AED0")] [FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = true, HasExplicitThis = true)] [MethodImpl(4096)] get; [Token(Token = "0x60006F4")] [Address(RVA = "0x594AF60", Offset = "0x5949B60", VA = "0x18594AF60")] [FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = true, HasExplicitThis = true)] [MethodImpl(4096)] [param: Unmarshalled] set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060006F5 RID: 1781
		// (set) Token: 0x060006F6 RID: 1782
		[Token(Token = "0x170001A7")]
		public extern GradientAlphaKey[] alphaKeys { [Token(Token = "0x60006F5")] [Address(RVA = "0x594AE90", Offset = "0x5949A90", VA = "0x18594AE90")] [FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = true, HasExplicitThis = true)] [MethodImpl(4096)] get; [Token(Token = "0x60006F6")] [Address(RVA = "0x594AF10", Offset = "0x5949B10", VA = "0x18594AF10")] [FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = true, HasExplicitThis = true)] [MethodImpl(4096)] [param: Unmarshalled] set; }

		// Token: 0x060006F7 RID: 1783 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x594AA70", Offset = "0x5949670", VA = "0x18594AA70", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x594ABD0", Offset = "0x59497D0", VA = "0x18594ABD0", Slot = "4")]
		public bool Equals(Gradient other)
		{
			return default(bool);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x591DCB0", Offset = "0x591C8B0", VA = "0x18591DCB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006FA RID: 1786
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x594AC90", Offset = "0x5949890", VA = "0x18594AC90")]
		[MethodImpl(4096)]
		private extern void Evaluate_Injected(float time, out Color ret);

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
