using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005995 RID: 22933
	[Token(Token = "0x2005995")]
	public class CrisisV2EntryTempButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060216DD RID: 136925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216DD")]
		[Address(RVA = "0x1BC0D70", Offset = "0x1BBF970", VA = "0x181BC0D70")]
		public void Render(CrisisV2EntryViewModel.TempPart tempPart)
		{
		}

		// Token: 0x060216DE RID: 136926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216DE")]
		[Address(RVA = "0x1BC0C70", Offset = "0x1BBF870", VA = "0x181BC0C70")]
		public void OnClickTemp()
		{
		}

		// Token: 0x060216DF RID: 136927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216DF")]
		[Address(RVA = "0x1BC1120", Offset = "0x1BBFD20", VA = "0x181BC1120")]
		public CrisisV2EntryTempButtonView()
		{
		}

		// Token: 0x0402D9CA RID: 186826
		[Token(Token = "0x402D9CA")]
		[FieldOffset(Offset = "0x18")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402D9CB RID: 186827
		[Token(Token = "0x402D9CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402D9CC RID: 186828
		[Token(Token = "0x402D9CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _code;

		// Token: 0x0402D9CD RID: 186829
		[Token(Token = "0x402D9CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x0402D9CE RID: 186830
		[Token(Token = "0x402D9CE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _zoneIcon;

		// Token: 0x0402D9CF RID: 186831
		[Token(Token = "0x402D9CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _canvasGroupPanel;

		// Token: 0x0402D9D0 RID: 186832
		[Token(Token = "0x402D9D0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _notOpenPart;

		// Token: 0x0402D9D1 RID: 186833
		[Token(Token = "0x402D9D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _openPart;

		// Token: 0x0402D9D2 RID: 186834
		[Token(Token = "0x402D9D2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _availPart;

		// Token: 0x0402D9D3 RID: 186835
		[Token(Token = "0x402D9D3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _inRewardTimePart;

		// Token: 0x0402D9D4 RID: 186836
		[Token(Token = "0x402D9D4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _outRewardTimePart;

		// Token: 0x0402D9D5 RID: 186837
		[Token(Token = "0x402D9D5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _allResPart;

		// Token: 0x0402D9D6 RID: 186838
		[Token(Token = "0x402D9D6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Graphic _imgLogoBg;

		// Token: 0x0402D9D7 RID: 186839
		[Token(Token = "0x402D9D7")]
		[FieldOffset(Offset = "0x88")]
		private CrisisV2EntryViewModel.TempPart m_cacheViewModel;

		// Token: 0x0402D9D8 RID: 186840
		[Token(Token = "0x402D9D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D9D9 RID: 186841
		[Token(Token = "0x402D9D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickTemp;

		// Token: 0x0402D9DA RID: 186842
		[Token(Token = "0x402D9DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
