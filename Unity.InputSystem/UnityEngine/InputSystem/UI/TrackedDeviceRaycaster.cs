using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UnityEngine.InputSystem.UI
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Event/Tracked Device Raycaster")]
	public class TrackedDeviceRaycaster : BaseRaycaster
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700038C")]
		public override Camera eventCamera
		{
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x56CCA90", Offset = "0x56CB690", VA = "0x1856CCA90", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00006990 File Offset: 0x00004B90
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038D")]
		public LayerMask blockingMask
		{
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x000069A8 File Offset: 0x00004BA8
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038E")]
		public bool checkFor3DOcclusion
		{
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x37002B0", Offset = "0x36FEEB0", VA = "0x1837002B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x37002D0", Offset = "0x36FEED0", VA = "0x1837002D0")]
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x000069C0 File Offset: 0x00004BC0
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038F")]
		public bool checkFor2DOcclusion
		{
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
			set
			{
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000069D8 File Offset: 0x00004BD8
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000390")]
		public bool ignoreReversedGraphics
		{
			[Token(Token = "0x6000D80")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D81")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000069F0 File Offset: 0x00004BF0
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000391")]
		public float maxDistance
		{
			[Token(Token = "0x6000D82")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D83")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x56CB710", Offset = "0x56CA310", VA = "0x1856CB710", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x56CB630", Offset = "0x56CA230", VA = "0x1856CB630", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x56CC240", Offset = "0x56CAE40", VA = "0x1856CC240", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x56CB790", Offset = "0x56CA390", VA = "0x1856CB790")]
		internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x56CC2F0", Offset = "0x56CAEF0", VA = "0x1856CC2F0")]
		private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<TrackedDeviceRaycaster.RaycastHitData> results)
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x56CBDE0", Offset = "0x56CA9E0", VA = "0x1856CBDE0")]
		private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance)
		{
			return default(bool);
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000392")]
		private Canvas canvas
		{
			[Token(Token = "0x6000D8A")]
			[Address(RVA = "0x56CC9F0", Offset = "0x56CB5F0", VA = "0x1856CC9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x56CC960", Offset = "0x56CB560", VA = "0x1856CC960")]
		public TrackedDeviceRaycaster()
		{
		}

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private List<TrackedDeviceRaycaster.RaycastHitData> m_RaycastResultsCache;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x0")]
		internal static InlinedArray<TrackedDeviceRaycaster> s_Instances;

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<TrackedDeviceRaycaster.RaycastHitData> s_SortedGraphics;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("ignoreReversedGraphics")]
		private bool m_IgnoreReversedGraphics;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x29")]
		[FormerlySerializedAs("checkFor2DOcclusion")]
		[SerializeField]
		private bool m_CheckFor2DOcclusion;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x2A")]
		[FormerlySerializedAs("checkFor3DOcclusion")]
		[SerializeField]
		private bool m_CheckFor3DOcclusion;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("Maximum distance (in 3D world space) that rays are traced to find a hit.")]
		private float m_MaxDistance;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayerMask m_BlockingMask;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x0200011A RID: 282
		[Token(Token = "0x200011A")]
		private struct RaycastHitData
		{
			// Token: 0x06000D8D RID: 3469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D8D")]
			[Address(RVA = "0x56C94F0", Offset = "0x56C80F0", VA = "0x1856C94F0")]
			public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance)
			{
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000393")]
			public readonly Graphic graphic
			{
				[Token(Token = "0x6000D8E")]
				[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00006A20 File Offset: 0x00004C20
			[Token(Token = "0x17000394")]
			public readonly Vector3 worldHitPosition
			{
				[Token(Token = "0x6000D8F")]
				[Address(RVA = "0x40076E0", Offset = "0x40062E0", VA = "0x1840076E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00006A38 File Offset: 0x00004C38
			[Token(Token = "0x17000395")]
			public readonly Vector2 screenPosition
			{
				[Token(Token = "0x6000D90")]
				[Address(RVA = "0x56C9550", Offset = "0x56C8150", VA = "0x1856C9550")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00006A50 File Offset: 0x00004C50
			[Token(Token = "0x17000396")]
			public readonly float distance
			{
				[Token(Token = "0x6000D91")]
				[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}
		}
	}
}
