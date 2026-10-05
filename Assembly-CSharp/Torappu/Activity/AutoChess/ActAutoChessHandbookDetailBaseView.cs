using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200710F RID: 28943
	[Token(Token = "0x200710F")]
	public abstract class ActAutoChessHandbookDetailBaseView : DataBinder<ActAutoChessHandbookProperty>, IHotfixable
	{
		// Token: 0x060291FD RID: 168445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291FD")]
		[Address(RVA = "0x2484250", Offset = "0x2482E50", VA = "0x182484250", Slot = "7")]
		public sealed override void OnValueChanged(ActAutoChessHandbookProperty property)
		{
		}

		// Token: 0x060291FE RID: 168446
		[Token(Token = "0x60291FE")]
		protected abstract void Render(ActAutoChessHandbookViewModel model);

		// Token: 0x060291FF RID: 168447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291FF")]
		[Address(RVA = "0x2484480", Offset = "0x2483080", VA = "0x182484480")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029200 RID: 168448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029200")]
		[Address(RVA = "0x2484560", Offset = "0x2483160", VA = "0x182484560")]
		protected ActAutoChessHandbookDetailBaseView()
		{
		}

		// Token: 0x0403AB85 RID: 240517
		[Token(Token = "0x403AB85")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403AB86 RID: 240518
		[Token(Token = "0x403AB86")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActAutoChessHandbookTabType _tabType;

		// Token: 0x0403AB87 RID: 240519
		[Token(Token = "0x403AB87")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ActAutoChessHandbookEnemyType _enemyType;

		// Token: 0x0403AB88 RID: 240520
		[Token(Token = "0x403AB88")]
		[FieldOffset(Offset = "0x30")]
		private UISwitchTween m_switchTween;

		// Token: 0x0403AB89 RID: 240521
		[Token(Token = "0x403AB89")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0403AB8A RID: 240522
		[Token(Token = "0x403AB8A")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedSequence;

		// Token: 0x0403AB8B RID: 240523
		[Token(Token = "0x403AB8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403AB8C RID: 240524
		[Token(Token = "0x403AB8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AB8D RID: 240525
		[Token(Token = "0x403AB8D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
