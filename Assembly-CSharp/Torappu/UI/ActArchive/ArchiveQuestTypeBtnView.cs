using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C03 RID: 27651
	[Token(Token = "0x2006C03")]
	public class ArchiveQuestTypeBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060277BB RID: 161723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277BB")]
		[Address(RVA = "0x22AD200", Offset = "0x22ABE00", VA = "0x1822AD200")]
		public void Render(ArchiveQuestModel model)
		{
		}

		// Token: 0x060277BC RID: 161724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277BC")]
		[Address(RVA = "0x22AD530", Offset = "0x22AC130", VA = "0x1822AD530")]
		public ArchiveQuestTypeBtnView()
		{
		}

		// Token: 0x04037F59 RID: 229209
		[Token(Token = "0x4037F59")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objectNew;

		// Token: 0x04037F5A RID: 229210
		[Token(Token = "0x4037F5A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04037F5B RID: 229211
		[Token(Token = "0x4037F5B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _toggleIfLocked;

		// Token: 0x04037F5C RID: 229212
		[Token(Token = "0x4037F5C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animLoop;

		// Token: 0x04037F5D RID: 229213
		[Token(Token = "0x4037F5D")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2ArchiveQuestType _questType;

		// Token: 0x04037F5E RID: 229214
		[Token(Token = "0x4037F5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037F5F RID: 229215
		[Token(Token = "0x4037F5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
