using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003930 RID: 14640
	[Token(Token = "0x2003930")]
	public class FillProgressBar : MonoBehaviour
	{
		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0601723F RID: 94783 RVA: 0x00094FF8 File Offset: 0x000931F8
		// (set) Token: 0x06017240 RID: 94784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003748")]
		[Inspect]
		public float progress
		{
			[Token(Token = "0x601723F")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017240")]
			[Address(RVA = "0xF862F0", Offset = "0xF84EF0", VA = "0x180F862F0")]
			set
			{
			}
		}

		// Token: 0x06017241 RID: 94785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017241")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FillProgressBar()
		{
		}

		// Token: 0x0401BEE9 RID: 114409
		[Token(Token = "0x401BEE9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageProgress;

		// Token: 0x0401BEEA RID: 114410
		[Token(Token = "0x401BEEA")]
		[FieldOffset(Offset = "0x20")]
		private float m_progress;
	}
}
