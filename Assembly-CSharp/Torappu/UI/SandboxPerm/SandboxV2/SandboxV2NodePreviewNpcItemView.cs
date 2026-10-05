using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004271 RID: 17009
	[Token(Token = "0x2004271")]
	public class SandboxV2NodePreviewNpcItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A35F RID: 107359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A35F")]
		[Address(RVA = "0x131F240", Offset = "0x131DE40", VA = "0x18131F240")]
		public void Render(ILoadAsset assetLoader, string topicId, string floatId)
		{
		}

		// Token: 0x0601A360 RID: 107360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A360")]
		[Address(RVA = "0x131F370", Offset = "0x131DF70", VA = "0x18131F370")]
		public SandboxV2NodePreviewNpcItemView()
		{
		}

		// Token: 0x040212A8 RID: 135848
		[Token(Token = "0x40212A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _floatImage;

		// Token: 0x040212A9 RID: 135849
		[Token(Token = "0x40212A9")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedTopicId;

		// Token: 0x040212AA RID: 135850
		[Token(Token = "0x40212AA")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedFloatId;

		// Token: 0x040212AB RID: 135851
		[Token(Token = "0x40212AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040212AC RID: 135852
		[Token(Token = "0x40212AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
