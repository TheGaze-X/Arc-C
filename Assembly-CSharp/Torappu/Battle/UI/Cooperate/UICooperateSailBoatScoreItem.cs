using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x0200341C RID: 13340
	[Token(Token = "0x200341C")]
	public class UICooperateSailBoatScoreItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601551E RID: 87326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601551E")]
		[Address(RVA = "0xDDA8F0", Offset = "0xDD94F0", VA = "0x180DDA8F0")]
		public void UpdateProgress(float progressValue)
		{
		}

		// Token: 0x0601551F RID: 87327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601551F")]
		[Address(RVA = "0xDDA680", Offset = "0xDD9280", VA = "0x180DDA680")]
		public void ShowGetScoreAnim()
		{
		}

		// Token: 0x06015520 RID: 87328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015520")]
		[Address(RVA = "0xDDA770", Offset = "0xDD9370", VA = "0x180DDA770")]
		public void ShowSwitchGoalAnim()
		{
		}

		// Token: 0x06015521 RID: 87329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015521")]
		[Address(RVA = "0xDDA840", Offset = "0xDD9440", VA = "0x180DDA840")]
		public void ShowSwitchLoseGoalAnim()
		{
		}

		// Token: 0x06015522 RID: 87330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015522")]
		[Address(RVA = "0xDDA970", Offset = "0xDD9570", VA = "0x180DDA970")]
		public UICooperateSailBoatScoreItem()
		{
		}

		// Token: 0x040197EC RID: 104428
		[Token(Token = "0x40197EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _progress;

		// Token: 0x040197ED RID: 104429
		[Token(Token = "0x40197ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _switchGoalAnim;

		// Token: 0x040197EE RID: 104430
		[Token(Token = "0x40197EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _getScoreAnim;

		// Token: 0x040197EF RID: 104431
		[Token(Token = "0x40197EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateProgress;

		// Token: 0x040197F0 RID: 104432
		[Token(Token = "0x40197F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowGetScoreAnim;

		// Token: 0x040197F1 RID: 104433
		[Token(Token = "0x40197F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowSwitchGoalAnim;

		// Token: 0x040197F2 RID: 104434
		[Token(Token = "0x40197F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowSwitchLoseGoalAnim;

		// Token: 0x040197F3 RID: 104435
		[Token(Token = "0x40197F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
