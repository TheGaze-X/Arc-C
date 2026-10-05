using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace XNode
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[Serializable]
	public class NodePort
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x1700001D")]
		public int ConnectionCount
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x5BDAE90", Offset = "0x5BD9A90", VA = "0x185BDAE90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001E")]
		public NodePort Connection
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x5BDAED0", Offset = "0x5BD9AD0", VA = "0x185BDAED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public NodePort.IO direction
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return NodePort.IO.Input;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			internal set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public Node.ConnectionType connectionType
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			get
			{
				return Node.ConnectionType.Multiple;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
			internal set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002250 File Offset: 0x00000450
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public Node.TypeConstraint typeConstraint
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return Node.TypeConstraint.None;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
			internal set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x17000022")]
		public bool IsConnected
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x5BDAF90", Offset = "0x5BD9B90", VA = "0x185BDAF90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x17000023")]
		public bool IsInput
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x5BDAFE0", Offset = "0x5BD9BE0", VA = "0x185BDAFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x17000024")]
		public bool IsOutput
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x5BDAFF0", Offset = "0x5BD9BF0", VA = "0x185BDAFF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000025")]
		public string fieldName
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000026")]
		public Node node
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x17000027")]
		public bool IsDynamic
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x220E7B0", Offset = "0x220D3B0", VA = "0x18220E7B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000028")]
		public bool IsStatic
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x5BDB000", Offset = "0x5BD9C00", VA = "0x185BDB000")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public Type ValueType
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x5BDB010", Offset = "0x5BD9C10", VA = "0x185BDB010")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x5BDB0F0", Offset = "0x5BD9CF0", VA = "0x185BDB0F0")]
			set
			{
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x5BDAB90", Offset = "0x5BD9790", VA = "0x185BDAB90")]
		public NodePort(FieldInfo fieldInfo)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x5BDAAA0", Offset = "0x5BD96A0", VA = "0x185BDAAA0")]
		public NodePort(NodePort nodePort, Node node)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x5BDA9A0", Offset = "0x5BD95A0", VA = "0x185BDA9A0")]
		public NodePort(string fieldName, Type type, NodePort.IO direction, Node.ConnectionType connectionType, Node.TypeConstraint typeConstraint, Node node)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x5BDA820", Offset = "0x5BD9420", VA = "0x185BDA820")]
		public void VerifyConnections()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x5BDA040", Offset = "0x5BD8C40", VA = "0x185BDA040")]
		public object GetOutputValue()
		{
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x5BD9D90", Offset = "0x5BD8990", VA = "0x185BD9D90")]
		public object GetInputValue()
		{
			return null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x5BD9EB0", Offset = "0x5BD8AB0", VA = "0x185BD9EB0")]
		public object[] GetInputValues()
		{
			return null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AD")]
		public T GetInputValue<T>()
		{
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AE")]
		public T[] GetInputValues<T>()
		{
			return null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000AF")]
		public bool TryGetInputValue<T>(out T value)
		{
			return default(bool);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x5BD9BE0", Offset = "0x5BD87E0", VA = "0x185BD9BE0")]
		public float GetInputSum(float fallback)
		{
			return 0f;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x5BD9CB0", Offset = "0x5BD88B0", VA = "0x185BD9CB0")]
		public int GetInputSum(int fallback)
		{
			return 0;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x5BD9290", Offset = "0x5BD7E90", VA = "0x185BD9290")]
		public void Connect(NodePort port)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x5BD9B00", Offset = "0x5BD8700", VA = "0x185BD9B00")]
		public List<NodePort> GetConnections()
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x5BD99A0", Offset = "0x5BD85A0", VA = "0x185BD99A0")]
		public NodePort GetConnection(int i)
		{
			return null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x5BD98F0", Offset = "0x5BD84F0", VA = "0x185BD98F0")]
		public int GetConnectionIndex(NodePort port)
		{
			return 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x5BDA100", Offset = "0x5BD8D00", VA = "0x185BDA100")]
		public bool IsConnectedTo(NodePort port)
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x5BD8EF0", Offset = "0x5BD7AF0", VA = "0x185BD8EF0")]
		public bool CanConnectTo(NodePort port)
		{
			return default(bool);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x5BD95E0", Offset = "0x5BD81E0", VA = "0x185BD95E0")]
		public void Disconnect(NodePort port)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x5BD9750", Offset = "0x5BD8350", VA = "0x185BD9750")]
		public void Disconnect(int i)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x5BD91F0", Offset = "0x5BD7DF0", VA = "0x185BD91F0")]
		public void ClearConnections()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5BDA0A0", Offset = "0x5BD8CA0", VA = "0x185BDA0A0")]
		public List<Vector2> GetReroutePoints(int index)
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5BDA4A0", Offset = "0x5BD90A0", VA = "0x185BDA4A0")]
		public void SwapConnections(NodePort targetPort)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5BD8E20", Offset = "0x5BD7A20", VA = "0x185BD8E20")]
		public void AddConnections(NodePort targetPort)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x5BDA1C0", Offset = "0x5BD8DC0", VA = "0x185BDA1C0")]
		public void MoveConnections(NodePort targetPort)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5BDA310", Offset = "0x5BD8F10", VA = "0x185BDA310")]
		public void Redirect(List<Node> oldNodes, List<Node> newNodes)
		{
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x10")]
		private Type valueType;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _fieldName;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Node _node;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _typeQualifiedName;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<NodePort.PortConnection> connections;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private NodePort.IO _direction;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Node.ConnectionType _connectionType;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Node.TypeConstraint _typeConstraint;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _dynamic;

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		public enum IO
		{
			// Token: 0x0400005A RID: 90
			[Token(Token = "0x400005A")]
			Input,
			// Token: 0x0400005B RID: 91
			[Token(Token = "0x400005B")]
			Output
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		[Serializable]
		private class PortConnection
		{
			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700002A")]
			public NodePort Port
			{
				[Token(Token = "0x60000C1")]
				[Address(RVA = "0x5BDCA90", Offset = "0x5BDB690", VA = "0x185BDCA90")]
				get
				{
					return null;
				}
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x5BDC9C0", Offset = "0x5BDB5C0", VA = "0x185BDC9C0")]
			public PortConnection(NodePort port)
			{
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x5BDC920", Offset = "0x5BDB520", VA = "0x185BDC920")]
			private NodePort GetPort()
			{
				return null;
			}

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string fieldName;

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public Node node;

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x20")]
			[NonSerialized]
			private NodePort port;

			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public List<Vector2> reroutePoints;
		}
	}
}
