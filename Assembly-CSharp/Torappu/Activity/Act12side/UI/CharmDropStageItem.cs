using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A79 RID: 31353
	[Token(Token = "0x2007A79")]
	public class CharmDropStageItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BEA8 RID: 179880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEA8")]
		[Address(RVA = "0x27D3870", Offset = "0x27D2470", VA = "0x1827D3870")]
		public void Flush(string stageID)
		{
		}

		// Token: 0x0602BEA9 RID: 179881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEA9")]
		[Address(RVA = "0x27D3A90", Offset = "0x27D2690", VA = "0x1827D3A90")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x0602BEAA RID: 179882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEAA")]
		[Address(RVA = "0x27D3760", Offset = "0x27D2360", VA = "0x1827D3760")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602BEAB RID: 179883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEAB")]
		[Address(RVA = "0x27D3B10", Offset = "0x27D2710", VA = "0x1827D3B10")]
		public CharmDropStageItem()
		{
		}

		// Token: 0x0403F9A3 RID: 260515
		[Token(Token = "0x403F9A3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _btnImage;

		// Token: 0x0403F9A4 RID: 260516
		[Token(Token = "0x403F9A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0403F9A5 RID: 260517
		[Token(Token = "0x403F9A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _validSprite;

		// Token: 0x0403F9A6 RID: 260518
		[Token(Token = "0x403F9A6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _validClr;

		// Token: 0x0403F9A7 RID: 260519
		[Token(Token = "0x403F9A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _invalidSprite;

		// Token: 0x0403F9A8 RID: 260520
		[Token(Token = "0x403F9A8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _invalidClr;

		// Token: 0x0403F9A9 RID: 260521
		[Token(Token = "0x403F9A9")]
		[FieldOffset(Offset = "0x58")]
		private StageData m_stage;

		// Token: 0x0403F9AA RID: 260522
		[Token(Token = "0x403F9AA")]
		[FieldOffset(Offset = "0x60")]
		private bool m_unlock;

		// Token: 0x0403F9AB RID: 260523
		[Token(Token = "0x403F9AB")]
		[FieldOffset(Offset = "0x61")]
		private bool m_timeout;

		// Token: 0x0403F9AC RID: 260524
		[Token(Token = "0x403F9AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x0403F9AD RID: 260525
		[Token(Token = "0x403F9AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x0403F9AE RID: 260526
		[Token(Token = "0x403F9AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403F9AF RID: 260527
		[Token(Token = "0x403F9AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
