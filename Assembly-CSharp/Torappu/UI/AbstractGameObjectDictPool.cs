using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003480 RID: 13440
	[Token(Token = "0x2003480")]
	public abstract class AbstractGameObjectDictPool<TPrefab, TInst> : IHotfixable where TPrefab : Component where TInst : class
	{
		// Token: 0x06015714 RID: 87828
		[Token(Token = "0x6015714")]
		protected abstract void SetInstActive(TInst inst, bool active);

		// Token: 0x06015715 RID: 87829
		[Token(Token = "0x6015715")]
		protected abstract bool ContainsKey(string key);

		// Token: 0x06015716 RID: 87830
		[Token(Token = "0x6015716")]
		protected abstract IEnumerable<string> IterKeys();

		// Token: 0x06015717 RID: 87831
		[Token(Token = "0x6015717")]
		protected abstract TPrefab GetPrefab(string key);

		// Token: 0x06015718 RID: 87832
		[Token(Token = "0x6015718")]
		protected abstract TInst Instantiate(string key, TPrefab prefab);

		// Token: 0x06015719 RID: 87833
		[Token(Token = "0x6015719")]
		protected abstract void Render(string key, TInst obj);

		// Token: 0x0601571A RID: 87834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601571A")]
		protected virtual void OnAllocate(string key, TInst obj)
		{
		}

		// Token: 0x0601571B RID: 87835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601571B")]
		protected virtual void OnRecycle(string key, TInst obj)
		{
		}

		// Token: 0x0601571C RID: 87836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601571C")]
		private void _RecycleObject(bool isForce)
		{
		}

		// Token: 0x0601571D RID: 87837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601571D")]
		private TInst _FetchNewInstance(TPrefab prefab, string key)
		{
			return null;
		}

		// Token: 0x0601571E RID: 87838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601571E")]
		private TInst _GetInstance(string key)
		{
			return null;
		}

		// Token: 0x0601571F RID: 87839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601571F")]
		public void OnDataChanged()
		{
		}

		// Token: 0x06015720 RID: 87840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015720")]
		public void ForceRecycleAll()
		{
		}

		// Token: 0x06015721 RID: 87841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015721")]
		public TInst GetItemView(string key)
		{
			return null;
		}

		// Token: 0x06015722 RID: 87842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015722")]
		protected AbstractGameObjectDictPool()
		{
		}

		// Token: 0x04019AC0 RID: 105152
		[Token(Token = "0x4019AC0")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, Dictionary<string, TInst>> m_objects;

		// Token: 0x04019AC1 RID: 105153
		[Token(Token = "0x4019AC1")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, List<TInst>> m_objectPool;

		// Token: 0x04019AC2 RID: 105154
		[Token(Token = "0x4019AC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04019AC3 RID: 105155
		[Token(Token = "0x4019AC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04019AC4 RID: 105156
		[Token(Token = "0x4019AC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RecycleObject;

		// Token: 0x04019AC5 RID: 105157
		[Token(Token = "0x4019AC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__FetchNewInstance;

		// Token: 0x04019AC6 RID: 105158
		[Token(Token = "0x4019AC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetInstance;

		// Token: 0x04019AC7 RID: 105159
		[Token(Token = "0x4019AC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataChanged;

		// Token: 0x04019AC8 RID: 105160
		[Token(Token = "0x4019AC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ForceRecycleAll;

		// Token: 0x04019AC9 RID: 105161
		[Token(Token = "0x4019AC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetItemView;

		// Token: 0x04019ACA RID: 105162
		[Token(Token = "0x4019ACA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
