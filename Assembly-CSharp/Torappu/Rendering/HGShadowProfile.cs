using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002066 RID: 8294
	[Token(Token = "0x2002066")]
	[CreateAssetMenu(menuName = "HGEffect/new shadow profile")]
	[Serializable]
	public class HGShadowProfile : ScriptableObject
	{
		// Token: 0x0600CC4A RID: 52298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC4A")]
		[Address(RVA = "0x34D4FB0", Offset = "0x34D3BB0", VA = "0x1834D4FB0")]
		public HGShadowProfile()
		{
		}

		// Token: 0x0400D6D6 RID: 54998
		[Token(Token = "0x400D6D6")]
		[FieldOffset(Offset = "0x18")]
		[Range(64f, 1024f)]
		[Tooltip("power of 2")]
		public int shadowMapSize;

		// Token: 0x0400D6D7 RID: 54999
		[Token(Token = "0x400D6D7")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 0.2f)]
		public float blur;

		// Token: 0x0400D6D8 RID: 55000
		[Token(Token = "0x400D6D8")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 0.02f)]
		public float bias;

		// Token: 0x0400D6D9 RID: 55001
		[Token(Token = "0x400D6D9")]
		[FieldOffset(Offset = "0x28")]
		public Shader shadowShader;
	}
}
