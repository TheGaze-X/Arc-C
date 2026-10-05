using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007801 RID: 30721
	[Token(Token = "0x2007801")]
	public class Act1VHalfIdleTechTreeDiagramView : UIDiagramBase<Act1VHalfIdleTechTreeNodeView>
	{
		// Token: 0x170064D2 RID: 25810
		// (get) Token: 0x0602B191 RID: 176529 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B190 RID: 176528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064D2")]
		public Action<string> onNodeClick
		{
			[Token(Token = "0x602B191")]
			[Address(RVA = "0x26E7620", Offset = "0x26E6220", VA = "0x1826E7620")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B190")]
			[Address(RVA = "0x26E7680", Offset = "0x26E6280", VA = "0x1826E7680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B192 RID: 176530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B192")]
		[Address(RVA = "0x26E72F0", Offset = "0x26E5EF0", VA = "0x1826E72F0", Slot = "4")]
		protected override Act1VHalfIdleTechTreeNodeView GetPrefab(string key)
		{
			return null;
		}

		// Token: 0x0602B193 RID: 176531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B193")]
		[Address(RVA = "0x26E7460", Offset = "0x26E6060", VA = "0x1826E7460", Slot = "5")]
		protected override void RenderNode(string key, Act1VHalfIdleTechTreeNodeView obj)
		{
		}

		// Token: 0x0602B194 RID: 176532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B194")]
		[Address(RVA = "0x26E75B0", Offset = "0x26E61B0", VA = "0x1826E75B0")]
		public Act1VHalfIdleTechTreeDiagramView()
		{
		}

		// Token: 0x0403E46B RID: 255083
		[Token(Token = "0x403E46B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act1VHalfIdleTechTreeNodeView _nodeViewPrefab;

		// Token: 0x0403E46C RID: 255084
		[Token(Token = "0x403E46C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act1VHalfIdleTechTreeNodeView _bigNodeViewPrefab;

		// Token: 0x0403E46E RID: 255086
		[Token(Token = "0x403E46E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onNodeClick;

		// Token: 0x0403E46F RID: 255087
		[Token(Token = "0x403E46F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onNodeClick;

		// Token: 0x0403E470 RID: 255088
		[Token(Token = "0x403E470")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x0403E471 RID: 255089
		[Token(Token = "0x403E471")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderNode;

		// Token: 0x0403E472 RID: 255090
		[Token(Token = "0x403E472")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
