using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E77 RID: 15991
	[Token(Token = "0x2003E77")]
	public class SpecialOperatorBoardLvlupTalentDetailView : SpecialOperatorBoardLvlupDetailView<SpecialOperatorBoardTalentNode>
	{
		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x06018DA5 RID: 101797 RVA: 0x0009C330 File Offset: 0x0009A530
		[Token(Token = "0x17003B52")]
		public override SpecialOperatorDetailNodeType nodeType
		{
			[Token(Token = "0x6018DA5")]
			[Address(RVA = "0x118E730", Offset = "0x118D330", VA = "0x18118E730", Slot = "4")]
			get
			{
				return SpecialOperatorDetailNodeType.NONE;
			}
		}

		// Token: 0x06018DA6 RID: 101798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DA6")]
		[Address(RVA = "0x118E640", Offset = "0x118D240", VA = "0x18118E640", Slot = "5")]
		public override void SetViewShow(bool isShow)
		{
		}

		// Token: 0x06018DA7 RID: 101799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DA7")]
		[Address(RVA = "0x118E450", Offset = "0x118D050", VA = "0x18118E450", Slot = "7")]
		public override void Render(SpecialOperatorBoardTalentNode viewModel, bool fastMode)
		{
		}

		// Token: 0x06018DA8 RID: 101800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DA8")]
		[Address(RVA = "0x118E6C0", Offset = "0x118D2C0", VA = "0x18118E6C0")]
		public SpecialOperatorBoardLvlupTalentDetailView()
		{
		}

		// Token: 0x0401E97A RID: 125306
		[Token(Token = "0x401E97A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0401E97B RID: 125307
		[Token(Token = "0x401E97B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _talentNameText;

		// Token: 0x0401E97C RID: 125308
		[Token(Token = "0x401E97C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _talentDescriptionText;

		// Token: 0x0401E97D RID: 125309
		[Token(Token = "0x401E97D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelTask;

		// Token: 0x0401E97E RID: 125310
		[Token(Token = "0x401E97E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _taskText;

		// Token: 0x0401E97F RID: 125311
		[Token(Token = "0x401E97F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelClickLocked;

		// Token: 0x0401E980 RID: 125312
		[Token(Token = "0x401E980")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelClickUnlocked;

		// Token: 0x0401E981 RID: 125313
		[Token(Token = "0x401E981")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0401E982 RID: 125314
		[Token(Token = "0x401E982")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401E983 RID: 125315
		[Token(Token = "0x401E983")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetViewShow;

		// Token: 0x0401E984 RID: 125316
		[Token(Token = "0x401E984")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E985 RID: 125317
		[Token(Token = "0x401E985")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
