using System;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037E7 RID: 14311
	[Token(Token = "0x20037E7")]
	public abstract class UICommonSortingInfoStorage<T> : IHotfixable where T : UnityEngine.Object
	{
		// Token: 0x06016AF3 RID: 92915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AF3")]
		protected UICommonSortingInfoStorage()
		{
		}

		// Token: 0x06016AF4 RID: 92916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AF4")]
		public void InitSortingInfo(SortingInfo sortingInfo)
		{
		}

		// Token: 0x06016AF5 RID: 92917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AF5")]
		public void AddTrace(T trace)
		{
		}

		// Token: 0x06016AF6 RID: 92918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AF6")]
		public void RemoveTrace(T trace)
		{
		}

		// Token: 0x06016AF7 RID: 92919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AF7")]
		public void AdjustSortingInfo(SortingInfo sortingInfo)
		{
		}

		// Token: 0x06016AF8 RID: 92920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AF8")]
		public void RestoreSortingInfo()
		{
		}

		// Token: 0x06016AF9 RID: 92921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AF9")]
		public void ClearTrace()
		{
		}

		// Token: 0x06016AFA RID: 92922
		[Token(Token = "0x6016AFA")]
		protected abstract string _GetSortingLayerName(T trace);

		// Token: 0x06016AFB RID: 92923
		[Token(Token = "0x6016AFB")]
		protected abstract void _SetSortingLayerName(T trace, string sortingLayerName);

		// Token: 0x06016AFC RID: 92924
		[Token(Token = "0x6016AFC")]
		protected abstract int _GetSortingOrder(T trace);

		// Token: 0x06016AFD RID: 92925
		[Token(Token = "0x6016AFD")]
		protected abstract void _SetSortingOrder(T trace, int sortingOrder);

		// Token: 0x0401B576 RID: 111990
		[Token(Token = "0x401B576")]
		[FieldOffset(Offset = "0x0")]
		private int m_initSortingLayerBase;

		// Token: 0x0401B577 RID: 111991
		[Token(Token = "0x401B577")]
		[FieldOffset(Offset = "0x0")]
		protected LocalGenericPool<SortingInfoCollection> m_sortingInfoPool;

		// Token: 0x0401B578 RID: 111992
		[Token(Token = "0x401B578")]
		[FieldOffset(Offset = "0x0")]
		protected ListDict<T, SortingInfoCollection> m_cachedSortingInfo;

		// Token: 0x0401B579 RID: 111993
		[Token(Token = "0x401B579")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B57A RID: 111994
		[Token(Token = "0x401B57A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitSortingInfo;

		// Token: 0x0401B57B RID: 111995
		[Token(Token = "0x401B57B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddTrace;

		// Token: 0x0401B57C RID: 111996
		[Token(Token = "0x401B57C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RemoveTrace;

		// Token: 0x0401B57D RID: 111997
		[Token(Token = "0x401B57D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AdjustSortingInfo;

		// Token: 0x0401B57E RID: 111998
		[Token(Token = "0x401B57E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RestoreSortingInfo;

		// Token: 0x0401B57F RID: 111999
		[Token(Token = "0x401B57F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ClearTrace;
	}
}
