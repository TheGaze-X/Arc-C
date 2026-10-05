using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00002DC0 File Offset: 0x00000FC0
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A5")]
		public AspectRatioFitter.AspectMode aspectMode
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return AspectRatioFitter.AspectMode.None;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x5B55620", Offset = "0x5B54220", VA = "0x185B55620")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A6")]
		public float aspectRatio
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x5B55680", Offset = "0x5B54280", VA = "0x185B55680")]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x5B55580", Offset = "0x5B54180", VA = "0x185B55580")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x5B55570", Offset = "0x5B54170", VA = "0x185B55570")]
		protected AspectRatioFitter()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x5B54F60", Offset = "0x5B53B60", VA = "0x185B54F60", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x5B550B0", Offset = "0x5B53CB0", VA = "0x185B550B0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x5B54EE0", Offset = "0x5B53AE0", VA = "0x185B54EE0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x5B55010", Offset = "0x5B53C10", VA = "0x185B55010", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x5B55550", Offset = "0x5B54150", VA = "0x185B55550", Slot = "19")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x5B55000", Offset = "0x5B53C00", VA = "0x185B55000", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x5B55100", Offset = "0x5B53D00", VA = "0x185B55100")]
		private void UpdateRect()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x5B54C20", Offset = "0x5B53820", VA = "0x185B54C20")]
		private float GetSizeDeltaToProduceSize(float size, int axis)
		{
			return 0f;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x5B54B20", Offset = "0x5B53720", VA = "0x185B54B20")]
		private Vector2 GetParentSize()
		{
			return default(Vector2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x5B55000", Offset = "0x5B53C00", VA = "0x185B55000")]
		protected void SetDirty()
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x5B54E30", Offset = "0x5B53A30", VA = "0x185B54E30")]
		public bool IsComponentValidOnObject()
		{
			return default(bool);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x5B54E10", Offset = "0x5B53A10", VA = "0x185B54E10")]
		public bool IsAspectModeValid()
		{
			return default(bool);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
		private bool DoesParentExists()
		{
			return default(bool);
		}

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AspectRatioFitter.AspectMode m_AspectMode;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_AspectRatio;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x28")]
		private bool m_DelayedSetDirty;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x29")]
		private bool m_DoesParentExist;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x2A")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		public enum AspectMode
		{
			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000134")]
			None,
			// Token: 0x04000135 RID: 309
			[Token(Token = "0x4000135")]
			WidthControlsHeight,
			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000136")]
			HeightControlsWidth,
			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			FitInParent,
			// Token: 0x04000138 RID: 312
			[Token(Token = "0x4000138")]
			EnvelopeParent
		}
	}
}
