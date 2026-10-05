using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Notification
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	public abstract class NotifyViewHost : IHotfixable
	{
		// Token: 0x06000BEB RID: 3051 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x5571000", Offset = "0x556FC00", VA = "0x185571000")]
		public void Tick()
		{
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00008054 File Offset: 0x00006254
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x5570EA0", Offset = "0x556FAA0", VA = "0x185570EA0")]
		public bool HasPendingNotifyRecords()
		{
			return default(bool);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0000806C File Offset: 0x0000626C
		[Token(Token = "0x6000BED")]
		public bool AddToast<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options) where ViewType : NotifyView where ParamType : NotifyViewParam
		{
			return default(bool);
		}

		// Token: 0x06000BEE RID: 3054
		[Token(Token = "0x6000BEE")]
		protected abstract long CurrentTicks();

		// Token: 0x06000BEF RID: 3055
		[Token(Token = "0x6000BEF")]
		protected abstract NotifyViewLayouter SelectLayouter<ViewType, ParamType>(NotifyViewOptions<ViewType, ParamType> options) where ViewType : NotifyView where ParamType : NotifyViewParam;

		// Token: 0x06000BF0 RID: 3056
		[Token(Token = "0x6000BF0")]
		public abstract Coroutine StartCoroutine(IEnumerator routine);

		// Token: 0x06000BF1 RID: 3057
		[Token(Token = "0x6000BF1")]
		public abstract GameObject LoadPrefabFromResource(string resPath);

		// Token: 0x06000BF2 RID: 3058
		[Token(Token = "0x6000BF2")]
		protected abstract void UnloadUnusedPrefabs();

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x55710A0", Offset = "0x556FCA0", VA = "0x1855710A0")]
		public void UINotifyView_CancelAutoHide(int viewId)
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x55711F0", Offset = "0x556FDF0", VA = "0x1855711F0")]
		public void UINotifyView_ManualHide(int viewId)
		{
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00008084 File Offset: 0x00006284
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x5571170", Offset = "0x556FD70", VA = "0x185571170")]
		public bool UINotifyView_CheckIfShowing(int viewId)
		{
			return default(bool);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x5570F20", Offset = "0x556FB20", VA = "0x185570F20")]
		public void NotifyViewLayouter_BeforeManualDestroyView(int viewId)
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x55712B0", Offset = "0x556FEB0", VA = "0x1855712B0")]
		private void _CancelToastAutoHide(int viewId)
		{
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x55713F0", Offset = "0x556FFF0", VA = "0x1855713F0")]
		private void _ManualHideToast(int viewId)
		{
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x5571340", Offset = "0x556FF40", VA = "0x185571340")]
		private NotifyViewHost.NotifyRecord _FindToastRecord(int viewId)
		{
			return null;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0000809C File Offset: 0x0000629C
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x5571550", Offset = "0x5570150", VA = "0x185571550")]
		private bool _ModifyToastEndTicks(int viewId, long endTicks)
		{
			return default(bool);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x5571600", Offset = "0x5570200", VA = "0x185571600")]
		private void _UpdateRecords()
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x5571480", Offset = "0x5570080", VA = "0x185571480")]
		private void _MarkNotifyRecordAsRemoved(NotifyViewHost.NotifyRecord record)
		{
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x000080B4 File Offset: 0x000062B4
		[Token(Token = "0x6000BFD")]
		private bool _LoadPrefabFromResource<ViewType>(string resPath, out ViewType prefabView, out GameObject prefabAsset) where ViewType : Component
		{
			return default(bool);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x5570BD0", Offset = "0x556F7D0", VA = "0x185570BD0")]
		protected void CollectUsedDynLoadedPrefabs(ICollection<UnityEngine.Object> usedAssets)
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x5571910", Offset = "0x5570510", VA = "0x185571910")]
		protected NotifyViewHost()
		{
		}

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		private const float DEFAULT_DURATION = 3f;

		// Token: 0x04000B9D RID: 2973
		[Token(Token = "0x4000B9D")]
		private const int MAX_TOAST_COUNT = 5;

		// Token: 0x04000B9E RID: 2974
		[Token(Token = "0x4000B9E")]
		private const long TICKS_PER_SECOND = 10000000L;

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x10")]
		private List<NotifyViewHost.NotifyRecord> m_records;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x18")]
		private long m_nextUpdateTicks;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<int, NotifyViewHost.NotifyRecord> m_removedRecords;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Tick;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_HasPendingNotifyRecords;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate26 __Hotfix0_UINotifyView_CancelAutoHide;

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate26 __Hotfix0_UINotifyView_ManualHide;

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate247 __Hotfix0_UINotifyView_CheckIfShowing;

		// Token: 0x04000BA7 RID: 2983
		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate26 __Hotfix0_NotifyViewLayouter_BeforeManualDestroyView;

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate26 __Hotfix0__CancelToastAutoHide;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate26 __Hotfix0__ManualHideToast;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate248 __Hotfix0__ModifyToastEndTicks;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate1 __Hotfix0__UpdateRecords;

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate0 __Hotfix0__MarkNotifyRecordAsRemoved;

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate0 __Hotfix0_CollectUsedDynLoadedPrefabs;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x020001FC RID: 508
		[Token(Token = "0x20001FC")]
		protected class NotifyRecord : IComparable<NotifyViewHost.NotifyRecord>
		{
			// Token: 0x06000C00 RID: 3072 RVA: 0x000080CC File Offset: 0x000062CC
			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x5570B30", Offset = "0x556F730", VA = "0x185570B30", Slot = "4")]
			public int CompareTo(NotifyViewHost.NotifyRecord other)
			{
				return 0;
			}

			// Token: 0x06000C01 RID: 3073 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NotifyRecord()
			{
			}

			// Token: 0x04000BAF RID: 2991
			[Token(Token = "0x4000BAF")]
			[FieldOffset(Offset = "0x10")]
			public int viewId;

			// Token: 0x04000BB0 RID: 2992
			[Token(Token = "0x4000BB0")]
			[FieldOffset(Offset = "0x18")]
			public long endTicks;

			// Token: 0x04000BB1 RID: 2993
			[Token(Token = "0x4000BB1")]
			[FieldOffset(Offset = "0x20")]
			public NotifyViewPriority priority;

			// Token: 0x04000BB2 RID: 2994
			[Token(Token = "0x4000BB2")]
			[FieldOffset(Offset = "0x28")]
			public string signature;

			// Token: 0x04000BB3 RID: 2995
			[Token(Token = "0x4000BB3")]
			[FieldOffset(Offset = "0x30")]
			public NotifyViewLayouter layouter;

			// Token: 0x04000BB4 RID: 2996
			[Token(Token = "0x4000BB4")]
			[FieldOffset(Offset = "0x38")]
			public GameObject prefab;

			// Token: 0x04000BB5 RID: 2997
			[Token(Token = "0x4000BB5")]
			[FieldOffset(Offset = "0x40")]
			public bool isDynLoaded;
		}
	}
}
