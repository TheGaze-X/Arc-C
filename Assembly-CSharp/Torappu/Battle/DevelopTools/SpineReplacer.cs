using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x02002890 RID: 10384
	[Token(Token = "0x2002890")]
	public class SpineReplacer : MonoBehaviour
	{
		// Token: 0x060114B4 RID: 70836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114B4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SpineReplacer()
		{
		}

		// Token: 0x04013502 RID: 79106
		[Token(Token = "0x4013502")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkeletonAnimation _skeleton;
	}
}
