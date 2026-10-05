using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ADB RID: 27355
	[Token(Token = "0x2006ADB")]
	public static class ActArchiveUtils
	{
		// Token: 0x0602720A RID: 160266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602720A")]
		[Address(RVA = "0x224E800", Offset = "0x224D400", VA = "0x18224E800")]
		public static void SetSkinImage(Image image, Sprite sprite)
		{
		}

		// Token: 0x0602720B RID: 160267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602720B")]
		[Address(RVA = "0x224E5F0", Offset = "0x224D1F0", VA = "0x18224E5F0")]
		public static string GetLocalTrackType(string archiveId)
		{
			return null;
		}

		// Token: 0x0602720C RID: 160268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602720C")]
		[Address(RVA = "0x224E650", Offset = "0x224D250", VA = "0x18224E650")]
		public static Sprite LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0403757F RID: 226687
		[Token(Token = "0x403757F")]
		public const string KEY_ARCHIVE_ID = "key_archive_id";

		// Token: 0x04037580 RID: 226688
		[Token(Token = "0x4037580")]
		public const string KEY_ARCHIVE_BGM_INST_ID_ALIAS = "key_archive_bgm_inst_id_alias";

		// Token: 0x04037581 RID: 226689
		[Token(Token = "0x4037581")]
		public const string KEY_ARCHIVE_PLUGIN_TYPE = "key_archive_plugin_type";

		// Token: 0x04037582 RID: 226690
		[Token(Token = "0x4037582")]
		public const string KEY_ARCHIVE_EXTRA_PASSTHROUGH_DATA = "key_archive_extra_passthrough_data";

		// Token: 0x04037583 RID: 226691
		[Token(Token = "0x4037583")]
		public const string KEY_ARCHIVE_ITEM_TYPE = "key_archive_item_type";

		// Token: 0x04037584 RID: 226692
		[Token(Token = "0x4037584")]
		public const string KEY_ARCHIVE_ITEM_ID = "key_archive_item_id";
	}
}
