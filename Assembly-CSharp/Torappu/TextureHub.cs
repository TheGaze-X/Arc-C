using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000587 RID: 1415
	[Token(Token = "0x2000587")]
	public class TextureHub : MonoBehaviour
	{
		// Token: 0x06005BF4 RID: 23540 RVA: 0x0002F0A0 File Offset: 0x0002D2A0
		[Token(Token = "0x6005BF4")]
		[Address(RVA = "0x1CF9900", Offset = "0x1CF8500", VA = "0x181CF9900")]
		public bool TryGetTexture(string id, out Texture tex)
		{
			return default(bool);
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BF5")]
		[Address(RVA = "0x1CF9730", Offset = "0x1CF8330", VA = "0x181CF9730")]
		public Texture GetTextureOrDefault(string id)
		{
			return null;
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF6")]
		[Address(RVA = "0x1CF9AD0", Offset = "0x1CF86D0", VA = "0x181CF9AD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF7")]
		[Address(RVA = "0x1CF9C30", Offset = "0x1CF8830", VA = "0x181CF9C30")]
		public TextureHub()
		{
		}

		// Token: 0x04002196 RID: 8598
		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture _default;

		// Token: 0x04002197 RID: 8599
		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture[] _textures;

		// Token: 0x04002198 RID: 8600
		[Token(Token = "0x4002198")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Texture> m_textureHub;
	}
}
