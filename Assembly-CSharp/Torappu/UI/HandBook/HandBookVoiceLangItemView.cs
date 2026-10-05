using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066AB RID: 26283
	[Token(Token = "0x20066AB")]
	public class HandBookVoiceLangItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025C04 RID: 154628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C04")]
		[Address(RVA = "0x20B2BC0", Offset = "0x20B17C0", VA = "0x1820B2BC0")]
		public void Render(HandBookVoiceLangViewModel viewModel, int position)
		{
		}

		// Token: 0x06025C05 RID: 154629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C05")]
		[Address(RVA = "0x20B2AF0", Offset = "0x20B16F0", VA = "0x1820B2AF0")]
		public void OnVoiceLangItemClick()
		{
		}

		// Token: 0x06025C06 RID: 154630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C06")]
		[Address(RVA = "0x20B2D50", Offset = "0x20B1950", VA = "0x1820B2D50")]
		public HandBookVoiceLangItemView()
		{
		}

		// Token: 0x04035101 RID: 217345
		[Token(Token = "0x4035101")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectObj;

		// Token: 0x04035102 RID: 217346
		[Token(Token = "0x4035102")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unSelectObj;

		// Token: 0x04035103 RID: 217347
		[Token(Token = "0x4035103")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _voiceLangText;

		// Token: 0x04035104 RID: 217348
		[Token(Token = "0x4035104")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _cvText;

		// Token: 0x04035105 RID: 217349
		[Token(Token = "0x4035105")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hotspotObj;

		// Token: 0x04035106 RID: 217350
		[Token(Token = "0x4035106")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _unselectTagObj;

		// Token: 0x04035107 RID: 217351
		[Token(Token = "0x4035107")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectTagObj;

		// Token: 0x04035108 RID: 217352
		[Token(Token = "0x4035108")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<VoiceLangType> onItemClick;

		// Token: 0x04035109 RID: 217353
		[Token(Token = "0x4035109")]
		[FieldOffset(Offset = "0x58")]
		private VoiceLangType m_voiceLangType;

		// Token: 0x0403510A RID: 217354
		[Token(Token = "0x403510A")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_hasNoResource;

		// Token: 0x0403510B RID: 217355
		[Token(Token = "0x403510B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403510C RID: 217356
		[Token(Token = "0x403510C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnVoiceLangItemClick;

		// Token: 0x0403510D RID: 217357
		[Token(Token = "0x403510D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
