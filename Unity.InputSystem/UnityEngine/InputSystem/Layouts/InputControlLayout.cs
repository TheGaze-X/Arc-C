using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Layouts
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	public class InputControlLayout
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x17000532")]
		public static InternedString DefaultVariant
		{
			[Token(Token = "0x6001226")]
			[Address(RVA = "0x56EDD20", Offset = "0x56EC920", VA = "0x1856EDD20")]
			get
			{
				return default(InternedString);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x17000533")]
		public InternedString name
		{
			[Token(Token = "0x6001227")]
			[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
			get
			{
				return default(InternedString);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000534")]
		public string displayName
		{
			[Token(Token = "0x6001228")]
			[Address(RVA = "0x56EE150", Offset = "0x56ECD50", VA = "0x1856EE150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000535")]
		public Type type
		{
			[Token(Token = "0x6001229")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x17000536")]
		public InternedString variants
		{
			[Token(Token = "0x600122A")]
			[Address(RVA = "0x4013E20", Offset = "0x4012A20", VA = "0x184013E20")]
			get
			{
				return default(InternedString);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x17000537")]
		public FourCC stateFormat
		{
			[Token(Token = "0x600122B")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x17000538")]
		public int stateSizeInBytes
		{
			[Token(Token = "0x600122C")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000539")]
		public IEnumerable<InternedString> baseLayouts
		{
			[Token(Token = "0x600122D")]
			[Address(RVA = "0x56EDF90", Offset = "0x56ECB90", VA = "0x1856EDF90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700053A")]
		public IEnumerable<InternedString> appliedOverrides
		{
			[Token(Token = "0x600122E")]
			[Address(RVA = "0x56EDF40", Offset = "0x56ECB40", VA = "0x1856EDF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x1700053B")]
		public ReadOnlyArray<InternedString> commonUsages
		{
			[Token(Token = "0x600122F")]
			[Address(RVA = "0x56EE090", Offset = "0x56ECC90", VA = "0x1856EE090")]
			get
			{
				return default(ReadOnlyArray<InternedString>);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x1700053C")]
		public ReadOnlyArray<InputControlLayout.ControlItem> controls
		{
			[Token(Token = "0x6001230")]
			[Address(RVA = "0x56EE0F0", Offset = "0x56ECCF0", VA = "0x1856EE0F0")]
			get
			{
				return default(ReadOnlyArray<InputControlLayout.ControlItem>);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x1700053D")]
		public bool updateBeforeRender
		{
			[Token(Token = "0x6001231")]
			[Address(RVA = "0x56EE320", Offset = "0x56ECF20", VA = "0x1856EE320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x1700053E")]
		public bool isDeviceLayout
		{
			[Token(Token = "0x6001232")]
			[Address(RVA = "0x56EE240", Offset = "0x56ECE40", VA = "0x1856EE240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x1700053F")]
		public bool isControlLayout
		{
			[Token(Token = "0x6001233")]
			[Address(RVA = "0x56EE190", Offset = "0x56ECD90", VA = "0x1856EE190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00009798 File Offset: 0x00007998
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000540")]
		public bool isOverride
		{
			[Token(Token = "0x6001234")]
			[Address(RVA = "0x56EE310", Offset = "0x56ECF10", VA = "0x1856EE310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001235")]
			[Address(RVA = "0x56EE460", Offset = "0x56ED060", VA = "0x1856EE460")]
			internal set
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x000097B0 File Offset: 0x000079B0
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000541")]
		public bool isGenericTypeOfDevice
		{
			[Token(Token = "0x6001236")]
			[Address(RVA = "0x56EE2F0", Offset = "0x56ECEF0", VA = "0x1856EE2F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001237")]
			[Address(RVA = "0x56EE420", Offset = "0x56ED020", VA = "0x1856EE420")]
			internal set
			{
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000097C8 File Offset: 0x000079C8
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000542")]
		public bool hideInUI
		{
			[Token(Token = "0x6001238")]
			[Address(RVA = "0x56EE180", Offset = "0x56ECD80", VA = "0x1856EE180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001239")]
			[Address(RVA = "0x56EE400", Offset = "0x56ED000", VA = "0x1856EE400")]
			internal set
			{
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000097E0 File Offset: 0x000079E0
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000543")]
		public bool isNoisy
		{
			[Token(Token = "0x600123A")]
			[Address(RVA = "0x56EE300", Offset = "0x56ECF00", VA = "0x1856EE300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600123B")]
			[Address(RVA = "0x56EE440", Offset = "0x56ED040", VA = "0x1856EE440")]
			internal set
			{
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x000097F8 File Offset: 0x000079F8
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000544")]
		public bool? canRunInBackground
		{
			[Token(Token = "0x600123C")]
			[Address(RVA = "0x56EE030", Offset = "0x56ECC30", VA = "0x1856EE030")]
			get
			{
				return null;
			}
			[Token(Token = "0x600123D")]
			[Address(RVA = "0x56EE360", Offset = "0x56ECF60", VA = "0x1856EE360")]
			internal set
			{
			}
		}

		// Token: 0x17000545 RID: 1349
		[Token(Token = "0x17000545")]
		public InputControlLayout.ControlItem this[string path]
		{
			[Token(Token = "0x600123E")]
			[Address(RVA = "0x56EDD80", Offset = "0x56EC980", VA = "0x1856EDD80")]
			get
			{
				return default(InputControlLayout.ControlItem);
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x56EB440", Offset = "0x56EA040", VA = "0x1856EB440")]
		public InputControlLayout.ControlItem? FindControl(InternedString path)
		{
			return null;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x6001240")]
		[Address(RVA = "0x56EAF20", Offset = "0x56E9B20", VA = "0x1856EAF20")]
		public InputControlLayout.ControlItem? FindControlIncludingArrayElements(string path, out int arrayIndex)
		{
			return null;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x56EBE00", Offset = "0x56EAA00", VA = "0x1856EBE00")]
		public Type GetValueType()
		{
			return null;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001242")]
		[Address(RVA = "0x56EB850", Offset = "0x56EA450", VA = "0x1856EB850")]
		public static InputControlLayout FromType(string name, Type type)
		{
			return null;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001243")]
		[Address(RVA = "0x56ED940", Offset = "0x56EC540", VA = "0x1856ED940")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x56EB790", Offset = "0x56EA390", VA = "0x1856EB790")]
		public static InputControlLayout FromJson(string json)
		{
			return null;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x56EDCB0", Offset = "0x56EC8B0", VA = "0x1856EDCB0")]
		private InputControlLayout(string name, Type type)
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x56E9ED0", Offset = "0x56E8AD0", VA = "0x1856E9ED0")]
		private static void AddControlItems(Type type, List<InputControlLayout.ControlItem> controlLayouts, string layoutName)
		{
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x56E9410", Offset = "0x56E8010", VA = "0x1856E9410")]
		private static void AddControlItemsFromFields(Type type, List<InputControlLayout.ControlItem> controlLayouts, string layoutName)
		{
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x56E9E20", Offset = "0x56E8A20", VA = "0x1856E9E20")]
		private static void AddControlItemsFromProperties(Type type, List<InputControlLayout.ControlItem> controlLayouts, string layoutName)
		{
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x56E9880", Offset = "0x56E8480", VA = "0x1856E9880")]
		private static void AddControlItemsFromMembers(MemberInfo[] members, List<InputControlLayout.ControlItem> controlItems, string layoutName)
		{
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124A")]
		[Address(RVA = "0x56E94C0", Offset = "0x56E80C0", VA = "0x1856E94C0")]
		private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<InputControlLayout.ControlItem> controlItems)
		{
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x56EA080", Offset = "0x56E8C80", VA = "0x1856EA080")]
		private static InputControlLayout.ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute)
		{
			return default(InputControlLayout.ControlItem);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x56EBE80", Offset = "0x56EAA80", VA = "0x1856EBE80")]
		private static string InferLayoutFromValueType(Type type)
		{
			return null;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x56EC0C0", Offset = "0x56EACC0", VA = "0x1856EC0C0")]
		public void MergeLayout(InputControlLayout other)
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600124E")]
		[Address(RVA = "0x56EAA80", Offset = "0x56E9680", VA = "0x1856EAA80")]
		private static Dictionary<string, InputControlLayout.ControlItem> CreateLookupTableForControls(InputControlLayout.ControlItem[] controlItems, [Optional] List<string> variants)
		{
			return null;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x600124F")]
		[Address(RVA = "0x56EDA90", Offset = "0x56EC690", VA = "0x1856EDA90")]
		internal static bool VariantsMatch(InternedString expected, InternedString actual)
		{
			return default(bool);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x6001250")]
		[Address(RVA = "0x56EDAF0", Offset = "0x56EC6F0", VA = "0x1856EDAF0")]
		internal static bool VariantsMatch(string expected, string actual)
		{
			return default(bool);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x56ED770", Offset = "0x56EC370", VA = "0x1856ED770")]
		internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString> baseLayouts, out InputDeviceMatcher deviceMatcher)
		{
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000546")]
		internal static ref InputControlLayout.Cache cache
		{
			[Token(Token = "0x6001252")]
			[Address(RVA = "0x56EDFE0", Offset = "0x56ECBE0", VA = "0x1856EDFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x56EA030", Offset = "0x56E8C30", VA = "0x1856EA030")]
		internal static InputControlLayout.CacheRefInstance CacheRef()
		{
			return default(InputControlLayout.CacheRefInstance);
		}

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InternedString s_DefaultVariant;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		public const string VariantSeparator = ";";

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private InternedString m_Name;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Type m_Type;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InternedString m_Variants;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FourCC m_StateFormat;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal int m_StateSizeInBytes;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool? m_UpdateBeforeRender;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal InlinedArray<InternedString> m_BaseLayouts;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private InlinedArray<InternedString> m_AppliedOverrides;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private InternedString[] m_CommonUsages;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal InputControlLayout.ControlItem[] m_Controls;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal string m_DisplayName;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string m_Description;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InputControlLayout.Flags m_Flags;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static InputControlLayout.Collection s_Layouts;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal static InputControlLayout.Cache s_CacheInstance;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal static int s_CacheInstanceRef;

		// Token: 0x020001F0 RID: 496
		[Token(Token = "0x20001F0")]
		public struct ControlItem
		{
			// Token: 0x17000547 RID: 1351
			// (get) Token: 0x06001256 RID: 4694 RVA: 0x000098D0 File Offset: 0x00007AD0
			// (set) Token: 0x06001257 RID: 4695 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000547")]
			public InternedString name
			{
				[Token(Token = "0x6001256")]
				[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
				[CompilerGenerated]
				readonly get
				{
					return default(InternedString);
				}
				[Token(Token = "0x6001257")]
				[Address(RVA = "0x4F7EA0", Offset = "0x4F6AA0", VA = "0x1804F7EA0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000548 RID: 1352
			// (get) Token: 0x06001258 RID: 4696 RVA: 0x000098E8 File Offset: 0x00007AE8
			// (set) Token: 0x06001259 RID: 4697 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000548")]
			public InternedString layout
			{
				[Token(Token = "0x6001258")]
				[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
				[CompilerGenerated]
				readonly get
				{
					return default(InternedString);
				}
				[Token(Token = "0x6001259")]
				[Address(RVA = "0x4229E60", Offset = "0x4228A60", VA = "0x184229E60")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000549 RID: 1353
			// (get) Token: 0x0600125A RID: 4698 RVA: 0x00009900 File Offset: 0x00007B00
			// (set) Token: 0x0600125B RID: 4699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000549")]
			public InternedString variants
			{
				[Token(Token = "0x600125A")]
				[Address(RVA = "0xF10AF0", Offset = "0xF0F6F0", VA = "0x180F10AF0")]
				[CompilerGenerated]
				readonly get
				{
					return default(InternedString);
				}
				[Token(Token = "0x600125B")]
				[Address(RVA = "0x56E8FD0", Offset = "0x56E7BD0", VA = "0x1856E8FD0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x1700054A RID: 1354
			// (get) Token: 0x0600125C RID: 4700 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600125D RID: 4701 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700054A")]
			public string useStateFrom
			{
				[Token(Token = "0x600125C")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600125D")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x1700054B RID: 1355
			// (get) Token: 0x0600125E RID: 4702 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600125F RID: 4703 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700054B")]
			public string displayName
			{
				[Token(Token = "0x600125E")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600125F")]
				[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x1700054C RID: 1356
			// (get) Token: 0x06001260 RID: 4704 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06001261 RID: 4705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700054C")]
			public string shortDisplayName
			{
				[Token(Token = "0x6001260")]
				[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6001261")]
				[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x1700054D RID: 1357
			// (get) Token: 0x06001262 RID: 4706 RVA: 0x00009918 File Offset: 0x00007B18
			// (set) Token: 0x06001263 RID: 4707 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700054D")]
			public ReadOnlyArray<InternedString> usages
			{
				[Token(Token = "0x6001262")]
				[Address(RVA = "0x56E8E60", Offset = "0x56E7A60", VA = "0x1856E8E60")]
				[CompilerGenerated]
				readonly get
				{
					return default(ReadOnlyArray<InternedString>);
				}
				[Token(Token = "0x6001263")]
				[Address(RVA = "0x56E8FB0", Offset = "0x56E7BB0", VA = "0x1856E8FB0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x1700054E RID: 1358
			// (get) Token: 0x06001264 RID: 4708 RVA: 0x00009930 File Offset: 0x00007B30
			// (set) Token: 0x06001265 RID: 4709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700054E")]
			public ReadOnlyArray<InternedString> aliases
			{
				[Token(Token = "0x6001264")]
				[Address(RVA = "0x56E8DA0", Offset = "0x56E79A0", VA = "0x1856E8DA0")]
				[CompilerGenerated]
				readonly get
				{
					return default(ReadOnlyArray<InternedString>);
				}
				[Token(Token = "0x6001265")]
				[Address(RVA = "0x56E8E70", Offset = "0x56E7A70", VA = "0x1856E8E70")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x1700054F RID: 1359
			// (get) Token: 0x06001266 RID: 4710 RVA: 0x00009948 File Offset: 0x00007B48
			// (set) Token: 0x06001267 RID: 4711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700054F")]
			public ReadOnlyArray<NamedValue> parameters
			{
				[Token(Token = "0x6001266")]
				[Address(RVA = "0x56E8E40", Offset = "0x56E7A40", VA = "0x1856E8E40")]
				[CompilerGenerated]
				readonly get
				{
					return default(ReadOnlyArray<NamedValue>);
				}
				[Token(Token = "0x6001267")]
				[Address(RVA = "0x56E8F70", Offset = "0x56E7B70", VA = "0x1856E8F70")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000550 RID: 1360
			// (get) Token: 0x06001268 RID: 4712 RVA: 0x00009960 File Offset: 0x00007B60
			// (set) Token: 0x06001269 RID: 4713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000550")]
			public ReadOnlyArray<NameAndParameters> processors
			{
				[Token(Token = "0x6001268")]
				[Address(RVA = "0x56E8E50", Offset = "0x56E7A50", VA = "0x1856E8E50")]
				[CompilerGenerated]
				readonly get
				{
					return default(ReadOnlyArray<NameAndParameters>);
				}
				[Token(Token = "0x6001269")]
				[Address(RVA = "0x56E8F90", Offset = "0x56E7B90", VA = "0x1856E8F90")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000551 RID: 1361
			// (get) Token: 0x0600126A RID: 4714 RVA: 0x00009978 File Offset: 0x00007B78
			// (set) Token: 0x0600126B RID: 4715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000551")]
			public uint offset
			{
				[Token(Token = "0x600126A")]
				[Address(RVA = "0x12905A0", Offset = "0x128F1A0", VA = "0x1812905A0")]
				[CompilerGenerated]
				readonly get
				{
					return 0U;
				}
				[Token(Token = "0x600126B")]
				[Address(RVA = "0x12905E0", Offset = "0x128F1E0", VA = "0x1812905E0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000552 RID: 1362
			// (get) Token: 0x0600126C RID: 4716 RVA: 0x00009990 File Offset: 0x00007B90
			// (set) Token: 0x0600126D RID: 4717 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000552")]
			public uint bit
			{
				[Token(Token = "0x600126C")]
				[Address(RVA = "0x524DE50", Offset = "0x524CA50", VA = "0x18524DE50")]
				[CompilerGenerated]
				readonly get
				{
					return 0U;
				}
				[Token(Token = "0x600126D")]
				[Address(RVA = "0x56E8E90", Offset = "0x56E7A90", VA = "0x1856E8E90")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000553 RID: 1363
			// (get) Token: 0x0600126E RID: 4718 RVA: 0x000099A8 File Offset: 0x00007BA8
			// (set) Token: 0x0600126F RID: 4719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000553")]
			public uint sizeInBits
			{
				[Token(Token = "0x600126E")]
				[Address(RVA = "0x4D67380", Offset = "0x4D65F80", VA = "0x184D67380")]
				[CompilerGenerated]
				readonly get
				{
					return 0U;
				}
				[Token(Token = "0x600126F")]
				[Address(RVA = "0x4D67390", Offset = "0x4D65F90", VA = "0x184D67390")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000554 RID: 1364
			// (get) Token: 0x06001270 RID: 4720 RVA: 0x000099C0 File Offset: 0x00007BC0
			// (set) Token: 0x06001271 RID: 4721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000554")]
			public FourCC format
			{
				[Token(Token = "0x6001270")]
				[Address(RVA = "0x42BAD30", Offset = "0x42B9930", VA = "0x1842BAD30")]
				[CompilerGenerated]
				readonly get
				{
					return default(FourCC);
				}
				[Token(Token = "0x6001271")]
				[Address(RVA = "0x42BAE40", Offset = "0x42B9A40", VA = "0x1842BAE40")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000555 RID: 1365
			// (get) Token: 0x06001272 RID: 4722 RVA: 0x000099D8 File Offset: 0x00007BD8
			// (set) Token: 0x06001273 RID: 4723 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000555")]
			private InputControlLayout.ControlItem.Flags flags
			{
				[Token(Token = "0x6001272")]
				[Address(RVA = "0x7CEE30", Offset = "0x7CDA30", VA = "0x1807CEE30")]
				[CompilerGenerated]
				readonly get
				{
					return (InputControlLayout.ControlItem.Flags)0;
				}
				[Token(Token = "0x6001273")]
				[Address(RVA = "0x7CEE40", Offset = "0x7CDA40", VA = "0x1807CEE40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000556 RID: 1366
			// (get) Token: 0x06001274 RID: 4724 RVA: 0x000099F0 File Offset: 0x00007BF0
			// (set) Token: 0x06001275 RID: 4725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000556")]
			public int arraySize
			{
				[Token(Token = "0x6001274")]
				[Address(RVA = "0x4211DF0", Offset = "0x42109F0", VA = "0x184211DF0")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6001275")]
				[Address(RVA = "0x4211E90", Offset = "0x4210A90", VA = "0x184211E90")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000557 RID: 1367
			// (get) Token: 0x06001276 RID: 4726 RVA: 0x00009A08 File Offset: 0x00007C08
			// (set) Token: 0x06001277 RID: 4727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000557")]
			public PrimitiveValue defaultState
			{
				[Token(Token = "0x6001276")]
				[Address(RVA = "0x56E8DB0", Offset = "0x56E79B0", VA = "0x1856E8DB0")]
				[CompilerGenerated]
				readonly get
				{
					return default(PrimitiveValue);
				}
				[Token(Token = "0x6001277")]
				[Address(RVA = "0x56E8EA0", Offset = "0x56E7AA0", VA = "0x1856E8EA0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000558 RID: 1368
			// (get) Token: 0x06001278 RID: 4728 RVA: 0x00009A20 File Offset: 0x00007C20
			// (set) Token: 0x06001279 RID: 4729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000558")]
			public PrimitiveValue minValue
			{
				[Token(Token = "0x6001278")]
				[Address(RVA = "0x56E8E30", Offset = "0x56E7A30", VA = "0x1856E8E30")]
				[CompilerGenerated]
				readonly get
				{
					return default(PrimitiveValue);
				}
				[Token(Token = "0x6001279")]
				[Address(RVA = "0x56E8F60", Offset = "0x56E7B60", VA = "0x1856E8F60")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x17000559 RID: 1369
			// (get) Token: 0x0600127A RID: 4730 RVA: 0x00009A38 File Offset: 0x00007C38
			// (set) Token: 0x0600127B RID: 4731 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000559")]
			public PrimitiveValue maxValue
			{
				[Token(Token = "0x600127A")]
				[Address(RVA = "0x56E8E20", Offset = "0x56E7A20", VA = "0x1856E8E20")]
				[CompilerGenerated]
				readonly get
				{
					return default(PrimitiveValue);
				}
				[Token(Token = "0x600127B")]
				[Address(RVA = "0x56E8F50", Offset = "0x56E7B50", VA = "0x1856E8F50")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x1700055A RID: 1370
			// (get) Token: 0x0600127C RID: 4732 RVA: 0x00009A50 File Offset: 0x00007C50
			// (set) Token: 0x0600127D RID: 4733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700055A")]
			public bool isModifyingExistingControl
			{
				[Token(Token = "0x600127C")]
				[Address(RVA = "0x56E8DF0", Offset = "0x56E79F0", VA = "0x1856E8DF0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600127D")]
				[Address(RVA = "0x56E8EF0", Offset = "0x56E7AF0", VA = "0x1856E8EF0")]
				internal set
				{
				}
			}

			// Token: 0x1700055B RID: 1371
			// (get) Token: 0x0600127E RID: 4734 RVA: 0x00009A68 File Offset: 0x00007C68
			// (set) Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700055B")]
			public bool isNoisy
			{
				[Token(Token = "0x600127E")]
				[Address(RVA = "0x56E8E00", Offset = "0x56E7A00", VA = "0x1856E8E00")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600127F")]
				[Address(RVA = "0x56E8F10", Offset = "0x56E7B10", VA = "0x1856E8F10")]
				internal set
				{
				}
			}

			// Token: 0x1700055C RID: 1372
			// (get) Token: 0x06001280 RID: 4736 RVA: 0x00009A80 File Offset: 0x00007C80
			// (set) Token: 0x06001281 RID: 4737 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700055C")]
			public bool isSynthetic
			{
				[Token(Token = "0x6001280")]
				[Address(RVA = "0x56E8E10", Offset = "0x56E7A10", VA = "0x1856E8E10")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001281")]
				[Address(RVA = "0x56E8F30", Offset = "0x56E7B30", VA = "0x1856E8F30")]
				internal set
				{
				}
			}

			// Token: 0x1700055D RID: 1373
			// (get) Token: 0x06001282 RID: 4738 RVA: 0x00009A98 File Offset: 0x00007C98
			// (set) Token: 0x06001283 RID: 4739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700055D")]
			public bool dontReset
			{
				[Token(Token = "0x6001282")]
				[Address(RVA = "0x56E8DC0", Offset = "0x56E79C0", VA = "0x1856E8DC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001283")]
				[Address(RVA = "0x56E8EB0", Offset = "0x56E7AB0", VA = "0x1856E8EB0")]
				internal set
				{
				}
			}

			// Token: 0x1700055E RID: 1374
			// (get) Token: 0x06001284 RID: 4740 RVA: 0x00009AB0 File Offset: 0x00007CB0
			// (set) Token: 0x06001285 RID: 4741 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700055E")]
			public bool isFirstDefinedInThisLayout
			{
				[Token(Token = "0x6001284")]
				[Address(RVA = "0x56E8DE0", Offset = "0x56E79E0", VA = "0x1856E8DE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001285")]
				[Address(RVA = "0x56E8ED0", Offset = "0x56E7AD0", VA = "0x1856E8ED0")]
				internal set
				{
				}
			}

			// Token: 0x1700055F RID: 1375
			// (get) Token: 0x06001286 RID: 4742 RVA: 0x00009AC8 File Offset: 0x00007CC8
			[Token(Token = "0x1700055F")]
			public bool isArray
			{
				[Token(Token = "0x6001286")]
				[Address(RVA = "0x56E8DD0", Offset = "0x56E79D0", VA = "0x1856E8DD0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001287 RID: 4743 RVA: 0x00009AE0 File Offset: 0x00007CE0
			[Token(Token = "0x6001287")]
			[Address(RVA = "0x56E89A0", Offset = "0x56E75A0", VA = "0x1856E89A0")]
			public InputControlLayout.ControlItem Merge(InputControlLayout.ControlItem other)
			{
				return default(InputControlLayout.ControlItem);
			}

			// Token: 0x020001F1 RID: 497
			[Token(Token = "0x20001F1")]
			[Flags]
			private enum Flags
			{
				// Token: 0x04000ADF RID: 2783
				[Token(Token = "0x4000ADF")]
				isModifyingExistingControl = 1,
				// Token: 0x04000AE0 RID: 2784
				[Token(Token = "0x4000AE0")]
				IsNoisy = 2,
				// Token: 0x04000AE1 RID: 2785
				[Token(Token = "0x4000AE1")]
				IsSynthetic = 4,
				// Token: 0x04000AE2 RID: 2786
				[Token(Token = "0x4000AE2")]
				IsFirstDefinedInThisLayout = 8,
				// Token: 0x04000AE3 RID: 2787
				[Token(Token = "0x4000AE3")]
				DontReset = 16
			}
		}

		// Token: 0x020001F2 RID: 498
		[Token(Token = "0x20001F2")]
		public class Builder
		{
			// Token: 0x17000560 RID: 1376
			// (get) Token: 0x06001288 RID: 4744 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06001289 RID: 4745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000560")]
			public string name
			{
				[Token(Token = "0x6001288")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001289")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000561 RID: 1377
			// (get) Token: 0x0600128A RID: 4746 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600128B RID: 4747 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000561")]
			public string displayName
			{
				[Token(Token = "0x600128A")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600128B")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000562 RID: 1378
			// (get) Token: 0x0600128C RID: 4748 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600128D RID: 4749 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000562")]
			public Type type
			{
				[Token(Token = "0x600128C")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600128D")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000563 RID: 1379
			// (get) Token: 0x0600128E RID: 4750 RVA: 0x00009AF8 File Offset: 0x00007CF8
			// (set) Token: 0x0600128F RID: 4751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000563")]
			public FourCC stateFormat
			{
				[Token(Token = "0x600128E")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
				[CompilerGenerated]
				get
				{
					return default(FourCC);
				}
				[Token(Token = "0x600128F")]
				[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000564 RID: 1380
			// (get) Token: 0x06001290 RID: 4752 RVA: 0x00009B10 File Offset: 0x00007D10
			// (set) Token: 0x06001291 RID: 4753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000564")]
			public int stateSizeInBytes
			{
				[Token(Token = "0x6001290")]
				[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001291")]
				[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000565 RID: 1381
			// (get) Token: 0x06001292 RID: 4754 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06001293 RID: 4755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000565")]
			public string extendsLayout
			{
				[Token(Token = "0x6001292")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001293")]
				[Address(RVA = "0x56E4D00", Offset = "0x56E3900", VA = "0x1856E4D00")]
				set
				{
				}
			}

			// Token: 0x17000566 RID: 1382
			// (get) Token: 0x06001294 RID: 4756 RVA: 0x00009B28 File Offset: 0x00007D28
			// (set) Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000566")]
			public bool? updateBeforeRender
			{
				[Token(Token = "0x6001294")]
				[Address(RVA = "0x56E4CF0", Offset = "0x56E38F0", VA = "0x1856E4CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001295")]
				[Address(RVA = "0x56E4D40", Offset = "0x56E3940", VA = "0x1856E4D40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000567 RID: 1383
			// (get) Token: 0x06001296 RID: 4758 RVA: 0x00009B40 File Offset: 0x00007D40
			[Token(Token = "0x17000567")]
			public ReadOnlyArray<InputControlLayout.ControlItem> controls
			{
				[Token(Token = "0x6001296")]
				[Address(RVA = "0x56E4C90", Offset = "0x56E3890", VA = "0x1856E4C90")]
				get
				{
					return default(ReadOnlyArray<InputControlLayout.ControlItem>);
				}
			}

			// Token: 0x06001297 RID: 4759 RVA: 0x00009B58 File Offset: 0x00007D58
			[Token(Token = "0x6001297")]
			[Address(RVA = "0x56E4750", Offset = "0x56E3350", VA = "0x1856E4750")]
			public InputControlLayout.Builder.ControlBuilder AddControl(string name)
			{
				return default(InputControlLayout.Builder.ControlBuilder);
			}

			// Token: 0x06001298 RID: 4760 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001298")]
			[Address(RVA = "0x3736D30", Offset = "0x3735930", VA = "0x183736D30")]
			public InputControlLayout.Builder WithName(string name)
			{
				return null;
			}

			// Token: 0x06001299 RID: 4761 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6001299")]
			[Address(RVA = "0x17967C0", Offset = "0x17953C0", VA = "0x1817967C0")]
			public InputControlLayout.Builder WithDisplayName(string displayName)
			{
				return null;
			}

			// Token: 0x0600129A RID: 4762 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600129A")]
			public InputControlLayout.Builder WithType<T>() where T : InputControl
			{
				return null;
			}

			// Token: 0x0600129B RID: 4763 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600129B")]
			[Address(RVA = "0x56E4C40", Offset = "0x56E3840", VA = "0x1856E4C40")]
			public InputControlLayout.Builder WithFormat(FourCC format)
			{
				return null;
			}

			// Token: 0x0600129C RID: 4764 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600129C")]
			[Address(RVA = "0x56E4C50", Offset = "0x56E3850", VA = "0x1856E4C50")]
			public InputControlLayout.Builder WithFormat(string format)
			{
				return null;
			}

			// Token: 0x0600129D RID: 4765 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600129D")]
			[Address(RVA = "0x56E4C80", Offset = "0x56E3880", VA = "0x1856E4C80")]
			public InputControlLayout.Builder WithSizeInBytes(int sizeInBytes)
			{
				return null;
			}

			// Token: 0x0600129E RID: 4766 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600129E")]
			[Address(RVA = "0x56E4BF0", Offset = "0x56E37F0", VA = "0x1856E4BF0")]
			public InputControlLayout.Builder Extend(string baseLayoutName)
			{
				return null;
			}

			// Token: 0x0600129F RID: 4767 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600129F")]
			[Address(RVA = "0x56E4980", Offset = "0x56E3580", VA = "0x1856E4980")]
			public InputControlLayout Build()
			{
				return null;
			}

			// Token: 0x060012A0 RID: 4768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012A0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Builder()
			{
			}

			// Token: 0x04000AE9 RID: 2793
			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string m_ExtendsLayout;

			// Token: 0x04000AEB RID: 2795
			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int m_ControlCount;

			// Token: 0x04000AEC RID: 2796
			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private InputControlLayout.ControlItem[] m_Controls;

			// Token: 0x020001F3 RID: 499
			[Token(Token = "0x20001F3")]
			public struct ControlBuilder
			{
				// Token: 0x060012A1 RID: 4769 RVA: 0x00009B70 File Offset: 0x00007D70
				[Token(Token = "0x60012A1")]
				[Address(RVA = "0x56E7070", Offset = "0x56E5C70", VA = "0x1856E7070")]
				public InputControlLayout.Builder.ControlBuilder WithDisplayName(string displayName)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012A2 RID: 4770 RVA: 0x00009B88 File Offset: 0x00007D88
				[Token(Token = "0x60012A2")]
				[Address(RVA = "0x56E71B0", Offset = "0x56E5DB0", VA = "0x1856E71B0")]
				public InputControlLayout.Builder.ControlBuilder WithLayout(string layout)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012A3 RID: 4771 RVA: 0x00009BA0 File Offset: 0x00007DA0
				[Token(Token = "0x60012A3")]
				[Address(RVA = "0x56E7160", Offset = "0x56E5D60", VA = "0x1856E7160")]
				public InputControlLayout.Builder.ControlBuilder WithFormat(FourCC format)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012A4 RID: 4772 RVA: 0x00009BB8 File Offset: 0x00007DB8
				[Token(Token = "0x60012A4")]
				[Address(RVA = "0x56E70E0", Offset = "0x56E5CE0", VA = "0x1856E70E0")]
				public InputControlLayout.Builder.ControlBuilder WithFormat(string format)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012A5 RID: 4773 RVA: 0x00009BD0 File Offset: 0x00007DD0
				[Token(Token = "0x60012A5")]
				[Address(RVA = "0x56E6FC0", Offset = "0x56E5BC0", VA = "0x1856E6FC0")]
				public InputControlLayout.Builder.ControlBuilder WithByteOffset(uint offset)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012A6 RID: 4774 RVA: 0x00009BE8 File Offset: 0x00007DE8
				[Token(Token = "0x60012A6")]
				[Address(RVA = "0x56E6F70", Offset = "0x56E5B70", VA = "0x1856E6F70")]
				public InputControlLayout.Builder.ControlBuilder WithBitOffset(uint bit)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012A7 RID: 4775 RVA: 0x00009C00 File Offset: 0x00007E00
				[Token(Token = "0x60012A7")]
				[Address(RVA = "0x56E6E80", Offset = "0x56E5A80", VA = "0x1856E6E80")]
				public InputControlLayout.Builder.ControlBuilder IsSynthetic(bool value)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012A8 RID: 4776 RVA: 0x00009C18 File Offset: 0x00007E18
				[Token(Token = "0x60012A8")]
				[Address(RVA = "0x56E6E10", Offset = "0x56E5A10", VA = "0x1856E6E10")]
				public InputControlLayout.Builder.ControlBuilder IsNoisy(bool value)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012A9 RID: 4777 RVA: 0x00009C30 File Offset: 0x00007E30
				[Token(Token = "0x60012A9")]
				[Address(RVA = "0x56E6DA0", Offset = "0x56E59A0", VA = "0x1856E6DA0")]
				public InputControlLayout.Builder.ControlBuilder DontReset(bool value)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012AA RID: 4778 RVA: 0x00009C48 File Offset: 0x00007E48
				[Token(Token = "0x60012AA")]
				[Address(RVA = "0x56E75D0", Offset = "0x56E61D0", VA = "0x1856E75D0")]
				public InputControlLayout.Builder.ControlBuilder WithSizeInBits(uint sizeInBits)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012AB RID: 4779 RVA: 0x00009C60 File Offset: 0x00007E60
				[Token(Token = "0x60012AB")]
				[Address(RVA = "0x56E74F0", Offset = "0x56E60F0", VA = "0x1856E74F0")]
				public InputControlLayout.Builder.ControlBuilder WithRange(float minValue, float maxValue)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012AC RID: 4780 RVA: 0x00009C78 File Offset: 0x00007E78
				[Token(Token = "0x60012AC")]
				[Address(RVA = "0x56E7620", Offset = "0x56E6220", VA = "0x1856E7620")]
				public InputControlLayout.Builder.ControlBuilder WithUsages(params InternedString[] usages)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012AD RID: 4781 RVA: 0x00009C90 File Offset: 0x00007E90
				[Token(Token = "0x60012AD")]
				[Address(RVA = "0x56E7860", Offset = "0x56E6460", VA = "0x1856E7860")]
				public InputControlLayout.Builder.ControlBuilder WithUsages(IEnumerable<string> usages)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012AE RID: 4782 RVA: 0x00009CA8 File Offset: 0x00007EA8
				[Token(Token = "0x60012AE")]
				[Address(RVA = "0x56E79D0", Offset = "0x56E65D0", VA = "0x1856E79D0")]
				public InputControlLayout.Builder.ControlBuilder WithUsages(params string[] usages)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012AF RID: 4783 RVA: 0x00009CC0 File Offset: 0x00007EC0
				[Token(Token = "0x60012AF")]
				[Address(RVA = "0x56E72E0", Offset = "0x56E5EE0", VA = "0x1856E72E0")]
				public InputControlLayout.Builder.ControlBuilder WithParameters(string parameters)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012B0 RID: 4784 RVA: 0x00009CD8 File Offset: 0x00007ED8
				[Token(Token = "0x60012B0")]
				[Address(RVA = "0x56E73E0", Offset = "0x56E5FE0", VA = "0x1856E73E0")]
				public InputControlLayout.Builder.ControlBuilder WithProcessors(string processors)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012B1 RID: 4785 RVA: 0x00009CF0 File Offset: 0x00007EF0
				[Token(Token = "0x60012B1")]
				[Address(RVA = "0x56E7010", Offset = "0x56E5C10", VA = "0x1856E7010")]
				public InputControlLayout.Builder.ControlBuilder WithDefaultState(PrimitiveValue value)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012B2 RID: 4786 RVA: 0x00009D08 File Offset: 0x00007F08
				[Token(Token = "0x60012B2")]
				[Address(RVA = "0x56E6EF0", Offset = "0x56E5AF0", VA = "0x1856E6EF0")]
				public InputControlLayout.Builder.ControlBuilder UsingStateFrom(string path)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x060012B3 RID: 4787 RVA: 0x00009D20 File Offset: 0x00007F20
				[Token(Token = "0x60012B3")]
				[Address(RVA = "0x56E6D50", Offset = "0x56E5950", VA = "0x1856E6D50")]
				public InputControlLayout.Builder.ControlBuilder AsArrayOfControlsWithSize(int arraySize)
				{
					return default(InputControlLayout.Builder.ControlBuilder);
				}

				// Token: 0x04000AED RID: 2797
				[Token(Token = "0x4000AED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal InputControlLayout.Builder builder;

				// Token: 0x04000AEE RID: 2798
				[Token(Token = "0x4000AEE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal int index;
			}
		}

		// Token: 0x020001F5 RID: 501
		[Token(Token = "0x20001F5")]
		[Flags]
		private enum Flags
		{
			// Token: 0x04000AF2 RID: 2802
			[Token(Token = "0x4000AF2")]
			IsGenericTypeOfDevice = 1,
			// Token: 0x04000AF3 RID: 2803
			[Token(Token = "0x4000AF3")]
			HideInUI = 2,
			// Token: 0x04000AF4 RID: 2804
			[Token(Token = "0x4000AF4")]
			IsOverride = 4,
			// Token: 0x04000AF5 RID: 2805
			[Token(Token = "0x4000AF5")]
			CanRunInBackground = 8,
			// Token: 0x04000AF6 RID: 2806
			[Token(Token = "0x4000AF6")]
			CanRunInBackgroundIsSet = 16,
			// Token: 0x04000AF7 RID: 2807
			[Token(Token = "0x4000AF7")]
			IsNoisy = 32
		}

		// Token: 0x020001F6 RID: 502
		[Token(Token = "0x20001F6")]
		[Serializable]
		internal struct LayoutJsonNameAndDescriptorOnly
		{
			// Token: 0x04000AF8 RID: 2808
			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000AF9 RID: 2809
			[Token(Token = "0x4000AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string extend;

			// Token: 0x04000AFA RID: 2810
			[Token(Token = "0x4000AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string[] extendMultiple;

			// Token: 0x04000AFB RID: 2811
			[Token(Token = "0x4000AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InputDeviceMatcher.MatcherJson device;
		}

		// Token: 0x020001F7 RID: 503
		[Token(Token = "0x20001F7")]
		[Serializable]
		private struct LayoutJson
		{
			// Token: 0x060012B7 RID: 4791 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60012B7")]
			[Address(RVA = "0x56F5B20", Offset = "0x56F4720", VA = "0x1856F5B20")]
			public InputControlLayout ToLayout()
			{
				return null;
			}

			// Token: 0x060012B8 RID: 4792 RVA: 0x00009D50 File Offset: 0x00007F50
			[Token(Token = "0x60012B8")]
			[Address(RVA = "0x56F56E0", Offset = "0x56F42E0", VA = "0x1856F56E0")]
			public static InputControlLayout.LayoutJson FromLayout(InputControlLayout layout)
			{
				return default(InputControlLayout.LayoutJson);
			}

			// Token: 0x04000AFC RID: 2812
			[Token(Token = "0x4000AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000AFD RID: 2813
			[Token(Token = "0x4000AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string extend;

			// Token: 0x04000AFE RID: 2814
			[Token(Token = "0x4000AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string[] extendMultiple;

			// Token: 0x04000AFF RID: 2815
			[Token(Token = "0x4000AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string format;

			// Token: 0x04000B00 RID: 2816
			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string beforeRender;

			// Token: 0x04000B01 RID: 2817
			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string runInBackground;

			// Token: 0x04000B02 RID: 2818
			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] commonUsages;

			// Token: 0x04000B03 RID: 2819
			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string displayName;

			// Token: 0x04000B04 RID: 2820
			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string description;

			// Token: 0x04000B05 RID: 2821
			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string type;

			// Token: 0x04000B06 RID: 2822
			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string variant;

			// Token: 0x04000B07 RID: 2823
			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool isGenericTypeOfDevice;

			// Token: 0x04000B08 RID: 2824
			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
			public bool hideInUI;

			// Token: 0x04000B09 RID: 2825
			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public InputControlLayout.ControlItemJson[] controls;
		}

		// Token: 0x020001F9 RID: 505
		[Token(Token = "0x20001F9")]
		[Serializable]
		private class ControlItemJson
		{
			// Token: 0x060012BE RID: 4798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012BE")]
			[Address(RVA = "0x56E8980", Offset = "0x56E7580", VA = "0x1856E8980")]
			public ControlItemJson()
			{
			}

			// Token: 0x060012BF RID: 4799 RVA: 0x00009D80 File Offset: 0x00007F80
			[Token(Token = "0x60012BF")]
			[Address(RVA = "0x56E8260", Offset = "0x56E6E60", VA = "0x1856E8260")]
			public InputControlLayout.ControlItem ToLayout()
			{
				return default(InputControlLayout.ControlItem);
			}

			// Token: 0x060012C0 RID: 4800 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60012C0")]
			[Address(RVA = "0x56E7A00", Offset = "0x56E6600", VA = "0x1856E7A00")]
			public static InputControlLayout.ControlItemJson[] FromControlItems(InputControlLayout.ControlItem[] items)
			{
				return null;
			}

			// Token: 0x04000B0E RID: 2830
			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04000B0F RID: 2831
			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string layout;

			// Token: 0x04000B10 RID: 2832
			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string variants;

			// Token: 0x04000B11 RID: 2833
			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string usage;

			// Token: 0x04000B12 RID: 2834
			[Token(Token = "0x4000B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string alias;

			// Token: 0x04000B13 RID: 2835
			[Token(Token = "0x4000B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string useStateFrom;

			// Token: 0x04000B14 RID: 2836
			[Token(Token = "0x4000B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint offset;

			// Token: 0x04000B15 RID: 2837
			[Token(Token = "0x4000B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public uint bit;

			// Token: 0x04000B16 RID: 2838
			[Token(Token = "0x4000B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public uint sizeInBits;

			// Token: 0x04000B17 RID: 2839
			[Token(Token = "0x4000B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string format;

			// Token: 0x04000B18 RID: 2840
			[Token(Token = "0x4000B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int arraySize;

			// Token: 0x04000B19 RID: 2841
			[Token(Token = "0x4000B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string[] usages;

			// Token: 0x04000B1A RID: 2842
			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string[] aliases;

			// Token: 0x04000B1B RID: 2843
			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public string parameters;

			// Token: 0x04000B1C RID: 2844
			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public string processors;

			// Token: 0x04000B1D RID: 2845
			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public string displayName;

			// Token: 0x04000B1E RID: 2846
			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public string shortDisplayName;

			// Token: 0x04000B1F RID: 2847
			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public bool noisy;

			// Token: 0x04000B20 RID: 2848
			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
			public bool dontReset;

			// Token: 0x04000B21 RID: 2849
			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
			public bool synthetic;

			// Token: 0x04000B22 RID: 2850
			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public string defaultState;

			// Token: 0x04000B23 RID: 2851
			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public string minValue;

			// Token: 0x04000B24 RID: 2852
			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public string maxValue;
		}

		// Token: 0x020001FB RID: 507
		[Token(Token = "0x20001FB")]
		internal struct Collection
		{
			// Token: 0x060012C9 RID: 4809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012C9")]
			[Address(RVA = "0x56E5000", Offset = "0x56E3C00", VA = "0x1856E5000")]
			public void Allocate()
			{
			}

			// Token: 0x060012CA RID: 4810 RVA: 0x00009DC8 File Offset: 0x00007FC8
			[Token(Token = "0x60012CA")]
			[Address(RVA = "0x56E5C40", Offset = "0x56E4840", VA = "0x1856E5C40")]
			public InternedString TryFindLayoutForType(Type layoutType)
			{
				return default(InternedString);
			}

			// Token: 0x060012CB RID: 4811 RVA: 0x00009DE0 File Offset: 0x00007FE0
			[Token(Token = "0x60012CB")]
			[Address(RVA = "0x56E5DF0", Offset = "0x56E49F0", VA = "0x1856E5DF0")]
			public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription)
			{
				return default(InternedString);
			}

			// Token: 0x060012CC RID: 4812 RVA: 0x00009DF8 File Offset: 0x00007FF8
			[Token(Token = "0x60012CC")]
			[Address(RVA = "0x56E5A40", Offset = "0x56E4640", VA = "0x1856E5A40")]
			public bool HasLayout(InternedString name)
			{
				return default(bool);
			}

			// Token: 0x060012CD RID: 4813 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60012CD")]
			[Address(RVA = "0x56E6010", Offset = "0x56E4C10", VA = "0x1856E6010")]
			private InputControlLayout TryLoadLayoutInternal(InternedString name)
			{
				return null;
			}

			// Token: 0x060012CE RID: 4814 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60012CE")]
			[Address(RVA = "0x56E62B0", Offset = "0x56E4EB0", VA = "0x1856E62B0")]
			public InputControlLayout TryLoadLayout(InternedString name, [Optional] Dictionary<InternedString, InputControlLayout> table)
			{
				return null;
			}

			// Token: 0x060012CF RID: 4815 RVA: 0x00009E10 File Offset: 0x00008010
			[Token(Token = "0x60012CF")]
			[Address(RVA = "0x56E56E0", Offset = "0x56E42E0", VA = "0x1856E56E0")]
			public InternedString GetBaseLayoutName(InternedString layoutName)
			{
				return default(InternedString);
			}

			// Token: 0x060012D0 RID: 4816 RVA: 0x00009E28 File Offset: 0x00008028
			[Token(Token = "0x60012D0")]
			[Address(RVA = "0x56E5990", Offset = "0x56E4590", VA = "0x1856E5990")]
			public InternedString GetRootLayoutName(InternedString layoutName)
			{
				return default(InternedString);
			}

			// Token: 0x060012D1 RID: 4817 RVA: 0x00009E40 File Offset: 0x00008040
			[Token(Token = "0x60012D1")]
			[Address(RVA = "0x56E52A0", Offset = "0x56E3EA0", VA = "0x1856E52A0")]
			public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance)
			{
				return default(bool);
			}

			// Token: 0x060012D2 RID: 4818 RVA: 0x00009E58 File Offset: 0x00008058
			[Token(Token = "0x60012D2")]
			[Address(RVA = "0x56E54F0", Offset = "0x56E40F0", VA = "0x1856E54F0")]
			public InternedString FindLayoutThatIntroducesControl(InputControl control, InputControlLayout.Cache cache)
			{
				return default(InternedString);
			}

			// Token: 0x060012D3 RID: 4819 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60012D3")]
			[Address(RVA = "0x56E5840", Offset = "0x56E4440", VA = "0x1856E5840")]
			public Type GetControlTypeForLayout(InternedString layoutName)
			{
				return null;
			}

			// Token: 0x060012D4 RID: 4820 RVA: 0x00009E70 File Offset: 0x00008070
			[Token(Token = "0x60012D4")]
			[Address(RVA = "0x56E6700", Offset = "0x56E5300", VA = "0x1856E6700")]
			public bool ValueTypeIsAssignableFrom(InternedString layoutName, Type valueType)
			{
				return default(bool);
			}

			// Token: 0x060012D5 RID: 4821 RVA: 0x00009E88 File Offset: 0x00008088
			[Token(Token = "0x60012D5")]
			[Address(RVA = "0x56E5BE0", Offset = "0x56E47E0", VA = "0x1856E5BE0")]
			public bool IsGeneratedLayout(InternedString layout)
			{
				return default(bool);
			}

			// Token: 0x060012D6 RID: 4822 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60012D6")]
			[Address(RVA = "0x56E5780", Offset = "0x56E4380", VA = "0x1856E5780")]
			public IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true)
			{
				return null;
			}

			// Token: 0x060012D7 RID: 4823 RVA: 0x00009EA0 File Offset: 0x000080A0
			[Token(Token = "0x60012D7")]
			[Address(RVA = "0x56E5B10", Offset = "0x56E4710", VA = "0x1856E5B10")]
			public bool IsBasedOn(InternedString parentLayout, InternedString childLayout)
			{
				return default(bool);
			}

			// Token: 0x060012D8 RID: 4824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012D8")]
			[Address(RVA = "0x56E4E40", Offset = "0x56E3A40", VA = "0x1856E4E40")]
			public void AddMatcher(InternedString layout, InputDeviceMatcher matcher)
			{
			}

			// Token: 0x04000B2C RID: 2860
			[Token(Token = "0x4000B2C")]
			public const float kBaseScoreForNonGeneratedLayouts = 1f;

			// Token: 0x04000B2D RID: 2861
			[Token(Token = "0x4000B2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<InternedString, Type> layoutTypes;

			// Token: 0x04000B2E RID: 2862
			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Dictionary<InternedString, string> layoutStrings;

			// Token: 0x04000B2F RID: 2863
			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<InternedString, Func<InputControlLayout>> layoutBuilders;

			// Token: 0x04000B30 RID: 2864
			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<InternedString, InternedString> baseLayoutTable;

			// Token: 0x04000B31 RID: 2865
			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<InternedString, InternedString[]> layoutOverrides;

			// Token: 0x04000B32 RID: 2866
			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HashSet<InternedString> layoutOverrideNames;

			// Token: 0x04000B33 RID: 2867
			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout> precompiledLayouts;

			// Token: 0x04000B34 RID: 2868
			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<InputControlLayout.Collection.LayoutMatcher> layoutMatchers;

			// Token: 0x020001FC RID: 508
			[Token(Token = "0x20001FC")]
			public struct LayoutMatcher
			{
				// Token: 0x04000B35 RID: 2869
				[Token(Token = "0x4000B35")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public InternedString layoutName;

				// Token: 0x04000B36 RID: 2870
				[Token(Token = "0x4000B36")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public InputDeviceMatcher deviceMatcher;
			}

			// Token: 0x020001FD RID: 509
			[Token(Token = "0x20001FD")]
			public struct PrecompiledLayout
			{
				// Token: 0x04000B37 RID: 2871
				[Token(Token = "0x4000B37")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Func<InputDevice> factoryMethod;

				// Token: 0x04000B38 RID: 2872
				[Token(Token = "0x4000B38")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string metadata;
			}
		}

		// Token: 0x020001FF RID: 511
		[Token(Token = "0x20001FF")]
		public class LayoutNotFoundException : Exception
		{
			// Token: 0x1700056A RID: 1386
			// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700056A")]
			public string layout
			{
				[Token(Token = "0x60012E1")]
				[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060012E2 RID: 4834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012E2")]
			[Address(RVA = "0x560AC50", Offset = "0x5609850", VA = "0x18560AC50")]
			public LayoutNotFoundException()
			{
			}

			// Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012E3")]
			[Address(RVA = "0x560ADC0", Offset = "0x56099C0", VA = "0x18560ADC0")]
			public LayoutNotFoundException(string name, string message)
			{
			}

			// Token: 0x060012E4 RID: 4836 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012E4")]
			[Address(RVA = "0x560ACA0", Offset = "0x56098A0", VA = "0x18560ACA0")]
			public LayoutNotFoundException(string name)
			{
			}

			// Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012E5")]
			[Address(RVA = "0x560AD50", Offset = "0x5609950", VA = "0x18560AD50")]
			public LayoutNotFoundException(string message, Exception innerException)
			{
			}

			// Token: 0x060012E6 RID: 4838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012E6")]
			[Address(RVA = "0x560AE40", Offset = "0x5609A40", VA = "0x18560AE40")]
			protected LayoutNotFoundException(SerializationInfo info, StreamingContext context)
			{
			}
		}

		// Token: 0x02000200 RID: 512
		[Token(Token = "0x2000200")]
		internal struct Cache
		{
			// Token: 0x060012E7 RID: 4839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012E7")]
			[Address(RVA = "0x4880CE0", Offset = "0x487F8E0", VA = "0x184880CE0")]
			public void Clear()
			{
			}

			// Token: 0x060012E8 RID: 4840 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60012E8")]
			[Address(RVA = "0x55FB470", Offset = "0x55FA070", VA = "0x1855FB470")]
			public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true)
			{
				return null;
			}

			// Token: 0x04000B43 RID: 2883
			[Token(Token = "0x4000B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<InternedString, InputControlLayout> table;
		}

		// Token: 0x02000201 RID: 513
		[Token(Token = "0x2000201")]
		internal struct CacheRefInstance : IDisposable
		{
			// Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012E9")]
			[Address(RVA = "0x55FB3C0", Offset = "0x55F9FC0", VA = "0x1855FB3C0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04000B44 RID: 2884
			[Token(Token = "0x4000B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool valid;
		}
	}
}
