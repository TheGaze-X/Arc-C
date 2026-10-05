using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	[System.Serializable]
	internal class MemberInfoSerializationHolder : System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IObjectReference
	{
		// Token: 0x060025FE RID: 9726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x4BD91B0", Offset = "0x4BD7DB0", VA = "0x184BD91B0")]
		public static void GetSerializationInfo(System.Runtime.Serialization.SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type)
		{
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x4BD8E70", Offset = "0x4BD7A70", VA = "0x184BD8E70")]
		public static void GetSerializationInfo(System.Runtime.Serialization.SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, System.Type[] genericArguments)
		{
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002600")]
		[Address(RVA = "0x4BD91E0", Offset = "0x4BD7DE0", VA = "0x184BD91E0")]
		internal MemberInfoSerializationHolder(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002601")]
		[Address(RVA = "0x4BD8170", Offset = "0x4BD6D70", VA = "0x184BD8170", Slot = "6")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002602")]
		[Address(RVA = "0x4BD81E0", Offset = "0x4BD6DE0", VA = "0x184BD81E0", Slot = "7")]
		public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
		{
			return null;
		}

		// Token: 0x040015D8 RID: 5592
		[Token(Token = "0x40015D8")]
		[FieldOffset(Offset = "0x10")]
		private string m_memberName;

		// Token: 0x040015D9 RID: 5593
		[Token(Token = "0x40015D9")]
		[FieldOffset(Offset = "0x18")]
		private RuntimeType m_reflectedType;

		// Token: 0x040015DA RID: 5594
		[Token(Token = "0x40015DA")]
		[FieldOffset(Offset = "0x20")]
		private string m_signature;

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x28")]
		private string m_signature2;

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x30")]
		private MemberTypes m_memberType;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x38")]
		private System.Runtime.Serialization.SerializationInfo m_info;
	}
}
