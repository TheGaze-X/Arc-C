using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	[RequiredByNativeCode]
	public struct TileAnimationData
	{
		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x0")]
		private Sprite[] m_AnimatedSprites;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x8")]
		private float m_AnimationSpeed;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xC")]
		private float m_AnimationStartTime;
	}
}
