using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	[AddComponentMenu("EasyTouch/Quick Twist")]
	public class QuickTwist : QuickBase
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x2534CD0", Offset = "0x25338D0", VA = "0x182534CD0")]
		public QuickTwist()
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x25349D0", Offset = "0x25335D0", VA = "0x1825349D0", Slot = "5")]
		public override void OnEnable()
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x25349C0", Offset = "0x25335C0", VA = "0x1825349C0", Slot = "6")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x25349C0", Offset = "0x25335C0", VA = "0x1825349C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x2534C00", Offset = "0x2533800", VA = "0x182534C00")]
		private void UnsubscribeEvent()
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x2534B50", Offset = "0x2533750", VA = "0x182534B50")]
		private void On_Twist(Gesture gesture)
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x2534AA0", Offset = "0x25336A0", VA = "0x182534AA0")]
		private void On_TwistEnd(Gesture gesture)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x2534910", Offset = "0x2533510", VA = "0x182534910")]
		private bool IsRightRotation(Gesture gesture)
		{
			return default(bool);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x2534710", Offset = "0x2533310", VA = "0x182534710")]
		private void DoAction(Gesture gesture)
		{
		}

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public QuickTwist.OnTwistAction onTwistAction;

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x78")]
		public bool isGestureOnMe;

		// Token: 0x04000B5C RID: 2908
		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0x7C")]
		public QuickTwist.ActionTiggering actionTriggering;

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x80")]
		public QuickTwist.ActionRotationDirection rotationDirection;

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0x84")]
		private float axisActionValue;

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x88")]
		public bool enableSimpleAction;

		// Token: 0x0200020E RID: 526
		[Token(Token = "0x200020E")]
		[Serializable]
		public class OnTwistAction : UnityEvent<Gesture>
		{
			// Token: 0x0600091B RID: 2331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x252FFA0", Offset = "0x252EBA0", VA = "0x18252FFA0")]
			public OnTwistAction()
			{
			}
		}

		// Token: 0x0200020F RID: 527
		[Token(Token = "0x200020F")]
		public enum ActionTiggering
		{
			// Token: 0x04000B61 RID: 2913
			[Token(Token = "0x4000B61")]
			InProgress,
			// Token: 0x04000B62 RID: 2914
			[Token(Token = "0x4000B62")]
			End
		}

		// Token: 0x02000210 RID: 528
		[Token(Token = "0x2000210")]
		public enum ActionRotationDirection
		{
			// Token: 0x04000B64 RID: 2916
			[Token(Token = "0x4000B64")]
			All,
			// Token: 0x04000B65 RID: 2917
			[Token(Token = "0x4000B65")]
			Clockwise,
			// Token: 0x04000B66 RID: 2918
			[Token(Token = "0x4000B66")]
			Counterclockwise
		}
	}
}
