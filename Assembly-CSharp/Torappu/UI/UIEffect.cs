using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Fx;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003AAB RID: 15019
	[Token(Token = "0x2003AAB")]
	public class UIEffect : BasicEffect
	{
		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x06017B93 RID: 97171 RVA: 0x00097D10 File Offset: 0x00095F10
		[Token(Token = "0x170038EC")]
		protected bool overrideSortingLayer
		{
			[Token(Token = "0x6017B93")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017B94 RID: 97172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B94")]
		[Address(RVA = "0xFF5F40", Offset = "0xFF4B40", VA = "0x180FF5F40")]
		public UIEffect()
		{
		}

		// Token: 0x0401CA20 RID: 117280
		[Token(Token = "0x401CA20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Override the sortingLayer of all renderers")]
		private bool _overrideSortingLayer;

		// Token: 0x0401CA21 RID: 117281
		[Token(Token = "0x401CA21")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Inspect("overrideSortingLayer")]
		private SortingLayerWrapper _sortingLayerId;

		// Token: 0x0401CA22 RID: 117282
		[Token(Token = "0x401CA22")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Inspect("overrideSortingLayer")]
		private int _sortingOrderDelta;

		// Token: 0x0401CA23 RID: 117283
		[Token(Token = "0x401CA23")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Override the layer of GameObject")]
		private bool _overrideGoLayerToUI;
	}
}
