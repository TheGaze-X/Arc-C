using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002051 RID: 8273
	[Token(Token = "0x2002051")]
	[CreateAssetMenu(menuName = "Torappu/Fog Profile")]
	public class FogProfile : ScriptableObject
	{
		// Token: 0x0600CBEC RID: 52204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBEC")]
		[Address(RVA = "0x34D0A10", Offset = "0x34CF610", VA = "0x1834D0A10")]
		public FogProfile()
		{
		}

		// Token: 0x0400D66F RID: 54895
		[Token(Token = "0x400D66F")]
		[FieldOffset(Offset = "0x18")]
		[Range(2f, 16f)]
		[Tooltip("32,512")]
		public int rtSize;

		// Token: 0x0400D670 RID: 54896
		[Token(Token = "0x400D670")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public GameObject fogTile;
	}
}
