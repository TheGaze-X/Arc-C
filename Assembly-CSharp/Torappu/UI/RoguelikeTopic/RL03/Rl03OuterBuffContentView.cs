using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045C8 RID: 17864
	[Token(Token = "0x20045C8")]
	public class Rl03OuterBuffContentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x0601B2D4 RID: 111316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040BF")]
		public List<Rl03OuterBuffNodeBase> nodes
		{
			[Token(Token = "0x601B2D4")]
			[Address(RVA = "0x14560D0", Offset = "0x1454CD0", VA = "0x1814560D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B2D5 RID: 111317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D5")]
		[Address(RVA = "0x1455700", Offset = "0x1454300", VA = "0x181455700")]
		public void Init(Rl03OuterBuffViewModel viewModel)
		{
		}

		// Token: 0x0601B2D6 RID: 111318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D6")]
		[Address(RVA = "0x1455A40", Offset = "0x1454640", VA = "0x181455A40")]
		public void Render(Rl03OuterBuffViewModel viewModel)
		{
		}

		// Token: 0x0601B2D7 RID: 111319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D7")]
		[Address(RVA = "0x1455BE0", Offset = "0x14547E0", VA = "0x181455BE0")]
		private void _InactiveNode(Rl03OuterBuffNodeBase nodeView)
		{
		}

		// Token: 0x0601B2D8 RID: 111320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D8")]
		[Address(RVA = "0x1455F40", Offset = "0x1454B40", VA = "0x181455F40")]
		private void _InitContentWidth(float maxAnchorX)
		{
		}

		// Token: 0x0601B2D9 RID: 111321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2D9")]
		[Address(RVA = "0x1456010", Offset = "0x1454C10", VA = "0x181456010")]
		public Rl03OuterBuffContentView()
		{
		}

		// Token: 0x0402302C RID: 143404
		[Token(Token = "0x402302C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Rl03OuterBuffNodeBase> _nodes;

		// Token: 0x0402302D RID: 143405
		[Token(Token = "0x402302D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _paddingRight;

		// Token: 0x0402302E RID: 143406
		[Token(Token = "0x402302E")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<string> onNodeClick;

		// Token: 0x0402302F RID: 143407
		[Token(Token = "0x402302F")]
		private const float MIN_NODE_POS = 0f;

		// Token: 0x04023030 RID: 143408
		[Token(Token = "0x4023030")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodes;

		// Token: 0x04023031 RID: 143409
		[Token(Token = "0x4023031")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023032 RID: 143410
		[Token(Token = "0x4023032")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023033 RID: 143411
		[Token(Token = "0x4023033")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InactiveNode;

		// Token: 0x04023034 RID: 143412
		[Token(Token = "0x4023034")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitContentWidth;

		// Token: 0x04023035 RID: 143413
		[Token(Token = "0x4023035")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
