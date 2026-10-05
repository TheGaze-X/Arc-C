using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005119 RID: 20761
	[Token(Token = "0x2005119")]
	public class DeepSeaRPBattleStoryViewObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601EA97 RID: 125591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA97")]
		[Address(RVA = "0x1853C60", Offset = "0x1852860", VA = "0x181853C60")]
		public void Render(StageViewModel stageModel, StoryData storyData)
		{
		}

		// Token: 0x0601EA98 RID: 125592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA98")]
		[Address(RVA = "0x1853E20", Offset = "0x1852A20", VA = "0x181853E20")]
		public DeepSeaRPBattleStoryViewObject()
		{
		}

		// Token: 0x040291E5 RID: 168421
		[Token(Token = "0x40291E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x040291E6 RID: 168422
		[Token(Token = "0x40291E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x040291E7 RID: 168423
		[Token(Token = "0x40291E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040291E8 RID: 168424
		[Token(Token = "0x40291E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _btnPanel;

		// Token: 0x040291E9 RID: 168425
		[Token(Token = "0x40291E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040291EA RID: 168426
		[Token(Token = "0x40291EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
