using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x02001748 RID: 5960
	[Token(Token = "0x2001748")]
	public class PersistentResRecover : IHotfixable
	{
		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06009647 RID: 38471 RVA: 0x0003A8D8 File Offset: 0x00038AD8
		[Token(Token = "0x17001010")]
		public bool isCancelled
		{
			[Token(Token = "0x6009647")]
			[Address(RVA = "0x31139A0", Offset = "0x31125A0", VA = "0x1831139A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009648")]
		[Address(RVA = "0x3112A60", Offset = "0x3111660", VA = "0x183112A60")]
		public void Cancel()
		{
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06009649 RID: 38473 RVA: 0x0003A8F0 File Offset: 0x00038AF0
		// (set) Token: 0x0600964A RID: 38474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001011")]
		public KeyValuePair<int, int> progress
		{
			[Token(Token = "0x6009649")]
			[Address(RVA = "0x3113A80", Offset = "0x3112680", VA = "0x183113A80")]
			get
			{
				return default(KeyValuePair<int, int>);
			}
			[Token(Token = "0x600964A")]
			[Address(RVA = "0x3113B90", Offset = "0x3112790", VA = "0x183113B90")]
			set
			{
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x0600964B RID: 38475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001012")]
		public WaitForAsyncTask<PersistentResInfo> currentTask
		{
			[Token(Token = "0x600964B")]
			[Address(RVA = "0x3113940", Offset = "0x3112540", VA = "0x183113940")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600964C RID: 38476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600964C")]
		[Address(RVA = "0x3112B30", Offset = "0x3111730", VA = "0x183112B30")]
		public IEnumerator StartTaskCoroutine(PersistentResRecover.Options options)
		{
			return null;
		}

		// Token: 0x0600964D RID: 38477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600964D")]
		[Address(RVA = "0x3113600", Offset = "0x3112200", VA = "0x183113600")]
		private WaitForAsyncTask<PersistentResInfo> _StartNewTask(HotUpdateInfo localInfo)
		{
			return null;
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600964E")]
		[Address(RVA = "0x3112EE0", Offset = "0x3111AE0", VA = "0x183112EE0")]
		private PersistentResInfo _FuncWorker(List<HotUpdateInfo.ABInfo> abInfoList, HotUpdateInfo localInfo)
		{
			return null;
		}

		// Token: 0x0600964F RID: 38479 RVA: 0x0003A908 File Offset: 0x00038B08
		[Token(Token = "0x600964F")]
		[Address(RVA = "0x3112D10", Offset = "0x3111910", VA = "0x183112D10")]
		private bool _CheckIfLocalABValid(HotUpdateInfo.ABInfo abInfo)
		{
			return default(bool);
		}

		// Token: 0x06009650 RID: 38480 RVA: 0x0003A920 File Offset: 0x00038B20
		[Token(Token = "0x6009650")]
		[Address(RVA = "0x3112C10", Offset = "0x3111810", VA = "0x183112C10")]
		private bool _CheckIfLocalABExists(HotUpdateInfo.ABInfo abInfo)
		{
			return default(bool);
		}

		// Token: 0x06009651 RID: 38481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009651")]
		[Address(RVA = "0x3113870", Offset = "0x3112470", VA = "0x183113870")]
		public PersistentResRecover()
		{
		}

		// Token: 0x04008C8C RID: 35980
		[Token(Token = "0x4008C8C")]
		[FieldOffset(Offset = "0x10")]
		private string m_localResFolder;

		// Token: 0x04008C8D RID: 35981
		[Token(Token = "0x4008C8D")]
		[FieldOffset(Offset = "0x18")]
		private PersistentResRecover.Status m_status;

		// Token: 0x04008C8E RID: 35982
		[Token(Token = "0x4008C8E")]
		[FieldOffset(Offset = "0x30")]
		private object m_lock;

		// Token: 0x04008C8F RID: 35983
		[Token(Token = "0x4008C8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCancelled;

		// Token: 0x04008C90 RID: 35984
		[Token(Token = "0x4008C90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Cancel;

		// Token: 0x04008C91 RID: 35985
		[Token(Token = "0x4008C91")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x04008C92 RID: 35986
		[Token(Token = "0x4008C92")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_progress;

		// Token: 0x04008C93 RID: 35987
		[Token(Token = "0x4008C93")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_currentTask;

		// Token: 0x04008C94 RID: 35988
		[Token(Token = "0x4008C94")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StartTaskCoroutine;

		// Token: 0x04008C95 RID: 35989
		[Token(Token = "0x4008C95")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StartNewTask;

		// Token: 0x04008C96 RID: 35990
		[Token(Token = "0x4008C96")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FuncWorker;

		// Token: 0x04008C97 RID: 35991
		[Token(Token = "0x4008C97")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfLocalABValid;

		// Token: 0x04008C98 RID: 35992
		[Token(Token = "0x4008C98")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIfLocalABExists;

		// Token: 0x04008C99 RID: 35993
		[Token(Token = "0x4008C99")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001749 RID: 5961
		[Token(Token = "0x2001749")]
		private struct Status
		{
			// Token: 0x04008C9A RID: 35994
			[Token(Token = "0x4008C9A")]
			[FieldOffset(Offset = "0x0")]
			public bool isCancelled;

			// Token: 0x04008C9B RID: 35995
			[Token(Token = "0x4008C9B")]
			[FieldOffset(Offset = "0x8")]
			public WaitForAsyncTask<PersistentResInfo> asyncTask;

			// Token: 0x04008C9C RID: 35996
			[Token(Token = "0x4008C9C")]
			[FieldOffset(Offset = "0x10")]
			public int prgCurrent;

			// Token: 0x04008C9D RID: 35997
			[Token(Token = "0x4008C9D")]
			[FieldOffset(Offset = "0x14")]
			public int prgTotal;
		}

		// Token: 0x0200174A RID: 5962
		[Token(Token = "0x200174A")]
		public struct Options
		{
			// Token: 0x04008C9E RID: 35998
			[Token(Token = "0x4008C9E")]
			[FieldOffset(Offset = "0x0")]
			public Action onComplete;

			// Token: 0x04008C9F RID: 35999
			[Token(Token = "0x4008C9F")]
			[FieldOffset(Offset = "0x8")]
			public Action<int, int> onProgress;
		}
	}
}
