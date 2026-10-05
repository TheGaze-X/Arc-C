using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007226 RID: 29222
	[Token(Token = "0x2007226")]
	public class Act5D1StageEntryButtonObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296B4 RID: 169652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B4")]
		[Address(RVA = "0x24D1FC0", Offset = "0x24D0BC0", VA = "0x1824D1FC0")]
		public void RenderStage(string stageId, Act5D1Data.RuneRecurrentStateData recurrentData)
		{
		}

		// Token: 0x060296B5 RID: 169653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B5")]
		[Address(RVA = "0x24D1F40", Offset = "0x24D0B40", VA = "0x1824D1F40")]
		public void OnClick()
		{
		}

		// Token: 0x060296B6 RID: 169654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B6")]
		[Address(RVA = "0x24D2290", Offset = "0x24D0E90", VA = "0x1824D2290")]
		public Act5D1StageEntryButtonObj()
		{
		}

		// Token: 0x0403B273 RID: 242291
		[Token(Token = "0x403B273")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403B274 RID: 242292
		[Token(Token = "0x403B274")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403B275 RID: 242293
		[Token(Token = "0x403B275")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0403B276 RID: 242294
		[Token(Token = "0x403B276")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _groupName;

		// Token: 0x0403B277 RID: 242295
		[Token(Token = "0x403B277")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _remainTime;

		// Token: 0x0403B278 RID: 242296
		[Token(Token = "0x403B278")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _remainText;

		// Token: 0x0403B279 RID: 242297
		[Token(Token = "0x403B279")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _onClick;

		// Token: 0x0403B27A RID: 242298
		[Token(Token = "0x403B27A")]
		[FieldOffset(Offset = "0x50")]
		private string m_cacheStageId;

		// Token: 0x0403B27B RID: 242299
		[Token(Token = "0x403B27B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x0403B27C RID: 242300
		[Token(Token = "0x403B27C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B27D RID: 242301
		[Token(Token = "0x403B27D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
