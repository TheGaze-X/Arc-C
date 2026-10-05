using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace XNode
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Serializable]
	public abstract class Node : ScriptableObject
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000004")]
		[Obsolete("Use DynamicPorts instead")]
		public IEnumerable<NodePort> InstancePorts
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x5BDC730", Offset = "0x5BDB330", VA = "0x185BDC730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000005")]
		[Obsolete("Use DynamicOutputs instead")]
		public IEnumerable<NodePort> InstanceOutputs
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x5BDC5B0", Offset = "0x5BDB1B0", VA = "0x185BDC5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000006")]
		[Obsolete("Use DynamicInputs instead")]
		public IEnumerable<NodePort> InstanceInputs
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5BDC530", Offset = "0x5BDB130", VA = "0x185BDC530")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5BDB290", Offset = "0x5BD9E90", VA = "0x185BDB290")]
		[Obsolete("Use AddDynamicInput instead")]
		public NodePort AddInstanceInput(Type type, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] string fieldName)
		{
			return null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5BDB2C0", Offset = "0x5BD9EC0", VA = "0x185BDB2C0")]
		[Obsolete("Use AddDynamicOutput instead")]
		public NodePort AddInstanceOutput(Type type, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] string fieldName)
		{
			return null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5BDB920", Offset = "0x5BDA520", VA = "0x185BDB920")]
		[Obsolete("Use AddDynamicPort instead")]
		private NodePort AddInstancePort(Type type, NodePort.IO direction, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] string fieldName)
		{
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5BDC140", Offset = "0x5BDAD40", VA = "0x185BDC140")]
		[Obsolete("Use RemoveDynamicPort instead")]
		public void RemoveInstancePort(string fieldName)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5BDC200", Offset = "0x5BDAE00", VA = "0x185BDC200")]
		[Obsolete("Use RemoveDynamicPort instead")]
		public void RemoveInstancePort(NodePort port)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5BDBD40", Offset = "0x5BDA940", VA = "0x185BDBD40")]
		[Obsolete("Use ClearDynamicPorts instead")]
		public void ClearInstancePorts()
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000007")]
		public IEnumerable<NodePort> Ports
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x5BDC7C0", Offset = "0x5BDB3C0", VA = "0x185BDC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000008")]
		public IEnumerable<NodePort> Outputs
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x5BDC740", Offset = "0x5BDB340", VA = "0x185BDC740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000009")]
		public IEnumerable<NodePort> Inputs
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x5BDC6B0", Offset = "0x5BDB2B0", VA = "0x185BDC6B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000A")]
		public IEnumerable<NodePort> DynamicPorts
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x5BDC630", Offset = "0x5BDB230", VA = "0x185BDC630")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000B")]
		public IEnumerable<NodePort> DynamicOutputs
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x5BDC5B0", Offset = "0x5BDB1B0", VA = "0x185BDC5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000C")]
		public IEnumerable<NodePort> DynamicInputs
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x5BDC530", Offset = "0x5BDB130", VA = "0x185BDC530")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x1700000D")]
		public virtual bool isHide
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5BDBF30", Offset = "0x5BDAB30", VA = "0x185BDBF30")]
		protected void OnEnable()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5BDC210", Offset = "0x5BDAE10", VA = "0x185BDC210")]
		public void UpdatePorts()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void Init()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5BDC220", Offset = "0x5BDAE20", VA = "0x185BDC220")]
		public void VerifyConnections()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5BDB290", Offset = "0x5BD9E90", VA = "0x185BDB290")]
		public NodePort AddDynamicInput(Type type, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] string fieldName)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5BDB2C0", Offset = "0x5BD9EC0", VA = "0x185BDB2C0")]
		public NodePort AddDynamicOutput(Type type, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] string fieldName)
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5BDB6C0", Offset = "0x5BDA2C0", VA = "0x185BDB6C0")]
		private NodePort AddDynamicPort(Type type, NodePort.IO direction, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] string fieldName)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5BDB2F0", Offset = "0x5BD9EF0", VA = "0x185BDB2F0")]
		public ParamNodePort AddDynamicParamInput(Type type, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] FieldInfo field, [Optional] object param, [Optional] string labelText)
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5BDB340", Offset = "0x5BD9F40", VA = "0x185BDB340")]
		public ParamNodePort AddDynamicParamOutput(Type type, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] FieldInfo field, [Optional] object param, [Optional] string labelText)
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5BDB390", Offset = "0x5BD9F90", VA = "0x185BDB390")]
		private ParamNodePort AddDynamicParamPort(Type type, NodePort.IO direction, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, [Optional] FieldInfo field, [Optional] object param, [Optional] string labelText)
		{
			return null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5BDC140", Offset = "0x5BDAD40", VA = "0x185BDC140")]
		public void RemoveDynamicPort(string fieldName)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5BDC030", Offset = "0x5BDAC30", VA = "0x185BDC030")]
		public void RemoveDynamicPort(NodePort port)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5BDBB00", Offset = "0x5BDA700", VA = "0x185BDBB00")]
		public void ClearDynamicPorts()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x5BDBD70", Offset = "0x5BDA970", VA = "0x185BDBD70")]
		public NodePort GetOutputPort(string fieldName)
		{
			return null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5BDBD50", Offset = "0x5BDA950", VA = "0x185BDBD50")]
		public NodePort GetInputPort(string fieldName)
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5BDBD90", Offset = "0x5BDA990", VA = "0x185BDBD90")]
		public NodePort GetPort(string fieldName)
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x5BDBED0", Offset = "0x5BDAAD0", VA = "0x185BDBED0")]
		public bool HasPort(string fieldName)
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000027")]
		public T GetInputValue<T>(string fieldName, [Optional] T fallback)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000028")]
		public T[] GetInputValues<T>(string fieldName, params T[] fallback)
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5BDBE10", Offset = "0x5BDAA10", VA = "0x185BDBE10", Slot = "6")]
		public virtual object GetValue(NodePort port)
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void OnCreateConnection(NodePort from, NodePort to)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void OnRemoveConnection(NodePort port)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5BDB930", Offset = "0x5BDA530", VA = "0x185BDB930")]
		public void ClearConnections()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5BDC3F0", Offset = "0x5BDAFF0", VA = "0x185BDC3F0")]
		protected Node()
		{
		}

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public NodeGraph graph;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Vector2 position;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Node.NodePortDictionary ports;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static NodeGraph graphHotfix;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		public enum ShowBackingValue
		{
			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			Never,
			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			Unconnected,
			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			Always
		}

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		public enum ConnectionType
		{
			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			Multiple,
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			Override
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		public enum TypeConstraint
		{
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			None,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			Inherited,
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			Strict,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			InheritedInverse,
			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			InheritedAny
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		[AttributeUsage(AttributeTargets.Field)]
		public class InputAttribute : Attribute
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600002E RID: 46 RVA: 0x00002088 File Offset: 0x00000288
			// (set) Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000E")]
			[Obsolete("Use dynamicPortList instead")]
			public bool instancePortList
			{
				[Token(Token = "0x600002E")]
				[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600002F")]
				[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
				set
				{
				}
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x5BD6340", Offset = "0x5BD4F40", VA = "0x185BD6340")]
			public InputAttribute(Node.ShowBackingValue backingValue = Node.ShowBackingValue.Unconnected, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, bool dynamicPortList = false)
			{
			}

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node.ShowBackingValue backingValue;

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Node.ConnectionType connectionType;

			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool dynamicPortList;

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Node.TypeConstraint typeConstraint;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		[AttributeUsage(AttributeTargets.Field)]
		public class OutputAttribute : Attribute
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000031 RID: 49 RVA: 0x000020A0 File Offset: 0x000002A0
			// (set) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000F")]
			[Obsolete("Use dynamicPortList instead")]
			public bool instancePortList
			{
				[Token(Token = "0x6000031")]
				[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000032")]
				[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
				set
				{
				}
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x5BD6340", Offset = "0x5BD4F40", VA = "0x185BD6340")]
			public OutputAttribute(Node.ShowBackingValue backingValue = Node.ShowBackingValue.Never, Node.ConnectionType connectionType = Node.ConnectionType.Multiple, Node.TypeConstraint typeConstraint = Node.TypeConstraint.None, bool dynamicPortList = false)
			{
			}

			// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x5BDC840", Offset = "0x5BDB440", VA = "0x185BDC840")]
			[Obsolete("Use constructor with TypeConstraint")]
			public OutputAttribute(Node.ShowBackingValue backingValue, Node.ConnectionType connectionType, bool dynamicPortList)
			{
			}

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node.ShowBackingValue backingValue;

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Node.ConnectionType connectionType;

			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool dynamicPortList;

			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Node.TypeConstraint typeConstraint;
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
		public class CreateNodeMenuAttribute : Attribute
		{
			// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x59471C0", Offset = "0x5945DC0", VA = "0x1859471C0")]
			public CreateNodeMenuAttribute(string menuName)
			{
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x37442C0", Offset = "0x3742EC0", VA = "0x1837442C0")]
			public CreateNodeMenuAttribute(string menuName, int order)
			{
			}

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string menuName;

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int order;
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
		public class DisallowMultipleNodesAttribute : Attribute
		{
			// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
			public DisallowMultipleNodesAttribute(int max = 1)
			{
			}

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int max;
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
		public class NodeTintAttribute : Attribute
		{
			// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x58F9D00", Offset = "0x58F8900", VA = "0x1858F9D00")]
			public NodeTintAttribute(float r, float g, float b)
			{
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x5BDB260", Offset = "0x5BD9E60", VA = "0x185BDB260")]
			public NodeTintAttribute(string hex)
			{
			}

			// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x5BDB1A0", Offset = "0x5BD9DA0", VA = "0x185BDB1A0")]
			public NodeTintAttribute(byte r, byte g, byte b)
			{
			}

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color color;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
		public class NodeWidthAttribute : Attribute
		{
			// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
			public NodeWidthAttribute(int width)
			{
			}

			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int width;
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		[Serializable]
		private class NodePortDictionary : Dictionary<string, NodePort>, ISerializationCallbackReceiver
		{
			// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x5BD8B50", Offset = "0x5BD7750", VA = "0x185BD8B50", Slot = "42")]
			public void OnBeforeSerialize()
			{
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x5BD8870", Offset = "0x5BD7470", VA = "0x185BD8870", Slot = "43")]
			public void OnAfterDeserialize()
			{
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x5BD8D40", Offset = "0x5BD7940", VA = "0x185BD8D40")]
			public NodePortDictionary()
			{
			}

			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[SerializeField]
			private List<string> keys;

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[SerializeField]
			private List<NodePort> values;
		}
	}
}
