using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	internal class MouseEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000BD1 RID: 3025 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x5AE77E0", Offset = "0x5AE63E0", VA = "0x185AE77E0", Slot = "4")]
		public bool CanDispatchEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x5AE7820", Offset = "0x5AE6420", VA = "0x185AE7820", Slot = "5")]
		public void DispatchEvent(EventBase evt, IPanel iPanel)
		{
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x5AE7E80", Offset = "0x5AE6A80", VA = "0x185AE7E80")]
		private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel)
		{
			return default(bool);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x5AE7E20", Offset = "0x5AE6A20", VA = "0x185AE7E20")]
		private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel)
		{
			return default(bool);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x5AE7C60", Offset = "0x5AE6860", VA = "0x185AE7C60")]
		private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel)
		{
			return default(bool);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x5AE7F00", Offset = "0x5AE6B00", VA = "0x185AE7F00")]
		private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel)
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x5AE7FE0", Offset = "0x5AE6BE0", VA = "0x185AE7FE0")]
		private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse)
		{
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00006330 File Offset: 0x00004530
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x5AE7C10", Offset = "0x5AE6810", VA = "0x185AE7C10")]
		private static bool IsDone(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MouseEventDispatchingStrategy()
		{
		}
	}
}
