using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Resource
{
	// Token: 0x02001751 RID: 5969
	[Token(Token = "0x2001751")]
	[Serializable]
	public class ResourceManifest
	{
		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06009673 RID: 38515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001016")]
		[JsonIgnore]
		public static string VERSION
		{
			[Token(Token = "0x6009673")]
			[Address(RVA = "0x312C150", Offset = "0x312AD50", VA = "0x18312C150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06009674 RID: 38516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001017")]
		[JsonIgnore]
		public Dictionary<string, int> bundleIndexMap
		{
			[Token(Token = "0x6009674")]
			[Address(RVA = "0x312C190", Offset = "0x312AD90", VA = "0x18312C190")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009675 RID: 38517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009675")]
		[Address(RVA = "0x312BCB0", Offset = "0x312A8B0", VA = "0x18312BCB0")]
		public string[] GetAllAssetBundles()
		{
			return null;
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009676")]
		[Address(RVA = "0x312BDE0", Offset = "0x312A9E0", VA = "0x18312BDE0")]
		public string[] GetAllDependencies(string assetBundleName)
		{
			return null;
		}

		// Token: 0x06009677 RID: 38519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009677")]
		[Address(RVA = "0x312C080", Offset = "0x312AC80", VA = "0x18312C080")]
		public ResourceManifest()
		{
		}

		// Token: 0x04008CAF RID: 36015
		[Token(Token = "0x4008CAF")]
		[FieldOffset(Offset = "0x10")]
		public int rawCount;

		// Token: 0x04008CB0 RID: 36016
		[Token(Token = "0x4008CB0")]
		[FieldOffset(Offset = "0x18")]
		public List<ResourceManifest.BundleMeta> bundles;

		// Token: 0x04008CB1 RID: 36017
		[Token(Token = "0x4008CB1")]
		[FieldOffset(Offset = "0x20")]
		public List<ResourceManifest.AssetToBundleMeta> assetToBundleList;

		// Token: 0x04008CB2 RID: 36018
		[Token(Token = "0x4008CB2")]
		[FieldOffset(Offset = "0x28")]
		[JsonIgnore]
		[NonSerialized]
		private Dictionary<string, int> m_bundleIndexMap;

		// Token: 0x02001752 RID: 5970
		[Token(Token = "0x2001752")]
		[Flags]
		public enum MetaProperty
		{
			// Token: 0x04008CB4 RID: 36020
			[Token(Token = "0x4008CB4")]
			NONE = 0,
			// Token: 0x04008CB5 RID: 36021
			[Token(Token = "0x4008CB5")]
			CACHEABLE = 1,
			// Token: 0x04008CB6 RID: 36022
			[Token(Token = "0x4008CB6")]
			RETAINED = 2
		}

		// Token: 0x02001753 RID: 5971
		[Token(Token = "0x2001753")]
		[Serializable]
		public struct BundleMeta
		{
			// Token: 0x06009678 RID: 38520 RVA: 0x0003A9B0 File Offset: 0x00038BB0
			[Token(Token = "0x6009678")]
			[Address(RVA = "0x3122C20", Offset = "0x3121820", VA = "0x183122C20")]
			public bool HasProperty(ResourceManifest.MetaProperty prop)
			{
				return default(bool);
			}

			// Token: 0x06009679 RID: 38521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009679")]
			[Address(RVA = "0x3122C30", Offset = "0x3121830", VA = "0x183122C30")]
			public void SetProperty(ResourceManifest.MetaProperty prop, bool enable)
			{
			}

			// Token: 0x0600967A RID: 38522 RVA: 0x0003A9C8 File Offset: 0x00038BC8
			[Token(Token = "0x600967A")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0600967B RID: 38523 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600967B")]
			[Address(RVA = "0x3122C70", Offset = "0x3121870", VA = "0x183122C70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04008CB7 RID: 36023
			[Token(Token = "0x4008CB7")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04008CB8 RID: 36024
			[Token(Token = "0x4008CB8")]
			[FieldOffset(Offset = "0x8")]
			public int props;

			// Token: 0x04008CB9 RID: 36025
			[Token(Token = "0x4008CB9")]
			[FieldOffset(Offset = "0xC")]
			public int sccIndex;

			// Token: 0x04008CBA RID: 36026
			[Token(Token = "0x4008CBA")]
			[FieldOffset(Offset = "0x10")]
			public List<int> allDependencies;
		}

		// Token: 0x02001754 RID: 5972
		[Token(Token = "0x2001754")]
		[Serializable]
		public struct AssetToBundleMeta
		{
			// Token: 0x0600967C RID: 38524 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600967C")]
			[Address(RVA = "0x311F330", Offset = "0x311DF30", VA = "0x18311F330", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04008CBB RID: 36027
			[Token(Token = "0x4008CBB")]
			[FieldOffset(Offset = "0x0")]
			public string assetName;

			// Token: 0x04008CBC RID: 36028
			[Token(Token = "0x4008CBC")]
			[FieldOffset(Offset = "0x8")]
			public int bundleIndex;

			// Token: 0x04008CBD RID: 36029
			[Token(Token = "0x4008CBD")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04008CBE RID: 36030
			[Token(Token = "0x4008CBE")]
			[FieldOffset(Offset = "0x18")]
			public string path;
		}
	}
}
