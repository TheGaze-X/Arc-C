using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	[ExtensionOfNativeClass]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
	[RequiredByNativeCode]
	public class MonoBehaviour : Behaviour
	{
		// Token: 0x060009B2 RID: 2482 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x5960660", Offset = "0x595F260", VA = "0x185960660")]
		public bool IsInvoking()
		{
			return default(bool);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x5960590", Offset = "0x595F190", VA = "0x185960590")]
		public void CancelInvoke()
		{
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x59607E0", Offset = "0x595F3E0", VA = "0x1859607E0")]
		public void Invoke(string methodName, float time)
		{
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x5960710", Offset = "0x595F310", VA = "0x185960710")]
		public void InvokeRepeating(string methodName, float time, float repeatRate)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x59605D0", Offset = "0x595F1D0", VA = "0x1859605D0")]
		public void CancelInvoke(string methodName)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x5960840", Offset = "0x595F440", VA = "0x185960840")]
		public bool IsInvoking(string methodName)
		{
			return default(bool);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x5960AA0", Offset = "0x595F6A0", VA = "0x185960AA0")]
		[ExcludeFromDocs]
		public Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x5960BD0", Offset = "0x595F7D0", VA = "0x185960BD0")]
		public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value)
		{
			return null;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x5960980", Offset = "0x595F580", VA = "0x185960980")]
		public Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x5960980", Offset = "0x595F580", VA = "0x185960980")]
		[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", false)]
		public Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x5960F50", Offset = "0x595FB50", VA = "0x185960F50")]
		public void StopCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x5960E30", Offset = "0x595FA30", VA = "0x185960E30")]
		public void StopCoroutine(Coroutine routine)
		{
		}

		// Token: 0x060009BE RID: 2494
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x5960DE0", Offset = "0x595F9E0", VA = "0x185960DE0")]
		[MethodImpl(4096)]
		public extern void StopCoroutine(string methodName);

		// Token: 0x060009BF RID: 2495
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x5960D00", Offset = "0x595F900", VA = "0x185960D00")]
		[MethodImpl(4096)]
		public extern void StopAllCoroutines();

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060009C0 RID: 2496
		// (set) Token: 0x060009C1 RID: 2497
		[Token(Token = "0x17000203")]
		public extern bool useGUILayout { [Token(Token = "0x60009C0")] [Address(RVA = "0x5961070", Offset = "0x595FC70", VA = "0x185961070")] [MethodImpl(4096)] get; [Token(Token = "0x60009C1")] [Address(RVA = "0x5961100", Offset = "0x595FD00", VA = "0x185961100")] [MethodImpl(4096)] set; }

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x59610B0", Offset = "0x595FCB0", VA = "0x1859610B0")]
		public static void print(object message)
		{
		}

		// Token: 0x060009C3 RID: 2499
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x5960590", Offset = "0x595F190", VA = "0x185960590")]
		[FreeFunction("CancelInvoke")]
		[MethodImpl(4096)]
		private static extern void Internal_CancelInvokeAll([NotNull("NullExceptionObject")] MonoBehaviour self);

		// Token: 0x060009C4 RID: 2500
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x5960660", Offset = "0x595F260", VA = "0x185960660")]
		[FreeFunction("IsInvoking")]
		[MethodImpl(4096)]
		private static extern bool Internal_IsInvokingAll([NotNull("NullExceptionObject")] MonoBehaviour self);

		// Token: 0x060009C5 RID: 2501
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x59606A0", Offset = "0x595F2A0", VA = "0x1859606A0")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern void InvokeDelayed([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName, float time, float repeatRate);

		// Token: 0x060009C6 RID: 2502
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x59605D0", Offset = "0x595F1D0", VA = "0x1859605D0")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern void CancelInvoke([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName);

		// Token: 0x060009C7 RID: 2503
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x5960840", Offset = "0x595F440", VA = "0x185960840")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern bool IsInvoking([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName);

		// Token: 0x060009C8 RID: 2504
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x5960890", Offset = "0x595F490", VA = "0x185960890")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern bool IsObjectMonoBehaviour([NotNull("NullExceptionObject")] Object obj);

		// Token: 0x060009C9 RID: 2505
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x5960920", Offset = "0x595F520", VA = "0x185960920")]
		[MethodImpl(4096)]
		private extern Coroutine StartCoroutineManaged(string methodName, object value);

		// Token: 0x060009CA RID: 2506
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x59608D0", Offset = "0x595F4D0", VA = "0x1859608D0")]
		[MethodImpl(4096)]
		private extern Coroutine StartCoroutineManaged2(IEnumerator enumerator);

		// Token: 0x060009CB RID: 2507
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x5960D90", Offset = "0x595F990", VA = "0x185960D90")]
		[MethodImpl(4096)]
		private extern void StopCoroutineManaged(Coroutine routine);

		// Token: 0x060009CC RID: 2508
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x5960D40", Offset = "0x595F940", VA = "0x185960D40")]
		[MethodImpl(4096)]
		private extern void StopCoroutineFromEnumeratorManaged(IEnumerator routine);

		// Token: 0x060009CD RID: 2509
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x5960620", Offset = "0x595F220", VA = "0x185960620")]
		[MethodImpl(4096)]
		internal extern string GetScriptClassName();

		// Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public MonoBehaviour()
		{
		}
	}
}
