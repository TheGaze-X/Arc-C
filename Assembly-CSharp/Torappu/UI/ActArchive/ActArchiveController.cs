using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AF2 RID: 27378
	[Token(Token = "0x2006AF2")]
	public abstract class ActArchiveController : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005C86 RID: 23686
		// (get) Token: 0x06027257 RID: 160343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C86")]
		public ActArchiveResHolder resHolder
		{
			[Token(Token = "0x6027257")]
			[Address(RVA = "0x224B4E0", Offset = "0x224A0E0", VA = "0x18224B4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027258 RID: 160344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027258")]
		[Address(RVA = "0x224B060", Offset = "0x2249C60", VA = "0x18224B060", Slot = "4")]
		public virtual void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x06027259 RID: 160345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027259")]
		[Address(RVA = "0x224B210", Offset = "0x2249E10", VA = "0x18224B210", Slot = "5")]
		public virtual void OnEnter()
		{
		}

		// Token: 0x0602725A RID: 160346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602725A")]
		[Address(RVA = "0x224B2C0", Offset = "0x2249EC0", VA = "0x18224B2C0", Slot = "6")]
		public virtual void OnExit()
		{
		}

		// Token: 0x0602725B RID: 160347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602725B")]
		[Address(RVA = "0x224B3D0", Offset = "0x2249FD0", VA = "0x18224B3D0", Slot = "7")]
		public virtual IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x0602725C RID: 160348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602725C")]
		[Address(RVA = "0x224B000", Offset = "0x2249C00", VA = "0x18224B000", Slot = "8")]
		public virtual void BeforePageExit()
		{
		}

		// Token: 0x0602725D RID: 160349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602725D")]
		[Address(RVA = "0x224B370", Offset = "0x2249F70", VA = "0x18224B370", Slot = "9")]
		public virtual void OnItemClick(string funcId)
		{
		}

		// Token: 0x17005C87 RID: 23687
		// (get) Token: 0x0602725E RID: 160350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C87")]
		public ActArchiveTopController topController
		{
			[Token(Token = "0x602725E")]
			[Address(RVA = "0x224B5D0", Offset = "0x224A1D0", VA = "0x18224B5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602725F RID: 160351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602725F")]
		[Address(RVA = "0x224B480", Offset = "0x224A080", VA = "0x18224B480")]
		protected ActArchiveController()
		{
		}

		// Token: 0x0403760F RID: 226831
		[Token(Token = "0x403760F")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public ActArchiveProxy proxy;

		// Token: 0x04037610 RID: 226832
		[Token(Token = "0x4037610")]
		[FieldOffset(Offset = "0x20")]
		private ActArchiveResHolder m_resHolder;

		// Token: 0x04037611 RID: 226833
		[Token(Token = "0x4037611")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActArchiveTopController _topHolderPrefab;

		// Token: 0x04037612 RID: 226834
		[Token(Token = "0x4037612")]
		[FieldOffset(Offset = "0x30")]
		private ActArchiveTopController m_topController;

		// Token: 0x04037613 RID: 226835
		[Token(Token = "0x4037613")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_resHolder;

		// Token: 0x04037614 RID: 226836
		[Token(Token = "0x4037614")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037615 RID: 226837
		[Token(Token = "0x4037615")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04037616 RID: 226838
		[Token(Token = "0x4037616")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04037617 RID: 226839
		[Token(Token = "0x4037617")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04037618 RID: 226840
		[Token(Token = "0x4037618")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_BeforePageExit;

		// Token: 0x04037619 RID: 226841
		[Token(Token = "0x4037619")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403761A RID: 226842
		[Token(Token = "0x403761A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_topController;

		// Token: 0x0403761B RID: 226843
		[Token(Token = "0x403761B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
