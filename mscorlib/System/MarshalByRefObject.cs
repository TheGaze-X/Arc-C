using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public abstract class MarshalByRefObject
	{
		// Token: 0x06000FF7 RID: 4087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		protected MarshalByRefObject()
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000172")]
		internal ServerIdentity ObjectIdentity
		{
			[Token(Token = "0x6000FF8")]
			[Address(RVA = "0x4D369E0", Offset = "0x4D355E0", VA = "0x184D369E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FF9")]
			[Address(RVA = "0x4D36A30", Offset = "0x4D35630", VA = "0x184D36A30")]
			set
			{
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x4D36940", Offset = "0x4D35540", VA = "0x184D36940", Slot = "4")]
		public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type requestedType)
		{
			return null;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x4D36990", Offset = "0x4D35590", VA = "0x184D36990", Slot = "5")]
		public virtual object InitializeLifetimeService()
		{
			return null;
		}

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[System.NonSerialized]
		private object _identity;
	}
}
