using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000378 RID: 888
	[Token(Token = "0x2000378")]
	[System.Serializable]
	internal class TypeInfo : IRemotingTypeInfo
	{
		// Token: 0x06001D27 RID: 7463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x4B92550", Offset = "0x4B91150", VA = "0x184B92550")]
		public TypeInfo(System.Type type)
		{
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000358")]
		public string TypeName
		{
			[Token(Token = "0x6001D28")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00012A20 File Offset: 0x00010C20
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x4B922E0", Offset = "0x4B90EE0", VA = "0x184B922E0", Slot = "5")]
		public bool CanCastTo(System.Type fromType, object o)
		{
			return default(bool);
		}

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		[FieldOffset(Offset = "0x10")]
		private string serverType;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		[FieldOffset(Offset = "0x18")]
		private string[] serverHierarchy;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0x20")]
		private string[] interfacesImplemented;
	}
}
