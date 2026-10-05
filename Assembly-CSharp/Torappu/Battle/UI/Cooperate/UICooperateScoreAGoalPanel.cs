using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033EB RID: 13291
	[Token(Token = "0x20033EB")]
	public class UICooperateScoreAGoalPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015364 RID: 86884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015364")]
		[Address(RVA = "0xDA8B60", Offset = "0xDA7760", VA = "0x180DA8B60")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x06015365 RID: 86885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015365")]
		[Address(RVA = "0xDA8CA0", Offset = "0xDA78A0", VA = "0x180DA8CA0")]
		public void OnUpdateScoreInfo(SideTypeIndex sideTypeIndex, Action callback)
		{
		}

		// Token: 0x06015366 RID: 86886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015366")]
		[Address(RVA = "0xDA8EC0", Offset = "0xDA7AC0", VA = "0x180DA8EC0")]
		public UICooperateScoreAGoalPanel()
		{
		}

		// Token: 0x04019555 RID: 103765
		[Token(Token = "0x4019555")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public UIPerform _uiPerform;

		// Token: 0x04019556 RID: 103766
		[Token(Token = "0x4019556")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _allyImage;

		// Token: 0x04019557 RID: 103767
		[Token(Token = "0x4019557")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _enemyImage;

		// Token: 0x04019558 RID: 103768
		[Token(Token = "0x4019558")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x04019559 RID: 103769
		[Token(Token = "0x4019559")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdateScoreInfo;

		// Token: 0x0401955A RID: 103770
		[Token(Token = "0x401955A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
