using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E82 RID: 16002
	[Token(Token = "0x2003E82")]
	public abstract class SpecialOperatorPointViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018DD7 RID: 101847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DD7")]
		[Address(RVA = "0x118ED40", Offset = "0x118D940", VA = "0x18118ED40", Slot = "4")]
		protected virtual void OnRender()
		{
		}

		// Token: 0x06018DD8 RID: 101848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DD8")]
		[Address(RVA = "0x118ECE0", Offset = "0x118D8E0", VA = "0x18118ECE0", Slot = "5")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x06018DD9 RID: 101849
		[Token(Token = "0x17003B59")]
		public abstract SpecialOperatorPointViewType viewType { [Token(Token = "0x6018DD9")] get; }

		// Token: 0x06018DDA RID: 101850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DDA")]
		[Address(RVA = "0x1195140", Offset = "0x1193D40", VA = "0x181195140")]
		public void Init(SpecialOperatorDiagramPointModel pointModel, SpecialOperatorBoardLvlupModelWithDiagram lvlupModel, SpecialOperatorBoardMainModel boardViewModel)
		{
		}

		// Token: 0x06018DDB RID: 101851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DDB")]
		[Address(RVA = "0x1195390", Offset = "0x1193F90", VA = "0x181195390")]
		private void _SetPos(Vector2 pos)
		{
		}

		// Token: 0x06018DDC RID: 101852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DDC")]
		[Address(RVA = "0x11952B0", Offset = "0x1193EB0", VA = "0x1811952B0")]
		public void Render(SpecialOperatorDiagramPointModel pointModel, SpecialOperatorBoardLvlupModelWithDiagram lvlupModel, SpecialOperatorBoardMainModel boardViewModel)
		{
		}

		// Token: 0x06018DDD RID: 101853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DDD")]
		[Address(RVA = "0x1195420", Offset = "0x1194020", VA = "0x181195420")]
		protected SpecialOperatorPointViewBase()
		{
		}

		// Token: 0x0401E9EF RID: 125423
		[Token(Token = "0x401E9EF")]
		[FieldOffset(Offset = "0x18")]
		protected SpecialOperatorDiagramPointModel m_pointModel;

		// Token: 0x0401E9F0 RID: 125424
		[Token(Token = "0x401E9F0")]
		[FieldOffset(Offset = "0x20")]
		protected SpecialOperatorBoardLvlupModelWithDiagram m_lvlupModel;

		// Token: 0x0401E9F1 RID: 125425
		[Token(Token = "0x401E9F1")]
		[FieldOffset(Offset = "0x28")]
		protected SpecialOperatorBoardMainModel m_boardViewModel;

		// Token: 0x0401E9F2 RID: 125426
		[Token(Token = "0x401E9F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401E9F3 RID: 125427
		[Token(Token = "0x401E9F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401E9F4 RID: 125428
		[Token(Token = "0x401E9F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E9F5 RID: 125429
		[Token(Token = "0x401E9F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetPos;

		// Token: 0x0401E9F6 RID: 125430
		[Token(Token = "0x401E9F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E9F7 RID: 125431
		[Token(Token = "0x401E9F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E83 RID: 16003
		[Token(Token = "0x2003E83")]
		public interface ISelectAnchorHolder
		{
			// Token: 0x06018DDE RID: 101854
			[Token(Token = "0x6018DDE")]
			RectTransform GetSelectAnchor();
		}
	}
}
