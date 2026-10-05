using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	public struct SortingLayer
	{
		// Token: 0x06000080 RID: 128
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x5941AA0", Offset = "0x59406A0", VA = "0x185941AA0")]
		[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
		[MethodImpl(4096)]
		public static extern int GetLayerValueFromID(int id);

		// Token: 0x06000081 RID: 129
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x5941AE0", Offset = "0x59406E0", VA = "0x185941AE0")]
		[FreeFunction("GetTagManager().GetSortingLayerUniqueIDFromName")]
		[MethodImpl(4096)]
		public static extern int NameToID(string name);

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x0")]
		private int m_Id;
	}
}
