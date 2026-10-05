using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	[UsedByNativeCode]
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
	public sealed class GameObject : Object
	{
		// Token: 0x0600095B RID: 2395
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x595AA60", Offset = "0x5959660", VA = "0x18595AA60")]
		[FreeFunction("GameObjectBindings::CreatePrimitive")]
		[MethodImpl(4096)]
		public static extern GameObject CreatePrimitive(PrimitiveType type);

		// Token: 0x0600095C RID: 2396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095C")]
		public T GetComponent<T>()
		{
			return null;
		}

		// Token: 0x0600095D RID: 2397
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x595AD70", Offset = "0x5959970", VA = "0x18595AD70")]
		[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[MethodImpl(4096)]
		public extern Component GetComponent(Type type);

		// Token: 0x0600095E RID: 2398
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x595ABB0", Offset = "0x59597B0", VA = "0x18595ABB0")]
		[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		[NativeWritableSelf]
		[MethodImpl(4096)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x0600095F RID: 2399
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x595AB60", Offset = "0x5959760", VA = "0x18595AB60")]
		[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObject", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern Component GetComponentByName(string type);

		// Token: 0x06000960 RID: 2400 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x595AB60", Offset = "0x5959760", VA = "0x18595AB60")]
		public Component GetComponent(string type)
		{
			return null;
		}

		// Token: 0x06000961 RID: 2401
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x595AC60", Offset = "0x5959860", VA = "0x18595AC60")]
		[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[MethodImpl(4096)]
		public extern Component GetComponentInChildren(Type type, bool includeInactive);

		// Token: 0x06000962 RID: 2402 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x595AC10", Offset = "0x5959810", VA = "0x18595AC10")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type type)
		{
			return null;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000963")]
		[ExcludeFromDocs]
		public T GetComponentInChildren<T>()
		{
			return null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000964")]
		public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000965 RID: 2405
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x595ACC0", Offset = "0x59598C0", VA = "0x18595ACC0")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern Component GetComponentInParent(Type type, bool includeInactive);

		// Token: 0x06000966 RID: 2406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x595AD20", Offset = "0x5959920", VA = "0x18595AD20")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type type)
		{
			return null;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000967")]
		[ExcludeFromDocs]
		public T GetComponentInParent<T>()
		{
			return null;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000968")]
		public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000969 RID: 2409
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x595B0A0", Offset = "0x5959CA0", VA = "0x18595B0A0")]
		[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);

		// Token: 0x0600096A RID: 2410 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x595B190", Offset = "0x5959D90", VA = "0x18595B190")]
		public Component[] GetComponents(Type type)
		{
			return null;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096B")]
		public T[] GetComponents<T>()
		{
			return null;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x595B120", Offset = "0x5959D20", VA = "0x18595B120")]
		public void GetComponents(Type type, List<Component> results)
		{
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600096D")]
		public void GetComponents<T>(List<T> results)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x595AE80", Offset = "0x5959A80", VA = "0x18595AE80")]
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type type)
		{
			return null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x595ADC0", Offset = "0x59599C0", VA = "0x18595ADC0")]
		public Component[] GetComponentsInChildren(Type type, [DefaultValue("false")] bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000970")]
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000971")]
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000972")]
		public T[] GetComponentsInChildren<T>()
		{
			return null;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000973")]
		public void GetComponentsInChildren<T>(List<T> results)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x595AF30", Offset = "0x5959B30", VA = "0x18595AF30")]
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type type)
		{
			return null;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x595AFE0", Offset = "0x5959BE0", VA = "0x18595AFE0")]
		public Component[] GetComponentsInParent(Type type, [DefaultValue("false")] bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000976")]
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000977")]
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000978")]
		public T[] GetComponentsInParent<T>()
		{
			return null;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x6000979")]
		public bool TryGetComponent<T>(out T component)
		{
			return default(bool);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x595B6E0", Offset = "0x595A2E0", VA = "0x18595B6E0")]
		public bool TryGetComponent(Type type, out Component component)
		{
			return default(bool);
		}

		// Token: 0x0600097B RID: 2427
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x595B690", Offset = "0x595A290", VA = "0x18595B690")]
		[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[MethodImpl(4096)]
		internal extern Component TryGetComponentInternal(Type type);

		// Token: 0x0600097C RID: 2428
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x595B630", Offset = "0x595A230", VA = "0x18595B630")]
		[NativeWritableSelf]
		[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		internal extern void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x0600097D RID: 2429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x595AAA0", Offset = "0x59596A0", VA = "0x18595AAA0")]
		public static GameObject FindWithTag(string tag)
		{
			return null;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x595B3B0", Offset = "0x5959FB0", VA = "0x18595B3B0")]
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x595B530", Offset = "0x595A130", VA = "0x18595B530")]
		public void SendMessage(string methodName, SendMessageOptions options)
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x595A8F0", Offset = "0x59594F0", VA = "0x18595A8F0")]
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
		}

		// Token: 0x06000981 RID: 2433
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x595A7F0", Offset = "0x59593F0", VA = "0x18595A7F0")]
		[FreeFunction(Name = "MonoAddComponent", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern Component AddComponentInternal(string className);

		// Token: 0x06000982 RID: 2434
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x595A840", Offset = "0x5959440", VA = "0x18595A840")]
		[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern Component Internal_AddComponentWithType(Type componentType);

		// Token: 0x06000983 RID: 2435 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x595A840", Offset = "0x5959440", VA = "0x18595A840")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component AddComponent(Type componentType)
		{
			return null;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000984")]
		public T AddComponent<T>() where T : Component
		{
			return null;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000985 RID: 2437
		[Token(Token = "0x170001F7")]
		public extern Transform transform { [Token(Token = "0x6000985")] [Address(RVA = "0x595BCB0", Offset = "0x595A8B0", VA = "0x18595BCB0")] [FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000986 RID: 2438
		// (set) Token: 0x06000987 RID: 2439
		[Token(Token = "0x170001F8")]
		public extern int layer { [Token(Token = "0x6000986")] [Address(RVA = "0x595BB50", Offset = "0x595A750", VA = "0x18595BB50")] [MethodImpl(4096)] get; [Token(Token = "0x6000987")] [Address(RVA = "0x595BD90", Offset = "0x595A990", VA = "0x18595BD90")] [MethodImpl(4096)] set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000988 RID: 2440
		// (set) Token: 0x06000989 RID: 2441
		[Token(Token = "0x170001F9")]
		[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
		public extern bool active { [Token(Token = "0x6000988")] [Address(RVA = "0x595BA90", Offset = "0x595A690", VA = "0x18595BA90")] [NativeMethod(Name = "IsActive")] [MethodImpl(4096)] get; [Token(Token = "0x6000989")] [Address(RVA = "0x595BCF0", Offset = "0x595A8F0", VA = "0x18595BCF0")] [NativeMethod(Name = "SetSelfActive")] [MethodImpl(4096)] set; }

		// Token: 0x0600098A RID: 2442
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x595B5E0", Offset = "0x595A1E0", VA = "0x18595B5E0")]
		[NativeMethod(Name = "SetSelfActive")]
		[MethodImpl(4096)]
		public extern void SetActive(bool value);

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600098B RID: 2443
		[Token(Token = "0x170001FA")]
		public extern bool activeSelf { [Token(Token = "0x600098B")] [Address(RVA = "0x595BA50", Offset = "0x595A650", VA = "0x18595BA50")] [NativeMethod(Name = "IsSelfActive")] [MethodImpl(4096)] get; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600098C RID: 2444
		[Token(Token = "0x170001FB")]
		public extern bool activeInHierarchy { [Token(Token = "0x600098C")] [Address(RVA = "0x595BA10", Offset = "0x595A610", VA = "0x18595BA10")] [NativeMethod(Name = "IsActive")] [MethodImpl(4096)] get; }

		// Token: 0x0600098D RID: 2445
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x595B590", Offset = "0x595A190", VA = "0x18595B590")]
		[NativeMethod(Name = "SetActiveRecursivelyDeprecated")]
		[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
		[MethodImpl(4096)]
		public extern void SetActiveRecursively(bool state);

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600098E RID: 2446
		// (set) Token: 0x0600098F RID: 2447
		[Token(Token = "0x170001FC")]
		public extern bool isStatic { [Token(Token = "0x600098E")] [Address(RVA = "0x595BB10", Offset = "0x595A710", VA = "0x18595BB10")] [NativeMethod(Name = "GetIsStaticDeprecated")] [MethodImpl(4096)] get; [Token(Token = "0x600098F")] [Address(RVA = "0x595BD40", Offset = "0x595A940", VA = "0x18595BD40")] [NativeMethod(Name = "SetIsStaticDeprecated")] [MethodImpl(4096)] set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000990 RID: 2448
		[Token(Token = "0x170001FD")]
		internal extern bool isStaticBatchable { [Token(Token = "0x6000990")] [Address(RVA = "0x595BAD0", Offset = "0x595A6D0", VA = "0x18595BAD0")] [NativeMethod(Name = "IsStaticBatchable")] [MethodImpl(4096)] get; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000991 RID: 2449
		// (set) Token: 0x06000992 RID: 2450
		[Token(Token = "0x170001FE")]
		public extern string tag { [Token(Token = "0x6000991")] [Address(RVA = "0x595BC70", Offset = "0x595A870", VA = "0x18595BC70")] [FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = true)] [MethodImpl(4096)] get; [Token(Token = "0x6000992")] [Address(RVA = "0x595BDD0", Offset = "0x595A9D0", VA = "0x18595BDD0")] [FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = true)] [MethodImpl(4096)] set; }

		// Token: 0x06000993 RID: 2451
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x595AA10", Offset = "0x5959610", VA = "0x18595AA10")]
		[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern bool CompareTag(string tag);

		// Token: 0x06000994 RID: 2452
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x595AAA0", Offset = "0x59596A0", VA = "0x18595AAA0")]
		[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern GameObject FindGameObjectWithTag(string tag);

		// Token: 0x06000995 RID: 2453
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x595AAE0", Offset = "0x59596E0", VA = "0x18595AAE0")]
		[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern GameObject[] FindGameObjectsWithTag(string tag);

		// Token: 0x06000996 RID: 2454
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x595B290", Offset = "0x5959E90", VA = "0x18595B290")]
		[FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x595B350", Offset = "0x5959F50", VA = "0x18595B350")]
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName, object value)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x595B300", Offset = "0x5959F00", VA = "0x18595B300")]
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName)
		{
		}

		// Token: 0x06000999 RID: 2457
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x595B410", Offset = "0x595A010", VA = "0x18595B410")]
		[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x0600099A RID: 2458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x595B4D0", Offset = "0x595A0D0", VA = "0x18595B4D0")]
		[ExcludeFromDocs]
		public void SendMessage(string methodName, object value)
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x595B480", Offset = "0x595A080", VA = "0x18595B480")]
		[ExcludeFromDocs]
		public void SendMessage(string methodName)
		{
		}

		// Token: 0x0600099C RID: 2460
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x595A950", Offset = "0x5959550", VA = "0x18595A950")]
		[FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x0600099D RID: 2461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x595A890", Offset = "0x5959490", VA = "0x18595A890")]
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName, object parameter)
		{
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x595A9C0", Offset = "0x59595C0", VA = "0x18595A9C0")]
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName)
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x595B830", Offset = "0x595A430", VA = "0x18595B830")]
		public GameObject(string name)
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x595B9A0", Offset = "0x595A5A0", VA = "0x18595B9A0")]
		public GameObject()
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x595B8B0", Offset = "0x595A4B0", VA = "0x18595B8B0")]
		public GameObject(string name, params Type[] components)
		{
		}

		// Token: 0x060009A2 RID: 2466
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x595B240", Offset = "0x5959E40", VA = "0x18595B240")]
		[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
		[MethodImpl(4096)]
		private static extern void Internal_CreateGameObject([Writable] GameObject self, string name);

		// Token: 0x060009A3 RID: 2467
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x595AB20", Offset = "0x5959720", VA = "0x18595AB20")]
		[FreeFunction(Name = "GameObjectBindings::Find")]
		[MethodImpl(4096)]
		public static extern GameObject Find(string name);

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x170001FF")]
		public Scene scene
		{
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x595BC20", Offset = "0x595A820", VA = "0x18595BC20")]
			[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = true)]
			get
			{
				return default(Scene);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060009A5 RID: 2469
		[Token(Token = "0x17000200")]
		public extern ulong sceneCullingMask { [Token(Token = "0x60009A5")] [Address(RVA = "0x595BB90", Offset = "0x595A790", VA = "0x18595BB90")] [FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000201")]
		public GameObject gameObject
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x4D365B0", Offset = "0x4D351B0", VA = "0x184D365B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009A7 RID: 2471
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x595BBD0", Offset = "0x595A7D0", VA = "0x18595BBD0")]
		[MethodImpl(4096)]
		private extern void get_scene_Injected(out Scene ret);
	}
}
