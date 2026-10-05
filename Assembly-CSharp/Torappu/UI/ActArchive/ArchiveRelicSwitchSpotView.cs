using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C15 RID: 27669
	[Token(Token = "0x2006C15")]
	public class ArchiveRelicSwitchSpotView : MonoBehaviour
	{
		// Token: 0x0602781A RID: 161818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602781A")]
		[Address(RVA = "0x22B3C30", Offset = "0x22B2830", VA = "0x1822B3C30")]
		public void Render(bool attained, bool selected)
		{
		}

		// Token: 0x0602781B RID: 161819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602781B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ArchiveRelicSwitchSpotView()
		{
		}

		// Token: 0x04038030 RID: 229424
		[Token(Token = "0x4038030")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _spotImage;

		// Token: 0x04038031 RID: 229425
		[Token(Token = "0x4038031")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedPanel;

		// Token: 0x04038032 RID: 229426
		[Token(Token = "0x4038032")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _attainedColor;

		// Token: 0x04038033 RID: 229427
		[Token(Token = "0x4038033")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _unattainedColor;
	}
}
