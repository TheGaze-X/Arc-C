using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004DA RID: 1242
	[Token(Token = "0x20004DA")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class ResourceManager
	{
		// Token: 0x060023C5 RID: 9157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x4BDE380", Offset = "0x4BDCF80", VA = "0x184BDE380")]
		[MethodImpl(8)]
		private void Init()
		{
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x4BDF130", Offset = "0x4BDDD30", VA = "0x184BDF130")]
		protected ResourceManager()
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x4BDF240", Offset = "0x4BDDE40", VA = "0x184BDF240")]
		[MethodImpl(8)]
		public ResourceManager(System.Type resourceSource)
		{
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x4BDEDF0", Offset = "0x4BDD9F0", VA = "0x184BDEDF0")]
		[System.Runtime.Serialization.OnDeserializing]
		private void OnDeserializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x4BDEB40", Offset = "0x4BDD740", VA = "0x184BDEB40")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x4BDEE40", Offset = "0x4BDDA40", VA = "0x184BDEE40")]
		[System.Runtime.Serialization.OnSerializing]
		private void OnSerializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x4BDD3B0", Offset = "0x4BDBFB0", VA = "0x184BDD3B0")]
		private void CommonAssemblyInit()
		{
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000495")]
		public virtual string BaseName
		{
			[Token(Token = "0x60023CC")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x000143A0 File Offset: 0x000125A0
		[Token(Token = "0x17000496")]
		public virtual bool IgnoreCase
		{
			[Token(Token = "0x60023CD")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x000143B8 File Offset: 0x000125B8
		[Token(Token = "0x17000497")]
		protected UltimateResourceFallbackLocation FallbackLocation
		{
			[Token(Token = "0x60023CE")]
			[Address(RVA = "0x32FB190", Offset = "0x32F9D90", VA = "0x1832FB190")]
			get
			{
				return UltimateResourceFallbackLocation.MainAssembly;
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x4BDD7C0", Offset = "0x4BDC3C0", VA = "0x184BDD7C0", Slot = "6")]
		protected virtual string GetResourceFileName(System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x4BDD940", Offset = "0x4BDC540", VA = "0x184BDD940", Slot = "7")]
		[MethodImpl(8)]
		public virtual ResourceSet GetResourceSet(System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			return null;
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x4BDE4C0", Offset = "0x4BDD0C0", VA = "0x184BDE4C0", Slot = "8")]
		[MethodImpl(8)]
		protected virtual ResourceSet InternalGetResourceSet(System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			return null;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x4BDE4F0", Offset = "0x4BDD0F0", VA = "0x184BDE4F0")]
		private ResourceSet InternalGetResourceSet(System.Globalization.CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x4BDD220", Offset = "0x4BDBE20", VA = "0x184BDD220")]
		private static void AddResourceSet(System.Collections.Generic.Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x4BDDD00", Offset = "0x4BDC900", VA = "0x184BDDD00")]
		protected static System.Version GetSatelliteContractVersion(System.Reflection.Assembly a)
		{
			return null;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x4BDD7A0", Offset = "0x4BDC3A0", VA = "0x184BDD7A0")]
		protected static System.Globalization.CultureInfo GetNeutralResourcesLanguage(System.Reflection.Assembly a)
		{
			return null;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000143D0 File Offset: 0x000125D0
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x4BDD570", Offset = "0x4BDC170", VA = "0x184BDD570")]
		internal static bool CompareNames(string asmTypeName1, string typeName2, System.Reflection.AssemblyName asmName2)
		{
			return default(bool);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void SetAppXConfiguration()
		{
		}

		// Token: 0x04001452 RID: 5202
		[Token(Token = "0x4001452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string BaseNameField;

		// Token: 0x04001453 RID: 5203
		[Token(Token = "0x4001453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[System.Obsolete("call InternalGetResourceSet instead")]
		protected System.Collections.Hashtable ResourceSets;

		// Token: 0x04001454 RID: 5204
		[Token(Token = "0x4001454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		private System.Collections.Generic.Dictionary<string, ResourceSet> _resourceSets;

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x4001455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string moduleDir;

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected System.Reflection.Assembly MainAssembly;

		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x4001457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private System.Type _locationInfo;

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private System.Type _userResourceSet;

		// Token: 0x04001459 RID: 5209
		[Token(Token = "0x4001459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private System.Globalization.CultureInfo _neutralResourcesCulture;

		// Token: 0x0400145A RID: 5210
		[Token(Token = "0x400145A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[System.NonSerialized]
		private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache;

		// Token: 0x0400145B RID: 5211
		[Token(Token = "0x400145B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _ignoreCase;

		// Token: 0x0400145C RID: 5212
		[Token(Token = "0x400145C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool UseManifest;

		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		private bool UseSatelliteAssem;

		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[System.Runtime.Serialization.OptionalField]
		private UltimateResourceFallbackLocation _fallbackLoc;

		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[System.Runtime.Serialization.OptionalField]
		private System.Version _satelliteContractVersion;

		// Token: 0x04001460 RID: 5216
		[Token(Token = "0x4001460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[System.Runtime.Serialization.OptionalField]
		private bool _lookedForSatelliteContractVersion;

		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		private System.Reflection.Assembly _callingAssembly;

		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		private RuntimeAssembly m_callingAssembly;

		// Token: 0x04001463 RID: 5219
		[Token(Token = "0x4001463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[System.NonSerialized]
		private IResourceGroveler resourceGroveler;

		// Token: 0x04001464 RID: 5220
		[Token(Token = "0x4001464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int MagicNumber;

		// Token: 0x04001465 RID: 5221
		[Token(Token = "0x4001465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int HeaderVersionNumber;

		// Token: 0x04001466 RID: 5222
		[Token(Token = "0x4001466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly System.Type _minResourceSet;

		// Token: 0x04001467 RID: 5223
		[Token(Token = "0x4001467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly string ResReaderTypeName;

		// Token: 0x04001468 RID: 5224
		[Token(Token = "0x4001468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly string ResSetTypeName;

		// Token: 0x04001469 RID: 5225
		[Token(Token = "0x4001469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly string MscorlibName;

		// Token: 0x0400146A RID: 5226
		[Token(Token = "0x400146A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static readonly int DEBUG;

		// Token: 0x020004DB RID: 1243
		[Token(Token = "0x20004DB")]
		internal class CultureNameResourceSetPair
		{
			// Token: 0x060023D9 RID: 9177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60023D9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CultureNameResourceSetPair()
			{
			}
		}

		// Token: 0x020004DC RID: 1244
		[Token(Token = "0x20004DC")]
		internal class ResourceManagerMediator
		{
			// Token: 0x060023DA RID: 9178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60023DA")]
			[Address(RVA = "0x4BDCF90", Offset = "0x4BDBB90", VA = "0x184BDCF90")]
			internal ResourceManagerMediator(ResourceManager rm)
			{
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x060023DB RID: 9179 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000498")]
			internal string ModuleDir
			{
				[Token(Token = "0x60023DB")]
				[Address(RVA = "0x1CA1D60", Offset = "0x1CA0960", VA = "0x181CA1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000499 RID: 1177
			// (get) Token: 0x060023DC RID: 9180 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000499")]
			internal System.Type LocationInfo
			{
				[Token(Token = "0x60023DC")]
				[Address(RVA = "0x4BDD0B0", Offset = "0x4BDBCB0", VA = "0x184BDD0B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700049A RID: 1178
			// (get) Token: 0x060023DD RID: 9181 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700049A")]
			internal System.Type UserResourceSet
			{
				[Token(Token = "0x60023DD")]
				[Address(RVA = "0x1CA1D80", Offset = "0x1CA0980", VA = "0x181CA1D80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700049B RID: 1179
			// (get) Token: 0x060023DE RID: 9182 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700049B")]
			internal string BaseNameField
			{
				[Token(Token = "0x60023DE")]
				[Address(RVA = "0x319C1D0", Offset = "0x319ADD0", VA = "0x18319C1D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700049C RID: 1180
			// (get) Token: 0x060023DF RID: 9183 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700049C")]
			internal System.Globalization.CultureInfo NeutralResourcesCulture
			{
				[Token(Token = "0x60023DF")]
				[Address(RVA = "0xFEE8C0", Offset = "0xFED4C0", VA = "0x180FEE8C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060023E0 RID: 9184 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60023E0")]
			[Address(RVA = "0x4BDCEE0", Offset = "0x4BDBAE0", VA = "0x184BDCEE0")]
			internal string GetResourceFileName(System.Globalization.CultureInfo culture)
			{
				return null;
			}

			// Token: 0x1700049D RID: 1181
			// (get) Token: 0x060023E1 RID: 9185 RVA: 0x000143E8 File Offset: 0x000125E8
			// (set) Token: 0x060023E2 RID: 9186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700049D")]
			internal bool LookedForSatelliteContractVersion
			{
				[Token(Token = "0x60023E1")]
				[Address(RVA = "0x4BDD0D0", Offset = "0x4BDBCD0", VA = "0x184BDD0D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60023E2")]
				[Address(RVA = "0x4BDD1D0", Offset = "0x4BDBDD0", VA = "0x184BDD1D0")]
				set
				{
				}
			}

			// Token: 0x1700049E RID: 1182
			// (get) Token: 0x060023E3 RID: 9187 RVA: 0x000020CA File Offset: 0x000002CA
			// (set) Token: 0x060023E4 RID: 9188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700049E")]
			internal System.Version SatelliteContractVersion
			{
				[Token(Token = "0x60023E3")]
				[Address(RVA = "0x4BDD1B0", Offset = "0x4BDBDB0", VA = "0x184BDD1B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60023E4")]
				[Address(RVA = "0x4BDD1F0", Offset = "0x4BDBDF0", VA = "0x184BDD1F0")]
				set
				{
				}
			}

			// Token: 0x060023E5 RID: 9189 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60023E5")]
			[Address(RVA = "0x4BDCF40", Offset = "0x4BDBB40", VA = "0x184BDCF40")]
			internal System.Version ObtainSatelliteContractVersion(System.Reflection.Assembly a)
			{
				return null;
			}

			// Token: 0x1700049F RID: 1183
			// (get) Token: 0x060023E6 RID: 9190 RVA: 0x00014400 File Offset: 0x00012600
			[Token(Token = "0x1700049F")]
			internal UltimateResourceFallbackLocation FallbackLoc
			{
				[Token(Token = "0x60023E6")]
				[Address(RVA = "0x4BDD090", Offset = "0x4BDBC90", VA = "0x184BDD090")]
				get
				{
					return UltimateResourceFallbackLocation.MainAssembly;
				}
			}

			// Token: 0x170004A0 RID: 1184
			// (get) Token: 0x060023E7 RID: 9191 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170004A0")]
			internal RuntimeAssembly CallingAssembly
			{
				[Token(Token = "0x60023E7")]
				[Address(RVA = "0x4BDD070", Offset = "0x4BDBC70", VA = "0x184BDD070")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004A1 RID: 1185
			// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170004A1")]
			internal RuntimeAssembly MainAssembly
			{
				[Token(Token = "0x60023E8")]
				[Address(RVA = "0x4BDD0F0", Offset = "0x4BDBCF0", VA = "0x184BDD0F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004A2 RID: 1186
			// (get) Token: 0x060023E9 RID: 9193 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170004A2")]
			internal string BaseName
			{
				[Token(Token = "0x60023E9")]
				[Address(RVA = "0x4BDD020", Offset = "0x4BDBC20", VA = "0x184BDD020")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400146B RID: 5227
			[Token(Token = "0x400146B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ResourceManager _rm;
		}
	}
}
