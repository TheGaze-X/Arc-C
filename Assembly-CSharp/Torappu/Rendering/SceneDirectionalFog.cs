using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200204D RID: 8269
	[Token(Token = "0x200204D")]
	public class SceneDirectionalFog : MonoBehaviour
	{
		// Token: 0x0600CBDC RID: 52188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDC")]
		[Address(RVA = "0x34CBC70", Offset = "0x34CA870", VA = "0x1834CBC70")]
		public SceneDirectionalFog()
		{
		}

		// Token: 0x0400D63F RID: 54847
		[Token(Token = "0x400D63F")]
		[FieldOffset(Offset = "0x18")]
		[Range(0.1f, 100f)]
		public float _distance;
	}
}
