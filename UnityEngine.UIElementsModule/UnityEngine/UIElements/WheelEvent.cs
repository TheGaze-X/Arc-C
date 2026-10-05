using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	public class WheelEvent : MouseEventBase<WheelEvent>
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00006480 File Offset: 0x00004680
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B6")]
		public Vector3 delta
		{
			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x5AEDA60", Offset = "0x5AEC660", VA = "0x185AEDA60")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x5AEDA80", Offset = "0x5AEC680", VA = "0x185AEDA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x5AED740", Offset = "0x5AEC340", VA = "0x185AED740")]
		public new static WheelEvent GetPooled(Event systemEvent)
		{
			return null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x5AED890", Offset = "0x5AEC490", VA = "0x185AED890")]
		internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent)
		{
			return null;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x5AED900", Offset = "0x5AEC500", VA = "0x185AED900", Slot = "12")]
		protected override void Init()
		{
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x5AED980", Offset = "0x5AEC580", VA = "0x185AED980")]
		private void LocalInit()
		{
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x5AED9E0", Offset = "0x5AEC5E0", VA = "0x185AED9E0")]
		public WheelEvent()
		{
		}
	}
}
