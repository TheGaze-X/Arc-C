using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class InputSettings : ScriptableObject
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00005520 File Offset: 0x00003720
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A8")]
		public InputSettings.UpdateMode updateMode
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return (InputSettings.UpdateMode)0;
			}
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x569E810", Offset = "0x569D410", VA = "0x18569E810")]
			set
			{
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00005538 File Offset: 0x00003738
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A9")]
		public bool compensateForScreenOrientation
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x569E510", Offset = "0x569D110", VA = "0x18569E510")]
			set
			{
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00005550 File Offset: 0x00003750
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AA")]
		[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", false)]
		public bool filterNoiseOnCurrent
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00005568 File Offset: 0x00003768
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AB")]
		public float defaultDeadzoneMin
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0xFB13C0", Offset = "0xFAFFC0", VA = "0x180FB13C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x569E580", Offset = "0x569D180", VA = "0x18569E580")]
			set
			{
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00005580 File Offset: 0x00003780
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AC")]
		public float defaultDeadzoneMax
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CDA20", VA = "0x1807CEE20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x569E560", Offset = "0x569D160", VA = "0x18569E560")]
			set
			{
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00005598 File Offset: 0x00003798
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AD")]
		public float defaultButtonPressPoint
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x42B1310", Offset = "0x42AFF10", VA = "0x1842B1310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x569E520", Offset = "0x569D120", VA = "0x18569E520")]
			set
			{
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000055B0 File Offset: 0x000037B0
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		public float buttonReleaseThreshold
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x4E48960", Offset = "0x4E47560", VA = "0x184E48960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x569E4F0", Offset = "0x569D0F0", VA = "0x18569E4F0")]
			set
			{
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000055C8 File Offset: 0x000037C8
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AF")]
		public float defaultTapTime
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x17DB8C0", Offset = "0x17DA4C0", VA = "0x1817DB8C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x569E5E0", Offset = "0x569D1E0", VA = "0x18569E5E0")]
			set
			{
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000055E0 File Offset: 0x000037E0
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B0")]
		public float defaultSlowTapTime
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x17DB8E0", Offset = "0x17DA4E0", VA = "0x1817DB8E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x569E5C0", Offset = "0x569D1C0", VA = "0x18569E5C0")]
			set
			{
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x000055F8 File Offset: 0x000037F8
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B1")]
		public float defaultHoldTime
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x1251100", Offset = "0x124FD00", VA = "0x181251100")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x569E5A0", Offset = "0x569D1A0", VA = "0x18569E5A0")]
			set
			{
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00005610 File Offset: 0x00003810
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B2")]
		public float tapRadius
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x1E29290", Offset = "0x1E27E90", VA = "0x181E29290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x569E7F0", Offset = "0x569D3F0", VA = "0x18569E7F0")]
			set
			{
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00005628 File Offset: 0x00003828
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B3")]
		public float multiTapDelayTime
		{
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x1692360", Offset = "0x1690F60", VA = "0x181692360")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x569E640", Offset = "0x569D240", VA = "0x18569E640")]
			set
			{
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00005640 File Offset: 0x00003840
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B4")]
		public InputSettings.BackgroundBehavior backgroundBehavior
		{
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return InputSettings.BackgroundBehavior.ResetAndDisableNonBackgroundDevices;
			}
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x569E4E0", Offset = "0x569D0E0", VA = "0x18569E4E0")]
			set
			{
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00005658 File Offset: 0x00003858
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B5")]
		public InputSettings.EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return InputSettings.EditorInputBehaviorInPlayMode.PointersAndKeyboardsRespectGameViewFocus;
			}
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x569E610", Offset = "0x569D210", VA = "0x18569E610")]
			set
			{
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00005670 File Offset: 0x00003870
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B6")]
		public int maxEventBytesPerUpdate
		{
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x569E620", Offset = "0x569D220", VA = "0x18569E620")]
			set
			{
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00005688 File Offset: 0x00003888
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B7")]
		public int maxQueuedEventsPerUpdate
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x569E630", Offset = "0x569D230", VA = "0x18569E630")]
			set
			{
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000056A0 File Offset: 0x000038A0
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		public ReadOnlyArray<string> supportedDevices
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x569E480", Offset = "0x569D080", VA = "0x18569E480")]
			get
			{
				return default(ReadOnlyArray<string>);
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x569E670", Offset = "0x569D270", VA = "0x18569E670")]
			set
			{
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000056B8 File Offset: 0x000038B8
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B9")]
		public bool disableRedundantEventsMerging
		{
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x4C91100", Offset = "0x4C8FD00", VA = "0x184C91100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x569E600", Offset = "0x569D200", VA = "0x18569E600")]
			set
			{
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x000056D0 File Offset: 0x000038D0
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BA")]
		public bool shortcutKeysConsumeInput
		{
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x569E470", Offset = "0x569D070", VA = "0x18569E470")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x569E660", Offset = "0x569D260", VA = "0x18569E660")]
			set
			{
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x569E1C0", Offset = "0x569CDC0", VA = "0x18569E1C0")]
		public void SetInternalFeatureFlag(string featureName, bool enabled)
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x569E070", Offset = "0x569CC70", VA = "0x18569E070")]
		internal bool IsFeatureEnabled(string featureName)
		{
			return default(bool);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x569E0F0", Offset = "0x569CCF0", VA = "0x18569E0F0")]
		internal void OnChange()
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x569E410", Offset = "0x569D010", VA = "0x18569E410")]
		public InputSettings()
		{
		}

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Determine which type of devices are used by the application. By default, this is empty meaning that all devices recognized by Unity will be used. Restricting the set of supported devices will make only those devices appear in the input system.")]
		[SerializeField]
		private string[] m_SupportedDevices;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Determine when Unity processes events. By default, accumulated input events are flushed out before each fixed update and before each dynamic update. This setting can be used to restrict event processing to only where the application needs it.")]
		private InputSettings.UpdateMode m_UpdateMode;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_MaxEventBytesPerUpdate;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_MaxQueuedEventsPerUpdate;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool m_CompensateForScreenOrientation;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputSettings.BackgroundBehavior m_BackgroundBehavior;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private InputSettings.EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_DefaultDeadzoneMin;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_DefaultDeadzoneMax;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x40")]
		[Min(0.0001f)]
		[SerializeField]
		private float m_DefaultButtonPressPoint;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_ButtonReleaseThreshold;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_DefaultTapTime;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_DefaultSlowTapTime;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_DefaultHoldTime;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TapRadius;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_MultiTapDelayTime;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool m_DisableRedundantEventsMerging;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x5D")]
		[SerializeField]
		private bool m_ShortcutKeysConsumeInputs;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		internal HashSet<string> m_FeatureFlags;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x0")]
		internal static bool optimizedControlsFeatureEnabled;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x1")]
		internal static bool readValueCachingFeatureEnabled;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x2")]
		internal static bool paranoidReadValueCachingChecksEnabled;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0;

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000C6")]
		public enum UpdateMode
		{
			// Token: 0x04000498 RID: 1176
			[Token(Token = "0x4000498")]
			ProcessEventsInDynamicUpdate = 1,
			// Token: 0x04000499 RID: 1177
			[Token(Token = "0x4000499")]
			ProcessEventsInFixedUpdate,
			// Token: 0x0400049A RID: 1178
			[Token(Token = "0x400049A")]
			ProcessEventsManually
		}

		// Token: 0x020000C7 RID: 199
		[Token(Token = "0x20000C7")]
		public enum BackgroundBehavior
		{
			// Token: 0x0400049C RID: 1180
			[Token(Token = "0x400049C")]
			ResetAndDisableNonBackgroundDevices,
			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			ResetAndDisableAllDevices,
			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			IgnoreFocus
		}

		// Token: 0x020000C8 RID: 200
		[Token(Token = "0x20000C8")]
		public enum EditorInputBehaviorInPlayMode
		{
			// Token: 0x040004A0 RID: 1184
			[Token(Token = "0x40004A0")]
			PointersAndKeyboardsRespectGameViewFocus,
			// Token: 0x040004A1 RID: 1185
			[Token(Token = "0x40004A1")]
			AllDevicesRespectGameViewFocus,
			// Token: 0x040004A2 RID: 1186
			[Token(Token = "0x40004A2")]
			AllDeviceInputAlwaysGoesToGameView
		}
	}
}
