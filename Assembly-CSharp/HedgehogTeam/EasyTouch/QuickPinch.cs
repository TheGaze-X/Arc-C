using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x020001FE RID: 510
	[Token(Token = "0x20001FE")]
	[AddComponentMenu("EasyTouch/Quick Pinch")]
	public class QuickPinch : QuickBase
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x2533100", Offset = "0x2531D00", VA = "0x182533100")]
		public QuickPinch()
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x2532D90", Offset = "0x2531990", VA = "0x182532D90", Slot = "5")]
		public override void OnEnable()
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x2532D80", Offset = "0x2531980", VA = "0x182532D80", Slot = "6")]
		public override void OnDisable()
		{
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x2532D80", Offset = "0x2531980", VA = "0x182532D80")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x2532F90", Offset = "0x2531B90", VA = "0x182532F90")]
		private void UnsubscribeEvent()
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x2532F70", Offset = "0x2531B70", VA = "0x182532F70")]
		private void On_Pinch(Gesture gesture)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x2532F10", Offset = "0x2531B10", VA = "0x182532F10")]
		private void On_PinchIn(Gesture gesture)
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x2532F40", Offset = "0x2531B40", VA = "0x182532F40")]
		private void On_PinchOut(Gesture gesture)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x2532F00", Offset = "0x2531B00", VA = "0x182532F00")]
		private void On_PichEnd(Gesture gesture)
		{
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x2532B60", Offset = "0x2531760", VA = "0x182532B60")]
		private void DoAction(Gesture gesture)
		{
		}

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4000B28")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public QuickPinch.OnPinchAction onPinchAction;

		// Token: 0x04000B29 RID: 2857
		[Token(Token = "0x4000B29")]
		[FieldOffset(Offset = "0x78")]
		public bool isGestureOnMe;

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0x7C")]
		public QuickPinch.ActionTiggering actionTriggering;

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4000B2B")]
		[FieldOffset(Offset = "0x80")]
		public QuickPinch.ActionPinchDirection pinchDirection;

		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4000B2C")]
		[FieldOffset(Offset = "0x84")]
		private float axisActionValue;

		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4000B2D")]
		[FieldOffset(Offset = "0x88")]
		public bool enableSimpleAction;

		// Token: 0x020001FF RID: 511
		[Token(Token = "0x20001FF")]
		[Serializable]
		public class OnPinchAction : UnityEvent<Gesture>
		{
			// Token: 0x060008FB RID: 2299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x252FDA0", Offset = "0x252E9A0", VA = "0x18252FDA0")]
			public OnPinchAction()
			{
			}
		}

		// Token: 0x02000200 RID: 512
		[Token(Token = "0x2000200")]
		public enum ActionTiggering
		{
			// Token: 0x04000B2F RID: 2863
			[Token(Token = "0x4000B2F")]
			InProgress,
			// Token: 0x04000B30 RID: 2864
			[Token(Token = "0x4000B30")]
			End
		}

		// Token: 0x02000201 RID: 513
		[Token(Token = "0x2000201")]
		public enum ActionPinchDirection
		{
			// Token: 0x04000B32 RID: 2866
			[Token(Token = "0x4000B32")]
			All,
			// Token: 0x04000B33 RID: 2867
			[Token(Token = "0x4000B33")]
			PinchIn,
			// Token: 0x04000B34 RID: 2868
			[Token(Token = "0x4000B34")]
			PinchOut
		}
	}
}
