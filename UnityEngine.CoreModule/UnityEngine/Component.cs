using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	[NativeClass("Unity::Component")]
	[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
	[RequiredByNativeCode]
	public class Component : Object
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600091F RID: 2335
		[Token(Token = "0x170001F2")]
		public extern Transform transform { [Token(Token = "0x600091F")] [Address(RVA = "0x594A7D0", Offset = "0x59493D0", VA = "0x18594A7D0")] [FreeFunction("GetTransform", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(4096)] get; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000920 RID: 2336
		[Token(Token = "0x170001F3")]
		public extern GameObject gameObject { [Token(Token = "0x6000920")] [Address(RVA = "0x594A740", Offset = "0x5949340", VA = "0x18594A740")] [FreeFunction("GetGameObject", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x06000921 RID: 2337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x594A110", Offset = "0x5948D10", VA = "0x18594A110")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponent(Type type)
		{
			return null;
		}

		// Token: 0x06000922 RID: 2338
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x5949EC0", Offset = "0x5948AC0", VA = "0x185949EC0")]
		[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x06000923 RID: 2339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000923")]
		public T GetComponent<T>()
		{
			return null;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x594A6D0", Offset = "0x59492D0", VA = "0x18594A6D0")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public bool TryGetComponent(Type type, out Component component)
		{
			return default(bool);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x6000925")]
		public bool TryGetComponent<T>(out T component)
		{
			return default(bool);
		}

		// Token: 0x06000926 RID: 2342
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x594A0C0", Offset = "0x5948CC0", VA = "0x18594A0C0")]
		[FreeFunction(HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern Component GetComponent(string type);

		// Token: 0x06000927 RID: 2343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x5949F80", Offset = "0x5948B80", VA = "0x185949F80")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type t, bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x5949F20", Offset = "0x5948B20", VA = "0x185949F20")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInChildren(Type t)
		{
			return null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000929")]
		public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
		{
			return null;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092A")]
		[ExcludeFromDocs]
		public T GetComponentInChildren<T>()
		{
			return null;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x594A1D0", Offset = "0x5948DD0", VA = "0x18594A1D0")]
		public Component[] GetComponentsInChildren(Type t, bool includeInactive)
		{
			return null;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x594A240", Offset = "0x5948E40", VA = "0x18594A240")]
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type t)
		{
			return null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092D")]
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			return null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092E")]
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600092F")]
		public T[] GetComponentsInChildren<T>()
		{
			return null;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000930")]
		public void GetComponentsInChildren<T>(List<T> results)
		{
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x594A050", Offset = "0x5948C50", VA = "0x18594A050")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type t, bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x5949FF0", Offset = "0x5948BF0", VA = "0x185949FF0")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type t)
		{
			return null;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000933")]
		public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000934")]
		public T GetComponentInParent<T>()
		{
			return null;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x594A2A0", Offset = "0x5948EA0", VA = "0x18594A2A0")]
		public Component[] GetComponentsInParent(Type t, [DefaultValue("false")] bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x594A310", Offset = "0x5948F10", VA = "0x18594A310")]
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type t)
		{
			return null;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000937")]
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000938")]
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000939")]
		public T[] GetComponentsInParent<T>()
		{
			return null;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x594A370", Offset = "0x5948F70", VA = "0x18594A370")]
		public Component[] GetComponents(Type type)
		{
			return null;
		}

		// Token: 0x0600093B RID: 2363
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x594A170", Offset = "0x5948D70", VA = "0x18594A170")]
		[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void GetComponentsForListInternal(Type searchType, object resultList);

		// Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x594A170", Offset = "0x5948D70", VA = "0x18594A170")]
		public void GetComponents(Type type, List<Component> results)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093D")]
		public void GetComponents<T>(List<T> results)
		{
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F4")]
		public string tag
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x594A780", Offset = "0x5949380", VA = "0x18594A780")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x594A810", Offset = "0x5949410", VA = "0x18594A810")]
			set
			{
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000940")]
		public T[] GetComponents<T>()
		{
			return null;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x5949E60", Offset = "0x5948A60", VA = "0x185949E60")]
		public bool CompareTag(string tag)
		{
			return default(bool);
		}

		// Token: 0x06000942 RID: 2370
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x594A3D0", Offset = "0x5948FD0", VA = "0x18594A3D0")]
		[FreeFunction(HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SendMessageUpwards(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x594A4F0", Offset = "0x59490F0", VA = "0x18594A4F0")]
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName, object value)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x594A440", Offset = "0x5949040", VA = "0x18594A440")]
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName)
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x594A490", Offset = "0x5949090", VA = "0x18594A490")]
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x594A5C0", Offset = "0x59491C0", VA = "0x18594A5C0")]
		public void SendMessage(string methodName, object value)
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x594A620", Offset = "0x5949220", VA = "0x18594A620")]
		public void SendMessage(string methodName)
		{
		}

		// Token: 0x06000948 RID: 2376
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x594A550", Offset = "0x5949150", VA = "0x18594A550")]
		[FreeFunction("SendMessage", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SendMessage(string methodName, object value, SendMessageOptions options);

		// Token: 0x06000949 RID: 2377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x594A670", Offset = "0x5949270", VA = "0x18594A670")]
		public void SendMessage(string methodName, SendMessageOptions options)
		{
		}

		// Token: 0x0600094A RID: 2378
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x5949DA0", Offset = "0x59489A0", VA = "0x185949DA0")]
		[FreeFunction("BroadcastMessage", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x5949CE0", Offset = "0x59488E0", VA = "0x185949CE0")]
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName, object parameter)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x5949E10", Offset = "0x5948A10", VA = "0x185949E10")]
		[ExcludeFromDocs]
		public void BroadcastMessage(string methodName)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x5949D40", Offset = "0x5948940", VA = "0x185949D40")]
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x5947ED0", Offset = "0x5946AD0", VA = "0x185947ED0")]
		public Component()
		{
		}
	}
}
