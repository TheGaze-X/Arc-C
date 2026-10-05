using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/StoryReviewMetaDB")]
	[Serializable]
	public class StoryReviewMetaDB : ConstTable<StoryReviewMetaTable, StoryReviewMetaDB>
	{
		// Token: 0x060061BF RID: 25023 RVA: 0x0002FE20 File Offset: 0x0002E020
		[Token(Token = "0x60061BF")]
		[Address(RVA = "0x1DFB230", Offset = "0x1DF9E30", VA = "0x181DFB230")]
		public static bool TryGetArchiveCompData(string archiveId, out ActArchiveComponentData compData)
		{
			return default(bool);
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C0")]
		[Address(RVA = "0x1DFB2F0", Offset = "0x1DF9EF0", VA = "0x181DFB2F0")]
		public StoryReviewMetaDB()
		{
		}

		// Token: 0x04002B79 RID: 11129
		[Token(Token = "0x4002B79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetArchiveCompData;

		// Token: 0x04002B7A RID: 11130
		[Token(Token = "0x4002B7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
