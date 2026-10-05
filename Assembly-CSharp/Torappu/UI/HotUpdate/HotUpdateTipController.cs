using System;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A56 RID: 19030
	[Token(Token = "0x2004A56")]
	public class HotUpdateTipController : MonoBehaviour
	{
		// Token: 0x0601C9A5 RID: 117157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A5")]
		[Address(RVA = "0x160D640", Offset = "0x160C240", VA = "0x18160D640")]
		public void PickNewTip(bool isInit)
		{
		}

		// Token: 0x0601C9A6 RID: 117158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A6")]
		[Address(RVA = "0x160D600", Offset = "0x160C200", VA = "0x18160D600")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601C9A7 RID: 117159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A7")]
		[Address(RVA = "0x160D8A0", Offset = "0x160C4A0", VA = "0x18160D8A0")]
		public HotUpdateTipController()
		{
		}

		// Token: 0x040258DE RID: 153822
		[Token(Token = "0x40258DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x040258DF RID: 153823
		[Token(Token = "0x40258DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _descriptionText;

		// Token: 0x040258E0 RID: 153824
		[Token(Token = "0x40258E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x040258E1 RID: 153825
		[Token(Token = "0x40258E1")]
		[FieldOffset(Offset = "0x30")]
		private WorldViewTip m_lastTip;

		// Token: 0x040258E2 RID: 153826
		[Token(Token = "0x40258E2")]
		[FieldOffset(Offset = "0x38")]
		private DirectAssetLoader m_assetLoader;
	}
}
