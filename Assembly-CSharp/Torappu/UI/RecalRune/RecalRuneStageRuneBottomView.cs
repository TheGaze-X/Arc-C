using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047B2 RID: 18354
	[Token(Token = "0x20047B2")]
	public class RecalRuneStageRuneBottomView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BCA2 RID: 113826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCA2")]
		[Address(RVA = "0x15301A0", Offset = "0x152EDA0", VA = "0x1815301A0")]
		public void Render(RecalRuneStageRuneViewModel model)
		{
		}

		// Token: 0x0601BCA3 RID: 113827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCA3")]
		[Address(RVA = "0x1530270", Offset = "0x152EE70", VA = "0x181530270")]
		private void _RenderStaticInfo(RecalRuneStageRuneViewModel model)
		{
		}

		// Token: 0x0601BCA4 RID: 113828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCA4")]
		[Address(RVA = "0x1530450", Offset = "0x152F050", VA = "0x181530450")]
		public RecalRuneStageRuneBottomView()
		{
		}

		// Token: 0x0402424B RID: 148043
		[Token(Token = "0x402424B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _tipsText;

		// Token: 0x0402424C RID: 148044
		[Token(Token = "0x402424C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _selectedScoreText;

		// Token: 0x0402424D RID: 148045
		[Token(Token = "0x402424D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _stagePreviewImage;

		// Token: 0x0402424E RID: 148046
		[Token(Token = "0x402424E")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedStageId;

		// Token: 0x0402424F RID: 148047
		[Token(Token = "0x402424F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024250 RID: 148048
		[Token(Token = "0x4024250")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderStaticInfo;

		// Token: 0x04024251 RID: 148049
		[Token(Token = "0x4024251")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
