using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001E6B RID: 7787
	[Token(Token = "0x2001E6B")]
	public class AVGMaterialTweenWrapper
	{
		// Token: 0x0600C10F RID: 49423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C10F")]
		[Address(RVA = "0x33DE130", Offset = "0x33DCD30", VA = "0x1833DE130")]
		public AVGMaterialTweenWrapper(AVGMaterialTweenWrapper.Mode mode = AVGMaterialTweenWrapper.Mode.Sequence)
		{
		}

		// Token: 0x0600C110 RID: 49424 RVA: 0x00046F20 File Offset: 0x00045120
		[Token(Token = "0x600C110")]
		[Address(RVA = "0x33DE000", Offset = "0x33DCC00", VA = "0x1833DE000")]
		public bool Play(Material mat, List<MaterialTweenParam> tweens, [Optional] Action onComplete)
		{
			return default(bool);
		}

		// Token: 0x0600C111 RID: 49425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C111")]
		[Address(RVA = "0x33DDF20", Offset = "0x33DCB20", VA = "0x1833DDF20")]
		public void Kill()
		{
		}

		// Token: 0x0400C28F RID: 49807
		[Token(Token = "0x400C28F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IMaterialTweenHandler m_handler;

		// Token: 0x0400C290 RID: 49808
		[Token(Token = "0x400C290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material m_material;

		// Token: 0x02001E6C RID: 7788
		[Token(Token = "0x2001E6C")]
		public enum Mode
		{
			// Token: 0x0400C292 RID: 49810
			[Token(Token = "0x400C292")]
			Sequence,
			// Token: 0x0400C293 RID: 49811
			[Token(Token = "0x400C293")]
			Batch
		}
	}
}
