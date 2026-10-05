using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001E66 RID: 7782
	[Token(Token = "0x2001E66")]
	public class SequenceBasedMaterialTweenHandler : IMaterialTweenHandler
	{
		// Token: 0x0600C0FE RID: 49406 RVA: 0x00046EF0 File Offset: 0x000450F0
		[Token(Token = "0x600C0FE")]
		[Address(RVA = "0x33EA3B0", Offset = "0x33E8FB0", VA = "0x1833EA3B0", Slot = "4")]
		public bool PlayTweens(Material mat, List<MaterialTweenParam> tweens, [Optional] Action onComplete)
		{
			return default(bool);
		}

		// Token: 0x0600C0FF RID: 49407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0FF")]
		[Address(RVA = "0x33EA300", Offset = "0x33E8F00", VA = "0x1833EA300", Slot = "5")]
		public void KillAll(Material mat)
		{
		}

		// Token: 0x0600C100 RID: 49408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C100")]
		[Address(RVA = "0x33EA800", Offset = "0x33E9400", VA = "0x1833EA800")]
		public SequenceBasedMaterialTweenHandler()
		{
		}

		// Token: 0x0400C27F RID: 49791
		[Token(Token = "0x400C27F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<int, Sequence> _activeSeqs;
	}
}
