using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class TypeLoadException : System.SystemException, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x4D45360", Offset = "0x4D43F60", VA = "0x184D45360")]
		public TypeLoadException()
		{
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x4D45330", Offset = "0x4D43F30", VA = "0x184D45330")]
		public TypeLoadException(string message)
		{
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000151")]
		public override string Message
		{
			[Token(Token = "0x6000F1A")]
			[Address(RVA = "0x4D45440", Offset = "0x4D44040", VA = "0x184D45440", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x4D44FC0", Offset = "0x4D43BC0", VA = "0x184D44FC0")]
		private void SetMessageField()
		{
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x4D453B0", Offset = "0x4D43FB0", VA = "0x184D453B0")]
		private TypeLoadException(string className, string assemblyName)
		{
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x4D45120", Offset = "0x4D43D20", VA = "0x184D45120")]
		private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId)
		{
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x4D451C0", Offset = "0x4D43DC0", VA = "0x184D451C0")]
		protected TypeLoadException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x4D44DF0", Offset = "0x4D439F0", VA = "0x184D44DF0", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string ClassName;

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string AssemblyName;

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string MessageArg;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal int ResourceId;
	}
}
