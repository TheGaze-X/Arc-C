using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace XNode
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public static class NodeDataCache
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x1700001C")]
		private static bool Initialized
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x5BD7FC0", Offset = "0x5BD6BC0", VA = "0x185BD7FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x5BD7510", Offset = "0x5BD6110", VA = "0x185BD7510")]
		public static void UpdatePorts(Node node, Dictionary<string, NodePort> ports)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x5BD6F20", Offset = "0x5BD5B20", VA = "0x185BD6F20")]
		private static Type GetBackingValueType(Type portValType)
		{
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x5BD7310", Offset = "0x5BD5F10", VA = "0x185BD7310")]
		private static bool IsDynamicListPort(NodePort port)
		{
			return default(bool);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x5BD6390", Offset = "0x5BD4F90", VA = "0x185BD6390")]
		private static void BuildCache()
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5BD7080", Offset = "0x5BD5C80", VA = "0x185BD7080")]
		public static List<FieldInfo> GetNodeFields(Type nodeType)
		{
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x5BD6860", Offset = "0x5BD5460", VA = "0x185BD6860")]
		private static void CachePorts(Type nodeType)
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		private static NodeDataCache.PortDataCache portDataCache;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		[Serializable]
		private class PortDataCache : Dictionary<Type, List<NodePort>>, ISerializationCallbackReceiver
		{
			// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x5BDCCE0", Offset = "0x5BDB8E0", VA = "0x185BDCCE0", Slot = "42")]
			public void OnBeforeSerialize()
			{
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x5BDCB50", Offset = "0x5BDB750", VA = "0x185BDCB50", Slot = "43")]
			public void OnAfterDeserialize()
			{
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x5BDCED0", Offset = "0x5BDBAD0", VA = "0x185BDCED0")]
			public PortDataCache()
			{
			}

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private List<Type> keys;

			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private List<List<NodePort>> values;
		}
	}
}
