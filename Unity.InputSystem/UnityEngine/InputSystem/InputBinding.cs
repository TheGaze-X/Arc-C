using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[Serializable]
	public struct InputBinding : IEquatable<InputBinding>
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000122")]
		public string name
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000123")]
		public Guid id
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x55F8160", Offset = "0x55F6D60", VA = "0x1855F8160")]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x55F83B0", Offset = "0x55F6FB0", VA = "0x1855F83B0")]
			set
			{
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000124")]
		public string path
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000125")]
		public string overridePath
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000126")]
		public string interactions
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		public string overrideInteractions
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		public string processors
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000129")]
		public string overrideProcessors
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012A")]
		public string groups
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		public string action
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00003A50 File Offset: 0x00001C50
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012C")]
		public bool isComposite
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x55F81B0", Offset = "0x55F6DB0", VA = "0x1855F81B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x55F83E0", Offset = "0x55F6FE0", VA = "0x1855F83E0")]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00003A68 File Offset: 0x00001C68
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		public bool isPartOfComposite
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x55F8210", Offset = "0x55F6E10", VA = "0x1855F8210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x55F8400", Offset = "0x55F7000", VA = "0x1855F8400")]
			set
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x1700012E")]
		public bool hasOverrides
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x55F8140", Offset = "0x55F6D40", VA = "0x1855F8140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x55F8040", Offset = "0x55F6C40", VA = "0x1855F8040")]
		public InputBinding(string path, [Optional] string action, [Optional] string groups, [Optional] string processors, [Optional] string interactions, [Optional] string name)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x55F75C0", Offset = "0x55F61C0", VA = "0x1855F75C0")]
		public string GetNameOfComposite()
		{
			return null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x55F73F0", Offset = "0x55F5FF0", VA = "0x1855F73F0")]
		internal void GenerateId()
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x55F79A0", Offset = "0x55F65A0", VA = "0x1855F79A0")]
		internal void RemoveOverrides()
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x55F7600", Offset = "0x55F6200", VA = "0x1855F7600")]
		public static InputBinding MaskByGroup(string group)
		{
			return default(InputBinding);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x55F7640", Offset = "0x55F6240", VA = "0x1855F7640")]
		public static InputBinding MaskByGroups(params string[] groups)
		{
			return default(InputBinding);
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700012F")]
		public string effectivePath
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x55F8120", Offset = "0x55F6D20", VA = "0x1855F8120")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000130")]
		public string effectiveInteractions
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x55F8110", Offset = "0x55F6D10", VA = "0x1855F8110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000131")]
		public string effectiveProcessors
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x55F8130", Offset = "0x55F6D30", VA = "0x1855F8130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x17000132")]
		internal bool isEmpty
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x55F81C0", Offset = "0x55F6DC0", VA = "0x1855F81C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x55F7310", Offset = "0x55F5F10", VA = "0x1855F7310", Slot = "4")]
		public bool Equals(InputBinding other)
		{
			return default(bool);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x55F7230", Offset = "0x55F5E30", VA = "0x1855F7230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x55F8220", Offset = "0x55F6E20", VA = "0x1855F8220")]
		public static bool operator ==(InputBinding left, InputBinding right)
		{
			return default(bool);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x55F8270", Offset = "0x55F6E70", VA = "0x1855F8270")]
		public static bool operator !=(InputBinding left, InputBinding right)
		{
			return default(bool);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x55F7430", Offset = "0x55F6030", VA = "0x1855F7430", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x55F7EB0", Offset = "0x55F6AB0", VA = "0x1855F7EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x55F7E70", Offset = "0x55F6A70", VA = "0x1855F7E70")]
		public string ToDisplayString(InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0, [Optional] InputControl control)
		{
			return null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x55F79F0", Offset = "0x55F65F0", VA = "0x1855F79F0")]
		public string ToDisplayString(out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options = (InputBinding.DisplayStringOptions)0, [Optional] InputControl control)
		{
			return null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x55F7FE0", Offset = "0x55F6BE0", VA = "0x1855F7FE0")]
		internal bool TriggersAction(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x55F77D0", Offset = "0x55F63D0", VA = "0x1855F77D0")]
		public bool Matches(InputBinding binding)
		{
			return default(bool);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x55F77F0", Offset = "0x55F63F0", VA = "0x1855F77F0")]
		internal bool Matches(ref InputBinding binding, InputBinding.MatchOptions options = (InputBinding.MatchOptions)0)
		{
			return default(bool);
		}

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		public const char Separator = ';';

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		internal const string kSeparatorString = ";";

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string m_Name;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		internal string m_Id;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Tooltip("Path of the control to bind to. Matched at runtime to controls from InputDevices present at the time.\n\nCan either be graphically from the control picker dropdown UI or edited manually in text mode by clicking the 'T' button. Internally, both methods result in control path strings that look like, for example, \"<Gamepad>/buttonSouth\".")]
		private string m_Path;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Interactions;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_Processors;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal string m_Groups;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_Action;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal InputBinding.Flags m_Flags;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private string m_OverridePath;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private string m_OverrideInteractions;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private string m_OverrideProcessors;

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		[Flags]
		public enum DisplayStringOptions
		{
			// Token: 0x040001E4 RID: 484
			[Token(Token = "0x40001E4")]
			DontUseShortDisplayNames = 1,
			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x40001E5")]
			DontOmitDevice = 2,
			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x40001E6")]
			DontIncludeInteractions = 4,
			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x40001E7")]
			IgnoreBindingOverrides = 8
		}

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		[Flags]
		internal enum MatchOptions
		{
			// Token: 0x040001E9 RID: 489
			[Token(Token = "0x40001E9")]
			EmptyGroupMatchesAny = 1
		}

		// Token: 0x02000050 RID: 80
		[Token(Token = "0x2000050")]
		[Flags]
		internal enum Flags
		{
			// Token: 0x040001EB RID: 491
			[Token(Token = "0x40001EB")]
			None = 0,
			// Token: 0x040001EC RID: 492
			[Token(Token = "0x40001EC")]
			Composite = 4,
			// Token: 0x040001ED RID: 493
			[Token(Token = "0x40001ED")]
			PartOfComposite = 8
		}
	}
}
