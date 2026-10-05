using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004AB4 RID: 19124
	[Token(Token = "0x2004AB4")]
	public static class HotUpdatePremainMockConfig
	{
		// Token: 0x0601CB98 RID: 117656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB98")]
		[Address(RVA = "0x16255B0", Offset = "0x16241B0", VA = "0x1816255B0")]
		public static void SaveConfigAndStart(HotUpdatePremainMockConfig.Config config)
		{
		}

		// Token: 0x0601CB99 RID: 117657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB99")]
		[Address(RVA = "0x1625300", Offset = "0x1623F00", VA = "0x181625300")]
		public static HotUpdatePremainViewModel.PvInfo PreparePVInfo()
		{
			return null;
		}

		// Token: 0x0601CB9A RID: 117658 RVA: 0x000A9380 File Offset: 0x000A7580
		[Token(Token = "0x601CB9A")]
		[Address(RVA = "0x1625150", Offset = "0x1623D50", VA = "0x181625150")]
		public static bool IsHacked()
		{
			return default(bool);
		}

		// Token: 0x0601CB9B RID: 117659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB9B")]
		[Address(RVA = "0x16253A0", Offset = "0x1623FA0", VA = "0x1816253A0")]
		public static List<HotUpdatePremainViewModel.PicInfo> PreparePicInfo()
		{
			return null;
		}

		// Token: 0x0601CB9C RID: 117660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB9C")]
		[Address(RVA = "0x1625170", Offset = "0x1623D70", VA = "0x181625170")]
		public static HotUpdatePremainMockConfig.Config LoadFromCache()
		{
			return null;
		}

		// Token: 0x0601CB9D RID: 117661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB9D")]
		[Address(RVA = "0x1625670", Offset = "0x1624270", VA = "0x181625670")]
		private static void _SaveToCache(HotUpdatePremainMockConfig.Config config)
		{
		}

		// Token: 0x04025B55 RID: 154453
		[Token(Token = "0x4025B55")]
		private const string CACHE_NAME = "PermainConfig";

		// Token: 0x02004AB5 RID: 19125
		[Token(Token = "0x2004AB5")]
		public class PremainPic
		{
			// Token: 0x0601CB9E RID: 117662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB9E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PremainPic()
			{
			}

			// Token: 0x04025B56 RID: 154454
			[Token(Token = "0x4025B56")]
			[FieldOffset(Offset = "0x10")]
			public string picId;

			// Token: 0x04025B57 RID: 154455
			[Token(Token = "0x4025B57")]
			[FieldOffset(Offset = "0x18")]
			public string logoId;
		}

		// Token: 0x02004AB6 RID: 19126
		[Token(Token = "0x2004AB6")]
		public class Config
		{
			// Token: 0x0601CB9F RID: 117663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB9F")]
			[Address(RVA = "0x1621320", Offset = "0x161FF20", VA = "0x181621320")]
			public Config()
			{
			}

			// Token: 0x04025B58 RID: 154456
			[Token(Token = "0x4025B58")]
			[FieldOffset(Offset = "0x10")]
			public bool isActive;

			// Token: 0x04025B59 RID: 154457
			[Token(Token = "0x4025B59")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("视频ID")]
			public string videoId;

			// Token: 0x04025B5A RID: 154458
			[Token(Token = "0x4025B5A")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("图片ID")]
			public List<HotUpdatePremainMockConfig.PremainPic> picIds;
		}
	}
}
