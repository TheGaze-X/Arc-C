using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020039D0 RID: 14800
	[Token(Token = "0x20039D0")]
	public class UIBicolorText : MonoBehaviour
	{
		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0601760B RID: 95755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037FE")]
		public Text text
		{
			[Token(Token = "0x601760B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601760C RID: 95756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601760C")]
		[Address(RVA = "0xFBBF90", Offset = "0xFBAB90", VA = "0x180FBBF90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0601760D RID: 95757 RVA: 0x000963C0 File Offset: 0x000945C0
		// (set) Token: 0x0601760E RID: 95758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037FF")]
		public bool isHilight
		{
			[Token(Token = "0x601760D")]
			[Address(RVA = "0xFBC020", Offset = "0xFBAC20", VA = "0x180FBC020")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601760E")]
			[Address(RVA = "0xFBC0A0", Offset = "0xFBACA0", VA = "0x180FBC0A0")]
			set
			{
			}
		}

		// Token: 0x0601760F RID: 95759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601760F")]
		[Address(RVA = "0xFBC000", Offset = "0xFBAC00", VA = "0x180FBC000")]
		public UIBicolorText()
		{
		}

		// Token: 0x0401C3CB RID: 115659
		[Token(Token = "0x401C3CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0401C3CC RID: 115660
		[Token(Token = "0x401C3CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _colorHilight;

		// Token: 0x0401C3CD RID: 115661
		[Token(Token = "0x401C3CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0401C3CE RID: 115662
		[Token(Token = "0x401C3CE")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isHilight;

		// Token: 0x0401C3CF RID: 115663
		[Token(Token = "0x401C3CF")]
		[FieldOffset(Offset = "0x41")]
		private bool m_isInited;
	}
}
