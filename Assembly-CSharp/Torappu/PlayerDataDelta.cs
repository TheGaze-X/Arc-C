using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Torappu.Reflection;
using XLua;

namespace Torappu
{
	// Token: 0x02000C0F RID: 3087
	[Token(Token = "0x2000C0F")]
	public struct PlayerDataDelta : IHotfixable
	{
		// Token: 0x060068BD RID: 26813 RVA: 0x00030A50 File Offset: 0x0002EC50
		[Token(Token = "0x60068BD")]
		[Address(RVA = "0x1EF4AC0", Offset = "0x1EF36C0", VA = "0x181EF4AC0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BE")]
		[Address(RVA = "0x1EF4780", Offset = "0x1EF3380", VA = "0x181EF4780")]
		public void Apply(JObject prevRawData, PlayerDataModel prevModel, bool useFastDelta, PlayerDataDelta.IncrementalDelta context, out PlayerDataModel resultModel)
		{
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BF")]
		[Address(RVA = "0x1EF4D20", Offset = "0x1EF3920", VA = "0x181EF4D20")]
		private static PlayerDataModel _ShallowDeltaPlayerDataModel(JObject rawData, PlayerDataModel prevModel, JObject modified, JObject deleted, PlayerDataDelta.IncrementalDelta context)
		{
			return null;
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C0")]
		[Address(RVA = "0x1EF4B60", Offset = "0x1EF3760", VA = "0x181EF4B60")]
		private static PlayerDataModel _FullDeltaPlayerDataModel(JObject rawData, PlayerDataModel prevModel, JObject modified, JObject deleted, PlayerDataDelta.IncrementalDelta context)
		{
			return null;
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C1")]
		[Address(RVA = "0x1EF5320", Offset = "0x1EF3F20", VA = "0x181EF5320")]
		[Conditional("TEST")]
		private static void _Test_BeginProfiling(string label)
		{
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C2")]
		[Address(RVA = "0x1EF5380", Offset = "0x1EF3F80", VA = "0x181EF5380")]
		[Conditional("TEST")]
		private static void _Test_EndProfiling()
		{
		}

		// Token: 0x04003F3C RID: 16188
		[Token(Token = "0x4003F3C")]
		public const string DELTA_FIELD = "playerDataDelta";

		// Token: 0x04003F3D RID: 16189
		[Token(Token = "0x4003F3D")]
		public const string MODIFY_FIELD = "modified";

		// Token: 0x04003F3E RID: 16190
		[Token(Token = "0x4003F3E")]
		public const string DELETED_FIELD = "deleted";

		// Token: 0x04003F3F RID: 16191
		[Token(Token = "0x4003F3F")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty(PropertyName = "modified")]
		public JObject modified;

		// Token: 0x04003F40 RID: 16192
		[Token(Token = "0x4003F40")]
		[FieldOffset(Offset = "0x8")]
		[JsonProperty(PropertyName = "deleted")]
		public JObject deleted;

		// Token: 0x04003F41 RID: 16193
		[Token(Token = "0x4003F41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04003F42 RID: 16194
		[Token(Token = "0x4003F42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x04003F43 RID: 16195
		[Token(Token = "0x4003F43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShallowDeltaPlayerDataModel;

		// Token: 0x04003F44 RID: 16196
		[Token(Token = "0x4003F44")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FullDeltaPlayerDataModel;

		// Token: 0x04003F45 RID: 16197
		[Token(Token = "0x4003F45")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Test_BeginProfiling;

		// Token: 0x04003F46 RID: 16198
		[Token(Token = "0x4003F46")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Test_EndProfiling;

		// Token: 0x02000C10 RID: 3088
		[Token(Token = "0x2000C10")]
		public enum TypeCategory
		{
			// Token: 0x04003F48 RID: 16200
			[Token(Token = "0x4003F48")]
			NONE,
			// Token: 0x04003F49 RID: 16201
			[Token(Token = "0x4003F49")]
			CLS,
			// Token: 0x04003F4A RID: 16202
			[Token(Token = "0x4003F4A")]
			MAP,
			// Token: 0x04003F4B RID: 16203
			[Token(Token = "0x4003F4B")]
			JOBJ,
			// Token: 0x04003F4C RID: 16204
			[Token(Token = "0x4003F4C")]
			MISC
		}

		// Token: 0x02000C11 RID: 3089
		[Token(Token = "0x2000C11")]
		public class DataReflectionInfo : IHotfixable
		{
			// Token: 0x17000CF6 RID: 3318
			// (get) Token: 0x060068C3 RID: 26819 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060068C4 RID: 26820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000CF6")]
			public Type targetType
			{
				[Token(Token = "0x60068C3")]
				[Address(RVA = "0x1EE99E0", Offset = "0x1EE85E0", VA = "0x181EE99E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60068C4")]
				[Address(RVA = "0x1EE9AB0", Offset = "0x1EE86B0", VA = "0x181EE9AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000CF7 RID: 3319
			// (get) Token: 0x060068C5 RID: 26821 RVA: 0x00030A68 File Offset: 0x0002EC68
			// (set) Token: 0x060068C6 RID: 26822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000CF7")]
			public PlayerDataDelta.TypeCategory category
			{
				[Token(Token = "0x60068C5")]
				[Address(RVA = "0x1EE9920", Offset = "0x1EE8520", VA = "0x181EE9920")]
				[CompilerGenerated]
				get
				{
					return PlayerDataDelta.TypeCategory.NONE;
				}
				[Token(Token = "0x60068C6")]
				[Address(RVA = "0x1EE9A40", Offset = "0x1EE8640", VA = "0x181EE9A40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000CF8 RID: 3320
			// (get) Token: 0x060068C7 RID: 26823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CF8")]
			public DictReflectionInfo dictInfo
			{
				[Token(Token = "0x60068C7")]
				[Address(RVA = "0x1EE9980", Offset = "0x1EE8580", VA = "0x181EE9980")]
				get
				{
					return null;
				}
			}

			// Token: 0x060068C8 RID: 26824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068C8")]
			[Address(RVA = "0x1EE9690", Offset = "0x1EE8290", VA = "0x181EE9690")]
			public FieldInfo GetClosedMatchField(string propertyName)
			{
				return null;
			}

			// Token: 0x060068C9 RID: 26825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068C9")]
			[Address(RVA = "0x1EE94D0", Offset = "0x1EE80D0", VA = "0x181EE94D0")]
			public string DumpDebugInfo()
			{
				return null;
			}

			// Token: 0x060068CA RID: 26826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068CA")]
			[Address(RVA = "0x1EE98C0", Offset = "0x1EE84C0", VA = "0x181EE98C0")]
			public DataReflectionInfo()
			{
			}

			// Token: 0x04003F4D RID: 16205
			[Token(Token = "0x4003F4D")]
			private const BindingFlags JSON_FIELDS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

			// Token: 0x04003F50 RID: 16208
			[Token(Token = "0x4003F50")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, FieldInfo> m_clsFields;

			// Token: 0x04003F51 RID: 16209
			[Token(Token = "0x4003F51")]
			[FieldOffset(Offset = "0x28")]
			private DictReflectionInfo m_dictInfo;

			// Token: 0x04003F52 RID: 16210
			[Token(Token = "0x4003F52")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_targetType;

			// Token: 0x04003F53 RID: 16211
			[Token(Token = "0x4003F53")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_targetType;

			// Token: 0x04003F54 RID: 16212
			[Token(Token = "0x4003F54")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_category;

			// Token: 0x04003F55 RID: 16213
			[Token(Token = "0x4003F55")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_category;

			// Token: 0x04003F56 RID: 16214
			[Token(Token = "0x4003F56")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_dictInfo;

			// Token: 0x04003F57 RID: 16215
			[Token(Token = "0x4003F57")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetClosedMatchField;

			// Token: 0x04003F58 RID: 16216
			[Token(Token = "0x4003F58")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_DumpDebugInfo;

			// Token: 0x04003F59 RID: 16217
			[Token(Token = "0x4003F59")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02000C12 RID: 3090
			[Token(Token = "0x2000C12")]
			public class Store : IHotfixable
			{
				// Token: 0x060068CB RID: 26827 RVA: 0x00030A80 File Offset: 0x0002EC80
				[Token(Token = "0x60068CB")]
				[Address(RVA = "0x200D440", Offset = "0x200C040", VA = "0x18200D440")]
				public Dictionary<string, FieldInfo>.Enumerator EnumClsFields(PlayerDataDelta.DataReflectionInfo info)
				{
					return default(Dictionary<string, FieldInfo>.Enumerator);
				}

				// Token: 0x060068CC RID: 26828 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60068CC")]
				[Address(RVA = "0x200D580", Offset = "0x200C180", VA = "0x18200D580")]
				public PlayerDataDelta.DataReflectionInfo GetOrCreateInfo(Type type)
				{
					return null;
				}

				// Token: 0x060068CD RID: 26829 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60068CD")]
				[Address(RVA = "0x200D9E0", Offset = "0x200C5E0", VA = "0x18200D9E0")]
				private PlayerDataDelta.DataReflectionInfo _CreateInfo(Type type)
				{
					return null;
				}

				// Token: 0x060068CE RID: 26830 RVA: 0x00030A98 File Offset: 0x0002EC98
				[Token(Token = "0x60068CE")]
				[Address(RVA = "0x200DC40", Offset = "0x200C840", VA = "0x18200DC40")]
				private PlayerDataDelta.TypeCategory _GetTypeCategory(Type type)
				{
					return PlayerDataDelta.TypeCategory.NONE;
				}

				// Token: 0x060068CF RID: 26831 RVA: 0x00030AB0 File Offset: 0x0002ECB0
				[Token(Token = "0x60068CF")]
				[Address(RVA = "0x200D6F0", Offset = "0x200C2F0", VA = "0x18200D6F0")]
				private static PlayerDataDelta.TypeCategory _CalcTypeCategoryImpl(Type type)
				{
					return PlayerDataDelta.TypeCategory.NONE;
				}

				// Token: 0x060068D0 RID: 26832 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60068D0")]
				[Address(RVA = "0x200DD40", Offset = "0x200C940", VA = "0x18200DD40")]
				private void _PopulateClsFields(PlayerDataDelta.DataReflectionInfo info, Type type)
				{
				}

				// Token: 0x060068D1 RID: 26833 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60068D1")]
				[Address(RVA = "0x200E060", Offset = "0x200CC60", VA = "0x18200E060")]
				public Store()
				{
				}

				// Token: 0x04003F5A RID: 16218
				[Token(Token = "0x4003F5A")]
				[FieldOffset(Offset = "0x10")]
				private Dictionary<string, FieldInfo> m_emptyFields;

				// Token: 0x04003F5B RID: 16219
				[Token(Token = "0x4003F5B")]
				[FieldOffset(Offset = "0x18")]
				private PlayerDataDelta.DataReflectionInfo m_emptyInfo;

				// Token: 0x04003F5C RID: 16220
				[Token(Token = "0x4003F5C")]
				[FieldOffset(Offset = "0x20")]
				private List<FieldInfo> m_sharedFields;

				// Token: 0x04003F5D RID: 16221
				[Token(Token = "0x4003F5D")]
				[FieldOffset(Offset = "0x28")]
				private Dictionary<Type, PlayerDataDelta.DataReflectionInfo> m_infoDict;

				// Token: 0x04003F5E RID: 16222
				[Token(Token = "0x4003F5E")]
				[FieldOffset(Offset = "0x30")]
				private Dictionary<Type, int> m_typeCategoryMemo;

				// Token: 0x04003F5F RID: 16223
				[Token(Token = "0x4003F5F")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_EnumClsFields;

				// Token: 0x04003F60 RID: 16224
				[Token(Token = "0x4003F60")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GetOrCreateInfo;

				// Token: 0x04003F61 RID: 16225
				[Token(Token = "0x4003F61")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0__CreateInfo;

				// Token: 0x04003F62 RID: 16226
				[Token(Token = "0x4003F62")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0__GetTypeCategory;

				// Token: 0x04003F63 RID: 16227
				[Token(Token = "0x4003F63")]
				[FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0__CalcTypeCategoryImpl;

				// Token: 0x04003F64 RID: 16228
				[Token(Token = "0x4003F64")]
				[FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0__PopulateClsFields;

				// Token: 0x04003F65 RID: 16229
				[Token(Token = "0x4003F65")]
				[FieldOffset(Offset = "0x30")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x02000C13 RID: 3091
		[Token(Token = "0x2000C13")]
		public struct DirtyPath : IHotfixable
		{
			// Token: 0x060068D2 RID: 26834 RVA: 0x00030AC8 File Offset: 0x0002ECC8
			[Token(Token = "0x60068D2")]
			[Address(RVA = "0x20091C0", Offset = "0x2007DC0", VA = "0x1820091C0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x060068D3 RID: 26835 RVA: 0x00030AE0 File Offset: 0x0002ECE0
			[Token(Token = "0x60068D3")]
			[Address(RVA = "0x2009010", Offset = "0x2007C10", VA = "0x182009010")]
			public static PlayerDataDelta.DirtyPath Create(JObject modified, object deleted)
			{
				return default(PlayerDataDelta.DirtyPath);
			}

			// Token: 0x060068D4 RID: 26836 RVA: 0x00030AF8 File Offset: 0x0002ECF8
			[Token(Token = "0x60068D4")]
			[Address(RVA = "0x20095C0", Offset = "0x20081C0", VA = "0x1820095C0")]
			public PlayerDataDelta.DirtyPath SubPath(string key)
			{
				return default(PlayerDataDelta.DirtyPath);
			}

			// Token: 0x060068D5 RID: 26837 RVA: 0x00030B10 File Offset: 0x0002ED10
			[Token(Token = "0x60068D5")]
			[Address(RVA = "0x20090C0", Offset = "0x2007CC0", VA = "0x1820090C0")]
			public bool HasDeletedFieldCurrentLayer()
			{
				return default(bool);
			}

			// Token: 0x060068D6 RID: 26838 RVA: 0x00030B28 File Offset: 0x0002ED28
			[Token(Token = "0x60068D6")]
			[Address(RVA = "0x2008F20", Offset = "0x2007B20", VA = "0x182008F20")]
			public bool CheckFieldModified(string key)
			{
				return default(bool);
			}

			// Token: 0x060068D7 RID: 26839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068D7")]
			[Address(RVA = "0x2009240", Offset = "0x2007E40", VA = "0x182009240")]
			public void PopulateModifiedFields(HashSet<string> output)
			{
			}

			// Token: 0x04003F66 RID: 16230
			[Token(Token = "0x4003F66")]
			[FieldOffset(Offset = "0x0")]
			private JObject m_modified;

			// Token: 0x04003F67 RID: 16231
			[Token(Token = "0x4003F67")]
			[FieldOffset(Offset = "0x8")]
			private object m_deleted;

			// Token: 0x04003F68 RID: 16232
			[Token(Token = "0x4003F68")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x04003F69 RID: 16233
			[Token(Token = "0x4003F69")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x04003F6A RID: 16234
			[Token(Token = "0x4003F6A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SubPath;

			// Token: 0x04003F6B RID: 16235
			[Token(Token = "0x4003F6B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_HasDeletedFieldCurrentLayer;

			// Token: 0x04003F6C RID: 16236
			[Token(Token = "0x4003F6C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CheckFieldModified;

			// Token: 0x04003F6D RID: 16237
			[Token(Token = "0x4003F6D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PopulateModifiedFields;
		}

		// Token: 0x02000C14 RID: 3092
		[Token(Token = "0x2000C14")]
		public class IncrementalDelta
		{
			// Token: 0x17000CF9 RID: 3321
			// (get) Token: 0x060068D8 RID: 26840 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060068D9 RID: 26841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000CF9")]
			public object[] object2
			{
				[Token(Token = "0x60068D8")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60068D9")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060068DA RID: 26842 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068DA")]
			[Address(RVA = "0x200B0E0", Offset = "0x2009CE0", VA = "0x18200B0E0")]
			private object _MemberwiseClone(object target)
			{
				return null;
			}

			// Token: 0x060068DB RID: 26843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068DB")]
			[Address(RVA = "0x200AFF0", Offset = "0x2009BF0", VA = "0x18200AFF0")]
			private object _JsonDeserialize(JToken json, Type type)
			{
				return null;
			}

			// Token: 0x060068DC RID: 26844 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068DC")]
			[Address(RVA = "0x200B020", Offset = "0x2009C20", VA = "0x18200B020")]
			private static void _LogError(PlayerDataDelta.DataReflectionInfo info, string message)
			{
			}

			// Token: 0x060068DD RID: 26845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068DD")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			public JsonSerializer GetSerializer()
			{
				return null;
			}

			// Token: 0x060068DE RID: 26846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068DE")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			public PlayerDataDelta.DataReflectionInfo.Store GetReflectInfoStore()
			{
				return null;
			}

			// Token: 0x060068DF RID: 26847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60068DF")]
			[Address(RVA = "0x200B1D0", Offset = "0x2009DD0", VA = "0x18200B1D0")]
			public IncrementalDelta(JsonSerializerSettings jsonSettings)
			{
			}

			// Token: 0x060068E0 RID: 26848 RVA: 0x00030B40 File Offset: 0x0002ED40
			[Token(Token = "0x60068E0")]
			[Address(RVA = "0x200A0F0", Offset = "0x2008CF0", VA = "0x18200A0F0")]
			public Dictionary<string, FieldInfo>.Enumerator EnumPlayerDataFields()
			{
				return default(Dictionary<string, FieldInfo>.Enumerator);
			}

			// Token: 0x060068E1 RID: 26849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068E1")]
			[Address(RVA = "0x200A7B0", Offset = "0x20093B0", VA = "0x18200A7B0")]
			public object FastCloneModel(JToken token, PlayerDataDelta.DirtyPath dirty, object model, PlayerDataDelta.DataReflectionInfo info)
			{
				return null;
			}

			// Token: 0x060068E2 RID: 26850 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60068E2")]
			[Address(RVA = "0x200A2E0", Offset = "0x2008EE0", VA = "0x18200A2E0")]
			public object FastCloneDict(JToken token, PlayerDataDelta.DirtyPath dirty, object dict, PlayerDataDelta.DataReflectionInfo info)
			{
				return null;
			}

			// Token: 0x060068E3 RID: 26851 RVA: 0x00030B58 File Offset: 0x0002ED58
			[Token(Token = "0x60068E3")]
			[Address(RVA = "0x200AE20", Offset = "0x2009A20", VA = "0x18200AE20")]
			public bool TryCopyDictValue(object fromDict, object toDict, string strKey, object typedKey, JToken token, in PlayerDataDelta.DirtyPath dirty, DictReflectionInfo dictInfo, PlayerDataDelta.DataReflectionInfo valueInfo)
			{
				return default(bool);
			}

			// Token: 0x04003F6F RID: 16239
			[Token(Token = "0x4003F6F")]
			[FieldOffset(Offset = "0x18")]
			public LocalGenericPool<HashSet<string>> stringSetPool;

			// Token: 0x04003F70 RID: 16240
			[Token(Token = "0x4003F70")]
			[FieldOffset(Offset = "0x20")]
			private MethodInfo m_memberwiseCloneMethod;

			// Token: 0x04003F71 RID: 16241
			[Token(Token = "0x4003F71")]
			[FieldOffset(Offset = "0x28")]
			private JsonSerializer m_jsonSerializer;

			// Token: 0x04003F72 RID: 16242
			[Token(Token = "0x4003F72")]
			[FieldOffset(Offset = "0x30")]
			private readonly PlayerDataDelta.DataReflectionInfo.Store m_dataInfoStore;
		}
	}
}
