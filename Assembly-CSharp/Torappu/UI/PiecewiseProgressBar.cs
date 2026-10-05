using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003997 RID: 14743
	[Token(Token = "0x2003997")]
	public class PiecewiseProgressBar : MonoBehaviour
	{
		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x060174E5 RID: 95461 RVA: 0x00095E20 File Offset: 0x00094020
		// (set) Token: 0x060174E6 RID: 95462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037CC")]
		[Inspect(Level = 2)]
		public float progress
		{
			[Token(Token = "0x60174E5")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60174E6")]
			[Address(RVA = "0xFACFD0", Offset = "0xFABBD0", VA = "0x180FACFD0")]
			set
			{
			}
		}

		// Token: 0x060174E7 RID: 95463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174E7")]
		[Address(RVA = "0xFACFD0", Offset = "0xFABBD0", VA = "0x180FACFD0")]
		private void _SetProgressInternal(float value)
		{
		}

		// Token: 0x060174E8 RID: 95464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174E8")]
		[Address(RVA = "0xFAD100", Offset = "0xFABD00", VA = "0x180FAD100")]
		public PiecewiseProgressBar()
		{
		}

		// Token: 0x0401C21E RID: 115230
		[Token(Token = "0x401C21E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _progressSlots;

		// Token: 0x0401C21F RID: 115231
		[Token(Token = "0x401C21F")]
		[FieldOffset(Offset = "0x20")]
		private float m_progress;

		// Token: 0x0401C220 RID: 115232
		[Token(Token = "0x401C220")]
		[FieldOffset(Offset = "0x24")]
		private int m_activeCountCache;

		// Token: 0x0401C221 RID: 115233
		[Token(Token = "0x401C221")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInit;
	}
}
