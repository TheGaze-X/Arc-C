using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007337 RID: 29495
	[Token(Token = "0x2007337")]
	public class Act42D0LocalCache : Singleton<Act42D0LocalCache>
	{
		// Token: 0x06029B66 RID: 170854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B66")]
		[Address(RVA = "0x2506730", Offset = "0x2505330", VA = "0x182506730")]
		private Act42D0LocalCache()
		{
		}

		// Token: 0x06029B67 RID: 170855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B67")]
		[Address(RVA = "0x2506430", Offset = "0x2505030", VA = "0x182506430")]
		private Act42D0LocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06029B68 RID: 170856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B68")]
		[Address(RVA = "0x2506270", Offset = "0x2504E70", VA = "0x182506270")]
		private Act42D0LocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x06029B69 RID: 170857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B69")]
		[Address(RVA = "0x2506570", Offset = "0x2505170", VA = "0x182506570")]
		private Act42D0LocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x06029B6A RID: 170858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B6A")]
		[Address(RVA = "0x25066A0", Offset = "0x25052A0", VA = "0x1825066A0")]
		private void _SaveData(Act42D0LocalCache.ActData data)
		{
		}

		// Token: 0x06029B6B RID: 170859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B6B")]
		[Address(RVA = "0x2505D90", Offset = "0x2504990", VA = "0x182505D90")]
		public List<string> LoadEffectSelectList(string actId, string areaId)
		{
			return null;
		}

		// Token: 0x06029B6C RID: 170860 RVA: 0x000D64A0 File Offset: 0x000D46A0
		[Token(Token = "0x6029B6C")]
		[Address(RVA = "0x2505E80", Offset = "0x2504A80", VA = "0x182505E80")]
		public bool LoadEffectShow(string actId, string areaId)
		{
			return default(bool);
		}

		// Token: 0x06029B6D RID: 170861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B6D")]
		[Address(RVA = "0x2505F70", Offset = "0x2504B70", VA = "0x182505F70")]
		public void SaveEffectSelectList(string actId, string areaId, List<string> selectEffect)
		{
		}

		// Token: 0x06029B6E RID: 170862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B6E")]
		[Address(RVA = "0x25060F0", Offset = "0x2504CF0", VA = "0x1825060F0")]
		public void SaveEffectShow(string actId, string areaId, bool isShow)
		{
		}

		// Token: 0x0403BB3F RID: 244543
		[Token(Token = "0x403BB3F")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<Act42D0LocalCache.ActData> m_memData;

		// Token: 0x0403BB40 RID: 244544
		[Token(Token = "0x403BB40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403BB41 RID: 244545
		[Token(Token = "0x403BB41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0403BB42 RID: 244546
		[Token(Token = "0x403BB42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x0403BB43 RID: 244547
		[Token(Token = "0x403BB43")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x0403BB44 RID: 244548
		[Token(Token = "0x403BB44")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0403BB45 RID: 244549
		[Token(Token = "0x403BB45")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadEffectSelectList;

		// Token: 0x0403BB46 RID: 244550
		[Token(Token = "0x403BB46")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadEffectShow;

		// Token: 0x0403BB47 RID: 244551
		[Token(Token = "0x403BB47")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SaveEffectSelectList;

		// Token: 0x0403BB48 RID: 244552
		[Token(Token = "0x403BB48")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveEffectShow;

		// Token: 0x02007338 RID: 29496
		[Token(Token = "0x2007338")]
		private class DataInAct
		{
			// Token: 0x06029B6F RID: 170863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029B6F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x0403BB49 RID: 244553
			[Token(Token = "0x403BB49")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, List<string>> effectSelectList;

			// Token: 0x0403BB4A RID: 244554
			[Token(Token = "0x403BB4A")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, bool> effectShowList;
		}

		// Token: 0x02007339 RID: 29497
		[Token(Token = "0x2007339")]
		private class ActData
		{
			// Token: 0x06029B70 RID: 170864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029B70")]
			[Address(RVA = "0x251B390", Offset = "0x2519F90", VA = "0x18251B390")]
			public ActData()
			{
			}

			// Token: 0x0403BB4B RID: 244555
			[Token(Token = "0x403BB4B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403BB4C RID: 244556
			[Token(Token = "0x403BB4C")]
			[FieldOffset(Offset = "0x18")]
			public Act42D0LocalCache.DataInAct dataInAct;
		}
	}
}
