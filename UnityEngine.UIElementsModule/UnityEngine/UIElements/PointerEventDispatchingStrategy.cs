using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	internal class PointerEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x5AEA490", Offset = "0x5AE9090", VA = "0x185AEA490", Slot = "4")]
		public bool CanDispatchEvent(EventBase evt)
		{
			return default(bool);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x5AEA4D0", Offset = "0x5AE90D0", VA = "0x185AEA4D0", Slot = "6")]
		public virtual void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x5AEA510", Offset = "0x5AE9110", VA = "0x185AEA510")]
		private static void SendEventToTarget(EventBase evt)
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x5AEA540", Offset = "0x5AE9140", VA = "0x185AEA540")]
		private static void SetBestTargetForEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x5AEA6E0", Offset = "0x5AE92E0", VA = "0x185AEA6E0")]
		private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer)
		{
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PointerEventDispatchingStrategy()
		{
		}
	}
}
