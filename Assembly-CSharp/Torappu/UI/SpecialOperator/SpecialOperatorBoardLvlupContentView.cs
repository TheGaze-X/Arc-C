using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E62 RID: 15970
	[Token(Token = "0x2003E62")]
	public abstract class SpecialOperatorBoardLvlupContentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018D6D RID: 101741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D6D")]
		[Address(RVA = "0x116AFA0", Offset = "0x1169BA0", VA = "0x18116AFA0", Slot = "4")]
		public virtual void Render(SpecialOperatorBoardLvlupModel model, SpecialOperatorBoardLvlupContentView.Param param)
		{
		}

		// Token: 0x06018D6E RID: 101742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D6E")]
		[Address(RVA = "0x116B110", Offset = "0x1169D10", VA = "0x18116B110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018D6F RID: 101743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D6F")]
		[Address(RVA = "0x116B1C0", Offset = "0x1169DC0", VA = "0x18116B1C0")]
		protected SpecialOperatorBoardLvlupContentView()
		{
		}

		// Token: 0x0401E8AF RID: 125103
		[Token(Token = "0x401E8AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0401E8B0 RID: 125104
		[Token(Token = "0x401E8B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _duration;

		// Token: 0x0401E8B1 RID: 125105
		[Token(Token = "0x401E8B1")]
		[FieldOffset(Offset = "0x24")]
		private bool m_inited;

		// Token: 0x0401E8B2 RID: 125106
		[Token(Token = "0x401E8B2")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0401E8B3 RID: 125107
		[Token(Token = "0x401E8B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E8B4 RID: 125108
		[Token(Token = "0x401E8B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E8B5 RID: 125109
		[Token(Token = "0x401E8B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E63 RID: 15971
		[Token(Token = "0x2003E63")]
		public struct Param
		{
			// Token: 0x0401E8B6 RID: 125110
			[Token(Token = "0x401E8B6")]
			[FieldOffset(Offset = "0x0")]
			public bool isFirstRender;

			// Token: 0x0401E8B7 RID: 125111
			[Token(Token = "0x401E8B7")]
			[FieldOffset(Offset = "0x1")]
			public bool isContentSwitch;

			// Token: 0x0401E8B8 RID: 125112
			[Token(Token = "0x401E8B8")]
			[FieldOffset(Offset = "0x2")]
			public bool isSelected;

			// Token: 0x0401E8B9 RID: 125113
			[Token(Token = "0x401E8B9")]
			[FieldOffset(Offset = "0x8")]
			public string selectedNodeId;
		}
	}
}
