using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	internal sealed class ObjectReader
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700045C")]
		private SerStack ValueFixupStack
		{
			[Token(Token = "0x600215C")]
			[Address(RVA = "0x4BBDC30", Offset = "0x4BBC830", VA = "0x184BBDC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		internal object TopObject
		{
			[Token(Token = "0x600215D")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x600215E")]
			[Address(RVA = "0x4BBDCD0", Offset = "0x4BBC8D0", VA = "0x184BBDCD0")]
			set
			{
			}
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215F")]
		[Address(RVA = "0x4BBDAC0", Offset = "0x4BBC6C0", VA = "0x184BBDAC0")]
		internal ObjectReader(System.IO.Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002160")]
		[Address(RVA = "0x4BB9700", Offset = "0x4BB8300", VA = "0x184BB9700")]
		internal object Deserialize(System.Runtime.Remoting.Messaging.HeaderHandler handler, __BinaryParser serParser, bool fCheck)
		{
			return null;
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x000137B8 File Offset: 0x000119B8
		[Token(Token = "0x6002161")]
		[Address(RVA = "0x4BBA5D0", Offset = "0x4BB91D0", VA = "0x184BBA5D0")]
		private bool HasSurrogate(System.Type t)
		{
			return default(bool);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002162")]
		[Address(RVA = "0x4BB92E0", Offset = "0x4BB7EE0", VA = "0x184BB92E0")]
		private void CheckSerializable(System.Type t)
		{
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002163")]
		[Address(RVA = "0x4BBA6F0", Offset = "0x4BB92F0", VA = "0x184BBA6F0")]
		private void InitFullDeserialization()
		{
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002164")]
		[Address(RVA = "0x4BB96D0", Offset = "0x4BB82D0", VA = "0x184BB96D0")]
		internal object CrossAppDomainArray(int index)
		{
			return null;
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002165")]
		[Address(RVA = "0x4BB9500", Offset = "0x4BB8100", VA = "0x184BB9500")]
		internal ReadObjectInfo CreateReadObjectInfo(System.Type objectType)
		{
			return null;
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002166")]
		[Address(RVA = "0x4BB9550", Offset = "0x4BB8150", VA = "0x184BB9550")]
		internal ReadObjectInfo CreateReadObjectInfo(System.Type objectType, string[] memberNames, System.Type[] memberTypes)
		{
			return null;
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002167")]
		[Address(RVA = "0x4BBD5C0", Offset = "0x4BBC1C0", VA = "0x184BBD5C0")]
		internal void Parse(ParseRecord pr)
		{
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002168")]
		[Address(RVA = "0x4BBC0A0", Offset = "0x4BBACA0", VA = "0x184BBC0A0")]
		private void ParseError(ParseRecord processing, ParseRecord onStack)
		{
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002169")]
		[Address(RVA = "0x4BBD470", Offset = "0x4BBC070", VA = "0x184BBD470")]
		private void ParseSerializedStreamHeader(ParseRecord pr)
		{
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216A")]
		[Address(RVA = "0x4BBD410", Offset = "0x4BBC010", VA = "0x184BBD410")]
		private void ParseSerializedStreamHeaderEnd(ParseRecord pr)
		{
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216B")]
		[Address(RVA = "0x4BBD060", Offset = "0x4BBBC60", VA = "0x184BBD060")]
		private void ParseObject(ParseRecord pr)
		{
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216C")]
		[Address(RVA = "0x4BBCBB0", Offset = "0x4BBB7B0", VA = "0x184BBCBB0")]
		private void ParseObjectEnd(ParseRecord pr)
		{
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216D")]
		[Address(RVA = "0x4BBB7C0", Offset = "0x4BBA3C0", VA = "0x184BBB7C0")]
		private void ParseArray(ParseRecord pr)
		{
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216E")]
		[Address(RVA = "0x4BBA840", Offset = "0x4BB9440", VA = "0x184BBA840")]
		private void NextRectangleMap(ParseRecord pr)
		{
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216F")]
		[Address(RVA = "0x4BBA960", Offset = "0x4BB9560", VA = "0x184BBA960")]
		private void ParseArrayMember(ParseRecord pr)
		{
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002170")]
		[Address(RVA = "0x4BBA930", Offset = "0x4BB9530", VA = "0x184BBA930")]
		private void ParseArrayMemberEnd(ParseRecord pr)
		{
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x4BBC430", Offset = "0x4BBB030", VA = "0x184BBC430")]
		private void ParseMember(ParseRecord pr)
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002172")]
		[Address(RVA = "0x4BBC380", Offset = "0x4BBAF80", VA = "0x184BBC380")]
		private void ParseMemberEnd(ParseRecord pr)
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002173")]
		[Address(RVA = "0x4BBD4A0", Offset = "0x4BBC0A0", VA = "0x184BBD4A0")]
		private void ParseString(ParseRecord pr, ParseRecord parentPr)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002174")]
		[Address(RVA = "0x4BBD970", Offset = "0x4BBC570", VA = "0x184BBD970")]
		private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr)
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002175")]
		[Address(RVA = "0x4BBD830", Offset = "0x4BBC430", VA = "0x184BBD830")]
		private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString)
		{
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x000137D0 File Offset: 0x000119D0
		[Token(Token = "0x6002176")]
		[Address(RVA = "0x4BB9FA0", Offset = "0x4BB8BA0", VA = "0x184BB9FA0")]
		internal long GetId(long objectId)
		{
			return 0L;
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002177")]
		[Address(RVA = "0x4BB9260", Offset = "0x4BB7E60", VA = "0x184BB9260")]
		internal System.Type Bind(string assemblyString, string typeString)
		{
			return null;
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002178")]
		[Address(RVA = "0x4BB9BE0", Offset = "0x4BB87E0", VA = "0x184BB9BE0")]
		internal System.Type FastBindToType(string assemblyName, string typeName)
		{
			return null;
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002179")]
		[Address(RVA = "0x4BBDA50", Offset = "0x4BBC650", VA = "0x184BBDA50")]
		[MethodImpl(8)]
		private static System.Reflection.Assembly ResolveSimpleAssemblyName(System.Reflection.AssemblyName assemblyName)
		{
			return null;
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217A")]
		[Address(RVA = "0x4BBA1D0", Offset = "0x4BB8DD0", VA = "0x184BBA1D0")]
		private static void GetSimplyNamedTypeFromAssembly(System.Reflection.Assembly assm, string typeName, ref System.Type type)
		{
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600217B")]
		[Address(RVA = "0x4BBA380", Offset = "0x4BB8F80", VA = "0x184BBA380")]
		internal System.Type GetType(BinaryAssemblyInfo assemblyInfo, string name)
		{
			return null;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217C")]
		[Address(RVA = "0x4BB9440", Offset = "0x4BB8040", VA = "0x184BB9440")]
		private static void CheckTypeForwardedTo(System.Reflection.Assembly sourceAssembly, System.Reflection.Assembly destAssembly, System.Type resolvedType)
		{
		}

		// Token: 0x04001262 RID: 4706
		[Token(Token = "0x4001262")]
		[FieldOffset(Offset = "0x10")]
		internal System.IO.Stream m_stream;

		// Token: 0x04001263 RID: 4707
		[Token(Token = "0x4001263")]
		[FieldOffset(Offset = "0x18")]
		internal ISurrogateSelector m_surrogates;

		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4001264")]
		[FieldOffset(Offset = "0x20")]
		internal StreamingContext m_context;

		// Token: 0x04001265 RID: 4709
		[Token(Token = "0x4001265")]
		[FieldOffset(Offset = "0x30")]
		internal ObjectManager m_objectManager;

		// Token: 0x04001266 RID: 4710
		[Token(Token = "0x4001266")]
		[FieldOffset(Offset = "0x38")]
		internal InternalFE formatterEnums;

		// Token: 0x04001267 RID: 4711
		[Token(Token = "0x4001267")]
		[FieldOffset(Offset = "0x40")]
		internal SerializationBinder m_binder;

		// Token: 0x04001268 RID: 4712
		[Token(Token = "0x4001268")]
		[FieldOffset(Offset = "0x48")]
		internal long topId;

		// Token: 0x04001269 RID: 4713
		[Token(Token = "0x4001269")]
		[FieldOffset(Offset = "0x50")]
		internal bool bSimpleAssembly;

		// Token: 0x0400126A RID: 4714
		[Token(Token = "0x400126A")]
		[FieldOffset(Offset = "0x58")]
		internal object handlerObject;

		// Token: 0x0400126B RID: 4715
		[Token(Token = "0x400126B")]
		[FieldOffset(Offset = "0x60")]
		internal object m_topObject;

		// Token: 0x0400126C RID: 4716
		[Token(Token = "0x400126C")]
		[FieldOffset(Offset = "0x68")]
		internal System.Runtime.Remoting.Messaging.Header[] headers;

		// Token: 0x0400126D RID: 4717
		[Token(Token = "0x400126D")]
		[FieldOffset(Offset = "0x70")]
		internal System.Runtime.Remoting.Messaging.HeaderHandler handler;

		// Token: 0x0400126E RID: 4718
		[Token(Token = "0x400126E")]
		[FieldOffset(Offset = "0x78")]
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x0400126F RID: 4719
		[Token(Token = "0x400126F")]
		[FieldOffset(Offset = "0x80")]
		internal IFormatterConverter m_formatterConverter;

		// Token: 0x04001270 RID: 4720
		[Token(Token = "0x4001270")]
		[FieldOffset(Offset = "0x88")]
		internal SerStack stack;

		// Token: 0x04001271 RID: 4721
		[Token(Token = "0x4001271")]
		[FieldOffset(Offset = "0x90")]
		private SerStack valueFixupStack;

		// Token: 0x04001272 RID: 4722
		[Token(Token = "0x4001272")]
		[FieldOffset(Offset = "0x98")]
		internal object[] crossAppDomainArray;

		// Token: 0x04001273 RID: 4723
		[Token(Token = "0x4001273")]
		[FieldOffset(Offset = "0xA0")]
		private bool bFullDeserialization;

		// Token: 0x04001274 RID: 4724
		[Token(Token = "0x4001274")]
		[FieldOffset(Offset = "0xA1")]
		private bool bOldFormatDetected;

		// Token: 0x04001275 RID: 4725
		[Token(Token = "0x4001275")]
		[FieldOffset(Offset = "0xA8")]
		private IntSizedArray valTypeObjectIdTable;

		// Token: 0x04001276 RID: 4726
		[Token(Token = "0x4001276")]
		[FieldOffset(Offset = "0xB0")]
		private NameCache typeCache;

		// Token: 0x04001277 RID: 4727
		[Token(Token = "0x4001277")]
		[FieldOffset(Offset = "0xB8")]
		private string previousAssemblyString;

		// Token: 0x04001278 RID: 4728
		[Token(Token = "0x4001278")]
		[FieldOffset(Offset = "0xC0")]
		private string previousName;

		// Token: 0x04001279 RID: 4729
		[Token(Token = "0x4001279")]
		[FieldOffset(Offset = "0xC8")]
		private System.Type previousType;

		// Token: 0x02000445 RID: 1093
		[Token(Token = "0x2000445")]
		internal class TypeNAssembly
		{
			// Token: 0x0600217D RID: 8573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600217D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TypeNAssembly()
			{
			}

			// Token: 0x0400127A RID: 4730
			[Token(Token = "0x400127A")]
			[FieldOffset(Offset = "0x10")]
			public System.Type type;

			// Token: 0x0400127B RID: 4731
			[Token(Token = "0x400127B")]
			[FieldOffset(Offset = "0x18")]
			public string assemblyName;
		}

		// Token: 0x02000446 RID: 1094
		[Token(Token = "0x2000446")]
		internal sealed class TopLevelAssemblyTypeResolver
		{
			// Token: 0x0600217E RID: 8574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600217E")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public TopLevelAssemblyTypeResolver(System.Reflection.Assembly topLevelAssembly)
			{
			}

			// Token: 0x0600217F RID: 8575 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600217F")]
			[Address(RVA = "0x4BC5FE0", Offset = "0x4BC4BE0", VA = "0x184BC5FE0")]
			public System.Type ResolveType(System.Reflection.Assembly assembly, string simpleTypeName, bool ignoreCase)
			{
				return null;
			}

			// Token: 0x0400127C RID: 4732
			[Token(Token = "0x400127C")]
			[FieldOffset(Offset = "0x10")]
			private System.Reflection.Assembly m_topLevelAssembly;
		}
	}
}
