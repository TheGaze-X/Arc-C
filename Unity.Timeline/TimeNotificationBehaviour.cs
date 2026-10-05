using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public class TimeNotificationBehaviour : PlayableBehaviour
	{
		// Token: 0x170000CB RID: 203
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000CB")]
		public Playable timeSource
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x4C97D70", Offset = "0x4C96970", VA = "0x184C97D70")]
			set
			{
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003914 File Offset: 0x00001B14
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x58FDCA0", Offset = "0x58FC8A0", VA = "0x1858FDCA0")]
		public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode)
		{
			return default(ScriptPlayable<TimeNotificationBehaviour>);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x58FDB00", Offset = "0x58FC700", VA = "0x1858FDB00")]
		public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x58FDFF0", Offset = "0x58FCBF0", VA = "0x1858FDFF0", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x58FDDC0", Offset = "0x58FC9C0", VA = "0x1858FDDC0", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x58FE1B0", Offset = "0x58FCDB0", VA = "0x1858FE1B0", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x58FE6F0", Offset = "0x58FD2F0", VA = "0x1858FE6F0")]
		private void SortNotifications()
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000392C File Offset: 0x00001B2C
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x58FDC20", Offset = "0x58FC820", VA = "0x1858FDC20")]
		private static bool CanRestoreNotification(TimeNotificationBehaviour.NotificationEntry e, FrameData info, double currentTime, double previousTime)
		{
			return default(bool);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x58FE920", Offset = "0x58FD520", VA = "0x1858FE920")]
		private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x58FE830", Offset = "0x58FD430", VA = "0x1858FE830")]
		private void SyncDurationWithExternalSource(Playable playable)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x58FEC20", Offset = "0x58FD820", VA = "0x1858FEC20")]
		private static void Trigger_internal(Playable playable, PlayableOutput output, ref TimeNotificationBehaviour.NotificationEntry e)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x13A5FA0", Offset = "0x13A4BA0", VA = "0x1813A5FA0")]
		private static void Restore_internal(ref TimeNotificationBehaviour.NotificationEntry e)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x58FECA0", Offset = "0x58FD8A0", VA = "0x1858FECA0")]
		public TimeNotificationBehaviour()
		{
		}

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<TimeNotificationBehaviour.NotificationEntry> m_Notifications;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x18")]
		private double m_PreviousTime;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x20")]
		private bool m_NeedSortNotifications;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x28")]
		private Playable m_TimeSource;

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		private struct NotificationEntry
		{
			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000300 RID: 768 RVA: 0x00003944 File Offset: 0x00001B44
			[Token(Token = "0x170000CC")]
			public bool triggerInEditor
			{
				[Token(Token = "0x6000300")]
				[Address(RVA = "0x58FBF70", Offset = "0x58FAB70", VA = "0x1858FBF70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000301 RID: 769 RVA: 0x0000395C File Offset: 0x00001B5C
			[Token(Token = "0x170000CD")]
			public bool prewarm
			{
				[Token(Token = "0x6000301")]
				[Address(RVA = "0x58FBF60", Offset = "0x58FAB60", VA = "0x1858FBF60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x06000302 RID: 770 RVA: 0x00003974 File Offset: 0x00001B74
			[Token(Token = "0x170000CE")]
			public bool triggerOnce
			{
				[Token(Token = "0x6000302")]
				[Address(RVA = "0x58FBF80", Offset = "0x58FAB80", VA = "0x1858FBF80")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			[FieldOffset(Offset = "0x0")]
			public double time;

			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			[FieldOffset(Offset = "0x8")]
			public INotification payload;

			// Token: 0x0400014E RID: 334
			[Token(Token = "0x400014E")]
			[FieldOffset(Offset = "0x10")]
			public bool notificationFired;

			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			[FieldOffset(Offset = "0x12")]
			public NotificationFlags flags;
		}
	}
}
