using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A9 RID: 18601
	[Token(Token = "0x20048A9")]
	public class SoCharMissionCharInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C11D RID: 114973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C11D")]
		[Address(RVA = "0x1570FB0", Offset = "0x156FBB0", VA = "0x181570FB0")]
		private void _BindIfNot(CharacterIllustViewProperty property)
		{
		}

		// Token: 0x0601C11E RID: 114974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C11E")]
		[Address(RVA = "0x1570DB0", Offset = "0x156F9B0", VA = "0x181570DB0")]
		public void RenderCharDefaultInfo(MissionModel.SoCharWrappedGroup socharWrappedGroup)
		{
		}

		// Token: 0x0601C11F RID: 114975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C11F")]
		[Address(RVA = "0x1571050", Offset = "0x156FC50", VA = "0x181571050")]
		public SoCharMissionCharInfoView()
		{
		}

		// Token: 0x04024A93 RID: 150163
		[Token(Token = "0x4024A93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterInfoIllustController _illustController;

		// Token: 0x04024A94 RID: 150164
		[Token(Token = "0x4024A94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x04024A95 RID: 150165
		[Token(Token = "0x4024A95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _profImg;

		// Token: 0x04024A96 RID: 150166
		[Token(Token = "0x4024A96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _realName;

		// Token: 0x04024A97 RID: 150167
		[Token(Token = "0x4024A97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nickName;

		// Token: 0x04024A98 RID: 150168
		[Token(Token = "0x4024A98")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04024A99 RID: 150169
		[Token(Token = "0x4024A99")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_finder;

		// Token: 0x04024A9A RID: 150170
		[Token(Token = "0x4024A9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__BindIfNot;

		// Token: 0x04024A9B RID: 150171
		[Token(Token = "0x4024A9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderCharDefaultInfo;

		// Token: 0x04024A9C RID: 150172
		[Token(Token = "0x4024A9C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
