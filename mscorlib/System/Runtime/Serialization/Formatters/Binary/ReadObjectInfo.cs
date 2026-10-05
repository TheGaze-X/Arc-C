using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	internal sealed class ReadObjectInfo
	{
		// Token: 0x06002140 RID: 8512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal ReadObjectInfo()
		{
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void ObjectEnd()
		{
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x4BC4350", Offset = "0x4BC2F50", VA = "0x184BC4350")]
		internal void PrepareForReuse()
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x4BC26F0", Offset = "0x4BC12F0", VA = "0x184BC26F0")]
		internal static ReadObjectInfo Create(System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			return null;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x4BC3F70", Offset = "0x4BC2B70", VA = "0x184BC3F70")]
		internal void Init(System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x4BC2820", Offset = "0x4BC1420", VA = "0x184BC2820")]
		internal static ReadObjectInfo Create(System.Type objectType, string[] memberNames, System.Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			return null;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x4BC4030", Offset = "0x4BC2C30", VA = "0x184BC4030")]
		internal void Init(System.Type objectType, string[] memberNames, System.Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x4BC3C50", Offset = "0x4BC2850", VA = "0x184BC3C50")]
		private void InitReadConstructor(System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context)
		{
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x4BC3EE0", Offset = "0x4BC2AE0", VA = "0x184BC3EE0")]
		private void InitSiRead()
		{
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002149")]
		[Address(RVA = "0x4BC3BD0", Offset = "0x4BC27D0", VA = "0x184BC3BD0")]
		private void InitNoMembers()
		{
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x4BC3900", Offset = "0x4BC2500", VA = "0x184BC3900")]
		private void InitMemberInfo()
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x4BC2990", Offset = "0x4BC1590", VA = "0x184BC2990")]
		internal System.Reflection.MemberInfo GetMemberInfo(string name)
		{
			return null;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x4BC3670", Offset = "0x4BC2270", VA = "0x184BC3670")]
		internal System.Type GetType(string name)
		{
			return null;
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214D")]
		[Address(RVA = "0x4BC2630", Offset = "0x4BC1230", VA = "0x184BC2630")]
		internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData)
		{
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214E")]
		[Address(RVA = "0x4BC3820", Offset = "0x4BC2420", VA = "0x184BC3820")]
		internal void InitDataStore(ref SerializationInfo si, ref object[] memberData)
		{
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214F")]
		[Address(RVA = "0x4BC4360", Offset = "0x4BC2F60", VA = "0x184BC4360")]
		internal void RecordFixup(long objectId, string name, long idRef)
		{
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002150")]
		[Address(RVA = "0x4BC4140", Offset = "0x4BC2D40", VA = "0x184BC4140")]
		internal void PopulateObjectMembers(object obj, object[] memberData)
		{
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00013788 File Offset: 0x00011988
		[Token(Token = "0x6002151")]
		[Address(RVA = "0x4BC41D0", Offset = "0x4BC2DD0", VA = "0x184BC41D0")]
		private int Position(string name)
		{
			return 0;
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002152")]
		[Address(RVA = "0x4BC2FB0", Offset = "0x4BC1BB0", VA = "0x184BC2FB0")]
		internal System.Type[] GetMemberTypes(string[] inMemberNames, System.Type objectType)
		{
			return null;
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002153")]
		[Address(RVA = "0x4BC2C10", Offset = "0x4BC1810", VA = "0x184BC2C10")]
		internal System.Type GetMemberType(System.Reflection.MemberInfo objMember)
		{
			return null;
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002154")]
		[Address(RVA = "0x4BC3600", Offset = "0x4BC2200", VA = "0x184BC3600")]
		private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			return null;
		}

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x10")]
		internal int objectInfoId;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x0")]
		internal static int readObjectInfoCounter;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x18")]
		internal System.Type objectType;

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x20")]
		internal ObjectManager objectManager;

		// Token: 0x04001248 RID: 4680
		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x28")]
		internal int count;

		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x2C")]
		internal bool isSi;

		// Token: 0x0400124A RID: 4682
		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0x2D")]
		internal bool isNamed;

		// Token: 0x0400124B RID: 4683
		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0x2E")]
		internal bool isTyped;

		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x2F")]
		internal bool bSimpleAssembly;

		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0x30")]
		internal SerObjectInfoCache cache;

		// Token: 0x0400124E RID: 4686
		[Token(Token = "0x400124E")]
		[FieldOffset(Offset = "0x38")]
		internal string[] wireMemberNames;

		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0x40")]
		internal System.Type[] wireMemberTypes;

		// Token: 0x04001250 RID: 4688
		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0x48")]
		private int lastPosition;

		// Token: 0x04001251 RID: 4689
		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0x50")]
		internal ISerializationSurrogate serializationSurrogate;

		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0x58")]
		internal StreamingContext context;

		// Token: 0x04001253 RID: 4691
		[Token(Token = "0x4001253")]
		[FieldOffset(Offset = "0x68")]
		internal System.Collections.Generic.List<System.Type> memberTypesList;

		// Token: 0x04001254 RID: 4692
		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0x70")]
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04001255 RID: 4693
		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0x78")]
		internal IFormatterConverter formatterConverter;
	}
}
