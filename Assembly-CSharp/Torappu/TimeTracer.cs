using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	public class TimeTracer : SingletonMonoBehaviour<TimeTracer>, ISingletonNotAutoCreate
	{
		// Token: 0x06005BF9 RID: 23545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF9")]
		[Address(RVA = "0x1CFABD0", Offset = "0x1CF97D0", VA = "0x181CFABD0")]
		public static void Watch(ITimeWatcher watcher, int groupId = 0)
		{
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFA")]
		[Address(RVA = "0x1CFA400", Offset = "0x1CF9000", VA = "0x181CFA400")]
		public static void UnWatch(ITimeWatcher watcher, int groupId = 0)
		{
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
		[Token(Token = "0x6005BFB")]
		[Address(RVA = "0x1CF9FC0", Offset = "0x1CF8BC0", VA = "0x181CF9FC0")]
		public static int RegisterGroup()
		{
			return 0;
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFC")]
		[Address(RVA = "0x1CFA5B0", Offset = "0x1CF91B0", VA = "0x181CFA5B0")]
		public static void UnregisterGroup(int groupId)
		{
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFD")]
		[Address(RVA = "0x1CF9EE0", Offset = "0x1CF8AE0", VA = "0x181CF9EE0")]
		public static void PauseGroup(int groupId)
		{
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFE")]
		[Address(RVA = "0x1CFA150", Offset = "0x1CF8D50", VA = "0x181CFA150")]
		public static void ResumeGroup(int groupId)
		{
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x0002F0D0 File Offset: 0x0002D2D0
		[Token(Token = "0x6005BFF")]
		[Address(RVA = "0x1CFA230", Offset = "0x1CF8E30", VA = "0x181CFA230")]
		public static bool StartTimeTask(Action task, float delay)
		{
			return default(bool);
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
		[Token(Token = "0x6005C00")]
		[Address(RVA = "0x1CF9DB0", Offset = "0x1CF89B0", VA = "0x181CF9DB0")]
		public static bool IsValidGroup(int groupId)
		{
			return default(bool);
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x0002F100 File Offset: 0x0002D300
		[Token(Token = "0x6005C01")]
		[Address(RVA = "0x1CF9C90", Offset = "0x1CF8890", VA = "0x181CF9C90")]
		public static bool InvokeNextFrame(Behaviour mono, Action action)
		{
			return default(bool);
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C02")]
		[Address(RVA = "0x1CF9E10", Offset = "0x1CF8A10", VA = "0x181CF9E10", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C03")]
		[Address(RVA = "0x1CFA6F0", Offset = "0x1CF92F0", VA = "0x181CFA6F0")]
		private void Update()
		{
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x0002F118 File Offset: 0x0002D318
		[Token(Token = "0x6005C04")]
		[Address(RVA = "0x1CFB360", Offset = "0x1CF9F60", VA = "0x181CFB360")]
		private int _RegisterGroup()
		{
			return 0;
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C05")]
		[Address(RVA = "0x1CFB5F0", Offset = "0x1CFA1F0", VA = "0x181CFB5F0")]
		private void _UnregisterGroup(int groupId)
		{
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C06")]
		[Address(RVA = "0x1CFB430", Offset = "0x1CFA030", VA = "0x181CFB430")]
		private void _SetGroupActive(int groupId, bool isActive)
		{
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C07")]
		[Address(RVA = "0x1CFBC30", Offset = "0x1CFA830", VA = "0x181CFBC30")]
		private void _WatchOnGroup(ITimeWatcher watcher, int groupId)
		{
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C08")]
		[Address(RVA = "0x1CFB500", Offset = "0x1CFA100", VA = "0x181CFB500")]
		private void _UnWatchOnGroup(ITimeWatcher watcher, int groupId)
		{
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x0002F130 File Offset: 0x0002D330
		[Token(Token = "0x6005C09")]
		[Address(RVA = "0x1CFAE70", Offset = "0x1CF9A70", VA = "0x181CFAE70")]
		private bool _AddInvokeNextFrame(Behaviour mono, Action action)
		{
			return default(bool);
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0x1CFB680", Offset = "0x1CFA280", VA = "0x181CFB680")]
		private void _UpdateInvokeNextFrame()
		{
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x1CFB100", Offset = "0x1CF9D00", VA = "0x181CFB100")]
		private TimeTracer.CallbackWithActiveMono _GetActionWithActiveMono(Behaviour mono, Action action)
		{
			return null;
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x1CFB2A0", Offset = "0x1CF9EA0", VA = "0x181CFB2A0")]
		private void _RecycleActionWithActiveMono(TimeTracer.CallbackWithActiveMono inst)
		{
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x1CFBE10", Offset = "0x1CFAA10", VA = "0x181CFBE10")]
		public TimeTracer()
		{
		}

		// Token: 0x04002199 RID: 8601
		[Token(Token = "0x4002199")]
		private const int DEFAULT_GROUP = 0;

		// Token: 0x0400219A RID: 8602
		[Token(Token = "0x400219A")]
		public const int INVALID_GROUP = -1;

		// Token: 0x0400219B RID: 8603
		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _timeScale;

		// Token: 0x0400219C RID: 8604
		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<int, TimeTracer.TimeWatcherGroup> m_timeWatcherGroup;

		// Token: 0x0400219D RID: 8605
		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x28")]
		private int m_groupIdTail;

		// Token: 0x0400219E RID: 8606
		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x30")]
		private List<ITimeWatcher> m_watchersBuffer;

		// Token: 0x0400219F RID: 8607
		[Token(Token = "0x400219F")]
		[FieldOffset(Offset = "0x38")]
		private List<TimeTracer.TimeTask> m_timeTasks;

		// Token: 0x040021A0 RID: 8608
		[Token(Token = "0x40021A0")]
		[FieldOffset(Offset = "0x40")]
		private long m_selfFrameCnt;

		// Token: 0x040021A1 RID: 8609
		[Token(Token = "0x40021A1")]
		[FieldOffset(Offset = "0x48")]
		private int m_unityFrameCnt;

		// Token: 0x040021A2 RID: 8610
		[Token(Token = "0x40021A2")]
		[FieldOffset(Offset = "0x50")]
		private Queue<TimeTracer.CallbackWithActiveMono> m_callbackPool;

		// Token: 0x040021A3 RID: 8611
		[Token(Token = "0x40021A3")]
		[FieldOffset(Offset = "0x58")]
		private List<TimeTracer.CallbackWithActiveMono> m_invokeNextFrame;

		// Token: 0x040021A4 RID: 8612
		[Token(Token = "0x40021A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Watch;

		// Token: 0x040021A5 RID: 8613
		[Token(Token = "0x40021A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UnWatch;

		// Token: 0x040021A6 RID: 8614
		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterGroup;

		// Token: 0x040021A7 RID: 8615
		[Token(Token = "0x40021A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UnregisterGroup;

		// Token: 0x040021A8 RID: 8616
		[Token(Token = "0x40021A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PauseGroup;

		// Token: 0x040021A9 RID: 8617
		[Token(Token = "0x40021A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResumeGroup;

		// Token: 0x040021AA RID: 8618
		[Token(Token = "0x40021AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StartTimeTask;

		// Token: 0x040021AB RID: 8619
		[Token(Token = "0x40021AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsValidGroup;

		// Token: 0x040021AC RID: 8620
		[Token(Token = "0x40021AC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InvokeNextFrame;

		// Token: 0x040021AD RID: 8621
		[Token(Token = "0x40021AD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040021AE RID: 8622
		[Token(Token = "0x40021AE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040021AF RID: 8623
		[Token(Token = "0x40021AF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RegisterGroup;

		// Token: 0x040021B0 RID: 8624
		[Token(Token = "0x40021B0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UnregisterGroup;

		// Token: 0x040021B1 RID: 8625
		[Token(Token = "0x40021B1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetGroupActive;

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__WatchOnGroup;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UnWatchOnGroup;

		// Token: 0x040021B4 RID: 8628
		[Token(Token = "0x40021B4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__AddInvokeNextFrame;

		// Token: 0x040021B5 RID: 8629
		[Token(Token = "0x40021B5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateInvokeNextFrame;

		// Token: 0x040021B6 RID: 8630
		[Token(Token = "0x40021B6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetActionWithActiveMono;

		// Token: 0x040021B7 RID: 8631
		[Token(Token = "0x40021B7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RecycleActionWithActiveMono;

		// Token: 0x040021B8 RID: 8632
		[Token(Token = "0x40021B8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200058A RID: 1418
		[Token(Token = "0x200058A")]
		private struct TimeTask
		{
			// Token: 0x040021B9 RID: 8633
			[Token(Token = "0x40021B9")]
			[FieldOffset(Offset = "0x0")]
			public float targetTime;

			// Token: 0x040021BA RID: 8634
			[Token(Token = "0x40021BA")]
			[FieldOffset(Offset = "0x8")]
			public Action task;
		}

		// Token: 0x0200058B RID: 1419
		[Token(Token = "0x200058B")]
		private class TimeWatcherGroup
		{
			// Token: 0x06005C0E RID: 23566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C0E")]
			[Address(RVA = "0x1CFC080", Offset = "0x1CFAC80", VA = "0x181CFC080")]
			public TimeWatcherGroup()
			{
			}

			// Token: 0x040021BB RID: 8635
			[Token(Token = "0x40021BB")]
			[FieldOffset(Offset = "0x10")]
			public bool isActive;

			// Token: 0x040021BC RID: 8636
			[Token(Token = "0x40021BC")]
			[FieldOffset(Offset = "0x18")]
			public List<ITimeWatcher> watchers;
		}

		// Token: 0x0200058C RID: 1420
		[Token(Token = "0x200058C")]
		private class CallbackWithActiveMono
		{
			// Token: 0x06005C0F RID: 23567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C0F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CallbackWithActiveMono()
			{
			}

			// Token: 0x040021BD RID: 8637
			[Token(Token = "0x40021BD")]
			[FieldOffset(Offset = "0x10")]
			public long frame;

			// Token: 0x040021BE RID: 8638
			[Token(Token = "0x40021BE")]
			[FieldOffset(Offset = "0x18")]
			public Behaviour mono;

			// Token: 0x040021BF RID: 8639
			[Token(Token = "0x40021BF")]
			[FieldOffset(Offset = "0x20")]
			public Action action;
		}
	}
}
