using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200398A RID: 14730
	[Token(Token = "0x200398A")]
	[Obsolete("Use 'LoopScrollAdapter<ViewHolder, DataType>' instead")]
	public abstract class RecycleLoopScrollAdapter<ViewHolder, DataType> : LoopScrollAdapter<ViewHolder, DataType> where ViewHolder : new()
	{
		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x060174B3 RID: 95411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037C3")]
		public GameObjectPool objectPool
		{
			[Token(Token = "0x60174B3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x060174B4 RID: 95412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037C4")]
		protected Transform objectPoolContainer
		{
			[Token(Token = "0x60174B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060174B5 RID: 95413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60174B5")]
		public sealed override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060174B6 RID: 95414
		[Token(Token = "0x60174B6")]
		protected abstract GameObject ViewConstructor(GameObjectPool objectPool);

		// Token: 0x060174B7 RID: 95415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174B7")]
		protected RecycleLoopScrollAdapter()
		{
		}

		// Token: 0x0401C1EC RID: 115180
		[Token(Token = "0x401C1EC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Tooltip("Item container used by the game object pool")]
		private Transform _objectPoolContainer;

		// Token: 0x0401C1ED RID: 115181
		[Token(Token = "0x401C1ED")]
		[FieldOffset(Offset = "0x0")]
		private GameObjectPool m_pool;
	}
}
