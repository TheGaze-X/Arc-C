using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F50 RID: 16208
	[Token(Token = "0x2003F50")]
	public class SiracusaLocalCache : Singleton<SiracusaLocalCache>
	{
		// Token: 0x0601928F RID: 103055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601928F")]
		[Address(RVA = "0x11D0740", Offset = "0x11CF340", VA = "0x1811D0740")]
		private SiracusaLocalCache()
		{
		}

		// Token: 0x06019290 RID: 103056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019290")]
		[Address(RVA = "0x11D0440", Offset = "0x11CF040", VA = "0x1811D0440")]
		private SiracusaLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06019291 RID: 103057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019291")]
		[Address(RVA = "0x11D0280", Offset = "0x11CEE80", VA = "0x1811D0280")]
		private SiracusaLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x06019292 RID: 103058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019292")]
		[Address(RVA = "0x11D0580", Offset = "0x11CF180", VA = "0x1811D0580")]
		private SiracusaLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x06019293 RID: 103059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019293")]
		[Address(RVA = "0x11D06B0", Offset = "0x11CF2B0", VA = "0x1811D06B0")]
		private void _SaveData(SiracusaLocalCache.ActData data)
		{
		}

		// Token: 0x06019294 RID: 103060 RVA: 0x0009D1E8 File Offset: 0x0009B3E8
		[Token(Token = "0x6019294")]
		[Address(RVA = "0x11CFDE0", Offset = "0x11CE9E0", VA = "0x1811CFDE0")]
		public bool GetIsPlayerEntryGroupFolded(string actId)
		{
			return default(bool);
		}

		// Token: 0x06019295 RID: 103061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019295")]
		[Address(RVA = "0x11D00A0", Offset = "0x11CECA0", VA = "0x1811D00A0")]
		public void SetIsPlayerEntryGroupFolded(string actId, bool isFolded)
		{
		}

		// Token: 0x06019296 RID: 103062 RVA: 0x0009D200 File Offset: 0x0009B400
		[Token(Token = "0x6019296")]
		[Address(RVA = "0x11D0160", Offset = "0x11CED60", VA = "0x1811D0160")]
		public bool TryGetLastBigMapPosition(string actId, out Vector2 lastPos)
		{
			return default(bool);
		}

		// Token: 0x06019297 RID: 103063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019297")]
		[Address(RVA = "0x11CFF60", Offset = "0x11CEB60", VA = "0x1811CFF60")]
		public void SaveLastBigMapPosition(string actId, Vector2 lastPos)
		{
		}

		// Token: 0x0401F30B RID: 127755
		[Token(Token = "0x401F30B")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<SiracusaLocalCache.ActData> m_memData;

		// Token: 0x0401F30C RID: 127756
		[Token(Token = "0x401F30C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401F30D RID: 127757
		[Token(Token = "0x401F30D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0401F30E RID: 127758
		[Token(Token = "0x401F30E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x0401F30F RID: 127759
		[Token(Token = "0x401F30F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x0401F310 RID: 127760
		[Token(Token = "0x401F310")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0401F311 RID: 127761
		[Token(Token = "0x401F311")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetIsPlayerEntryGroupFolded;

		// Token: 0x0401F312 RID: 127762
		[Token(Token = "0x401F312")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetIsPlayerEntryGroupFolded;

		// Token: 0x0401F313 RID: 127763
		[Token(Token = "0x401F313")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryGetLastBigMapPosition;

		// Token: 0x0401F314 RID: 127764
		[Token(Token = "0x401F314")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveLastBigMapPosition;

		// Token: 0x02003F51 RID: 16209
		[Token(Token = "0x2003F51")]
		private class DataInAct
		{
			// Token: 0x06019298 RID: 103064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019298")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x0401F315 RID: 127765
			[Token(Token = "0x401F315")]
			[FieldOffset(Offset = "0x10")]
			public bool groupEntryFolded;

			// Token: 0x0401F316 RID: 127766
			[Token(Token = "0x401F316")]
			[FieldOffset(Offset = "0x18")]
			public float[] lastBigMapPos;
		}

		// Token: 0x02003F52 RID: 16210
		[Token(Token = "0x2003F52")]
		private class ActData
		{
			// Token: 0x06019299 RID: 103065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019299")]
			[Address(RVA = "0x11C4120", Offset = "0x11C2D20", VA = "0x1811C4120")]
			public ActData()
			{
			}

			// Token: 0x0401F317 RID: 127767
			[Token(Token = "0x401F317")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0401F318 RID: 127768
			[Token(Token = "0x401F318")]
			[FieldOffset(Offset = "0x18")]
			public SiracusaLocalCache.DataInAct dataInAct;
		}
	}
}
