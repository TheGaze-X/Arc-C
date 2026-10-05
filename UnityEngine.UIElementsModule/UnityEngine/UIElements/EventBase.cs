using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	public abstract class EventBase : IDisposable
	{
		// Token: 0x06000B00 RID: 2816 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x5ADB930", Offset = "0x5ADA530", VA = "0x185ADB930")]
		protected static long RegisterEventType()
		{
			return 0L;
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x17000261")]
		public virtual long eventTypeId
		{
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x2112BF0", Offset = "0x21117F0", VA = "0x182112BF0", Slot = "5")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00005DC0 File Offset: 0x00003FC0
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000262")]
		public long timestamp
		{
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00005DD8 File Offset: 0x00003FD8
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000263")]
		internal ulong eventId
		{
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000264 RID: 612
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000264")]
		private ulong triggerEventId
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
		internal void SetTriggerEventId(ulong id)
		{
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00005DF0 File Offset: 0x00003FF0
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000265")]
		internal EventBase.EventPropagation propagation
		{
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			[CompilerGenerated]
			get
			{
				return EventBase.EventPropagation.None;
			}
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000266")]
		internal PropagationPaths path
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x5ADBB40", Offset = "0x5ADA740", VA = "0x185ADBB40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x5ADBFC0", Offset = "0x5ADABC0", VA = "0x185ADBFC0")]
			set
			{
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00005E08 File Offset: 0x00004008
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000267")]
		private EventBase.LifeCycleStatus lifeCycleStatus
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			[CompilerGenerated]
			get
			{
				return EventBase.LifeCycleStatus.None;
			}
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		[Obsolete("Override PreDispatch(IPanel panel) instead.")]
		protected virtual void PreDispatch()
		{
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x3E806B0", Offset = "0x3E7F2B0", VA = "0x183E806B0", Slot = "7")]
		protected internal virtual void PreDispatch(IPanel panel)
		{
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		[Obsolete("Override PostDispatch(IPanel panel) instead.")]
		protected virtual void PostDispatch()
		{
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x5ADB8E0", Offset = "0x5ADA4E0", VA = "0x185ADB8E0", Slot = "9")]
		protected internal virtual void PostDispatch(IPanel panel)
		{
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x17000268")]
		public bool bubbles
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x5ADBA90", Offset = "0x5ADA690", VA = "0x185ADBA90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00005E38 File Offset: 0x00004038
		[Token(Token = "0x17000269")]
		public bool tricklesDown
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x5ADBCC0", Offset = "0x5ADA8C0", VA = "0x185ADBCC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00005E50 File Offset: 0x00004050
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026A")]
		internal bool skipDisabledElements
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x5ADBCA0", Offset = "0x5ADA8A0", VA = "0x185ADBCA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x5ADC0B0", Offset = "0x5ADACB0", VA = "0x185ADC0B0")]
			set
			{
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00005E68 File Offset: 0x00004068
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026B")]
		internal bool ignoreCompositeRoots
		{
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x5ADBAC0", Offset = "0x5ADA6C0", VA = "0x185ADBAC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x5ADBE70", Offset = "0x5ADAA70", VA = "0x185ADBE70")]
			set
			{
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026C")]
		internal IEventHandler leafTarget
		{
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026D")]
		public IEventHandler target
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x59976E0", Offset = "0x59962E0", VA = "0x1859976E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x5ADC0F0", Offset = "0x5ADACF0", VA = "0x185ADC0F0")]
			set
			{
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700026E")]
		internal List<IEventHandler> skipElements
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x5ADB970", Offset = "0x5ADA570", VA = "0x185ADB970")]
		internal bool Skip(IEventHandler h)
		{
			return default(bool);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00005E98 File Offset: 0x00004098
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026F")]
		public bool isPropagationStopped
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x5ADBB10", Offset = "0x5ADA710", VA = "0x185ADBB10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x5ADBFA0", Offset = "0x5ADABA0", VA = "0x185ADBFA0")]
			private set
			{
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x5ADB9E0", Offset = "0x5ADA5E0", VA = "0x185ADB9E0")]
		public void StopPropagation()
		{
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00005EB0 File Offset: 0x000040B0
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000270")]
		public bool isImmediatePropagationStopped
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x5ADBB00", Offset = "0x5ADA700", VA = "0x185ADBB00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x5ADBF80", Offset = "0x5ADAB80", VA = "0x185ADBF80")]
			private set
			{
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x5ADB9D0", Offset = "0x5ADA5D0", VA = "0x185ADB9D0")]
		public void StopImmediatePropagation()
		{
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00005EC8 File Offset: 0x000040C8
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000271")]
		public bool isDefaultPrevented
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x5ADBAF0", Offset = "0x5ADA6F0", VA = "0x185ADBAF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x55F83E0", Offset = "0x55F6FE0", VA = "0x1855F83E0")]
			private set
			{
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x5ADB920", Offset = "0x5ADA520", VA = "0x185ADB920")]
		public void PreventDefault()
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00005EE0 File Offset: 0x000040E0
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		public PropagationPhase propagationPhase
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			[CompilerGenerated]
			get
			{
				return PropagationPhase.None;
			}
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x4A5BF80", Offset = "0x4A5AB80", VA = "0x184A5BF80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000273")]
		public virtual IEventHandler currentTarget
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x5997680", Offset = "0x5996280", VA = "0x185997680", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x5ADBCD0", Offset = "0x5ADA8D0", VA = "0x185ADBCD0", Slot = "11")]
			internal set
			{
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00005EF8 File Offset: 0x000040F8
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000274")]
		public bool dispatch
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x5ADBAA0", Offset = "0x5ADA6A0", VA = "0x185ADBAA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x5ADBE30", Offset = "0x5ADAA30", VA = "0x185ADBE30")]
			internal set
			{
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x5ADB860", Offset = "0x5ADA460", VA = "0x185ADB860")]
		internal void MarkReceivedByDispatcher()
		{
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00005F10 File Offset: 0x00004110
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000275")]
		private bool dispatched
		{
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x5ADBAB0", Offset = "0x5ADA6B0", VA = "0x185ADBAB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x5ADBE50", Offset = "0x5ADAA50", VA = "0x185ADBE50")]
			set
			{
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00005F28 File Offset: 0x00004128
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000276")]
		internal bool processed
		{
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x5ADBC80", Offset = "0x5ADA880", VA = "0x185ADBC80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x5ADC070", Offset = "0x5ADAC70", VA = "0x185ADC070")]
			private set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00005F40 File Offset: 0x00004140
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000277")]
		internal bool processedByFocusController
		{
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x5ADBC70", Offset = "0x5ADA870", VA = "0x185ADBC70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x5ADC050", Offset = "0x5ADAC50", VA = "0x185ADC050")]
			set
			{
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00005F58 File Offset: 0x00004158
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000278")]
		internal bool stopDispatch
		{
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x5ADBCB0", Offset = "0x5ADA8B0", VA = "0x185ADBCB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x5ADC0D0", Offset = "0x5ADACD0", VA = "0x185ADC0D0")]
			set
			{
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00005F70 File Offset: 0x00004170
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000279")]
		internal bool propagateToIMGUI
		{
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x5ADBC90", Offset = "0x5ADA890", VA = "0x185ADBC90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x5ADC090", Offset = "0x5ADAC90", VA = "0x185ADC090")]
			set
			{
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00005F88 File Offset: 0x00004188
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027A")]
		private bool imguiEventIsValid
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x5ADBAD0", Offset = "0x5ADA6D0", VA = "0x185ADBAD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x5ADBE90", Offset = "0x5ADAA90", VA = "0x185ADBE90")]
			set
			{
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027B")]
		public Event imguiEvent
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x5ADBAE0", Offset = "0x5ADA6E0", VA = "0x185ADBAE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x5ADBEB0", Offset = "0x5ADAAB0", VA = "0x185ADBEB0")]
			protected set
			{
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00005FA0 File Offset: 0x000041A0
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027C")]
		public Vector2 originalMousePosition
		{
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x5ADBB20", Offset = "0x5ADA720", VA = "0x185ADBB20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x53CF500", Offset = "0x53CE100", VA = "0x1853CF500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x5ADB6D0", Offset = "0x5ADA2D0", VA = "0x185ADB6D0", Slot = "12")]
		protected virtual void Init()
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x5ADB6E0", Offset = "0x5ADA2E0", VA = "0x185ADB6E0")]
		private void LocalInit()
		{
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x5ADB9F0", Offset = "0x5ADA5F0", VA = "0x185ADB9F0")]
		protected EventBase()
		{
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00005FB8 File Offset: 0x000041B8
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027D")]
		protected bool pooled
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x5ADBC60", Offset = "0x5ADA860", VA = "0x185ADBC60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x5ADC030", Offset = "0x5ADAC30", VA = "0x185ADC030")]
			set
			{
			}
		}

		// Token: 0x06000B43 RID: 2883
		[Token(Token = "0x6000B43")]
		internal abstract void Acquire();

		// Token: 0x06000B44 RID: 2884
		[Token(Token = "0x6000B44")]
		public abstract void Dispose();

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x0")]
		private static long s_LastTypeId;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x8")]
		private static ulong s_NextEventId;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x30")]
		private PropagationPaths m_Path;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x48")]
		private IEventHandler m_Target;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x60")]
		private IEventHandler m_CurrentTarget;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x68")]
		private Event m_ImguiEvent;

		// Token: 0x02000194 RID: 404
		[Token(Token = "0x2000194")]
		[Flags]
		internal enum EventPropagation
		{
			// Token: 0x0400061D RID: 1565
			[Token(Token = "0x400061D")]
			None = 0,
			// Token: 0x0400061E RID: 1566
			[Token(Token = "0x400061E")]
			Bubbles = 1,
			// Token: 0x0400061F RID: 1567
			[Token(Token = "0x400061F")]
			TricklesDown = 2,
			// Token: 0x04000620 RID: 1568
			[Token(Token = "0x4000620")]
			Cancellable = 4,
			// Token: 0x04000621 RID: 1569
			[Token(Token = "0x4000621")]
			SkipDisabledElements = 8,
			// Token: 0x04000622 RID: 1570
			[Token(Token = "0x4000622")]
			IgnoreCompositeRoots = 16
		}

		// Token: 0x02000195 RID: 405
		[Token(Token = "0x2000195")]
		[Flags]
		private enum LifeCycleStatus
		{
			// Token: 0x04000624 RID: 1572
			[Token(Token = "0x4000624")]
			None = 0,
			// Token: 0x04000625 RID: 1573
			[Token(Token = "0x4000625")]
			PropagationStopped = 1,
			// Token: 0x04000626 RID: 1574
			[Token(Token = "0x4000626")]
			ImmediatePropagationStopped = 2,
			// Token: 0x04000627 RID: 1575
			[Token(Token = "0x4000627")]
			DefaultPrevented = 4,
			// Token: 0x04000628 RID: 1576
			[Token(Token = "0x4000628")]
			Dispatching = 8,
			// Token: 0x04000629 RID: 1577
			[Token(Token = "0x4000629")]
			Pooled = 16,
			// Token: 0x0400062A RID: 1578
			[Token(Token = "0x400062A")]
			IMGUIEventIsValid = 32,
			// Token: 0x0400062B RID: 1579
			[Token(Token = "0x400062B")]
			StopDispatch = 64,
			// Token: 0x0400062C RID: 1580
			[Token(Token = "0x400062C")]
			PropagateToIMGUI = 128,
			// Token: 0x0400062D RID: 1581
			[Token(Token = "0x400062D")]
			Dispatched = 512,
			// Token: 0x0400062E RID: 1582
			[Token(Token = "0x400062E")]
			Processed = 1024,
			// Token: 0x0400062F RID: 1583
			[Token(Token = "0x400062F")]
			ProcessedByFocusController = 2048
		}
	}
}
