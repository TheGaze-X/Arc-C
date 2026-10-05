using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
	[RequiredByNativeCode(GenerateProxy = true)]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeHeader("Runtime/GameCode/CloneObject.h")]
	[StructLayout(0)]
	public class Object
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x59622B0", Offset = "0x5960EB0", VA = "0x1859622B0")]
		public int GetInstanceID()
		{
			return 0;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x59622A0", Offset = "0x5960EA0", VA = "0x1859622A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x5961900", Offset = "0x5960500", VA = "0x185961900", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x5963850", Offset = "0x5962450", VA = "0x185963850")]
		public static implicit operator bool(Object exists)
		{
			return default(bool);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x59613E0", Offset = "0x595FFE0", VA = "0x1859613E0")]
		private static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			return default(bool);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x5961840", Offset = "0x5960440", VA = "0x185961840")]
		private void EnsureRunningOnMainThread()
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x5963450", Offset = "0x5962050", VA = "0x185963450")]
		private static bool IsNativeObjectAlive(Object o)
		{
			return default(bool);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
		private IntPtr GetCachedPtr()
		{
			return 0;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000209")]
		public string name
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x5963670", Offset = "0x5962270", VA = "0x185963670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x5963AC0", Offset = "0x59626C0", VA = "0x185963AC0")]
			set
			{
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x5962A00", Offset = "0x5961600", VA = "0x185962A00")]
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x59624B0", Offset = "0x59610B0", VA = "0x1859624B0")]
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x5962820", Offset = "0x5961420", VA = "0x185962820")]
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original)
		{
			return null;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x5962450", Offset = "0x5961050", VA = "0x185962450")]
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Transform parent)
		{
			return null;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x5962D10", Offset = "0x5961910", VA = "0x185962D10")]
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
		{
			return null;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A16")]
		public static T Instantiate<T>(T original) where T : Object
		{
			return null;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A17")]
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			return null;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A18")]
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
		{
			return null;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A19")]
		public static T Instantiate<T>(T original, Transform parent) where T : Object
		{
			return null;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A1A")]
		public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
		{
			return null;
		}

		// Token: 0x06000A1B RID: 2587
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x5961700", Offset = "0x5960300", VA = "0x185961700")]
		[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern void Destroy(Object obj, [DefaultValue("0.0F")] float t);

		// Token: 0x06000A1C RID: 2588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x5961750", Offset = "0x5960350", VA = "0x185961750")]
		[ExcludeFromDocs]
		public static void Destroy(Object obj)
		{
		}

		// Token: 0x06000A1D RID: 2589
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x59615C0", Offset = "0x59601C0", VA = "0x1859615C0")]
		[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets);

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x5961550", Offset = "0x5960150", VA = "0x185961550")]
		[ExcludeFromDocs]
		public static void DestroyImmediate(Object obj)
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x5962100", Offset = "0x5960D00", VA = "0x185962100")]
		public static Object[] FindObjectsOfType(Type type)
		{
			return null;
		}

		// Token: 0x06000A20 RID: 2592
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x5962170", Offset = "0x5960D70", VA = "0x185962170")]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
		[MethodImpl(4096)]
		public static extern Object[] FindObjectsOfType(Type type, bool includeInactive);

		// Token: 0x06000A21 RID: 2593 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x5962030", Offset = "0x5960C30", VA = "0x185962030")]
		public static Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode)
		{
			return null;
		}

		// Token: 0x06000A22 RID: 2594
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x5961FE0", Offset = "0x5960BE0", VA = "0x185961FE0")]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
		[MethodImpl(4096)]
		public static extern Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode);

		// Token: 0x06000A23 RID: 2595
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x5961800", Offset = "0x5960400", VA = "0x185961800")]
		[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern void DontDestroyOnLoad([NotNull("NullExceptionObject")] Object target);

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A24 RID: 2596
		// (set) Token: 0x06000A25 RID: 2597
		[Token(Token = "0x1700020A")]
		public extern HideFlags hideFlags { [Token(Token = "0x6000A24")] [Address(RVA = "0x5963630", Offset = "0x5962230", VA = "0x185963630")] [MethodImpl(4096)] get; [Token(Token = "0x6000A25")] [Address(RVA = "0x5963A80", Offset = "0x5962680", VA = "0x185963A80")] [MethodImpl(4096)] set; }

		// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x5961610", Offset = "0x5960210", VA = "0x185961610")]
		[Obsolete("use Object.Destroy instead.")]
		public static void DestroyObject(Object obj, [DefaultValue("0.0F")] float t)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x5961690", Offset = "0x5960290", VA = "0x185961690")]
		[Obsolete("use Object.Destroy instead.")]
		[ExcludeFromDocs]
		public static void DestroyObject(Object obj)
		{
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x59621C0", Offset = "0x5960DC0", VA = "0x1859621C0")]
		[Obsolete("warning use Object.FindObjectsByType instead.")]
		public static Object[] FindSceneObjectsOfType(Type type)
		{
			return null;
		}

		// Token: 0x06000A29 RID: 2601
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x59620C0", Offset = "0x5960CC0", VA = "0x1859620C0")]
		[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
		[MethodImpl(4096)]
		public static extern Object[] FindObjectsOfTypeIncludingAssets(Type type);

		// Token: 0x06000A2A RID: 2602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A2A")]
		public static T[] FindObjectsOfType<T>() where T : Object
		{
			return null;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A2B")]
		public static T[] FindObjectsByType<T>(FindObjectsSortMode sortMode) where T : Object
		{
			return null;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A2C")]
		public static T[] FindObjectsOfType<T>(bool includeInactive) where T : Object
		{
			return null;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A2D")]
		public static T[] FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) where T : Object
		{
			return null;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A2E")]
		public static T FindObjectOfType<T>() where T : Object
		{
			return null;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A2F")]
		public static T FindObjectOfType<T>(bool includeInactive) where T : Object
		{
			return null;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A30")]
		public static T FindFirstObjectByType<T>() where T : Object
		{
			return null;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A31")]
		public static T FindAnyObjectByType<T>() where T : Object
		{
			return null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A32")]
		public static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			return null;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A33")]
		public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			return null;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x59620B0", Offset = "0x5960CB0", VA = "0x1859620B0")]
		[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x5961380", Offset = "0x595FF80", VA = "0x185961380")]
		private static void CheckNullArgument(object arg, string message)
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x5961F50", Offset = "0x5960B50", VA = "0x185961F50")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object FindObjectOfType(Type type)
		{
			return null;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x5961D20", Offset = "0x5960920", VA = "0x185961D20")]
		public static Object FindFirstObjectByType(Type type)
		{
			return null;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x5961BD0", Offset = "0x59607D0", VA = "0x185961BD0")]
		public static Object FindAnyObjectByType(Type type)
		{
			return null;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x5961EB0", Offset = "0x5960AB0", VA = "0x185961EB0")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object FindObjectOfType(Type type, bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x5961DC0", Offset = "0x59609C0", VA = "0x185961DC0")]
		public static Object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			return null;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x5961C70", Offset = "0x5960870", VA = "0x185961C70")]
		public static Object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			return null;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x5963540", Offset = "0x5962140", VA = "0x185963540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x59636E0", Offset = "0x59622E0", VA = "0x1859636E0")]
		public static bool operator ==(Object x, Object y)
		{
			return default(bool);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x5963910", Offset = "0x5962510", VA = "0x185963910")]
		public static bool operator !=(Object x, Object y)
		{
			return default(bool);
		}

		// Token: 0x06000A3F RID: 2623
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x5962420", Offset = "0x5961020", VA = "0x185962420")]
		[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern int GetOffsetOfInstanceIDInCPlusPlusObject();

		// Token: 0x06000A40 RID: 2624
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x5961520", Offset = "0x5960120", VA = "0x185961520")]
		[NativeMethod(Name = "CurrentThreadIsMainThread", IsFreeFunction = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern bool CurrentThreadIsMainThread();

		// Token: 0x06000A41 RID: 2625
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x5963210", Offset = "0x5961E10", VA = "0x185963210")]
		[NativeMethod(Name = "CloneObject", IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private static extern Object Internal_CloneSingle([NotNull("NullExceptionObject")] Object data);

		// Token: 0x06000A42 RID: 2626
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x59631B0", Offset = "0x5961DB0", VA = "0x1859631B0")]
		[FreeFunction("CloneObject")]
		[MethodImpl(4096)]
		private static extern Object Internal_CloneSingleWithParent([NotNull("NullExceptionObject")] Object data, [NotNull("NullExceptionObject")] Transform parent, bool worldPositionStays);

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x59633C0", Offset = "0x5961FC0", VA = "0x1859633C0")]
		[FreeFunction("InstantiateObject")]
		private static Object Internal_InstantiateSingle([NotNull("NullExceptionObject")] Object data, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x59632C0", Offset = "0x5961EC0", VA = "0x1859632C0")]
		[FreeFunction("InstantiateObject")]
		private static Object Internal_InstantiateSingleWithParent([NotNull("NullExceptionObject")] Object data, [NotNull("NullExceptionObject")] Transform parent, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x06000A45 RID: 2629
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x59635B0", Offset = "0x59621B0", VA = "0x1859635B0")]
		[FreeFunction("UnityEngineObjectBindings::ToString")]
		[MethodImpl(4096)]
		private static extern string ToString(Object obj);

		// Token: 0x06000A46 RID: 2630
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x59623E0", Offset = "0x5960FE0", VA = "0x1859623E0")]
		[FreeFunction("UnityEngineObjectBindings::GetName")]
		[MethodImpl(4096)]
		private static extern string GetName([NotNull("NullExceptionObject")] Object obj);

		// Token: 0x06000A47 RID: 2631
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x59634B0", Offset = "0x59620B0", VA = "0x1859634B0")]
		[FreeFunction("UnityEngineObjectBindings::IsPersistent")]
		[MethodImpl(4096)]
		internal static extern bool IsPersistent([NotNull("NullExceptionObject")] Object obj);

		// Token: 0x06000A48 RID: 2632
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x59634F0", Offset = "0x59620F0", VA = "0x1859634F0")]
		[FreeFunction("UnityEngineObjectBindings::SetName")]
		[MethodImpl(4096)]
		private static extern void SetName([NotNull("NullExceptionObject")] Object obj, string name);

		// Token: 0x06000A49 RID: 2633
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x59617C0", Offset = "0x59603C0", VA = "0x1859617C0")]
		[NativeMethod(Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist", IsFreeFunction = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		internal static extern bool DoesObjectWithInstanceIDExist(int instanceID);

		// Token: 0x06000A4A RID: 2634
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x5961E70", Offset = "0x5960A70", VA = "0x185961E70")]
		[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
		[VisibleToOtherModules]
		[MethodImpl(4096)]
		internal static extern Object FindObjectFromInstanceID(int instanceID);

		// Token: 0x06000A4B RID: 2635
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x5962260", Offset = "0x5960E60", VA = "0x185962260")]
		[VisibleToOtherModules]
		[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
		[MethodImpl(4096)]
		internal static extern Object ForceLoadFromInstanceID(int instanceID);

		// Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Object()
		{
		}

		// Token: 0x06000A4E RID: 2638
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x5963360", Offset = "0x5961F60", VA = "0x185963360")]
		[MethodImpl(4096)]
		private static extern Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot);

		// Token: 0x06000A4F RID: 2639
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x5963250", Offset = "0x5961E50", VA = "0x185963250")]
		[MethodImpl(4096)]
		private static extern Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot);

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_CachedPtr;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static int OffsetOfInstanceIDInCPlusPlusObject;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		private const string objectIsNullMessage = "The Object you want to instantiate is null.";

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";
	}
}
