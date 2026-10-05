using System;
using System.Collections.Generic;
using System.Reflection;
using FullInspector.Internal.Preserve;
using FullSerializer;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BCC RID: 31692
	[Token(Token = "0x2007BCC")]
	[Preserve]
	public class FullSerializerSerializer : BaseSerializer
	{
		// Token: 0x170067D8 RID: 26584
		// (get) Token: 0x0602C5BB RID: 181691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067D8")]
		private static fsSerializer Serializer
		{
			[Token(Token = "0x602C5BB")]
			[Address(RVA = "0x2857FE0", Offset = "0x2856BE0", VA = "0x182857FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C5BC RID: 181692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5BC")]
		public static void AddConverter<TConverter>() where TConverter : fsConverter, new()
		{
		}

		// Token: 0x0602C5BD RID: 181693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5BD")]
		public static void AddProcessor<TProcessor>() where TProcessor : fsObjectProcessor, new()
		{
		}

		// Token: 0x0602C5BF RID: 181695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5BF")]
		[Address(RVA = "0x2857CF0", Offset = "0x28568F0", VA = "0x182857CF0", Slot = "4")]
		public override string Serialize(MemberInfo storageType, object value, ISerializationOperator serializationOperator)
		{
			return null;
		}

		// Token: 0x0602C5C0 RID: 181696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5C0")]
		[Address(RVA = "0x2857A60", Offset = "0x2856660", VA = "0x182857A60", Slot = "5")]
		public override object Deserialize(MemberInfo storageType, string serializedState, ISerializationOperator serializationOperator)
		{
			return null;
		}

		// Token: 0x170067D9 RID: 26585
		// (get) Token: 0x0602C5C1 RID: 181697 RVA: 0x000DFB78 File Offset: 0x000DDD78
		[Token(Token = "0x170067D9")]
		public override bool SupportsMultithreading
		{
			[Token(Token = "0x602C5C1")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C5C2 RID: 181698 RVA: 0x000DFB90 File Offset: 0x000DDD90
		[Token(Token = "0x602C5C2")]
		[Address(RVA = "0x2857BD0", Offset = "0x28567D0", VA = "0x182857BD0")]
		private static bool EmitFailWarning(fsResult result)
		{
			return default(bool);
		}

		// Token: 0x0602C5C3 RID: 181699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5C3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FullSerializerSerializer()
		{
		}

		// Token: 0x04040246 RID: 262726
		[Token(Token = "0x4040246")]
		[ThreadStatic]
		private static fsSerializer _serializer;

		// Token: 0x04040247 RID: 262727
		[Token(Token = "0x4040247")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<fsSerializer> _serializers;

		// Token: 0x04040248 RID: 262728
		[Token(Token = "0x4040248")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<Type> _converters;

		// Token: 0x04040249 RID: 262729
		[Token(Token = "0x4040249")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<Type> _processors;
	}
}
