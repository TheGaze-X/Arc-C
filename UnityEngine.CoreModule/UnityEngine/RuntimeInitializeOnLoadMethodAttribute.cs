using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[RequiredByNativeCode]
	public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x5123450", Offset = "0x5122050", VA = "0x185123450")]
		public RuntimeInitializeOnLoadMethodAttribute()
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		{
		}

		// Token: 0x17000205 RID: 517
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000205")]
		private RuntimeInitializeLoadType loadType
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x10")]
		private RuntimeInitializeLoadType m_LoadType;
	}
}
