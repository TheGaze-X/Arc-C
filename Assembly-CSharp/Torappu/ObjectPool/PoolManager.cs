using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;

namespace Torappu.ObjectPool
{
	// Token: 0x02001476 RID: 5238
	[Token(Token = "0x2001476")]
	public class PoolManager : SingletonMonoBehaviour<PoolManager>, ISingletonNotAutoCreate
	{
		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06007920 RID: 31008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E78")]
		private new static PoolManager instance
		{
			[Token(Token = "0x6007920")]
			[Address(RVA = "0x2642D30", Offset = "0x2641930", VA = "0x182642D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06007921 RID: 31009 RVA: 0x000367E0 File Offset: 0x000349E0
		[Token(Token = "0x17000E79")]
		public bool usePoolManager
		{
			[Token(Token = "0x6007921")]
			[Address(RVA = "0x2642E60", Offset = "0x2641A60", VA = "0x182642E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E7A")]
		public AbstractAssetLoader assetLoader
		{
			[Token(Token = "0x6007922")]
			[Address(RVA = "0x2642CC0", Offset = "0x26418C0", VA = "0x182642CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06007923 RID: 31011 RVA: 0x000367F8 File Offset: 0x000349F8
		[Token(Token = "0x17000E7B")]
		public bool isUnloading
		{
			[Token(Token = "0x6007923")]
			[Address(RVA = "0x2642DE0", Offset = "0x26419E0", VA = "0x182642DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007924")]
		[Address(RVA = "0x263FA90", Offset = "0x263E690", VA = "0x18263FA90")]
		public void SetOption(PoolManager.Option option)
		{
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x00036810 File Offset: 0x00034A10
		[Token(Token = "0x6007925")]
		[Address(RVA = "0x263E290", Offset = "0x263CE90", VA = "0x18263E290")]
		public bool BattleOnly_RawRecycle(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x06007926 RID: 31014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007926")]
		[Address(RVA = "0x263FC70", Offset = "0x263E870", VA = "0x18263FC70")]
		public void UnloadPoolsWithKeptConfig(IList<PoolManager.ObjectConfig> keptConfigs)
		{
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007927")]
		[Address(RVA = "0x2642530", Offset = "0x2641130", VA = "0x182642530")]
		private void _StopUnloadIfNecessary(bool showError = false)
		{
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007928")]
		[Address(RVA = "0x2640AB0", Offset = "0x263F6B0", VA = "0x182640AB0")]
		private GameObjectPool _NewPool(PoolManager.ObjectConfig config)
		{
			return null;
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007929")]
		[Address(RVA = "0x2640C70", Offset = "0x263F870", VA = "0x182640C70")]
		private GameObjectPool _NewPool(GameObject prefab, GameObjectPool.Options options)
		{
			return null;
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600792A")]
		[Address(RVA = "0x2640FB0", Offset = "0x263FBB0", VA = "0x182640FB0")]
		private GameObjectPool _NewPool(string name, GameObjectPool.Options options)
		{
			return null;
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x00036828 File Offset: 0x00034A28
		[Token(Token = "0x600792B")]
		[Address(RVA = "0x2640330", Offset = "0x263EF30", VA = "0x182640330")]
		private bool _ContainsPool(string name)
		{
			return default(bool);
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600792C")]
		[Address(RVA = "0x2640030", Offset = "0x263EC30", VA = "0x182640030")]
		private GameObject _AllocateInternal(string name, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600792D")]
		[Address(RVA = "0x263FDF0", Offset = "0x263E9F0", VA = "0x18263FDF0")]
		private GameObject _AllocateInternal(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x00036840 File Offset: 0x00034A40
		[Token(Token = "0x600792E")]
		[Address(RVA = "0x2642130", Offset = "0x2640D30", VA = "0x182642130")]
		private bool _RecycleInternal(Component comp)
		{
			return default(bool);
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x00036858 File Offset: 0x00034A58
		[Token(Token = "0x600792F")]
		[Address(RVA = "0x2642210", Offset = "0x2640E10", VA = "0x182642210")]
		private bool _RecycleInternal(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007930")]
		[Address(RVA = "0x2641F70", Offset = "0x2640B70", VA = "0x182641F70")]
		private void _RecycleInternal(GameObject obj, float delay)
		{
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007931")]
		[Address(RVA = "0x2641DB0", Offset = "0x26409B0", VA = "0x182641DB0")]
		private void _RecycleInternal(Component comp, float delay)
		{
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007932")]
		[Address(RVA = "0x2641CA0", Offset = "0x26408A0", VA = "0x182641CA0")]
		private IEnumerator _RecycleAsync(GameObject obj, float delay)
		{
			return null;
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007933")]
		[Address(RVA = "0x2641B90", Offset = "0x2640790", VA = "0x182641B90")]
		private IEnumerator _RecycleAsync(Component comp, float delay)
		{
			return null;
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007934")]
		[Address(RVA = "0x2642820", Offset = "0x2641420", VA = "0x182642820")]
		private static IEnumerator _WaitForFixedSeconds(float time)
		{
			return null;
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007935")]
		[Address(RVA = "0x26404D0", Offset = "0x263F0D0", VA = "0x1826404D0")]
		private string _GetNameOfPrefab(GameObject prefab)
		{
			return null;
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007936")]
		[Address(RVA = "0x2640960", Offset = "0x263F560", VA = "0x182640960")]
		private Transform _NewPoolContainer(string name)
		{
			return null;
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007937")]
		[Address(RVA = "0x263EF30", Offset = "0x263DB30", VA = "0x18263EF30", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007938")]
		[Address(RVA = "0x263ED40", Offset = "0x263D940", VA = "0x18263ED40", Slot = "5")]
		protected override void OnDuplicated()
		{
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007939")]
		[Address(RVA = "0x263E9A0", Offset = "0x263D5A0", VA = "0x18263E9A0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600793A")]
		[Address(RVA = "0x2641450", Offset = "0x2640050", VA = "0x182641450")]
		private GameObject _OnNewObject(GameObject obj, GameObjectPool pool)
		{
			return null;
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600793B")]
		[Address(RVA = "0x26416E0", Offset = "0x26402E0", VA = "0x1826416E0")]
		private void _OnSceneUnloaded(Scene scene)
		{
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600793C")]
		[Address(RVA = "0x26403E0", Offset = "0x263EFE0", VA = "0x1826403E0")]
		private IEnumerator _DoUnloadUnused([Optional] IList<PoolManager.ObjectConfig> keptConfigs)
		{
			return null;
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600793D")]
		[Address(RVA = "0x2641910", Offset = "0x2640510", VA = "0x182641910")]
		private void _PruneAllPools()
		{
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x00036870 File Offset: 0x00034A70
		[Token(Token = "0x600793E")]
		[Address(RVA = "0x26406E0", Offset = "0x263F2E0", VA = "0x1826406E0")]
		private bool _IsPoolKeyInConfigs(IList<PoolManager.ObjectConfig> keptConfigs, string poolKey)
		{
			return default(bool);
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600793F")]
		[Address(RVA = "0x2641530", Offset = "0x2640130", VA = "0x182641530")]
		private void _OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007940")]
		[Address(RVA = "0x263EE10", Offset = "0x263DA10", VA = "0x18263EE10")]
		private void OnEnable()
		{
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007941")]
		[Address(RVA = "0x263EC20", Offset = "0x263D820", VA = "0x18263EC20")]
		private void OnDisable()
		{
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007942")]
		[Address(RVA = "0x263FB20", Offset = "0x263E720", VA = "0x18263FB20")]
		private void Start()
		{
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007943")]
		[Address(RVA = "0x263E4C0", Offset = "0x263D0C0", VA = "0x18263E4C0")]
		public static void LoadPool(PoolManager.ObjectConfig config)
		{
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007944")]
		[Address(RVA = "0x263E6B0", Offset = "0x263D2B0", VA = "0x18263E6B0")]
		public static void LoadPools(IList<PoolManager.ObjectConfig> configs)
		{
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007945")]
		[Address(RVA = "0x263E610", Offset = "0x263D210", VA = "0x18263E610")]
		public static void LoadPools(PreloadConfigAsset preloadConfig)
		{
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x00036888 File Offset: 0x00034A88
		[Token(Token = "0x6007946")]
		[Address(RVA = "0x263E320", Offset = "0x263CF20", VA = "0x18263E320")]
		public static bool ContainsPool(string name)
		{
			return default(bool);
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007947")]
		[Address(RVA = "0x263DE30", Offset = "0x263CA30", VA = "0x18263DE30")]
		public static GameObject Allocate(string name, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007948")]
		[Address(RVA = "0x263DAF0", Offset = "0x263C6F0", VA = "0x18263DAF0")]
		public static GameObject Allocate(string name, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007949")]
		[Address(RVA = "0x263DCF0", Offset = "0x263C8F0", VA = "0x18263DCF0")]
		public static GameObject Allocate(string name)
		{
			return null;
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794A")]
		public static T Allocate<T>(string name, Vector3 position, Quaternion rotation, Transform parent) where T : Component
		{
			return null;
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794B")]
		public static T Allocate<T>(string name, Vector3 position, Quaternion rotation) where T : Component
		{
			return null;
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794C")]
		public static T Allocate<T>(string name) where T : Component
		{
			return null;
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794D")]
		[Address(RVA = "0x263D580", Offset = "0x263C180", VA = "0x18263D580")]
		public static GameObject Allocate(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794E")]
		[Address(RVA = "0x263DBF0", Offset = "0x263C7F0", VA = "0x18263DBF0")]
		public static GameObject Allocate(GameObject prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794F")]
		[Address(RVA = "0x263D9B0", Offset = "0x263C5B0", VA = "0x18263D9B0")]
		public static GameObject Allocate(GameObject prefab)
		{
			return null;
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007950")]
		public static T Allocate<T>(Component comp, Vector3 position, Quaternion rotation, Transform parent) where T : Component
		{
			return null;
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007951")]
		public static T Allocate<T>(Component comp, Vector3 position, Quaternion rotation) where T : Component
		{
			return null;
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007952")]
		public static T Allocate<T>(Component comp) where T : Component
		{
			return null;
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x000368A0 File Offset: 0x00034AA0
		[Token(Token = "0x6007953")]
		[Address(RVA = "0x263F430", Offset = "0x263E030", VA = "0x18263F430")]
		public static bool Recycle(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007954")]
		[Address(RVA = "0x263F170", Offset = "0x263DD70", VA = "0x18263F170")]
		public static void Recycle(GameObject obj, float delay)
		{
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x000368B8 File Offset: 0x00034AB8
		[Token(Token = "0x6007955")]
		[Address(RVA = "0x263F560", Offset = "0x263E160", VA = "0x18263F560")]
		public static bool Recycle(Component comp)
		{
			return default(bool);
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007956")]
		[Address(RVA = "0x263F760", Offset = "0x263E360", VA = "0x18263F760")]
		public static void Recycle(Component comp, float delay)
		{
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007957")]
		[Address(RVA = "0x2642630", Offset = "0x2641230", VA = "0x182642630")]
		private void _TrySetupRelease()
		{
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007958")]
		[Address(RVA = "0x2642480", Offset = "0x2641080", VA = "0x182642480")]
		private void _SetPolicyDirty()
		{
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007959")]
		[Address(RVA = "0x2640250", Offset = "0x263EE50", VA = "0x182640250")]
		private void _ClearRelase()
		{
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600795A")]
		[Address(RVA = "0x2642780", Offset = "0x2641380", VA = "0x182642780")]
		private void _TryStopRelease()
		{
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600795B")]
		[Address(RVA = "0x26423C0", Offset = "0x2640FC0", VA = "0x1826423C0")]
		private IEnumerator _RunReleasePolicies()
		{
			return null;
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600795C")]
		[Address(RVA = "0x26405B0", Offset = "0x263F1B0", VA = "0x1826405B0")]
		private void _InitPolicyAssignerIfNot()
		{
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600795D")]
		[Address(RVA = "0x26412E0", Offset = "0x263FEE0", VA = "0x1826412E0")]
		private void _OnBeforePoolAdded(string poolKey, ref GameObjectPool.Options options)
		{
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600795E")]
		[Address(RVA = "0x2642980", Offset = "0x2641580", VA = "0x182642980")]
		public PoolManager()
		{
		}

		// Token: 0x0400773A RID: 30522
		[Token(Token = "0x400773A")]
		private const int UNLOAD_POOL_PER_FRAME = 3;

		// Token: 0x0400773B RID: 30523
		[Token(Token = "0x400773B")]
		private const string NON_RESOURCE_PREFIX = "NON_RESOURCE#";

		// Token: 0x0400773C RID: 30524
		[Token(Token = "0x400773C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _usePoolManager;

		// Token: 0x0400773D RID: 30525
		[Token(Token = "0x400773D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _keepInNextScene;

		// Token: 0x0400773E RID: 30526
		[Token(Token = "0x400773E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool _autoAddMissingPool;

		// Token: 0x0400773F RID: 30527
		[Token(Token = "0x400773F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PoolManager.ObjectConfig[] _scenePools;

		// Token: 0x04007740 RID: 30528
		[Token(Token = "0x4007740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_keepInNextScene;

		// Token: 0x04007741 RID: 30529
		[Token(Token = "0x4007741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private PoolManager.Option m_option;

		// Token: 0x04007742 RID: 30530
		[Token(Token = "0x4007742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IEnumerator m_unloadCoroutine;

		// Token: 0x04007743 RID: 30531
		[Token(Token = "0x4007743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AbstractAssetLoader m_assetLoader;

		// Token: 0x04007744 RID: 30532
		[Token(Token = "0x4007744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, GameObjectPool> m_pools;

		// Token: 0x04007745 RID: 30533
		[Token(Token = "0x4007745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, GameObject> m_initialObjects;

		// Token: 0x04007746 RID: 30534
		[Token(Token = "0x4007746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ListDict<int, GameObjectPool> m_instanceIdToPoolMap;

		// Token: 0x04007747 RID: 30535
		[Token(Token = "0x4007747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BaseAssetLoader m_baseAssetLoader;

		// Token: 0x04007748 RID: 30536
		[Token(Token = "0x4007748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<string> s_unloadCache;

		// Token: 0x04007749 RID: 30537
		[Token(Token = "0x4007749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<ReleasePolicyAssigner> m_policyAssignerList;

		// Token: 0x0400774A RID: 30538
		[Token(Token = "0x400774A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Coroutine m_releaseRoroutine;

		// Token: 0x0400774B RID: 30539
		[Token(Token = "0x400774B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, float> m_nextPolicyCheckAt;

		// Token: 0x0400774C RID: 30540
		[Token(Token = "0x400774C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<string> m_policyPools;

		// Token: 0x0400774D RID: 30541
		[Token(Token = "0x400774D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int m_policyCursor;

		// Token: 0x0400774E RID: 30542
		[Token(Token = "0x400774E")]
		private const float CHECK_MIN_INTERVAL = 0.1f;

		// Token: 0x0400774F RID: 30543
		[Token(Token = "0x400774F")]
		private const int RELEASE_POOL_PER_FRAME = 3;

		// Token: 0x04007750 RID: 30544
		[Token(Token = "0x4007750")]
		private const int RELEASE_GOBJ_PER_FRAME = 8;

		// Token: 0x04007751 RID: 30545
		[Token(Token = "0x4007751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_instance;

		// Token: 0x04007752 RID: 30546
		[Token(Token = "0x4007752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_usePoolManager;

		// Token: 0x04007753 RID: 30547
		[Token(Token = "0x4007753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x04007754 RID: 30548
		[Token(Token = "0x4007754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isUnloading;

		// Token: 0x04007755 RID: 30549
		[Token(Token = "0x4007755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetOption;

		// Token: 0x04007756 RID: 30550
		[Token(Token = "0x4007756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BattleOnly_RawRecycle;

		// Token: 0x04007757 RID: 30551
		[Token(Token = "0x4007757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UnloadPoolsWithKeptConfig;

		// Token: 0x04007758 RID: 30552
		[Token(Token = "0x4007758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StopUnloadIfNecessary;

		// Token: 0x04007759 RID: 30553
		[Token(Token = "0x4007759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__NewPool;

		// Token: 0x0400775A RID: 30554
		[Token(Token = "0x400775A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix1__NewPool;

		// Token: 0x0400775B RID: 30555
		[Token(Token = "0x400775B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix2__NewPool;

		// Token: 0x0400775C RID: 30556
		[Token(Token = "0x400775C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ContainsPool;

		// Token: 0x0400775D RID: 30557
		[Token(Token = "0x400775D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__AllocateInternal;

		// Token: 0x0400775E RID: 30558
		[Token(Token = "0x400775E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1__AllocateInternal;

		// Token: 0x0400775F RID: 30559
		[Token(Token = "0x400775F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RecycleInternal;

		// Token: 0x04007760 RID: 30560
		[Token(Token = "0x4007760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1__RecycleInternal;

		// Token: 0x04007761 RID: 30561
		[Token(Token = "0x4007761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix2__RecycleInternal;

		// Token: 0x04007762 RID: 30562
		[Token(Token = "0x4007762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix3__RecycleInternal;

		// Token: 0x04007763 RID: 30563
		[Token(Token = "0x4007763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RecycleAsync;

		// Token: 0x04007764 RID: 30564
		[Token(Token = "0x4007764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1__RecycleAsync;

		// Token: 0x04007765 RID: 30565
		[Token(Token = "0x4007765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__WaitForFixedSeconds;

		// Token: 0x04007766 RID: 30566
		[Token(Token = "0x4007766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetNameOfPrefab;

		// Token: 0x04007767 RID: 30567
		[Token(Token = "0x4007767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__NewPoolContainer;

		// Token: 0x04007768 RID: 30568
		[Token(Token = "0x4007768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04007769 RID: 30569
		[Token(Token = "0x4007769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnDuplicated;

		// Token: 0x0400776A RID: 30570
		[Token(Token = "0x400776A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400776B RID: 30571
		[Token(Token = "0x400776B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnNewObject;

		// Token: 0x0400776C RID: 30572
		[Token(Token = "0x400776C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnSceneUnloaded;

		// Token: 0x0400776D RID: 30573
		[Token(Token = "0x400776D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__DoUnloadUnused;

		// Token: 0x0400776E RID: 30574
		[Token(Token = "0x400776E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__PruneAllPools;

		// Token: 0x0400776F RID: 30575
		[Token(Token = "0x400776F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__IsPoolKeyInConfigs;

		// Token: 0x04007770 RID: 30576
		[Token(Token = "0x4007770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnSceneLoaded;

		// Token: 0x04007771 RID: 30577
		[Token(Token = "0x4007771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04007772 RID: 30578
		[Token(Token = "0x4007772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04007773 RID: 30579
		[Token(Token = "0x4007773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04007774 RID: 30580
		[Token(Token = "0x4007774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_LoadPool;

		// Token: 0x04007775 RID: 30581
		[Token(Token = "0x4007775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_LoadPools;

		// Token: 0x04007776 RID: 30582
		[Token(Token = "0x4007776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix1_LoadPools;

		// Token: 0x04007777 RID: 30583
		[Token(Token = "0x4007777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_ContainsPool;

		// Token: 0x04007778 RID: 30584
		[Token(Token = "0x4007778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_Allocate;

		// Token: 0x04007779 RID: 30585
		[Token(Token = "0x4007779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix1_Allocate;

		// Token: 0x0400777A RID: 30586
		[Token(Token = "0x400777A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix2_Allocate;

		// Token: 0x0400777B RID: 30587
		[Token(Token = "0x400777B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix3_Allocate;

		// Token: 0x0400777C RID: 30588
		[Token(Token = "0x400777C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix4_Allocate;

		// Token: 0x0400777D RID: 30589
		[Token(Token = "0x400777D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix5_Allocate;

		// Token: 0x0400777E RID: 30590
		[Token(Token = "0x400777E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix6_Allocate;

		// Token: 0x0400777F RID: 30591
		[Token(Token = "0x400777F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix7_Allocate;

		// Token: 0x04007780 RID: 30592
		[Token(Token = "0x4007780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix8_Allocate;

		// Token: 0x04007781 RID: 30593
		[Token(Token = "0x4007781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix9_Allocate;

		// Token: 0x04007782 RID: 30594
		[Token(Token = "0x4007782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix10_Allocate;

		// Token: 0x04007783 RID: 30595
		[Token(Token = "0x4007783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix11_Allocate;

		// Token: 0x04007784 RID: 30596
		[Token(Token = "0x4007784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_Recycle;

		// Token: 0x04007785 RID: 30597
		[Token(Token = "0x4007785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix1_Recycle;

		// Token: 0x04007786 RID: 30598
		[Token(Token = "0x4007786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix2_Recycle;

		// Token: 0x04007787 RID: 30599
		[Token(Token = "0x4007787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix3_Recycle;

		// Token: 0x04007788 RID: 30600
		[Token(Token = "0x4007788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__TrySetupRelease;

		// Token: 0x04007789 RID: 30601
		[Token(Token = "0x4007789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__SetPolicyDirty;

		// Token: 0x0400778A RID: 30602
		[Token(Token = "0x400778A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__ClearRelase;

		// Token: 0x0400778B RID: 30603
		[Token(Token = "0x400778B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__TryStopRelease;

		// Token: 0x0400778C RID: 30604
		[Token(Token = "0x400778C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__RunReleasePolicies;

		// Token: 0x0400778D RID: 30605
		[Token(Token = "0x400778D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__InitPolicyAssignerIfNot;

		// Token: 0x0400778E RID: 30606
		[Token(Token = "0x400778E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__OnBeforePoolAdded;

		// Token: 0x0400778F RID: 30607
		[Token(Token = "0x400778F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001477 RID: 5239
		[Token(Token = "0x2001477")]
		[Serializable]
		public struct ObjectConfig
		{
			// Token: 0x17000E7C RID: 3708
			// (get) Token: 0x06007960 RID: 31072 RVA: 0x000368D0 File Offset: 0x00034AD0
			[Token(Token = "0x17000E7C")]
			public bool isResourcePool
			{
				[Token(Token = "0x6007960")]
				[Address(RVA = "0x2114460", Offset = "0x2113060", VA = "0x182114460")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000E7D RID: 3709
			// (get) Token: 0x06007961 RID: 31073 RVA: 0x000368E8 File Offset: 0x00034AE8
			[Token(Token = "0x17000E7D")]
			public bool isPrototypePool
			{
				[Token(Token = "0x6007961")]
				[Address(RVA = "0x263D540", Offset = "0x263C140", VA = "0x18263D540")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007962 RID: 31074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007962")]
			[Address(RVA = "0x263D400", Offset = "0x263C000", VA = "0x18263D400", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04007790 RID: 30608
			[Token(Token = "0x4007790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PoolManager.ObjectConfig.SourceType sourceType;

			// Token: 0x04007791 RID: 30609
			[Token(Token = "0x4007791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Inspect("isResourcePool")]
			public string assetName;

			// Token: 0x04007792 RID: 30610
			[Token(Token = "0x4007792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Inspect("isPrototypePool")]
			public GameObject prototype;

			// Token: 0x04007793 RID: 30611
			[Token(Token = "0x4007793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Expandable(AlwaysExpanded = true)]
			public GameObjectPool.Options poolOptions;

			// Token: 0x02001478 RID: 5240
			[Token(Token = "0x2001478")]
			public enum SourceType
			{
				// Token: 0x04007795 RID: 30613
				[Token(Token = "0x4007795")]
				RESOURCE,
				// Token: 0x04007796 RID: 30614
				[Token(Token = "0x4007796")]
				PROTOTYPE
			}
		}

		// Token: 0x02001479 RID: 5241
		[Token(Token = "0x2001479")]
		public struct Option
		{
			// Token: 0x04007797 RID: 30615
			[Token(Token = "0x4007797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool allowUnload;

			// Token: 0x04007798 RID: 30616
			[Token(Token = "0x4007798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool enableRelease;
		}
	}
}
