using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	internal sealed class NetEventSource : EventSource
	{
		// Token: 0x060011FA RID: 4602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x51B2780", Offset = "0x51B1380", VA = "0x1851B2780")]
		[NonEvent]
		public static void Enter(object thisOrContextObject, [Optional] FormattableString formattableString, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x51B2600", Offset = "0x51B1200", VA = "0x1851B2600")]
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x51B2910", Offset = "0x51B1510", VA = "0x1851B2910")]
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x51B2AC0", Offset = "0x51B16C0", VA = "0x1851B2AC0")]
		[Event(1, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void Enter(string thisOrContextObject, string memberName, string parameters)
		{
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x51B2E00", Offset = "0x51B1A00", VA = "0x1851B2E00")]
		[NonEvent]
		public static void Exit(object thisOrContextObject, [Optional] FormattableString formattableString, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x51B2F90", Offset = "0x51B1B90", VA = "0x1851B2F90")]
		[NonEvent]
		public static void Exit(object thisOrContextObject, object arg0, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001200")]
		[Address(RVA = "0x51B2D70", Offset = "0x51B1970", VA = "0x1851B2D70")]
		[Event(2, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void Exit(string thisOrContextObject, string memberName, string result)
		{
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x51B3C80", Offset = "0x51B2880", VA = "0x1851B3C80")]
		[NonEvent]
		public static void Info(object thisOrContextObject, [Optional] FormattableString formattableString, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001202")]
		[Address(RVA = "0x51B3EA0", Offset = "0x51B2AA0", VA = "0x1851B3EA0")]
		[NonEvent]
		public static void Info(object thisOrContextObject, object message, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001203")]
		[Address(RVA = "0x51B3E10", Offset = "0x51B2A10", VA = "0x1851B3E10")]
		[Event(4, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void Info(string thisOrContextObject, string memberName, string message)
		{
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x51B2BE0", Offset = "0x51B17E0", VA = "0x1851B2BE0")]
		[NonEvent]
		public static void Error(object thisOrContextObject, object message, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x51B2B50", Offset = "0x51B1750", VA = "0x1851B2B50")]
		[Event(5, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
		private void ErrorMessage(string thisOrContextObject, string memberName, string message)
		{
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x51B3120", Offset = "0x51B1D20", VA = "0x1851B3120")]
		[NonEvent]
		public static void Fail(object thisOrContextObject, object message, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x51B2570", Offset = "0x51B1170", VA = "0x1851B2570")]
		[Event(6, Level = EventLevel.Critical, Keywords = (EventKeywords)2L)]
		private void CriticalFailure(string thisOrContextObject, string memberName, string message)
		{
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x51B2350", Offset = "0x51B0F50", VA = "0x1851B2350")]
		[NonEvent]
		public static void Associate(object first, object second, [CallerMemberName] [Optional] string memberName)
		{
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x51B24D0", Offset = "0x51B10D0", VA = "0x1851B24D0")]
		[Event(3, Level = EventLevel.Informational, Keywords = (EventKeywords)1L, Message = "[{2}]<-->[{3}]")]
		private void Associate(string thisOrContextObject, string memberName, string first, string second)
		{
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x170003B3")]
		public new static bool IsEnabled
		{
			[Token(Token = "0x600120A")]
			[Address(RVA = "0x51B42D0", Offset = "0x51B2ED0", VA = "0x1851B42D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x51B3B70", Offset = "0x51B2770", VA = "0x1851B3B70")]
		[NonEvent]
		public static string IdOf(object value)
		{
			return null;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x600120C")]
		[Address(RVA = "0x51B3B20", Offset = "0x51B2720", VA = "0x1851B3B20")]
		[NonEvent]
		public static int GetHashCode(object value)
		{
			return 0;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120D")]
		[Address(RVA = "0x51B3710", Offset = "0x51B2310", VA = "0x1851B3710")]
		[NonEvent]
		public static object Format(object value)
		{
			return null;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120E")]
		[Address(RVA = "0x51B32B0", Offset = "0x51B1EB0", VA = "0x1851B32B0")]
		[NonEvent]
		private static string Format(FormattableString s)
		{
			return null;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600120F")]
		[Address(RVA = "0x51B4030", Offset = "0x51B2C30", VA = "0x1851B4030")]
		[NonEvent]
		private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4)
		{
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x51B42C0", Offset = "0x51B2EC0", VA = "0x1851B42C0")]
		public NetEventSource()
		{
		}

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NetEventSource Log;

		// Token: 0x02000282 RID: 642
		[Token(Token = "0x2000282")]
		public class Keywords
		{
			// Token: 0x040008D2 RID: 2258
			[Token(Token = "0x40008D2")]
			public const EventKeywords Default = (EventKeywords)1L;

			// Token: 0x040008D3 RID: 2259
			[Token(Token = "0x40008D3")]
			public const EventKeywords Debug = (EventKeywords)2L;

			// Token: 0x040008D4 RID: 2260
			[Token(Token = "0x40008D4")]
			public const EventKeywords EnterExit = (EventKeywords)4L;
		}
	}
}
