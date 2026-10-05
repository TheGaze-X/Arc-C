using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200478B RID: 18315
	[Token(Token = "0x200478B")]
	public class RecalRuneStagePreviewState : PopupFloatState
	{
		// Token: 0x0601BB9F RID: 113567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB9F")]
		[Address(RVA = "0x150E1B0", Offset = "0x150CDB0", VA = "0x18150E1B0")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601BBA0 RID: 113568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA0")]
		[Address(RVA = "0x150E870", Offset = "0x150D470", VA = "0x18150E870")]
		public void OnHandBookClick()
		{
		}

		// Token: 0x0601BBA1 RID: 113569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BBA1")]
		[Address(RVA = "0x150E150", Offset = "0x150CD50", VA = "0x18150E150", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601BBA2 RID: 113570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA2")]
		[Address(RVA = "0x150E230", Offset = "0x150CE30", VA = "0x18150E230", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601BBA3 RID: 113571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA3")]
		[Address(RVA = "0x150E9E0", Offset = "0x150D5E0", VA = "0x18150E9E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BBA4 RID: 113572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA4")]
		[Address(RVA = "0x150EAF0", Offset = "0x150D6F0", VA = "0x18150EAF0")]
		private void _RenderLogo(string logoId)
		{
		}

		// Token: 0x0601BBA5 RID: 113573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA5")]
		[Address(RVA = "0x150EC20", Offset = "0x150D820", VA = "0x18150EC20")]
		private void _RenderPreview(string stageId, string levelId)
		{
		}

		// Token: 0x0601BBA6 RID: 113574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA6")]
		[Address(RVA = "0x150ED70", Offset = "0x150D970", VA = "0x18150ED70")]
		public RecalRuneStagePreviewState()
		{
		}

		// Token: 0x0601BBA7 RID: 113575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBA7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402408E RID: 147598
		[Token(Token = "0x402408E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _levelFromText;

		// Token: 0x0402408F RID: 147599
		[Token(Token = "0x402408F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _levelNameText;

		// Token: 0x04024090 RID: 147600
		[Token(Token = "0x4024090")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _descriptionText;

		// Token: 0x04024091 RID: 147601
		[Token(Token = "0x4024091")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIDynImage _logoImage;

		// Token: 0x04024092 RID: 147602
		[Token(Token = "0x4024092")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIDynImage _previewImage;

		// Token: 0x04024093 RID: 147603
		[Token(Token = "0x4024093")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04024094 RID: 147604
		[Token(Token = "0x4024094")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x04024095 RID: 147605
		[Token(Token = "0x4024095")]
		[FieldOffset(Offset = "0xA8")]
		private string m_stageId;

		// Token: 0x04024096 RID: 147606
		[Token(Token = "0x4024096")]
		[FieldOffset(Offset = "0xB0")]
		private string m_levelId;

		// Token: 0x04024097 RID: 147607
		[Token(Token = "0x4024097")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04024098 RID: 147608
		[Token(Token = "0x4024098")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnHandBookClick;

		// Token: 0x04024099 RID: 147609
		[Token(Token = "0x4024099")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402409A RID: 147610
		[Token(Token = "0x402409A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402409B RID: 147611
		[Token(Token = "0x402409B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402409C RID: 147612
		[Token(Token = "0x402409C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderLogo;

		// Token: 0x0402409D RID: 147613
		[Token(Token = "0x402409D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderPreview;

		// Token: 0x0402409E RID: 147614
		[Token(Token = "0x402409E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
