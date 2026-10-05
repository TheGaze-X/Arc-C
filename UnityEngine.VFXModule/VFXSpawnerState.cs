using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public sealed class VFXSpawnerState : IDisposable
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5BA1210", Offset = "0x5B9FE10", VA = "0x185BA1210")]
		internal VFXSpawnerState(IntPtr ptr, bool owner)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5BA0C50", Offset = "0x5B9F850", VA = "0x185BA0C50")]
		[RequiredByNativeCode]
		internal static VFXSpawnerState CreateSpawnerStateWrapper()
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5BA0ED0", Offset = "0x5B9FAD0", VA = "0x185BA0ED0")]
		private void PrepareWrapper()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5BA10F0", Offset = "0x5B9FCF0", VA = "0x185BA10F0")]
		[RequiredByNativeCode]
		internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5BA1040", Offset = "0x5B9FC40", VA = "0x185BA1040")]
		private void Release()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5BA0E30", Offset = "0x5B9FA30", VA = "0x185BA0E30", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5BA0DD0", Offset = "0x5B9F9D0", VA = "0x185BA0DD0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5BA0E90", Offset = "0x5B9FA90", VA = "0x185BA0E90")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_Ptr;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_Owner;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VFXEventAttribute m_WrapEventAttribute;
	}
}
