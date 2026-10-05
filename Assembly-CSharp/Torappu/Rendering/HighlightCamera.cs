using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002056 RID: 8278
	[Token(Token = "0x2002056")]
	[RequireComponent(typeof(Camera))]
	public class HighlightCamera : MonoBehaviour
	{
		// Token: 0x0600CBF9 RID: 52217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBF9")]
		[Address(RVA = "0x34D4FD0", Offset = "0x34D3BD0", VA = "0x1834D4FD0")]
		private void Awake()
		{
		}

		// Token: 0x0600CBFA RID: 52218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBFA")]
		[Address(RVA = "0x34D5560", Offset = "0x34D4160", VA = "0x1834D5560")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CBFB RID: 52219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBFB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HighlightCamera()
		{
		}

		// Token: 0x0400D67F RID: 54911
		[Token(Token = "0x400D67F")]
		[FieldOffset(Offset = "0x18")]
		private Camera _highlightCamera;

		// Token: 0x0400D680 RID: 54912
		[Token(Token = "0x400D680")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture _renderTarget;

		// Token: 0x0400D681 RID: 54913
		[Token(Token = "0x400D681")]
		[FieldOffset(Offset = "0x28")]
		public HGSceneHighlightProfile _profile;
	}
}
