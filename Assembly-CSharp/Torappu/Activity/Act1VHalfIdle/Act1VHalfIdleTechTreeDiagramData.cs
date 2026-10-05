using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007806 RID: 30726
	[Token(Token = "0x2007806")]
	public class Act1VHalfIdleTechTreeDiagramData : UIDiagramBase<Act1VHalfIdleTechTreeNodeView>.IDataSource
	{
		// Token: 0x170064DF RID: 25823
		// (get) Token: 0x0602B1BF RID: 176575 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B1C0 RID: 176576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064DF")]
		public string selectedNodeId
		{
			[Token(Token = "0x602B1BF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B1C0")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170064E0 RID: 25824
		// (get) Token: 0x0602B1C1 RID: 176577 RVA: 0x000DAE38 File Offset: 0x000D9038
		[Token(Token = "0x170064E0")]
		public Vector2 diagramSize
		{
			[Token(Token = "0x602B1C1")]
			[Address(RVA = "0x26FA000", Offset = "0x26F8C00", VA = "0x1826FA000", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0602B1C2 RID: 176578 RVA: 0x000DAE50 File Offset: 0x000D9050
		[Token(Token = "0x602B1C2")]
		[Address(RVA = "0x26F9C60", Offset = "0x26F8860", VA = "0x1826F9C60", Slot = "5")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x0602B1C3 RID: 176579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1C3")]
		[Address(RVA = "0x26F9CC0", Offset = "0x26F88C0", VA = "0x1826F9CC0", Slot = "7")]
		public void FillLinePos(int grpIdx, List<Vector2> linePointList)
		{
		}

		// Token: 0x0602B1C4 RID: 176580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B1C4")]
		[Address(RVA = "0x26F9EE0", Offset = "0x26F8AE0", VA = "0x1826F9EE0", Slot = "6")]
		public IEnumerable<string> IterKeys()
		{
			return null;
		}

		// Token: 0x0602B1C5 RID: 176581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1C5")]
		[Address(RVA = "0x26F9F30", Offset = "0x26F8B30", VA = "0x1826F9F30")]
		public Act1VHalfIdleTechTreeDiagramData()
		{
		}

		// Token: 0x0403E4BA RID: 255162
		[Token(Token = "0x403E4BA")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 size;

		// Token: 0x0403E4BB RID: 255163
		[Token(Token = "0x403E4BB")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act1VHalfIdleTechTreeNodeViewModel> nodes;

		// Token: 0x0403E4BC RID: 255164
		[Token(Token = "0x403E4BC")]
		[FieldOffset(Offset = "0x20")]
		public List<Act1VHalfIdleTechTreeDiagramLine> lines;

		// Token: 0x0403E4BE RID: 255166
		[Token(Token = "0x403E4BE")]
		private const int LINE_GROUP_UNLOCK = 0;

		// Token: 0x0403E4BF RID: 255167
		[Token(Token = "0x403E4BF")]
		private const int LINE_GROUP_LOCKED = 1;
	}
}
