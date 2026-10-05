using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000569 RID: 1385
	[Token(Token = "0x2000569")]
	[RequireComponent(typeof(Camera))]
	public class PerspectiveCameraScaler : MonoBehaviour
	{
		// Token: 0x06005B6A RID: 23402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6A")]
		[Address(RVA = "0x1AF72E0", Offset = "0x1AF5EE0", VA = "0x181AF72E0")]
		public static void UpdateViewport(Camera camera, float minRatioThreshold)
		{
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x1AF71C0", Offset = "0x1AF5DC0", VA = "0x181AF71C0")]
		private void Start()
		{
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PerspectiveCameraScaler()
		{
		}

		// Token: 0x040020FB RID: 8443
		[Token(Token = "0x40020FB")]
		public const float STANDARD_RATIO_THRESHOLD = 1.7777778f;
	}
}
