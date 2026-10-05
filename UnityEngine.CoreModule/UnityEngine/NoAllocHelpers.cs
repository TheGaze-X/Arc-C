using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	[NativeHeader("Runtime/Export/Scripting/NoAllocHelpers.bindings.h")]
	internal sealed class NoAllocHelpers
	{
		// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CF")]
		public static void ResizeList<T>(List<T> list, int size)
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D0")]
		public static void EnsureListElemCount<T>(List<T> list, int count)
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x5961360", Offset = "0x595FF60", VA = "0x185961360")]
		public static int SafeLength(Array values)
		{
			return 0;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x60009D2")]
		public static int SafeLength<T>(List<T> values)
		{
			return 0;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009D3")]
		public static T[] ExtractArrayFromListT<T>(List<T> list)
		{
			return null;
		}

		// Token: 0x060009D4 RID: 2516
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x5961320", Offset = "0x595FF20", VA = "0x185961320")]
		[FreeFunction("NoAllocHelpers_Bindings::Internal_ResizeList")]
		[MethodImpl(4096)]
		internal static extern void Internal_ResizeList(object list, int size);

		// Token: 0x060009D5 RID: 2517
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x59612E0", Offset = "0x595FEE0", VA = "0x1859612E0")]
		[FreeFunction("NoAllocHelpers_Bindings::ExtractArrayFromList")]
		[MethodImpl(4096)]
		public static extern Array ExtractArrayFromList(object list);
	}
}
