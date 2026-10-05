using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public class VulkanDelayedTextureDestroyer : MonoBehaviour
	{
		// Token: 0x06000476 RID: 1142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x5BD4AA0", Offset = "0x5BD36A0", VA = "0x185BD4AA0")]
		public static VulkanDelayedTextureDestroyer GetInstance(Action<IntPtr> destroyVulkanTextureFunction)
		{
			return null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x5BD49F0", Offset = "0x5BD35F0", VA = "0x185BD49F0")]
		public void DestroyTexture(IntPtr nativeTexture)
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x5BD4C20", Offset = "0x5BD3820", VA = "0x185BD4C20")]
		private void OnEnable()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x5BD4E50", Offset = "0x5BD3A50", VA = "0x185BD4E50")]
		private IEnumerator _destroyTexturesPeriodically()
		{
			return null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x5BD4CA0", Offset = "0x5BD38A0", VA = "0x185BD4CA0")]
		public VulkanDelayedTextureDestroyer()
		{
		}

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x18")]
		private Action<IntPtr> _destroyVulkanTextureFunction;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x20")]
		private int _indexOfTextureListActiveForDiscarding;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x0")]
		private static VulkanDelayedTextureDestroyer _instance;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x28")]
		private List<IntPtr>[] _textureLists;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x30")]
		private WaitForSeconds _waitShortDelay;
	}
}
