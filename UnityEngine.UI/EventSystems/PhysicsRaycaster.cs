using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[AddComponentMenu("Event/Physics Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class PhysicsRaycaster : BaseRaycaster
	{
		// Token: 0x060007BE RID: 1982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x5B8DC00", Offset = "0x5B8C800", VA = "0x185B8DC00")]
		protected PhysicsRaycaster()
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020D")]
		public override Camera eventCamera
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x5B8E5A0", Offset = "0x5B8D1A0", VA = "0x185B8E5A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x1700020E")]
		public virtual int depth
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x5B8E4C0", Offset = "0x5B8D0C0", VA = "0x185B8E4C0", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x1700020F")]
		public int finalEventMask
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x5B8E650", Offset = "0x5B8D250", VA = "0x185B8E650")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x000050E8 File Offset: 0x000032E8
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000210")]
		public LayerMask eventMask
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00005100 File Offset: 0x00003300
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000211")]
		public int maxRayIntersections
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
			set
			{
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x5B8DC30", Offset = "0x5B8C830", VA = "0x185B8DC30")]
		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
		{
			return default(bool);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x5B8DFA0", Offset = "0x5B8CBA0", VA = "0x185B8DFA0", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		protected const int kNoEventMaskSet = -1;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x20")]
		protected Camera m_EventCamera;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected LayerMask m_EventMask;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected int m_MaxRayIntersections;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x30")]
		protected int m_LastMaxRayIntersections;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x38")]
		private RaycastHit[] m_Hits;

		// Token: 0x020000D9 RID: 217
		[Token(Token = "0x20000D9")]
		private class RaycastHitComparer : IComparer<RaycastHit>
		{
			// Token: 0x060007C8 RID: 1992 RVA: 0x00005130 File Offset: 0x00003330
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x5B91900", Offset = "0x5B90500", VA = "0x185B91900", Slot = "4")]
			public int Compare(RaycastHit x, RaycastHit y)
			{
				return 0;
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RaycastHitComparer()
			{
			}

			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			[FieldOffset(Offset = "0x0")]
			public static PhysicsRaycaster.RaycastHitComparer instance;
		}
	}
}
