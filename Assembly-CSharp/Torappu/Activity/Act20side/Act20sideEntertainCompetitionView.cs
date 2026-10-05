using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007686 RID: 30342
	[Token(Token = "0x2007686")]
	public class Act20sideEntertainCompetitionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AADE RID: 174814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AADE")]
		[Address(RVA = "0x2675EB0", Offset = "0x2674AB0", VA = "0x182675EB0")]
		public void Render(Act20sideEntertainCompViewModel viewModel, bool isRetro)
		{
		}

		// Token: 0x0602AADF RID: 174815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AADF")]
		[Address(RVA = "0x2676430", Offset = "0x2675030", VA = "0x182676430")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AAE0 RID: 174816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAE0")]
		[Address(RVA = "0x2676540", Offset = "0x2675140", VA = "0x182676540")]
		public Act20sideEntertainCompetitionView()
		{
		}

		// Token: 0x0403D7BF RID: 251839
		[Token(Token = "0x403D7BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelValidStage1;

		// Token: 0x0403D7C0 RID: 251840
		[Token(Token = "0x403D7C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtDescStage1;

		// Token: 0x0403D7C1 RID: 251841
		[Token(Token = "0x403D7C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgRankStage1;

		// Token: 0x0403D7C2 RID: 251842
		[Token(Token = "0x403D7C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLockStage1;

		// Token: 0x0403D7C3 RID: 251843
		[Token(Token = "0x403D7C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtUnlockStage1;

		// Token: 0x0403D7C4 RID: 251844
		[Token(Token = "0x403D7C4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _panelNewStage1;

		// Token: 0x0403D7C5 RID: 251845
		[Token(Token = "0x403D7C5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelValidStage2;

		// Token: 0x0403D7C6 RID: 251846
		[Token(Token = "0x403D7C6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtDescStage2;

		// Token: 0x0403D7C7 RID: 251847
		[Token(Token = "0x403D7C7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imgRankStage2;

		// Token: 0x0403D7C8 RID: 251848
		[Token(Token = "0x403D7C8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelLockStage2;

		// Token: 0x0403D7C9 RID: 251849
		[Token(Token = "0x403D7C9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtUnlockStage2;

		// Token: 0x0403D7CA RID: 251850
		[Token(Token = "0x403D7CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _panelNewStage2;

		// Token: 0x0403D7CB RID: 251851
		[Token(Token = "0x403D7CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _trackPointPrefab;

		// Token: 0x0403D7CC RID: 251852
		[Token(Token = "0x403D7CC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<string> _rankImageName;

		// Token: 0x0403D7CD RID: 251853
		[Token(Token = "0x403D7CD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasObject _rankImageObject;

		// Token: 0x0403D7CE RID: 251854
		[Token(Token = "0x403D7CE")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0403D7CF RID: 251855
		[Token(Token = "0x403D7CF")]
		[FieldOffset(Offset = "0x98")]
		private GameObject m_trackPointStage1;

		// Token: 0x0403D7D0 RID: 251856
		[Token(Token = "0x403D7D0")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_trackPointStage2;

		// Token: 0x0403D7D1 RID: 251857
		[Token(Token = "0x403D7D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D7D2 RID: 251858
		[Token(Token = "0x403D7D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D7D3 RID: 251859
		[Token(Token = "0x403D7D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
