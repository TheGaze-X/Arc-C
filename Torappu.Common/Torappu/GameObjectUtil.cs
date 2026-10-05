using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	public static class GameObjectUtil
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B3")]
		public static T[] FindAllObjectsInScene<T>() where T : Component
		{
			return null;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x551AA10", Offset = "0x5519610", VA = "0x18551AA10")]
		public static Component[] FindComponentsInScene(Type type)
		{
			return null;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005B5")]
		public static void FindAllComponentsRecursively<T>(GameObject target, ref List<T> output) where T : Component
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x551A400", Offset = "0x5519000", VA = "0x18551A400")]
		public static void DestroyAllChildren(Transform transform)
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x551A5D0", Offset = "0x55191D0", VA = "0x18551A5D0")]
		public static void Destroy(UnityEngine.Object obj)
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x551B8A0", Offset = "0x551A4A0", VA = "0x18551B8A0")]
		public static void SetGameObjectActive(this Component comp, bool isActive)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x551A4E0", Offset = "0x55190E0", VA = "0x18551A4E0")]
		public static void DestroyGameObject(Component comp)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BA")]
		public static Coroutine InvokeAsync<T>(this T mono, Action<T> cb, float delay, bool ignoreTimeScale = false) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BB")]
		public static Coroutine InvokeAsync<T>(this T mono, Action cb, float delay, bool ignoreTimeScale = false) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BC")]
		private static IEnumerator _InvokeAsync<T>(T mono, Action<T> cb, float delay, bool ignoreTimeScale) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BD")]
		private static IEnumerator _InvokeAsync<T>(T mono, Action cb, float delay, bool ignoreTimeScale) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BE")]
		public static Coroutine InvokeEndOfFrame<T>(this T mono, Action<T> cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BF")]
		public static Coroutine InvokeEndOfFrame<T>(this T mono, Action cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C0")]
		private static IEnumerator _InvokeEndOfFrame<T>(this T mono, Action<T> cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C1")]
		private static IEnumerator _InvokeEndOfFrame<T>(this T mono, Action cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C2")]
		public static Coroutine InvokeNextFrame<T>(this T mono, Action<T> cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C3")]
		public static Coroutine InvokeNextFrame<T>(this T mono, Action cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C4")]
		private static IEnumerator _InvokeNextFrame<T>(this T mono, Action<T> cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C5")]
		private static IEnumerator _InvokeNextFrame<T>(this T mono, Action cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C6")]
		public static T InstantiateLocal<T>(this T prototype, Vector3 position, Quaternion rotation, Transform parent) where T : Component
		{
			return null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C7")]
		public static T InstantiateEnsureOnAwake<T>(this T prototype, Transform parent) where T : Component
		{
			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x551B780", Offset = "0x551A380", VA = "0x18551B780")]
		public static void SetActiveIfNecessary(this GameObject gameObject, bool isActive)
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x551B810", Offset = "0x551A410", VA = "0x18551B810")]
		public static void SetEnabledIfNecessary(this Behaviour behaviour, bool isEnabled)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CA")]
		public static T AddComponent<T>(this GameObject go, T proto) where T : Component
		{
			return null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CB")]
		public static T EnsureComponent<T>(this GameObject go) where T : Component
		{
			return null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CC")]
		public static T EnsureComponent<T>(this GameObject go, out bool isNewlyAdded) where T : Component
		{
			return null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x551A8C0", Offset = "0x55194C0", VA = "0x18551A8C0")]
		public static Component EnsureComponent(this GameObject go, Type type)
		{
			return null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x551A840", Offset = "0x5519440", VA = "0x18551A840")]
		public static Component EnsureComponent(this GameObject go, Type type, out bool isNewlyAdded)
		{
			return null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005CF")]
		public static void ClearAllComponent<T>(this GameObject go, [Optional] Func<T, bool> validator, bool allowDestroyingAsset = false) where T : Component
		{
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x551A1D0", Offset = "0x5518DD0", VA = "0x18551A1D0")]
		public static void ClearAllChildren(this Transform transform, [Optional] Func<Transform, bool> validator)
		{
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005D1")]
		public static void ClearAllComponentsInChildren<T>(this GameObject go, bool includeInactive = false, [Optional] Func<T, bool> validator) where T : Component
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005D2")]
		public static void DisableComponentsInChildren<T>(this GameObject go, bool includeInactive = false, [Optional] Func<T, bool> validator) where T : Behaviour
		{
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x551A920", Offset = "0x5519520", VA = "0x18551A920")]
		public static Transform EnsureSubGameObject(this Transform transform, string name)
		{
			return null;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D4")]
		public static T EnsureSubGameObject<T>(this Transform transform, string name) where T : Component
		{
			return null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x551A620", Offset = "0x5519220", VA = "0x18551A620")]
		public static Transform DuplicateAdditionalLayer(string name, Transform transform, bool includeRotationAndScale = false)
		{
			return null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00005D2C File Offset: 0x00003F2C
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x551BED0", Offset = "0x551AAD0", VA = "0x18551BED0")]
		public static Rect TransformRect(this Transform transform, Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00005D44 File Offset: 0x00003F44
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x551B540", Offset = "0x551A140", VA = "0x18551B540")]
		public static Rect InverseTransformRect(this Transform transform, Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x551B700", Offset = "0x551A300", VA = "0x18551B700")]
		public static string SafeName(this GameObject obj)
		{
			return null;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x551B680", Offset = "0x551A280", VA = "0x18551B680")]
		public static string SafeName(this Component component)
		{
			return null;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x551AC60", Offset = "0x5519860", VA = "0x18551AC60")]
		public static Transform FindDeepChildContainSubstring(this Transform transform, string substr, bool capitalSensitive = true)
		{
			return null;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x551AF40", Offset = "0x5519B40", VA = "0x18551AF40")]
		public static Transform[] FindDeepChildrenContainSubstring(this Transform transform, string substr, bool capitalSensitive = true)
		{
			return null;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x551AE30", Offset = "0x5519A30", VA = "0x18551AE30")]
		public static Transform FindDeepChild(this Transform transform, string name)
		{
			return null;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005DD")]
		public static void ForeachComponentWithInterface<TClass, TInterface>(this Component comp, Action<TClass, TInterface> cb) where TClass : Component where TInterface : class
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005DE")]
		public static void ForeachComponentInChildrenWithInterface<TClass, TInterface>(this Component comp, Action<TClass, TInterface> cb, bool includeInactive = false) where TClass : Component where TInterface : class
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x551A2E0", Offset = "0x5518EE0", VA = "0x18551A2E0")]
		public static RectTransform CreateUIObject(string name, RectTransform parent)
		{
			return null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x551B980", Offset = "0x551A580", VA = "0x18551B980")]
		public static void SetLayerRecursively(GameObject go, int layer)
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x551BA20", Offset = "0x551A620", VA = "0x18551BA20")]
		public static void SetSortingLayerIDRecursively(GameObject go, int sortingLayerID)
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x5519EC0", Offset = "0x5518AC0", VA = "0x185519EC0")]
		public static void AddSortingLayerOrderRecursively(GameObject go, int delta, bool includeInactive)
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x551BAC0", Offset = "0x551A6C0", VA = "0x18551BAC0")]
		public static void ShrinkSortingOrders(IList<Renderer> targets, int baseOrder)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x551C010", Offset = "0x551AC10", VA = "0x18551C010")]
		public static void TranverseAllGameObjects(GameObject root, Action<GameObject> callback)
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00005D5C File Offset: 0x00003F5C
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x551A0C0", Offset = "0x5518CC0", VA = "0x18551A0C0")]
		public static bool CheckIfAncestor(Transform ancestor, Transform descendant)
		{
			return default(bool);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00005D74 File Offset: 0x00003F74
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x5519F80", Offset = "0x5518B80", VA = "0x185519F80")]
		public static bool CheckIfAncestor(Transform ancestor, Transform descendant, Func<Transform, bool> breakCallback)
		{
			return default(bool);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x551BD70", Offset = "0x551A970", VA = "0x18551BD70")]
		public static void StopCoroutineNested(this MonoBehaviour host, IEnumerator routine)
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E8")]
		public static T GetComponentInParent<T>(this Component self, bool includeInactive) where T : Component
		{
			return null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E9")]
		public static T GetComponentInParent<T>(this GameObject self, bool includeInactive) where T : Component
		{
			return null;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EA")]
		public static T GetComponentInParent<T>(this Transform self, bool includeInactive) where T : Component
		{
			return null;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x551B1A0", Offset = "0x5519DA0", VA = "0x18551B1A0")]
		public static string GeneratePathFromRoot(this GameObject go, [Optional] Transform rootTrans)
		{
			return null;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x551B250", Offset = "0x5519E50", VA = "0x18551B250")]
		public static string GeneratePathFromRoot(this Transform t, [Optional] Transform rootTrans)
		{
			return null;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x551C1D0", Offset = "0x551ADD0", VA = "0x18551C1D0")]
		private static void _ConstructPathFromRoot(Transform t, Transform rootTrans, ref StringBuilder builder)
		{
		}
	}
}
