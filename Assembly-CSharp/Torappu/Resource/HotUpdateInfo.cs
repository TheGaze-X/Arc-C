using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Resource
{
	// Token: 0x0200173D RID: 5949
	[Token(Token = "0x200173D")]
	public class HotUpdateInfo
	{
		// Token: 0x06009611 RID: 38417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009611")]
		[Address(RVA = "0x3108130", Offset = "0x3106D30", VA = "0x183108130")]
		public HotUpdateInfo ShallowClone()
		{
			return null;
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009612")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private HotUpdateInfo()
		{
		}

		// Token: 0x04008C4A RID: 35914
		[Token(Token = "0x4008C4A")]
		[FieldOffset(Offset = "0x10")]
		public string versionId;

		// Token: 0x04008C4B RID: 35915
		[Token(Token = "0x4008C4B")]
		[FieldOffset(Offset = "0x18")]
		public HotUpdateInfo.ABInfo[] abInfos;

		// Token: 0x04008C4C RID: 35916
		[Token(Token = "0x4008C4C")]
		[FieldOffset(Offset = "0x20")]
		public string manifestName;

		// Token: 0x04008C4D RID: 35917
		[Token(Token = "0x4008C4D")]
		[FieldOffset(Offset = "0x28")]
		public string manifestVersion;

		// Token: 0x04008C4E RID: 35918
		[Token(Token = "0x4008C4E")]
		[FieldOffset(Offset = "0x30")]
		public HotUpdateInfo.ABInfo[] packInfos;

		// Token: 0x04008C4F RID: 35919
		[Token(Token = "0x4008C4F")]
		[FieldOffset(Offset = "0x38")]
		[JsonIgnore]
		public HotUpdateInfo.Source source;

		// Token: 0x04008C50 RID: 35920
		[Token(Token = "0x4008C50")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HotUpdateInfo EMPTY;

		// Token: 0x0200173E RID: 5950
		[Token(Token = "0x200173E")]
		[Flags]
		public enum ABMetaFlag
		{
			// Token: 0x04008C52 RID: 35922
			[Token(Token = "0x4008C52")]
			NONE = 0,
			// Token: 0x04008C53 RID: 35923
			[Token(Token = "0x4008C53")]
			IGNORE_MD5 = 1
		}

		// Token: 0x0200173F RID: 5951
		[Token(Token = "0x200173F")]
		public enum Source
		{
			// Token: 0x04008C55 RID: 35925
			[Token(Token = "0x4008C55")]
			NONE,
			// Token: 0x04008C56 RID: 35926
			[Token(Token = "0x4008C56")]
			LOCAL,
			// Token: 0x04008C57 RID: 35927
			[Token(Token = "0x4008C57")]
			RES_CACHE
		}

		// Token: 0x02001740 RID: 5952
		[Token(Token = "0x2001740")]
		public struct ABInfo
		{
			// Token: 0x17001009 RID: 4105
			// (get) Token: 0x06009614 RID: 38420 RVA: 0x0003A7B8 File Offset: 0x000389B8
			[Token(Token = "0x17001009")]
			[JsonIgnore]
			public bool isValid
			{
				[Token(Token = "0x6009614")]
				[Address(RVA = "0x1B18570", Offset = "0x1B17170", VA = "0x181B18570")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009615 RID: 38421 RVA: 0x0003A7D0 File Offset: 0x000389D0
			[Token(Token = "0x6009615")]
			[Address(RVA = "0x30FF560", Offset = "0x30FE160", VA = "0x1830FF560")]
			public bool CheckMeta(HotUpdateInfo.ABMetaFlag target)
			{
				return default(bool);
			}

			// Token: 0x06009616 RID: 38422 RVA: 0x0003A7E8 File Offset: 0x000389E8
			[Token(Token = "0x6009616")]
			[Address(RVA = "0x1FF9BF0", Offset = "0x1FF87F0", VA = "0x181FF9BF0")]
			public bool ShouldSerializepackId()
			{
				return default(bool);
			}

			// Token: 0x06009617 RID: 38423 RVA: 0x0003A800 File Offset: 0x00038A00
			[Token(Token = "0x6009617")]
			[Address(RVA = "0x1FFE4D0", Offset = "0x1FFD0D0", VA = "0x181FFE4D0")]
			public bool ShouldSerializetypeHash()
			{
				return default(bool);
			}

			// Token: 0x06009618 RID: 38424 RVA: 0x0003A818 File Offset: 0x00038A18
			[Token(Token = "0x6009618")]
			[Address(RVA = "0x30FF570", Offset = "0x30FE170", VA = "0x1830FF570")]
			public bool ShouldSerializecat()
			{
				return default(bool);
			}

			// Token: 0x06009619 RID: 38425 RVA: 0x0003A830 File Offset: 0x00038A30
			[Token(Token = "0x6009619")]
			[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
			public bool ShouldSerializetype()
			{
				return default(bool);
			}

			// Token: 0x0600961A RID: 38426 RVA: 0x0003A848 File Offset: 0x00038A48
			[Token(Token = "0x600961A")]
			[Address(RVA = "0x30FF590", Offset = "0x30FE190", VA = "0x1830FF590")]
			public bool ShouldSerializemeta()
			{
				return default(bool);
			}

			// Token: 0x0600961B RID: 38427 RVA: 0x0003A860 File Offset: 0x00038A60
			[Token(Token = "0x600961B")]
			[Address(RVA = "0x30FF580", Offset = "0x30FE180", VA = "0x1830FF580")]
			public bool ShouldSerializecode()
			{
				return default(bool);
			}

			// Token: 0x04008C58 RID: 35928
			[Token(Token = "0x4008C58")]
			[FieldOffset(Offset = "0x0")]
			[JsonIgnore]
			public static readonly HotUpdateInfo.ABInfo EMPTY;

			// Token: 0x04008C59 RID: 35929
			[Token(Token = "0x4008C59")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04008C5A RID: 35930
			[Token(Token = "0x4008C5A")]
			[FieldOffset(Offset = "0x8")]
			public string hash;

			// Token: 0x04008C5B RID: 35931
			[Token(Token = "0x4008C5B")]
			[FieldOffset(Offset = "0x10")]
			public string md5;

			// Token: 0x04008C5C RID: 35932
			[Token(Token = "0x4008C5C")]
			[FieldOffset(Offset = "0x18")]
			public long totalSize;

			// Token: 0x04008C5D RID: 35933
			[Token(Token = "0x4008C5D")]
			[FieldOffset(Offset = "0x20")]
			public long abSize;

			// Token: 0x04008C5E RID: 35934
			[Token(Token = "0x4008C5E")]
			[FieldOffset(Offset = "0x28")]
			public string type;

			// Token: 0x04008C5F RID: 35935
			[Token(Token = "0x4008C5F")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty(PropertyName = "thash")]
			public string typeHash;

			// Token: 0x04008C60 RID: 35936
			[Token(Token = "0x4008C60")]
			[FieldOffset(Offset = "0x38")]
			[JsonProperty(PropertyName = "pid")]
			public string packId;

			// Token: 0x04008C61 RID: 35937
			[Token(Token = "0x4008C61")]
			[FieldOffset(Offset = "0x40")]
			[JsonProperty(PropertyName = "cid")]
			public int code;

			// Token: 0x04008C62 RID: 35938
			[Token(Token = "0x4008C62")]
			[FieldOffset(Offset = "0x44")]
			public int cat;

			// Token: 0x04008C63 RID: 35939
			[Token(Token = "0x4008C63")]
			[FieldOffset(Offset = "0x48")]
			public int meta;
		}
	}
}
