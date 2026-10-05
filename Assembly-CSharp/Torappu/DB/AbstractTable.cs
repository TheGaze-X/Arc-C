using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x020016A5 RID: 5797
	[Token(Token = "0x20016A5")]
	public abstract class AbstractTable : ScriptableObject, ILuaCallCSharp, IHotfixable, ITableDataType
	{
		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x060092C7 RID: 37575 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060092C8 RID: 37576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F99")]
		[Inspect]
		[Group("SampleData")]
		private TextAsset[] _dragSamplesHere
		{
			[Token(Token = "0x60092C7")]
			[Address(RVA = "0x2B24E70", Offset = "0x2B23A70", VA = "0x182B24E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60092C8")]
			[Address(RVA = "0x2B25050", Offset = "0x2B23C50", VA = "0x182B25050")]
			set
			{
			}
		}

		// Token: 0x060092C9 RID: 37577 RVA: 0x000391B0 File Offset: 0x000373B0
		[Token(Token = "0x60092C9")]
		[Address(RVA = "0x2B249E0", Offset = "0x2B235E0", VA = "0x182B249E0")]
		public bool RemoveSamples()
		{
			return default(bool);
		}

		// Token: 0x060092CA RID: 37578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092CA")]
		[Address(RVA = "0x2B24520", Offset = "0x2B23120", VA = "0x182B24520")]
		public AbstractTable.ExtensionOnlyInterface EditorInterface()
		{
			return null;
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x060092CB RID: 37579
		[Token(Token = "0x17000F9A")]
		public abstract bool inited { [Token(Token = "0x60092CB")] get; }

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x060092CC RID: 37580 RVA: 0x000391C8 File Offset: 0x000373C8
		[Token(Token = "0x17000F9B")]
		public bool isProdMode
		{
			[Token(Token = "0x60092CC")]
			[Address(RVA = "0x2B24F40", Offset = "0x2B23B40", VA = "0x182B24F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x060092CD RID: 37581 RVA: 0x000391E0 File Offset: 0x000373E0
		[Token(Token = "0x17000F9C")]
		public AbstractTable.RequireConfig requireConfig
		{
			[Token(Token = "0x60092CD")]
			[Address(RVA = "0x2B24FC0", Offset = "0x2B23BC0", VA = "0x182B24FC0")]
			get
			{
				return default(AbstractTable.RequireConfig);
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x060092CE RID: 37582 RVA: 0x000391F8 File Offset: 0x000373F8
		[Token(Token = "0x17000F9D")]
		public bool enableAsyncLoad
		{
			[Token(Token = "0x60092CE")]
			[Address(RVA = "0x2B24EE0", Offset = "0x2B23AE0", VA = "0x182B24EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092CF")]
		[Address(RVA = "0x2B246E0", Offset = "0x2B232E0", VA = "0x182B246E0")]
		public TableConfig GetConfig()
		{
			return null;
		}

		// Token: 0x060092D0 RID: 37584
		[Token(Token = "0x60092D0")]
		public abstract bool Init(Stream stream, IConverter converter);

		// Token: 0x060092D1 RID: 37585
		[Token(Token = "0x60092D1")]
		public abstract bool Init(TextAsset rawData, IConverter converter);

		// Token: 0x060092D2 RID: 37586
		[Token(Token = "0x60092D2")]
		public abstract AbstractTable.IAsyncLoadRequest InitAsync(IConverter converter);

		// Token: 0x060092D3 RID: 37587
		[Token(Token = "0x60092D3")]
		public abstract bool Validate();

		// Token: 0x060092D4 RID: 37588
		[Token(Token = "0x60092D4")]
		public abstract string SerializeToString(bool intended);

		// Token: 0x060092D5 RID: 37589
		[Token(Token = "0x60092D5")]
		public abstract string GetDebugString();

		// Token: 0x060092D6 RID: 37590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092D6")]
		protected static WaitForAsyncTask<AbstractTable.DeserializeResult<ResType>> CreateDeserializeTask<ResType>(TextAsset rawData, IConverter converter)
		{
			return null;
		}

		// Token: 0x060092D7 RID: 37591
		[Token(Token = "0x60092D7")]
		public abstract Type GetDataType();

		// Token: 0x060092D8 RID: 37592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092D8")]
		[Address(RVA = "0x2B247B0", Offset = "0x2B233B0", VA = "0x182B247B0")]
		public AbstractTable.RuntimeAsset LoadMainAsset()
		{
			return null;
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x00039210 File Offset: 0x00037410
		[Token(Token = "0x60092D9")]
		[Address(RVA = "0x2B24AC0", Offset = "0x2B236C0", VA = "0x182B24AC0")]
		public bool TryLoadToCheckMainAsset(out string mainAssetPath)
		{
			return default(bool);
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092DA")]
		[Address(RVA = "0x2B24580", Offset = "0x2B23180", VA = "0x182B24580")]
		[Conditional("UNITY_EDITOR")]
		public void EditorSetRequireConfig(AbstractTable.RequireConfig config)
		{
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092DB")]
		[Address(RVA = "0x2B24970", Offset = "0x2B23570", VA = "0x182B24970")]
		public void MarkMainAssetInvalid()
		{
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092DC")]
		[Address(RVA = "0x2B24C40", Offset = "0x2B23840", VA = "0x182B24C40")]
		private string _GenerateRuntimeResPath()
		{
			return null;
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092DD")]
		[Address(RVA = "0x2B24E10", Offset = "0x2B23A10", VA = "0x182B24E10")]
		protected AbstractTable()
		{
		}

		// Token: 0x04008869 RID: 34921
		[Token(Token = "0x4008869")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TableConfig _devConfig;

		// Token: 0x0400886A RID: 34922
		[Token(Token = "0x400886A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TableConfig _prodConfig;

		// Token: 0x0400886B RID: 34923
		[Token(Token = "0x400886B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbstractTable.RequireConfig _requireConfig;

		// Token: 0x0400886C RID: 34924
		[Token(Token = "0x400886C")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _enableAsyncLoad;

		// Token: 0x0400886D RID: 34925
		[Token(Token = "0x400886D")]
		[FieldOffset(Offset = "0x30")]
		[Group("SampleData")]
		[SerializeField]
		[Tooltip("This is not needed when samples not needed in editor mode")]
		protected List<string> _samplePaths;

		// Token: 0x0400886E RID: 34926
		[Token(Token = "0x400886E")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public bool disableSampleData;

		// Token: 0x0400886F RID: 34927
		[Token(Token = "0x400886F")]
		[FieldOffset(Offset = "0x40")]
		private AbstractTable.ExtensionOnlyInterface m_extensionInterface;

		// Token: 0x04008870 RID: 34928
		[Token(Token = "0x4008870")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get__dragSamplesHere;

		// Token: 0x04008871 RID: 34929
		[Token(Token = "0x4008871")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set__dragSamplesHere;

		// Token: 0x04008872 RID: 34930
		[Token(Token = "0x4008872")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RemoveSamples;

		// Token: 0x04008873 RID: 34931
		[Token(Token = "0x4008873")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EditorInterface;

		// Token: 0x04008874 RID: 34932
		[Token(Token = "0x4008874")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isProdMode;

		// Token: 0x04008875 RID: 34933
		[Token(Token = "0x4008875")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_requireConfig;

		// Token: 0x04008876 RID: 34934
		[Token(Token = "0x4008876")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_enableAsyncLoad;

		// Token: 0x04008877 RID: 34935
		[Token(Token = "0x4008877")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetConfig;

		// Token: 0x04008878 RID: 34936
		[Token(Token = "0x4008878")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateDeserializeTask;

		// Token: 0x04008879 RID: 34937
		[Token(Token = "0x4008879")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadMainAsset;

		// Token: 0x0400887A RID: 34938
		[Token(Token = "0x400887A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryLoadToCheckMainAsset;

		// Token: 0x0400887B RID: 34939
		[Token(Token = "0x400887B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EditorSetRequireConfig;

		// Token: 0x0400887C RID: 34940
		[Token(Token = "0x400887C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_MarkMainAssetInvalid;

		// Token: 0x0400887D RID: 34941
		[Token(Token = "0x400887D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenerateRuntimeResPath;

		// Token: 0x0400887E RID: 34942
		[Token(Token = "0x400887E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020016A6 RID: 5798
		[Token(Token = "0x20016A6")]
		protected struct DeserializeResult<ResType>
		{
			// Token: 0x0400887F RID: 34943
			[Token(Token = "0x400887F")]
			[FieldOffset(Offset = "0x0")]
			public ResType data;
		}

		// Token: 0x020016A7 RID: 5799
		[Token(Token = "0x20016A7")]
		public struct AsyncLoadResult
		{
			// Token: 0x04008880 RID: 34944
			[Token(Token = "0x4008880")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AbstractTable.AsyncLoadResult EMPTY;

			// Token: 0x04008881 RID: 34945
			[Token(Token = "0x4008881")]
			[FieldOffset(Offset = "0x0")]
			public Exception exception;

			// Token: 0x04008882 RID: 34946
			[Token(Token = "0x4008882")]
			[FieldOffset(Offset = "0x8")]
			public object data;
		}

		// Token: 0x020016A8 RID: 5800
		[Token(Token = "0x20016A8")]
		public interface IAsyncLoadRequest
		{
			// Token: 0x060092DF RID: 37599
			[Token(Token = "0x60092DF")]
			object Deserialize(ConverterInput input);

			// Token: 0x060092E0 RID: 37600
			[Token(Token = "0x60092E0")]
			bool Finish(AbstractTable.AsyncLoadResult result);

			// Token: 0x060092E1 RID: 37601
			[Token(Token = "0x60092E1")]
			string GetName();
		}

		// Token: 0x020016A9 RID: 5801
		[Token(Token = "0x20016A9")]
		public class AsyncLoadRequest<TValue> : AbstractTable.IAsyncLoadRequest
		{
			// Token: 0x060092E2 RID: 37602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60092E2")]
			private AsyncLoadRequest()
			{
			}

			// Token: 0x060092E3 RID: 37603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60092E3")]
			public AsyncLoadRequest(Action<TValue> dataCallback, IConverter converter, Type dbType)
			{
			}

			// Token: 0x060092E4 RID: 37604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60092E4")]
			public string GetName()
			{
				return null;
			}

			// Token: 0x060092E5 RID: 37605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60092E5")]
			public object Deserialize(ConverterInput input)
			{
				return null;
			}

			// Token: 0x060092E6 RID: 37606 RVA: 0x00039228 File Offset: 0x00037428
			[Token(Token = "0x60092E6")]
			public bool Finish(AbstractTable.AsyncLoadResult result)
			{
				return default(bool);
			}

			// Token: 0x04008883 RID: 34947
			[Token(Token = "0x4008883")]
			[FieldOffset(Offset = "0x0")]
			private Action<TValue> m_dataCb;

			// Token: 0x04008884 RID: 34948
			[Token(Token = "0x4008884")]
			[FieldOffset(Offset = "0x0")]
			private IConverter m_converter;

			// Token: 0x04008885 RID: 34949
			[Token(Token = "0x4008885")]
			[FieldOffset(Offset = "0x0")]
			private Type m_dbType;
		}

		// Token: 0x020016AA RID: 5802
		[Token(Token = "0x20016AA")]
		[Serializable]
		public struct RequireConfig
		{
			// Token: 0x060092E7 RID: 37607 RVA: 0x00039240 File Offset: 0x00037440
			[Token(Token = "0x60092E7")]
			[Address(RVA = "0x2B3B530", Offset = "0x2B3A130", VA = "0x182B3B530")]
			public bool ShouldLoad(bool isHotUpdateScene)
			{
				return default(bool);
			}

			// Token: 0x04008886 RID: 34950
			[Token(Token = "0x4008886")]
			[FieldOffset(Offset = "0x0")]
			public bool hotupdate;

			// Token: 0x04008887 RID: 34951
			[Token(Token = "0x4008887")]
			[FieldOffset(Offset = "0x1")]
			public bool login;

			// Token: 0x04008888 RID: 34952
			[Token(Token = "0x4008888")]
			[FieldOffset(Offset = "0x2")]
			[Tooltip("Tick 'bypass' would make the DB skip building and loading.")]
			public bool bypass;
		}

		// Token: 0x020016AB RID: 5803
		[Token(Token = "0x20016AB")]
		public class RuntimeAsset : IDisposable
		{
			// Token: 0x17000F9E RID: 3998
			// (get) Token: 0x060092E8 RID: 37608 RVA: 0x00039258 File Offset: 0x00037458
			// (set) Token: 0x060092E9 RID: 37609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F9E")]
			public bool fromResource
			{
				[Token(Token = "0x60092E8")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60092E9")]
				[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000F9F RID: 3999
			// (get) Token: 0x060092EA RID: 37610 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060092EB RID: 37611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F9F")]
			public TextAsset asset
			{
				[Token(Token = "0x60092EA")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60092EB")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060092EC RID: 37612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60092EC")]
			[Address(RVA = "0x2B3B5E0", Offset = "0x2B3A1E0", VA = "0x182B3B5E0")]
			public RuntimeAsset(TextAsset pAsset, bool pFromResource)
			{
			}

			// Token: 0x060092ED RID: 37613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60092ED")]
			[Address(RVA = "0x2B3B550", Offset = "0x2B3A150", VA = "0x182B3B550", Slot = "4")]
			public void Dispose()
			{
			}
		}

		// Token: 0x020016AC RID: 5804
		[Token(Token = "0x20016AC")]
		public class ExtensionOnlyInterface
		{
			// Token: 0x060092EE RID: 37614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60092EE")]
			[Address(RVA = "0x5B5460", Offset = "0x5B4060", VA = "0x1805B5460")]
			public TableConfig GetDevConfig()
			{
				return null;
			}

			// Token: 0x060092EF RID: 37615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60092EF")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public ExtensionOnlyInterface(AbstractTable closure)
			{
			}

			// Token: 0x0400888B RID: 34955
			[Token(Token = "0x400888B")]
			[FieldOffset(Offset = "0x10")]
			private AbstractTable m_clsoure;
		}
	}
}
