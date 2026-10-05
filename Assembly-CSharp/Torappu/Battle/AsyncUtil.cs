using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200214E RID: 8526
	[Token(Token = "0x200214E")]
	public static class AsyncUtil
	{
		// Token: 0x0600D1DD RID: 53725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1DD")]
		[Address(RVA = "0x3527E70", Offset = "0x3526A70", VA = "0x183527E70")]
		public static IEnumerator WaitForFixedSeconds(float time)
		{
			return null;
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1DE")]
		[Address(RVA = "0x3528080", Offset = "0x3526C80", VA = "0x183528080")]
		public static IEnumerator WaitWhileForFixedSeconds(Func<bool> predicate, float time)
		{
			return null;
		}

		// Token: 0x0600D1DF RID: 53727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1DF")]
		[Address(RVA = "0x3527EE0", Offset = "0x3526AE0", VA = "0x183527EE0")]
		public static IEnumerator WaitUntilForFixedSeconds(Func<bool> predicate, float time)
		{
			return null;
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1E0")]
		[Address(RVA = "0x3527D70", Offset = "0x3526970", VA = "0x183527D70")]
		public static IEnumerator WaitForConditionalFixedSeconds(float time, Func<bool> condition)
		{
			return null;
		}

		// Token: 0x0600D1E1 RID: 53729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1E1")]
		[Address(RVA = "0x3528000", Offset = "0x3526C00", VA = "0x183528000")]
		public static IEnumerator WaitWhileFixed(Func<bool> predicate)
		{
			return null;
		}

		// Token: 0x0600D1E2 RID: 53730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1E2")]
		[Address(RVA = "0x3527E00", Offset = "0x3526A00", VA = "0x183527E00")]
		public static IEnumerator WaitForFixedSeconds(FP time)
		{
			return null;
		}

		// Token: 0x0600D1E3 RID: 53731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1E3")]
		[Address(RVA = "0x3528110", Offset = "0x3526D10", VA = "0x183528110")]
		public static IEnumerator WaitWhileForFixedSeconds(Func<bool> predicate, FP time)
		{
			return null;
		}

		// Token: 0x0600D1E4 RID: 53732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1E4")]
		[Address(RVA = "0x3527F70", Offset = "0x3526B70", VA = "0x183527F70")]
		public static IEnumerator WaitUntilForFixedSeconds(Func<bool> predicate, FP time)
		{
			return null;
		}

		// Token: 0x0600D1E5 RID: 53733 RVA: 0x0004B990 File Offset: 0x00049B90
		[Token(Token = "0x600D1E5")]
		[Address(RVA = "0x3527B40", Offset = "0x3526740", VA = "0x183527B40")]
		public static CoroutineId InvokeFixedDelayGlobal(Action cb, float delay)
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D1E6 RID: 53734 RVA: 0x0004B9A8 File Offset: 0x00049BA8
		[Token(Token = "0x600D1E6")]
		[Address(RVA = "0x3527C60", Offset = "0x3526860", VA = "0x183527C60")]
		public static CoroutineId InvokeNextFixedFrameGlobal(Action cb)
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D1E7 RID: 53735 RVA: 0x0004B9C0 File Offset: 0x00049BC0
		[Token(Token = "0x600D1E7")]
		public static CoroutineId InvokeNextFixedFrame<T>(T mono, Action<T> cb) where T : MonoBehaviour
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D1E8 RID: 53736 RVA: 0x0004B9D8 File Offset: 0x00049BD8
		[Token(Token = "0x600D1E8")]
		public static CoroutineId InvokeNextFixedFrame<T>(T mono, Action cb) where T : MonoBehaviour
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D1E9 RID: 53737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1E9")]
		private static IEnumerator _InvokeNextFixedFrame<T>(T mono, Action<T> cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x0600D1EA RID: 53738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1EA")]
		private static IEnumerator _InvokeNextFixedFrame<T>(T mono, Action cb) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x0600D1EB RID: 53739 RVA: 0x0004B9F0 File Offset: 0x00049BF0
		[Token(Token = "0x600D1EB")]
		public static CoroutineId InvokeAsyncFixedSeconds<T>(T mono, Action<T> cb, float delay) where T : MonoBehaviour
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D1EC RID: 53740 RVA: 0x0004BA08 File Offset: 0x00049C08
		[Token(Token = "0x600D1EC")]
		public static CoroutineId InvokeAsyncFixedSeconds<T>(T mono, Action cb, float delay) where T : MonoBehaviour
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D1ED RID: 53741 RVA: 0x0004BA20 File Offset: 0x00049C20
		[Token(Token = "0x600D1ED")]
		public static CoroutineId InvokeAsyncConditionalFixedSeconds<T>(T mono, Action cb, float delay, Func<bool> condition) where T : MonoBehaviour
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D1EE RID: 53742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1EE")]
		private static IEnumerator _InvokeAsyncFixedSeconds<T>(T mono, Action<T> cb, float delay) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x0600D1EF RID: 53743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1EF")]
		private static IEnumerator _InvokeAsyncFixedSeconds<T>(T mono, Action cb, float delay) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x0600D1F0 RID: 53744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D1F0")]
		private static IEnumerator _InvokeAsyncConditionalFixedSeconds<T>(T mono, Action cb, float delay, Func<bool> condition) where T : MonoBehaviour
		{
			return null;
		}
	}
}
