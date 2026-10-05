using System;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200723B RID: 29243
	[Token(Token = "0x200723B")]
	public class Act5D1RuneStagePreview : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029705 RID: 169733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029705")]
		[Address(RVA = "0x24CC7F0", Offset = "0x24CB3F0", VA = "0x1824CC7F0")]
		public void OnClickMapDetail()
		{
		}

		// Token: 0x06029706 RID: 169734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029706")]
		[Address(RVA = "0x24CCDF0", Offset = "0x24CB9F0", VA = "0x1824CCDF0")]
		private void _InitifNot()
		{
		}

		// Token: 0x06029707 RID: 169735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029707")]
		[Address(RVA = "0x24CC8B0", Offset = "0x24CB4B0", VA = "0x1824CC8B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06029708 RID: 169736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029708")]
		[Address(RVA = "0x24CC850", Offset = "0x24CB450", VA = "0x1824CC850")]
		public void OnCloseMapDetail()
		{
		}

		// Token: 0x06029709 RID: 169737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029709")]
		[Address(RVA = "0x24CC940", Offset = "0x24CB540", VA = "0x1824CC940")]
		public void RenderInfo(string runeReId, string stageId)
		{
		}

		// Token: 0x0602970A RID: 169738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602970A")]
		[Address(RVA = "0x24CCEA0", Offset = "0x24CBAA0", VA = "0x1824CCEA0")]
		public Act5D1RuneStagePreview()
		{
		}

		// Token: 0x0403B337 RID: 242487
		[Token(Token = "0x403B337")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _mapPreview;

		// Token: 0x0403B338 RID: 242488
		[Token(Token = "0x403B338")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _mapPreviewLarge;

		// Token: 0x0403B339 RID: 242489
		[Token(Token = "0x403B339")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _mapBlur;

		// Token: 0x0403B33A RID: 242490
		[Token(Token = "0x403B33A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _groupImg;

		// Token: 0x0403B33B RID: 242491
		[Token(Token = "0x403B33B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _pointCount;

		// Token: 0x0403B33C RID: 242492
		[Token(Token = "0x403B33C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _countDownPart;

		// Token: 0x0403B33D RID: 242493
		[Token(Token = "0x403B33D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _countDownText;

		// Token: 0x0403B33E RID: 242494
		[Token(Token = "0x403B33E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _mapDesc;

		// Token: 0x0403B33F RID: 242495
		[Token(Token = "0x403B33F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0403B340 RID: 242496
		[Token(Token = "0x403B340")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x0403B341 RID: 242497
		[Token(Token = "0x403B341")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x0403B342 RID: 242498
		[Token(Token = "0x403B342")]
		[FieldOffset(Offset = "0x70")]
		private DirectAssetLoader m_directAssetsLoader;

		// Token: 0x0403B343 RID: 242499
		[Token(Token = "0x403B343")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickMapDetail;

		// Token: 0x0403B344 RID: 242500
		[Token(Token = "0x403B344")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitifNot;

		// Token: 0x0403B345 RID: 242501
		[Token(Token = "0x403B345")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403B346 RID: 242502
		[Token(Token = "0x403B346")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCloseMapDetail;

		// Token: 0x0403B347 RID: 242503
		[Token(Token = "0x403B347")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x0403B348 RID: 242504
		[Token(Token = "0x403B348")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
