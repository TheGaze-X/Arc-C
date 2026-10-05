using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	public struct Vector3Tween : ITweenValue
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000030EC File Offset: 0x000012EC
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006B")]
		public EasingEquations.EaseType easeType
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return EasingEquations.EaseType.LinearInOutFade;
			}
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00003104 File Offset: 0x00001304
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006C")]
		public Vector3 startValue
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x5C3A0B0", Offset = "0x5C38CB0", VA = "0x185C3A0B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x5C3A0D0", Offset = "0x5C38CD0", VA = "0x185C3A0D0")]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0000311C File Offset: 0x0000131C
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006D")]
		public Vector3 targetValue
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x58DDFE0", Offset = "0x58DCBE0", VA = "0x1858DDFE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x58DE150", Offset = "0x58DCD50", VA = "0x1858DE150")]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00003134 File Offset: 0x00001334
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006E")]
		public float duration
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0000314C File Offset: 0x0000134C
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700006F")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680", Slot = "7")]
		public bool ValidTarget()
		{
			return default(bool);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x5C39F40", Offset = "0x5C38B40", VA = "0x185C39F40", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x5C39DF0", Offset = "0x5C389F0", VA = "0x185C39DF0")]
		public void AddOnChangedCallback(UnityAction<Vector3> callback)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x5C39EB0", Offset = "0x5C38AB0", VA = "0x185C39EB0")]
		public void AddOnFinishCallback(UnityAction callback)
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x5C2A650", Offset = "0x5C29250", VA = "0x185C2A650", Slot = "8")]
		public void OnFinish()
		{
		}

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x0")]
		private Vector3Tween.Vector3TweenCallback m_Target;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x8")]
		private Vector3Tween.Vector3TweenFinishCallback m_OnFinish;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x10")]
		private EasingEquations.EaseType m_EaseType;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 m_StartValue;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetValue;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x2C")]
		private float m_Duration;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IgnoreTimeScale;

		// Token: 0x020000EA RID: 234
		[Token(Token = "0x20000EA")]
		public class Vector3TweenCallback : UnityEvent<Vector3>
		{
			// Token: 0x06000650 RID: 1616 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x5C39DB0", Offset = "0x5C389B0", VA = "0x185C39DB0")]
			public Vector3TweenCallback()
			{
			}
		}

		// Token: 0x020000EB RID: 235
		[Token(Token = "0x20000EB")]
		public class Vector3TweenFinishCallback : UnityEvent
		{
			// Token: 0x06000651 RID: 1617 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
			public Vector3TweenFinishCallback()
			{
			}
		}
	}
}
