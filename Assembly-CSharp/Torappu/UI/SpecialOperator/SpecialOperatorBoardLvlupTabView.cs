using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003EA6 RID: 16038
	[Token(Token = "0x2003EA6")]
	public abstract class SpecialOperatorBoardLvlupTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x06018E56 RID: 101974 RVA: 0x0009C588 File Offset: 0x0009A788
		[Token(Token = "0x17003B62")]
		public SpecialOperatorDetailNodeType nodeType
		{
			[Token(Token = "0x6018E56")]
			[Address(RVA = "0x118E3F0", Offset = "0x118CFF0", VA = "0x18118E3F0")]
			get
			{
				return SpecialOperatorDetailNodeType.NONE;
			}
		}

		// Token: 0x06018E57 RID: 101975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E57")]
		[Address(RVA = "0x118E200", Offset = "0x118CE00", VA = "0x18118E200", Slot = "4")]
		public virtual void Render(SpecialOperatorBoardLvlupModel model, SpecialOperatorBoardLvlupTabView.Param param)
		{
		}

		// Token: 0x06018E58 RID: 101976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E58")]
		[Address(RVA = "0x118E120", Offset = "0x118CD20", VA = "0x18118E120")]
		public void OnTabClicked()
		{
		}

		// Token: 0x06018E59 RID: 101977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E59")]
		[Address(RVA = "0x118E390", Offset = "0x118CF90", VA = "0x18118E390")]
		protected SpecialOperatorBoardLvlupTabView()
		{
		}

		// Token: 0x0401EB48 RID: 125768
		[Token(Token = "0x401EB48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _tabNameText;

		// Token: 0x0401EB49 RID: 125769
		[Token(Token = "0x401EB49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _topLineGo;

		// Token: 0x0401EB4A RID: 125770
		[Token(Token = "0x401EB4A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _nameCanvasGroup;

		// Token: 0x0401EB4B RID: 125771
		[Token(Token = "0x401EB4B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0401EB4C RID: 125772
		[Token(Token = "0x401EB4C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _selectedAlpha;

		// Token: 0x0401EB4D RID: 125773
		[Token(Token = "0x401EB4D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _unselectedAlpha;

		// Token: 0x0401EB4E RID: 125774
		[Token(Token = "0x401EB4E")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EB4F RID: 125775
		[Token(Token = "0x401EB4F")]
		[FieldOffset(Offset = "0x50")]
		private SpecialOperatorDetailNodeType m_cachedNodeType;

		// Token: 0x0401EB50 RID: 125776
		[Token(Token = "0x401EB50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401EB51 RID: 125777
		[Token(Token = "0x401EB51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EB52 RID: 125778
		[Token(Token = "0x401EB52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTabClicked;

		// Token: 0x0401EB53 RID: 125779
		[Token(Token = "0x401EB53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EA7 RID: 16039
		[Token(Token = "0x2003EA7")]
		public struct Param
		{
			// Token: 0x0401EB54 RID: 125780
			[Token(Token = "0x401EB54")]
			[FieldOffset(Offset = "0x0")]
			public int pos;

			// Token: 0x0401EB55 RID: 125781
			[Token(Token = "0x401EB55")]
			[FieldOffset(Offset = "0x4")]
			public bool isFirstRender;

			// Token: 0x0401EB56 RID: 125782
			[Token(Token = "0x401EB56")]
			[FieldOffset(Offset = "0x5")]
			public bool isSelected;

			// Token: 0x0401EB57 RID: 125783
			[Token(Token = "0x401EB57")]
			[FieldOffset(Offset = "0x8")]
			public float tweenDuration;
		}
	}
}
