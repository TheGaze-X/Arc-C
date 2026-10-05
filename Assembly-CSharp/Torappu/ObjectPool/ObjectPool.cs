using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.ObjectPool
{
	// Token: 0x02001474 RID: 5236
	[Token(Token = "0x2001474")]
	public class ObjectPool<T> where T : class, IReusable
	{
		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06007913 RID: 30995 RVA: 0x00036798 File Offset: 0x00034998
		[Token(Token = "0x17000E76")]
		public int availableUnusedCnt
		{
			[Token(Token = "0x6007913")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06007914 RID: 30996 RVA: 0x000367B0 File Offset: 0x000349B0
		[Token(Token = "0x17000E77")]
		public int allLoadedCnt
		{
			[Token(Token = "0x6007914")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007915")]
		public ObjectPool(Func<T> constructor, [Optional] ObjectPool<T>.Options options)
		{
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007916")]
		public T Allocate()
		{
			return null;
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x000367C8 File Offset: 0x000349C8
		[Token(Token = "0x6007917")]
		public bool Recycle(T obj)
		{
			return default(bool);
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007918")]
		public void Reset()
		{
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007919")]
		public void ClearUsingLinksOnly()
		{
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600791A")]
		private T _PickOneAndForceReuse()
		{
			return null;
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791B")]
		private void _LoadToSize(int size)
		{
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791C")]
		private void _RecycleInternal(T obj)
		{
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791D")]
		private void _SendNotification(T obj, NotificationEvent ev)
		{
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600791E")]
		private T _CreateNew()
		{
			return null;
		}

		// Token: 0x04007732 RID: 30514
		[Token(Token = "0x4007732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ObjectPool<T>.Options m_options;

		// Token: 0x04007733 RID: 30515
		[Token(Token = "0x4007733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Stack<T> m_unusedObjs;

		// Token: 0x04007734 RID: 30516
		[Token(Token = "0x4007734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HashSet<T> m_usingObjs;

		// Token: 0x04007735 RID: 30517
		[Token(Token = "0x4007735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<T> m_constructor;

		// Token: 0x04007736 RID: 30518
		[Token(Token = "0x4007736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> m_pendingObjsToAutoReuse;

		// Token: 0x02001475 RID: 5237
		[Token(Token = "0x2001475")]
		[Serializable]
		public struct Options
		{
			// Token: 0x0600791F RID: 31007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600791F")]
			public void Prepare()
			{
			}

			// Token: 0x04007737 RID: 30519
			[Token(Token = "0x4007737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Size of objects to be preloaded when ObjectPool is created.")]
			public int preloadSize;

			// Token: 0x04007738 RID: 30520
			[Token(Token = "0x4007738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Max capacity of this ObjectPool. If it's zero, then set it to int.MaxValue.")]
			public int maxCapacity;

			// Token: 0x04007739 RID: 30521
			[Token(Token = "0x4007739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Allow pool to pick up an using object and recycle it when maxCapacity is reached.")]
			public bool allowPoolAutoReuse;
		}
	}
}
