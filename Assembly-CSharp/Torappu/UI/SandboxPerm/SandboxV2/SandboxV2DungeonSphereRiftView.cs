using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004219 RID: 16921
	[Token(Token = "0x2004219")]
	public class SandboxV2DungeonSphereRiftView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A1A1 RID: 106913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1A1")]
		[Address(RVA = "0x1302E70", Offset = "0x1301A70", VA = "0x181302E70")]
		public void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A1A2 RID: 106914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1A2")]
		[Address(RVA = "0x1302DD0", Offset = "0x13019D0", VA = "0x181302DD0")]
		public void OnBtnDirectLeaveClicked()
		{
		}

		// Token: 0x0601A1A3 RID: 106915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1A3")]
		[Address(RVA = "0x1303120", Offset = "0x1301D20", VA = "0x181303120")]
		public SandboxV2DungeonSphereRiftView()
		{
		}

		// Token: 0x04020EC0 RID: 134848
		[Token(Token = "0x4020EC0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtMainTitle;

		// Token: 0x04020EC1 RID: 134849
		[Token(Token = "0x4020EC1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtSubTitle;

		// Token: 0x04020EC2 RID: 134850
		[Token(Token = "0x4020EC2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtRemainDay;

		// Token: 0x04020EC3 RID: 134851
		[Token(Token = "0x4020EC3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objDirectLeaveBtnFinish;

		// Token: 0x04020EC4 RID: 134852
		[Token(Token = "0x4020EC4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objDirectLeaveBtnUnFinish;

		// Token: 0x04020EC5 RID: 134853
		[Token(Token = "0x4020EC5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objMainMissionFinish;

		// Token: 0x04020EC6 RID: 134854
		[Token(Token = "0x4020EC6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtMainMissionFinish;

		// Token: 0x04020EC7 RID: 134855
		[Token(Token = "0x4020EC7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objMainMissionFail;

		// Token: 0x04020EC8 RID: 134856
		[Token(Token = "0x4020EC8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtMainMissionFail;

		// Token: 0x04020EC9 RID: 134857
		[Token(Token = "0x4020EC9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objMainMissionUnFinish;

		// Token: 0x04020ECA RID: 134858
		[Token(Token = "0x4020ECA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtMainMissionUnFinish;

		// Token: 0x04020ECB RID: 134859
		[Token(Token = "0x4020ECB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _seasonName;

		// Token: 0x04020ECC RID: 134860
		[Token(Token = "0x4020ECC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _seasonDesc;

		// Token: 0x04020ECD RID: 134861
		[Token(Token = "0x4020ECD")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020ECE RID: 134862
		[Token(Token = "0x4020ECE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020ECF RID: 134863
		[Token(Token = "0x4020ECF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnDirectLeaveClicked;

		// Token: 0x04020ED0 RID: 134864
		[Token(Token = "0x4020ED0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
