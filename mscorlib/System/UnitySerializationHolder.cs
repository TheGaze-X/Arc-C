using System;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	[System.Serializable]
	internal class UnitySerializationHolder : System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IObjectReference
	{
		// Token: 0x06000F20 RID: 3872 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x4D45C50", Offset = "0x4D44850", VA = "0x184D45C50")]
		internal static RuntimeType AddElementTypes(System.Runtime.Serialization.SerializationInfo info, RuntimeType type)
		{
			return null;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x4D46D30", Offset = "0x4D45930", VA = "0x184D46D30")]
		internal System.Type MakeElementTypes(System.Type type)
		{
			return null;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x4D46C00", Offset = "0x4D45800", VA = "0x184D46C00")]
		internal static void GetUnitySerializationInfo(System.Runtime.Serialization.SerializationInfo info, int unityType)
		{
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x4D46560", Offset = "0x4D45160", VA = "0x184D46560")]
		internal static void GetUnitySerializationInfo(System.Runtime.Serialization.SerializationInfo info, RuntimeType type)
		{
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x4D46A70", Offset = "0x4D45670", VA = "0x184D46A70")]
		internal static void GetUnitySerializationInfo(System.Runtime.Serialization.SerializationInfo info, int unityType, string data, RuntimeAssembly assembly)
		{
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x4D46EC0", Offset = "0x4D45AC0", VA = "0x184D46EC0")]
		internal UnitySerializationHolder(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x4D46E10", Offset = "0x4D45A10", VA = "0x184D46E10")]
		private void ThrowInsufficientInformation(string field)
		{
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x4D45E70", Offset = "0x4D44A70", VA = "0x184D45E70", Slot = "6")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x4D45EE0", Offset = "0x4D44AE0", VA = "0x184D45EE0", Slot = "7")]
		public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
		{
			return null;
		}

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0x10")]
		private System.Type[] m_instantiation;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0x18")]
		private int[] m_elementTypes;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0x20")]
		private int m_genericParameterPosition;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x28")]
		private System.Type m_declaringType;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x30")]
		private System.Reflection.MethodBase m_declaringMethod;

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x38")]
		private string m_data;

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x40")]
		private string m_assemblyName;

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x48")]
		private int m_unityType;
	}
}
