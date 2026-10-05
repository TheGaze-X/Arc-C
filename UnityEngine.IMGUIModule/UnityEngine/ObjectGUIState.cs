using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[NativeHeader("Modules/IMGUI/GUIState.h")]
	internal class ObjectGUIState : IDisposable
	{
		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x59AE1C0", Offset = "0x59ACDC0", VA = "0x1859AE1C0")]
		public ObjectGUIState()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x59AE090", Offset = "0x59ACC90", VA = "0x1859AE090", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x59AE0F0", Offset = "0x59ACCF0", VA = "0x1859AE0F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x59ADFF0", Offset = "0x59ACBF0", VA = "0x1859ADFF0")]
		private void Destroy()
		{
		}

		// Token: 0x06000249 RID: 585
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x59AE150", Offset = "0x59ACD50", VA = "0x1859AE150")]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create();

		// Token: 0x0600024A RID: 586
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x59AE180", Offset = "0x59ACD80", VA = "0x1859AE180")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
