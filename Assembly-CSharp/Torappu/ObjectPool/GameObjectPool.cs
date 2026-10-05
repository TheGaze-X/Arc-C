using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.ObjectPool
{
	// Token: 0x0200146D RID: 5229
	[Token(Token = "0x200146D")]
	public class GameObjectPool
	{
		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x060078F1 RID: 30961 RVA: 0x000366D8 File Offset: 0x000348D8
		[Token(Token = "0x17000E70")]
		public int availableUnusedCnt
		{
			[Token(Token = "0x60078F1")]
			[Address(RVA = "0x2638EE0", Offset = "0x2637AE0", VA = "0x182638EE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x060078F2 RID: 30962 RVA: 0x000366F0 File Offset: 0x000348F0
		[Token(Token = "0x17000E71")]
		public int allLoadedCnt
		{
			[Token(Token = "0x60078F2")]
			[Address(RVA = "0x2638E80", Offset = "0x2637A80", VA = "0x182638E80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x060078F3 RID: 30963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E72")]
		public Transform parentTransform
		{
			[Token(Token = "0x60078F3")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x060078F4 RID: 30964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E73")]
		public IPoolReleasePolicy releasePolicy
		{
			[Token(Token = "0x60078F4")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x060078F5 RID: 30965 RVA: 0x00036708 File Offset: 0x00034908
		[Token(Token = "0x17000E74")]
		public bool isInUse
		{
			[Token(Token = "0x60078F5")]
			[Address(RVA = "0x2638F20", Offset = "0x2637B20", VA = "0x182638F20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078F6")]
		[Address(RVA = "0x2638CD0", Offset = "0x26378D0", VA = "0x182638CD0")]
		public GameObjectPool(Func<GameObjectPool, GameObject> constructor, [Optional] GameObjectPool.Options options)
		{
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078F7")]
		[Address(RVA = "0x26377A0", Offset = "0x26363A0", VA = "0x1826377A0")]
		public GameObject Allocate(Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x00036720 File Offset: 0x00034920
		[Token(Token = "0x60078F8")]
		[Address(RVA = "0x2638430", Offset = "0x2637030", VA = "0x182638430")]
		public bool Recycle(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078F9")]
		[Address(RVA = "0x26381F0", Offset = "0x2636DF0", VA = "0x1826381F0")]
		public void RecoverAfterSceneReloaded(bool allowComplement)
		{
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x00036738 File Offset: 0x00034938
		[Token(Token = "0x60078FA")]
		[Address(RVA = "0x2637A90", Offset = "0x2636690", VA = "0x182637A90")]
		public bool ClearIfNotUsed()
		{
			return default(bool);
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FB")]
		[Address(RVA = "0x2637B90", Offset = "0x2636790", VA = "0x182637B90")]
		public void ComplementToPreloadSize()
		{
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078FC")]
		[Address(RVA = "0x26388E0", Offset = "0x26374E0", VA = "0x1826388E0")]
		private GameObject _PickOneAndForceReuse()
		{
			return null;
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FD")]
		[Address(RVA = "0x2637F60", Offset = "0x2636B60", VA = "0x182637F60")]
		public void PrunePool()
		{
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FE")]
		[Address(RVA = "0x26387F0", Offset = "0x26373F0", VA = "0x1826387F0")]
		private void _LoadToSize(int size)
		{
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078FF")]
		[Address(RVA = "0x2638B10", Offset = "0x2637710", VA = "0x182638B10")]
		private void _RecycleInternal(GameObject obj)
		{
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007900")]
		[Address(RVA = "0x2638C10", Offset = "0x2637810", VA = "0x182638C10")]
		private void _SendNotification(GameObject obj, NotificationEvent ev)
		{
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007901")]
		[Address(RVA = "0x26385F0", Offset = "0x26371F0", VA = "0x1826385F0")]
		private GameObject _CreateNew(bool initActive = false)
		{
			return null;
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007902")]
		[Address(RVA = "0x2637BA0", Offset = "0x26367A0", VA = "0x182637BA0")]
		public void EmptyPool([Optional] Action<GameObject> preProcess)
		{
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x00036750 File Offset: 0x00034950
		[Token(Token = "0x6007903")]
		[Address(RVA = "0x2637EC0", Offset = "0x2636AC0", VA = "0x182637EC0")]
		public GameObjectPoolStats GetStats()
		{
			return default(GameObjectPoolStats);
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x00036768 File Offset: 0x00034968
		[Token(Token = "0x6007904")]
		[Address(RVA = "0x26384E0", Offset = "0x26370E0", VA = "0x1826384E0")]
		public int ReleaseUnused(int countToRelease)
		{
			return 0;
		}

		// Token: 0x0400771A RID: 30490
		[Token(Token = "0x400771A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_counter;

		// Token: 0x0400771B RID: 30491
		[Token(Token = "0x400771B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObjectPool.Options m_options;

		// Token: 0x0400771C RID: 30492
		[Token(Token = "0x400771C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> m_unusedObjs;

		// Token: 0x0400771D RID: 30493
		[Token(Token = "0x400771D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HashSet<GameObject> m_usingObjs;

		// Token: 0x0400771E RID: 30494
		[Token(Token = "0x400771E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Func<GameObjectPool, GameObject> m_constructor;

		// Token: 0x0400771F RID: 30495
		[Token(Token = "0x400771F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_lastAllocateAt;

		// Token: 0x04007720 RID: 30496
		[Token(Token = "0x4007720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_lastRecycleAt;

		// Token: 0x04007721 RID: 30497
		[Token(Token = "0x4007721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Queue<GameObject> m_pendingObjsToAutoReuse;

		// Token: 0x0200146E RID: 5230
		[Token(Token = "0x200146E")]
		public enum NotificationType
		{
			// Token: 0x04007723 RID: 30499
			[Token(Token = "0x4007723")]
			NONE,
			// Token: 0x04007724 RID: 30500
			[Token(Token = "0x4007724")]
			SEND_MESSAGE,
			// Token: 0x04007725 RID: 30501
			[Token(Token = "0x4007725")]
			BROADCAST_MESSAGE
		}

		// Token: 0x0200146F RID: 5231
		[Token(Token = "0x200146F")]
		[Serializable]
		public struct Options
		{
			// Token: 0x06007905 RID: 30981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007905")]
			[Address(RVA = "0x263D550", Offset = "0x263C150", VA = "0x18263D550")]
			public void Prepare()
			{
			}

			// Token: 0x04007726 RID: 30502
			[Token(Token = "0x4007726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public static readonly GameObjectPool.Options DEFAULT;

			// Token: 0x04007727 RID: 30503
			[Token(Token = "0x4007727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Size of objects to be preloaded when ObjectPool is created.")]
			public int preloadSize;

			// Token: 0x04007728 RID: 30504
			[Token(Token = "0x4007728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Max capacity of this ObjectPool. If it's zero, then set it to int.MaxValue.")]
			public int maxCapacity;

			// Token: 0x04007729 RID: 30505
			[Token(Token = "0x4007729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Allow pool to pick up an using object and recycle it when maxCapacity is reached.")]
			public bool allowPoolAutoReuse;

			// Token: 0x0400772A RID: 30506
			[Token(Token = "0x400772A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("Indicate which way to notify the ObjectPool events to hold objects.")]
			public GameObjectPool.NotificationType notificationType;

			// Token: 0x0400772B RID: 30507
			[Token(Token = "0x400772B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Container transform to hold this pool.")]
			public Transform container;

			// Token: 0x0400772C RID: 30508
			[Token(Token = "0x400772C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Release policy for this pool. If null, no shrinking will happen.")]
			public IPoolReleasePolicy releasePolicy;
		}
	}
}
