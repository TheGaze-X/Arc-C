using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044FA RID: 17658
	[Token(Token = "0x20044FA")]
	public class RoguelikeCommonOuterBuffContentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x0601AF2B RID: 110379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FFD")]
		public List<RoguelikeCommonOuterBuffNodeBase> nodes
		{
			[Token(Token = "0x601AF2B")]
			[Address(RVA = "0x141A740", Offset = "0x1419340", VA = "0x18141A740")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AF2C RID: 110380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF2C")]
		[Address(RVA = "0x1419D20", Offset = "0x1418920", VA = "0x181419D20")]
		public void Init(RoguelikeCommonOuterBuffViewModel viewModel)
		{
		}

		// Token: 0x0601AF2D RID: 110381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF2D")]
		[Address(RVA = "0x141A0A0", Offset = "0x1418CA0", VA = "0x18141A0A0")]
		public void Render(RoguelikeCommonOuterBuffViewModel viewModel)
		{
		}

		// Token: 0x0601AF2E RID: 110382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF2E")]
		[Address(RVA = "0x141A260", Offset = "0x1418E60", VA = "0x18141A260")]
		private void _InactiveNode(RoguelikeCommonOuterBuffNodeBase nodeView)
		{
		}

		// Token: 0x0601AF2F RID: 110383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF2F")]
		[Address(RVA = "0x141A5B0", Offset = "0x14191B0", VA = "0x18141A5B0")]
		private void _InitContentWidth(float maxAnchorX)
		{
		}

		// Token: 0x0601AF30 RID: 110384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF30")]
		[Address(RVA = "0x141A680", Offset = "0x1419280", VA = "0x18141A680")]
		public RoguelikeCommonOuterBuffContentView()
		{
		}

		// Token: 0x0402293C RID: 141628
		[Token(Token = "0x402293C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RoguelikeCommonOuterBuffNodeBase> _nodes;

		// Token: 0x0402293D RID: 141629
		[Token(Token = "0x402293D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _paddingRight;

		// Token: 0x0402293E RID: 141630
		[Token(Token = "0x402293E")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<string> onNodeClick;

		// Token: 0x0402293F RID: 141631
		[Token(Token = "0x402293F")]
		private const float MIN_NODE_POS = 0f;

		// Token: 0x04022940 RID: 141632
		[Token(Token = "0x4022940")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodes;

		// Token: 0x04022941 RID: 141633
		[Token(Token = "0x4022941")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022942 RID: 141634
		[Token(Token = "0x4022942")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022943 RID: 141635
		[Token(Token = "0x4022943")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InactiveNode;

		// Token: 0x04022944 RID: 141636
		[Token(Token = "0x4022944")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitContentWidth;

		// Token: 0x04022945 RID: 141637
		[Token(Token = "0x4022945")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
