using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[AddComponentMenu("Event/Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class GraphicRaycaster : BaseRaycaster
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x17000045")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x5A146D0", Offset = "0x5A132D0", VA = "0x185A146D0", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x17000046")]
		public override int renderOrderPriority
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x5A14670", Offset = "0x5A13270", VA = "0x185A14670", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002508 File Offset: 0x00000708
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000047")]
		public bool ignoreReversedGraphics
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000048")]
		public GraphicRaycaster.BlockingObjects blockingObjects
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return GraphicRaycaster.BlockingObjects.None;
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002538 File Offset: 0x00000738
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000049")]
		public LayerMask blockingMask
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x5A14470", Offset = "0x5A13070", VA = "0x185A14470")]
		protected GraphicRaycaster()
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		private Canvas canvas
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x5A14510", Offset = "0x5A13110", VA = "0x185A14510")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x5A13350", Offset = "0x5A11F50", VA = "0x185A13350", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		public override Camera eventCamera
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x5A145B0", Offset = "0x5A131B0", VA = "0x185A145B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x5A12DB0", Offset = "0x5A119B0", VA = "0x185A12DB0")]
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		protected const int kNoEventMaskSet = -1;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("ignoreReversedGraphics")]
		private bool m_IgnoreReversedGraphics;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("blockingObjects")]
		[SerializeField]
		private GraphicRaycaster.BlockingObjects m_BlockingObjects;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected LayerMask m_BlockingMask;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x30")]
		private Canvas m_Canvas;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private List<Graphic> m_RaycastResults;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics;

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		public enum BlockingObjects
		{
			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			None,
			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			TwoD,
			// Token: 0x0400008B RID: 139
			[Token(Token = "0x400008B")]
			ThreeD,
			// Token: 0x0400008C RID: 140
			[Token(Token = "0x400008C")]
			All
		}
	}
}
