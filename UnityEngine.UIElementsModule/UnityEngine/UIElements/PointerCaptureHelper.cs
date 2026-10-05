using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public static class PointerCaptureHelper
	{
		// Token: 0x0600021E RID: 542 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x5A39E30", Offset = "0x5A38A30", VA = "0x185A39E30")]
		private static PointerDispatchState GetStateFor(IEventHandler handler)
		{
			return null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x5A39EF0", Offset = "0x5A38AF0", VA = "0x185A39EF0")]
		public static bool HasPointerCapture(this IEventHandler handler, int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x5A39C50", Offset = "0x5A38850", VA = "0x185A39C50")]
		public static void CapturePointer(this IEventHandler handler, int pointerId)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x5A3A040", Offset = "0x5A38C40", VA = "0x185A3A040")]
		public static void ReleasePointer(this IEventHandler handler, int pointerId)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x5A39DA0", Offset = "0x5A389A0", VA = "0x185A39DA0")]
		public static IEventHandler GetCapturingElement(this IPanel panel, int pointerId)
		{
			return null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x5A3A0B0", Offset = "0x5A38CB0", VA = "0x185A3A0B0")]
		public static void ReleasePointer(this IPanel panel, int pointerId)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x5A39BD0", Offset = "0x5A387D0", VA = "0x185A39BD0")]
		internal static void ActivateCompatibilityMouseEvents(this IPanel panel, int pointerId)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x5A39F50", Offset = "0x5A38B50", VA = "0x185A39F50")]
		internal static void PreventCompatibilityMouseEvents(this IPanel panel, int pointerId)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x5A3A150", Offset = "0x5A38D50", VA = "0x185A3A150")]
		internal static bool ShouldSendCompatibilityMouseEvents(this IPanel panel, IPointerEvent evt)
		{
			return default(bool);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x5A39FD0", Offset = "0x5A38BD0", VA = "0x185A39FD0")]
		internal static void ProcessPointerCapture(this IPanel panel, int pointerId)
		{
		}
	}
}
