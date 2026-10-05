using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000BCE RID: 3022 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x5AE6CE0", Offset = "0x5AE58E0", VA = "0x185AE6CE0", Slot = "4")]
		public bool CanDispatchEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x5AE6D60", Offset = "0x5AE5960", VA = "0x185AE6D60", Slot = "5")]
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MouseCaptureDispatchingStrategy()
		{
		}

		// Token: 0x020001B3 RID: 435
		[Token(Token = "0x20001B3")]
		[Flags]
		private enum EventBehavior
		{
			// Token: 0x0400065D RID: 1629
			[Token(Token = "0x400065D")]
			None = 0,
			// Token: 0x0400065E RID: 1630
			[Token(Token = "0x400065E")]
			IsCapturable = 1,
			// Token: 0x0400065F RID: 1631
			[Token(Token = "0x400065F")]
			IsSentExclusivelyToCapturingElement = 2
		}
	}
}
