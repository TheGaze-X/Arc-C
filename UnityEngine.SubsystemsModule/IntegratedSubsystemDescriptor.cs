using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[UsedByNativeCode("SubsystemDescriptorBase")]
	[StructLayout(0)]
	public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		public string id
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x59CC110", Offset = "0x59CAD10", VA = "0x1859CC110", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected IntegratedSubsystemDescriptor()
		{
		}

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
