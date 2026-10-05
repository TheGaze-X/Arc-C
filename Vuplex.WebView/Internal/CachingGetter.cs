using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	internal class CachingGetter<TResult>
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		public CachingGetter(Func<TResult> getterFunction, int cacheInvalidationPeriodSeconds, MonoBehaviour monoBehaviourForCoroutine)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003F4")]
		public TResult GetValue()
		{
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003F5")]
		private IEnumerator _invalidateCachePeriodically()
		{
			return null;
		}

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x0")]
		private Func<TResult> _getterFunction;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x0")]
		private bool _valueNeedsToBeUpdated;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x0")]
		private TResult _cachedValue;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x0")]
		private WaitForSeconds _waitForSeconds;
	}
}
