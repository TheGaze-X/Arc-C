using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200741B RID: 29723
	[Token(Token = "0x200741B")]
	public class Act3D0ClueShowPart : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F77 RID: 171895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F77")]
		[Address(RVA = "0x2586B50", Offset = "0x2585750", VA = "0x182586B50")]
		public void InitRender()
		{
		}

		// Token: 0x06029F78 RID: 171896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F78")]
		[Address(RVA = "0x25869D0", Offset = "0x25855D0", VA = "0x1825869D0")]
		public void AddNewClue(string clueId)
		{
		}

		// Token: 0x06029F79 RID: 171897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F79")]
		[Address(RVA = "0x2586C30", Offset = "0x2585830", VA = "0x182586C30")]
		public void OpenClue()
		{
		}

		// Token: 0x06029F7A RID: 171898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F7A")]
		[Address(RVA = "0x2586DB0", Offset = "0x25859B0", VA = "0x182586DB0")]
		private void _RenderClue()
		{
		}

		// Token: 0x06029F7B RID: 171899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F7B")]
		[Address(RVA = "0x2586EB0", Offset = "0x2585AB0", VA = "0x182586EB0")]
		public Act3D0ClueShowPart()
		{
		}

		// Token: 0x0403C28F RID: 246415
		[Token(Token = "0x403C28F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0403C290 RID: 246416
		[Token(Token = "0x403C290")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _haveRemainCount;

		// Token: 0x0403C291 RID: 246417
		[Token(Token = "0x403C291")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _haveAnimator;

		// Token: 0x0403C292 RID: 246418
		[Token(Token = "0x403C292")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _currentText;

		// Token: 0x0403C293 RID: 246419
		[Token(Token = "0x403C293")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _clueBackImg;

		// Token: 0x0403C294 RID: 246420
		[Token(Token = "0x403C294")]
		[FieldOffset(Offset = "0x40")]
		private int m_remainCount;

		// Token: 0x0403C295 RID: 246421
		[Token(Token = "0x403C295")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitRender;

		// Token: 0x0403C296 RID: 246422
		[Token(Token = "0x403C296")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddNewClue;

		// Token: 0x0403C297 RID: 246423
		[Token(Token = "0x403C297")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenClue;

		// Token: 0x0403C298 RID: 246424
		[Token(Token = "0x403C298")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderClue;

		// Token: 0x0403C299 RID: 246425
		[Token(Token = "0x403C299")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
