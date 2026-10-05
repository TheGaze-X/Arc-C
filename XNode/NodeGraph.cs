using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XNode
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[Serializable]
	public abstract class NodeGraph : ScriptableObject
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000088")]
		public T AddNode<T>() where T : Node
		{
			return null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5BD8000", Offset = "0x5BD6C00", VA = "0x185BD8000", Slot = "4")]
		public virtual Node AddNode(Type type)
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x5BD8280", Offset = "0x5BD6E80", VA = "0x185BD8280", Slot = "5")]
		public virtual Node CopyNode(Node original)
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5BD8740", Offset = "0x5BD7340", VA = "0x185BD8740", Slot = "6")]
		public virtual void RemoveNode(Node node)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5BD8170", Offset = "0x5BD6D70", VA = "0x185BD8170", Slot = "7")]
		public virtual void Clear()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x5BD8370", Offset = "0x5BD6F70", VA = "0x185BD8370", Slot = "8")]
		public virtual NodeGraph Copy()
		{
			return null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x3264D80", Offset = "0x3263980", VA = "0x183264D80", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5BD87E0", Offset = "0x5BD73E0", VA = "0x185BD87E0")]
		protected NodeGraph()
		{
		}

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<Node> nodes;

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
		public class RequireNodeAttribute : Attribute
		{
			// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x5BDD120", Offset = "0x5BDBD20", VA = "0x185BDD120")]
			public RequireNodeAttribute(Type type)
			{
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x5BDD0C0", Offset = "0x5BDBCC0", VA = "0x185BDD0C0")]
			public RequireNodeAttribute(Type type, Type type2)
			{
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x43CB130", Offset = "0x43C9D30", VA = "0x1843CB130")]
			public RequireNodeAttribute(Type type, Type type2, Type type3)
			{
			}

			// Token: 0x06000093 RID: 147 RVA: 0x000021F0 File Offset: 0x000003F0
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x5BDCFB0", Offset = "0x5BDBBB0", VA = "0x185BDCFB0")]
			public bool Requires(Type type)
			{
				return default(bool);
			}

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x10")]
			public Type type0;

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x18")]
			public Type type1;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			[FieldOffset(Offset = "0x20")]
			public Type type2;
		}

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		public class NotRefreshXNodeGraph : Attribute
		{
			// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public NotRefreshXNodeGraph()
			{
			}
		}
	}
}
