using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class LifecycleHelper : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event Action<bool> onApplicationPausedEvent
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x4E07310", Offset = "0x4E05F10", VA = "0x184E07310")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x4E073C0", Offset = "0x4E05FC0", VA = "0x184E073C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x3104BA0", Offset = "0x31037A0", VA = "0x183104BA0")]
		private void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public LifecycleHelper()
		{
		}
	}
}
