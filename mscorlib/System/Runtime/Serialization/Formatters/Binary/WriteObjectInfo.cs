using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200043F RID: 1087
	[Token(Token = "0x200043F")]
	internal sealed class WriteObjectInfo
	{
		// Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal WriteObjectInfo()
		{
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212F")]
		[Address(RVA = "0x4BC8600", Offset = "0x4BC7200", VA = "0x184BC8600")]
		internal void ObjectEnd()
		{
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x4BC84F0", Offset = "0x4BC70F0", VA = "0x184BC84F0")]
		private void InternalInit()
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x4BC8700", Offset = "0x4BC7300", VA = "0x184BC8700")]
		internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			return null;
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x4BC7810", Offset = "0x4BC6410", VA = "0x184BC7810")]
		internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x4BC8660", Offset = "0x4BC7260", VA = "0x184BC8660")]
		internal static WriteObjectInfo Serialize(System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			return null;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002134")]
		[Address(RVA = "0x4BC71D0", Offset = "0x4BC5DD0", VA = "0x184BC71D0")]
		internal void InitSerialize(System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002135")]
		[Address(RVA = "0x4BC8130", Offset = "0x4BC6D30", VA = "0x184BC8130")]
		private void InitSiWrite()
		{
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002136")]
		[Address(RVA = "0x4BC6470", Offset = "0x4BC5070", VA = "0x184BC6470")]
		private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, System.Type objectType, string binderAssemblyString)
		{
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002137")]
		[Address(RVA = "0x4BC7050", Offset = "0x4BC5C50", VA = "0x184BC7050")]
		private void InitNoMembers()
		{
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002138")]
		[Address(RVA = "0x4BC6C10", Offset = "0x4BC5810", VA = "0x184BC6C10")]
		private void InitMemberInfo()
		{
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002139")]
		[Address(RVA = "0x4BC6BE0", Offset = "0x4BC57E0", VA = "0x184BC6BE0")]
		internal string GetTypeFullName()
		{
			return null;
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x4BC65E0", Offset = "0x4BC51E0", VA = "0x184BC65E0")]
		internal string GetAssemblyString()
		{
			return null;
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x4BC8580", Offset = "0x4BC7180", VA = "0x184BC8580")]
		private void InvokeSerializationBinder(SerializationBinder binder)
		{
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x4BC6700", Offset = "0x4BC5300", VA = "0x184BC6700")]
		internal System.Type GetMemberType(System.Reflection.MemberInfo objMember)
		{
			return null;
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x4BC6610", Offset = "0x4BC5210", VA = "0x184BC6610")]
		internal void GetMemberInfo(out string[] outMemberNames, out System.Type[] outMemberTypes, out object[] outMemberData)
		{
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x4BC6AA0", Offset = "0x4BC56A0", VA = "0x184BC6AA0")]
		private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			return null;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x4BC8630", Offset = "0x4BC7230", VA = "0x184BC8630")]
		private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo)
		{
		}

		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4001233")]
		[FieldOffset(Offset = "0x10")]
		internal int objectInfoId;

		// Token: 0x04001234 RID: 4660
		[Token(Token = "0x4001234")]
		[FieldOffset(Offset = "0x18")]
		internal object obj;

		// Token: 0x04001235 RID: 4661
		[Token(Token = "0x4001235")]
		[FieldOffset(Offset = "0x20")]
		internal System.Type objectType;

		// Token: 0x04001236 RID: 4662
		[Token(Token = "0x4001236")]
		[FieldOffset(Offset = "0x28")]
		internal bool isSi;

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0x29")]
		internal bool isNamed;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x2A")]
		internal bool isTyped;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0x2B")]
		internal bool isArray;

		// Token: 0x0400123A RID: 4666
		[Token(Token = "0x400123A")]
		[FieldOffset(Offset = "0x30")]
		internal SerializationInfo si;

		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x400123B")]
		[FieldOffset(Offset = "0x38")]
		internal SerObjectInfoCache cache;

		// Token: 0x0400123C RID: 4668
		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0x40")]
		internal object[] memberData;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x48")]
		internal ISerializationSurrogate serializationSurrogate;

		// Token: 0x0400123E RID: 4670
		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x50")]
		internal StreamingContext context;

		// Token: 0x0400123F RID: 4671
		[Token(Token = "0x400123F")]
		[FieldOffset(Offset = "0x60")]
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04001240 RID: 4672
		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0x68")]
		internal long objectId;

		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x70")]
		internal long assemId;

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x78")]
		private string binderTypeName;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x80")]
		private string binderAssemblyString;
	}
}
