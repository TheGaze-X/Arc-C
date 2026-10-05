using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class BinaryFormatter : IFormatter
	{
		// Token: 0x17000457 RID: 1111
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000457")]
		public FormatterAssemblyStyle AssemblyFormat
		{
			[Token(Token = "0x60020F1")]
			[Address(RVA = "0x4A83F60", Offset = "0x4A82B60", VA = "0x184A83F60")]
			set
			{
			}
		}

		// Token: 0x17000458 RID: 1112
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000458")]
		public ISurrogateSelector SurrogateSelector
		{
			[Token(Token = "0x60020F2")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x4B95800", Offset = "0x4B94400", VA = "0x184B95800")]
		public BinaryFormatter()
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x4B95870", Offset = "0x4B94470", VA = "0x184B95870")]
		public BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
		{
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x4B95170", Offset = "0x4B93D70", VA = "0x184B95170", Slot = "4")]
		public object Deserialize(System.IO.Stream serializationStream)
		{
			return null;
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x4B94E50", Offset = "0x4B93A50", VA = "0x184B94E50")]
		internal object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler, bool fCheck)
		{
			return null;
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x4B95150", Offset = "0x4B93D50", VA = "0x184B95150", Slot = "6")]
		public object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler)
		{
			return null;
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x4B95750", Offset = "0x4B94350", VA = "0x184B95750", Slot = "7")]
		public void Serialize(System.IO.Stream serializationStream, object graph)
		{
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x4B95460", Offset = "0x4B94060", VA = "0x184B95460", Slot = "8")]
		public void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers)
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x4B95480", Offset = "0x4B94080", VA = "0x184B95480")]
		internal void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers, bool fCheck)
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x4B95190", Offset = "0x4B93D90", VA = "0x184B95190")]
		internal static TypeInformation GetTypeInformation(System.Type type)
		{
			return null;
		}

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal ISurrogateSelector m_surrogates;

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal StreamingContext m_context;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal SerializationBinder m_binder;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal FormatterTypeStyle m_typeFormat;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal FormatterAssemblyStyle m_assemblyFormat;

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal TypeFilterLevel m_securityLevel;

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal object[] m_crossAppDomainArray;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Collections.Generic.Dictionary<System.Type, TypeInformation> typeNameCache;
	}
}
