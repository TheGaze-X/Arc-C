using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIStyleState
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000157 RID: 343
		// (set) Token: 0x06000158 RID: 344
		[Token(Token = "0x1700004F")]
		[NativeProperty("Background", false, TargetType.Function)]
		public extern Texture2D background { [Token(Token = "0x6000157")] [Address(RVA = "0x5998870", Offset = "0x5997470", VA = "0x185998870")] [MethodImpl(4096)] get; [Token(Token = "0x6000158")] [Address(RVA = "0x5998950", Offset = "0x5997550", VA = "0x185998950")] [MethodImpl(4096)] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		[NativeProperty("textColor", false, TargetType.Field)]
		public Color textColor
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x5998900", Offset = "0x5997500", VA = "0x185998900")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x59989F0", Offset = "0x59975F0", VA = "0x1859989F0")]
			set
			{
			}
		}

		// Token: 0x0600015B RID: 347
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5998800", Offset = "0x5997400", VA = "0x185998800")]
		[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern IntPtr Init();

		// Token: 0x0600015C RID: 348
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x5998680", Offset = "0x5997280", VA = "0x185998680")]
		[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void Cleanup();

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x5998830", Offset = "0x5997430", VA = "0x185998830")]
		public GUIStyleState()
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5937CA0", Offset = "0x59368A0", VA = "0x185937CA0")]
		private GUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x5998780", Offset = "0x5997380", VA = "0x185998780")]
		internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x59986C0", Offset = "0x59972C0", VA = "0x1859986C0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000161 RID: 353
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x59988B0", Offset = "0x59974B0", VA = "0x1859988B0")]
		[MethodImpl(4096)]
		private extern void get_textColor_Injected(out Color ret);

		// Token: 0x06000162 RID: 354
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x59989A0", Offset = "0x59975A0", VA = "0x1859989A0")]
		[MethodImpl(4096)]
		private extern void set_textColor_Injected(ref Color value);

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly GUIStyle m_SourceStyle;
	}
}
