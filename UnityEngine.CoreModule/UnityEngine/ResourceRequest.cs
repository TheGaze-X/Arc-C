using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	[RequiredByNativeCode]
	[StructLayout(0)]
	public class ResourceRequest : AsyncOperation
	{
		// Token: 0x060008CE RID: 2254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x5952410", Offset = "0x5951010", VA = "0x185952410", Slot = "4")]
		protected virtual Object GetResult()
		{
			return null;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E6")]
		public Object asset
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x5919C80", Offset = "0x5918880", VA = "0x185919C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ResourceRequest()
		{
		}

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string m_Path;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Type m_Type;
	}
}
