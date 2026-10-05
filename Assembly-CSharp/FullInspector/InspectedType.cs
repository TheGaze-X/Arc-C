using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BE0 RID: 31712
	[Token(Token = "0x2007BE0")]
	public sealed class InspectedType
	{
		// Token: 0x0602C61D RID: 181789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C61D")]
		[Address(RVA = "0x285F0F0", Offset = "0x285DCF0", VA = "0x18285F0F0")]
		public static InspectedType Get(Type type)
		{
			return null;
		}

		// Token: 0x0602C61E RID: 181790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C61E")]
		[Address(RVA = "0x285FF80", Offset = "0x285EB80", VA = "0x18285FF80")]
		public static void ResetCacheForTesting()
		{
		}

		// Token: 0x170067F2 RID: 26610
		// (get) Token: 0x0602C620 RID: 181792 RVA: 0x000DFE00 File Offset: 0x000DE000
		[Token(Token = "0x170067F2")]
		public bool HasDefaultConstructor
		{
			[Token(Token = "0x602C620")]
			[Address(RVA = "0x2860C80", Offset = "0x285F880", VA = "0x182860C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C621 RID: 181793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C621")]
		[Address(RVA = "0x285D900", Offset = "0x285C500", VA = "0x18285D900")]
		public object CreateInstance()
		{
			return null;
		}

		// Token: 0x0602C622 RID: 181794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C622")]
		[Address(RVA = "0x285E820", Offset = "0x285D420", VA = "0x18285E820")]
		public List<InspectedMember> GetMembers(IInspectedMemberFilter filter)
		{
			return null;
		}

		// Token: 0x0602C623 RID: 181795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C623")]
		[Address(RVA = "0x285ED30", Offset = "0x285D930", VA = "0x18285ED30")]
		public List<InspectedProperty> GetProperties(IInspectedMemberFilter filter)
		{
			return null;
		}

		// Token: 0x0602C624 RID: 181796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C624")]
		[Address(RVA = "0x285EA70", Offset = "0x285D670", VA = "0x18285EA70")]
		public List<InspectedMethod> GetMethods(IInspectedMemberFilter filter)
		{
			return null;
		}

		// Token: 0x0602C625 RID: 181797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C625")]
		[Address(RVA = "0x2860030", Offset = "0x285EC30", VA = "0x182860030")]
		private void VerifyNotCollection()
		{
		}

		// Token: 0x0602C626 RID: 181798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C626")]
		[Address(RVA = "0x2860320", Offset = "0x285EF20", VA = "0x182860320")]
		internal InspectedType(Type type)
		{
		}

		// Token: 0x0602C627 RID: 181799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C627")]
		public static void StableSort<T>(IList<T> list, Func<T, T, int> comparator)
		{
		}

		// Token: 0x0602C628 RID: 181800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C628")]
		[Address(RVA = "0x285D100", Offset = "0x285BD00", VA = "0x18285D100")]
		private static List<InspectedMember> CollectUnorderedLocalMembers(Type reflectedType)
		{
			return null;
		}

		// Token: 0x170067F3 RID: 26611
		// (get) Token: 0x0602C629 RID: 181801 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C62A RID: 181802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067F3")]
		public Type ReflectedType
		{
			[Token(Token = "0x602C629")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C62A")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170067F4 RID: 26612
		// (get) Token: 0x0602C62B RID: 181803 RVA: 0x000DFE18 File Offset: 0x000DE018
		// (set) Token: 0x0602C62C RID: 181804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067F4")]
		public bool IsCollection
		{
			[Token(Token = "0x602C62B")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C62C")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602C62D RID: 181805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C62D")]
		[Address(RVA = "0x285DF10", Offset = "0x285CB10", VA = "0x18285DF10")]
		public Dictionary<string, List<InspectedMember>> GetCategories(IInspectedMemberFilter filter)
		{
			return null;
		}

		// Token: 0x0602C62E RID: 181806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C62E")]
		[Address(RVA = "0x285F070", Offset = "0x285DC70", VA = "0x18285F070")]
		public InspectedProperty GetPropertyByName(string name)
		{
			return null;
		}

		// Token: 0x0602C62F RID: 181807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C62F")]
		[Address(RVA = "0x285EFF0", Offset = "0x285DBF0", VA = "0x18285EFF0")]
		public InspectedProperty GetPropertyByFormerlySerializedName(string name)
		{
			return null;
		}

		// Token: 0x0602C630 RID: 181808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C630")]
		[Address(RVA = "0x285F2A0", Offset = "0x285DEA0", VA = "0x18285F2A0")]
		private static void InitializePropertyRemoval()
		{
		}

		// Token: 0x0602C631 RID: 181809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C631")]
		public static void RemoveProperty<T>(string propertyName)
		{
		}

		// Token: 0x0602C632 RID: 181810 RVA: 0x000DFE30 File Offset: 0x000DE030
		[Token(Token = "0x602C632")]
		[Address(RVA = "0x285FD50", Offset = "0x285E950", VA = "0x18285FD50")]
		private static bool IsSimpleTypeThatUnityCanSerialize(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C633 RID: 181811 RVA: 0x000DFE48 File Offset: 0x000DE048
		[Token(Token = "0x602C633")]
		[Address(RVA = "0x285F430", Offset = "0x285E030", VA = "0x18285F430")]
		private static bool IsPrimitiveSkippedByUnity(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C634 RID: 181812 RVA: 0x000DFE60 File Offset: 0x000DE060
		[Token(Token = "0x602C634")]
		[Address(RVA = "0x285F930", Offset = "0x285E530", VA = "0x18285F930")]
		public static bool IsSerializedByUnity(InspectedProperty property)
		{
			return default(bool);
		}

		// Token: 0x0602C635 RID: 181813 RVA: 0x000DFE78 File Offset: 0x000DE078
		[Token(Token = "0x602C635")]
		[Address(RVA = "0x285F580", Offset = "0x285E180", VA = "0x18285F580")]
		public static bool IsSerializedByFullInspector(InspectedProperty property)
		{
			return default(bool);
		}

		// Token: 0x0404025D RID: 262749
		[Token(Token = "0x404025D")]
		[ThreadStatic]
		private static Dictionary<Type, InspectedType> _cachedMetadata;

		// Token: 0x0404025E RID: 262750
		[Token(Token = "0x404025E")]
		[FieldOffset(Offset = "0x10")]
		private bool? _hasDefaultConstructorCache;

		// Token: 0x0404025F RID: 262751
		[Token(Token = "0x404025F")]
		[FieldOffset(Offset = "0x18")]
		private List<InspectedMember> _allMembers;

		// Token: 0x04040260 RID: 262752
		[Token(Token = "0x4040260")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<IInspectedMemberFilter, List<InspectedMember>> _cachedMembers;

		// Token: 0x04040261 RID: 262753
		[Token(Token = "0x4040261")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<IInspectedMemberFilter, List<InspectedProperty>> _cachedProperties;

		// Token: 0x04040262 RID: 262754
		[Token(Token = "0x4040262")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<IInspectedMemberFilter, List<InspectedMethod>> _cachedMethods;

		// Token: 0x04040265 RID: 262757
		[Token(Token = "0x4040265")]
		[FieldOffset(Offset = "0x41")]
		private bool _isArray;

		// Token: 0x04040266 RID: 262758
		[Token(Token = "0x4040266")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<IInspectedMemberFilter, Dictionary<string, List<InspectedMember>>> _categoryCache;

		// Token: 0x04040267 RID: 262759
		[Token(Token = "0x4040267")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, InspectedProperty> _nameToProperty;

		// Token: 0x04040268 RID: 262760
		[Token(Token = "0x4040268")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, InspectedProperty> _formerlySerializedAsPropertyNames;
	}
}
