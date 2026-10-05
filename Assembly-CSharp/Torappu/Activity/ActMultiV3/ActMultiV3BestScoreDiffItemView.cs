using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F8D RID: 28557
	[Token(Token = "0x2006F8D")]
	public class ActMultiV3BestScoreDiffItemView : ActMultiV3QuickMatchDiffItemView
	{
		// Token: 0x0602888D RID: 166029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602888D")]
		[Address(RVA = "0x23D3D30", Offset = "0x23D2930", VA = "0x1823D3D30", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0602888E RID: 166030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602888E")]
		[Address(RVA = "0x23D4190", Offset = "0x23D2D90", VA = "0x1823D4190")]
		public ActMultiV3BestScoreDiffItemView()
		{
		}

		// Token: 0x0602888F RID: 166031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602888F")]
		[Address(RVA = "0x23D4130", Offset = "0x23D2D30", VA = "0x1823D4130")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x04039B67 RID: 236391
		[Token(Token = "0x4039B67")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _bestRecordPartGO;

		// Token: 0x04039B68 RID: 236392
		[Token(Token = "0x4039B68")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textBestRecord;

		// Token: 0x04039B69 RID: 236393
		[Token(Token = "0x4039B69")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textCaption;

		// Token: 0x04039B6A RID: 236394
		[Token(Token = "0x4039B6A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _colorRecordUnselect;

		// Token: 0x04039B6B RID: 236395
		[Token(Token = "0x4039B6B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _colorRecordSelect;

		// Token: 0x04039B6C RID: 236396
		[Token(Token = "0x4039B6C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _colorCaptionUnselect;

		// Token: 0x04039B6D RID: 236397
		[Token(Token = "0x4039B6D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _colorCaptionSelect;

		// Token: 0x04039B6E RID: 236398
		[Token(Token = "0x4039B6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04039B6F RID: 236399
		[Token(Token = "0x4039B6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
