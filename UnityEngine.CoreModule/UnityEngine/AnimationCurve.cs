using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
	[StructLayout(0)]
	public class AnimationCurve : IEquatable<AnimationCurve>
	{
		// Token: 0x06000097 RID: 151
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x591DE00", Offset = "0x591CA00", VA = "0x18591DE00")]
		[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x06000098 RID: 152
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x591DDC0", Offset = "0x591C9C0", VA = "0x18591DDC0")]
		[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create(Keyframe[] keys);

		// Token: 0x06000099 RID: 153
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x591DE40", Offset = "0x591CA40", VA = "0x18591DE40")]
		[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		private extern bool Internal_Equals(IntPtr other);

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x591DC30", Offset = "0x591C830", VA = "0x18591DC30", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600009B RID: 155
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x591DBE0", Offset = "0x591C7E0", VA = "0x18591DBE0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public extern float Evaluate(float time);

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public Keyframe[] keys
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x591DD80", Offset = "0x591C980", VA = "0x18591DD80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x591E180", Offset = "0x591CD80", VA = "0x18591E180")]
			set
			{
			}
		}

		// Token: 0x0600009E RID: 158
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x591D580", Offset = "0x591C180", VA = "0x18591D580")]
		[FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		public extern int AddKey(float time, float value);

		// Token: 0x0600009F RID: 159 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x591D520", Offset = "0x591C120", VA = "0x18591D520")]
		public int AddKey(Keyframe key)
		{
			return 0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x591D4D0", Offset = "0x591C0D0", VA = "0x18591D4D0")]
		[NativeMethod("AddKey", IsThreadSafe = true)]
		private int AddKey_Internal(Keyframe key)
		{
			return 0;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x591E0F0", Offset = "0x591CCF0", VA = "0x18591E0F0")]
		[FreeFunction("AnimationCurveBindings::MoveKey", HasExplicitThis = true, IsThreadSafe = true)]
		[NativeThrows]
		public int MoveKey(int index, Keyframe key)
		{
			return 0;
		}

		// Token: 0x060000A2 RID: 162
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x591E140", Offset = "0x591CD40", VA = "0x18591E140")]
		[FreeFunction("AnimationCurveBindings::RemoveKey", HasExplicitThis = true, IsThreadSafe = true)]
		[NativeThrows]
		[MethodImpl(4096)]
		public extern void RemoveKey(int index);

		// Token: 0x17000017 RID: 23
		[Token(Token = "0x17000017")]
		public Keyframe this[int index]
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x591E2B0", Offset = "0x591CEB0", VA = "0x18591E2B0")]
			get
			{
				return default(Keyframe);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A4 RID: 164
		[Token(Token = "0x17000018")]
		public extern int length { [Token(Token = "0x60000A4")] [Address(RVA = "0x591E340", Offset = "0x591CF40", VA = "0x18591E340")] [NativeMethod("GetKeyCount", IsThreadSafe = true)] [MethodImpl(4096)] get; }

		// Token: 0x060000A5 RID: 165
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x591E180", Offset = "0x591CD80", VA = "0x18591E180")]
		[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		private extern void SetKeys(Keyframe[] keys);

		// Token: 0x060000A6 RID: 166 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x591DD10", Offset = "0x591C910", VA = "0x18591DD10")]
		[NativeThrows]
		[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = true, IsThreadSafe = true)]
		private Keyframe GetKey(int index)
		{
			return default(Keyframe);
		}

		// Token: 0x060000A7 RID: 167
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x591DD80", Offset = "0x591C980", VA = "0x18591DD80")]
		[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		private extern Keyframe[] GetKeys();

		// Token: 0x060000A8 RID: 168
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x591E1D0", Offset = "0x591CDD0", VA = "0x18591E1D0")]
		[FreeFunction("AnimationCurveBindings::SmoothTangents", HasExplicitThis = true, IsThreadSafe = true)]
		[NativeThrows]
		[MethodImpl(4096)]
		public extern void SmoothTangents(int index, float weight);

		// Token: 0x060000A9 RID: 169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x591D5E0", Offset = "0x591C1E0", VA = "0x18591D5E0")]
		public static AnimationCurve Constant(float timeStart, float timeEnd, float value)
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x591DE90", Offset = "0x591CA90", VA = "0x18591DE90")]
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x591D7E0", Offset = "0x591C3E0", VA = "0x18591D7E0")]
		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			return null;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000AC RID: 172
		// (set) Token: 0x060000AD RID: 173
		[Token(Token = "0x17000019")]
		public extern WrapMode preWrapMode { [Token(Token = "0x60000AC")] [Address(RVA = "0x591E3C0", Offset = "0x591CFC0", VA = "0x18591E3C0")] [NativeMethod("GetPreInfinity", IsThreadSafe = true)] [MethodImpl(4096)] get; [Token(Token = "0x60000AD")] [Address(RVA = "0x591E440", Offset = "0x591D040", VA = "0x18591E440")] [NativeMethod("SetPreInfinity", IsThreadSafe = true)] [MethodImpl(4096)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000AE RID: 174
		// (set) Token: 0x060000AF RID: 175
		[Token(Token = "0x1700001A")]
		public extern WrapMode postWrapMode { [Token(Token = "0x60000AE")] [Address(RVA = "0x591E380", Offset = "0x591CF80", VA = "0x18591E380")] [NativeMethod("GetPostInfinity", IsThreadSafe = true)] [MethodImpl(4096)] get; [Token(Token = "0x60000AF")] [Address(RVA = "0x591E400", Offset = "0x591D000", VA = "0x18591E400")] [NativeMethod("SetPostInfinity", IsThreadSafe = true)] [MethodImpl(4096)] set; }

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x591E260", Offset = "0x591CE60", VA = "0x18591E260")]
		public AnimationCurve(params Keyframe[] keys)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x591E220", Offset = "0x591CE20", VA = "0x18591E220")]
		[RequiredByNativeCode]
		public AnimationCurve()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x591DA80", Offset = "0x591C680", VA = "0x18591DA80", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x591D9C0", Offset = "0x591C5C0", VA = "0x18591D9C0", Slot = "4")]
		public bool Equals(AnimationCurve other)
		{
			return default(bool);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x591DCB0", Offset = "0x591C8B0", VA = "0x18591DCB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000B5 RID: 181
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x591D480", Offset = "0x591C080", VA = "0x18591D480")]
		[MethodImpl(4096)]
		private extern int AddKey_Internal_Injected(ref Keyframe key);

		// Token: 0x060000B6 RID: 182
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x591E0A0", Offset = "0x591CCA0", VA = "0x18591E0A0")]
		[MethodImpl(4096)]
		private extern int MoveKey_Injected(int index, ref Keyframe key);

		// Token: 0x060000B7 RID: 183
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x591DCC0", Offset = "0x591C8C0", VA = "0x18591DCC0")]
		[MethodImpl(4096)]
		private extern void GetKey_Injected(int index, out Keyframe ret);

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
