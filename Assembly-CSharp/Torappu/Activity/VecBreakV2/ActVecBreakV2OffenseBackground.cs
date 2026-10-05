using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E4F RID: 28239
	[Token(Token = "0x2006E4F")]
	public class ActVecBreakV2OffenseBackground : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028310 RID: 164624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028310")]
		[Address(RVA = "0x2376EE0", Offset = "0x2375AE0", VA = "0x182376EE0")]
		public void UpdateThemeColor(Color themeColor)
		{
		}

		// Token: 0x06028311 RID: 164625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028311")]
		[Address(RVA = "0x2377190", Offset = "0x2375D90", VA = "0x182377190")]
		public ActVecBreakV2OffenseBackground()
		{
		}

		// Token: 0x0403913D RID: 233789
		[Token(Token = "0x403913D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _backThemeImage;

		// Token: 0x0403913E RID: 233790
		[Token(Token = "0x403913E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image[] _backThemeFxImages;

		// Token: 0x0403913F RID: 233791
		[Token(Token = "0x403913F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleSystem[] _backThemeParticles;

		// Token: 0x04039140 RID: 233792
		[Token(Token = "0x4039140")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateThemeColor;

		// Token: 0x04039141 RID: 233793
		[Token(Token = "0x4039141")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
