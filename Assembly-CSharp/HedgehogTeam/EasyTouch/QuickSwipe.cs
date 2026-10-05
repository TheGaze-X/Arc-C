using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	[AddComponentMenu("EasyTouch/Quick Swipe")]
	public class QuickSwipe : QuickBase
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x2533C90", Offset = "0x2532890", VA = "0x182533C90")]
		public QuickSwipe()
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x2533230", Offset = "0x2531E30", VA = "0x182533230", Slot = "5")]
		public override void OnEnable()
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x2533220", Offset = "0x2531E20", VA = "0x182533220", Slot = "6")]
		public override void OnDisable()
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x2533220", Offset = "0x2531E20", VA = "0x182533220")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x2533B20", Offset = "0x2532720", VA = "0x182533B20")]
		private void UnsubscribeEvent()
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x2533900", Offset = "0x2532500", VA = "0x182533900")]
		private void On_Swipe(Gesture gesture)
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x2533690", Offset = "0x2532290", VA = "0x182533690")]
		private void On_SwipeEnd(Gesture gesture)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x25333A0", Offset = "0x2531FA0", VA = "0x1825333A0")]
		private void On_DragEnd(Gesture gesture)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x25335E0", Offset = "0x25321E0", VA = "0x1825335E0")]
		private void On_Drag(Gesture gesture)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x2533D40", Offset = "0x2532940", VA = "0x182533D40")]
		private bool isRightDirection(Gesture gesture)
		{
			return default(bool);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x25331A0", Offset = "0x2531DA0", VA = "0x1825331A0")]
		private void DoAction(Gesture gesture)
		{
		}

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4000B35")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public QuickSwipe.OnSwipeAction onSwipeAction;

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		[FieldOffset(Offset = "0x78")]
		public bool allowSwipeStartOverMe;

		// Token: 0x04000B37 RID: 2871
		[Token(Token = "0x4000B37")]
		[FieldOffset(Offset = "0x7C")]
		public QuickSwipe.ActionTriggering actionTriggering;

		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x80")]
		public QuickSwipe.SwipeDirection swipeDirection;

		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x84")]
		private float axisActionValue;

		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x88")]
		public bool enableSimpleAction;

		// Token: 0x02000203 RID: 515
		[Token(Token = "0x2000203")]
		[Serializable]
		public class OnSwipeAction : UnityEvent<Gesture>
		{
			// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x252FDE0", Offset = "0x252E9E0", VA = "0x18252FDE0")]
			public OnSwipeAction()
			{
			}
		}

		// Token: 0x02000204 RID: 516
		[Token(Token = "0x2000204")]
		public enum ActionTriggering
		{
			// Token: 0x04000B3C RID: 2876
			[Token(Token = "0x4000B3C")]
			InProgress,
			// Token: 0x04000B3D RID: 2877
			[Token(Token = "0x4000B3D")]
			End
		}

		// Token: 0x02000205 RID: 517
		[Token(Token = "0x2000205")]
		public enum SwipeDirection
		{
			// Token: 0x04000B3F RID: 2879
			[Token(Token = "0x4000B3F")]
			Vertical,
			// Token: 0x04000B40 RID: 2880
			[Token(Token = "0x4000B40")]
			Horizontal,
			// Token: 0x04000B41 RID: 2881
			[Token(Token = "0x4000B41")]
			DiagonalRight,
			// Token: 0x04000B42 RID: 2882
			[Token(Token = "0x4000B42")]
			DiagonalLeft,
			// Token: 0x04000B43 RID: 2883
			[Token(Token = "0x4000B43")]
			Up,
			// Token: 0x04000B44 RID: 2884
			[Token(Token = "0x4000B44")]
			UpRight,
			// Token: 0x04000B45 RID: 2885
			[Token(Token = "0x4000B45")]
			Right,
			// Token: 0x04000B46 RID: 2886
			[Token(Token = "0x4000B46")]
			DownRight,
			// Token: 0x04000B47 RID: 2887
			[Token(Token = "0x4000B47")]
			Down,
			// Token: 0x04000B48 RID: 2888
			[Token(Token = "0x4000B48")]
			DownLeft,
			// Token: 0x04000B49 RID: 2889
			[Token(Token = "0x4000B49")]
			Left,
			// Token: 0x04000B4A RID: 2890
			[Token(Token = "0x4000B4A")]
			UpLeft,
			// Token: 0x04000B4B RID: 2891
			[Token(Token = "0x4000B4B")]
			All
		}
	}
}
