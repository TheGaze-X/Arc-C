using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007807 RID: 30727
	[Token(Token = "0x2007807")]
	public class Act1VHalfIdleTechTreeDiagramLine
	{
		// Token: 0x0602B1C6 RID: 176582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1C6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleTechTreeDiagramLine()
		{
		}

		// Token: 0x0403E4C0 RID: 255168
		[Token(Token = "0x403E4C0")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 startPos;

		// Token: 0x0403E4C1 RID: 255169
		[Token(Token = "0x403E4C1")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 endPos;

		// Token: 0x0403E4C2 RID: 255170
		[Token(Token = "0x403E4C2")]
		[FieldOffset(Offset = "0x20")]
		public List<string> startNodeList;

		// Token: 0x0403E4C3 RID: 255171
		[Token(Token = "0x403E4C3")]
		[FieldOffset(Offset = "0x28")]
		public List<string> endNodeList;

		// Token: 0x0403E4C4 RID: 255172
		[Token(Token = "0x403E4C4")]
		[FieldOffset(Offset = "0x30")]
		public bool unlock;
	}
}
