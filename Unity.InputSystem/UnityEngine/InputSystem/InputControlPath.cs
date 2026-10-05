using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public static class InputControlPath
	{
		// Token: 0x060005DA RID: 1498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x5621140", Offset = "0x561FD40", VA = "0x185621140")]
		internal static string CleanSlashes(this string pathComponent)
		{
			return null;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x5621170", Offset = "0x561FD70", VA = "0x185621170")]
		public static string Combine(InputControl parent, string path)
		{
			return null;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x56226F0", Offset = "0x56212F0", VA = "0x1856226F0")]
		public static string ToHumanReadableString(string path, InputControlPath.HumanReadableStringOptions options = InputControlPath.HumanReadableStringOptions.None, [Optional] InputControl control)
		{
			return null;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x5622730", Offset = "0x5621330", VA = "0x185622730")]
		public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, InputControlPath.HumanReadableStringOptions options = InputControlPath.HumanReadableStringOptions.None, [Optional] InputControl control)
		{
			return null;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x5623370", Offset = "0x5621F70", VA = "0x185623370")]
		public static string[] TryGetDeviceUsages(string path)
		{
			return null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x5623200", Offset = "0x5621E00", VA = "0x185623200")]
		public static string TryGetDeviceLayout(string path)
		{
			return null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x5622F90", Offset = "0x5621B90", VA = "0x185622F90")]
		public static string TryGetControlLayout(string path)
		{
			return null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x5621860", Offset = "0x5620460", VA = "0x185621860")]
		private static string FindControlLayoutRecursive(ref InputControlPath.PathParser parser, string layoutName)
		{
			return null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x5621460", Offset = "0x5620060", VA = "0x185621460")]
		private static string FindControlLayoutRecursive(ref InputControlPath.PathParser parser, InputControlLayout layout)
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x5621260", Offset = "0x561FE60", VA = "0x185621260")]
		private static bool ControlLayoutMatchesPathComponent(ref InputControlLayout.ControlItem controlItem, ref InputControlPath.PathParser parser)
		{
			return default(bool);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x5622500", Offset = "0x5621100", VA = "0x185622500")]
		private static bool StringMatches(Substring str, InternedString matchTo)
		{
			return default(bool);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x5622D90", Offset = "0x5621990", VA = "0x185622D90")]
		public static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0)
		{
			return null;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x5622E60", Offset = "0x5621A60", VA = "0x185622E60")]
		public static InputControl[] TryFindControls(InputControl control, string path, int indexInPath = 0)
		{
			return null;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x5622DF0", Offset = "0x56219F0", VA = "0x185622DF0")]
		public static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl> matches, int indexInPath = 0)
		{
			return 0;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005E8")]
		public static TControl TryFindControl<TControl>(InputControl control, string path, int indexInPath = 0) where TControl : InputControl
		{
			return null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x60005E9")]
		public static int TryFindControls<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches) where TControl : InputControl
		{
			return 0;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x5622D30", Offset = "0x5621930", VA = "0x185622D30")]
		public static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0)
		{
			return null;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005EB")]
		public static TControl TryFindChild<TControl>(InputControl control, string path, int indexInPath = 0) where TControl : InputControl
		{
			return null;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x5622210", Offset = "0x5620E10", VA = "0x185622210")]
		public static bool Matches(string expected, InputControl control)
		{
			return default(bool);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x56219C0", Offset = "0x56205C0", VA = "0x1856219C0")]
		internal static bool MatchControlComponent(ref InputControlPath.ParsedPathComponent expectedControlComponent, ref InputControlLayout.ControlItem controlItem, bool matchAlias = false)
		{
			return default(bool);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x5621FD0", Offset = "0x5620BD0", VA = "0x185621FD0")]
		public static bool MatchesPrefix(string expected, InputControl control)
		{
			return default(bool);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x5622180", Offset = "0x5620D80", VA = "0x185622180")]
		private static bool MatchesRecursive(ref InputControlPath.PathParser parser, InputControl currentControl, bool prefixOnly = false)
		{
			return default(bool);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F0")]
		private static TControl MatchControlsRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
		{
			return null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F1")]
		private static TControl MatchByUsageAtDeviceRootRecursive<TControl>(InputDevice device, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
		{
			return null;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F2")]
		private static TControl MatchChildrenRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
		{
			return null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x5621D80", Offset = "0x5620980", VA = "0x185621D80")]
		private static bool MatchPathComponent(string component, string path, ref int indexInPath, InputControlPath.PathComponentType componentType, int startIndexInComponent = 0)
		{
			return default(bool);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x5622430", Offset = "0x5621030", VA = "0x185622430")]
		private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath)
		{
			return default(bool);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x56223B0", Offset = "0x5620FB0", VA = "0x1856223B0")]
		public static IEnumerable<InputControlPath.ParsedPathComponent> Parse(string path)
		{
			return null;
		}

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		public const string Wildcard = "*";

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		public const string DoubleWildcard = "**";

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		public const char Separator = '/';

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		internal const char SeparatorReplacement = ' ';

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		[Flags]
		public enum HumanReadableStringOptions
		{
			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			None = 0,
			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			OmitDevice = 2,
			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			UseShortNames = 4
		}

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x200007B")]
		private enum PathComponentType
		{
			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			Name,
			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			DisplayName,
			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			Usage,
			// Token: 0x040002C0 RID: 704
			[Token(Token = "0x40002C0")]
			Layout
		}

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x200007C")]
		public struct ParsedPathComponent
		{
			// Token: 0x1700019D RID: 413
			// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700019D")]
			public string layout
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x562FA30", Offset = "0x562E630", VA = "0x18562FA30")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700019E")]
			public IEnumerable<string> usages
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x562FA50", Offset = "0x562E650", VA = "0x18562FA50")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700019F")]
			public string name
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x562FA40", Offset = "0x562E640", VA = "0x18562FA40")]
				get
				{
					return null;
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001A0")]
			public string displayName
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x562F940", Offset = "0x562E540", VA = "0x18562F940")]
				get
				{
					return null;
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x060005FA RID: 1530 RVA: 0x00004C08 File Offset: 0x00002E08
			[Token(Token = "0x170001A1")]
			internal bool isWildcard
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x562F9C0", Offset = "0x562E5C0", VA = "0x18562F9C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x060005FB RID: 1531 RVA: 0x00004C20 File Offset: 0x00002E20
			[Token(Token = "0x170001A2")]
			internal bool isDoubleWildcard
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x562F950", Offset = "0x562E550", VA = "0x18562F950")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x562EF80", Offset = "0x562DB80", VA = "0x18562EF80")]
			internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, InputControlPath.HumanReadableStringOptions options)
			{
				return null;
			}

			// Token: 0x060005FD RID: 1533 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x562EF30", Offset = "0x562DB30", VA = "0x18562EF30")]
			private static string ToHumanReadableString(Substring substring)
			{
				return null;
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x00004C38 File Offset: 0x00002E38
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x562EB40", Offset = "0x562D740", VA = "0x18562EB40")]
			public bool Matches(InputControl control)
			{
				return default(bool);
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x00004C50 File Offset: 0x00002E50
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x562EA10", Offset = "0x562D610", VA = "0x18562EA10")]
			private static bool ComparePathElementToString(Substring pathElement, string element)
			{
				return default(bool);
			}

			// Token: 0x040002C1 RID: 705
			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Substring m_Layout;

			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal InlinedArray<Substring> m_Usages;

			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Substring m_Name;

			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Substring m_DisplayName;
		}

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		private struct PathParser
		{
			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x06000603 RID: 1539 RVA: 0x00004C68 File Offset: 0x00002E68
			[Token(Token = "0x170001A3")]
			public bool isAtEnd
			{
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x5630200", Offset = "0x562EE00", VA = "0x185630200")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x56301A0", Offset = "0x562EDA0", VA = "0x1856301A0")]
			public PathParser(string path)
			{
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x00004C80 File Offset: 0x00002E80
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x562FBB0", Offset = "0x562E7B0", VA = "0x18562FBB0")]
			public bool MoveToNextComponent()
			{
				return default(bool);
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00004C98 File Offset: 0x00002E98
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x56300C0", Offset = "0x562ECC0", VA = "0x1856300C0")]
			private Substring ParseComponentPart(char terminator)
			{
				return default(Substring);
			}

			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string path;

			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int length;

			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int leftIndexInPath;

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int rightIndexInPath;

			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InputControlPath.ParsedPathComponent current;
		}
	}
}
