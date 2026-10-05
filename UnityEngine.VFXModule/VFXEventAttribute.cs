using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public sealed class VFXEventAttribute : IDisposable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5BA0B30", Offset = "0x5B9F730", VA = "0x185BA0B30")]
		private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5BA0730", Offset = "0x5B9F330", VA = "0x185BA0730")]
		internal static VFXEventAttribute CreateEventAttributeWrapper()
		{
			return null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5BA0AC0", Offset = "0x5B9F6C0", VA = "0x185BA0AC0")]
		internal void SetWrapValue(IntPtr ptrToEventAttribute)
		{
		}

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5BA0880", Offset = "0x5B9F480", VA = "0x185BA0880")]
		[MethodImpl(4096)]
		internal static extern IntPtr Internal_Create();

		// Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5BA0940", Offset = "0x5B9F540", VA = "0x185BA0940")]
		internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset)
		{
			return null;
		}

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5BA08F0", Offset = "0x5B9F4F0", VA = "0x185BA08F0")]
		[MethodImpl(4096)]
		internal extern void Internal_InitFromAsset(VisualEffectAsset vfxAsset);

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5BA0A10", Offset = "0x5B9F610", VA = "0x185BA0A10")]
		private void Release()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x5BA0820", Offset = "0x5B9F420", VA = "0x185BA0820", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5BA07C0", Offset = "0x5B9F3C0", VA = "0x185BA07C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5BA08B0", Offset = "0x5B9F4B0", VA = "0x185BA08B0")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		internal static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_Ptr;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_Owner;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VisualEffectAsset m_VfxAsset;
	}
}
