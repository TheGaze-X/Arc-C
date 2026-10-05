using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000447 RID: 1095
	[Token(Token = "0x2000447")]
	internal sealed class ObjectWriter
	{
		// Token: 0x06002180 RID: 8576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002180")]
		[Address(RVA = "0x4BC18F0", Offset = "0x4BC04F0", VA = "0x184BC18F0")]
		internal ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
		{
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002181")]
		[Address(RVA = "0x4BBE660", Offset = "0x4BBD260", VA = "0x184BBE660")]
		internal void Serialize(object graph, System.Runtime.Remoting.Messaging.Header[] inHeaders, __BinaryWriter serWriter, bool fCheck)
		{
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700045E")]
		internal SerializationObjectManager ObjectManager
		{
			[Token(Token = "0x6002182")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002183")]
		[Address(RVA = "0x4BC0FC0", Offset = "0x4BBFBC0", VA = "0x184BC0FC0")]
		private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002184")]
		[Address(RVA = "0x4BC0B50", Offset = "0x4BBF750", VA = "0x184BC0B50")]
		private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, System.Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos)
		{
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002185")]
		[Address(RVA = "0x4BC0060", Offset = "0x4BBEC60", VA = "0x184BC0060")]
		private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, System.Type memberType, object memberData, WriteObjectInfo memberObjectInfo)
		{
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002186")]
		[Address(RVA = "0x4BC01E0", Offset = "0x4BBEDE0", VA = "0x184BC01E0")]
		private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo)
		{
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002187")]
		[Address(RVA = "0x4BBF380", Offset = "0x4BBDF80", VA = "0x184BBF380")]
		private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo)
		{
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002188")]
		[Address(RVA = "0x4BBF020", Offset = "0x4BBDC20", VA = "0x184BBF020")]
		private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data)
		{
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002189")]
		[Address(RVA = "0x4BC07A0", Offset = "0x4BBF3A0", VA = "0x184BC07A0")]
		private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, System.Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA)
		{
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600218A")]
		[Address(RVA = "0x4BBE1B0", Offset = "0x4BBCDB0", VA = "0x184BBE1B0")]
		private object GetNext(out long objID)
		{
			return null;
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x600218B")]
		[Address(RVA = "0x4BBE3D0", Offset = "0x4BBCFD0", VA = "0x184BBE3D0")]
		private long InternalGetId(object obj, bool assignUniqueIdToValueType, System.Type type, out bool isNew)
		{
			return 0L;
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00013800 File Offset: 0x00011A00
		[Token(Token = "0x600218C")]
		[Address(RVA = "0x4BBE5E0", Offset = "0x4BBD1E0", VA = "0x184BBE5E0")]
		private long Schedule(object obj, bool assignUniqueIdToValueType, System.Type type)
		{
			return 0L;
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00013818 File Offset: 0x00011A18
		[Token(Token = "0x600218D")]
		[Address(RVA = "0x4BBE540", Offset = "0x4BBD140", VA = "0x184BBE540")]
		private long Schedule(object obj, bool assignUniqueIdToValueType, System.Type type, WriteObjectInfo objectInfo)
		{
			return 0L;
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00013830 File Offset: 0x00011A30
		[Token(Token = "0x600218E")]
		[Address(RVA = "0x4BBFE20", Offset = "0x4BBEA20", VA = "0x184BBFE20")]
		private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data)
		{
			return default(bool);
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218F")]
		[Address(RVA = "0x4BC0780", Offset = "0x4BBF380", VA = "0x184BC0780")]
		private void WriteObjectRef(NameInfo nameInfo, long objectId)
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002190")]
		[Address(RVA = "0x4BC09D0", Offset = "0x4BBF5D0", VA = "0x184BC09D0")]
		private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject)
		{
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00013848 File Offset: 0x00011A48
		[Token(Token = "0x6002191")]
		[Address(RVA = "0x4BBDD10", Offset = "0x4BBC910", VA = "0x184BBDD10")]
		private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data)
		{
			return default(bool);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002192")]
		[Address(RVA = "0x4BC09A0", Offset = "0x4BBF5A0", VA = "0x184BC09A0")]
		private void WriteSerializedStreamHeader(long topId, long headerId)
		{
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002193")]
		[Address(RVA = "0x4BBED70", Offset = "0x4BBD970", VA = "0x184BBED70")]
		private NameInfo TypeToNameInfo(System.Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo)
		{
			return null;
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002194")]
		[Address(RVA = "0x4BBEE60", Offset = "0x4BBDA60", VA = "0x184BBEE60")]
		private NameInfo TypeToNameInfo(System.Type type)
		{
			return null;
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002195")]
		[Address(RVA = "0x4BBEEC0", Offset = "0x4BBDAC0", VA = "0x184BBEEC0")]
		private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo)
		{
			return null;
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x4BBED00", Offset = "0x4BBD900", VA = "0x184BBED00")]
		private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo)
		{
			return null;
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x4BBEF70", Offset = "0x4BBDB70", VA = "0x184BBEF70")]
		private void TypeToNameInfo(System.Type type, NameInfo nameInfo)
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x4BBE4D0", Offset = "0x4BBD0D0", VA = "0x184BBE4D0")]
		private NameInfo MemberToNameInfo(string name)
		{
			return null;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00013860 File Offset: 0x00011A60
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x4BBEC50", Offset = "0x4BBD850", VA = "0x184BBEC50")]
		internal InternalPrimitiveTypeE ToCode(System.Type type)
		{
			return InternalPrimitiveTypeE.Invalid;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00013878 File Offset: 0x00011A78
		[Token(Token = "0x600219A")]
		[Address(RVA = "0x4BBDDF0", Offset = "0x4BBC9F0", VA = "0x184BBDDF0")]
		private long GetAssemblyId(WriteObjectInfo objectInfo)
		{
			return 0L;
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600219B")]
		[Address(RVA = "0x4BBE3B0", Offset = "0x4BBCFB0", VA = "0x184BBE3B0")]
		private System.Type GetType(object obj)
		{
			return null;
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600219C")]
		[Address(RVA = "0x4BBE0C0", Offset = "0x4BBCCC0", VA = "0x184BBE0C0")]
		private NameInfo GetNameInfo()
		{
			return null;
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00013890 File Offset: 0x00011A90
		[Token(Token = "0x600219D")]
		[Address(RVA = "0x4BBDDE0", Offset = "0x4BBC9E0", VA = "0x184BBDDE0")]
		private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want)
		{
			return default(bool);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219E")]
		[Address(RVA = "0x4BBE510", Offset = "0x4BBD110", VA = "0x184BBE510")]
		private void PutNameInfo(NameInfo nameInfo)
		{
		}

		// Token: 0x0400127D RID: 4733
		[Token(Token = "0x400127D")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.Queue m_objectQueue;

		// Token: 0x0400127E RID: 4734
		[Token(Token = "0x400127E")]
		[FieldOffset(Offset = "0x18")]
		private ObjectIDGenerator m_idGenerator;

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x20")]
		private int m_currentId;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x28")]
		private ISurrogateSelector m_surrogates;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x30")]
		private StreamingContext m_context;

		// Token: 0x04001282 RID: 4738
		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x40")]
		private __BinaryWriter serWriter;

		// Token: 0x04001283 RID: 4739
		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x48")]
		private SerializationObjectManager m_objectManager;

		// Token: 0x04001284 RID: 4740
		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x50")]
		private long topId;

		// Token: 0x04001285 RID: 4741
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x58")]
		private string topName;

		// Token: 0x04001286 RID: 4742
		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x60")]
		private System.Runtime.Remoting.Messaging.Header[] headers;

		// Token: 0x04001287 RID: 4743
		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x68")]
		private InternalFE formatterEnums;

		// Token: 0x04001288 RID: 4744
		[Token(Token = "0x4001288")]
		[FieldOffset(Offset = "0x70")]
		private SerializationBinder m_binder;

		// Token: 0x04001289 RID: 4745
		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x78")]
		private SerObjectInfoInit serObjectInfoInit;

		// Token: 0x0400128A RID: 4746
		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x80")]
		private IFormatterConverter m_formatterConverter;

		// Token: 0x0400128B RID: 4747
		[Token(Token = "0x400128B")]
		[FieldOffset(Offset = "0x88")]
		internal object[] crossAppDomainArray;

		// Token: 0x0400128C RID: 4748
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x90")]
		private object previousObj;

		// Token: 0x0400128D RID: 4749
		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x98")]
		private long previousId;

		// Token: 0x0400128E RID: 4750
		[Token(Token = "0x400128E")]
		[FieldOffset(Offset = "0xA0")]
		private System.Type previousType;

		// Token: 0x0400128F RID: 4751
		[Token(Token = "0x400128F")]
		[FieldOffset(Offset = "0xA8")]
		private InternalPrimitiveTypeE previousCode;

		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0xB0")]
		private System.Collections.Hashtable assemblyToIdTable;

		// Token: 0x04001291 RID: 4753
		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0xB8")]
		private SerStack niPool;
	}
}
