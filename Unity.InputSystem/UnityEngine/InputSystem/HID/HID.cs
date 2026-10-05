using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.HID
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	public class HID : InputDevice
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x00006D50 File Offset: 0x00004F50
		[Token(Token = "0x170003B5")]
		public static FourCC QueryHIDReportDescriptorDeviceCommandType
		{
			[Token(Token = "0x6000E02")]
			[Address(RVA = "0x56BDAF0", Offset = "0x56BC6F0", VA = "0x1856BDAF0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x170003B6")]
		public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType
		{
			[Token(Token = "0x6000E03")]
			[Address(RVA = "0x56BDB30", Offset = "0x56BC730", VA = "0x1856BDB30")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00006D80 File Offset: 0x00004F80
		[Token(Token = "0x170003B7")]
		public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType
		{
			[Token(Token = "0x6000E04")]
			[Address(RVA = "0x56BDAB0", Offset = "0x56BC6B0", VA = "0x1856BDAB0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x170003B8")]
		public HID.HIDDeviceDescriptor hidDescriptor
		{
			[Token(Token = "0x6000E05")]
			[Address(RVA = "0x56BDB70", Offset = "0x56BC770", VA = "0x1856BDB70")]
			get
			{
				return default(HID.HIDDeviceDescriptor);
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x56BC6E0", Offset = "0x56BB2E0", VA = "0x1856BC6E0")]
		internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand)
		{
			return null;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x56BD1D0", Offset = "0x56BBDD0", VA = "0x1856BD1D0")]
		internal static HID.HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate)
		{
			return default(HID.HIDDeviceDescriptor);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x56BD990", Offset = "0x56BC590", VA = "0x1856BD990")]
		public static string UsagePageToString(HID.UsagePage usagePage)
		{
			return null;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x56BDA00", Offset = "0x56BC600", VA = "0x1856BDA00")]
		public static string UsageToString(HID.UsagePage usagePage, int usage)
		{
			return null;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public HID()
		{
		}

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		internal const string kHIDInterface = "HID";

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		internal const string kHIDNamespace = "HID";

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x170")]
		private bool m_HaveParsedHIDDescriptor;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x178")]
		private HID.HIDDeviceDescriptor m_HIDDescriptor;

		// Token: 0x02000131 RID: 305
		[Token(Token = "0x2000131")]
		[Serializable]
		private class HIDLayoutBuilder
		{
			// Token: 0x06000E0B RID: 3595 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E0B")]
			[Address(RVA = "0x56BB3E0", Offset = "0x56B9FE0", VA = "0x1856BB3E0")]
			public InputControlLayout Build()
			{
				return null;
			}

			// Token: 0x06000E0C RID: 3596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E0C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HIDLayoutBuilder()
			{
			}

			// Token: 0x040006FE RID: 1790
			[Token(Token = "0x40006FE")]
			[FieldOffset(Offset = "0x10")]
			public string displayName;

			// Token: 0x040006FF RID: 1791
			[Token(Token = "0x40006FF")]
			[FieldOffset(Offset = "0x18")]
			public HID.HIDDeviceDescriptor hidDescriptor;

			// Token: 0x04000700 RID: 1792
			[Token(Token = "0x4000700")]
			[FieldOffset(Offset = "0x48")]
			public string parentLayout;

			// Token: 0x04000701 RID: 1793
			[Token(Token = "0x4000701")]
			[FieldOffset(Offset = "0x50")]
			public Type deviceType;
		}

		// Token: 0x02000133 RID: 307
		[Token(Token = "0x2000133")]
		public enum HIDReportType
		{
			// Token: 0x04000707 RID: 1799
			[Token(Token = "0x4000707")]
			Unknown,
			// Token: 0x04000708 RID: 1800
			[Token(Token = "0x4000708")]
			Input,
			// Token: 0x04000709 RID: 1801
			[Token(Token = "0x4000709")]
			Output,
			// Token: 0x0400070A RID: 1802
			[Token(Token = "0x400070A")]
			Feature
		}

		// Token: 0x02000134 RID: 308
		[Token(Token = "0x2000134")]
		public enum HIDCollectionType
		{
			// Token: 0x0400070C RID: 1804
			[Token(Token = "0x400070C")]
			Physical,
			// Token: 0x0400070D RID: 1805
			[Token(Token = "0x400070D")]
			Application,
			// Token: 0x0400070E RID: 1806
			[Token(Token = "0x400070E")]
			Logical,
			// Token: 0x0400070F RID: 1807
			[Token(Token = "0x400070F")]
			Report,
			// Token: 0x04000710 RID: 1808
			[Token(Token = "0x4000710")]
			NamedArray,
			// Token: 0x04000711 RID: 1809
			[Token(Token = "0x4000711")]
			UsageSwitch,
			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			UsageModifier
		}

		// Token: 0x02000135 RID: 309
		[Token(Token = "0x2000135")]
		[Flags]
		public enum HIDElementFlags
		{
			// Token: 0x04000714 RID: 1812
			[Token(Token = "0x4000714")]
			Constant = 1,
			// Token: 0x04000715 RID: 1813
			[Token(Token = "0x4000715")]
			Variable = 2,
			// Token: 0x04000716 RID: 1814
			[Token(Token = "0x4000716")]
			Relative = 4,
			// Token: 0x04000717 RID: 1815
			[Token(Token = "0x4000717")]
			Wrap = 8,
			// Token: 0x04000718 RID: 1816
			[Token(Token = "0x4000718")]
			NonLinear = 16,
			// Token: 0x04000719 RID: 1817
			[Token(Token = "0x4000719")]
			NoPreferred = 32,
			// Token: 0x0400071A RID: 1818
			[Token(Token = "0x400071A")]
			NullState = 64,
			// Token: 0x0400071B RID: 1819
			[Token(Token = "0x400071B")]
			Volatile = 128,
			// Token: 0x0400071C RID: 1820
			[Token(Token = "0x400071C")]
			BufferedBytes = 256
		}

		// Token: 0x02000136 RID: 310
		[Token(Token = "0x2000136")]
		[Serializable]
		public struct HIDElementDescriptor
		{
			// Token: 0x170003B9 RID: 953
			// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00006DF8 File Offset: 0x00004FF8
			[Token(Token = "0x170003B9")]
			public bool hasNullState
			{
				[Token(Token = "0x6000E12")]
				[Address(RVA = "0x56BB1D0", Offset = "0x56B9DD0", VA = "0x1856BB1D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003BA RID: 954
			// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00006E10 File Offset: 0x00005010
			[Token(Token = "0x170003BA")]
			public bool hasPreferredState
			{
				[Token(Token = "0x6000E13")]
				[Address(RVA = "0x56BB1E0", Offset = "0x56B9DE0", VA = "0x1856BB1E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003BB RID: 955
			// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00006E28 File Offset: 0x00005028
			[Token(Token = "0x170003BB")]
			public bool isArray
			{
				[Token(Token = "0x6000E14")]
				[Address(RVA = "0x56BB1F0", Offset = "0x56B9DF0", VA = "0x1856BB1F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00006E40 File Offset: 0x00005040
			[Token(Token = "0x170003BC")]
			public bool isNonLinear
			{
				[Token(Token = "0x6000E15")]
				[Address(RVA = "0x56BB210", Offset = "0x56B9E10", VA = "0x1856BB210")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00006E58 File Offset: 0x00005058
			[Token(Token = "0x170003BD")]
			public bool isRelative
			{
				[Token(Token = "0x6000E16")]
				[Address(RVA = "0x56BB220", Offset = "0x56B9E20", VA = "0x1856BB220")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00006E70 File Offset: 0x00005070
			[Token(Token = "0x170003BE")]
			public bool isConstant
			{
				[Token(Token = "0x6000E17")]
				[Address(RVA = "0x56BB200", Offset = "0x56B9E00", VA = "0x1856BB200")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00006E88 File Offset: 0x00005088
			[Token(Token = "0x170003BF")]
			public bool isWrapping
			{
				[Token(Token = "0x6000E18")]
				[Address(RVA = "0x56BB230", Offset = "0x56B9E30", VA = "0x1856BB230")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00006EA0 File Offset: 0x000050A0
			[Token(Token = "0x170003C0")]
			internal bool isSigned
			{
				[Token(Token = "0x6000E19")]
				[Address(RVA = "0x1EF14C0", Offset = "0x1EF00C0", VA = "0x181EF14C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00006EB8 File Offset: 0x000050B8
			[Token(Token = "0x170003C1")]
			internal float minFloatValue
			{
				[Token(Token = "0x6000E1A")]
				[Address(RVA = "0x56BB310", Offset = "0x56B9F10", VA = "0x1856BB310")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00006ED0 File Offset: 0x000050D0
			[Token(Token = "0x170003C2")]
			internal float maxFloatValue
			{
				[Token(Token = "0x6000E1B")]
				[Address(RVA = "0x56BB240", Offset = "0x56B9E40", VA = "0x1856BB240")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06000E1C RID: 3612 RVA: 0x00006EE8 File Offset: 0x000050E8
			[Token(Token = "0x6000E1C")]
			[Address(RVA = "0x56BB1C0", Offset = "0x56B9DC0", VA = "0x1856BB1C0")]
			public bool Is(HID.UsagePage usagePage, int usage)
			{
				return default(bool);
			}

			// Token: 0x06000E1D RID: 3613 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E1D")]
			[Address(RVA = "0x56BAB90", Offset = "0x56B9790", VA = "0x1856BAB90")]
			internal string DetermineName()
			{
				return null;
			}

			// Token: 0x06000E1E RID: 3614 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E1E")]
			[Address(RVA = "0x56BA850", Offset = "0x56B9450", VA = "0x1856BA850")]
			internal string DetermineDisplayName()
			{
				return null;
			}

			// Token: 0x06000E1F RID: 3615 RVA: 0x00006F00 File Offset: 0x00005100
			[Token(Token = "0x6000E1F")]
			[Address(RVA = "0x56BB190", Offset = "0x56B9D90", VA = "0x1856BB190")]
			internal bool IsUsableElement()
			{
				return default(bool);
			}

			// Token: 0x06000E20 RID: 3616 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x56BAAA0", Offset = "0x56B96A0", VA = "0x1856BAAA0")]
			internal string DetermineLayout()
			{
				return null;
			}

			// Token: 0x06000E21 RID: 3617 RVA: 0x00006F18 File Offset: 0x00005118
			[Token(Token = "0x6000E21")]
			[Address(RVA = "0x56BA920", Offset = "0x56B9520", VA = "0x1856BA920")]
			internal FourCC DetermineFormat()
			{
				return default(FourCC);
			}

			// Token: 0x06000E22 RID: 3618 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x56BAF90", Offset = "0x56B9B90", VA = "0x1856BAF90")]
			internal InternedString[] DetermineUsages()
			{
				return null;
			}

			// Token: 0x06000E23 RID: 3619 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E23")]
			[Address(RVA = "0x56BAD80", Offset = "0x56B9980", VA = "0x1856BAD80")]
			internal string DetermineParameters()
			{
				return null;
			}

			// Token: 0x06000E24 RID: 3620 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E24")]
			[Address(RVA = "0x56BA5B0", Offset = "0x56B91B0", VA = "0x1856BA5B0")]
			private string DetermineAxisNormalizationParameters()
			{
				return null;
			}

			// Token: 0x06000E25 RID: 3621 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E25")]
			[Address(RVA = "0x56BAF30", Offset = "0x56B9B30", VA = "0x1856BAF30")]
			internal string DetermineProcessors()
			{
				return null;
			}

			// Token: 0x06000E26 RID: 3622 RVA: 0x00006F30 File Offset: 0x00005130
			[Token(Token = "0x6000E26")]
			[Address(RVA = "0x56BA760", Offset = "0x56B9360", VA = "0x1856BA760")]
			internal PrimitiveValue DetermineDefaultState()
			{
				return default(PrimitiveValue);
			}

			// Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E27")]
			[Address(RVA = "0x56B9E50", Offset = "0x56B8A50", VA = "0x1856B9E50")]
			internal void AddChildControls(ref HID.HIDElementDescriptor element, string controlName, ref InputControlLayout.Builder builder)
			{
			}

			// Token: 0x0400071D RID: 1821
			[Token(Token = "0x400071D")]
			[FieldOffset(Offset = "0x0")]
			public int usage;

			// Token: 0x0400071E RID: 1822
			[Token(Token = "0x400071E")]
			[FieldOffset(Offset = "0x4")]
			public HID.UsagePage usagePage;

			// Token: 0x0400071F RID: 1823
			[Token(Token = "0x400071F")]
			[FieldOffset(Offset = "0x8")]
			public int unit;

			// Token: 0x04000720 RID: 1824
			[Token(Token = "0x4000720")]
			[FieldOffset(Offset = "0xC")]
			public int unitExponent;

			// Token: 0x04000721 RID: 1825
			[Token(Token = "0x4000721")]
			[FieldOffset(Offset = "0x10")]
			public int logicalMin;

			// Token: 0x04000722 RID: 1826
			[Token(Token = "0x4000722")]
			[FieldOffset(Offset = "0x14")]
			public int logicalMax;

			// Token: 0x04000723 RID: 1827
			[Token(Token = "0x4000723")]
			[FieldOffset(Offset = "0x18")]
			public int physicalMin;

			// Token: 0x04000724 RID: 1828
			[Token(Token = "0x4000724")]
			[FieldOffset(Offset = "0x1C")]
			public int physicalMax;

			// Token: 0x04000725 RID: 1829
			[Token(Token = "0x4000725")]
			[FieldOffset(Offset = "0x20")]
			public HID.HIDReportType reportType;

			// Token: 0x04000726 RID: 1830
			[Token(Token = "0x4000726")]
			[FieldOffset(Offset = "0x24")]
			public int collectionIndex;

			// Token: 0x04000727 RID: 1831
			[Token(Token = "0x4000727")]
			[FieldOffset(Offset = "0x28")]
			public int reportId;

			// Token: 0x04000728 RID: 1832
			[Token(Token = "0x4000728")]
			[FieldOffset(Offset = "0x2C")]
			public int reportSizeInBits;

			// Token: 0x04000729 RID: 1833
			[Token(Token = "0x4000729")]
			[FieldOffset(Offset = "0x30")]
			public int reportOffsetInBits;

			// Token: 0x0400072A RID: 1834
			[Token(Token = "0x400072A")]
			[FieldOffset(Offset = "0x34")]
			public HID.HIDElementFlags flags;

			// Token: 0x0400072B RID: 1835
			[Token(Token = "0x400072B")]
			[FieldOffset(Offset = "0x38")]
			public int? usageMin;

			// Token: 0x0400072C RID: 1836
			[Token(Token = "0x400072C")]
			[FieldOffset(Offset = "0x40")]
			public int? usageMax;
		}

		// Token: 0x02000137 RID: 311
		[Token(Token = "0x2000137")]
		[Serializable]
		public struct HIDCollectionDescriptor
		{
			// Token: 0x0400072D RID: 1837
			[Token(Token = "0x400072D")]
			[FieldOffset(Offset = "0x0")]
			public HID.HIDCollectionType type;

			// Token: 0x0400072E RID: 1838
			[Token(Token = "0x400072E")]
			[FieldOffset(Offset = "0x4")]
			public int usage;

			// Token: 0x0400072F RID: 1839
			[Token(Token = "0x400072F")]
			[FieldOffset(Offset = "0x8")]
			public HID.UsagePage usagePage;

			// Token: 0x04000730 RID: 1840
			[Token(Token = "0x4000730")]
			[FieldOffset(Offset = "0xC")]
			public int parent;

			// Token: 0x04000731 RID: 1841
			[Token(Token = "0x4000731")]
			[FieldOffset(Offset = "0x10")]
			public int childCount;

			// Token: 0x04000732 RID: 1842
			[Token(Token = "0x4000732")]
			[FieldOffset(Offset = "0x14")]
			public int firstChild;
		}

		// Token: 0x02000138 RID: 312
		[Token(Token = "0x2000138")]
		[Serializable]
		public struct HIDDeviceDescriptor
		{
			// Token: 0x06000E28 RID: 3624 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000E28")]
			[Address(RVA = "0x56D7AC0", Offset = "0x56D66C0", VA = "0x1856D7AC0")]
			public string ToJson()
			{
				return null;
			}

			// Token: 0x06000E29 RID: 3625 RVA: 0x00006F48 File Offset: 0x00005148
			[Token(Token = "0x6000E29")]
			[Address(RVA = "0x56D6A20", Offset = "0x56D5620", VA = "0x1856D6A20")]
			public static HID.HIDDeviceDescriptor FromJson(string json)
			{
				return default(HID.HIDDeviceDescriptor);
			}

			// Token: 0x04000733 RID: 1843
			[Token(Token = "0x4000733")]
			[FieldOffset(Offset = "0x0")]
			public int vendorId;

			// Token: 0x04000734 RID: 1844
			[Token(Token = "0x4000734")]
			[FieldOffset(Offset = "0x4")]
			public int productId;

			// Token: 0x04000735 RID: 1845
			[Token(Token = "0x4000735")]
			[FieldOffset(Offset = "0x8")]
			public int usage;

			// Token: 0x04000736 RID: 1846
			[Token(Token = "0x4000736")]
			[FieldOffset(Offset = "0xC")]
			public HID.UsagePage usagePage;

			// Token: 0x04000737 RID: 1847
			[Token(Token = "0x4000737")]
			[FieldOffset(Offset = "0x10")]
			public int inputReportSize;

			// Token: 0x04000738 RID: 1848
			[Token(Token = "0x4000738")]
			[FieldOffset(Offset = "0x14")]
			public int outputReportSize;

			// Token: 0x04000739 RID: 1849
			[Token(Token = "0x4000739")]
			[FieldOffset(Offset = "0x18")]
			public int featureReportSize;

			// Token: 0x0400073A RID: 1850
			[Token(Token = "0x400073A")]
			[FieldOffset(Offset = "0x20")]
			public HID.HIDElementDescriptor[] elements;

			// Token: 0x0400073B RID: 1851
			[Token(Token = "0x400073B")]
			[FieldOffset(Offset = "0x28")]
			public HID.HIDCollectionDescriptor[] collections;
		}

		// Token: 0x02000139 RID: 313
		[Token(Token = "0x2000139")]
		public struct HIDDeviceDescriptorBuilder
		{
			// Token: 0x06000E2A RID: 3626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E2A")]
			[Address(RVA = "0x56D69F0", Offset = "0x56D55F0", VA = "0x1856D69F0")]
			public HIDDeviceDescriptorBuilder(HID.UsagePage usagePage, int usage)
			{
			}

			// Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E2B")]
			[Address(RVA = "0x56D69C0", Offset = "0x56D55C0", VA = "0x1856D69C0")]
			public HIDDeviceDescriptorBuilder(HID.GenericDesktop usage)
			{
			}

			// Token: 0x06000E2C RID: 3628 RVA: 0x00006F60 File Offset: 0x00005160
			[Token(Token = "0x6000E2C")]
			[Address(RVA = "0x56D6640", Offset = "0x56D5240", VA = "0x1856D6640")]
			public HID.HIDDeviceDescriptorBuilder StartReport(HID.HIDReportType reportType, int reportId = 1)
			{
				return default(HID.HIDDeviceDescriptorBuilder);
			}

			// Token: 0x06000E2D RID: 3629 RVA: 0x00006F78 File Offset: 0x00005178
			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0x56D6140", Offset = "0x56D4D40", VA = "0x1856D6140")]
			public HID.HIDDeviceDescriptorBuilder AddElement(HID.UsagePage usagePage, int usage, int sizeInBits)
			{
				return default(HID.HIDDeviceDescriptorBuilder);
			}

			// Token: 0x06000E2E RID: 3630 RVA: 0x00006F90 File Offset: 0x00005190
			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0x56D6520", Offset = "0x56D5120", VA = "0x1856D6520")]
			public HID.HIDDeviceDescriptorBuilder AddElement(HID.GenericDesktop usage, int sizeInBits)
			{
				return default(HID.HIDDeviceDescriptorBuilder);
			}

			// Token: 0x06000E2F RID: 3631 RVA: 0x00006FA8 File Offset: 0x000051A8
			[Token(Token = "0x6000E2F")]
			[Address(RVA = "0x56D6820", Offset = "0x56D5420", VA = "0x1856D6820")]
			public HID.HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max)
			{
				return default(HID.HIDDeviceDescriptorBuilder);
			}

			// Token: 0x06000E30 RID: 3632 RVA: 0x00006FC0 File Offset: 0x000051C0
			[Token(Token = "0x6000E30")]
			[Address(RVA = "0x56D6680", Offset = "0x56D5280", VA = "0x1856D6680")]
			public HID.HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max)
			{
				return default(HID.HIDDeviceDescriptorBuilder);
			}

			// Token: 0x06000E31 RID: 3633 RVA: 0x00006FD8 File Offset: 0x000051D8
			[Token(Token = "0x6000E31")]
			[Address(RVA = "0x56D6580", Offset = "0x56D5180", VA = "0x1856D6580")]
			public HID.HIDDeviceDescriptor Finish()
			{
				return default(HID.HIDDeviceDescriptor);
			}

			// Token: 0x0400073C RID: 1852
			[Token(Token = "0x400073C")]
			[FieldOffset(Offset = "0x0")]
			public HID.UsagePage usagePage;

			// Token: 0x0400073D RID: 1853
			[Token(Token = "0x400073D")]
			[FieldOffset(Offset = "0x4")]
			public int usage;

			// Token: 0x0400073E RID: 1854
			[Token(Token = "0x400073E")]
			[FieldOffset(Offset = "0x8")]
			private int m_CurrentReportId;

			// Token: 0x0400073F RID: 1855
			[Token(Token = "0x400073F")]
			[FieldOffset(Offset = "0xC")]
			private HID.HIDReportType m_CurrentReportType;

			// Token: 0x04000740 RID: 1856
			[Token(Token = "0x4000740")]
			[FieldOffset(Offset = "0x10")]
			private int m_CurrentReportOffsetInBits;

			// Token: 0x04000741 RID: 1857
			[Token(Token = "0x4000741")]
			[FieldOffset(Offset = "0x18")]
			private List<HID.HIDElementDescriptor> m_Elements;

			// Token: 0x04000742 RID: 1858
			[Token(Token = "0x4000742")]
			[FieldOffset(Offset = "0x20")]
			private List<HID.HIDCollectionDescriptor> m_Collections;

			// Token: 0x04000743 RID: 1859
			[Token(Token = "0x4000743")]
			[FieldOffset(Offset = "0x28")]
			private int m_InputReportSize;

			// Token: 0x04000744 RID: 1860
			[Token(Token = "0x4000744")]
			[FieldOffset(Offset = "0x2C")]
			private int m_OutputReportSize;

			// Token: 0x04000745 RID: 1861
			[Token(Token = "0x4000745")]
			[FieldOffset(Offset = "0x30")]
			private int m_FeatureReportSize;
		}

		// Token: 0x0200013A RID: 314
		[Token(Token = "0x200013A")]
		public enum UsagePage
		{
			// Token: 0x04000747 RID: 1863
			[Token(Token = "0x4000747")]
			Undefined,
			// Token: 0x04000748 RID: 1864
			[Token(Token = "0x4000748")]
			GenericDesktop,
			// Token: 0x04000749 RID: 1865
			[Token(Token = "0x4000749")]
			Simulation,
			// Token: 0x0400074A RID: 1866
			[Token(Token = "0x400074A")]
			VRControls,
			// Token: 0x0400074B RID: 1867
			[Token(Token = "0x400074B")]
			SportControls,
			// Token: 0x0400074C RID: 1868
			[Token(Token = "0x400074C")]
			GameControls,
			// Token: 0x0400074D RID: 1869
			[Token(Token = "0x400074D")]
			GenericDeviceControls,
			// Token: 0x0400074E RID: 1870
			[Token(Token = "0x400074E")]
			Keyboard,
			// Token: 0x0400074F RID: 1871
			[Token(Token = "0x400074F")]
			LEDs,
			// Token: 0x04000750 RID: 1872
			[Token(Token = "0x4000750")]
			Button,
			// Token: 0x04000751 RID: 1873
			[Token(Token = "0x4000751")]
			Ordinal,
			// Token: 0x04000752 RID: 1874
			[Token(Token = "0x4000752")]
			Telephony,
			// Token: 0x04000753 RID: 1875
			[Token(Token = "0x4000753")]
			Consumer,
			// Token: 0x04000754 RID: 1876
			[Token(Token = "0x4000754")]
			Digitizer,
			// Token: 0x04000755 RID: 1877
			[Token(Token = "0x4000755")]
			PID = 15,
			// Token: 0x04000756 RID: 1878
			[Token(Token = "0x4000756")]
			Unicode,
			// Token: 0x04000757 RID: 1879
			[Token(Token = "0x4000757")]
			AlphanumericDisplay = 20,
			// Token: 0x04000758 RID: 1880
			[Token(Token = "0x4000758")]
			MedicalInstruments = 64,
			// Token: 0x04000759 RID: 1881
			[Token(Token = "0x4000759")]
			Monitor = 128,
			// Token: 0x0400075A RID: 1882
			[Token(Token = "0x400075A")]
			Power = 132,
			// Token: 0x0400075B RID: 1883
			[Token(Token = "0x400075B")]
			BarCodeScanner = 140,
			// Token: 0x0400075C RID: 1884
			[Token(Token = "0x400075C")]
			MagneticStripeReader = 142,
			// Token: 0x0400075D RID: 1885
			[Token(Token = "0x400075D")]
			Camera = 144,
			// Token: 0x0400075E RID: 1886
			[Token(Token = "0x400075E")]
			Arcade,
			// Token: 0x0400075F RID: 1887
			[Token(Token = "0x400075F")]
			VendorDefined = 65280
		}

		// Token: 0x0200013B RID: 315
		[Token(Token = "0x200013B")]
		public enum GenericDesktop
		{
			// Token: 0x04000761 RID: 1889
			[Token(Token = "0x4000761")]
			Undefined,
			// Token: 0x04000762 RID: 1890
			[Token(Token = "0x4000762")]
			Pointer,
			// Token: 0x04000763 RID: 1891
			[Token(Token = "0x4000763")]
			Mouse,
			// Token: 0x04000764 RID: 1892
			[Token(Token = "0x4000764")]
			Joystick = 4,
			// Token: 0x04000765 RID: 1893
			[Token(Token = "0x4000765")]
			Gamepad,
			// Token: 0x04000766 RID: 1894
			[Token(Token = "0x4000766")]
			Keyboard,
			// Token: 0x04000767 RID: 1895
			[Token(Token = "0x4000767")]
			Keypad,
			// Token: 0x04000768 RID: 1896
			[Token(Token = "0x4000768")]
			MultiAxisController,
			// Token: 0x04000769 RID: 1897
			[Token(Token = "0x4000769")]
			TabletPCControls,
			// Token: 0x0400076A RID: 1898
			[Token(Token = "0x400076A")]
			AssistiveControl,
			// Token: 0x0400076B RID: 1899
			[Token(Token = "0x400076B")]
			X = 48,
			// Token: 0x0400076C RID: 1900
			[Token(Token = "0x400076C")]
			Y,
			// Token: 0x0400076D RID: 1901
			[Token(Token = "0x400076D")]
			Z,
			// Token: 0x0400076E RID: 1902
			[Token(Token = "0x400076E")]
			Rx,
			// Token: 0x0400076F RID: 1903
			[Token(Token = "0x400076F")]
			Ry,
			// Token: 0x04000770 RID: 1904
			[Token(Token = "0x4000770")]
			Rz,
			// Token: 0x04000771 RID: 1905
			[Token(Token = "0x4000771")]
			Slider,
			// Token: 0x04000772 RID: 1906
			[Token(Token = "0x4000772")]
			Dial,
			// Token: 0x04000773 RID: 1907
			[Token(Token = "0x4000773")]
			Wheel,
			// Token: 0x04000774 RID: 1908
			[Token(Token = "0x4000774")]
			HatSwitch,
			// Token: 0x04000775 RID: 1909
			[Token(Token = "0x4000775")]
			CountedBuffer,
			// Token: 0x04000776 RID: 1910
			[Token(Token = "0x4000776")]
			ByteCount,
			// Token: 0x04000777 RID: 1911
			[Token(Token = "0x4000777")]
			MotionWakeup,
			// Token: 0x04000778 RID: 1912
			[Token(Token = "0x4000778")]
			Start,
			// Token: 0x04000779 RID: 1913
			[Token(Token = "0x4000779")]
			Select,
			// Token: 0x0400077A RID: 1914
			[Token(Token = "0x400077A")]
			Vx = 64,
			// Token: 0x0400077B RID: 1915
			[Token(Token = "0x400077B")]
			Vy,
			// Token: 0x0400077C RID: 1916
			[Token(Token = "0x400077C")]
			Vz,
			// Token: 0x0400077D RID: 1917
			[Token(Token = "0x400077D")]
			Vbrx,
			// Token: 0x0400077E RID: 1918
			[Token(Token = "0x400077E")]
			Vbry,
			// Token: 0x0400077F RID: 1919
			[Token(Token = "0x400077F")]
			Vbrz,
			// Token: 0x04000780 RID: 1920
			[Token(Token = "0x4000780")]
			Vno,
			// Token: 0x04000781 RID: 1921
			[Token(Token = "0x4000781")]
			FeatureNotification,
			// Token: 0x04000782 RID: 1922
			[Token(Token = "0x4000782")]
			ResolutionMultiplier,
			// Token: 0x04000783 RID: 1923
			[Token(Token = "0x4000783")]
			SystemControl = 128,
			// Token: 0x04000784 RID: 1924
			[Token(Token = "0x4000784")]
			SystemPowerDown,
			// Token: 0x04000785 RID: 1925
			[Token(Token = "0x4000785")]
			SystemSleep,
			// Token: 0x04000786 RID: 1926
			[Token(Token = "0x4000786")]
			SystemWakeUp,
			// Token: 0x04000787 RID: 1927
			[Token(Token = "0x4000787")]
			SystemContextMenu,
			// Token: 0x04000788 RID: 1928
			[Token(Token = "0x4000788")]
			SystemMainMenu,
			// Token: 0x04000789 RID: 1929
			[Token(Token = "0x4000789")]
			SystemAppMenu,
			// Token: 0x0400078A RID: 1930
			[Token(Token = "0x400078A")]
			SystemMenuHelp,
			// Token: 0x0400078B RID: 1931
			[Token(Token = "0x400078B")]
			SystemMenuExit,
			// Token: 0x0400078C RID: 1932
			[Token(Token = "0x400078C")]
			SystemMenuSelect,
			// Token: 0x0400078D RID: 1933
			[Token(Token = "0x400078D")]
			SystemMenuRight,
			// Token: 0x0400078E RID: 1934
			[Token(Token = "0x400078E")]
			SystemMenuLeft,
			// Token: 0x0400078F RID: 1935
			[Token(Token = "0x400078F")]
			SystemMenuUp,
			// Token: 0x04000790 RID: 1936
			[Token(Token = "0x4000790")]
			SystemMenuDown,
			// Token: 0x04000791 RID: 1937
			[Token(Token = "0x4000791")]
			SystemColdRestart,
			// Token: 0x04000792 RID: 1938
			[Token(Token = "0x4000792")]
			SystemWarmRestart,
			// Token: 0x04000793 RID: 1939
			[Token(Token = "0x4000793")]
			DpadUp,
			// Token: 0x04000794 RID: 1940
			[Token(Token = "0x4000794")]
			DpadDown,
			// Token: 0x04000795 RID: 1941
			[Token(Token = "0x4000795")]
			DpadRight,
			// Token: 0x04000796 RID: 1942
			[Token(Token = "0x4000796")]
			DpadLeft,
			// Token: 0x04000797 RID: 1943
			[Token(Token = "0x4000797")]
			SystemDock = 160,
			// Token: 0x04000798 RID: 1944
			[Token(Token = "0x4000798")]
			SystemUndock,
			// Token: 0x04000799 RID: 1945
			[Token(Token = "0x4000799")]
			SystemSetup,
			// Token: 0x0400079A RID: 1946
			[Token(Token = "0x400079A")]
			SystemBreak,
			// Token: 0x0400079B RID: 1947
			[Token(Token = "0x400079B")]
			SystemDebuggerBreak,
			// Token: 0x0400079C RID: 1948
			[Token(Token = "0x400079C")]
			ApplicationBreak,
			// Token: 0x0400079D RID: 1949
			[Token(Token = "0x400079D")]
			ApplicationDebuggerBreak,
			// Token: 0x0400079E RID: 1950
			[Token(Token = "0x400079E")]
			SystemSpeakerMute,
			// Token: 0x0400079F RID: 1951
			[Token(Token = "0x400079F")]
			SystemHibernate,
			// Token: 0x040007A0 RID: 1952
			[Token(Token = "0x40007A0")]
			SystemDisplayInvert = 176,
			// Token: 0x040007A1 RID: 1953
			[Token(Token = "0x40007A1")]
			SystemDisplayInternal,
			// Token: 0x040007A2 RID: 1954
			[Token(Token = "0x40007A2")]
			SystemDisplayExternal,
			// Token: 0x040007A3 RID: 1955
			[Token(Token = "0x40007A3")]
			SystemDisplayBoth,
			// Token: 0x040007A4 RID: 1956
			[Token(Token = "0x40007A4")]
			SystemDisplayDual,
			// Token: 0x040007A5 RID: 1957
			[Token(Token = "0x40007A5")]
			SystemDisplayToggleIntExt,
			// Token: 0x040007A6 RID: 1958
			[Token(Token = "0x40007A6")]
			SystemDisplaySwapPrimarySecondary,
			// Token: 0x040007A7 RID: 1959
			[Token(Token = "0x40007A7")]
			SystemDisplayLCDAutoScale
		}

		// Token: 0x0200013C RID: 316
		[Token(Token = "0x200013C")]
		public enum Simulation
		{
			// Token: 0x040007A9 RID: 1961
			[Token(Token = "0x40007A9")]
			Undefined,
			// Token: 0x040007AA RID: 1962
			[Token(Token = "0x40007AA")]
			FlightSimulationDevice,
			// Token: 0x040007AB RID: 1963
			[Token(Token = "0x40007AB")]
			AutomobileSimulationDevice,
			// Token: 0x040007AC RID: 1964
			[Token(Token = "0x40007AC")]
			TankSimulationDevice,
			// Token: 0x040007AD RID: 1965
			[Token(Token = "0x40007AD")]
			SpaceshipSimulationDevice,
			// Token: 0x040007AE RID: 1966
			[Token(Token = "0x40007AE")]
			SubmarineSimulationDevice,
			// Token: 0x040007AF RID: 1967
			[Token(Token = "0x40007AF")]
			SailingSimulationDevice,
			// Token: 0x040007B0 RID: 1968
			[Token(Token = "0x40007B0")]
			MotorcycleSimulationDevice,
			// Token: 0x040007B1 RID: 1969
			[Token(Token = "0x40007B1")]
			SportsSimulationDevice,
			// Token: 0x040007B2 RID: 1970
			[Token(Token = "0x40007B2")]
			AirplaneSimulationDevice,
			// Token: 0x040007B3 RID: 1971
			[Token(Token = "0x40007B3")]
			HelicopterSimulationDevice,
			// Token: 0x040007B4 RID: 1972
			[Token(Token = "0x40007B4")]
			MagicCarpetSimulationDevice,
			// Token: 0x040007B5 RID: 1973
			[Token(Token = "0x40007B5")]
			BicylcleSimulationDevice,
			// Token: 0x040007B6 RID: 1974
			[Token(Token = "0x40007B6")]
			FlightControlStick = 32,
			// Token: 0x040007B7 RID: 1975
			[Token(Token = "0x40007B7")]
			FlightStick,
			// Token: 0x040007B8 RID: 1976
			[Token(Token = "0x40007B8")]
			CyclicControl,
			// Token: 0x040007B9 RID: 1977
			[Token(Token = "0x40007B9")]
			CyclicTrim,
			// Token: 0x040007BA RID: 1978
			[Token(Token = "0x40007BA")]
			FlightYoke,
			// Token: 0x040007BB RID: 1979
			[Token(Token = "0x40007BB")]
			TrackControl,
			// Token: 0x040007BC RID: 1980
			[Token(Token = "0x40007BC")]
			Aileron = 176,
			// Token: 0x040007BD RID: 1981
			[Token(Token = "0x40007BD")]
			AileronTrim,
			// Token: 0x040007BE RID: 1982
			[Token(Token = "0x40007BE")]
			AntiTorqueControl,
			// Token: 0x040007BF RID: 1983
			[Token(Token = "0x40007BF")]
			AutopilotEnable,
			// Token: 0x040007C0 RID: 1984
			[Token(Token = "0x40007C0")]
			ChaffRelease,
			// Token: 0x040007C1 RID: 1985
			[Token(Token = "0x40007C1")]
			CollectiveControl,
			// Token: 0x040007C2 RID: 1986
			[Token(Token = "0x40007C2")]
			DiveBreak,
			// Token: 0x040007C3 RID: 1987
			[Token(Token = "0x40007C3")]
			ElectronicCountermeasures,
			// Token: 0x040007C4 RID: 1988
			[Token(Token = "0x40007C4")]
			Elevator,
			// Token: 0x040007C5 RID: 1989
			[Token(Token = "0x40007C5")]
			ElevatorTrim,
			// Token: 0x040007C6 RID: 1990
			[Token(Token = "0x40007C6")]
			Rudder,
			// Token: 0x040007C7 RID: 1991
			[Token(Token = "0x40007C7")]
			Throttle,
			// Token: 0x040007C8 RID: 1992
			[Token(Token = "0x40007C8")]
			FlightCommunications,
			// Token: 0x040007C9 RID: 1993
			[Token(Token = "0x40007C9")]
			FlareRelease,
			// Token: 0x040007CA RID: 1994
			[Token(Token = "0x40007CA")]
			LandingGear,
			// Token: 0x040007CB RID: 1995
			[Token(Token = "0x40007CB")]
			ToeBreak,
			// Token: 0x040007CC RID: 1996
			[Token(Token = "0x40007CC")]
			Trigger,
			// Token: 0x040007CD RID: 1997
			[Token(Token = "0x40007CD")]
			WeaponsArm,
			// Token: 0x040007CE RID: 1998
			[Token(Token = "0x40007CE")]
			WeaponsSelect,
			// Token: 0x040007CF RID: 1999
			[Token(Token = "0x40007CF")]
			WingFlaps,
			// Token: 0x040007D0 RID: 2000
			[Token(Token = "0x40007D0")]
			Accelerator,
			// Token: 0x040007D1 RID: 2001
			[Token(Token = "0x40007D1")]
			Brake,
			// Token: 0x040007D2 RID: 2002
			[Token(Token = "0x40007D2")]
			Clutch,
			// Token: 0x040007D3 RID: 2003
			[Token(Token = "0x40007D3")]
			Shifter,
			// Token: 0x040007D4 RID: 2004
			[Token(Token = "0x40007D4")]
			Steering,
			// Token: 0x040007D5 RID: 2005
			[Token(Token = "0x40007D5")]
			TurretDirection,
			// Token: 0x040007D6 RID: 2006
			[Token(Token = "0x40007D6")]
			BarrelElevation,
			// Token: 0x040007D7 RID: 2007
			[Token(Token = "0x40007D7")]
			DivePlane,
			// Token: 0x040007D8 RID: 2008
			[Token(Token = "0x40007D8")]
			Ballast,
			// Token: 0x040007D9 RID: 2009
			[Token(Token = "0x40007D9")]
			BicycleCrank,
			// Token: 0x040007DA RID: 2010
			[Token(Token = "0x40007DA")]
			HandleBars,
			// Token: 0x040007DB RID: 2011
			[Token(Token = "0x40007DB")]
			FrontBrake,
			// Token: 0x040007DC RID: 2012
			[Token(Token = "0x40007DC")]
			RearBrake
		}

		// Token: 0x0200013D RID: 317
		[Token(Token = "0x200013D")]
		public enum Button
		{
			// Token: 0x040007DE RID: 2014
			[Token(Token = "0x40007DE")]
			Undefined,
			// Token: 0x040007DF RID: 2015
			[Token(Token = "0x40007DF")]
			Primary,
			// Token: 0x040007E0 RID: 2016
			[Token(Token = "0x40007E0")]
			Secondary,
			// Token: 0x040007E1 RID: 2017
			[Token(Token = "0x40007E1")]
			Tertiary
		}
	}
}
