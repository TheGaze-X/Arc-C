using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x02007910 RID: 30992
	[Token(Token = "0x2007910")]
	public class GameCityWaveStartPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B79A RID: 178074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B79A")]
		[Address(RVA = "0x275F920", Offset = "0x275E520", VA = "0x18275F920")]
		public void OnUpdateWaveInfo(int currWaveCnt, int maxWaveCnt)
		{
		}

		// Token: 0x0602B79B RID: 178075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B79B")]
		[Address(RVA = "0x275FCF0", Offset = "0x275E8F0", VA = "0x18275FCF0")]
		public GameCityWaveStartPanel()
		{
		}

		// Token: 0x0403EDD0 RID: 257488
		[Token(Token = "0x403EDD0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _maxWaveText;

		// Token: 0x0403EDD1 RID: 257489
		[Token(Token = "0x403EDD1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _maxWaveTextShadow;

		// Token: 0x0403EDD2 RID: 257490
		[Token(Token = "0x403EDD2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _curWaveText;

		// Token: 0x0403EDD3 RID: 257491
		[Token(Token = "0x403EDD3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curWaveTextShadow;

		// Token: 0x0403EDD4 RID: 257492
		[Token(Token = "0x403EDD4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _curWaveShowText;

		// Token: 0x0403EDD5 RID: 257493
		[Token(Token = "0x403EDD5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _curWaveShowTextShadow;

		// Token: 0x0403EDD6 RID: 257494
		[Token(Token = "0x403EDD6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _atlasImage;

		// Token: 0x0403EDD7 RID: 257495
		[Token(Token = "0x403EDD7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _atlasObj;

		// Token: 0x0403EDD8 RID: 257496
		[Token(Token = "0x403EDD8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _atlasImageShadow;

		// Token: 0x0403EDD9 RID: 257497
		[Token(Token = "0x403EDD9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<string> _waveTextShow;

		// Token: 0x0403EDDA RID: 257498
		[Token(Token = "0x403EDDA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<string> _waveIconShow;

		// Token: 0x0403EDDB RID: 257499
		[Token(Token = "0x403EDDB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public UIPerform uiPerform;

		// Token: 0x0403EDDC RID: 257500
		[Token(Token = "0x403EDDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdateWaveInfo;

		// Token: 0x0403EDDD RID: 257501
		[Token(Token = "0x403EDDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
