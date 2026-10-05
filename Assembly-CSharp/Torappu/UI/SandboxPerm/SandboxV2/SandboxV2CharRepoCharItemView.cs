using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004420 RID: 17440
	[Token(Token = "0x2004420")]
	public class SandboxV2CharRepoCharItemView : SandboxV2CharRepoAbstractItemView
	{
		// Token: 0x0601AA2A RID: 109098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA2A")]
		[Address(RVA = "0x13BFE30", Offset = "0x13BEA30", VA = "0x1813BFE30", Slot = "4")]
		public override void Render(int position, SandboxV2CharViewModel charModel, bool isCookClickable)
		{
		}

		// Token: 0x0601AA2B RID: 109099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA2B")]
		[Address(RVA = "0x13BFEE0", Offset = "0x13BEAE0", VA = "0x1813BFEE0")]
		private void _RenderCharSkillAndEquipInfo(SandboxV2CharViewModel charModel)
		{
		}

		// Token: 0x0601AA2C RID: 109100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA2C")]
		[Address(RVA = "0x13C0130", Offset = "0x13BED30", VA = "0x1813C0130")]
		public SandboxV2CharRepoCharItemView()
		{
		}

		// Token: 0x0601AA2D RID: 109101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA2D")]
		[Address(RVA = "0x121D540", Offset = "0x121C140", VA = "0x18121D540")]
		private void <>xLuaBaseProxy_Render(int P0, SandboxV2CharViewModel P1, bool P2)
		{
		}

		// Token: 0x04021F97 RID: 139159
		[Token(Token = "0x4021F97")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _emptySkillGo;

		// Token: 0x04021F98 RID: 139160
		[Token(Token = "0x4021F98")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _detailSkillGo;

		// Token: 0x04021F99 RID: 139161
		[Token(Token = "0x4021F99")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x04021F9A RID: 139162
		[Token(Token = "0x4021F9A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject _emptyEquipGo;

		// Token: 0x04021F9B RID: 139163
		[Token(Token = "0x4021F9B")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _detailEquipGo;

		// Token: 0x04021F9C RID: 139164
		[Token(Token = "0x4021F9C")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Image _imgEquipIcon;

		// Token: 0x04021F9D RID: 139165
		[Token(Token = "0x4021F9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021F9E RID: 139166
		[Token(Token = "0x4021F9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCharSkillAndEquipInfo;

		// Token: 0x04021F9F RID: 139167
		[Token(Token = "0x4021F9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
