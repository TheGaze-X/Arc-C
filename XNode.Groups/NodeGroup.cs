using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XNode.NodeGroups
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[Node.CreateNodeMenuAttribute("Group")]
	public class NodeGroup : Node
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override object GetValue(NodePort port)
		{
			return null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5BDED50", Offset = "0x5BDD950", VA = "0x185BDED50")]
		public IEnumerable<UnityEngine.Object> GetNodes()
		{
			return null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5BDEFC0", Offset = "0x5BDDBC0", VA = "0x185BDEFC0")]
		public NodeGroup()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x30")]
		public int width;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x34")]
		public int height;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x38")]
		public Color color;
	}
}
