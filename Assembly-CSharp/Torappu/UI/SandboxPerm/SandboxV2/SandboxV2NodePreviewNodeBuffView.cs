using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004270 RID: 17008
	[Token(Token = "0x2004270")]
	public class SandboxV2NodePreviewNodeBuffView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A35B RID: 107355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A35B")]
		[Address(RVA = "0x131EED0", Offset = "0x131DAD0", VA = "0x18131EED0")]
		public void OnBtnZoneBuffDetailClicked()
		{
		}

		// Token: 0x0601A35C RID: 107356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A35C")]
		[Address(RVA = "0x131F080", Offset = "0x131DC80", VA = "0x18131F080")]
		public void Render(string topicId, SandboxV2DungeonNodeBuffViewModel viewModel)
		{
		}

		// Token: 0x0601A35D RID: 107357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A35D")]
		[Address(RVA = "0x131EE60", Offset = "0x131DA60", VA = "0x18131EE60")]
		public void CloseZoneBuffDetail()
		{
		}

		// Token: 0x0601A35E RID: 107358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A35E")]
		[Address(RVA = "0x131F1E0", Offset = "0x131DDE0", VA = "0x18131F1E0")]
		public SandboxV2NodePreviewNodeBuffView()
		{
		}

		// Token: 0x0402129F RID: 135839
		[Token(Token = "0x402129F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _nodeBuffIcon;

		// Token: 0x040212A0 RID: 135840
		[Token(Token = "0x40212A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _nodeBuffPanel;

		// Token: 0x040212A1 RID: 135841
		[Token(Token = "0x40212A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2NodePreviewNodeBuffFloatPanel _nodeBuffFloatPanel;

		// Token: 0x040212A2 RID: 135842
		[Token(Token = "0x40212A2")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_finder;

		// Token: 0x040212A3 RID: 135843
		[Token(Token = "0x40212A3")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2DungeonNodeBuffViewModel m_cachedModel;

		// Token: 0x040212A4 RID: 135844
		[Token(Token = "0x40212A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBtnZoneBuffDetailClicked;

		// Token: 0x040212A5 RID: 135845
		[Token(Token = "0x40212A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040212A6 RID: 135846
		[Token(Token = "0x40212A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CloseZoneBuffDetail;

		// Token: 0x040212A7 RID: 135847
		[Token(Token = "0x40212A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
