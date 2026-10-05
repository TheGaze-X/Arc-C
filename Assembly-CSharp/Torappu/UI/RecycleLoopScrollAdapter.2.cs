using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200398B RID: 14731
	[Token(Token = "0x200398B")]
	[Obsolete("Use 'LoopScrollAdapter<ViewHolder, DataType>' instead")]
	public abstract class RecycleLoopScrollAdapter : LoopScrollAdapter
	{
		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x060174B8 RID: 95416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037C5")]
		public GameObjectPool objectPool
		{
			[Token(Token = "0x60174B8")]
			[Address(RVA = "0xFAEAB0", Offset = "0xFAD6B0", VA = "0x180FAEAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x060174B9 RID: 95417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037C6")]
		protected Transform objectPoolContainer
		{
			[Token(Token = "0x60174B9")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x060174BA RID: 95418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60174BA")]
		[Address(RVA = "0xFAE5D0", Offset = "0xFAD1D0", VA = "0x180FAE5D0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060174BB RID: 95419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174BB")]
		[Address(RVA = "0xFAE690", Offset = "0xFAD290", VA = "0x180FAE690")]
		public void NotifyDataSourceChanged(bool forceRebuild = false)
		{
		}

		// Token: 0x060174BC RID: 95420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174BC")]
		[Address(RVA = "0xFAE6E0", Offset = "0xFAD2E0", VA = "0x180FAE6E0")]
		public void NotifyRebuildWithIndexWithCountChange(int startIndex)
		{
		}

		// Token: 0x060174BD RID: 95421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174BD")]
		[Address(RVA = "0xFAE7E0", Offset = "0xFAD3E0", VA = "0x180FAE7E0", Slot = "12")]
		protected virtual void OnDataSourceChanged(bool forceRebuild)
		{
		}

		// Token: 0x060174BE RID: 95422
		[Token(Token = "0x60174BE")]
		protected abstract GameObject ViewConstructor(GameObjectPool objectPool);

		// Token: 0x060174BF RID: 95423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174BF")]
		[Address(RVA = "0xFAE9C0", Offset = "0xFAD5C0", VA = "0x180FAE9C0")]
		protected RecycleLoopScrollAdapter()
		{
		}

		// Token: 0x0401C1EE RID: 115182
		[Token(Token = "0x401C1EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Item container used by the game object pool")]
		private Transform _objectPoolContainer;

		// Token: 0x0401C1EF RID: 115183
		[Token(Token = "0x401C1EF")]
		[FieldOffset(Offset = "0x48")]
		private int m_totalCountCached;

		// Token: 0x0401C1F0 RID: 115184
		[Token(Token = "0x401C1F0")]
		[FieldOffset(Offset = "0x50")]
		private GameObjectPool m_pool;
	}
}
